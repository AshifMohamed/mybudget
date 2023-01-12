using MyBudget.Core;
using MyBudget.Models;
using MyBudget.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static MyBudget.Models.Transactions.BasicTransaction;
using static MyBudget.Models.Transactions.RecurTransaction;

namespace MyBudget.Data
{
    public class TransactionData
    {
        static IList<BasicTransaction> data;
        static bool isInitialized = false;
        public static BasicTransaction Get(int id)
        {
            return Get().First(c => c.Id == id);
        }
        public static IList<BasicTransaction> Get()
        {
            InitializeData();
            return data;
        }
        public static void Insert(IList<BasicTransaction> transactions)
        {
            foreach (BasicTransaction transaction in transactions)
            {
                Add(transaction);
            }
        }

        public static BasicTransaction Update(BasicTransaction transaction)
        {
            int index = ((List<BasicTransaction>)Get()).FindIndex(c => c.Id == transaction.Id);

            if (index != -1)
            {
                Get()[index] = transaction;
            }
            return transaction;
        }

        public static bool Delete(int id)
        {
            int index = ((List<BasicTransaction>)Get()).FindIndex(c => c.Id == id);

            if (index != -1)
            {
                Get().RemoveAt(index);
                return true;
            }
            return false;
        }

        public static BasicTransaction Add(BasicTransaction transaction)
        {
            int newId = Get().Last().Id + 1;
            transaction.Id = newId;
            data.Add(transaction);

            return transaction;
        }
        public static void InitializeData()
        {
            if (!isInitialized)
            {
                data = CreateData.CreateTransactionData();

                isInitialized = true;
            }
        }

        private static string GetWeek(DateTime date)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date,
                CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday).ToString();
        }

        private static string GroupByDate(string group, DateTime date)
        {
            switch (group)
            {
                case "WEEK": return GetWeek(date);
                case "MONTH": return date.ToString("MMMM");
                default: return date.Date.ToString(ThemeConstant.DATE_FORMAT);
            }
        }

        public static IList<TranscationChartData> GetTransactionChartData(DateTime start, DateTime end, string group)
        {
            List<TranscationChartData> chartData = Get()
            .Where(w =>
                (!(w is RecurTransaction)) &&
                (w.Date >= start && w.Date <= end)
            )
            .AsEnumerable()
            .GroupBy(t => new
            {
                year = t.Date.Year,
                //month = t.Date.Month,
                grp = GroupByDate(group, t.Date)
                // grp = GetWeek(t.Date) // t.Date.ToString("MMMM")
            })
            .Select(chart => new TranscationChartData()
            {
                DateGroup = chart.Key.grp,
                TotalIncome = chart.Sum(c => c.Type == BasicTransaction.TRANSACTION_TYPE.INCOME ? c.Amount : 0),
                TotalExpense = chart.Sum(c => c.Type == BasicTransaction.TRANSACTION_TYPE.EXPENSE ? c.Amount : 0)
            })
              .ToList();

            return chartData;
        }

        public static IList<CategoryMonthTotalData> GetCategoryChartData(DateTime start, DateTime end, int month)
        {
            List<CategoryMonthTotalData> chartData = Get()
            .Where(w =>
                (!(w is RecurTransaction)) &&
                (w.Date.Month == month) &&
                (w.Date.Year == DateTime.Now.Year) &&
                (w.Type == TRANSACTION_TYPE.EXPENSE)
            )
            .GroupBy(t => new
            {
                category = t.Category.Name
                // grp = GetWeek(t.Date) // t.Date.ToString("MMMM")
            })
            .Select(chart => new CategoryMonthTotalData()
            {
                Category = chart.Key.category,
                Total = chart.Sum(c=>c.Amount),
            })
              .ToList();

            return chartData;
        }

        public static IList<CategoryMonthTotalData> GetTotalForCategory(int month)
        {
            List<CategoryMonthTotalData> chartData = Get()
            .Where(w =>
                (!(w is RecurTransaction)) &&
                (w.Date.Month == month) &&
                (w.Date.Year == DateTime.Now.Year) &&
                (w.Type == TRANSACTION_TYPE.EXPENSE)
            )
            .GroupBy(t => new
            {
                category = t.Category.Name
            })
            .Select(chart => new CategoryMonthTotalData()
            {
                Category = chart.Key.category,
                Total = chart.Sum(c => c.Amount),
            })
              .ToList();

            return chartData;
        }
        public static IList<BasicTransaction> GetTransactions(DateTime start, DateTime end)
        {

            List<BasicTransaction> filteredData = Get()
            .Where(t =>
                (t.Date >= start && t.Date <= end)
            )
            .OrderByDescending(o => o.Date)
            .ToList();

            return filteredData;
        }
        public static IList<BasicTransaction> GetFilteredData(DateTime start, DateTime end, TRANSACTION_TYPE type, bool isRecurring, bool isCredit)
        {

            List<BasicTransaction> filteredData = Get()
            .Where(t =>
                ((t is RecurTransaction) == isRecurring) &&
                (t.Type == type) &&

                (t is RecurTransaction r ? r.ExpectedEndDate >= end :
                (t.Date >= start && t.Date <= end)) 

                //(t.Date >= start && t.Date <= end)
            )
            .OrderByDescending(t => t.Date)
            .ToList();

            return filteredData;
        }

        public static double GetActualBalance(DateTime currentDate, TRANSACTION_TYPE type)
        {
            List<TranscationMonthTotalData> totalData = Get()
            .Where(w =>
                (!(w is RecurTransaction))
            )
            .OrderByDescending(o => o.Date)
            .GroupBy(t => new
            {
                year = t.Date.Year,
                month = t.Date.Month,
            })
            .Select(t => new TranscationMonthTotalData()
            {
                Month = t.Key.month,
                Total = t.Sum(c => c.Type == type ? c.Amount : 0),
            })
            .ToList();

            double totalCurrent = totalData.Count > 0 ? 
                totalData.First().Total : 0;

            double recur = GetRecurringTransactionsForAMonth(currentDate, type);
            return totalCurrent + recur;
        }
        public static double GetForecastBalance(DateTime currentDate, TRANSACTION_TYPE type)
        {
            DateTime firstDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime start = firstDate.AddMonths(-3).Date;
            DateTime end = firstDate.AddDays(-1).Date;
            double forecast;

            int compare = DateTime.Now.CompareTo(start);
            List<TranscationMonthTotalData> totalData = Get()
            .Where(w =>
                (!(w is RecurTransaction)) &&
                (w.Date.CompareTo(start) >= 0) &&
                (w.Date.CompareTo(end) <= 0)
            )
            .OrderByDescending(o => o.Date)
            .GroupBy(t => new
            {
                year = t.Date.Year,
                month = t.Date.Month,
            })
            .Select(t => new TranscationMonthTotalData()
            {
                Month = t.Key.month,
                Total = t.Sum(c => c.Type == type ? c.Amount : 0),
            })
            .ToList();

            if (totalData.Count() > 0)
            {
                //double avgOfLastThreeMonths = totalData.Average(t => t.Total);
                double rateOfChange = GetRateOfChange(totalData);

                double totalCurrent = totalData.First().Total;
                forecast = (totalData.First().Total * (rateOfChange + 100)) / 100.0;


                //double forecast = (totalData.First().Total - avgOfLastThreeMonths) / rateOfChange;
            }
            else
            {
                forecast = 0;
            }

            double recur = GetRecurringTransactionsForAMonth(currentDate, type);
            return forecast + recur;
        }

        public static double GetRecurringTransactionsForAMonth(DateTime date, TRANSACTION_TYPE type)
        {

            List<TranscationMonthTotalData> totalData =  Get()
            .Where(w =>
                (w is RecurTransaction transaction) &&
                (transaction.ExpectedEndDate >= date) &&
                (w.Type == type)
            )
            .Select(t => new TranscationMonthTotalData()
            {
                Total = ((RecurTransaction)t).Cycle == RecurTransaction.TransactionCycle.Weekly ?
                t.Amount * 4 : t.Amount
            })
            .ToList();

            return totalData.Sum(t => t.Total);
        }

        private static double GetRateOfChange(List<TranscationMonthTotalData> data)
        {
            double avgOfLastThreeMonths = data.Average(t => t.Total);

            if (data.Count > 1)
            {
                //double originalTotal = data.Last().Total;
                double newTotal = data.First().Total;

                //return (originalTotal - newTotal) / originalTotal;
                return (newTotal - avgOfLastThreeMonths) / avgOfLastThreeMonths * 100;
            }

            return 0;
        }

        public class TranscationChartData
        {
            public string DateGroup { get; set; }
            public double TotalIncome { get; set; }
            public double TotalExpense { get; set; }
        }

        public class TranscationMonthTotalData
        {
            public int Month { get; set; }
            public double Total { get; set; }
        }

        public class CategoryMonthTotalData
        {
            public string Category { get; set; }
            public double Total { get; set; }
        }
    }
}

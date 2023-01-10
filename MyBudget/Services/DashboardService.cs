using MyBudget.Data;
using MyBudget.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBudget.Data.TransactionData;
using static MyBudget.Models.Transactions.BasicTransaction;

namespace MyBudget.Services
{
    public class DashboardService
    {
        public IList<BasicTransaction> GetFilteredTransactions(DateTime start, DateTime end,
            TRANSACTION_TYPE type, bool isRecurring, bool isCredit)
        {
            return TransactionData.GetFilteredData(start, end, type, isRecurring, isCredit);
        }

        public IList<TranscationChartData> GetChartData(DateTime start, 
            DateTime end, string group)
        {
            return TransactionData.GetTransactionChartData(start, end, group);
        }

        public double GetForecastBalance(DateTime currentDate, TRANSACTION_TYPE type)
        {
            return TransactionData.GetForecastBalance(currentDate, type);
        }
        public double GetActualBalance(DateTime currentDate, TRANSACTION_TYPE type)
        {
            return TransactionData.GetActualBalance(currentDate, type);
        }

    }
}

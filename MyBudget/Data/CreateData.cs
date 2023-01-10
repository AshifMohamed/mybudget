using MyBudget.Models;
using MyBudget.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBudget.Models.Transactions.BasicTransaction;
using static MyBudget.Models.Transactions.RecurTransaction;

namespace MyBudget.Data
{
    public class CreateData
    {
        public static IList<BasicTransaction> CreateTransactionData()
        {
            IList<Category> categories = CategoryData.Get();

            IList<BasicTransaction> basicTransactions = CreateBasicTransactions(categories);
            IList<BasicTransaction> recurTransactions = CreateRecurTransactions(categories);
            IList<BasicTransaction> creditTransactions = CreateCreditTransactions(categories);

            List<BasicTransaction> data = new List<BasicTransaction>();
            data.AddRange(basicTransactions);
            data.AddRange(recurTransactions);
            data.AddRange(creditTransactions);

            return data;
        }

        private static IList<BasicTransaction> CreateBasicTransactions(IList<Category> categories)
        {
             IList<BasicTransaction> data = new List<BasicTransaction>
                {
                    //Dec
                    Expense(1, 2500, DateTime.Parse("12/3/2021"), categories.ElementAt(0)),
                    Expense(2, 3400, DateTime.Parse("12/6/2021"), categories.ElementAt(1)),
                    Expense(3, 700, DateTime.Parse("12/8/2021"), categories.ElementAt(2)),
                    Expense(4, 500, DateTime.Parse("12/8/2021"), categories.ElementAt(1)),
                    Expense(5, 16000, DateTime.Parse("12/10/2021"), categories.ElementAt(4)),
                    Expense(6, 1000, DateTime.Parse("12/12/2021"), categories.ElementAt(4)),
                    Expense(8, 5000, DateTime.Parse("12/18/2021"), categories.ElementAt(5)),
                    Income(9, 1200, DateTime.Parse("12/20/2021"), categories.ElementAt(9)),
                    Expense(11, 12500, DateTime.Parse("12/25/2021"), categories.ElementAt(3)),

                    //Jan
                    Expense(13, 1200, DateTime.Parse("01/01/2022"), categories.ElementAt(2)),
                    Expense(15, 4000, DateTime.Parse("01/10/2022"), categories.ElementAt(0)),
                    Expense(16, 400, DateTime.Parse("01/12/2022"), categories.ElementAt(1)),
                    Expense(17, 15000, DateTime.Parse("01/15/2022"), categories.ElementAt(4)),
                    Expense(18, 1000, DateTime.Parse("01/17/2022"), categories.ElementAt(2)),
                    Expense(19, 5000, DateTime.Parse("01/17/2022"), categories.ElementAt(10)),
                    Expense(20, 4000, DateTime.Parse("01/20/2022"), categories.ElementAt(5)),
                    Income(21, 1400, DateTime.Parse("01/20/2022"), categories.ElementAt(9)),
                    Expense(22, 11750, DateTime.Parse("01/25/2022"), categories.ElementAt(3)),

                    //Feb
                    Expense(23, 2000, DateTime.Parse("02/02/2022"), categories.ElementAt(0)),
                    Expense(24, 1500, DateTime.Parse("02/05/2022"), categories.ElementAt(4)),
                    Expense(25, 700, DateTime.Parse("02/05/2022"), categories.ElementAt(0)),
                    Expense(26, 500, DateTime.Parse("02/04/2022"), categories.ElementAt(2)),
                    Expense(27, 15000, DateTime.Parse("02/10/2022"), categories.ElementAt(4)),
                    Expense(28, 1000, DateTime.Parse("02/12/2022"), categories.ElementAt(1)),
                    Expense(29, 7500, DateTime.Parse("02/20/2022"), categories.ElementAt(5)),
                    Expense(30, 5500, DateTime.Parse("02/17/2022"), categories.ElementAt(10)),
                    Income(31, 1500, DateTime.Parse("02/20/2022"), categories.ElementAt(9)),
                    Expense(32, 10500, DateTime.Parse("02/25/2022"), categories.ElementAt(3)),

                    //March
                    Expense(33, 3000, DateTime.Parse("03/02/2022"), categories.ElementAt(0)),
                    Income(34, 3500, DateTime.Parse("03/03/2022"), categories.ElementAt(1)),
                    Expense(35, 1000, DateTime.Parse("03/04/2022"), categories.ElementAt(2)),
                    Expense(36, 500, DateTime.Parse("03/05/2022"), categories.ElementAt(1)),
                    Expense(37, 15000, DateTime.Parse("03/08/2022"), categories.ElementAt(4)),
                    Expense(38, 1500, DateTime.Parse("03/10/2022"), categories.ElementAt(4)),
                    Expense(39, 4000, DateTime.Parse("03/14/2022"), categories.ElementAt(5)),
                    Income(40, 1750, DateTime.Parse("03/20/2022"), categories.ElementAt(9)),
                    Expense(41, 10200, DateTime.Parse("03/25/2022"), categories.ElementAt(3)),

                };

            return data;
        }
        private static IList<BasicTransaction> CreateRecurTransactions(IList<Category> categories)
        {
            RecurTransaction tr1 = new RecurTransaction(7, 50000, DateTime.Parse("12/15/2021"), 
                TRANSACTION_TYPE.EXPENSE, categories.ElementAt(7), TransactionCycle.Monthly,
                DateTime.Parse("12/15/2023"));

            RecurTransaction tr2 = new RecurTransaction(10, 100000, DateTime.Parse("12/25/2021"),
                TRANSACTION_TYPE.INCOME, categories.ElementAt(6), TransactionCycle.Monthly,
                DateTime.Parse("12/25/2022"));

            return new List<BasicTransaction>() { tr1, tr2 };
        }

        private static IList<BasicTransaction> CreateCreditTransactions(IList<Category> categories)
        {
            IList<Contact> contacts = ContactData.Get();

            CreditTransaction cr1 = new CreditTransaction(12, 7500, DateTime.Parse("12/31/2021"), 
                TRANSACTION_TYPE.EXPENSE, categories.ElementAt(8), contacts.ElementAt(0),
                DateTime.Parse("01/05/2022"));

            CreditTransaction cr2 = new CreditTransaction(14, 3600, DateTime.Parse("1/4/2022"),
                TRANSACTION_TYPE.INCOME, categories.ElementAt(1), contacts.ElementAt(1),
                DateTime.Parse("1/15/2022"));

            return new List<BasicTransaction>() { cr1, cr2 };
        }
    }
}

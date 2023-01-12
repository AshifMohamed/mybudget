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
    public class TransactionService
    {
        public void InitializeData()
        {
            TransactionData.InitializeData();
        }
        public BasicTransaction GetTransaction(int id)
        {
            return TransactionData.Get(id);
        }
        public IList<BasicTransaction> GetAllTransactions()
        {
            return TransactionData.Get();
        }
        public IList<BasicTransaction> GetAllTransactions(DateTime start, DateTime end)
        {
            return TransactionData.GetTransactions(start, end);
        }

        public void AddTransactions(IList<BasicTransaction> transactions)
        {
            TransactionData.Insert(transactions);
        }
        public BasicTransaction UpdateTransaction(BasicTransaction transaction)
        {
            return TransactionData.Update(transaction);
        }

        public bool RemoveTransaction(int id)
        {
            return TransactionData.Delete(id);
        }

        public IList<BasicTransaction> GetFilteredTransactions(DateTime start, DateTime end,
            TRANSACTION_TYPE type, bool isRecurring, bool isCredit)
        {
            return TransactionData.GetFilteredData(start, end, type, isRecurring, isCredit);
        }

        public IList<CategoryMonthTotalData> GetTotalForCategory(int month)
        {
            return TransactionData.GetTotalForCategory(month);
        }
    }
}

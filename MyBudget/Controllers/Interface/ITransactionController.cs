using MyBudget.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBudget.Models.Transactions.BasicTransaction;

namespace MyBudget.Controllers.Interface
{
    public interface ITransactionController
    {
        void InitializeData();
        void LoadTransactions();

        IList<BasicTransaction> GetTransactions();
        void GetTransactions(DateTime start, DateTime end);
        BasicTransaction GetTransaction(int id);

        void AddTransactions(IList<BasicTransaction> transactions);
        void UpdateTransaction(BasicTransaction transaction);
        bool RemoveTransaction(int id);
        void GetFilteredTransactions(DateTime start, DateTime end,
            TRANSACTION_TYPE type, bool isRecurring, bool isCredit);
    }
}

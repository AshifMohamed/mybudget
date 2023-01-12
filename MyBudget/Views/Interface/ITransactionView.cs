using MyBudget.Controllers.Interface;
using MyBudget.Models;
using MyBudget.Models.Transactions;
using MyBudget.Views.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Views.Interface
{
    public interface ITransactionView
    {
        void SetController(ITransactionController controller);
        void AddTransactions(IList<BasicTransaction> transactions);
        void UpdateTransaction(BasicTransaction transaction);
        void LoadTransactions(IList<TransactionViewData> transactionList);
        IList<Category> Categories { get; }  
    }
}

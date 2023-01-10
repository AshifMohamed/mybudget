using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Models.Transactions
{
    public class RecurTransaction : BasicTransaction
    {
        public RecurTransaction(int id, double amount, DateTime date, TRANSACTION_TYPE type, Category category, TransactionCycle cycle, DateTime expectedEndDate) : base(id, amount, date, type, category)
        {
            Cycle = cycle;
            ExpectedEndDate = expectedEndDate;
        }

        public enum TransactionCycle
        {
            Weekly = 1,
            Monthly = 2,
        }
        public TransactionCycle Cycle { get; set; }
        public DateTime ExpectedEndDate { get; set; }
    }
}

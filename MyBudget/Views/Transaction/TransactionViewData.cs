using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Views.Transaction
{
    public class TransactionViewData
    {
        public enum TYPE
        {
            INCOME,
            EXPENSE,
            RECEIVABLE,
            PAYABALE,
            RECURRING_INCOME,
            RECURRING_EXPENSE
        }
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Date { get; set; }
        public int Type { get; set; }
        public string Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Models.Transactions
{
    public class CreditTransaction : BasicTransaction
    {

        public CreditTransaction(int id, double amount, DateTime date, TRANSACTION_TYPE type, Category category, Contact contact, DateTime expectedDate) : base(id, amount, date, type, category)
        {
            Contact = contact;
            ExpectedDate = expectedDate;
        }

        public CreditTransaction()
        {

        }

        public Contact Contact { get; set; }
        public DateTime ExpectedDate { get; set; }

    }
}

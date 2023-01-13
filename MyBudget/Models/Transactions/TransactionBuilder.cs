using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBudget.Models.Transactions.BasicTransaction;
using static MyBudget.Models.Transactions.RecurTransaction;

namespace MyBudget.Models.Transactions
{
    public class TransactionBuilder
    {
        private int Id;
        private double Amount;
        private DateTime Date;
        private TRANSACTION_TYPE Type;
        private Category Category;
        private TransactionCycle Cycle;
        private DateTime ExpectedEndDate;

        public TransactionBuilder WithId(int id)
        {
            this.Id = id;
            return this;
        }
        public TransactionBuilder WithAmount(double amount)
        {
            this.Amount = amount;
            return this;
        }
        public TransactionBuilder WithDate(DateTime date)
        {
            this.Date = date;
            return this;
        }
        public TransactionBuilder WithType(TRANSACTION_TYPE type)
        {
            this.Type = type;
            return this;
        }

        public TransactionBuilder WithCategory(Category category)
        {
            this.Category = category;
            return this;
        }

        public TransactionBuilder WithCycle(TransactionCycle cycle)
        {
            this.Cycle = cycle;
            return this;
        }

        public TransactionBuilder WithEndDate(DateTime date)
        {
            this.ExpectedEndDate = date;
            return this;
        }

        public RecurTransaction BuildRecur()
        {
            RecurTransaction Transaction = new RecurTransaction();
            Transaction.Id = Id;
            Transaction.Amount = Amount;
            Transaction.Date = Date;
            Transaction.Type = Type;
            Transaction.Category = Category;
            Transaction.Cycle = Cycle;
            Transaction.ExpectedEndDate = ExpectedEndDate;

            return Transaction;
        }
        public BasicTransaction BuildBasic()
        {
            BasicTransaction Transaction = new BasicTransaction();
            Transaction.Id = Id;
            Transaction.Amount = Amount;
            Transaction.Date = Date;
            Transaction.Type = Type;
            Transaction.Category = Category;

            return Transaction;
        }
    }
}

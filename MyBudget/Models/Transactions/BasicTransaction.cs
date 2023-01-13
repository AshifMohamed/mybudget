using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Models.Transactions
{
    public class BasicTransaction
    {
        public enum TRANSACTION_TYPE
        {
            INCOME = 1,
            EXPENSE = 2
        }
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public TRANSACTION_TYPE Type { get; set; }
        public Category Category { get; set; }

        public BasicTransaction(int id, double amount, DateTime date, TRANSACTION_TYPE type, Category category)
        {
            Id = id;
            Amount = amount;
            Date = date;
            Type = type;
            Category = category;
        }
        public BasicTransaction()
        {

        }

        public static BasicTransaction Expense(int id, double amount, DateTime date, Category category)
        {
            return new BasicTransaction(id, amount, date, TRANSACTION_TYPE.EXPENSE, category);
        }
        public static BasicTransaction Income(int id, double amount, DateTime date, Category category)
        {
            return new BasicTransaction(id, amount, date, TRANSACTION_TYPE.INCOME, category);
        } 
    }
}

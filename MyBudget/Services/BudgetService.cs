using MyBudget.Data;
using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Services
{
    public class BudgetService
    {
        public void InitializeData()
        {
            BudgetData.InitializeData();
        }
        public IList<Budget> GetAllBudgets()
        {
            return BudgetData.Get();
        }

        public bool AddBudget(Budget budget)
        {
            return BudgetData.Insert(budget);
        }

        public bool UpdateBudget(Budget budget)
        {
            return BudgetData.Update(budget);
        }
    }
}

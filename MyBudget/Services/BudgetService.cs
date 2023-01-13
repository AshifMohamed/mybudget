using MyBudget.Controllers;
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
        private static BudgetService _budgetService;
        private static readonly object _lock = new object();

        private BudgetService() { }
        public static BudgetService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_budgetService == null)
                    {
                        _budgetService = new BudgetService();
                    }
                    return _budgetService;
                }
            }
        }

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

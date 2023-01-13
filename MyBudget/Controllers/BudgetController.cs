using MyBudget.Controllers.Interface;
using MyBudget.Models;
using MyBudget.Services;
using MyBudget.Views;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBudget.Data.TransactionData;

namespace MyBudget.Controllers
{
    public class BudgetController : IBudgetController
    {
        private static BudgetController _budgetController;
        private static readonly object _lock = new object();
        IBudgetView _budgetView;
        BudgetService _budgetService = BudgetService.Instance;
        TransactionService _transactionService = TransactionService.Instance;

        public static BudgetController Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_budgetController == null)
                    {
                        _budgetController = new BudgetController();
                    }
                    return _budgetController;
                }
            }
        }


        private BudgetController()
        {

        }

        public void SetBudgetView(IBudgetView budgetView)
        {
            _budgetView = budgetView;
        }

        public void AddBudget(Category category, double allocation)
        {
            Budget budget = new Budget("", allocation, category);

            bool isAdded = _budgetService.AddBudget(budget);

            if (isAdded)
            {
                _budgetView.ShowMessage("Budget created successfully.");
                LoadBudgets();
            }
            else
            {
                _budgetView.ShowMessage("There is already a Category with same name.");
            }
        }

        public IList<Budget> GetBudgets()
        {
           return _budgetService.GetAllBudgets();
        }

        public void InitializeData()
        {
            _budgetService.InitializeData();
        }

        public void LoadBudgets()
        {
            var categoryTotal = _transactionService.GetTotalForCategory(DateTime.Now.Month);
            var budgetList = MapViewData(GetBudgets(), categoryTotal);

            _budgetView.LoadBudgets(budgetList);
        }

        public void UpdateBudget(Budget budget)
        {
            bool isUpdated = _budgetService.UpdateBudget(budget);
            if (isUpdated)
            {
                _budgetView.ShowMessage("Budget amount Updated successfully.");
                LoadBudgets();
            }
            else
            {
                _budgetView.ShowMessage("There was an error while updating the budget.");
            }
        }

        private IList<BudgetViewData> MapViewData(IList<Budget> data, IList<CategoryMonthTotalData> categoryTotal)
        {
            return data.Select(x => new BudgetViewData()
            {
                Allocation = x.Allocation,
                Actual = categoryTotal.Where(c => c.Category.Equals(x.Category.Name)).Select(s => s.Total).FirstOrDefault(),
                Category = x.Category.Name
            }).ToList();
        }
    }
}

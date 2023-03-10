using MyBudget.Models;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers.Interface
{
    public interface IBudgetController
    {
        void SetBudgetView(IBudgetView budgetView);
        void InitializeData();
        void LoadBudgets();
        IList<Budget> GetBudgets();
        void AddBudget(Category category, double allocation);
        void UpdateBudget(Budget category);
    }
}

using MyBudget.Controllers.Interface;
using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Views.Interface
{
    public interface IBudgetView
    {
        void SetController(IBudgetController controller);
        void LoadBudgets(IList<BudgetViewData> categories);
        void UpdateBudget(Budget category);
        void ShowMessage(string message);
        //string Category { get; set; }
    }
}

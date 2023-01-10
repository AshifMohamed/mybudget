using MyBudget.Controllers.Interface;
using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Views.Interface
{
    public interface ICategoryView
    {
        void SetController(ICategoryController controller);
        void LoadCategories(IList<Category> categories);
        void UpdateCategory(Category category);
        void ShowMessage(string message);
        string Category { get; set; }
    }
}

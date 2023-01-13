using MyBudget.Models;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers.Interface
{
    public interface ICategoryController
    {
        void setCategoryView(ICategoryView categoryView);
        void InitializeData();
        void LoadCategories();

        IList<Category> GetCategories();

        void AddCategory(string name);
        void UpdateCategory(Category category);
    }
}

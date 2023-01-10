using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers.Interface
{
    public interface ICategoryController
    {
        void InitializeData();
        void LoadCategories();

        IList<Category> GetCategories();

        void AddCategory(string name);
        void UpdateCategory(Category category);
    }
}

using MyBudget.Data;
using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Services
{
    public class CategoryService
    {
        public void InitializeData()
        {
            CategoryData.InitializeData();
        }
        public IList<Category> GetAllCategories()
        {
            return CategoryData.Get();
        }

        public bool AddCategory(string name)
        {
            return CategoryData.Insert(new Category(name));
        }

        public bool UpdateCategory(Category category)
        {
            return CategoryData.Update(category);
        }
    }
}

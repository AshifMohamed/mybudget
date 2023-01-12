using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Data
{
    public class CategoryData
    {
        static IList<Category> data;
        static bool isInitialized = false;
        public static IList<Category> Get()
        {
            InitializeData();
            return data;
        }
        public static bool Insert(Category category)
        {
            bool isExist = Get().Any(c => c.Name.Equals(category.Name));

            if (!isExist)
            {
                int newId = Get().Last().Id + 1;
                category.Id = newId;

                data.Add(category);

                return true;
            }

            return false;
        }

        public static bool Update(Category category)
        {
            bool isExist = Get().Any(c => c.Name.Equals(category.Name));

            if (isExist)
            {
                Category updateCategory = Get().First(c => c.Id == category.Id);

                if (updateCategory != null)
                {
                    updateCategory.Name = category.Name;
                    return true;
                }
            }
            
            return false;
        }
        public static void InitializeData()
        {
            if (!isInitialized)
            {
                data = new List<Category>
                {
                    new Category(1, "Household"),
                    new Category(2, "Miscellaneous"),
                    new Category(3, "Travel"),
                    new Category(4, "Utility"),
                    new Category(5, "Groceries"),
                    new Category(6, "Fuel"),
                    new Category(7, "Monthly Salary"),
                    new Category(8, "House Rent"),
                    new Category(9, "Eating out"),
                    new Category(10, "Deposit Interest"),
                    new Category(11, "Food"),
                };

                isInitialized = true;
            }
        }
    }
}

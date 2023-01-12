using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Data
{
    public class BudgetData
    {
        static IList<Budget> data;
        static bool isInitialized = false;
        public static IList<Budget> Get()
        {
            InitializeData();
            return data;
        }
        public static bool Insert(Budget budget)
        {
            bool isExist = Get().Any(b => b.Category.Id.Equals(budget.Category.Id));

            if (!isExist)
            {
                string newId = Guid.NewGuid().ToString();
                budget.Id = newId;

                data.Add(budget);

                return true;
            }

            return false;
        }

        public static bool Update(Budget budget)
        {
            Budget updateBudget = Get().FirstOrDefault(b => b.Category.Name.Equals(budget.Category.Name));

            if(updateBudget != null)
            {
                updateBudget.Allocation = budget.Allocation;
                return true;
            }

            return false;
        }

        public static bool Delete(Budget budget)
        {
            Budget updateBudget = Get().FirstOrDefault(b => b.Id.Equals(budget.Id));

            if (updateBudget != null)
            {
                Get().Remove(updateBudget);
                return true;
            }

            return false;
        }
        public static void InitializeData()
        {
            if (!isInitialized)
            {
                IList<Category> categories = CategoryData.Get();

                data = new List<Budget>
                {
                    new Budget("1", 15000,categories.ElementAt(10)),
                    new Budget("2", 10000,categories.ElementAt(2)),
                    new Budget("3", 20000,categories.ElementAt(4))

                    //new Budget(1, "Household"),
                    //new Category(2, "Miscellaneous"),
                    //new Category(3, "Travel"),
                    //new Category(4, "Utility"),
                    //new Category(5, "Groceries"),
                    //new Category(6, "Fuel"),
                    //new Category(7, "Monthly Salary"),
                    //new Category(8, "House Rent"),
                    //new Category(9, "Eating out"),
                    //new Category(10, "Deposit Interest"),
                    //new Category(11, "Food"),
                };

                isInitialized = true;
            }
        }
    }
}

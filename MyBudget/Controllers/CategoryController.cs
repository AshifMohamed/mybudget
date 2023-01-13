using MyBudget.Controllers.Interface;
using MyBudget.Models;
using MyBudget.Services;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers
{
    public class CategoryController : ICategoryController
    {
        private static CategoryController _categoryController;
        private static readonly object _lock = new object();
        ICategoryView _categoryView;
        CategoryService _categoryService = CategoryService.Instance;

        private CategoryController()
        {

        }
        public static CategoryController Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_categoryController == null)
                    {
                        _categoryController = new CategoryController();
                    }
                    return _categoryController;
                }
            }
        }

        public void setCategoryView(ICategoryView categoryView)
        {
            _categoryView = categoryView;
        }

        public void AddCategory(string name)
        {
            bool isAdded = _categoryService.AddCategory(name);

            if (isAdded)
            {
                _categoryView.ShowMessage("Category Added successfully.");
                LoadCategories();
            }
            else
            {
                _categoryView.ShowMessage("There is already a Category with same name.");
            }
        }

        public IList<Category> GetCategories()
        {
            return _categoryService.GetAllCategories();
        }

        public void InitializeData()
        {
            _categoryService.InitializeData();
        }

        public void LoadCategories()
        {
            _categoryView.LoadCategories(GetCategories());
        }

        public void UpdateCategory(Category category)
        {
            bool isUpdated = _categoryService.UpdateCategory(category);
            if (isUpdated)
            {
                _categoryView.ShowMessage("Category Updated successfully.");
                LoadCategories();
            }
            else
            {
                _categoryView.ShowMessage("There was an error while updating the category.");
            }
        }
    }
}
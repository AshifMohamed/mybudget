using MyBudget.Models;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget.Views
{
    public partial class UpdateCategory : Form
    {
        private ICategoryView _categoryView;
        private Category _category;
        public UpdateCategory()
        {
            InitializeComponent();
        }
        public UpdateCategory(ICategoryView categoryView, Category category)
        {
            InitializeComponent();
            _categoryView = categoryView;
            _category = category;

            txt_update_category.Text = _category.Name;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string newName = txt_update_category.Text;

            if (_category.Name.Equals(newName))
            {
                Close();
                return;
            }

            _category.Name = newName;
            _categoryView.UpdateCategory(_category);
            txt_update_category.Text = string.Empty;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using MyBudget.Controllers.Interface;
using MyBudget.Core;
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
    public partial class CategoryView : Form, ICategoryView
    {
        ICategoryController _controller;
        public CategoryView()
        {
            InitializeComponent();
        }


        private void CategoryView_Load(object sender, EventArgs e)
        {
            btn_addCategory.Enabled = false;
            InitializeGridColumns();
        }
        private void InitializeGridColumns()
        {
            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();

            DataGridViewImageColumn Edit = new DataGridViewImageColumn()
            {
                Image = ThemeConstant.GetResourceIcon(ThemeConstant.DEFAULT_EDIT_ICON),
                Name = "Edit",
                HeaderText = "",           
            };

            //grid_category.Columns.Add(Edit);

            grid_category.Columns.AddRange(new DataGridViewColumn[] {
            Id,
            Name,
            Edit});

            // 
            // Date
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Category
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.ReadOnly = true;

            grid_category.Columns["Id"].Width = 100;
            grid_category.Columns["Edit"].Width = 20;

        }
        private void pnl_control_Paint(object sender, PaintEventArgs e)
        {

        }

        public string Category
        {
            get { return txt_category.Text; }
            set { txt_category.Text = value; }
        }
        public void SetController(ICategoryController controller)
        {
            _controller = controller;
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {       
            _controller.AddCategory(Category.Trim());
            //_controller.LoadCategories();
            txt_category.Text = string.Empty;
        }

        private void txt_category_TextChanged(object sender, EventArgs e)
        {
            btn_addCategory.Enabled = !string.IsNullOrWhiteSpace(Category);
        }

        public void LoadCategories(IList<Category> categories)
        {
            grid_category.DataSource = null;

            grid_category.DataSource = categories;
        }

        private void grid_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == grid_category.Columns["Edit"].Index)
            {
                string name = grid_category.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                int id = int.Parse(grid_category.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                Category selectedCategory = new Category(id, name);
                UpdateCategory updateCategory = new UpdateCategory(this, selectedCategory); ;
                updateCategory.ShowDialog();
            }
        }

        public void UpdateCategory(Category category)
        {
            _controller.UpdateCategory(category);
            //_controller.LoadCategories();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}

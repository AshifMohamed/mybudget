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
    public partial class BudgetView : Form, IBudgetView
    {
        IBudgetController _controller;
        IList<Category> _categories;
        public string Allocation
        {
            get { return txt_allocation.Text; }
            set { txt_allocation.Text = value; }
        }
        public BudgetView()
        {
            InitializeComponent();
        }

        public BudgetView(IList<Category> categories)
        {
            _categories = categories;
            InitializeComponent();
            InitializeCategoryComboBox();
        }

        private void BudgetView_Load(object sender, EventArgs e)
        {
            btn_budget.Text = "Create Budget";
            InitializeGridColumns();
        }

        private void InitializeCategoryComboBox()
        {
            cmb_category.DisplayMember = "Name";
            cmb_category.ValueMember = "Id";
            cmb_category.DataSource = new List<Category>(_categories);
        }
        private void InitializeGridColumns()
        {
            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn CategoryName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Allocation = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Actual = new DataGridViewTextBoxColumn();


            DataGridViewImageColumn Edit = new DataGridViewImageColumn()
            {
                Image = ThemeConstant.GetResourceIcon(ThemeConstant.DEFAULT_EDIT_ICON),
                Name = "Edit",
                HeaderText = "",
            };

            //grid_category.Columns.Add(Edit);

            grid_budget.Columns.AddRange(new DataGridViewColumn[] {
            //Id,
            CategoryName,
            Allocation,
            Actual,
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
            CategoryName.DataPropertyName = "Category";
            CategoryName.HeaderText = "Category";
            CategoryName.MinimumWidth = 8;
            CategoryName.Name = "Category";
            CategoryName.ReadOnly = true;

            // 
            // Allocation
            // 
            Allocation.DataPropertyName = "Allocation";
            Allocation.HeaderText = "Allocation";
            Allocation.MinimumWidth = 8;
            Allocation.Name = "Allocation";
            Allocation.ReadOnly = true;

            // 
            // Actual
            // 
            Actual.DataPropertyName = "Actual";
            Actual.HeaderText = "Actual";
            Actual.MinimumWidth = 8;
            Actual.Name = "Actual";
            Actual.ReadOnly = true;

            //grid_budget.Columns["Id"].Width = 100;
            grid_budget.Columns["Edit"].Width = 20;

        }

        //public string Category
        //{
        //    get { return txt_category.Text; }
        //    set { txt_category.Text = value; }
        //}

        public void SetController(IBudgetController controller)
        {
            _controller = controller;
        }

        //private void btn_addCategory_Click(object sender, EventArgs e)
        //{
        //    _controller.AddCategory(Category.Trim());
        //    //_controller.LoadCategories();
        //    txt_category.Text = string.Empty;
        //}

        //private void txt_category_TextChanged(object sender, EventArgs e)
        //{
        //    btn_addCategory.Enabled = !string.IsNullOrWhiteSpace(Category);
        //}

        public void LoadBudgets(IList<BudgetViewData> budgets)
        {
            grid_budget.DataSource = null;

            grid_budget.DataSource = budgets;
        }
        //public void LoadCategories(IList<Category> categories)
        //{
        //    grid_category.DataSource = null;

        //    grid_category.DataSource = categories;
        //}

        public void UpdateBudget(Budget budget)
        {
            _controller.UpdateBudget(budget);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void txt_allocation_TextChanged(object sender, EventArgs e)
        {
            double x;
            btn_budget.Enabled = double.TryParse(Allocation, out x);
        }

        private void grid_budget_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == grid_budget.Columns["Edit"].Index)
            {
                string categoryName = grid_budget.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                double allocation = double.Parse(grid_budget.Rows[e.RowIndex].Cells["Allocation"].Value.ToString());

                Category category = new Category(categoryName);

                Budget selectedBudget = new Budget("temp", allocation, category);
                UpdateBudget updateBudget = new UpdateBudget(this, selectedBudget);
                updateBudget.ShowDialog();
            }
        }

        private void btn_budget_Click(object sender, EventArgs e)
        {
            Category category = (Category)cmb_category.SelectedItem;
            _controller.AddBudget(category, double.Parse(Allocation));
            //_controller.LoadCategories();
            txt_allocation.Text = string.Empty;
        }
    }
}

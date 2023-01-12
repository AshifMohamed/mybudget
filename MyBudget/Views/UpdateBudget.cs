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
    public partial class UpdateBudget : Form
    {
        private IBudgetView _budgetView;
        private Budget _budget;

        public string Allocation
        {
            get { return txt_update_allocation.Text; }
            set { txt_update_allocation.Text = value; }
        }
        public UpdateBudget()
        {
            InitializeComponent();
        }

        public UpdateBudget(IBudgetView budgetView, Budget budget)
        {
            InitializeComponent();
            _budgetView = budgetView;
            _budget = budget;

            txt_update_allocation.Text = _budget.Allocation.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string newAllocation = Allocation;

            if (_budget.Allocation.Equals(newAllocation))
            {
                Close();
                return;
            }

            _budget.Allocation = double.Parse(newAllocation);
            _budgetView.UpdateBudget(_budget);
            txt_update_allocation.Text = string.Empty;
            Close();
        }

        private void txt_update_allocation_TextChanged(object sender, EventArgs e)
        {
            double x;
            btn_update.Enabled = double.TryParse(Allocation, out x);
        }
    }
}

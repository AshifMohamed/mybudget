using MyBudget.Controllers.Interface;
using MyBudget.Core;
using MyBudget.Data;
using MyBudget.Models;
using MyBudget.Models.Transactions;
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

namespace MyBudget.Views.Transaction
{
    public partial class TransactionView : Form, ITransactionView
    {
        ITransactionController _controller;
        public IList<Category> Categories { get; }

        public TransactionView()
        {
            InitializeComponent();
            InitializeGridColumns();

            grid_transaction.AllowUserToAddRows = false;

            cmb_filter.Items.Add("ALL TRANSACTIONS");

            cmb_filter.Items.AddRange(Enum.GetNames(typeof(TransactionViewData.TYPE)));

            DateTime now = DateTime.Now;
            DateTime startDate = new DateTime(now.Year, now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            date_start.Value = startDate;
            date_end.Value = endDate;

            date_start.Format = DateTimePickerFormat.Custom;
            date_start.CustomFormat = ThemeConstant.DATE_FORMAT;
            date_end.Format = DateTimePickerFormat.Custom;
            date_end.CustomFormat = ThemeConstant.DATE_FORMAT;

            cmb_filter.SelectedIndex = 0;

            pnl_date_container.BackColor = ThemeColor.ActionPanelColor;
        }

        public TransactionView(IList<Category> categories) : this()
        {
            Categories = categories;
        }
        private void pnl_control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TransactionView_Load(object sender, EventArgs e)
        {
           
        }

        private void InitializeGridColumns()
        {
            DataGridViewTextBoxColumn Date = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Category = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Amount = new DataGridViewTextBoxColumn();

            DataGridViewImageColumn Edit = new DataGridViewImageColumn()
            {
                Image = ThemeConstant.GetResourceIcon(ThemeConstant.DEFAULT_EDIT_ICON),
                Name = "Edit",
                HeaderText = "",
            };

            DataGridViewImageColumn Delete = new DataGridViewImageColumn()
            {
                Image = ThemeConstant.GetResourceIcon(ThemeConstant.DEFAULT_DELETE_ICON),
                Name = "Delete",
                HeaderText = "",
            };

            grid_transaction.Columns.AddRange(new DataGridViewColumn[] {
            Date,
            Category,
            Amount,
            Edit,
            Delete
            });

            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;

            grid_transaction.Columns["Date"].Width = 150;
            grid_transaction.Columns["Category"].Width = 200;
            grid_transaction.Columns["Amount"].Width = 100;
            grid_transaction.Columns["Edit"].Width = 20;
            grid_transaction.Columns["Delete"].Width = 20;
        }
        private void grid_transaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_addTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction(this);
            addTransaction.ShowDialog();
        }

        public void SetController(ITransactionController controller)
        {
            _controller = controller;
        }

        public void LoadTransactions(IList<TransactionViewData> transactionList)
        {
            grid_transaction.DataSource = null;

            grid_transaction.DataSource = transactionList;
        }

        public void AddTransactions(IList<BasicTransaction> transactions)
        {
            _controller.AddTransactions(transactions);
            FilerData();
            //_controller.LoadTransactions();
        }

        private void grid_transaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == grid_transaction.Columns["Edit"].Index)
            {
                HandleEditClick(e.RowIndex);
            }
            else if(e.ColumnIndex == grid_transaction.Columns["Delete"].Index)
            {
                HandleDeleteClick(e.RowIndex);
            }
        }

        private void HandleEditClick(int index)
        {
            TransactionViewData selectedRow = (TransactionViewData)grid_transaction.Rows[index].DataBoundItem;
            BasicTransaction selectedTransaction = _controller.GetTransaction(selectedRow.Id);

            UpdateTransaction updateTransaction = new UpdateTransaction(this, selectedTransaction);
            updateTransaction.ShowDialog();
        }

        private void HandleDeleteClick(int index)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this Transaction ?", 
                "Delete Transaction ?", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                TransactionViewData selectedRow = (TransactionViewData)grid_transaction.Rows[index].DataBoundItem;
                DeleteTransaction(selectedRow.Id);
            }
        }
        private void DeleteTransaction(int id)
        {
            _controller.RemoveTransaction(id);
            FilerData();
            //_controller.LoadTransactions();
        }
        public void UpdateTransaction(BasicTransaction transaction)
        {
            _controller.UpdateTransaction(transaction);
            FilerData();
            //_controller.LoadTransactions();
        }

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FilerData()
        {
            string selectedType = (string)cmb_filter.SelectedItem;

            if (Enum.TryParse(selectedType, out TransactionViewData.TYPE transactionType))
            {
                switch (transactionType)
                {
                    case TransactionViewData.TYPE.RECURRING_INCOME:
                        _controller.GetFilteredTransactions(date_start.Value, date_end.Value,
                            BasicTransaction.TRANSACTION_TYPE.INCOME, true, false);
                        break;
                    case TransactionViewData.TYPE.RECURRING_EXPENSE:
                        _controller.GetFilteredTransactions(date_start.Value, date_end.Value,
                           BasicTransaction.TRANSACTION_TYPE.EXPENSE, true, false);
                        break;
                    case TransactionViewData.TYPE.INCOME:
                        _controller.GetFilteredTransactions(date_start.Value, date_end.Value,
                          BasicTransaction.TRANSACTION_TYPE.INCOME, false, false);
                        break;
                    case TransactionViewData.TYPE.EXPENSE:
                        _controller.GetFilteredTransactions(date_start.Value, date_end.Value,
                          BasicTransaction.TRANSACTION_TYPE.EXPENSE, false, false);
                        break;
                    default:
                        _controller.GetTransactions(date_start.Value, date_end.Value);
                        break;
                }
            }
            else
            {
                _controller.GetTransactions(date_start.Value, date_end.Value);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            FilerData();
        }
    }
}

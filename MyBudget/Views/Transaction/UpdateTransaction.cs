using MyBudget.Core;
using MyBudget.Models;
using MyBudget.Models.Transactions;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MyBudget.Models.Transactions.BasicTransaction;
using static MyBudget.Models.Transactions.RecurTransaction;

namespace MyBudget.Views.Transaction
{
    public partial class UpdateTransaction : Form
    {
        private ITransactionView _transactionView;
        private BasicTransaction _transaction;
        public UpdateTransaction()
        {
            InitializeComponent();
        }

        public UpdateTransaction(ITransactionView transactionView, BasicTransaction transaction)
        {
            InitializeComponent();
            _transactionView = transactionView;
            _transaction = transaction;

            InitializeComboBoxes();
            InitializeControls();
        }
        private void InitializeComboBoxes()
        {
            cmb_category.DisplayMember = "Name";
            cmb_category.ValueMember = "Id";
            cmb_category.DataSource = new List<Category>(_transactionView.Categories);
            cmb_type.Items.AddRange(Enum.GetNames(typeof(TransactionViewData.TYPE)));
            cmb_cycle.Items.AddRange(Enum.GetNames(typeof(TransactionCycle)));
            cmb_type.Format += new ListControlConvertEventHandler(typeComboBox_Format);

        }
        private void InitializeControls()
        {
            txt_amount.Text = _transaction.Amount.ToString();

            txt_amount.KeyPress += new KeyPressEventHandler(amount_KeyPress);
            txt_amount.Leave += new EventHandler(amount_Leave);

            date_transaction.Value = _transaction.Date;
            date_transaction.Format = DateTimePickerFormat.Custom;
            date_transaction.CustomFormat = ThemeConstant.DATE_FORMAT;
           
            date_end.Format = DateTimePickerFormat.Custom;
            date_end.CustomFormat = ThemeConstant.DATE_FORMAT;
            cmb_category.SelectedValue = _transaction.Category.Id;

            TransactionViewData.TYPE type;
            if(_transaction is RecurTransaction recurTransaction)
            {
                type = recurTransaction.Type == TRANSACTION_TYPE.INCOME ?
                                            TransactionViewData.TYPE.RECURRING_INCOME :
                                            TransactionViewData.TYPE.RECURRING_EXPENSE;

                string cycle = recurTransaction.Cycle.ToString();
                cmb_cycle.SelectedItem = cycle;

                date_end.Value = recurTransaction.ExpectedEndDate;
            }
            else
            {
                type = _transaction.Type == TRANSACTION_TYPE.INCOME ?
                                            TransactionViewData.TYPE.INCOME :
                                            TransactionViewData.TYPE.EXPENSE;
                EnablePanelContents(pnl_recur, false);
            }

            cmb_type.SelectedItem = type.ToString();
        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {

        }

        private void lbl_type_Click(object sender, EventArgs e)
        {

        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = (string)cmb_type.SelectedItem;

            if (Enum.TryParse(selectedType, out TransactionViewData.TYPE transactionType))
            {
                switch (transactionType)
                {
                    case TransactionViewData.TYPE.RECURRING_INCOME:
                    case TransactionViewData.TYPE.RECURRING_EXPENSE:
                        EnablePanelContents(pnl_recur, true);
                        break;
 
                    default:
                        EnablePanelContents(pnl_recur, false);
                        break;
                }
            }
        }

        private void lbl_expected_Click(object sender, EventArgs e)
        {

        }
        private void EnablePanelContents(Panel panel, bool enabled)
        {
            foreach (Control control in panel.Controls)
            {
                control.Enabled = enabled;
            }

            panel.Visible = enabled;
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void amount_Leave(object sender, EventArgs e)
        {
            TextBox control = sender as TextBox;

            if (double.TryParse(control.Text, out double value))
            {
                control.Text = string.Format("{0:#,##0.00}", value);
            }
            else
            {
                control.Text = string.Empty;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void typeComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.Value.ToString().Replace("_", " ");
        }

        private BasicTransaction CreateTransaction()
        {
            BasicTransaction transaction = null;
            TRANSACTION_TYPE income_expense_type;

            DateTime date = date_transaction.Value;
            Category category = (Category)cmb_category.SelectedItem;
            double amount = double.Parse(txt_amount.Text);
            string type = (string)cmb_type.SelectedItem;


            if (Enum.TryParse(type, out TransactionViewData.TYPE transactionType))
            {
                income_expense_type = transactionType.Equals(TransactionViewData.TYPE.INCOME) ||
                                      transactionType.Equals(TransactionViewData.TYPE.RECURRING_INCOME)
                                      ? TRANSACTION_TYPE.INCOME : TRANSACTION_TYPE.EXPENSE;

                if (transactionType.Equals(TransactionViewData.TYPE.RECURRING_EXPENSE) ||
                    transactionType.Equals(TransactionViewData.TYPE.RECURRING_INCOME))
                {
                    Enum.TryParse((string)cmb_cycle.SelectedItem, out TransactionCycle cycle);
                    DateTime endDate = date_end.Value;

                    transaction = new TransactionBuilder().WithId(0)
                        .WithAmount(amount).WithDate(date)
                        .WithType(income_expense_type)
                        .WithCategory(category).WithCycle(cycle)
                        .WithEndDate(endDate).BuildRecur();

                    //transaction = new RecurTransaction(0, amount, date, income_expense_type, category, cycle, endDate);
                }
                else
                {
                    transaction = new TransactionBuilder().WithId(0)
                        .WithAmount(amount).WithDate(date)
                        .WithType(income_expense_type)
                        .WithCategory(category).BuildBasic();
                    //transaction = new BasicTransaction(0, amount, date, income_expense_type, category);
                }

            }

            transaction.Id = _transaction.Id;
            return transaction;
        }

        private bool ValidateTransaction()
        {
            if(string.IsNullOrWhiteSpace(txt_amount.Text))
            {
                return false;
            }

            if(cmb_cycle.Enabled && cmb_cycle.SelectedIndex < 0)
            {
                return false;
            }

            return true;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ValidateTransaction())
            {
                _transactionView.UpdateTransaction(CreateTransaction());
                MessageBox.Show("Transaction Updated Successfully.");
                Close();
            }
            else
            {
                MessageBox.Show("One or more fields are empty");
            }
        }
    }
}

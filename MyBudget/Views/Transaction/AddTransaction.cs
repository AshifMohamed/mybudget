using MyBudget.Core;
using MyBudget.Framework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBudget.Models.Transactions;
using static MyBudget.Models.Transactions.RecurTransaction;
using static MyBudget.Models.Transactions.BasicTransaction;
using MyBudget.Models;
using MyBudget.Controllers.Interface;
using MyBudget.Views.Interface;

namespace MyBudget.Views.Transaction
{
    public partial class AddTransaction : Form
    {
        private ITransactionView _transactionView;
        private readonly Font DEFAULT_FONT = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        private readonly string DATE_FORMAT = "MMM dd yyyy";
        private List<List<Control>> controlLists = new List<List<Control>>();

        enum Fields
        {
            DATE,
            TYPE,
            CATEGORY,
            AMOUNT,
            //CONTACT,
            //EXPECTED_DATE,
            CYCLE,
            END_DATE
        }
        public AddTransaction()
        {
         
        }

        public AddTransaction(ITransactionView transactionView)
        {
            _transactionView = transactionView;

            InitializeComponent();
            this.Width = 1000;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            //  MaximizeBox = false;
            pnl_bottom.BackColor = ThemeColor.ActionPanelColor;

            AddRow();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }  

        private void AddRow()
        {
            int row = tableLayoutPanel1.RowCount;
            List<Control> rowControls = GetRowControls();

            for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
            {
                tableLayoutPanel1.Controls.Add(rowControls[col], col, row);
            }
            controlLists.Add(rowControls);
            tableLayoutPanel1.RowCount++;

        }

        private List<Control> GetRowControls()
        {
            DateTimePicker date = new DateTimePicker();
            ComboBox type = new ComboBox();
            ComboBox category = new ComboBox();
            RichTextBox amount = new RichTextBox();
            RichTextBox description = new RichTextBox();
            ComboBox cycle = new ComboBox();
            DateTimePicker endDate = new DateTimePicker();


            date.Dock = DockStyle.Fill;
            date.Font = DEFAULT_FONT;
            date.Height = 28;
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = DATE_FORMAT;
            
            type.Dock = DockStyle.Fill;
            type.Font = DEFAULT_FONT;
            type.FormattingEnabled = true;
            type.Items.AddRange(Enum.GetNames(typeof(TransactionViewData.TYPE)));
            type.Height = 28;
            type.SelectedIndexChanged += new EventHandler(type_SelectedIndexChanged);
            type.Format += new ListControlConvertEventHandler(typeComboBox_Format);

            category.Dock = DockStyle.Fill;
            category.Font = DEFAULT_FONT;
            category.FormattingEnabled = true;
            category.Height = 28;
            category.DisplayMember = "Name";
            category.ValueMember = "Id";
            category.DataSource = new List<Category>(_transactionView.Categories);
           
            amount.Dock = DockStyle.Fill;
            amount.Multiline = false;
            amount.Text = "";
            amount.Height = category.Height;
            amount.KeyPress += new KeyPressEventHandler(amount_KeyPress);
            amount.Leave += new EventHandler(amount_Leave);

 
            description.Dock = DockStyle.Fill;
            description.Text = "";
            description.Height = 28;

            cycle.Dock = DockStyle.Fill;
            cycle.Font = DEFAULT_FONT;
            cycle.FormattingEnabled = true;
            cycle.Items.AddRange(Enum.GetNames(typeof(TransactionCycle)));
            cycle.Height = 28;

            endDate.Dock = DockStyle.Fill;
            endDate.Font = DEFAULT_FONT;
            endDate.Height = 28;
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.CustomFormat = DATE_FORMAT;

            //disable additional controls
            cycle.Enabled = false;
            endDate.Enabled = false;

            return new List<Control>()
            {
                date,
                type,
                category,
                amount,
                cycle,
                endDate
            };

        }

        private void myBudgetButton1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();
            AddRow();
            tableLayoutPanel1.ResumeLayout();
        }
        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int row = tableLayoutPanel1.GetRow(comboBox);
            string selectedType = (string)comboBox.SelectedItem;

            if (Enum.TryParse(selectedType, out TransactionViewData.TYPE transactionType))
            {
                switch (transactionType)
                {
                    case TransactionViewData.TYPE.RECURRING_INCOME:
                    case TransactionViewData.TYPE.RECURRING_EXPENSE:
                        tableLayoutPanel1.GetControlFromPosition(4, row).Enabled = true;
                        tableLayoutPanel1.GetControlFromPosition(5, row).Enabled = true;
                     
                        //tableLayoutPanel1.GetControlFromPosition(4, row).Enabled = false;
                        //tableLayoutPanel1.GetControlFromPosition(5, row).Enabled = false;
                        //tableLayoutPanel1.GetControlFromPosition(6, row).Enabled = true;
                        //tableLayoutPanel1.GetControlFromPosition(7, row).Enabled = true;
                        break;

                    default:
                        for (int col = 4; col < tableLayoutPanel1.ColumnCount; col++)
                        {
                            tableLayoutPanel1.GetControlFromPosition(col, row).Enabled = false;
                        }
                        break;
                }
            }
            else
            {

            }

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
            RichTextBox control = sender as RichTextBox;

            if (double.TryParse(control.Text, out double value))
            {
                control.Text = string.Format("{0:#,##0.00}", value);
            }
            else
            {
                control.Text = string.Empty;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<BasicTransaction> transactionList = new List<BasicTransaction>();

            foreach (List<Control> controls in controlLists)
            {
                if(!IsRowValid(controls))
                {
                    MessageBox.Show("Some values are Invalid");
                    return;
                }

                transactionList.Add(CreateTransaction(controls));         
            }

            if(transactionList.Count > 0)
            {
                _transactionView.AddTransactions(transactionList);
                MessageBox.Show("Transactions created successfully");
            }

            Close();
        }

        private bool IsRowValid(List<Control> row)
        {
            bool isValid = false;

            foreach(Control control in row)
            {
                if(control is RichTextBox)
                {
                    isValid = !string.IsNullOrWhiteSpace((control as RichTextBox).Text);
                }
                else if(control is ComboBox)
                {
                    isValid = !(control.Enabled && (control as ComboBox).SelectedItem == null);
                }
                else
                {
                    isValid = true;
                }
                
                if(!isValid)
                {
                    control.Focus();
                    break;
                }
            }

            return isValid;
        }

        private BasicTransaction CreateTransaction(List<Control> row)
        {
            BasicTransaction transaction = null;
            TRANSACTION_TYPE income_expense_type;


            DateTimePicker dateControl = (DateTimePicker)row.ElementAt((int)Fields.DATE);
            DateTime date = dateControl.Value;

            ComboBox categoryControl = (ComboBox)row.ElementAt((int)Fields.CATEGORY);
            Category category = (Category)categoryControl.SelectedItem;

            RichTextBox amountControl = (RichTextBox)row.ElementAt((int)Fields.AMOUNT);
            double amount = double.Parse(amountControl.Text);

            ComboBox typeControl = (ComboBox)row.ElementAt((int)Fields.TYPE);
            string type = (string)typeControl.SelectedItem;


            if (Enum.TryParse(type, out TransactionViewData.TYPE transactionType))
            {
                income_expense_type = transactionType.Equals(TransactionViewData.TYPE.INCOME) ||
                                      transactionType.Equals(TransactionViewData.TYPE.RECURRING_INCOME)
                                      ? TRANSACTION_TYPE.INCOME : TRANSACTION_TYPE.EXPENSE;

                if (transactionType.Equals(TransactionViewData.TYPE.RECURRING_EXPENSE) ||
                    transactionType.Equals(TransactionViewData.TYPE.RECURRING_INCOME))
                {
                    ComboBox cycleControl = (ComboBox)row.ElementAt((int)Fields.CYCLE);
                    Enum.TryParse((string)cycleControl.SelectedItem, out TransactionCycle cycle);
                    DateTimePicker endDateControl = (DateTimePicker)row.ElementAt((int)Fields.END_DATE);
                    DateTime endDate = endDateControl.Value;

                    transaction = new RecurTransaction(0, amount, date, income_expense_type, category, cycle, endDate);
                }
                else
                {
                    transaction = new BasicTransaction(0, amount, date, income_expense_type, category);
                }

            }

            return transaction;
        }

        private void typeComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.Value.ToString().Replace("_", " ");
        }
    }
}

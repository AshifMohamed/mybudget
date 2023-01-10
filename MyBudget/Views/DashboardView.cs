using MyBudget.Controllers.Interface;
using MyBudget.Core;
using MyBudget.Data;
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
using System.Windows.Forms.DataVisualization.Charting;
using static MyBudget.Data.TransactionData;
using static MyBudget.Models.Transactions.BasicTransaction;

namespace MyBudget.Views
{
    public partial class DashboardView : Form, IDashboardView
    {
        IDashboardController _controller;
        public string Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DashboardView()
        {
            InitializeComponent();
            InitializeChartControls();
            InitializeTransactionChart();
            InitializeCategoryChart();

            DateTime now = DateTime.Now;
            DateTime startDate = new DateTime(now.Year, now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            date_start.Value = startDate;
            date_end.Value = endDate;
        }

        private void InitializeChartControls()
        {
            date_end.Format = DateTimePickerFormat.Custom;
            date_end.CustomFormat = ThemeConstant.DATE_FORMAT;
            date_end.Value = DateTime.Now;

            date_start.Format = DateTimePickerFormat.Custom;
            date_start.CustomFormat = ThemeConstant.DATE_FORMAT;
            date_start.Value = DateTime.Now;

            ActivateButton(btn_monthly);       
        }

        private void ActivateButton(Button btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                btnSender.ForeColor = ThemeColor.PrimaryColor;
            }
        }

        private void DisableButton()
        {
            btn_monthly.ForeColor = Color.Gainsboro;
            btn_weekly.ForeColor = Color.Gainsboro;
            btn_daily.ForeColor = Color.Gainsboro;
        }
        private void InitializeTransactionChart()
        {
            chart_transaction.PaletteCustomColors = new Color[] { ThemeColor.SecondaryColor, 
                ThemeColor.CancelBtnBorderColor };

            chart_transaction.ChartAreas["ChartArea1"].BackColor = ThemeColor.ActionPanelColor;
            chart_transaction.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart_transaction.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            Series income = chart_transaction.Series.Add("Income");
            income.XValueMember = "DateGroup";
            income.YValueMembers = "TotalIncome";

            Series expense = chart_transaction.Series.Add("Expense");
            expense.YValueMembers = "TotalExpense";
            expense.XValueMember = "DateGroup";

            income.LabelForeColor = Color.White;
            income.IsValueShownAsLabel = true;

            expense.LabelForeColor = Color.White;
            expense.IsValueShownAsLabel = true;

            chart_transaction.Titles.Add("Transactions Overview Chart");
            chart_transaction.Titles.Add("* Recursice Transactions are not shown");
        }

        private void InitializeCategoryChart()
        {
            chart_category.DataSource = TransactionData.GetCategoryChartData(date_start.Value, date_end.Value,
                DateTime.Now.Month);


            Series expense = chart_category.Series.Add("Expense");
            expense.XValueMember = "Category";
            expense.YValueMembers = "Total";

            expense.ChartType = SeriesChartType.Pie;

            expense.LabelForeColor = Color.White;
            expense.IsValueShownAsLabel = true;

            chart_category.Titles.Add("Expenses for current Month");
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            btn_daily.PerformClick();
            
            double forecastExpense = _controller.GetForecastBalance(DateTime.Now, TRANSACTION_TYPE.EXPENSE);
            double forecastIncome = _controller.GetForecastBalance(DateTime.Now, TRANSACTION_TYPE.INCOME);

            double actualExpense = _controller.GetActualBalance(DateTime.Now, TRANSACTION_TYPE.EXPENSE);
            double actualIncome = _controller.GetActualBalance(DateTime.Now, TRANSACTION_TYPE.INCOME);

            string monthName = DateTime.Today.ToString("MMMM");
            lbl_today.Text = monthName;

            lbl_forecast_expense.Text = string.Format("Rs.{0,0:N2}", Convert.ToInt32(forecastExpense) / 1.0);
            lbl_forecast_Income.Text = string.Format("Rs.{0,0:N2}",Convert.ToInt32(forecastIncome) / 1.0);

            lbl_actual_expense.Text = string.Format("Rs.{0,0:N2}", Convert.ToInt32(actualExpense) / 1.0);
            lbl_actual_income.Text = string.Format("Rs.{0,0:N2}", Convert.ToInt32(actualIncome) / 1.0);
        }
        private void btn_monthly_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            _controller.GetChartData(date_start.Value, date_end.Value, "MONTH");

            //LoadTransactionChart(GetChartData(date_start.Value, date_end.Value, "MONTH"));
        }

        private void btn_weekly_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            _controller.GetChartData(date_start.Value, date_end.Value, "WEEK");
            //LoadTransactionChart(GetChartData(date_start.Value, date_end.Value, "WEEK"));
        }

        private void btn_daily_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            _controller.GetChartData(date_start.Value, date_end.Value, "DAY");

            //LoadTransactionChart(GetChartData(date_start.Value, date_end.Value, "DAY"));
        }

        public void LoadTransactionChart(IList<TranscationChartData> data)
        {
            chart_transaction.DataSource = null;

            chart_transaction.DataSource = data;

            chart_transaction.DataBind();
        }

        public void SetController(IDashboardController controller)
        {
            _controller = controller;
        }
    }
}

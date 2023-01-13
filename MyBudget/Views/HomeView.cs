using MyBudget.Controllers;
using MyBudget.Controllers.Interface;
using MyBudget.Core;
using MyBudget.Views.Interface;
using MyBudget.Views.Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget.Views
{
    public partial class HomeView : Form
    {
        private Button currentButton;
        private Form activeForm;
        public HomeView()
        {
            InitializeComponent();
            this.Height = 600;
            this.Width = 1200;
            StartPosition = FormStartPosition.CenterScreen;
            //btnCloseChildForm.Visible = false;
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);   

        private void ActivateMenu(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableMenu();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = ThemeColor.PrimaryColor;
                }
            }
        }

        private void DisableMenu()
        {
            foreach (Control previousBtn in this.pnl_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateMenu(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_container.Controls.Add(childForm);
            this.pnl_container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_title.Text = childForm.Text;

        }

        private void pnl_navigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            btn_transaction.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool isSameMenu(Button btn)
        {
            return btn.Equals(currentButton);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_closeChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableMenu();
            lbl_title.Text = "HOME";
            //panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            //panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
        }

        private void pnl_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pnl_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            if (!isSameMenu((Button)sender))
            {
                ICategoryController categoryController = CategoryController.Instance;

                TransactionView transactionView = new TransactionView(categoryController.GetCategories());

                ITransactionController transactionController = TransactionController.Instance;
                transactionController.SetTransactionView(transactionView);
                transactionView.SetController(transactionController);
                transactionController.InitializeData();
                //transactionController.LoadTransactions();

                OpenChildForm(transactionView, sender);
            }
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            if (!isSameMenu((Button)sender))
            {
                CategoryView categoryView = new CategoryView();

                ICategoryController _categoryController = CategoryController.Instance;
                _categoryController.setCategoryView(categoryView);
                categoryView.SetController(_categoryController);
                _categoryController.InitializeData();
                _categoryController.LoadCategories();

                OpenChildForm(categoryView, sender);
            }
        }

        private void btn_budget_Click(object sender, EventArgs e)
        {
            if (!isSameMenu((Button)sender))
            {
                ICategoryController _categoryController = CategoryController.Instance;
                BudgetView budgetView = new BudgetView(_categoryController.GetCategories());

                IBudgetController _budgetController = BudgetController.Instance;
                _budgetController.SetBudgetView(budgetView);
                budgetView.SetController(_budgetController);
                _budgetController.InitializeData();
                _budgetController.LoadBudgets();

                OpenChildForm(budgetView, sender);
            }
        }
    }
}

using MyBudget.Controllers;
using MyBudget.Controllers.Interface;
using MyBudget.Data;
using MyBudget.Views;
using MyBudget.Views.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeData();

            LoginView loginView = new LoginView();
            ILoginController loginController = new LoginController(loginView);
            loginController.InitializeData();
            Application.Run(new HomeView());
        }

        private static void InitializeData()
        {
            //LoginData.InitializeData();
            TransactionData.InitializeData();
        }
    }
}

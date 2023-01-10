using MyBudget.Controllers.Interface;
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
    public partial class LoginView : Form, ILoginVew
    {
        ILoginController _controller;
        public LoginView()
        {
            InitializeComponent();
        }

        public void SetController(ILoginController controller)
        {
            _controller = controller;
        }

        public string Username
        {
            get { return txt_username.Text; }
            set { txt_username.Text = value; }
        }

        public string Password
        {
            get { return txt_password.Text; }
            set { txt_password.Text = value; }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if(_controller.Login(Username, Password))
            {
                HomeView homeView = new HomeView();
                homeView.Show();
            }
        }
    }
}

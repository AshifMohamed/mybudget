using MyBudget.Controllers.Interface;
using MyBudget.Data;
using MyBudget.Services;
using MyBudget.Views;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers
{
    public class LoginController : ILoginController
    {
        ILoginVew _loginView;
        LoginService _loginService;

        public LoginController(ILoginVew loginView)
        {
            _loginView = loginView;
            _loginView.SetController(this);
            _loginService = new LoginService();
        }

        public void InitializeData()
        {
            _loginService.InitializeData();
        }

        public bool Login(string username, string password)
        {
            return _loginService.IsUserExist(username, password);
        }
    }
}

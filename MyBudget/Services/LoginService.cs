using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBudget.Data;

namespace MyBudget.Services
{
    public class LoginService
    {
        private static LoginService _loginService;
        private static readonly object _lock = new object();

        private LoginService() { }

        public static LoginService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_loginService == null)
                    {
                        _loginService = new LoginService();
                    }
                    return _loginService;
                }
            }
        }

        public void InitializeData()
        {
            LoginData.InitializeData();
        }
        public bool IsUserExist(string username, string password)
        {
            return LoginData.GetLogins().Any(login => login.Username.Equals(username)
            && login.Password.Equals(password));
        }
    }
}

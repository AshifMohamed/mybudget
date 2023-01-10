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

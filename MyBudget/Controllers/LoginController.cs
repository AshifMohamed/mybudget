using MyBudget.Controllers.Interface;
using MyBudget.Services;
using MyBudget.Views.Interface;

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
            _loginService = LoginService.Instance;
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

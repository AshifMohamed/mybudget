using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers.Interface
{
    public interface ILoginController
    {
        void InitializeData();
        bool Login(string username, string password);
    }
}

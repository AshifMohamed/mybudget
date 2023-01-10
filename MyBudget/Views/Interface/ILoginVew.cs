using MyBudget.Controllers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Views.Interface
{
    public interface ILoginVew
    {
        void SetController(ILoginController controller);
        string Username { get; set; }
        string Password { get; set; }
    }
}

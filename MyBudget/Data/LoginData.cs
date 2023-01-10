using MyBudget.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Data
{
    public class LoginData
    {
        static IList<Login> data;

        public LoginData()
        {
            InitializeData();
        }

        public static IList<Login> GetLogins()
        {
            return data;
        }
        public static void InitializeData()
        {
            data = new List<Login>
            {
                new Login(1, "ashif1", "ashif1"),
                new Login(2, "ashif2", "ashif2"),
                new Login(3, "ashif3", "ashif3")
            };
        }
 
    }
}

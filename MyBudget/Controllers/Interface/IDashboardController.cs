using MyBudget.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBudget.Data.TransactionData;
using static MyBudget.Models.Transactions.BasicTransaction;

namespace MyBudget.Controllers.Interface
{
    public interface IDashboardController
    {
        void GetChartData(DateTime start,
            DateTime end, string group);

        double GetForecastBalance(DateTime currentDate, TRANSACTION_TYPE type);
        double GetActualBalance(DateTime currentDate, TRANSACTION_TYPE type);

    }
}

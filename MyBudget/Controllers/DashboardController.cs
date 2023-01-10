using MyBudget.Controllers.Interface;
using MyBudget.Data;
using MyBudget.Models.Transactions;
using MyBudget.Services;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers
{
    public class DashboardController : IDashboardController
    {
        IDashboardView _dashboardView;
        DashboardService _dashboardService = new DashboardService();

        public DashboardController()
        {

        }
        public DashboardController(IDashboardView dashboardView)
        {
            _dashboardView = dashboardView;
            _dashboardView.SetController(this);
        }

        public void GetChartData(DateTime start, 
            DateTime end, string group)
        {
            IList<TransactionData.TranscationChartData> data = _dashboardService.GetChartData(start, end, group);
            _dashboardView.LoadTransactionChart(data); 
        }

        public double GetForecastBalance(DateTime currentDate, BasicTransaction.TRANSACTION_TYPE type)
        {
            return _dashboardService.GetForecastBalance(currentDate, type);
        }
        public double GetActualBalance(DateTime currentDate, BasicTransaction.TRANSACTION_TYPE type)
        {
            return _dashboardService.GetActualBalance(currentDate, type);
        }
    }
}

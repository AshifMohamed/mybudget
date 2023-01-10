using MyBudget.Controllers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBudget.Data.TransactionData;

namespace MyBudget.Views.Interface
{
    public interface IDashboardView
    {
        void SetController(IDashboardController controller);
        void LoadTransactionChart(IList<TranscationChartData> data);
        string Category { get; set; }
    }
}

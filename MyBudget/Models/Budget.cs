using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Models
{
    public class Budget
    {
        public string Id { get; set; }
        public double Allocation { get; set; }
        public Category Category { get; set; }

        public Budget(string id, double allocation, Category category)
        {
            Id = id;
            Allocation = allocation;
            Category = category;
        }
    }
}

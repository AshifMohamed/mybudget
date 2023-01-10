using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Contact(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Contact(string name)
        {
            Name = name;
        }
    }
}

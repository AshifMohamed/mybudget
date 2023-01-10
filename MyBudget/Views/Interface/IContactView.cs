using MyBudget.Controllers.Interface;
using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Views.Interface
{
    public interface IContactView
    {
        void SetController(IContactController controller);
        void LoadContacts(IList<Contact> contacts);
        void UpdateContact(Contact contact);
        string Contact { get; set; }
        void ShowMessage(string message);
    }
}

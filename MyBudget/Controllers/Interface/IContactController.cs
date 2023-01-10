using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers.Interface
{
    public interface IContactController
    {
        void InitializeData();
        void LoadContacts();

        IList<Contact> GetContacts();
        void AddContact(string name);

        void UpdateContact(Contact contact);
    }
}

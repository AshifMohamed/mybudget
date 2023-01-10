using MyBudget.Data;
using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Services
{
    public class ContactService
    {
        public void InitializeData()
        {
            ContactData.InitializeData();
        }
        public IList<Contact> GetAllContacts()
        {
            return ContactData.Get();
        }

        public bool AddContact(string name)
        {
            return ContactData.Insert(new Contact(name));
        }
        public bool UpdateContact(Contact contact)
        {
            return ContactData.Update(contact);
        }
    }
}

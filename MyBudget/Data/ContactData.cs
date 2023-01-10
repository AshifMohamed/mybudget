using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Data
{
    public class ContactData
    {
        static IList<Contact> data;
        static bool isInitialized = false;
        public static IList<Contact> Get()
        {
            InitializeData();
            return data;
        }
        public static bool Insert(Contact contact)
        {
            bool isExist = Get().Any(c => c.Name.Equals(contact.Name));

            if (!isExist)
            {
                int newId = Get().Last().Id + 1;
                contact.Id = newId;

                data.Add(contact);

                return true;
            }

            return false;
        }
        public static bool Update(Contact contact)
        {
            bool isExist = Get().Any(c => c.Name.Equals(contact.Name));

            if (!isExist)
            {
                Contact updateContact = Get().First(c => c.Id == contact.Id);

                if (updateContact != null)
                {
                    updateContact.Name = contact.Name;
                    return true;
                }
            }

            return false;
        }
        public static void InitializeData()
        {
            if (!isInitialized)
            {
                data = new List<Contact>
                {
                    new Contact(1, "Tharaka"),
                    new Contact(2, "Harsha"),
                    new Contact(3, "Ajith"),
                    new Contact(4, "Arjun"),
                    new Contact(5, "Rahul"),
                };

                isInitialized = true;
            }
        }
    }
}

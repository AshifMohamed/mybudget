using MyBudget.Controllers.Interface;
using MyBudget.Models;
using MyBudget.Services;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers
{
    public class ContactController : IContactController
    {
        IContactView _contactView;
        ContactService _contactService = new ContactService();

        public ContactController()
        {

        }
        public ContactController(IContactView contactView)
        {
            _contactView = contactView;
            _contactView.SetController(this);
        }
        public void AddContact(string name)
        {
            bool isAdded = _contactService.AddContact(name);

            string message = isAdded ? "Contact Added successfully."
                    : "There is already a Contact with same name.";
            _contactView.ShowMessage(message);
        }

        public IList<Contact> GetContacts()
        {
           return _contactService.GetAllContacts();
        }

        public void InitializeData()
        {
            _contactService.InitializeData();
        }

        public void LoadContacts()
        {
            _contactView.LoadContacts(GetContacts());
        }

        public void UpdateContact(Contact contact)
        {
            bool isUpdated = _contactService.UpdateContact(contact);

            if (isUpdated)
            {
                _contactView.ShowMessage("Contact Updated successfully.");
                LoadContacts();
            }
            else
            {
                _contactView.ShowMessage("There was an error while updating the contact.");
            }
        }
    }
}

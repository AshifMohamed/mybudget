using MyBudget.Models;
using MyBudget.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget.Views
{
    public partial class UpdateContact : Form
    {
        private IContactView _contactView;
        private Contact _contact;
        public UpdateContact()
        {
            InitializeComponent();
        }

        public UpdateContact(IContactView contactView, Contact contact)
        {
            InitializeComponent();
            _contactView = contactView;
            _contact = contact;

            txt_update_contact.Text = _contact.Name;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string newName = txt_update_contact.Text;

            if (_contact.Name.Equals(newName))
            {
                Close();
                return;
            }

            _contact.Name = txt_update_contact.Text;
            _contactView.UpdateContact(_contact);
            txt_update_contact.Text = string.Empty;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

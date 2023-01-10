using MyBudget.Controllers.Interface;
using MyBudget.Core;
using MyBudget.Models;
using MyBudget.Views.Interface;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyBudget.Views
{
    public partial class ContactView : Form, IContactView 
    {
        IContactController _controller;
        public ContactView()
        {
            InitializeComponent();
        }

        private void ContactView_Load(object sender, System.EventArgs e)
        {
            btn_addContact.Enabled = false;
            InitializeGridColumns();
        }
        private void InitializeGridColumns()
        {
            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();

            DataGridViewImageColumn Edit = new DataGridViewImageColumn()
            {
                Image = ThemeConstant.GetResourceIcon(ThemeConstant.DEFAULT_EDIT_ICON),
                Name = "Edit",
                HeaderText = "",
            };

            grid_contact.Columns.AddRange(new DataGridViewColumn[] {
            Id,
            Name,
            Edit});

            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.ReadOnly = true;

            grid_contact.Columns["Id"].Width = 100;
            grid_contact.Columns["Edit"].Width = 20;
        }

        public string Contact 
        {
            get { return txt_contact.Text; }
            set { txt_contact.Text = value; }
        }

        public void LoadContacts(IList<Contact> contacts)
        {
            grid_contact.DataSource = null;

            grid_contact.DataSource = contacts;
        }

        public void SetController(IContactController controller)
        {
            _controller = controller;
        }

        private void btn_addContact_Click(object sender, System.EventArgs e)
        {
            _controller.AddContact(Contact.Trim());
            _controller.LoadContacts();
            txt_contact.Text = string.Empty;
        }

        private void txt_contact_TextChanged(object sender, System.EventArgs e)
        {
            btn_addContact.Enabled = !string.IsNullOrWhiteSpace(Contact);
        }

        private void grid_contact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == grid_contact.Columns["Edit"].Index)
            {
                string name = grid_contact.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                int id = int.Parse(grid_contact.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                Contact selectedContact = new Contact(id, name);
                UpdateContact updateCategory = new UpdateContact(this, selectedContact); ;
                updateCategory.ShowDialog();
            }
        }

        public void UpdateContact(Contact contact)
        {
            _controller.UpdateContact(contact);
            _controller.LoadContacts();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}

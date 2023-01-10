namespace MyBudget.Views
{
    partial class ContactView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_control = new System.Windows.Forms.Panel();
            this.btn_addContact = new MyBudget.Framework.Controls.MyBudgetActionButton();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.pnl_grid_container = new System.Windows.Forms.Panel();
            this.grid_contact = new MyBudget.Framework.Controls.MyBudgetDataGrid();
            this.pnl_control.SuspendLayout();
            this.pnl_grid_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_contact)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_control
            // 
            this.pnl_control.Controls.Add(this.btn_addContact);
            this.pnl_control.Controls.Add(this.txt_contact);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_control.Location = new System.Drawing.Point(0, 0);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(800, 70);
            this.pnl_control.TabIndex = 1;
            // 
            // btn_addContact
            // 
            this.btn_addContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_addContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.btn_addContact.BorderRadius = 5;
            this.btn_addContact.BorderSize = 2;
            this.btn_addContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addContact.FlatAppearance.BorderSize = 0;
            this.btn_addContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addContact.ForeColor = System.Drawing.Color.White;
            this.btn_addContact.Location = new System.Drawing.Point(301, 16);
            this.btn_addContact.Name = "btn_addContact";
            this.btn_addContact.Size = new System.Drawing.Size(150, 40);
            this.btn_addContact.TabIndex = 1;
            this.btn_addContact.Text = "SAVE";
            this.btn_addContact.Type = MyBudget.Framework.Controls.MyBudgetActionButton.ActionType.Save;
            this.btn_addContact.UseVisualStyleBackColor = false;
            this.btn_addContact.Click += new System.EventHandler(this.btn_addContact_Click);
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(30, 22);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(250, 26);
            this.txt_contact.TabIndex = 0;
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_contact_TextChanged);
            // 
            // pnl_grid_container
            // 
            this.pnl_grid_container.Controls.Add(this.grid_contact);
            this.pnl_grid_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid_container.Location = new System.Drawing.Point(0, 70);
            this.pnl_grid_container.Name = "pnl_grid_container";
            this.pnl_grid_container.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pnl_grid_container.Size = new System.Drawing.Size(800, 380);
            this.pnl_grid_container.TabIndex = 2;
            // 
            // grid_contact
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.grid_contact.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_contact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_contact.BackgroundColor = System.Drawing.Color.White;
            this.grid_contact.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_contact.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_contact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_contact.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_contact.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_contact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_contact.EnableHeadersVisualStyles = false;
            this.grid_contact.GridColor = System.Drawing.Color.White;
            this.grid_contact.Location = new System.Drawing.Point(3, 3);
            this.grid_contact.Name = "grid_contact";
            this.grid_contact.ReadOnly = true;
            this.grid_contact.RowHeadersWidth = 62;
            this.grid_contact.RowTemplate.Height = 28;
            this.grid_contact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_contact.Size = new System.Drawing.Size(787, 374);
            this.grid_contact.TabIndex = 0;
            this.grid_contact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_contact_CellClick);
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_grid_container);
            this.Controls.Add(this.pnl_control);
            this.Name = "ContactView";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.ContactView_Load);
            this.pnl_control.ResumeLayout(false);
            this.pnl_control.PerformLayout();
            this.pnl_grid_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_contact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_control;
        private Framework.Controls.MyBudgetActionButton btn_addContact;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Panel pnl_grid_container;
        private Framework.Controls.MyBudgetDataGrid grid_contact;
    }
}
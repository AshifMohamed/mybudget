namespace MyBudget.Views.Transaction
{
    partial class UpdateTransaction
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
            this.pnl_container = new System.Windows.Forms.Panel();
            this.pnl_action = new System.Windows.Forms.Panel();
            this.btn_update = new MyBudget.Framework.Controls.MyBudgetButton();
            this.btn_cancel = new MyBudget.Framework.Controls.MyBudgetActionButton();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.pnl_add_transaction_container = new System.Windows.Forms.Panel();
            this.pnl_recur = new System.Windows.Forms.Panel();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.cmb_cycle = new System.Windows.Forms.ComboBox();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_cycle = new System.Windows.Forms.Label();
            this.pnl_contact = new System.Windows.Forms.Panel();
            this.date_expected = new System.Windows.Forms.DateTimePicker();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_expected = new System.Windows.Forms.Label();
            this.cmb_contact = new System.Windows.Forms.ComboBox();
            this.pnl_basic = new System.Windows.Forms.Panel();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.date_transaction = new System.Windows.Forms.DateTimePicker();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.pnl_container.SuspendLayout();
            this.pnl_action.SuspendLayout();
            this.pnl_content.SuspendLayout();
            this.pnl_add_transaction_container.SuspendLayout();
            this.pnl_recur.SuspendLayout();
            this.pnl_contact.SuspendLayout();
            this.pnl_basic.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.Controls.Add(this.pnl_action);
            this.pnl_container.Controls.Add(this.pnl_content);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(778, 344);
            this.pnl_container.TabIndex = 1;
            // 
            // pnl_action
            // 
            this.pnl_action.Controls.Add(this.btn_update);
            this.pnl_action.Controls.Add(this.btn_cancel);
            this.pnl_action.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_action.Location = new System.Drawing.Point(0, 284);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(778, 60);
            this.pnl_action.TabIndex = 7;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_update.BorderRadius = 5;
            this.btn_update.BorderSize = 2;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(431, 8);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 40);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btn_cancel.BorderRadius = 5;
            this.btn_cancel.BorderSize = 2;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(605, 8);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 40);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.Type = MyBudget.Framework.Controls.MyBudgetActionButton.ActionType.Cancel;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.pnl_add_transaction_container);
            this.pnl_content.Controls.Add(this.pnl_basic);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_content.Location = new System.Drawing.Point(0, 0);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(778, 259);
            this.pnl_content.TabIndex = 6;
            // 
            // pnl_add_transaction_container
            // 
            this.pnl_add_transaction_container.Controls.Add(this.pnl_recur);
            this.pnl_add_transaction_container.Controls.Add(this.pnl_contact);
            this.pnl_add_transaction_container.Location = new System.Drawing.Point(374, 12);
            this.pnl_add_transaction_container.Name = "pnl_add_transaction_container";
            this.pnl_add_transaction_container.Size = new System.Drawing.Size(374, 223);
            this.pnl_add_transaction_container.TabIndex = 17;
            // 
            // pnl_recur
            // 
            this.pnl_recur.Controls.Add(this.date_end);
            this.pnl_recur.Controls.Add(this.cmb_cycle);
            this.pnl_recur.Controls.Add(this.lbl_end);
            this.pnl_recur.Controls.Add(this.lbl_cycle);
            this.pnl_recur.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_recur.Location = new System.Drawing.Point(0, 110);
            this.pnl_recur.Name = "pnl_recur";
            this.pnl_recur.Size = new System.Drawing.Size(374, 110);
            this.pnl_recur.TabIndex = 16;
            // 
            // date_end
            // 
            this.date_end.Location = new System.Drawing.Point(154, 59);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(200, 26);
            this.date_end.TabIndex = 14;
            // 
            // cmb_cycle
            // 
            this.cmb_cycle.FormattingEnabled = true;
            this.cmb_cycle.Location = new System.Drawing.Point(154, 8);
            this.cmb_cycle.Name = "cmb_cycle";
            this.cmb_cycle.Size = new System.Drawing.Size(200, 28);
            this.cmb_cycle.TabIndex = 13;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(18, 64);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(77, 20);
            this.lbl_end.TabIndex = 15;
            this.lbl_end.Text = "End Date";
            // 
            // lbl_cycle
            // 
            this.lbl_cycle.AutoSize = true;
            this.lbl_cycle.Location = new System.Drawing.Point(18, 11);
            this.lbl_cycle.Name = "lbl_cycle";
            this.lbl_cycle.Size = new System.Drawing.Size(47, 20);
            this.lbl_cycle.TabIndex = 12;
            this.lbl_cycle.Text = "Cycle";
            // 
            // pnl_contact
            // 
            this.pnl_contact.Controls.Add(this.date_expected);
            this.pnl_contact.Controls.Add(this.lbl_contact);
            this.pnl_contact.Controls.Add(this.lbl_expected);
            this.pnl_contact.Controls.Add(this.cmb_contact);
            this.pnl_contact.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_contact.Location = new System.Drawing.Point(0, 0);
            this.pnl_contact.Name = "pnl_contact";
            this.pnl_contact.Size = new System.Drawing.Size(374, 110);
            this.pnl_contact.TabIndex = 14;
            // 
            // date_expected
            // 
            this.date_expected.Location = new System.Drawing.Point(154, 71);
            this.date_expected.Name = "date_expected";
            this.date_expected.Size = new System.Drawing.Size(200, 26);
            this.date_expected.TabIndex = 12;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(18, 17);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(65, 20);
            this.lbl_contact.TabIndex = 12;
            this.lbl_contact.Text = "Contact";
            // 
            // lbl_expected
            // 
            this.lbl_expected.AutoSize = true;
            this.lbl_expected.Location = new System.Drawing.Point(18, 76);
            this.lbl_expected.Name = "lbl_expected";
            this.lbl_expected.Size = new System.Drawing.Size(115, 20);
            this.lbl_expected.TabIndex = 13;
            this.lbl_expected.Text = "Expected Date";
            this.lbl_expected.Click += new System.EventHandler(this.lbl_expected_Click);
            // 
            // cmb_contact
            // 
            this.cmb_contact.FormattingEnabled = true;
            this.cmb_contact.Location = new System.Drawing.Point(154, 14);
            this.cmb_contact.Name = "cmb_contact";
            this.cmb_contact.Size = new System.Drawing.Size(200, 28);
            this.cmb_contact.TabIndex = 13;
            // 
            // pnl_basic
            // 
            this.pnl_basic.Controls.Add(this.lbl_amount);
            this.pnl_basic.Controls.Add(this.txt_amount);
            this.pnl_basic.Controls.Add(this.cmb_category);
            this.pnl_basic.Controls.Add(this.date_transaction);
            this.pnl_basic.Controls.Add(this.cmb_type);
            this.pnl_basic.Controls.Add(this.lbl_date);
            this.pnl_basic.Controls.Add(this.lbl_type);
            this.pnl_basic.Controls.Add(this.lbl_category);
            this.pnl_basic.Location = new System.Drawing.Point(12, 12);
            this.pnl_basic.Name = "pnl_basic";
            this.pnl_basic.Size = new System.Drawing.Size(343, 220);
            this.pnl_basic.TabIndex = 15;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(18, 17);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(65, 20);
            this.lbl_amount.TabIndex = 5;
            this.lbl_amount.Text = "Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(122, 14);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(206, 26);
            this.txt_amount.TabIndex = 6;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(122, 176);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(200, 28);
            this.cmb_category.TabIndex = 11;
            // 
            // date_transaction
            // 
            this.date_transaction.Location = new System.Drawing.Point(122, 71);
            this.date_transaction.Name = "date_transaction";
            this.date_transaction.Size = new System.Drawing.Size(200, 26);
            this.date_transaction.TabIndex = 7;
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(122, 123);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(200, 28);
            this.cmb_type.TabIndex = 10;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(18, 76);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(44, 20);
            this.lbl_date.TabIndex = 8;
            this.lbl_date.Text = "Date";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(18, 126);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(43, 20);
            this.lbl_type.TabIndex = 9;
            this.lbl_type.Text = "Type";
            this.lbl_type.Click += new System.EventHandler(this.lbl_type_Click);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(18, 179);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(73, 20);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "Category";
            // 
            // UpdateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 344);
            this.Controls.Add(this.pnl_container);
            this.Name = "UpdateTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Transaction";
            this.pnl_container.ResumeLayout(false);
            this.pnl_action.ResumeLayout(false);
            this.pnl_content.ResumeLayout(false);
            this.pnl_add_transaction_container.ResumeLayout(false);
            this.pnl_recur.ResumeLayout(false);
            this.pnl_recur.PerformLayout();
            this.pnl_contact.ResumeLayout(false);
            this.pnl_contact.PerformLayout();
            this.pnl_basic.ResumeLayout(false);
            this.pnl_basic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_container;
        private System.Windows.Forms.Label lbl_category;
        private Framework.Controls.MyBudgetActionButton btn_cancel;
        private Framework.Controls.MyBudgetButton btn_update;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker date_transaction;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Panel pnl_contact;
        private System.Windows.Forms.ComboBox cmb_contact;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Panel pnl_basic;
        private System.Windows.Forms.Panel pnl_recur;
        private System.Windows.Forms.DateTimePicker date_expected;
        private System.Windows.Forms.Label lbl_expected;
        private System.Windows.Forms.ComboBox cmb_cycle;
        private System.Windows.Forms.Label lbl_cycle;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Panel pnl_action;
        private System.Windows.Forms.Panel pnl_add_transaction_container;
    }
}
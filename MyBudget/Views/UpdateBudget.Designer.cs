namespace MyBudget.Views
{
    partial class UpdateBudget
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
            this.lbl_allocation = new System.Windows.Forms.Label();
            this.txt_update_allocation = new System.Windows.Forms.TextBox();
            this.btn_cancel = new MyBudget.Framework.Controls.MyBudgetActionButton();
            this.btn_update = new MyBudget.Framework.Controls.MyBudgetButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_allocation
            // 
            this.lbl_allocation.AutoSize = true;
            this.lbl_allocation.Location = new System.Drawing.Point(19, 30);
            this.lbl_allocation.Name = "lbl_allocation";
            this.lbl_allocation.Size = new System.Drawing.Size(78, 20);
            this.lbl_allocation.TabIndex = 7;
            this.lbl_allocation.Text = "Allocation";
            // 
            // txt_update_allocation
            // 
            this.txt_update_allocation.Location = new System.Drawing.Point(115, 27);
            this.txt_update_allocation.Name = "txt_update_allocation";
            this.txt_update_allocation.Size = new System.Drawing.Size(269, 26);
            this.txt_update_allocation.TabIndex = 6;
            this.txt_update_allocation.TextChanged += new System.EventHandler(this.txt_update_allocation_TextChanged);
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
            this.btn_cancel.Location = new System.Drawing.Point(259, 71);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 40);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.Type = MyBudget.Framework.Controls.MyBudgetActionButton.ActionType.Cancel;
            this.btn_cancel.UseVisualStyleBackColor = false;
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
            this.btn_update.Location = new System.Drawing.Point(99, 71);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 40);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_allocation);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.txt_update_allocation);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 135);
            this.panel1.TabIndex = 8;
            // 
            // UpdateBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 137);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateBudget";
            this.Text = "UpdateBudget";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_allocation;
        private System.Windows.Forms.TextBox txt_update_allocation;
        private Framework.Controls.MyBudgetActionButton btn_cancel;
        private Framework.Controls.MyBudgetButton btn_update;
        private System.Windows.Forms.Panel panel1;
    }
}
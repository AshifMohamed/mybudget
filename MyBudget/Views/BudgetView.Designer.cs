namespace MyBudget.Views
{
    partial class BudgetView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_budget = new MyBudget.Framework.Controls.MyBudgetActionButton();
            this.lbl_allocation = new System.Windows.Forms.Label();
            this.txt_allocation = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.grid_budget = new MyBudget.Framework.Controls.MyBudgetDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_budget)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_budget);
            this.panel1.Controls.Add(this.lbl_allocation);
            this.panel1.Controls.Add(this.txt_allocation);
            this.panel1.Controls.Add(this.lbl_category);
            this.panel1.Controls.Add(this.cmb_category);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 0;
            // 
            // btn_budget
            // 
            this.btn_budget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_budget.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.btn_budget.BorderRadius = 5;
            this.btn_budget.BorderSize = 2;
            this.btn_budget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_budget.FlatAppearance.BorderSize = 0;
            this.btn_budget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_budget.ForeColor = System.Drawing.Color.White;
            this.btn_budget.Location = new System.Drawing.Point(547, 21);
            this.btn_budget.Name = "btn_budget";
            this.btn_budget.Size = new System.Drawing.Size(150, 40);
            this.btn_budget.TabIndex = 5;
            this.btn_budget.Text = "SAVE";
            this.btn_budget.Type = MyBudget.Framework.Controls.MyBudgetActionButton.ActionType.Save;
            this.btn_budget.UseVisualStyleBackColor = false;
            this.btn_budget.Click += new System.EventHandler(this.btn_budget_Click);
            // 
            // lbl_allocation
            // 
            this.lbl_allocation.AutoSize = true;
            this.lbl_allocation.Location = new System.Drawing.Point(302, 31);
            this.lbl_allocation.Name = "lbl_allocation";
            this.lbl_allocation.Size = new System.Drawing.Size(78, 20);
            this.lbl_allocation.TabIndex = 3;
            this.lbl_allocation.Text = "Allocation";
            // 
            // txt_allocation
            // 
            this.txt_allocation.Location = new System.Drawing.Point(387, 30);
            this.txt_allocation.Name = "txt_allocation";
            this.txt_allocation.Size = new System.Drawing.Size(127, 26);
            this.txt_allocation.TabIndex = 2;
            this.txt_allocation.TextChanged += new System.EventHandler(this.txt_allocation_TextChanged);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(24, 31);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(73, 20);
            this.lbl_category.TabIndex = 1;
            this.lbl_category.Text = "Category";
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(123, 28);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(154, 28);
            this.cmb_category.TabIndex = 0;
            // 
            // grid_budget
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.grid_budget.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_budget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_budget.BackgroundColor = System.Drawing.Color.White;
            this.grid_budget.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_budget.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_budget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_budget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_budget.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_budget.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_budget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_budget.EnableHeadersVisualStyles = false;
            this.grid_budget.GridColor = System.Drawing.Color.White;
            this.grid_budget.Location = new System.Drawing.Point(0, 81);
            this.grid_budget.Name = "grid_budget";
            this.grid_budget.ReadOnly = true;
            this.grid_budget.RowHeadersWidth = 62;
            this.grid_budget.RowTemplate.Height = 28;
            this.grid_budget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_budget.Size = new System.Drawing.Size(800, 369);
            this.grid_budget.TabIndex = 1;
            this.grid_budget.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_budget_CellClick);
            // 
            // BudgetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_budget);
            this.Controls.Add(this.panel1);
            this.Name = "BudgetView";
            this.Text = "Manage Budgets";
            this.Load += new System.EventHandler(this.BudgetView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_budget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Framework.Controls.MyBudgetDataGrid grid_budget;
        private System.Windows.Forms.Label lbl_allocation;
        private System.Windows.Forms.TextBox txt_allocation;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cmb_category;
        private Framework.Controls.MyBudgetActionButton btn_budget;
    }
}
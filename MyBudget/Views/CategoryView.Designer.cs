namespace MyBudget.Views
{
    partial class CategoryView
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
            this.btn_addCategory = new MyBudget.Framework.Controls.MyBudgetActionButton();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.pnl_grid_container = new System.Windows.Forms.Panel();
            this.grid_category = new MyBudget.Framework.Controls.MyBudgetDataGrid();
            this.pnl_control.SuspendLayout();
            this.pnl_grid_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_control
            // 
            this.pnl_control.Controls.Add(this.btn_addCategory);
            this.pnl_control.Controls.Add(this.txt_category);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_control.Location = new System.Drawing.Point(0, 0);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(800, 70);
            this.pnl_control.TabIndex = 0;
            this.pnl_control.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_control_Paint);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_addCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.btn_addCategory.BorderRadius = 5;
            this.btn_addCategory.BorderSize = 2;
            this.btn_addCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addCategory.FlatAppearance.BorderSize = 0;
            this.btn_addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCategory.ForeColor = System.Drawing.Color.White;
            this.btn_addCategory.Location = new System.Drawing.Point(301, 16);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(150, 40);
            this.btn_addCategory.TabIndex = 1;
            this.btn_addCategory.Text = "SAVE";
            this.btn_addCategory.Type = MyBudget.Framework.Controls.MyBudgetActionButton.ActionType.Save;
            this.btn_addCategory.UseVisualStyleBackColor = false;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(30, 22);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(250, 26);
            this.txt_category.TabIndex = 0;
            this.txt_category.TextChanged += new System.EventHandler(this.txt_category_TextChanged);
            // 
            // pnl_grid_container
            // 
            this.pnl_grid_container.Controls.Add(this.grid_category);
            this.pnl_grid_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid_container.Location = new System.Drawing.Point(0, 70);
            this.pnl_grid_container.Name = "pnl_grid_container";
            this.pnl_grid_container.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pnl_grid_container.Size = new System.Drawing.Size(800, 380);
            this.pnl_grid_container.TabIndex = 1;
            // 
            // grid_category
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.grid_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_category.BackgroundColor = System.Drawing.Color.White;
            this.grid_category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_category.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_category.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_category.EnableHeadersVisualStyles = false;
            this.grid_category.GridColor = System.Drawing.Color.White;
            this.grid_category.Location = new System.Drawing.Point(3, 3);
            this.grid_category.Name = "grid_category";
            this.grid_category.ReadOnly = true;
            this.grid_category.RowHeadersWidth = 62;
            this.grid_category.RowTemplate.Height = 28;
            this.grid_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_category.Size = new System.Drawing.Size(787, 374);
            this.grid_category.TabIndex = 0;
            this.grid_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_category_CellClick);
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_grid_container);
            this.Controls.Add(this.pnl_control);
            this.Name = "CategoryView";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.CategoryView_Load);
            this.pnl_control.ResumeLayout(false);
            this.pnl_control.PerformLayout();
            this.pnl_grid_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_control;
        private System.Windows.Forms.TextBox txt_category;
        private Framework.Controls.MyBudgetActionButton btn_addCategory;
        private System.Windows.Forms.Panel pnl_grid_container;
        private Framework.Controls.MyBudgetDataGrid grid_category;
    }
}
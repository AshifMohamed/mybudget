namespace MyBudget.Views
{
    partial class HomeView
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_budget = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_transaction = new System.Windows.Forms.Button();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pnl_titlebar = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            this.pnl_titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnl_menu.Controls.Add(this.btn_budget);
            this.pnl_menu.Controls.Add(this.btn_category);
            this.pnl_menu.Controls.Add(this.btn_transaction);
            this.pnl_menu.Controls.Add(this.pnl_logo);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(220, 647);
            this.pnl_menu.TabIndex = 0;
            this.pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_navigation_Paint);
            // 
            // btn_budget
            // 
            this.btn_budget.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_budget.FlatAppearance.BorderSize = 0;
            this.btn_budget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_budget.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_budget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_budget.Location = new System.Drawing.Point(0, 200);
            this.btn_budget.Name = "btn_budget";
            this.btn_budget.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_budget.Size = new System.Drawing.Size(220, 60);
            this.btn_budget.TabIndex = 5;
            this.btn_budget.Text = "Budget";
            this.btn_budget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_budget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_budget.UseVisualStyleBackColor = true;
            this.btn_budget.Click += new System.EventHandler(this.btn_budget_Click);
            // 
            // btn_category
            // 
            this.btn_category.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_category.FlatAppearance.BorderSize = 0;
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_category.Location = new System.Drawing.Point(0, 140);
            this.btn_category.Name = "btn_category";
            this.btn_category.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_category.Size = new System.Drawing.Size(220, 60);
            this.btn_category.TabIndex = 3;
            this.btn_category.Text = "Category";
            this.btn_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_transaction
            // 
            this.btn_transaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_transaction.FlatAppearance.BorderSize = 0;
            this.btn_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaction.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transaction.Location = new System.Drawing.Point(0, 80);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_transaction.Size = new System.Drawing.Size(220, 60);
            this.btn_transaction.TabIndex = 2;
            this.btn_transaction.Text = "Transaction";
            this.btn_transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_transaction.UseVisualStyleBackColor = true;
            this.btn_transaction.Click += new System.EventHandler(this.btn_transaction_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnl_logo.Controls.Add(this.lbl_logo);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(220, 80);
            this.pnl_logo.TabIndex = 0;
            this.pnl_logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_logo
            // 
            this.lbl_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_logo.Location = new System.Drawing.Point(45, 31);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(121, 29);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "MyBudget";
            this.lbl_logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_titlebar
            // 
            this.pnl_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnl_titlebar.Controls.Add(this.btn_minimize);
            this.pnl_titlebar.Controls.Add(this.btn_maximize);
            this.pnl_titlebar.Controls.Add(this.btn_close);
            this.pnl_titlebar.Controls.Add(this.lbl_title);
            this.pnl_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titlebar.Location = new System.Drawing.Point(220, 0);
            this.pnl_titlebar.Name = "pnl_titlebar";
            this.pnl_titlebar.Size = new System.Drawing.Size(1028, 80);
            this.pnl_titlebar.TabIndex = 7;
            this.pnl_titlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.pnl_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titlebar_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(926, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximize.ForeColor = System.Drawing.Color.White;
            this.btn_maximize.Location = new System.Drawing.Point(962, 0);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(30, 30);
            this.btn_maximize.TabIndex = 1;
            this.btn_maximize.Text = "[]";
            this.btn_maximize.UseVisualStyleBackColor = true;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(998, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(476, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(112, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "HOME";
            // 
            // pnl_container
            // 
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(220, 80);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1028, 567);
            this.pnl_container.TabIndex = 8;
            this.pnl_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_container_Paint);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 647);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.pnl_titlebar);
            this.Controls.Add(this.pnl_menu);
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeView";
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            this.pnl_titlebar.ResumeLayout(false);
            this.pnl_titlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_transaction;
        private System.Windows.Forms.Panel pnl_titlebar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Panel pnl_container;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_budget;
    }
}
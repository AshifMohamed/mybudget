namespace MyBudget.Views.Transaction
{
    partial class TransactionView
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
            this.btn_load = new MyBudget.Framework.Controls.MyBudgetButton();
            this.pnl_date_container = new System.Windows.Forms.Panel();
            this.pnl_date_filter = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.btn_addTransaction = new MyBudget.Framework.Controls.MyBudgetButton();
            this.pnl_datagrid = new System.Windows.Forms.Panel();
            this.grid_transaction = new MyBudget.Framework.Controls.MyBudgetDataGrid();
            this.pnl_control.SuspendLayout();
            this.pnl_date_container.SuspendLayout();
            this.pnl_date_filter.SuspendLayout();
            this.pnl_datagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_control
            // 
            this.pnl_control.Controls.Add(this.btn_load);
            this.pnl_control.Controls.Add(this.pnl_date_container);
            this.pnl_control.Controls.Add(this.cmb_filter);
            this.pnl_control.Controls.Add(this.btn_addTransaction);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_control.Location = new System.Drawing.Point(0, 0);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(944, 140);
            this.pnl_control.TabIndex = 0;
            this.pnl_control.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_control_Paint);
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.BackColor = System.Drawing.Color.White;
            this.btn_load.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_load.BorderRadius = 5;
            this.btn_load.BorderSize = 2;
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.ForeColor = System.Drawing.Color.Black;
            this.btn_load.Location = new System.Drawing.Point(507, 85);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(100, 40);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // pnl_date_container
            // 
            this.pnl_date_container.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnl_date_container.Controls.Add(this.pnl_date_filter);
            this.pnl_date_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_date_container.Location = new System.Drawing.Point(624, 0);
            this.pnl_date_container.Name = "pnl_date_container";
            this.pnl_date_container.Size = new System.Drawing.Size(320, 140);
            this.pnl_date_container.TabIndex = 5;
            // 
            // pnl_date_filter
            // 
            this.pnl_date_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnl_date_filter.ColumnCount = 2;
            this.pnl_date_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnl_date_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnl_date_filter.Controls.Add(this.lbl_end, 0, 1);
            this.pnl_date_filter.Controls.Add(this.lbl_start, 0, 0);
            this.pnl_date_filter.Controls.Add(this.date_start, 1, 0);
            this.pnl_date_filter.Controls.Add(this.date_end, 1, 1);
            this.pnl_date_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_date_filter.Location = new System.Drawing.Point(0, 0);
            this.pnl_date_filter.Name = "pnl_date_filter";
            this.pnl_date_filter.RowCount = 2;
            this.pnl_date_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_date_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_date_filter.Size = new System.Drawing.Size(320, 140);
            this.pnl_date_filter.TabIndex = 4;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_end.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_end.Location = new System.Drawing.Point(3, 70);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(58, 70);
            this.lbl_end.TabIndex = 5;
            this.lbl_end.Text = "End";
            this.lbl_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_start.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_start.Location = new System.Drawing.Point(3, 0);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(58, 70);
            this.lbl_start.TabIndex = 4;
            this.lbl_start.Text = "Start";
            this.lbl_start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date_start
            // 
            this.date_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_start.Location = new System.Drawing.Point(67, 3);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(250, 26);
            this.date_start.TabIndex = 3;
            // 
            // date_end
            // 
            this.date_end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_end.Location = new System.Drawing.Point(67, 73);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(250, 26);
            this.date_end.TabIndex = 2;
            // 
            // cmb_filter
            // 
            this.cmb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.Location = new System.Drawing.Point(417, 23);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(190, 28);
            this.cmb_filter.TabIndex = 3;
            this.cmb_filter.SelectedIndexChanged += new System.EventHandler(this.cmb_filter_SelectedIndexChanged);
            // 
            // btn_addTransaction
            // 
            this.btn_addTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addTransaction.BackColor = System.Drawing.Color.White;
            this.btn_addTransaction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_addTransaction.BorderRadius = 5;
            this.btn_addTransaction.BorderSize = 2;
            this.btn_addTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addTransaction.FlatAppearance.BorderSize = 0;
            this.btn_addTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTransaction.ForeColor = System.Drawing.Color.Black;
            this.btn_addTransaction.Location = new System.Drawing.Point(24, 85);
            this.btn_addTransaction.Name = "btn_addTransaction";
            this.btn_addTransaction.Size = new System.Drawing.Size(100, 40);
            this.btn_addTransaction.TabIndex = 2;
            this.btn_addTransaction.Text = "+ Add";
            this.btn_addTransaction.UseVisualStyleBackColor = false;
            this.btn_addTransaction.Click += new System.EventHandler(this.btn_addTransaction_Click);
            // 
            // pnl_datagrid
            // 
            this.pnl_datagrid.Controls.Add(this.grid_transaction);
            this.pnl_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_datagrid.Location = new System.Drawing.Point(0, 140);
            this.pnl_datagrid.Name = "pnl_datagrid";
            this.pnl_datagrid.Size = new System.Drawing.Size(944, 375);
            this.pnl_datagrid.TabIndex = 1;
            // 
            // grid_transaction
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.grid_transaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_transaction.BackgroundColor = System.Drawing.Color.White;
            this.grid_transaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_transaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_transaction.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_transaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_transaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_transaction.EnableHeadersVisualStyles = false;
            this.grid_transaction.GridColor = System.Drawing.Color.White;
            this.grid_transaction.Location = new System.Drawing.Point(0, 0);
            this.grid_transaction.Name = "grid_transaction";
            this.grid_transaction.ReadOnly = true;
            this.grid_transaction.RowHeadersWidth = 62;
            this.grid_transaction.RowTemplate.Height = 28;
            this.grid_transaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_transaction.Size = new System.Drawing.Size(944, 375);
            this.grid_transaction.TabIndex = 0;
            this.grid_transaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_transaction_CellClick);
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 515);
            this.Controls.Add(this.pnl_datagrid);
            this.Controls.Add(this.pnl_control);
            this.Name = "TransactionView";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionView_Load);
            this.pnl_control.ResumeLayout(false);
            this.pnl_date_container.ResumeLayout(false);
            this.pnl_date_filter.ResumeLayout(false);
            this.pnl_date_filter.PerformLayout();
            this.pnl_datagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_transaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_control;
        private System.Windows.Forms.Panel pnl_datagrid;
        private Framework.Controls.MyBudgetButton btn_addTransaction;
        private Framework.Controls.MyBudgetDataGrid grid_transaction;
        private System.Windows.Forms.ComboBox cmb_filter;
        private System.Windows.Forms.Panel pnl_date_container;
        private System.Windows.Forms.TableLayoutPanel pnl_date_filter;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.DateTimePicker date_end;
        private Framework.Controls.MyBudgetButton btn_load;
    }
}
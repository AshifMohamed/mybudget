namespace MyBudget.Views
{
    partial class DashboardView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart_transaction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_chart_container = new System.Windows.Forms.Panel();
            this.pnl_chart_transaction_filter = new System.Windows.Forms.Panel();
            this.pntl_filter_btn_container = new System.Windows.Forms.Panel();
            this.btn_daily = new System.Windows.Forms.Button();
            this.btn_weekly = new System.Windows.Forms.Button();
            this.btn_monthly = new System.Windows.Forms.Button();
            this.pnl_date_filter = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.pnl_balance_container = new System.Windows.Forms.Panel();
            this.pnl_forecast = new System.Windows.Forms.Panel();
            this.lbl_forecast_expense = new System.Windows.Forms.Label();
            this.pnl_actual = new System.Windows.Forms.Panel();
            this.lbl_forecast_Income = new System.Windows.Forms.Label();
            this.pnl_labels = new System.Windows.Forms.Panel();
            this.lbl_today = new System.Windows.Forms.Label();
            this.lbl_forecast_title = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.pnl_category_chart = new System.Windows.Forms.Panel();
            this.chart_category = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_forecast_income_title = new System.Windows.Forms.Label();
            this.lbl_forecast_expense_title = new System.Windows.Forms.Label();
            this.pnl_actual_balance_container = new System.Windows.Forms.Panel();
            this.pnl_actual_expense = new System.Windows.Forms.Panel();
            this.lbl_actual_expense_title = new System.Windows.Forms.Label();
            this.lbl_actual_expense = new System.Windows.Forms.Label();
            this.pnl_actual_income = new System.Windows.Forms.Panel();
            this.lbl_actual_income_title = new System.Windows.Forms.Label();
            this.lbl_actual_income = new System.Windows.Forms.Label();
            this.pnl_actual_balalce_title = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_actual_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_transaction)).BeginInit();
            this.pnl_chart_container.SuspendLayout();
            this.pnl_chart_transaction_filter.SuspendLayout();
            this.pntl_filter_btn_container.SuspendLayout();
            this.pnl_date_filter.SuspendLayout();
            this.pnl_balance_container.SuspendLayout();
            this.pnl_forecast.SuspendLayout();
            this.pnl_actual.SuspendLayout();
            this.pnl_labels.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.pnl_category_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_category)).BeginInit();
            this.pnl_actual_balance_container.SuspendLayout();
            this.pnl_actual_expense.SuspendLayout();
            this.pnl_actual_income.SuspendLayout();
            this.pnl_actual_balalce_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_transaction
            // 
            this.chart_transaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea3.Name = "ChartArea1";
            this.chart_transaction.ChartAreas.Add(chartArea3);
            this.chart_transaction.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_transaction.Legends.Add(legend3);
            this.chart_transaction.Location = new System.Drawing.Point(0, 0);
            this.chart_transaction.Name = "chart_transaction";
            this.chart_transaction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_transaction.Size = new System.Drawing.Size(1027, 395);
            this.chart_transaction.TabIndex = 0;
            this.chart_transaction.Text = "chart1";
            // 
            // pnl_chart_container
            // 
            this.pnl_chart_container.Controls.Add(this.chart_transaction);
            this.pnl_chart_container.Controls.Add(this.pnl_chart_transaction_filter);
            this.pnl_chart_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_chart_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_chart_container.Name = "pnl_chart_container";
            this.pnl_chart_container.Size = new System.Drawing.Size(1327, 395);
            this.pnl_chart_container.TabIndex = 1;
            // 
            // pnl_chart_transaction_filter
            // 
            this.pnl_chart_transaction_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnl_chart_transaction_filter.Controls.Add(this.pntl_filter_btn_container);
            this.pnl_chart_transaction_filter.Controls.Add(this.pnl_date_filter);
            this.pnl_chart_transaction_filter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_chart_transaction_filter.Location = new System.Drawing.Point(1027, 0);
            this.pnl_chart_transaction_filter.Name = "pnl_chart_transaction_filter";
            this.pnl_chart_transaction_filter.Size = new System.Drawing.Size(300, 395);
            this.pnl_chart_transaction_filter.TabIndex = 2;
            // 
            // pntl_filter_btn_container
            // 
            this.pntl_filter_btn_container.Controls.Add(this.btn_daily);
            this.pntl_filter_btn_container.Controls.Add(this.btn_weekly);
            this.pntl_filter_btn_container.Controls.Add(this.btn_monthly);
            this.pntl_filter_btn_container.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntl_filter_btn_container.Location = new System.Drawing.Point(0, 80);
            this.pntl_filter_btn_container.Name = "pntl_filter_btn_container";
            this.pntl_filter_btn_container.Size = new System.Drawing.Size(300, 172);
            this.pntl_filter_btn_container.TabIndex = 5;
            // 
            // btn_daily
            // 
            this.btn_daily.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_daily.FlatAppearance.BorderSize = 0;
            this.btn_daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daily.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_daily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_daily.Location = new System.Drawing.Point(0, 120);
            this.btn_daily.Name = "btn_daily";
            this.btn_daily.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_daily.Size = new System.Drawing.Size(300, 60);
            this.btn_daily.TabIndex = 4;
            this.btn_daily.Text = "Daily";
            this.btn_daily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_daily.UseVisualStyleBackColor = true;
            this.btn_daily.Click += new System.EventHandler(this.btn_daily_Click);
            // 
            // btn_weekly
            // 
            this.btn_weekly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_weekly.FlatAppearance.BorderSize = 0;
            this.btn_weekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_weekly.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_weekly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_weekly.Location = new System.Drawing.Point(0, 60);
            this.btn_weekly.Name = "btn_weekly";
            this.btn_weekly.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_weekly.Size = new System.Drawing.Size(300, 60);
            this.btn_weekly.TabIndex = 2;
            this.btn_weekly.Text = "Weekly";
            this.btn_weekly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_weekly.UseVisualStyleBackColor = true;
            this.btn_weekly.Click += new System.EventHandler(this.btn_weekly_Click);
            // 
            // btn_monthly
            // 
            this.btn_monthly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_monthly.FlatAppearance.BorderSize = 0;
            this.btn_monthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monthly.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_monthly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_monthly.Location = new System.Drawing.Point(0, 0);
            this.btn_monthly.Name = "btn_monthly";
            this.btn_monthly.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_monthly.Size = new System.Drawing.Size(300, 60);
            this.btn_monthly.TabIndex = 3;
            this.btn_monthly.Text = "Monthly";
            this.btn_monthly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_monthly.UseVisualStyleBackColor = true;
            this.btn_monthly.Click += new System.EventHandler(this.btn_monthly_Click);
            // 
            // pnl_date_filter
            // 
            this.pnl_date_filter.ColumnCount = 2;
            this.pnl_date_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnl_date_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnl_date_filter.Controls.Add(this.lbl_end, 0, 1);
            this.pnl_date_filter.Controls.Add(this.lbl_start, 0, 0);
            this.pnl_date_filter.Controls.Add(this.date_start, 1, 0);
            this.pnl_date_filter.Controls.Add(this.date_end, 1, 1);
            this.pnl_date_filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_date_filter.Location = new System.Drawing.Point(0, 0);
            this.pnl_date_filter.Name = "pnl_date_filter";
            this.pnl_date_filter.RowCount = 2;
            this.pnl_date_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_date_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_date_filter.Size = new System.Drawing.Size(300, 80);
            this.pnl_date_filter.TabIndex = 3;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_end.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_end.Location = new System.Drawing.Point(3, 40);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(54, 40);
            this.lbl_end.TabIndex = 5;
            this.lbl_end.Text = "End";
            this.lbl_end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_start.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_start.Location = new System.Drawing.Point(3, 0);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(54, 40);
            this.lbl_start.TabIndex = 4;
            this.lbl_start.Text = "Start";
            this.lbl_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_start
            // 
            this.date_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_start.Location = new System.Drawing.Point(63, 3);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(234, 26);
            this.date_start.TabIndex = 3;
            // 
            // date_end
            // 
            this.date_end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_end.Location = new System.Drawing.Point(63, 43);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(234, 26);
            this.date_end.TabIndex = 2;
            // 
            // pnl_balance_container
            // 
            this.pnl_balance_container.Controls.Add(this.pnl_forecast);
            this.pnl_balance_container.Controls.Add(this.pnl_actual);
            this.pnl_balance_container.Controls.Add(this.pnl_labels);
            this.pnl_balance_container.Location = new System.Drawing.Point(342, 24);
            this.pnl_balance_container.Name = "pnl_balance_container";
            this.pnl_balance_container.Size = new System.Drawing.Size(307, 240);
            this.pnl_balance_container.TabIndex = 2;
            // 
            // pnl_forecast
            // 
            this.pnl_forecast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.pnl_forecast.Controls.Add(this.lbl_forecast_expense_title);
            this.pnl_forecast.Controls.Add(this.lbl_forecast_expense);
            this.pnl_forecast.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_forecast.Location = new System.Drawing.Point(0, 155);
            this.pnl_forecast.Name = "pnl_forecast";
            this.pnl_forecast.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_forecast.Size = new System.Drawing.Size(307, 80);
            this.pnl_forecast.TabIndex = 4;
            // 
            // lbl_forecast_expense
            // 
            this.lbl_forecast_expense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_forecast_expense.AutoSize = true;
            this.lbl_forecast_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forecast_expense.ForeColor = System.Drawing.Color.White;
            this.lbl_forecast_expense.Location = new System.Drawing.Point(99, 46);
            this.lbl_forecast_expense.Name = "lbl_forecast_expense";
            this.lbl_forecast_expense.Size = new System.Drawing.Size(70, 25);
            this.lbl_forecast_expense.TabIndex = 0;
            this.lbl_forecast_expense.Text = "label1";
            // 
            // pnl_actual
            // 
            this.pnl_actual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnl_actual.Controls.Add(this.label_forecast_income_title);
            this.pnl_actual.Controls.Add(this.lbl_forecast_Income);
            this.pnl_actual.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_actual.Location = new System.Drawing.Point(0, 75);
            this.pnl_actual.Name = "pnl_actual";
            this.pnl_actual.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_actual.Size = new System.Drawing.Size(307, 80);
            this.pnl_actual.TabIndex = 3;
            // 
            // lbl_forecast_Income
            // 
            this.lbl_forecast_Income.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_forecast_Income.AutoSize = true;
            this.lbl_forecast_Income.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forecast_Income.ForeColor = System.Drawing.Color.White;
            this.lbl_forecast_Income.Location = new System.Drawing.Point(99, 43);
            this.lbl_forecast_Income.Name = "lbl_forecast_Income";
            this.lbl_forecast_Income.Size = new System.Drawing.Size(70, 25);
            this.lbl_forecast_Income.TabIndex = 0;
            this.lbl_forecast_Income.Text = "label1";
            // 
            // pnl_labels
            // 
            this.pnl_labels.BackColor = System.Drawing.Color.White;
            this.pnl_labels.Controls.Add(this.lbl_today);
            this.pnl_labels.Controls.Add(this.lbl_forecast_title);
            this.pnl_labels.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_labels.Location = new System.Drawing.Point(0, 0);
            this.pnl_labels.Name = "pnl_labels";
            this.pnl_labels.Size = new System.Drawing.Size(307, 75);
            this.pnl_labels.TabIndex = 3;
            // 
            // lbl_today
            // 
            this.lbl_today.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_today.AutoSize = true;
            this.lbl_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_today.ForeColor = System.Drawing.Color.Black;
            this.lbl_today.Location = new System.Drawing.Point(99, 46);
            this.lbl_today.Name = "lbl_today";
            this.lbl_today.Size = new System.Drawing.Size(76, 26);
            this.lbl_today.TabIndex = 3;
            this.lbl_today.Text = "Today";
            // 
            // lbl_forecast_title
            // 
            this.lbl_forecast_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_forecast_title.AutoSize = true;
            this.lbl_forecast_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forecast_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_forecast_title.Location = new System.Drawing.Point(69, 10);
            this.lbl_forecast_title.Name = "lbl_forecast_title";
            this.lbl_forecast_title.Size = new System.Drawing.Size(164, 25);
            this.lbl_forecast_title.TabIndex = 3;
            this.lbl_forecast_title.Text = "Forecast Balance";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Controls.Add(this.pnl_actual_balance_container);
            this.pnl_bottom.Controls.Add(this.pnl_category_chart);
            this.pnl_bottom.Controls.Add(this.pnl_balance_container);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 395);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1327, 276);
            this.pnl_bottom.TabIndex = 3;
            // 
            // pnl_category_chart
            // 
            this.pnl_category_chart.Controls.Add(this.chart_category);
            this.pnl_category_chart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_category_chart.Location = new System.Drawing.Point(831, 0);
            this.pnl_category_chart.Name = "pnl_category_chart";
            this.pnl_category_chart.Size = new System.Drawing.Size(496, 276);
            this.pnl_category_chart.TabIndex = 3;
            // 
            // chart_category
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_category.ChartAreas.Add(chartArea4);
            this.chart_category.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart_category.Legends.Add(legend4);
            this.chart_category.Location = new System.Drawing.Point(0, 0);
            this.chart_category.Name = "chart_category";
            this.chart_category.Size = new System.Drawing.Size(496, 276);
            this.chart_category.TabIndex = 0;
            this.chart_category.Text = "chart1";
            // 
            // label_forecast_income_title
            // 
            this.label_forecast_income_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_forecast_income_title.AutoSize = true;
            this.label_forecast_income_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forecast_income_title.ForeColor = System.Drawing.Color.White;
            this.label_forecast_income_title.Location = new System.Drawing.Point(85, 12);
            this.label_forecast_income_title.Name = "label_forecast_income_title";
            this.label_forecast_income_title.Size = new System.Drawing.Size(98, 25);
            this.label_forecast_income_title.TabIndex = 1;
            this.label_forecast_income_title.Text = "(Income)";
            // 
            // lbl_forecast_expense_title
            // 
            this.lbl_forecast_expense_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_forecast_expense_title.AutoSize = true;
            this.lbl_forecast_expense_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forecast_expense_title.ForeColor = System.Drawing.Color.White;
            this.lbl_forecast_expense_title.Location = new System.Drawing.Point(85, 7);
            this.lbl_forecast_expense_title.Name = "lbl_forecast_expense_title";
            this.lbl_forecast_expense_title.Size = new System.Drawing.Size(112, 25);
            this.lbl_forecast_expense_title.TabIndex = 2;
            this.lbl_forecast_expense_title.Text = "(Expense)";
            // 
            // pnl_actual_balance_container
            // 
            this.pnl_actual_balance_container.Controls.Add(this.pnl_actual_expense);
            this.pnl_actual_balance_container.Controls.Add(this.pnl_actual_income);
            this.pnl_actual_balance_container.Controls.Add(this.pnl_actual_balalce_title);
            this.pnl_actual_balance_container.Location = new System.Drawing.Point(12, 24);
            this.pnl_actual_balance_container.Name = "pnl_actual_balance_container";
            this.pnl_actual_balance_container.Size = new System.Drawing.Size(307, 240);
            this.pnl_actual_balance_container.TabIndex = 5;
            // 
            // pnl_actual_expense
            // 
            this.pnl_actual_expense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.pnl_actual_expense.Controls.Add(this.lbl_actual_expense_title);
            this.pnl_actual_expense.Controls.Add(this.lbl_actual_expense);
            this.pnl_actual_expense.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_actual_expense.Location = new System.Drawing.Point(0, 155);
            this.pnl_actual_expense.Name = "pnl_actual_expense";
            this.pnl_actual_expense.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_actual_expense.Size = new System.Drawing.Size(307, 80);
            this.pnl_actual_expense.TabIndex = 4;
            // 
            // lbl_actual_expense_title
            // 
            this.lbl_actual_expense_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_actual_expense_title.AutoSize = true;
            this.lbl_actual_expense_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actual_expense_title.ForeColor = System.Drawing.Color.White;
            this.lbl_actual_expense_title.Location = new System.Drawing.Point(85, 7);
            this.lbl_actual_expense_title.Name = "lbl_actual_expense_title";
            this.lbl_actual_expense_title.Size = new System.Drawing.Size(112, 25);
            this.lbl_actual_expense_title.TabIndex = 2;
            this.lbl_actual_expense_title.Text = "(Expense)";
            // 
            // lbl_actual_expense
            // 
            this.lbl_actual_expense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_actual_expense.AutoSize = true;
            this.lbl_actual_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actual_expense.ForeColor = System.Drawing.Color.White;
            this.lbl_actual_expense.Location = new System.Drawing.Point(99, 46);
            this.lbl_actual_expense.Name = "lbl_actual_expense";
            this.lbl_actual_expense.Size = new System.Drawing.Size(70, 25);
            this.lbl_actual_expense.TabIndex = 0;
            this.lbl_actual_expense.Text = "label1";
            // 
            // pnl_actual_income
            // 
            this.pnl_actual_income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnl_actual_income.Controls.Add(this.lbl_actual_income_title);
            this.pnl_actual_income.Controls.Add(this.lbl_actual_income);
            this.pnl_actual_income.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_actual_income.Location = new System.Drawing.Point(0, 75);
            this.pnl_actual_income.Name = "pnl_actual_income";
            this.pnl_actual_income.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_actual_income.Size = new System.Drawing.Size(307, 80);
            this.pnl_actual_income.TabIndex = 3;
            // 
            // lbl_actual_income_title
            // 
            this.lbl_actual_income_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_actual_income_title.AutoSize = true;
            this.lbl_actual_income_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actual_income_title.ForeColor = System.Drawing.Color.White;
            this.lbl_actual_income_title.Location = new System.Drawing.Point(85, 12);
            this.lbl_actual_income_title.Name = "lbl_actual_income_title";
            this.lbl_actual_income_title.Size = new System.Drawing.Size(98, 25);
            this.lbl_actual_income_title.TabIndex = 1;
            this.lbl_actual_income_title.Text = "(Income)";
            // 
            // lbl_actual_income
            // 
            this.lbl_actual_income.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_actual_income.AutoSize = true;
            this.lbl_actual_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actual_income.ForeColor = System.Drawing.Color.White;
            this.lbl_actual_income.Location = new System.Drawing.Point(99, 43);
            this.lbl_actual_income.Name = "lbl_actual_income";
            this.lbl_actual_income.Size = new System.Drawing.Size(70, 25);
            this.lbl_actual_income.TabIndex = 0;
            this.lbl_actual_income.Text = "label1";
            // 
            // pnl_actual_balalce_title
            // 
            this.pnl_actual_balalce_title.BackColor = System.Drawing.Color.White;
            this.pnl_actual_balalce_title.Controls.Add(this.label5);
            this.pnl_actual_balalce_title.Controls.Add(this.lbl_actual_title);
            this.pnl_actual_balalce_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_actual_balalce_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_actual_balalce_title.Name = "pnl_actual_balalce_title";
            this.pnl_actual_balalce_title.Size = new System.Drawing.Size(307, 75);
            this.pnl_actual_balalce_title.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(99, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Today";
            // 
            // lbl_actual_title
            // 
            this.lbl_actual_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_actual_title.AutoSize = true;
            this.lbl_actual_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actual_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_actual_title.Location = new System.Drawing.Point(69, 10);
            this.lbl_actual_title.Name = "lbl_actual_title";
            this.lbl_actual_title.Size = new System.Drawing.Size(143, 25);
            this.lbl_actual_title.TabIndex = 3;
            this.lbl_actual_title.Text = "Actual Balance";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 671);
            this.Controls.Add(this.pnl_chart_container);
            this.Controls.Add(this.pnl_bottom);
            this.Name = "DashboardView";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_transaction)).EndInit();
            this.pnl_chart_container.ResumeLayout(false);
            this.pnl_chart_transaction_filter.ResumeLayout(false);
            this.pntl_filter_btn_container.ResumeLayout(false);
            this.pnl_date_filter.ResumeLayout(false);
            this.pnl_date_filter.PerformLayout();
            this.pnl_balance_container.ResumeLayout(false);
            this.pnl_forecast.ResumeLayout(false);
            this.pnl_forecast.PerformLayout();
            this.pnl_actual.ResumeLayout(false);
            this.pnl_actual.PerformLayout();
            this.pnl_labels.ResumeLayout(false);
            this.pnl_labels.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_category_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_category)).EndInit();
            this.pnl_actual_balance_container.ResumeLayout(false);
            this.pnl_actual_expense.ResumeLayout(false);
            this.pnl_actual_expense.PerformLayout();
            this.pnl_actual_income.ResumeLayout(false);
            this.pnl_actual_income.PerformLayout();
            this.pnl_actual_balalce_title.ResumeLayout(false);
            this.pnl_actual_balalce_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_transaction;
        private System.Windows.Forms.Panel pnl_chart_container;
        private System.Windows.Forms.Panel pnl_chart_transaction_filter;
        private System.Windows.Forms.Button btn_daily;
        private System.Windows.Forms.Button btn_weekly;
        private System.Windows.Forms.Button btn_monthly;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.TableLayoutPanel pnl_date_filter;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Panel pntl_filter_btn_container;
        private System.Windows.Forms.Panel pnl_balance_container;
        private System.Windows.Forms.Panel pnl_labels;
        private System.Windows.Forms.Label lbl_forecast_title;
        private System.Windows.Forms.Label lbl_today;
        private System.Windows.Forms.Panel pnl_actual;
        private System.Windows.Forms.Panel pnl_forecast;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_category_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_category;
        private System.Windows.Forms.Label lbl_forecast_expense;
        private System.Windows.Forms.Label lbl_forecast_Income;
        private System.Windows.Forms.Label lbl_forecast_expense_title;
        private System.Windows.Forms.Label label_forecast_income_title;
        private System.Windows.Forms.Panel pnl_actual_balance_container;
        private System.Windows.Forms.Panel pnl_actual_expense;
        private System.Windows.Forms.Label lbl_actual_expense_title;
        private System.Windows.Forms.Label lbl_actual_expense;
        private System.Windows.Forms.Panel pnl_actual_income;
        private System.Windows.Forms.Label lbl_actual_income_title;
        private System.Windows.Forms.Label lbl_actual_income;
        private System.Windows.Forms.Panel pnl_actual_balalce_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_actual_title;
    }
}
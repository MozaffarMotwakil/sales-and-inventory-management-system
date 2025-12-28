namespace SIMS.WinForms.Dashboard
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodayNetSales = new System.Windows.Forms.Label();
            this.lblTodayTotalSalesReturn = new System.Windows.Forms.Label();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTodayNetPurchases = new System.Windows.Forms.Label();
            this.lblTodayPurchasesReturn = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTodayPurchases = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTodayProfitRate = new System.Windows.Forms.Label();
            this.lblTodayTotalProfits = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvRunningLowProducts = new System.Windows.Forms.DataGridView();
            this.chartDepartmentalSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProfitsAndExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTodayPurchasesInvoices = new System.Windows.Forms.Label();
            this.lblTodaySalesInvoices = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRunningLowProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartmentalSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfitsAndExpenses)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTodayNetSales);
            this.panel1.Controls.Add(this.lblTodayTotalSalesReturn);
            this.panel1.Controls.Add(this.lblTodaySales);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 126);
            this.panel1.TabIndex = 0;
            // 
            // lblTodayNetSales
            // 
            this.lblTodayNetSales.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayNetSales.Location = new System.Drawing.Point(3, 98);
            this.lblTodayNetSales.Name = "lblTodayNetSales";
            this.lblTodayNetSales.Size = new System.Drawing.Size(145, 25);
            this.lblTodayNetSales.TabIndex = 1;
            this.lblTodayNetSales.Text = "999.999.999.99 ج.س";
            this.lblTodayNetSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayTotalSalesReturn
            // 
            this.lblTodayTotalSalesReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTotalSalesReturn.Location = new System.Drawing.Point(3, 74);
            this.lblTodayTotalSalesReturn.Name = "lblTodayTotalSalesReturn";
            this.lblTodayTotalSalesReturn.Size = new System.Drawing.Size(145, 25);
            this.lblTodayTotalSalesReturn.TabIndex = 1;
            this.lblTodayTotalSalesReturn.Text = "999.999.999.99 ج.س";
            this.lblTodayTotalSalesReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.Location = new System.Drawing.Point(3, 45);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(261, 25);
            this.lblTodaySales.TabIndex = 1;
            this.lblTodaySales.Text = "999.999.999.99 ج.س";
            this.lblTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "صافي المبيعات:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "المرتجعات:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "مبيعات اليوم";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SIMS.WinForms.Properties.Resources.view_details;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lblTodayNetPurchases);
            this.panel9.Controls.Add(this.lblTodayPurchasesReturn);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Controls.Add(this.lblTodayPurchases);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.button9);
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Location = new System.Drawing.Point(292, 49);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(269, 126);
            this.panel9.TabIndex = 0;
            // 
            // lblTodayNetPurchases
            // 
            this.lblTodayNetPurchases.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayNetPurchases.Location = new System.Drawing.Point(1, 98);
            this.lblTodayNetPurchases.Name = "lblTodayNetPurchases";
            this.lblTodayNetPurchases.Size = new System.Drawing.Size(145, 25);
            this.lblTodayNetPurchases.TabIndex = 3;
            this.lblTodayNetPurchases.Text = "999.999.999.99 ج.س";
            this.lblTodayNetPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayPurchasesReturn
            // 
            this.lblTodayPurchasesReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPurchasesReturn.Location = new System.Drawing.Point(1, 74);
            this.lblTodayPurchasesReturn.Name = "lblTodayPurchasesReturn";
            this.lblTodayPurchasesReturn.Size = new System.Drawing.Size(145, 25);
            this.lblTodayPurchasesReturn.TabIndex = 4;
            this.lblTodayPurchasesReturn.Text = "999.999.999.99 ج.س";
            this.lblTodayPurchasesReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(146, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "صافي المشتريات:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(189, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "المرتجعات:";
            // 
            // lblTodayPurchases
            // 
            this.lblTodayPurchases.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPurchases.Location = new System.Drawing.Point(3, 45);
            this.lblTodayPurchases.Name = "lblTodayPurchases";
            this.lblTodayPurchases.Size = new System.Drawing.Size(261, 25);
            this.lblTodayPurchases.TabIndex = 1;
            this.lblTodayPurchases.Text = "999.999.999.99 ج.س";
            this.lblTodayPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "مشتريات اليوم";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::SIMS.WinForms.Properties.Resources.view_details;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(3, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 39);
            this.button9.TabIndex = 1;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTodayProfitRate);
            this.panel4.Controls.Add(this.lblTodayTotalProfits);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(12, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 126);
            this.panel4.TabIndex = 0;
            // 
            // lblTodayProfitRate
            // 
            this.lblTodayProfitRate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayProfitRate.Location = new System.Drawing.Point(3, 100);
            this.lblTodayProfitRate.Name = "lblTodayProfitRate";
            this.lblTodayProfitRate.Size = new System.Drawing.Size(261, 19);
            this.lblTodayProfitRate.TabIndex = 1;
            this.lblTodayProfitRate.Text = "100.00%";
            this.lblTodayProfitRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayTotalProfits
            // 
            this.lblTodayTotalProfits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTotalProfits.Location = new System.Drawing.Point(3, 45);
            this.lblTodayTotalProfits.Name = "lblTodayTotalProfits";
            this.lblTodayTotalProfits.Size = new System.Drawing.Size(261, 25);
            this.lblTodayTotalProfits.TabIndex = 1;
            this.lblTodayTotalProfits.Text = "999.999.999.99 ج.س";
            this.lblTodayTotalProfits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SIMS.WinForms.Properties.Resources.total_profits;
            this.pictureBox5.Location = new System.Drawing.Point(217, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "نسبة الربح:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(78, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "أرباح اليوم";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::SIMS.WinForms.Properties.Resources.view_details;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 39);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "نظرة عامة";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(562, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(362, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "البضاعة التي وصلت إلى حد إعادة الطلب";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 319);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "الأرباح والخسائر";
            // 
            // dgvRunningLowProducts
            // 
            this.dgvRunningLowProducts.AllowUserToAddRows = false;
            this.dgvRunningLowProducts.AllowUserToDeleteRows = false;
            this.dgvRunningLowProducts.AllowUserToOrderColumns = true;
            this.dgvRunningLowProducts.AllowUserToResizeColumns = false;
            this.dgvRunningLowProducts.AllowUserToResizeRows = false;
            this.dgvRunningLowProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRunningLowProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvRunningLowProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRunningLowProducts.Location = new System.Drawing.Point(567, 49);
            this.dgvRunningLowProducts.Name = "dgvRunningLowProducts";
            this.dgvRunningLowProducts.ReadOnly = true;
            this.dgvRunningLowProducts.Size = new System.Drawing.Size(541, 258);
            this.dgvRunningLowProducts.TabIndex = 2;
            // 
            // chartDepartmentalSales
            // 
            this.chartDepartmentalSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDepartmentalSales.BackColor = System.Drawing.Color.LightSeaGreen;
            chartArea7.Name = "ChartArea1";
            this.chartDepartmentalSales.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartDepartmentalSales.Legends.Add(legend7);
            this.chartDepartmentalSales.Location = new System.Drawing.Point(567, 357);
            this.chartDepartmentalSales.Name = "chartDepartmentalSales";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartDepartmentalSales.Series.Add(series10);
            this.chartDepartmentalSales.Size = new System.Drawing.Size(541, 332);
            this.chartDepartmentalSales.TabIndex = 4;
            this.chartDepartmentalSales.Text = "chart1";
            // 
            // chartProfitsAndExpenses
            // 
            this.chartProfitsAndExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartProfitsAndExpenses.BackColor = System.Drawing.Color.LightSeaGreen;
            chartArea8.Name = "ChartArea1";
            this.chartProfitsAndExpenses.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartProfitsAndExpenses.Legends.Add(legend8);
            this.chartProfitsAndExpenses.Location = new System.Drawing.Point(12, 357);
            this.chartProfitsAndExpenses.Name = "chartProfitsAndExpenses";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.LimeGreen;
            series11.Legend = "Legend1";
            series11.Name = "Profits";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.Red;
            series12.Legend = "Legend1";
            series12.Name = "Expenses";
            this.chartProfitsAndExpenses.Series.Add(series11);
            this.chartProfitsAndExpenses.Series.Add(series12);
            this.chartProfitsAndExpenses.Size = new System.Drawing.Size(549, 332);
            this.chartProfitsAndExpenses.TabIndex = 5;
            this.chartProfitsAndExpenses.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "مبيعات الأصناف المختلفة";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTodayPurchasesInvoices);
            this.panel3.Controls.Add(this.lblTodaySalesInvoices);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(292, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 126);
            this.panel3.TabIndex = 29;
            // 
            // lblTodayPurchasesInvoices
            // 
            this.lblTodayPurchasesInvoices.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPurchasesInvoices.Location = new System.Drawing.Point(3, 82);
            this.lblTodayPurchasesInvoices.Name = "lblTodayPurchasesInvoices";
            this.lblTodayPurchasesInvoices.Size = new System.Drawing.Size(261, 37);
            this.lblTodayPurchasesInvoices.TabIndex = 1;
            this.lblTodayPurchasesInvoices.Text = "1500 فاتورة شراء";
            this.lblTodayPurchasesInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodaySalesInvoices
            // 
            this.lblTodaySalesInvoices.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySalesInvoices.Location = new System.Drawing.Point(3, 45);
            this.lblTodaySalesInvoices.Name = "lblTodaySalesInvoices";
            this.lblTodaySalesInvoices.Size = new System.Drawing.Size(261, 37);
            this.lblTodaySalesInvoices.TabIndex = 1;
            this.lblTodaySalesInvoices.Text = "1500 فاتورة بيع";
            this.lblTodaySalesInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SIMS.WinForms.Properties.Resources.Invoice;
            this.pictureBox3.Location = new System.Drawing.Point(217, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "فواتير اليوم";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::SIMS.WinForms.Properties.Resources.view_details;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 39);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chartProfitsAndExpenses);
            this.Controls.Add(this.chartDepartmentalSales);
            this.Controls.Add(this.dgvRunningLowProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لمحة سريعة";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRunningLowProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartmentalSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfitsAndExpenses)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTodayTotalProfits;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvRunningLowProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepartmentalSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProfitsAndExpenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTodaySalesInvoices;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTodayPurchases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblTodayPurchasesInvoices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTodayNetSales;
        private System.Windows.Forms.Label lblTodayTotalSalesReturn;
        private System.Windows.Forms.Label lblTodayNetPurchases;
        private System.Windows.Forms.Label lblTodayPurchasesReturn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTodayProfitRate;
    }
}
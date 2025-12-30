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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTodayNetSales = new System.Windows.Forms.Label();
            this.lblTodayTotalSalesReturn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTodayNetPurchases = new System.Windows.Forms.Label();
            this.lblTodayPurchasesReturn = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTodayPurchases = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTodaySalesInvoices = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTodayProfitRate = new System.Windows.Forms.Label();
            this.lblTodayTotalProfits = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvRunningLowProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GoToInventoriesListtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowStockTransactionsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuppliedItemsLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartCategoriesSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCategorySalesTextHeder = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTodayPurchasesInvoices = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRunningLowProducts)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoriesSales)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTodaySales);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 126);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.Location = new System.Drawing.Point(3, 45);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(261, 37);
            this.lblTodaySales.TabIndex = 1;
            this.lblTodaySales.Text = "999.999.999.99 ج.س";
            this.lblTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodaySales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
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
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
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
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
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
            this.lblTodayNetSales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // lblTodayTotalSalesReturn
            // 
            this.lblTodayTotalSalesReturn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTotalSalesReturn.Location = new System.Drawing.Point(3, 45);
            this.lblTodayTotalSalesReturn.Name = "lblTodayTotalSalesReturn";
            this.lblTodayTotalSalesReturn.Size = new System.Drawing.Size(261, 37);
            this.lblTodayTotalSalesReturn.TabIndex = 1;
            this.lblTodayTotalSalesReturn.Text = "999.999.999.99 ج.س";
            this.lblTodayTotalSalesReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodayTotalSalesReturn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "صافي المبيعات:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lblTodayNetSales);
            this.panel9.Controls.Add(this.lblTodayTotalSalesReturn);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(287, 49);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(269, 126);
            this.panel9.TabIndex = 0;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "مرتجعات المبيعات";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
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
            this.lblTodayNetPurchases.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // lblTodayPurchasesReturn
            // 
            this.lblTodayPurchasesReturn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPurchasesReturn.Location = new System.Drawing.Point(3, 45);
            this.lblTodayPurchasesReturn.Name = "lblTodayPurchasesReturn";
            this.lblTodayPurchasesReturn.Size = new System.Drawing.Size(261, 37);
            this.lblTodayPurchasesReturn.TabIndex = 4;
            this.lblTodayPurchasesReturn.Text = "999.999.999.99 ج.س";
            this.lblTodayPurchasesReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodayPurchasesReturn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
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
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // lblTodayPurchases
            // 
            this.lblTodayPurchases.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPurchases.Location = new System.Drawing.Point(3, 47);
            this.lblTodayPurchases.Name = "lblTodayPurchases";
            this.lblTodayPurchases.Size = new System.Drawing.Size(261, 37);
            this.lblTodayPurchases.TabIndex = 1;
            this.lblTodayPurchases.Text = "999.999.999.99 ج.س";
            this.lblTodayPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodayPurchases.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "مشتريات اليوم";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.lblTodaySalesInvoices);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(12, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 126);
            this.panel4.TabIndex = 0;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SIMS.WinForms.Properties.Resources.Invoice;
            this.pictureBox5.Location = new System.Drawing.Point(217, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // lblTodaySalesInvoices
            // 
            this.lblTodaySalesInvoices.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySalesInvoices.Location = new System.Drawing.Point(3, 45);
            this.lblTodaySalesInvoices.Name = "lblTodaySalesInvoices";
            this.lblTodaySalesInvoices.Size = new System.Drawing.Size(261, 37);
            this.lblTodaySalesInvoices.TabIndex = 1;
            this.lblTodaySalesInvoices.Text = "1500";
            this.lblTodaySalesInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodaySalesInvoices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "فواتير المبيعات";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // lblTodayProfitRate
            // 
            this.lblTodayProfitRate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayProfitRate.Location = new System.Drawing.Point(3, 45);
            this.lblTodayProfitRate.Name = "lblTodayProfitRate";
            this.lblTodayProfitRate.Size = new System.Drawing.Size(261, 37);
            this.lblTodayProfitRate.TabIndex = 1;
            this.lblTodayProfitRate.Text = "100.00%";
            this.lblTodayProfitRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodayProfitRate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // lblTodayTotalProfits
            // 
            this.lblTodayTotalProfits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTotalProfits.Location = new System.Drawing.Point(3, 45);
            this.lblTodayTotalProfits.Name = "lblTodayTotalProfits";
            this.lblTodayTotalProfits.Size = new System.Drawing.Size(261, 37);
            this.lblTodayTotalProfits.TabIndex = 1;
            this.lblTodayTotalProfits.Text = "999.999.999.99 ج.س";
            this.lblTodayTotalProfits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodayTotalProfits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "نسبة الربح";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
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
            this.label15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "نظرة عامة على الأداء اليومي";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(362, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "البضاعة التي وصلت إلى حد إعادة الطلب";
            this.label16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // dgvRunningLowProducts
            // 
            this.dgvRunningLowProducts.AllowUserToAddRows = false;
            this.dgvRunningLowProducts.AllowUserToDeleteRows = false;
            this.dgvRunningLowProducts.AllowUserToResizeColumns = false;
            this.dgvRunningLowProducts.AllowUserToResizeRows = false;
            this.dgvRunningLowProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRunningLowProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRunningLowProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRunningLowProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRunningLowProducts.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRunningLowProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRunningLowProducts.Location = new System.Drawing.Point(12, 357);
            this.dgvRunningLowProducts.MultiSelect = false;
            this.dgvRunningLowProducts.Name = "dgvRunningLowProducts";
            this.dgvRunningLowProducts.ReadOnly = true;
            this.dgvRunningLowProducts.RowHeadersVisible = false;
            this.dgvRunningLowProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRunningLowProducts.Size = new System.Drawing.Size(544, 332);
            this.dgvRunningLowProducts.TabIndex = 2;
            this.dgvRunningLowProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRunningLowProducts_DataBindingComplete);
            this.dgvRunningLowProducts.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvRunningLowProducts_RowPrePaint);
            this.dgvRunningLowProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvRunningLowProducts_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoToInventoriesListtoolStripMenuItem,
            this.ShowStockTransactionsListToolStripMenuItem,
            this.SuppliedItemsLogToolStripMenuItem});
            this.contextMenuStrip.Name = "SuppliersContextMenuStrip";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(201, 118);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            this.contextMenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // GoToInventoriesListtoolStripMenuItem
            // 
            this.GoToInventoriesListtoolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.warehouse;
            this.GoToInventoriesListtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GoToInventoriesListtoolStripMenuItem.Name = "GoToInventoriesListtoolStripMenuItem";
            this.GoToInventoriesListtoolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.GoToInventoriesListtoolStripMenuItem.Text = "الإنتقال لقائمة المخزون";
            this.GoToInventoriesListtoolStripMenuItem.Click += new System.EventHandler(this.GoToInventoriesListtoolStripMenuItem_Click);
            this.GoToInventoriesListtoolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // ShowStockTransactionsListToolStripMenuItem
            // 
            this.ShowStockTransactionsListToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.stock_market;
            this.ShowStockTransactionsListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowStockTransactionsListToolStripMenuItem.Name = "ShowStockTransactionsListToolStripMenuItem";
            this.ShowStockTransactionsListToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.ShowStockTransactionsListToolStripMenuItem.Text = "عرض حركات المخزون";
            this.ShowStockTransactionsListToolStripMenuItem.Click += new System.EventHandler(this.ShowStockTransactionsListToolStripMenuItem_Click);
            this.ShowStockTransactionsListToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // SuppliedItemsLogToolStripMenuItem
            // 
            this.SuppliedItemsLogToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supplied_items_32;
            this.SuppliedItemsLogToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SuppliedItemsLogToolStripMenuItem.Name = "SuppliedItemsLogToolStripMenuItem";
            this.SuppliedItemsLogToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.SuppliedItemsLogToolStripMenuItem.Text = "عرض سجل التوريد";
            this.SuppliedItemsLogToolStripMenuItem.Click += new System.EventHandler(this.SuppliedItemsLogToolStripMenuItem_Click);
            this.SuppliedItemsLogToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // chartCategoriesSales
            // 
            this.chartCategoriesSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCategoriesSales.BackColor = System.Drawing.Color.LightSeaGreen;
            chartArea1.Name = "ChartArea1";
            this.chartCategoriesSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCategoriesSales.Legends.Add(legend1);
            this.chartCategoriesSales.Location = new System.Drawing.Point(564, 357);
            this.chartCategoriesSales.Name = "chartCategoriesSales";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCategoriesSales.Series.Add(series1);
            this.chartCategoriesSales.Size = new System.Drawing.Size(544, 332);
            this.chartCategoriesSales.TabIndex = 4;
            this.chartCategoriesSales.Text = "chart1";
            this.chartCategoriesSales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // lblCategorySalesTextHeder
            // 
            this.lblCategorySalesTextHeder.AutoSize = true;
            this.lblCategorySalesTextHeder.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorySalesTextHeder.Location = new System.Drawing.Point(562, 319);
            this.lblCategorySalesTextHeder.Name = "lblCategorySalesTextHeder";
            this.lblCategorySalesTextHeder.Size = new System.Drawing.Size(366, 25);
            this.lblCategorySalesTextHeder.TabIndex = 1;
            this.lblCategorySalesTextHeder.Text = "مبيعات الأصناف المختلفة (الشهر الحالي)";
            this.lblCategorySalesTextHeder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblTodayPurchasesInvoices);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(287, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 126);
            this.panel3.TabIndex = 29;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "فواتير المشتريات";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // lblTodayPurchasesInvoices
            // 
            this.lblTodayPurchasesInvoices.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPurchasesInvoices.Location = new System.Drawing.Point(3, 45);
            this.lblTodayPurchasesInvoices.Name = "lblTodayPurchasesInvoices";
            this.lblTodayPurchasesInvoices.Size = new System.Drawing.Size(261, 37);
            this.lblTodayPurchasesInvoices.TabIndex = 1;
            this.lblTodayPurchasesInvoices.Text = "1500";
            this.lblTodayPurchasesInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodayPurchasesInvoices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::SIMS.WinForms.Properties.Resources.Invoice;
            this.pictureBox3.Location = new System.Drawing.Point(217, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblTodayPurchases);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(564, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 126);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblTodayNetPurchases);
            this.panel5.Controls.Add(this.lblTodayPurchasesReturn);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(839, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 126);
            this.panel5.TabIndex = 0;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "مرتجعات المشتريات";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.LightGreen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Controls.Add(this.lblTodayTotalProfits);
            this.panel6.Location = new System.Drawing.Point(564, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(269, 126);
            this.panel6.TabIndex = 0;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::SIMS.WinForms.Properties.Resources.total_profits;
            this.pictureBox7.Location = new System.Drawing.Point(217, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 39);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.LightGreen;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblTodayProfitRate);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(839, 181);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(269, 126);
            this.panel7.TabIndex = 29;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SIMS.WinForms.Properties.Resources.total_profits;
            this.pictureBox4.Location = new System.Drawing.Point(217, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyControl_MouseDown);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chartCategoriesSales);
            this.Controls.Add(this.dgvRunningLowProducts);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblCategorySalesTextHeder);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashbord_Click);
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
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoriesSales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvRunningLowProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoriesSales;
        private System.Windows.Forms.Label lblCategorySalesTextHeder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTodaySalesInvoices;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTodayPurchases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTodayPurchasesInvoices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTodayNetSales;
        private System.Windows.Forms.Label lblTodayTotalSalesReturn;
        private System.Windows.Forms.Label lblTodayNetPurchases;
        private System.Windows.Forms.Label lblTodayPurchasesReturn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTodayProfitRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem GoToInventoriesListtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowStockTransactionsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuppliedItemsLogToolStripMenuItem;
    }
}
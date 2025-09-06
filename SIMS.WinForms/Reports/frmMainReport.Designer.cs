namespace SIMS.WinForms.Reports
{
    partial class frmMainReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSlowMovingProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartButtomFiveLeastSelling = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTotalMonthlyProfits = new System.Windows.Forms.Panel();
            this.lblTotalMonthlyProfits = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.chartTopFiveBestSalling = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTotalProjectedSalesValue = new System.Windows.Forms.Panel();
            this.lblTotalProjectedSalesValue = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAverageInvoiceValue = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlAverageDailyInvoices = new System.Windows.Forms.Panel();
            this.lblAverageDailyInvoices = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAverageInvoiceValue = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSlowMovingProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartButtomFiveLeastSelling)).BeginInit();
            this.pnlTotalMonthlyProfits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopFiveBestSalling)).BeginInit();
            this.pnlTotalProjectedSalesValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAverageDailyInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAverageInvoiceValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSlowMovingProducts
            // 
            this.chartSlowMovingProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartSlowMovingProducts.BackColor = System.Drawing.Color.LightSeaGreen;
            chartArea4.Name = "ChartArea1";
            this.chartSlowMovingProducts.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSlowMovingProducts.Legends.Add(legend4);
            this.chartSlowMovingProducts.Location = new System.Drawing.Point(566, 46);
            this.chartSlowMovingProducts.Name = "chartSlowMovingProducts";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Products";
            this.chartSlowMovingProducts.Series.Add(series4);
            this.chartSlowMovingProducts.Size = new System.Drawing.Size(549, 258);
            this.chartSlowMovingProducts.TabIndex = 25;
            this.chartSlowMovingProducts.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Top 5 Best-Selling Products in Current Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bottom 5 Least-Selling Products in Current Month";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Slow-Moving Products (Not sold for over 30 days)";
            // 
            // chartButtomFiveLeastSelling
            // 
            this.chartButtomFiveLeastSelling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartButtomFiveLeastSelling.BackColor = System.Drawing.Color.LightSeaGreen;
            chartArea5.Name = "ChartArea1";
            this.chartButtomFiveLeastSelling.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartButtomFiveLeastSelling.Legends.Add(legend5);
            this.chartButtomFiveLeastSelling.Location = new System.Drawing.Point(11, 357);
            this.chartButtomFiveLeastSelling.Name = "chartButtomFiveLeastSelling";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartButtomFiveLeastSelling.Series.Add(series5);
            this.chartButtomFiveLeastSelling.Size = new System.Drawing.Size(549, 332);
            this.chartButtomFiveLeastSelling.TabIndex = 27;
            this.chartButtomFiveLeastSelling.Text = "chart2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Monthly Profits";
            // 
            // pnlTotalMonthlyProfits
            // 
            this.pnlTotalMonthlyProfits.BackColor = System.Drawing.Color.LightGreen;
            this.pnlTotalMonthlyProfits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalMonthlyProfits.Controls.Add(this.lblTotalMonthlyProfits);
            this.pnlTotalMonthlyProfits.Controls.Add(this.pictureBox5);
            this.pnlTotalMonthlyProfits.Controls.Add(this.label7);
            this.pnlTotalMonthlyProfits.Location = new System.Drawing.Point(11, 178);
            this.pnlTotalMonthlyProfits.Name = "pnlTotalMonthlyProfits";
            this.pnlTotalMonthlyProfits.Size = new System.Drawing.Size(269, 126);
            this.pnlTotalMonthlyProfits.TabIndex = 19;
            // 
            // lblTotalMonthlyProfits
            // 
            this.lblTotalMonthlyProfits.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMonthlyProfits.Location = new System.Drawing.Point(3, 74);
            this.lblTotalMonthlyProfits.Name = "lblTotalMonthlyProfits";
            this.lblTotalMonthlyProfits.Size = new System.Drawing.Size(185, 23);
            this.lblTotalMonthlyProfits.TabIndex = 1;
            this.lblTotalMonthlyProfits.Text = "$999.999.999";
            this.lblTotalMonthlyProfits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SIMS.WinForms.Properties.Resources.total_profits;
            this.pictureBox5.Location = new System.Drawing.Point(194, 51);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 72);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // chartTopFiveBestSalling
            // 
            this.chartTopFiveBestSalling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTopFiveBestSalling.BackColor = System.Drawing.Color.LightSeaGreen;
            chartArea6.Name = "ChartArea1";
            this.chartTopFiveBestSalling.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartTopFiveBestSalling.Legends.Add(legend6);
            this.chartTopFiveBestSalling.Location = new System.Drawing.Point(566, 357);
            this.chartTopFiveBestSalling.Name = "chartTopFiveBestSalling";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartTopFiveBestSalling.Series.Add(series6);
            this.chartTopFiveBestSalling.Size = new System.Drawing.Size(549, 332);
            this.chartTopFiveBestSalling.TabIndex = 26;
            this.chartTopFiveBestSalling.Text = "chart1";
            // 
            // pnlTotalProjectedSalesValue
            // 
            this.pnlTotalProjectedSalesValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotalProjectedSalesValue.BackColor = System.Drawing.Color.LightGreen;
            this.pnlTotalProjectedSalesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalProjectedSalesValue.Controls.Add(this.lblTotalProjectedSalesValue);
            this.pnlTotalProjectedSalesValue.Controls.Add(this.pictureBox8);
            this.pnlTotalProjectedSalesValue.Controls.Add(this.label8);
            this.pnlTotalProjectedSalesValue.Location = new System.Drawing.Point(291, 178);
            this.pnlTotalProjectedSalesValue.Name = "pnlTotalProjectedSalesValue";
            this.pnlTotalProjectedSalesValue.Size = new System.Drawing.Size(269, 126);
            this.pnlTotalProjectedSalesValue.TabIndex = 17;
            // 
            // lblTotalProjectedSalesValue
            // 
            this.lblTotalProjectedSalesValue.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProjectedSalesValue.Location = new System.Drawing.Point(3, 74);
            this.lblTotalProjectedSalesValue.Name = "lblTotalProjectedSalesValue";
            this.lblTotalProjectedSalesValue.Size = new System.Drawing.Size(185, 23);
            this.lblTotalProjectedSalesValue.TabIndex = 1;
            this.lblTotalProjectedSalesValue.Text = "$999.999.999";
            this.lblTotalProjectedSalesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SIMS.WinForms.Properties.Resources.inventory_value;
            this.pictureBox8.Location = new System.Drawing.Point(194, 51);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(72, 72);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Projected Sales Value";
            // 
            // lblAverageInvoiceValue
            // 
            this.lblAverageInvoiceValue.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageInvoiceValue.Location = new System.Drawing.Point(3, 74);
            this.lblAverageInvoiceValue.Name = "lblAverageInvoiceValue";
            this.lblAverageInvoiceValue.Size = new System.Drawing.Size(185, 23);
            this.lblAverageInvoiceValue.TabIndex = 1;
            this.lblAverageInvoiceValue.Text = "$999.999.999";
            this.lblAverageInvoiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SIMS.WinForms.Properties.Resources.Invoice;
            this.pictureBox2.Location = new System.Drawing.Point(194, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Average Invoice Value";
            // 
            // pnlAverageDailyInvoices
            // 
            this.pnlAverageDailyInvoices.BackColor = System.Drawing.Color.LightGray;
            this.pnlAverageDailyInvoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAverageDailyInvoices.Controls.Add(this.lblAverageDailyInvoices);
            this.pnlAverageDailyInvoices.Controls.Add(this.pictureBox1);
            this.pnlAverageDailyInvoices.Controls.Add(this.label5);
            this.pnlAverageDailyInvoices.Location = new System.Drawing.Point(11, 46);
            this.pnlAverageDailyInvoices.Name = "pnlAverageDailyInvoices";
            this.pnlAverageDailyInvoices.Size = new System.Drawing.Size(269, 126);
            this.pnlAverageDailyInvoices.TabIndex = 20;
            // 
            // lblAverageDailyInvoices
            // 
            this.lblAverageDailyInvoices.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageDailyInvoices.Location = new System.Drawing.Point(3, 74);
            this.lblAverageDailyInvoices.Name = "lblAverageDailyInvoices";
            this.lblAverageDailyInvoices.Size = new System.Drawing.Size(185, 23);
            this.lblAverageDailyInvoices.TabIndex = 1;
            this.lblAverageDailyInvoices.Text = "1500";
            this.lblAverageDailyInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMS.WinForms.Properties.Resources.Invoice;
            this.pictureBox1.Location = new System.Drawing.Point(194, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Average Daily Invoices";
            // 
            // pnlAverageInvoiceValue
            // 
            this.pnlAverageInvoiceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAverageInvoiceValue.BackColor = System.Drawing.Color.LightGray;
            this.pnlAverageInvoiceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAverageInvoiceValue.Controls.Add(this.lblAverageInvoiceValue);
            this.pnlAverageInvoiceValue.Controls.Add(this.pictureBox2);
            this.pnlAverageInvoiceValue.Controls.Add(this.label6);
            this.pnlAverageInvoiceValue.Location = new System.Drawing.Point(291, 46);
            this.pnlAverageInvoiceValue.Name = "pnlAverageInvoiceValue";
            this.pnlAverageInvoiceValue.Size = new System.Drawing.Size(269, 126);
            this.pnlAverageInvoiceValue.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Overview";
            // 
            // frmMainReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 701);
            this.Controls.Add(this.chartSlowMovingProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartButtomFiveLeastSelling);
            this.Controls.Add(this.pnlTotalMonthlyProfits);
            this.Controls.Add(this.chartTopFiveBestSalling);
            this.Controls.Add(this.pnlTotalProjectedSalesValue);
            this.Controls.Add(this.pnlAverageDailyInvoices);
            this.Controls.Add(this.pnlAverageInvoiceValue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Report";
            ((System.ComponentModel.ISupportInitialize)(this.chartSlowMovingProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartButtomFiveLeastSelling)).EndInit();
            this.pnlTotalMonthlyProfits.ResumeLayout(false);
            this.pnlTotalMonthlyProfits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopFiveBestSalling)).EndInit();
            this.pnlTotalProjectedSalesValue.ResumeLayout(false);
            this.pnlTotalProjectedSalesValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlAverageDailyInvoices.ResumeLayout(false);
            this.pnlAverageDailyInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAverageInvoiceValue.ResumeLayout(false);
            this.pnlAverageInvoiceValue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSlowMovingProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartButtomFiveLeastSelling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlTotalMonthlyProfits;
        private System.Windows.Forms.Label lblTotalMonthlyProfits;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopFiveBestSalling;
        private System.Windows.Forms.Panel pnlTotalProjectedSalesValue;
        private System.Windows.Forms.Label lblTotalProjectedSalesValue;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAverageInvoiceValue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlAverageDailyInvoices;
        private System.Windows.Forms.Label lblAverageDailyInvoices;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlAverageInvoiceValue;
        private System.Windows.Forms.Label label1;
    }
}
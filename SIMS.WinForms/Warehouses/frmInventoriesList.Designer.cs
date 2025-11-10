namespace SIMS.WinForms.Warehouses
{
    partial class frmInventoriesList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.cbInventoryStatus = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.pnlTotalProjectedSalesValue = new System.Windows.Forms.Panel();
            this.lblExpectedProfitValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblExpectedProfitRate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalProjectedSalesValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalInventoryValue = new System.Windows.Forms.Label();
            this.lblEmptyInventoriesCount = new System.Windows.Forms.Label();
            this.lblLowedInventoriesCount = new System.Windows.Forms.Label();
            this.lblSavedIInventoriesCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTotalProjectedSalesValue.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Location = new System.Drawing.Point(9, 688);
            this.lblTotalRecordsText.Size = new System.Drawing.Size(133, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد العناصر:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(150, 689);
            this.lblTotalRecords.Size = new System.Drawing.Size(84, 14);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnApplyFilter);
            this.panel1.Controls.Add(this.cbInventoryStatus);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.cbProduct);
            this.panel1.Controls.Add(this.cbUnit);
            this.panel1.Controls.Add(this.cbWarehouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 40);
            this.panel1.TabIndex = 50;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackgroundImage = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.btnApplyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApplyFilter.Location = new System.Drawing.Point(12, 3);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(48, 35);
            this.btnApplyFilter.TabIndex = 5;
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // cbInventoryStatus
            // 
            this.cbInventoryStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInventoryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInventoryStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInventoryStatus.FormattingEnabled = true;
            this.cbInventoryStatus.Items.AddRange(new object[] {
            "كل الحالات",
            "آمن",
            "منخفض",
            "نفذ"});
            this.cbInventoryStatus.Location = new System.Drawing.Point(199, 10);
            this.cbInventoryStatus.Name = "cbInventoryStatus";
            this.cbInventoryStatus.Size = new System.Drawing.Size(150, 22);
            this.cbInventoryStatus.TabIndex = 4;
            // 
            // cbCategory
            // 
            this.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "كل التصنيفات"});
            this.cbCategory.Location = new System.Drawing.Point(668, 10);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 22);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.Leave += new System.EventHandler(this.cbCategory_Leave);
            // 
            // cbProduct
            // 
            this.cbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Items.AddRange(new object[] {
            "كل المنتجات"});
            this.cbProduct.Location = new System.Drawing.Point(875, 10);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(225, 22);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.Leave += new System.EventHandler(this.cbProduct_Leave);
            // 
            // cbUnit
            // 
            this.cbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "كل الوحدات"});
            this.cbUnit.Location = new System.Drawing.Point(511, 10);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(150, 22);
            this.cbUnit.TabIndex = 2;
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Items.AddRange(new object[] {
            "كل المخازن"});
            this.cbWarehouse.Location = new System.Drawing.Point(355, 10);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(150, 22);
            this.cbWarehouse.TabIndex = 3;
            // 
            // pnlTotalProjectedSalesValue
            // 
            this.pnlTotalProjectedSalesValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotalProjectedSalesValue.BackColor = System.Drawing.Color.LightGray;
            this.pnlTotalProjectedSalesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalProjectedSalesValue.Controls.Add(this.lblExpectedProfitValue);
            this.pnlTotalProjectedSalesValue.Controls.Add(this.label8);
            this.pnlTotalProjectedSalesValue.Location = new System.Drawing.Point(558, 46);
            this.pnlTotalProjectedSalesValue.Name = "pnlTotalProjectedSalesValue";
            this.pnlTotalProjectedSalesValue.Size = new System.Drawing.Size(269, 83);
            this.pnlTotalProjectedSalesValue.TabIndex = 73;
            // 
            // lblExpectedProfitValue
            // 
            this.lblExpectedProfitValue.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedProfitValue.Location = new System.Drawing.Point(3, 43);
            this.lblExpectedProfitValue.Name = "lblExpectedProfitValue";
            this.lblExpectedProfitValue.Size = new System.Drawing.Size(261, 23);
            this.lblExpectedProfitValue.TabIndex = 1;
            this.lblExpectedProfitValue.Text = "$999.999.999";
            this.lblExpectedProfitValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "إجمالي الربح المتوقع";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblExpectedProfitRate);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(831, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 83);
            this.panel5.TabIndex = 72;
            // 
            // lblExpectedProfitRate
            // 
            this.lblExpectedProfitRate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedProfitRate.Location = new System.Drawing.Point(3, 43);
            this.lblExpectedProfitRate.Name = "lblExpectedProfitRate";
            this.lblExpectedProfitRate.Size = new System.Drawing.Size(261, 23);
            this.lblExpectedProfitRate.TabIndex = 1;
            this.lblExpectedProfitRate.Text = "%100.00";
            this.lblExpectedProfitRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "معدل الربح المتوقع";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalProjectedSalesValue);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(285, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 83);
            this.panel3.TabIndex = 71;
            // 
            // lblTotalProjectedSalesValue
            // 
            this.lblTotalProjectedSalesValue.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProjectedSalesValue.Location = new System.Drawing.Point(3, 43);
            this.lblTotalProjectedSalesValue.Name = "lblTotalProjectedSalesValue";
            this.lblTotalProjectedSalesValue.Size = new System.Drawing.Size(261, 23);
            this.lblTotalProjectedSalesValue.TabIndex = 1;
            this.lblTotalProjectedSalesValue.Text = "$999.999.999";
            this.lblTotalProjectedSalesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "القيمة المتوقعة من بيع المخزون";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTotalInventoryValue);
            this.panel2.Location = new System.Drawing.Point(12, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 83);
            this.panel2.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "التكلفة الحالية للمخزون";
            // 
            // lblTotalInventoryValue
            // 
            this.lblTotalInventoryValue.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInventoryValue.Location = new System.Drawing.Point(3, 43);
            this.lblTotalInventoryValue.Name = "lblTotalInventoryValue";
            this.lblTotalInventoryValue.Size = new System.Drawing.Size(261, 23);
            this.lblTotalInventoryValue.TabIndex = 1;
            this.lblTotalInventoryValue.Text = "$999.999.999";
            this.lblTotalInventoryValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptyInventoriesCount
            // 
            this.lblEmptyInventoriesCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyInventoriesCount.Location = new System.Drawing.Point(985, 689);
            this.lblEmptyInventoriesCount.Name = "lblEmptyInventoriesCount";
            this.lblEmptyInventoriesCount.Size = new System.Drawing.Size(84, 14);
            this.lblEmptyInventoriesCount.TabIndex = 77;
            this.lblEmptyInventoriesCount.Text = "N/A";
            this.lblEmptyInventoriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLowedInventoriesCount
            // 
            this.lblLowedInventoriesCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowedInventoriesCount.Location = new System.Drawing.Point(713, 690);
            this.lblLowedInventoriesCount.Name = "lblLowedInventoriesCount";
            this.lblLowedInventoriesCount.Size = new System.Drawing.Size(84, 14);
            this.lblLowedInventoriesCount.TabIndex = 78;
            this.lblLowedInventoriesCount.Text = "N/A";
            this.lblLowedInventoriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSavedIInventoriesCount
            // 
            this.lblSavedIInventoriesCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedIInventoriesCount.Location = new System.Drawing.Point(419, 686);
            this.lblSavedIInventoriesCount.Name = "lblSavedIInventoriesCount";
            this.lblSavedIInventoriesCount.Size = new System.Drawing.Size(84, 14);
            this.lblSavedIInventoriesCount.TabIndex = 79;
            this.lblSavedIInventoriesCount.Text = "N/A";
            this.lblSavedIInventoriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(803, 688);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "إجمالي عدد العناصر النافذة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 688);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "إجمالي عدد العناصر المنخفضة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 688);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "إجمالي عدد العناصر الآمنة:";
            // 
            // frmInventoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.lblEmptyInventoriesCount);
            this.Controls.Add(this.lblLowedInventoriesCount);
            this.Controls.Add(this.lblSavedIInventoriesCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlTotalProjectedSalesValue);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmInventoriesList";
            this.ShowSearchTextBox = true;
            this.Load += new System.EventHandler(this.frmInventoriesList_Load);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.pnlTotalProjectedSalesValue, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblSavedIInventoriesCount, 0);
            this.Controls.SetChildIndex(this.lblLowedInventoriesCount, 0);
            this.Controls.SetChildIndex(this.lblEmptyInventoriesCount, 0);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlTotalProjectedSalesValue.ResumeLayout(false);
            this.pnlTotalProjectedSalesValue.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbInventoryStatus;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Panel pnlTotalProjectedSalesValue;
        private System.Windows.Forms.Label lblExpectedProfitValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblExpectedProfitRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProjectedSalesValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalInventoryValue;
        private System.Windows.Forms.Label lblEmptyInventoriesCount;
        private System.Windows.Forms.Label lblLowedInventoriesCount;
        private System.Windows.Forms.Label lblSavedIInventoriesCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}
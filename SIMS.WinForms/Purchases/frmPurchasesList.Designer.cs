namespace SIMS.WinForms.Purchases
{
    partial class frmPurchasesList
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.issuePurchaseInvoiceToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ctrInvoiceInfo = new SIMS.WinForms.Invoices.ctrInvoiceInfo();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRange = new System.Windows.Forms.ComboBox();
            this.cbInvoiceStatus = new System.Windows.Forms.ComboBox();
            this.cbInvoiceType = new System.Windows.Forms.ComboBox();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Size = new System.Drawing.Size(135, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد الفواتير: ";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(152, 691);
            // 
            // searchPanel
            // 
            this.searchPanel.Location = new System.Drawing.Point(640, 8);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Text = "أدخل رقم الفاتورة أو إسم المورد";
            // 
            // txtSearch
            // 
            this.txtSearch.TabIndex = 3;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuePurchaseInvoiceToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(1112, 40);
            this.toolStrip.TabIndex = 48;
            this.toolStrip.Text = "toolStrip1";
            // 
            // issuePurchaseInvoiceToolStripButton
            // 
            this.issuePurchaseInvoiceToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuePurchaseInvoiceToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.Invoice_32;
            this.issuePurchaseInvoiceToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.issuePurchaseInvoiceToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issuePurchaseInvoiceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.issuePurchaseInvoiceToolStripButton.Name = "issuePurchaseInvoiceToolStripButton";
            this.issuePurchaseInvoiceToolStripButton.Size = new System.Drawing.Size(161, 37);
            this.issuePurchaseInvoiceToolStripButton.Text = "   إصدار فاتورة مشتريات";
            this.issuePurchaseInvoiceToolStripButton.Click += new System.EventHandler(this.issuePurchaseInvoiceToolStripButton_Click);
            // 
            // ctrInvoiceInfo
            // 
            this.ctrInvoiceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrInvoiceInfo.BackColor = System.Drawing.Color.White;
            this.ctrInvoiceInfo.Entity = null;
            this.ctrInvoiceInfo.Location = new System.Drawing.Point(12, 43);
            this.ctrInvoiceInfo.Name = "ctrInvoiceInfo";
            this.ctrInvoiceInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrInvoiceInfo.Size = new System.Drawing.Size(1088, 275);
            this.ctrInvoiceInfo.TabIndex = 7;
            this.ctrInvoiceInfo.Visible = false;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(937, 0);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.RightToLeftLayout = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(110, 21);
            this.dtpDateFrom.TabIndex = 4;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(937, 19);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.RightToLeftLayout = true;
            this.dtpDateTo.Size = new System.Drawing.Size(110, 21);
            this.dtpDateTo.TabIndex = 5;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackgroundImage = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.btnApplyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApplyFilter.Location = new System.Drawing.Point(1065, 2);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(35, 35);
            this.btnApplyFilter.TabIndex = 6;
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(899, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "إلى:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(902, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "من:";
            // 
            // cbRange
            // 
            this.cbRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRange.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRange.FormattingEnabled = true;
            this.cbRange.Items.AddRange(new object[] {
            "آخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 3 شهور",
            "آخر 6 شهور",
            "أخر 12 شهر",
            "كل الأيام",
            "مخصص"});
            this.cbRange.Location = new System.Drawing.Point(484, 11);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(150, 22);
            this.cbRange.TabIndex = 2;
            this.cbRange.SelectedIndexChanged += new System.EventHandler(this.cbRange_SelectedIndexChanged);
            // 
            // cbInvoiceStatus
            // 
            this.cbInvoiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoiceStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvoiceStatus.FormattingEnabled = true;
            this.cbInvoiceStatus.Items.AddRange(new object[] {
            "كل حالات الدفع",
            "مدفوعة بالكامل",
            "مدفوعة جزئيا",
            "غير مدفوعة"});
            this.cbInvoiceStatus.Location = new System.Drawing.Point(357, 11);
            this.cbInvoiceStatus.Name = "cbInvoiceStatus";
            this.cbInvoiceStatus.Size = new System.Drawing.Size(121, 22);
            this.cbInvoiceStatus.TabIndex = 1;
            // 
            // cbInvoiceType
            // 
            this.cbInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoiceType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvoiceType.FormattingEnabled = true;
            this.cbInvoiceType.Items.AddRange(new object[] {
            "كل الفواتير",
            "مشتريات",
            "مرتجعات مشتريات"});
            this.cbInvoiceType.Location = new System.Drawing.Point(230, 11);
            this.cbInvoiceType.Name = "cbInvoiceType";
            this.cbInvoiceType.Size = new System.Drawing.Size(121, 22);
            this.cbInvoiceType.TabIndex = 0;
            // 
            // frmPurchasesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.cbInvoiceStatus);
            this.Controls.Add(this.cbInvoiceType);
            this.Controls.Add(this.cbRange);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrInvoiceInfo);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmPurchasesList";
            this.ShowIcon = false;
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير المشتريات";
            this.Load += new System.EventHandler(this.frmPurchasesList_Load);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.ctrInvoiceInfo, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnApplyFilter, 0);
            this.Controls.SetChildIndex(this.dtpDateTo, 0);
            this.Controls.SetChildIndex(this.dtpDateFrom, 0);
            this.Controls.SetChildIndex(this.cbRange, 0);
            this.Controls.SetChildIndex(this.cbInvoiceType, 0);
            this.Controls.SetChildIndex(this.cbInvoiceStatus, 0);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton issuePurchaseInvoiceToolStripButton;
        private Invoices.ctrInvoiceInfo ctrInvoiceInfo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRange;
        private System.Windows.Forms.ComboBox cbInvoiceStatus;
        private System.Windows.Forms.ComboBox cbInvoiceType;
    }
}
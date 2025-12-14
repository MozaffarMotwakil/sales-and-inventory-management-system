namespace SIMS.WinForms.Products
{
    partial class frmDiscountsList
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
            this.addNewDiscountToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cbActivityStatus = new System.Windows.Forms.ComboBox();
            this.cbValueType = new System.Windows.Forms.ComboBox();
            this.cbCreatedDate = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Size = new System.Drawing.Size(151, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد الخصومات:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(168, 691);
            // 
            // searchPanel
            // 
            this.searchPanel.Location = new System.Drawing.Point(640, 7);
            this.searchPanel.Size = new System.Drawing.Size(209, 26);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(179, 0);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Size = new System.Drawing.Size(170, 16);
            this.lblSearchHintText.Text = "أدخل إسم الخصم";
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(179, 26);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDiscountToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(1112, 40);
            this.toolStrip.TabIndex = 49;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addNewDiscountToolStripButton
            // 
            this.addNewDiscountToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewDiscountToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.discount;
            this.addNewDiscountToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewDiscountToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDiscountToolStripButton.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.addNewDiscountToolStripButton.Name = "addNewDiscountToolStripButton";
            this.addNewDiscountToolStripButton.Size = new System.Drawing.Size(137, 37);
            this.addNewDiscountToolStripButton.Text = "   إضافة خصم جديد";
            this.addNewDiscountToolStripButton.Click += new System.EventHandler(this.addNewDiscountToolStripButton_Click);
            // 
            // cbActivityStatus
            // 
            this.cbActivityStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivityStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivityStatus.FormattingEnabled = true;
            this.cbActivityStatus.Items.AddRange(new object[] {
            "كل الحالات",
            "نشط",
            "غير نشط"});
            this.cbActivityStatus.Location = new System.Drawing.Point(357, 10);
            this.cbActivityStatus.Name = "cbActivityStatus";
            this.cbActivityStatus.Size = new System.Drawing.Size(121, 22);
            this.cbActivityStatus.TabIndex = 79;
            // 
            // cbValueType
            // 
            this.cbValueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValueType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValueType.FormattingEnabled = true;
            this.cbValueType.Items.AddRange(new object[] {
            "كل القيم",
            "نسبة مئوية",
            "مبلغ"});
            this.cbValueType.Location = new System.Drawing.Point(230, 10);
            this.cbValueType.Name = "cbValueType";
            this.cbValueType.Size = new System.Drawing.Size(121, 22);
            this.cbValueType.TabIndex = 78;
            // 
            // cbCreatedDate
            // 
            this.cbCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCreatedDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCreatedDate.FormattingEnabled = true;
            this.cbCreatedDate.Items.AddRange(new object[] {
            "آخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 3 شهور",
            "آخر 6 شهور",
            "أخر 12 شهر",
            "كل الأيام"});
            this.cbCreatedDate.Location = new System.Drawing.Point(484, 10);
            this.cbCreatedDate.Name = "cbCreatedDate";
            this.cbCreatedDate.Size = new System.Drawing.Size(150, 22);
            this.cbCreatedDate.TabIndex = 80;
            this.cbCreatedDate.Text = "إختر نطاق إضافة الخصم";
            this.cbCreatedDate.Enter += new System.EventHandler(this.cbCreatedDate_Enter);
            this.cbCreatedDate.Leave += new System.EventHandler(this.cbCreatedDate_Leave);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(937, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.RightToLeftLayout = true;
            this.dtpStartDate.Size = new System.Drawing.Size(110, 21);
            this.dtpStartDate.TabIndex = 81;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(937, 19);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.RightToLeftLayout = true;
            this.dtpEndDate.Size = new System.Drawing.Size(110, 21);
            this.dtpEndDate.TabIndex = 82;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackgroundImage = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.btnApplyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApplyFilter.Location = new System.Drawing.Point(1065, 2);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(35, 35);
            this.btnApplyFilter.TabIndex = 83;
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(855, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "تاريخ النهاية:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(856, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "تاريخ البداية:";
            // 
            // frmDiscountsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.cbActivityStatus);
            this.Controls.Add(this.cbValueType);
            this.Controls.Add(this.cbCreatedDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmDiscountsList";
            this.ShowIcon = false;
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الخصومات";
            this.Load += new System.EventHandler(this.frmDiscountsList_Load);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnApplyFilter, 0);
            this.Controls.SetChildIndex(this.dtpEndDate, 0);
            this.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.Controls.SetChildIndex(this.cbCreatedDate, 0);
            this.Controls.SetChildIndex(this.cbValueType, 0);
            this.Controls.SetChildIndex(this.cbActivityStatus, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
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
        private System.Windows.Forms.ToolStripButton addNewDiscountToolStripButton;
        private System.Windows.Forms.ComboBox cbActivityStatus;
        private System.Windows.Forms.ComboBox cbValueType;
        private System.Windows.Forms.ComboBox cbCreatedDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
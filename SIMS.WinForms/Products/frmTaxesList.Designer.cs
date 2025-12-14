namespace SIMS.WinForms.Products
{
    partial class frmTaxesList
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
            this.addNewTaxToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cbActivityStatus = new System.Windows.Forms.ComboBox();
            this.cbCreatedDate = new System.Windows.Forms.ComboBox();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Size = new System.Drawing.Size(138, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد الضرائب:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(155, 691);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Text = "أدخل إسم الضريبة";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTaxToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(1112, 40);
            this.toolStrip.TabIndex = 50;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addNewTaxToolStripButton
            // 
            this.addNewTaxToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTaxToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.dividend;
            this.addNewTaxToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewTaxToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewTaxToolStripButton.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.addNewTaxToolStripButton.Name = "addNewTaxToolStripButton";
            this.addNewTaxToolStripButton.Size = new System.Drawing.Size(142, 37);
            this.addNewTaxToolStripButton.Text = "   إضافة ضريبة جديد";
            this.addNewTaxToolStripButton.Click += new System.EventHandler(this.addNewTaxToolStripButton_Click);
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
            this.cbActivityStatus.Location = new System.Drawing.Point(567, 10);
            this.cbActivityStatus.Name = "cbActivityStatus";
            this.cbActivityStatus.Size = new System.Drawing.Size(121, 22);
            this.cbActivityStatus.TabIndex = 81;
            this.cbActivityStatus.SelectedIndexChanged += new System.EventHandler(this.cbActivityStatus_SelectedIndexChanged);
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
            this.cbCreatedDate.Location = new System.Drawing.Point(694, 10);
            this.cbCreatedDate.Name = "cbCreatedDate";
            this.cbCreatedDate.Size = new System.Drawing.Size(150, 22);
            this.cbCreatedDate.TabIndex = 82;
            this.cbCreatedDate.Text = "إختر نطاق إضافة الضريبة";
            this.cbCreatedDate.SelectedIndexChanged += new System.EventHandler(this.cbCreatedDate_SelectedIndexChanged);
            this.cbCreatedDate.Enter += new System.EventHandler(this.cbCreatedDate_Enter);
            this.cbCreatedDate.Leave += new System.EventHandler(this.cbCreatedDate_Leave);
            // 
            // frmTaxesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.cbActivityStatus);
            this.Controls.Add(this.cbCreatedDate);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmTaxesList";
            this.ShowIcon = false;
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الضرائب";
            this.Load += new System.EventHandler(this.frmTaxesList_Load);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.cbCreatedDate, 0);
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
        private System.Windows.Forms.ToolStripButton addNewTaxToolStripButton;
        private System.Windows.Forms.ComboBox cbActivityStatus;
        private System.Windows.Forms.ComboBox cbCreatedDate;
    }
}
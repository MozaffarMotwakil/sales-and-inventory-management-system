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
            this.issuePurchaseInvoiceToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issuePurchaseInvoiceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.issuePurchaseInvoiceToolStripButton.Name = "issuePurchaseInvoiceToolStripButton";
            this.issuePurchaseInvoiceToolStripButton.Size = new System.Drawing.Size(129, 37);
            this.issuePurchaseInvoiceToolStripButton.Text = "   إصدار فاتورة مشتريات";
            this.issuePurchaseInvoiceToolStripButton.Click += new System.EventHandler(this.issuePurchaseInvoiceToolStripButton_Click);
            // 
            // ctrInvoiceInfo
            // 
            this.ctrInvoiceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrInvoiceInfo.Entity = null;
            this.ctrInvoiceInfo.Location = new System.Drawing.Point(12, 43);
            this.ctrInvoiceInfo.Name = "ctrInvoiceInfo";
            this.ctrInvoiceInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrInvoiceInfo.Size = new System.Drawing.Size(1088, 275);
            this.ctrInvoiceInfo.TabIndex = 51;
            this.ctrInvoiceInfo.Visible = false;
            // 
            // frmPurchasesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.ctrInvoiceInfo);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmPurchasesList";
            this.ShowIcon = false;
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير المشتريات";
            this.Load += new System.EventHandler(this.frmPurchasesList_Load);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.ctrInvoiceInfo, 0);
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
    }
}
namespace SIMS.WinForms.Invoices
{
    partial class frmShowInvoiceInfo
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
            this.ctrInvoiceInfo = new SIMS.WinForms.Invoices.ctrInvoiceInfo();
            this.SuspendLayout();
            // 
            // ctrInvoiceInfo
            // 
            this.ctrInvoiceInfo.Invoice = null;
            this.ctrInvoiceInfo.Location = new System.Drawing.Point(12, 12);
            this.ctrInvoiceInfo.Name = "ctrInvoiceInfo";
            this.ctrInvoiceInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrInvoiceInfo.Size = new System.Drawing.Size(1185, 276);
            this.ctrInvoiceInfo.TabIndex = 0;
            // 
            // frmShowInvoiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 300);
            this.Controls.Add(this.ctrInvoiceInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowInvoiceInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض تفاصيل فاتورة";
            this.Load += new System.EventHandler(this.frmShowInvoiceInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrInvoiceInfo ctrInvoiceInfo;
    }
}
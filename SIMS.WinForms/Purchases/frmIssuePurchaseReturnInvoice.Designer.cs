namespace SIMS.WinForms.Purchases
{
    partial class frmIssuePurchaseReturnInvoice
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
            ((System.ComponentModel.ISupportInitialize)(this.vwSuppliersDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierNames)).BeginInit();
            this.gbInvoiceSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNames)).BeginInit();
            this.gbPaymentInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbInvoiceDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.Position = 0;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            // 
            // cbParty
            // 
            this.cbParty.Enabled = false;
            // 
            // dtpInvoiceIssueDate
            // 
            this.dtpInvoiceIssueDate.Value = new System.DateTime(2025, 11, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Text = "المورد";
            // 
            // label1
            // 
            this.label1.Text = "رقم الفاتورة الأصلية:";
            // 
            // frmIssuePurchaseReturnInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Name = "frmIssuePurchaseReturnInvoice";
            this.Load += new System.EventHandler(this.frmReturnPurchaseInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwSuppliersDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierNames)).EndInit();
            this.gbInvoiceSummary.ResumeLayout(false);
            this.gbInvoiceSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNames)).EndInit();
            this.gbPaymentInfo.ResumeLayout(false);
            this.gbPaymentInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbInvoiceDetails.ResumeLayout(false);
            this.gbInvoiceDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

    }
}
namespace SIMS.WinForms.Sales
{
    partial class frmIssueSaleReturnInvoice
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbInvoiceSummary.SuspendLayout();
            this.gbInvoiceDetails.SuspendLayout();
            this.gbPaymentInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(906, 475);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(906, 521);
            // 
            // gbInvoiceLines
            // 
            this.gbInvoiceLines.Size = new System.Drawing.Size(1010, 370);
            // 
            // gbInvoiceDetails
            // 
            this.gbInvoiceDetails.Size = new System.Drawing.Size(1009, 78);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Location = new System.Drawing.Point(778, 45);
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.Enabled = false;
            this.cbWarehouse.Location = new System.Drawing.Point(273, 45);
            // 
            // cbParty
            // 
            this.cbParty.Enabled = false;
            this.cbParty.Location = new System.Drawing.Point(19, 45);
            this.cbParty.Text = "لم يتم توفير قسم العملاء بعد";
            // 
            // dtpInvoiceIssueDate
            // 
            this.dtpInvoiceIssueDate.Location = new System.Drawing.Point(527, 47);
            this.dtpInvoiceIssueDate.MaxDate = new System.DateTime(2025, 12, 3, 0, 0, 0, 0);
            this.dtpInvoiceIssueDate.MinDate = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            this.dtpInvoiceIssueDate.Value = new System.DateTime(2025, 11, 2, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(280, 25);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 26);
            this.label3.Text = "العميل";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(531, 26);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(782, 25);
            this.label1.Text = "رقم الفاتورة الأصلية:";
            // 
            // gbPaymentInfo
            // 
            this.gbPaymentInfo.Location = new System.Drawing.Point(153, 456);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1020, 563);
            // 
            // frmIssueSaleReturnInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Name = "frmIssueSaleReturnInvoice";
            this.Text = "إصدار فاتورة مرتجعات مبيعات";
            this.Load += new System.EventHandler(this.frmIssueSaleReturnInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbInvoiceSummary.ResumeLayout(false);
            this.gbInvoiceSummary.PerformLayout();
            this.gbInvoiceDetails.ResumeLayout(false);
            this.gbInvoiceDetails.PerformLayout();
            this.gbPaymentInfo.ResumeLayout(false);
            this.gbPaymentInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
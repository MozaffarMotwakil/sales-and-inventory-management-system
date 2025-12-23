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
            this.lineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversionFactorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineSubTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineGrandTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isNewRowDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.cbWarehouse.Location = new System.Drawing.Point(273, 45);
            // 
            // cbParty
            // 
            this.cbParty.Enabled = false;
            this.cbParty.Location = new System.Drawing.Point(19, 45);
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
            this.label3.Text = "المورد";
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
            // lineIDDataGridViewTextBoxColumn
            // 
            this.lineIDDataGridViewTextBoxColumn.Name = "lineIDDataGridViewTextBoxColumn";
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productInfoDataGridViewTextBoxColumn
            // 
            this.productInfoDataGridViewTextBoxColumn.Name = "productInfoDataGridViewTextBoxColumn";
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            // 
            // unitInfoDataGridViewTextBoxColumn
            // 
            this.unitInfoDataGridViewTextBoxColumn.Name = "unitInfoDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // conversionFactorDataGridViewTextBoxColumn
            // 
            this.conversionFactorDataGridViewTextBoxColumn.Name = "conversionFactorDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // discountRateDataGridViewTextBoxColumn
            // 
            this.discountRateDataGridViewTextBoxColumn.Name = "discountRateDataGridViewTextBoxColumn";
            // 
            // discountAmountDataGridViewTextBoxColumn
            // 
            this.discountAmountDataGridViewTextBoxColumn.Name = "discountAmountDataGridViewTextBoxColumn";
            // 
            // taxRateDataGridViewTextBoxColumn
            // 
            this.taxRateDataGridViewTextBoxColumn.Name = "taxRateDataGridViewTextBoxColumn";
            // 
            // taxAmountDataGridViewTextBoxColumn
            // 
            this.taxAmountDataGridViewTextBoxColumn.Name = "taxAmountDataGridViewTextBoxColumn";
            // 
            // lineSubTotalDataGridViewTextBoxColumn
            // 
            this.lineSubTotalDataGridViewTextBoxColumn.Name = "lineSubTotalDataGridViewTextBoxColumn";
            // 
            // lineGrandTotalDataGridViewTextBoxColumn
            // 
            this.lineGrandTotalDataGridViewTextBoxColumn.Name = "lineGrandTotalDataGridViewTextBoxColumn";
            // 
            // isNewRowDataGridViewCheckBoxColumn
            // 
            this.isNewRowDataGridViewCheckBoxColumn.Name = "isNewRowDataGridViewCheckBoxColumn";
            // 
            // frmIssuePurchaseReturnInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Name = "frmIssuePurchaseReturnInvoice";
            this.Text = "إصدار فاتورة مرتجعات مشتريات";
            this.Load += new System.EventHandler(this.frmReturnPurchaseInvoice_Load_Local);
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

        private System.Windows.Forms.DataGridViewTextBoxColumn lineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversionFactorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineSubTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineGrandTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNewRowDataGridViewCheckBoxColumn;
    }
}
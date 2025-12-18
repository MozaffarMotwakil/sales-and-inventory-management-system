namespace SIMS.WinForms.Sales
{
    partial class frmIssueSaleInvoice
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
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Text = "يولد بشكل تلقائي";
            // 
            // cbParty
            // 
            this.cbParty.Enabled = false;
            // 
            // dtpInvoiceIssueDate
            // 
            this.dtpInvoiceIssueDate.MaxDate = new System.DateTime(2025, 12, 17, 0, 0, 0, 0);
            this.dtpInvoiceIssueDate.MinDate = new System.DateTime(2024, 12, 17, 0, 0, 0, 0);
            this.dtpInvoiceIssueDate.Value = new System.DateTime(2025, 12, 17, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Text = "العميل:";
            // 
            // lineIDDataGridViewTextBoxColumn
            // 
            this.lineIDDataGridViewTextBoxColumn.DataPropertyName = "LineID";
            this.lineIDDataGridViewTextBoxColumn.HeaderText = "LineID";
            this.lineIDDataGridViewTextBoxColumn.Name = "lineIDDataGridViewTextBoxColumn";
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productInfoDataGridViewTextBoxColumn
            // 
            this.productInfoDataGridViewTextBoxColumn.DataPropertyName = "ProductInfo";
            this.productInfoDataGridViewTextBoxColumn.HeaderText = "ProductInfo";
            this.productInfoDataGridViewTextBoxColumn.Name = "productInfoDataGridViewTextBoxColumn";
            this.productInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            // 
            // unitInfoDataGridViewTextBoxColumn
            // 
            this.unitInfoDataGridViewTextBoxColumn.DataPropertyName = "UnitInfo";
            this.unitInfoDataGridViewTextBoxColumn.HeaderText = "UnitInfo";
            this.unitInfoDataGridViewTextBoxColumn.Name = "unitInfoDataGridViewTextBoxColumn";
            this.unitInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // conversionFactorDataGridViewTextBoxColumn
            // 
            this.conversionFactorDataGridViewTextBoxColumn.DataPropertyName = "ConversionFactor";
            this.conversionFactorDataGridViewTextBoxColumn.HeaderText = "ConversionFactor";
            this.conversionFactorDataGridViewTextBoxColumn.Name = "conversionFactorDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // discountRateDataGridViewTextBoxColumn
            // 
            this.discountRateDataGridViewTextBoxColumn.DataPropertyName = "DiscountRate";
            this.discountRateDataGridViewTextBoxColumn.HeaderText = "DiscountRate";
            this.discountRateDataGridViewTextBoxColumn.Name = "discountRateDataGridViewTextBoxColumn";
            // 
            // discountAmountDataGridViewTextBoxColumn
            // 
            this.discountAmountDataGridViewTextBoxColumn.DataPropertyName = "DiscountAmount";
            this.discountAmountDataGridViewTextBoxColumn.HeaderText = "DiscountAmount";
            this.discountAmountDataGridViewTextBoxColumn.Name = "discountAmountDataGridViewTextBoxColumn";
            // 
            // taxRateDataGridViewTextBoxColumn
            // 
            this.taxRateDataGridViewTextBoxColumn.DataPropertyName = "TaxRate";
            this.taxRateDataGridViewTextBoxColumn.HeaderText = "TaxRate";
            this.taxRateDataGridViewTextBoxColumn.Name = "taxRateDataGridViewTextBoxColumn";
            // 
            // taxAmountDataGridViewTextBoxColumn
            // 
            this.taxAmountDataGridViewTextBoxColumn.DataPropertyName = "TaxAmount";
            this.taxAmountDataGridViewTextBoxColumn.HeaderText = "TaxAmount";
            this.taxAmountDataGridViewTextBoxColumn.Name = "taxAmountDataGridViewTextBoxColumn";
            // 
            // lineSubTotalDataGridViewTextBoxColumn
            // 
            this.lineSubTotalDataGridViewTextBoxColumn.DataPropertyName = "LineSubTotal";
            this.lineSubTotalDataGridViewTextBoxColumn.HeaderText = "LineSubTotal";
            this.lineSubTotalDataGridViewTextBoxColumn.Name = "lineSubTotalDataGridViewTextBoxColumn";
            // 
            // lineGrandTotalDataGridViewTextBoxColumn
            // 
            this.lineGrandTotalDataGridViewTextBoxColumn.DataPropertyName = "LineGrandTotal";
            this.lineGrandTotalDataGridViewTextBoxColumn.HeaderText = "LineGrandTotal";
            this.lineGrandTotalDataGridViewTextBoxColumn.Name = "lineGrandTotalDataGridViewTextBoxColumn";
            // 
            // isNewRowDataGridViewCheckBoxColumn
            // 
            this.isNewRowDataGridViewCheckBoxColumn.DataPropertyName = "IsNewRow";
            this.isNewRowDataGridViewCheckBoxColumn.HeaderText = "IsNewRow";
            this.isNewRowDataGridViewCheckBoxColumn.Name = "isNewRowDataGridViewCheckBoxColumn";
            this.isNewRowDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // frmIssueSaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 581);
            this.Name = "frmIssueSaleInvoice";
            this.Text = "إصدار فاتورة مبيعات";
            this.Load += new System.EventHandler(this.frmIssueSaleInvoice_Load);
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
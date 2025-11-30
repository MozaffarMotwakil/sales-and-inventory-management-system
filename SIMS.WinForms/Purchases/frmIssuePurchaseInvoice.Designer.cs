namespace SIMS.WinForms.Inventory
{
    partial class frmIssuePurchaseInvoice
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
            this.llAddPersonSupplier = new System.Windows.Forms.LinkLabel();
            this.llAddOrganizationSupplier = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.vwSuppliersDetailsBindingSource)).BeginInit();
            this.gbInvoiceSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
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
            // gbInvoiceDetails
            // 
            this.gbInvoiceDetails.Controls.Add(this.llAddOrganizationSupplier);
            this.gbInvoiceDetails.Controls.Add(this.llAddPersonSupplier);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.label1, 0);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.label2, 0);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.label3, 0);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.label5, 0);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.dtpInvoiceIssueDate, 0);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.cbSupplier, 0);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.cbWarehouse, 0);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.llAddPersonSupplier, 0);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.txtInvoiceNo, 0);
            this.gbInvoiceDetails.Controls.SetChildIndex(this.llAddOrganizationSupplier, 0);
            // 
            // dtpInvoiceIssueDate
            // 
            this.dtpInvoiceIssueDate.Value = new System.DateTime(2025, 11, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Text = "المورد:";
            // 
            // llAddPersonSupplier
            // 
            this.llAddPersonSupplier.AutoSize = true;
            this.llAddPersonSupplier.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddPersonSupplier.Location = new System.Drawing.Point(870, 112);
            this.llAddPersonSupplier.Name = "llAddPersonSupplier";
            this.llAddPersonSupplier.Size = new System.Drawing.Size(137, 14);
            this.llAddPersonSupplier.TabIndex = 37;
            this.llAddPersonSupplier.TabStop = true;
            this.llAddPersonSupplier.Text = "إضافة مورد جديد (شخص)";
            this.llAddPersonSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddPersonSupplier_LinkClicked);
            // 
            // llAddOrganizationSupplier
            // 
            this.llAddOrganizationSupplier.AutoSize = true;
            this.llAddOrganizationSupplier.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddOrganizationSupplier.Location = new System.Drawing.Point(729, 112);
            this.llAddOrganizationSupplier.Name = "llAddOrganizationSupplier";
            this.llAddOrganizationSupplier.Size = new System.Drawing.Size(135, 14);
            this.llAddOrganizationSupplier.TabIndex = 37;
            this.llAddOrganizationSupplier.TabStop = true;
            this.llAddOrganizationSupplier.Text = "إضافة مورد جديد (منظمة)";
            this.llAddOrganizationSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddOrganizationSupplier_LinkClicked);
            // 
            // frmIssuePurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 657);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmIssuePurchaseInvoice";
            this.Text = "إصدار فاتورة مشتريات";
            this.Load += new System.EventHandler(this.frmReceiveNewGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwSuppliersDetailsBindingSource)).EndInit();
            this.gbInvoiceSummary.ResumeLayout(false);
            this.gbInvoiceSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
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

        private System.Windows.Forms.LinkLabel llAddPersonSupplier;
        private System.Windows.Forms.LinkLabel llAddOrganizationSupplier;
    }
}
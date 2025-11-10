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
            this.btnCancle = new System.Windows.Forms.Button();
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
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(547, 129);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.TabStop = false;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmShowInvoiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(1209, 300);
            this.Controls.Add(this.ctrInvoiceInfo);
            this.Controls.Add(this.btnCancle);
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
        private System.Windows.Forms.Button btnCancle;
    }
}
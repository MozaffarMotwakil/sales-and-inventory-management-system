namespace SIMS.WinForms.Suppliers
{
    partial class frmShowSupplierInfo
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
            this.ctrSupplierInfo = new SIMS.WinForms.Suppliers.ctrSupplierInfo();
            this.SuspendLayout();
            // 
            // ctrSupplierInfo
            // 
            this.ctrSupplierInfo.Location = new System.Drawing.Point(12, 12);
            this.ctrSupplierInfo.Name = "ctrSupplierInfo";
            this.ctrSupplierInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrSupplierInfo.Size = new System.Drawing.Size(600, 265);
            this.ctrSupplierInfo.Supplier = null;
            this.ctrSupplierInfo.TabIndex = 0;
            this.ctrSupplierInfo.SizeChanged += new System.EventHandler(this.ctrSupplierInfo_SizeChanged);
            // 
            // frmShowSupplierInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 286);
            this.Controls.Add(this.ctrSupplierInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowSupplierInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض معلومات مورد";
            this.Load += new System.EventHandler(this.frmShowSupplierInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrSupplierInfo ctrSupplierInfo;
    }
}
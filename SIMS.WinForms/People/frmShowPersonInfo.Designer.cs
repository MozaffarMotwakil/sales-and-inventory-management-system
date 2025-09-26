namespace SIMS.WinForms.People
{
    partial class frmShowPersonInfo
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
            this.ctrPersonInfo = new SIMS.WinForms.People.ctrPersonInfo();
            this.SuspendLayout();
            // 
            // ctrPersonInfo
            // 
            this.ctrPersonInfo.Location = new System.Drawing.Point(3, 2);
            this.ctrPersonInfo.Name = "ctrPersonInfo";
            this.ctrPersonInfo.Person = null;
            this.ctrPersonInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrPersonInfo.Size = new System.Drawing.Size(600, 241);
            this.ctrPersonInfo.TabIndex = 0;
            // 
            // frmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 246);
            this.Controls.Add(this.ctrPersonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowPersonInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض معلومات شخص";
            this.Load += new System.EventHandler(this.frmShowPersonInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrPersonInfo ctrPersonInfo;
    }
}
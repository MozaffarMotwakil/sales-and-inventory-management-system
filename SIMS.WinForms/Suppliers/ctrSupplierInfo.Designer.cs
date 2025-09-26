namespace SIMS.WinForms.Suppliers
{
    partial class ctrSupplierInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.ctrPersonInfo = new SIMS.WinForms.People.ctrPersonInfo();
            this.ctrOrganizationInfo = new SIMS.WinForms.Organizations.ctrOrganizationInfo();
            this.SuspendLayout();
            // 
            // lblNotesTitle
            // 
            this.lblNotesTitle.AutoSize = true;
            this.lblNotesTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesTitle.Location = new System.Drawing.Point(520, 244);
            this.lblNotesTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotesTitle.Name = "lblNotesTitle";
            this.lblNotesTitle.Size = new System.Drawing.Size(75, 16);
            this.lblNotesTitle.TabIndex = 56;
            this.lblNotesTitle.Text = "الملاحظات:";
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Black;
            this.lblNotes.Location = new System.Drawing.Point(5, 244);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(459, 16);
            this.lblNotes.TabIndex = 55;
            this.lblNotes.Text = "N/A";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctrPersonInfo
            // 
            this.ctrPersonInfo.Location = new System.Drawing.Point(0, 0);
            this.ctrPersonInfo.Name = "ctrPersonInfo";
            this.ctrPersonInfo.Person = null;
            this.ctrPersonInfo.PersonType = BusinessLogic.clsParty.enPartyType.Supplier;
            this.ctrPersonInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrPersonInfo.Size = new System.Drawing.Size(600, 241);
            this.ctrPersonInfo.TabIndex = 57;
            // 
            // ctrOrganizationInfo
            // 
            this.ctrOrganizationInfo.Location = new System.Drawing.Point(0, 0);
            this.ctrOrganizationInfo.Name = "ctrOrganizationInfo";
            this.ctrOrganizationInfo.Organization = null;
            this.ctrOrganizationInfo.OrganizationType = BusinessLogic.clsParty.enPartyType.Supplier;
            this.ctrOrganizationInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrOrganizationInfo.Size = new System.Drawing.Size(600, 175);
            this.ctrOrganizationInfo.TabIndex = 53;
            // 
            // ctrSupplierInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrPersonInfo);
            this.Controls.Add(this.lblNotesTitle);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.ctrOrganizationInfo);
            this.Name = "ctrSupplierInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(600, 265);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Organizations.ctrOrganizationInfo ctrOrganizationInfo;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.Label lblNotes;
        private People.ctrPersonInfo ctrPersonInfo;
    }
}

namespace SIMS.WinForms.Organizations
{
    partial class ctrOrganizationInfo
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
            this.llContactPerson = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrPartyInfo = new SIMS.WinForms.Parties.ctrPartyInfo();
            this.ctrPartyInfo1 = new SIMS.WinForms.Parties.ctrPartyInfo();
            this.SuspendLayout();
            // 
            // llContactPerson
            // 
            this.llContactPerson.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llContactPerson.Location = new System.Drawing.Point(3, 152);
            this.llContactPerson.Name = "llContactPerson";
            this.llContactPerson.Size = new System.Drawing.Size(461, 16);
            this.llContactPerson.TabIndex = 35;
            this.llContactPerson.TabStop = true;
            this.llContactPerson.Text = "N/A";
            this.llContactPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llContactPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llContactPerson_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "إسم جهة التواصل:";
            // 
            // ctrPartyInfo
            // 
            this.ctrPartyInfo.Location = new System.Drawing.Point(0, -1);
            this.ctrPartyInfo.Name = "ctrPartyInfo";
            this.ctrPartyInfo.PartyCategory = BusinessLogic.clsParty.enPartyCategory.Organization;
            this.ctrPartyInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrPartyInfo.Size = new System.Drawing.Size(600, 150);
            this.ctrPartyInfo.TabIndex = 36;
            // 
            // ctrPartyInfo1
            // 
            this.ctrPartyInfo1.Location = new System.Drawing.Point(0, -1);
            this.ctrPartyInfo1.Name = "ctrPartyInfo1";
            this.ctrPartyInfo1.PartyCategory = BusinessLogic.clsParty.enPartyCategory.Organization;
            this.ctrPartyInfo1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrPartyInfo1.Size = new System.Drawing.Size(600, 150);
            this.ctrPartyInfo1.TabIndex = 36;
            // 
            // ctrOrganizationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrPartyInfo);
            this.Controls.Add(this.llContactPerson);
            this.Controls.Add(this.label3);
            this.Name = "ctrOrganizationInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(600, 175);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llContactPerson;
        private System.Windows.Forms.Label label3;
        private Parties.ctrPartyInfo ctrPartyInfo;
        private Parties.ctrPartyInfo ctrPartyInfo1;
    }
}

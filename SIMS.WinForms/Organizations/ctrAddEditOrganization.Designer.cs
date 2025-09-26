namespace SIMS.WinForms.Organizations
{
    partial class ctrAddEditOrganization
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
            this.components = new System.ComponentModel.Container();
            this.gbBasicInfo = new System.Windows.Forms.GroupBox();
            this.btnDeleteContactPerson = new System.Windows.Forms.Button();
            this.llAddContactPerson = new System.Windows.Forms.LinkLabel();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrAddEditParty = new SIMS.WinForms.Parties.ctrAddEditParty();
            this.gbBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBasicInfo
            // 
            this.gbBasicInfo.Controls.Add(this.btnDeleteContactPerson);
            this.gbBasicInfo.Controls.Add(this.llAddContactPerson);
            this.gbBasicInfo.Controls.Add(this.txtContactPerson);
            this.gbBasicInfo.Controls.Add(this.label3);
            this.gbBasicInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBasicInfo.Location = new System.Drawing.Point(7, 259);
            this.gbBasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbBasicInfo.Name = "gbBasicInfo";
            this.gbBasicInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbBasicInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbBasicInfo.Size = new System.Drawing.Size(489, 98);
            this.gbBasicInfo.TabIndex = 1;
            this.gbBasicInfo.TabStop = false;
            this.gbBasicInfo.Text = "معلومات إضافية عن المنظمة";
            // 
            // btnDeleteContactPerson
            // 
            this.btnDeleteContactPerson.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteContactPerson.BackgroundImage = global::SIMS.WinForms.Properties.Resources.delete;
            this.btnDeleteContactPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteContactPerson.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDeleteContactPerson.FlatAppearance.BorderSize = 0;
            this.btnDeleteContactPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContactPerson.Location = new System.Drawing.Point(20, 46);
            this.btnDeleteContactPerson.Name = "btnDeleteContactPerson";
            this.btnDeleteContactPerson.Size = new System.Drawing.Size(27, 23);
            this.btnDeleteContactPerson.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnDeleteContactPerson, "حذف جهة التواصل داخل المنظمة");
            this.btnDeleteContactPerson.UseVisualStyleBackColor = false;
            this.btnDeleteContactPerson.Click += new System.EventHandler(this.btnDeleteContactPerson_Click);
            // 
            // llAddContactPerson
            // 
            this.llAddContactPerson.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddContactPerson.Location = new System.Drawing.Point(176, 75);
            this.llAddContactPerson.Name = "llAddContactPerson";
            this.llAddContactPerson.Size = new System.Drawing.Size(305, 16);
            this.llAddContactPerson.TabIndex = 3;
            this.llAddContactPerson.TabStop = true;
            this.llAddContactPerson.Text = "إضافة جهة تواصل داخل المنظمة";
            this.llAddContactPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llAddContactPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddContactPerson_LinkClicked);
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.Location = new System.Drawing.Point(20, 44);
            this.txtContactPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.ReadOnly = true;
            this.txtContactPerson.Size = new System.Drawing.Size(458, 27);
            this.txtContactPerson.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "جهة التواصل داخل المنظمة";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ctrAddEditParty
            // 
            this.ctrAddEditParty.Address = "";
            this.ctrAddEditParty.CountryID = ((byte)(164));
            this.ctrAddEditParty.Email = "";
            this.ctrAddEditParty.Location = new System.Drawing.Point(3, 3);
            this.ctrAddEditParty.Name = "ctrAddEditParty";
            this.ctrAddEditParty.PartyCategory = BusinessLogic.clsParty.enPartyCategory.Organization;
            this.ctrAddEditParty.PartyName = "";
            this.ctrAddEditParty.PartyType = BusinessLogic.clsParty.enPartyType.Supplier;
            this.ctrAddEditParty.Phone = "";
            this.ctrAddEditParty.Size = new System.Drawing.Size(497, 249);
            this.ctrAddEditParty.TabIndex = 0;
            // 
            // ctrAddEditOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbBasicInfo);
            this.Controls.Add(this.ctrAddEditParty);
            this.Name = "ctrAddEditOrganization";
            this.Size = new System.Drawing.Size(503, 360);
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Parties.ctrAddEditParty ctrAddEditParty;
        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.Button btnDeleteContactPerson;
        private System.Windows.Forms.LinkLabel llAddContactPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtContactPerson;
    }
}

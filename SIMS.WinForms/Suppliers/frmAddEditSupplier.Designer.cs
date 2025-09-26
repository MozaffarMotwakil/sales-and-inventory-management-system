namespace SIMS.WinForms.Suppliers
{
    partial class frmAddEditSupplier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditSupplier));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.gbOtherInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.ctrAddEditOrganization = new SIMS.WinForms.Organizations.ctrAddEditOrganization();
            this.ctrAddEditPerson = new SIMS.WinForms.People.ctrAddEditPerson();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbOtherInfo.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            resources.ApplyResources(this.lblFormTitle, "lblFormTitle");
            this.lblFormTitle.Name = "lblFormTitle";
            // 
            // gbOtherInfo
            // 
            this.gbOtherInfo.Controls.Add(this.label7);
            this.gbOtherInfo.Controls.Add(this.txtNotes);
            resources.ApplyResources(this.gbOtherInfo, "gbOtherInfo");
            this.gbOtherInfo.Name = "gbOtherInfo";
            this.gbOtherInfo.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtNotes
            // 
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.txtNotes.Name = "txtNotes";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancle, "btnCancle");
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.ctrAddEditPerson);
            this.panel.Controls.Add(this.lblFormTitle);
            this.panel.Controls.Add(this.ctrAddEditOrganization);
            this.panel.Controls.Add(this.btnCancle);
            this.panel.Controls.Add(this.btnSave);
            this.panel.Controls.Add(this.gbOtherInfo);
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // ctrAddEditOrganization
            // 
            resources.ApplyResources(this.ctrAddEditOrganization, "ctrAddEditOrganization");
            this.ctrAddEditOrganization.Name = "ctrAddEditOrganization";
            // 
            // ctrAddEditPerson
            // 
            resources.ApplyResources(this.ctrAddEditPerson, "ctrAddEditPerson");
            this.ctrAddEditPerson.Name = "ctrAddEditPerson";
            this.ctrAddEditPerson.PersonType = BusinessLogic.clsParty.enPartyType.Supplier;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // frmAddEditSupplier
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditSupplier";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmAddEditSupplier_Load);
            this.gbOtherInfo.ResumeLayout(false);
            this.gbOtherInfo.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox gbOtherInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private People.ctrAddEditPerson ctrAddEditPerson;
        private Organizations.ctrAddEditOrganization ctrAddEditOrganization;
    }
}
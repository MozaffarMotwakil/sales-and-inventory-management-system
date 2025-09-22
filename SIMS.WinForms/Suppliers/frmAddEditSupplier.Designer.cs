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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrAddEditPerson1 = new SIMS.WinForms.People.ctrAddEditPerson();
            this.gbOtherInfo.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            resources.ApplyResources(this.lblFormTitle, "lblFormTitle");
            this.errorProvider.SetError(this.lblFormTitle, resources.GetString("lblFormTitle.Error"));
            this.errorProvider.SetIconAlignment(this.lblFormTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblFormTitle.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblFormTitle, ((int)(resources.GetObject("lblFormTitle.IconPadding"))));
            this.lblFormTitle.Name = "lblFormTitle";
            // 
            // gbOtherInfo
            // 
            resources.ApplyResources(this.gbOtherInfo, "gbOtherInfo");
            this.gbOtherInfo.Controls.Add(this.label7);
            this.gbOtherInfo.Controls.Add(this.txtNotes);
            this.errorProvider.SetError(this.gbOtherInfo, resources.GetString("gbOtherInfo.Error"));
            this.errorProvider.SetIconAlignment(this.gbOtherInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbOtherInfo.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.gbOtherInfo, ((int)(resources.GetObject("gbOtherInfo.IconPadding"))));
            this.gbOtherInfo.Name = "gbOtherInfo";
            this.gbOtherInfo.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // txtNotes
            // 
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.errorProvider.SetError(this.txtNotes, resources.GetString("txtNotes.Error"));
            this.errorProvider.SetIconAlignment(this.txtNotes, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNotes.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtNotes, ((int)(resources.GetObject("txtNotes.IconPadding"))));
            this.txtNotes.Name = "txtNotes";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.errorProvider.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorProvider.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            resources.ApplyResources(this.btnCancle, "btnCancle");
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider.SetError(this.btnCancle, resources.GetString("btnCancle.Error"));
            this.errorProvider.SetIconAlignment(this.btnCancle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancle.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnCancle, ((int)(resources.GetObject("btnCancle.IconPadding"))));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // panel
            // 
            resources.ApplyResources(this.panel, "panel");
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.ctrAddEditPerson1);
            this.panel.Controls.Add(this.btnCancle);
            this.panel.Controls.Add(this.btnSave);
            this.panel.Controls.Add(this.gbOtherInfo);
            this.panel.Controls.Add(this.lblFormTitle);
            this.errorProvider.SetError(this.panel, resources.GetString("panel.Error"));
            this.errorProvider.SetIconAlignment(this.panel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.panel, ((int)(resources.GetObject("panel.IconPadding"))));
            this.panel.Name = "panel";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // ctrAddEditPerson1
            // 
            resources.ApplyResources(this.ctrAddEditPerson1, "ctrAddEditPerson1");
            this.errorProvider.SetError(this.ctrAddEditPerson1, resources.GetString("ctrAddEditPerson1.Error"));
            this.errorProvider.SetIconAlignment(this.ctrAddEditPerson1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ctrAddEditPerson1.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.ctrAddEditPerson1, ((int)(resources.GetObject("ctrAddEditPerson1.IconPadding"))));
            this.ctrAddEditPerson1.Name = "ctrAddEditPerson1";
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
        private People.ctrAddEditPerson ctrAddEditPerson1;
    }
}
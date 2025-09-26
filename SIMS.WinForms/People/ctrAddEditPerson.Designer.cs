namespace SIMS.WinForms.People
{
    partial class ctrAddEditPerson
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
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.llDeletePersonImage = new System.Windows.Forms.LinkLabel();
            this.llSetPersonImage = new System.Windows.Forms.LinkLabel();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNationalNa = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrAddEditParty = new SIMS.WinForms.Parties.ctrAddEditParty();
            this.gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Controls.Add(this.llDeletePersonImage);
            this.gbPersonInfo.Controls.Add(this.llSetPersonImage);
            this.gbPersonInfo.Controls.Add(this.pbPersonImage);
            this.gbPersonInfo.Controls.Add(this.dtpBirthDate);
            this.gbPersonInfo.Controls.Add(this.rbFemale);
            this.gbPersonInfo.Controls.Add(this.rbMale);
            this.gbPersonInfo.Controls.Add(this.label4);
            this.gbPersonInfo.Controls.Add(this.label3);
            this.gbPersonInfo.Controls.Add(this.label2);
            this.gbPersonInfo.Controls.Add(this.txtNationalNa);
            this.gbPersonInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonInfo.Location = new System.Drawing.Point(7, 259);
            this.gbPersonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbPersonInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbPersonInfo.Size = new System.Drawing.Size(489, 203);
            this.gbPersonInfo.TabIndex = 1;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "معلومات إضافية عن الشخص";
            // 
            // llDeletePersonImage
            // 
            this.llDeletePersonImage.AutoSize = true;
            this.llDeletePersonImage.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.llDeletePersonImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.llDeletePersonImage.LinkColor = System.Drawing.Color.Red;
            this.llDeletePersonImage.Location = new System.Drawing.Point(56, 180);
            this.llDeletePersonImage.Name = "llDeletePersonImage";
            this.llDeletePersonImage.Size = new System.Drawing.Size(72, 16);
            this.llDeletePersonImage.TabIndex = 7;
            this.llDeletePersonImage.TabStop = true;
            this.llDeletePersonImage.Text = "حذف الصورة";
            this.llDeletePersonImage.Visible = false;
            this.llDeletePersonImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDeletePersonImage_LinkClicked);
            // 
            // llSetPersonImage
            // 
            this.llSetPersonImage.AutoSize = true;
            this.llSetPersonImage.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.llSetPersonImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.llSetPersonImage.Location = new System.Drawing.Point(58, 163);
            this.llSetPersonImage.Name = "llSetPersonImage";
            this.llSetPersonImage.Size = new System.Drawing.Size(68, 16);
            this.llSetPersonImage.TabIndex = 6;
            this.llSetPersonImage.TabStop = true;
            this.llSetPersonImage.Text = "تعيين صورة";
            this.llSetPersonImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetPersonImage_LinkClicked);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::SIMS.WinForms.Properties.Resources.unknow_male;
            this.pbPersonImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbPersonImage.Location = new System.Drawing.Point(8, 24);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(168, 136);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 43;
            this.pbPersonImage.TabStop = false;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtpBirthDate.Location = new System.Drawing.Point(196, 103);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.RightToLeftLayout = true;
            this.dtpBirthDate.Size = new System.Drawing.Size(282, 23);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.rbFemale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbFemale.Location = new System.Drawing.Point(361, 166);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(50, 20);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.Text = "أنثى";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbGender_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.rbMale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbMale.Location = new System.Drawing.Point(436, 166);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(42, 20);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "ذكر";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbGender_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(432, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "الجنس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(404, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "تاريخ الميلاد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(392, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "الرقم الوطني";
            // 
            // txtNationalNa
            // 
            this.txtNationalNa.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNationalNa.Location = new System.Drawing.Point(196, 44);
            this.txtNationalNa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalNa.Name = "txtNationalNa";
            this.txtNationalNa.Size = new System.Drawing.Size(282, 27);
            this.txtNationalNa.TabIndex = 2;
            this.txtNationalNa.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNa_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // ctrAddEditParty
            // 
            this.ctrAddEditParty.Address = "";
            this.ctrAddEditParty.CountryID = ((byte)(164));
            this.ctrAddEditParty.Email = "";
            this.ctrAddEditParty.Location = new System.Drawing.Point(3, 3);
            this.ctrAddEditParty.Name = "ctrAddEditParty";
            this.ctrAddEditParty.PartyCategory = BusinessLogic.clsParty.enPartyCategory.Person;
            this.ctrAddEditParty.PartyName = "";
            this.ctrAddEditParty.PartyType = BusinessLogic.clsParty.enPartyType.Supplier;
            this.ctrAddEditParty.Phone = "";
            this.ctrAddEditParty.Size = new System.Drawing.Size(497, 249);
            this.ctrAddEditParty.TabIndex = 0;
            // 
            // ctrAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPersonInfo);
            this.Controls.Add(this.ctrAddEditParty);
            this.Name = "ctrAddEditPerson";
            this.Size = new System.Drawing.Size(503, 464);
            this.Load += new System.EventHandler(this.ctrAddEditPerson_Load);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Parties.ctrAddEditParty ctrAddEditParty;
        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNationalNa;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llDeletePersonImage;
        private System.Windows.Forms.LinkLabel llSetPersonImage;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

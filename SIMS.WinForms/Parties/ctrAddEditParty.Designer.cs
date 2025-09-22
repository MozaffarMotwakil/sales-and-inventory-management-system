namespace SIMS.WinForms.Parties
{
    partial class ctrAddEditParty
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
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.lblPartyTypeName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBasicInfo
            // 
            this.gbBasicInfo.Controls.Add(this.cbCountry);
            this.gbBasicInfo.Controls.Add(this.label9);
            this.gbBasicInfo.Controls.Add(this.label6);
            this.gbBasicInfo.Controls.Add(this.txtAddress);
            this.gbBasicInfo.Controls.Add(this.txtPhone);
            this.gbBasicInfo.Controls.Add(this.label5);
            this.gbBasicInfo.Controls.Add(this.txtEmail);
            this.gbBasicInfo.Controls.Add(this.label1);
            this.gbBasicInfo.Controls.Add(this.txtPartyName);
            this.gbBasicInfo.Controls.Add(this.lblPartyTypeName);
            this.gbBasicInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBasicInfo.Location = new System.Drawing.Point(4, 3);
            this.gbBasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbBasicInfo.Name = "gbBasicInfo";
            this.gbBasicInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbBasicInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbBasicInfo.Size = new System.Drawing.Size(489, 244);
            this.gbBasicInfo.TabIndex = 0;
            this.gbBasicInfo.TabStop = false;
            this.gbBasicInfo.Text = "المعلومات الأساسية";
            // 
            // cbCountry
            // 
            this.cbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCountry.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "أفغانستان",
            "ألبانيا",
            "الجزائر",
            "أندورا",
            "أنغولا",
            "أنتيغوا وبربودا",
            "الأرجنتين",
            "أرمينيا",
            "أستراليا",
            "النمسا",
            "أذربيجان",
            "الباهاما",
            "البحرين",
            "بنغلاديش",
            "باربادوس",
            "بيلاروسيا",
            "بلجيكا",
            "بليز",
            "بنين",
            "بوتان",
            "بوليفيا",
            "البوسنة والهرسك",
            "بوتسوانا",
            "البرازيل",
            "بروناي",
            "بلغاريا",
            "بوركينا فاسو",
            "بوروندي",
            "الرأس الأخضر",
            "كمبوديا",
            "الكاميرون",
            "كندا",
            "جمهورية أفريقيا الوسطى",
            "تشاد",
            "تشيلي",
            "الصين",
            "كولومبيا",
            "جزر القمر",
            "الكونغو(برازافيل)",
            "الكونغو(كينشاسا)",
            "كوستاريكا",
            "ساحل العاج",
            "كرواتيا",
            "كوبا",
            "قبرص",
            "جمهورية التشيك",
            "الدنمارك",
            "جيبوتي",
            "دومينيكا",
            "جمهورية الدومينيكان",
            "الإكوادور",
            "مصر",
            "السلفادور",
            "غينيا الاستوائية",
            "إريتريا",
            "إستونيا",
            "إثيوبيا",
            "فيجي",
            "فنلندا",
            "فرنسا",
            "الغابون",
            "غامبيا",
            "جورجيا",
            "ألمانيا",
            "غانا",
            "اليونان",
            "غرينادا",
            "غواتيمالا",
            "غينيا",
            "غينيا بيساو",
            "غيانا",
            "هايتي",
            "هندوراس",
            "هنغاريا",
            "آيسلندا",
            "الهند",
            "إندونيسيا",
            "إيران",
            "العراق",
            "إيرلندا",
            "إيطاليا",
            "جامايكا",
            "اليابان",
            "الأردن",
            "كازاخستان",
            "كينيا",
            "كيريباتي",
            "كوريا الشمالية",
            "كوريا الجنوبية",
            "الكويت",
            "قيرغيزستان",
            "لاوس",
            "لاتفيا",
            "لبنان",
            "ليسوتو",
            "ليبيريا",
            "ليبيا",
            "ليختنشتاين",
            "ليتوانيا",
            "لوكسمبورغ",
            "مدغشقر",
            "مالاوي",
            "ماليزيا",
            "المالديف",
            "مالي",
            "مالطا",
            "جزر مارشال",
            "موريتانيا",
            "موريشيوس",
            "المكسيك",
            "مايكرونيزيا",
            "مولدوفا",
            "موناكو",
            "منغوليا",
            "الجبل الأسود",
            "المغرب",
            "موزمبيق",
            "ميانمار",
            "ناميبيا",
            "ناورو",
            "نيبال",
            "هولندا",
            "نيوزيلندا",
            "نيكاراغوا",
            "النيجر",
            "نيجيريا",
            "مقدونيا الشمالية",
            "النرويج",
            "سلطنة عمان",
            "باكستان",
            "بالاو",
            "فلسطين",
            "بنما",
            "بابوا غينيا الجديدة",
            "باراغواي",
            "بيرو",
            "الفلبين",
            "بولندا",
            "البرتغال",
            "قطر",
            "رومانيا",
            "روسيا",
            "رواندا",
            "سانت كيتس ونيفيس",
            "سانت لوسيا",
            "سانت فنسنت والغرينادين",
            "ساموا",
            "سان مارينو",
            "ساو تومي وبرينسيبي",
            "المملكة العربية السعودية",
            "السنغال",
            "صربيا",
            "سيشل",
            "سيراليون",
            "سنغافورة",
            "سلوفاكيا",
            "سلوفينيا",
            "جزر سليمان",
            "الصومال",
            "جنوب أفريقيا",
            "جنوب السودان",
            "إسبانيا",
            "سريلانكا",
            "السودان",
            "سورينام",
            "السويد",
            "سويسرا",
            "سوريا",
            "طاجيكستان",
            "تنزانيا",
            "تايلاند",
            "تيمور الشرقية",
            "توغو",
            "تونغا",
            "ترينيداد وتوباغو",
            "تونس",
            "تركيا",
            "تركمانستان",
            "توفالو",
            "أوغندا",
            "أوكرانيا",
            "الإمارات العربية المتحدة",
            "المملكة المتحدة",
            "الولايات المتحدة",
            "أوروغواي",
            "أوزبكستان",
            "فانواتو",
            "فنزويلا",
            "فيتنام",
            "اليمن",
            "زامبيا",
            "زيمبابوي"});
            this.cbCountry.Location = new System.Drawing.Point(253, 100);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(225, 24);
            this.cbCountry.TabIndex = 2;
            this.cbCountry.Leave += new System.EventHandler(this.cbCountry_Leave);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "الجنسية";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "العنوان";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(20, 209);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(458, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(20, 100);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(225, 23);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "البريد الإلكتروني";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(20, 153);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(458, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "رقم الهاتف";
            // 
            // txtPartyName
            // 
            this.txtPartyName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyName.Location = new System.Drawing.Point(20, 44);
            this.txtPartyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(458, 27);
            this.txtPartyName.TabIndex = 1;
            this.txtPartyName.Validating += new System.ComponentModel.CancelEventHandler(this.txtPartyName_Validating);
            // 
            // lblPartyTypeName
            // 
            this.lblPartyTypeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyTypeName.Location = new System.Drawing.Point(20, 24);
            this.lblPartyTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartyTypeName.Name = "lblPartyTypeName";
            this.lblPartyTypeName.Size = new System.Drawing.Size(461, 16);
            this.lblPartyTypeName.TabIndex = 10;
            this.lblPartyTypeName.Text = "إسم الكيان";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // ctrAddEditParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbBasicInfo);
            this.Name = "ctrAddEditParty";
            this.Size = new System.Drawing.Size(497, 249);
            this.Load += new System.EventHandler(this.ctrAddEditParty_Load);
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Label lblPartyTypeName;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

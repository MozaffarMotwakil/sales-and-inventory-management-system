namespace SIMS.WinForms.Products
{
    partial class frmAddEditProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalOtherUnits = new System.Windows.Forms.Label();
            this.llAddOtherUnits = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateBarcode = new System.Windows.Forms.Button();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.cbBaseUnit = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llAddOrganizationSupplier = new System.Windows.Forms.LinkLabel();
            this.llAddPersonSupplier = new System.Windows.Forms.LinkLabel();
            this.cbMainSupplier = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labal10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrProductImage = new SIMS.WinForms.Utilities.ctrImage();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 487);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(350, 432);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "    حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(228, 432);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 13;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(682, 117);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "معلومات أخرى";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(19, 25);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(535, 83);
            this.txtDescription.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(620, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "الوصف:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTotalOtherUnits);
            this.groupBox2.Controls.Add(this.llAddOtherUnits);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnGenerateBarcode);
            this.groupBox2.Controls.Add(this.txtProductBarcode);
            this.groupBox2.Controls.Add(this.txtSellingPrice);
            this.groupBox2.Controls.Add(this.cbBaseUnit);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 137);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات الوحدة الأساسية والوحدات البديلة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 14);
            this.label3.TabIndex = 64;
            this.label3.Text = "الوحدة الأساسية:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 62;
            this.label5.Text = "سعر البيع:";
            // 
            // lblTotalOtherUnits
            // 
            this.lblTotalOtherUnits.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOtherUnits.ForeColor = System.Drawing.Color.Black;
            this.lblTotalOtherUnits.Location = new System.Drawing.Point(19, 49);
            this.lblTotalOtherUnits.Name = "lblTotalOtherUnits";
            this.lblTotalOtherUnits.Size = new System.Drawing.Size(28, 16);
            this.lblTotalOtherUnits.TabIndex = 60;
            this.lblTotalOtherUnits.Text = "0";
            this.lblTotalOtherUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llAddOtherUnits
            // 
            this.llAddOtherUnits.AutoSize = true;
            this.llAddOtherUnits.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddOtherUnits.Location = new System.Drawing.Point(441, 49);
            this.llAddOtherUnits.Name = "llAddOtherUnits";
            this.llAddOtherUnits.Size = new System.Drawing.Size(116, 16);
            this.llAddOtherUnits.TabIndex = 7;
            this.llAddOtherUnits.TabStop = true;
            this.llAddOtherUnits.Text = "إدارة الوحدات البديلة";
            this.llAddOtherUnits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddOtherUnits_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(53, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "عدد الوحدات البديلة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 63;
            this.label2.Text = "الباركود:";
            // 
            // btnGenerateBarcode
            // 
            this.btnGenerateBarcode.BackColor = System.Drawing.Color.White;
            this.btnGenerateBarcode.BackgroundImage = global::SIMS.WinForms.Properties.Resources.generate_barcode;
            this.btnGenerateBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateBarcode.FlatAppearance.BorderSize = 0;
            this.btnGenerateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBarcode.Location = new System.Drawing.Point(19, 72);
            this.btnGenerateBarcode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGenerateBarcode.Name = "btnGenerateBarcode";
            this.btnGenerateBarcode.Size = new System.Drawing.Size(31, 20);
            this.btnGenerateBarcode.TabIndex = 9;
            this.btnGenerateBarcode.UseVisualStyleBackColor = false;
            this.btnGenerateBarcode.Click += new System.EventHandler(this.btnGenerateBarcode_Click);
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductBarcode.Location = new System.Drawing.Point(19, 72);
            this.txtProductBarcode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(535, 23);
            this.txtProductBarcode.TabIndex = 8;
            this.txtProductBarcode.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductBarcode_Validating);
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(19, 105);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(535, 23);
            this.txtSellingPrice.TabIndex = 10;
            this.txtSellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellingPrice_KeyPress);
            this.txtSellingPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtSellingPrice_Validating);
            // 
            // cbBaseUnit
            // 
            this.cbBaseUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBaseUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBaseUnit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaseUnit.FormattingEnabled = true;
            this.cbBaseUnit.Location = new System.Drawing.Point(19, 23);
            this.cbBaseUnit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbBaseUnit.Name = "cbBaseUnit";
            this.cbBaseUnit.Size = new System.Drawing.Size(535, 24);
            this.cbBaseUnit.TabIndex = 6;
            this.cbBaseUnit.Text = "إختار وحدة القياس الأساسية";
            this.cbBaseUnit.Enter += new System.EventHandler(this.cbUnit_Enter);
            this.cbBaseUnit.Leave += new System.EventHandler(this.cbUnit_Leave);
            this.cbBaseUnit.Validating += new System.ComponentModel.CancelEventHandler(this.cbBaseUnit_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llAddOrganizationSupplier);
            this.groupBox1.Controls.Add(this.llAddPersonSupplier);
            this.groupBox1.Controls.Add(this.cbMainSupplier);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labal10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctrProductImage);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 158);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الأساسية";
            // 
            // llAddOrganizationSupplier
            // 
            this.llAddOrganizationSupplier.AutoSize = true;
            this.llAddOrganizationSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddOrganizationSupplier.Location = new System.Drawing.Point(260, 131);
            this.llAddOrganizationSupplier.Name = "llAddOrganizationSupplier";
            this.llAddOrganizationSupplier.Size = new System.Drawing.Size(145, 16);
            this.llAddOrganizationSupplier.TabIndex = 4;
            this.llAddOrganizationSupplier.TabStop = true;
            this.llAddOrganizationSupplier.Text = "إضافة مورد جديد (منظمة)";
            this.llAddOrganizationSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddOrganizationSupplier_LinkClicked);
            // 
            // llAddPersonSupplier
            // 
            this.llAddPersonSupplier.AutoSize = true;
            this.llAddPersonSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddPersonSupplier.Location = new System.Drawing.Point(411, 131);
            this.llAddPersonSupplier.Name = "llAddPersonSupplier";
            this.llAddPersonSupplier.Size = new System.Drawing.Size(146, 16);
            this.llAddPersonSupplier.TabIndex = 3;
            this.llAddPersonSupplier.TabStop = true;
            this.llAddPersonSupplier.Text = "إضافة مورد جديد (شخص)";
            this.llAddPersonSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddPersonSupplier_LinkClicked);
            // 
            // cbMainSupplier
            // 
            this.cbMainSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMainSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMainSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMainSupplier.FormattingEnabled = true;
            this.cbMainSupplier.Location = new System.Drawing.Point(212, 105);
            this.cbMainSupplier.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbMainSupplier.Name = "cbMainSupplier";
            this.cbMainSupplier.Size = new System.Drawing.Size(342, 24);
            this.cbMainSupplier.TabIndex = 2;
            this.cbMainSupplier.Text = "إختار المورد الأساسي";
            this.cbMainSupplier.Enter += new System.EventHandler(this.cbMainSupllier_Enter);
            this.cbMainSupplier.Leave += new System.EventHandler(this.cbMainSupllier_Leave);
            // 
            // cbCategory
            // 
            this.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(212, 64);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(342, 24);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.Text = "إختار التصنيف/الفئة";
            this.cbCategory.Enter += new System.EventHandler(this.cbCatigory_Enter);
            this.cbCategory.Leave += new System.EventHandler(this.cbCatigory_Leave);
            this.cbCategory.Validating += new System.ComponentModel.CancelEventHandler(this.cbCategory_Validating);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(212, 23);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(342, 23);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 14);
            this.label4.TabIndex = 43;
            this.label4.Text = "المورد الأساسي:";
            // 
            // labal10
            // 
            this.labal10.AutoSize = true;
            this.labal10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labal10.Location = new System.Drawing.Point(591, 68);
            this.labal10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labal10.Name = "labal10";
            this.labal10.Size = new System.Drawing.Size(84, 14);
            this.labal10.TabIndex = 42;
            this.labal10.Text = "الفئة/الصنف:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "إسم المنتج:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // ctrProductImage
            // 
            this.ctrProductImage.DefaultImage = global::SIMS.WinForms.Properties.Resources.product;
            this.ctrProductImage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrProductImage.ImageLocation = null;
            this.ctrProductImage.Location = new System.Drawing.Point(19, 23);
            this.ctrProductImage.Margin = new System.Windows.Forms.Padding(4);
            this.ctrProductImage.Name = "ctrProductImage";
            this.ctrProductImage.PictureBoxSizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctrProductImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrProductImage.Size = new System.Drawing.Size(173, 124);
            this.ctrProductImage.TabIndex = 5;
            // 
            // frmAddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(716, 511);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة/تعديل منتج";
            this.Load += new System.EventHandler(this.frmAddEditProduct_Load);
            this.Shown += new System.EventHandler(this.frmAddEditProduct_Shown);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Utilities.ctrImage ctrProductImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labal10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llAddOrganizationSupplier;
        private System.Windows.Forms.LinkLabel llAddPersonSupplier;
        private System.Windows.Forms.ComboBox cbMainSupplier;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalOtherUnits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel llAddOtherUnits;
        private System.Windows.Forms.Button btnGenerateBarcode;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.ComboBox cbBaseUnit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
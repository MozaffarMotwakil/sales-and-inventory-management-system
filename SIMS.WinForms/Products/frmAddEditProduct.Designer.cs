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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnDeleteContactPerson = new System.Windows.Forms.Button();
            this.btnGenerateBarcode = new System.Windows.Forms.Button();
            this.labal10 = new System.Windows.Forms.Label();
            this.cbCatigory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBaseUnit = new System.Windows.Forms.ComboBox();
            this.cbMainSupllier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.llAddPersonSupplier = new System.Windows.Forms.LinkLabel();
            this.llAddOtherUnits = new System.Windows.Forms.LinkLabel();
            this.llAddOrganizationSupplier = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalOtherUnits = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctrProductImage = new SIMS.WinForms.Utilities.ctrImage();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "سعر البيع:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "الباركود:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "إسم المنتج:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(142, 11);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(353, 23);
            this.txtProductName.TabIndex = 0;
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductBarcode.Location = new System.Drawing.Point(142, 57);
            this.txtProductBarcode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(353, 23);
            this.txtProductBarcode.TabIndex = 1;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(142, 204);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(551, 23);
            this.txtSellingPrice.TabIndex = 5;
            // 
            // btnDeleteContactPerson
            // 
            this.btnDeleteContactPerson.BackColor = System.Drawing.Color.White;
            this.btnDeleteContactPerson.BackgroundImage = global::SIMS.WinForms.Properties.Resources.delete;
            this.btnDeleteContactPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteContactPerson.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDeleteContactPerson.FlatAppearance.BorderSize = 0;
            this.btnDeleteContactPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContactPerson.Location = new System.Drawing.Point(665, 251);
            this.btnDeleteContactPerson.Name = "btnDeleteContactPerson";
            this.btnDeleteContactPerson.Size = new System.Drawing.Size(27, 22);
            this.btnDeleteContactPerson.TabIndex = 15;
            this.toolTip.SetToolTip(this.btnDeleteContactPerson, "حذف المورد الأساسي الذي تم إضافته");
            this.btnDeleteContactPerson.UseVisualStyleBackColor = false;
            this.btnDeleteContactPerson.Visible = false;
            // 
            // btnGenerateBarcode
            // 
            this.btnGenerateBarcode.BackColor = System.Drawing.Color.White;
            this.btnGenerateBarcode.BackgroundImage = global::SIMS.WinForms.Properties.Resources.generate_barcode;
            this.btnGenerateBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateBarcode.FlatAppearance.BorderSize = 0;
            this.btnGenerateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBarcode.Location = new System.Drawing.Point(464, 58);
            this.btnGenerateBarcode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGenerateBarcode.Name = "btnGenerateBarcode";
            this.btnGenerateBarcode.Size = new System.Drawing.Size(31, 20);
            this.btnGenerateBarcode.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnGenerateBarcode, "توليد باركود جديد");
            this.btnGenerateBarcode.UseVisualStyleBackColor = false;
            this.btnGenerateBarcode.Click += new System.EventHandler(this.btnGenerateBarcode_Click);
            // 
            // labal10
            // 
            this.labal10.AutoSize = true;
            this.labal10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labal10.Location = new System.Drawing.Point(7, 106);
            this.labal10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labal10.Name = "labal10";
            this.labal10.Size = new System.Drawing.Size(99, 16);
            this.labal10.TabIndex = 10;
            this.labal10.Text = "التصنيف/الفئة:";
            // 
            // cbCatigory
            // 
            this.cbCatigory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCatigory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCatigory.FormattingEnabled = true;
            this.cbCatigory.Items.AddRange(new object[] {
            "Accessories",
            "Baby Food",
            "Books & Magazines",
            "Bread & Pastries",
            "Canned Goods",
            "Car Tools",
            "Cheese & Dairy",
            "Children\'s Clothing",
            "Cleaning Tools",
            "Computers",
            "Cooking Tools",
            "Cosmetics",
            "Cookware",
            "Dishwashing Detergents",
            "Files",
            "Fish & Seafood",
            "Floor Cleaners",
            "Fruits",
            "Furniture",
            "Grains & Dried Goods",
            "Headphones & Accessories",
            "Home Appliances",
            "Juices",
            "Kids\' Clothing",
            "Laundry Detergents",
            "Meat & Poultry",
            "Medicines & Medical Products",
            "Men\'s Clothing",
            "Mobile Phones",
            "Nuts",
            "Notebooks & Paper",
            "Oils & Spices",
            "Pens",
            "Perfumes",
            "Pet Products",
            "Shampoo & Soap",
            "Shaving Tools",
            "Shoes",
            "Snacks",
            "Soft Drinks",
            "Sports Equipment",
            "Sweets",
            "Tea & Coffee",
            "Toys",
            "Trash Bags",
            "Vegetables",
            "Water",
            "Women\'s Clothing"});
            this.cbCatigory.Location = new System.Drawing.Point(142, 103);
            this.cbCatigory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbCatigory.Name = "cbCatigory";
            this.cbCatigory.Size = new System.Drawing.Size(353, 24);
            this.cbCatigory.TabIndex = 3;
            this.cbCatigory.Text = "إختار التصنيف/الفئة";
            this.cbCatigory.Enter += new System.EventHandler(this.cbCatigory_Enter);
            this.cbCatigory.Leave += new System.EventHandler(this.cbCatigory_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "الوحدة الأساسية:";
            // 
            // cbBaseUnit
            // 
            this.cbBaseUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBaseUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBaseUnit.FormattingEnabled = true;
            this.cbBaseUnit.Items.AddRange(new object[] {
            "قطعة",
            "كرتونة",
            "علبة",
            "زجاجة",
            "كيلوغرام",
            "لتر",
            "كيس"});
            this.cbBaseUnit.Location = new System.Drawing.Point(142, 149);
            this.cbBaseUnit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbBaseUnit.Name = "cbBaseUnit";
            this.cbBaseUnit.Size = new System.Drawing.Size(353, 24);
            this.cbBaseUnit.TabIndex = 4;
            this.cbBaseUnit.Text = "إختار وحدة القياس";
            this.cbBaseUnit.Enter += new System.EventHandler(this.cbUnit_Enter);
            this.cbBaseUnit.Leave += new System.EventHandler(this.cbUnit_Leave);
            // 
            // cbMainSupllier
            // 
            this.cbMainSupllier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMainSupllier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMainSupllier.FormattingEnabled = true;
            this.cbMainSupllier.Location = new System.Drawing.Point(142, 250);
            this.cbMainSupllier.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbMainSupllier.Name = "cbMainSupllier";
            this.cbMainSupllier.Size = new System.Drawing.Size(551, 24);
            this.cbMainSupllier.TabIndex = 12;
            this.cbMainSupllier.Text = "إختار المورد الأساسي";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "المورد الأساسي:";
            // 
            // llAddPersonSupplier
            // 
            this.llAddPersonSupplier.AutoSize = true;
            this.llAddPersonSupplier.Location = new System.Drawing.Point(139, 276);
            this.llAddPersonSupplier.Name = "llAddPersonSupplier";
            this.llAddPersonSupplier.Size = new System.Drawing.Size(146, 16);
            this.llAddPersonSupplier.TabIndex = 14;
            this.llAddPersonSupplier.TabStop = true;
            this.llAddPersonSupplier.Text = "إضافة مورد جديد (شخص)";
            this.llAddPersonSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddPersonSupplier_LinkClicked);
            // 
            // llAddOtherUnits
            // 
            this.llAddOtherUnits.AutoSize = true;
            this.llAddOtherUnits.Location = new System.Drawing.Point(139, 175);
            this.llAddOtherUnits.Name = "llAddOtherUnits";
            this.llAddOtherUnits.Size = new System.Drawing.Size(106, 16);
            this.llAddOtherUnits.TabIndex = 14;
            this.llAddOtherUnits.TabStop = true;
            this.llAddOtherUnits.Text = "إضافة وحدات بديلة";
            this.llAddOtherUnits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddOtherUnits_LinkClicked);
            // 
            // llAddOrganizationSupplier
            // 
            this.llAddOrganizationSupplier.AutoSize = true;
            this.llAddOrganizationSupplier.Location = new System.Drawing.Point(291, 276);
            this.llAddOrganizationSupplier.Name = "llAddOrganizationSupplier";
            this.llAddOrganizationSupplier.Size = new System.Drawing.Size(145, 16);
            this.llAddOrganizationSupplier.TabIndex = 14;
            this.llAddOrganizationSupplier.TabStop = true;
            this.llAddOrganizationSupplier.Text = "إضافة مورد جديد (منظمة)";
            this.llAddOrganizationSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddOrganizationSupplier_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(244, 395);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 8;
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
            this.btnCancle.Location = new System.Drawing.Point(364, 395);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 9;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "مجموع الوحدات البديلة:";
            // 
            // lblTotalOtherUnits
            // 
            this.lblTotalOtherUnits.AutoSize = true;
            this.lblTotalOtherUnits.Location = new System.Drawing.Point(481, 175);
            this.lblTotalOtherUnits.Name = "lblTotalOtherUnits";
            this.lblTotalOtherUnits.Size = new System.Drawing.Size(14, 16);
            this.lblTotalOtherUnits.TabIndex = 16;
            this.lblTotalOtherUnits.Text = "0";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(142, 308);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(551, 83);
            this.txtDescription.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "الوصف:";
            // 
            // ctrProductImage
            // 
            this.ctrProductImage.DefaultImage = global::SIMS.WinForms.Properties.Resources.product;
            this.ctrProductImage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrProductImage.ImageLocation = null;
            this.ctrProductImage.Location = new System.Drawing.Point(523, 11);
            this.ctrProductImage.Margin = new System.Windows.Forms.Padding(4);
            this.ctrProductImage.Name = "ctrProductImage";
            this.ctrProductImage.PictureBoxSizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctrProductImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrProductImage.Size = new System.Drawing.Size(170, 180);
            this.ctrProductImage.TabIndex = 7;
            // 
            // frmAddEditProduct
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(716, 442);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalOtherUnits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteContactPerson);
            this.Controls.Add(this.llAddOtherUnits);
            this.Controls.Add(this.llAddOrganizationSupplier);
            this.Controls.Add(this.llAddPersonSupplier);
            this.Controls.Add(this.cbMainSupllier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrProductImage);
            this.Controls.Add(this.cbBaseUnit);
            this.Controls.Add(this.cbCatigory);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGenerateBarcode);
            this.Controls.Add(this.txtProductBarcode);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labal10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Button btnGenerateBarcode;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labal10;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbCatigory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBaseUnit;
        private System.Windows.Forms.ComboBox cbMainSupllier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llAddPersonSupplier;
        private System.Windows.Forms.LinkLabel llAddOtherUnits;
        private System.Windows.Forms.Button btnDeleteContactPerson;
        private System.Windows.Forms.LinkLabel llAddOrganizationSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalOtherUnits;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private Utilities.ctrImage ctrProductImage;
    }
}
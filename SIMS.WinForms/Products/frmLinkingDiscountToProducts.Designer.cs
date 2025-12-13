namespace SIMS.WinForms.Products
{
    partial class frmLinkingDiscountToProducts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPeriodOperation = new System.Windows.Forms.Label();
            this.lblActiveLinkingProduct = new System.Windows.Forms.Label();
            this.lblActivityStatus = new System.Windows.Forms.Label();
            this.lblDiscountName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trvProducts = new System.Windows.Forms.TreeView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.trvProducts);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 587);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPeriodOperation);
            this.groupBox1.Controls.Add(this.lblActiveLinkingProduct);
            this.groupBox1.Controls.Add(this.lblActivityStatus);
            this.groupBox1.Controls.Add(this.lblDiscountName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الخصم";
            // 
            // lblPeriodOperation
            // 
            this.lblPeriodOperation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodOperation.Location = new System.Drawing.Point(412, 47);
            this.lblPeriodOperation.Name = "lblPeriodOperation";
            this.lblPeriodOperation.Size = new System.Drawing.Size(301, 23);
            this.lblPeriodOperation.TabIndex = 0;
            this.lblPeriodOperation.Text = "yyyy/MM/dd - yyyy/MM/dd (N/A يوم)";
            this.lblPeriodOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActiveLinkingProduct
            // 
            this.lblActiveLinkingProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveLinkingProduct.Location = new System.Drawing.Point(6, 28);
            this.lblActiveLinkingProduct.Name = "lblActiveLinkingProduct";
            this.lblActiveLinkingProduct.Size = new System.Drawing.Size(211, 14);
            this.lblActiveLinkingProduct.TabIndex = 0;
            this.lblActiveLinkingProduct.Text = "N/A";
            this.lblActiveLinkingProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActivityStatus
            // 
            this.lblActivityStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityStatus.Location = new System.Drawing.Point(412, 70);
            this.lblActivityStatus.Name = "lblActivityStatus";
            this.lblActivityStatus.Size = new System.Drawing.Size(301, 23);
            this.lblActivityStatus.TabIndex = 0;
            this.lblActivityStatus.Text = "N/A";
            this.lblActivityStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountName
            // 
            this.lblDiscountName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountName.ForeColor = System.Drawing.Color.Red;
            this.lblDiscountName.Location = new System.Drawing.Point(412, 23);
            this.lblDiscountName.Name = "lblDiscountName";
            this.lblDiscountName.Size = new System.Drawing.Size(301, 23);
            this.lblDiscountName.TabIndex = 0;
            this.lblDiscountName.Text = "N/A";
            this.lblDiscountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 14);
            this.label8.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "عدد المنتجات المرتبطة بالخصم:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(719, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "حالة النشاط:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(713, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "فترة السريان:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(719, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "إسم الخصم:";
            // 
            // trvProducts
            // 
            this.trvProducts.CheckBoxes = true;
            this.trvProducts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvProducts.FullRowSelect = true;
            this.trvProducts.Location = new System.Drawing.Point(3, 110);
            this.trvProducts.Name = "trvProducts";
            this.trvProducts.RightToLeftLayout = true;
            this.trvProducts.Size = new System.Drawing.Size(804, 428);
            this.trvProducts.TabIndex = 1;
            this.trvProducts.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvProducts_AfterCheck);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(415, 543);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 14;
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
            this.btnCancle.Location = new System.Drawing.Point(293, 543);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 15;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmLinkingDiscountToProducts
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLinkingDiscountToProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ربط الخصم مع المنتجات";
            this.Load += new System.EventHandler(this.frmLinkingDiscountToProducts_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trvProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiscountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeriodOperation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblActiveLinkingProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblActivityStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
    }
}
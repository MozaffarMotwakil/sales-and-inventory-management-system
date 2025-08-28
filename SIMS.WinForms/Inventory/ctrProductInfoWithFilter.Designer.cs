namespace SIMS.WinForms.Inventory
{
    partial class ctrProductInfoWithFilter
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
            this.ctrProductInfo = new SIMS.WinForms.Inventory.ctrProductInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSearchBy = new System.Windows.Forms.GroupBox();
            this.rbBarcode = new System.Windows.Forms.RadioButton();
            this.rbProductName = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFilterText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gbSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrProductInfo
            // 
            this.ctrProductInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrProductInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrProductInfo.Location = new System.Drawing.Point(5, 63);
            this.ctrProductInfo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ctrProductInfo.Name = "ctrProductInfo";
            this.ctrProductInfo.Size = new System.Drawing.Size(636, 272);
            this.ctrProductInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gbSearchBy);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtFilterText);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 58);
            this.panel1.TabIndex = 1;
            // 
            // gbSearchBy
            // 
            this.gbSearchBy.Controls.Add(this.rbBarcode);
            this.gbSearchBy.Controls.Add(this.rbProductName);
            this.gbSearchBy.Location = new System.Drawing.Point(3, 3);
            this.gbSearchBy.Name = "gbSearchBy";
            this.gbSearchBy.Size = new System.Drawing.Size(229, 52);
            this.gbSearchBy.TabIndex = 6;
            this.gbSearchBy.TabStop = false;
            this.gbSearchBy.Text = "Search By";
            // 
            // rbBarcode
            // 
            this.rbBarcode.AutoSize = true;
            this.rbBarcode.Location = new System.Drawing.Point(141, 26);
            this.rbBarcode.Name = "rbBarcode";
            this.rbBarcode.Size = new System.Drawing.Size(79, 22);
            this.rbBarcode.TabIndex = 0;
            this.rbBarcode.Text = "Barcode";
            this.rbBarcode.UseVisualStyleBackColor = true;
            // 
            // rbProductName
            // 
            this.rbProductName.AutoSize = true;
            this.rbProductName.Checked = true;
            this.rbProductName.Location = new System.Drawing.Point(8, 26);
            this.rbProductName.Name = "rbProductName";
            this.rbProductName.Size = new System.Drawing.Size(119, 22);
            this.rbProductName.TabIndex = 0;
            this.rbProductName.TabStop = true;
            this.rbProductName.Text = "Product Name";
            this.rbProductName.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::SIMS.WinForms.Properties.Resources.search;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Location = new System.Drawing.Point(587, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(37, 27);
            this.btnFind.TabIndex = 5;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFilterText
            // 
            this.txtFilterText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterText.Location = new System.Drawing.Point(239, 22);
            this.txtFilterText.Name = "txtFilterText";
            this.txtFilterText.Size = new System.Drawing.Size(342, 27);
            this.txtFilterText.TabIndex = 0;
            // 
            // ctrProductInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrProductInfo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ctrProductInfoWithFilter";
            this.Size = new System.Drawing.Size(646, 337);
            this.Load += new System.EventHandler(this.ctrProductInfoWithFilter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSearchBy.ResumeLayout(false);
            this.gbSearchBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrProductInfo ctrProductInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilterText;
        private System.Windows.Forms.GroupBox gbSearchBy;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton rbBarcode;
        private System.Windows.Forms.RadioButton rbProductName;
    }
}

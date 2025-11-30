namespace SIMS.WinForms.Products
{
    partial class frmProductsList
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addProducrToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ctrProductInfo = new SIMS.WinForms.Products.ctrProductInfo();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Size = new System.Drawing.Size(142, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد المنتجات:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(159, 691);
            this.lblTotalRecords.Size = new System.Drawing.Size(154, 16);
            this.lblTotalRecords.Text = "4";
            // 
            // cbCategory
            // 
            this.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "كل التصنيفات"});
            this.cbCategory.Location = new System.Drawing.Point(643, 9);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 24);
            this.cbCategory.TabIndex = 45;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCatigory_SelectedIndexChanged);
            this.cbCategory.Leave += new System.EventHandler(this.cbCatigory_Leave);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProducrToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(1112, 40);
            this.toolStrip.TabIndex = 47;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addProducrToolStripButton
            // 
            this.addProducrToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducrToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.shopping_basket_add;
            this.addProducrToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addProducrToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addProducrToolStripButton.Name = "addProducrToolStripButton";
            this.addProducrToolStripButton.Size = new System.Drawing.Size(133, 37);
            this.addProducrToolStripButton.Text = "   إضافة منتج جديد";
            this.addProducrToolStripButton.Click += new System.EventHandler(this.addProducrToolStripButton_Click);
            // 
            // ctrProductInfo
            // 
            this.ctrProductInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrProductInfo.Location = new System.Drawing.Point(12, 43);
            this.ctrProductInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrProductInfo.Name = "ctrProductInfo";
            this.ctrProductInfo.Product = null;
            this.ctrProductInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrProductInfo.Size = new System.Drawing.Size(850, 270);
            this.ctrProductInfo.TabIndex = 46;
            this.ctrProductInfo.TabStop = false;
            this.ctrProductInfo.Visible = false;
            // 
            // frmProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.ctrProductInfo);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmProductsList";
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProductsList_Load);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.ctrProductInfo, 0);
            this.Controls.SetChildIndex(this.cbCategory, 0);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        private ctrProductInfo ctrProductInfo;
        protected System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addProducrToolStripButton;
    }
}
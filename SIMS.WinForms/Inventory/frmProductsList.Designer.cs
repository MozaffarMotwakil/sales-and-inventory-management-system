namespace SIMS.WinForms.Inventory
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
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalInventoryItems = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBelowAverageItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblItemsRunningLow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAddProduct = new System.Windows.Forms.ToolStripButton();
            this.btnEditProduct = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteProduct = new System.Windows.Forms.ToolStripButton();
            this.btnReceiveGoods = new System.Windows.Forms.ToolStripButton();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ctrProductInfo = new SIMS.WinForms.Inventory.ctrProductInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.AllowUserToAddRows = false;
            this.dgvProductsList.AllowUserToDeleteRows = false;
            this.dgvProductsList.AllowUserToOrderColumns = true;
            this.dgvProductsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Location = new System.Drawing.Point(14, 339);
            this.dgvProductsList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.ReadOnly = true;
            this.dgvProductsList.Size = new System.Drawing.Size(1120, 170);
            this.dgvProductsList.TabIndex = 0;
            this.dgvProductsList.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Controls.Add(this.lblTotalInventoryItems);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(908, 73);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 64);
            this.panel5.TabIndex = 2;
            // 
            // lblTotalInventoryItems
            // 
            this.lblTotalInventoryItems.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInventoryItems.Location = new System.Drawing.Point(4, 32);
            this.lblTotalInventoryItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalInventoryItems.Name = "lblTotalInventoryItems";
            this.lblTotalInventoryItems.Size = new System.Drawing.Size(218, 25);
            this.lblTotalInventoryItems.TabIndex = 4;
            this.lblTotalInventoryItems.Text = "1500";
            this.lblTotalInventoryItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total Inventory Items";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.lblBelowAverageItems);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(908, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 64);
            this.panel1.TabIndex = 2;
            // 
            // lblBelowAverageItems
            // 
            this.lblBelowAverageItems.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelowAverageItems.Location = new System.Drawing.Point(4, 32);
            this.lblBelowAverageItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBelowAverageItems.Name = "lblBelowAverageItems";
            this.lblBelowAverageItems.Size = new System.Drawing.Size(218, 25);
            this.lblBelowAverageItems.TabIndex = 4;
            this.lblBelowAverageItems.Text = "1500";
            this.lblBelowAverageItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Below Average Items";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.lblItemsRunningLow);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(908, 235);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 64);
            this.panel2.TabIndex = 2;
            // 
            // lblItemsRunningLow
            // 
            this.lblItemsRunningLow.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsRunningLow.Location = new System.Drawing.Point(4, 32);
            this.lblItemsRunningLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsRunningLow.Name = "lblItemsRunningLow";
            this.lblItemsRunningLow.Size = new System.Drawing.Size(218, 25);
            this.lblItemsRunningLow.TabIndex = 4;
            this.lblItemsRunningLow.Text = "1500";
            this.lblItemsRunningLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Items Running Low";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProduct,
            this.btnEditProduct,
            this.btnDeleteProduct,
            this.btnReceiveGoods});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(1148, 39);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Image = global::SIMS.WinForms.Properties.Resources.shopping_basket_add;
            this.btnAddProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(98, 36);
            this.btnAddProduct.Text = "   Add   ";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Image = global::SIMS.WinForms.Properties.Resources.shopping_basket_edit;
            this.btnEditProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(96, 36);
            this.btnEditProduct.Text = "   Edit   ";
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Image = global::SIMS.WinForms.Properties.Resources.shopping_basket_delete;
            this.btnDeleteProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(114, 36);
            this.btnDeleteProduct.Text = "   Delete   ";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnReceiveGoods
            // 
            this.btnReceiveGoods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveGoods.Image = global::SIMS.WinForms.Properties.Resources.recived_goods_32;
            this.btnReceiveGoods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReceiveGoods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceiveGoods.Name = "btnReceiveGoods";
            this.btnReceiveGoods.Size = new System.Drawing.Size(208, 36);
            this.btnReceiveGoods.Text = "   Receive New Goods   ";
            this.btnReceiveGoods.Click += new System.EventHandler(this.btnReceiveGoods_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(617, 7);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(140, 27);
            this.cbFilter.TabIndex = 14;
            // 
            // txtFilterText
            // 
            this.txtFilterText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterText.Location = new System.Drawing.Point(869, 7);
            this.txtFilterText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterText.Name = "txtFilterText";
            this.txtFilterText.Size = new System.Drawing.Size(265, 27);
            this.txtFilterText.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(805, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMS.WinForms.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(765, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SIMS.WinForms.Properties.Resources.filter;
            this.pictureBox4.Location = new System.Drawing.Point(527, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // ctrProductInfo
            // 
            this.ctrProductInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrProductInfo.Location = new System.Drawing.Point(14, 56);
            this.ctrProductInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrProductInfo.Name = "ctrProductInfo";
            this.ctrProductInfo.Size = new System.Drawing.Size(642, 270);
            this.ctrProductInfo.TabIndex = 4;
            this.ctrProductInfo.TabStop = false;
            // 
            // frmProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 523);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilterText);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.ctrProductInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvProductsList);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductsList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalInventoryItems;
        private System.Windows.Forms.Label lblBelowAverageItems;
        private System.Windows.Forms.Label lblItemsRunningLow;
        private ctrProductInfo ctrProductInfo;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnAddProduct;
        private System.Windows.Forms.ToolStripButton btnEditProduct;
        private System.Windows.Forms.ToolStripButton btnDeleteProduct;
        private System.Windows.Forms.ToolStripButton btnReceiveGoods;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilterText;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
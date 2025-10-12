namespace SIMS.WinForms.Warehouses
{
    partial class frmWarehousesList
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addWarehouseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cbWarehouseActivity = new System.Windows.Forms.ComboBox();
            this.ctrWarehouseInfo = new SIMS.WinForms.Warehouses.ctrWarehouseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Size = new System.Drawing.Size(136, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد المخازن:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(153, 437);
            this.lblTotalRecords.Text = "0";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWarehouseToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(900, 40);
            this.toolStrip.TabIndex = 48;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addWarehouseToolStripButton
            // 
            this.addWarehouseToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.warehouse_add;
            this.addWarehouseToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addWarehouseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addWarehouseToolStripButton.Name = "addWarehouseToolStripButton";
            this.addWarehouseToolStripButton.Size = new System.Drawing.Size(138, 37);
            this.addWarehouseToolStripButton.Text = "   إضافة مخزن جديد";
            this.addWarehouseToolStripButton.Click += new System.EventHandler(this.addWarehouseToolStripButton_Click);
            // 
            // cbWarehouseActivity
            // 
            this.cbWarehouseActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouseActivity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWarehouseActivity.FormattingEnabled = true;
            this.cbWarehouseActivity.Items.AddRange(new object[] {
            "كل المخازن",
            "المخازن النشطه",
            "المخازن الغير نشطه"});
            this.cbWarehouseActivity.Location = new System.Drawing.Point(559, 8);
            this.cbWarehouseActivity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbWarehouseActivity.Name = "cbWarehouseActivity";
            this.cbWarehouseActivity.Size = new System.Drawing.Size(200, 24);
            this.cbWarehouseActivity.TabIndex = 49;
            this.cbWarehouseActivity.SelectedIndexChanged += new System.EventHandler(this.cbWarehouseActivity_SelectedIndexChanged);
            // 
            // ctrWarehouseInfo
            // 
            this.ctrWarehouseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrWarehouseInfo.Location = new System.Drawing.Point(12, 43);
            this.ctrWarehouseInfo.Name = "ctrWarehouseInfo";
            this.ctrWarehouseInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrWarehouseInfo.Size = new System.Drawing.Size(876, 270);
            this.ctrWarehouseInfo.TabIndex = 50;
            this.ctrWarehouseInfo.UseWaitCursor = true;
            this.ctrWarehouseInfo.Visible = false;
            // 
            // frmWarehousesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 460);
            this.Controls.Add(this.ctrWarehouseInfo);
            this.Controls.Add(this.cbWarehouseActivity);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmWarehousesList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmWarehousesList_Load);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.pictureBox, 0);
            this.Controls.SetChildIndex(this.lblSearchHintText, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.cbWarehouseActivity, 0);
            this.Controls.SetChildIndex(this.ctrWarehouseInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addWarehouseToolStripButton;
        private System.Windows.Forms.ComboBox cbWarehouseActivity;
        private ctrWarehouseInfo ctrWarehouseInfo;
    }
}
namespace SIMS.WinForms.Products
{
    partial class frmUnitsList
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
            this.addUnitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Location = new System.Drawing.Point(13, 533);
            this.lblTotalRecordsText.Size = new System.Drawing.Size(137, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد الوحدات:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(158, 533);
            // 
            // searchPanel
            // 
            this.searchPanel.Location = new System.Drawing.Point(438, 7);
            this.searchPanel.Size = new System.Drawing.Size(284, 26);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(254, 0);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Size = new System.Drawing.Size(245, 16);
            this.lblSearchHintText.Text = "أدخل إسم الوحدة";
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(254, 26);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUnitToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(734, 40);
            this.toolStrip.TabIndex = 50;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addUnitToolStripButton
            // 
            this.addUnitToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUnitToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.ready_stock;
            this.addUnitToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addUnitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addUnitToolStripButton.Name = "addUnitToolStripButton";
            this.addUnitToolStripButton.Size = new System.Drawing.Size(142, 37);
            this.addUnitToolStripButton.Text = "   إضافة وحدة جديدة";
            this.addUnitToolStripButton.ToolTipText = "   إضافة مخزن جديد   ";
            this.addUnitToolStripButton.Click += new System.EventHandler(this.addUnitToolStripButton_Click);
            // 
            // frmUnitsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmUnitsList";
            this.ShowIcon = false;
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الوحدات";
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addUnitToolStripButton;
    }
}
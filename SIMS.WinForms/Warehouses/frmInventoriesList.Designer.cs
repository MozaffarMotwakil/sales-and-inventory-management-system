namespace SIMS.WinForms.Warehouses
{
    partial class frmInventoriesList
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
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Size = new System.Drawing.Size(150, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد المخزونات:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(167, 693);
            // 
            // searchPanel
            // 
            this.searchPanel.Location = new System.Drawing.Point(850, 7);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 40);
            this.panel1.TabIndex = 50;
            // 
            // frmInventoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.panel1);
            this.Name = "frmInventoriesList";
            this.ShowSearchTextBox = true;
            this.Load += new System.EventHandler(this.frmInventoriesList_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
    }
}
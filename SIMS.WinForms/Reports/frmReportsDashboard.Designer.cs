namespace SIMS.WinForms.Reports
{
    partial class frmReportsDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportsDashboard));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.mainReportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salesByCategoryReportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salesByDateReportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salesByEmployeeReporttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.profitAndLossReportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pnlReportsContainer = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainReportToolStripButton,
            this.salesByCategoryReportToolStripButton,
            this.salesByDateReportToolStripButton,
            this.salesByEmployeeReporttoolStripButton,
            this.profitAndLossReportToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(1, 1);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(1119, 30);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // mainReportToolStripButton
            // 
            this.mainReportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainReportToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainReportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mainReportToolStripButton.Image")));
            this.mainReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainReportToolStripButton.Name = "mainReportToolStripButton";
            this.mainReportToolStripButton.Size = new System.Drawing.Size(116, 27);
            this.mainReportToolStripButton.Text = "  Main Report  ";
            this.mainReportToolStripButton.Click += new System.EventHandler(this.mainReportToolStripButton_Click);
            // 
            // salesByCategoryReportToolStripButton
            // 
            this.salesByCategoryReportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.salesByCategoryReportToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesByCategoryReportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salesByCategoryReportToolStripButton.Image")));
            this.salesByCategoryReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salesByCategoryReportToolStripButton.Name = "salesByCategoryReportToolStripButton";
            this.salesByCategoryReportToolStripButton.Size = new System.Drawing.Size(205, 27);
            this.salesByCategoryReportToolStripButton.Text = "  Sales by Category Report  ";
            this.salesByCategoryReportToolStripButton.Click += new System.EventHandler(this.salesByCategoryReportToolStripButton_Click);
            // 
            // salesByDateReportToolStripButton
            // 
            this.salesByDateReportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.salesByDateReportToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesByDateReportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salesByDateReportToolStripButton.Image")));
            this.salesByDateReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salesByDateReportToolStripButton.Name = "salesByDateReportToolStripButton";
            this.salesByDateReportToolStripButton.Size = new System.Drawing.Size(174, 27);
            this.salesByDateReportToolStripButton.Text = "  Sales by Date Report  ";
            this.salesByDateReportToolStripButton.Click += new System.EventHandler(this.salesByDateReportToolStripButton_Click);
            // 
            // salesByEmployeeReporttoolStripButton
            // 
            this.salesByEmployeeReporttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.salesByEmployeeReporttoolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesByEmployeeReporttoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salesByEmployeeReporttoolStripButton.Image")));
            this.salesByEmployeeReporttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salesByEmployeeReporttoolStripButton.Name = "salesByEmployeeReporttoolStripButton";
            this.salesByEmployeeReporttoolStripButton.Size = new System.Drawing.Size(210, 27);
            this.salesByEmployeeReporttoolStripButton.Text = "  Sales by Employee Report  ";
            this.salesByEmployeeReporttoolStripButton.Click += new System.EventHandler(this.salesByEmployeeReportToolStripButton_Click);
            // 
            // profitAndLossReportToolStripButton
            // 
            this.profitAndLossReportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.profitAndLossReportToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitAndLossReportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("profitAndLossReportToolStripButton.Image")));
            this.profitAndLossReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profitAndLossReportToolStripButton.Name = "profitAndLossReportToolStripButton";
            this.profitAndLossReportToolStripButton.Size = new System.Drawing.Size(184, 27);
            this.profitAndLossReportToolStripButton.Text = "  Profit and Loss Report  ";
            this.profitAndLossReportToolStripButton.Click += new System.EventHandler(this.profitAndLossReportToolStripButton_Click);
            // 
            // pnlReportsContainer
            // 
            this.pnlReportsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportsContainer.Location = new System.Drawing.Point(0, 30);
            this.pnlReportsContainer.Name = "pnlReportsContainer";
            this.pnlReportsContainer.Size = new System.Drawing.Size(1120, 701);
            this.pnlReportsContainer.TabIndex = 6;
            // 
            // frmReportsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 731);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnlReportsContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportsDashboard";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Dashboard";
            this.Deactivate += new System.EventHandler(this.frmReportsDashboard_Deactivate);
            this.Load += new System.EventHandler(this.frmReportsDashboard_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton mainReportToolStripButton;
        private System.Windows.Forms.ToolStripButton salesByCategoryReportToolStripButton;
        private System.Windows.Forms.ToolStripButton salesByDateReportToolStripButton;
        private System.Windows.Forms.ToolStripButton salesByEmployeeReporttoolStripButton;
        private System.Windows.Forms.ToolStripButton profitAndLossReportToolStripButton;
        private System.Windows.Forms.Panel pnlReportsContainer;
    }
}
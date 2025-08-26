namespace SIMS.WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.DashboardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PointOfSelesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.InventoryToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.SuppliersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ReportsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UsersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.InvoicesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ActivityLogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LogoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.circularPictureBox = new ctrCircularPictureBox();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DashboardToolStripButton,
            this.PointOfSelesToolStripButton,
            this.InventoryToolStripButton3,
            this.SuppliersToolStripButton,
            this.ReportsToolStripButton,
            this.UsersToolStripButton,
            this.InvoicesToolStripButton,
            this.ActivityLogToolStripButton,
            this.LogoutToolStripButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 281);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(250, 330);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // DashboardToolStripButton
            // 
            this.DashboardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DashboardToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardToolStripButton.Image")));
            this.DashboardToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DashboardToolStripButton.Name = "DashboardToolStripButton";
            this.DashboardToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.DashboardToolStripButton.Text = " Dashboard";
            this.DashboardToolStripButton.Click += new System.EventHandler(this.DashboardToolStripButton_Click);
            // 
            // PointOfSelesToolStripButton
            // 
            this.PointOfSelesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PointOfSelesToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointOfSelesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PointOfSelesToolStripButton.Image")));
            this.PointOfSelesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PointOfSelesToolStripButton.Name = "PointOfSelesToolStripButton";
            this.PointOfSelesToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.PointOfSelesToolStripButton.Text = "Point of Seles";
            this.PointOfSelesToolStripButton.Click += new System.EventHandler(this.PointOfSelesToolStripButton_Click);
            // 
            // InventoryToolStripButton3
            // 
            this.InventoryToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InventoryToolStripButton3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("InventoryToolStripButton3.Image")));
            this.InventoryToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InventoryToolStripButton3.Name = "InventoryToolStripButton3";
            this.InventoryToolStripButton3.Size = new System.Drawing.Size(249, 36);
            this.InventoryToolStripButton3.Text = "Inventory";
            this.InventoryToolStripButton3.Click += new System.EventHandler(this.InventoryToolStripButton3_Click);
            // 
            // SuppliersToolStripButton
            // 
            this.SuppliersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SuppliersToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SuppliersToolStripButton.Image")));
            this.SuppliersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SuppliersToolStripButton.Name = "SuppliersToolStripButton";
            this.SuppliersToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.SuppliersToolStripButton.Text = "Suppliers";
            this.SuppliersToolStripButton.Click += new System.EventHandler(this.SuppliersToolStripButton_Click);
            // 
            // ReportsToolStripButton
            // 
            this.ReportsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReportsToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportsToolStripButton.Image")));
            this.ReportsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReportsToolStripButton.Name = "ReportsToolStripButton";
            this.ReportsToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.ReportsToolStripButton.Text = "Reports";
            this.ReportsToolStripButton.Click += new System.EventHandler(this.ReportsToolStripButton_Click);
            // 
            // UsersToolStripButton
            // 
            this.UsersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UsersToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UsersToolStripButton.Image")));
            this.UsersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsersToolStripButton.Name = "UsersToolStripButton";
            this.UsersToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.UsersToolStripButton.Text = "Users";
            this.UsersToolStripButton.Click += new System.EventHandler(this.UsersToolStripButton_Click);
            // 
            // InvoicesToolStripButton
            // 
            this.InvoicesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InvoicesToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("InvoicesToolStripButton.Image")));
            this.InvoicesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InvoicesToolStripButton.Name = "InvoicesToolStripButton";
            this.InvoicesToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.InvoicesToolStripButton.Text = "Invoices";
            this.InvoicesToolStripButton.Click += new System.EventHandler(this.InvoicesToolStripButton_Click);
            // 
            // ActivityLogToolStripButton
            // 
            this.ActivityLogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ActivityLogToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityLogToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ActivityLogToolStripButton.Image")));
            this.ActivityLogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActivityLogToolStripButton.Name = "ActivityLogToolStripButton";
            this.ActivityLogToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.ActivityLogToolStripButton.Text = "Activity Log";
            this.ActivityLogToolStripButton.Click += new System.EventHandler(this.ActivityLogToolStripButton_Click);
            // 
            // LogoutToolStripButton
            // 
            this.LogoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LogoutToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutToolStripButton.Image")));
            this.LogoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutToolStripButton.Name = "LogoutToolStripButton";
            this.LogoutToolStripButton.Size = new System.Drawing.Size(93, 36);
            this.LogoutToolStripButton.Text = "Logout";
            this.LogoutToolStripButton.Click += new System.EventHandler(this.LogoutToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.circularPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 230);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mozaffar_Mo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 52);
            this.panel2.TabIndex = 5;
            // 
            // circularPictureBox
            // 
            this.circularPictureBox.BackColor = System.Drawing.Color.White;
            this.circularPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox.Image")));
            this.circularPictureBox.Location = new System.Drawing.Point(51, 9);
            this.circularPictureBox.Name = "circularPictureBox";
            this.circularPictureBox.Size = new System.Drawing.Size(150, 150);
            this.circularPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox.TabIndex = 2;
            this.circularPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(250, 50, 0, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton DashboardToolStripButton;
        private System.Windows.Forms.ToolStripButton PointOfSelesToolStripButton;
        private System.Windows.Forms.ToolStripButton InventoryToolStripButton3;
        private System.Windows.Forms.ToolStripButton ReportsToolStripButton;
        private System.Windows.Forms.ToolStripButton LogoutToolStripButton;
        private ctrCircularPictureBox circularPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton SuppliersToolStripButton;
        private System.Windows.Forms.ToolStripButton UsersToolStripButton;
        private System.Windows.Forms.ToolStripButton InvoicesToolStripButton;
        private System.Windows.Forms.ToolStripButton ActivityLogToolStripButton;
        private System.Windows.Forms.Panel panel2;
    }
}


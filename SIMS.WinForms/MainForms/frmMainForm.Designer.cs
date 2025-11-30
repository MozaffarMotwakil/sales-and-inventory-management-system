namespace SIMS.WinForms
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.DashboardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PointOfSelesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SuppliersToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.SuppliersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuppliedItemsLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InventoryToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.WarehousesAndInventories = new System.Windows.Forms.ToolStripDropDownButton();
            this.WarehousesToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.InventoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransferOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchasesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ReportsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UsersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ActivityLogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LogoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circularPictureBox = new ctrCircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.ClockAndDateTimer = new System.Windows.Forms.Timer(this.components);
            this.PaymentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.DarkCyan;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DashboardToolStripButton,
            this.PointOfSelesToolStripButton,
            this.SuppliersToolStripDropDownButton,
            this.InventoryToolStripButton3,
            this.WarehousesAndInventories,
            this.PurchasesToolStripButton,
            this.ReportsToolStripButton,
            this.UsersToolStripButton,
            this.PaymentsToolStripButton,
            this.ActivityLogToolStripButton,
            this.LogoutToolStripButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 232);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(250, 468);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // DashboardToolStripButton
            // 
            this.DashboardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DashboardToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardToolStripButton.Image")));
            this.DashboardToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DashboardToolStripButton.Name = "DashboardToolStripButton";
            this.DashboardToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.DashboardToolStripButton.Text = "لمحة سريعة";
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
            this.PointOfSelesToolStripButton.Visible = false;
            this.PointOfSelesToolStripButton.Click += new System.EventHandler(this.PointOfSelesToolStripButton_Click);
            // 
            // SuppliersToolStripDropDownButton
            // 
            this.SuppliersToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SuppliersToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuppliersListToolStripMenuItem,
            this.SuppliedItemsLogToolStripMenuItem});
            this.SuppliersToolStripDropDownButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("SuppliersToolStripDropDownButton.Image")));
            this.SuppliersToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SuppliersToolStripDropDownButton.Name = "SuppliersToolStripDropDownButton";
            this.SuppliersToolStripDropDownButton.Size = new System.Drawing.Size(249, 36);
            this.SuppliersToolStripDropDownButton.Text = "الموردين";
            // 
            // SuppliersListToolStripMenuItem
            // 
            this.SuppliersListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersListToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supplier_32;
            this.SuppliersListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SuppliersListToolStripMenuItem.Name = "SuppliersListToolStripMenuItem";
            this.SuppliersListToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.SuppliersListToolStripMenuItem.Text = "قائمة الموردين";
            this.SuppliersListToolStripMenuItem.Click += new System.EventHandler(this.SuppliersToolStripButton_Click);
            // 
            // SuppliedItemsLogToolStripMenuItem
            // 
            this.SuppliedItemsLogToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliedItemsLogToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supplied_items_32;
            this.SuppliedItemsLogToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SuppliedItemsLogToolStripMenuItem.Name = "SuppliedItemsLogToolStripMenuItem";
            this.SuppliedItemsLogToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.SuppliedItemsLogToolStripMenuItem.Text = "سجل التوريد";
            this.SuppliedItemsLogToolStripMenuItem.Click += new System.EventHandler(this.SuppliedItemsLogToolStripMenuItem_Click);
            // 
            // InventoryToolStripButton3
            // 
            this.InventoryToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InventoryToolStripButton3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("InventoryToolStripButton3.Image")));
            this.InventoryToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InventoryToolStripButton3.Name = "InventoryToolStripButton3";
            this.InventoryToolStripButton3.Size = new System.Drawing.Size(249, 36);
            this.InventoryToolStripButton3.Text = "المنتجات";
            this.InventoryToolStripButton3.Click += new System.EventHandler(this.InventoryToolStripButton_Click);
            // 
            // WarehousesAndInventories
            // 
            this.WarehousesAndInventories.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WarehousesAndInventories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WarehousesToolStripButton,
            this.InventoriesToolStripMenuItem,
            this.StockTransactionsToolStripMenuItem,
            this.TransferOperationsToolStripMenuItem});
            this.WarehousesAndInventories.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehousesAndInventories.Image = ((System.Drawing.Image)(resources.GetObject("WarehousesAndInventories.Image")));
            this.WarehousesAndInventories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WarehousesAndInventories.Name = "WarehousesAndInventories";
            this.WarehousesAndInventories.Size = new System.Drawing.Size(249, 36);
            this.WarehousesAndInventories.Text = "المخازن و المخزون";
            // 
            // WarehousesToolStripButton
            // 
            this.WarehousesToolStripButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehousesToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.warehouse;
            this.WarehousesToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.WarehousesToolStripButton.Name = "WarehousesToolStripButton";
            this.WarehousesToolStripButton.Size = new System.Drawing.Size(218, 38);
            this.WarehousesToolStripButton.Text = "المخازن";
            this.WarehousesToolStripButton.Click += new System.EventHandler(this.WarehousesToolStripButton_Click);
            // 
            // InventoriesToolStripMenuItem
            // 
            this.InventoriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoriesToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.packages;
            this.InventoriesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InventoriesToolStripMenuItem.Name = "InventoriesToolStripMenuItem";
            this.InventoriesToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.InventoriesToolStripMenuItem.Text = "المخزون";
            this.InventoriesToolStripMenuItem.Click += new System.EventHandler(this.InventoriesToolStripMenuItem_Click);
            // 
            // StockTransactionsToolStripMenuItem
            // 
            this.StockTransactionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTransactionsToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.stock_market;
            this.StockTransactionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StockTransactionsToolStripMenuItem.Name = "StockTransactionsToolStripMenuItem";
            this.StockTransactionsToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.StockTransactionsToolStripMenuItem.Text = "حركات المخزون";
            this.StockTransactionsToolStripMenuItem.Click += new System.EventHandler(this.StockTransactionsToolStripMenuItem_Click);
            // 
            // TransferOperationsToolStripMenuItem
            // 
            this.TransferOperationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferOperationsToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supply;
            this.TransferOperationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TransferOperationsToolStripMenuItem.Name = "TransferOperationsToolStripMenuItem";
            this.TransferOperationsToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.TransferOperationsToolStripMenuItem.Text = "عمليات النقل";
            this.TransferOperationsToolStripMenuItem.Click += new System.EventHandler(this.TransferOperationsToolStripMenuItem_Click);
            // 
            // PurchasesToolStripButton
            // 
            this.PurchasesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PurchasesToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PurchasesToolStripButton.Name = "PurchasesToolStripButton";
            this.PurchasesToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.PurchasesToolStripButton.Text = "المشتريات";
            this.PurchasesToolStripButton.Click += new System.EventHandler(this.PurchasesToolStripButton_Click);
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
            this.ReportsToolStripButton.Visible = false;
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
            this.UsersToolStripButton.Visible = false;
            this.UsersToolStripButton.Click += new System.EventHandler(this.UsersToolStripButton_Click);
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
            this.ActivityLogToolStripButton.Visible = false;
            this.ActivityLogToolStripButton.Click += new System.EventHandler(this.ActivityLogToolStripButton_Click);
            // 
            // LogoutToolStripButton
            // 
            this.LogoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LogoutToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutToolStripButton.Image")));
            this.LogoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutToolStripButton.Name = "LogoutToolStripButton";
            this.LogoutToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.LogoutToolStripButton.Text = "تسجيل الخروج";
            this.LogoutToolStripButton.Click += new System.EventHandler(this.LogoutToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.circularPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 239);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2, 197);
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
            this.label1.Location = new System.Drawing.Point(2, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mozaffar_Mo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularPictureBox
            // 
            this.circularPictureBox.BackColor = System.Drawing.Color.White;
            this.circularPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox.Image")));
            this.circularPictureBox.Location = new System.Drawing.Point(49, 15);
            this.circularPictureBox.Name = "circularPictureBox";
            this.circularPictureBox.Size = new System.Drawing.Size(150, 150);
            this.circularPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox.TabIndex = 2;
            this.circularPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblCurrentDate);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblCurrentTime);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 50);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "سوبرماركت الواحة";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.White;
            this.lblCurrentDate.Location = new System.Drawing.Point(3, 15);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(134, 23);
            this.lblCurrentDate.TabIndex = 7;
            this.lblCurrentDate.Text = "dd/MM/yyyy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SIMS.WinForms.Properties.Resources.al_waha_mall;
            this.pictureBox1.Location = new System.Drawing.Point(651, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(136, 15);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(132, 23);
            this.lblCurrentTime.TabIndex = 8;
            this.lblCurrentTime.Text = "00:00:00 AM";
            // 
            // ClockAndDateTimer
            // 
            this.ClockAndDateTimer.Interval = 1000;
            this.ClockAndDateTimer.Tick += new System.EventHandler(this.ClockAndDateTimer_Tick);
            // 
            // InvoicesToolStripButton
            // 
            this.PaymentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PaymentsToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("InvoicesToolStripButton.Image")));
            this.PaymentsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaymentsToolStripButton.Name = "InvoicesToolStripButton";
            this.PaymentsToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.PaymentsToolStripButton.Text = "المدفوعات/المقبوضات";
            this.PaymentsToolStripButton.Click += new System.EventHandler(this.PaymentsToolStripButton_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 700);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMainForm";
            this.Padding = new System.Windows.Forms.Padding(250, 50, 0, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripButton UsersToolStripButton;
        private System.Windows.Forms.ToolStripButton ActivityLogToolStripButton;
        private System.Windows.Forms.ToolStripButton PurchasesToolStripButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripDropDownButton WarehousesAndInventories;
        private System.Windows.Forms.ToolStripMenuItem InventoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WarehousesToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem TransferOperationsToolStripMenuItem;
        private System.Windows.Forms.Timer ClockAndDateTimer;
        private System.Windows.Forms.ToolStripDropDownButton SuppliersToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem SuppliersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuppliedItemsLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton PaymentsToolStripButton;
    }
}


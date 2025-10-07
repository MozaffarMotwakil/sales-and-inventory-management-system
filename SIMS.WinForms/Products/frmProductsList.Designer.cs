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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalInventoryItems = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBelowAverageItems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblItemsRunningLow = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.ToolStripButton();
            this.cbCatigory = new System.Windows.Forms.ComboBox();
            this.lblSearchHintText = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPages = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addProducrToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMainSupllier = new System.Windows.Forms.ComboBox();
            this.ctrProductInfo = new SIMS.WinForms.Products.ctrProductInfo();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Controls.Add(this.lblTotalInventoryItems);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(888, 62);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 64);
            this.panel5.TabIndex = 2;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // lblTotalInventoryItems
            // 
            this.lblTotalInventoryItems.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInventoryItems.Location = new System.Drawing.Point(4, 32);
            this.lblTotalInventoryItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalInventoryItems.Name = "lblTotalInventoryItems";
            this.lblTotalInventoryItems.Size = new System.Drawing.Size(218, 25);
            this.lblTotalInventoryItems.TabIndex = 4;
            this.lblTotalInventoryItems.Text = "N/A";
            this.lblTotalInventoryItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalInventoryItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "إجمالي عدد المنتجات";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.lblBelowAverageItems);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(888, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 64);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // lblBelowAverageItems
            // 
            this.lblBelowAverageItems.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelowAverageItems.Location = new System.Drawing.Point(4, 32);
            this.lblBelowAverageItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBelowAverageItems.Name = "lblBelowAverageItems";
            this.lblBelowAverageItems.Size = new System.Drawing.Size(218, 25);
            this.lblBelowAverageItems.TabIndex = 4;
            this.lblBelowAverageItems.Text = "N/A";
            this.lblBelowAverageItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBelowAverageItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "عدد المنتجات تحت حد الإنذار";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "عدد المنتجات التي نفذت";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.lblItemsRunningLow);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(888, 224);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 64);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // lblItemsRunningLow
            // 
            this.lblItemsRunningLow.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsRunningLow.Location = new System.Drawing.Point(4, 32);
            this.lblItemsRunningLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsRunningLow.Name = "lblItemsRunningLow";
            this.lblItemsRunningLow.Size = new System.Drawing.Size(218, 25);
            this.lblItemsRunningLow.TabIndex = 4;
            this.lblItemsRunningLow.Text = "N/A";
            this.lblItemsRunningLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemsRunningLow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(23, 23);
            // 
            // cbCatigory
            // 
            this.cbCatigory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCatigory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCatigory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCatigory.FormattingEnabled = true;
            this.cbCatigory.Items.AddRange(new object[] {
            "كل التصنيفات"});
            this.cbCatigory.Location = new System.Drawing.Point(557, 8);
            this.cbCatigory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCatigory.Name = "cbCatigory";
            this.cbCatigory.Size = new System.Drawing.Size(200, 24);
            this.cbCatigory.TabIndex = 1;
            this.cbCatigory.SelectedIndexChanged += new System.EventHandler(this.cbCatigory_SelectedIndexChanged);
            this.cbCatigory.Leave += new System.EventHandler(this.cbCatigory_Leave);
            this.cbCatigory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.AutoSize = true;
            this.lblSearchHintText.BackColor = System.Drawing.Color.White;
            this.lblSearchHintText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearchHintText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHintText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchHintText.Location = new System.Drawing.Point(799, 11);
            this.lblSearchHintText.Name = "lblSearchHintText";
            this.lblSearchHintText.Size = new System.Drawing.Size(47, 16);
            this.lblSearchHintText.TabIndex = 32;
            this.lblSearchHintText.Text = "الرسالة";
            this.lblSearchHintText.Click += new System.EventHandler(this.pictureBoxAndSearchHintText_Click);
            this.lblSearchHintText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox.Image = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.pictureBox.Location = new System.Drawing.Point(764, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(29, 25);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 33;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBoxAndSearchHintText_Click);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(792, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(342, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.lblCurrentPage);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(424, 573);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 40);
            this.panel3.TabIndex = 38;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Image = global::SIMS.WinForms.Properties.Resources.back;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 40);
            this.btnPrevious.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnPrevious, "الصفحة التالية");
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::SIMS.WinForms.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(226, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 40);
            this.btnNext.TabIndex = 8;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.btnNext, "الصفحة السابقة");
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCurrentPage.Location = new System.Drawing.Point(78, 12);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(33, 16);
            this.lblCurrentPage.TabIndex = 3;
            this.lblCurrentPage.Text = "N/A";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "الصفحة الحالية:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "مجموع الصفحات:";
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPages.AutoSize = true;
            this.lblTotalPages.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPages.Location = new System.Drawing.Point(131, 597);
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(28, 16);
            this.lblTotalPages.TabIndex = 35;
            this.lblTotalPages.Text = "N/A";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(131, 573);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(28, 16);
            this.lblTotalRecords.TabIndex = 36;
            this.lblTotalRecords.Text = "N/A";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 573);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "مجموع المنتجات:";
            // 
            // addProducrToolStripButton
            // 
            this.addProducrToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducrToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.shopping_basket_add;
            this.addProducrToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addProducrToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addProducrToolStripButton.Name = "addProducrToolStripButton";
            this.addProducrToolStripButton.Size = new System.Drawing.Size(159, 36);
            this.addProducrToolStripButton.Text = "   إضافة منتج جديد   ";
            this.addProducrToolStripButton.Click += new System.EventHandler(this.addProducrToolStripButton_Click);
            this.addProducrToolStripButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProducrToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(1148, 39);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductsList.Location = new System.Drawing.Point(15, 318);
            this.dgvProductsList.MultiSelect = false;
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.ReadOnly = true;
            this.dgvProductsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductsList.RowHeadersVisible = false;
            this.dgvProductsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductsList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsList.Size = new System.Drawing.Size(1119, 249);
            this.dgvProductsList.TabIndex = 39;
            this.dgvProductsList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductsList_CellMouseClick);
            this.dgvProductsList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductsList_CellMouseDoubleClick);
            this.dgvProductsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProductsList_DataBindingComplete);
            this.dgvProductsList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(124, 80);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.edit;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.editToolStripMenuItem.Text = "تعديل";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.delete;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.deleteToolStripMenuItem.Text = "حذف";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cbMainSupllier
            // 
            this.cbMainSupllier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMainSupllier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMainSupllier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMainSupllier.FormattingEnabled = true;
            this.cbMainSupllier.Items.AddRange(new object[] {
            "كل الموردين"});
            this.cbMainSupllier.Location = new System.Drawing.Point(349, 8);
            this.cbMainSupllier.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbMainSupllier.Name = "cbMainSupllier";
            this.cbMainSupllier.Size = new System.Drawing.Size(200, 24);
            this.cbMainSupllier.TabIndex = 40;
            this.cbMainSupllier.SelectedIndexChanged += new System.EventHandler(this.cbMainSupllier_SelectedIndexChanged);
            // 
            // ctrProductInfo
            // 
            this.ctrProductInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrProductInfo.Location = new System.Drawing.Point(15, 42);
            this.ctrProductInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrProductInfo.Name = "ctrProductInfo";
            this.ctrProductInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrProductInfo.Size = new System.Drawing.Size(642, 270);
            this.ctrProductInfo.TabIndex = 4;
            this.ctrProductInfo.TabStop = false;
            this.ctrProductInfo.Visible = false;
            // 
            // frmProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 625);
            this.Controls.Add(this.cbMainSupllier);
            this.Controls.Add(this.dgvProductsList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalPages);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSearchHintText);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbCatigory);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.ctrProductInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.frmProductsList_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProductsList_FormClosed);
            this.Load += new System.EventHandler(this.frmProductsList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalInventoryItems;
        private System.Windows.Forms.Label lblBelowAverageItems;
        private System.Windows.Forms.Label lblItemsRunningLow;
        private System.Windows.Forms.ToolStripButton btnAddProduct;
        private System.Windows.Forms.ComboBox cbCatigory;
        private System.Windows.Forms.Label lblSearchHintText;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPages;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip;
        private ctrProductInfo ctrProductInfo;
        private System.Windows.Forms.ToolStripButton addProducrToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.DataGridView dgvProductsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbMainSupllier;
    }
}
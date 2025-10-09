namespace SIMS.WinForms.Suppliers
{
    partial class frmSuppliersList
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
            this.dgvSuppliersList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAddSupplier = new System.Windows.Forms.ToolStripDropDownButton();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSearchHintText = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblTotalSuppliersCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbSupplierCategory = new System.Windows.Forms.ComboBox();
            this.ctrSupplierInfo = new SIMS.WinForms.Suppliers.ctrSupplierInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersList)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSuppliersList
            // 
            this.dgvSuppliersList.AllowUserToAddRows = false;
            this.dgvSuppliersList.AllowUserToDeleteRows = false;
            this.dgvSuppliersList.AllowUserToOrderColumns = true;
            this.dgvSuppliersList.AllowUserToResizeRows = false;
            this.dgvSuppliersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliersList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliersList.ContextMenuStrip = this.contextMenuStrip;
            this.dgvSuppliersList.Location = new System.Drawing.Point(13, 319);
            this.dgvSuppliersList.MultiSelect = false;
            this.dgvSuppliersList.Name = "dgvSuppliersList";
            this.dgvSuppliersList.ReadOnly = true;
            this.dgvSuppliersList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliersList.RowHeadersVisible = false;
            this.dgvSuppliersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSuppliersList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliersList.Size = new System.Drawing.Size(875, 119);
            this.dgvSuppliersList.TabIndex = 2;
            this.dgvSuppliersList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSuppliersList_CellMouseClick);
            this.dgvSuppliersList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSuppliersList_CellMouseDoubleClick);
            this.dgvSuppliersList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSuppliersList_DataBindingComplete);
            this.dgvSuppliersList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSuppliersList_KeyDown);
            this.dgvSuppliersList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
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
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSupplier});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(900, 39);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            this.toolStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem,
            this.organizationToolStripMenuItem});
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Image = global::SIMS.WinForms.Properties.Resources.add;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(120, 36);
            this.btnAddSupplier.Text = "  إضافة مورد  ";
            this.btnAddSupplier.ToolTipText = "Add a new supplier";
            this.btnAddSupplier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.personToolStripMenuItem.Text = "شخص";
            this.personToolStripMenuItem.Click += new System.EventHandler(this.personToolStripMenuItem_Click);
            this.personToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // organizationToolStripMenuItem
            // 
            this.organizationToolStripMenuItem.Name = "organizationToolStripMenuItem";
            this.organizationToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.organizationToolStripMenuItem.Text = "منظمة";
            this.organizationToolStripMenuItem.Click += new System.EventHandler(this.organizationToolStripMenuItem_Click);
            this.organizationToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.AutoSize = true;
            this.lblSearchHintText.BackColor = System.Drawing.Color.White;
            this.lblSearchHintText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearchHintText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHintText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchHintText.Location = new System.Drawing.Point(797, 11);
            this.lblSearchHintText.Name = "lblSearchHintText";
            this.lblSearchHintText.Size = new System.Drawing.Size(47, 16);
            this.lblSearchHintText.TabIndex = 29;
            this.lblSearchHintText.Text = "الرسالة";
            this.lblSearchHintText.Click += new System.EventHandler(this.pictureBoxAndSearchHintText_Click);
            this.lblSearchHintText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(793, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(95, 26);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox.Image = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.pictureBox.Location = new System.Drawing.Point(764, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(29, 26);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 34;
            this.pictureBox.TabStop = false;
            // 
            // lblTotalSuppliersCount
            // 
            this.lblTotalSuppliersCount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuppliersCount.Location = new System.Drawing.Point(4, 32);
            this.lblTotalSuppliersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSuppliersCount.Name = "lblTotalSuppliersCount";
            this.lblTotalSuppliersCount.Size = new System.Drawing.Size(238, 25);
            this.lblTotalSuppliersCount.TabIndex = 4;
            this.lblTotalSuppliersCount.Text = "N/A";
            this.lblTotalSuppliersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "إجمالي عدد الموردين";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Controls.Add(this.lblTotalSuppliersCount);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(641, 66);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 64);
            this.panel5.TabIndex = 35;
            // 
            // cbSupplierCategory
            // 
            this.cbSupplierCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplierCategory.FormattingEnabled = true;
            this.cbSupplierCategory.Items.AddRange(new object[] {
            "كل الموردين",
            "الأشخاص فقط",
            "المنظمات فقط"});
            this.cbSupplierCategory.Location = new System.Drawing.Point(557, 8);
            this.cbSupplierCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSupplierCategory.Name = "cbSupplierCategory";
            this.cbSupplierCategory.Size = new System.Drawing.Size(200, 24);
            this.cbSupplierCategory.TabIndex = 36;
            this.cbSupplierCategory.SelectedIndexChanged += new System.EventHandler(this.cbSupplierCategory_SelectedIndexChanged);
            // 
            // ctrSupplierInfo
            // 
            this.ctrSupplierInfo.Location = new System.Drawing.Point(13, 46);
            this.ctrSupplierInfo.Name = "ctrSupplierInfo";
            this.ctrSupplierInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrSupplierInfo.Size = new System.Drawing.Size(600, 265);
            this.ctrSupplierInfo.Supplier = null;
            this.ctrSupplierInfo.TabIndex = 31;
            this.ctrSupplierInfo.Visible = false;
            this.ctrSupplierInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            // 
            // frmSuppliersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.cbSupplierCategory);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblSearchHintText);
            this.Controls.Add(this.ctrSupplierInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvSuppliersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuppliersList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSuppliersList_FormClosed);
            this.Load += new System.EventHandler(this.frmSuppliersList_Load);
            this.Shown += new System.EventHandler(this.frmSuppliersList_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControls_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersList)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuppliersList;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Label lblSearchHintText;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripDropDownButton btnAddSupplier;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationToolStripMenuItem;
        private ctrSupplierInfo ctrSupplierInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblTotalSuppliersCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbSupplierCategory;
    }
}
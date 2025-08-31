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
            this.dgvSuppliersList = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAddSupplier = new System.Windows.Forms.ToolStripButton();
            this.btnEditSupplier = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteSupplier = new System.Windows.Forms.ToolStripButton();
            this.cbFilterColumn = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ctrSupplierInfo1 = new SIMS.WinForms.Suppliers.ctrSupplierInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersList)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuppliersList
            // 
            this.dgvSuppliersList.AllowUserToAddRows = false;
            this.dgvSuppliersList.AllowUserToDeleteRows = false;
            this.dgvSuppliersList.AllowUserToOrderColumns = true;
            this.dgvSuppliersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliersList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliersList.Location = new System.Drawing.Point(13, 301);
            this.dgvSuppliersList.Name = "dgvSuppliersList";
            this.dgvSuppliersList.ReadOnly = true;
            this.dgvSuppliersList.Size = new System.Drawing.Size(775, 137);
            this.dgvSuppliersList.TabIndex = 2;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSupplier,
            this.btnEditSupplier,
            this.btnDeleteSupplier});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(800, 45);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Image = global::SIMS.WinForms.Properties.Resources.add;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(102, 42);
            this.btnAddSupplier.Text = "   Add    ";
            this.btnAddSupplier.ToolTipText = "Add a new supplier";
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.Image = global::SIMS.WinForms.Properties.Resources.edit;
            this.btnEditSupplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(96, 42);
            this.btnEditSupplier.Text = "   Edit   ";
            this.btnEditSupplier.ToolTipText = "Edit a supplier";
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.Image = global::SIMS.WinForms.Properties.Resources.delete;
            this.btnDeleteSupplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(114, 42);
            this.btnDeleteSupplier.Text = "   Delete   ";
            this.btnDeleteSupplier.ToolTipText = "Delete a supplier";
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // cbFilterColumn
            // 
            this.cbFilterColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterColumn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterColumn.FormattingEnabled = true;
            this.cbFilterColumn.Items.AddRange(new object[] {
            "Supplier Name",
            "Contact Person",
            "Phone Number"});
            this.cbFilterColumn.Location = new System.Drawing.Point(417, 12);
            this.cbFilterColumn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterColumn.Name = "cbFilterColumn";
            this.cbFilterColumn.Size = new System.Drawing.Size(175, 27);
            this.cbFilterColumn.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(696, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(91, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SIMS.WinForms.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(600, 7);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SIMS.WinForms.Properties.Resources.filter;
            this.pictureBox4.Location = new System.Drawing.Point(327, 7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // ctrSupplierInfo1
            // 
            this.ctrSupplierInfo1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrSupplierInfo1.Location = new System.Drawing.Point(13, 64);
            this.ctrSupplierInfo1.Name = "ctrSupplierInfo1";
            this.ctrSupplierInfo1.Size = new System.Drawing.Size(583, 215);
            this.ctrSupplierInfo1.TabIndex = 3;
            // 
            // frmSuppliersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFilterColumn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrSupplierInfo1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvSuppliersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuppliersList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers List";
            this.Load += new System.EventHandler(this.frmSuppliersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersList)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuppliersList;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnAddSupplier;
        private System.Windows.Forms.ToolStripButton btnEditSupplier;
        private System.Windows.Forms.ToolStripButton btnDeleteSupplier;
        private ctrSupplierInfo ctrSupplierInfo1;
        private System.Windows.Forms.ComboBox cbFilterColumn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
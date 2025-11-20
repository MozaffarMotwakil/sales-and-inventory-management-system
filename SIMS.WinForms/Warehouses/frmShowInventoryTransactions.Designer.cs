namespace SIMS.WinForms.Warehouses
{
    partial class frmShowInventoryTransactions
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
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStockTransactions = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCancle = new System.Windows.Forms.Button();
            this.showInvoiceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTransactions)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(910, 637);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWarehouseName);
            this.groupBox2.Controls.Add(this.lblUnitName);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 121);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات المخزون";
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseName.ForeColor = System.Drawing.Color.Red;
            this.lblWarehouseName.Location = new System.Drawing.Point(12, 91);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(793, 16);
            this.lblWarehouseName.TabIndex = 54;
            this.lblWarehouseName.Text = "N/A";
            this.lblWarehouseName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            // 
            // lblUnitName
            // 
            this.lblUnitName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.Color.Red;
            this.lblUnitName.Location = new System.Drawing.Point(12, 63);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(792, 16);
            this.lblUnitName.TabIndex = 55;
            this.lblUnitName.Text = "N/A";
            this.lblUnitName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Red;
            this.lblProductName.Location = new System.Drawing.Point(12, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(792, 16);
            this.lblProductName.TabIndex = 56;
            this.lblProductName.Text = "N/A";
            this.lblProductName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(835, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "المخزن:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(839, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "الوحدة:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(810, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "إسم المنتج:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStockTransactions);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 500);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سجل الحركات";
            // 
            // dgvStockTransactions
            // 
            this.dgvStockTransactions.AllowUserToAddRows = false;
            this.dgvStockTransactions.AllowUserToDeleteRows = false;
            this.dgvStockTransactions.AllowUserToResizeColumns = false;
            this.dgvStockTransactions.AllowUserToResizeRows = false;
            this.dgvStockTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStockTransactions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockTransactions.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockTransactions.Location = new System.Drawing.Point(6, 25);
            this.dgvStockTransactions.MultiSelect = false;
            this.dgvStockTransactions.Name = "dgvStockTransactions";
            this.dgvStockTransactions.ReadOnly = true;
            this.dgvStockTransactions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockTransactions.RowHeadersVisible = false;
            this.dgvStockTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStockTransactions.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStockTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockTransactions.Size = new System.Drawing.Size(885, 469);
            this.dgvStockTransactions.TabIndex = 47;
            this.dgvStockTransactions.TabStop = false;
            this.dgvStockTransactions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStockTransactions_CellMouseClick);
            this.dgvStockTransactions.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStockTransactions_CellMouseDoubleClick);
            this.dgvStockTransactions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStockTransactions_DataBindingComplete);
            this.dgvStockTransactions.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvStockTransactions_RowPrePaint);
            this.dgvStockTransactions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvStockTransactions_KeyDown);
            this.dgvStockTransactions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInvoiceInfoToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(197, 42);
            this.contextMenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(410, 309);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // showInvoiceInfoToolStripMenuItem
            // 
            this.showInvoiceInfoToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.Invoice_32;
            this.showInvoiceInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showInvoiceInfoToolStripMenuItem.Name = "showInvoiceInfoToolStripMenuItem";
            this.showInvoiceInfoToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.showInvoiceInfoToolStripMenuItem.Text = "عرض تفاصيل الفاتورة";
            this.showInvoiceInfoToolStripMenuItem.Click += new System.EventHandler(this.showInvoiceInfoToolStripMenuItem_Click);
            // 
            // frmShowInventoryTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnCancle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowInventoryTransactions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض سحل حركات المخزون";
            this.Load += new System.EventHandler(this.frmShowInventoryTransactions_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearSelectionFromDGV);
            this.panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTransactions)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.DataGridView dgvStockTransactions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showInvoiceInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnCancle;
    }
}
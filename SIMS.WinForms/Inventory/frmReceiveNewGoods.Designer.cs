namespace SIMS.WinForms.Inventory
{
    partial class frmReceiveNewGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiveNewGoods));
            this.dgvProductsDetailsList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbPurchaseInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.llAddSupplier = new System.Windows.Forms.LinkLabel();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtPurchaseInvoiceNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDetailsList)).BeginInit();
            this.gbPurchaseInvoiceDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductsDetailsList
            // 
            this.dgvProductsDetailsList.AllowUserToResizeColumns = false;
            this.dgvProductsDetailsList.AllowUserToResizeRows = false;
            this.dgvProductsDetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductsDetailsList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsDetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductsDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsDetailsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductName,
            this.ReceivedQuantity,
            this.PurchasePrice,
            this.Total,
            this.Notes,
            this.Delete});
            this.dgvProductsDetailsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvProductsDetailsList.Location = new System.Drawing.Point(14, 223);
            this.dgvProductsDetailsList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductsDetailsList.MultiSelect = false;
            this.dgvProductsDetailsList.Name = "dgvProductsDetailsList";
            this.dgvProductsDetailsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductsDetailsList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductsDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProductsDetailsList.Size = new System.Drawing.Size(1003, 399);
            this.dgvProductsDetailsList.TabIndex = 0;
            this.dgvProductsDetailsList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductsDetailsList_CellMouseClick);
            this.dgvProductsDetailsList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductsDetailsList_RowsAdded);
            this.dgvProductsDetailsList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductsDetailsList_RowsRemoved);
            // 
            // No
            // 
            this.No.FillWeight = 40.92768F;
            this.No.HeaderText = "No.";
            this.No.MaxInputLength = 2;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.No.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.FillWeight = 177.3019F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductName.Width = 250;
            // 
            // ReceivedQuantity
            // 
            this.ReceivedQuantity.FillWeight = 76.84161F;
            this.ReceivedQuantity.HeaderText = "Received Quantity";
            this.ReceivedQuantity.MaxInputLength = 9;
            this.ReceivedQuantity.Name = "ReceivedQuantity";
            this.ReceivedQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReceivedQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ReceivedQuantity.Width = 150;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.FillWeight = 78.73761F;
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.MaxInputLength = 9;
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchasePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PurchasePrice.Width = 150;
            // 
            // Total
            // 
            this.Total.FillWeight = 96.44992F;
            this.Total.HeaderText = "Total";
            this.Total.MaxInputLength = 18;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 120;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.FillWeight = 129.7412F;
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::SIMS.WinForms.Properties.Resources.delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.ToolTipText = "Delete This Row";
            this.Delete.Width = 50;
            // 
            // gbPurchaseInvoiceDetails
            // 
            this.gbPurchaseInvoiceDetails.Controls.Add(this.llAddSupplier);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.dtpPurchaseDate);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.txtSupplier);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.txtPurchaseInvoiceNo);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label3);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label2);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label1);
            this.gbPurchaseInvoiceDetails.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPurchaseInvoiceDetails.Location = new System.Drawing.Point(14, 16);
            this.gbPurchaseInvoiceDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbPurchaseInvoiceDetails.Name = "gbPurchaseInvoiceDetails";
            this.gbPurchaseInvoiceDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbPurchaseInvoiceDetails.Size = new System.Drawing.Size(1003, 151);
            this.gbPurchaseInvoiceDetails.TabIndex = 0;
            this.gbPurchaseInvoiceDetails.TabStop = false;
            this.gbPurchaseInvoiceDetails.Text = "Purchase Invoice Details";
            // 
            // llAddSupplier
            // 
            this.llAddSupplier.AutoSize = true;
            this.llAddSupplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddSupplier.Location = new System.Drawing.Point(636, 119);
            this.llAddSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llAddSupplier.Name = "llAddSupplier";
            this.llAddSupplier.Size = new System.Drawing.Size(101, 19);
            this.llAddSupplier.TabIndex = 3;
            this.llAddSupplier.TabStop = true;
            this.llAddSupplier.Text = "Add Supplier";
            this.llAddSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddSupplier_LinkClicked);
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(211, 69);
            this.dtpPurchaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(417, 27);
            this.dtpPurchaseDate.TabIndex = 1;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(211, 110);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(417, 27);
            this.txtSupplier.TabIndex = 2;
            // 
            // txtPurchaseInvoiceNo
            // 
            this.txtPurchaseInvoiceNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseInvoiceNo.Location = new System.Drawing.Point(211, 28);
            this.txtPurchaseInvoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurchaseInvoiceNo.Name = "txtPurchaseInvoiceNo";
            this.txtPurchaseInvoiceNo.Size = new System.Drawing.Size(417, 27);
            this.txtPurchaseInvoiceNo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Supplier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Purchase Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Invoice No. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Products Details";
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(744, 629);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(133, 52);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(884, 629);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "     Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmReceiveNewGoods
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(1031, 690);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPurchaseInvoiceDetails);
            this.Controls.Add(this.dgvProductsDetailsList);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceiveNewGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive New Goods";
            this.Load += new System.EventHandler(this.frmReceiveNewGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsDetailsList)).EndInit();
            this.gbPurchaseInvoiceDetails.ResumeLayout(false);
            this.gbPurchaseInvoiceDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductsDetailsList;
        private System.Windows.Forms.GroupBox gbPurchaseInvoiceDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.TextBox txtPurchaseInvoiceNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel llAddSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
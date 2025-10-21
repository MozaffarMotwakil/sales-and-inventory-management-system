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
            this.gbPurchaseInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.llAddOrganizationSupplier = new System.Windows.Forms.LinkLabel();
            this.llAddPersonSupplier = new System.Windows.Forms.LinkLabel();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.cbMainSupplier = new System.Windows.Forms.ComboBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtPurchaseInvoiceNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.colLineNa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ReceivedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsDetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductsDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsDetailsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLineNa,
            this.colProductName,
            this.colUnit,
            this.ReceivedQuantity,
            this.colPurchasePrice,
            this.colDiscount,
            this.colTax,
            this.colSubTotal,
            this.colGrandTotal,
            this.colDelete});
            this.dgvProductsDetailsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvProductsDetailsList.Location = new System.Drawing.Point(12, 245);
            this.dgvProductsDetailsList.MultiSelect = false;
            this.dgvProductsDetailsList.Name = "dgvProductsDetailsList";
            this.dgvProductsDetailsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductsDetailsList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductsDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProductsDetailsList.Size = new System.Drawing.Size(1260, 407);
            this.dgvProductsDetailsList.TabIndex = 0;
            this.dgvProductsDetailsList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductsDetailsList_CellMouseClick);
            this.dgvProductsDetailsList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductsDetailsList_RowsAdded);
            this.dgvProductsDetailsList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductsDetailsList_RowsRemoved);
            // 
            // gbPurchaseInvoiceDetails
            // 
            this.gbPurchaseInvoiceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPurchaseInvoiceDetails.Controls.Add(this.llAddOrganizationSupplier);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.llAddPersonSupplier);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.cbWarehouse);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.cbMainSupplier);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.dtpPurchaseDate);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.txtPurchaseInvoiceNo);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label5);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label3);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label2);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label1);
            this.gbPurchaseInvoiceDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPurchaseInvoiceDetails.Location = new System.Drawing.Point(12, 12);
            this.gbPurchaseInvoiceDetails.Name = "gbPurchaseInvoiceDetails";
            this.gbPurchaseInvoiceDetails.Size = new System.Drawing.Size(1260, 199);
            this.gbPurchaseInvoiceDetails.TabIndex = 0;
            this.gbPurchaseInvoiceDetails.TabStop = false;
            this.gbPurchaseInvoiceDetails.Text = "رأس الفاتورة";
            // 
            // llAddOrganizationSupplier
            // 
            this.llAddOrganizationSupplier.AutoSize = true;
            this.llAddOrganizationSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddOrganizationSupplier.Location = new System.Drawing.Point(809, 168);
            this.llAddOrganizationSupplier.Name = "llAddOrganizationSupplier";
            this.llAddOrganizationSupplier.Size = new System.Drawing.Size(145, 16);
            this.llAddOrganizationSupplier.TabIndex = 12;
            this.llAddOrganizationSupplier.TabStop = true;
            this.llAddOrganizationSupplier.Text = "إضافة مورد جديد (منظمة)";
            // 
            // llAddPersonSupplier
            // 
            this.llAddPersonSupplier.AutoSize = true;
            this.llAddPersonSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddPersonSupplier.Location = new System.Drawing.Point(980, 168);
            this.llAddPersonSupplier.Name = "llAddPersonSupplier";
            this.llAddPersonSupplier.Size = new System.Drawing.Size(146, 16);
            this.llAddPersonSupplier.TabIndex = 11;
            this.llAddPersonSupplier.TabStop = true;
            this.llAddPersonSupplier.Text = "إضافة مورد جديد (شخص)";
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Location = new System.Drawing.Point(765, 106);
            this.cbWarehouse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(358, 24);
            this.cbWarehouse.TabIndex = 10;
            // 
            // cbMainSupplier
            // 
            this.cbMainSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMainSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMainSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMainSupplier.FormattingEnabled = true;
            this.cbMainSupplier.Location = new System.Drawing.Point(765, 142);
            this.cbMainSupplier.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbMainSupplier.Name = "cbMainSupplier";
            this.cbMainSupplier.Size = new System.Drawing.Size(358, 24);
            this.cbMainSupplier.TabIndex = 10;
            this.cbMainSupplier.Text = "إختار المورد الأساسي";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(765, 67);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.RightToLeftLayout = true;
            this.dtpPurchaseDate.Size = new System.Drawing.Size(358, 23);
            this.dtpPurchaseDate.TabIndex = 1;
            // 
            // txtPurchaseInvoiceNo
            // 
            this.txtPurchaseInvoiceNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseInvoiceNo.Location = new System.Drawing.Point(765, 28);
            this.txtPurchaseInvoiceNo.Name = "txtPurchaseInvoiceNo";
            this.txtPurchaseInvoiceNo.Size = new System.Drawing.Size(361, 23);
            this.txtPurchaseInvoiceNo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1198, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "المخزن:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1205, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "المورد:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1129, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاريخ عملية الشراء:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1171, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "سطور الفاتورة";
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(659, 658);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 14;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(539, 658);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "    حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // colLineNa
            // 
            this.colLineNa.FillWeight = 40.92768F;
            this.colLineNa.HeaderText = "م";
            this.colLineNa.MaxInputLength = 2;
            this.colLineNa.Name = "colLineNa";
            this.colLineNa.ReadOnly = true;
            this.colLineNa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLineNa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLineNa.Width = 50;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductName.FillWeight = 177.3019F;
            this.colProductName.HeaderText = "المنتج";
            this.colProductName.Name = "colProductName";
            this.colProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.Name = "colUnit";
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colUnit.Width = 150;
            // 
            // ReceivedQuantity
            // 
            this.ReceivedQuantity.FillWeight = 76.84161F;
            this.ReceivedQuantity.HeaderText = "الكمية";
            this.ReceivedQuantity.MaxInputLength = 9;
            this.ReceivedQuantity.Name = "ReceivedQuantity";
            this.ReceivedQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReceivedQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ReceivedQuantity.Width = 150;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.FillWeight = 78.73761F;
            this.colPurchasePrice.HeaderText = "سعر شراء الوحدة";
            this.colPurchasePrice.MaxInputLength = 9;
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPurchasePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPurchasePrice.Width = 150;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "قيمة الخصم";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTax
            // 
            this.colTax.HeaderText = "نسبة الضريبة";
            this.colTax.Name = "colTax";
            this.colTax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "الإجمالي الفرعي";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSubTotal.Width = 110;
            // 
            // colGrandTotal
            // 
            this.colGrandTotal.HeaderText = "الإجمالي الكلي";
            this.colGrandTotal.Name = "colGrandTotal";
            this.colGrandTotal.ReadOnly = true;
            this.colGrandTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colGrandTotal.Width = 110;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDelete.HeaderText = "حذف";
            this.colDelete.Image = global::SIMS.WinForms.Properties.Resources.delete;
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.ToolTipText = "Delete This Row";
            this.colDelete.Width = 50;
            // 
            // frmReceiveNewGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPurchaseInvoiceDetails);
            this.Controls.Add(this.dgvProductsDetailsList);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceiveNewGoods";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إصدار فاتورة مشتريات";
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
        private System.Windows.Forms.LinkLabel llAddOrganizationSupplier;
        private System.Windows.Forms.LinkLabel llAddPersonSupplier;
        private System.Windows.Forms.ComboBox cbMainSupplier;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineNa;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrandTotal;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
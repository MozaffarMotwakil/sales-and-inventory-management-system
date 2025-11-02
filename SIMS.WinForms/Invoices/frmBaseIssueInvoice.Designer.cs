namespace SIMS.WinForms.Invoices
{
    partial class frmBaseIssueInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.warehousesTableAdapter = new SIMS.WinForms.WarehouseNamesTableAdapters.WarehousesTableAdapter();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotalSubTotal = new System.Windows.Forms.Label();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseNames = new SIMS.WinForms.WarehouseNames();
            this.label15 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new SIMS.WinForms.ProductNamesTableAdapters.ProductsTableAdapter();
            this.vwSuppliersDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierNames = new SIMS.WinForms.SupplierNames();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbInvoiceSummary = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalGrandTotal = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vw_SuppliersDetailsTableAdapter = new SIMS.WinForms.SupplierNamesTableAdapters.vw_SuppliersDetailsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNames = new SIMS.WinForms.ProductNames();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbInvoiceLines = new System.Windows.Forms.GroupBox();
            this.dgvInvoiceLines = new System.Windows.Forms.DataGridView();
            this.colLineNa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConversionFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rbUnpaid = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbPartiallyPaid = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbBankTransfer = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpInvoiceIssueDate = new System.Windows.Forms.DateTimePicker();
            this.cbParty = new System.Windows.Forms.ComboBox();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.gbInvoiceDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSuppliersDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierNames)).BeginInit();
            this.gbInvoiceSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNames)).BeginInit();
            this.gbInvoiceLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceLines)).BeginInit();
            this.gbPaymentInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbInvoiceDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(2, 61);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(343, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "________________________________________________";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(236, 78);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "الإجمالي الكلي";
            // 
            // lblTotalSubTotal
            // 
            this.lblTotalSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSubTotal.AutoSize = true;
            this.lblTotalSubTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSubTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSubTotal.Location = new System.Drawing.Point(8, 19);
            this.lblTotalSubTotal.Name = "lblTotalSubTotal";
            this.lblTotalSubTotal.Size = new System.Drawing.Size(14, 16);
            this.lblTotalSubTotal.TabIndex = 17;
            this.lblTotalSubTotal.Text = "0";
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDiscount.Location = new System.Drawing.Point(8, 37);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(14, 16);
            this.lblTotalDiscount.TabIndex = 17;
            this.lblTotalDiscount.Text = "0";
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.warehouseNames;
            // 
            // warehouseNames
            // 
            this.warehouseNames.DataSetName = "WarehouseNames";
            this.warehouseNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(240, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 16);
            this.label15.TabIndex = 12;
            this.label15.Text = "إجمالي الخصم";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // vwSuppliersDetailsBindingSource
            // 
            this.vwSuppliersDetailsBindingSource.DataMember = "vw_SuppliersDetails";
            this.vwSuppliersDetailsBindingSource.DataSource = this.supplierNames;
            this.vwSuppliersDetailsBindingSource.Sort = "PartyName";
            // 
            // supplierNames
            // 
            this.supplierNames.DataSetName = "SupplierNames";
            this.supplierNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTax.ForeColor = System.Drawing.Color.Red;
            this.lblTotalTax.Location = new System.Drawing.Point(8, 55);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(14, 16);
            this.lblTotalTax.TabIndex = 17;
            this.lblTotalTax.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(226, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "الإجمالي الفرعي";
            // 
            // gbInvoiceSummary
            // 
            this.gbInvoiceSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvoiceSummary.Controls.Add(this.lblTotalTax);
            this.gbInvoiceSummary.Controls.Add(this.label13);
            this.gbInvoiceSummary.Controls.Add(this.label14);
            this.gbInvoiceSummary.Controls.Add(this.label15);
            this.gbInvoiceSummary.Controls.Add(this.label16);
            this.gbInvoiceSummary.Controls.Add(this.label17);
            this.gbInvoiceSummary.Controls.Add(this.lblTotalSubTotal);
            this.gbInvoiceSummary.Controls.Add(this.lblTotalGrandTotal);
            this.gbInvoiceSummary.Controls.Add(this.lblTotalDiscount);
            this.gbInvoiceSummary.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvoiceSummary.Location = new System.Drawing.Point(14, 553);
            this.gbInvoiceSummary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInvoiceSummary.Name = "gbInvoiceSummary";
            this.gbInvoiceSummary.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInvoiceSummary.Size = new System.Drawing.Size(348, 100);
            this.gbInvoiceSummary.TabIndex = 36;
            this.gbInvoiceSummary.TabStop = false;
            this.gbInvoiceSummary.Text = "ملخص الفاتورة";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(235, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "إجمالي الضريبة";
            // 
            // lblTotalGrandTotal
            // 
            this.lblTotalGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalGrandTotal.AutoSize = true;
            this.lblTotalGrandTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalGrandTotal.Location = new System.Drawing.Point(8, 79);
            this.lblTotalGrandTotal.Name = "lblTotalGrandTotal";
            this.lblTotalGrandTotal.Size = new System.Drawing.Size(14, 16);
            this.lblTotalGrandTotal.TabIndex = 17;
            this.lblTotalGrandTotal.Text = "0";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // vw_SuppliersDetailsTableAdapter
            // 
            this.vw_SuppliersDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productNames;
            this.productsBindingSource.Sort = "ProductName";
            // 
            // productNames
            // 
            this.productNames.DataSetName = "ProductNames";
            this.productNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(1157, 597);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 17;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1157, 551);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "    حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbInvoiceLines
            // 
            this.gbInvoiceLines.Controls.Add(this.dgvInvoiceLines);
            this.gbInvoiceLines.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvoiceLines.Location = new System.Drawing.Point(12, 156);
            this.gbInvoiceLines.Name = "gbInvoiceLines";
            this.gbInvoiceLines.Size = new System.Drawing.Size(1258, 390);
            this.gbInvoiceLines.TabIndex = 5;
            this.gbInvoiceLines.TabStop = false;
            this.gbInvoiceLines.Text = "تفاصيل الفاتورة";
            // 
            // dgvInvoiceLines
            // 
            this.dgvInvoiceLines.AllowUserToResizeColumns = false;
            this.dgvInvoiceLines.AllowUserToResizeRows = false;
            this.dgvInvoiceLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceLines.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLineNa,
            this.colProduct,
            this.colUnit,
            this.colQuantity,
            this.colConversionFactor,
            this.colUnitPrice,
            this.colDiscountRate,
            this.colDiscountAmount,
            this.colTaxRate,
            this.colTaxAmount,
            this.colSubTotal,
            this.colGrandTotal,
            this.colDelete});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceLines.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInvoiceLines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInvoiceLines.Location = new System.Drawing.Point(6, 25);
            this.dgvInvoiceLines.MultiSelect = false;
            this.dgvInvoiceLines.Name = "dgvInvoiceLines";
            this.dgvInvoiceLines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoiceLines.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInvoiceLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvoiceLines.Size = new System.Drawing.Size(1246, 359);
            this.dgvInvoiceLines.TabIndex = 6;
            this.dgvInvoiceLines.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInvoiceLines_CellBeginEdit);
            this.dgvInvoiceLines.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoiceLines_CellMouseClick);
            this.dgvInvoiceLines.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvInvoiceLines_RowsAdded);
            this.dgvInvoiceLines.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvInvoiceLines_RowsRemoved);
            this.dgvInvoiceLines.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInvoiceLines_RowValidating);
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
            this.colLineNa.Width = 40;
            // 
            // colProduct
            // 
            this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduct.DataSource = this.productsBindingSource;
            this.colProduct.DisplayMember = "ProductName";
            this.colProduct.FillWeight = 177.3019F;
            this.colProduct.HeaderText = "المنتج";
            this.colProduct.Name = "colProduct";
            this.colProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProduct.ValueMember = "ProductID";
            // 
            // colUnit
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.Name = "colUnit";
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUnit.Width = 150;
            // 
            // colQuantity
            // 
            this.colQuantity.FillWeight = 76.84161F;
            this.colQuantity.HeaderText = "الكمية";
            this.colQuantity.MaxInputLength = 9;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colConversionFactor
            // 
            this.colConversionFactor.HeaderText = "معامل التحويل";
            this.colConversionFactor.Name = "colConversionFactor";
            this.colConversionFactor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colConversionFactor.Visible = false;
            // 
            // colUnitPrice
            // 
            dataGridViewCellStyle3.Format = "0.##";
            this.colUnitPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colUnitPrice.FillWeight = 78.73761F;
            this.colUnitPrice.HeaderText = "سعر شراء الوحدة";
            this.colUnitPrice.MaxInputLength = 9;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDiscountRate
            // 
            dataGridViewCellStyle4.Format = "0.##";
            this.colDiscountRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDiscountRate.HeaderText = "نسبة الخصم";
            this.colDiscountRate.Name = "colDiscountRate";
            this.colDiscountRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiscountRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDiscountRate.Width = 80;
            // 
            // colDiscountAmount
            // 
            dataGridViewCellStyle5.Format = "0.##";
            this.colDiscountAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDiscountAmount.HeaderText = "قيمة الخصم";
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiscountAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDiscountAmount.Width = 80;
            // 
            // colTaxRate
            // 
            dataGridViewCellStyle6.Format = "0.##";
            this.colTaxRate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTaxRate.HeaderText = "نسبة الضريبة";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTaxRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTaxRate.Width = 80;
            // 
            // colTaxAmount
            // 
            dataGridViewCellStyle7.Format = "0.##";
            this.colTaxAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTaxAmount.HeaderText = "قيمة الضريبة";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTaxAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTaxAmount.Width = 80;
            // 
            // colSubTotal
            // 
            dataGridViewCellStyle8.Format = "0.##";
            this.colSubTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.colSubTotal.HeaderText = "الإجمالي الفرعي";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colGrandTotal
            // 
            dataGridViewCellStyle9.Format = "0.##";
            this.colGrandTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.colGrandTotal.HeaderText = "الإجمالي الكلي";
            this.colGrandTotal.Name = "colGrandTotal";
            this.colGrandTotal.ReadOnly = true;
            this.colGrandTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGrandTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.NullValue = null;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDelete.HeaderText = "حذف";
            this.colDelete.Image = global::SIMS.WinForms.Properties.Resources.delete;
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.ToolTipText = "Delete This Row";
            this.colDelete.Width = 50;
            // 
            // gbPaymentInfo
            // 
            this.gbPaymentInfo.Controls.Add(this.txtPaidAmount);
            this.gbPaymentInfo.Controls.Add(this.panel1);
            this.gbPaymentInfo.Controls.Add(this.panel2);
            this.gbPaymentInfo.Controls.Add(this.label8);
            this.gbPaymentInfo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentInfo.Location = new System.Drawing.Point(370, 553);
            this.gbPaymentInfo.Name = "gbPaymentInfo";
            this.gbPaymentInfo.Size = new System.Drawing.Size(503, 100);
            this.gbPaymentInfo.TabIndex = 7;
            this.gbPaymentInfo.TabStop = false;
            this.gbPaymentInfo.Text = "معلومات الدفع";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaidAmount.Enabled = false;
            this.txtPaidAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(6, 71);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(363, 23);
            this.txtPaidAmount.TabIndex = 15;
            this.txtPaidAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaidAmount_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rbUnpaid);
            this.panel1.Controls.Add(this.rbPaid);
            this.panel1.Controls.Add(this.rbPartiallyPaid);
            this.panel1.Location = new System.Drawing.Point(1, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 29);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "حالة الفاتورة:";
            // 
            // rbUnpaid
            // 
            this.rbUnpaid.AutoSize = true;
            this.rbUnpaid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnpaid.Location = new System.Drawing.Point(56, 2);
            this.rbUnpaid.Name = "rbUnpaid";
            this.rbUnpaid.Size = new System.Drawing.Size(87, 20);
            this.rbUnpaid.TabIndex = 14;
            this.rbUnpaid.Text = "غير مدفوعة";
            this.rbUnpaid.UseVisualStyleBackColor = true;
            this.rbUnpaid.CheckedChanged += new System.EventHandler(this.rbUnpaid_CheckedChanged);
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Checked = true;
            this.rbPaid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaid.Location = new System.Drawing.Point(255, 2);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(108, 20);
            this.rbPaid.TabIndex = 12;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "مدفوعة بالكامل";
            this.rbPaid.UseVisualStyleBackColor = true;
            this.rbPaid.CheckedChanged += new System.EventHandler(this.rbPaid_CheckedChanged);
            // 
            // rbPartiallyPaid
            // 
            this.rbPartiallyPaid.AutoSize = true;
            this.rbPartiallyPaid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPartiallyPaid.Location = new System.Drawing.Point(153, 2);
            this.rbPartiallyPaid.Name = "rbPartiallyPaid";
            this.rbPartiallyPaid.Size = new System.Drawing.Size(96, 20);
            this.rbPartiallyPaid.TabIndex = 13;
            this.rbPartiallyPaid.Text = "مدفوعة جزئيا";
            this.rbPartiallyPaid.UseVisualStyleBackColor = true;
            this.rbPartiallyPaid.CheckedChanged += new System.EventHandler(this.rbPartiallyPaid_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbBankTransfer);
            this.panel2.Controls.Add(this.rbCash);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(1, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 29);
            this.panel2.TabIndex = 8;
            // 
            // rbBankTransfer
            // 
            this.rbBankTransfer.AutoSize = true;
            this.rbBankTransfer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBankTransfer.Location = new System.Drawing.Point(159, 4);
            this.rbBankTransfer.Name = "rbBankTransfer";
            this.rbBankTransfer.Size = new System.Drawing.Size(90, 20);
            this.rbBankTransfer.TabIndex = 10;
            this.rbBankTransfer.Text = "تحويل بنكي";
            this.rbBankTransfer.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(312, 4);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(51, 20);
            this.rbCash.TabIndex = 9;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "كاش";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(408, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "طريقة الدفع:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "المبلغ المدفوع:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1022, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1022, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاريخ العملية:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(710, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "الطرف:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(710, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "المخزن:";
            // 
            // dtpInvoiceIssueDate
            // 
            this.dtpInvoiceIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInvoiceIssueDate.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceIssueDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceIssueDate.Location = new System.Drawing.Point(1022, 87);
            this.dtpInvoiceIssueDate.Name = "dtpInvoiceIssueDate";
            this.dtpInvoiceIssueDate.RightToLeftLayout = true;
            this.dtpInvoiceIssueDate.Size = new System.Drawing.Size(225, 23);
            this.dtpInvoiceIssueDate.TabIndex = 2;
            // 
            // cbParty
            // 
            this.cbParty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbParty.DataSource = this.vwSuppliersDetailsBindingSource;
            this.cbParty.DisplayMember = "PartyName";
            this.cbParty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParty.FormattingEnabled = true;
            this.cbParty.Location = new System.Drawing.Point(710, 86);
            this.cbParty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbParty.Name = "cbParty";
            this.cbParty.Size = new System.Drawing.Size(294, 24);
            this.cbParty.TabIndex = 4;
            this.cbParty.ValueMember = "SupplierID";
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWarehouse.DataSource = this.warehousesBindingSource;
            this.cbWarehouse.DisplayMember = "WarehouseName";
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Location = new System.Drawing.Point(710, 41);
            this.cbWarehouse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(294, 24);
            this.cbWarehouse.TabIndex = 3;
            this.cbWarehouse.ValueMember = "WarehouseID";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(1022, 42);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(225, 23);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // gbInvoiceDetails
            // 
            this.gbInvoiceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvoiceDetails.Controls.Add(this.txtInvoiceNo);
            this.gbInvoiceDetails.Controls.Add(this.cbWarehouse);
            this.gbInvoiceDetails.Controls.Add(this.cbParty);
            this.gbInvoiceDetails.Controls.Add(this.dtpInvoiceIssueDate);
            this.gbInvoiceDetails.Controls.Add(this.label5);
            this.gbInvoiceDetails.Controls.Add(this.label3);
            this.gbInvoiceDetails.Controls.Add(this.label2);
            this.gbInvoiceDetails.Controls.Add(this.label1);
            this.gbInvoiceDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvoiceDetails.Location = new System.Drawing.Point(14, 12);
            this.gbInvoiceDetails.Name = "gbInvoiceDetails";
            this.gbInvoiceDetails.Size = new System.Drawing.Size(1256, 138);
            this.gbInvoiceDetails.TabIndex = 0;
            this.gbInvoiceDetails.TabStop = false;
            this.gbInvoiceDetails.Text = "رأس الفاتورة";
            // 
            // frmBaseIssueInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.gbInvoiceLines);
            this.Controls.Add(this.gbInvoiceSummary);
            this.Controls.Add(this.gbInvoiceDetails);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPaymentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaseIssueInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إصدار فاتورة";
            this.Load += new System.EventHandler(this.frmBaseIssueInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSuppliersDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierNames)).EndInit();
            this.gbInvoiceSummary.ResumeLayout(false);
            this.gbInvoiceSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNames)).EndInit();
            this.gbInvoiceLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceLines)).EndInit();
            this.gbPaymentInfo.ResumeLayout(false);
            this.gbPaymentInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbInvoiceDetails.ResumeLayout(false);
            this.gbInvoiceDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected WarehouseNamesTableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label lblTotalSubTotal;
        protected System.Windows.Forms.Label lblTotalDiscount;
        protected System.Windows.Forms.BindingSource warehousesBindingSource;
        protected WarehouseNames warehouseNames;
        protected System.Windows.Forms.Label label15;
        protected ProductNamesTableAdapters.ProductsTableAdapter productsTableAdapter;
        protected System.Windows.Forms.BindingSource vwSuppliersDetailsBindingSource;
        protected SupplierNames supplierNames;
        protected System.Windows.Forms.Label lblTotalTax;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.GroupBox gbInvoiceSummary;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label lblTotalGrandTotal;
        protected System.Windows.Forms.ErrorProvider errorProvider;
        protected System.Windows.Forms.BindingSource productsBindingSource;
        protected ProductNames productNames;
        protected System.Windows.Forms.Button btnCancle;
        protected System.Windows.Forms.Button btnSave;
        protected SupplierNamesTableAdapters.vw_SuppliersDetailsTableAdapter vw_SuppliersDetailsTableAdapter;
        protected System.Windows.Forms.GroupBox gbInvoiceLines;
        protected System.Windows.Forms.DataGridView dgvInvoiceLines;
        protected System.Windows.Forms.GroupBox gbPaymentInfo;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.RadioButton rbBankTransfer;
        protected System.Windows.Forms.RadioButton rbCash;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtPaidAmount;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.RadioButton rbUnpaid;
        protected System.Windows.Forms.RadioButton rbPaid;
        protected System.Windows.Forms.RadioButton rbPartiallyPaid;
        protected System.Windows.Forms.GroupBox gbInvoiceDetails;
        protected System.Windows.Forms.TextBox txtInvoiceNo;
        protected System.Windows.Forms.ComboBox cbWarehouse;
        protected System.Windows.Forms.ComboBox cbParty;
        protected System.Windows.Forms.DateTimePicker dtpInvoiceIssueDate;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colLineNa;
        protected System.Windows.Forms.DataGridViewComboBoxColumn colProduct;
        protected System.Windows.Forms.DataGridViewComboBoxColumn colUnit;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colConversionFactor;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colDiscountRate;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colDiscountAmount;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colTaxRate;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colTaxAmount;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colGrandTotal;
        protected System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
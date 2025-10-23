namespace SIMS.WinForms.Inventory
{
    partial class frmIssuePurchaseInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInvoiceLines = new System.Windows.Forms.DataGridView();
            this.colLineNa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNames = new SIMS.WinForms.ProductNames();
            this.colUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbPurchaseInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.llAddOrganizationSupplier = new System.Windows.Forms.LinkLabel();
            this.llAddPersonSupplier = new System.Windows.Forms.LinkLabel();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseNames = new SIMS.WinForms.WarehouseNames();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.vwSuppliersDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierNames = new SIMS.WinForms.SupplierNames();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtPurchaseInvoiceNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbUnpaid = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbPartiallyPaid = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbBankTransfer = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblTotalGrandTotal = new System.Windows.Forms.Label();
            this.lblTotalSubTotal = new System.Windows.Forms.Label();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.warehousesTableAdapter = new SIMS.WinForms.WarehouseNamesTableAdapters.WarehousesTableAdapter();
            this.productsTableAdapter = new SIMS.WinForms.ProductNamesTableAdapters.ProductsTableAdapter();
            this.vw_SuppliersDetailsTableAdapter = new SIMS.WinForms.SupplierNamesTableAdapters.vw_SuppliersDetailsTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNames)).BeginInit();
            this.gbPurchaseInvoiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSuppliersDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierNames)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoiceLines
            // 
            this.dgvInvoiceLines.AllowUserToResizeColumns = false;
            this.dgvInvoiceLines.AllowUserToResizeRows = false;
            this.dgvInvoiceLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceLines.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInvoiceLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLineNa,
            this.colProduct,
            this.colUnit,
            this.colQuantity,
            this.colUnitPrice,
            this.colDiscount,
            this.colTax,
            this.colSubTotal,
            this.colGrandTotal,
            this.colDelete});
            this.dgvInvoiceLines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInvoiceLines.Location = new System.Drawing.Point(12, 149);
            this.dgvInvoiceLines.MultiSelect = false;
            this.dgvInvoiceLines.Name = "dgvInvoiceLines";
            this.dgvInvoiceLines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoiceLines.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInvoiceLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvoiceLines.Size = new System.Drawing.Size(1156, 350);
            this.dgvInvoiceLines.TabIndex = 0;
            this.dgvInvoiceLines.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvProductsDetailsList_CellBeginEdit);
            this.dgvInvoiceLines.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsDetailsList_CellEndEdit);
            this.dgvInvoiceLines.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductsDetailsList_CellMouseClick);
            this.dgvInvoiceLines.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvInvoiceLines_CellValidating);
            this.dgvInvoiceLines.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProductsDetailsList_EditingControlShowing);
            this.dgvInvoiceLines.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductsDetailsList_RowsAdded);
            this.dgvInvoiceLines.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductsDetailsList_RowsRemoved);
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
            // colUnit
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle6;
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
            // colUnitPrice
            // 
            this.colUnitPrice.FillWeight = 78.73761F;
            this.colUnitPrice.HeaderText = "سعر شراء الوحدة";
            this.colUnitPrice.MaxInputLength = 9;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "قيمة الخصم";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDiscount.Width = 80;
            // 
            // colTax
            // 
            this.colTax.HeaderText = "نسبة الضريبة";
            this.colTax.Name = "colTax";
            this.colTax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTax.Width = 80;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "الإجمالي الفرعي";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colGrandTotal
            // 
            this.colGrandTotal.HeaderText = "الإجمالي الكلي";
            this.colGrandTotal.Name = "colGrandTotal";
            this.colGrandTotal.ReadOnly = true;
            this.colGrandTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.NullValue = null;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDelete.HeaderText = "حذف";
            this.colDelete.Image = global::SIMS.WinForms.Properties.Resources.delete;
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.ToolTipText = "Delete This Row";
            this.colDelete.Width = 50;
            // 
            // gbPurchaseInvoiceDetails
            // 
            this.gbPurchaseInvoiceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPurchaseInvoiceDetails.Controls.Add(this.llAddOrganizationSupplier);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.llAddPersonSupplier);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.cbWarehouse);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.cbSupplier);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.dtpPurchaseDate);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.txtPurchaseInvoiceNo);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label5);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label3);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label2);
            this.gbPurchaseInvoiceDetails.Controls.Add(this.label1);
            this.gbPurchaseInvoiceDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPurchaseInvoiceDetails.Location = new System.Drawing.Point(12, 2);
            this.gbPurchaseInvoiceDetails.Name = "gbPurchaseInvoiceDetails";
            this.gbPurchaseInvoiceDetails.Size = new System.Drawing.Size(1156, 115);
            this.gbPurchaseInvoiceDetails.TabIndex = 0;
            this.gbPurchaseInvoiceDetails.TabStop = false;
            this.gbPurchaseInvoiceDetails.Text = "رأس الفاتورة";
            // 
            // llAddOrganizationSupplier
            // 
            this.llAddOrganizationSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAddOrganizationSupplier.AutoSize = true;
            this.llAddOrganizationSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddOrganizationSupplier.Location = new System.Drawing.Point(213, 91);
            this.llAddOrganizationSupplier.Name = "llAddOrganizationSupplier";
            this.llAddOrganizationSupplier.Size = new System.Drawing.Size(145, 16);
            this.llAddOrganizationSupplier.TabIndex = 12;
            this.llAddOrganizationSupplier.TabStop = true;
            this.llAddOrganizationSupplier.Text = "إضافة مورد جديد (منظمة)";
            this.llAddOrganizationSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddOrganizationSupplier_LinkClicked);
            // 
            // llAddPersonSupplier
            // 
            this.llAddPersonSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAddPersonSupplier.AutoSize = true;
            this.llAddPersonSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddPersonSupplier.Location = new System.Drawing.Point(384, 91);
            this.llAddPersonSupplier.Name = "llAddPersonSupplier";
            this.llAddPersonSupplier.Size = new System.Drawing.Size(146, 16);
            this.llAddPersonSupplier.TabIndex = 11;
            this.llAddPersonSupplier.TabStop = true;
            this.llAddPersonSupplier.Text = "إضافة مورد جديد (شخص)";
            this.llAddPersonSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddPersonSupplier_LinkClicked);
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
            this.cbWarehouse.Location = new System.Drawing.Point(169, 29);
            this.cbWarehouse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(358, 24);
            this.cbWarehouse.TabIndex = 10;
            this.cbWarehouse.ValueMember = "WarehouseID";
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
            // cbSupplier
            // 
            this.cbSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSupplier.DataSource = this.vwSuppliersDetailsBindingSource;
            this.cbSupplier.DisplayMember = "PartyName";
            this.cbSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(169, 65);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(358, 24);
            this.cbSupplier.TabIndex = 10;
            this.cbSupplier.ValueMember = "SupplierID";
            this.cbSupplier.Enter += new System.EventHandler(this.cbSupllier_Enter);
            this.cbSupplier.Leave += new System.EventHandler(this.cbSupllier_Leave);
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
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPurchaseDate.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(661, 68);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.RightToLeftLayout = true;
            this.dtpPurchaseDate.Size = new System.Drawing.Size(358, 23);
            this.dtpPurchaseDate.TabIndex = 1;
            // 
            // txtPurchaseInvoiceNo
            // 
            this.txtPurchaseInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurchaseInvoiceNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseInvoiceNo.Location = new System.Drawing.Point(661, 29);
            this.txtPurchaseInvoiceNo.Name = "txtPurchaseInvoiceNo";
            this.txtPurchaseInvoiceNo.Size = new System.Drawing.Size(361, 23);
            this.txtPurchaseInvoiceNo.TabIndex = 0;
            this.txtPurchaseInvoiceNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtPurchaseInvoiceNo_Validating);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "المخزن:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "المورد:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1025, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاريخ عملية الشراء:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1067, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "سطور الفاتورة";
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(584, 629);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 14;
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
            this.btnSave.Location = new System.Drawing.Point(464, 629);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "    حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUnpaid);
            this.panel1.Controls.Add(this.rbPaid);
            this.panel1.Controls.Add(this.rbPartiallyPaid);
            this.panel1.Location = new System.Drawing.Point(105, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 31);
            this.panel1.TabIndex = 21;
            // 
            // rbUnpaid
            // 
            this.rbUnpaid.AutoSize = true;
            this.rbUnpaid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnpaid.Location = new System.Drawing.Point(6, 4);
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
            this.rbPaid.Location = new System.Drawing.Point(255, 4);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(108, 20);
            this.rbPaid.TabIndex = 14;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "مدفوعة بالكامل";
            this.rbPaid.UseVisualStyleBackColor = true;
            this.rbPaid.CheckedChanged += new System.EventHandler(this.rbPaid_CheckedChanged);
            // 
            // rbPartiallyPaid
            // 
            this.rbPartiallyPaid.AutoSize = true;
            this.rbPartiallyPaid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPartiallyPaid.Location = new System.Drawing.Point(126, 4);
            this.rbPartiallyPaid.Name = "rbPartiallyPaid";
            this.rbPartiallyPaid.Size = new System.Drawing.Size(96, 20);
            this.rbPartiallyPaid.TabIndex = 14;
            this.rbPartiallyPaid.Text = "مدفوعة جزئيا";
            this.rbPartiallyPaid.UseVisualStyleBackColor = true;
            this.rbPartiallyPaid.CheckedChanged += new System.EventHandler(this.rbPartiallyPaid_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "حالة الفاتورة:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbBankTransfer);
            this.panel2.Controls.Add(this.rbCash);
            this.panel2.Location = new System.Drawing.Point(105, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 31);
            this.panel2.TabIndex = 19;
            // 
            // rbBankTransfer
            // 
            this.rbBankTransfer.AutoSize = true;
            this.rbBankTransfer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBankTransfer.Location = new System.Drawing.Point(132, 4);
            this.rbBankTransfer.Name = "rbBankTransfer";
            this.rbBankTransfer.Size = new System.Drawing.Size(90, 20);
            this.rbBankTransfer.TabIndex = 14;
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
            this.rbCash.TabIndex = 14;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "كاش";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "المبلغ المدفوع:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "طريقة الدفع:";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaidAmount.Enabled = false;
            this.txtPaidAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(114, 581);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(363, 23);
            this.txtPaidAmount.TabIndex = 22;
            this.txtPaidAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaidAmount_Validating);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(580, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "مجموع الإجمالي الفرعي:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(580, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "مجموع الخصومات:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(894, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "مجموع الضريبة:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(894, 549);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "مجموع الإجمالي الكلي:";
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTax.ForeColor = System.Drawing.Color.Red;
            this.lblTotalTax.Location = new System.Drawing.Point(1054, 509);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(114, 16);
            this.lblTotalTax.TabIndex = 17;
            this.lblTotalTax.Text = "0";
            // 
            // lblTotalGrandTotal
            // 
            this.lblTotalGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalGrandTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalGrandTotal.Location = new System.Drawing.Point(1054, 549);
            this.lblTotalGrandTotal.Name = "lblTotalGrandTotal";
            this.lblTotalGrandTotal.Size = new System.Drawing.Size(114, 16);
            this.lblTotalGrandTotal.TabIndex = 17;
            this.lblTotalGrandTotal.Text = "0";
            // 
            // lblTotalSubTotal
            // 
            this.lblTotalSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSubTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSubTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSubTotal.Location = new System.Drawing.Point(750, 511);
            this.lblTotalSubTotal.Name = "lblTotalSubTotal";
            this.lblTotalSubTotal.Size = new System.Drawing.Size(138, 16);
            this.lblTotalSubTotal.TabIndex = 17;
            this.lblTotalSubTotal.Text = "0";
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDiscount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDiscount.Location = new System.Drawing.Point(750, 551);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(138, 16);
            this.lblTotalDiscount.TabIndex = 17;
            this.lblTotalDiscount.Text = "0";
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // vw_SuppliersDetailsTableAdapter
            // 
            this.vw_SuppliersDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmIssuePurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 682);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalDiscount);
            this.Controls.Add(this.lblTotalSubTotal);
            this.Controls.Add(this.lblTotalGrandTotal);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPurchaseInvoiceDetails);
            this.Controls.Add(this.dgvInvoiceLines);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssuePurchaseInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إصدار فاتورة مشتريات";
            this.Load += new System.EventHandler(this.frmReceiveNewGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNames)).EndInit();
            this.gbPurchaseInvoiceDetails.ResumeLayout(false);
            this.gbPurchaseInvoiceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSuppliersDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierNames)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoiceLines;
        private System.Windows.Forms.GroupBox gbPurchaseInvoiceDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.TextBox txtPurchaseInvoiceNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llAddOrganizationSupplier;
        private System.Windows.Forms.LinkLabel llAddPersonSupplier;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbUnpaid;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.RadioButton rbPartiallyPaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbBankTransfer;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblTotalGrandTotal;
        private System.Windows.Forms.Label lblTotalSubTotal;
        private System.Windows.Forms.Label lblTotalDiscount;
        private WarehouseNames warehouseNames;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private WarehouseNamesTableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private ProductNames productNames;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProductNamesTableAdapters.ProductsTableAdapter productsTableAdapter;
        private SupplierNames supplierNames;
        private System.Windows.Forms.BindingSource vwSuppliersDetailsBindingSource;
        private SupplierNamesTableAdapters.vw_SuppliersDetailsTableAdapter vw_SuppliersDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineNa;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrandTotal;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
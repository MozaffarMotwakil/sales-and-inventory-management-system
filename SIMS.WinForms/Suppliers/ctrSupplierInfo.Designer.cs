namespace SIMS.WinForms.Suppliers
{
    partial class ctrSupplierInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageBasicInfo = new System.Windows.Forms.TabPage();
            this.ctrPersonInfo = new SIMS.WinForms.Parties.Person.ctrPersonInfo();
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.ctrOrganizationInfo = new SIMS.WinForms.Parties.Organization.ctrOrganizationInfo();
            this.pageSuppliedProducts = new System.Windows.Forms.TabPage();
            this.dgvSuppliedProducts = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPurchaseDataTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageInvoices = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbInvoicesRange = new System.Windows.Forms.ComboBox();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cbInvoiceType = new System.Windows.Forms.ComboBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.colPurchaseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pagePayments = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblSearchHintText = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbPaymentsRange = new System.Windows.Forms.ComboBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageBasicInfo.SuspendLayout();
            this.pageSuppliedProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliedProducts)).BeginInit();
            this.pageInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.pagePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageBasicInfo);
            this.tabControl.Controls.Add(this.pageSuppliedProducts);
            this.tabControl.Controls.Add(this.pageInvoices);
            this.tabControl.Controls.Add(this.pagePayments);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(694, 264);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pageBasicInfo
            // 
            this.pageBasicInfo.Controls.Add(this.ctrPersonInfo);
            this.pageBasicInfo.Controls.Add(this.lblNotesTitle);
            this.pageBasicInfo.Controls.Add(this.lblNotes);
            this.pageBasicInfo.Controls.Add(this.ctrOrganizationInfo);
            this.pageBasicInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageBasicInfo.Location = new System.Drawing.Point(4, 23);
            this.pageBasicInfo.Name = "pageBasicInfo";
            this.pageBasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pageBasicInfo.Size = new System.Drawing.Size(686, 237);
            this.pageBasicInfo.TabIndex = 0;
            this.pageBasicInfo.Text = "المعلومات الأساسية";
            this.pageBasicInfo.UseVisualStyleBackColor = true;
            // 
            // ctrPersonInfo
            // 
            this.ctrPersonInfo.Location = new System.Drawing.Point(7, 7);
            this.ctrPersonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ctrPersonInfo.Name = "ctrPersonInfo";
            this.ctrPersonInfo.Person = null;
            this.ctrPersonInfo.PersonType = BusinessLogic.Parties.clsParty.enPartyType.Supplier;
            this.ctrPersonInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrPersonInfo.Size = new System.Drawing.Size(675, 177);
            this.ctrPersonInfo.TabIndex = 61;
            // 
            // lblNotesTitle
            // 
            this.lblNotesTitle.AutoSize = true;
            this.lblNotesTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesTitle.Location = new System.Drawing.Point(602, 188);
            this.lblNotesTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotesTitle.Name = "lblNotesTitle";
            this.lblNotesTitle.Size = new System.Drawing.Size(75, 16);
            this.lblNotesTitle.TabIndex = 60;
            this.lblNotesTitle.Text = "الملاحظات:";
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Black;
            this.lblNotes.Location = new System.Drawing.Point(87, 188);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(459, 16);
            this.lblNotes.TabIndex = 59;
            this.lblNotes.Text = "N/A";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctrOrganizationInfo
            // 
            this.ctrOrganizationInfo.Location = new System.Drawing.Point(88, 4);
            this.ctrOrganizationInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ctrOrganizationInfo.Name = "ctrOrganizationInfo";
            this.ctrOrganizationInfo.Organization = null;
            this.ctrOrganizationInfo.OrganizationType = BusinessLogic.Parties.clsParty.enPartyType.Supplier;
            this.ctrOrganizationInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrOrganizationInfo.Size = new System.Drawing.Size(594, 138);
            this.ctrOrganizationInfo.TabIndex = 58;
            // 
            // pageSuppliedProducts
            // 
            this.pageSuppliedProducts.Controls.Add(this.dgvSuppliedProducts);
            this.pageSuppliedProducts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSuppliedProducts.Location = new System.Drawing.Point(4, 23);
            this.pageSuppliedProducts.Name = "pageSuppliedProducts";
            this.pageSuppliedProducts.Padding = new System.Windows.Forms.Padding(3);
            this.pageSuppliedProducts.Size = new System.Drawing.Size(686, 237);
            this.pageSuppliedProducts.TabIndex = 1;
            this.pageSuppliedProducts.Text = "المنتجات الموردة";
            this.pageSuppliedProducts.UseVisualStyleBackColor = true;
            // 
            // dgvSuppliedProducts
            // 
            this.dgvSuppliedProducts.AllowUserToAddRows = false;
            this.dgvSuppliedProducts.AllowUserToDeleteRows = false;
            this.dgvSuppliedProducts.AllowUserToResizeColumns = false;
            this.dgvSuppliedProducts.AllowUserToResizeRows = false;
            this.dgvSuppliedProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvSuppliedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colProduct,
            this.colUnit,
            this.colLastPurchaseDataTime,
            this.colLastPurchasePrice});
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliedProducts.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvSuppliedProducts.Location = new System.Drawing.Point(6, 6);
            this.dgvSuppliedProducts.MultiSelect = false;
            this.dgvSuppliedProducts.Name = "dgvSuppliedProducts";
            this.dgvSuppliedProducts.ReadOnly = true;
            this.dgvSuppliedProducts.RowHeadersVisible = false;
            this.dgvSuppliedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliedProducts.Size = new System.Drawing.Size(674, 225);
            this.dgvSuppliedProducts.TabIndex = 0;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "م";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNo.Width = 45;
            // 
            // colProduct
            // 
            this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduct.HeaderText = "المنتج";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUnit.Width = 150;
            // 
            // colLastPurchaseDataTime
            // 
            this.colLastPurchaseDataTime.HeaderText = "تاريخ آخر شراء";
            this.colLastPurchaseDataTime.Name = "colLastPurchaseDataTime";
            this.colLastPurchaseDataTime.ReadOnly = true;
            this.colLastPurchaseDataTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLastPurchaseDataTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLastPurchaseDataTime.Width = 135;
            // 
            // colLastPurchasePrice
            // 
            this.colLastPurchasePrice.HeaderText = "آخر سعر شراء (جنيه)";
            this.colLastPurchasePrice.Name = "colLastPurchasePrice";
            this.colLastPurchasePrice.ReadOnly = true;
            this.colLastPurchasePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLastPurchasePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pageInvoices
            // 
            this.pageInvoices.Controls.Add(this.label8);
            this.pageInvoices.Controls.Add(this.label9);
            this.pageInvoices.Controls.Add(this.label6);
            this.pageInvoices.Controls.Add(this.label7);
            this.pageInvoices.Controls.Add(this.label4);
            this.pageInvoices.Controls.Add(this.label3);
            this.pageInvoices.Controls.Add(this.label2);
            this.pageInvoices.Controls.Add(this.lblAmount);
            this.pageInvoices.Controls.Add(this.cbInvoicesRange);
            this.pageInvoices.Controls.Add(this.cbPaymentStatus);
            this.pageInvoices.Controls.Add(this.cbInvoiceType);
            this.pageInvoices.Controls.Add(this.dgvInvoices);
            this.pageInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInvoices.Location = new System.Drawing.Point(4, 23);
            this.pageInvoices.Name = "pageInvoices";
            this.pageInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.pageInvoices.Size = new System.Drawing.Size(686, 237);
            this.pageInvoices.TabIndex = 2;
            this.pageInvoices.Text = "المشتريات/المرتجعات";
            this.pageInvoices.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "إجمالي الرصيد المستحق من المورد:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "0 جنيه";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "إجمالي الرصيد المتبقي للمورد:";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Red;
            this.lblAmount.Location = new System.Drawing.Point(6, 3);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "0 جنيه";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInvoicesRange
            // 
            this.cbInvoicesRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoicesRange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvoicesRange.FormattingEnabled = true;
            this.cbInvoicesRange.Items.AddRange(new object[] {
            "آخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 6 شهور",
            "أخر 12 شهر"});
            this.cbInvoicesRange.Location = new System.Drawing.Point(305, 6);
            this.cbInvoicesRange.Name = "cbInvoicesRange";
            this.cbInvoicesRange.Size = new System.Drawing.Size(121, 21);
            this.cbInvoicesRange.TabIndex = 2;
            this.cbInvoicesRange.SelectedIndexChanged += new System.EventHandler(this.cbInvoicesRange_SelectedIndexChanged);
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Items.AddRange(new object[] {
            "كل حالات الدفع",
            "مدفوعة بالكامل",
            "مدفوعة جزئيا",
            "غير مدفوعة"});
            this.cbPaymentStatus.Location = new System.Drawing.Point(432, 6);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentStatus.TabIndex = 1;
            this.cbPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cbPaymentStatus_SelectedIndexChanged);
            // 
            // cbInvoiceType
            // 
            this.cbInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoiceType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvoiceType.FormattingEnabled = true;
            this.cbInvoiceType.Items.AddRange(new object[] {
            "كل الحركات",
            "مشتريات",
            "مرتجعات"});
            this.cbInvoiceType.Location = new System.Drawing.Point(559, 6);
            this.cbInvoiceType.Name = "cbInvoiceType";
            this.cbInvoiceType.Size = new System.Drawing.Size(121, 21);
            this.cbInvoiceType.TabIndex = 0;
            this.cbInvoiceType.SelectedIndexChanged += new System.EventHandler(this.cbInvoiceType_SelectedIndexChanged);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToResizeColumns = false;
            this.dgvInvoices.AllowUserToResizeRows = false;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPurchaseNo});
            this.dgvInvoices.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvInvoices.Location = new System.Drawing.Point(6, 33);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(674, 185);
            this.dgvInvoices.TabIndex = 3;
            this.dgvInvoices.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectedCurrentRow_CellMouseClick);
            this.dgvInvoices.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowInvoiceInfo_CellMouseDoubleClick);
            this.dgvInvoices.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInvoices_DataBindingComplete);
            this.dgvInvoices.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvInvoices_RowPrePaint);
            this.dgvInvoices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowInvoiceInfo_KeyDown);
            // 
            // colPurchaseNo
            // 
            this.colPurchaseNo.HeaderText = "م";
            this.colPurchaseNo.Name = "colPurchaseNo";
            this.colPurchaseNo.ReadOnly = true;
            this.colPurchaseNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPurchaseNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPurchaseNo.Width = 50;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // pagePayments
            // 
            this.pagePayments.Controls.Add(this.label1);
            this.pagePayments.Controls.Add(this.label5);
            this.pagePayments.Controls.Add(this.pictureBox);
            this.pagePayments.Controls.Add(this.lblSearchHintText);
            this.pagePayments.Controls.Add(this.txtSearch);
            this.pagePayments.Controls.Add(this.cbPaymentsRange);
            this.pagePayments.Controls.Add(this.cbPaymentMethod);
            this.pagePayments.Controls.Add(this.cbPaymentType);
            this.pagePayments.Controls.Add(this.dgvPayments);
            this.pagePayments.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagePayments.Location = new System.Drawing.Point(4, 23);
            this.pagePayments.Name = "pagePayments";
            this.pagePayments.Padding = new System.Windows.Forms.Padding(3);
            this.pagePayments.Size = new System.Drawing.Size(686, 237);
            this.pagePayments.TabIndex = 3;
            this.pagePayments.Text = "المدفوعات/المقبوضات";
            this.pagePayments.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox.Image = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.pictureBox.Location = new System.Drawing.Point(226, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(30, 26);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 43;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBoxAndSearchHintText_Click);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchHintText.BackColor = System.Drawing.Color.White;
            this.lblSearchHintText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearchHintText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHintText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchHintText.Location = new System.Drawing.Point(9, 8);
            this.lblSearchHintText.Name = "lblSearchHintText";
            this.lblSearchHintText.Size = new System.Drawing.Size(211, 16);
            this.lblSearchHintText.TabIndex = 5;
            this.lblSearchHintText.Text = "أدخل رقم الفاتورة";
            this.lblSearchHintText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearchHintText.Click += new System.EventHandler(this.pictureBoxAndSearchHintText_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // cbPaymentsRange
            // 
            this.cbPaymentsRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentsRange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentsRange.FormattingEnabled = true;
            this.cbPaymentsRange.Items.AddRange(new object[] {
            "آخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 6 شهور",
            "أخر 12 شهر"});
            this.cbPaymentsRange.Location = new System.Drawing.Point(305, 6);
            this.cbPaymentsRange.Name = "cbPaymentsRange";
            this.cbPaymentsRange.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentsRange.TabIndex = 2;
            this.cbPaymentsRange.SelectedIndexChanged += new System.EventHandler(this.cbPaymentsRange_SelectedIndexChanged);
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "كل طرق الدفع",
            "كاش",
            "تحويل بنكي"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(432, 6);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentMethod.TabIndex = 1;
            this.cbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cbPaymentMethod_SelectedIndexChanged);
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "كل المعاملات",
            "المدفوعات",
            "المقبوضات"});
            this.cbPaymentType.Location = new System.Drawing.Point(559, 6);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentType.TabIndex = 0;
            this.cbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cbPaymentType_SelectedIndexChanged);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeColumns = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvPayments.Location = new System.Drawing.Point(6, 33);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(674, 185);
            this.dgvPayments.TabIndex = 4;
            this.dgvPayments.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectedCurrentRow_CellMouseClick);
            this.dgvPayments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowInvoiceInfo_CellMouseDoubleClick);
            this.dgvPayments.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPayments_RowPrePaint);
            this.dgvPayments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowInvoiceInfo_KeyDown);
            // 
            // searchTimer
            // 
            this.searchTimer.Enabled = true;
            this.searchTimer.Interval = 300;
            this.searchTimer.Tick += new System.EventHandler(this.searchTimer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(427, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "🔴 غير مدفوع ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(588, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "🔴 مدفوعة بالكامل ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(546, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "🔴 المقبوضات (أموال داخلة) ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(402, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "🔴 المدفوعات (أموال خارجة) ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(506, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "🔴 مدفوع جزئيا";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(360, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "🔴 مرتجعات";
            // 
            // ctrSupplierInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "ctrSupplierInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(700, 270);
            this.Load += new System.EventHandler(this.ctrSupplierInfo_Load);
            this.tabControl.ResumeLayout(false);
            this.pageBasicInfo.ResumeLayout(false);
            this.pageBasicInfo.PerformLayout();
            this.pageSuppliedProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliedProducts)).EndInit();
            this.pageInvoices.ResumeLayout(false);
            this.pageInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.pagePayments.ResumeLayout(false);
            this.pagePayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageBasicInfo;
        private System.Windows.Forms.TabPage pageSuppliedProducts;
        private Parties.Person.ctrPersonInfo ctrPersonInfo;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.Label lblNotes;
        private Parties.Organization.ctrOrganizationInfo ctrOrganizationInfo;
        private System.Windows.Forms.TabPage pageInvoices;
        private System.Windows.Forms.TabPage pagePayments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridView dgvSuppliedProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPurchaseDataTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPurchasePrice;
        private System.Windows.Forms.ComboBox cbInvoiceType;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.ComboBox cbInvoicesRange;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ComboBox cbPaymentsRange;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.ComboBox cbPaymentType;
        protected System.Windows.Forms.PictureBox pictureBox;
        protected System.Windows.Forms.Label lblSearchHintText;
        protected System.Windows.Forms.TextBox txtSearch;
        protected System.Windows.Forms.Timer searchTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

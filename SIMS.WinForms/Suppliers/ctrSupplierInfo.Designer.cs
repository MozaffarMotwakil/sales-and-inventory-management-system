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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pageSuppliedProducts = new System.Windows.Forms.TabPage();
            this.dgvSuppliedProducts = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPurchaseDataTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbRange = new System.Windows.Forms.ComboBox();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cbInvoiceType = new System.Windows.Forms.ComboBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.colPurchaseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ctrPersonInfo = new SIMS.WinForms.Parties.Person.ctrPersonInfo();
            this.ctrOrganizationInfo = new SIMS.WinForms.Parties.Organization.ctrOrganizationInfo();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pageSuppliedProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliedProducts)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.pageSuppliedProducts);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(694, 264);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrPersonInfo);
            this.tabPage1.Controls.Add(this.lblNotesTitle);
            this.tabPage1.Controls.Add(this.lblNotes);
            this.tabPage1.Controls.Add(this.ctrOrganizationInfo);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "المعلومات الأساسية";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvSuppliedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colProduct,
            this.colUnit,
            this.colLastPurchaseDataTime,
            this.colLastPurchasePrice});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliedProducts.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvSuppliedProducts.Location = new System.Drawing.Point(6, 6);
            this.dgvSuppliedProducts.MultiSelect = false;
            this.dgvSuppliedProducts.Name = "dgvSuppliedProducts";
            this.dgvSuppliedProducts.ReadOnly = true;
            this.dgvSuppliedProducts.RowHeadersVisible = false;
            this.dgvSuppliedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliedProducts.Size = new System.Drawing.Size(674, 225);
            this.dgvSuppliedProducts.TabIndex = 1;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lblAmount);
            this.tabPage3.Controls.Add(this.cbRange);
            this.tabPage3.Controls.Add(this.cbPaymentStatus);
            this.tabPage3.Controls.Add(this.cbInvoiceType);
            this.tabPage3.Controls.Add(this.dgvInvoices);
            this.tabPage3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(686, 237);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "المشتريات/المرتجعات";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.label3.TabIndex = 3;
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
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "0 جنيه";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRange
            // 
            this.cbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRange.FormattingEnabled = true;
            this.cbRange.Items.AddRange(new object[] {
            "آخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 6 شهور",
            "أخر 12 شهر"});
            this.cbRange.Location = new System.Drawing.Point(305, 6);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(121, 21);
            this.cbRange.TabIndex = 2;
            this.cbRange.SelectedIndexChanged += new System.EventHandler(this.cbRange_SelectedIndexChanged);
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
            this.cbPaymentStatus.TabIndex = 2;
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
            this.cbInvoiceType.TabIndex = 2;
            this.cbInvoiceType.SelectedIndexChanged += new System.EventHandler(this.cbInvoiceType_SelectedIndexChanged);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToResizeColumns = false;
            this.dgvInvoices.AllowUserToResizeRows = false;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPurchaseNo});
            this.dgvInvoices.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvInvoices.Location = new System.Drawing.Point(6, 33);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(674, 198);
            this.dgvInvoices.TabIndex = 1;
            this.dgvInvoices.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_CellMouseClick);
            this.dgvInvoices.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_CellMouseDoubleClick);
            this.dgvInvoices.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInvoices_DataBindingComplete);
            this.dgvInvoices.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvInvoices_RowPrePaint);
            this.dgvInvoices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvInvoices_KeyDown);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(686, 237);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "المدفوعات";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 225);
            this.dataGridView1.TabIndex = 0;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pageSuppliedProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliedProducts)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage pageSuppliedProducts;
        private Parties.Person.ctrPersonInfo ctrPersonInfo;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.Label lblNotes;
        private Parties.Organization.ctrOrganizationInfo ctrOrganizationInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridView dgvSuppliedProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPurchaseDataTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPurchasePrice;
        private System.Windows.Forms.ComboBox cbInvoiceType;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.ComboBox cbRange;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    }
}

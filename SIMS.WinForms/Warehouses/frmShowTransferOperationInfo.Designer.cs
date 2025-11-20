namespace SIMS.WinForms.Warehouses
{
    partial class frmShowTransferOperationInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbBaseTransferOperationInfo = new System.Windows.Forms.GroupBox();
            this.gbTransferedInventories = new System.Windows.Forms.GroupBox();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblResponsiableEmployeeName = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.colPreviousSourceQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTransferedOperationDateTime = new System.Windows.Forms.Label();
            this.lblDestinationWarehouseName = new System.Windows.Forms.Label();
            this.colNextSourceQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreviousDestinationQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextDestinationQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransferedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransferedInventoryValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalTransferedInventoriesValue = new System.Windows.Forms.Label();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverageInventoryPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInventoriesCount = new System.Windows.Forms.Label();
            this.lblSourceWarehouseName = new System.Windows.Forms.Label();
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransferedInventories = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbBaseTransferOperationInfo.SuspendLayout();
            this.gbTransferedInventories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferedInventories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.gbTransferedInventories);
            this.panel1.Controls.Add(this.gbBaseTransferOperationInfo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 587);
            this.panel1.TabIndex = 0;
            // 
            // gbBaseTransferOperationInfo
            // 
            this.gbBaseTransferOperationInfo.Controls.Add(this.label11);
            this.gbBaseTransferOperationInfo.Controls.Add(this.label1);
            this.gbBaseTransferOperationInfo.Controls.Add(this.label3);
            this.gbBaseTransferOperationInfo.Controls.Add(this.label2);
            this.gbBaseTransferOperationInfo.Controls.Add(this.label4);
            this.gbBaseTransferOperationInfo.Controls.Add(this.label13);
            this.gbBaseTransferOperationInfo.Controls.Add(this.lblResponsiableEmployeeName);
            this.gbBaseTransferOperationInfo.Controls.Add(this.lblTotalQuantity);
            this.gbBaseTransferOperationInfo.Controls.Add(this.label10);
            this.gbBaseTransferOperationInfo.Controls.Add(this.label8);
            this.gbBaseTransferOperationInfo.Controls.Add(this.lblTransferedOperationDateTime);
            this.gbBaseTransferOperationInfo.Controls.Add(this.lblDestinationWarehouseName);
            this.gbBaseTransferOperationInfo.Controls.Add(this.lblTotalTransferedInventoriesValue);
            this.gbBaseTransferOperationInfo.Controls.Add(this.lblInventoriesCount);
            this.gbBaseTransferOperationInfo.Controls.Add(this.lblSourceWarehouseName);
            this.gbBaseTransferOperationInfo.Controls.Add(this.lblProductsCount);
            this.gbBaseTransferOperationInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBaseTransferOperationInfo.Location = new System.Drawing.Point(3, 3);
            this.gbBaseTransferOperationInfo.Name = "gbBaseTransferOperationInfo";
            this.gbBaseTransferOperationInfo.Size = new System.Drawing.Size(1000, 129);
            this.gbBaseTransferOperationInfo.TabIndex = 0;
            this.gbBaseTransferOperationInfo.TabStop = false;
            this.gbBaseTransferOperationInfo.Text = "التفاصيل الأساسية لعملية النقل";
            // 
            // gbTransferedInventories
            // 
            this.gbTransferedInventories.Controls.Add(this.dgvTransferedInventories);
            this.gbTransferedInventories.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTransferedInventories.Location = new System.Drawing.Point(3, 138);
            this.gbTransferedInventories.Name = "gbTransferedInventories";
            this.gbTransferedInventories.Size = new System.Drawing.Size(1000, 442);
            this.gbTransferedInventories.TabIndex = 0;
            this.gbTransferedInventories.TabStop = false;
            this.gbTransferedInventories.Text = "البضاعة المنقولة";
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUnit.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 14);
            this.label4.TabIndex = 78;
            this.label4.Text = "عدد المخزونات المنقولة:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 14);
            this.label13.TabIndex = 77;
            this.label13.Text = "إجمالي قيمة البضاعة المنقولة:";
            // 
            // lblResponsiableEmployeeName
            // 
            this.lblResponsiableEmployeeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsiableEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.lblResponsiableEmployeeName.Location = new System.Drawing.Point(535, 105);
            this.lblResponsiableEmployeeName.Name = "lblResponsiableEmployeeName";
            this.lblResponsiableEmployeeName.Size = new System.Drawing.Size(305, 16);
            this.lblResponsiableEmployeeName.TabIndex = 67;
            this.lblResponsiableEmployeeName.Text = "N/A";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblTotalQuantity.Location = new System.Drawing.Point(32, 78);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(305, 16);
            this.lblTotalQuantity.TabIndex = 69;
            this.lblTotalQuantity.Text = "N/A";
            // 
            // colPreviousSourceQuantity
            // 
            this.colPreviousSourceQuantity.HeaderText = "الكمية قبل النقل (المصدر)";
            this.colPreviousSourceQuantity.Name = "colPreviousSourceQuantity";
            this.colPreviousSourceQuantity.ReadOnly = true;
            this.colPreviousSourceQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPreviousSourceQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPreviousSourceQuantity.Width = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(384, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 14);
            this.label10.TabIndex = 75;
            this.label10.Text = "إجمالي الكمية المنقولة:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 14);
            this.label8.TabIndex = 82;
            this.label8.Text = "عدد المنتجات المنقولة:";
            // 
            // lblTransferedOperationDateTime
            // 
            this.lblTransferedOperationDateTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferedOperationDateTime.ForeColor = System.Drawing.Color.Black;
            this.lblTransferedOperationDateTime.Location = new System.Drawing.Point(535, 77);
            this.lblTransferedOperationDateTime.Name = "lblTransferedOperationDateTime";
            this.lblTransferedOperationDateTime.Size = new System.Drawing.Size(305, 16);
            this.lblTransferedOperationDateTime.TabIndex = 68;
            this.lblTransferedOperationDateTime.Text = "N/A";
            // 
            // lblDestinationWarehouseName
            // 
            this.lblDestinationWarehouseName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationWarehouseName.ForeColor = System.Drawing.Color.Red;
            this.lblDestinationWarehouseName.Location = new System.Drawing.Point(536, 52);
            this.lblDestinationWarehouseName.Name = "lblDestinationWarehouseName";
            this.lblDestinationWarehouseName.Size = new System.Drawing.Size(304, 16);
            this.lblDestinationWarehouseName.TabIndex = 71;
            this.lblDestinationWarehouseName.Text = "N/A";
            // 
            // colNextSourceQuantity
            // 
            this.colNextSourceQuantity.HeaderText = "الكمية بعد النقل (المصدر)";
            this.colNextSourceQuantity.Name = "colNextSourceQuantity";
            this.colNextSourceQuantity.ReadOnly = true;
            this.colNextSourceQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNextSourceQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNextSourceQuantity.Width = 80;
            // 
            // colPreviousDestinationQuantity
            // 
            this.colPreviousDestinationQuantity.HeaderText = "الكمية قبل النقل (الوجهة)";
            this.colPreviousDestinationQuantity.Name = "colPreviousDestinationQuantity";
            this.colPreviousDestinationQuantity.ReadOnly = true;
            this.colPreviousDestinationQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPreviousDestinationQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPreviousDestinationQuantity.Width = 80;
            // 
            // colNextDestinationQuantity
            // 
            this.colNextDestinationQuantity.HeaderText = "الكمية بعد النقل (الوجهة)";
            this.colNextDestinationQuantity.Name = "colNextDestinationQuantity";
            this.colNextDestinationQuantity.ReadOnly = true;
            this.colNextDestinationQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNextDestinationQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNextDestinationQuantity.Width = 80;
            // 
            // colTransferedQuantity
            // 
            this.colTransferedQuantity.HeaderText = "الكمية المنقولة";
            this.colTransferedQuantity.Name = "colTransferedQuantity";
            this.colTransferedQuantity.ReadOnly = true;
            this.colTransferedQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTransferedQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTransferedQuantity.Width = 80;
            // 
            // colTransferedInventoryValue
            // 
            this.colTransferedInventoryValue.HeaderText = "قيمة البضاعة المنقولة (جنيه)";
            this.colTransferedInventoryValue.Name = "colTransferedInventoryValue";
            this.colTransferedInventoryValue.ReadOnly = true;
            this.colTransferedInventoryValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTransferedInventoryValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTransferedInventoryValue.Width = 80;
            // 
            // lblTotalTransferedInventoriesValue
            // 
            this.lblTotalTransferedInventoriesValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransferedInventoriesValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalTransferedInventoriesValue.Location = new System.Drawing.Point(33, 104);
            this.lblTotalTransferedInventoriesValue.Name = "lblTotalTransferedInventoriesValue";
            this.lblTotalTransferedInventoriesValue.Size = new System.Drawing.Size(304, 16);
            this.lblTotalTransferedInventoriesValue.TabIndex = 73;
            this.lblTotalTransferedInventoriesValue.Text = "N/A";
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
            // colAverageInventoryPurchasePrice
            // 
            this.colAverageInventoryPurchasePrice.HeaderText = "متوسط سعر الشراء عند عملية النقل (جنيه)";
            this.colAverageInventoryPurchasePrice.Name = "colAverageInventoryPurchasePrice";
            this.colAverageInventoryPurchasePrice.ReadOnly = true;
            this.colAverageInventoryPurchasePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAverageInventoryPurchasePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAverageInventoryPurchasePrice.Width = 80;
            // 
            // lblInventoriesCount
            // 
            this.lblInventoriesCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoriesCount.ForeColor = System.Drawing.Color.Black;
            this.lblInventoriesCount.Location = new System.Drawing.Point(32, 50);
            this.lblInventoriesCount.Name = "lblInventoriesCount";
            this.lblInventoriesCount.Size = new System.Drawing.Size(304, 16);
            this.lblInventoriesCount.TabIndex = 70;
            this.lblInventoriesCount.Text = "N/A";
            // 
            // lblSourceWarehouseName
            // 
            this.lblSourceWarehouseName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceWarehouseName.ForeColor = System.Drawing.Color.Red;
            this.lblSourceWarehouseName.Location = new System.Drawing.Point(536, 24);
            this.lblSourceWarehouseName.Name = "lblSourceWarehouseName";
            this.lblSourceWarehouseName.Size = new System.Drawing.Size(304, 16);
            this.lblSourceWarehouseName.TabIndex = 72;
            this.lblSourceWarehouseName.Text = "N/A";
            // 
            // lblProductsCount
            // 
            this.lblProductsCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsCount.ForeColor = System.Drawing.Color.Black;
            this.lblProductsCount.Location = new System.Drawing.Point(32, 24);
            this.lblProductsCount.Name = "lblProductsCount";
            this.lblProductsCount.Size = new System.Drawing.Size(304, 16);
            this.lblProductsCount.TabIndex = 74;
            this.lblProductsCount.Text = "N/A";
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
            // dgvTransferedInventories
            // 
            this.dgvTransferedInventories.AllowUserToAddRows = false;
            this.dgvTransferedInventories.AllowUserToDeleteRows = false;
            this.dgvTransferedInventories.AllowUserToResizeColumns = false;
            this.dgvTransferedInventories.AllowUserToResizeRows = false;
            this.dgvTransferedInventories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferedInventories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransferedInventories.ColumnHeadersHeight = 60;
            this.dgvTransferedInventories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransferedInventories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colProduct,
            this.colUnit,
            this.colTransferedQuantity,
            this.colPreviousSourceQuantity,
            this.colNextSourceQuantity,
            this.colPreviousDestinationQuantity,
            this.colNextDestinationQuantity,
            this.colAverageInventoryPurchasePrice,
            this.colTransferedInventoryValue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransferedInventories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransferedInventories.Location = new System.Drawing.Point(9, 19);
            this.dgvTransferedInventories.MultiSelect = false;
            this.dgvTransferedInventories.Name = "dgvTransferedInventories";
            this.dgvTransferedInventories.ReadOnly = true;
            this.dgvTransferedInventories.RowHeadersVisible = false;
            this.dgvTransferedInventories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTransferedInventories.Size = new System.Drawing.Size(985, 417);
            this.dgvTransferedInventories.TabIndex = 66;
            this.dgvTransferedInventories.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(880, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 14);
            this.label11.TabIndex = 84;
            this.label11.Text = "الموظف المسؤول:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(851, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 14);
            this.label1.TabIndex = 83;
            this.label1.Text = "تاريخ/وقت عملية النقل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(868, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 85;
            this.label3.Text = "إسم المخزن المصدر:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(869, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 14);
            this.label2.TabIndex = 86;
            this.label2.Text = "إسم المخزن الوجهة:";
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(30, -47);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 28;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmShowTransferOperationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowTransferOperationInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض معلومات عملية نقل بضاعة";
            this.Load += new System.EventHandler(this.frmShowTransferOperationInfo_Load);
            this.panel1.ResumeLayout(false);
            this.gbBaseTransferOperationInfo.ResumeLayout(false);
            this.gbBaseTransferOperationInfo.PerformLayout();
            this.gbTransferedInventories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferedInventories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbBaseTransferOperationInfo;
        private System.Windows.Forms.GroupBox gbTransferedInventories;
        private System.Windows.Forms.DataGridView dgvTransferedInventories;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreviousSourceQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextSourceQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreviousDestinationQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextDestinationQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverageInventoryPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferedInventoryValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblResponsiableEmployeeName;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTransferedOperationDateTime;
        private System.Windows.Forms.Label lblDestinationWarehouseName;
        private System.Windows.Forms.Label lblTotalTransferedInventoriesValue;
        private System.Windows.Forms.Label lblInventoriesCount;
        private System.Windows.Forms.Label lblSourceWarehouseName;
        private System.Windows.Forms.Label lblProductsCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancle;
    }
}
namespace SIMS.WinForms.Warehouses
{
    partial class frmTransfareInventories
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalItemsValue = new System.Windows.Forms.Label();
            this.lblTotalItemsCount = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.lblTotalProsuctsCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTransferedInventories = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDestinationWarehouse = new System.Windows.Forms.ComboBox();
            this.cbResponsibleEmployee = new System.Windows.Forms.ComboBox();
            this.cbSourceWarehouse = new System.Windows.Forms.ComboBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTransfareQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCurrentQuantitySource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentQuantityDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAveragePurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransafareQuantityAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferedInventories)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 587);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblTotalItemsValue);
            this.groupBox3.Controls.Add(this.lblTotalItemsCount);
            this.groupBox3.Controls.Add(this.lblTotalQuantity);
            this.groupBox3.Controls.Add(this.lblTotalProsuctsCount);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(125, 493);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(997, 88);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ملخص عملية النقل";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(485, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "مجموع قيمة البضائع المراد نقلها:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(828, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "مجموع العناصر المراد نقلها:";
            // 
            // lblTotalItemsValue
            // 
            this.lblTotalItemsValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsValue.Location = new System.Drawing.Point(352, 65);
            this.lblTotalItemsValue.Name = "lblTotalItemsValue";
            this.lblTotalItemsValue.Size = new System.Drawing.Size(127, 14);
            this.lblTotalItemsValue.TabIndex = 0;
            this.lblTotalItemsValue.Text = "N/A جنيه";
            // 
            // lblTotalItemsCount
            // 
            this.lblTotalItemsCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsCount.Location = new System.Drawing.Point(686, 63);
            this.lblTotalItemsCount.Name = "lblTotalItemsCount";
            this.lblTotalItemsCount.Size = new System.Drawing.Size(127, 14);
            this.lblTotalItemsCount.TabIndex = 0;
            this.lblTotalItemsCount.Text = "N/A";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(352, 27);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(127, 14);
            this.lblTotalQuantity.TabIndex = 0;
            this.lblTotalQuantity.Text = "N/A";
            // 
            // lblTotalProsuctsCount
            // 
            this.lblTotalProsuctsCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProsuctsCount.Location = new System.Drawing.Point(686, 27);
            this.lblTotalProsuctsCount.Name = "lblTotalProsuctsCount";
            this.lblTotalProsuctsCount.Size = new System.Drawing.Size(127, 14);
            this.lblTotalProsuctsCount.TabIndex = 0;
            this.lblTotalProsuctsCount.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(522, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "مجموع الكمية المراد نقلها:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(819, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "مجموع المنتجات المراد نقلها:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTransferedInventories);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1119, 395);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المنتجات المنقولة";
            // 
            // dgvTransferedInventories
            // 
            this.dgvTransferedInventories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferedInventories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransferedInventories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferedInventories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colProduct,
            this.colUnit,
            this.colTransfareQuantity,
            this.ColCurrentQuantitySource,
            this.colStatusSource,
            this.colCurrentQuantityDestination,
            this.colStatusDestination,
            this.colAveragePurchasePrice,
            this.colSellingPrice,
            this.colTransafareQuantityAmount,
            this.colDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransferedInventories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransferedInventories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTransferedInventories.Location = new System.Drawing.Point(6, 22);
            this.dgvTransferedInventories.MultiSelect = false;
            this.dgvTransferedInventories.Name = "dgvTransferedInventories";
            this.dgvTransferedInventories.Size = new System.Drawing.Size(1107, 367);
            this.dgvTransferedInventories.TabIndex = 2;
            this.dgvTransferedInventories.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTransferedInventories_CellBeginEdit);
            this.dgvTransferedInventories.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransferedInventories_CellEndEdit);
            this.dgvTransferedInventories.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTransferedInventories_CellMouseClick);
            this.dgvTransferedInventories.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvTransferedInventories_CellValidating);
            this.dgvTransferedInventories.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTransferedInventories_RowsAdded);
            this.dgvTransferedInventories.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvTransferedInventories_RowsRemoved);
            this.dgvTransferedInventories.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTransferedInventories_RowValidating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTime);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDestinationWarehouse);
            this.groupBox1.Controls.Add(this.cbResponsibleEmployee);
            this.groupBox1.Controls.Add(this.cbSourceWarehouse);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 83);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات النقل الأساسية";
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(442, 22);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.RightToLeftLayout = true;
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(122, 22);
            this.dtpTime.TabIndex = 74;
            this.dtpTime.Value = new System.DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(570, 22);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeftLayout = true;
            this.dtpDate.Size = new System.Drawing.Size(121, 22);
            this.dtpDate.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 14);
            this.label4.TabIndex = 75;
            this.label4.Text = "الموظف المسؤول:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 14);
            this.label3.TabIndex = 75;
            this.label3.Text = "تاريخ ووقت العملية:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1081, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "إلى:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1085, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "من:";
            // 
            // cbDestinationWarehouse
            // 
            this.cbDestinationWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDestinationWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestinationWarehouse.FormattingEnabled = true;
            this.cbDestinationWarehouse.Location = new System.Drawing.Point(826, 53);
            this.cbDestinationWarehouse.Name = "cbDestinationWarehouse";
            this.cbDestinationWarehouse.Size = new System.Drawing.Size(249, 22);
            this.cbDestinationWarehouse.TabIndex = 0;
            this.cbDestinationWarehouse.Leave += new System.EventHandler(this.cbDestinationWarehouse_Leave);
            // 
            // cbResponsibleEmployee
            // 
            this.cbResponsibleEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbResponsibleEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbResponsibleEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbResponsibleEmployee.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResponsibleEmployee.FormattingEnabled = true;
            this.cbResponsibleEmployee.Location = new System.Drawing.Point(442, 53);
            this.cbResponsibleEmployee.Name = "cbResponsibleEmployee";
            this.cbResponsibleEmployee.Size = new System.Drawing.Size(249, 22);
            this.cbResponsibleEmployee.TabIndex = 0;
            this.cbResponsibleEmployee.Validating += new System.ComponentModel.CancelEventHandler(this.cbResponsibleEmployee_Validating);
            // 
            // cbSourceWarehouse
            // 
            this.cbSourceWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSourceWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSourceWarehouse.FormattingEnabled = true;
            this.cbSourceWarehouse.Location = new System.Drawing.Point(826, 22);
            this.cbSourceWarehouse.Name = "cbSourceWarehouse";
            this.cbSourceWarehouse.Size = new System.Drawing.Size(249, 22);
            this.cbSourceWarehouse.TabIndex = 0;
            this.cbSourceWarehouse.Leave += new System.EventHandler(this.cbSourceWarehouse_Leave);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(4, 538);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 29;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(3, 492);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "    حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "م";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNo.Width = 40;
            // 
            // colProduct
            // 
            this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduct.HeaderText = "المنتج";
            this.colProduct.Name = "colProduct";
            this.colProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.Name = "colUnit";
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnit.Width = 120;
            // 
            // colTransfareQuantity
            // 
            this.colTransfareQuantity.HeaderText = "الكمية المراد نقلها";
            this.colTransfareQuantity.Name = "colTransfareQuantity";
            this.colTransfareQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTransfareQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTransfareQuantity.Width = 85;
            // 
            // ColCurrentQuantitySource
            // 
            this.ColCurrentQuantitySource.HeaderText = "الكمية الحالية (المصدر)";
            this.ColCurrentQuantitySource.Name = "ColCurrentQuantitySource";
            this.ColCurrentQuantitySource.ReadOnly = true;
            this.ColCurrentQuantitySource.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCurrentQuantitySource.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCurrentQuantitySource.Width = 80;
            // 
            // colStatusSource
            // 
            this.colStatusSource.HeaderText = "حالة المخزون (المصدر)";
            this.colStatusSource.Name = "colStatusSource";
            this.colStatusSource.ReadOnly = true;
            this.colStatusSource.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStatusSource.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStatusSource.Width = 80;
            // 
            // colCurrentQuantityDestination
            // 
            this.colCurrentQuantityDestination.HeaderText = "الكمية الحالية (الوجهة)";
            this.colCurrentQuantityDestination.Name = "colCurrentQuantityDestination";
            this.colCurrentQuantityDestination.ReadOnly = true;
            this.colCurrentQuantityDestination.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCurrentQuantityDestination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCurrentQuantityDestination.Width = 80;
            // 
            // colStatusDestination
            // 
            this.colStatusDestination.HeaderText = "حالة المخزون (الوجهة)";
            this.colStatusDestination.Name = "colStatusDestination";
            this.colStatusDestination.ReadOnly = true;
            this.colStatusDestination.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStatusDestination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStatusDestination.Width = 80;
            // 
            // colAveragePurchasePrice
            // 
            this.colAveragePurchasePrice.HeaderText = "متوسط سعر الشراء (جنيه)";
            this.colAveragePurchasePrice.Name = "colAveragePurchasePrice";
            this.colAveragePurchasePrice.ReadOnly = true;
            this.colAveragePurchasePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAveragePurchasePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAveragePurchasePrice.Width = 80;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.HeaderText = "سعر البيع (جنيه)";
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.ReadOnly = true;
            this.colSellingPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSellingPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSellingPrice.Width = 80;
            // 
            // colTransafareQuantityAmount
            // 
            this.colTransafareQuantityAmount.HeaderText = "قيمة البضاعة المراد نقلها (جنيه)";
            this.colTransafareQuantityAmount.Name = "colTransafareQuantityAmount";
            this.colTransafareQuantityAmount.ReadOnly = true;
            this.colTransafareQuantityAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTransafareQuantityAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTransafareQuantityAmount.Width = 85;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "حذف";
            this.colDelete.Image = global::SIMS.WinForms.Properties.Resources.delete;
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.Width = 40;
            // 
            // frmTransfareInventories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(1153, 612);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransfareInventories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نقل البضاعة بين المخازن";
            this.Load += new System.EventHandler(this.frmTransfareInventories_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferedInventories)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTransferedInventories;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDestinationWarehouse;
        private System.Windows.Forms.ComboBox cbSourceWarehouse;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalItemsValue;
        private System.Windows.Forms.Label lblTotalItemsCount;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label lblTotalProsuctsCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbResponsibleEmployee;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransfareQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCurrentQuantitySource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentQuantityDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAveragePurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransafareQuantityAmount;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
namespace SIMS.WinForms.Invoices
{
    partial class ctrInvoiceInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPurchasedProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llPartyName = new System.Windows.Forms.LinkLabel();
            this.llCreatedByUser = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblInvoiceStatus = new System.Windows.Forms.Label();
            this.lblInvoiceType = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.gbInvoiceSummary = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTaxTotal = new System.Windows.Forms.Label();
            this.lblDiscountTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colLineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbInvoiceSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPurchasedProducts
            // 
            this.dgvPurchasedProducts.AllowUserToAddRows = false;
            this.dgvPurchasedProducts.AllowUserToDeleteRows = false;
            this.dgvPurchasedProducts.AllowUserToResizeColumns = false;
            this.dgvPurchasedProducts.AllowUserToResizeRows = false;
            this.dgvPurchasedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchasedProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchasedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchasedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchasedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLineNo,
            this.colProduct,
            this.colUnit,
            this.colQuantity,
            this.UnitPrice,
            this.colSubTotal,
            this.colDiscountRate,
            this.colDiscountValue,
            this.colTaxRate,
            this.colTaxValue,
            this.colGrandTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchasedProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchasedProducts.Location = new System.Drawing.Point(5, 4);
            this.dgvPurchasedProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvPurchasedProducts.MultiSelect = false;
            this.dgvPurchasedProducts.Name = "dgvPurchasedProducts";
            this.dgvPurchasedProducts.ReadOnly = true;
            this.dgvPurchasedProducts.RowHeadersVisible = false;
            this.dgvPurchasedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchasedProducts.Size = new System.Drawing.Size(484, 268);
            this.dgvPurchasedProducts.TabIndex = 2;
            this.dgvPurchasedProducts.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.llPartyName);
            this.groupBox1.Controls.Add(this.llCreatedByUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblPaymentAmount);
            this.groupBox1.Controls.Add(this.lblPaymentMethod);
            this.groupBox1.Controls.Add(this.lblInvoiceStatus);
            this.groupBox1.Controls.Add(this.lblInvoiceType);
            this.groupBox1.Controls.Add(this.lblWarehouse);
            this.groupBox1.Controls.Add(this.lblIssuedDate);
            this.groupBox1.Controls.Add(this.lblInvoiceNo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(497, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 179);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الأساسية";
            // 
            // llPartyName
            // 
            this.llPartyName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPartyName.Location = new System.Drawing.Point(6, 142);
            this.llPartyName.Name = "llPartyName";
            this.llPartyName.Size = new System.Drawing.Size(228, 16);
            this.llPartyName.TabIndex = 4;
            this.llPartyName.TabStop = true;
            this.llPartyName.Text = "N/A";
            this.llPartyName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPartyName_LinkClicked);
            // 
            // llCreatedByUser
            // 
            this.llCreatedByUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llCreatedByUser.Location = new System.Drawing.Point(6, 160);
            this.llCreatedByUser.Name = "llCreatedByUser";
            this.llCreatedByUser.Size = new System.Drawing.Size(228, 16);
            this.llCreatedByUser.TabIndex = 4;
            this.llCreatedByUser.TabStop = true;
            this.llCreatedByUser.Text = "N/A";
            this.llCreatedByUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCreatedByUser_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(248, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "المبلغ المدفوع:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(263, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "طريقة الدفع:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(267, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "حالة الفاترة:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(268, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "نوع الفاتورة:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(252, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "المخزن المتأثر:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "أصدرت إلى:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاريخ العملية:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "أصدرت بواسطة:";
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAmount.Location = new System.Drawing.Point(6, 124);
            this.lblPaymentAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(228, 16);
            this.lblPaymentAmount.TabIndex = 0;
            this.lblPaymentAmount.Text = "N/A";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentMethod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(6, 106);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(228, 16);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "N/A";
            // 
            // lblInvoiceStatus
            // 
            this.lblInvoiceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceStatus.Location = new System.Drawing.Point(6, 88);
            this.lblInvoiceStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInvoiceStatus.Name = "lblInvoiceStatus";
            this.lblInvoiceStatus.Size = new System.Drawing.Size(228, 16);
            this.lblInvoiceStatus.TabIndex = 0;
            this.lblInvoiceStatus.Text = "N/A";
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceType.Location = new System.Drawing.Point(6, 70);
            this.lblInvoiceType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(228, 16);
            this.lblInvoiceType.TabIndex = 0;
            this.lblInvoiceType.Text = "N/A";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarehouse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.Location = new System.Drawing.Point(6, 52);
            this.lblWarehouse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(228, 16);
            this.lblWarehouse.TabIndex = 0;
            this.lblWarehouse.Text = "N/A";
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIssuedDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedDate.Location = new System.Drawing.Point(6, 34);
            this.lblIssuedDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(228, 16);
            this.lblIssuedDate.TabIndex = 0;
            this.lblIssuedDate.Text = "N/A";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(6, 16);
            this.lblInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(228, 16);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "N/A";
            // 
            // gbInvoiceSummary
            // 
            this.gbInvoiceSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvoiceSummary.Controls.Add(this.label9);
            this.gbInvoiceSummary.Controls.Add(this.label7);
            this.gbInvoiceSummary.Controls.Add(this.label8);
            this.gbInvoiceSummary.Controls.Add(this.lblGrandTotal);
            this.gbInvoiceSummary.Controls.Add(this.lblTaxTotal);
            this.gbInvoiceSummary.Controls.Add(this.lblDiscountTotal);
            this.gbInvoiceSummary.Controls.Add(this.lblSubtotal);
            this.gbInvoiceSummary.Controls.Add(this.label5);
            this.gbInvoiceSummary.Controls.Add(this.label6);
            this.gbInvoiceSummary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvoiceSummary.Location = new System.Drawing.Point(497, 179);
            this.gbInvoiceSummary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInvoiceSummary.Name = "gbInvoiceSummary";
            this.gbInvoiceSummary.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInvoiceSummary.Size = new System.Drawing.Size(348, 95);
            this.gbInvoiceSummary.TabIndex = 6;
            this.gbInvoiceSummary.TabStop = false;
            this.gbInvoiceSummary.Text = "ملخص الفاتورة";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(235, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "الإجمالي الفرعي";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "إجمالي الضريبة";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "إجمالي الخصم";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(8, 75);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(39, 16);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "00.00";
            // 
            // lblTaxTotal
            // 
            this.lblTaxTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTaxTotal.AutoSize = true;
            this.lblTaxTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxTotal.Location = new System.Drawing.Point(8, 55);
            this.lblTaxTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTaxTotal.Name = "lblTaxTotal";
            this.lblTaxTotal.Size = new System.Drawing.Size(39, 16);
            this.lblTaxTotal.TabIndex = 5;
            this.lblTaxTotal.Text = "00.00";
            // 
            // lblDiscountTotal
            // 
            this.lblDiscountTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiscountTotal.AutoSize = true;
            this.lblDiscountTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTotal.Location = new System.Drawing.Point(8, 37);
            this.lblDiscountTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiscountTotal.Name = "lblDiscountTotal";
            this.lblDiscountTotal.Size = new System.Drawing.Size(39, 16);
            this.lblDiscountTotal.TabIndex = 6;
            this.lblDiscountTotal.Text = "00.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(8, 19);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(39, 16);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "00.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "________________________________________________";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "الإجمالي الكلي";
            // 
            // colLineNo
            // 
            this.colLineNo.FillWeight = 34.76712F;
            this.colLineNo.HeaderText = "م";
            this.colLineNo.Name = "colLineNo";
            this.colLineNo.ReadOnly = true;
            this.colLineNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLineNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLineNo.Width = 35;
            // 
            // colProduct
            // 
            this.colProduct.FillWeight = 171.306F;
            this.colProduct.HeaderText = "المنتج";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colProduct.Width = 250;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUnit.Width = 80;
            // 
            // colQuantity
            // 
            this.colQuantity.FillWeight = 83.51167F;
            this.colQuantity.HeaderText = "الكمية";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQuantity.Width = 60;
            // 
            // UnitPrice
            // 
            this.UnitPrice.FillWeight = 83.51167F;
            this.UnitPrice.HeaderText = "سعر الوحدة (جنيه)";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UnitPrice.Width = 75;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "الإجمالي الفرعي (جنيه)";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSubTotal.Width = 80;
            // 
            // colDiscountRate
            // 
            this.colDiscountRate.HeaderText = "نسبة الخصم";
            this.colDiscountRate.Name = "colDiscountRate";
            this.colDiscountRate.ReadOnly = true;
            this.colDiscountRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDiscountRate.Width = 80;
            // 
            // colDiscountValue
            // 
            this.colDiscountValue.HeaderText = "قيمة الخصم (جنيه)";
            this.colDiscountValue.Name = "colDiscountValue";
            this.colDiscountValue.ReadOnly = true;
            this.colDiscountValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiscountValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDiscountValue.Width = 80;
            // 
            // colTaxRate
            // 
            this.colTaxRate.HeaderText = "نسبة الضريبة";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.ReadOnly = true;
            this.colTaxRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTaxRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTaxRate.Width = 80;
            // 
            // colTaxValue
            // 
            this.colTaxValue.HeaderText = "قيمة الضريبة (جنيه)";
            this.colTaxValue.Name = "colTaxValue";
            this.colTaxValue.ReadOnly = true;
            this.colTaxValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTaxValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTaxValue.Width = 80;
            // 
            // colGrandTotal
            // 
            this.colGrandTotal.FillWeight = 126.9036F;
            this.colGrandTotal.HeaderText = "الإجمالي الكلي (جنيه)";
            this.colGrandTotal.Name = "colGrandTotal";
            this.colGrandTotal.ReadOnly = true;
            this.colGrandTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ctrInvoiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPurchasedProducts);
            this.Controls.Add(this.gbInvoiceSummary);
            this.Name = "ctrInvoiceInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(850, 275);
            this.Load += new System.EventHandler(this.ctrInvoiceInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInvoiceSummary.ResumeLayout(false);
            this.gbInvoiceSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPurchasedProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llCreatedByUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.GroupBox gbInvoiceSummary;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTaxTotal;
        private System.Windows.Forms.Label lblDiscountTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblInvoiceStatus;
        private System.Windows.Forms.Label lblInvoiceType;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.LinkLabel llPartyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrandTotal;
    }
}

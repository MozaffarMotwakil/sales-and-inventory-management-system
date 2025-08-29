namespace SIMS.WinForms.Sales
{
    partial class frmPointOfSale
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
            this.gbInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.dgvPurchasedProducts = new System.Windows.Forms.DataGridView();
            this.gbInvoiceSummary = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSallingOperation = new System.Windows.Forms.GroupBox();
            this.gbProductSearchResults = new System.Windows.Forms.GroupBox();
            this.dgvProductSearchResults = new System.Windows.Forms.DataGridView();
            this.gbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.btnCancleSale = new System.Windows.Forms.Button();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.rtxtAmountPaid = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtTextForSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbBankTransfer = new System.Windows.Forms.RadioButton();
            this.rbCasch = new System.Windows.Forms.RadioButton();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInvoiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedProducts)).BeginInit();
            this.gbInvoiceSummary.SuspendLayout();
            this.gbSallingOperation.SuspendLayout();
            this.gbProductSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearchResults)).BeginInit();
            this.gbPaymentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInvoiceDetails
            // 
            this.gbInvoiceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvoiceDetails.Controls.Add(this.dgvPurchasedProducts);
            this.gbInvoiceDetails.Controls.Add(this.gbInvoiceSummary);
            this.gbInvoiceDetails.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvoiceDetails.Location = new System.Drawing.Point(466, 17);
            this.gbInvoiceDetails.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInvoiceDetails.Name = "gbInvoiceDetails";
            this.gbInvoiceDetails.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInvoiceDetails.Size = new System.Drawing.Size(433, 536);
            this.gbInvoiceDetails.TabIndex = 0;
            this.gbInvoiceDetails.TabStop = false;
            this.gbInvoiceDetails.Text = "Invoice Details";
            // 
            // dgvPurchasedProducts
            // 
            this.dgvPurchasedProducts.AllowUserToAddRows = false;
            this.dgvPurchasedProducts.AllowUserToDeleteRows = false;
            this.dgvPurchasedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchasedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchasedProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchasedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchasedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchasedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductName,
            this.Quantity,
            this.UnitPrice,
            this.Total});
            this.dgvPurchasedProducts.Location = new System.Drawing.Point(8, 37);
            this.dgvPurchasedProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvPurchasedProducts.Name = "dgvPurchasedProducts";
            this.dgvPurchasedProducts.ReadOnly = true;
            this.dgvPurchasedProducts.RowHeadersVisible = false;
            this.dgvPurchasedProducts.Size = new System.Drawing.Size(417, 237);
            this.dgvPurchasedProducts.TabIndex = 1;
            this.dgvPurchasedProducts.TabStop = false;
            // 
            // gbInvoiceSummary
            // 
            this.gbInvoiceSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvoiceSummary.Controls.Add(this.label4);
            this.gbInvoiceSummary.Controls.Add(this.label5);
            this.gbInvoiceSummary.Controls.Add(this.label3);
            this.gbInvoiceSummary.Controls.Add(this.label2);
            this.gbInvoiceSummary.Controls.Add(this.lblGrandTotal);
            this.gbInvoiceSummary.Controls.Add(this.lblTax);
            this.gbInvoiceSummary.Controls.Add(this.lblDiscount);
            this.gbInvoiceSummary.Controls.Add(this.lblSubtotal);
            this.gbInvoiceSummary.Controls.Add(this.label1);
            this.gbInvoiceSummary.Location = new System.Drawing.Point(8, 290);
            this.gbInvoiceSummary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInvoiceSummary.Name = "gbInvoiceSummary";
            this.gbInvoiceSummary.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInvoiceSummary.Size = new System.Drawing.Size(417, 238);
            this.gbInvoiceSummary.TabIndex = 0;
            this.gbInvoiceSummary.TabStop = false;
            this.gbInvoiceSummary.Text = "Invoice Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(5, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(609, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "_________________________________________________________________________________" +
    "_____";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Grand Total";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tax";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Discount";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(357, 195);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(50, 19);
            this.lblGrandTotal.TabIndex = 0;
            this.lblGrandTotal.Text = "00.00";
            // 
            // lblTax
            // 
            this.lblTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(357, 123);
            this.lblTax.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(50, 19);
            this.lblTax.TabIndex = 0;
            this.lblTax.Text = "00.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(358, 80);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(50, 19);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "00.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(357, 37);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(50, 19);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "00.00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // gbSallingOperation
            // 
            this.gbSallingOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSallingOperation.Controls.Add(this.gbProductSearchResults);
            this.gbSallingOperation.Controls.Add(this.gbPaymentInfo);
            this.gbSallingOperation.Controls.Add(this.txtTextForSearch);
            this.gbSallingOperation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSallingOperation.Location = new System.Drawing.Point(16, 17);
            this.gbSallingOperation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbSallingOperation.Name = "gbSallingOperation";
            this.gbSallingOperation.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbSallingOperation.Size = new System.Drawing.Size(433, 536);
            this.gbSallingOperation.TabIndex = 0;
            this.gbSallingOperation.TabStop = false;
            this.gbSallingOperation.Text = "Products Search";
            // 
            // gbProductSearchResults
            // 
            this.gbProductSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbProductSearchResults.Controls.Add(this.dgvProductSearchResults);
            this.gbProductSearchResults.Location = new System.Drawing.Point(9, 83);
            this.gbProductSearchResults.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbProductSearchResults.Name = "gbProductSearchResults";
            this.gbProductSearchResults.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbProductSearchResults.Size = new System.Drawing.Size(417, 199);
            this.gbProductSearchResults.TabIndex = 2;
            this.gbProductSearchResults.TabStop = false;
            this.gbProductSearchResults.Text = "Product Search Results";
            // 
            // dgvProductSearchResults
            // 
            this.dgvProductSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProductSearchResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductSearchResults.Location = new System.Drawing.Point(8, 36);
            this.dgvProductSearchResults.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvProductSearchResults.Name = "dgvProductSearchResults";
            this.dgvProductSearchResults.Size = new System.Drawing.Size(401, 155);
            this.dgvProductSearchResults.TabIndex = 0;
            this.dgvProductSearchResults.TabStop = false;
            // 
            // gbPaymentInfo
            // 
            this.gbPaymentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPaymentInfo.Controls.Add(this.rbBankTransfer);
            this.gbPaymentInfo.Controls.Add(this.rbCasch);
            this.gbPaymentInfo.Controls.Add(this.btnCancleSale);
            this.gbPaymentInfo.Controls.Add(this.btnCompleteSale);
            this.gbPaymentInfo.Controls.Add(this.rtxtAmountPaid);
            this.gbPaymentInfo.Controls.Add(this.label13);
            this.gbPaymentInfo.Controls.Add(this.label11);
            this.gbPaymentInfo.Controls.Add(this.label10);
            this.gbPaymentInfo.Controls.Add(this.lblChange);
            this.gbPaymentInfo.Location = new System.Drawing.Point(9, 290);
            this.gbPaymentInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbPaymentInfo.Name = "gbPaymentInfo";
            this.gbPaymentInfo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbPaymentInfo.Size = new System.Drawing.Size(417, 238);
            this.gbPaymentInfo.TabIndex = 1;
            this.gbPaymentInfo.TabStop = false;
            this.gbPaymentInfo.Text = "Payment Info";
            // 
            // btnCancleSale
            // 
            this.btnCancleSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancleSale.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancleSale.Location = new System.Drawing.Point(41, 178);
            this.btnCancleSale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancleSale.Name = "btnCancleSale";
            this.btnCancleSale.Size = new System.Drawing.Size(161, 52);
            this.btnCancleSale.TabIndex = 5;
            this.btnCancleSale.Text = "Cancle Sale";
            this.btnCancleSale.UseVisualStyleBackColor = true;
            this.btnCancleSale.Click += new System.EventHandler(this.btnCancleSale_Click);
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleteSale.Location = new System.Drawing.Point(210, 178);
            this.btnCompleteSale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(161, 52);
            this.btnCompleteSale.TabIndex = 4;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            // 
            // rtxtAmountPaid
            // 
            this.rtxtAmountPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtAmountPaid.Location = new System.Drawing.Point(187, 30);
            this.rtxtAmountPaid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rtxtAmountPaid.Name = "rtxtAmountPaid";
            this.rtxtAmountPaid.Size = new System.Drawing.Size(222, 36);
            this.rtxtAmountPaid.TabIndex = 1;
            this.rtxtAmountPaid.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Change";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Amount Paid";
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(183, 80);
            this.lblChange.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(50, 19);
            this.lblChange.TabIndex = 0;
            this.lblChange.Text = "00.00";
            // 
            // txtTextForSearch
            // 
            this.txtTextForSearch.Location = new System.Drawing.Point(9, 37);
            this.txtTextForSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTextForSearch.Name = "txtTextForSearch";
            this.txtTextForSearch.Size = new System.Drawing.Size(414, 27);
            this.txtTextForSearch.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Payment Method";
            // 
            // rbBankTransfer
            // 
            this.rbBankTransfer.AutoSize = true;
            this.rbBankTransfer.Location = new System.Drawing.Point(266, 121);
            this.rbBankTransfer.Name = "rbBankTransfer";
            this.rbBankTransfer.Size = new System.Drawing.Size(125, 23);
            this.rbBankTransfer.TabIndex = 3;
            this.rbBankTransfer.Text = "Bank Transfer";
            this.rbBankTransfer.UseVisualStyleBackColor = true;
            // 
            // rbCasch
            // 
            this.rbCasch.AutoSize = true;
            this.rbCasch.Checked = true;
            this.rbCasch.Location = new System.Drawing.Point(187, 121);
            this.rbCasch.Name = "rbCasch";
            this.rbCasch.Size = new System.Drawing.Size(61, 23);
            this.rbCasch.TabIndex = 2;
            this.rbCasch.TabStop = true;
            this.rbCasch.Text = "Cash";
            this.rbCasch.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            this.No.FillWeight = 38.07107F;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.FillWeight = 187.5854F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 91.44786F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UnitPrice
            // 
            this.UnitPrice.FillWeight = 91.44786F;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.FillWeight = 91.44786F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmPointOfSale
            // 
            this.AcceptButton = this.btnCompleteSale;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancleSale;
            this.ClientSize = new System.Drawing.Size(912, 569);
            this.Controls.Add(this.gbSallingOperation);
            this.Controls.Add(this.gbInvoiceDetails);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPointOfSale";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.gbInvoiceDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedProducts)).EndInit();
            this.gbInvoiceSummary.ResumeLayout(false);
            this.gbInvoiceSummary.PerformLayout();
            this.gbSallingOperation.ResumeLayout(false);
            this.gbSallingOperation.PerformLayout();
            this.gbProductSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearchResults)).EndInit();
            this.gbPaymentInfo.ResumeLayout(false);
            this.gbPaymentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInvoiceDetails;
        private System.Windows.Forms.GroupBox gbSallingOperation;
        private System.Windows.Forms.DataGridView dgvPurchasedProducts;
        private System.Windows.Forms.GroupBox gbInvoiceSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox gbPaymentInfo;
        private System.Windows.Forms.TextBox txtTextForSearch;
        private System.Windows.Forms.Button btnCancleSale;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.RichTextBox rtxtAmountPaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbProductSearchResults;
        private System.Windows.Forms.DataGridView dgvProductSearchResults;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbBankTransfer;
        private System.Windows.Forms.RadioButton rbCasch;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
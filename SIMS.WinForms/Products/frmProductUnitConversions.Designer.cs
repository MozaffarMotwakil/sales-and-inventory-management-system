namespace SIMS.WinForms.Products
{
    partial class frmProductUnitConversions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUnitConversions = new System.Windows.Forms.DataGridView();
            this.colUnitConversion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colConversionFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaseUnitName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitConversions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnitConversions
            // 
            this.dgvUnitConversions.AllowUserToResizeColumns = false;
            this.dgvUnitConversions.AllowUserToResizeRows = false;
            this.dgvUnitConversions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnitConversions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnitConversions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUnitConversions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitConversions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnitConversion,
            this.colConversionFactor,
            this.colSellingPrice,
            this.colBarcode,
            this.colDescription,
            this.colDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnitConversions.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUnitConversions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvUnitConversions.Location = new System.Drawing.Point(12, 44);
            this.dgvUnitConversions.MultiSelect = false;
            this.dgvUnitConversions.Name = "dgvUnitConversions";
            this.dgvUnitConversions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnitConversions.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUnitConversions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUnitConversions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnitConversions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUnitConversions.ShowCellToolTips = false;
            this.dgvUnitConversions.Size = new System.Drawing.Size(1010, 250);
            this.dgvUnitConversions.TabIndex = 0;
            this.dgvUnitConversions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitConversions_CellEndEdit);
            this.dgvUnitConversions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dgvUnitConversions.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvUnitConversions_CellValidating);
            this.dgvUnitConversions.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvUnitConversions_EditingControlShowing);
            this.dgvUnitConversions.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvUnitConversions_RowsAdded);
            this.dgvUnitConversions.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvUnitConversions_RowsRemoved);
            this.dgvUnitConversions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUnitConversions_KeyDown);
            // 
            // colUnitConversion
            // 
            this.colUnitConversion.HeaderText = "الوحدة البديلة";
            this.colUnitConversion.Name = "colUnitConversion";
            this.colUnitConversion.Width = 175;
            // 
            // colConversionFactor
            // 
            this.colConversionFactor.HeaderText = "معامل التحويل";
            this.colConversionFactor.MaxInputLength = 10;
            this.colConversionFactor.Name = "colConversionFactor";
            this.colConversionFactor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colConversionFactor.Width = 140;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.HeaderText = "سعر البيع";
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSellingPrice.Width = 150;
            // 
            // colBarcode
            // 
            this.colBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBarcode.HeaderText = "الباركود";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "الوصف المرئي";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDescription.Width = 200;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "حذف";
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.Width = 50;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(501, 299);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(379, 299);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "    حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "الوحدة الأساسية:";
            // 
            // lblBaseUnitName
            // 
            this.lblBaseUnitName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseUnitName.ForeColor = System.Drawing.Color.Red;
            this.lblBaseUnitName.Location = new System.Drawing.Point(130, 9);
            this.lblBaseUnitName.Name = "lblBaseUnitName";
            this.lblBaseUnitName.Size = new System.Drawing.Size(363, 16);
            this.lblBaseUnitName.TabIndex = 3;
            this.lblBaseUnitName.Text = "N/A";
            this.lblBaseUnitName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProductUnitConversions
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(1034, 351);
            this.Controls.Add(this.lblBaseUnitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvUnitConversions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductUnitConversions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الوحدات البديلة للمنتج: [اسم المنتج]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductUnitConversions_FormClosing);
            this.Load += new System.EventHandler(this.frmProductUnitConversions_Load);
            this.Shown += new System.EventHandler(this.frmProductUnitConversions_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitConversions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnitConversions;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaseUnitName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUnitConversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConversionFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
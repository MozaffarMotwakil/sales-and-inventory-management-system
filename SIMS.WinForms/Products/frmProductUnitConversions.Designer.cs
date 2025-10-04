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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUnitConversions = new System.Windows.Forms.DataGridView();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConversionFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitConversion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitConversions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnitConversions
            // 
            this.dgvUnitConversions.AllowUserToResizeColumns = false;
            this.dgvUnitConversions.AllowUserToResizeRows = false;
            this.dgvUnitConversions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnitConversions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnitConversions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitConversions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnitConversion,
            this.colConversionFactor,
            this.colBaseUnit,
            this.colDescription,
            this.colDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnitConversions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnitConversions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvUnitConversions.Location = new System.Drawing.Point(12, 12);
            this.dgvUnitConversions.MultiSelect = false;
            this.dgvUnitConversions.Name = "dgvUnitConversions";
            this.dgvUnitConversions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnitConversions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnitConversions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUnitConversions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnitConversions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUnitConversions.ShowCellToolTips = false;
            this.dgvUnitConversions.Size = new System.Drawing.Size(776, 253);
            this.dgvUnitConversions.TabIndex = 0;
            this.dgvUnitConversions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitConversions_CellEndEdit);
            this.dgvUnitConversions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dgvUnitConversions.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvUnitConversions_CellValidating);
            this.dgvUnitConversions.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvUnitConversions_RowsAdded);
            this.dgvUnitConversions.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvUnitConversions_RowsRemoved);
            this.dgvUnitConversions.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvUnitConversions_RowValidating);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(380, 270);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(258, 270);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "    حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "حذف";
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.Width = 50;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "الوصف المرئي";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDescription.Width = 225;
            // 
            // colBaseUnit
            // 
            this.colBaseUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBaseUnit.HeaderText = "الوحدة الأساسية";
            this.colBaseUnit.Name = "colBaseUnit";
            this.colBaseUnit.ReadOnly = true;
            this.colBaseUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colConversionFactor
            // 
            this.colConversionFactor.HeaderText = "معامل التحويل";
            this.colConversionFactor.MaxInputLength = 10;
            this.colConversionFactor.Name = "colConversionFactor";
            this.colConversionFactor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colConversionFactor.Width = 140;
            // 
            // colUnitConversion
            // 
            this.colUnitConversion.HeaderText = "الوحدة البديلة";
            this.colUnitConversion.Items.AddRange(new object[] {
            "قطعة",
            "كرتونة",
            "علبة",
            "زجاجة",
            "كيلوغرام",
            "لتر",
            "كيس"});
            this.colUnitConversion.Name = "colUnitConversion";
            this.colUnitConversion.Width = 175;
            // 
            // frmProductUnitConversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(800, 317);
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
            this.Text = "إدارة معاملات التحويل للمنتج: [اسم المنتج]";
            this.Load += new System.EventHandler(this.frmProductUnitConversions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitConversions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnitConversions;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUnitConversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConversionFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
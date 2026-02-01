using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Products;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Products
{
    public class BaseUnitForm : frmGenericListBase<clsUnitService, clsUnit>
    {
        public BaseUnitForm() : base(clsUnitService.CreateInstance())
        {
            searchPanel.Location = new Point(540, searchPanel.Location.Y);
            dgvEntitiesList.Size = new Size(710, 310);
            dgvEntitiesList.Location = new Point(dgvEntitiesList.Location.X, 220);
            lblTotalRecords.Location = new Point(lblTotalRecords.Location.X, 425);
            lblTotalRecordsText.Location = new Point(lblTotalRecordsText.Location.X, 425);
        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف الفئة";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم الوحدة";
                base.dgvEntitiesList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[2].HeaderText = "عدد المنتجات المنتمية لهذه الوحدة";
                base.dgvEntitiesList.Columns[2].Width = 120;

                base.dgvEntitiesList.Columns[3].HeaderText = "تاريخ الإنشاء";
                base.dgvEntitiesList.Columns[3].Width = 120;
            }
        }

    }
}

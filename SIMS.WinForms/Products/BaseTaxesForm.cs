using System;
using System.Windows.Forms;
using BusinessLogic.Products;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Products
{
    public class BaseTaxesForm : frmGenericListBase<clsTaxService, clsTax>
    {
        public BaseTaxesForm() : base(clsTaxService.CreateInstance()) { }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "الضريبة الخصم";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم الضريبة";
                base.dgvEntitiesList.Columns[1].Width = 300;

                base.dgvEntitiesList.Columns[2].HeaderText = "معدل الضريبة";
                base.dgvEntitiesList.Columns[2].Width = 100;

                base.dgvEntitiesList.Columns[3].HeaderText = "الوصف";
                base.dgvEntitiesList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[4].HeaderText = "عدد المنتجات المرتبطة بالضريبة";
                base.dgvEntitiesList.Columns[4].Width = 80;

                base.dgvEntitiesList.Columns[5].HeaderText = "تاريخ الإضافة";
                base.dgvEntitiesList.Columns[5].Width = 85;

                base.dgvEntitiesList.Columns[6].HeaderText = "حالة النشاط";
                base.dgvEntitiesList.Columns[6].Width = 80;
            }
        }
    }
}

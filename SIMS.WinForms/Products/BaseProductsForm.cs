using System.Windows.Forms;
using BusinessLogic.Products;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Products
{
    public class BaseProductsForm : frmGenericListBase<clsProductService, clsProduct>
    {
        public BaseProductsForm() : base(clsProductService.CreateInstance()) { }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف المنتج";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم المنتج";
                base.dgvEntitiesList.Columns[1].Width = 275;

                base.dgvEntitiesList.Columns[2].HeaderText = "الفئة/الصنف";
                base.dgvEntitiesList.Columns[2].Width = 150;

                base.dgvEntitiesList.Columns[3].HeaderText = "الوحدة الأساسية";
                base.dgvEntitiesList.Columns[3].Width = 120;

                base.dgvEntitiesList.Columns[4].HeaderText = "عدد الوحدات البديلة";
                base.dgvEntitiesList.Columns[4].Width = 100;

                base.dgvEntitiesList.Columns[5].HeaderText = "عدد الموردين";
                base.dgvEntitiesList.Columns[5].Width = 80;

                base.dgvEntitiesList.Columns[6].HeaderText = "المورد الرئيسي";
                base.dgvEntitiesList.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[7].HeaderText = "حالة التفعيل";
                base.dgvEntitiesList.Columns[7].Width = 80;
            }
        }

    }
}

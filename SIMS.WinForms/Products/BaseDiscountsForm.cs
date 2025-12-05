using System;
using System.Windows.Forms;
using BusinessLogic.Discounts;
using BusinessLogic.Products;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Products
{
    public class BaseDiscountsForm : frmGenericListBase<clsDiscountService, clsDiscount>
    {
        public BaseDiscountsForm() : base(clsDiscountService.CreateInstance())
        {

        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف الخصم";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم الخصم";
                base.dgvEntitiesList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[2].HeaderText = "قيمة الخصم";
                base.dgvEntitiesList.Columns[2].Width = 100;

                base.dgvEntitiesList.Columns[3].HeaderText = "نوع قيمة الخصم";
                base.dgvEntitiesList.Columns[3].Width = 85;

                base.dgvEntitiesList.Columns[4].HeaderText = "الحد الأدنى من الكمية";
                base.dgvEntitiesList.Columns[4].Width = 80;

                base.dgvEntitiesList.Columns[5].HeaderText = "تاريح البداية";
                base.dgvEntitiesList.Columns[5].Width = 125;

                base.dgvEntitiesList.Columns[6].HeaderText = "تاريخ الإنتهاء";
                base.dgvEntitiesList.Columns[6].Width = 125;

                base.dgvEntitiesList.Columns[7].HeaderText = "عدد المنتجات المرتبطة بالخصم";
                base.dgvEntitiesList.Columns[7].Width = 80;

                base.dgvEntitiesList.Columns[8].HeaderText = "تاريخ الإضافة";
                base.dgvEntitiesList.Columns[8].Width = 85;

                base.dgvEntitiesList.Columns[9].HeaderText = "حالة النشاط";
                base.dgvEntitiesList.Columns[9].Width = 80;
            }
        }

    }
}
using System;
using System.Windows.Forms;
using BusinessLogic.Warehouses;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Warehouses
{
    public class BaseInventoriesForm : frmGenericListBase<clsInventoryService, clsInventory>
    {
        public BaseInventoriesForm() : base(clsInventoryService.CreateInstance()) { }
        
        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف المخزون";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "معرف المنتج";
                base.dgvEntitiesList.Columns[1].Visible = false;

                base.dgvEntitiesList.Columns[2].HeaderText = "المنتج";
                base.dgvEntitiesList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[3].HeaderText = "معرف الوحدة";
                base.dgvEntitiesList.Columns[3].Visible = false;

                base.dgvEntitiesList.Columns[4].HeaderText = "الوحدة";
                base.dgvEntitiesList.Columns[4].Width = 90;

                base.dgvEntitiesList.Columns[5].HeaderText = "معرف المخزن";
                base.dgvEntitiesList.Columns[5].Visible = false;

                base.dgvEntitiesList.Columns[6].HeaderText = "المخزن";
                base.dgvEntitiesList.Columns[6].Width = 120;

                base.dgvEntitiesList.Columns[7].HeaderText = "الكمية الحالية";
                base.dgvEntitiesList.Columns[7].Width = 75;

                base.dgvEntitiesList.Columns[8].HeaderText = "حد إعادة الطلب";
                base.dgvEntitiesList.Columns[8].Width = 75;

                base.dgvEntitiesList.Columns[9].HeaderText = "سعر البيع (جنيه)";
                base.dgvEntitiesList.Columns[9].Width = 85;
                base.dgvEntitiesList.Columns[9].DefaultCellStyle.Format = "0.##";

                base.dgvEntitiesList.Columns[10].HeaderText = "متوسط سعر الشراء (جنيه)";
                base.dgvEntitiesList.Columns[10].Width = 85;
                base.dgvEntitiesList.Columns[10].DefaultCellStyle.Format = "0.##";

                base.dgvEntitiesList.Columns[11].HeaderText = "قيمة المخزون (جنيه)";
                base.dgvEntitiesList.Columns[11].Width = 85;
                base.dgvEntitiesList.Columns[11].DefaultCellStyle.Format = "0.##";

                base.dgvEntitiesList.Columns[12].HeaderText = "الربع المتوقع (جنيه)";
                base.dgvEntitiesList.Columns[12].Width = 85;
                base.dgvEntitiesList.Columns[12].DefaultCellStyle.Format = "0.##";

                base.dgvEntitiesList.Columns[13].HeaderText = "معدل الربح (%)";
                base.dgvEntitiesList.Columns[13].Width = 85;

                base.dgvEntitiesList.Columns[14].HeaderText = "حالة المخزون";
                base.dgvEntitiesList.Columns[14].Width = 85;
            }
        }

    }
}

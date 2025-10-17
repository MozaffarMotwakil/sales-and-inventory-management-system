using System.Windows.Forms;
using BusinessLogic.Warehouses;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Warehouses
{
    public class BaseWarehousesForm : frmGenericListBase<clsWarehouseService, clsWarehouse>
    {
        public BaseWarehousesForm() : base(clsWarehouseService.CreateInstance()) { }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف المخزن";
                base.dgvEntitiesList.Columns[0].Width = 105;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم المخزن";
                base.dgvEntitiesList.Columns[1].Width = 225;

                base.dgvEntitiesList.Columns[2].HeaderText = "الموقع/العنوان";
                base.dgvEntitiesList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[3].HeaderText = "عدد العناصر";
                base.dgvEntitiesList.Columns[3].Width = 150;

                base.dgvEntitiesList.Columns[4].HeaderText = "النوع";
                base.dgvEntitiesList.Columns[4].Width = 100;

                base.dgvEntitiesList.Columns[5].HeaderText = "الحالة";
                base.dgvEntitiesList.Columns[5].Width = 100;
            }
        }

    }
}

using System.Windows.Forms;
using BusinessLogic.Suppliers;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Suppliers
{
    public class BaseSuppliersForm : frmGenericListBase<clsSupplierService, clsSupplier>
    {
        public BaseSuppliersForm() : base(clsSupplierService.GetInstance()) { }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف المورد";
                base.dgvEntitiesList.Columns[0].Width = 100;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم المورد";
                base.dgvEntitiesList.Columns[1].Width = 200;

                base.dgvEntitiesList.Columns[2].HeaderText = "نوع المورد";
                base.dgvEntitiesList.Columns[2].Width = 100;

                base.dgvEntitiesList.Columns[3].HeaderText = "الجنسية/البلد";
                base.dgvEntitiesList.Columns[3].Width = 100;

                base.dgvEntitiesList.Columns[4].HeaderText = "رقم الهاتف";
                base.dgvEntitiesList.Columns[4].Width = 100;

                base.dgvEntitiesList.Columns[5].HeaderText = "العنوان";
                base.dgvEntitiesList.Columns[5].Width = 225;

                base.dgvEntitiesList.Columns[6].HeaderText = "الملاحظات";
                base.dgvEntitiesList.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

    }
}

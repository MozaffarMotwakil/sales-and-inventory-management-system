using System.Drawing;
using BusinessLogic.Warehouses;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Warehouses
{
    public class BaseTransferedOperationsForm : frmGenericListBase<clsTransferOperationService, clsTransferOperation>
    {
        public BaseTransferedOperationsForm() : base(clsTransferOperationService.CreateInstance(), false)
        {
            dgvEntitiesList.Location = new Point(dgvEntitiesList.Location.X, 65);
            dgvEntitiesList.Height = 625;
            ShowSearchTextBox = false;
        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف عملية النقل";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "معرف المخزن المصدر";
                base.dgvEntitiesList.Columns[1].Visible = false;

                base.dgvEntitiesList.Columns[2].HeaderText = "المخزن المصدر";
                base.dgvEntitiesList.Columns[2].Width = 200;

                base.dgvEntitiesList.Columns[3].HeaderText = "معرف المخزن الوجهة";
                base.dgvEntitiesList.Columns[3].Visible = false;

                base.dgvEntitiesList.Columns[4].HeaderText = "المخزن الوجهة";
                base.dgvEntitiesList.Columns[4].Width = 200;
                
                base.dgvEntitiesList.Columns[5].HeaderText = "عدد المنتجات المنقولة";
                base.dgvEntitiesList.Columns[5].Width = 80;

                base.dgvEntitiesList.Columns[6].HeaderText = " عدد المخزونات المنقولة";
                base.dgvEntitiesList.Columns[6].Width = 80;

                base.dgvEntitiesList.Columns[7].HeaderText = "إجمالي الكمية المنقولة";
                base.dgvEntitiesList.Columns[7].Width = 80;

                base.dgvEntitiesList.Columns[8].HeaderText = "إجمالي قيمة البضاعة المنقولة (جنيه)";
                base.dgvEntitiesList.Columns[8].Width = 110;

                base.dgvEntitiesList.Columns[9].HeaderText = "معرف الموظف المسؤول";
                base.dgvEntitiesList.Columns[9].Visible = false;

                base.dgvEntitiesList.Columns[10].HeaderText = "الموظف المسؤول";
                base.dgvEntitiesList.Columns[10].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[11].HeaderText = "تاريخ عملية النقل";
                base.dgvEntitiesList.Columns[11].Width = 125;
            }
        }

    }
}

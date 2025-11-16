using System.Drawing;
using BusinessLogic.Warehouses;
using SIMS.WinForms.BaseForms;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Warehouses
{
    public class BaseStockTransactionsForm : frmGenericListBase<clsStockTransactionService, clsStockTransaction>
    {
        public BaseStockTransactionsForm() : base(clsStockTransactionService.CreateInstance()) 
        {
            dgvEntitiesList.Location = new Point(dgvEntitiesList.Location.X, 65);
            dgvEntitiesList.Height = 625;
            pictureBox.Image = Resources.Invoice_32;
        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف سجل الحركة";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "المنتج";
                base.dgvEntitiesList.Columns[1].Width = 250;

                base.dgvEntitiesList.Columns[2].HeaderText = "الوحدة";
                base.dgvEntitiesList.Columns[2].Width = 100;

                base.dgvEntitiesList.Columns[3].HeaderText = "المخزن";
                base.dgvEntitiesList.Columns[3].Width = 160;

                base.dgvEntitiesList.Columns[4].HeaderText = "معرف نوع الحركة";
                base.dgvEntitiesList.Columns[4].Visible = false;

                base.dgvEntitiesList.Columns[5].HeaderText = "نوع الحركة";
                base.dgvEntitiesList.Columns[5].Width = 80;

                base.dgvEntitiesList.Columns[6].HeaderText = "سبب الحركة";
                base.dgvEntitiesList.Columns[6].Width = 120;

                base.dgvEntitiesList.Columns[7].HeaderText = "الكمية قبل الحركة";
                base.dgvEntitiesList.Columns[7].Width = 75;

                base.dgvEntitiesList.Columns[8].HeaderText = "التأثير على المخزون";
                base.dgvEntitiesList.Columns[8].Width = 80;

                base.dgvEntitiesList.Columns[9].HeaderText = "الكمية بعد الحركة";
                base.dgvEntitiesList.Columns[9].Width = 75;

                base.dgvEntitiesList.Columns[10].HeaderText = "معرف الفاتورة المؤثرة";
                base.dgvEntitiesList.Columns[10].Visible = false;

                base.dgvEntitiesList.Columns[11].HeaderText = "معرف عملية النقل";
                base.dgvEntitiesList.Columns[11].Visible = false;

                base.dgvEntitiesList.Columns[12].HeaderText = "تاريخ الحركة";
                base.dgvEntitiesList.Columns[12].Width = 125;

                base.dgvEntitiesList.Columns[13].HeaderText = "رقم الفاتورة المؤثرة";
                base.dgvEntitiesList.Columns[13].Width = 120;

                base.dgvEntitiesList.Columns[14].HeaderText = "الموظف المسؤول";
                base.dgvEntitiesList.Columns[14].Width = 175;
            }
        }

    }
}

using System;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Purchases
{
    public class BasePurchasesForm : frmGenericListBase<clsInvoiceService, clsInvoice>
    {
        public BasePurchasesForm() : base(clsInvoiceService.CreateInstance()) { }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف الفاتورة";
                base.dgvEntitiesList.Columns[0].Width = 100;
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "رقم الفاتورة";
                base.dgvEntitiesList.Columns[1].Width = 150;

                base.dgvEntitiesList.Columns[2].HeaderText = "تاريخ الفاتورة";
                base.dgvEntitiesList.Columns[2].Width = 120;

                base.dgvEntitiesList.Columns[3].HeaderText = "نوع الفاتورة";
                base.dgvEntitiesList.Columns[3].Width = 150;

                base.dgvEntitiesList.Columns[4].HeaderText = "حالة الفاتورة";
                base.dgvEntitiesList.Columns[4].Width = 100;

                base.dgvEntitiesList.Columns[5].HeaderText = "إسم المورد";
                base.dgvEntitiesList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[6].HeaderText = "عدد السطور";
                base.dgvEntitiesList.Columns[6].Width = 100;

                base.dgvEntitiesList.Columns[7].HeaderText = "الإجمالي الكلي";
                base.dgvEntitiesList.Columns[7].Width = 125;
            }
        }

    }
}

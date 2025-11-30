using System;
using System.Drawing;
using BusinessLogic.Payments;
using SIMS.WinForms.BaseForms;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Payments
{
    public class BasePaymentsForm : frmGenericListBase<clsPaymentService, clsPayment>
    {
        public BasePaymentsForm() : base(clsPaymentService.CreateInstance())
        {
            dgvEntitiesList.Location = new Point(dgvEntitiesList.Location.X, 65);
            dgvEntitiesList.Height = 625;
            pictureBox.Image = Resources.Invoice_32;
        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف السند";
                base.dgvEntitiesList.Columns[0].Width = 65;

                base.dgvEntitiesList.Columns[1].HeaderText = "تاريخ السند";
                base.dgvEntitiesList.Columns[1].Width = 90;

                base.dgvEntitiesList.Columns[2].HeaderText = "نوع السند";
                base.dgvEntitiesList.Columns[2].Width = 100;

                base.dgvEntitiesList.Columns[3].HeaderText = "الطرف المقابل";
                base.dgvEntitiesList.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[4].HeaderText = "سبب إصدار السند";
                base.dgvEntitiesList.Columns[4].Width = 120;

                base.dgvEntitiesList.Columns[5].HeaderText = "معرف الفاتورة";
                base.dgvEntitiesList.Columns[5].Visible = false;

                base.dgvEntitiesList.Columns[6].HeaderText = "رقم الفاتورة";
                base.dgvEntitiesList.Columns[6].Width = 100;

                base.dgvEntitiesList.Columns[7].HeaderText = "المبلغ (جنيه)";
                base.dgvEntitiesList.Columns[7].Width = 100;

                base.dgvEntitiesList.Columns[8].HeaderText = "طريقة الدقع";
                base.dgvEntitiesList.Columns[8].Width = 100;

                base.dgvEntitiesList.Columns[9].HeaderText = "الموظف المسؤول";
                base.dgvEntitiesList.Columns[9].Width = 180;
            }
        }

    }
}

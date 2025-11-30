using System;
using System.Drawing;
using BusinessLogic.Suppliers;
using SIMS.WinForms.BaseForms;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Suppliers
{
    public class BaseSuppliedItemsLogForm : frmGenericListBase<clsSupplierService, clsSupplier>
    {
        public BaseSuppliedItemsLogForm() : base(clsSupplierService.CreateInstance(), true)
        {
            dgvEntitiesList.Location = new Point(dgvEntitiesList.Location.X, 65);
            dgvEntitiesList.Height = 625;
            pictureBox.Image = Resources.Invoice_32;
        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف الفاتورة";
                base.dgvEntitiesList.Columns[0].Visible = false;

                base.dgvEntitiesList.Columns[1].HeaderText = "تاريخ الفاتورة";
                base.dgvEntitiesList.Columns[1].Width = 90;

                base.dgvEntitiesList.Columns[2].HeaderText = "رقم الفاتورة";
                base.dgvEntitiesList.Columns[2].Width = 120;

                base.dgvEntitiesList.Columns[3].HeaderText = "معرف نوع الحركة";
                base.dgvEntitiesList.Columns[3].Visible = false;

                base.dgvEntitiesList.Columns[4].HeaderText = "نوع الفاتورة";
                base.dgvEntitiesList.Columns[4].Width = 100;

                base.dgvEntitiesList.Columns[5].HeaderText = "معرف المخزن";
                base.dgvEntitiesList.Columns[5].Visible = false;

                base.dgvEntitiesList.Columns[6].HeaderText = "المخزن";
                base.dgvEntitiesList.Columns[6].Width = 150;

                base.dgvEntitiesList.Columns[7].HeaderText = "معرف المورد";
                base.dgvEntitiesList.Columns[7].Visible = false;

                base.dgvEntitiesList.Columns[8].HeaderText = "المورد";
                base.dgvEntitiesList.Columns[8].Width = 200;

                base.dgvEntitiesList.Columns[9].HeaderText = "معرف المنتج";
                base.dgvEntitiesList.Columns[9].Visible = false;

                base.dgvEntitiesList.Columns[10].HeaderText = "المنتج";
                base.dgvEntitiesList.Columns[10].Width = 225;

                base.dgvEntitiesList.Columns[11].HeaderText = "معرف الوحدة";
                base.dgvEntitiesList.Columns[11].Visible = false;

                base.dgvEntitiesList.Columns[12].HeaderText = "الوحدة";
                base.dgvEntitiesList.Columns[12].Width = 85;

                base.dgvEntitiesList.Columns[13].HeaderText = "سعر الوحدة (جنيه)";
                base.dgvEntitiesList.Columns[13].Width = 100;

                base.dgvEntitiesList.Columns[14].HeaderText = "السعر الصافي للوحدة (جنيه)";
                base.dgvEntitiesList.Columns[14].Width = 100;

                base.dgvEntitiesList.Columns[15].HeaderText = "الكمية";
                base.dgvEntitiesList.Columns[15].Width = 100;

                base.dgvEntitiesList.Columns[16].HeaderText = "الإجمالي الفرعي (جنيه)";
                base.dgvEntitiesList.Columns[16].Width = 120;

                base.dgvEntitiesList.Columns[17].HeaderText = "قيمة الخصم (جنيه)";
                base.dgvEntitiesList.Columns[17].Width = 100;

                base.dgvEntitiesList.Columns[18].HeaderText = "قيمة الضريبة (جنيه)";
                base.dgvEntitiesList.Columns[18].Width = 100;

                base.dgvEntitiesList.Columns[19].HeaderText = "الإجمالي النهائي (جنيه)";
                base.dgvEntitiesList.Columns[19].Width = 120;
            }
        }

    }
}
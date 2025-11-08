using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Warehouses;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Warehouses
{
    public class BaseStockTransactionsForm : frmGenericListBase<clsStockTransactionService, clsStockTransaction>
    {
        public BaseStockTransactionsForm() : base(clsStockTransactionService.CreateInstance()) 
        {
            dgvEntitiesList.RowPrePaint += dgvEntitiesList_RowPrePaint;
            dgvEntitiesList.Location = new Point(dgvEntitiesList.Location.X, 65);
            dgvEntitiesList.Height = 625;
            ShowSearchTextBox = false;
        }

        private void dgvEntitiesList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int transactionType = Convert.ToInt32(dgvEntitiesList.Rows[e.RowIndex].Cells["TransactionTypeID"].Value);

                if (transactionType == 1)
                {
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else if (transactionType == 2)
                {
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvEntitiesList.DefaultCellStyle.BackColor;
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dgvEntitiesList.DefaultCellStyle.ForeColor;
                }
            }
        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف سجل الحركة";
                base.dgvEntitiesList.Columns[0].Visible = false;
                base.dgvEntitiesList.Columns[0].Width = 105;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم المنتج";
                base.dgvEntitiesList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[2].HeaderText = "إسم الوحدة";
                base.dgvEntitiesList.Columns[2].Width = 90;

                base.dgvEntitiesList.Columns[3].HeaderText = "إسم المخزن";
                base.dgvEntitiesList.Columns[3].Width = 100;

                base.dgvEntitiesList.Columns[4].HeaderText = "معرف نوع الحركة";
                base.dgvEntitiesList.Columns[4].Visible = false;
                base.dgvEntitiesList.Columns[4].Width = 100;

                base.dgvEntitiesList.Columns[5].HeaderText = "نوع الحركة";
                base.dgvEntitiesList.Columns[5].Width = 80;

                base.dgvEntitiesList.Columns[6].HeaderText = "الكمية قبل الحركة";
                base.dgvEntitiesList.Columns[6].Width = 75;

                base.dgvEntitiesList.Columns[7].HeaderText = "التأثير على المخزون";
                base.dgvEntitiesList.Columns[7].Width = 75;

                base.dgvEntitiesList.Columns[8].HeaderText = "الكمية بعد الحركة";
                base.dgvEntitiesList.Columns[8].Width = 75;

                base.dgvEntitiesList.Columns[9].HeaderText = "رقم الفاتورة المؤثرة";
                base.dgvEntitiesList.Columns[9].Width = 120;

                base.dgvEntitiesList.Columns[10].HeaderText = "الموظف المسؤول";
                base.dgvEntitiesList.Columns[10].Width = 150;

                base.dgvEntitiesList.Columns[11].HeaderText = "تاريخ الحركة";
                base.dgvEntitiesList.Columns[11].Width = 125;
            }
        }
    }
}

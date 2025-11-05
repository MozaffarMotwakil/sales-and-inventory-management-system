using System;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Products;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmInventoriesList : BaseInventoriesForm
    {
        public frmInventoriesList()
        {
            InitializeComponent();
        }

        private void frmInventoriesList_Load(object sender, EventArgs e)
        {
            contextMenuStrip.Items.Clear();

            contextMenuStrip.Items.Add("عرض سجل النشاط");
            contextMenuStrip.Items[0].Click += ShowTransactionLog_Click;

            contextMenuStrip.Items.Add("عرض تفاصيل المنتج");
            contextMenuStrip.Items[1].Click += ShowProductInfo_Click;

            contextMenuStrip.Items.Add("تعديل حد إعادة الطلب");
            contextMenuStrip.Items[2].Click += UpdateReorderQuantity_Click;
        }

        private void UpdateReorderQuantity_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            frmUpdateReorderInventoryQuantity inventoryQuantity = new frmUpdateReorderInventoryQuantity(clsFormHelper.GetSelectedRowID(dgvEntitiesList));
            inventoryQuantity.ShowDialog();
        }

        private void ShowProductInfo_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            int? productID = (int?)GetCellValue(dgvEntitiesList.Columns["ProductID"].Index);

            if (productID.HasValue)
            {
                frmAddEditProduct editProduct = new frmAddEditProduct(productID.Value);
                editProduct.ShowDialog();
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على المنتج");
            }
        }

        private void ShowTransactionLog_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }


        }

    }
}

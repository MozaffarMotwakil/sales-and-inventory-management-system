using System;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmUpdateReorderInventoryQuantity : Form
    {
        private clsInventory _Inventory;

        public frmUpdateReorderInventoryQuantity(int inventoryID)
        {
            InitializeComponent();
            _Inventory = clsInventoryService.CreateInstance().Find(inventoryID);
        }

        private void frmUpdateReorderInventoryQuantity_Load(object sender, EventArgs e)
        {
            if (_Inventory == null)
            { 
                clsFormMessages.ShowError("لم يتم العثور على المخزون");
                this.Close();
                return;
            }

            lblProductName.Text = _Inventory.ProductInfo.ProductName;
            lblUnitName.Text = _Inventory.UnitInfo.UnitName;
            lblWarehouseName.Text = _Inventory.WarehouseInfo.WarehouseName;
            txtReorderQuantity.Text = _Inventory.ReorderQuantity.ToString();
        }

        private void txtReorderQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReorderQuantity.Text))
            {
                errorProvider.SetError(txtReorderQuantity, "لا يمكن أن يكون حقل حد إعادة الطلب فارغاً");
            }
            else if (!int.TryParse(txtReorderQuantity.Text, out int reorderQuantity))
            {
                errorProvider.SetError(txtReorderQuantity, "يجب أن يكون حد إعادة الطلب قيمة رقمية صحيحة");
            }
            else if (reorderQuantity < 0)
            {
                errorProvider.SetError(txtReorderQuantity, "لا يمكن أن يكون حد إعادة الطلب بالسالب");
            }
            else
            {
                errorProvider.SetError(txtReorderQuantity, string.Empty);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsFormValidation.IsDataValid(this, errorProvider))
            {
                clsFormMessages.ShowInvalidDataError();
                return;
            }

            if (!clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                return;
            }

            if (_Inventory.UpdateReorderQuantity(int.Parse(txtReorderQuantity.Text)))
            {
                clsFormMessages.ShowSuccess("تم تعديل حد إعادة الطلب لهذا المخزون بنجاح");
                this.Close();
            }
            else
            {
                clsFormMessages.ShowError("فشل إعادة تعيين حد إعادة الطلب لهذا المخزون");
            }
        }

    }
}

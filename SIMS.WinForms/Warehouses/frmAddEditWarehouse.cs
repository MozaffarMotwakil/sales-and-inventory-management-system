using System;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmAddEditWarehouse : Form
    {
        private clsWarehouse _Warehouse;
        private enMode _FormMode;

        public frmAddEditWarehouse()
        {
            InitializeComponent();
            _Warehouse = null;
            _FormMode = enMode.Add;
        }

        public frmAddEditWarehouse(clsWarehouse warehouse)
        {
            InitializeComponent();
            _Warehouse = warehouse;
            _FormMode = enMode.Edit;
        }

        private void frmAddEditWarehouse_Load(object sender, EventArgs e)
        {
            this.Text = _FormMode is enMode.Add ?
                "إضافة مخزن جديد" :
                "تعديل معلومات مخزن";

            if (_FormMode is enMode.Edit)
            {
                if (_Warehouse is null)
                {
                    this.Close();
                    clsFormMessages.ShowError("لم يتم العثور على المخزن");
                    return;
                }

                txtWarehouseName.Text = _Warehouse.WarehouseName;
                rbActive.Checked = _Warehouse.IsActive;
                rbInActive.Checked = !_Warehouse.IsActive;
                rbMainWarehouse.Checked = _Warehouse.IsMainWarehouse;
                rbSubWarehouse.Checked = !_Warehouse.IsMainWarehouse;
                txtAddress.Text = _Warehouse.Address;
            }
        }

        private void frmAddEditWarehouse_Shown(object sender, EventArgs e)
        {
            txtWarehouseName.Focus();
        }

        private void txtWarehouseName_Validating(object sender, CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtWarehouseName, errorProvider, "لايمكن أن يكون إسم المخزن فارغا");
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtAddress, errorProvider, "لا يمكن أن يكون عنوان المخزن فارغا");
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
                
            if (_FormMode is enMode.Add)
            {
                _Warehouse = new clsWarehouse(
                    txtWarehouseName.Text, 
                    txtAddress.Text, 
                    rbMainWarehouse.Checked, 
                    rbActive.Checked
                    );
            }
            else
            {
                _Warehouse.WarehouseName = txtWarehouseName.Text;
                _Warehouse.Address = txtAddress.Text;
                _Warehouse.IsMainWarehouse = rbMainWarehouse.Checked;
                _Warehouse.IsActive = rbActive.Checked;
            }

            clsValidationResult validationResult = clsWarehouseService.GetInstance().Save(_Warehouse);

            if (validationResult.IsValid)
            {
                if (_FormMode is enMode.Add)
                {
                    clsFormMessages.ShowSuccess("تم إضافة المخزن بنجاح");
                }
                else
                {
                    clsFormMessages.ShowSuccess("تم حفظ التغيرات بنجاح");
                }

                this.Close();
            }
            else
            {
                clsFormMessages.ShowValidationErrors(validationResult);
            }
        }

    }
}

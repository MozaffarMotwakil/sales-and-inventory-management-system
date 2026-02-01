using System;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Products;
using BusinessLogic.Validation;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Products
{
    public partial class frmAddEditUnit : Form
    {
        private clsUnit _Unit;
        private enMode _FormMode;

        public frmAddEditUnit()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
        }

        public frmAddEditUnit(int unitID)
        {
            InitializeComponent();
            _Unit = clsUnitService.CreateInstance().Find(unitID);
            _FormMode = enMode.Edit;
        }

        public frmAddEditUnit(clsUnit unit)
        {
            InitializeComponent();
            _Unit = unit;
            _FormMode = enMode.Edit;
        }

        private void frmAddEditUnit_Load(object sender, EventArgs e)
        {
            this.Text = _FormMode is enMode.Add ?
                "إضافة وحدة جديدة" :
                "تعديل معلومات وحدة";

            if (_FormMode is enMode.Edit)
            {
                if (_Unit == null)
                {
                    this.Close();
                    clsFormMessages.ShowError("لم يتم العثور على الوحدة");
                    return;
                }

                txtUnitName.Text = _Unit.UnitName;
            }
        }

        private void txtUnitName_Validating(object sender, CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtUnitName, errorProvider, "يجب إدخال إسم للوحدة");
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

            if (_FormMode is enMode.Add)
            {
                _Unit = new clsUnit(
                    txtUnitName.Text
                    );
            }
            else
            {
                _Unit.UnitName = txtUnitName.Text;
            }

            clsValidationResult validationResult = _Unit.Save();

            if (validationResult.IsValid)
            {
                if (_FormMode is enMode.Add)
                {
                    clsFormMessages.ShowSuccess("تم إضافة الوحدة بنجاح");
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

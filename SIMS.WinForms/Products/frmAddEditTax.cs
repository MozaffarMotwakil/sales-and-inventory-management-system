using System;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Products;
using BusinessLogic.Validation;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Products
{
    public partial class frmAddEditTax : Form
    {
        private clsTax _Tax;
        private enMode _FormMode;

        public frmAddEditTax()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
        }

        public frmAddEditTax(clsTax Tax)
        {
            InitializeComponent();
            _Tax = Tax;
            _FormMode = enMode.Edit;
        }

        private void frmAddEditTax_Load(object sender, EventArgs e)
        {
            this.Text = _FormMode == enMode.Add ?
                "إضافة ضريبة جديد" :
                "تعديل ضريبة";

            if (_FormMode is enMode.Edit)
            {
                if (_Tax == null)
                {
                    clsFormMessages.ShowError("لم يتم العثور على الضريبة");
                    this.Close();
                    return;
                }

                txtTaxName.Text = _Tax.TaxName;
                txtTaxRate.Text = _Tax.TaxRate.ToString();
                txtDescription.Text = _Tax.Description;
            }
        }

        private void txtTaxName_Validating(object sender, CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtTaxName, errorProvider, "لا يمكن أن يكون حقل إسم الضريبة فارغا");
        }

        private void txtTaxRate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaxRate.Text))
            {
                errorProvider.SetError(txtTaxRate, "لا يمكن أن يكون حقل معدل الضريبة فارغاً");
            }
            else if (!decimal.TryParse(txtTaxRate.Text, out decimal sellingPrice) || sellingPrice < 1)
            {
                errorProvider.SetError(txtTaxRate, "يجب إدخال قيمة رقمية موجبة صحيحة أو عشرية لمعدل الضريبة");
            }
            else
            {
                errorProvider.SetError(txtTaxRate, string.Empty);
            }
        }

        private void txtTaxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsFormValidation.HandleFloatingKeyPress(e, txtTaxRate, errorProvider);
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
                _Tax = new clsTax(
                    txtTaxName.Text,
                    Convert.ToDecimal(txtTaxRate.Text),
                    txtDescription.Text
                    );
            }
            else
            {
                _Tax.TaxName = txtTaxName.Text;
                _Tax.TaxRate = Convert.ToDecimal(txtTaxRate.Text);
                _Tax.Description = txtDescription.Text;
            }

            clsValidationResult validationResult = _Tax.Save();

            if (validationResult.IsValid)
            {
                if (_FormMode is enMode.Add)
                {
                    clsFormMessages.ShowSuccess("تم إضافة الضريبة بنجاح");
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

using System;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Products;
using BusinessLogic.Validation;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Products
{
    public partial class frmAddEditDiscount : Form
    {
        private clsDiscount _Discount;
        private enMode _FormMode;

        public frmAddEditDiscount()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
        }

        public frmAddEditDiscount(clsDiscount discount)
        {
            InitializeComponent();
            _Discount = discount;
            _FormMode = enMode.Edit;
        }

        private void frmAddEditDiscount_Load(object sender, EventArgs e)
        {
            this.Text = _FormMode == enMode.Add ?
                "إضافة خصم جديد" :
                "تعديل خصم";

            if (_FormMode is enMode.Edit)
            {
                if (_Discount == null)
                {
                    clsFormMessages.ShowError("لم يتم العثور على الخصم");
                    this.Close();
                    return;
                }

                txtDiscountName.Text = _Discount.DiscountName;
                rbPercentage.Checked = _Discount.DiscountValueType == clsDiscount.enValueType.Percentage ? 
                    false :
                    true;
                rbAmount.Checked = !rbPercentage.Checked;
                txtDiscountValue.Text = _Discount.DiscountValue.ToString();
                txtMinimumQuantity.Text = _Discount.MinimumQuantity.ToString();
                dtpStartDate.Value = _Discount.StartDate;
                dtpEndDate.Value = _Discount.EndDate;
            }
        }

        private void txtDiscountName_Validating(object sender, CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtDiscountName, errorProvider, "لا يمكن أن يكون حقل إسم الخصم فارغا");
        }

        private void txtDiscountValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiscountValue.Text))
            {
                errorProvider.SetError(txtDiscountValue, "لا يمكن أن يكون حقل قيمة الخصم فارغاً");
            }
            else if (!decimal.TryParse(txtDiscountValue.Text, out decimal sellingPrice) || sellingPrice < 1)
            {
                errorProvider.SetError(txtDiscountValue, "يجب إدخال قيمة رقمية موجبة صحيحة أو عشرية لقيمة الخصم");
            }
            else
            {
                errorProvider.SetError(txtDiscountValue, string.Empty);
            }
        }

        private void txtDiscountValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsFormValidation.HandleFloatingKeyPress(e, txtDiscountValue, errorProvider);
        }

        private void txtMinimumQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMinimumQuantity.Text))
            {
                errorProvider.SetError(txtMinimumQuantity, "لا يمكن أن يكون حقل الحد الأدنى للكمية فارغاً");
            }
            else if (!int.TryParse(txtMinimumQuantity.Text, out int reorderQuantity))
            {
                errorProvider.SetError(txtMinimumQuantity, "يجب أن يكون الحد الأدنى للكمية قيمة رقمية صحيحة");
            }
            else if (reorderQuantity < 0)
            {
                errorProvider.SetError(txtMinimumQuantity, "لا يمكن أن يكون الحد الأدنى للكمية بالسالب");
            }
            else
            {
                errorProvider.SetError(txtMinimumQuantity, string.Empty);
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

            if (_FormMode is enMode.Add)
            {
                _Discount = new clsDiscount(
                    txtDiscountName.Text,
                    Convert.ToDecimal(txtDiscountValue.Text),
                    rbPercentage.Checked ? clsDiscount.enValueType.Percentage : clsDiscount.enValueType.Amount,
                    Convert.ToInt32(txtMinimumQuantity.Text),
                    dtpStartDate.Value,
                    dtpEndDate.Value
                    );
            }
            else
            {
                _Discount.DiscountName = txtDiscountName.Text;
                _Discount.DiscountValue = Convert.ToDecimal(txtDiscountValue.Text);
                _Discount.DiscountValueType = rbPercentage.Checked ?
                    clsDiscount.enValueType.Percentage :
                    clsDiscount.enValueType.Amount;
                _Discount.MinimumQuantity = Convert.ToInt32(txtMinimumQuantity.Text);
                _Discount.StartDate = dtpStartDate.Value;
                _Discount.EndDate = dtpEndDate.Value;
            }

            clsValidationResult validationResult = _Discount.Save();

            if (validationResult.IsValid)
            {
                if (_FormMode is enMode.Add)
                {
                    clsFormMessages.ShowSuccess("تم إضافة الخصم بنجاح");
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

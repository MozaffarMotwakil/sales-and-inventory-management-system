using System;
using System.Windows.Forms;
using BusinessLogic;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmAddEditSupplier : Form
    {
        public enMode FormMode;
        private clsSupplier _Supplier;

        public frmAddEditSupplier()
        {
            InitializeComponent();
            _Supplier = null;
            FormMode = enMode.Add;
        }

        public frmAddEditSupplier(int supplierID)
        {
            InitializeComponent();
            _Supplier = null;
            FormMode = enMode.Edit;
        }

        private void frmAddEditSupplier_Load(object sender, EventArgs e)
        {
            if (FormMode == enMode.Add)
            {
                this.Text = lblFormTitle.Text = "إضافة مورد جديد";
            }
            else
            {
                this.Text = lblFormTitle.Text = "تعديل بيانات مورد";
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

            if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                if (FormMode is enMode.Add)
                {
                    _Supplier = new clsSupplier(
                        null,
                        txtNotes.Text
                    );
                }
                else
                {

                }

                clsValidationResult validationResult = _Supplier.Save();

                if (validationResult.IsValid)
                {
                    if (FormMode is enMode.Add)
                    {
                        clsFormMessages.ShowSuccess("تم إضافة المورد بنجاح");
                    }
                    else
                    {
                        clsFormMessages.ShowSuccess("تم حفظ التغيرات بنجاح");
                    }

                    this.Close();
                }
                else
                {
                    string errorMessages = string.Join(Environment.NewLine, validationResult.ConvertErrorsListToStringList());
                    clsFormMessages.ShowError(errorMessages, "فشل الحفظ");
                }
            }
        }

    }
}

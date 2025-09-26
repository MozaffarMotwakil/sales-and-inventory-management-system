using System;
using System.Windows.Forms;
using BusinessLogic;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmAddEditSupplier : Form
    {
        private clsParty.enPartyCategory _SupplierCatigory;
        public clsParty.enPartyCategory SupplierCatigory 
        {
            get
            {
                return _SupplierCatigory;
            }
            set
            {
                _SupplierCatigory = value;

                switch (_SupplierCatigory)
                {
                    case clsParty.enPartyCategory.Person:
                        ctrAddEditOrganization.Visible = false;
                        ctrAddEditPerson.Visible = true;
                        ctrAddEditPerson.AttachErrorProvider(errorProvider);
                        break;
                    case clsParty.enPartyCategory.Organization:
                        ctrAddEditPerson.Visible = false;
                        ctrAddEditOrganization.Visible = true;
                        gbOtherInfo.Location = new System.Drawing.Point(
                            gbOtherInfo.Location.X,
                            397
                            );
                        btnSave.Location = new System.Drawing.Point(
                            btnSave.Location.X,
                            545
                            );
                        btnCancle.Location = new System.Drawing.Point(
                            btnCancle.Location.X,
                            545
                            );
                        panel.Size = new System.Drawing.Size(panel.Width, 600);
                        this.Size = new System.Drawing.Size(this.Width, 660);
                        ctrAddEditOrganization.AttachErrorProvider(errorProvider);
                        break;
                    default:
                        break;
                }
            }
        }

        public enMode FormMode;
        private clsSupplier _Supplier;

        public frmAddEditSupplier(clsParty.enPartyCategory supplierType)
        {
            InitializeComponent();
            _Supplier = null;
            SupplierCatigory = supplierType;
            FormMode = enMode.Add;
        }

        public frmAddEditSupplier(int supplierID, clsParty.enPartyCategory supplierType)
        {
            InitializeComponent();
            _Supplier = null;
            SupplierCatigory = supplierType;
            FormMode = enMode.Edit;
        }

        private void frmAddEditSupplier_Load(object sender, EventArgs e)
        {
            if (FormMode is enMode.Add)
            {
                this.Text = lblFormTitle.Text = SupplierCatigory is clsParty.enPartyCategory.Person ?
                    "إضافة مورد جديد - شخص" :
                    "إضافة مورد جديد - منظمة";
            }
            else
            {
                this.Text = lblFormTitle.Text = SupplierCatigory is clsParty.enPartyCategory.Person ?
                    "تعديل بيانات مورد - شخص" :
                    "تعديل بيانات مورد - منظمة";
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
                clsParty supplierType = SupplierCatigory is clsParty.enPartyCategory.Person ?
                    ctrAddEditPerson.Person :
                    (clsParty)ctrAddEditOrganization.Organization;

                if (FormMode is enMode.Add)
                {
                    _Supplier = new clsSupplier(
                        supplierType,
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
                    string errorMessages = string.Join(Environment.NewLine, validationResult.ConvertObjectErrorsListToStringList());
                    clsFormMessages.ShowError(errorMessages, "فشل الحفظ");
                }
            }
        }

    }
}

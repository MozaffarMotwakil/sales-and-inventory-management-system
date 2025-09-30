using System;
using System.Windows.Forms;
using BusinessLogic.Parties;
using BusinessLogic.Validation;
using BusinessLogic.Suppliers;
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

        public frmAddEditSupplier(clsSupplier supplier, clsParty.enPartyCategory supplierType)
        {
            InitializeComponent();
            _Supplier = supplier;
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

            if (FormMode is enMode.Edit)
            {
                if (_Supplier is null)
                {
                    this.Close();
                    clsFormMessages.ShowError("لم يتم العثور على المورد");
                    return;
                }

                switch (_SupplierCatigory)
                {
                    case clsParty.enPartyCategory.Person:
                        ctrAddEditPerson.Person = _Supplier.PartyInfo as clsPerson;
                        break;
                    case clsParty.enPartyCategory.Organization:
                        ctrAddEditOrganization.Organization = _Supplier.PartyInfo as clsOrganization;
                        break;
                }

                txtNotes.Text = _Supplier.Notes;
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
                    _Supplier.PartyInfo.PartyName = supplierType.PartyName;
                    _Supplier.PartyInfo.CountryInfo.CountryID = supplierType.CountryInfo.CountryID;
                    _Supplier.PartyInfo.CountryInfo.CountryName = supplierType.CountryInfo.CountryName;
                    _Supplier.PartyInfo.Phone = supplierType.Phone;
                    _Supplier.PartyInfo.Email = supplierType.Email;
                    _Supplier.PartyInfo.Address = supplierType.Address;

                    switch (SupplierCatigory)
                    {
                        case clsParty.enPartyCategory.Person:
                            ((clsPerson)_Supplier.PartyInfo).NationalNa = ((clsPerson)supplierType).NationalNa;
                            ((clsPerson)_Supplier.PartyInfo).BirthDate = ((clsPerson)supplierType).BirthDate;
                            ((clsPerson)_Supplier.PartyInfo).Gender = ((clsPerson)supplierType).Gender;
                            ((clsPerson)_Supplier.PartyInfo).ImagePath = ((clsPerson)supplierType).ImagePath;
                            break;
                        case clsParty.enPartyCategory.Organization:
                            clsPerson newContactPersonInfo = ((clsOrganization)supplierType).ContactPersonInfo;

                            if (newContactPersonInfo != null)
                            {
                                ((clsOrganization)_Supplier.PartyInfo).ChangeContactPersonInfo(newContactPersonInfo);
                            }
                            else
                            {
                                ((clsOrganization)_Supplier.PartyInfo).RemoveContactPerson();
                            }

                            break;
                    }

                    _Supplier.Notes = txtNotes.Text;
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

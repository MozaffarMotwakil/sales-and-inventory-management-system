using System;
using System.Windows.Forms;
using BusinessLogic.Parties;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Parties;
using SIMS.WinForms.Parties.Person;

namespace SIMS.WinForms.Parties.Organization
{
    public partial class ctrAddEditOrganization : UserControl
    {
        private clsPerson _ContactPerson;

        public clsOrganization Organization
        {
            get
            {
                return new clsOrganization(
                    ctrAddEditParty.PartyName,
                    ctrAddEditParty.CountryID,
                    ctrAddEditParty.Phone,
                    ctrAddEditParty.Email,
                    ctrAddEditParty.Address,
                    _ContactPerson
                    );
            }
            set
            {
                if (value is null)
                {
                    return;
                }

                ctrAddEditParty.PartyName = value.PartyName;
                ctrAddEditParty.CountryID = value.CountryInfo.CountryID;
                ctrAddEditParty.Phone = value.Phone;
                ctrAddEditParty.Email = value.Email;
                ctrAddEditParty.Address = value.Address;
                _ContactPerson = value.ContactPersonInfo;
                txtContactPerson.Text = value.ContactPersonInfo?.PartyName;
                
                if (value.ContactPersonInfo != null)
                {
                    llAddContactPerson.Text = "تعديل بيانات جهة التواصل داخل المنظمة";
                }
            }
        }

        public ctrAddEditOrganization()
        {
            InitializeComponent();
            _ContactPerson = null;
        }

        private void llAddContactPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson addEditContactPerson;

            if (_ContactPerson is null)
            {
                addEditContactPerson = new frmAddEditPerson(enMode.Add, clsParty.enPartyType.ContactPerson);
            }
            else
            {
                addEditContactPerson = new frmAddEditPerson(_ContactPerson, enMode.Edit, clsParty.enPartyType.ContactPerson);
            }

            addEditContactPerson.PersonSaved += AddEditContactPerson_PersonSaved; ;
            addEditContactPerson.ShowDialog();
        }

        private void AddEditContactPerson_PersonSaved(object sender, clsPerson savedPerson)
        {
            _ContactPerson = savedPerson;
            txtContactPerson.Text = _ContactPerson.PartyName;
            llAddContactPerson.Text = "تعديل بيانات جهة التواصل داخل المنظمة";
        }

        private void btnDeleteContactPerson_Click(object sender, EventArgs e)
        {
            if (_ContactPerson != null)
            {
                if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد حذف جهة التواصل داخل هذه المنظمة ؟", messageBoxIcon: MessageBoxIcon.Warning))
                {
                    _ContactPerson = null;
                    txtContactPerson.Text = string.Empty;
                    llAddContactPerson.Text = "إضافة جهة تواصل داخل المنظمة";
                }
            }
            else
            {
                clsFormMessages.ShowError("ليس هناك جهة تواصل داخل هذه المنظمة لحذفها");
            }
        }

        public void AttachErrorProvider(ErrorProvider errorProvider)
        {
            this.errorProvider = errorProvider;
            ctrAddEditParty.AttachErrorProvider(errorProvider);
        }

    }
}

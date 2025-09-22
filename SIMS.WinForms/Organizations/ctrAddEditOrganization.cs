using System;
using System.Windows.Forms;
using BusinessLogic;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Parties;
using SIMS.WinForms.People;

namespace SIMS.WinForms.Organizations
{
    public partial class ctrAddEditOrganization : UserControl
    {
        private clsPerson _ContactPerson;
        public clsPerson ContactPerson 
        {
            get
            {
                return _ContactPerson;
            }
            set
            {
                if (value is null)
                {
                    return;
                }

                _ContactPerson = value;
                txtContactPerson.Text = value.PartyName;
                llAddContactPerson.Text = "تعديل بيانات جهة التواصل داخل المنظمة";
            }
        }

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
                    ContactPerson
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
                ContactPerson = value.ContactPerson;
            }
        }

        public ctrAddEditOrganization()
        {
            InitializeComponent();
        }

        private void llAddContactPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson addEditContactPerson;

            if (ContactPerson is null)
            {
                addEditContactPerson = new frmAddEditPerson(enMode.Add, clsParty.enPartyType.ContactPerson);
            }
            else
            {
                addEditContactPerson = new frmAddEditPerson(ContactPerson, enMode.Edit, clsParty.enPartyType.ContactPerson);
            }

            addEditContactPerson.SaveSuccess += AddEditContactPerson_SaveSuccess;
            addEditContactPerson.ShowDialog();
        }

        private void AddEditContactPerson_SaveSuccess(clsPerson contactPerson)
        {
            ContactPerson = contactPerson;
        }

        private void btnDeleteContactPerson_Click(object sender, EventArgs e)
        {
            if (ContactPerson != null)
            {
                if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد حذف جهة التواصل داخل هذه المنظمة ؟", messageBoxIcon: MessageBoxIcon.Warning))
                {
                    ContactPerson = null;
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

using System;
using System.Windows.Forms;
using DVLD.WinForms.Utils;
using BusinessLogic.Parties;

namespace SIMS.WinForms.Parties.Person
{
    public partial class ctrAddEditPerson : UserControl
    {
        public clsParty.enPartyType PersonType
        {
            get
            {
                return ctrAddEditParty.PartyType;
            }
            set
            {
                ctrAddEditParty.PartyType = value;
            }
        }

        public clsPerson Person
        { 
            get
            {
                return new clsPerson(
                ctrAddEditParty.PartyName,
                ctrAddEditParty.CountryID,
                ctrAddEditParty.Phone,
                ctrAddEditParty.Email,
                ctrAddEditParty.Address,
                txtNationalNa.Text,
                dtpBirthDate.Value,
                rbMale.Checked ? clsPerson.enGender.Male : clsPerson.enGender.Female,
                ctrPersonImage.ImageLocation
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
                txtNationalNa.Text = value.NationalNa;
                dtpBirthDate.Value = value.BirthDate;
                rbMale.Checked = value.Gender is clsPerson.enGender.Male;
                rbFemale.Checked = value.Gender is clsPerson.enGender.Female;
                ctrPersonImage.ImageLocation = value.ImagePath;
            }
        }

        public ctrAddEditPerson()
        {
            InitializeComponent();
        }

        private void ctrAddEditPerson_Load(object sender, EventArgs e)
        {
            dtpBirthDate.MinDate = DateTime.Today.AddYears(-100);
            dtpBirthDate.MaxDate = DateTime.Today;
        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ctrPersonImage.ImageLocation))
            {
                return;
            }

            ctrPersonImage.DefaultImage = clsFormHelper.GetDefaultPersonImage(
                rbMale.Checked ?
                clsPerson.enGender.Male :
                clsPerson.enGender.Female
                );
        }

        public void AttachErrorProvider(ErrorProvider errorProvider)
        {
            this.errorProvider = errorProvider;
            ctrAddEditParty.AttachErrorProvider(errorProvider);
        }

    }
}

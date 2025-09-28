using System;
using System.ComponentModel;
using System.Windows.Forms;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;
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
                    pbPersonImage.ImageLocation
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

                if (!string.IsNullOrEmpty(value.ImagePath))
                {
                    pbPersonImage.ImageLocation = value.ImagePath;
                    llDeletePersonImage.Visible = true;
                }
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

        private void txtNationalNa_Validating(object sender, CancelEventArgs e)
        {

        }

        private void llSetPersonImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialogSetNewImage = new OpenFileDialog();
            fileDialogSetNewImage.Title = "Set Image";
            fileDialogSetNewImage.InitialDirectory = @"C:\";
            fileDialogSetNewImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|.jpg|*.jpg|.png|*.png";
            fileDialogSetNewImage.DefaultExt = "JPG";
            fileDialogSetNewImage.FilterIndex = 1;

            if (fileDialogSetNewImage.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = fileDialogSetNewImage.FileName;
                llDeletePersonImage.Visible = true;
            }
        }

        private void llDeletePersonImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد حذف الصورة ؟", messageBoxIcon: MessageBoxIcon.Warning))
            {
                pbPersonImage.ImageLocation = string.Empty;
                pbPersonImage.Image = rbMale.Checked ? Resources.unknow_male : Resources.unknow_female;
                llDeletePersonImage.Visible = false;
            }
        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                return;
            }

            pbPersonImage.Image = clsFormHelper.GetDefaultPersonImage(
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

using System;
using System.Windows.Forms;
using BusinessLogic;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.People
{
    public partial class ctrPersonInfo : UserControl
    {
        public clsParty.enPartyType PersonType
        {
            get
            {
                return ctrPartyInfo.PartyType;
            }
            set
            {
                ctrPartyInfo.PartyType = value;
            }
        }

        private clsPerson _Person;
        public clsPerson Person
        {
            get
            {
                return _Person;
            }
            set
            {
                if (value is null)
                {
                    return;
                }

                _Person = value;
                ctrPartyInfo.Party = _Person;
                pbPersonImage.Image = _Person.Gender is clsPerson.enGender.Male ?
                    Resources.unknow_male :
                    Resources.unknow_female;
                pbPersonImage.ImageLocation = _Person.CurrentImagePath;
                lblNationalNa.Text = string.IsNullOrEmpty(_Person.NationalNa) ? "N/A" : _Person.NationalNa;
                lblBirthData.Text = _Person.BirthDate.ToString("dd/MM/yyyy");
                lblGender.Text = _Person.Gender is clsPerson.enGender.Male ?
                    "ذكر" :
                    "أنثى";
            }
        }

        public ctrPersonInfo()
        {
            InitializeComponent();
            _Person = null;
        }

    }
}

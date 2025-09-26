using System;
using System.Windows.Forms;
using BusinessLogic;

namespace SIMS.WinForms.Parties
{
    public partial class ctrPartyInfo : UserControl
    {
        public ctrPartyInfo()
        {
            InitializeComponent();
        }

        private clsParty.enPartyCategory _PartyCategory;
        public clsParty.enPartyCategory PartyCategory
        {
            get
            {
                return _PartyCategory;
            }
            set
            {
                _PartyCategory = value;

                switch (_PartyCategory)
                {
                    case clsParty.enPartyCategory.Person:
                        lblCountryTitle.Text = "الجنسية";
                        break;
                    case clsParty.enPartyCategory.Organization:
                        lblCountryTitle.Text = "البلد";
                        break;
                }

                lblCountryTitle.Text += ':';
            }
        }

        private clsParty.enPartyType _PartyType;
        public clsParty.enPartyType PartyType
        {
            get
            {
                return _PartyType;
            }
            set
            {
                _PartyType = value;

                switch (_PartyType)
                {
                    case clsParty.enPartyType.Employee:
                        lblPartyTypeTitle.Text = "إسم الموظف";
                        break;
                    case clsParty.enPartyType.Customer:
                        lblPartyTypeTitle.Text = "إسم العميل";
                        break;
                    case clsParty.enPartyType.Supplier:
                        lblPartyTypeTitle.Text = "إسم المورد";
                        break;
                    case clsParty.enPartyType.ContactPerson:
                        lblPartyTypeTitle.Text = "إسم جهة التواصل";
                        break;
                    default:
                        lblPartyTypeTitle.Text = "إسم الكيان";
                        break;
                }

                lblPartyTypeTitle.Text += ':';
            }
        }
        
        public clsParty Party
        {
            set
            {
                if (value is null)
                {
                    return;
                }

                lblPartyName.Text = value.PartyName;
                lblCountry.Text = value.CountryInfo.CountryName;
                lblPhoneNumber.Text = value.Phone;
                lblEmail.Text = string.IsNullOrEmpty(value.Email) ? "N/A" : value.Email;
                lblAddress.Text = string.IsNullOrEmpty(value.Address) ? "N/A" : value.Address;
            }
        }
    }
}

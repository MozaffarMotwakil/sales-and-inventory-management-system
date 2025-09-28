using System;
using System.Windows.Forms;
using BusinessLogic.Parties;
using SIMS.WinForms.Parties.Person;

namespace SIMS.WinForms.Parties.Organization
{
    public partial class ctrOrganizationInfo : UserControl
    {
        public ctrOrganizationInfo()
        {
            InitializeComponent();
        }

        public clsParty.enPartyType OrganizationType
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

        private clsOrganization _Organization;

        public clsOrganization Organization
        {
            get
            {
                return _Organization;
            }
            set
            {
                if (value is null)
                {
                    return;
                }

                _Organization = value;
                ctrPartyInfo.Party = _Organization;
                llContactPerson.Text = _Organization.ContactPersonInfo?.PartyName ?? "N/A";
            }
        }

        private void llContactPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Organization?.ContactPersonInfo is null)
            {
                return;
            }

            frmShowPersonInfo personInfo = new frmShowPersonInfo(Organization.ContactPersonInfo, clsParty.enPartyType.ContactPerson);
            personInfo.ShowDialog();
        }

    }
}

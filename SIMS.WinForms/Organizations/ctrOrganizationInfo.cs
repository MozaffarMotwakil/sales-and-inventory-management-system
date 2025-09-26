using System;
using System.Windows.Forms;
using BusinessLogic;
using SIMS.WinForms.People;

namespace SIMS.WinForms.Organizations
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
                llContactPerson.Text = _Organization.ContactPerson?.PartyName ?? "N/A";
            }
        }

        private void llContactPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Organization?.ContactPerson is null)
            {
                return;
            }

            frmShowPersonInfo personInfo = new frmShowPersonInfo(Organization.ContactPerson, clsParty.enPartyType.ContactPerson);
            personInfo.ShowDialog();
        }

    }
}

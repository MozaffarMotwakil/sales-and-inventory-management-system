using System;
using System.Windows.Forms;
using BusinessLogic;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.People
{
    public partial class frmShowPersonInfo : Form
    {
        private clsPerson _Person;
        private clsParty.enPartyType _PersonType;

        public frmShowPersonInfo(clsPerson person, clsParty.enPartyType personType)
        {
            InitializeComponent();
            _Person = person;
            _PersonType = personType;
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            if (_Person is null)
            {
                this.Close();
                clsFormMessages.ShowError("لم يتم العثور على الشخص");
                return;
            }

            ctrPersonInfo.Person = _Person;
            ctrPersonInfo.PersonType = _PersonType;
        }
    }
}
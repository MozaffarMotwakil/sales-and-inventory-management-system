using System;
using System.Windows.Forms;
using BusinessLogic;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Parties
{
    public partial class ctrAddEditParty : UserControl
    {
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
                    case clsParty.enPartyType.Supplier:
                        lblPartyTypeName.Text = "إسم المورد";
                        break;
                    default:
                        lblPartyTypeName.Text = "إسم الكيان";
                        break;
                }
            }
        }

        public string PartyName 
        {
            get
            {
                return txtPartyName.Text;
            }
            set
            {
                txtPartyName.Text = value;
            }
        }

        public byte CountryID
        {
            get
            { 
                return (byte)cbCountry.SelectedIndex; 
            }
            set
            {
                cbCountry.SelectedIndex = value;
            }
        }

        public string Phone 
        {
            get 
            {
                return txtPhone.Text;
            }
            set
            {
                txtPhone.Text = value;
            }
        }
        
        public string Email 
        {
            get 
            {
                return txtEmail.Text; 
            }
            set
            {
                txtEmail.Text = value;
            }
        }

        public string Address {
            get
            {
                return txtAddress.Text; 
            }
            set
            {
                txtAddress.Text = value;
            }
        }

        public ctrAddEditParty()
        {
            InitializeComponent();
        }

        private void ctrAddEditParty_Load(object sender, EventArgs e)
        {
            cbCountry.SelectedIndex = 165;
        }

        private void txtPartyName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtPartyName, "لا يمكن أن يكون الإسم فارغا", errorProvider);
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtPhone, "لا يمكن أن يكون رقم الهاتف فارغا", errorProvider);

            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                if (txtPhone.TextLength != 10)
                {
                    errorProvider.SetError(txtPhone, "رقم الهاتف يجب أن يتكون من 10 أرقام");
                }
                else
                {
                    errorProvider.SetError(txtPhone, string.Empty);
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsFormValidation.HandleNumericKeyPress(e, txtPhone, errorProvider);
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !clsValidator.IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "تنسيق البريد الإلكتروني غير صحيح");
            }
            else
            {
                errorProvider.SetError(txtEmail, string.Empty);
            }
        }

        public void AttachErrorProvider(ErrorProvider errorProvider)
        {
            this.errorProvider = errorProvider;
        }

    }
}

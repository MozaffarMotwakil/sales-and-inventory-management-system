using System.Media;
using System.Windows.Forms;

namespace DVLD.WinForms.Utils
{
    public static class clsFormValidation
    {
        public static void HandleNumericKeyPress(KeyPressEventArgs e, Control targetControl, ErrorProvider errorProvider,
            string errorMessage = "لا يمكن إدخال حروف أو رموز خاصة, يمكن فقط إدخال أرقام.")
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play(); 
                errorProvider.SetError(targetControl, errorMessage); 
            }
            else
            {
                errorProvider.SetError(targetControl, string.Empty);
            }
        }

        public static bool IsDataValid(UserControl userControl, ErrorProvider errorProvider)
        {
            userControl.ValidateChildren();

            foreach (Control control in userControl.Controls)
            {
                if (errorProvider.GetError(control) != string.Empty)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsDataValid(Form form, Control.ControlCollection collection, ErrorProvider errorProvider)
        {
            form.ValidateChildren();

            foreach (Control control in collection)
            {
                if (errorProvider.GetError(control) != string.Empty)
                {
                    return false;
                }
            }

            return true;
        }

        public static void ValidatingRequiredField(Control control, string ErrorMessage, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider.SetError(control, ErrorMessage);
            }
            else
            {
                errorProvider.SetError(control, string.Empty);
            }
        }

    }
}

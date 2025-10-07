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

        public static void HandleFloatingKeyPress(KeyPressEventArgs e, Control targetControl, ErrorProvider errorProvider,
            string errorMessage = "لا يمكن إدخال حروف أو رموز خاصة, يمكن فقط إدخال أرقام و فاصلة عشرية")
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
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

        public static bool IsDataValid(Control control, ErrorProvider errorProvider)
        {
            if (control is ContainerControl container)
            {
                container.ValidateChildren(ValidationConstraints.None);
            }

            return !IsControlsHasError(control, errorProvider);
        }

        private static bool IsControlsHasError(Control control, ErrorProvider errorProvider)
        {
            foreach (Control ctr in control.Controls)
            {
                if (errorProvider.GetError(ctr) != string.Empty)
                {
                    return true;
                }

                if (ctr.HasChildren)
                {
                    if (IsControlsHasError(ctr, errorProvider))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void ValidatingRequiredField(Control control, ErrorProvider errorProvider, string ErrorMessage = "لا يمكن أن يكون هذا الحقل فارغا")
        {
            if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(control, ErrorMessage);
            }
            else if (control is ComboBox comboBox && (comboBox.SelectedIndex == -1 || comboBox.SelectedItem is null))
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

using System.Windows.Forms;

namespace DVLD.WinForms.Utils
{
    public static class clsFormMessages
    {
        public static void ShowInvalidDataError()
        {
            ShowError("هناك بعض الحقول تحتوي على بيانات غير صحيحة, الرجاء إدخال البيانات الصحيحة في جميع الحقول أولا");
        }

        public static void ShowNotImplementedFeatureWarning()
        {
            ShowWarning("لم يتم تنفيذ هذه الميزة بعد, سوف يتم إضافتها قريبا", "ميزة غير متوفرة");
        }

        public static void ShowSuccess(string message, string title = "نجاح")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string message, string title = "خطأ")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public static void ShowWarning(string message, string title = "تحذير")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Confirm(string message, string title = "تأكيد", MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question, 
            MessageBoxDefaultButton messageBoxDefaultButton = MessageBoxDefaultButton.Button1)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, messageBoxIcon, messageBoxDefaultButton) == DialogResult.Yes;
        }
        
    }
}

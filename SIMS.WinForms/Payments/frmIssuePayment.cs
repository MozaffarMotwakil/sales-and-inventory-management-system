using System;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Payments;
using BusinessLogic.Validation;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;

namespace SIMS.WinForms.Payments
{
    public partial class frmIssuePayment : Form
    {
        private clsInvoice _Invoice;

        public frmIssuePayment(clsInvoice invoice)
        {
            InitializeComponent();
            _Invoice = invoice;
        }

        private void frmIssuePayment_Load(object sender, EventArgs e)
        {
            if (_Invoice == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على الفاتورة");
                this.Close();
                return;
            }

            llInvoiceNo.Text = _Invoice.InvoiceNo;
            lblRemainingAmount.Text = _Invoice.RemainingAmount.ToString();

            dtpPaymentDate.MaxDate = DateTime.Today;
            dtpPaymentDate.MinDate = DateTime.Today.AddYears(-1);
            dtpPaymentDate.Value = DateTime.Today;
        }

        private void llInvoiceNo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInvoiceInfo invoiceInfo = new frmShowInvoiceInfo(_Invoice);
            invoiceInfo.ShowDialog();
        }

        private void txtPaymentAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaymentAmount.Text))
            {
                errorProvider.SetError(txtPaymentAmount, "لا يمكن أن يكون حقل قيمة المدفوع فارغاً");
            }
            else if (!decimal.TryParse(txtPaymentAmount.Text, out decimal sellingPrice))
            {
                errorProvider.SetError(txtPaymentAmount, "يجب إدخال قيمة رقمية صحيحة أو عشرية لقيمة المدفوع");
            }
            else if (sellingPrice < 1)
            {
                errorProvider.SetError(txtPaymentAmount, "يجب أن يكون قيمة المدفوع أكبر من صفر");
            }
            else
            {
                errorProvider.SetError(txtPaymentAmount, string.Empty);
            }
        }

        private void txtPaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsFormValidation.HandleFloatingKeyPress(e, txtPaymentAmount, errorProvider);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsFormValidation.IsDataValid(this, errorProvider))
            {
                clsFormMessages.ShowInvalidDataError();
                return;
            }

            if (!clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                return;
            }

            clsPayment payment = new clsPayment(
                _Invoice,
                Convert.ToDecimal(txtPaymentAmount.Text), 
                rbCash.Checked ? enPaymentMethod.Cash : enPaymentMethod.BankTransfer, 
                dtpPaymentDate.Value
                );

            clsValidationResult validationResult = payment.IssuePayment();

            if (validationResult.IsValid)
            {
                clsFormMessages.ShowSuccess("تم إصدار المدفوع بنجاح");
                this.Close();
            }
            else
            {
                clsFormMessages.ShowValidationErrors(validationResult);
            }
        }

    }
}

using System;
using System.Windows.Forms;
using BusinessLogic.Suppliers;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Suppliers;

namespace SIMS.WinForms.Inventory
{
    public partial class frmAddEditProduct : Form
    {
        public enMode FormMode;

        public frmAddEditProduct()
        {
            InitializeComponent();
            FormMode = enMode.Add;
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            this.Text = FormMode == enMode.Add ? "إضافة منتج جديد" : "تعديل منتج";
            cbMainSupllier.Items.AddRange(clsSupplier.GetAllSupplierNames());
        }

        private void cbCatigory_Enter(object sender, EventArgs e)
        {
            if (cbCatigory.SelectedIndex == -1)
            {
                cbCatigory.Text = string.Empty;
            }
        }

        private void cbCatigory_Leave(object sender, EventArgs e)
        {
            if (cbCatigory.SelectedIndex == -1)
            {
                cbCatigory.Text = "إختار التصنيف/الفئة";
            }
        }

        private void cbUnit_Enter(object sender, EventArgs e)
        {
            if (cbUnit.SelectedIndex == -1)
            {
                cbUnit.Text = string.Empty;
            }
        }

        private void cbUnit_Leave(object sender, EventArgs e)
        {
            if (cbUnit.SelectedIndex == -1)
            {
                cbUnit.Text = "إختار وحدة القياس";
            }
        }

        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductBarcode.Text))
            {
                // ينقل لاحقا إلى طبقة الأعمال
                txtProductBarcode.Text = "INV-" + Guid.NewGuid();
            }
            else
            {
                clsFormMessages.ShowError("يجب أن يكون حقل الباركود فارغا لتوليد باركود جديد");
            }
        }

        private void llAddPersonSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addEditPersonSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Person);
            addEditPersonSupplier.ShowDialog();
        }

        private void llAddOrganizationSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addEditOrganizationSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Organization);
            addEditOrganizationSupplier.ShowDialog();
        }

        private void llAddOtherUnits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProductUnitConversions unitConversions = new frmProductUnitConversions(txtProductName.Text, cbUnit.Text);
            unitConversions.ShowDialog();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
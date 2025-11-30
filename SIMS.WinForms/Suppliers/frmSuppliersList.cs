using System;
using System.Windows.Forms;
using BusinessLogic.Suppliers;
using BusinessLogic.Parties;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmSuppliersList : BaseSuppliersForm
    {
        public frmSuppliersList()
        {
            InitializeComponent();
            frmMainForm.CreateInstance().lblCurrentFormName.Text = this.Text;
        }

        private void frmSuppliersList_Load(object sender, EventArgs e)
        {
            cbSupplierCategory.SelectedIndex = 0;
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.SearchHintMessage = "أدخل إسم المورد أو العنوان";
            base.EntityName = "المورد";
            base.EntityInfoControl = ctrSupplierInfo;
        }
        
        protected override void SearchTextChanged(object sender, EventArgs e)
        {
            base.SearchTextChanged(sender, e);

            if (cbSupplierCategory.SelectedIndex == 0)
            {
                Filter = $"PartyName LIKE '%{txtSearch.Text}%' OR Address LIKE '%{txtSearch.Text}%'";
            }
            else
            {
                string category = cbSupplierCategory.SelectedIndex == 1 ? "شخص" : "منظمة";
                Filter = $"(PartyName LIKE '%{txtSearch.Text}%' OR Address LIKE '%{txtSearch.Text}%') AND CategoryName = '{category}'";
            }
        }

        private void cbSupplierCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;

            if (cbSupplierCategory.SelectedIndex == 1)
            {
                Filter = "CategoryName = 'شخص'";
            }
            else if (cbSupplierCategory.SelectedIndex == 2)
            {
                Filter = "CategoryName = 'منظمة'";
            }
            else
            {
                Filter = string.Empty;
            }

            base.ApplySearchFilter();
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier addPersonSupplier = new frmAddEditSupplier(clsParty.enPartyCategory.Person);
            addPersonSupplier.ShowDialog();
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier addOrganizationSupplier = new frmAddEditSupplier(clsParty.enPartyCategory.Organization);
            addOrganizationSupplier.ShowDialog();
        }

        protected override Form CreateEditForm(clsSupplier supplier)
        {
            return new frmAddEditSupplier(supplier, supplier.PartyInfo.PartyCategory);
        }

        protected override void HandleEntityInfoDisplay(clsSupplier supplier)
        {
            ctrSupplierInfo.Supplier = supplier;
        }

    }
}

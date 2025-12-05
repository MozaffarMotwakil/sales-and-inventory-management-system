using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Parties;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmSuppliersList : BaseSuppliersForm
    {
        protected override Form EditEntityForm => new frmAddEditSupplier(SelectedEntity, SelectedEntity.PartyInfo.PartyCategory);

        public frmSuppliersList()
        {
            InitializeComponent();
        }

        private void frmSuppliersList_Load(object sender, EventArgs e)
        {
            cbSupplierCategory.SelectedIndex = 0;
            cbSupplierActivity.SelectedIndex = 0;
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.EntityName = "المورد";
            IsEntitySupportActivityStatus = true;
            base.EntityInfoControl = ctrSupplierInfo;
        }

        private void cbSupplierCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            ApplySearchFilter();
        }

        private void cbSupplierActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            ApplySearchFilter();
        }

        protected override void ApplySearchFilter()
        {
            List<string> filters = new List<string>();

            if (cbSupplierCategory.SelectedIndex == 1)
            {
                filters.Add("CategoryName = 'شخص'");
            }
            else if (cbSupplierCategory.SelectedIndex == 2)
            {
                filters.Add("CategoryName = 'منظمة'");
            }

            if (cbSupplierActivity.SelectedIndex == 1)
            {
                filters.Add("IsActive = 1");
            }
            else if (cbSupplierActivity.SelectedIndex == 2)
            {
                filters.Add("IsActive = 0");
            }

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                filters.Add($"(PartyName LIKE '%{txtSearch.Text}%' OR Address LIKE '%{txtSearch.Text}%')");
            }

            base.Filter = string.Join(" AND ", filters);
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

    }
}

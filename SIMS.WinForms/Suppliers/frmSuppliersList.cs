using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Parties;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;

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
            cbSupplierActivity.SelectedIndex = 0;
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.EntityName = "المورد";
            IsEntitySupportActivityStatus = true;
            base.EntityInfoControl = ctrSupplierInfo;
        }

        protected override bool GetEntityActivityStatus()
        {
            return GetSelectedEntity().IsActive;
        }

        protected override bool MarkRecordAsActive()
        {
            return GetSelectedEntity().MarkAsActive();
        }

        protected override bool MarkRecordAsInActive()
        {
            return GetSelectedEntity().MarkAsInActive();
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

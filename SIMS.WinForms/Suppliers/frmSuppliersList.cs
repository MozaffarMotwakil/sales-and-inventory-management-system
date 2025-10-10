using System;
using System.Windows.Forms;
using BusinessLogic.Suppliers;
using BusinessLogic.Parties;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmSuppliersList : frmGenericListBase<clsSupplierService, clsSupplier>
    {
        public frmSuppliersList()
        {
            InitializeComponent();
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

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف المورد";
                base.dgvEntitiesList.Columns[0].Width = 100;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم المورد";
                base.dgvEntitiesList.Columns[1].Width = 200;

                base.dgvEntitiesList.Columns[2].HeaderText = "نوع المورد";
                base.dgvEntitiesList.Columns[2].Width = 100;

                base.dgvEntitiesList.Columns[3].HeaderText = "الجنسية/البلد";
                base.dgvEntitiesList.Columns[3].Width = 100;

                base.dgvEntitiesList.Columns[4].HeaderText = "رقم الهاتف";
                base.dgvEntitiesList.Columns[4].Width = 100;

                base.dgvEntitiesList.Columns[5].HeaderText = "العنوان";
                base.dgvEntitiesList.Columns[5].Width = 225;

                base.dgvEntitiesList.Columns[6].HeaderText = "الملاحظات";
                base.dgvEntitiesList.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
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

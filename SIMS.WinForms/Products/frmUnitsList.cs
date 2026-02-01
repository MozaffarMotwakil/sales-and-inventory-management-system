using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SIMS.WinForms.Products
{
    public partial class frmUnitsList : BaseUnitForm
    {
        protected override Form EditEntityForm => new frmAddEditUnit(SelectedEntity);

        public frmUnitsList()
        {
            InitializeComponent();
        }

        private void addUnitToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddEditUnit addUnit = new frmAddEditUnit();
            addUnit.ShowDialog();
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.EntityName = "الوحدة";
        }

        protected override void ApplySearchFilter()
        {
            List<string> filters = new List<string>();

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                filters.Add($"UnitName LIKE '%{txtSearch.Text}%'");
            }

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }

    }
}

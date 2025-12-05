using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SIMS.WinForms.Products
{
    public partial class frmDiscountsList : BaseDiscountsForm
    {
        protected override Form EditEntityForm => new frmAddEditDiscount(SelectedEntity);

        public frmDiscountsList()
        {
            InitializeComponent();
        }

        private void frmDiscountsList_Load(object sender, EventArgs e)
        {
            cbValueType.SelectedIndex = cbActivityStatus.SelectedIndex = 0;
            cbCreatedDate.SelectedIndex = 6;
            cbCreatedDate.Text = "إختر نطاق إضافة الخصم";

            if (dgvEntitiesList.Rows.Count > 0)
            {
                dtpStartDate.Value = dgvEntitiesList
                    .Rows
                    .Cast<DataGridViewRow>()
                    .Select(row => Convert.ToDateTime(row.Cells[5].Value))
                    .Min();

                dtpEndDate.Value = dgvEntitiesList
                    .Rows
                    .Cast<DataGridViewRow>()
                    .Select(row => Convert.ToDateTime(row.Cells[6].Value))
                    .Max();
            }
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.EntityName = "الخصم";
            base.IsEntitySupportActivityStatus = true;
        }

        private void cbCreatedDate_Enter(object sender, EventArgs e)
        {
            if (cbCreatedDate.SelectedIndex == -1)
            {
                cbCreatedDate.Text = string.Empty;
            }
        }

        private void cbCreatedDate_Leave(object sender, EventArgs e)
        {
            if (cbCreatedDate.SelectedIndex == -1)
            {
                cbCreatedDate.SelectedIndex = 6;
                cbCreatedDate.Text = "إختر نطاق إضافة الخصم";
            }
        }

        private void addNewDiscountToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddEditDiscount addEditDiscount = new frmAddEditDiscount();
            addEditDiscount.ShowDialog();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();

            if (cbValueType.SelectedIndex > 0)
            {
                filters.Add($"DiscountValueType = '{cbValueType.SelectedItem}'");
            }

            if (cbActivityStatus.SelectedIndex == 1)
            {
                filters.Add("IsActive = 1");
            }
            else if (cbActivityStatus.SelectedIndex == 2)
            {
                filters.Add("IsActive = 0");
            }

            if (cbCreatedDate.SelectedIndex == 0)
            {
                filters.Add($"(CreatedDate >= #{DateTime.Now.AddDays(-1):yyyy-MM-dd}# AND CreatedDate <= #{DateTime.Now:yyyy-MM-dd}#)");
            }
            else if (cbCreatedDate.SelectedIndex == 1)
            {
                filters.Add($"(CreatedDate >= #{DateTime.Now.AddDays(-7):yyyy-MM-dd}# AND CreatedDate <= #{DateTime.Now:yyyy-MM-dd}#)");
            }
            else if (cbCreatedDate.SelectedIndex == 2)
            {
                filters.Add($"(CreatedDate >= #{DateTime.Now.AddMonths(-1):yyyy-MM-dd}# AND CreatedDate <= #{DateTime.Now:yyyy-MM-dd}#)");
            }
            else if (cbCreatedDate.SelectedIndex == 3)
            {
                filters.Add($"(CreatedDate >= #{DateTime.Now.AddMonths(-3):yyyy-MM-dd}# AND CreatedDate <= #{DateTime.Now:yyyy-MM-dd}#)");
            }
            else if (cbCreatedDate.SelectedIndex == 4)
            {
                filters.Add($"(CreatedDate >= #{DateTime.Now.AddMonths(-6):yyyy-MM-dd}# AND CreatedDate <= #{DateTime.Now:yyyy-MM-dd}#)");
            }
            else if (cbCreatedDate.SelectedIndex == 5)
            {
                filters.Add($"(CreatedDate >= #{DateTime.Now.AddYears(-1):yyyy-MM-dd}# AND CreatedDate <= #{DateTime.Now:yyyy-MM-dd}#)");
            }

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                filters.Add($"DiscountName LIKE '%{txtSearch.Text}%'");
            }

            filters.Add($"StartDate >= #{dtpStartDate.Value:yyyy/MM/dd}#");

            filters.Add($"EndDate >= #{dtpStartDate.Value:yyyy/MM/dd}#");

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }

    }
}
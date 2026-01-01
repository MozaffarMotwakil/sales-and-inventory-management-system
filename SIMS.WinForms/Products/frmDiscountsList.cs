using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Discounts;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

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
            cbValueType.SelectedIndex = 0;
            cbActivityStatus.SelectedIndex = 1;
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

            btnApplyFilter_Click(sender, e);

            contextMenuStrip.Items.Add("الربط مع منتجات");
            contextMenuStrip.Items[4].Image = Resources.link;
            contextMenuStrip.Items[4].ImageScaling = ToolStripItemImageScaling.None;
            contextMenuStrip.Items[4].Click += LinkingDiscountToProducts_Click;

            clsDiscountService.CreateInstance().EntitySaved += WhenDiscountEdited_EntitySaved;
        }

        private void WhenDiscountEdited_EntitySaved(object sender, BusinessLogic.Interfaces.EntitySavedEventArgs e)
        {
            DateTime? newEndDate = clsDiscountService.CreateInstance().Find(e.EntityID)?.EndDate;

            if (e.OperationMode == BusinessLogic.enMode.Update && newEndDate.HasValue && newEndDate >= _GetMaximumEndDateInDGV())
            {
                dtpEndDate.Value = newEndDate.Value;
                base.Filter = _GetAppliedFilters();
                base.ApplySearchFilter();
            }
        }

        private DateTime _GetMaximumEndDateInDGV()
        {
            return dgvEntitiesList
                .Rows
                .Cast<DataGridViewRow>()
                .Max(discountRow => Convert.ToDateTime(discountRow.Cells["EndDate"].Value));
        }

        private void LinkingDiscountToProducts_Click(object sender, EventArgs e)
        {
            if (!SelectedEntity.IsValid)
            {
                clsFormMessages.ShowError("عذرا, لا يمكن ربط منتجات مع هذا الخصم لأنه غير ساري");
                return;
            }

            if (!SelectedEntity.IsActive)
            {
                clsFormMessages.ShowError("عذرا, لا يمكن ربط منتجات مع هذا الخصم لأنه غير نشط");
                return;
            }

            frmLinkingDiscountToProducts linkingDiscountToProducts = new frmLinkingDiscountToProducts(SelectedEntity);
            linkingDiscountToProducts.ShowDialog();
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
            base.Filter = _GetAppliedFilters();
            base.ApplySearchFilter();
        }

        private string _GetAppliedFilters()
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

            filters.Add($"EndDate <= #{dtpEndDate.Value:yyyy/MM/dd}#");

            return string.Join(" AND ", filters);
        }

    }
}
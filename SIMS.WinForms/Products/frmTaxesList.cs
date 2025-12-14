using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Products
{
    public partial class frmTaxesList : BaseTaxesForm
    {
        protected override Form EditEntityForm => new frmAddEditTax(SelectedEntity);

        public frmTaxesList()
        {
            InitializeComponent();
        }

        private void frmTaxesList_Load(object sender, EventArgs e)
        {
            cbActivityStatus.SelectedIndex = 1;
            cbCreatedDate.SelectedIndex = 6;
            cbCreatedDate.Text = "إختر نطاق إضافة الضريبة";

            contextMenuStrip.Items.Add("الربط مع منتجات");
            contextMenuStrip.Items[4].Image = Resources.link;
            contextMenuStrip.Items[4].ImageScaling = ToolStripItemImageScaling.None;
            contextMenuStrip.Items[4].Click += LinkingTaxToProducts_Click;
        }

        private void LinkingTaxToProducts_Click(object sender, EventArgs e)
        {
            if (!SelectedEntity.IsActive)
            {
                clsFormMessages.ShowError("عذرا, لا يمكن ربط منتجات مع هذه الضريبة لأنها غير نشطة");
                return;
            }

            frmLinkingTaxToProducts linkingTaxToProducts = new frmLinkingTaxToProducts(SelectedEntity);
            linkingTaxToProducts.ShowDialog();
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.EntityName = "الضريبة";
            base.IsEntitySupportActivityStatus = true;
        }

        private void cbActivityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void cbCreatedDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        protected override void ApplySearchFilter()
        {
            Filter = _GetFilter();
            base.ApplySearchFilter();
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
                cbCreatedDate.Text = "إختر نطاق إضافة الضريبة";
            }
        }

        private void addNewTaxToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddEditTax addEditTax = new frmAddEditTax();
            addEditTax.ShowDialog();
        }

        private string _GetFilter()
        {
            List<string> filters = new List<string>();

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
                filters.Add($"TaxName LIKE '%{txtSearch.Text}%'");
            }

            return string.Join(" AND ", filters);
        }

    }
}

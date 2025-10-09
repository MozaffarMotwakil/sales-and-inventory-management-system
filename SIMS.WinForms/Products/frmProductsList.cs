using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Products;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Products
{
    public partial class frmProductsList : Form
    {
        public frmProductsList()
        {
            InitializeComponent();
            clsProduct.ProductSaved += ClsProduct_ProductSaved;
            clsProduct.ProductDeleted += ClsProduct_ProductDeleted;
        }

        private void ClsProduct_ProductDeleted(object sender, clsProduct.ProductDeletedEventArgs e)
        {
            txtSearch.Text = string.Empty;
            lblTotalInventoryItems.Text = clsFormHelper.RefreshDataGridView(
                dgvProductsList,
                clsProduct.GetAllProducts()
                ).ToString();
        }

        private void ClsProduct_ProductSaved(object sender, clsProduct.ProductSavedEventArgs e)
        {
            txtSearch.Text = string.Empty;
            lblTotalInventoryItems.Text = clsFormHelper.RefreshDataGridView(
                dgvProductsList,
                clsProduct.GetAllProducts()
                ).ToString();
        }

        private void frmProductsList_Load(object sender, EventArgs e)
        {
            lblSearchHintText.Text = "أدخل إسم المنتج أو الباركود الخاص بالمنتج";
            lblTotalInventoryItems.Text = clsFormHelper.RefreshDataGridView(
                dgvProductsList,
                clsProduct.GetAllProducts()
                ).ToString();
            _ResetDGV();
            cbCategory.SelectedIndex = 0;
            cbCategory.Items.AddRange(clsCategory.GetCategoryNames());
        }

        private void frmProductsList_Shown(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void _ResetDGV()
        {
            dgvProductsList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);

            if (dgvProductsList.RowCount > 0)
            {
                dgvProductsList.Columns[0].HeaderText = "معرف المنتج";
                dgvProductsList.Columns[0].Width = 95;

                dgvProductsList.Columns[1].HeaderText = "إسم المنتج";
                dgvProductsList.Columns[1].Width = 200;

                dgvProductsList.Columns[2].HeaderText = "الباركود";
                dgvProductsList.Columns[2].Width = 150;

                dgvProductsList.Columns[3].HeaderText = "التصنيف/الفئة";
                dgvProductsList.Columns[3].Width = 150;

                dgvProductsList.Columns[4].HeaderText = "الوحدة الأساسية";
                dgvProductsList.Columns[4].Width = 100;

                dgvProductsList.Columns[5].HeaderText = "الوحدات البديلة";
                dgvProductsList.Columns[5].Width = 100;

                dgvProductsList.Columns[6].HeaderText = "سعر البيع";
                dgvProductsList.Columns[6].Width = 80;

                dgvProductsList.Columns[7].HeaderText = "المورد الرئيسي";
                dgvProductsList.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                foreach (DataGridViewColumn column in dgvProductsList.Columns)
                {
                    if (column.Index != 0)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);

            DataView producsList = (dgvProductsList.DataSource as DataTable).DefaultView;

            try
            {
                if (cbCategory.SelectedIndex == 0)
                {
                    producsList.RowFilter = $"ProductName LIKE '%{txtSearch.Text}%' OR Barcode LIKE '%{txtSearch.Text}%'";
                }
                else
                {
                    producsList.RowFilter = $"(ProductName LIKE '%{txtSearch.Text}%' OR Barcode LIKE '%{txtSearch.Text}%') AND CategoryName = '{cbCategory.SelectedItem}'";
                }
            }
            catch (Exception) { } // في حال رمي إستثناء بسبب إدخال رموز غير صالحة فلا حاجة لعرض رسالة خطأ أو إيقاف تجربة المستخدم

            lblTotalInventoryItems.Text = producsList.Count.ToString();
        }

        private void cbCatigory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            DataView producsList = (dgvProductsList.DataSource as DataTable).DefaultView;

            try
            {
                if (cbCategory.SelectedIndex == 0)
                {
                    producsList.RowFilter = string.Empty;
                }
                else
                {
                    producsList.RowFilter = $"CategoryName LIKE '%{cbCategory.Text}%'";
                }
            }
            catch (Exception) { } // في حال رمي إستثناء بسبب إدخال رموز غير صالحة فلا حاجة لعرض رسالة خطأ أو إيقاف تجربة المستخدم

            lblTotalInventoryItems.Text = producsList.Count.ToString();
        }

        private void cbCatigory_Leave(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == -1)
            {
                cbCategory.SelectedIndex = 0;
            }
        }

        private void pictureBoxAndSearchHintText_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void addProducrToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddEditProduct addProduct = new frmAddEditProduct();
            addProduct.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsProduct product = clsProduct.Find(clsFormHelper.GetSelectedRowID(dgvProductsList));

            if (product is null)
            {
                clsFormMessages.ShowError("لم يتم العثور على المنتج");
                return;
            }

            frmAddEditProduct editProduct = new frmAddEditProduct(product);
            editProduct.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteSelectedProduct();
        }

        private void dgvProductsList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Left && e.RowIndex != -1)
            {
                _ShowSelectedProductInfo();
            }
        }

        private void dgvProductsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvProductsList.SelectedRows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    _ShowSelectedProductInfo();
                }
                else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    _DeleteSelectedProduct();
                }
            }
        }

        private void dgvProductsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProductsList.ClearSelection();
        }

        private void dgvProductsList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvProductsList.Rows[e.RowIndex].Selected = true;
                dgvProductsList.Columns[e.ColumnIndex].Selected = true;
            }
        }

        private void FormControls_MouseDown(object sender, MouseEventArgs e)
        {
            dgvProductsList.ClearSelection();

            if (sender != dgvProductsList)
            {
                ctrProductInfo.Visible = false;
            }
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvProductsList, e);
        }

        private void _ShowSelectedProductInfo()
        {
            if (dgvProductsList.SelectedRows.Count == 0)
            {
                clsFormMessages.ShowError("لم يتم العثور على المنتج");
                return;
            }

            if (ctrProductInfo.Visible && ctrProductInfo.Product?.ProductID == clsFormHelper.GetSelectedRowID(dgvProductsList))
            {
                return;
            }

            clsProduct product = clsProduct.Find(clsFormHelper.GetSelectedRowID(dgvProductsList));

            ctrProductInfo.Product = product;
            ctrProductInfo.Visible = true;
        }

        private void _DeleteSelectedProduct()
        {
            if (dgvProductsList.SelectedRows.Count == 0)
            {
                clsFormMessages.ShowError("لم يتم العثور على المنتج");
                return;
            }

            if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد حذف هذا المنتج ؟", messageBoxIcon: MessageBoxIcon.Warning, messageBoxDefaultButton: MessageBoxDefaultButton.Button2))
            {
                if (clsProduct.Delete(clsFormHelper.GetSelectedRowID(dgvProductsList)))
                {
                    clsFormMessages.ShowSuccess("تم حذف المنتج بنجاح");
                }
                else
                {
                    clsFormMessages.ShowError("فشلت عملية حذف المنتج");
                }
            }
        }

        private void frmProductsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsProduct.ProductSaved -= ClsProduct_ProductSaved;
            clsProduct.ProductDeleted -= ClsProduct_ProductDeleted;
        }

    }
}

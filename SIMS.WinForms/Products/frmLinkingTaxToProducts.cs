using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Products;
using DTOs.Products;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Products
{
    public partial class frmLinkingTaxToProducts : Form
    {
        private clsTax _Tax;
        private List<clsTaxItem> _TaxItems;
        private bool isPropagating = true;

        public frmLinkingTaxToProducts(clsTax tax)
        {
            InitializeComponent();
            _Tax = tax;
        }

        private void frmLinkingTaxToProducts_Load(object sender, EventArgs e)
        {
            if (_Tax == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على الضريبة");
                this.Close();
                return;
            }

            _TaxItems = _Tax.Items;

            lblTaxName.Text = _Tax.TaxName;
            lblTaxRate.Text = _Tax.TaxRate.ToString() + "%";
            lblActiveLinkingProduct.Text = _TaxItems.Count.ToString();
            lblCreatedAt.Text = _Tax.CreatedAt?.ToString("yyyy/MM/dd") ?? "N/A";
            lblActivityStatus.Text = _Tax.IsActive ? "نشط" : "غير نشط";
            lblActivityStatus.ForeColor = _Tax.IsActive ? Color.Lime : Color.Red;

            LoadProductsToTreeView(clsProductService.GetProductHierarchyForTreeView(withUnits: false));
        }

        private void trvProducts_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (isPropagating)
            {
                return;
            }

            isPropagating = true;

            if (e.Node.Nodes.Count > 0)
            {
                SelectedAllChiledNodes(e.Node);
            }

            CheckParentState(e.Node);

            isPropagating = false;
        }

        public void LoadProductsToTreeView(List<clsTreeCategoryDTO> categoriesHierarchy)
        {
            trvProducts.Nodes.Clear();

            TreeNode rootNode = new TreeNode("جميع المنتجات");
            rootNode.Tag = "ROOT";
            rootNode.Checked = false;
            trvProducts.Nodes.Add(rootNode);

            BuildCategoryNodes(categoriesHierarchy, rootNode);

            rootNode.Expand();
        }

        private void BuildCategoryNodes(List<clsTreeCategoryDTO> categories, TreeNode parentNode)
        {
            parentNode.Checked = true;

            foreach (var category in categories)
            {
                TreeNode categoryNode = new TreeNode(category.CategoryName);
                categoryNode.Tag = $"CATEGORY_{category.CategoryID}";

                foreach (var product in category.Products)
                {
                    TreeNode productNode = new TreeNode(product.ProductName);
                    productNode.Tag = $"PRODUCT_{product.ProductID}";

                    categoryNode.Checked = productNode.Checked = _TaxItems
                            .Any(
                            item =>
                            item.ProductID == product.ProductID
                            );

                    parentNode.Checked &= productNode.Checked;
                    categoryNode.Nodes.Add(productNode);
                }

                parentNode.Nodes.Add(categoryNode);
            }

            isPropagating = false;
        }

        private void SelectedAllChiledNodes(TreeNode root)
        {
            foreach (TreeNode node in root.Nodes)
            {
                node.Checked = root.Checked;
                SelectedAllChiledNodes(node);
            }
        }

        private void CheckParentState(TreeNode node)
        {
            if (node.Parent == null)
            {
                return;
            }

            bool isRootNode = node.Parent.Tag?.ToString() == "ROOT";

            if (isRootNode)
            {
                bool allProductsAndUnitsChecked = true;

                foreach (TreeNode categoryNode in node.Parent.Nodes.Cast<TreeNode>())
                {
                    foreach (TreeNode productNode in categoryNode.Nodes.Cast<TreeNode>())
                    {
                        if (!productNode.Checked)
                        {
                            allProductsAndUnitsChecked = false;
                            break;
                        }
                    }

                    if (!allProductsAndUnitsChecked)
                    {
                        break;
                    }
                }

                if (allProductsAndUnitsChecked)
                {
                    if (!node.Parent.Checked)
                    {
                        node.Parent.Checked = true;
                    }
                }
                else
                {
                    if (node.Parent.Checked)
                    {
                        node.Parent.Checked = false;
                    }
                }
            }
            else
            {
                bool anySiblingChecked = node.Parent.Nodes.
                    Cast<TreeNode>().
                    Any(sibling => sibling.Checked);

                if (anySiblingChecked)
                {
                    if (!node.Parent.Checked)
                    {
                        node.Parent.Checked = true;
                    }
                }
                else
                {
                    if (node.Parent.Checked)
                    {
                        node.Parent.Checked = false;
                    }
                }
            }

            CheckParentState(node.Parent);
        }

        public List<clsTaxItem> GetSelectedTaxItems()
        {
            List<clsTaxItem> selectedTaxItems = new List<clsTaxItem>();

            if (trvProducts.Nodes.Count > 0)
            {
                TreeNode rootNode = trvProducts.Nodes[0];
                CollectTaxItemsRecursively(rootNode, _Tax.TaxID ?? -1, selectedTaxItems);
            }

            return selectedTaxItems;
        }

        private void CollectTaxItemsRecursively(
            TreeNode node,
            int taxID,
            List<clsTaxItem> itemsList)
        {
            if (node.Checked && node.Tag != null)
            {
                string tag = node.Tag.ToString();

                if (tag.StartsWith("PRODUCT_"))
                {
                    if (int.TryParse(tag.Substring(tag.IndexOf('_') + 1), out int productID))
                    {
                        if (productID > 0)
                        {
                            itemsList.Add(
                                new clsTaxItem
                                (
                                    taxID,
                                    productID
                                )
                            );
                        }
                    }
                }
            }

            foreach (TreeNode child in node.Nodes)
            {
                CollectTaxItemsRecursively(child, taxID, itemsList);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                return;
            }

            if (_Tax.SaveTaxItems(GetSelectedTaxItems()))
            {
                clsFormMessages.ShowSuccess("تم ربط الضريبة مع المنتجات المحددة بنجاح");
                this.Close();
            }
            else
            {
                clsFormMessages.ShowSuccess("فشل ربط الضريبة بالمنتجات المحددة");
            }
        }

    }
}

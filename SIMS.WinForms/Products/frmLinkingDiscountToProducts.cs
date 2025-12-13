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
    public partial class frmLinkingDiscountToProducts : Form
    {
        private clsDiscount _Discount;
        private List<clsDiscountItem> _DiscountItems;
        private bool isPropagating = true;

        public frmLinkingDiscountToProducts(clsDiscount discount)
        {
            InitializeComponent();
            _Discount = discount;
        }

        private void frmLinkingDiscountToProducts_Load(object sender, EventArgs e)
        {
            if (_Discount == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على الخصم");
                this.Close();
                return;
            }

            lblDiscountName.Text = _Discount.DiscountName;
            lblPeriodOperation.Text = _Discount.StartDate.ToString("yyyy/MM/dd") + " - " + _Discount.EndDate.ToString("yyyy/MM/dd") + $" ({(_Discount.EndDate - _Discount.StartDate).Days} يوم/أيام)";
            lblActivityStatus.Text = _Discount.IsActive ? "نشط" : "غير نشط";
            lblActivityStatus.ForeColor = _Discount.IsActive ? Color.Lime : Color.Red;
            _DiscountItems = _Discount.Items;
            lblActiveLinkingProduct.Text = _DiscountItems.Count.ToString();

            LoadProductsToTreeView(clsProductService.GetProductHierarchyForTreeView());
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

                    foreach (var unit in product.Units)
                    {
                        TreeNode unitNode = new TreeNode($"{unit.UnitName}");
                        unitNode.Tag = $"UNIT_{unit.UnitID}";

                        categoryNode.Checked = productNode.Checked = unitNode.Checked =
                            _DiscountItems.Any(
                            item => 
                            item.ProductID == product.ProductID &&
                            item.UnitID == unit.UnitID
                            );

                        parentNode.Checked &= unitNode.Checked;
                        productNode.Nodes.Add(unitNode);
                    }

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
                        foreach (TreeNode unitNode in productNode.Nodes.Cast<TreeNode>())
                        {
                            if (!unitNode.Checked)
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

        public List<clsDiscountItem> GetSelectedDiscountItems()
        {
            List<clsDiscountItem> selectedDiscountItems = new List<clsDiscountItem>();

            if (trvProducts.Nodes.Count > 0)
            {
                TreeNode rootNode = trvProducts.Nodes[0];
                CollectDiscountItemsRecursively(rootNode, _Discount.DiscountID ?? -1, selectedDiscountItems);
            }

            return selectedDiscountItems;
        }

        private void CollectDiscountItemsRecursively(
            TreeNode node,
            int discountID,
            List<clsDiscountItem> itemsList)
        {
            if (node.Checked && node.Tag != null)
            {
                string tag = node.Tag.ToString();

                if (tag.StartsWith("UNIT_"))
                {
                    if (int.TryParse(tag.Substring(tag.IndexOf('_') + 1), out int unitID))
                    {
                        int productID = 0;

                        if (node.Parent != null && node.Parent.Tag != null && node.Parent.Tag.ToString().StartsWith("PRODUCT_"))
                        {
                            string parentTag = node.Parent.Tag.ToString();
                            int.TryParse(parentTag.Substring(parentTag.IndexOf('_') + 1), out productID);
                        }

                        if (productID > 0)
                        {
                            itemsList.Add(
                                new clsDiscountItem
                                (
                                    discountID,
                                    productID,
                                    unitID
                                )
                            );
                        }
                    }
                }
            }

            foreach (TreeNode child in node.Nodes)
            {
                CollectDiscountItemsRecursively(child, discountID, itemsList);
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

            if (_Discount.SaveDiscountItems(GetSelectedDiscountItems()))
            {
                clsFormMessages.ShowSuccess("تم ربط الخصم مع المنتجات المحددة بنجاح");
                this.Close();
            }
            else
            {
                clsFormMessages.ShowSuccess("فشل ربط الخصم بالمنتجات المحددة");
            }
        }

    }
}
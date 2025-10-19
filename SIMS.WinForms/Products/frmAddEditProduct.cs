using System;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;
using BusinessLogic.Validation;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Suppliers;

namespace SIMS.WinForms.Products
{
    public partial class frmAddEditProduct : Form
    {
        private clsProduct _Product;
        private frmProductUnitConversions _UnitConversionsForm;
        private bool _IsAddedSupplier;
        private int _AddedSupplierID;
        private enMode _FormMode;

        public frmAddEditProduct()
        {
            InitializeComponent();
            _Product = null;
            _UnitConversionsForm = new frmProductUnitConversions(this);
            _FormMode = enMode.Add;
        }

        public frmAddEditProduct(clsProduct product)
        {
            InitializeComponent();
            _Product = product;
            _UnitConversionsForm = new frmProductUnitConversions(this, product.UnitConversions);
            _FormMode = enMode.Edit;
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            this.Text = _FormMode == enMode.Add ? 
                "إضافة منتج جديد" :
                "تعديل منتج";

            cbCategory.Items.AddRange(clsCategory.GetCategoryNames());
            cbBaseUnit.Items.AddRange(clsUnit.GetUnitNames());
            cbMainSupplier.Items.AddRange(clsSupplierService.GetAllSupplierNames());

            if (_FormMode is enMode.Edit)
            {
                txtProductName.Text = _Product.ProductName;
                txtProductBarcode.Text = _Product.Barcode;
                cbCategory.SelectedIndex = _Product.CategoryInfo.CategoryID - 1;
                cbBaseUnit.SelectedIndex = _Product.MainUnitInfo.UnitID - 1;
                txtSellingPrice.Text = _Product.SellingPrice.ToString();
                cbMainSupplier.SelectedItem = _Product.MainSupplierInfo?.PartyInfo.PartyName;
                txtDescription.Text = _Product.Description;
                lblTotalOtherUnits.Text = _Product.UnitConversions?.Count.ToString();
                ctrProductImage.ImageLocation = _Product.ImagePath;
            }

            clsSupplierService.CreateInstance().EntitySaved += ClsSupplier_SupplierSaved;
        }

        private void cbCatigory_Enter(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == -1)
            {
                cbCategory.Text = string.Empty;
            }
        }

        private void cbCatigory_Leave(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == -1)
            {
                cbCategory.Text = "إختار التصنيف/الفئة";
            }
        }

        private void cbUnit_Enter(object sender, EventArgs e)
        {
            if (cbBaseUnit.SelectedIndex == -1)
            {
                cbBaseUnit.Text = string.Empty;
            }
        }

        private void cbUnit_Leave(object sender, EventArgs e)
        {
            if (cbBaseUnit.SelectedIndex == -1)
            {
                cbBaseUnit.Text = "إختار وحدة القياس الأساسية";
            }
        }

        private void cbMainSupllier_Enter(object sender, EventArgs e)
        {
            if (cbMainSupplier.SelectedIndex == -1)
            {
                cbMainSupplier.Text = string.Empty;
            }
        }

        private void cbMainSupllier_Leave(object sender, EventArgs e)
        {
            if (cbMainSupplier.SelectedIndex == -1)
            {
                cbMainSupplier.Text = "إختار المورد الأساسي";
            }
        }

        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductBarcode.Text))
            {
                txtProductBarcode.Text = clsProductService.GenerateBarcode();

                if (!string.IsNullOrEmpty(errorProvider.GetError(txtProductBarcode)))
                {
                    errorProvider.SetError(txtProductBarcode, string.Empty);
                }
            }
            else
            {
                clsFormMessages.ShowError("يجب أن يكون حقل الباركود فارغا لتوليد باركود جديد");
            }
        }

        private void llAddPersonSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addPersonSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Person);
            addPersonSupplier.ShowDialog();
            cbMainSupplier.Focus();
            llAddPersonSupplier.Focus();
        }

        private void llAddOrganizationSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addEditOrganizationSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Organization);
            addEditOrganizationSupplier.ShowDialog();
            cbMainSupplier.Focus();
            llAddOrganizationSupplier.Focus();
        }

        private void ClsSupplier_SupplierSaved(object sender, EntitySavedEventArgs e)
        {
            cbMainSupplier.Items.AddRange(clsSupplierService.GetAllSupplierNames());
            cbMainSupplier.SelectedItem = e.EntityName;

            // It use later for delete the added supplier if the user cancle the add/edit operation
            _IsAddedSupplier = true;
            _AddedSupplierID = e.EntityID;
        }

        private void llAddOtherUnits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || cbBaseUnit.SelectedIndex == -1)
            {
                txtProductName.Focus(); cbBaseUnit.Focus(); llAddOtherUnits.Focus();
                clsFormMessages.ShowError("لإضافة وحدات بديلة يجب أولا تعيين إسم للمنتج و إختيار وحدة قياس أساسية");
                return;
            }

            _UnitConversionsForm.ProductName = txtProductName.Text;
            _UnitConversionsForm.BaseUnit = cbBaseUnit.Text;
            _UnitConversionsForm.FormMode = _FormMode;
            _UnitConversionsForm.ShowDialog();

            // after come back from setting a unit cinversions
            lblTotalOtherUnits.Text = _UnitConversionsForm.UnitConversions.Count.ToString();
        }

        private void txtProductName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtProductName, errorProvider, "لا يمكن أن يكون حقل إسم المنتج فارغا");
        }

        private void txtProductBarcode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtProductBarcode, errorProvider, "لا يمكن أن يكون حقل الباركود فارغا");
        }

        private void cbCategory_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(cbCategory, errorProvider, "يجب إختيار تصنيف/فئة للمنتج");
        }

        private void cbBaseUnit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(cbBaseUnit, errorProvider, "يجب إختيار وحدة قياس أساسية للمنتج");
        }

        private void txtSellingPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSellingPrice.Text))
            {
                errorProvider.SetError(txtSellingPrice, "لا يمكن أن يكون حقل سعر البيع فارغاً");
            }
            else if (!decimal.TryParse(txtSellingPrice.Text, out decimal sellingPrice))
            {
                errorProvider.SetError(txtSellingPrice, "يجب إدخال قيمة رقمية صحيحة أو عشرية لسعر البيع");
            }
            else if (sellingPrice < 1)
            {
                errorProvider.SetError(txtSellingPrice, "يجب أن يكون سعر البيع أكبر من صفر");
            }
            else
            {
                errorProvider.SetError(txtSellingPrice, string.Empty);
            }
        }

        private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsFormValidation.HandleFloatingKeyPress(e, txtSellingPrice, errorProvider);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (_IsAddedSupplier)
            {
                if (clsFormMessages.Confirm("لقد قمت بإضافة مورد جديد, هل تريد حذفه ؟", messageBoxIcon: MessageBoxIcon.Warning))
                {
                    if (!clsSupplierService.CreateInstance().Delete(_AddedSupplierID))
                    {
                        clsFormMessages.ShowError("لقد فشلت عملية حذف المورد الجديد الذي تم إضافته, رجاءا قم بحذفه يدويا إذا لم تكن بحاجة إليه");
                    }
                }
            }

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsFormValidation.IsDataValid(this, errorProvider))
            {
                clsFormMessages.ShowInvalidDataError();
                return;
            }

            if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                if (_FormMode is enMode.Add)
                {
                    _Product = new clsProduct(
                        txtProductName.Text,
                        txtProductBarcode.Text,
                        cbCategory.SelectedIndex + 1,
                        cbBaseUnit.SelectedIndex + 1,
                        _UnitConversionsForm.UnitConversions,
                        cbMainSupplier.Text,
                        Convert.ToSingle(txtSellingPrice.Text),
                        txtDescription.Text,
                        ctrProductImage.ImageLocation
                        );
                }
                else
                {
                    _Product.ProductName = txtProductName.Text;
                    _Product.Barcode = txtProductBarcode.Text;
                    _Product.ChangeCategory(cbCategory.SelectedIndex + 1);
                    _Product.ChangeMainUnit(cbBaseUnit.SelectedIndex + 1);
                    _Product.ChangeMainSupplier(cbMainSupplier.Text);
                    _Product.SellingPrice = Convert.ToSingle(txtSellingPrice.Text);
                    _Product.Description = txtDescription.Text;
                    _Product.ImagePath = ctrProductImage.ImageLocation;
                }

                clsValidationResult validationResult = clsProductService.CreateInstance().Save(_Product);

                if (validationResult.IsValid)
                {
                    if (_FormMode is enMode.Add)
                    {
                        clsFormMessages.ShowSuccess("تم إضافة المنتج بنجاح");
                    }
                    else
                    {
                        clsFormMessages.ShowSuccess("تم حفظ التغيرات بنجاح");
                    }

                    this.Close();
                }
                else
                {
                    clsFormMessages.ShowValidationErrors(validationResult);
                }
            }
        }
        
    }
}
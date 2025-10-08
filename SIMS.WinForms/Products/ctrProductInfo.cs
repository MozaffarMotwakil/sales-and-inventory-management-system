using System.Windows.Forms;
using BusinessLogic.Products;

namespace SIMS.WinForms.Products
{
    public partial class ctrProductInfo : UserControl
    {
        private clsProduct _Product;

        public clsProduct Product
        {
            get => _Product;

            set
            {
                if (value is null)
                {
                    return;
                }

                _Product = value;
                lblProductName.Text = _Product.ProductName;
                lblProductBarcode.Text = _Product.Barcode;
                lblSellingPrice.Text = _Product.SellingPrice.ToString() + " ريال";
                pbProductImage.ImageLocation = _Product.ImagePath;
            }
        }

        public ctrProductInfo()
        {
            InitializeComponent();
        }

    }
}

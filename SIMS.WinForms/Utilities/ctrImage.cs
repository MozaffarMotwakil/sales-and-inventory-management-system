using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Utilities
{
    public partial class ctrImage : UserControl
    {
        public string ImageLocation 
        {
            get => pbImage.ImageLocation;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    pbImage.ImageLocation = value;
                    llDeleteImage.Visible = true;
                }
            }
        }

        public PictureBoxSizeMode PictureBoxSizeMode
        {
            get => pbImage.SizeMode;
            set => pbImage.SizeMode = value;
        }

        private Image _DefaultImage;
        public Image DefaultImage 
        {
            get => _DefaultImage;
            set
            {
                _DefaultImage = value;
                pbImage.Image = value;
            }
        }

        public ctrImage()
        {
            InitializeComponent();
            DefaultImage = Resources.default_image;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialogSetNewImage = new OpenFileDialog();
            fileDialogSetNewImage.Title = "Set Image";
            fileDialogSetNewImage.InitialDirectory = @"C:\";
            fileDialogSetNewImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|.jpg|*.jpg|.png|*.png";
            fileDialogSetNewImage.DefaultExt = "JPG";
            fileDialogSetNewImage.FilterIndex = 1;

            if (fileDialogSetNewImage.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = fileDialogSetNewImage.FileName;
                llDeleteImage.Visible = true;
            }
        }

        private void llDeleteImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد حذف الصورة ؟", messageBoxIcon: MessageBoxIcon.Warning))
            {
                pbImage.ImageLocation = string.Empty;
                pbImage.Image = DefaultImage;
                llDeleteImage.Visible = false;
            }
        }

    }
}

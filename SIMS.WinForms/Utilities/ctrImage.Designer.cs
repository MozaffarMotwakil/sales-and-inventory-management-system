namespace SIMS.WinForms.Utilities
{
    partial class ctrImage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.llDeleteImage = new System.Windows.Forms.LinkLabel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // llDeleteImage
            // 
            this.llDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llDeleteImage.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.llDeleteImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.llDeleteImage.LinkColor = System.Drawing.Color.Red;
            this.llDeleteImage.Location = new System.Drawing.Point(1, 156);
            this.llDeleteImage.Name = "llDeleteImage";
            this.llDeleteImage.Size = new System.Drawing.Size(169, 16);
            this.llDeleteImage.TabIndex = 45;
            this.llDeleteImage.TabStop = true;
            this.llDeleteImage.Text = "حذف الصورة";
            this.llDeleteImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llDeleteImage.Visible = false;
            this.llDeleteImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDeleteImage_LinkClicked);
            // 
            // llSetImage
            // 
            this.llSetImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llSetImage.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.llSetImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.llSetImage.Location = new System.Drawing.Point(3, 139);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(165, 16);
            this.llSetImage.TabIndex = 44;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "تعيين صورة";
            this.llSetImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.Image = global::SIMS.WinForms.Properties.Resources.default_image;
            this.pbImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbImage.Location = new System.Drawing.Point(1, 0);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(168, 136);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 46;
            this.pbImage.TabStop = false;
            // 
            // ctrImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llDeleteImage);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.pbImage);
            this.Name = "ctrImage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(170, 175);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel llDeleteImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.PictureBox pbImage;
    }
}

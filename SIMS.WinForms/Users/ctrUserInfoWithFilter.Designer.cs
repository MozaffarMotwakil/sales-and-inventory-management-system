namespace SIMS.WinForms.Users
{
    partial class ctrUserInfoWithFilter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSearchBy = new System.Windows.Forms.GroupBox();
            this.rbUsername = new System.Windows.Forms.RadioButton();
            this.rbFullName = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ctrUserInfo = new SIMS.WinForms.Users.ctrUserInfo();
            this.panel1.SuspendLayout();
            this.gbSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gbSearchBy);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 58);
            this.panel1.TabIndex = 0;
            // 
            // gbSearchBy
            // 
            this.gbSearchBy.Controls.Add(this.rbUsername);
            this.gbSearchBy.Controls.Add(this.rbFullName);
            this.gbSearchBy.Location = new System.Drawing.Point(3, 3);
            this.gbSearchBy.Name = "gbSearchBy";
            this.gbSearchBy.Size = new System.Drawing.Size(187, 52);
            this.gbSearchBy.TabIndex = 6;
            this.gbSearchBy.TabStop = false;
            this.gbSearchBy.Text = "Search By";
            // 
            // rbUsername
            // 
            this.rbUsername.AutoSize = true;
            this.rbUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsername.Location = new System.Drawing.Point(98, 26);
            this.rbUsername.Name = "rbUsername";
            this.rbUsername.Size = new System.Drawing.Size(83, 20);
            this.rbUsername.TabIndex = 4;
            this.rbUsername.Text = "Username";
            this.rbUsername.UseVisualStyleBackColor = true;
            // 
            // rbFullName
            // 
            this.rbFullName.AutoSize = true;
            this.rbFullName.Checked = true;
            this.rbFullName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFullName.Location = new System.Drawing.Point(8, 26);
            this.rbFullName.Name = "rbFullName";
            this.rbFullName.Size = new System.Drawing.Size(82, 20);
            this.rbFullName.TabIndex = 3;
            this.rbFullName.TabStop = true;
            this.rbFullName.Text = "Full Name";
            this.rbFullName.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::SIMS.WinForms.Properties.Resources.search;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Location = new System.Drawing.Point(562, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(37, 27);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(196, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // ctrUserInfo
            // 
            this.ctrUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrUserInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrUserInfo.Location = new System.Drawing.Point(4, 66);
            this.ctrUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ctrUserInfo.Name = "ctrUserInfo";
            this.ctrUserInfo.Size = new System.Drawing.Size(604, 285);
            this.ctrUserInfo.TabIndex = 5;
            // 
            // ctrUserInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrUserInfo);
            this.Name = "ctrUserInfoWithFilter";
            this.Size = new System.Drawing.Size(611, 353);
            this.Load += new System.EventHandler(this.ctrUserInfoWithFilter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSearchBy.ResumeLayout(false);
            this.gbSearchBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrUserInfo ctrUserInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSearchBy;
        private System.Windows.Forms.RadioButton rbUsername;
        private System.Windows.Forms.RadioButton rbFullName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

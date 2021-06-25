
namespace RED7Studios.EzCarRecode
{
    partial class frmAbout
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new RED7Studios.UI.Controls.ModernButton();
            this.lbProductNameLabel = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbCompanyLabel = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbVersionLabel = new System.Windows.Forms.Label();
            this.modernButton1 = new RED7Studios.UI.Controls.ModernButton();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.CustomColorScheme = false;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(436, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 128);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbProductNameLabel
            // 
            this.lbProductNameLabel.AutoSize = true;
            this.lbProductNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbProductNameLabel.Location = new System.Drawing.Point(14, 46);
            this.lbProductNameLabel.Name = "lbProductNameLabel";
            this.lbProductNameLabel.Size = new System.Drawing.Size(100, 19);
            this.lbProductNameLabel.TabIndex = 1;
            this.lbProductNameLabel.Text = "Product Name:";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbProductName.Location = new System.Drawing.Point(114, 46);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(120, 19);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "PRODUCT NAME";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCompany.Location = new System.Drawing.Point(114, 65);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(80, 19);
            this.lbCompany.TabIndex = 4;
            this.lbCompany.Text = "COMPANY";
            // 
            // lbCompanyLabel
            // 
            this.lbCompanyLabel.AutoSize = true;
            this.lbCompanyLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbCompanyLabel.Location = new System.Drawing.Point(14, 65);
            this.lbCompanyLabel.Name = "lbCompanyLabel";
            this.lbCompanyLabel.Size = new System.Drawing.Size(71, 19);
            this.lbCompanyLabel.TabIndex = 3;
            this.lbCompanyLabel.Text = "Company:";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbVersion.Location = new System.Drawing.Point(114, 84);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(68, 19);
            this.lbVersion.TabIndex = 6;
            this.lbVersion.Text = "VERSION";
            // 
            // lbVersionLabel
            // 
            this.lbVersionLabel.AutoSize = true;
            this.lbVersionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbVersionLabel.Location = new System.Drawing.Point(14, 84);
            this.lbVersionLabel.Name = "lbVersionLabel";
            this.lbVersionLabel.Size = new System.Drawing.Size(57, 19);
            this.lbVersionLabel.TabIndex = 5;
            this.lbVersionLabel.Text = "Version:";
            // 
            // modernButton1
            // 
            this.modernButton1.CustomColorScheme = false;
            this.modernButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernButton1.Location = new System.Drawing.Point(302, 44);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.Size = new System.Drawing.Size(128, 128);
            this.modernButton1.TabIndex = 23;
            this.modernButton1.Text = "Settings";
            this.modernButton1.UseVisualStyleBackColor = true;
            this.modernButton1.Click += new System.EventHandler(this.modernButton1_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 185);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.modernButton1);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbVersionLabel);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbCompanyLabel);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProductNameLabel);
            this.Controls.Add(this.btnExit);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAbout_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.Controls.ModernButton btnExit;
        private System.Windows.Forms.Label lbProductNameLabel;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label lbCompanyLabel;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbVersionLabel;
        private UI.Controls.ModernButton modernButton1;
    }
}
using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.EzCarRecode
{
    public partial class frmAbout : ModernForm
    {
        public frmAbout()
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            lbCompany.Text = fvi.CompanyName;
            lbProductName.Text = fvi.ProductName;
            lbVersion.Text = fvi.ProductVersion;
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.Show();
        }
    }
}

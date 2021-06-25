using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.EzCarRecode
{
    public partial class frmSettings : ModernForm
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            Settings.MusicPlayerSettings MusicPlayerSettings = new Settings.MusicPlayerSettings();
            MusicPlayerSettings.Show();
        }

        private void modernButton3_Click(object sender, EventArgs e)
        {
            Settings.Plugins Plugins = new Settings.Plugins();
            Plugins.Show();
        }
    }
}

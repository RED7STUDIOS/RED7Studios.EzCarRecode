using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace RED7Studios.EzCarRecode.Settings
{
    public partial class MusicPlayerSettings : ModernForm
    {
        string musicLocation;

        Common common;

        public MusicPlayerSettings()
        {
            InitializeComponent();

            using (StreamReader r = new StreamReader("config.json"))
            {
                string json = r.ReadToEnd();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                var Items = jss.Deserialize<JSONClass>(json);
                musicLocation = Items.musicLocation;
            }

            // Set the common variable to a new Common class.
            common = new Common();
        }

        private void MusicPlayerSettings_Load(object sender, EventArgs e)
        {
            textBox1.Text = musicLocation;
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            common.EditJsonString("config.json", "musicLocation", textBox1.Text);
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            var selectedOption = MessageBox.Show("This will restart the whole program which if set up may restart the computer it is running on, are you sure you want to restart the application?", "APPLICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (selectedOption == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}

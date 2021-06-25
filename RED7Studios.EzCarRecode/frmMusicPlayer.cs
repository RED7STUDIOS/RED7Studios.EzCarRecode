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

namespace RED7Studios.EzCarRecode
{
    public partial class frmMusicPlayer : Form
    {
        string musicRootDirectory;

        Common common;

        string musicLocation;
        bool isDeveloper;

        public frmMusicPlayer()
        {
            InitializeComponent();

            using (StreamReader r = new StreamReader("config.json"))
            {
                string json = r.ReadToEnd();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                var Items = jss.Deserialize<JSONClass>(json);
                musicLocation = Items.musicLocation;
                isDeveloper = Items.isDeveloper;
            }

            musicRootDirectory = musicLocation;

            common = new Common();

            this.Text = Languages.Resources.frmMusicPlayer_Title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!isDeveloper)
                {
                    tlpSongControls.ColumnCount = 1;
                }

                // Create a new list.
                List<String> dataSource = new List<String>();
                // Get all of the sub directories of the root directory for music and convert it to a list.
                dataSource = Directory.GetDirectories(musicRootDirectory).Select(Path.GetFileName).ToList();

                // If "System Volume Information" exists,
                if (dataSource.Contains("System Volume Information"))
                {
                    // Then remove it from the data source which is all the sub directories of the root directory.
                    dataSource.RemoveAt(0);
                }

                // Populate artists list box with the list.
                lbArtists.DataSource = dataSource;

                // Utilize the create playlist function.
                CreatePlaylist();

                lbSongs.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        // Create playlist function to create a playlist.
        private void CreatePlaylist()
        {
            try
            {
                // Set the player URL to what is selected in the songs list box.
                string music = listBox1.SelectedItem.ToString();
                player.URL = music;

                // Play the player with the selected song.
                player.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = lbSongs.SelectedIndex;
            CreatePlaylist();
        }

        private void lbAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.DataSource = Directory.GetFiles(musicRootDirectory + @"\" + lbArtists.SelectedItem.ToString() + @"\" + lbAlbums.SelectedItem.ToString(), "*.*", SearchOption.AllDirectories).ToList();
                DirectoryInfo di = new DirectoryInfo(musicRootDirectory + @"\" + lbArtists.SelectedItem.ToString() + @"\" + lbAlbums.SelectedItem.ToString());
                FileInfo[] files = di.GetFiles("*.*");

                lbSongs.Items.Clear();

                foreach (FileInfo file in files)
                {
                    var str = Path.ChangeExtension(file.Name, null);

                    lbSongs.Items.Add(str);
                }

                CreatePlaylist();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void lbArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbAlbums.DataSource = Directory.GetDirectories(musicRootDirectory + @"\" + lbArtists.SelectedItem).Select(Path.GetFileName).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void player_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            
        }

        private void frmMusicPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode.ToString());

            if (e.KeyCode == Keys.F1)
            {
                if (gbChangeSongs.Visible == true)
                {
                    gbChangeSongs.Visible = false;
                    tlpMain.ColumnCount = 1;
                }
                else
                {
                    gbChangeSongs.Visible = true;
                    tlpMain.ColumnCount = 2;
                }
            }

            else if (e.KeyCode == Keys.F11)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    common.GoFullscreen(true, this, player);
                }
                else
                {
                    common.GoFullscreen(false, this, player);
                }
            }

            else if (e.KeyCode == Keys.F12)
            {
                frmAbout about = new frmAbout();
                about.ShowDialog();
            }
        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void player_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            label1.Text = "Playing: " + player.URL;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            common.PlayPause(player);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lbSongs.SelectedIndex != lbSongs.Items.Count - 1)
            {
                lbSongs.SelectedIndex = lbSongs.SelectedIndex + 1;
            }
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            if (lbSongs.SelectedIndex > 0)
            {
                lbSongs.SelectedIndex = lbSongs.SelectedIndex - 1;
            }
        }

        private void player_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            if (lbSongs.SelectedIndex != 0)
            {
                if (lbSongs.SelectedIndex != lbSongs.Items.Count - 1)
                {
                    lbSongs.SelectedIndex = lbSongs.SelectedIndex + 1;
                }
            }
        }
    }
}

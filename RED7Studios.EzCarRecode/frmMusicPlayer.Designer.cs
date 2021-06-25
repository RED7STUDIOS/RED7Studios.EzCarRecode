
namespace RED7Studios.EzCarRecode
{
    partial class frmMusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusicPlayer));
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.lbAlbums = new System.Windows.Forms.ListBox();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.gbChangeSongs = new System.Windows.Forms.GroupBox();
            this.tlpSongControls = new System.Windows.Forms.TableLayoutPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbDeveloper = new System.Windows.Forms.GroupBox();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.gbChangeSongs.SuspendLayout();
            this.tlpSongControls.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.gbDeveloper.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSongs
            // 
            this.lbSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSongs.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 30;
            this.lbSongs.Location = new System.Drawing.Point(0, 0);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(360, 313);
            this.lbSongs.TabIndex = 25;
            this.lbSongs.SelectedIndexChanged += new System.EventHandler(this.lbSongs_SelectedIndexChanged);
            // 
            // lbAlbums
            // 
            this.lbAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAlbums.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lbAlbums.FormattingEnabled = true;
            this.lbAlbums.ItemHeight = 30;
            this.lbAlbums.Location = new System.Drawing.Point(0, 0);
            this.lbAlbums.Name = "lbAlbums";
            this.lbAlbums.ScrollAlwaysVisible = true;
            this.lbAlbums.Size = new System.Drawing.Size(360, 313);
            this.lbAlbums.TabIndex = 27;
            this.lbAlbums.SelectedIndexChanged += new System.EventHandler(this.lbAlbums_SelectedIndexChanged);
            // 
            // lbArtists
            // 
            this.lbArtists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbArtists.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.ItemHeight = 30;
            this.lbArtists.Location = new System.Drawing.Point(0, 0);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.ScrollAlwaysVisible = true;
            this.lbArtists.Size = new System.Drawing.Size(345, 313);
            this.lbArtists.TabIndex = 26;
            this.lbArtists.SelectedIndexChanged += new System.EventHandler(this.lbArtists_SelectedIndexChanged);
            // 
            // gbChangeSongs
            // 
            this.gbChangeSongs.Controls.Add(this.tlpSongControls);
            this.gbChangeSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChangeSongs.Location = new System.Drawing.Point(818, 3);
            this.gbChangeSongs.Name = "gbChangeSongs";
            this.gbChangeSongs.Size = new System.Drawing.Size(365, 576);
            this.gbChangeSongs.TabIndex = 28;
            this.gbChangeSongs.TabStop = false;
            this.gbChangeSongs.Text = "Song Controls";
            // 
            // tlpSongControls
            // 
            this.tlpSongControls.ColumnCount = 1;
            this.tlpSongControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSongControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSongControls.Controls.Add(this.metroTabControl1, 1, 0);
            this.tlpSongControls.Controls.Add(this.gbDeveloper, 0, 1);
            this.tlpSongControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSongControls.Location = new System.Drawing.Point(3, 16);
            this.tlpSongControls.Name = "tlpSongControls";
            this.tlpSongControls.RowCount = 2;
            this.tlpSongControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.27289F));
            this.tlpSongControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.72711F));
            this.tlpSongControls.Size = new System.Drawing.Size(359, 557);
            this.tlpSongControls.TabIndex = 28;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(353, 352);
            this.metroTabControl1.TabIndex = 28;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lbArtists);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(345, 313);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Artists";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.lbAlbums);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(360, 313);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Albums";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.listBox1);
            this.metroTabPage3.Controls.Add(this.lbSongs);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(360, 313);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Songs";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(3, 475);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(33, 34);
            this.listBox1.TabIndex = 26;
            this.listBox1.Visible = false;
            // 
            // gbDeveloper
            // 
            this.gbDeveloper.Controls.Add(this.btnBefore);
            this.gbDeveloper.Controls.Add(this.btnNext);
            this.gbDeveloper.Controls.Add(this.btnPlayPause);
            this.gbDeveloper.Controls.Add(this.label1);
            this.gbDeveloper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbDeveloper.Location = new System.Drawing.Point(3, 361);
            this.gbDeveloper.Name = "gbDeveloper";
            this.gbDeveloper.Size = new System.Drawing.Size(353, 193);
            this.gbDeveloper.TabIndex = 29;
            this.gbDeveloper.TabStop = false;
            this.gbDeveloper.Text = "Developer";
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(198, 156);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(88, 31);
            this.btnBefore.TabIndex = 3;
            this.btnBefore.Text = "before";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(104, 156);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 31);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(10, 156);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(88, 31);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.Text = "play/pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playing";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.77534F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.22466F));
            this.tlpMain.Controls.Add(this.gbChangeSongs, 1, 0);
            this.tlpMain.Controls.Add(this.player, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(1186, 582);
            this.tlpMain.TabIndex = 29;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(3, 3);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(809, 576);
            this.player.TabIndex = 0;
            this.player.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.player_MediaChange);
            this.player.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.player_CurrentItemChange);
            this.player.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.player_KeyDownEvent);
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // frmMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 582);
            this.Controls.Add(this.tlpMain);
            this.KeyPreview = true;
            this.Name = "frmMusicPlayer";
            this.ShowIcon = false;
            this.Text = "Music Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMusicPlayer_KeyDown);
            this.gbChangeSongs.ResumeLayout(false);
            this.tlpSongControls.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.gbDeveloper.ResumeLayout(false);
            this.gbDeveloper.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.ListBox lbAlbums;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.GroupBox gbChangeSongs;
        private System.Windows.Forms.TableLayoutPanel tlpSongControls;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbDeveloper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnNext;
    }
}


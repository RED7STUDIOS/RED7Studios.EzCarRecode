using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.EzCarRecode
{
    public class Common
    {
        public void GoFullscreen(bool fullscreen, Form form, AxWMPLib.AxWindowsMediaPlayer player)
        {
            if (fullscreen)
            {
                form.WindowState = FormWindowState.Normal;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Bounds = Screen.PrimaryScreen.Bounds;
                player.fullScreen = true;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
                form.FormBorderStyle = FormBorderStyle.Sizable;
                player.fullScreen = false;
            }
        }

        public void EditJsonBoolean(string fileDir, string obj, bool value)
        {
            string json = File.ReadAllText(fileDir);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj[obj] = value;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fileDir, output);
        }

        public void EditJsonString(string fileDir, string obj, string value)
        {
            string json = File.ReadAllText(fileDir);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj[obj] = value;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fileDir, output);
        }

        public void PlayPause(AxWMPLib.AxWindowsMediaPlayer player)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.play();
            }
        }
    }
}

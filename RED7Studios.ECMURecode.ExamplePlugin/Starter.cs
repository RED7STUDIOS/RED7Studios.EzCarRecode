using RED7Studios.ECMURecode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.ECMURecode.ExamplePlugin
{
    public class Starter : PluginImplementer
    {
        public string PluginName()
        {
            return "Example Plugin";
        }

        public string PluginVersion()
        {
            return "1.0.0.0";
        }

        public string PluginAuthor()
        {
            return "ECMU Authors";
        }

        public string PluginDescription()
        {
            return "Example Plugin testing.";
        }

        public void ButtonAdder(Button btn)
        {
            btn.Click += button_Click;
        }

        public void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!");
        }
    }
}

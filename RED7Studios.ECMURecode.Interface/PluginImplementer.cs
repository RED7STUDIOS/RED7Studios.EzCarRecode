using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RED7Studios.ECMURecode.Interface
{
    public interface PluginImplementer
    {
        string PluginName();
        string PluginVersion();
        string PluginAuthor();
        string PluginDescription();
        void ButtonAdder(Button btn);
    }
}

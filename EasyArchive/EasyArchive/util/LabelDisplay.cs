using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyArchive.util
{
    class LabelDisplay : ITextDisplay
    {
        private ToolStripStatusLabel _label;
        public LabelDisplay(ToolStripStatusLabel label)
        {
            _label = label;
        }
        public void Show(string message)
        {
            _label.Text = message;
        }
    }
}

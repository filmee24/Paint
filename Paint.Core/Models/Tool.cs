using System.Drawing;
using ICSharpCode.Core;

namespace Paint.Core
{
    public class Tool
    {
        public string ToolTipText { get; set; }
        public Image Image { get; set; }
        public AbstractCommand Command { get; set; }
    }
}
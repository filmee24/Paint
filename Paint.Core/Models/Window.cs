using System.Windows.Forms;

namespace Paint.Core.Models
{
    public class Window
    {
        public string Title { get; set; }
        public string DockPosition { get; set; }
        public Control ContainerControl { get; set; }
    }
}
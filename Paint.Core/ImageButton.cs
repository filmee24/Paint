using System;
using System.Windows.Forms;

namespace Paint.Core
{
    public class ImageButton : PictureBox
    {
        public string ToolTipText { get; set; }

        private ToolTip _tooltip = new ToolTip();

        public ImageButton()
        {
            SizeMode = PictureBoxSizeMode.Zoom;

            Cursor = Cursors.Hand;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;

            if (ToolTipText != null)
            {
                _tooltip.Show(ToolTipText, this);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }
    }
}
using System;
using System.Windows.Forms;

namespace Paint.Core
{
    public class ImageButton : PictureBox
    {
        public ImageButton()
        {
            SizeMode = PictureBoxSizeMode.Zoom;

            Cursor = Cursors.Hand;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }
    }
}
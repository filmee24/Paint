using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Paint.Core
{
    public class DialogBuilder
    {
        private Dictionary<string, Control> _controls = new Dictionary<string, Control>();

        public DialogBuilder AddTextBox(string caption, string text)
        {
            var tb = new RadTextBox();
            tb.ThemeName = ThemeResolutionService.ApplicationThemeName;
            tb.Text = text;
            tb.Name = text;
            tb.Dock = DockStyle.Fill;

            _controls.Add(caption, tb);

            return this;
        }

        public RadForm Build(string title)
        {
            var frm = new RadForm();
            var tableLayoutPanel1 = new TableLayoutPanel();

            frm.Text = title;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.ShowIcon = false;
            frm.ShowInTaskbar = false;
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.AutoSize = true;
            frm.AutoSizeMode = AutoSizeMode.GrowOnly;

            var btnCancel = new RadButton();
            btnCancel.ThemeName = ThemeResolutionService.ApplicationThemeName;

            btnCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.Dock = DockStyle.Right;

            var btnOk = new RadButton();
            btnOk.ThemeName = ThemeResolutionService.ApplicationThemeName;

            btnOk.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.Dock = DockStyle.Right;

            tableLayoutPanel1.RowCount = _controls.Count;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Dock = DockStyle.Fill;

            for (int i = 0; i < _controls.Count; i++)
            {
                var c = _controls.Values.ToArray()[i];
                var label = CreateLabel(_controls.Keys.ToArray()[i]);

                tableLayoutPanel1.Controls.Add(label, 0, i);
                tableLayoutPanel1.Controls.Add(c, 1, i);
            }

            frm.Width = tableLayoutPanel1.Width + 40;
            frm.Height = tableLayoutPanel1.Height + 90;

            var p = new Panel();
            p.Dock = DockStyle.Bottom;
            p.Size = new System.Drawing.Size(75, 23);

            p.Controls.Add(btnCancel);
            p.Controls.Add(btnOk);

            frm.Controls.Add(p);
            var sp = new RadScrollablePanel();
            sp.Dock = DockStyle.Fill;
            sp.AutoScroll = true;

            sp.Controls.Add(tableLayoutPanel1);
            frm.Controls.Add(sp);

            return frm;
        }

        internal static Label CreateLabel(string text)
        {
            var label = new Label();
            label.Text = text + ":";
            label.AutoSize = true;
            label.Margin = new Padding(3, 6, 6, 0);
            return label;
        }
    }
}
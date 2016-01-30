using Creek.UI.QuickMouse;
using Paint.Core;
using Paint.Properties;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System;

namespace Paint
{
    public partial class MainWindow : Telerik.WinControls.UI.RadForm
    {
        public MainWindow()
        {
            InitializeComponent();

            // Initialize the Colordialog
            radColorDialog1.Icon = this.Icon;
            (radColorDialog1.ColorDialogForm as RadColorDialogForm).ThemeName = this.ThemeName;
            radColorDialog1.ColorDialogForm.AllowColorPickFromScreen = false;

            ThemeResolutionService.ApplicationThemeName = this.ThemeName;

            pictureBox1.MouseClick += (s, e) =>
            {
                var qm = new QuickMouseMenu();

                qm.AddQuickMouseMenuItem(Resources.GIMP_Toolbox_GEGLOperationTool_Icon, "GEGL");
                qm.AddQuickMouseMenuItem(Resources.GIMP_Toolbox_MeasureTool_Icon, "GEGL");
                qm.AddQuickMouseMenuItem(Resources.GIMP_Toolbox_SelectionForeground_Icon, "GEGL");
                qm.AddQuickMouseMenuItem(Resources.GIMP_Toolbox_TransformShear_Icon, "GEGL");
                qm.AddQuickMouseMenuItem(Resources.GIMP_Toolbox_TransformMove_Icon, "GEGL");
                qm.AddQuickMouseMenuItem(Resources.GIMP_Toolbox_TextTool_Icon, "GEGL");

                qm.QuickMenuItemClicked += (se, ee) =>
                {
                    MessageBox.Show(((QuickMouseMenuItem)se).Caption);
                };

                qm.ShowMenu(e.Location);
            };
        }

        internal void OpenImage(string v)
        {
            dock.AddDocument(new Telerik.WinControls.UI.Docking.DocumentWindow { Text = v });
        }

        void newMenuItem_Click(object sender, EventArgs e)
        {

        }

        void firstColorPreviewBtn_Click(object sender, EventArgs e)
        {
            radColorDialog1.SelectedColor = firstColorPreviewBtn.BackColor;
            if (radColorDialog1.ShowDialog() == DialogResult.OK)
            {
                firstColorPreviewBtn.BackColor = radColorDialog1.SelectedColor;
            }
        }

        void secondColorPreviewBtn_Click(object sender, EventArgs e)
        {
            radColorDialog1.SelectedColor = secondColorPreviewBtn.BackColor;
            if (radColorDialog1.ShowDialog() == DialogResult.OK)
            {
                secondColorPreviewBtn.BackColor = radColorDialog1.SelectedColor;
            }
        }

        void defaultColorsBtn_Click(object sender, EventArgs e)
        {
            firstColorPreviewBtn.BackColor = System.Drawing.Color.Black;
            secondColorPreviewBtn.BackColor = System.Drawing.Color.White;
        }

        void switchColorsBtn_Click(object sender, EventArgs e)
        {
            var first = firstColorPreviewBtn.BackColor;

            firstColorPreviewBtn.BackColor = secondColorPreviewBtn.BackColor;
            secondColorPreviewBtn.BackColor = first;
        }

        void imageButton2_Click(object sender, EventArgs e)
        {
            var db = new DialogBuilder();

            db.AddTextBox("Name", "default value");
            db.AddTextBox("Name2", "default value");
            db.AddTextBox("Name3", "default value");
            db.AddTextBox("Name4", "default value");
            db.AddTextBox("Name5", "default value");
            db.AddTextBox("Name6", "default value");

            var d = db.Build("Test Dialog");

            if (d.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void loadMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenImage(openFileDialog1.FileName);
            }
        }
    }
}
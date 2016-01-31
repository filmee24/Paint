using Paint.Core;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System;
using AppLoadingMT;
using ICSharpCode.Core;

namespace Paint
{
    public partial class Workbench : Telerik.WinControls.UI.RadForm
    {
        #region Singleton implementation
        static Workbench instance;

        public static Workbench Instance
        {
            get
            {
                return instance;
            }
        }

        public static void InitializeWorkbench()
        {
            instance = new Workbench();
        }
        #endregion

        public Workbench()
        {
            InitializeComponent();

            // Initialize the Colordialog
            radColorDialog1.Icon = Icon;
            (radColorDialog1.ColorDialogForm as RadColorDialogForm).ThemeName = ThemeName;
            radColorDialog1.ColorDialogForm.AllowColorPickFromScreen = false;

            ThemeResolutionService.ApplicationThemeName = ThemeName;

            //var menu = new MenuStrip();
            //MenuService.AddItemsToMenu(menu.Items, this, "/Workbench/MainMenu");
            //Controls.Add(menu);

            /*pictureBox1.MouseClick += (s, e) =>
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
            */
        }

        public void OpenImage(string v)
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

        private void Workbench_FormClosing(object sender, FormClosingEventArgs e)
        {
            Splasher.Close();
            Environment.Exit(0);
        }
    }
}
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Paint
{
    partial class Workbench
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workbench));
            this.dock = new Telerik.WinControls.UI.Docking.RadDock();
            this.layersWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.layersList = new Telerik.WinControls.UI.RadListControl();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip8 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.toolsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pencilToolButton = new Paint.Core.ImageButton();
            this.textToolButton = new Paint.Core.ImageButton();
            this.moveToolButton = new Paint.Core.ImageButton();
            this.mirrorToolButton = new Paint.Core.ImageButton();
            this.perspektiveToolButton = new Paint.Core.ImageButton();
            this.brushToolButton = new Paint.Core.ImageButton();
            this.anchorToolButton = new Paint.Core.ImageButton();
            this.rotateToolButton = new Paint.Core.ImageButton();
            this.resizeToolButton = new Paint.Core.ImageButton();
            this.magicSelectorToolButton = new Paint.Core.ImageButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.colorContainer = new Telerik.WinControls.UI.RadPanel();
            this.firstColorPreviewBtn = new System.Windows.Forms.PictureBox();
            this.switchColorsBtn = new System.Windows.Forms.PictureBox();
            this.secondColorPreviewBtn = new System.Windows.Forms.PictureBox();
            this.defaultColorsBtn = new System.Windows.Forms.PictureBox();
            this.toolTabStrip9 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.settingsWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.toolTabStrip7 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.fileMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.newMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.loadMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.saveMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.exportMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolTabStrip3 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.dockWindowPlaceholder1 = new Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
            this.toolTabStrip4 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.dockWindowPlaceholder2 = new Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radColorDialog1 = new Telerik.WinControls.RadColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dock)).BeginInit();
            this.dock.SuspendLayout();
            this.layersWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip8)).BeginInit();
            this.toolTabStrip8.SuspendLayout();
            this.toolWindow.SuspendLayout();
            this.toolsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pencilToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perspektiveToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchorToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicSelectorToolButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorContainer)).BeginInit();
            this.colorContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstColorPreviewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchColorsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondColorPreviewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultColorsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip9)).BeginInit();
            this.toolTabStrip9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip7)).BeginInit();
            this.toolTabStrip7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dock
            // 
            this.dock.ActiveWindow = this.layersWindow;
            this.dock.CausesValidation = false;
            this.dock.Controls.Add(this.radSplitContainer1);
            this.dock.Controls.Add(this.documentContainer1);
            this.dock.Controls.Add(this.toolTabStrip7);
            this.dock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dock.IsCleanUpTarget = true;
            this.dock.Location = new System.Drawing.Point(0, 20);
            this.dock.MainDocumentContainer = this.documentContainer1;
            this.dock.Name = "dock";
            this.dock.Padding = new System.Windows.Forms.Padding(0);
            this.dock.Size = new System.Drawing.Size(908, 394);
            this.dock.SplitterWidth = 2;
            this.dock.TabIndex = 0;
            this.dock.TabStop = false;
            this.dock.Text = "radDock1";
            this.dock.ThemeName = "Windows8";
            // 
            // layersWindow
            // 
            this.layersWindow.Caption = null;
            this.layersWindow.Controls.Add(this.layersList);
            this.layersWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.layersWindow.Location = new System.Drawing.Point(4, 27);
            this.layersWindow.Name = "layersWindow";
            this.layersWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.layersWindow.Size = new System.Drawing.Size(192, 363);
            this.layersWindow.Text = "Ebenen";
            // 
            // layersList
            // 
            this.layersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layersList.Location = new System.Drawing.Point(0, 0);
            this.layersList.Name = "layersList";
            this.layersList.Size = new System.Drawing.Size(192, 363);
            this.layersList.TabIndex = 0;
            this.layersList.ThemeName = "Windows8";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.CausesValidation = false;
            this.radSplitContainer1.Controls.Add(this.toolTabStrip8);
            this.radSplitContainer1.Controls.Add(this.toolTabStrip9);
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radSplitContainer1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer1.Size = new System.Drawing.Size(186, 394);
            this.radSplitContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(186, 200);
            this.radSplitContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-14, 0);
            this.radSplitContainer1.SplitterWidth = 2;
            this.radSplitContainer1.TabIndex = 7;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "Windows8";
            // 
            // toolTabStrip8
            // 
            this.toolTabStrip8.CanUpdateChildIndex = true;
            this.toolTabStrip8.CausesValidation = false;
            this.toolTabStrip8.Controls.Add(this.toolWindow);
            this.toolTabStrip8.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip8.Name = "toolTabStrip8";
            // 
            // 
            // 
            this.toolTabStrip8.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip8.SelectedIndex = 0;
            this.toolTabStrip8.Size = new System.Drawing.Size(186, 210);
            this.toolTabStrip8.SizeInfo.AbsoluteSize = new System.Drawing.Size(186, 200);
            this.toolTabStrip8.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.03508772F);
            this.toolTabStrip8.SizeInfo.SplitterCorrection = new System.Drawing.Size(-14, 12);
            this.toolTabStrip8.TabIndex = 4;
            this.toolTabStrip8.TabStop = false;
            this.toolTabStrip8.ThemeName = "Windows8";
            // 
            // toolWindow
            // 
            this.toolWindow.Caption = null;
            this.toolWindow.Controls.Add(this.toolsLayout);
            this.toolWindow.Controls.Add(this.radPanel1);
            this.toolWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.toolWindow.Location = new System.Drawing.Point(4, 27);
            this.toolWindow.Name = "toolWindow";
            this.toolWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.toolWindow.Size = new System.Drawing.Size(178, 179);
            this.toolWindow.Text = "Werkzeuge";
            // 
            // toolsLayout
            // 
            this.toolsLayout.AutoScroll = true;
            this.toolsLayout.Controls.Add(this.pencilToolButton);
            this.toolsLayout.Controls.Add(this.textToolButton);
            this.toolsLayout.Controls.Add(this.moveToolButton);
            this.toolsLayout.Controls.Add(this.mirrorToolButton);
            this.toolsLayout.Controls.Add(this.perspektiveToolButton);
            this.toolsLayout.Controls.Add(this.brushToolButton);
            this.toolsLayout.Controls.Add(this.anchorToolButton);
            this.toolsLayout.Controls.Add(this.rotateToolButton);
            this.toolsLayout.Controls.Add(this.resizeToolButton);
            this.toolsLayout.Controls.Add(this.magicSelectorToolButton);
            this.toolsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsLayout.Location = new System.Drawing.Point(0, 0);
            this.toolsLayout.Name = "toolsLayout";
            this.toolsLayout.Size = new System.Drawing.Size(178, 106);
            this.toolsLayout.TabIndex = 2;
            // 
            // pencilToolButton
            // 
            this.pencilToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pencilToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_BrushPencil_Icon;
            this.pencilToolButton.Location = new System.Drawing.Point(3, 3);
            this.pencilToolButton.Name = "pencilToolButton";
            this.pencilToolButton.Size = new System.Drawing.Size(24, 24);
            this.pencilToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pencilToolButton.TabIndex = 0;
            this.pencilToolButton.TabStop = false;
            this.pencilToolButton.ToolTipText = "Stift";
            // 
            // textToolButton
            // 
            this.textToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_TextTool_Icon;
            this.textToolButton.Location = new System.Drawing.Point(33, 3);
            this.textToolButton.Name = "textToolButton";
            this.textToolButton.Size = new System.Drawing.Size(24, 24);
            this.textToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.textToolButton.TabIndex = 1;
            this.textToolButton.TabStop = false;
            this.textToolButton.ToolTipText = "Text";
            this.textToolButton.Click += new System.EventHandler(this.imageButton2_Click);
            // 
            // moveToolButton
            // 
            this.moveToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_TransformMove_Icon;
            this.moveToolButton.Location = new System.Drawing.Point(63, 3);
            this.moveToolButton.Name = "moveToolButton";
            this.moveToolButton.Size = new System.Drawing.Size(24, 24);
            this.moveToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moveToolButton.TabIndex = 2;
            this.moveToolButton.TabStop = false;
            this.moveToolButton.ToolTipText = "Verschieben";
            // 
            // mirrorToolButton
            // 
            this.mirrorToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mirrorToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_TransformFlip_Icon;
            this.mirrorToolButton.Location = new System.Drawing.Point(93, 3);
            this.mirrorToolButton.Name = "mirrorToolButton";
            this.mirrorToolButton.Size = new System.Drawing.Size(24, 24);
            this.mirrorToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mirrorToolButton.TabIndex = 3;
            this.mirrorToolButton.TabStop = false;
            this.mirrorToolButton.ToolTipText = "Spiegeln";
            // 
            // perspektiveToolButton
            // 
            this.perspektiveToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.perspektiveToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_TransformPerspective_Icon;
            this.perspektiveToolButton.Location = new System.Drawing.Point(123, 3);
            this.perspektiveToolButton.Name = "perspektiveToolButton";
            this.perspektiveToolButton.Size = new System.Drawing.Size(24, 24);
            this.perspektiveToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.perspektiveToolButton.TabIndex = 4;
            this.perspektiveToolButton.TabStop = false;
            this.perspektiveToolButton.ToolTipText = "Perspektive";
            // 
            // brushToolButton
            // 
            this.brushToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brushToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_BrushAirbrush_Icon;
            this.brushToolButton.Location = new System.Drawing.Point(3, 33);
            this.brushToolButton.Name = "brushToolButton";
            this.brushToolButton.Size = new System.Drawing.Size(24, 24);
            this.brushToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brushToolButton.TabIndex = 5;
            this.brushToolButton.TabStop = false;
            this.brushToolButton.ToolTipText = "Sprüher";
            // 
            // anchorToolButton
            // 
            this.anchorToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anchorToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_TransformAlign_Icon;
            this.anchorToolButton.Location = new System.Drawing.Point(33, 33);
            this.anchorToolButton.Name = "anchorToolButton";
            this.anchorToolButton.Size = new System.Drawing.Size(24, 24);
            this.anchorToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anchorToolButton.TabIndex = 6;
            this.anchorToolButton.TabStop = false;
            this.anchorToolButton.ToolTipText = "Ausrichten";
            // 
            // rotateToolButton
            // 
            this.rotateToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rotateToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_TransformRotate_Icon;
            this.rotateToolButton.Location = new System.Drawing.Point(63, 33);
            this.rotateToolButton.Name = "rotateToolButton";
            this.rotateToolButton.Size = new System.Drawing.Size(24, 24);
            this.rotateToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rotateToolButton.TabIndex = 7;
            this.rotateToolButton.TabStop = false;
            this.rotateToolButton.ToolTipText = "Drehen";
            // 
            // resizeToolButton
            // 
            this.resizeToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resizeToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_TransformScale_Icon;
            this.resizeToolButton.Location = new System.Drawing.Point(93, 33);
            this.resizeToolButton.Name = "resizeToolButton";
            this.resizeToolButton.Size = new System.Drawing.Size(24, 24);
            this.resizeToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resizeToolButton.TabIndex = 8;
            this.resizeToolButton.TabStop = false;
            this.resizeToolButton.ToolTipText = "Skalieren";
            // 
            // magicSelectorToolButton
            // 
            this.magicSelectorToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicSelectorToolButton.Image = global::Base.Properties.Resources.GIMP_Toolbox_SelectionWand_Icon;
            this.magicSelectorToolButton.Location = new System.Drawing.Point(123, 33);
            this.magicSelectorToolButton.Name = "magicSelectorToolButton";
            this.magicSelectorToolButton.Size = new System.Drawing.Size(24, 24);
            this.magicSelectorToolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magicSelectorToolButton.TabIndex = 9;
            this.magicSelectorToolButton.TabStop = false;
            this.magicSelectorToolButton.ToolTipText = "Zauberstab";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.colorContainer);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 106);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(178, 73);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "Windows8";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // colorContainer
            // 
            this.colorContainer.Controls.Add(this.firstColorPreviewBtn);
            this.colorContainer.Controls.Add(this.switchColorsBtn);
            this.colorContainer.Controls.Add(this.secondColorPreviewBtn);
            this.colorContainer.Controls.Add(this.defaultColorsBtn);
            this.colorContainer.Location = new System.Drawing.Point(47, 7);
            this.colorContainer.Name = "colorContainer";
            this.colorContainer.Size = new System.Drawing.Size(64, 59);
            this.colorContainer.TabIndex = 2;
            this.colorContainer.ThemeName = "Windows8";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.colorContainer.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.colorContainer.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // firstColorPreviewBtn
            // 
            this.firstColorPreviewBtn.BackColor = System.Drawing.Color.Black;
            this.firstColorPreviewBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstColorPreviewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstColorPreviewBtn.Location = new System.Drawing.Point(6, 3);
            this.firstColorPreviewBtn.Name = "firstColorPreviewBtn";
            this.firstColorPreviewBtn.Size = new System.Drawing.Size(36, 36);
            this.firstColorPreviewBtn.TabIndex = 0;
            this.firstColorPreviewBtn.TabStop = false;
            this.firstColorPreviewBtn.Click += new System.EventHandler(this.firstColorPreviewBtn_Click);
            // 
            // switchColorsBtn
            // 
            this.switchColorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchColorsBtn.Image = global::Base.Properties.Resources.switchcolors;
            this.switchColorsBtn.Location = new System.Drawing.Point(45, 3);
            this.switchColorsBtn.Name = "switchColorsBtn";
            this.switchColorsBtn.Size = new System.Drawing.Size(16, 16);
            this.switchColorsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switchColorsBtn.TabIndex = 3;
            this.switchColorsBtn.TabStop = false;
            this.switchColorsBtn.Click += new System.EventHandler(this.switchColorsBtn_Click);
            // 
            // secondColorPreviewBtn
            // 
            this.secondColorPreviewBtn.BackColor = System.Drawing.Color.White;
            this.secondColorPreviewBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondColorPreviewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondColorPreviewBtn.Location = new System.Drawing.Point(24, 20);
            this.secondColorPreviewBtn.Name = "secondColorPreviewBtn";
            this.secondColorPreviewBtn.Size = new System.Drawing.Size(36, 36);
            this.secondColorPreviewBtn.TabIndex = 1;
            this.secondColorPreviewBtn.TabStop = false;
            this.secondColorPreviewBtn.Click += new System.EventHandler(this.secondColorPreviewBtn_Click);
            // 
            // defaultColorsBtn
            // 
            this.defaultColorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.defaultColorsBtn.Image = global::Base.Properties.Resources.standardcolors;
            this.defaultColorsBtn.Location = new System.Drawing.Point(6, 41);
            this.defaultColorsBtn.Name = "defaultColorsBtn";
            this.defaultColorsBtn.Size = new System.Drawing.Size(16, 16);
            this.defaultColorsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.defaultColorsBtn.TabIndex = 2;
            this.defaultColorsBtn.TabStop = false;
            this.defaultColorsBtn.Click += new System.EventHandler(this.defaultColorsBtn_Click);
            // 
            // toolTabStrip9
            // 
            this.toolTabStrip9.CanUpdateChildIndex = true;
            this.toolTabStrip9.CausesValidation = false;
            this.toolTabStrip9.Controls.Add(this.settingsWindow);
            this.toolTabStrip9.Location = new System.Drawing.Point(0, 212);
            this.toolTabStrip9.Name = "toolTabStrip9";
            // 
            // 
            // 
            this.toolTabStrip9.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip9.SelectedIndex = 0;
            this.toolTabStrip9.Size = new System.Drawing.Size(186, 182);
            this.toolTabStrip9.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.03508772F);
            this.toolTabStrip9.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -12);
            this.toolTabStrip9.TabIndex = 5;
            this.toolTabStrip9.TabStop = false;
            this.toolTabStrip9.ThemeName = "Windows8";
            // 
            // settingsWindow
            // 
            this.settingsWindow.Caption = null;
            this.settingsWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsWindow.Location = new System.Drawing.Point(4, 27);
            this.settingsWindow.Name = "settingsWindow";
            this.settingsWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.settingsWindow.Size = new System.Drawing.Size(178, 151);
            this.settingsWindow.Text = "Einstellungen";
            // 
            // documentContainer1
            // 
            this.documentContainer1.CausesValidation = false;
            this.documentContainer1.Name = "documentContainer1";
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(510, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(14, 0);
            this.documentContainer1.SplitterWidth = 2;
            this.documentContainer1.TabIndex = 5;
            this.documentContainer1.ThemeName = "Windows8";
            // 
            // toolTabStrip7
            // 
            this.toolTabStrip7.CanUpdateChildIndex = true;
            this.toolTabStrip7.Controls.Add(this.layersWindow);
            this.toolTabStrip7.Location = new System.Drawing.Point(708, 0);
            this.toolTabStrip7.Name = "toolTabStrip7";
            // 
            // 
            // 
            this.toolTabStrip7.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip7.SelectedIndex = 0;
            this.toolTabStrip7.Size = new System.Drawing.Size(200, 394);
            this.toolTabStrip7.TabIndex = 3;
            this.toolTabStrip7.TabStop = false;
            this.toolTabStrip7.ThemeName = "Windows8";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.AccessibleDescription = "Datei";
            this.fileMenuItem.AccessibleName = "Datei";
            this.fileMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.newMenuItem,
            this.loadMenuItem,
            this.saveMenuItem,
            this.exportMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Text = "Datei";
            // 
            // newMenuItem
            // 
            this.newMenuItem.AccessibleDescription = "Neu";
            this.newMenuItem.AccessibleName = "Neu";
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Text = "Neu";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.AccessibleDescription = "Laden";
            this.loadMenuItem.AccessibleName = "Laden";
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Text = "Laden";
            this.loadMenuItem.Click += new System.EventHandler(this.loadMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.AccessibleDescription = "Speichern";
            this.saveMenuItem.AccessibleName = "Speichern";
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Text = "Speichern";
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.AccessibleDescription = "Exportieren";
            this.exportMenuItem.AccessibleName = "Exportieren";
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.Text = "Exportieren";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Effekte";
            this.radMenuItem2.AccessibleName = "Effekte";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Effekte";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Einstellungen";
            this.radMenuItem3.AccessibleName = "Einstellungen";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Einstellungen";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "Hilfe";
            this.radMenuItem4.AccessibleName = "Hilfe";
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Hilfe";
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.CanUpdateChildIndex = true;
            this.toolTabStrip2.Location = new System.Drawing.Point(703, 5);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.Size = new System.Drawing.Size(200, 384);
            this.toolTabStrip2.TabIndex = 2;
            this.toolTabStrip2.TabStop = false;
            this.toolTabStrip2.ThemeName = "Windows8";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.CausesValidation = false;
            this.toolTabStrip1.Location = new System.Drawing.Point(5, 5);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.Size = new System.Drawing.Size(200, 384);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "Windows8";
            // 
            // toolTabStrip3
            // 
            this.toolTabStrip3.CanUpdateChildIndex = true;
            this.toolTabStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip3.Name = "toolTabStrip3";
            // 
            // 
            // 
            this.toolTabStrip3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip3.SelectedIndex = 0;
            this.toolTabStrip3.Size = new System.Drawing.Size(292, 270);
            this.toolTabStrip3.TabIndex = 0;
            this.toolTabStrip3.TabStop = false;
            // 
            // dockWindowPlaceholder1
            // 
            this.dockWindowPlaceholder1.DockWindowName = "toolWindow";
            this.dockWindowPlaceholder1.DockWindowText = "Werkzeuge";
            this.dockWindowPlaceholder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dockWindowPlaceholder1.Location = new System.Drawing.Point(0, 0);
            this.dockWindowPlaceholder1.Name = "dockWindowPlaceholder1";
            this.dockWindowPlaceholder1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.dockWindowPlaceholder1.Size = new System.Drawing.Size(284, 262);
            this.dockWindowPlaceholder1.Text = "dockWindowPlaceholder1";
            // 
            // toolTabStrip4
            // 
            this.toolTabStrip4.CanUpdateChildIndex = true;
            this.toolTabStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip4.Name = "toolTabStrip4";
            // 
            // 
            // 
            this.toolTabStrip4.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip4.SelectedIndex = 0;
            this.toolTabStrip4.Size = new System.Drawing.Size(292, 270);
            this.toolTabStrip4.TabIndex = 0;
            this.toolTabStrip4.TabStop = false;
            // 
            // dockWindowPlaceholder2
            // 
            this.dockWindowPlaceholder2.DockWindowName = "layersWindow";
            this.dockWindowPlaceholder2.DockWindowText = "Ebenen";
            this.dockWindowPlaceholder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dockWindowPlaceholder2.Location = new System.Drawing.Point(0, 0);
            this.dockWindowPlaceholder2.Name = "dockWindowPlaceholder2";
            this.dockWindowPlaceholder2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.dockWindowPlaceholder2.Size = new System.Drawing.Size(284, 262);
            this.dockWindowPlaceholder2.Text = "dockWindowPlaceholder2";
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.fileMenuItem,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(908, 20);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.Text = "radMenu1";
            // 
            // radColorDialog1
            // 
            this.radColorDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("radColorDialog1.Icon")));
            this.radColorDialog1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radColorDialog1.SelectedColor = System.Drawing.Color.Red;
            this.radColorDialog1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0D, 1D, 1D);
            // 
            // Workbench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 414);
            this.Controls.Add(this.dock);
            this.Controls.Add(this.radMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Workbench";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.ThemeName = "Windows8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Workbench_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dock)).EndInit();
            this.dock.ResumeLayout(false);
            this.layersWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip8)).EndInit();
            this.toolTabStrip8.ResumeLayout(false);
            this.toolWindow.ResumeLayout(false);
            this.toolsLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pencilToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perspektiveToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchorToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicSelectorToolButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorContainer)).EndInit();
            this.colorContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstColorPreviewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchColorsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondColorPreviewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultColorsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip9)).EndInit();
            this.toolTabStrip9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip7)).EndInit();
            this.toolTabStrip7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock dock;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow;
        private Telerik.WinControls.UI.Docking.ToolWindow layersWindow;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private RadMenuItem fileMenuItem;
        private RadMenuItem radMenuItem2;
        private RadMenuItem radMenuItem3;
        private RadMenuItem radMenuItem4;
        private RadMenu radMenu1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip3;
        private Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip4;
        private Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip7;
        private Telerik.WinControls.UI.RadListControl layersList;
        private Telerik.WinControls.UI.RadMenuItem newMenuItem;
        private Telerik.WinControls.UI.RadMenuItem loadMenuItem;
        private Telerik.WinControls.UI.RadMenuItem saveMenuItem;
        private Telerik.WinControls.UI.RadMenuItem exportMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.PictureBox firstColorPreviewBtn;
        private System.Windows.Forms.PictureBox secondColorPreviewBtn;
        private System.Windows.Forms.FlowLayoutPanel toolsLayout;
        private Core.ImageButton pencilToolButton;
        private System.Windows.Forms.PictureBox defaultColorsBtn;
        private Core.ImageButton textToolButton;
        private Core.ImageButton moveToolButton;
        private Core.ImageButton mirrorToolButton;
        private Core.ImageButton perspektiveToolButton;
        private Telerik.WinControls.RadColorDialog radColorDialog1;
        private System.Windows.Forms.PictureBox switchColorsBtn;
        private Telerik.WinControls.UI.RadPanel colorContainer;
        private Core.ImageButton brushToolButton;
        private Core.ImageButton anchorToolButton;
        private Core.ImageButton rotateToolButton;
        private Core.ImageButton resizeToolButton;
        private Core.ImageButton magicSelectorToolButton;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip8;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip9;
        private Telerik.WinControls.UI.Docking.ToolWindow settingsWindow;
    }
}

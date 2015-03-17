namespace XNALevelEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSep5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddObject = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.mainMouse = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainObjectLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.topSplitPanel = new System.Windows.Forms.SplitContainer();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.picEnvironment = new System.Windows.Forms.PictureBox();
            this.mnuContextPicEnv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEnvCutObject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnvCopyObject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnvPasteObject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnvSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEnvDeleteObject = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.tabRight = new System.Windows.Forms.TabControl();
            this.tabTiles = new System.Windows.Forms.TabPage();
            this.cmdObjectClear = new System.Windows.Forms.Button();
            this.cmdObjectDelete = new System.Windows.Forms.Button();
            this.lstObjects = new System.Windows.Forms.ListView();
            this.imgObjectList = new System.Windows.Forms.ImageList(this.components);
            this.tabEnvironment = new System.Windows.Forms.TabPage();
            this.cmdEnvrionmentOK = new System.Windows.Forms.Button();
            this.cmdEnvironmentRemoveOutsideObjects = new System.Windows.Forms.Button();
            this.txtEnvrionmentEnvH = new System.Windows.Forms.TextBox();
            this.txtEnvrionmentEnvW = new System.Windows.Forms.TextBox();
            this.txtEnvrionmentGridH = new System.Windows.Forms.TextBox();
            this.txtEnvrionmentGridW = new System.Windows.Forms.TextBox();
            this.lblEnvrionmentEnvH = new System.Windows.Forms.Label();
            this.lblEnvrionmentEnvW = new System.Windows.Forms.Label();
            this.lblEnvrionmentEnv = new System.Windows.Forms.Label();
            this.picEnvrionmentGridColor = new System.Windows.Forms.PictureBox();
            this.lblEnvrionmentGridColor = new System.Windows.Forms.Label();
            this.picEnvironmentBackground = new System.Windows.Forms.PictureBox();
            this.lblEnvrionmentBackground = new System.Windows.Forms.Label();
            this.lblEnvrionmentGridH = new System.Windows.Forms.Label();
            this.lblEnvrionmentGridW = new System.Windows.Forms.Label();
            this.lblEnvrionmentGrid = new System.Windows.Forms.Label();
            this.imgGraphicRes = new System.Windows.Forms.ImageList(this.components);
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.cmdLeftPanelTool1 = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.topPanel = new System.Windows.Forms.Panel();
            this.mnuMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.topSplitPanel.Panel1.SuspendLayout();
            this.topSplitPanel.Panel2.SuspendLayout();
            this.topSplitPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnvironment)).BeginInit();
            this.mnuContextPicEnv.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.tabRight.SuspendLayout();
            this.tabTiles.SuspendLayout();
            this.tabEnvironment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnvrionmentGridColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnvironmentBackground)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.editToolStripMenuItem,
            this.mnuObject});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(834, 31);
            this.mnuMain.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.AutoSize = false;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Padding = new System.Windows.Forms.Padding(4);
            this.mnuFile.Size = new System.Drawing.Size(37, 27);
            this.mnuFile.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopy,
            this.mnuPaste,
            this.mnuSep5,
            this.mnuDelete,
            this.mnuDeleteAll});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 27);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy.Size = new System.Drawing.Size(152, 22);
            this.mnuCopy.Text = "C&opy";
            this.mnuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuPaste.Size = new System.Drawing.Size(152, 22);
            this.mnuPaste.Text = "&Paste";
            this.mnuPaste.Click += new System.EventHandler(this.menuPaste_Click);
            // 
            // mnuSep5
            // 
            this.mnuSep5.Name = "mnuSep5";
            this.mnuSep5.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuDelete.Size = new System.Drawing.Size(152, 22);
            this.mnuDelete.Text = "&Delete";
            this.mnuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // mnuDeleteAll
            // 
            this.mnuDeleteAll.Name = "mnuDeleteAll";
            this.mnuDeleteAll.Size = new System.Drawing.Size(152, 22);
            this.mnuDeleteAll.Text = "Delete &All";
            this.mnuDeleteAll.Click += new System.EventHandler(this.menuDeleteAll_Click);
            // 
            // mnuObject
            // 
            this.mnuObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddObject});
            this.mnuObject.Name = "mnuObject";
            this.mnuObject.Padding = new System.Windows.Forms.Padding(4);
            this.mnuObject.Size = new System.Drawing.Size(78, 27);
            this.mnuObject.Text = "&Object/Tile";
            // 
            // mnuAddObject
            // 
            this.mnuAddObject.Name = "mnuAddObject";
            this.mnuAddObject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAddObject.Size = new System.Drawing.Size(152, 22);
            this.mnuAddObject.Text = "&Add...";
            this.mnuAddObject.Click += new System.EventHandler(this.menuAddObject_Click);
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMouse,
            this.mainObjectLabel});
            this.stsMain.Location = new System.Drawing.Point(0, 534);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(834, 28);
            this.stsMain.TabIndex = 1;
            // 
            // mainMouse
            // 
            this.mainMouse.Name = "mainMouse";
            this.mainMouse.Padding = new System.Windows.Forms.Padding(4);
            this.mainMouse.Size = new System.Drawing.Size(409, 23);
            this.mainMouse.Spring = true;
            this.mainMouse.Text = "Mouse: X = 0, Y = 0";
            // 
            // mainObjectLabel
            // 
            this.mainObjectLabel.Name = "mainObjectLabel";
            this.mainObjectLabel.Padding = new System.Windows.Forms.Padding(4);
            this.mainObjectLabel.Size = new System.Drawing.Size(409, 23);
            this.mainObjectLabel.Spring = true;
            this.mainObjectLabel.Text = "Object: X = 0, Y = 0";
            // 
            // topSplitPanel
            // 
            this.topSplitPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topSplitPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.topSplitPanel.Location = new System.Drawing.Point(43, 73);
            this.topSplitPanel.Name = "topSplitPanel";
            // 
            // topSplitPanel.Panel1
            // 
            this.topSplitPanel.Panel1.Controls.Add(this.mainPanel);
            // 
            // topSplitPanel.Panel2
            // 
            this.topSplitPanel.Panel2.Controls.Add(this.pnlRight);
            this.topSplitPanel.Size = new System.Drawing.Size(787, 345);
            this.topSplitPanel.SplitterDistance = 575;
            this.topSplitPanel.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.picEnvironment);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(575, 345);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // picEnvironment
            // 
            this.picEnvironment.BackColor = System.Drawing.Color.White;
            this.picEnvironment.ContextMenuStrip = this.mnuContextPicEnv;
            this.picEnvironment.Location = new System.Drawing.Point(-21, -54);
            this.picEnvironment.Name = "picEnvironment";
            this.picEnvironment.Size = new System.Drawing.Size(591, 453);
            this.picEnvironment.TabIndex = 0;
            this.picEnvironment.TabStop = false;
            this.picEnvironment.Paint += new System.Windows.Forms.PaintEventHandler(this.picEnvironment_Paint);
            this.picEnvironment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picEnvironment_MouseDown);
            this.picEnvironment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picEnvironment_MouseMove);
            this.picEnvironment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picEnvironment_MouseUp);
            // 
            // mnuContextPicEnv
            // 
            this.mnuContextPicEnv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnvCutObject,
            this.mnuEnvCopyObject,
            this.mnuEnvPasteObject,
            this.mnuEnvSep1,
            this.mnuEnvDeleteObject});
            this.mnuContextPicEnv.Name = "mnuContextPicEnv";
            this.mnuContextPicEnv.Size = new System.Drawing.Size(145, 98);
            // 
            // mnuEnvCutObject
            // 
            this.mnuEnvCutObject.Name = "mnuEnvCutObject";
            this.mnuEnvCutObject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuEnvCutObject.Size = new System.Drawing.Size(144, 22);
            this.mnuEnvCutObject.Text = "&Cut";
            this.mnuEnvCutObject.Click += new System.EventHandler(this.environmentMenuCutObject_Click);
            // 
            // mnuEnvCopyObject
            // 
            this.mnuEnvCopyObject.Name = "mnuEnvCopyObject";
            this.mnuEnvCopyObject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuEnvCopyObject.Size = new System.Drawing.Size(144, 22);
            this.mnuEnvCopyObject.Text = "C&opy";
            this.mnuEnvCopyObject.Click += new System.EventHandler(this.environmentMenuCopyObject_Click);
            // 
            // mnuEnvPasteObject
            // 
            this.mnuEnvPasteObject.Name = "mnuEnvPasteObject";
            this.mnuEnvPasteObject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuEnvPasteObject.Size = new System.Drawing.Size(144, 22);
            this.mnuEnvPasteObject.Text = "&Paste";
            this.mnuEnvPasteObject.Click += new System.EventHandler(this.environmentMenuPasteObject_Click);
            // 
            // mnuEnvSep1
            // 
            this.mnuEnvSep1.Name = "mnuEnvSep1";
            this.mnuEnvSep1.Size = new System.Drawing.Size(141, 6);
            // 
            // mnuEnvDeleteObject
            // 
            this.mnuEnvDeleteObject.Name = "mnuEnvDeleteObject";
            this.mnuEnvDeleteObject.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuEnvDeleteObject.Size = new System.Drawing.Size(144, 22);
            this.mnuEnvDeleteObject.Text = "&Delete";
            this.mnuEnvDeleteObject.Click += new System.EventHandler(this.environmentMenuDeleteObject_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRight.Controls.Add(this.tabRight);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(208, 345);
            this.pnlRight.TabIndex = 5;
            // 
            // tabRight
            // 
            this.tabRight.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabRight.Controls.Add(this.tabTiles);
            this.tabRight.Controls.Add(this.tabEnvironment);
            this.tabRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRight.Location = new System.Drawing.Point(0, 0);
            this.tabRight.Multiline = true;
            this.tabRight.Name = "tabRight";
            this.tabRight.SelectedIndex = 0;
            this.tabRight.Size = new System.Drawing.Size(204, 341);
            this.tabRight.TabIndex = 0;
            // 
            // tabTiles
            // 
            this.tabTiles.Controls.Add(this.cmdObjectClear);
            this.tabTiles.Controls.Add(this.cmdObjectDelete);
            this.tabTiles.Controls.Add(this.lstObjects);
            this.tabTiles.Location = new System.Drawing.Point(4, 4);
            this.tabTiles.Name = "tabTiles";
            this.tabTiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabTiles.Size = new System.Drawing.Size(176, 333);
            this.tabTiles.TabIndex = 1;
            this.tabTiles.Text = "Tiles";
            this.tabTiles.UseVisualStyleBackColor = true;
            // 
            // cmdObjectClear
            // 
            this.cmdObjectClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdObjectClear.Location = new System.Drawing.Point(59, 306);
            this.cmdObjectClear.Name = "cmdObjectClear";
            this.cmdObjectClear.Size = new System.Drawing.Size(54, 25);
            this.cmdObjectClear.TabIndex = 9;
            this.cmdObjectClear.Text = "Clear";
            this.cmdObjectClear.UseVisualStyleBackColor = true;
            this.cmdObjectClear.Click += new System.EventHandler(this.cmdObjectClear_Click);
            // 
            // cmdObjectDelete
            // 
            this.cmdObjectDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdObjectDelete.Location = new System.Drawing.Point(6, 306);
            this.cmdObjectDelete.Name = "cmdObjectDelete";
            this.cmdObjectDelete.Size = new System.Drawing.Size(47, 25);
            this.cmdObjectDelete.TabIndex = 8;
            this.cmdObjectDelete.Text = "Delete";
            this.cmdObjectDelete.UseVisualStyleBackColor = true;
            this.cmdObjectDelete.Click += new System.EventHandler(this.cmdObjectDelete_Click);
            // 
            // lstObjects
            // 
            this.lstObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstObjects.HideSelection = false;
            this.lstObjects.LargeImageList = this.imgObjectList;
            this.lstObjects.Location = new System.Drawing.Point(3, 3);
            this.lstObjects.MultiSelect = false;
            this.lstObjects.Name = "lstObjects";
            this.lstObjects.Size = new System.Drawing.Size(167, 300);
            this.lstObjects.SmallImageList = this.imgObjectList;
            this.lstObjects.TabIndex = 6;
            this.lstObjects.UseCompatibleStateImageBehavior = false;
            this.lstObjects.SelectedIndexChanged += new System.EventHandler(this.lstObjects_SelectedIndexChanged);
            // 
            // imgObjectList
            // 
            this.imgObjectList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgObjectList.ImageSize = new System.Drawing.Size(64, 64);
            this.imgObjectList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabEnvironment
            // 
            this.tabEnvironment.Controls.Add(this.cmdEnvrionmentOK);
            this.tabEnvironment.Controls.Add(this.cmdEnvironmentRemoveOutsideObjects);
            this.tabEnvironment.Controls.Add(this.txtEnvrionmentEnvH);
            this.tabEnvironment.Controls.Add(this.txtEnvrionmentEnvW);
            this.tabEnvironment.Controls.Add(this.txtEnvrionmentGridH);
            this.tabEnvironment.Controls.Add(this.txtEnvrionmentGridW);
            this.tabEnvironment.Controls.Add(this.lblEnvrionmentEnvH);
            this.tabEnvironment.Controls.Add(this.lblEnvrionmentEnvW);
            this.tabEnvironment.Controls.Add(this.lblEnvrionmentEnv);
            this.tabEnvironment.Controls.Add(this.picEnvrionmentGridColor);
            this.tabEnvironment.Controls.Add(this.lblEnvrionmentGridColor);
            this.tabEnvironment.Controls.Add(this.picEnvironmentBackground);
            this.tabEnvironment.Controls.Add(this.lblEnvrionmentBackground);
            this.tabEnvironment.Controls.Add(this.lblEnvrionmentGridH);
            this.tabEnvironment.Controls.Add(this.lblEnvrionmentGridW);
            this.tabEnvironment.Controls.Add(this.lblEnvrionmentGrid);
            this.tabEnvironment.Location = new System.Drawing.Point(4, 4);
            this.tabEnvironment.Name = "tabEnvironment";
            this.tabEnvironment.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnvironment.Size = new System.Drawing.Size(177, 333);
            this.tabEnvironment.TabIndex = 2;
            this.tabEnvironment.Text = "Environment";
            this.tabEnvironment.UseVisualStyleBackColor = true;
            // 
            // cmdEnvrionmentOK
            // 
            this.cmdEnvrionmentOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdEnvrionmentOK.Location = new System.Drawing.Point(11, 293);
            this.cmdEnvrionmentOK.Name = "cmdEnvrionmentOK";
            this.cmdEnvrionmentOK.Size = new System.Drawing.Size(72, 25);
            this.cmdEnvrionmentOK.TabIndex = 7;
            this.cmdEnvrionmentOK.Text = "OK";
            this.cmdEnvrionmentOK.UseVisualStyleBackColor = true;
            this.cmdEnvrionmentOK.Click += new System.EventHandler(this.cmdEnvrionmentOK_Click);
            // 
            // cmdEnvironmentRemoveOutsideObjects
            // 
            this.cmdEnvironmentRemoveOutsideObjects.Location = new System.Drawing.Point(11, 186);
            this.cmdEnvironmentRemoveOutsideObjects.Name = "cmdEnvironmentRemoveOutsideObjects";
            this.cmdEnvironmentRemoveOutsideObjects.Size = new System.Drawing.Size(150, 23);
            this.cmdEnvironmentRemoveOutsideObjects.TabIndex = 15;
            this.cmdEnvironmentRemoveOutsideObjects.Text = "Delete Objects/Tiles";
            this.cmdEnvironmentRemoveOutsideObjects.UseVisualStyleBackColor = true;
            this.cmdEnvironmentRemoveOutsideObjects.Click += new System.EventHandler(this.cmdEnvironmentRemoveOutsideObjects_Click);
            // 
            // txtEnvrionmentEnvH
            // 
            this.txtEnvrionmentEnvH.Location = new System.Drawing.Point(118, 30);
            this.txtEnvrionmentEnvH.Name = "txtEnvrionmentEnvH";
            this.txtEnvrionmentEnvH.Size = new System.Drawing.Size(43, 21);
            this.txtEnvrionmentEnvH.TabIndex = 14;
            this.txtEnvrionmentEnvH.Text = "480";
            // 
            // txtEnvrionmentEnvW
            // 
            this.txtEnvrionmentEnvW.Location = new System.Drawing.Point(39, 30);
            this.txtEnvrionmentEnvW.Name = "txtEnvrionmentEnvW";
            this.txtEnvrionmentEnvW.Size = new System.Drawing.Size(43, 21);
            this.txtEnvrionmentEnvW.TabIndex = 12;
            this.txtEnvrionmentEnvW.Text = "640";
            // 
            // txtEnvrionmentGridH
            // 
            this.txtEnvrionmentGridH.Location = new System.Drawing.Point(118, 83);
            this.txtEnvrionmentGridH.Name = "txtEnvrionmentGridH";
            this.txtEnvrionmentGridH.Size = new System.Drawing.Size(43, 21);
            this.txtEnvrionmentGridH.TabIndex = 4;
            this.txtEnvrionmentGridH.Text = "16";
            // 
            // txtEnvrionmentGridW
            // 
            this.txtEnvrionmentGridW.Location = new System.Drawing.Point(39, 83);
            this.txtEnvrionmentGridW.Name = "txtEnvrionmentGridW";
            this.txtEnvrionmentGridW.Size = new System.Drawing.Size(43, 21);
            this.txtEnvrionmentGridW.TabIndex = 2;
            this.txtEnvrionmentGridW.Text = "16";
            // 
            // lblEnvrionmentEnvH
            // 
            this.lblEnvrionmentEnvH.AutoSize = true;
            this.lblEnvrionmentEnvH.Location = new System.Drawing.Point(98, 33);
            this.lblEnvrionmentEnvH.Name = "lblEnvrionmentEnvH";
            this.lblEnvrionmentEnvH.Size = new System.Drawing.Size(18, 13);
            this.lblEnvrionmentEnvH.TabIndex = 13;
            this.lblEnvrionmentEnvH.Text = "H:";
            // 
            // lblEnvrionmentEnvW
            // 
            this.lblEnvrionmentEnvW.AutoSize = true;
            this.lblEnvrionmentEnvW.Location = new System.Drawing.Point(17, 33);
            this.lblEnvrionmentEnvW.Name = "lblEnvrionmentEnvW";
            this.lblEnvrionmentEnvW.Size = new System.Drawing.Size(21, 13);
            this.lblEnvrionmentEnvW.TabIndex = 11;
            this.lblEnvrionmentEnvW.Text = "W:";
            // 
            // lblEnvrionmentEnv
            // 
            this.lblEnvrionmentEnv.AutoSize = true;
            this.lblEnvrionmentEnv.Location = new System.Drawing.Point(8, 8);
            this.lblEnvrionmentEnv.Name = "lblEnvrionmentEnv";
            this.lblEnvrionmentEnv.Size = new System.Drawing.Size(71, 13);
            this.lblEnvrionmentEnv.TabIndex = 10;
            this.lblEnvrionmentEnv.Text = "Environment:";
            // 
            // picEnvrionmentGridColor
            // 
            this.picEnvrionmentGridColor.BackColor = System.Drawing.Color.LightGray;
            this.picEnvrionmentGridColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEnvrionmentGridColor.Location = new System.Drawing.Point(76, 148);
            this.picEnvrionmentGridColor.Name = "picEnvrionmentGridColor";
            this.picEnvrionmentGridColor.Size = new System.Drawing.Size(85, 20);
            this.picEnvrionmentGridColor.TabIndex = 9;
            this.picEnvrionmentGridColor.TabStop = false;
            this.picEnvrionmentGridColor.Click += new System.EventHandler(this.picEnvironmentGridColor_Click);
            // 
            // lblEnvrionmentGridColor
            // 
            this.lblEnvrionmentGridColor.AutoSize = true;
            this.lblEnvrionmentGridColor.Location = new System.Drawing.Point(8, 151);
            this.lblEnvrionmentGridColor.Name = "lblEnvrionmentGridColor";
            this.lblEnvrionmentGridColor.Size = new System.Drawing.Size(30, 13);
            this.lblEnvrionmentGridColor.TabIndex = 8;
            this.lblEnvrionmentGridColor.Text = "Grid:";
            // 
            // picEnvironmentBackground
            // 
            this.picEnvironmentBackground.BackColor = System.Drawing.Color.White;
            this.picEnvironmentBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEnvironmentBackground.Location = new System.Drawing.Point(76, 122);
            this.picEnvironmentBackground.Name = "picEnvironmentBackground";
            this.picEnvironmentBackground.Size = new System.Drawing.Size(85, 20);
            this.picEnvironmentBackground.TabIndex = 6;
            this.picEnvironmentBackground.TabStop = false;
            this.picEnvironmentBackground.Click += new System.EventHandler(this.picEnvrionmentBackground_Click);
            // 
            // lblEnvrionmentBackground
            // 
            this.lblEnvrionmentBackground.AutoSize = true;
            this.lblEnvrionmentBackground.Location = new System.Drawing.Point(8, 125);
            this.lblEnvrionmentBackground.Name = "lblEnvrionmentBackground";
            this.lblEnvrionmentBackground.Size = new System.Drawing.Size(67, 13);
            this.lblEnvrionmentBackground.TabIndex = 5;
            this.lblEnvrionmentBackground.Text = "Background:";
            // 
            // lblEnvrionmentGridH
            // 
            this.lblEnvrionmentGridH.AutoSize = true;
            this.lblEnvrionmentGridH.Location = new System.Drawing.Point(98, 86);
            this.lblEnvrionmentGridH.Name = "lblEnvrionmentGridH";
            this.lblEnvrionmentGridH.Size = new System.Drawing.Size(18, 13);
            this.lblEnvrionmentGridH.TabIndex = 3;
            this.lblEnvrionmentGridH.Text = "H:";
            // 
            // lblEnvrionmentGridW
            // 
            this.lblEnvrionmentGridW.AutoSize = true;
            this.lblEnvrionmentGridW.Location = new System.Drawing.Point(17, 86);
            this.lblEnvrionmentGridW.Name = "lblEnvrionmentGridW";
            this.lblEnvrionmentGridW.Size = new System.Drawing.Size(21, 13);
            this.lblEnvrionmentGridW.TabIndex = 1;
            this.lblEnvrionmentGridW.Text = "W:";
            // 
            // lblEnvrionmentGrid
            // 
            this.lblEnvrionmentGrid.AutoSize = true;
            this.lblEnvrionmentGrid.Location = new System.Drawing.Point(8, 61);
            this.lblEnvrionmentGrid.Name = "lblEnvrionmentGrid";
            this.lblEnvrionmentGrid.Size = new System.Drawing.Size(30, 13);
            this.lblEnvrionmentGrid.TabIndex = 0;
            this.lblEnvrionmentGrid.Text = "Grid:";
            // 
            // imgGraphicRes
            // 
            this.imgGraphicRes.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgGraphicRes.ImageSize = new System.Drawing.Size(64, 64);
            this.imgGraphicRes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dlgOpen
            // 
            this.dlgOpen.Multiselect = true;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPanel.Controls.Add(this.cmdLeftPanelTool1);
            this.leftPanel.Location = new System.Drawing.Point(4, 73);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(36, 456);
            this.leftPanel.TabIndex = 6;
            // 
            // cmdLeftPanelTool1
            // 
            this.cmdLeftPanelTool1.BackColor = System.Drawing.Color.LightGray;
            this.cmdLeftPanelTool1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdLeftPanelTool1.FlatAppearance.BorderSize = 0;
            this.cmdLeftPanelTool1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLeftPanelTool1.Location = new System.Drawing.Point(1, 1);
            this.cmdLeftPanelTool1.Name = "cmdLeftPanelTool1";
            this.cmdLeftPanelTool1.Size = new System.Drawing.Size(30, 31);
            this.cmdLeftPanelTool1.TabIndex = 2;
            this.cmdLeftPanelTool1.UseVisualStyleBackColor = false;
            this.cmdLeftPanelTool1.Click += new System.EventHandler(this.cmdLeftPanelTool1_Click);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topPanel.Location = new System.Drawing.Point(4, 34);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(826, 36);
            this.topPanel.TabIndex = 7;
            this.topPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topSplitPanel);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Editor Version 2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.topSplitPanel.Panel1.ResumeLayout(false);
            this.topSplitPanel.Panel2.ResumeLayout(false);
            this.topSplitPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEnvironment)).EndInit();
            this.mnuContextPicEnv.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.tabRight.ResumeLayout(false);
            this.tabTiles.ResumeLayout(false);
            this.tabEnvironment.ResumeLayout(false);
            this.tabEnvironment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnvrionmentGridColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnvironmentBackground)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripSeparator mnuSep5;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteAll;
        private System.Windows.Forms.ToolStripMenuItem mnuObject;
        private System.Windows.Forms.ToolStripMenuItem mnuAddObject;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel mainMouse;
        private System.Windows.Forms.ToolStripStatusLabel mainObjectLabel;
        private System.Windows.Forms.SplitContainer topSplitPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ImageList imgGraphicRes;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.ImageList imgObjectList;
        private System.Windows.Forms.PictureBox picEnvironment;
        private System.Windows.Forms.ContextMenuStrip mnuContextPicEnv;
        private System.Windows.Forms.ToolStripMenuItem mnuEnvCutObject;
        private System.Windows.Forms.ToolStripMenuItem mnuEnvCopyObject;
        private System.Windows.Forms.ToolStripMenuItem mnuEnvPasteObject;
        private System.Windows.Forms.ToolStripSeparator mnuEnvSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuEnvDeleteObject;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button cmdLeftPanelTool1;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TabControl tabRight;
        private System.Windows.Forms.TabPage tabTiles;
        private System.Windows.Forms.Button cmdObjectClear;
        private System.Windows.Forms.Button cmdObjectDelete;
        private System.Windows.Forms.ListView lstObjects;
        private System.Windows.Forms.TabPage tabEnvironment;
        private System.Windows.Forms.Button cmdEnvrionmentOK;
        private System.Windows.Forms.Button cmdEnvironmentRemoveOutsideObjects;
        private System.Windows.Forms.TextBox txtEnvrionmentEnvH;
        private System.Windows.Forms.TextBox txtEnvrionmentEnvW;
        private System.Windows.Forms.TextBox txtEnvrionmentGridH;
        private System.Windows.Forms.TextBox txtEnvrionmentGridW;
        private System.Windows.Forms.Label lblEnvrionmentEnvH;
        private System.Windows.Forms.Label lblEnvrionmentEnvW;
        private System.Windows.Forms.Label lblEnvrionmentEnv;
        private System.Windows.Forms.PictureBox picEnvrionmentGridColor;
        private System.Windows.Forms.Label lblEnvrionmentGridColor;
        private System.Windows.Forms.PictureBox picEnvironmentBackground;
        private System.Windows.Forms.Label lblEnvrionmentBackground;
        private System.Windows.Forms.Label lblEnvrionmentGridH;
        private System.Windows.Forms.Label lblEnvrionmentGridW;
        private System.Windows.Forms.Label lblEnvrionmentGrid;
    }
}


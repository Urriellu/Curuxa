namespace CuruxaIDE {
	partial class FrmMainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusProgrammer = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusLin = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusCol = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.MiNewPrj = new System.Windows.Forms.ToolStripMenuItem();
			this.MiOpenExpl = new System.Windows.Forms.ToolStripMenuItem();
			this.MiOpenPrj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.MiClose = new System.Windows.Forms.ToolStripMenuItem();
			this.MiSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.MiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.MiProject = new System.Windows.Forms.ToolStripMenuItem();
			this.MiNewFile = new System.Windows.Forms.ToolStripMenuItem();
			this.MiAddFilePrj = new System.Windows.Forms.ToolStripMenuItem();
			this.MiPrjClose = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.MiBuildPrj = new System.Windows.Forms.ToolStripMenuItem();
			this.MiProgramPrj = new System.Windows.Forms.ToolStripMenuItem();
			this.MiRunPrj = new System.Windows.Forms.ToolStripMenuItem();
			this.MiStopPrj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.MiSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.MiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.MiWebsite = new System.Windows.Forms.ToolStripMenuItem();
			this.MiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.TreePrj = new System.Windows.Forms.TreeView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TabsSrc = new CuruxaIDE.SrcTabControl();
			this.MenuTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MiTabSave = new System.Windows.Forms.ToolStripMenuItem();
			this.MiTabClose = new System.Windows.Forms.ToolStripMenuItem();
			this.TabDemo = new System.Windows.Forms.TabPage();
			this.TabsMsg = new System.Windows.Forms.TabControl();
			this.TabMsgIDE = new System.Windows.Forms.TabPage();
			this.TxtLogIDE = new System.Windows.Forms.RichTextBox();
			this.TabBuildLog = new System.Windows.Forms.TabPage();
			this.TxtLogBuild = new System.Windows.Forms.RichTextBox();
			this.TabProgLog = new System.Windows.Forms.TabPage();
			this.TxtLogProgrammer = new System.Windows.Forms.RichTextBox();
			this.StripPrj = new System.Windows.Forms.ToolStrip();
			this.BtnNewFile = new System.Windows.Forms.ToolStripButton();
			this.BtnAddFIlePrj = new System.Windows.Forms.ToolStripButton();
			this.BtnSaveFile = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnClosePrj = new System.Windows.Forms.ToolStripButton();
			this.BtnConfigPrj = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnBuild = new System.Windows.Forms.ToolStripButton();
			this.BtnProgramMCU = new System.Windows.Forms.ToolStripButton();
			this.BtnRun = new System.Windows.Forms.ToolStripButton();
			this.BtnStop = new System.Windows.Forms.ToolStripButton();
			this.StatusStrip.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.TabsSrc.SuspendLayout();
			this.MenuTabs.SuspendLayout();
			this.TabsMsg.SuspendLayout();
			this.TabMsgIDE.SuspendLayout();
			this.TabBuildLog.SuspendLayout();
			this.TabProgLog.SuspendLayout();
			this.StripPrj.SuspendLayout();
			this.SuspendLayout();
			// 
			// StatusStrip
			// 
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus,
            this.StatusProgrammer,
            this.StatusLin,
            this.StatusCol});
			this.StatusStrip.Location = new System.Drawing.Point(0, 551);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(792, 22);
			this.StatusStrip.TabIndex = 1;
			this.StatusStrip.Text = "statusStrip1";
			// 
			// LblStatus
			// 
			this.LblStatus.Name = "LblStatus";
			this.LblStatus.Size = new System.Drawing.Size(552, 17);
			this.LblStatus.Spring = true;
			this.LblStatus.Text = "NS (Status text)";
			this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StatusProgrammer
			// 
			this.StatusProgrammer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.StatusProgrammer.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.StatusProgrammer.Name = "StatusProgrammer";
			this.StatusProgrammer.Size = new System.Drawing.Size(126, 17);
			this.StatusProgrammer.Text = "NS (programmer status)";
			// 
			// StatusLin
			// 
			this.StatusLin.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.StatusLin.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.StatusLin.Name = "StatusLin";
			this.StatusLin.Size = new System.Drawing.Size(51, 17);
			this.StatusLin.Text = "NS (line)";
			// 
			// StatusCol
			// 
			this.StatusCol.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.StatusCol.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.StatusCol.Name = "StatusCol";
			this.StatusCol.Size = new System.Drawing.Size(48, 17);
			this.StatusCol.Text = "NS (col)";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiFile,
            this.MiProject,
            this.MiHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(792, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MiFile
			// 
			this.MiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiNewPrj,
            this.MiOpenExpl,
            this.MiOpenPrj,
            this.toolStripMenuItem1,
            this.MiClose,
            this.MiSave,
            this.toolStripMenuItem2,
            this.MiExit});
			this.MiFile.Name = "MiFile";
			this.MiFile.Size = new System.Drawing.Size(59, 20);
			this.MiFile.Text = "NS (File)";
			// 
			// MiNewPrj
			// 
			this.MiNewPrj.Name = "MiNewPrj";
			this.MiNewPrj.Size = new System.Drawing.Size(214, 22);
			this.MiNewPrj.Text = "NS (New Project)";
			this.MiNewPrj.Click += new System.EventHandler(this.MiNewPrj_Click);
			// 
			// MiOpenExpl
			// 
			this.MiOpenExpl.Name = "MiOpenExpl";
			this.MiOpenExpl.Size = new System.Drawing.Size(214, 22);
			this.MiOpenExpl.Text = "NS (New prj from example)";
			this.MiOpenExpl.Click += new System.EventHandler(this.MiOpenExpl_Click);
			// 
			// MiOpenPrj
			// 
			this.MiOpenPrj.Name = "MiOpenPrj";
			this.MiOpenPrj.Size = new System.Drawing.Size(214, 22);
			this.MiOpenPrj.Text = "NS (Open Project)";
			this.MiOpenPrj.Click += new System.EventHandler(this.MiOpenPrj_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
			// 
			// MiClose
			// 
			this.MiClose.Name = "MiClose";
			this.MiClose.Size = new System.Drawing.Size(214, 22);
			this.MiClose.Text = "NS (Close)";
			this.MiClose.Click += new System.EventHandler(this.MiClose_Click);
			// 
			// MiSave
			// 
			this.MiSave.Name = "MiSave";
			this.MiSave.Size = new System.Drawing.Size(214, 22);
			this.MiSave.Text = "NS (Save)";
			this.MiSave.Click += new System.EventHandler(this.MiSave_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
			// 
			// MiExit
			// 
			this.MiExit.Name = "MiExit";
			this.MiExit.Size = new System.Drawing.Size(214, 22);
			this.MiExit.Text = "NS (Exit)";
			this.MiExit.Click += new System.EventHandler(this.MiExit_Click);
			// 
			// MiProject
			// 
			this.MiProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiNewFile,
            this.MiAddFilePrj,
            this.MiPrjClose,
            this.toolStripMenuItem3,
            this.MiBuildPrj,
            this.MiProgramPrj,
            this.MiRunPrj,
            this.MiStopPrj,
            this.toolStripMenuItem4,
            this.MiSettings});
			this.MiProject.Name = "MiProject";
			this.MiProject.Size = new System.Drawing.Size(77, 20);
			this.MiProject.Text = "NS (Project)";
			// 
			// MiNewFile
			// 
			this.MiNewFile.Name = "MiNewFile";
			this.MiNewFile.Size = new System.Drawing.Size(187, 22);
			this.MiNewFile.Text = "NS (New File)";
			// 
			// MiAddFilePrj
			// 
			this.MiAddFilePrj.Name = "MiAddFilePrj";
			this.MiAddFilePrj.Size = new System.Drawing.Size(187, 22);
			this.MiAddFilePrj.Text = "NS (Add Existing File)";
			// 
			// MiPrjClose
			// 
			this.MiPrjClose.Name = "MiPrjClose";
			this.MiPrjClose.Size = new System.Drawing.Size(187, 22);
			this.MiPrjClose.Text = "NS (Close)";
			this.MiPrjClose.Click += new System.EventHandler(this.MiPrjClose_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(184, 6);
			// 
			// MiBuildPrj
			// 
			this.MiBuildPrj.Name = "MiBuildPrj";
			this.MiBuildPrj.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.MiBuildPrj.Size = new System.Drawing.Size(187, 22);
			this.MiBuildPrj.Text = "NS (Build)";
			this.MiBuildPrj.Click += new System.EventHandler(this.MiBuildPrj_Click);
			// 
			// MiProgramPrj
			// 
			this.MiProgramPrj.Name = "MiProgramPrj";
			this.MiProgramPrj.ShortcutKeyDisplayString = "";
			this.MiProgramPrj.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.MiProgramPrj.Size = new System.Drawing.Size(187, 22);
			this.MiProgramPrj.Text = "NS (Program)";
			this.MiProgramPrj.Click += new System.EventHandler(this.MiProgramPrj_Click);
			// 
			// MiRunPrj
			// 
			this.MiRunPrj.Name = "MiRunPrj";
			this.MiRunPrj.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.MiRunPrj.Size = new System.Drawing.Size(187, 22);
			this.MiRunPrj.Text = "NS (Run)";
			this.MiRunPrj.Click += new System.EventHandler(this.MiRunPrj_Click);
			// 
			// MiStopPrj
			// 
			this.MiStopPrj.Name = "MiStopPrj";
			this.MiStopPrj.ShortcutKeyDisplayString = "";
			this.MiStopPrj.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.MiStopPrj.Size = new System.Drawing.Size(187, 22);
			this.MiStopPrj.Text = "NS (Stop)";
			this.MiStopPrj.Click += new System.EventHandler(this.MiStopPrj_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(184, 6);
			// 
			// MiSettings
			// 
			this.MiSettings.Name = "MiSettings";
			this.MiSettings.Size = new System.Drawing.Size(187, 22);
			this.MiSettings.Text = "NS (Settings)";
			this.MiSettings.Click += new System.EventHandler(this.MiSettings_Click);
			// 
			// MiHelp
			// 
			this.MiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiWebsite,
            this.MiAbout});
			this.MiHelp.Name = "MiHelp";
			this.MiHelp.Size = new System.Drawing.Size(64, 20);
			this.MiHelp.Text = "NS (Help)";
			// 
			// MiWebsite
			// 
			this.MiWebsite.Name = "MiWebsite";
			this.MiWebsite.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.MiWebsite.Size = new System.Drawing.Size(205, 22);
			this.MiWebsite.Text = "NS (Curuxa Website)";
			this.MiWebsite.Click += new System.EventHandler(this.MiWebsite_Click);
			// 
			// MiAbout
			// 
			this.MiAbout.Name = "MiAbout";
			this.MiAbout.Size = new System.Drawing.Size(205, 22);
			this.MiAbout.Text = "NS (About Curuxa IDE)";
			this.MiAbout.Click += new System.EventHandler(this.MiAbout_Click);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.Location = new System.Drawing.Point(0, 52);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.TreePrj);
			this.splitContainer2.Panel1MinSize = 150;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
			this.splitContainer2.Size = new System.Drawing.Size(792, 496);
			this.splitContainer2.SplitterDistance = 182;
			this.splitContainer2.TabIndex = 0;
			// 
			// TreePrj
			// 
			this.TreePrj.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TreePrj.FullRowSelect = true;
			this.TreePrj.HideSelection = false;
			this.TreePrj.Location = new System.Drawing.Point(0, 0);
			this.TreePrj.Name = "TreePrj";
			this.TreePrj.PathSeparator = "/";
			this.TreePrj.ShowNodeToolTips = true;
			this.TreePrj.Size = new System.Drawing.Size(182, 496);
			this.TreePrj.TabIndex = 0;
			this.TreePrj.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreePrj_NodeMouseDoubleClick);
			this.TreePrj.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreePrj_NodeMouseClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.TabsSrc);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.TabsMsg);
			this.splitContainer1.Size = new System.Drawing.Size(606, 496);
			this.splitContainer1.SplitterDistance = 361;
			this.splitContainer1.TabIndex = 0;
			// 
			// TabsSrc
			// 
			this.TabsSrc.Controls.Add(this.TabDemo);
			this.TabsSrc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabsSrc.Location = new System.Drawing.Point(0, 0);
			this.TabsSrc.Name = "TabsSrc";
			this.TabsSrc.SelectedIndex = 0;
			this.TabsSrc.Size = new System.Drawing.Size(606, 361);
			this.TabsSrc.TabIndex = 1;
			// 
			// MenuTabs
			// 
			this.MenuTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiTabSave,
            this.MiTabClose});
			this.MenuTabs.Name = "MenuTabs";
			this.MenuTabs.Size = new System.Drawing.Size(136, 48);
			// 
			// MiTabSave
			// 
			this.MiTabSave.Name = "MiTabSave";
			this.MiTabSave.Size = new System.Drawing.Size(135, 22);
			this.MiTabSave.Text = "NS (Save)";
			// 
			// MiTabClose
			// 
			this.MiTabClose.Name = "MiTabClose";
			this.MiTabClose.Size = new System.Drawing.Size(135, 22);
			this.MiTabClose.Text = "NS (Close)";
			// 
			// TabDemo
			// 
			this.TabDemo.Location = new System.Drawing.Point(4, 22);
			this.TabDemo.Name = "TabDemo";
			this.TabDemo.Padding = new System.Windows.Forms.Padding(3);
			this.TabDemo.Size = new System.Drawing.Size(598, 335);
			this.TabDemo.TabIndex = 0;
			this.TabDemo.Text = "demo tab page";
			this.TabDemo.UseVisualStyleBackColor = true;
			// 
			// TabsMsg
			// 
			this.TabsMsg.Controls.Add(this.TabMsgIDE);
			this.TabsMsg.Controls.Add(this.TabBuildLog);
			this.TabsMsg.Controls.Add(this.TabProgLog);
			this.TabsMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabsMsg.Location = new System.Drawing.Point(0, 0);
			this.TabsMsg.Name = "TabsMsg";
			this.TabsMsg.SelectedIndex = 0;
			this.TabsMsg.Size = new System.Drawing.Size(606, 131);
			this.TabsMsg.TabIndex = 0;
			// 
			// TabMsgIDE
			// 
			this.TabMsgIDE.Controls.Add(this.TxtLogIDE);
			this.TabMsgIDE.Location = new System.Drawing.Point(4, 22);
			this.TabMsgIDE.Name = "TabMsgIDE";
			this.TabMsgIDE.Padding = new System.Windows.Forms.Padding(3);
			this.TabMsgIDE.Size = new System.Drawing.Size(598, 105);
			this.TabMsgIDE.TabIndex = 0;
			this.TabMsgIDE.Text = "NS (IDE)";
			this.TabMsgIDE.UseVisualStyleBackColor = true;
			// 
			// TxtLogIDE
			// 
			this.TxtLogIDE.BackColor = System.Drawing.SystemColors.Window;
			this.TxtLogIDE.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtLogIDE.Location = new System.Drawing.Point(3, 3);
			this.TxtLogIDE.Name = "TxtLogIDE";
			this.TxtLogIDE.ReadOnly = true;
			this.TxtLogIDE.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.TxtLogIDE.Size = new System.Drawing.Size(592, 99);
			this.TxtLogIDE.TabIndex = 0;
			this.TxtLogIDE.Text = "";
			// 
			// TabBuildLog
			// 
			this.TabBuildLog.Controls.Add(this.TxtLogBuild);
			this.TabBuildLog.Location = new System.Drawing.Point(4, 22);
			this.TabBuildLog.Name = "TabBuildLog";
			this.TabBuildLog.Padding = new System.Windows.Forms.Padding(3);
			this.TabBuildLog.Size = new System.Drawing.Size(598, 105);
			this.TabBuildLog.TabIndex = 1;
			this.TabBuildLog.Text = "NS (build log)";
			this.TabBuildLog.UseVisualStyleBackColor = true;
			// 
			// TxtLogBuild
			// 
			this.TxtLogBuild.BackColor = System.Drawing.SystemColors.Window;
			this.TxtLogBuild.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtLogBuild.Location = new System.Drawing.Point(3, 3);
			this.TxtLogBuild.Name = "TxtLogBuild";
			this.TxtLogBuild.ReadOnly = true;
			this.TxtLogBuild.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.TxtLogBuild.Size = new System.Drawing.Size(592, 99);
			this.TxtLogBuild.TabIndex = 1;
			this.TxtLogBuild.Text = "";
			// 
			// TabProgLog
			// 
			this.TabProgLog.Controls.Add(this.TxtLogProgrammer);
			this.TabProgLog.Location = new System.Drawing.Point(4, 22);
			this.TabProgLog.Name = "TabProgLog";
			this.TabProgLog.Padding = new System.Windows.Forms.Padding(3);
			this.TabProgLog.Size = new System.Drawing.Size(598, 105);
			this.TabProgLog.TabIndex = 2;
			this.TabProgLog.Text = "NS (prog log)";
			this.TabProgLog.UseVisualStyleBackColor = true;
			// 
			// TxtLogProgrammer
			// 
			this.TxtLogProgrammer.BackColor = System.Drawing.SystemColors.Window;
			this.TxtLogProgrammer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtLogProgrammer.Location = new System.Drawing.Point(3, 3);
			this.TxtLogProgrammer.Name = "TxtLogProgrammer";
			this.TxtLogProgrammer.ReadOnly = true;
			this.TxtLogProgrammer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.TxtLogProgrammer.Size = new System.Drawing.Size(592, 99);
			this.TxtLogProgrammer.TabIndex = 2;
			this.TxtLogProgrammer.Text = "";
			// 
			// StripPrj
			// 
			this.StripPrj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewFile,
            this.BtnAddFIlePrj,
            this.BtnSaveFile,
            this.toolStripSeparator1,
            this.BtnClosePrj,
            this.BtnConfigPrj,
            this.toolStripSeparator2,
            this.BtnBuild,
            this.BtnProgramMCU,
            this.BtnRun,
            this.BtnStop});
			this.StripPrj.Location = new System.Drawing.Point(0, 24);
			this.StripPrj.Name = "StripPrj";
			this.StripPrj.Size = new System.Drawing.Size(792, 25);
			this.StripPrj.TabIndex = 4;
			this.StripPrj.Text = "ToolStrip";
			// 
			// BtnNewFile
			// 
			this.BtnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewFile.Image")));
			this.BtnNewFile.ImageTransparentColor = System.Drawing.Color.Black;
			this.BtnNewFile.Name = "BtnNewFile";
			this.BtnNewFile.Size = new System.Drawing.Size(23, 22);
			this.BtnNewFile.Text = "NS (New File)";
			this.BtnNewFile.Click += new System.EventHandler(this.BtnNewFile_Click);
			// 
			// BtnAddFIlePrj
			// 
			this.BtnAddFIlePrj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnAddFIlePrj.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddFIlePrj.Image")));
			this.BtnAddFIlePrj.ImageTransparentColor = System.Drawing.Color.Black;
			this.BtnAddFIlePrj.Name = "BtnAddFIlePrj";
			this.BtnAddFIlePrj.Size = new System.Drawing.Size(23, 22);
			this.BtnAddFIlePrj.Text = "NS (Add Existing File to Project)";
			this.BtnAddFIlePrj.Click += new System.EventHandler(this.BtnAddFIlePrj_Click);
			// 
			// BtnSaveFile
			// 
			this.BtnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveFile.Image")));
			this.BtnSaveFile.ImageTransparentColor = System.Drawing.Color.Black;
			this.BtnSaveFile.Name = "BtnSaveFile";
			this.BtnSaveFile.Size = new System.Drawing.Size(23, 22);
			this.BtnSaveFile.Text = "NS (Save File)";
			this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnClosePrj
			// 
			this.BtnClosePrj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnClosePrj.Image = ((System.Drawing.Image)(resources.GetObject("BtnClosePrj.Image")));
			this.BtnClosePrj.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnClosePrj.Name = "BtnClosePrj";
			this.BtnClosePrj.Size = new System.Drawing.Size(23, 22);
			this.BtnClosePrj.Text = "NS (Close Project)";
			this.BtnClosePrj.Click += new System.EventHandler(this.BtnClosePrj_Click);
			// 
			// BtnConfigPrj
			// 
			this.BtnConfigPrj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnConfigPrj.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfigPrj.Image")));
			this.BtnConfigPrj.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnConfigPrj.Name = "BtnConfigPrj";
			this.BtnConfigPrj.Size = new System.Drawing.Size(23, 22);
			this.BtnConfigPrj.Text = "NS (Project Settings)";
			this.BtnConfigPrj.Click += new System.EventHandler(this.BtnConfigPrj_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnBuild
			// 
			this.BtnBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnBuild.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuild.Image")));
			this.BtnBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnBuild.Name = "BtnBuild";
			this.BtnBuild.Size = new System.Drawing.Size(23, 22);
			this.BtnBuild.Text = "NS (Build)";
			this.BtnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
			// 
			// BtnProgramMCU
			// 
			this.BtnProgramMCU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnProgramMCU.Image = ((System.Drawing.Image)(resources.GetObject("BtnProgramMCU.Image")));
			this.BtnProgramMCU.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnProgramMCU.Name = "BtnProgramMCU";
			this.BtnProgramMCU.Size = new System.Drawing.Size(23, 22);
			this.BtnProgramMCU.Text = "NS (Write App to MCU)";
			this.BtnProgramMCU.Click += new System.EventHandler(this.BtnProgramMCU_Click);
			// 
			// BtnRun
			// 
			this.BtnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnRun.Image = ((System.Drawing.Image)(resources.GetObject("BtnRun.Image")));
			this.BtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(23, 22);
			this.BtnRun.Text = "NS (Run Program)";
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// BtnStop
			// 
			this.BtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
			this.BtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(23, 22);
			this.BtnStop.Text = "NS (Stop)";
			this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
			// 
			// FrmMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.Add(this.splitContainer2);
			this.Controls.Add(this.StripPrj);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(400, 350);
			this.Name = "FrmMainWindow";
			this.Text = "NS (Title)";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainWindow_FormClosing);
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.TabsSrc.ResumeLayout(false);
			this.MenuTabs.ResumeLayout(false);
			this.TabsMsg.ResumeLayout(false);
			this.TabMsgIDE.ResumeLayout(false);
			this.TabBuildLog.ResumeLayout(false);
			this.TabProgLog.ResumeLayout(false);
			this.StripPrj.ResumeLayout(false);
			this.StripPrj.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel LblStatus;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MiFile;
		private System.Windows.Forms.ToolStripMenuItem MiNewPrj;
		private System.Windows.Forms.ToolStripMenuItem MiOpenExpl;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem MiSave;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem MiExit;
		private System.Windows.Forms.ToolStripMenuItem MiProject;
		private System.Windows.Forms.ToolStripMenuItem MiNewFile;
		private System.Windows.Forms.ToolStripMenuItem MiAddFilePrj;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem MiSettings;
		private System.Windows.Forms.ToolStripMenuItem MiHelp;
		private System.Windows.Forms.ToolStripMenuItem MiBuildPrj;
		private System.Windows.Forms.ToolStripMenuItem MiProgramPrj;
		private System.Windows.Forms.ToolStripMenuItem MiRunPrj;
		private System.Windows.Forms.ToolStripMenuItem MiStopPrj;
		private System.Windows.Forms.ToolStripMenuItem MiWebsite;
		private System.Windows.Forms.ToolStripMenuItem MiAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TreeView TreePrj;
		private System.Windows.Forms.RichTextBox TxtLogIDE;
		private System.Windows.Forms.ToolStripMenuItem MiPrjClose;
		private System.Windows.Forms.ToolStrip StripPrj;
		private System.Windows.Forms.ToolStripButton BtnNewFile;
		private System.Windows.Forms.ToolStripButton BtnAddFIlePrj;
		private System.Windows.Forms.ToolStripButton BtnSaveFile;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton BtnBuild;
		private System.Windows.Forms.ToolStripButton BtnProgramMCU;
		private System.Windows.Forms.ToolStripButton BtnRun;
		private System.Windows.Forms.ToolStripButton BtnStop;
		private System.Windows.Forms.ToolStripButton BtnClosePrj;
		private System.Windows.Forms.ToolStripButton BtnConfigPrj;
		private System.Windows.Forms.ToolStripMenuItem MiOpenPrj;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabPage TabMsgIDE;
		public System.Windows.Forms.RichTextBox TxtLogBuild;
		public System.Windows.Forms.RichTextBox TxtLogProgrammer;
		public System.Windows.Forms.TabPage TabBuildLog;
		public System.Windows.Forms.TabPage TabProgLog;
		public System.Windows.Forms.TabControl TabsMsg;
		private System.Windows.Forms.ToolStripStatusLabel StatusLin;
		private System.Windows.Forms.ToolStripStatusLabel StatusProgrammer;
		private SrcTabControl TabsSrc;
		private System.Windows.Forms.TabPage TabDemo;
		private System.Windows.Forms.ToolStripStatusLabel StatusCol;
		private System.Windows.Forms.ToolStripMenuItem MiClose;
		private System.Windows.Forms.ToolStripMenuItem MiTabSave;
		private System.Windows.Forms.ToolStripMenuItem MiTabClose;
		public System.Windows.Forms.ContextMenuStrip MenuTabs;
	}
}


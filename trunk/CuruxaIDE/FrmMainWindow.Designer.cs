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
			this.MiPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.MiFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.MiFileClose = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.MiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.MiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.MiUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.MiRedo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.MiCut = new System.Windows.Forms.ToolStripMenuItem();
			this.MiCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.MiPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.MiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.MiProject = new System.Windows.Forms.ToolStripMenuItem();
			this.MiNewFile = new System.Windows.Forms.ToolStripMenuItem();
			this.MiPrjAddFile = new System.Windows.Forms.ToolStripMenuItem();
			this.MiPrjSaveAll = new System.Windows.Forms.ToolStripMenuItem();
			this.MiPrjClose = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.MiPrjBuildBurnRun = new System.Windows.Forms.ToolStripMenuItem();
			this.MiPrjBuild = new System.Windows.Forms.ToolStripMenuItem();
			this.MiPrjProgram = new System.Windows.Forms.ToolStripMenuItem();
			this.MiPrjRun = new System.Windows.Forms.ToolStripMenuItem();
			this.MiPrjStop = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.MiPrjSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.MiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.MiLanguage = new System.Windows.Forms.ToolStripMenuItem();
			this.MiLangSpanish = new System.Windows.Forms.ToolStripMenuItem();
			this.MiLangEnglish = new System.Windows.Forms.ToolStripMenuItem();
			this.MiWebsite = new System.Windows.Forms.ToolStripMenuItem();
			this.MiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.TreePrj = new System.Windows.Forms.TreeView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TabsSrc = new CuruxaIDE.SrcTabControl();
			this.TabDemo = new System.Windows.Forms.TabPage();
			this.TabsMsg = new System.Windows.Forms.TabControl();
			this.TabMsgIDE = new System.Windows.Forms.TabPage();
			this.TxtLogIDE = new System.Windows.Forms.RichTextBox();
			this.TabBuildLog = new System.Windows.Forms.TabPage();
			this.TxtLogBuild = new System.Windows.Forms.RichTextBox();
			this.TabProgLog = new System.Windows.Forms.TabPage();
			this.TxtLogProgrammer = new System.Windows.Forms.RichTextBox();
			this.MenuTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MiTabSave = new System.Windows.Forms.ToolStripMenuItem();
			this.MiTabClose = new System.Windows.Forms.ToolStripMenuItem();
			this.StripPrj = new System.Windows.Forms.ToolStrip();
			this.BtnNewFile = new System.Windows.Forms.ToolStripButton();
			this.BtnAddFilePrj = new System.Windows.Forms.ToolStripButton();
			this.BtnSaveFile = new System.Windows.Forms.ToolStripButton();
			this.BtnFileClose = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnCut = new System.Windows.Forms.ToolStripButton();
			this.BtnCopy = new System.Windows.Forms.ToolStripButton();
			this.BtnPaste = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnUndo = new System.Windows.Forms.ToolStripButton();
			this.BtnRedo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.BtnSaveAll = new System.Windows.Forms.ToolStripButton();
			this.BtnClosePrj = new System.Windows.Forms.ToolStripButton();
			this.BtnPrjSettings = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnPrjBuildBurnRun = new System.Windows.Forms.ToolStripButton();
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
			this.TabsMsg.SuspendLayout();
			this.TabMsgIDE.SuspendLayout();
			this.TabBuildLog.SuspendLayout();
			this.TabProgLog.SuspendLayout();
			this.MenuTabs.SuspendLayout();
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
            this.MiEdit,
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
            this.MiPrint,
            this.MiFileSave,
            this.MiFileClose,
            this.toolStripMenuItem2,
            this.MiExit});
			this.MiFile.Name = "MiFile";
			this.MiFile.Size = new System.Drawing.Size(59, 20);
			this.MiFile.Text = "NS (File)";
			// 
			// MiNewPrj
			// 
			this.MiNewPrj.Name = "MiNewPrj";
			this.MiNewPrj.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.N)));
			this.MiNewPrj.Size = new System.Drawing.Size(242, 22);
			this.MiNewPrj.Text = "NS (New Project)";
			this.MiNewPrj.Click += new System.EventHandler(this.MiNewPrj_Click);
			// 
			// MiOpenExpl
			// 
			this.MiOpenExpl.Name = "MiOpenExpl";
			this.MiOpenExpl.Size = new System.Drawing.Size(242, 22);
			this.MiOpenExpl.Text = "NS (New prj from example)";
			this.MiOpenExpl.Click += new System.EventHandler(this.MiOpenExpl_Click);
			// 
			// MiOpenPrj
			// 
			this.MiOpenPrj.Name = "MiOpenPrj";
			this.MiOpenPrj.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.O)));
			this.MiOpenPrj.Size = new System.Drawing.Size(242, 22);
			this.MiOpenPrj.Text = "NS (Open Project)";
			this.MiOpenPrj.Click += new System.EventHandler(this.MiOpenPrj_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(239, 6);
			// 
			// MiPrint
			// 
			this.MiPrint.Name = "MiPrint";
			this.MiPrint.Size = new System.Drawing.Size(242, 22);
			this.MiPrint.Text = "NS (Print)";
			// 
			// MiFileSave
			// 
			this.MiFileSave.Name = "MiFileSave";
			this.MiFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.MiFileSave.Size = new System.Drawing.Size(242, 22);
			this.MiFileSave.Text = "NS (Save)";
			this.MiFileSave.Click += new System.EventHandler(this.MiSave_Click);
			// 
			// MiFileClose
			// 
			this.MiFileClose.Name = "MiFileClose";
			this.MiFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.MiFileClose.Size = new System.Drawing.Size(242, 22);
			this.MiFileClose.Text = "NS (Close)";
			this.MiFileClose.Click += new System.EventHandler(this.MiClose_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(239, 6);
			// 
			// MiExit
			// 
			this.MiExit.Name = "MiExit";
			this.MiExit.Size = new System.Drawing.Size(242, 22);
			this.MiExit.Text = "NS (Exit)";
			this.MiExit.Click += new System.EventHandler(this.MiExit_Click);
			// 
			// MiEdit
			// 
			this.MiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiUndo,
            this.MiRedo,
            this.toolStripSeparator7,
            this.MiCut,
            this.MiCopy,
            this.MiPaste,
            this.toolStripSeparator8,
            this.MiSelectAll});
			this.MiEdit.Name = "MiEdit";
			this.MiEdit.Size = new System.Drawing.Size(61, 20);
			this.MiEdit.Text = "NS (Edit)";
			// 
			// MiUndo
			// 
			this.MiUndo.Enabled = false;
			this.MiUndo.Name = "MiUndo";
			this.MiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.MiUndo.Size = new System.Drawing.Size(202, 22);
			this.MiUndo.Text = "NS (Undo)";
			this.MiUndo.Click += new System.EventHandler(this.MiUndo_Click);
			// 
			// MiRedo
			// 
			this.MiRedo.Enabled = false;
			this.MiRedo.Name = "MiRedo";
			this.MiRedo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.Z)));
			this.MiRedo.Size = new System.Drawing.Size(202, 22);
			this.MiRedo.Text = "NS (Redo)";
			this.MiRedo.Click += new System.EventHandler(this.MiRedo_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(199, 6);
			// 
			// MiCut
			// 
			this.MiCut.Image = ((System.Drawing.Image)(resources.GetObject("MiCut.Image")));
			this.MiCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MiCut.Name = "MiCut";
			this.MiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.MiCut.Size = new System.Drawing.Size(202, 22);
			this.MiCut.Text = "NS (Cut)";
			this.MiCut.Click += new System.EventHandler(this.MiCut_Click);
			// 
			// MiCopy
			// 
			this.MiCopy.Image = ((System.Drawing.Image)(resources.GetObject("MiCopy.Image")));
			this.MiCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MiCopy.Name = "MiCopy";
			this.MiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.MiCopy.Size = new System.Drawing.Size(202, 22);
			this.MiCopy.Text = "NS (Copy)";
			this.MiCopy.Click += new System.EventHandler(this.MiCopy_Click);
			// 
			// MiPaste
			// 
			this.MiPaste.Image = ((System.Drawing.Image)(resources.GetObject("MiPaste.Image")));
			this.MiPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MiPaste.Name = "MiPaste";
			this.MiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.MiPaste.Size = new System.Drawing.Size(202, 22);
			this.MiPaste.Text = "NS (Paste)";
			this.MiPaste.Click += new System.EventHandler(this.MiPaste_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(199, 6);
			// 
			// MiSelectAll
			// 
			this.MiSelectAll.Name = "MiSelectAll";
			this.MiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.MiSelectAll.Size = new System.Drawing.Size(202, 22);
			this.MiSelectAll.Text = "NS (Select All)";
			this.MiSelectAll.Click += new System.EventHandler(this.MiSelectAll_Click);
			// 
			// MiProject
			// 
			this.MiProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiNewFile,
            this.MiPrjAddFile,
            this.MiPrjSaveAll,
            this.MiPrjClose,
            this.toolStripMenuItem3,
            this.MiPrjBuildBurnRun,
            this.MiPrjBuild,
            this.MiPrjProgram,
            this.MiPrjRun,
            this.MiPrjStop,
            this.toolStripMenuItem4,
            this.MiPrjSettings});
			this.MiProject.Name = "MiProject";
			this.MiProject.Size = new System.Drawing.Size(77, 20);
			this.MiProject.Text = "NS (Project)";
			// 
			// MiNewFile
			// 
			this.MiNewFile.Enabled = false;
			this.MiNewFile.Name = "MiNewFile";
			this.MiNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.MiNewFile.Size = new System.Drawing.Size(227, 22);
			this.MiNewFile.Text = "NS (New File)";
			this.MiNewFile.Click += new System.EventHandler(this.MiNewFile_Click);
			// 
			// MiPrjAddFile
			// 
			this.MiPrjAddFile.Enabled = false;
			this.MiPrjAddFile.Name = "MiPrjAddFile";
			this.MiPrjAddFile.ShortcutKeyDisplayString = "Ctrl+O";
			this.MiPrjAddFile.Size = new System.Drawing.Size(227, 22);
			this.MiPrjAddFile.Text = "NS (Add Existing File)";
			this.MiPrjAddFile.Click += new System.EventHandler(this.MiPrjAddFile_Click);
			// 
			// MiPrjSaveAll
			// 
			this.MiPrjSaveAll.Name = "MiPrjSaveAll";
			this.MiPrjSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.S)));
			this.MiPrjSaveAll.Size = new System.Drawing.Size(227, 22);
			this.MiPrjSaveAll.Text = "NS (Save All)";
			this.MiPrjSaveAll.Click += new System.EventHandler(this.MiPrjSaveAll_Click);
			// 
			// MiPrjClose
			// 
			this.MiPrjClose.Name = "MiPrjClose";
			this.MiPrjClose.Size = new System.Drawing.Size(227, 22);
			this.MiPrjClose.Text = "NS (Close)";
			this.MiPrjClose.Click += new System.EventHandler(this.MiPrjClose_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(224, 6);
			// 
			// MiPrjBuildBurnRun
			// 
			this.MiPrjBuildBurnRun.Name = "MiPrjBuildBurnRun";
			this.MiPrjBuildBurnRun.ShortcutKeys = System.Windows.Forms.Keys.F4;
			this.MiPrjBuildBurnRun.Size = new System.Drawing.Size(227, 22);
			this.MiPrjBuildBurnRun.Text = "NS (Build, Burn, Run)";
			this.MiPrjBuildBurnRun.Click += new System.EventHandler(this.MiBuildBurnRun_Click);
			// 
			// MiPrjBuild
			// 
			this.MiPrjBuild.Name = "MiPrjBuild";
			this.MiPrjBuild.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.MiPrjBuild.Size = new System.Drawing.Size(227, 22);
			this.MiPrjBuild.Text = "NS (Build)";
			this.MiPrjBuild.Click += new System.EventHandler(this.MiBuildPrj_Click);
			// 
			// MiPrjProgram
			// 
			this.MiPrjProgram.Name = "MiPrjProgram";
			this.MiPrjProgram.ShortcutKeyDisplayString = "";
			this.MiPrjProgram.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.MiPrjProgram.Size = new System.Drawing.Size(227, 22);
			this.MiPrjProgram.Text = "NS (Program)";
			this.MiPrjProgram.Click += new System.EventHandler(this.MiProgramPrj_Click);
			// 
			// MiPrjRun
			// 
			this.MiPrjRun.Name = "MiPrjRun";
			this.MiPrjRun.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.MiPrjRun.Size = new System.Drawing.Size(227, 22);
			this.MiPrjRun.Text = "NS (Run)";
			this.MiPrjRun.Click += new System.EventHandler(this.MiRunPrj_Click);
			// 
			// MiPrjStop
			// 
			this.MiPrjStop.Name = "MiPrjStop";
			this.MiPrjStop.ShortcutKeyDisplayString = "";
			this.MiPrjStop.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.MiPrjStop.Size = new System.Drawing.Size(227, 22);
			this.MiPrjStop.Text = "NS (Stop)";
			this.MiPrjStop.Click += new System.EventHandler(this.MiStopPrj_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 6);
			// 
			// MiPrjSettings
			// 
			this.MiPrjSettings.Name = "MiPrjSettings";
			this.MiPrjSettings.Size = new System.Drawing.Size(227, 22);
			this.MiPrjSettings.Text = "NS (Settings)";
			this.MiPrjSettings.Click += new System.EventHandler(this.MiSettings_Click);
			// 
			// MiHelp
			// 
			this.MiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiLanguage,
            this.MiWebsite,
            this.MiAbout});
			this.MiHelp.Name = "MiHelp";
			this.MiHelp.Size = new System.Drawing.Size(64, 20);
			this.MiHelp.Text = "NS (Help)";
			// 
			// MiLanguage
			// 
			this.MiLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiLangSpanish,
            this.MiLangEnglish});
			this.MiLanguage.Name = "MiLanguage";
			this.MiLanguage.Size = new System.Drawing.Size(205, 22);
			this.MiLanguage.Text = "NS (Language)";
			// 
			// MiLangSpanish
			// 
			this.MiLangSpanish.Name = "MiLangSpanish";
			this.MiLangSpanish.Size = new System.Drawing.Size(122, 22);
			this.MiLangSpanish.Text = "Español";
			this.MiLangSpanish.Click += new System.EventHandler(this.MiLangSpanish_Click);
			// 
			// MiLangEnglish
			// 
			this.MiLangEnglish.Name = "MiLangEnglish";
			this.MiLangEnglish.Size = new System.Drawing.Size(122, 22);
			this.MiLangEnglish.Text = "English";
			this.MiLangEnglish.Click += new System.EventHandler(this.MiLangEnglish_Click);
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
			this.TreePrj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			// StripPrj
			// 
			this.StripPrj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewFile,
            this.BtnAddFilePrj,
            this.BtnSaveFile,
            this.BtnFileClose,
            this.toolStripSeparator1,
            this.BtnCut,
            this.BtnCopy,
            this.BtnPaste,
            this.toolStripSeparator4,
            this.BtnUndo,
            this.BtnRedo,
            this.toolStripSeparator,
            this.BtnSaveAll,
            this.BtnClosePrj,
            this.BtnPrjSettings,
            this.toolStripSeparator2,
            this.BtnPrjBuildBurnRun,
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
			// BtnAddFilePrj
			// 
			this.BtnAddFilePrj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnAddFilePrj.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddFilePrj.Image")));
			this.BtnAddFilePrj.ImageTransparentColor = System.Drawing.Color.Black;
			this.BtnAddFilePrj.Name = "BtnAddFilePrj";
			this.BtnAddFilePrj.Size = new System.Drawing.Size(23, 22);
			this.BtnAddFilePrj.Text = "NS (Add Existing File to Project)";
			this.BtnAddFilePrj.Click += new System.EventHandler(this.BtnAddFIlePrj_Click);
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
			// BtnFileClose
			// 
			this.BtnFileClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnFileClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnFileClose.Image")));
			this.BtnFileClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnFileClose.Name = "BtnFileClose";
			this.BtnFileClose.Size = new System.Drawing.Size(23, 22);
			this.BtnFileClose.Text = "NS (close file)";
			this.BtnFileClose.Click += new System.EventHandler(this.BtnFileClose_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnCut
			// 
			this.BtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnCut.Image = ((System.Drawing.Image)(resources.GetObject("BtnCut.Image")));
			this.BtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnCut.Name = "BtnCut";
			this.BtnCut.Size = new System.Drawing.Size(23, 22);
			this.BtnCut.Text = "C&ut";
			this.BtnCut.Click += new System.EventHandler(this.BtnCut_Click);
			// 
			// BtnCopy
			// 
			this.BtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("BtnCopy.Image")));
			this.BtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnCopy.Name = "BtnCopy";
			this.BtnCopy.Size = new System.Drawing.Size(23, 22);
			this.BtnCopy.Text = "&Copy";
			this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
			// 
			// BtnPaste
			// 
			this.BtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("BtnPaste.Image")));
			this.BtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnPaste.Name = "BtnPaste";
			this.BtnPaste.Size = new System.Drawing.Size(23, 22);
			this.BtnPaste.Text = "&Paste";
			this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnUndo
			// 
			this.BtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnUndo.Enabled = false;
			this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
			this.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnUndo.Name = "BtnUndo";
			this.BtnUndo.Size = new System.Drawing.Size(23, 22);
			this.BtnUndo.Text = "NS (Undo)";
			this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
			// 
			// BtnRedo
			// 
			this.BtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnRedo.Enabled = false;
			this.BtnRedo.Image = ((System.Drawing.Image)(resources.GetObject("BtnRedo.Image")));
			this.BtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnRedo.Name = "BtnRedo";
			this.BtnRedo.Size = new System.Drawing.Size(23, 22);
			this.BtnRedo.Text = "NS (Redo)";
			this.BtnRedo.Click += new System.EventHandler(this.BtnRedo_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnSaveAll
			// 
			this.BtnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveAll.Image")));
			this.BtnSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnSaveAll.Name = "BtnSaveAll";
			this.BtnSaveAll.Size = new System.Drawing.Size(23, 22);
			this.BtnSaveAll.Text = "NS (Save All)";
			this.BtnSaveAll.Click += new System.EventHandler(this.BtnSaveAll_Click);
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
			// BtnPrjSettings
			// 
			this.BtnPrjSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnPrjSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrjSettings.Image")));
			this.BtnPrjSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnPrjSettings.Name = "BtnPrjSettings";
			this.BtnPrjSettings.Size = new System.Drawing.Size(23, 22);
			this.BtnPrjSettings.Text = "NS (Project Settings)";
			this.BtnPrjSettings.Click += new System.EventHandler(this.BtnConfigPrj_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnPrjBuildBurnRun
			// 
			this.BtnPrjBuildBurnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnPrjBuildBurnRun.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrjBuildBurnRun.Image")));
			this.BtnPrjBuildBurnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnPrjBuildBurnRun.Name = "BtnPrjBuildBurnRun";
			this.BtnPrjBuildBurnRun.Size = new System.Drawing.Size(23, 22);
			this.BtnPrjBuildBurnRun.Text = "toolStripButton1";
			this.BtnPrjBuildBurnRun.Click += new System.EventHandler(this.BtnBuildBurnRun_Click);
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
			this.TabsMsg.ResumeLayout(false);
			this.TabMsgIDE.ResumeLayout(false);
			this.TabBuildLog.ResumeLayout(false);
			this.TabProgLog.ResumeLayout(false);
			this.MenuTabs.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem MiFileSave;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem MiExit;
		private System.Windows.Forms.ToolStripMenuItem MiProject;
		private System.Windows.Forms.ToolStripMenuItem MiNewFile;
		private System.Windows.Forms.ToolStripMenuItem MiPrjAddFile;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem MiPrjSettings;
		private System.Windows.Forms.ToolStripMenuItem MiHelp;
		private System.Windows.Forms.ToolStripMenuItem MiPrjBuild;
		private System.Windows.Forms.ToolStripMenuItem MiPrjProgram;
		private System.Windows.Forms.ToolStripMenuItem MiPrjRun;
		private System.Windows.Forms.ToolStripMenuItem MiPrjStop;
		private System.Windows.Forms.ToolStripMenuItem MiWebsite;
		private System.Windows.Forms.ToolStripMenuItem MiAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TreeView TreePrj;
		private System.Windows.Forms.RichTextBox TxtLogIDE;
		private System.Windows.Forms.ToolStripMenuItem MiPrjClose;
		private System.Windows.Forms.ToolStrip StripPrj;
		private System.Windows.Forms.ToolStripButton BtnNewFile;
		private System.Windows.Forms.ToolStripButton BtnAddFilePrj;
		private System.Windows.Forms.ToolStripButton BtnSaveFile;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton BtnBuild;
		private System.Windows.Forms.ToolStripButton BtnProgramMCU;
		private System.Windows.Forms.ToolStripButton BtnRun;
		private System.Windows.Forms.ToolStripButton BtnStop;
		private System.Windows.Forms.ToolStripButton BtnClosePrj;
		private System.Windows.Forms.ToolStripButton BtnPrjSettings;
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
		private System.Windows.Forms.ToolStripMenuItem MiFileClose;
		private System.Windows.Forms.ToolStripMenuItem MiTabSave;
		private System.Windows.Forms.ToolStripMenuItem MiTabClose;
		public System.Windows.Forms.ContextMenuStrip MenuTabs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton BtnCut;
		private System.Windows.Forms.ToolStripButton BtnCopy;
		private System.Windows.Forms.ToolStripButton BtnPaste;
		private System.Windows.Forms.ToolStripMenuItem MiEdit;
		private System.Windows.Forms.ToolStripMenuItem MiUndo;
		private System.Windows.Forms.ToolStripMenuItem MiRedo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem MiCut;
		private System.Windows.Forms.ToolStripMenuItem MiCopy;
		private System.Windows.Forms.ToolStripMenuItem MiPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem MiSelectAll;
		private System.Windows.Forms.ToolStripMenuItem MiPrjSaveAll;
		private System.Windows.Forms.ToolStripButton BtnFileClose;
		private System.Windows.Forms.ToolStripMenuItem MiLanguage;
		private System.Windows.Forms.ToolStripMenuItem MiLangSpanish;
		private System.Windows.Forms.ToolStripMenuItem MiLangEnglish;
		private System.Windows.Forms.ToolStripMenuItem MiPrint;
		private System.Windows.Forms.ToolStripButton BtnSaveAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton BtnUndo;
		private System.Windows.Forms.ToolStripButton BtnRedo;
		private System.Windows.Forms.ToolStripMenuItem MiPrjBuildBurnRun;
		private System.Windows.Forms.ToolStripButton BtnPrjBuildBurnRun;
	}
}


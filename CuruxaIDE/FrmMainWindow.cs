using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace CuruxaIDE {
	public partial class FrmMainWindow:Form {
		FrmAbout AboutWindow = new FrmAbout();
		Timer TmrHighlight = new Timer();

		/// <summary>
		/// Indicates if the forms is currently being closed
		/// </summary>
		bool IsClosing = false;

		/// <summary>
		/// Amount of informative lines shown in the projects tree at the beginning of each project, before showing source files
		/// </summary>
		const uint LinesInfoPrjTree = 2;

		public FrmMainWindow() {
			InitializeComponent();
			this.WindowState = Settings.MainWindowState;

			UpdateLang();
			SetTitle("");
			LogIDE(i18n.str("AppInitialized"));
			if(Project.OpenProjects.Length > 0) Globals.ActiveProject = Project.OpenProjects[0];
			TreePrj.ImageList = new ImageList();
			TreePrj.ImageList.Images.Add("Project", Globals.LoadImage("CuruxaLogo_16x16.png"));
			TreePrj.ImageList.Images.Add("Source", Globals.LoadImage("edit.png"));
			TreePrj.ImageList.Images.Add("Library", Globals.LoadImage("contents.png"));
			TreePrj.ImageList.Images.Add("Info", Globals.LoadImage("info.png"));
			UpdatePrjList();
			MiNewFile.Image = BtnNewFile.Image = Globals.LoadImage("filenew.png");
			MiPrjAddFile.Image = BtnAddFilePrj.Image = Globals.LoadImage("fileopen.png");
			MiFileSave.Image = BtnSaveFile.Image = Globals.LoadImage("filesave.png");
			MiNewPrj.Image = Globals.LoadImage("window_new.png");
			MiPrint.Image = Globals.LoadImage("fileprint.png");
			MiOpenPrj.Image = Globals.LoadImage("project_open.png");
			MiPrjBuild.Image = BtnBuild.Image = Globals.LoadImage("exec.png");
			MiPrjProgram.Image = BtnProgramMCU.Image = Globals.LoadImage("bottom.png");
			MiPrjRun.Image = BtnRun.Image = Globals.LoadImage("play.png");
			MiPrjStop.Image = BtnStop.Image = Globals.LoadImage("stop.png");
			MiPrjClose.Image = BtnClosePrj.Image = Globals.LoadImage("cancel.png");
			MiPrjSettings.Image = BtnPrjSettings.Image = Globals.LoadImage("configure.png");
			MiCut.Image = BtnCut.Image = Globals.LoadImage("editcut.png");
			MiCopy.Image = BtnCopy.Image = Globals.LoadImage("editcopy.png");
			MiPaste.Image = BtnPaste.Image = Globals.LoadImage("editpaste.png");
			MiPrjSaveAll.Image = BtnSaveAll.Image = Globals.LoadImage("save_all.png");
			MiFileClose.Image = BtnFileClose.Image = Globals.LoadImage("fileclose.png");
			MiPrjBuildBurnRun.Image = BtnPrjBuildBurnRun.Image = Globals.LoadImage("launch.png");
			MiOpenExpl.Image = Globals.LoadImage("wizard.png");
			MiUndo.Image = BtnUndo.Image = Globals.LoadImage("undo.png");
			MiRedo.Image = BtnRedo.Image = Globals.LoadImage("redo.png");
			MiAbout.Image = Globals.LoadImage("CuruxaLogo_16x16.png");
			MiWebsite.Image = Globals.LoadImage("gohome.png");
			MiExit.Image = Globals.LoadImage("exit.png");
			TabsSrc.TabPages.Clear(); //remove demo tab page
			lblLoadingSrc.Visible = false;
		}

		private void MainWindow_Load(object sender, EventArgs e) {
			UpdateLabelPleaseWaitPosition();

			CheckForIllegalCrossThreadCalls = false;

			HttpDownloader.DownloadCuruxaWebsiteMenu();
			HttpDownloader.DownloadCommunityWebsiteMenu();

			//InstallManager.CheckVersionWeb();  Not used anymore. Now we use ClickOnce when available
		}

		/// <summary>
		/// Download the list of links shown at Curuxa's website and add them to a menu
		/// </summary>
		public void UpdateCuruxaWebsiteMenuLinks() {
			foreach(var section in HttpDownloader.CuruxaWebsiteMenu) {
				ToolStripMenuItem newSectionMenu = new ToolStripMenuItem(section.Key);
				foreach(var link in section.Value) {
					string linkText = link.Key;
					string linkUrl = link.Value;
					ToolStripMenuItem newMenuLink = new ToolStripMenuItem(linkText);
					newMenuLink.Click += delegate(object sender, EventArgs e) { OpenUrlExtern(linkUrl); };
					newSectionMenu.DropDownItems.Insert(newSectionMenu.DropDownItems.Count, newMenuLink);
				}
				if(MiHelp.DropDownItems.ContainsKey(newSectionMenu.Text)) MiHelp.DropDownItems.Remove(MiHelp.DropDownItems[newSectionMenu.Text]);
				MiHelp.DropDownItems.Insert(MiHelp.DropDownItems.IndexOf(tsSeparatorAfterCuruxa), newSectionMenu);
			}
		}

		/// <summary>
		/// Download the list of links shown at Curuxa Community website and add them to a menu
		/// </summary>
		public void UpdateCommunityWebsiteMenuLinks() {
			foreach(var section in HttpDownloader.CommunityWebsiteMenu) {
				if(section.Key == "Curuxa") continue;
				ToolStripMenuItem newSectionMenu = new ToolStripMenuItem(section.Key);
				foreach(var link in section.Value) {
					string linkText = link.Key;
					string linkUrl = link.Value;
					ToolStripMenuItem newMenuLink = new ToolStripMenuItem(linkText);
					newMenuLink.Click += delegate(object sender, EventArgs e) { OpenUrlExtern(linkUrl); };
					newSectionMenu.DropDownItems.Insert(newSectionMenu.DropDownItems.Count, newMenuLink);
				}
				if(MiHelp.DropDownItems.ContainsKey(newSectionMenu.Text)) MiHelp.DropDownItems.Remove(MiHelp.DropDownItems[newSectionMenu.Text]);
				MiHelp.DropDownItems.Insert(MiHelp.DropDownItems.IndexOf(tsSeparatorAfterCommunity), newSectionMenu);
			}
		}

		private void UpdateLabelPleaseWaitPosition() {
			lblLoadingSrc.Location = new Point(splitContainer2.SplitterDistance + TabsSrc.Width / 2 - lblLoadingSrc.Width / 2, splitContainer2.Location.Y + TabsSrc.Height / 2 - lblLoadingSrc.Height / 2);
		}

		/// <summary>
		/// Open a website with the default browser
		/// </summary>
		/// <param name="url"></param>
		private void OpenUrlExtern(string url) {
			System.Diagnostics.Process.Start(url);
		}

		public void UpdateLang() {
			MiFile.Text = i18n.str("File");
			MiNewPrj.Text = i18n.str("NewProject");
			MiOpenExpl.Text = i18n.str("NewPrjFromEx");
			MiFileSave.Text = i18n.str("Save");
			MiExit.Text = i18n.str("Exit");
			MiNewFile.Text = BtnNewFile.Text = i18n.str("NewFile");
			MiPrjAddFile.Text = BtnAddFilePrj.Text = i18n.str("AddExistingFile");
			MiPrjBuild.Text = BtnBuild.Text = i18n.str("Build");
			MiPrjProgram.Text = BtnProgramMCU.Text = i18n.str("Program");
			MiPrjRun.Text = BtnRun.Text = i18n.str("Run");
			MiPrjStop.Text = BtnStop.Text = i18n.str("Stop");
			MiPrjSettings.Text = i18n.str("Settings");
			MiHelp.Text = i18n.str("Help");
			MiWebsite.Text = i18n.str("Website");
			MiCuruxaCommunityWebsite.Text = i18n.str("CuruxaCommunity");
			MiAbout.Text = i18n.str("About");
			MiPrjClose.Text = i18n.str("Close");
			MiFileClose.Text = BtnFileClose.Text = i18n.str("CloseFile");
			MiPrint.Text = i18n.str("MenuPrint");
			MiUndo.Text = BtnUndo.Text = i18n.str("MenuUndo");
			MiRedo.Text = BtnRedo.Text = i18n.str("MenuRedo");
			MiCut.Text = BtnCut.Text = i18n.str("MenuCut");
			MiCopy.Text = BtnCopy.Text = i18n.str("MenuCopy");
			MiPaste.Text = BtnPaste.Text = i18n.str("MenuPaste");
			MiSelectAll.Text = i18n.str("MenuSelectAll");
			MiPrjSaveAll.Text = BtnSaveAll.Text = i18n.str("MenuSaveAll");
			MiLanguage.Text = i18n.str("MenuLanguage");
			BtnSaveFile.Text = i18n.str("SaveFile");
			BtnClosePrj.Text = i18n.str("ClosePrj");
			BtnPrjSettings.Text = i18n.str("PrjSettings");
			MiOpenPrj.Text = i18n.str("OpenPrj");
			MiCheckMB.Text = i18n.str("CheckMB");
			UpdateActivePrj(Globals.ActiveProject);
			TabMsgIDE.Text = i18n.str("IdeLog");
			TabBuildLog.Text = i18n.str("BuildLog");
			TabProgLog.Text = i18n.str("ProgLog");
			MiEdit.Text = i18n.str("MenuEdit");
			MiPrjBuildBurnRun.Text = BtnPrjBuildBurnRun.Text = i18n.str("BuildBurnRun");
			miInfoHelpIde.Text = i18n.str("infoHelpIde");
			CursorLocationChanged(new CursorLocation(0, 0));
			StatusProgrammer.Text = "";
			MiPreferences.Text = i18n.str("Preferences");
			MiPrintPreview.Text = i18n.str("PrintPreview");
			lblLoadingSrc.Text = i18n.str("loadingSrc");
		}

		string FormatLogText(string Text) {
			return string.Format("[{0:00}:{1:00}:{2:00}] {3}\n", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, Text);
		}

		/// <summary>
		/// Put some text into the Curuxa IDE log
		/// </summary>
		public void LogIDE(string Text) {
			LogIDE(Text, true);
		}

		/// <summary>
		/// Put some text into the Curuxa IDE log
		/// </summary>
		public void LogIDE(string Text, bool LogDebug) {
			if(LogDebug) Globals.Debug("[IDE] " + Text);

			//avoid null, empty, or all-spaces texts
			if(string.IsNullOrEmpty(Text)) return;
			for(int i = 0; i <= Text.Length; i++) {
				if(i == Text.Length) return;
				if(Text[i] != ' ') break;
			}

			if(IsClosing) return;

			TxtLogIDE.AppendText(FormatLogText(Text));
			TxtLogIDE.SelectionStart = TxtLogIDE.Text.Length - 1;
			TxtLogIDE.ScrollToCaret();
			LblStatus.Text = Text;
		}

		/// <summary>
		/// Put some text into the Curuxa IDE log
		/// </summary>
		public void LogIDE(string Text, params object[] p) {
			LogIDE(string.Format(Text, p));
		}

		bool LogBuildLocker = false;

		/// <summary>
		/// Put some text into the build log
		/// </summary>
		public void LogBuild(string Text) {
			Globals.Debug("[Build] " + Text);

			//avoid null, empty, or all-spaces texts
			if(string.IsNullOrEmpty(Text)) return;
			for(int i = 0; i <= Text.Length; i++) {
				if(i == Text.Length) return;
				if(Text[i] != ' ') break;
			}

			if(IsClosing) return;

			TxtLogBuild.AppendText(FormatLogText(Text));
			TxtLogBuild.SelectionStart = TxtLogIDE.Text.Length - 1;
			TxtLogBuild.ScrollToCaret();
		}

		/// <summary>
		/// Put some text into the programmer log
		/// </summary>
		public void LogProgrammer(string Text, params object[] p) {
			LogProgrammer(string.Format(Text, p));
		}

		/// <summary>
		/// Put some text into the programmer log
		/// </summary>
		public void LogProgrammer(string Text) {
			Globals.Debug("[Programmer] " + Text);

			//avoid null, empty, or all-spaces texts
			if(string.IsNullOrEmpty(Text)) return;
			for(int i = 0; i <= Text.Length; i++) {
				if(i == Text.Length) return;
				if(Text[i] != ' ') break;
			}

			if(IsClosing) return;

			TxtLogProgrammer.AppendText(FormatLogText(Text));
			TxtLogProgrammer.SelectionStart = TxtLogIDE.Text.Length - 1;
			TxtLogProgrammer.ScrollToCaret();
		}

		/// <summary>
		/// Put some text into the build log
		/// </summary>
		public void LogBuild(string Text, params object[] p) {
			LogBuild(string.Format(Text, p));
		}

		/// <summary>
		/// Set window title
		/// </summary>
		/// <param name="Text"></param>
		public void SetTitle(string Text) {
			string tail = "Curuxa IDE";
			if(string.IsNullOrEmpty(Text)) this.Text = tail;
			else this.Text = Text + " || " + tail;
		}

		/// <summary>
		/// Update list of projects
		/// </summary>
		///NOTE FOR DEVELOPERS: if we set regular fonts as default (for the treeview) and then we force the Parent Node to be bold, its text wouldn't be shown properly
		public void UpdatePrjList() {
			if(IsClosing) return;

			Font ChildrenFont = new Font(TreePrj.Font, FontStyle.Regular);

			TreeNode SelectedNode = TreePrj.SelectedNode;
			TreePrj.Nodes.Clear();
			TreePrj.BackColor = Settings.PrjListBackColor;
			foreach(Project prj in Project.OpenProjects) {
				TreeNode Parent = new TreeNode(prj.Name);
				Parent.ToolTipText = prj.Description;
				Parent.ImageKey = Parent.SelectedImageKey = "Project";

				//Main Board
				TreeNode TnMB = new TreeNode(prj.MainBoard.ToString());
				TnMB.NodeFont = ChildrenFont;
				TnMB.ForeColor = Settings.PrjListSettingsColor;
				TnMB.ToolTipText = i18n.str("PrjTreeTooltipMB", prj.MainBoard, prj.MainBoard.GetMCU());
				TnMB.ImageKey = TnMB.SelectedImageKey = "Info";
				Parent.Nodes.Add(TnMB);

				//Language
				TreeNode TnLang = new TreeNode(i18n.str("Language:") + " " + prj.Language.ToString());
				TnLang.NodeFont = ChildrenFont;
				TnLang.ForeColor = Settings.PrjListSettingsColor;
				TnLang.ToolTipText = i18n.str("PrjTreeTooltipLang", prj.Language);
				TnLang.ImageKey = TnLang.SelectedImageKey = "Info";
				Parent.Nodes.Add(TnLang);

				//WARNING: if you add more informative lines here, remember to update "LinesInfoPrjTree" constant

				//source files
				foreach(SrcFile src in prj.SrcFiles) {
					//TreeNode TnSrc = new TreeNode(src.FileName + ((src.Modified) ? " *" : "")); //use this for showing an asterisk on modified files
					TreeNode TnSrc = new TreeNode(src.FileName);
					TnSrc.NodeFont = ChildrenFont;
					TnSrc.ForeColor = Settings.PrjListSrcColor;
					TnSrc.ImageKey = TnSrc.SelectedImageKey = "Source";
					TnSrc.ToolTipText = src.FullPath;
					Parent.Nodes.Add(TnSrc);
				}

				//libraries
				foreach(SrcFile lib in prj.Libs) {
					TreeNode TnLib = new TreeNode(lib.FileName);
					TnLib.NodeFont = ChildrenFont;
					if(lib.IsReadOnly) TnLib.ForeColor = Settings.PrjListLibsColor;
					else TnLib.ForeColor = Settings.PrjListSrcColor;
					TnLib.ImageKey = TnLib.SelectedImageKey = "Library";
					TnLib.ToolTipText = lib.FullPath;
					Parent.Nodes.Add(TnLib);
				}

				TreePrj.Nodes.Add(Parent);
			}
			TreePrj.ExpandAll();
			if(Project.OpenProjects.Length > 0) {
				TreePrj.Enabled = true;
				if(SelectedNode != null) {
					//select previous node
					switch(SelectedNode.Level) {
						case 0:
							TreePrj.SelectedNode = TreePrj.Nodes[SelectedNode.Text];
							break;
						case 1:
							if(TreePrj.Nodes.ContainsKey(SelectedNode.Parent.Text)) {
								if(TreePrj.Nodes[SelectedNode.Parent.Text].Nodes.ContainsKey(SelectedNode.Text)) TreePrj.SelectedNode = TreePrj.Nodes[SelectedNode.Parent.Text].Nodes[SelectedNode.Text];
								else if(TreePrj.Nodes[SelectedNode.Parent.Text].Nodes.ContainsKey(SelectedNode.Text.Replace(" *", ""))) TreePrj.SelectedNode = TreePrj.Nodes[SelectedNode.Parent.Text].Nodes[SelectedNode.Text.Replace(" *", "")];
								else TreePrj.SelectedNode = TreePrj.Nodes[0];
							} else TreePrj.SelectedNode = TreePrj.Nodes[0];
							break;
						default:
							throw new NotImplementedException();
					}
				} else {
					//select first node
					TreePrj.SelectedNode = TreePrj.Nodes[0];
				}
			} else {
				TreePrj.Enabled = false;
				TreePrj.Nodes.Add(i18n.str("NoPrjAvail"));
			}
		}

		private void MiAbout_Click(object sender, EventArgs e) {
			AboutWindow.ShowDialog(this);
		}

		private void MiExit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void MiNewPrj_Click(object sender, EventArgs e) {
			Project NewProject = new Project();

			//Save Project As...
			SaveFileDialog SaveProjectDialog = new SaveFileDialog();
			SaveProjectDialog.AddExtension = true;
			SaveProjectDialog.FileName = i18n.str("NewPrjName");
			SaveProjectDialog.Filter = i18n.str("CrxPrjFilter");
			SaveProjectDialog.OverwritePrompt = true;
			SaveProjectDialog.RestoreDirectory = false;
			SaveProjectDialog.ShowHelp = false;
			SaveProjectDialog.Title = i18n.str("SavePrjAs");
			SaveProjectDialog.ValidateNames = true;
			if(SaveProjectDialog.ShowDialog(this) == DialogResult.Cancel) return;
			NewProject.PrjFilePath = SaveProjectDialog.FileName;

			//Project Settings
			FrmProjectSettings SettingsWindow = new FrmProjectSettings(NewProject);
			if(SettingsWindow.ShowDialog(this) == DialogResult.Cancel) return;

			FrmFileName FN = new FrmFileName(i18n.str("NewMainFileName") + "." + NewProject.Language.GetExtension());
			FN.ShowInTaskbar = true;
			if(FN.ShowDialog() == DialogResult.Cancel) return;
			string FileName = FN.TxtFileName.Text;
			if(string.IsNullOrEmpty(FileName)) FileName = "Undefined";
			if(!FileName.EndsWith("." + NewProject.Language.GetExtension())) FileName += "." + NewProject.Language.GetExtension();
			SrcFile MainFile = SrcFile.GetFromTemplate(NewProject, FileName, NewProject.MainBoard, NewProject.Language);
			NewProject.AddSrcFile(MainFile);

			//Add it to the list of open projects
			Project.Add(NewProject);
			NewProject.SaveAll();
			MainFile.SaveFile();
			Globals.LogIDE(i18n.str("NewEmptyPrj", NewProject.Path));
		}

		private void MiOpenExpl_Click(object sender, EventArgs e) {
			FrmNewPrjFromExample newExWin = new FrmNewPrjFromExample();
			if(newExWin.ShowDialog(this) == DialogResult.OK) {
				MessageBox.Show(i18n.str("warnOldExamples"), i18n.str("NewPrjFromEx"), MessageBoxButtons.OK, MessageBoxIcon.Warning);

				Example ex = newExWin.ChosenExample;
				Globals.LogIDE(i18n.str("GeneratingExample", ex.Project.Name));

				//load contents to memory so they get copied later
				string temp = "";
				foreach(SrcFile src in ex.Project.SrcFiles) temp = src.Content;

				Project NewPrj = ex.Project;
				NewPrj.PrjFilePath = newExWin.TxtPrjFile.Text;
				NewPrj.SaveAll();
				Project.Add(NewPrj);
			}
		}

		private void MiOpenPrj_Click(object sender, EventArgs e) {
			//Open Project...
			OpenFileDialog OpenProjectDialog = new OpenFileDialog();
			OpenProjectDialog.AddExtension = true;
			OpenProjectDialog.Filter = i18n.str("CrxPrjFilter");
			OpenProjectDialog.RestoreDirectory = false;
			OpenProjectDialog.ShowHelp = false;
			OpenProjectDialog.Title = i18n.str("OpenPrj");
			OpenProjectDialog.ValidateNames = true;
			OpenProjectDialog.ShowDialog(this);

			string PrjFile = OpenProjectDialog.FileName;
			Globals.LogIDE(i18n.str("OpeningPrj", PrjFile));
			Project.Open(PrjFile);
		}

		private void MiWebsite_Click(object sender, EventArgs e) {
			OpenUrlExtern("http://curuxa.org/");
		}

		private void FrmMainWindow_FormClosing(object sender, FormClosingEventArgs e) {
			IsClosing = true;
			foreach(Project prj in Project.OpenProjects) {
				CheckSavePrj(prj);
			}
			Settings.Save();
		}

		private void TreePrj_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
			if(e.Node.Level == 0) {
				Globals.ActiveProject = Project.OpenProjects.GetByName(e.Node.Text);
			} else if(e.Node.Level == 1) {
				Globals.ActiveProject = Project.OpenProjects.GetByName(e.Node.Parent.Text);
			}
		}

		private void TreePrj_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
			lblLoadingSrc.Visible = true; Update();
			if(e.Node.Level == 1) {
				//a file has just been selected
				Globals.ActiveProject = Project.OpenProjects.GetByName(e.Node.Parent.Text);

				//double click on source files
				if(e.Node.Index >= LinesInfoPrjTree) {
					if(Globals.ActiveProject.SrcFiles.ContainsFileName(e.Node.Text)) {
						TabsSrc.OpenSrc(Globals.ActiveProject.SrcFiles.GetByFileName(e.Node.Text));
					}
				}

				//double click on libraries
				if(e.Node.Index >= LinesInfoPrjTree && e.Node.Index >= (LinesInfoPrjTree + Globals.ActiveProject.SrcFiles.Count)) {
					if(Globals.ActiveProject.Libs.ContainsFileName(e.Node.Text)) {
						TabsSrc.OpenSrc(Globals.ActiveProject.Libs.GetByFileName(e.Node.Text));
					}
				}
			}
			lblLoadingSrc.Visible = false;
		}

		/// <summary>
		/// Update the GUI to match the options available for the current active project (if any)
		/// </summary>
		/// <param name="value">Active project</param>
		public void UpdateActivePrj(Project value) {
			if(value == null) {
				MiProject.Text = i18n.str("Project");
				MiProject.Enabled = false;
				StripPrj.Enabled = false;
				SetTitle("");
			} else {
				MiProject.Text = i18n.str("ProjectX", value.Name);
				MiProject.Enabled = true;
				StripPrj.Enabled = true;
				SetTitle(Globals.ActiveProject.Name);
			}
		}

		private void MiSave_Click(object sender, EventArgs e) {
			if(Globals.ActiveSrcFile != null) {
				Globals.ActiveSrcFile.SaveFile();
				if(TabsSrc.Tabs.ContainsKey(Globals.ActiveSrcFile)) TabsSrc.Tabs[Globals.ActiveSrcFile].UpdateTitle();
			}
		}

		private void MiPrjClose_Click(object sender, EventArgs e) {
			Project p = Globals.ActiveProject;
			CheckSavePrj(p);
			TabsSrc.RemoveAllFromPrj(p);
			p.Close();
		}

		/// <summary>
		/// Check if a project and its source files need to be save, and ask the user
		/// </summary>
		/// <param name="p"></param>
		private void CheckSavePrj(Project p) {
			//saving files
			foreach(SrcFile src in p.SrcFiles) {
				if(src.Modified) {
					DialogResult srcresult = MessageBox.Show(this, i18n.str("WantSaveFilePrj", src.FileName, p.Name), i18n.str("FileNotSaved"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
					if(srcresult == DialogResult.Yes) src.SaveFile();
					if(srcresult == DialogResult.Cancel) return;
				}
			}

			//saving project
			/*DialogResult presult = MessageBox.Show(this, i18n.str("WantSavePrj", p.Name), i18n.str("PrjNotSaved"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if(presult == DialogResult.Yes) p.Save();
			if(presult == DialogResult.Cancel) return;*/
			p.Save();
		}

		private void BtnNewFile_Click(object sender, EventArgs e) {
			MiNewFile.PerformClick();
		}

		private void BtnAddFIlePrj_Click(object sender, EventArgs e) {
			MiPrjAddFile.PerformClick();
		}

		private void BtnSaveFile_Click(object sender, EventArgs e) {
			MiFileSave.PerformClick();
		}

		private void BtnBuild_Click(object sender, EventArgs e) {
			MiPrjBuild.PerformClick();
		}

		private void BtnRun_Click(object sender, EventArgs e) {
			MiPrjRun.PerformClick();
		}

		private void BtnStop_Click(object sender, EventArgs e) {
			MiPrjStop.PerformClick();
		}

		private void BtnClosePrj_Click(object sender, EventArgs e) {
			MiPrjClose.PerformClick();
		}

		private void BtnConfigPrj_Click(object sender, EventArgs e) {
			MiPrjSettings.PerformClick();
		}

		private void MiPrjBuild_Click(object sender, EventArgs e) {
			if(Globals.ActiveProject == null) {
				LogIDE(i18n.str("NoActivePrj"));
			} else {
				Globals.ActiveProject.SaveAll();

				if(Globals.ActiveProject.Build() == 0) {
					LogIDE(i18n.str("BuildOk"));
					LogBuild(i18n.str("BuildOk"));
				} else {
					LogIDE(i18n.str("BuildFail"));
					LogBuild(i18n.str("BuildFail"));
					if(Globals.ActiveProject.Language.GetToolsuite().IsNotInstalled) {
						if(MessageBox.Show(i18n.str("reqAppNotInstalledNeedHelp"), "Curuxa IDE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
							OpenUrlExtern("http://curuxa.org/en/Downloads");
						}
					}
				}
			}
		}

		private void MiPrjSettings_Click(object sender, EventArgs e) {
			if(Globals.ActiveProject != null) {
				FrmProjectSettings frm = new FrmProjectSettings(Globals.ActiveProject);
				frm.ShowDialog(this);
				UpdatePrjList();
				Globals.ActiveProject.SaveAll();
			}
		}

		private void MiProgramPrj_Click(object sender, EventArgs e) {
			if(Globals.ActiveProject == null) {
				LogIDE(i18n.str("NoActivePrj"));
			} else {
				if(Globals.ActiveProject.Burn() == 0) {
					StatusProgrammer.Text = i18n.str("PrjProgrammed");
				}
			}
		}

		private void BtnProgramMCU_Click(object sender, EventArgs e) {
			MiPrjProgram.PerformClick();
		}

		private void MiRunPrj_Click(object sender, EventArgs e) {
			if(Globals.ActiveProject == null) {
				LogIDE(i18n.str("NoActivePrj"));
			} else {
				if(Globals.ActiveProject.Run() == 0) {
					StatusProgrammer.Text = i18n.str("PrjRun");
				}
			}
		}

		private void MiStopPrj_Click(object sender, EventArgs e) {
			if(Globals.ActiveProject == null) {
				LogIDE(i18n.str("NoActivePrj"));
			} else {
				if(Globals.ActiveProject.Stop() == 0) {
					StatusProgrammer.Text = i18n.str("PrjStopped");
				}
			}
		}

		public void CursorLocationChanged(CursorLocation c) {
			StatusLin.Text = i18n.str("LineX", c.Line);
			StatusCol.Text = i18n.str("ColX", c.Column);
		}

		private void MiClose_Click(object sender, EventArgs e) {
			TabsSrc.CloseSrc(Globals.ActiveSrcFile);
		}

		private void MiPrjSaveAll_Click(object sender, EventArgs e) {
			Globals.ActiveProject.SaveAll();
			foreach(KeyValuePair<SrcFile, SrcTabPage> pair in TabsSrc.Tabs) {
				pair.Value.UpdateTitle();
			}
		}

		private void BtnFileClose_Click(object sender, EventArgs e) {
			MiFileClose.PerformClick();
		}

		private void MiLangSpanish_Click(object sender, EventArgs e) {
			i18n.CurrentLanguage = "es";
			UpdateLang();
		}

		private void MiLangEnglish_Click(object sender, EventArgs e) {
			i18n.CurrentLanguage = "en";
			UpdateLang();
		}

		private void BtnUndo_Click(object sender, EventArgs e) {
			MiUndo.PerformClick();
		}

		private void MiUndo_Click(object sender, EventArgs e) {
			if(TabsSrc.SelectedTab != null) {
				//(TabsSrc.SelectedTab as SrcTabPage).TxtCode.Undo(); THIS DOESN'T WORK WHEN SYNTAX HIGHLIGHT IS ON
			}
		}

		private void MiRedo_Click(object sender, EventArgs e) {
			if(TabsSrc.SelectedTab != null) {
				//(TabsSrc.SelectedTab as SrcTabPage).TxtCode.Redo(); THIS DOESN'T WORK WHEN SYNTAX HIGHLIGHT IS ON
			}
		}

		private void BtnRedo_Click(object sender, EventArgs e) {
			MiRedo.PerformClick();
		}

		private void BtnSaveAll_Click(object sender, EventArgs e) {
			MiPrjSaveAll.PerformClick();
		}

		private void BtnCut_Click(object sender, EventArgs e) {
			MiCut.PerformClick();
		}

		private void MiCut_Click(object sender, EventArgs e) {
			if(TabsSrc.SelectedTab != null) {
				(TabsSrc.SelectedTab as SrcTabPage).TxtCode.Cut();
			}
		}

		private void BtnCopy_Click(object sender, EventArgs e) {
			MiCopy.PerformClick();
		}

		private void MiCopy_Click(object sender, EventArgs e) {
			if(TabsSrc.SelectedTab != null) {
				(TabsSrc.SelectedTab as SrcTabPage).TxtCode.Copy();
			}
		}

		private void BtnPaste_Click(object sender, EventArgs e) {
			MiPaste.PerformClick();
		}

		private void MiPaste_Click(object sender, EventArgs e) {
			if(TabsSrc.SelectedTab != null) {
				(TabsSrc.SelectedTab as SrcTabPage).TxtCode.Paste();
			}
		}

		private void BtnBuildBurnRun_Click(object sender, EventArgs e) {
			MiPrjBuildBurnRun.PerformClick();
		}

		private void MiBuildBurnRun_Click(object sender, EventArgs e) {
			Project p = Globals.ActiveProject;
			if(p != null) {
				MiPrjBuild.PerformClick();
				if(p.IsCompiled) MiPrjProgram.PerformClick();
				if(p.IsBurnt) MiPrjRun.PerformClick();
			}
		}

		private void MiNewFile_Click(object sender, EventArgs e) {

		}

		private void MiPrjAddFile_Click(object sender, EventArgs e) {

		}

		private void MiSelectAll_Click(object sender, EventArgs e) {
			if(TabsSrc.SelectedTab != null) {
				(TabsSrc.SelectedTab as SrcTabPage).TxtCode.SelectAll();
			}
		}

		private void MiCheckMB_Click(object sender, EventArgs e) {
			Microcontroller? DetectedMCU = Globals.ActiveProject.Programmer.GetProgrammerApp().Detect();
			TabsMsg.SelectedTab = TabMsgIDE;
			if(!DetectedMCU.HasValue) Globals.LogIDE(i18n.str("NoMcuDetected"));
			else {
				Globals.LogIDE(i18n.str("DetectedX", DetectedMCU.Value, DetectedMCU.Value.GetMainBoard()));
			}
		}

		#region printing
		string[] lines;
		private PrintDialog printDialog1;
		private PrintDocument printDocument1;
		private PageSetupDialog pageSetupDialog1;
		private PrintPreviewDialog printPreviewDialog1;
		bool PrintSetup = false;

		private void SetupPrint() {
			printDialog1 = new PrintDialog();
			printDocument1 = new PrintDocument();
			pageSetupDialog1 = new PageSetupDialog();

			printDialog1.Document = this.printDocument1;
			printDocument1.BeginPrint += new PrintEventHandler(OnBeginPrint);
			printDocument1.PrintPage += new PrintPageEventHandler(OnPrintPage);
			pageSetupDialog1.Document = this.printDocument1;

			printPreviewDialog1 = new PrintPreviewDialog();

			printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			printPreviewDialog1.Document = this.printDocument1;
			printPreviewDialog1.Enabled = true;
			//printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			printPreviewDialog1.Location = new System.Drawing.Point(88, 116);
			printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
			printPreviewDialog1.Name = i18n.str("PrintPreview");
			printPreviewDialog1.Opacity = 1;
			printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			printPreviewDialog1.Visible = false;

			PrintSetup = true;
		}

		private void MiPrint_Click(object sender, EventArgs e) {
			if(TabsSrc.SelectedTab == null) {
				LogIDE(i18n.str("NoSrcSelected"));
				return;
			}

			if(!PrintSetup) SetupPrint();

			if(printDialog1.ShowDialog() == DialogResult.OK) {
				printDocument1.Print();
			}
		}

		private void OnBeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
			char[] param = { '\n' };

			if(printDialog1.PrinterSettings.PrintRange == PrintRange.Selection) {
				lines = ((SrcTabPage)TabsSrc.SelectedTab).TxtCode.SelectedText.Split(param);
			} else {
				lines = ((SrcTabPage)TabsSrc.SelectedTab).TxtCode.Text.Split(param);
			}

			int i = 0;
			char[] trimParam = { '\r' };
			foreach(string s in lines) {
				lines[i++] = s.TrimEnd(trimParam);
			}
		}

		private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
			int linesPrinted = 0;
			int x = e.MarginBounds.Left;
			int y = e.MarginBounds.Top;
			Brush brush = new SolidBrush(((SrcTabPage)TabsSrc.SelectedTab).TxtCode.ForeColor);

			while(linesPrinted < lines.Length) {
				e.Graphics.DrawString(lines[linesPrinted++], ((SrcTabPage)TabsSrc.SelectedTab).TxtCode.Font, brush, x, y);
				y += 15;
				if(y >= e.MarginBounds.Bottom) {
					e.HasMorePages = true;
					return;
				}
			}

			linesPrinted = 0;
			e.HasMorePages = false;
		}

		private void MiPrintPreview_Click(object sender, EventArgs e) {
			if(TabsSrc.SelectedTab == null) {
				LogIDE(i18n.str("NoSrcSelected"));
				return;
			}

			if(!PrintSetup) SetupPrint();

			printPreviewDialog1.ShowDialog();
		}
		#endregion

		private void MiPreferences_Click(object sender, EventArgs e) {
			FrmIdeSettings frm = new FrmIdeSettings();
			frm.ShowDialog(this);
		}

		private void FrmMainWindow_Resize(object sender, EventArgs e) {
			UpdateLabelPleaseWaitPosition();
		}

		private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e) {
			UpdateLabelPleaseWaitPosition();
		}

		private void MiCuruxaCommunityWebsite_Click(object sender, EventArgs e) {
			OpenUrlExtern("http://community.curuxa.org/");
		}

		private void miInfoHelpIde_Click(object sender, EventArgs e) {
			OpenUrlExtern("http://curuxa.org/en/Curuxa_IDE");
		}
	}
}

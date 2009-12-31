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

namespace CuruxaIDE {
	public partial class FrmMainWindow:Form {
		FrmAbout AboutWindow = new FrmAbout();
		Timer TmrHighlight = new Timer();

		public FrmMainWindow() {
			InitializeComponent();
		}

		private void MainWindow_Load(object sender, EventArgs e) {
			UpdateLang();
			SetTitle("");
			InitSyntaxHighlight();
			Log(i18n.str("AppInitialized"));
			if(Project.OpenProjects.Length > 0) Globals.ActiveProject = Project.OpenProjects[0];
			UpdatePrjList();
			BtnNewFile.Image = Image.FromFile(Settings.ImagesDir + "/filenew.png");
			BtnAddFIlePrj.Image = Image.FromFile(Settings.ImagesDir + "/fileopen.png");
			BtnSaveFile.Image = Image.FromFile(Settings.ImagesDir + "/filesave.png");
			BtnBuild.Image = Image.FromFile(Settings.ImagesDir + "/exec.png");
			BtnProgramMCU.Image = Image.FromFile(Settings.ImagesDir + "/bottom.png");
			BtnRun.Image = Image.FromFile(Settings.ImagesDir + "/play.png");
			BtnStop.Image = Image.FromFile(Settings.ImagesDir + "/stop.png");
			BtnClosePrj.Image = Image.FromFile(Settings.ImagesDir + "/cancel.png");
			BtnConfigPrj.Image = Image.FromFile(Settings.ImagesDir + "/configure.png");

			TmrHighlight.Interval = 1000;
			TmrHighlight.Tick += new EventHandler(TmrHighlight_Tick);
			//TmrHighlight.Start(); //syntax highlight doesn't work properly
		}

		private void InitSyntaxHighlight() {
			TxtCode.Settings.Comment = "//";
			TxtCode.Settings.Keywords.Clear();
			TxtCode.Settings.Keywords.Add("auto");
			TxtCode.Settings.Keywords.Add("_Bool");
			TxtCode.Settings.Keywords.Add("break");
			TxtCode.Settings.Keywords.Add("case");
			TxtCode.Settings.Keywords.Add("char");
			TxtCode.Settings.Keywords.Add("_Complex");
			TxtCode.Settings.Keywords.Add("const");
			TxtCode.Settings.Keywords.Add("continue");
			TxtCode.Settings.Keywords.Add("default");
			TxtCode.Settings.Keywords.Add("do");
			TxtCode.Settings.Keywords.Add("double");
			TxtCode.Settings.Keywords.Add("else");
			TxtCode.Settings.Keywords.Add("enum");
			TxtCode.Settings.Keywords.Add("extern");
			TxtCode.Settings.Keywords.Add("float");
			TxtCode.Settings.Keywords.Add("for");
			TxtCode.Settings.Keywords.Add("goto");
			TxtCode.Settings.Keywords.Add("if");
			TxtCode.Settings.Keywords.Add("_Imaginary");
			TxtCode.Settings.Keywords.Add("inline");
			TxtCode.Settings.Keywords.Add("int");
			TxtCode.Settings.Keywords.Add("long");
			TxtCode.Settings.Keywords.Add("register");
			TxtCode.Settings.Keywords.Add("restrict");
			TxtCode.Settings.Keywords.Add("return");
			TxtCode.Settings.Keywords.Add("short");
			TxtCode.Settings.Keywords.Add("signed");
			TxtCode.Settings.Keywords.Add("sizeof");
			TxtCode.Settings.Keywords.Add("static");
			TxtCode.Settings.Keywords.Add("struct");
			TxtCode.Settings.Keywords.Add("switch");
			TxtCode.Settings.Keywords.Add("typedef");
			TxtCode.Settings.Keywords.Add("union");
			TxtCode.Settings.Keywords.Add("unsigned");
			TxtCode.Settings.Keywords.Add("void");
			TxtCode.Settings.Keywords.Add("volatile");
			TxtCode.Settings.Keywords.Add("while");
			TxtCode.CompileKeywords();
		}

		void TmrHighlight_Tick(object sender, EventArgs e) {
			if(TxtCode.Enabled) {
				SyntaxHighlight();
			}
		}

		private void UpdateLang() {
			MiFile.Text = i18n.str("File");
			MiNewPrj.Text = i18n.str("NewProject");
			MiOpenExpl.Text = i18n.str("NewPrjFromEx");
			MiSave.Text = i18n.str("Save");
			MiExit.Text = i18n.str("Exit");
			MiNewFile.Text = BtnNewFile.Text = i18n.str("NewFile");
			MiAddFilePrj.Text = BtnAddFIlePrj.Text = i18n.str("AddExistingFile");
			MiBuildPrj.Text = BtnBuild.Text = i18n.str("Build");
			MiProgramPrj.Text = BtnProgramMCU.Text = i18n.str("Program");
			MiRunPrj.Text = BtnRun.Text = i18n.str("Run");
			MiStopPrj.Text = BtnStop.Text = i18n.str("Stop");
			MiSettings.Text = i18n.str("Settings");
			MiHelp.Text = i18n.str("Help");
			MiWebsite.Text = i18n.str("Website");
			MiAbout.Text = i18n.str("About");
			MiPrjClose.Text = i18n.str("Close");
			BtnSaveFile.Text = i18n.str("SaveFile");
			BtnClosePrj.Text = i18n.str("ClosePrj");
			BtnConfigPrj.Text = i18n.str("PrjSettings");
			MiOpenPrj.Text = i18n.str("OpenPrj");
			UpdateActivePrj(Globals.ActiveProject);
			UpdateActiveSrc(Globals.ActiveSrcFile);
		}

		/// <summary>
		/// Put some text into the log
		/// </summary>
		public void Log(string Text) {
			Globals.Debug(Text);

			//avoid null, empty, or all-spaces texts
			if(string.IsNullOrEmpty(Text)) return;
			for(int i = 0; i <= Text.Length; i++) {
				if(i == Text.Length) return;
				if(Text[i] != ' ') break;
			}

			TxtLog.AppendText(string.Format("[{0:00}:{1:00}:{2:00}] {3}\n", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, Text));
			TxtLog.SelectionStart = TxtLog.Text.Length - 1;
			TxtLog.ScrollToCaret();
			LblStatus.Text = Text;
		}

		/// <summary>
		/// Put some text into the log
		/// </summary>
		public void Log(string Text, params object[] p) {
			Log(string.Format(Text, p));
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
		public void UpdatePrjList() {
			TreeNode SelectedNode = TreePrj.SelectedNode;
			TreePrj.Nodes.Clear();
			TreePrj.BackColor = Settings.PrjListBackColor;
			foreach(Project prj in Project.OpenProjects) {
				TreeNode Parent = new TreeNode(prj.Name);
				Parent.ToolTipText = prj.Description;
				Parent.NodeFont = new Font(TreePrj.Font, FontStyle.Bold);

				//Main Board
				TreeNode TnMB = new TreeNode(prj.MainBoard.ToString());
				TnMB.ForeColor = Settings.PrjListSettingsColor;
				Parent.Nodes.Add(TnMB);

				//Language
				TreeNode TnLang = new TreeNode(i18n.str("Language:") + " " + prj.Language.ToString());
				TnLang.ForeColor = Settings.PrjListSettingsColor;
				Parent.Nodes.Add(TnLang);

				//source files
				foreach(SrcFile src in prj.SrcFiles) {
					TreeNode TnSrc = new TreeNode(src.FileName + ((src.Modified) ? " *" : ""));
					//if(Globals.ActiveSrcFile != null && Globals.ActiveSrcFile.FileName == FileName) Child.NodeFont = new Font(Child.NodeFont, FontStyle.Bold);
					TnSrc.ForeColor = Settings.PrjListSrcColor;
					Parent.Nodes.Add(TnSrc);
				}

				//libraries
				TreeNode TnLib = new TreeNode("lib test");
				TnLib.ForeColor = Settings.PrjListLibsColor;
				Parent.Nodes.Add(TnLib);

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

			//Project Settings
			FrmProjectSettings SettingsWindow = new FrmProjectSettings(NewProject);
			if(SettingsWindow.ShowDialog(this) == DialogResult.Cancel) return;

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

			FrmFileName FN = new FrmFileName(i18n.str("NewMainFileName") + "." + NewProject.Language.GetExtension());
			FN.ShowInTaskbar = true;
			if(FN.ShowDialog() == DialogResult.Cancel) return;
			string FileName = FN.TxtFileName.Text;
			if(string.IsNullOrEmpty(FileName)) FileName = "Undefined";
			if(!FileName.EndsWith("." + NewProject.Language.GetExtension())) FileName += "." + NewProject.Language.GetExtension();
			SrcFile MainFile = new SrcFile(NewProject, FileName, NewProject.MainBoard, NewProject.Language);
			NewProject.AddSrcFile(MainFile);

			//Add it to the list of open projects
			Project.Add(NewProject);
			NewProject.Save();
			MainFile.SaveFile();
			Globals.Log(i18n.str("NewEmptyPrj", NewProject.Path));
		}

		private void MiOpenExpl_Click(object sender, EventArgs e) {
			FrmNewPrjFromExample win = new FrmNewPrjFromExample();
			if(win.ShowDialog(this) == DialogResult.OK) {
				Example ex = win.ChosenExample;
				Globals.Log(i18n.str("GeneratingExample", ex.Project.Name));
				
				//load contents to memory so they get copied later
				string temp = "";
				foreach(SrcFile src in ex.Project.SrcFiles) temp = src.Content;
				
				Project NewPrj = ex.Project;
				NewPrj.PrjFilePath = win.TxtPrjFile.Text;
				NewPrj.Save();
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
			Globals.Log(i18n.str("OpeningPrj", PrjFile));
			Project.Open(PrjFile);
		}

		private void MiWebsite_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start("http://curuxa.org/");
		}

		private void FrmMainWindow_FormClosing(object sender, FormClosingEventArgs e) {
			foreach(Project prj in Project.OpenProjects) {
				CheckSavePrj(prj);
			}
			Settings.Save();
		}

		private void TreePrj_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
			switch(e.Node.Level) {
				case 0:
					//a project has just been selected
					Globals.ActiveProject = Project.OpenProjects[e.Node.Index];
					break;
				case 1:
					//a file has just been selected
					Globals.ActiveProject = Project.OpenProjects[e.Node.Parent.Index];
					Globals.ActiveSrcFile = Globals.ActiveProject.SrcFiles[e.Node.Index];
					break;
				default:
					throw new NotImplementedException();
			}
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
			} else {
				MiProject.Text = i18n.str("ProjectX", value.Name);
				MiProject.Enabled = true;
				StripPrj.Enabled = true;
				SetTitle(Globals.ActiveProject.Name);
			}
		}

		/// <summary>
		/// Update the GUI to match the options available for the current active source file (if any)
		/// </summary>
		/// <param name="value">Active source file</param>
		public void UpdateActiveSrc(SrcFile value) {
			if(value == null) {
				TxtCode.Enabled = false;
				TxtCode.Text = i18n.str("NoSrcLoaded");
			} else {
				TxtCode.Enabled = true;
				TxtCode.Text = value.Content;
				SetTitle(Globals.ActiveProject.Name + " -> " + Globals.ActiveSrcFile.FileName);
			}
			TxtCode.ProcessAllLines();
		}

		Regex RxKeyWords = new Regex("at|bool|break|byte|case|char|config|const|continue|decimal|default|do|double|else|enum|false|float|for|goto|if|int|long|null|return|sbyte|short|signed|sizeof|stackalloc|static|string|struct|switch|this|true|typedef|typeof|uint|ulong|unsigned|ushort|volatile|void|while|");
		//Regex RxMultiLineComment = new Regex(@"/\*(.|[\r\n])*?\*/");
		Regex RxMultiLineComment = new Regex(@"/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/");

		/// <summary>
		/// Color for normal source code
		/// </summary>
		Color ColorCode = Color.Black;

		/// <summary>
		/// Color for keywords
		/// </summary>
		Color ColorKeywords = Color.Blue;

		/// <summary>
		/// Color for comments
		/// </summary>
		Color ColorComments = Color.Gray;

		void SyntaxHighlight() {
			int selPos = TxtCode.SelectionStart;

			//clear color
			TxtCode.SelectAll();
			TxtCode.SelectionColor = ColorCode;

			//put cursor at its original position
			TxtCode.SelectionStart = selPos;
			TxtCode.SelectionColor = ColorCode;

			HighlightMatches(RxKeyWords, ColorKeywords);
			HighlightMatches(RxMultiLineComment, ColorComments);
		}

		private void HighlightMatches(Regex regex, Color Color) {
			int selPos = TxtCode.SelectionStart;

			foreach(Match m in regex.Matches(TxtCode.Text)) {
				TxtCode.Select(m.Index, m.Length);
				TxtCode.SelectionColor = Color;
			}

			//put cursor at its original position
			TxtCode.SelectionStart = selPos;
			TxtCode.SelectionColor = ColorCode;
		}

		private void TxtCode_TextChanged(object sender, EventArgs e) {
			if(TxtCode.Enabled && Globals.ActiveSrcFile != null) {
				Globals.ActiveSrcFile.Modified = true;

				//update object contents
				Globals.ActiveSrcFile.Content = TxtCode.Text;
			}
			//TxtCode.ProcessChangedText();
		}

		private void MiSave_Click(object sender, EventArgs e) {
			if(Globals.ActiveSrcFile != null) {
				Globals.ActiveSrcFile.SaveFile();
			}
		}

		private void MiPrjClose_Click(object sender, EventArgs e) {
			Project p = Globals.ActiveProject;
			CheckSavePrj(p);
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
			MiAddFilePrj.PerformClick();
		}

		private void BtnSaveFile_Click(object sender, EventArgs e) {
			MiSave.PerformClick();
		}

		private void BtnBuild_Click(object sender, EventArgs e) {
			MiBuildPrj.PerformClick();
		}

		private void BtnRun_Click(object sender, EventArgs e) {
			MiRunPrj.PerformClick();
		}

		private void BtnStop_Click(object sender, EventArgs e) {
			MiStopPrj.PerformClick();
		}

		private void BtnClosePrj_Click(object sender, EventArgs e) {
			MiPrjClose.PerformClick();
		}

		private void BtnConfigPrj_Click(object sender, EventArgs e) {
			MiSettings.PerformClick();
		}

		private void MiBuildPrj_Click(object sender, EventArgs e) {
			Globals.ActiveSrcFile.SaveFile();
			if(Globals.ActiveProject.Build() == 0) Log(i18n.str("BuildOk"));
			else Log(i18n.str("BuildFail"));
		}

		private void MiSettings_Click(object sender, EventArgs e) {
			FrmProjectSettings frm = new FrmProjectSettings(Globals.ActiveProject);
			frm.ShowDialog(this);
			UpdatePrjList();
			Globals.ActiveProject.Save();
		}

		private void MiProgramPrj_Click(object sender, EventArgs e) {
			Globals.ActiveProject.Burn();
		}

		private void BtnProgramMCU_Click(object sender, EventArgs e) {
			MiProgramPrj.PerformClick();
		}

		private void MiRunPrj_Click(object sender, EventArgs e) {
			Globals.ActiveProject.Run();
		}

		private void MiStopPrj_Click(object sender, EventArgs e) {
			Globals.ActiveProject.Stop();
		}
	}
}

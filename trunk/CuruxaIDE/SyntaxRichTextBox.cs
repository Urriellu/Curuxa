using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Drawing;

namespace CuruxaIDE {
	public class SyntaxRichTextBox:System.Windows.Forms.RichTextBox {
		private SyntaxSettings m_settings = new SyntaxSettings();
		private static bool m_bPaint = true;
		private string m_strLine = "";
		private int m_nContentLength = 0;
		private int m_nLineLength = 0;
		private int m_nLineStart = 0;
		private int m_nLineEnd = 0;
		private string m_strKeywords = "";
		private int m_nCurSelection = 0;

		/// <summary>
		/// Syntax highlighter settings
		/// </summary>
		public SyntaxSettings Settings {
			get { return m_settings; }
		}

		/// <summary>
		/// WndProc
		/// </summary>
		/// <param name="m"></param>
		protected override void WndProc(ref System.Windows.Forms.Message m) {
			if(m.Msg == 0x00f) {
				if(m_bPaint) {
					base.WndProc(ref m);
				} else {
					m.Result = IntPtr.Zero;
				}
			} else {
				base.WndProc(ref m);
			}
		}

		/// <summary>
		/// ProcessChangedText
		/// </summary>
		public void ProcessChangedText() {
			// Calculate shit here.
			m_nContentLength = this.TextLength;

			int nCurrentSelectionStart = SelectionStart;
			int nCurrentSelectionLength = SelectionLength;

			m_bPaint = false;

			// Find the start of the current line.
			m_nLineStart = nCurrentSelectionStart;
			while((m_nLineStart > 0) && (Text[m_nLineStart - 1] != '\n'))
				m_nLineStart--;
			// Find the end of the current line.
			m_nLineEnd = nCurrentSelectionStart;
			while((m_nLineEnd < Text.Length) && (Text[m_nLineEnd] != '\n'))
				m_nLineEnd++;
			// Calculate the length of the line.
			m_nLineLength = m_nLineEnd - m_nLineStart;
			// Get the current line.
			m_strLine = Text.Substring(m_nLineStart, m_nLineLength);

			// Process this line.
			ProcessLine();

			m_bPaint = true;
		}

		/// <summary>
		/// Process a line.
		/// </summary>
		private void ProcessLine() {
			// Save the position and make the whole line black
			int nPosition = SelectionStart;
			SelectionStart = m_nLineStart;
			SelectionLength = m_nLineLength;
			SelectionColor = Color.Black;

			bool IsPPD = false;

			// Process the keywords
			ProcessRegex(m_strKeywords, Settings.KeywordColor);

			//Process preprocessor directives
			/*if(Settings.EnablePPD) {
				if(m_strLine[0]=='#') {
					IsPPD = true;
					SelectionStart = m_nLineStart;
					SelectionLength = m_nLineLength-1;
					SelectionColor = Settings.PPDColor;
				}
			}*/

			// Process numbers
			if(Settings.EnableIntegers && !IsPPD) ProcessRegex("\\b(?:[0-9]*\\.)?[0-9]+\\b", Settings.IntegerColor);

			// Process strings
			if(Settings.EnableStrings && !IsPPD) ProcessRegex("\"[^\"\\\\\\r\\n]*(?:\\\\.[^\"\\\\\\r\\n]*)*\"", Settings.StringColor);

			// Process comments
			if(Settings.EnableComments && !string.IsNullOrEmpty(Settings.Comment) && !IsPPD) ProcessRegex(Settings.Comment + ".*$", Settings.CommentColor);

			SelectionStart = nPosition;
			SelectionLength = 0;
			SelectionColor = Color.Black;

			m_nCurSelection = nPosition;
		}
		/// <summary>
		/// Process a regular expression.
		/// </summary>
		/// <param name="strRegex">The regular expression.</param>
		/// <param name="color">The color.</param>
		private void ProcessRegex(string strRegex, Color color) {
			Regex regKeywords = new Regex(strRegex, RegexOptions.IgnoreCase | RegexOptions.Compiled);
			Match regMatch;

			for(regMatch = regKeywords.Match(m_strLine); regMatch.Success; regMatch = regMatch.NextMatch()) {
				// Process the words
				int nStart = m_nLineStart + regMatch.Index;
				int nLenght = regMatch.Length;
				SelectionStart = nStart;
				SelectionLength = nLenght;
				SelectionColor = color;
			}
		}
		/// <summary>
		/// Compiles the keywords as a regular expression.
		/// </summary>
		public void CompileKeywords() {
			for(int i = 0; i < Settings.Keywords.Count; i++) {
				string strKeyword = Settings.Keywords[i];

				if(i == Settings.Keywords.Count - 1)
					m_strKeywords += "\\b" + strKeyword + "\\b";
				else
					m_strKeywords += "\\b" + strKeyword + "\\b|";
			}
		}

		public void ProcessAllLines() {
			m_bPaint = false;

			int nStartPos = 0;
			int i = 0;
			int nOriginalPos = SelectionStart;
			while(i < Lines.Length) {
				m_strLine = Lines[i];
				m_nLineStart = nStartPos;
				m_nLineEnd = m_nLineStart + m_strLine.Length;

				ProcessLine();
				i++;

				nStartPos += m_strLine.Length + 1;
			}

			m_bPaint = true;
		}
	}

	/// <summary>
	/// Class to store syntax objects in.
	/// </summary>
	public class SyntaxList {
		public List<string> m_rgList = new List<string>();
		public Color m_color = new Color();
	}

	/// <summary>
	/// Settings for the keywords and colors
	/// </summary>
	public class SyntaxSettings {
		SyntaxList m_rgKeywords = new SyntaxList();

		#region Properties
		/// <summary>
		/// A list containing all keywords.
		/// </summary>
		public List<string> Keywords {
			get { return m_rgKeywords.m_rgList; }
		}

		/// <summary>
		/// The color of keywords.
		/// </summary>
		public Color KeywordColor = Color.Blue;

		/// <summary>
		/// A string containing the comment identifier
		/// </summary>
		public string Comment = "";

		/// <summary>
		/// The color of comments.
		/// </summary>
		public Color CommentColor=Color.Green;

		/// <summary>
		/// Enables processing of comments if set to true
		/// </summary>
		public bool EnableComments =true;

		/// <summary>
		/// Enables processing of integers if set to true
		/// </summary>
		public bool EnableIntegers =true;

		/// <summary>
		/// Enables processing of strings if set to true
		/// </summary>
		public bool EnableStrings=true;

		/// <summary>
		/// Enables processing of preprocessor directives if set to true
		/// </summary>
		public bool EnablePPD = true;

		/// <summary>
		/// The color of strings
		/// </summary>
		public Color StringColor = Color.DarkRed;

		/// <summary>
		/// The color of integers
		/// </summary>
		public Color IntegerColor = Color.DarkGreen;

		/// <summary>
		/// The color of preprocessor directives
		/// </summary>
		public Color PPDColor = Color.Green;
		#endregion
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using krnlss;
using Microsoft.CSharp.RuntimeBinder;

namespace Controls
{
	// Token: 0x0200000E RID: 14
	public class MonacoCustomTabControl : TabControl
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00007C6E File Offset: 0x00005E6E
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00007C76 File Offset: 0x00005E76
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the selected page")]
		public Color ActiveColor
		{
			get
			{
				return this.activeColor;
			}
			set
			{
				this.activeColor = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00007C7F File Offset: 0x00005E7F
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00007C87 File Offset: 0x00005E87
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the background of the tab")]
		public Color BackTabColor
		{
			get
			{
				return this.backTabColor;
			}
			set
			{
				this.backTabColor = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00007C90 File Offset: 0x00005E90
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00007C98 File Offset: 0x00005E98
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the border of the control")]
		public Color BorderColor
		{
			get
			{
				return this.borderColor;
			}
			set
			{
				this.borderColor = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00007CA1 File Offset: 0x00005EA1
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00007CA9 File Offset: 0x00005EA9
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the closing button")]
		public Color ClosingButtonColor
		{
			get
			{
				return this.closingButtonColor;
			}
			set
			{
				this.closingButtonColor = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00007CB2 File Offset: 0x00005EB2
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00007CBA File Offset: 0x00005EBA
		[Category("Options")]
		[Browsable(true)]
		[Description("The message that will be shown before closing.")]
		public string ClosingMessage
		{
			get
			{
				return this.closingMessage;
			}
			set
			{
				this.closingMessage = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00007CC3 File Offset: 0x00005EC3
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00007CCB File Offset: 0x00005ECB
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the header.")]
		public Color HeaderColor
		{
			get
			{
				return this.headerColor;
			}
			set
			{
				this.headerColor = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00007CD4 File Offset: 0x00005ED4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00007CDC File Offset: 0x00005EDC
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the horizontal line which is located under the headers of the pages.")]
		public Color HorizontalLineColor
		{
			get
			{
				return this.horizLineColor;
			}
			set
			{
				this.horizLineColor = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00007CE5 File Offset: 0x00005EE5
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00007CED File Offset: 0x00005EED
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the title of the page")]
		public Color SelectedTextColor
		{
			get
			{
				return this.selectedTextColor;
			}
			set
			{
				this.selectedTextColor = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00007CF6 File Offset: 0x00005EF6
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00007CFE File Offset: 0x00005EFE
		public bool ShowClosingButton { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00007D07 File Offset: 0x00005F07
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00007D0F File Offset: 0x00005F0F
		[Category("Options")]
		[Browsable(true)]
		[Description("Show a Yes/No message before closing?")]
		public bool ShowClosingMessage { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00007D18 File Offset: 0x00005F18
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00007D20 File Offset: 0x00005F20
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the title of the page")]
		public Color TextColor
		{
			get
			{
				return this.textColor;
			}
			set
			{
				this.textColor = value;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007D2C File Offset: 0x00005F2C
		public MonacoCustomTabControl()
		{
			this.InitializeChromium();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.SizeMode = TabSizeMode.Normal;
			base.ItemSize = new Size(240, 16);
			this.AllowDrop = true;
			base.Selecting += this.TabChanging;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007E42 File Offset: 0x00006042
		public void AddEvent(string name = "Script.lua", string content = "")
		{
			this.addnewtab();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007E4C File Offset: 0x0000604C
		public void AddIntellisense(ChromiumWebBrowser chrome, string p1, string p2, string p3, string p4)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				try
				{
					WebBrowserExtensions.ExecuteScriptAsyncWhenPageLoaded(chrome, string.Concat(new string[]
					{
						"AddIntellisense('",
						p1,
						"', '",
						p2,
						"', '",
						p3,
						"', '",
						p4,
						"')"
					}), true);
				}
				catch
				{
				}
			}));
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007E98 File Offset: 0x00006098
		public void addnewtab()
		{
			int num = base.TabCount - 1;
			base.TabPages.Insert(num, string.Format("Script{0}.lua", base.TabCount));
			base.SelectTab(base.TabPages[num]);
			((Control)this.browser).Parent = base.TabPages[num];
			base.SelectedIndex = num;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007F04 File Offset: 0x00006104
		public void CloseTab(TabPage tab)
		{
			Control control = tab.Controls[0];
			int num = base.TabPages.IndexOf(tab);
			if (num != 0 || base.TabCount > 2)
			{
				base.TabPages.RemoveAt(num);
				this.count--;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00007F51 File Offset: 0x00006151
		public ChromiumWebBrowser GetWorkingTextEditor()
		{
			TabPage selectedTab = base.SelectedTab;
			return this.browser;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00007F60 File Offset: 0x00006160
		public void InitializeChromium()
		{
			if (!Cef.IsInitialized)
			{
				Cef.Initialize(new CefSettings
				{
					BrowserSubprocessPath = Path.Combine(Environment.CurrentDirectory, "bin", "src", "CefSharp.BrowserSubprocess.exe"),
					LocalesDirPath = Path.Combine(Environment.CurrentDirectory, "bin", "src", "locales"),
					ResourcesDirPath = Path.Combine(Environment.CurrentDirectory, "bin", "src")
				});
			}
			this.browser = new ChromiumWebBrowser(Environment.CurrentDirectory.Replace("\\", "/") + "/bin/Monaco/Monaco.html", null);
			((Control)this.browser).Dock = DockStyle.Fill;
			((Control)this.browser).BringToFront();
			this.browser.LoadingStateChanged += delegate(object o, LoadingStateChangedEventArgs e)
			{
				if (!e.IsLoading && this.browser.CanExecuteJavascriptInMainFrame)
				{
					base.Invoke(new MethodInvoker(delegate()
					{
						((Control)this.browser).Visible = true;
						Intellisense.addIntellisense(this.browser);
					}));
				}
			};
			this.browser.BrowserSettings.WindowlessFrameRate = 120;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000804B File Offset: 0x0000624B
		public void addScript(string content)
		{
			Program.tabScripts.Add(content);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008058 File Offset: 0x00006258
		public bool OpenFileDialog(TabPage tab)
		{
			bool result;
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					WebBrowserExtensions.ExecuteScriptAsync(this.GetWorkingTextEditor(), "SetText", new object[]
					{
						File.ReadAllText(openFileDialog.FileName)
					});
					tab.Text = Path.GetFileName(openFileDialog.FileName);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000080E0 File Offset: 0x000062E0
		public string OpenSaveDialog(TabPage tab, string text)
		{
			string result;
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
				saveFileDialog.RestoreDirectory = true;
				saveFileDialog.FileName = tab.Text;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(saveFileDialog.FileName, WebBrowserExtensions.EvaluateScriptAsync(this.GetWorkingTextEditor(), "GetText", new object[0]).GetAwaiter().GetResult().Result.ToString());
					result = new FileInfo(saveFileDialog.FileName).Name;
				}
				else
				{
					result = tab.Text;
				}
			}
			return result;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000818C File Offset: 0x0000638C
		public void TabChanging(object sender, TabControlCancelEventArgs e)
		{
			if (this.browser != null && !this.browser.IsLoading && this.browser.IsBrowserInitialized && this.browser.CanExecuteJavascriptInMainFrame && this.realIndex >= 0)
			{
				if (MonacoCustomTabControl.removed)
				{
					Program.tabScripts.RemoveAt(MonacoCustomTabControl.removeIdx);
				}
				if (MonacoCustomTabControl.removeIdx != this.realIndex)
				{
					Console.WriteLine(this.realIndex.ToString() + " | " + Program.tabScripts[this.realIndex]);
					string text = WebBrowserExtensions.EvaluateScriptAsync(this.browser, "GetText", new object[0]).GetAwaiter().GetResult().Result.ToString();
					Program.tabScripts[this.realIndex] = ((text != "-- Krnl Monaco") ? text : Program.tabScripts[this.realIndex]);
				}
				MonacoCustomTabControl.removed = false;
				MonacoCustomTabControl.removeIdx = -1;
			}
			if (Program.tabScripts.Count < e.TabPageIndex + 1)
			{
				Program.tabScripts.Add("-- Krnl Monaco");
			}
			if (e.TabPageIndex == base.TabCount - 1)
			{
				e.Cancel = true;
				return;
			}
			if (e.Action == TabControlAction.Selecting)
			{
				if (!this.browser.IsLoading && this.browser.IsBrowserInitialized)
				{
					WebBrowserExtensions.ExecuteScriptAsync(this.browser, "SetText", new object[]
					{
						Program.tabScripts[e.TabPageIndex]
					});
					((Control)this.browser).Parent = this.GetPointedTab();
				}
				this.realIndex = e.TabPageIndex;
				WebBrowserExtensions.ExecuteScriptAsyncWhenPageLoaded(this.browser, "SetText(`" + Program.tabScripts[this.realIndex].Replace("`", "\\`") + "`)", true);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000837F File Offset: 0x0000657F
		protected override void CreateHandle()
		{
			base.CreateHandle();
			base.Alignment = TabAlignment.Top;
			MonacoCustomTabControl.SendMessage(base.Handle, 4913, IntPtr.Zero, (IntPtr)16);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000083AC File Offset: 0x000065AC
		public static void Swap<T>(IList<T> list, int indexA, int indexB)
		{
			T value = list[indexA];
			list[indexA] = list[indexB];
			list[indexB] = value;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000083D7 File Offset: 0x000065D7
		protected override void OnDragOver(DragEventArgs drgevent)
		{
			base.OnDragOver(drgevent);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000083E0 File Offset: 0x000065E0
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.predraggedTab = this.GetPointedTab();
			Point location = e.Location;
			for (int i = 0; i < base.TabCount; i++)
			{
				object obj = base.GetTabRect(i);
				if (MonacoCustomTabControl.<>o__67.<>p__2 == null)
				{
					MonacoCustomTabControl.<>o__67.<>p__2 = CallSite<Action<CallSite, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Offset", null, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Action<CallSite, object, object, int> target = MonacoCustomTabControl.<>o__67.<>p__2.Target;
				CallSite <>p__ = MonacoCustomTabControl.<>o__67.<>p__2;
				object arg = obj;
				if (MonacoCustomTabControl.<>o__67.<>p__1 == null)
				{
					MonacoCustomTabControl.<>o__67.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Subtract, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target2 = MonacoCustomTabControl.<>o__67.<>p__1.Target;
				CallSite <>p__2 = MonacoCustomTabControl.<>o__67.<>p__1;
				if (MonacoCustomTabControl.<>o__67.<>p__0 == null)
				{
					MonacoCustomTabControl.<>o__67.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Width", typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, arg, target2(<>p__2, MonacoCustomTabControl.<>o__67.<>p__0.Target(MonacoCustomTabControl.<>o__67.<>p__0, obj), 15), 2);
				if (MonacoCustomTabControl.<>o__67.<>p__3 == null)
				{
					MonacoCustomTabControl.<>o__67.<>p__3 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Width", typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				MonacoCustomTabControl.<>o__67.<>p__3.Target(MonacoCustomTabControl.<>o__67.<>p__3, obj, 10);
				if (MonacoCustomTabControl.<>o__67.<>p__4 == null)
				{
					MonacoCustomTabControl.<>o__67.<>p__4 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Height", typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				MonacoCustomTabControl.<>o__67.<>p__4.Target(MonacoCustomTabControl.<>o__67.<>p__4, obj, 10);
				if (MonacoCustomTabControl.<>o__67.<>p__6 == null)
				{
					MonacoCustomTabControl.<>o__67.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target3 = MonacoCustomTabControl.<>o__67.<>p__6.Target;
				CallSite <>p__3 = MonacoCustomTabControl.<>o__67.<>p__6;
				if (MonacoCustomTabControl.<>o__67.<>p__5 == null)
				{
					MonacoCustomTabControl.<>o__67.<>p__5 = CallSite<Func<CallSite, object, Point, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				object arg2 = target3(<>p__3, MonacoCustomTabControl.<>o__67.<>p__5.Target(MonacoCustomTabControl.<>o__67.<>p__5, obj, location));
				if (MonacoCustomTabControl.<>o__67.<>p__9 == null)
				{
					MonacoCustomTabControl.<>o__67.<>p__9 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (!MonacoCustomTabControl.<>o__67.<>p__9.Target(MonacoCustomTabControl.<>o__67.<>p__9, arg2))
				{
					if (MonacoCustomTabControl.<>o__67.<>p__8 == null)
					{
						MonacoCustomTabControl.<>o__67.<>p__8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target4 = MonacoCustomTabControl.<>o__67.<>p__8.Target;
					CallSite <>p__4 = MonacoCustomTabControl.<>o__67.<>p__8;
					if (MonacoCustomTabControl.<>o__67.<>p__7 == null)
					{
						MonacoCustomTabControl.<>o__67.<>p__7 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					if (!target4(<>p__4, MonacoCustomTabControl.<>o__67.<>p__7.Target(MonacoCustomTabControl.<>o__67.<>p__7, arg2, e.Button != MouseButtons.Left)))
					{
						if (i != base.TabCount - 1)
						{
							this.predraggedTab = null;
							TabPage tabPage = base.TabPages[i];
							if (!this.ShowClosingMessage)
							{
								if (base.TabCount == 2)
								{
									if (MessageBox.Show("Are you sure you want to clear this tab?\nThe reason why you see this prompt is because there is only one tab currently opened.", "SINGLE TAB DETECTED", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
									{
										Program.tabScripts[0] = "";
										tabPage.Text = "Untitled.lua";
										ChromiumWebBrowser workingTextEditor = this.GetWorkingTextEditor();
										object[] array = new string[]
										{
											""
										};
										object[] array2 = array;
										WebBrowserExtensions.ExecuteScriptAsync(workingTextEditor, "SetText", array2);
									}
									return;
								}
								if (tabPage.Controls.Count <= 0)
								{
									break;
								}
								((Control)this.browser).Parent = null;
								MonacoCustomTabControl.removeIdx = i;
								MonacoCustomTabControl.removed = true;
								tabPage.Dispose();
								int index = (base.TabPages.Count - 2 > 2) ? 1 : 0;
								if (base.TabPages.Count - 2 > 0)
								{
									TabPage tabPage2 = base.TabPages[index];
									base.SelectTab(tabPage2);
									((Control)this.browser).Parent = tabPage2;
									break;
								}
								break;
							}
							else
							{
								MessageBox.Show("Changing tab?");
							}
						}
						else if (base.GetTabRect(base.TabCount - 1).Contains(e.Location))
						{
							this.AddEvent("Script.lua", "");
							this.predraggedTab = null;
							break;
						}
					}
				}
			}
			base.OnMouseDown(e);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000088DA File Offset: 0x00006ADA
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000088E4 File Offset: 0x00006AE4
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.predraggedTab = null;
			this.contextTab = null;
			if (e.Button == MouseButtons.Right)
			{
				MonacoCustomTabControl.Form1.TabContextMenu.Show(Cursor.Position);
				this.contextTab = this.GetPointedTab();
			}
			base.OnMouseUp(e);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00008934 File Offset: 0x00006B34
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(this.headerColor);
			try
			{
				base.SelectedTab.BackColor = this.backTabColor;
			}
			catch
			{
			}
			try
			{
				base.SelectedTab.BorderStyle = BorderStyle.None;
			}
			catch
			{
			}
			for (int i = 0; i <= base.TabCount - 1; i++)
			{
				TabPage tabPage = base.TabPages[i];
				int num = tabPage.Width = (int)e.Graphics.MeasureString(tabPage.Text, this.Font).Width + 16;
				Rectangle rectangle = new Rectangle(new Point(base.GetTabRect(i).Location.X + 2, base.GetTabRect(i).Location.Y), new Size(base.GetTabRect(i).Width, base.GetTabRect(i).Height));
				Rectangle rectangle2 = new Rectangle(rectangle.Location, new Size(rectangle.Width, rectangle.Height));
				Brush brush = new SolidBrush(this.closingButtonColor);
				if (i != base.SelectedIndex)
				{
					graphics.DrawString(tabPage.Text, this.Font, new SolidBrush(this.textColor), rectangle2, this.CenterSringFormat);
				}
				else
				{
					graphics.FillRectangle(new SolidBrush(this.headerColor), rectangle2);
					graphics.FillRectangle(new SolidBrush(Color.FromArgb(36, 36, 36)), new Rectangle(rectangle.X - 5, rectangle.Y - 3, rectangle.Width, rectangle.Height + 5));
					graphics.DrawString(tabPage.Text, this.Font, new SolidBrush(this.selectedTextColor), rectangle2, this.CenterSringFormat);
				}
				if (i != base.TabCount - 1)
				{
					if (this.ShowClosingButton)
					{
						e.Graphics.DrawString("X", this.Font, brush, (float)(rectangle2.Right - 17), 3f);
					}
				}
				else
				{
					using (Font font = new Font(SystemFonts.DefaultFont.FontFamily, 14f, FontStyle.Bold))
					{
						e.Graphics.DrawString("+", font, brush, (float)(rectangle2.Right - 22), (float)(rectangle2.Top / 2 - 4));
					}
				}
				brush.Dispose();
			}
			graphics.DrawLine(new Pen(Color.FromArgb(36, 36, 36), 5f), new Point(0, 19), new Point(base.Width, 19));
			graphics.FillRectangle(new SolidBrush(this.backTabColor), new Rectangle(0, 20, base.Width, base.Height - 20));
			graphics.DrawRectangle(new Pen(this.borderColor, 2f), new Rectangle(0, 0, base.Width, base.Height));
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		}

		// Token: 0x060000B5 RID: 181
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x060000B6 RID: 182 RVA: 0x00008C70 File Offset: 0x00006E70
		private void DragDropHandler(object sender, DragEventArgs e)
		{
			foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop, false))
			{
				this.AddEvent(Path.GetFileNameWithoutExtension(path), File.ReadAllText(path));
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00008CB8 File Offset: 0x00006EB8
		private void DragOverEnterHandler(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008CDC File Offset: 0x00006EDC
		private TabPage GetPointedTab()
		{
			for (int i = 0; i <= base.TabPages.Count - 1; i++)
			{
				if (base.GetTabRect(i).Contains(base.PointToClient(Cursor.Position)))
				{
					return base.TabPages[i];
				}
			}
			return null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00008D2C File Offset: 0x00006F2C
		private void ReplaceTabPages(TabPage Source, TabPage Destination)
		{
			object obj = base.TabPages.IndexOf(Source);
			object obj2 = base.TabPages.IndexOf(Destination);
			if (MonacoCustomTabControl.<>o__75.<>p__0 == null)
			{
				MonacoCustomTabControl.<>o__75.<>p__0 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			object obj3 = MonacoCustomTabControl.<>o__75.<>p__0.Target(MonacoCustomTabControl.<>o__75.<>p__0, obj, -1);
			if (MonacoCustomTabControl.<>o__75.<>p__1 == null)
			{
				MonacoCustomTabControl.<>o__75.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (!MonacoCustomTabControl.<>o__75.<>p__1.Target(MonacoCustomTabControl.<>o__75.<>p__1, obj3))
			{
				if (MonacoCustomTabControl.<>o__75.<>p__4 == null)
				{
					MonacoCustomTabControl.<>o__75.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = MonacoCustomTabControl.<>o__75.<>p__4.Target;
				CallSite <>p__ = MonacoCustomTabControl.<>o__75.<>p__4;
				if (MonacoCustomTabControl.<>o__75.<>p__3 == null)
				{
					MonacoCustomTabControl.<>o__75.<>p__3 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Or, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target2 = MonacoCustomTabControl.<>o__75.<>p__3.Target;
				CallSite <>p__2 = MonacoCustomTabControl.<>o__75.<>p__3;
				object arg = obj3;
				if (MonacoCustomTabControl.<>o__75.<>p__2 == null)
				{
					MonacoCustomTabControl.<>o__75.<>p__2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (!target(<>p__, target2(<>p__2, arg, MonacoCustomTabControl.<>o__75.<>p__2.Target(MonacoCustomTabControl.<>o__75.<>p__2, obj2, -1))))
				{
					if (MonacoCustomTabControl.<>o__75.<>p__5 == null)
					{
						MonacoCustomTabControl.<>o__75.<>p__5 = CallSite<Func<CallSite, TabControl.TabPageCollection, object, TabPage, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					MonacoCustomTabControl.<>o__75.<>p__5.Target(MonacoCustomTabControl.<>o__75.<>p__5, base.TabPages, obj2, Source);
					if (MonacoCustomTabControl.<>o__75.<>p__6 == null)
					{
						MonacoCustomTabControl.<>o__75.<>p__6 = CallSite<Func<CallSite, TabControl.TabPageCollection, object, TabPage, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					MonacoCustomTabControl.<>o__75.<>p__6.Target(MonacoCustomTabControl.<>o__75.<>p__6, base.TabPages, obj, Destination);
					if (MonacoCustomTabControl.<>o__75.<>p__8 == null)
					{
						MonacoCustomTabControl.<>o__75.<>p__8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target3 = MonacoCustomTabControl.<>o__75.<>p__8.Target;
					CallSite <>p__3 = MonacoCustomTabControl.<>o__75.<>p__8;
					if (MonacoCustomTabControl.<>o__75.<>p__7 == null)
					{
						MonacoCustomTabControl.<>o__75.<>p__7 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (target3(<>p__3, MonacoCustomTabControl.<>o__75.<>p__7.Target(MonacoCustomTabControl.<>o__75.<>p__7, base.SelectedIndex, obj)))
					{
						if (MonacoCustomTabControl.<>o__75.<>p__9 == null)
						{
							MonacoCustomTabControl.<>o__75.<>p__9 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(MonacoCustomTabControl)));
						}
						base.SelectedIndex = MonacoCustomTabControl.<>o__75.<>p__9.Target(MonacoCustomTabControl.<>o__75.<>p__9, obj2);
					}
					else
					{
						if (MonacoCustomTabControl.<>o__75.<>p__11 == null)
						{
							MonacoCustomTabControl.<>o__75.<>p__11 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target4 = MonacoCustomTabControl.<>o__75.<>p__11.Target;
						CallSite <>p__4 = MonacoCustomTabControl.<>o__75.<>p__11;
						if (MonacoCustomTabControl.<>o__75.<>p__10 == null)
						{
							MonacoCustomTabControl.<>o__75.<>p__10 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(MonacoCustomTabControl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (target4(<>p__4, MonacoCustomTabControl.<>o__75.<>p__10.Target(MonacoCustomTabControl.<>o__75.<>p__10, base.SelectedIndex, obj2)))
						{
							if (MonacoCustomTabControl.<>o__75.<>p__12 == null)
							{
								MonacoCustomTabControl.<>o__75.<>p__12 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(MonacoCustomTabControl)));
							}
							base.SelectedIndex = MonacoCustomTabControl.<>o__75.<>p__12.Target(MonacoCustomTabControl.<>o__75.<>p__12, obj);
						}
					}
					this.Refresh();
				}
			}
		}

		// Token: 0x04000053 RID: 83
		public static krnl_monaco Form1;

		// Token: 0x04000054 RID: 84
		private ChromiumWebBrowser browser;

		// Token: 0x04000055 RID: 85
		public TabPage contextTab;

		// Token: 0x04000056 RID: 86
		public Color selectedTextColor = Color.FromArgb(255, 255, 255);

		// Token: 0x04000057 RID: 87
		private readonly StringFormat CenterSringFormat = new StringFormat
		{
			Alignment = StringAlignment.Near,
			LineAlignment = StringAlignment.Center
		};

		// Token: 0x04000058 RID: 88
		private Color activeColor = Color.FromArgb(36, 36, 36);

		// Token: 0x04000059 RID: 89
		private Color backTabColor = Color.FromArgb(0, 0, 0);

		// Token: 0x0400005A RID: 90
		private Color borderColor = Color.FromArgb(30, 30, 30);

		// Token: 0x0400005B RID: 91
		private Color closingButtonColor = Color.WhiteSmoke;

		// Token: 0x0400005C RID: 92
		private string closingMessage;

		// Token: 0x0400005D RID: 93
		private int count = 1;

		// Token: 0x0400005E RID: 94
		public int realIndex = -1;

		// Token: 0x0400005F RID: 95
		private Color headerColor = Color.FromArgb(45, 45, 48);

		// Token: 0x04000060 RID: 96
		private Color horizLineColor = Color.FromArgb(36, 36, 36);

		// Token: 0x04000061 RID: 97
		private TabPage predraggedTab;

		// Token: 0x04000062 RID: 98
		private Color textColor = Color.FromArgb(255, 255, 255);

		// Token: 0x04000063 RID: 99
		public static bool removed = false;

		// Token: 0x04000064 RID: 100
		public static int removeIdx = -1;
	}
}

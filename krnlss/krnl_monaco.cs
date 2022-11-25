using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using CefSharp;
using CefSharp.WinForms;
using Controls;
using injection;
using krnlss.Properties;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32;
using SirhurtUI.Controls;

namespace krnlss
{
	// Token: 0x02000012 RID: 18
	public partial class krnl_monaco : Form
	{
		// Token: 0x0600012C RID: 300
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

		// Token: 0x0600012D RID: 301
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		// Token: 0x0600012E RID: 302
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600012F RID: 303
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000130 RID: 304 RVA: 0x000103A4 File Offset: 0x0000E5A4
		public void PopulateTree(dynamic dir, TreeNode node)
		{
			try
			{
				if (krnl_monaco.<>o__75.<>p__0 == null)
				{
					krnl_monaco.<>o__75.<>p__0 = CallSite<Func<CallSite, Type, object, DirectoryInfo>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object arg = krnl_monaco.<>o__75.<>p__0.Target(krnl_monaco.<>o__75.<>p__0, typeof(DirectoryInfo), dir);
				if (krnl_monaco.<>o__75.<>p__8 == null)
				{
					krnl_monaco.<>o__75.<>p__8 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(krnl_monaco)));
				}
				Func<CallSite, object, IEnumerable> target = krnl_monaco.<>o__75.<>p__8.Target;
				CallSite <>p__ = krnl_monaco.<>o__75.<>p__8;
				if (krnl_monaco.<>o__75.<>p__1 == null)
				{
					krnl_monaco.<>o__75.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetDirectories", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				foreach (object arg2 in target(<>p__, krnl_monaco.<>o__75.<>p__1.Target(krnl_monaco.<>o__75.<>p__1, arg)))
				{
					if (krnl_monaco.<>o__75.<>p__3 == null)
					{
						krnl_monaco.<>o__75.<>p__3 = CallSite<Func<CallSite, Type, object, TreeNode>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, TreeNode> target2 = krnl_monaco.<>o__75.<>p__3.Target;
					CallSite <>p__2 = krnl_monaco.<>o__75.<>p__3;
					Type typeFromHandle = typeof(TreeNode);
					if (krnl_monaco.<>o__75.<>p__2 == null)
					{
						krnl_monaco.<>o__75.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = target2(<>p__2, typeFromHandle, krnl_monaco.<>o__75.<>p__2.Target(krnl_monaco.<>o__75.<>p__2, arg2));
					if (node == null)
					{
						if (krnl_monaco.<>o__75.<>p__4 == null)
						{
							krnl_monaco.<>o__75.<>p__4 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl_monaco.<>o__75.<>p__4.Target(krnl_monaco.<>o__75.<>p__4, this.ScriptView.Nodes, obj);
					}
					else
					{
						if (krnl_monaco.<>o__75.<>p__5 == null)
						{
							krnl_monaco.<>o__75.<>p__5 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl_monaco.<>o__75.<>p__5.Target(krnl_monaco.<>o__75.<>p__5, node.Nodes, obj);
					}
					if (krnl_monaco.<>o__75.<>p__7 == null)
					{
						krnl_monaco.<>o__75.<>p__7 = CallSite<Action<CallSite, krnl_monaco, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "PopulateTree", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, krnl_monaco, object, object> target3 = krnl_monaco.<>o__75.<>p__7.Target;
					CallSite <>p__3 = krnl_monaco.<>o__75.<>p__7;
					if (krnl_monaco.<>o__75.<>p__6 == null)
					{
						krnl_monaco.<>o__75.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "FullName", typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target3(<>p__3, this, krnl_monaco.<>o__75.<>p__6.Target(krnl_monaco.<>o__75.<>p__6, arg2), obj);
				}
				if (krnl_monaco.<>o__75.<>p__14 == null)
				{
					krnl_monaco.<>o__75.<>p__14 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(krnl_monaco)));
				}
				Func<CallSite, object, IEnumerable> target4 = krnl_monaco.<>o__75.<>p__14.Target;
				CallSite <>p__4 = krnl_monaco.<>o__75.<>p__14;
				if (krnl_monaco.<>o__75.<>p__9 == null)
				{
					krnl_monaco.<>o__75.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetFiles", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				foreach (object arg3 in target4(<>p__4, krnl_monaco.<>o__75.<>p__9.Target(krnl_monaco.<>o__75.<>p__9, arg)))
				{
					if (krnl_monaco.<>o__75.<>p__11 == null)
					{
						krnl_monaco.<>o__75.<>p__11 = CallSite<Func<CallSite, Type, object, TreeNode>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, TreeNode> target5 = krnl_monaco.<>o__75.<>p__11.Target;
					CallSite <>p__5 = krnl_monaco.<>o__75.<>p__11;
					Type typeFromHandle2 = typeof(TreeNode);
					if (krnl_monaco.<>o__75.<>p__10 == null)
					{
						krnl_monaco.<>o__75.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg4 = target5(<>p__5, typeFromHandle2, krnl_monaco.<>o__75.<>p__10.Target(krnl_monaco.<>o__75.<>p__10, arg3));
					if (node != null)
					{
						if (krnl_monaco.<>o__75.<>p__12 == null)
						{
							krnl_monaco.<>o__75.<>p__12 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl_monaco.<>o__75.<>p__12.Target(krnl_monaco.<>o__75.<>p__12, node.Nodes, arg4);
					}
					else
					{
						if (krnl_monaco.<>o__75.<>p__13 == null)
						{
							krnl_monaco.<>o__75.<>p__13 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl_monaco.<>o__75.<>p__13.Target(krnl_monaco.<>o__75.<>p__13, this.ScriptView.Nodes, arg4);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00010978 File Offset: 0x0000EB78
		private void ScriptLoading()
		{
			try
			{
				object arg = Directory.Exists(Settings.Default.ScriptPath);
				if (krnl_monaco.<>o__76.<>p__1 == null)
				{
					krnl_monaco.<>o__76.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = krnl_monaco.<>o__76.<>p__1.Target;
				CallSite <>p__ = krnl_monaco.<>o__76.<>p__1;
				if (krnl_monaco.<>o__76.<>p__0 == null)
				{
					krnl_monaco.<>o__76.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target(<>p__, krnl_monaco.<>o__76.<>p__0.Target(krnl_monaco.<>o__76.<>p__0, arg)))
				{
					Directory.CreateDirectory(Settings.Default.ScriptPath);
				}
			}
			catch
			{
			}
			this.PopulateTree(Settings.Default.ScriptPath, null);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00010A64 File Offset: 0x0000EC64
		public krnl_monaco()
		{
			AppDomain.CurrentDomain.UnhandledException += this.CurrentDomain_UnhandledException;
			this.InitializeComponent();
			this.panel3.Width = base.Width;
			this.createCustomTabControl1();
			MonacoCustomTabControl.Form1 = this;
			this.customTabControl1.ShowClosingButton = true;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Settings.Default.monaco = false;
			Settings.Default.Save();
			Exception ex = (Exception)e.ExceptionObject;
			string path = "error.txt";
			string separator = "\n";
			string[] array = new string[7];
			array[0] = "Message: " + ex.Message;
			array[1] = "StackTrace: " + ex.StackTrace;
			array[2] = "Source: " + ex.Source;
			int num = 3;
			string str = "TargetSite: ";
			MethodBase targetSite = ex.TargetSite;
			array[num] = str + ((targetSite != null) ? targetSite.ToString() : null);
			array[4] = "HResult: " + ex.HResult.ToString();
			array[5] = "HelpLink: " + ex.HelpLink;
			array[6] = "Values: [ " + string.Join("\n", new object[]
			{
				ex.Data.Values
			}) + " ]";
			File.WriteAllText(path, string.Join(separator, array));
			MessageBox.Show("Send `error.txt` to krnl server", "Caught an oopsies!");
			if (MessageBox.Show("Click `Yes` if you want to get an invite to krnl discord server.", "Krnl Prompt", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Process.Start("https://" + Program.url + "/invite");
			}
			Process.Start(Process.GetCurrentProcess().MainModule.FileName);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00010C40 File Offset: 0x0000EE40
		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < this.hotScriptsToolStripMenuItem.DropDownItems.Count; i++)
			{
				ToolStripItem toolStripItem = this.hotScriptsToolStripMenuItem.DropDownItems[i];
				if (toolStripItem.Text == "Owl Hub" || toolStripItem.Text == "Galaxy Hub")
				{
					toolStripItem.Visible = false;
					toolStripItem.Enabled = false;
				}
			}
			if (!Directory.Exists("bin/tabs"))
			{
				Directory.CreateDirectory("bin/tabs");
			}
			if (Directory.GetFiles("bin/tabs").Length != 0)
			{
				for (int j = 0; j < Directory.GetFiles("bin/tabs").Length / 2; j++)
				{
					int count2 = this.customTabControl1.TabPages.Count;
					int num = j;
					using (FileStream fileStream = new FileStream(string.Format("bin/tabs/{0}_source.lua", num), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
					{
						using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
						{
							string content = streamReader.ReadToEnd();
							this.customTabControl1.addScript(content);
							streamReader.Close();
						}
					}
				}
				for (int k = 0; k < Directory.GetFiles("bin/tabs").Length / 2; k++)
				{
					this.customTabControl1.addnewtab();
					int count = this.customTabControl1.TabPages.Count - 2;
					int curr = k;
					if (k + 1 == Directory.GetFiles("bin/tabs").Length / 2)
					{
						ChromiumWebBrowser editor = this.customTabControl1.GetWorkingTextEditor();
						editor.LoadingStateChanged += delegate(object sender, LoadingStateChangedEventArgs args)
						{
							if (!args.IsLoading && args.CanReload && args.Browser.HasDocument && editor.CanExecuteJavascriptInMainFrame)
							{
								try
								{
									using (FileStream fileStream2 = new FileStream(string.Format("bin/tabs/{0}_name.txt", curr), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
									{
										using (StreamReader streamReader2 = new StreamReader(fileStream2, Encoding.UTF8))
										{
											this.customTabControl1.TabPages[count].Text = streamReader2.ReadToEnd();
											streamReader2.Close();
										}
									}
									using (FileStream fileStream3 = new FileStream(string.Format("bin/tabs/{0}_source.lua", curr), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
									{
										using (StreamReader streamReader3 = new StreamReader(fileStream3, Encoding.UTF8))
										{
											WebBrowserExtensions.ExecuteScriptAsync(editor, "SetText", new object[]
											{
												streamReader3.ReadToEnd()
											});
											streamReader3.Close();
										}
									}
								}
								catch
								{
								}
							}
						};
					}
				}
			}
			else
			{
				this.customTabControl1.addnewtab();
			}
			if (!Directory.Exists(Settings.Default.ScriptPath))
			{
				Settings.Default.ScriptPath = Environment.CurrentDirectory + "\\scripts";
			}
			this.menuStrip1.Renderer = new ToolStripProfessionalRenderer(new krnl_monaco.BrowserColors());
			this.ScriptLoading();
			this.Anim_ATF_break = true;
			this.anim_AwaitingTaskFinish();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00010E7C File Offset: 0x0000F07C
		private void button1_Click(object sender, EventArgs e)
		{
			krnl_monaco.<button1_Click>d__80 <button1_Click>d__;
			<button1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button1_Click>d__.<>4__this = this;
			<button1_Click>d__.<>1__state = -1;
			<button1_Click>d__.<>t__builder.Start<krnl_monaco.<button1_Click>d__80>(ref <button1_Click>d__);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00010EB3 File Offset: 0x0000F0B3
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00010EBC File Offset: 0x0000F0BC
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00010EBE File Offset: 0x0000F0BE
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				krnl_monaco.ReleaseCapture();
				krnl_monaco.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00010EE6 File Offset: 0x0000F0E6
		private void tabPage1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00010EE8 File Offset: 0x0000F0E8
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabPage contextTab = this.customTabControl1.contextTab;
			this.customTabControl1.CloseTab(contextTab);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00010F10 File Offset: 0x0000F110
		private void createCustomTabControl1()
		{
			this.customTabControl1 = new MonacoCustomTabControl();
			this.customTabControl1.ActiveColor = Color.FromArgb(30, 30, 30);
			this.customTabControl1.AllowDrop = true;
			this.customTabControl1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.customTabControl1.BackTabColor = Color.FromArgb(36, 36, 36);
			this.customTabControl1.BorderColor = Color.FromArgb(30, 30, 30);
			this.customTabControl1.ClosingButtonColor = Color.WhiteSmoke;
			this.customTabControl1.ClosingMessage = null;
			this.customTabControl1.Controls.Add(this.tabPage1);
			this.customTabControl1.HeaderColor = Color.FromArgb(45, 45, 48);
			this.customTabControl1.HorizontalLineColor = Color.FromArgb(30, 30, 30);
			this.customTabControl1.ItemSize = new Size(240, 16);
			this.customTabControl1.Location = new Point(4, 59);
			this.customTabControl1.Name = "customTabControl1";
			this.customTabControl1.SelectedIndex = 0;
			this.customTabControl1.SelectedTextColor = Color.FromArgb(255, 255, 255);
			this.customTabControl1.ShowClosingButton = false;
			this.customTabControl1.ShowClosingMessage = false;
			this.customTabControl1.Size = new Size(556, 259);
			this.customTabControl1.TabIndex = 3;
			this.customTabControl1.TextColor = Color.FromArgb(255, 255, 255);
			this.customTabControl1.SelectedIndexChanged += this.customTabControl1_SelectedIndexChanged;
			base.Controls.Add(this.customTabControl1);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000110CB File Offset: 0x0000F2CB
		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			WebBrowserExtensions.ExecuteScriptAsync(this.customTabControl1.GetWorkingTextEditor(), "SetText", new object[]
			{
				""
			});
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000110F0 File Offset: 0x0000F2F0
		private void openIntoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabPage contextTab = this.customTabControl1.contextTab;
			if (contextTab == null)
			{
				throw new Exception("SELECTED TAB NOT FOUND");
			}
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.CheckFileExists = true;
				openFileDialog.Filter = "Script Files (*.txt, *.lua)|*.txt;*.lua|All Files (*.*)|*.*";
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					contextTab.Text = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
					object obj = File.ReadAllText(openFileDialog.FileName);
					try
					{
						Control control = this.customTabControl1.contextTab.Controls[0];
						WebBrowserExtensions.ExecuteScriptAsync((ChromiumWebBrowser)((control is ChromiumWebBrowser) ? control : null), "SetText", new object[]
						{
							obj
						});
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000111C8 File Offset: 0x0000F3C8
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabPage contextTab = this.customTabControl1.contextTab;
			if (contextTab == null)
			{
				throw new Exception("TAB NOT FOUND");
			}
			contextTab.Text = this.customTabControl1.OpenSaveDialog(contextTab, WebBrowserExtensions.EvaluateScriptAsync(this.customTabControl1.GetWorkingTextEditor(), "GetText", new object[0]).GetAwaiter().GetResult().Result.ToString());
		}

		// Token: 0x0600013F RID: 319
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x06000140 RID: 320 RVA: 0x00011233 File Offset: 0x0000F433
		public static bool findpipe(string pipeName)
		{
			return krnl_monaco.WaitNamedPipe(Path.GetFullPath("\\\\.\\pipe\\" + pipeName), 0) || (Marshal.GetLastWin32Error() != 0 && Marshal.GetLastWin32Error() != 2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00011260 File Offset: 0x0000F460
		public static void pipeshit(string script)
		{
			try
			{
				if (krnl_monaco.findpipe("krnlpipe"))
				{
					using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", "krnlpipe", PipeDirection.Out))
					{
						namedPipeClientStream.Connect();
						if (!namedPipeClientStream.IsConnected)
						{
							throw new IOException("Failed To Connect To Pipe....");
						}
						StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999);
						streamWriter.Write(script);
						streamWriter.Dispose();
						return;
					}
				}
				MessageBox.Show("Please Inject To Execute Scripts", "krnl");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000112FC File Offset: 0x0000F4FC
		public static void Pipe(string script)
		{
			if (krnl_monaco.findpipe("krnlpipe"))
			{
				krnl_monaco.pipeshit(script);
				return;
			}
			MessageBox.Show("Please Inject To Execute Scripts", "krnl");
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00011324 File Offset: 0x0000F524
		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			try
			{
				krnl_monaco.Pipe(WebBrowserExtensions.EvaluateScriptAsync(this.customTabControl1.GetWorkingTextEditor(), "GetText", new object[0]).GetAwaiter().GetResult().Result.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00011388 File Offset: 0x0000F588
		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
			WebBrowserExtensions.ExecuteScriptAsync(this.customTabControl1.GetWorkingTextEditor(), "SetText", new object[]
			{
				""
			});
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000113AD File Offset: 0x0000F5AD
		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			this.customTabControl1.OpenFileDialog(this.customTabControl1.SelectedTab);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000113C6 File Offset: 0x0000F5C6
		private void bunifuFlatButton4_Click(object sender, EventArgs e)
		{
			this.ScriptView.Nodes.Clear();
			this.ScriptLoading();
			this.customTabControl1.OpenSaveDialog(this.customTabControl1.SelectedTab, "");
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000113FA File Offset: 0x0000F5FA
		private void injectToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000113FC File Offset: 0x0000F5FC
		private void bunifuFlatButton5_Click(object sender, EventArgs e)
		{
			Program.call_inject();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00011404 File Offset: 0x0000F604
		private void executeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object fullPath = this.ScriptView.SelectedNode.FullPath;
				if (krnl_monaco.<>o__100.<>p__1 == null)
				{
					krnl_monaco.<>o__100.<>p__1 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, Type, object, object> target = krnl_monaco.<>o__100.<>p__1.Target;
				CallSite <>p__ = krnl_monaco.<>o__100.<>p__1;
				Type typeFromHandle = typeof(File);
				if (krnl_monaco.<>o__100.<>p__0 == null)
				{
					krnl_monaco.<>o__100.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object arg = target(<>p__, typeFromHandle, krnl_monaco.<>o__100.<>p__0.Target(krnl_monaco.<>o__100.<>p__0, Settings.Default.ScriptPath + "//", fullPath));
				if (krnl_monaco.<>o__100.<>p__2 == null)
				{
					krnl_monaco.<>o__100.<>p__2 = CallSite<Action<CallSite, krnl_monaco, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "Pipe", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				krnl_monaco.<>o__100.<>p__2.Target(krnl_monaco.<>o__100.<>p__2, this, arg);
			}
			catch
			{
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00011564 File Offset: 0x0000F764
		private void loadIntoEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object fullPath = this.ScriptView.SelectedNode.FullPath;
				if (krnl_monaco.<>o__101.<>p__1 == null)
				{
					krnl_monaco.<>o__101.<>p__1 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, Type, object, object> target = krnl_monaco.<>o__101.<>p__1.Target;
				CallSite <>p__ = krnl_monaco.<>o__101.<>p__1;
				Type typeFromHandle = typeof(File);
				if (krnl_monaco.<>o__101.<>p__0 == null)
				{
					krnl_monaco.<>o__101.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object obj = target(<>p__, typeFromHandle, krnl_monaco.<>o__101.<>p__0.Target(krnl_monaco.<>o__101.<>p__0, Settings.Default.ScriptPath + "//", fullPath));
				WebBrowserExtensions.ExecuteScriptAsync(this.customTabControl1.GetWorkingTextEditor(), "SetText", new object[]
				{
					obj
				});
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001167C File Offset: 0x0000F87C
		private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object fullPath = this.ScriptView.SelectedNode.FullPath;
				if (krnl_monaco.<>o__102.<>p__1 == null)
				{
					krnl_monaco.<>o__102.<>p__1 = CallSite<Action<CallSite, Type, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Delete", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Action<CallSite, Type, object> target = krnl_monaco.<>o__102.<>p__1.Target;
				CallSite <>p__ = krnl_monaco.<>o__102.<>p__1;
				Type typeFromHandle = typeof(File);
				if (krnl_monaco.<>o__102.<>p__0 == null)
				{
					krnl_monaco.<>o__102.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl_monaco), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, typeFromHandle, krnl_monaco.<>o__102.<>p__0.Target(krnl_monaco.<>o__102.<>p__0, Settings.Default.ScriptPath + "//", fullPath));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00011778 File Offset: 0x0000F978
		private void changePathToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object arg = new FolderBrowserDialog();
				if (krnl_monaco.<>o__103.<>p__11 == null)
				{
					krnl_monaco.<>o__103.<>p__11 = CallSite<Func<CallSite, object, IDisposable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IDisposable), typeof(krnl_monaco)));
				}
				using (krnl_monaco.<>o__103.<>p__11.Target(krnl_monaco.<>o__103.<>p__11, arg))
				{
					if (krnl_monaco.<>o__103.<>p__1 == null)
					{
						krnl_monaco.<>o__103.<>p__1 = CallSite<Func<CallSite, object, DialogResult, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, DialogResult, object> target = krnl_monaco.<>o__103.<>p__1.Target;
					CallSite <>p__ = krnl_monaco.<>o__103.<>p__1;
					if (krnl_monaco.<>o__103.<>p__0 == null)
					{
						krnl_monaco.<>o__103.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ShowDialog", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = target(<>p__, krnl_monaco.<>o__103.<>p__0.Target(krnl_monaco.<>o__103.<>p__0, arg), DialogResult.OK);
					if (krnl_monaco.<>o__103.<>p__6 == null)
					{
						krnl_monaco.<>o__103.<>p__6 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj2;
					if (!krnl_monaco.<>o__103.<>p__6.Target(krnl_monaco.<>o__103.<>p__6, obj))
					{
						if (krnl_monaco.<>o__103.<>p__5 == null)
						{
							krnl_monaco.<>o__103.<>p__5 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object, object> target2 = krnl_monaco.<>o__103.<>p__5.Target;
						CallSite <>p__2 = krnl_monaco.<>o__103.<>p__5;
						object arg2 = obj;
						if (krnl_monaco.<>o__103.<>p__4 == null)
						{
							krnl_monaco.<>o__103.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target3 = krnl_monaco.<>o__103.<>p__4.Target;
						CallSite <>p__3 = krnl_monaco.<>o__103.<>p__4;
						if (krnl_monaco.<>o__103.<>p__3 == null)
						{
							krnl_monaco.<>o__103.<>p__3 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "IsNullOrWhiteSpace", null, typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, Type, object, object> target4 = krnl_monaco.<>o__103.<>p__3.Target;
						CallSite <>p__4 = krnl_monaco.<>o__103.<>p__3;
						Type typeFromHandle = typeof(string);
						if (krnl_monaco.<>o__103.<>p__2 == null)
						{
							krnl_monaco.<>o__103.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "SelectedPath", typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						obj2 = target2(<>p__2, arg2, target3(<>p__3, target4(<>p__4, typeFromHandle, krnl_monaco.<>o__103.<>p__2.Target(krnl_monaco.<>o__103.<>p__2, arg))));
					}
					else
					{
						obj2 = obj;
					}
					object arg3 = obj2;
					if (krnl_monaco.<>o__103.<>p__7 == null)
					{
						krnl_monaco.<>o__103.<>p__7 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl_monaco), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (krnl_monaco.<>o__103.<>p__7.Target(krnl_monaco.<>o__103.<>p__7, arg3))
					{
						if (krnl_monaco.<>o__103.<>p__8 == null)
						{
							krnl_monaco.<>o__103.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "SelectedPath", typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						this.ScriptPath = krnl_monaco.<>o__103.<>p__8.Target(krnl_monaco.<>o__103.<>p__8, arg);
						Settings @default = Settings.Default;
						if (krnl_monaco.<>o__103.<>p__10 == null)
						{
							krnl_monaco.<>o__103.<>p__10 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl_monaco)));
						}
						Func<CallSite, object, string> target5 = krnl_monaco.<>o__103.<>p__10.Target;
						CallSite <>p__5 = krnl_monaco.<>o__103.<>p__10;
						if (krnl_monaco.<>o__103.<>p__9 == null)
						{
							krnl_monaco.<>o__103.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "SelectedPath", typeof(krnl_monaco), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						@default.ScriptPath = target5(<>p__5, krnl_monaco.<>o__103.<>p__9.Target(krnl_monaco.<>o__103.<>p__9, arg));
						Settings.Default.Save();
					}
				}
				this.ScriptView.Nodes.Clear();
				this.ScriptLoading();
			}
			catch
			{
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00011B98 File Offset: 0x0000FD98
		private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ScriptView.Nodes.Clear();
			this.ScriptLoading();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		private void ScriptView_AfterSelect(object sender, TreeViewEventArgs e)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00011BB2 File Offset: 0x0000FDB2
		private void customTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00011BB4 File Offset: 0x0000FDB4
		private void renameToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00011BB6 File Offset: 0x0000FDB6
		private void openGuiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/UXmbai5q', true))()");
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00011BC2 File Offset: 0x0000FDC2
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))();");
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00011BCE File Offset: 0x0000FDCE
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/Babyhamsta/RBLX_Scripts/main/Universal/BypassedDarkDexV3.lua', true))()");
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00011BDA File Offset: 0x0000FDDA
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00011BDC File Offset: 0x0000FDDC
		private void bunifuFlatButton6_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<settings>().Count<settings>() != 1)
			{
				new settings(this).Show();
				Application.OpenForms.OfType<settings>().First<settings>().SetDesktopLocation(base.Location.X + base.Size.Width + 5, base.Location.Y);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00011C47 File Offset: 0x0000FE47
		private void gamesToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Disabled as most scripts are patched.");
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00011C54 File Offset: 0x0000FE54
		private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<About>().Count<About>() != 1)
			{
				new About().Show();
				Application.OpenForms.OfType<About>().First<About>().SetDesktopLocation(base.Location.X + base.Size.Width + 5, base.Location.Y);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00011CBE File Offset: 0x0000FEBE
		private void injectToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Program.call_inject();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00011CC5 File Offset: 0x0000FEC5
		private void openGuiToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/UXmbai5q', true))()");
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00011CD1 File Offset: 0x0000FED1
		private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))();");
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00011CE0 File Offset: 0x0000FEE0
		private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			int num = 0;
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
				num++;
			}
			MessageBox.Show(string.Format("Terminated {0} Process", num), "krnl");
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00011D30 File Offset: 0x0000FF30
		private void krnl_FormClosing(object sender, FormClosingEventArgs e)
		{
			string[] files = Directory.GetFiles("bin/tabs");
			for (int i = 0; i < ((files.Length != 0) ? (files.Length / 2) : 0); i++)
			{
				if (this.customTabControl1.TabPages.Count <= i + 1)
				{
					try
					{
						File.Delete(string.Format("bin/tabs/{0}_name.txt", i));
						File.Delete(string.Format("bin/tabs/{0}_source.lua", i));
					}
					catch
					{
					}
				}
			}
			string text = WebBrowserExtensions.EvaluateScriptAsync(this.customTabControl1.GetWorkingTextEditor(), "GetText", new object[0]).GetAwaiter().GetResult().Result.ToString();
			Program.tabScripts[this.customTabControl1.realIndex] = ((text != "-- Krnl Monaco") ? text : Program.tabScripts[this.customTabControl1.realIndex]);
			for (int j = 0; j < this.customTabControl1.TabCount - 1; j++)
			{
				File.WriteAllText(string.Format("bin/tabs/{0}_name.txt", j), this.customTabControl1.TabPages[j].Text);
				File.WriteAllText(string.Format("bin/tabs/{0}_source.lua", j), Program.tabScripts[j]);
			}
			Environment.Exit(Environment.ExitCode);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00011E98 File Offset: 0x00010098
		private void krnl_Deactivate(object sender, EventArgs e)
		{
			krnl_monaco.<krnl_Deactivate>d__120 <krnl_Deactivate>d__;
			<krnl_Deactivate>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<krnl_Deactivate>d__.<>1__state = -1;
			<krnl_Deactivate>d__.<>t__builder.Start<krnl_monaco.<krnl_Deactivate>d__120>(ref <krnl_Deactivate>d__);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00011EC8 File Offset: 0x000100C8
		protected override void OnActivated(EventArgs e)
		{
			krnl_monaco.<OnActivated>d__121 <OnActivated>d__;
			<OnActivated>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnActivated>d__.<>4__this = this;
			<OnActivated>d__.<>1__state = -1;
			<OnActivated>d__.<>t__builder.Start<krnl_monaco.<OnActivated>d__121>(ref <OnActivated>d__);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00011F00 File Offset: 0x00010100
		protected override void OnDeactivate(EventArgs e)
		{
			krnl_monaco.<OnDeactivate>d__122 <OnDeactivate>d__;
			<OnDeactivate>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnDeactivate>d__.<>4__this = this;
			<OnDeactivate>d__.<>1__state = -1;
			<OnDeactivate>d__.<>t__builder.Start<krnl_monaco.<OnDeactivate>d__122>(ref <OnDeactivate>d__);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00011F38 File Offset: 0x00010138
		private void krnl_Activated(object sender, EventArgs e)
		{
			krnl_monaco.<krnl_Activated>d__123 <krnl_Activated>d__;
			<krnl_Activated>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<krnl_Activated>d__.<>1__state = -1;
			<krnl_Activated>d__.<>t__builder.Start<krnl_monaco.<krnl_Activated>d__123>(ref <krnl_Activated>d__);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00011F67 File Offset: 0x00010167
		private void gameSenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/rPnPiYZV'))();");
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00011F73 File Offset: 0x00010173
		private void remoteSpyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/JZaJe9Sg'))();");
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000146C6 File Offset: 0x000128C6
		private void unnamedESPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://ic3w0lf.xyz/rblx/protoesp.lua', true))()");
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000146D4 File Offset: 0x000128D4
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Settings.Default.remove_crash_logs)
			{
				try
				{
					if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Roblox\\logs\\archive"))
					{
						Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Roblox\\logs\\archive", true);
					}
					else if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Roblox\\logs\\archive"))
					{
						Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Roblox\\logs\\archive", true);
					}
				}
				catch
				{
				}
			}
			if (!Settings.Default.autoinject)
			{
				return;
			}
			if (Program.attaching || Process.GetProcessesByName("RobloxPlayerBeta").Length != 1)
			{
				return;
			}
			if (!File.Exists(Program.dll_path) || !File.Exists(Program.injector_path))
			{
				return;
			}
			Task.Run(delegate()
			{
				Program.attaching = true;
				Injector.inject(Program.dll_path);
				Task.Delay(3000).GetAwaiter().GetResult();
				Program.attaching = false;
			});
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000147CC File Offset: 0x000129CC
		private void toolStripMenuItem1_Click_2(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/LaziestBoy/Krnl-Hub/master/Krnl-Hub.lua', true))()");
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000147D8 File Offset: 0x000129D8
		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))();");
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000147E4 File Offset: 0x000129E4
		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			this.toolTip1.SetToolTip((PictureBox)sender, "Click to join the server");
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000147FC File Offset: 0x000129FC
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			this.toolTip1.Hide((PictureBox)sender);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001480F File Offset: 0x00012A0F
		private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
		{
			Process.Start("https://" + Program.url + "/invite");
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001482B File Offset: 0x00012A2B
		private void bunifuFlatButton8_Click(object sender, EventArgs e)
		{
			Process.Start("https://cdn." + Program.url + "/getkey");
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00014847 File Offset: 0x00012A47
		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			Process.Start("https://" + Program.url + "/invite");
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00014864 File Offset: 0x00012A64
		private void krnl_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mMouseDown)
			{
				this.Refresh();
				base.SuspendLayout();
				if (this.isonEdge)
				{
					if (this.Cursor == Cursors.PanSouth)
					{
						if (e.Y > 350)
						{
							this.heightUnchanged = false;
							base.SetBounds(base.Left, base.Top, base.Width, base.Height - (base.Height - e.Y));
						}
						else
						{
							this.heightUnchanged = true;
							base.SetBounds(base.Left, base.Top, base.Width, 350);
						}
					}
					if (this.Cursor == Cursors.PanEast)
					{
						if (e.X > 690)
						{
							this.widthUnchanged = false;
							base.SetBounds(base.Left, base.Top, base.Width - (base.Width - e.X), base.Height);
						}
						else
						{
							this.widthUnchanged = true;
							base.SetBounds(base.Left, base.Top, 690, base.Height);
						}
					}
					else if (this.Cursor == Cursors.PanSE)
					{
						base.SetBounds(base.Left, base.Top, (base.Width - (base.Width - e.X) < 690) ? 690 : (base.Width - (base.Width - e.X)), (base.Height - (base.Height - e.Y) < 350) ? 350 : (base.Height - (base.Height - e.Y)));
					}
					this.panel3.Width = base.Width;
				}
				base.ResumeLayout();
				return;
			}
			if (e.Y > base.Height - 10 && e.X < base.Width - 5)
			{
				this.Cursor = Cursors.PanSouth;
				this.isonEdge = true;
				return;
			}
			if (e.X > base.Width - (this.mWidth + 2) && e.Y > base.Height - (this.mWidth + 2))
			{
				this.Cursor = Cursors.PanSE;
				this.isonEdge = true;
				return;
			}
			if (e.X > base.Width - 5 && e.Y > this.button1.Size.Height)
			{
				this.Cursor = Cursors.PanEast;
				this.isonEdge = true;
				return;
			}
			this.Cursor = Cursors.Default;
			this.isonEdge = false;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00014AF8 File Offset: 0x00012CF8
		private void krnl_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.mMouseDown = true;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00014B0E File Offset: 0x00012D0E
		private void krnl_MouseUp(object sender, MouseEventArgs e)
		{
			this.mMouseDown = false;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00014B17 File Offset: 0x00012D17
		private void bunifuFlatButton7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00014B1C File Offset: 0x00012D1C
		public void anim_CompletedTask()
		{
			krnl_monaco.<anim_CompletedTask>d__141 <anim_CompletedTask>d__;
			<anim_CompletedTask>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<anim_CompletedTask>d__.<>4__this = this;
			<anim_CompletedTask>d__.<>1__state = -1;
			<anim_CompletedTask>d__.<>t__builder.Start<krnl_monaco.<anim_CompletedTask>d__141>(ref <anim_CompletedTask>d__);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00014B54 File Offset: 0x00012D54
		public void anim_AwaitingTaskFinish()
		{
			krnl_monaco.<anim_AwaitingTaskFinish>d__142 <anim_AwaitingTaskFinish>d__;
			<anim_AwaitingTaskFinish>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<anim_AwaitingTaskFinish>d__.<>4__this = this;
			<anim_AwaitingTaskFinish>d__.<>1__state = -1;
			<anim_AwaitingTaskFinish>d__.<>t__builder.Start<krnl_monaco.<anim_AwaitingTaskFinish>d__142>(ref <anim_AwaitingTaskFinish>d__);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00014B8B File Offset: 0x00012D8B
		private void bunifuFlatButton8_Click_1(object sender, EventArgs e)
		{
			this.Anim_ATF_break = true;
			this.anim_AwaitingTaskFinish();
			this.Anim_ATF_break = false;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00014BA1 File Offset: 0x00012DA1
		private void bunifuFlatButton10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00014BA3 File Offset: 0x00012DA3
		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00014BB0 File Offset: 0x00012DB0
		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			TabPage contextTab = this.customTabControl1.contextTab;
			if (contextTab != null)
			{
				Form prompt = new Form
				{
					Width = 200,
					Height = 50,
					MinimumSize = new Size(200, 50),
					MaximumSize = new Size(200, 50),
					FormBorderStyle = FormBorderStyle.None,
					Text = "What do you want to rename this tab to?",
					StartPosition = FormStartPosition.CenterParent
				};
				Label value = new Label
				{
					Width = 200,
					Height = 50,
					Text = "What do you want to rename this tab to?",
					Top = 0,
					Left = 0
				};
				TextBox textBox = new TextBox
				{
					Left = 0,
					Top = 30,
					Width = 150,
					Text = contextTab.Text
				};
				Button button = new Button
				{
					Text = "Ok",
					Left = 150,
					Width = 50,
					Top = 30,
					DialogResult = DialogResult.OK
				};
				prompt.TopMost = true;
				button.Click += delegate(object <p0>, EventArgs <p1>)
				{
					prompt.Close();
				};
				prompt.Controls.Add(textBox);
				prompt.Controls.Add(button);
				prompt.Controls.Add(value);
				prompt.AcceptButton = button;
				string text = (prompt.ShowDialog() == DialogResult.OK) ? textBox.Text : "";
				if (text.Length > 0)
				{
					contextTab.Text = text;
				}
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00014D51 File Offset: 0x00012F51
		private void cMDXToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl_monaco.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CMD-X/CMD-X/master/Source', true))()");
		}

		// Token: 0x040000E0 RID: 224
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040000E1 RID: 225
		public const int HT_CAPTION = 2;

		// Token: 0x040000E2 RID: 226
		[Dynamic]
		private dynamic ScriptPath = Settings.Default.ScriptPath;

		// Token: 0x040000E3 RID: 227
		public TabPanelControl tpc = new TabPanelControl();

		// Token: 0x040000E4 RID: 228
		public bool changed;

		// Token: 0x040000EB RID: 235
		private ToolStripMenuItem renameToolStripMenuItem;

		// Token: 0x040000ED RID: 237
		public MonacoCustomTabControl customTabControl1;

		// Token: 0x04000117 RID: 279
		public static int injectedPID = 0;

		// Token: 0x04000118 RID: 280
		public static RegistryKey SOFTWARE = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

		// Token: 0x04000119 RID: 281
		public static bool activated = false;

		// Token: 0x0400011A RID: 282
		public static bool launcherDetected = false;

		// Token: 0x0400011B RID: 283
		public static double timeout = 6.0;

		// Token: 0x0400011C RID: 284
		private krnl_monaco.EdgeEnum mEdge;

		// Token: 0x0400011D RID: 285
		private bool isonEdge;

		// Token: 0x0400011E RID: 286
		private int mWidth = 20;

		// Token: 0x0400011F RID: 287
		private bool mMouseDown;

		// Token: 0x04000120 RID: 288
		private bool heightUnchanged = true;

		// Token: 0x04000121 RID: 289
		private bool widthUnchanged = true;

		// Token: 0x04000123 RID: 291
		private bool Anim_ATF_break;

		// Token: 0x0200002D RID: 45
		public class BrowserMenuRenderer : ToolStripProfessionalRenderer
		{
			// Token: 0x060001E3 RID: 483 RVA: 0x000176DA File Offset: 0x000158DA
			public BrowserMenuRenderer() : base(new krnl_monaco.BrowserColors())
			{
			}
		}

		// Token: 0x0200002E RID: 46
		public class BrowserColors : ProfessionalColorTable
		{
			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x000176E7 File Offset: 0x000158E7
			public override Color ToolStripDropDownBackground
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060001E5 RID: 485 RVA: 0x000176F4 File Offset: 0x000158F4
			public override Color ImageMarginGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x060001E6 RID: 486 RVA: 0x00017701 File Offset: 0x00015901
			public override Color ImageMarginGradientMiddle
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001770E File Offset: 0x0001590E
			public override Color ImageMarginGradientEnd
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x060001E8 RID: 488 RVA: 0x0001771B File Offset: 0x0001591B
			public override Color MenuBorder
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x060001E9 RID: 489 RVA: 0x00017728 File Offset: 0x00015928
			public override Color MenuItemBorder
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x060001EA RID: 490 RVA: 0x00017735 File Offset: 0x00015935
			public override Color MenuItemSelected
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x060001EB RID: 491 RVA: 0x00017742 File Offset: 0x00015942
			public override Color MenuStripGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x060001EC RID: 492 RVA: 0x0001774F File Offset: 0x0001594F
			public override Color MenuStripGradientEnd
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x060001ED RID: 493 RVA: 0x0001775C File Offset: 0x0001595C
			public override Color MenuItemSelectedGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x060001EE RID: 494 RVA: 0x00017769 File Offset: 0x00015969
			public override Color MenuItemSelectedGradientEnd
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x060001EF RID: 495 RVA: 0x00017776 File Offset: 0x00015976
			public override Color MenuItemPressedGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x00017783 File Offset: 0x00015983
			public override Color MenuItemPressedGradientEnd
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}
		}

		// Token: 0x0200002F RID: 47
		private enum EdgeEnum
		{
			// Token: 0x040001CF RID: 463
			None,
			// Token: 0x040001D0 RID: 464
			Right,
			// Token: 0x040001D1 RID: 465
			Left,
			// Token: 0x040001D2 RID: 466
			Top,
			// Token: 0x040001D3 RID: 467
			Bottom,
			// Token: 0x040001D4 RID: 468
			TopLeft,
			// Token: 0x040001D5 RID: 469
			BottomRight
		}
	}
}

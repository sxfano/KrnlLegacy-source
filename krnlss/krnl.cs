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
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Controls;
using injection;
using krnlss.Properties;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32;
using ScintillaNET;
using SirhurtUI.Controls;

namespace krnlss
{
	// Token: 0x02000011 RID: 17
	public partial class krnl : Form
	{
		// Token: 0x060000DF RID: 223
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

		// Token: 0x060000E0 RID: 224
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		// Token: 0x060000E1 RID: 225
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060000E2 RID: 226
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060000E3 RID: 227
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		// Token: 0x060000E4 RID: 228
		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x060000E5 RID: 229 RVA: 0x0000BA8C File Offset: 0x00009C8C
		public void PopulateTree(dynamic dir, TreeNode node)
		{
			try
			{
				if (krnl.<>o__77.<>p__0 == null)
				{
					krnl.<>o__77.<>p__0 = CallSite<Func<CallSite, Type, object, DirectoryInfo>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object arg = krnl.<>o__77.<>p__0.Target(krnl.<>o__77.<>p__0, typeof(DirectoryInfo), dir);
				if (krnl.<>o__77.<>p__8 == null)
				{
					krnl.<>o__77.<>p__8 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(krnl)));
				}
				Func<CallSite, object, IEnumerable> target = krnl.<>o__77.<>p__8.Target;
				CallSite <>p__ = krnl.<>o__77.<>p__8;
				if (krnl.<>o__77.<>p__1 == null)
				{
					krnl.<>o__77.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetDirectories", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				foreach (object arg2 in target(<>p__, krnl.<>o__77.<>p__1.Target(krnl.<>o__77.<>p__1, arg)))
				{
					if (krnl.<>o__77.<>p__3 == null)
					{
						krnl.<>o__77.<>p__3 = CallSite<Func<CallSite, Type, object, TreeNode>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, TreeNode> target2 = krnl.<>o__77.<>p__3.Target;
					CallSite <>p__2 = krnl.<>o__77.<>p__3;
					Type typeFromHandle = typeof(TreeNode);
					if (krnl.<>o__77.<>p__2 == null)
					{
						krnl.<>o__77.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = target2(<>p__2, typeFromHandle, krnl.<>o__77.<>p__2.Target(krnl.<>o__77.<>p__2, arg2));
					if (node == null)
					{
						if (krnl.<>o__77.<>p__4 == null)
						{
							krnl.<>o__77.<>p__4 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl.<>o__77.<>p__4.Target(krnl.<>o__77.<>p__4, this.ScriptView.Nodes, obj);
					}
					else
					{
						if (krnl.<>o__77.<>p__5 == null)
						{
							krnl.<>o__77.<>p__5 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl.<>o__77.<>p__5.Target(krnl.<>o__77.<>p__5, node.Nodes, obj);
					}
					if (krnl.<>o__77.<>p__7 == null)
					{
						krnl.<>o__77.<>p__7 = CallSite<Action<CallSite, krnl, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "PopulateTree", null, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, krnl, object, object> target3 = krnl.<>o__77.<>p__7.Target;
					CallSite <>p__3 = krnl.<>o__77.<>p__7;
					if (krnl.<>o__77.<>p__6 == null)
					{
						krnl.<>o__77.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "FullName", typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target3(<>p__3, this, krnl.<>o__77.<>p__6.Target(krnl.<>o__77.<>p__6, arg2), obj);
				}
				if (krnl.<>o__77.<>p__14 == null)
				{
					krnl.<>o__77.<>p__14 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(krnl)));
				}
				Func<CallSite, object, IEnumerable> target4 = krnl.<>o__77.<>p__14.Target;
				CallSite <>p__4 = krnl.<>o__77.<>p__14;
				if (krnl.<>o__77.<>p__9 == null)
				{
					krnl.<>o__77.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetFiles", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				foreach (object arg3 in target4(<>p__4, krnl.<>o__77.<>p__9.Target(krnl.<>o__77.<>p__9, arg)))
				{
					if (krnl.<>o__77.<>p__11 == null)
					{
						krnl.<>o__77.<>p__11 = CallSite<Func<CallSite, Type, object, TreeNode>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, TreeNode> target5 = krnl.<>o__77.<>p__11.Target;
					CallSite <>p__5 = krnl.<>o__77.<>p__11;
					Type typeFromHandle2 = typeof(TreeNode);
					if (krnl.<>o__77.<>p__10 == null)
					{
						krnl.<>o__77.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg4 = target5(<>p__5, typeFromHandle2, krnl.<>o__77.<>p__10.Target(krnl.<>o__77.<>p__10, arg3));
					if (node != null)
					{
						if (krnl.<>o__77.<>p__12 == null)
						{
							krnl.<>o__77.<>p__12 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl.<>o__77.<>p__12.Target(krnl.<>o__77.<>p__12, node.Nodes, arg4);
					}
					else
					{
						if (krnl.<>o__77.<>p__13 == null)
						{
							krnl.<>o__77.<>p__13 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl.<>o__77.<>p__13.Target(krnl.<>o__77.<>p__13, this.ScriptView.Nodes, arg4);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000C060 File Offset: 0x0000A260
		private void ScriptLoading()
		{
			try
			{
				object arg = Directory.Exists(Settings.Default.ScriptPath);
				if (krnl.<>o__78.<>p__1 == null)
				{
					krnl.<>o__78.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = krnl.<>o__78.<>p__1.Target;
				CallSite <>p__ = krnl.<>o__78.<>p__1;
				if (krnl.<>o__78.<>p__0 == null)
				{
					krnl.<>o__78.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target(<>p__, krnl.<>o__78.<>p__0.Target(krnl.<>o__78.<>p__0, arg)))
				{
					Directory.CreateDirectory(Settings.Default.ScriptPath);
				}
			}
			catch
			{
			}
			this.PopulateTree(Settings.Default.ScriptPath, null);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000C14C File Offset: 0x0000A34C
		public krnl()
		{
			AppDomain.CurrentDomain.UnhandledException += this.CurrentDomain_UnhandledException;
			this.InitializeComponent();
			this.panel3.Width = base.Width;
			CustomTabControl.Form1 = this;
			this.customTabControl1.ShowClosingButton = true;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
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
				Process.Start("https://cdn." + Program.url + "/invite");
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
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
					this.customTabControl1.addnewtab();
					try
					{
						using (FileStream fileStream = new FileStream(string.Format("bin/tabs/{0}_name.txt", j), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
						{
							using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
							{
								this.customTabControl1.TabPages[this.customTabControl1.TabPages.Count - 2].Text = streamReader.ReadToEnd();
								streamReader.Close();
							}
						}
						using (FileStream fileStream2 = new FileStream(string.Format("bin/tabs/{0}_source.lua", j), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
						{
							using (StreamReader streamReader2 = new StreamReader(fileStream2, Encoding.UTF8))
							{
								this.customTabControl1.GetWorkingTextEditor().Text = streamReader2.ReadToEnd();
								streamReader2.Close();
							}
						}
					}
					catch
					{
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
			this.menuStrip1.Renderer = new ToolStripProfessionalRenderer(new krnl.BrowserColors());
			this.ScriptLoading();
			this.Anim_ATF_break = true;
			this.anim_AwaitingTaskFinish();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000C530 File Offset: 0x0000A730
		private void button1_Click(object sender, EventArgs e)
		{
			krnl.<button1_Click>d__82 <button1_Click>d__;
			<button1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button1_Click>d__.<>4__this = this;
			<button1_Click>d__.<>1__state = -1;
			<button1_Click>d__.<>t__builder.Start<krnl.<button1_Click>d__82>(ref <button1_Click>d__);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000C567 File Offset: 0x0000A767
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000C570 File Offset: 0x0000A770
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000C572 File Offset: 0x0000A772
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				krnl.ReleaseCapture();
				krnl.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000C59A File Offset: 0x0000A79A
		private void tabPage1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000C59C File Offset: 0x0000A79C
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabPage contextTab = this.customTabControl1.contextTab;
			this.customTabControl1.CloseTab(contextTab);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000C5C1 File Offset: 0x0000A7C1
		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Scintilla scintilla = this.customTabControl1.contextTab.Controls[0] as Scintilla;
			scintilla.Text = "";
			scintilla.Refresh();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
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
					object arg = File.ReadAllText(openFileDialog.FileName);
					Scintilla scintilla = contextTab.Controls[0] as Scintilla;
					if (krnl.<>o__89.<>p__0 == null)
					{
						krnl.<>o__89.<>p__0 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
					}
					scintilla.Text = krnl.<>o__89.<>p__0.Target(krnl.<>o__89.<>p__0, arg);
					scintilla.Refresh();
				}
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabPage contextTab = this.customTabControl1.contextTab;
			if (contextTab == null)
			{
				throw new Exception("TAB NOT FOUND");
			}
			contextTab.Text = this.customTabControl1.OpenSaveDialog(contextTab, contextTab.Controls[0].Text);
		}

		// Token: 0x060000F3 RID: 243
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x060000F4 RID: 244 RVA: 0x0000C71E File Offset: 0x0000A91E
		private static bool findpipe(string pipeName)
		{
			return krnl.WaitNamedPipe(Path.GetFullPath("\\\\.\\pipe\\" + pipeName), 0) || (Marshal.GetLastWin32Error() != 0 && Marshal.GetLastWin32Error() != 2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000C74C File Offset: 0x0000A94C
		public static void pipeshit(string script)
		{
			try
			{
				if (krnl.findpipe("krnlpipe"))
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

		// Token: 0x060000F6 RID: 246 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		public static void Pipe(string script)
		{
			if (krnl.findpipe("krnlpipe"))
			{
				krnl.pipeshit(script);
				return;
			}
			MessageBox.Show("Please Inject To Execute Scripts", "krnl");
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000C810 File Offset: 0x0000AA10
		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			try
			{
				krnl.Pipe(this.customTabControl1.GetWorkingTextEditor().Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000C854 File Offset: 0x0000AA54
		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
			this.customTabControl1.GetWorkingTextEditor().Text = "";
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000C86B File Offset: 0x0000AA6B
		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			this.customTabControl1.OpenFileDialog(this.customTabControl1.SelectedTab);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000C884 File Offset: 0x0000AA84
		private void bunifuFlatButton4_Click(object sender, EventArgs e)
		{
			this.ScriptView.Nodes.Clear();
			this.ScriptLoading();
			this.customTabControl1.OpenSaveDialog(this.customTabControl1.SelectedTab, this.customTabControl1.GetWorkingTextEditor().Text);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000C8C3 File Offset: 0x0000AAC3
		private void injectToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000C8C5 File Offset: 0x0000AAC5
		private void bunifuFlatButton5_Click(object sender, EventArgs e)
		{
			Program.call_inject();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000C8CC File Offset: 0x0000AACC
		private void executeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object fullPath = this.ScriptView.SelectedNode.FullPath;
				if (krnl.<>o__101.<>p__1 == null)
				{
					krnl.<>o__101.<>p__1 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, Type, object, object> target = krnl.<>o__101.<>p__1.Target;
				CallSite <>p__ = krnl.<>o__101.<>p__1;
				Type typeFromHandle = typeof(File);
				if (krnl.<>o__101.<>p__0 == null)
				{
					krnl.<>o__101.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object arg = target(<>p__, typeFromHandle, krnl.<>o__101.<>p__0.Target(krnl.<>o__101.<>p__0, Settings.Default.ScriptPath + "//", fullPath));
				if (krnl.<>o__101.<>p__2 == null)
				{
					krnl.<>o__101.<>p__2 = CallSite<Action<CallSite, krnl, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "Pipe", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				krnl.<>o__101.<>p__2.Target(krnl.<>o__101.<>p__2, this, arg);
			}
			catch
			{
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000CA2C File Offset: 0x0000AC2C
		private void loadIntoEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object fullPath = this.ScriptView.SelectedNode.FullPath;
				if (krnl.<>o__102.<>p__1 == null)
				{
					krnl.<>o__102.<>p__1 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, Type, object, object> target = krnl.<>o__102.<>p__1.Target;
				CallSite <>p__ = krnl.<>o__102.<>p__1;
				Type typeFromHandle = typeof(File);
				if (krnl.<>o__102.<>p__0 == null)
				{
					krnl.<>o__102.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object arg = target(<>p__, typeFromHandle, krnl.<>o__102.<>p__0.Target(krnl.<>o__102.<>p__0, Settings.Default.ScriptPath + "//", fullPath));
				Control workingTextEditor = this.customTabControl1.GetWorkingTextEditor();
				if (krnl.<>o__102.<>p__2 == null)
				{
					krnl.<>o__102.<>p__2 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
				}
				workingTextEditor.Text = krnl.<>o__102.<>p__2.Target(krnl.<>o__102.<>p__2, arg);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000CB84 File Offset: 0x0000AD84
		private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object fullPath = this.ScriptView.SelectedNode.FullPath;
				if (krnl.<>o__103.<>p__1 == null)
				{
					krnl.<>o__103.<>p__1 = CallSite<Action<CallSite, Type, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Delete", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Action<CallSite, Type, object> target = krnl.<>o__103.<>p__1.Target;
				CallSite <>p__ = krnl.<>o__103.<>p__1;
				Type typeFromHandle = typeof(File);
				if (krnl.<>o__103.<>p__0 == null)
				{
					krnl.<>o__103.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, typeFromHandle, krnl.<>o__103.<>p__0.Target(krnl.<>o__103.<>p__0, Settings.Default.ScriptPath + "//", fullPath));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000CC80 File Offset: 0x0000AE80
		private void changePathToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object arg = new FolderBrowserDialog();
				if (krnl.<>o__104.<>p__11 == null)
				{
					krnl.<>o__104.<>p__11 = CallSite<Func<CallSite, object, IDisposable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IDisposable), typeof(krnl)));
				}
				using (krnl.<>o__104.<>p__11.Target(krnl.<>o__104.<>p__11, arg))
				{
					if (krnl.<>o__104.<>p__1 == null)
					{
						krnl.<>o__104.<>p__1 = CallSite<Func<CallSite, object, DialogResult, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, DialogResult, object> target = krnl.<>o__104.<>p__1.Target;
					CallSite <>p__ = krnl.<>o__104.<>p__1;
					if (krnl.<>o__104.<>p__0 == null)
					{
						krnl.<>o__104.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ShowDialog", null, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = target(<>p__, krnl.<>o__104.<>p__0.Target(krnl.<>o__104.<>p__0, arg), DialogResult.OK);
					if (krnl.<>o__104.<>p__6 == null)
					{
						krnl.<>o__104.<>p__6 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj2;
					if (!krnl.<>o__104.<>p__6.Target(krnl.<>o__104.<>p__6, obj))
					{
						if (krnl.<>o__104.<>p__5 == null)
						{
							krnl.<>o__104.<>p__5 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object, object> target2 = krnl.<>o__104.<>p__5.Target;
						CallSite <>p__2 = krnl.<>o__104.<>p__5;
						object arg2 = obj;
						if (krnl.<>o__104.<>p__4 == null)
						{
							krnl.<>o__104.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target3 = krnl.<>o__104.<>p__4.Target;
						CallSite <>p__3 = krnl.<>o__104.<>p__4;
						if (krnl.<>o__104.<>p__3 == null)
						{
							krnl.<>o__104.<>p__3 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "IsNullOrWhiteSpace", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, Type, object, object> target4 = krnl.<>o__104.<>p__3.Target;
						CallSite <>p__4 = krnl.<>o__104.<>p__3;
						Type typeFromHandle = typeof(string);
						if (krnl.<>o__104.<>p__2 == null)
						{
							krnl.<>o__104.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "SelectedPath", typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						obj2 = target2(<>p__2, arg2, target3(<>p__3, target4(<>p__4, typeFromHandle, krnl.<>o__104.<>p__2.Target(krnl.<>o__104.<>p__2, arg))));
					}
					else
					{
						obj2 = obj;
					}
					object arg3 = obj2;
					if (krnl.<>o__104.<>p__7 == null)
					{
						krnl.<>o__104.<>p__7 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (krnl.<>o__104.<>p__7.Target(krnl.<>o__104.<>p__7, arg3))
					{
						if (krnl.<>o__104.<>p__8 == null)
						{
							krnl.<>o__104.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "SelectedPath", typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						this.ScriptPath = krnl.<>o__104.<>p__8.Target(krnl.<>o__104.<>p__8, arg);
						Settings @default = Settings.Default;
						if (krnl.<>o__104.<>p__10 == null)
						{
							krnl.<>o__104.<>p__10 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
						}
						Func<CallSite, object, string> target5 = krnl.<>o__104.<>p__10.Target;
						CallSite <>p__5 = krnl.<>o__104.<>p__10;
						if (krnl.<>o__104.<>p__9 == null)
						{
							krnl.<>o__104.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "SelectedPath", typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						@default.ScriptPath = target5(<>p__5, krnl.<>o__104.<>p__9.Target(krnl.<>o__104.<>p__9, arg));
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

		// Token: 0x06000101 RID: 257 RVA: 0x0000D0A0 File Offset: 0x0000B2A0
		private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ScriptView.Nodes.Clear();
			this.ScriptLoading();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		private void ScriptView_AfterSelect(object sender, TreeViewEventArgs e)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000D0BA File Offset: 0x0000B2BA
		private void customTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000D0BC File Offset: 0x0000B2BC
		private void renameToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000D0BE File Offset: 0x0000B2BE
		private void openGuiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/UXmbai5q', true))()");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000D0CA File Offset: 0x0000B2CA
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))();");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000D0D6 File Offset: 0x0000B2D6
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/Babyhamsta/RBLX_Scripts/main/Universal/BypassedDarkDexV3.lua', true))()");
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000D0E2 File Offset: 0x0000B2E2
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
		private void bunifuFlatButton6_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<settings>().Count<settings>() != 1)
			{
				new settings(this).Show();
				Application.OpenForms.OfType<settings>().First<settings>().SetDesktopLocation(base.Location.X + base.Size.Width + 5, base.Location.Y);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000D14F File Offset: 0x0000B34F
		private void gamesToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Disabled as most scripts are patched.");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000D15C File Offset: 0x0000B35C
		private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<About>().Count<About>() != 1)
			{
				new About().Show();
				Application.OpenForms.OfType<About>().First<About>().SetDesktopLocation(base.Location.X + base.Size.Width + 5, base.Location.Y);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000D1C6 File Offset: 0x0000B3C6
		private void injectToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Program.call_inject();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000D1CD File Offset: 0x0000B3CD
		private void openGuiToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/UXmbai5q', true))()");
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000D1D9 File Offset: 0x0000B3D9
		private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))();");
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
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

		// Token: 0x06000110 RID: 272 RVA: 0x0000D238 File Offset: 0x0000B438
		private void krnl_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				string[] files = Directory.GetFiles("bin/tabs");
				for (int i = 0; i < ((files.Length != 0) ? (files.Length / 2) : 0); i++)
				{
					if (this.customTabControl1.TabPages.Count <= i + 1)
					{
						File.Delete(string.Format("bin/tabs/{0}_name.txt", i));
						File.Delete(string.Format("bin/tabs/{0}_source.lua", i));
					}
				}
				for (int j = 0; j < this.customTabControl1.TabPages.Count; j++)
				{
					TabPage tabPage = this.customTabControl1.TabPages[j];
					if (tabPage.Controls.Count > 0)
					{
						Scintilla scintilla = tabPage.Controls[0] as Scintilla;
						File.WriteAllText(string.Format("bin/tabs/{0}_name.txt", j), tabPage.Text.ToString());
						File.WriteAllText(string.Format("bin/tabs/{0}_source.lua", j), scintilla.Text.ToString());
					}
				}
			}
			catch
			{
			}
			Environment.Exit(Environment.ExitCode);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000D360 File Offset: 0x0000B560
		private void krnl_Deactivate(object sender, EventArgs e)
		{
			krnl.<krnl_Deactivate>d__121 <krnl_Deactivate>d__;
			<krnl_Deactivate>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<krnl_Deactivate>d__.<>4__this = this;
			<krnl_Deactivate>d__.<>1__state = -1;
			<krnl_Deactivate>d__.<>t__builder.Start<krnl.<krnl_Deactivate>d__121>(ref <krnl_Deactivate>d__);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000D398 File Offset: 0x0000B598
		private void krnl_Activated(object sender, EventArgs e)
		{
			krnl.<krnl_Activated>d__122 <krnl_Activated>d__;
			<krnl_Activated>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<krnl_Activated>d__.<>4__this = this;
			<krnl_Activated>d__.<>1__state = -1;
			<krnl_Activated>d__.<>t__builder.Start<krnl.<krnl_Activated>d__122>(ref <krnl_Activated>d__);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		private void gameSenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/rPnPiYZV'))();");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000D3DB File Offset: 0x0000B5DB
		private void remoteSpyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/JZaJe9Sg'))();");
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000FCF4 File Offset: 0x0000DEF4
		private void unnamedESPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://ic3w0lf.xyz/rblx/protoesp.lua', true))()");
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000FD00 File Offset: 0x0000DF00
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
			if (Program.attached || Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
			{
				return;
			}
			if (!File.Exists(Program.dll_path) || !File.Exists(Program.injector_path))
			{
				return;
			}
			Program.attached = true;
			Injector.inject(Program.dll_path);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		private void toolStripMenuItem1_Click_2(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/LaziestBoy/Krnl-Hub/master/Krnl-Hub.lua', true))()");
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000FDEC File Offset: 0x0000DFEC
		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))();");
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			this.toolTip1.SetToolTip((PictureBox)sender, "Click to join the server");
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000FE10 File Offset: 0x0000E010
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			this.toolTip1.Hide((PictureBox)sender);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000FE23 File Offset: 0x0000E023
		private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
		{
			Process.Start("https://" + Program.url + "/invite");
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000FE3F File Offset: 0x0000E03F
		private void bunifuFlatButton8_Click(object sender, EventArgs e)
		{
			Process.Start("https://cdn." + Program.url + "/getkey");
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000FE5B File Offset: 0x0000E05B
		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			Process.Start("https://" + Program.url + "/invite");
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000FE78 File Offset: 0x0000E078
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

		// Token: 0x06000121 RID: 289 RVA: 0x0001010C File Offset: 0x0000E30C
		private void krnl_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.mMouseDown = true;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00010122 File Offset: 0x0000E322
		private void krnl_MouseUp(object sender, MouseEventArgs e)
		{
			this.mMouseDown = false;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001012B File Offset: 0x0000E32B
		private void bunifuFlatButton7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00010130 File Offset: 0x0000E330
		public void anim_CompletedTask()
		{
			krnl.<anim_CompletedTask>d__140 <anim_CompletedTask>d__;
			<anim_CompletedTask>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<anim_CompletedTask>d__.<>4__this = this;
			<anim_CompletedTask>d__.<>1__state = -1;
			<anim_CompletedTask>d__.<>t__builder.Start<krnl.<anim_CompletedTask>d__140>(ref <anim_CompletedTask>d__);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00010168 File Offset: 0x0000E368
		public void anim_AwaitingTaskFinish()
		{
			krnl.<anim_AwaitingTaskFinish>d__141 <anim_AwaitingTaskFinish>d__;
			<anim_AwaitingTaskFinish>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<anim_AwaitingTaskFinish>d__.<>4__this = this;
			<anim_AwaitingTaskFinish>d__.<>1__state = -1;
			<anim_AwaitingTaskFinish>d__.<>t__builder.Start<krnl.<anim_AwaitingTaskFinish>d__141>(ref <anim_AwaitingTaskFinish>d__);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001019F File Offset: 0x0000E39F
		private void bunifuFlatButton8_Click_1(object sender, EventArgs e)
		{
			this.Anim_ATF_break = true;
			this.anim_AwaitingTaskFinish();
			this.Anim_ATF_break = false;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000101B5 File Offset: 0x0000E3B5
		private void bunifuFlatButton10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000101B7 File Offset: 0x0000E3B7
		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000101C4 File Offset: 0x0000E3C4
		private void renameToolStripMenuItem_Click_1(object sender, EventArgs e)
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

		// Token: 0x0600012A RID: 298 RVA: 0x00010365 File Offset: 0x0000E565
		private void cMDXToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CMD-X/CMD-X/master/Source', true))()");
		}

		// Token: 0x0400009C RID: 156
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400009D RID: 157
		public const int HT_CAPTION = 2;

		// Token: 0x0400009E RID: 158
		[Dynamic]
		private dynamic ScriptPath = Settings.Default.ScriptPath;

		// Token: 0x0400009F RID: 159
		public TabPanelControl tpc = new TabPanelControl();

		// Token: 0x040000A0 RID: 160
		public bool changed;

		// Token: 0x040000D2 RID: 210
		private bool mMouseDown;

		// Token: 0x040000D3 RID: 211
		private const int SW_HIDE = 0;

		// Token: 0x040000D4 RID: 212
		private const int SW_SHOW = 5;

		// Token: 0x040000D5 RID: 213
		public static int injectedPID = 0;

		// Token: 0x040000D6 RID: 214
		public static RegistryKey SOFTWARE = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

		// Token: 0x040000D7 RID: 215
		public static bool launcherDetected = false;

		// Token: 0x040000D8 RID: 216
		public static double timeout = 6.0;

		// Token: 0x040000D9 RID: 217
		private krnl.EdgeEnum mEdge;

		// Token: 0x040000DA RID: 218
		private bool isonEdge;

		// Token: 0x040000DB RID: 219
		private int mWidth = 20;

		// Token: 0x040000DC RID: 220
		private bool heightUnchanged = true;

		// Token: 0x040000DD RID: 221
		private bool widthUnchanged = true;

		// Token: 0x040000DF RID: 223
		private bool Anim_ATF_break;

		// Token: 0x0200001D RID: 29
		public class BrowserMenuRenderer : ToolStripProfessionalRenderer
		{
			// Token: 0x060001C8 RID: 456 RVA: 0x00016DA0 File Offset: 0x00014FA0
			public BrowserMenuRenderer() : base(new krnl.BrowserColors())
			{
			}
		}

		// Token: 0x0200001E RID: 30
		public class BrowserColors : ProfessionalColorTable
		{
			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060001C9 RID: 457 RVA: 0x00016DAD File Offset: 0x00014FAD
			public override Color ToolStripDropDownBackground
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060001CA RID: 458 RVA: 0x00016DBA File Offset: 0x00014FBA
			public override Color ImageMarginGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060001CB RID: 459 RVA: 0x00016DC7 File Offset: 0x00014FC7
			public override Color ImageMarginGradientMiddle
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060001CC RID: 460 RVA: 0x00016DD4 File Offset: 0x00014FD4
			public override Color ImageMarginGradientEnd
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060001CD RID: 461 RVA: 0x00016DE1 File Offset: 0x00014FE1
			public override Color MenuBorder
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060001CE RID: 462 RVA: 0x00016DEE File Offset: 0x00014FEE
			public override Color MenuItemBorder
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060001CF RID: 463 RVA: 0x00016DFB File Offset: 0x00014FFB
			public override Color MenuItemSelected
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x00016E08 File Offset: 0x00015008
			public override Color MenuStripGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x00016E15 File Offset: 0x00015015
			public override Color MenuStripGradientEnd
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x00016E22 File Offset: 0x00015022
			public override Color MenuItemSelectedGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060001D3 RID: 467 RVA: 0x00016E2F File Offset: 0x0001502F
			public override Color MenuItemSelectedGradientEnd
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060001D4 RID: 468 RVA: 0x00016E3C File Offset: 0x0001503C
			public override Color MenuItemPressedGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060001D5 RID: 469 RVA: 0x00016E49 File Offset: 0x00015049
			public override Color MenuItemPressedGradientEnd
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}
		}

		// Token: 0x0200001F RID: 31
		private enum EdgeEnum
		{
			// Token: 0x0400018A RID: 394
			None,
			// Token: 0x0400018B RID: 395
			Right,
			// Token: 0x0400018C RID: 396
			Left,
			// Token: 0x0400018D RID: 397
			Top,
			// Token: 0x0400018E RID: 398
			Bottom,
			// Token: 0x0400018F RID: 399
			TopLeft,
			// Token: 0x04000190 RID: 400
			BottomRight
		}
	}
}

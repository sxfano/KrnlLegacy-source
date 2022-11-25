using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using injection;
using krnlss.Properties;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32;

namespace krnlss
{
	// Token: 0x02000013 RID: 19
	internal static class Program
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00014D94 File Offset: 0x00012F94
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00014D9B File Offset: 0x00012F9B
		private static int injectedPID { get; set; }

		// Token: 0x0600017C RID: 380 RVA: 0x00014DA3 File Offset: 0x00012FA3
		[STAThread]
		public static void writerblx()
		{
		}

		// Token: 0x0600017D RID: 381
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x0600017E RID: 382
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

		// Token: 0x0600017F RID: 383
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		// Token: 0x06000180 RID: 384 RVA: 0x00014DA5 File Offset: 0x00012FA5
		public static bool findpipe(string pipeName)
		{
			return Program.WaitNamedPipe(Path.GetFullPath("\\\\.\\pipe\\" + pipeName), 0) || (Marshal.GetLastWin32Error() != 0 && Marshal.GetLastWin32Error() != 2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00014DD4 File Offset: 0x00012FD4
		public static void pc(bool start = false, bool urlPassed = false, int key = -1)
		{
			if (Program.debugme)
			{
				if (start)
				{
					File.WriteAllText("pass check.txt", "");
				}
				string str = Convert.ToString(Program.__i++);
				string str2;
				if (key != 0)
				{
					if (key == 1)
					{
						str2 = " Key";
					}
					else
					{
						str2 = "";
					}
				}
				else
				{
					str2 = " No Key";
				}
				File.AppendAllText("pass check.txt", str + str2 + (urlPassed ? " Url Passed" : "") + "\n");
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00014E50 File Offset: 0x00013050
		public static bool isCompatible()
		{
			string text = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductName");
			return text.IndexOf("Windows 8.1") != -1 || (text.IndexOf("Windows 8") != -1 && text.IndexOf("1") != -1) || text.IndexOf("Windows 10") != -1;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00014EBC File Offset: 0x000130BC
		public static bool hasFolder(string name, string path)
		{
			DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				if (directories[i].Name == name)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00014EF8 File Offset: 0x000130F8
		public static bool hasFile(string name, string path)
		{
			FileInfo[] files = new DirectoryInfo(path).GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				if (files[i].Name == name)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00014F34 File Offset: 0x00013134
		private static void LoadReferencedAssembly(Assembly assembly)
		{
			AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
			for (int i = 0; i < referencedAssemblies.Length; i++)
			{
				AssemblyName name = referencedAssemblies[i];
				if (!AppDomain.CurrentDomain.GetAssemblies().Any((Assembly a) => a.FullName == name.FullName))
				{
					Program.LoadReferencedAssembly(Assembly.Load(name));
				}
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00014F92 File Offset: 0x00013192
		public static void test()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00014F94 File Offset: 0x00013194
		[STAThread]
		private static void Main()
		{
			if (!File.Exists("krnlss.exe.config"))
			{
				File.WriteAllText("krnlss.exe.config", "<?xml version=\"1.0\" encoding=\"utf-8\" ?><configuration><runtime><assemblyBinding xmlns=\"urn:schemas-microsoft-com:asm.v1\"><probing privatePath=\"bin;bin/src\" /></assemblyBinding></runtime></configuration>");
				Task.Delay(500).GetAwaiter().GetResult();
				Process.Start("krnlss.exe");
				Environment.Exit(0);
			}
			Settings.Default.monaco = (!Program.is_wrd && Settings.Default.monaco);
			if (Program.is_wrd)
			{
				Program.create_wrd_button();
			}
			Program.auto_attach();
			Program.test();
			try
			{
				string[] array = new string[]
				{
					"CefSharp.dll",
					"CefSharp.Core.dll",
					"CefSharp.WinForms.dll",
					"CefSharp.OffScreen.dll"
				};
				for (int i = 0; i < array.Length; i++)
				{
					try
					{
						Program.LoadReferencedAssembly(Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin/src", array[i])));
					}
					catch
					{
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				string[] array2 = new string[]
				{
					"ScintillaNET.dll",
					"Bunifu_UI_v1.5.3.dll"
				};
				for (int j = 0; j < array2.Length; j++)
				{
					try
					{
						Program.LoadReferencedAssembly(Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", array2[j])));
					}
					catch
					{
					}
				}
			}
			catch (Exception)
			{
			}
			Program.test();
			ServicePointManager.Expect100Continue = true;
			Program.test();
			Process[] processes = Process.GetProcesses();
			for (int k = 0; k < processes.Length; k++)
			{
				if (processes[k] != Process.GetCurrentProcess() && new string[]
				{
					"krnl",
					"krnlss"
				}.ToList<string>().IndexOf(processes[k].ProcessName.Split(new char[]
				{
					'.'
				})[0].ToLower()) != -1)
				{
					try
					{
						processes[k].CloseMainWindow();
					}
					catch
					{
					}
				}
			}
			Program.test();
			if (!Directory.Exists("workspace"))
			{
				Directory.CreateDirectory("workspace");
			}
			if (!Directory.Exists("scripts"))
			{
				Directory.CreateDirectory("scripts");
			}
			if (!Directory.Exists("autoexec"))
			{
				Directory.CreateDirectory("autoexec");
			}
			Program.test();
			Program.writerblx();
			if (File.Exists("krnl.exe.bak"))
			{
				File.Delete("krnl.exe.bak");
			}
			Program.test();
			Stack<string> stack = new Stack<string>(Environment.CurrentDirectory.Split(new char[]
			{
				'\\'
			}));
			bool flag = false;
			stack.Reverse<string>();
			while (stack.Count != 0)
			{
				if (string.Join("\\", stack.ToArray().Reverse<string>()) + "\\" == Path.GetTempPath())
				{
					flag = true;
					break;
				}
				stack.Pop();
			}
			if (!flag)
			{
				if (Directory.GetCurrentDirectory().Split(new char[]
				{
					'\\'
				}).ToList<string>().Last<string>().StartsWith("Rar$EX"))
				{
					flag = true;
				}
				if (Directory.GetCurrentDirectory().ToLower().IndexOf("c:\\windows\\system32") != -1)
				{
					flag = false;
					MessageBox.Show("You cannot run this here!\nYou must extract the zip file!", "Zip file detected.");
				}
			}
			if (flag)
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				if (!Directory.Exists(folderPath + "\\krnl"))
				{
					Directory.CreateDirectory(folderPath + "\\krnl");
				}
				string text = folderPath + "\\krnl";
				new DirectoryInfo(text);
				DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
				directoryInfo.GetDirectories();
				FileInfo[] files = directoryInfo.GetFiles();
				MessageBox.Show("You cannot run this here!\nExtracting the zip file to your Desktop.", "Zip file detected.");
				MessageBox.Show(Process.GetCurrentProcess().MainModule.FileName);
				for (int l = 0; l < files.Length; l++)
				{
					if (!Program.hasFile(files[l].Name, text))
					{
						files[l].CopyTo(files[l].FullName.Replace(Environment.CurrentDirectory, text), true);
					}
				}
				Process.Start(text);
				Process.Start(new ProcessStartInfo
				{
					WorkingDirectory = text,
					FileName = "krnlss.exe",
					CreateNoWindow = true
				});
				Environment.Exit(1);
				return;
			}
			Program.test();
			if (Program.is_wrd || !Settings.Default.monaco)
			{
				Program.form = new krnl();
			}
			else
			{
				Program.form = new krnl_monaco();
			}
			Program.test();
			Program.form.Width = 690;
			Program.form.Opacity = 0.0;
			Application.Run(Program.form);
			Form form = Program.form;
			EventHandler value;
			if ((value = Program.<>O.<0>__Form_Activated) == null)
			{
				value = (Program.<>O.<0>__Form_Activated = new EventHandler(Program.Form_Activated));
			}
			form.Load += value;
			Component component = Program.form;
			EventHandler value2;
			if ((value2 = Program.<>O.<1>__Form_Disposed) == null)
			{
				value2 = (Program.<>O.<1>__Form_Disposed = new EventHandler(Program.Form_Disposed));
			}
			component.Disposed += value2;
			Form form2 = Program.form;
			FormClosingEventHandler value3;
			if ((value3 = Program.<>O.<2>__Form_FormClosing) == null)
			{
				value3 = (Program.<>O.<2>__Form_FormClosing = new FormClosingEventHandler(Program.Form_FormClosing));
			}
			form2.FormClosing += value3;
			Component currentProcess = Process.GetCurrentProcess();
			EventHandler value4;
			if ((value4 = Program.<>O.<3>__Program_Disposed) == null)
			{
				value4 = (Program.<>O.<3>__Program_Disposed = new EventHandler(Program.Program_Disposed));
			}
			currentProcess.Disposed += value4;
			Process currentProcess2 = Process.GetCurrentProcess();
			EventHandler value5;
			if ((value5 = Program.<>O.<4>__Program_Exited) == null)
			{
				value5 = (Program.<>O.<4>__Program_Exited = new EventHandler(Program.Program_Exited));
			}
			currentProcess2.Exited += value5;
			AppDomain currentDomain = AppDomain.CurrentDomain;
			EventHandler value6;
			if ((value6 = Program.<>O.<5>__CurrentDomain_ProcessExit) == null)
			{
				value6 = (Program.<>O.<5>__CurrentDomain_ProcessExit = new EventHandler(Program.CurrentDomain_ProcessExit));
			}
			currentDomain.ProcessExit += value6;
			Program.test();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00015510 File Offset: 0x00013710
		private static void Program_Disposed(object sender, EventArgs e)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00015512 File Offset: 0x00013712
		private static void Program_Exited(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00015514 File Offset: 0x00013714
		private static void Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Settings.Default.monaco)
			{
				MessageBox.Show(((krnl_monaco)Program.form).customTabControl1.TabCount.ToString());
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001554F File Offset: 0x0001374F
		private static void Form_Disposed(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00015551 File Offset: 0x00013751
		private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00015553 File Offset: 0x00013753
		public static void writeToDir(string directory)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00015558 File Offset: 0x00013758
		private static void Form_Activated(object sender, EventArgs e)
		{
			while (Program.form.Opacity < 1.0)
			{
				Program.form.Opacity += Math.Min(1.0, 0.05);
				Task.Delay(1).GetAwaiter().GetResult();
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000155B8 File Offset: 0x000137B8
		public static void auto_attach()
		{
			Program.<auto_attach>d__38 <auto_attach>d__;
			<auto_attach>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<auto_attach>d__.<>1__state = -1;
			<auto_attach>d__.<>t__builder.Start<Program.<auto_attach>d__38>(ref <auto_attach>d__);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000155E8 File Offset: 0x000137E8
		public static void create_wrd_button()
		{
			Program.<>c__DisplayClass39_0 CS$<>8__locals1 = new Program.<>c__DisplayClass39_0();
			CS$<>8__locals1.btn = new Button();
			CS$<>8__locals1.btn.Width = 50;
			CS$<>8__locals1.btn.Height = 20;
			CS$<>8__locals1.btn.FlatStyle = FlatStyle.Flat;
			CS$<>8__locals1.btn.Margin = new Padding(3, 3, 3, 3);
			CS$<>8__locals1.btn.Location = new Point(35, 8);
			CS$<>8__locals1.btn.BackColor = Color.FromArgb(29, 29, 29);
			CS$<>8__locals1.btn.ForeColor = Color.FromArgb(200, 200, 200);
			CS$<>8__locals1.btn.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			CS$<>8__locals1.btn.Text = "WRD";
			CS$<>8__locals1.btn.TextAlign = ContentAlignment.MiddleCenter;
			CS$<>8__locals1.btn.TabStop = false;
			CS$<>8__locals1.btn.Click += delegate(object sender, EventArgs args)
			{
				Process.Start("https://wearedevs.net/d/Krnl");
			};
			Task.Run(delegate()
			{
				Program.<>c__DisplayClass39_0.<<create_wrd_button>b__1>d <<create_wrd_button>b__1>d;
				<<create_wrd_button>b__1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<create_wrd_button>b__1>d.<>4__this = CS$<>8__locals1;
				<<create_wrd_button>b__1>d.<>1__state = -1;
				<<create_wrd_button>b__1>d.<>t__builder.Start<Program.<>c__DisplayClass39_0.<<create_wrd_button>b__1>d>(ref <<create_wrd_button>b__1>d);
				return <<create_wrd_button>b__1>d.<>t__builder.Task;
			});
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00015708 File Offset: 0x00013908
		public static void call_inject()
		{
			if (Program.use_new_injector && !File.Exists(Program.injector_path))
			{
				MessageBox.Show("Krnl Injector DLL does not exist in the directory!", "Krnl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (!File.Exists(Program.dll_path))
			{
				MessageBox.Show("Krnl DLL does not exist in the directory!", "Krnl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (!Program.use_new_injector)
			{
				Task.Run(delegate()
				{
					switch (Program.OldInject())
					{
					case Old_Injector.inject_status.ProcessNotFound:
						MessageBox.Show("No ROBLOX process has been found.", "Krnl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					case Old_Injector.inject_status.Failed:
						MessageBox.Show("Failed to inject for unknown reason", "Krnl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					case Old_Injector.inject_status.Success:
						Program.form.Invoke(new Action(delegate()
						{
							if (Program.<>o__40.<>p__0 == null)
							{
								Program.<>o__40.<>p__0 = CallSite<Action<CallSite, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "anim_CompletedTask", null, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Program.<>o__40.<>p__0.Target(Program.<>o__40.<>p__0, Program.form);
						}));
						return;
					default:
						return;
					}
				});
				return;
			}
			new Thread(delegate(object <p0>)
			{
				switch (Injector.inject(Program.dll_path))
				{
				case Injector.inject_status.failure:
					MessageBox.Show("Failed to inject for unknown reason", "Krnl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				case Injector.inject_status.success:
					Program.form.Invoke(new MethodInvoker(delegate()
					{
						if (Program.<>o__40.<>p__1 == null)
						{
							Program.<>o__40.<>p__1 = CallSite<Action<CallSite, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "anim_CompletedTask", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Program.<>o__40.<>p__1.Target(Program.<>o__40.<>p__1, Program.form);
					}));
					return;
				case Injector.inject_status.loadimage_fail:
					MessageBox.Show("Failed to access dll file.\n\nKrnl is most likely already injected, or your anti-virus is on!", "krnl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				case Injector.inject_status.no_rbx_proc:
					MessageBox.Show("No ROBLOX process has been found.", "Krnl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				default:
					return;
				}
			}).Start();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000157B4 File Offset: 0x000139B4
		[HandleProcessCorruptedStateExceptions]
		public static Injector.inject_status NewInject()
		{
			if (Program.findpipe("krnlpipe"))
			{
				return Injector.inject_status.success;
			}
			try
			{
				if (File.Exists(Program.dll_path) && File.Exists(Program.injector_path))
				{
					return Injector.inject(Program.dll_path);
				}
			}
			catch (AccessViolationException)
			{
			}
			return Injector.inject_status.failure;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00015810 File Offset: 0x00013A10
		public static Old_Injector.inject_status OldInject()
		{
			if (Program.findpipe("krnlpipe"))
			{
				return Old_Injector.inject_status.Success;
			}
			if (!File.Exists(Program.dll_path))
			{
				return Old_Injector.inject_status.DllNotFound;
			}
			int num = 0;
			Program.GetWindowThreadProcessId(Program.FindWindowA("WINDOWSCLIENT", "Roblox"), out num);
			if (num == 0)
			{
				Program.is_attached = false;
				return Old_Injector.inject_status.ProcessNotFound;
			}
			if (Old_Injector.inject_dll((uint)num))
			{
				return Old_Injector.inject_status.Success;
			}
			return Old_Injector.inject_status.Failed;
		}

		// Token: 0x04000124 RID: 292
		public static string url = "krnl.place";

		// Token: 0x04000125 RID: 293
		public static string dll_path = Directory.GetCurrentDirectory() + string.Format("\\\\{0}", "krnl.dll");

		// Token: 0x04000126 RID: 294
		public static string injector_path = Directory.GetCurrentDirectory() + string.Format("\\\\{0}", "injector.dll");

		// Token: 0x04000127 RID: 295
		public static bool attached = false;

		// Token: 0x04000128 RID: 296
		public static bool attaching = false;

		// Token: 0x04000129 RID: 297
		public static bool use_new_injector = true;

		// Token: 0x0400012A RID: 298
		public static Form form;

		// Token: 0x0400012B RID: 299
		public static List<string> tabScripts = new List<string>();

		// Token: 0x0400012C RID: 300
		private static bool is_wrd = false;

		// Token: 0x0400012D RID: 301
		public static bool injecting = false;

		// Token: 0x0400012E RID: 302
		public static bool failed_inject = false;

		// Token: 0x0400012F RID: 303
		public static int __i;

		// Token: 0x04000130 RID: 304
		public static bool debugme;

		// Token: 0x04000131 RID: 305
		public static int idx;

		// Token: 0x04000133 RID: 307
		public static bool is_attached = false;

		// Token: 0x02000040 RID: 64
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400021B RID: 539
			public static EventHandler <0>__Form_Activated;

			// Token: 0x0400021C RID: 540
			public static EventHandler <1>__Form_Disposed;

			// Token: 0x0400021D RID: 541
			public static FormClosingEventHandler <2>__Form_FormClosing;

			// Token: 0x0400021E RID: 542
			public static EventHandler <3>__Program_Disposed;

			// Token: 0x0400021F RID: 543
			public static EventHandler <4>__Program_Exited;

			// Token: 0x04000220 RID: 544
			public static EventHandler <5>__CurrentDomain_ProcessExit;
		}
	}
}

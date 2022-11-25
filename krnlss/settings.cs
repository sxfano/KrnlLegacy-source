using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using krnlss.Properties;
using ToggleSlider;

namespace krnlss
{
	// Token: 0x02000014 RID: 20
	public partial class settings : Form
	{
		// Token: 0x06000195 RID: 405
		[DllImport("user32.dll")]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// Token: 0x06000196 RID: 406 RVA: 0x000158EF File Offset: 0x00013AEF
		public settings(Form parentt)
		{
			this.InitializeComponent();
			this.parent = parentt;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00015904 File Offset: 0x00013B04
		private void krnl_Load(object sender, EventArgs e)
		{
			if (Settings.Default.autoinject)
			{
				this.toggleSliderComponent1.Checked = true;
			}
			if (Settings.Default.topmostchecked)
			{
				this.toggleSliderComponent2.Checked = true;
			}
			if (Settings.Default.fadein_out_opacity)
			{
				this.toggleSliderComponent3.Checked = true;
			}
			if (Settings.Default.remove_crash_logs)
			{
				this.toggleSliderComponent4.Checked = true;
			}
			if (Settings.Default.monaco)
			{
				this.toggleSliderComponent5.Checked = true;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00015989 File Offset: 0x00013B89
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00015990 File Offset: 0x00013B90
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00015992 File Offset: 0x00013B92
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00015994 File Offset: 0x00013B94
		private void OPACITYASSS_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00015996 File Offset: 0x00013B96
		private void button1_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001599E File Offset: 0x00013B9E
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000159A0 File Offset: 0x00013BA0
		private void panel1_MouseDown_1(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				krnl.ReleaseCapture();
				krnl.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000159C8 File Offset: 0x00013BC8
		private void toggleSliderComponent2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000159CA File Offset: 0x00013BCA
		private void button4_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000159D2 File Offset: 0x00013BD2
		private void button3_Click_1(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060001A2 RID: 418
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		// Token: 0x060001A3 RID: 419
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x060001A4 RID: 420 RVA: 0x000159DC File Offset: 0x00013BDC
		private static bool findpipe(string pipeName)
		{
			bool result;
			try
			{
				if (settings.WaitNamedPipe(Path.GetFullPath("\\\\.\\pipe\\" + pipeName), 0) && (Marshal.GetLastWin32Error() == 0 || Marshal.GetLastWin32Error() == 2))
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00015A30 File Offset: 0x00013C30
		private void autoinjectbruh()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00015A32 File Offset: 0x00013C32
		private void toggleSliderComponent1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00015A34 File Offset: 0x00013C34
		private void toggleSliderComponent1_CheckChanged(object sender, EventArgs e)
		{
			if (this.toggleSliderComponent1.Checked)
			{
				this.autoinjectiont = new Thread(new ThreadStart(this.autoinjectbruh));
				this.autoinjectiont.IsBackground = true;
				this.autoinjectiont.Start();
				Settings.Default.autoinject = true;
				Settings.Default.Save();
				return;
			}
			if (this.autoinjectiont != null)
			{
				this.autoinjectiont.Abort();
				this.autoinjectiont = null;
			}
			Settings.Default.autoinject = false;
			Settings.Default.Save();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00015AC4 File Offset: 0x00013CC4
		private void toggleSliderComponent2_CheckChanged(object sender, EventArgs e)
		{
			if (this.toggleSliderComponent2.Checked)
			{
				base.TopMost = true;
				this.parent.TopMost = true;
				Settings.Default.topmostchecked = true;
				Settings.Default.Save();
				return;
			}
			base.TopMost = false;
			this.parent.TopMost = false;
			Settings.Default.topmostchecked = false;
			Settings.Default.Save();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00015B2F File Offset: 0x00013D2F
		private void settings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (settings.monaco_changed)
			{
				base.TopMost = true;
				if (MessageBox.Show("Automatically restart the UI to complete the changes?", "Krnl Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Process.Start(Process.GetCurrentProcess().MainModule.FileName);
				}
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00016A6B File Offset: 0x00014C6B
		private void toggleSliderComponent3_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00016A70 File Offset: 0x00014C70
		private void toggleSliderComponent3_CheckChanged(object sender, EventArgs e)
		{
			Settings.Default.fadein_out_opacity = this.toggleSliderComponent3.Checked;
			if (Settings.Default.fadein_out_opacity)
			{
				while (this.parent.Opacity > 0.5)
				{
					Task.Delay(10).GetAwaiter().GetResult();
					this.parent.Opacity -= 0.05;
				}
			}
			else
			{
				while (this.parent.Opacity < 1.0)
				{
					Task.Delay(10).GetAwaiter().GetResult();
					this.parent.Opacity += 0.05;
				}
			}
			Settings.Default.Save();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00016B36 File Offset: 0x00014D36
		private void button1_Click_2(object sender, EventArgs e)
		{
			new WebClient().DownloadFile(new Uri("https://k-storage.com/krnl_bootstrapper.exe"), "krnl_bootstrapper.exe");
			Process.Start("krnl_bootstrapper.exe");
			Environment.Exit(1);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00016B62 File Offset: 0x00014D62
		private void toggleSliderComponent4_CheckChanged(object sender, EventArgs e)
		{
			Settings.Default.remove_crash_logs = this.toggleSliderComponent4.Checked;
			Settings.Default.Save();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00016B83 File Offset: 0x00014D83
		private void toggleSliderComponent4_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00016B85 File Offset: 0x00014D85
		private void toggleSliderComponent5_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00016B87 File Offset: 0x00014D87
		private void toggleSliderComponent5_CheckChanged(object sender, EventArgs e)
		{
			settings.monaco_changed = !settings.monaco_changed;
			Settings.Default.monaco = this.toggleSliderComponent5.Checked;
			Settings.Default.Save();
		}

		// Token: 0x04000134 RID: 308
		private Form parent;

		// Token: 0x04000135 RID: 309
		private Thread autoinjectiont;

		// Token: 0x04000149 RID: 329
		public static bool monaco_changed;
	}
}

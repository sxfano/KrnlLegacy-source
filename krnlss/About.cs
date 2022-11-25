using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace krnlss
{
	// Token: 0x0200000F RID: 15
	public partial class About : Form
	{
		// Token: 0x060000BD RID: 189
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060000BE RID: 190
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060000BF RID: 191 RVA: 0x000091EE File Offset: 0x000073EE
		public About()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000091FC File Offset: 0x000073FC
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00009204 File Offset: 0x00007404
		private void panel1_Move(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00009206 File Offset: 0x00007406
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00009208 File Offset: 0x00007408
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				About.ReleaseCapture();
				About.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00009230 File Offset: 0x00007430
		private void About_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000067 RID: 103
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000068 RID: 104
		public const int HT_CAPTION = 2;
	}
}

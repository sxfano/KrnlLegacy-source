using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace krnlss
{
	// Token: 0x02000010 RID: 16
	public partial class Games : Form
	{
		// Token: 0x060000C7 RID: 199
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060000C8 RID: 200
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060000C9 RID: 201 RVA: 0x00009D1A File Offset: 0x00007F1A
		public Games()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00009D33 File Offset: 0x00007F33
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00009D3C File Offset: 0x00007F3C
		private void Games_Load(object sender, EventArgs e)
		{
			this.panel2.Visible = false;
			this.panel3.Visible = false;
			this.listPanel.Add(this.panel2);
			this.listPanel.Add(this.panel3);
			this.listPanel[this.i].BringToFront();
			this.listPanel[this.i].Visible = true;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00009DB0 File Offset: 0x00007FB0
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Games.ReleaseCapture();
				Games.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00009DD8 File Offset: 0x00007FD8
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Jxnt Scripts", "Credits");
			krnl.Pipe("loadstring(game:HttpGet('https://system-exodus.com/scripts/ninjalegends/NinjaLegendsV2.lua', true))()");
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00009DF4 File Offset: 0x00007FF4
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/rT3UCQRs', true))();");
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00009E00 File Offset: 0x00008000
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/cE6kQe1G', true))();");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00009E0C File Offset: 0x0000800C
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/J420Y71u', true))();");
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00009E18 File Offset: 0x00008018
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			krnl.Pipe("\r\n                while wait(0.5) do\r\n                local stuff = workspace:getDescendants()\r\n                for i=1,#stuff do\r\n                if stuff[i].Name == 'Hitbox' then\r\n                if stuff[i].Parent.Name ~= game.Players.LocalPlayer.Name then\r\n                stuff[i].Massless = true\r\n                stuff[i].Size = Vector3.new (100,100,100)\r\n                stuff[i].Transparency = 0.5\r\n                end\r\n                end\r\n                end\r\n                end\r\n            ");
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00009E24 File Offset: 0x00008024
		private void pictureBox7_Click(object sender, EventArgs e)
		{
			krnl.Pipe("\r\n                _G.ServerHop = false\r\n                _G.PercentageToHop = 25\r\n                _G.AutoEquipMask = false\r\n                _G.RepFarm = false\r\n                _G.AogiriFarm = false\r\n                _G.CCGFarm = false\r\n                _G.HumanFarm = false\r\n                _G.FarmAll = false\r\n                _G.PlayAsGhoul = false\r\n                _G.PlayAsCCG = false\r\n\r\n                loadstring(game:HttpGet(('https://pastebin.com/raw/x9She8BF'),true))()\r\n            ");
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00009E30 File Offset: 0x00008030
		private void pictureBox9_Click(object sender, EventArgs e)
		{
			krnl.Pipe("\r\n                local player = game.Players.LocalPlayer\r\n                local library = loadstring(game:HttpGet('https://pastebin.com/raw/JsdM2jiP',true))()\r\n                library.options.underlinecolor = 'rainbow'\r\n\r\n                -- Ranch Tab\r\n                local Ranch = library:CreateWindow('Ranch')\r\n                Ranch: Section('- Ranch -')\r\n                local Upgrade = Ranch:Toggle('Auto Upgrade Ranch', { flag = 'RU'})\r\n                local EquipBest = Ranch:Toggle('Auto Equip Pets', { flag = 'EP'})\r\n\r\n                --Auto Upgrade\r\n                spawn(function()\r\n                while wait(.01) do\r\n                                    if Ranch.flags.RU then\r\n                                    game:GetService('ReplicatedStorage').RemoteFunctions.MainRemoteFunction:InvokeServer('UpgradeRanch', false)\r\n                end\r\n                end\r\n                end)\r\n\r\n                --Auto Equip\r\n                spawn(function()\r\n                while wait(.01) do\r\n                                    if Ranch.flags.EP then\r\n                                    game:GetService('ReplicatedStorage').RemoteFunctions.MainRemoteFunction:InvokeServer('EquipTopPets')\r\n                end\r\n                end\r\n                end)\r\n            ");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00009E3C File Offset: 0x0000803C
		private void pictureBox8_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/bCYBdgTD', true))();");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00009E48 File Offset: 0x00008048
		private void pictureBox6_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/ecVs72us', true))()");
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00009E54 File Offset: 0x00008054
		private void pictureBox10_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/p2wJy279', true))()");
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00009E60 File Offset: 0x00008060
		private void pictureBox12_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/WBfWy8Md', true))()");
			MessageBox.Show("This script was created by Jxnt#9946!");
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00009E77 File Offset: 0x00008077
		private void pictureBox11_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/Rge4t3Sh', true))()");
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00009E84 File Offset: 0x00008084
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.i < this.listPanel.Count - 1)
			{
				this.listPanel[this.i].Visible = false;
				List<Panel> list = this.listPanel;
				int index = this.i + 1;
				this.i = index;
				list[index].BringToFront();
				this.listPanel[this.i].Visible = true;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00009EF8 File Offset: 0x000080F8
		private void button3_Click(object sender, EventArgs e)
		{
			if (this.i > 0)
			{
				this.listPanel[this.i].Visible = false;
				List<Panel> list = this.listPanel;
				int index = this.i - 1;
				this.i = index;
				list[index].BringToFront();
				this.listPanel[this.i].Visible = true;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00009F5D File Offset: 0x0000815D
		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00009F5F File Offset: 0x0000815F
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x04000078 RID: 120
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000079 RID: 121
		public const int HT_CAPTION = 2;

		// Token: 0x0400007A RID: 122
		private List<Panel> listPanel = new List<Panel>();

		// Token: 0x0400007B RID: 123
		private int i;
	}
}

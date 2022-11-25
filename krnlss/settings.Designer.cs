namespace krnlss
{
	// Token: 0x02000014 RID: 20
	public partial class settings : global::System.Windows.Forms.Form
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00015B69 File Offset: 0x00013D69
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00015B88 File Offset: 0x00013D88
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::krnlss.settings));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuCustomLabel3 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel4 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel5 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel6 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.toggleSliderComponent5 = new global::ToggleSlider.ToggleSliderComponent();
			this.toggleSliderComponent4 = new global::ToggleSlider.ToggleSliderComponent();
			this.toggleSliderComponent3 = new global::ToggleSlider.ToggleSliderComponent();
			this.toggleSliderComponent2 = new global::ToggleSlider.ToggleSliderComponent();
			this.toggleSliderComponent1 = new global::ToggleSlider.ToggleSliderComponent();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Location = new global::System.Drawing.Point(-9, -3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(281, 37);
			this.panel1.TabIndex = 13;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(7, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(35, 36);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(110, 11);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(54, 17);
			this.label1.TabIndex = 23;
			this.label1.Text = "Settings";
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.button3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(200, -1);
			this.button3.Margin = new global::System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(25, 37);
			this.button3.TabIndex = 22;
			this.button3.Text = "—";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click_1);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.Color.White;
			this.button4.Location = new global::System.Drawing.Point(228, -1);
			this.button4.Margin = new global::System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(25, 37);
			this.button4.TabIndex = 21;
			this.button4.Text = "✕";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(10, 81);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(64, 17);
			this.bunifuCustomLabel1.TabIndex = 15;
			this.bunifuCustomLabel1.Text = "Top Most";
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel2.ForeColor = global::System.Drawing.Color.White;
			this.bunifuCustomLabel2.Location = new global::System.Drawing.Point(10, 55);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new global::System.Drawing.Size(75, 17);
			this.bunifuCustomLabel2.TabIndex = 17;
			this.bunifuCustomLabel2.Text = "Auto Attach";
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			this.bunifuCustomLabel3.AutoSize = true;
			this.bunifuCustomLabel3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel3.ForeColor = global::System.Drawing.Color.White;
			this.bunifuCustomLabel3.Location = new global::System.Drawing.Point(12, 108);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new global::System.Drawing.Size(123, 17);
			this.bunifuCustomLabel3.TabIndex = 15;
			this.bunifuCustomLabel3.Text = "Opacity Fade-in/out";
			this.bunifuCustomLabel4.AutoSize = true;
			this.bunifuCustomLabel4.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel4.ForeColor = global::System.Drawing.Color.White;
			this.bunifuCustomLabel4.Location = new global::System.Drawing.Point(12, 195);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new global::System.Drawing.Size(116, 17);
			this.bunifuCustomLabel4.TabIndex = 21;
			this.bunifuCustomLabel4.Text = "Install missing files";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(155, 195);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(62, 23);
			this.button1.TabIndex = 22;
			this.button1.Text = "INSTALL";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_2);
			this.bunifuCustomLabel5.AutoSize = true;
			this.bunifuCustomLabel5.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel5.ForeColor = global::System.Drawing.Color.White;
			this.bunifuCustomLabel5.Location = new global::System.Drawing.Point(12, 134);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new global::System.Drawing.Size(124, 17);
			this.bunifuCustomLabel5.TabIndex = 15;
			this.bunifuCustomLabel5.Text = "Remove Crash Logs";
			this.bunifuCustomLabel6.AutoSize = true;
			this.bunifuCustomLabel6.Enabled = false;
			this.bunifuCustomLabel6.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel6.ForeColor = global::System.Drawing.Color.White;
			this.bunifuCustomLabel6.Location = new global::System.Drawing.Point(12, 163);
			this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
			this.bunifuCustomLabel6.Size = new global::System.Drawing.Size(100, 17);
			this.bunifuCustomLabel6.TabIndex = 15;
			this.bunifuCustomLabel6.Text = "Toggle Monaco";
			this.toggleSliderComponent5.AutoSize = true;
			this.toggleSliderComponent5.Checked = false;
			this.toggleSliderComponent5.Location = new global::System.Drawing.Point(187, 163);
			this.toggleSliderComponent5.Margin = new global::System.Windows.Forms.Padding(4);
			this.toggleSliderComponent5.Name = "toggleSliderComponent5";
			this.toggleSliderComponent5.Size = new global::System.Drawing.Size(54, 21);
			this.toggleSliderComponent5.TabIndex = 20;
			this.toggleSliderComponent5.ToggleBarText = "";
			this.toggleSliderComponent5.ToggleCircleColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.toggleSliderComponent5.ToggleColorBar = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.toggleSliderComponent5.CheckChanged += new global::System.EventHandler(this.toggleSliderComponent5_CheckChanged);
			this.toggleSliderComponent5.Load += new global::System.EventHandler(this.toggleSliderComponent5_Load);
			this.toggleSliderComponent4.AutoSize = true;
			this.toggleSliderComponent4.Checked = false;
			this.toggleSliderComponent4.Location = new global::System.Drawing.Point(187, 134);
			this.toggleSliderComponent4.Margin = new global::System.Windows.Forms.Padding(4);
			this.toggleSliderComponent4.Name = "toggleSliderComponent4";
			this.toggleSliderComponent4.Size = new global::System.Drawing.Size(54, 21);
			this.toggleSliderComponent4.TabIndex = 20;
			this.toggleSliderComponent4.ToggleBarText = "";
			this.toggleSliderComponent4.ToggleCircleColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.toggleSliderComponent4.ToggleColorBar = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.toggleSliderComponent4.CheckChanged += new global::System.EventHandler(this.toggleSliderComponent4_CheckChanged);
			this.toggleSliderComponent4.Load += new global::System.EventHandler(this.toggleSliderComponent4_Load);
			this.toggleSliderComponent3.AutoSize = true;
			this.toggleSliderComponent3.Checked = false;
			this.toggleSliderComponent3.Location = new global::System.Drawing.Point(187, 108);
			this.toggleSliderComponent3.Margin = new global::System.Windows.Forms.Padding(4);
			this.toggleSliderComponent3.Name = "toggleSliderComponent3";
			this.toggleSliderComponent3.Size = new global::System.Drawing.Size(54, 21);
			this.toggleSliderComponent3.TabIndex = 20;
			this.toggleSliderComponent3.ToggleBarText = "";
			this.toggleSliderComponent3.ToggleCircleColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.toggleSliderComponent3.ToggleColorBar = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.toggleSliderComponent3.CheckChanged += new global::System.EventHandler(this.toggleSliderComponent3_CheckChanged);
			this.toggleSliderComponent3.Load += new global::System.EventHandler(this.toggleSliderComponent3_Load);
			this.toggleSliderComponent2.AutoSize = true;
			this.toggleSliderComponent2.Checked = false;
			this.toggleSliderComponent2.Location = new global::System.Drawing.Point(187, 81);
			this.toggleSliderComponent2.Margin = new global::System.Windows.Forms.Padding(4);
			this.toggleSliderComponent2.Name = "toggleSliderComponent2";
			this.toggleSliderComponent2.Size = new global::System.Drawing.Size(54, 21);
			this.toggleSliderComponent2.TabIndex = 20;
			this.toggleSliderComponent2.ToggleBarText = "";
			this.toggleSliderComponent2.ToggleCircleColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.toggleSliderComponent2.ToggleColorBar = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.toggleSliderComponent2.CheckChanged += new global::System.EventHandler(this.toggleSliderComponent2_CheckChanged);
			this.toggleSliderComponent2.Load += new global::System.EventHandler(this.toggleSliderComponent2_Load);
			this.toggleSliderComponent1.AutoSize = true;
			this.toggleSliderComponent1.Checked = false;
			this.toggleSliderComponent1.Location = new global::System.Drawing.Point(187, 55);
			this.toggleSliderComponent1.Margin = new global::System.Windows.Forms.Padding(4);
			this.toggleSliderComponent1.Name = "toggleSliderComponent1";
			this.toggleSliderComponent1.Size = new global::System.Drawing.Size(54, 21);
			this.toggleSliderComponent1.TabIndex = 19;
			this.toggleSliderComponent1.ToggleBarText = "";
			this.toggleSliderComponent1.ToggleCircleColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.toggleSliderComponent1.ToggleColorBar = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.toggleSliderComponent1.CheckChanged += new global::System.EventHandler(this.toggleSliderComponent1_CheckChanged);
			this.toggleSliderComponent1.Load += new global::System.EventHandler(this.toggleSliderComponent1_Load);
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(248, 230);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.bunifuCustomLabel4);
			base.Controls.Add(this.toggleSliderComponent5);
			base.Controls.Add(this.toggleSliderComponent4);
			base.Controls.Add(this.toggleSliderComponent3);
			base.Controls.Add(this.toggleSliderComponent2);
			base.Controls.Add(this.toggleSliderComponent1);
			base.Controls.Add(this.bunifuCustomLabel2);
			base.Controls.Add(this.bunifuCustomLabel6);
			base.Controls.Add(this.bunifuCustomLabel5);
			base.Controls.Add(this.bunifuCustomLabel3);
			base.Controls.Add(this.bunifuCustomLabel1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "settings";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.settings_FormClosing);
			base.Load += new global::System.EventHandler(this.krnl_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000136 RID: 310
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000138 RID: 312
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000139 RID: 313
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;

		// Token: 0x0400013A RID: 314
		private global::ToggleSlider.ToggleSliderComponent toggleSliderComponent1;

		// Token: 0x0400013B RID: 315
		private global::ToggleSlider.ToggleSliderComponent toggleSliderComponent2;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400013E RID: 318
		private global::ToggleSlider.ToggleSliderComponent toggleSliderComponent3;

		// Token: 0x0400013F RID: 319
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000142 RID: 322
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000144 RID: 324
		private global::ToggleSlider.ToggleSliderComponent toggleSliderComponent4;

		// Token: 0x04000145 RID: 325
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;

		// Token: 0x04000146 RID: 326
		private global::ToggleSlider.ToggleSliderComponent toggleSliderComponent5;

		// Token: 0x04000147 RID: 327
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;

		// Token: 0x04000148 RID: 328
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}

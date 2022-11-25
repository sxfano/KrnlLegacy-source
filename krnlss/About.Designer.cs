namespace krnlss
{
	// Token: 0x0200000F RID: 15
	public partial class About : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00009232 File Offset: 0x00007432
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009254 File Offset: 0x00007454
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::krnlss.About));
			this.button1 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Corbel", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			this.button1.Location = new global::System.Drawing.Point(285, 0);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(35, 33);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(320, 33);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.Move += new global::System.EventHandler(this.panel1_Move);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(-64, -21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(270, 237);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(140, 59);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(168, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "UI Design and Components";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label2.Location = new global::System.Drawing.Point(140, 78);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(25, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Iris";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label3.Location = new global::System.Drawing.Point(164, 78);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(51, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Littensy";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label4.Location = new global::System.Drawing.Point(140, 116);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(54, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Ice Bear";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(140, 97);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(111, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Exploit Developer";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label6.Location = new global::System.Drawing.Point(230, 154);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(72, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "KowalskiFX";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label7.Location = new global::System.Drawing.Point(140, 154);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(75, 17);
			this.label7.TabIndex = 9;
			this.label7.Text = "Customality";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(140, 135);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(49, 17);
			this.label8.TabIndex = 8;
			this.label8.Text = "Credits";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label9.Location = new global::System.Drawing.Point(212, 78);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(24, 17);
			this.label9.TabIndex = 11;
			this.label9.Text = "XV";
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label10.Location = new global::System.Drawing.Point(234, 78);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(35, 17);
			this.label10.TabIndex = 11;
			this.label10.Text = "0x00";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label11.Location = new global::System.Drawing.Point(268, 78);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(34, 17);
			this.label11.TabIndex = 11;
			this.label11.Text = "King";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			base.ClientSize = new global::System.Drawing.Size(320, 191);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "About";
			this.Text = "About";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.About_Load);
			this.panel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000069 RID: 105
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Label label9;
	}
}

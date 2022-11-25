using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ToggleSlider
{
	// Token: 0x02000007 RID: 7
	public class ToggleSliderComponent : UserControl
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000256B File Offset: 0x0000076B
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002573 File Offset: 0x00000773
		public bool Checked
		{
			get
			{
				return this.Checked_bool;
			}
			set
			{
				this.Checked_bool = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002582 File Offset: 0x00000782
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000258A File Offset: 0x0000078A
		public Color ToggleCircleColor
		{
			get
			{
				return this.ToggleColorDisabled_Color;
			}
			set
			{
				this.ToggleColorDisabled_Color = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002599 File Offset: 0x00000799
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000025A1 File Offset: 0x000007A1
		public Color ToggleColorBar
		{
			get
			{
				return this.Bar_Color;
			}
			set
			{
				this.Bar_Color = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000025B8 File Offset: 0x000007B8
		public string ToggleBarText
		{
			get
			{
				return this.Text;
			}
			set
			{
				this.Text = value;
				base.Invalidate();
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000041 RID: 65 RVA: 0x000025C8 File Offset: 0x000007C8
		// (remove) Token: 0x06000042 RID: 66 RVA: 0x00002600 File Offset: 0x00000800
		public event EventHandler CheckChanged;

		// Token: 0x06000043 RID: 67 RVA: 0x00002638 File Offset: 0x00000838
		public ToggleSliderComponent()
		{
			this.InitializeComponent();
			this.DoubleBuffered = true;
			base.Click += this.ToggleSlider_Click;
			this.timer1.Tick += this.Timer1_Tick;
			this.AutoSize = true;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000026BC File Offset: 0x000008BC
		protected override void OnPaint(PaintEventArgs pevent)
		{
			if (this.init_)
			{
				this.circlecolor_ = this.ToggleColorDisabled_Color;
			}
			pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			Size size = new Size(Convert.ToInt32(this.Font.SizeInPoints * 5f), Convert.ToInt32(this.Font.SizeInPoints * 5f));
			ToggleSliderComponent.RoundedRect(this.Bar_Color, pevent.Graphics, new Rectangle(size.Width / 4, size.Height / 5 / 2, size.Width / 2, 3 * (size.Height / 5) / 2), 5);
			new LinearGradientBrush(new Point(size.Width / 4, size.Height / 5 / 2), new Point(size.Width / 2, size.Height / 2), this.ToggleColorDisabled_Color, this.ToggleColorDisabled_Color);
			if (!this.animating_)
			{
				if (!this.Checked_bool)
				{
					this.posx = 0;
				}
				else
				{
					this.posx = size.Width / 2;
				}
			}
			pevent.Graphics.FillEllipse(new SolidBrush(this.ToggleColorDisabled_Color), this.posx, this.posy, size.Width / 2, size.Height / 2);
			TextRenderer.DrawText(pevent.Graphics, this.ToggleBarText, this.Font, new Point(size.Width, size.Height / 10), this.ForeColor);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000283B File Offset: 0x00000A3B
		private void ToggleSlider_Click(object sender, EventArgs e)
		{
			this.Animate();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002843 File Offset: 0x00000A43
		private void Animate()
		{
			this.timer1.Interval = 1;
			this.timer1.Start();
			this.animating_ = true;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002864 File Offset: 0x00000A64
		private void Timer1_Tick(object sender, EventArgs e)
		{
			Size size = new Size(Convert.ToInt32(this.Font.SizeInPoints * 5f), Convert.ToInt32(this.Font.SizeInPoints * 5f));
			if (this.Checked_bool)
			{
				if (this.posx > 0)
				{
					this.posx -= 3;
					base.Invalidate();
					return;
				}
				this.Checked_bool = false;
				this.animating_ = false;
				if (this.CheckChanged != null)
				{
					this.CheckChanged(this, e);
				}
				this.timer1.Stop();
				return;
			}
			else
			{
				this.init_ = false;
				if (this.posx < size.Width / 2)
				{
					this.posx += 3;
					base.Invalidate();
					return;
				}
				this.Checked_bool = true;
				this.animating_ = false;
				if (this.CheckChanged != null)
				{
					this.CheckChanged(this, e);
				}
				this.timer1.Stop();
				return;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002954 File Offset: 0x00000B54
		public static GraphicsPath RoundedRect(Color c, Graphics g, Rectangle bounds, int radius)
		{
			int num = radius * 2;
			Size size = new Size(num, num);
			Rectangle rect = new Rectangle(bounds.Location, size);
			GraphicsPath graphicsPath = new GraphicsPath();
			if (radius == 0)
			{
				graphicsPath.AddRectangle(bounds);
				return graphicsPath;
			}
			graphicsPath.AddArc(rect, 180f, 90f);
			rect.X = bounds.Right - num;
			graphicsPath.AddArc(rect, 270f, 90f);
			rect.Y = bounds.Bottom - num;
			graphicsPath.AddArc(rect, 0f, 90f);
			rect.X = bounds.Left;
			graphicsPath.AddArc(rect, 90f, 90f);
			g.FillPath(new SolidBrush(c), graphicsPath);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002A14 File Offset: 0x00000C14
		private void ToggleSliderComponent_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002A16 File Offset: 0x00000C16
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002A38 File Offset: 0x00000C38
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Margin = new Padding(4, 4, 4, 4);
			base.Name = "ToggleSliderComponent";
			base.Size = new Size(308, 52);
			base.Load += this.ToggleSliderComponent_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x0400000B RID: 11
		private bool Checked_bool;

		// Token: 0x0400000C RID: 12
		private Color ToggleColorDisabled_Color = Color.Green;

		// Token: 0x0400000D RID: 13
		private Color Bar_Color = Color.Gray;

		// Token: 0x0400000E RID: 14
		private new string Text = "toggleSlider1";

		// Token: 0x0400000F RID: 15
		private int posx;

		// Token: 0x04000010 RID: 16
		private int posy;

		// Token: 0x04000011 RID: 17
		private bool init_ = true;

		// Token: 0x04000012 RID: 18
		private Color circlecolor_;

		// Token: 0x04000013 RID: 19
		private bool animating_;

		// Token: 0x04000014 RID: 20
		private Timer timer1 = new Timer();

		// Token: 0x04000015 RID: 21
		private IContainer components;
	}
}

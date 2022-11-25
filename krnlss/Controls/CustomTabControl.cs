using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using krnlss;
using Microsoft.CSharp.RuntimeBinder;
using ScintillaNET;

namespace Controls
{
	// Token: 0x0200000C RID: 12
	public class CustomTabControl : TabControl
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002BE6 File Offset: 0x00000DE6
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002BEE File Offset: 0x00000DEE
		public bool ShowClosingButton { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002BF7 File Offset: 0x00000DF7
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002BFF File Offset: 0x00000DFF
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002C08 File Offset: 0x00000E08
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002C10 File Offset: 0x00000E10
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002C19 File Offset: 0x00000E19
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002C21 File Offset: 0x00000E21
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002C2A File Offset: 0x00000E2A
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002C32 File Offset: 0x00000E32
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

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002C3B File Offset: 0x00000E3B
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002C43 File Offset: 0x00000E43
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002C4C File Offset: 0x00000E4C
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002C54 File Offset: 0x00000E54
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002C5D File Offset: 0x00000E5D
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002C65 File Offset: 0x00000E65
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002C6E File Offset: 0x00000E6E
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002C76 File Offset: 0x00000E76
		[Category("Options")]
		[Browsable(true)]
		[Description("Show a Yes/No message before closing?")]
		public bool ShowClosingMessage { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002C7F File Offset: 0x00000E7F
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002C87 File Offset: 0x00000E87
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002C90 File Offset: 0x00000E90
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002C98 File Offset: 0x00000E98
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

		// Token: 0x06000074 RID: 116
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000075 RID: 117 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public CustomTabControl()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.SizeMode = TabSizeMode.Normal;
			base.ItemSize = new Size(240, 16);
			this.AllowDrop = true;
			base.Selecting += this.TabChanging;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002DAD File Offset: 0x00000FAD
		protected override void CreateHandle()
		{
			base.CreateHandle();
			base.Alignment = TabAlignment.Top;
			CustomTabControl.SendMessage(base.Handle, 4913, IntPtr.Zero, (IntPtr)16);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002DDC File Offset: 0x00000FDC
		protected override void OnDragOver(DragEventArgs drgevent)
		{
			if (this.predraggedTab != null)
			{
				TabPage tabPage = (TabPage)drgevent.Data.GetData(typeof(TabPage));
				TabPage pointedTab = this.GetPointedTab();
				int num = base.TabPages.IndexOf(tabPage);
				if (tabPage != null && num != base.TabCount)
				{
					TabPage tabPage2 = base.TabPages[base.TabCount - 1];
					if (tabPage != tabPage2 && tabPage == this.predraggedTab && pointedTab != null)
					{
						drgevent.Effect = DragDropEffects.Move;
						if (pointedTab != tabPage2 && pointedTab != tabPage)
						{
							this.ReplaceTabPages(tabPage, pointedTab);
						}
					}
				}
			}
			base.OnDragOver(drgevent);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002E70 File Offset: 0x00001070
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.predraggedTab = this.GetPointedTab();
			Point location = e.Location;
			for (int i = 0; i < base.TabCount; i++)
			{
				object obj = base.GetTabRect(i);
				if (CustomTabControl.<>o__53.<>p__2 == null)
				{
					CustomTabControl.<>o__53.<>p__2 = CallSite<Action<CallSite, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Offset", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Action<CallSite, object, object, int> target = CustomTabControl.<>o__53.<>p__2.Target;
				CallSite <>p__ = CustomTabControl.<>o__53.<>p__2;
				object arg = obj;
				if (CustomTabControl.<>o__53.<>p__1 == null)
				{
					CustomTabControl.<>o__53.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Subtract, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target2 = CustomTabControl.<>o__53.<>p__1.Target;
				CallSite <>p__2 = CustomTabControl.<>o__53.<>p__1;
				if (CustomTabControl.<>o__53.<>p__0 == null)
				{
					CustomTabControl.<>o__53.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Width", typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, arg, target2(<>p__2, CustomTabControl.<>o__53.<>p__0.Target(CustomTabControl.<>o__53.<>p__0, obj), 15), 2);
				if (CustomTabControl.<>o__53.<>p__3 == null)
				{
					CustomTabControl.<>o__53.<>p__3 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Width", typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				CustomTabControl.<>o__53.<>p__3.Target(CustomTabControl.<>o__53.<>p__3, obj, 10);
				if (CustomTabControl.<>o__53.<>p__4 == null)
				{
					CustomTabControl.<>o__53.<>p__4 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Height", typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				CustomTabControl.<>o__53.<>p__4.Target(CustomTabControl.<>o__53.<>p__4, obj, 10);
				if (CustomTabControl.<>o__53.<>p__6 == null)
				{
					CustomTabControl.<>o__53.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target3 = CustomTabControl.<>o__53.<>p__6.Target;
				CallSite <>p__3 = CustomTabControl.<>o__53.<>p__6;
				if (CustomTabControl.<>o__53.<>p__5 == null)
				{
					CustomTabControl.<>o__53.<>p__5 = CallSite<Func<CallSite, object, Point, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				object arg2 = target3(<>p__3, CustomTabControl.<>o__53.<>p__5.Target(CustomTabControl.<>o__53.<>p__5, obj, location));
				if (CustomTabControl.<>o__53.<>p__9 == null)
				{
					CustomTabControl.<>o__53.<>p__9 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (!CustomTabControl.<>o__53.<>p__9.Target(CustomTabControl.<>o__53.<>p__9, arg2))
				{
					if (CustomTabControl.<>o__53.<>p__8 == null)
					{
						CustomTabControl.<>o__53.<>p__8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target4 = CustomTabControl.<>o__53.<>p__8.Target;
					CallSite <>p__4 = CustomTabControl.<>o__53.<>p__8;
					if (CustomTabControl.<>o__53.<>p__7 == null)
					{
						CustomTabControl.<>o__53.<>p__7 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					if (!target4(<>p__4, CustomTabControl.<>o__53.<>p__7.Target(CustomTabControl.<>o__53.<>p__7, arg2, e.Button != MouseButtons.Left)))
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
										tabPage.Text = "Untitled.lua";
										this.GetWorkingTextEditor().Text = "";
									}
									return;
								}
								if (tabPage.Controls.Count > 0)
								{
									tabPage.Controls[0].Dispose();
								}
								base.TabPages.RemoveAt(i);
								break;
							}
							else
							{
								this.CloseTab(tabPage);
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

		// Token: 0x06000079 RID: 121 RVA: 0x000032DF File Offset: 0x000014DF
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && this.predraggedTab != null)
			{
				base.DoDragDrop(this.predraggedTab, DragDropEffects.Move);
			}
			base.OnMouseMove(e);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000330C File Offset: 0x0000150C
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.predraggedTab = null;
			this.contextTab = null;
			if (e.Button == MouseButtons.Right)
			{
				CustomTabControl.Form1.TabContextMenu.Show(Cursor.Position);
				this.contextTab = this.GetPointedTab();
			}
			base.OnMouseUp(e);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000335C File Offset: 0x0000155C
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

		// Token: 0x0600007C RID: 124 RVA: 0x00003698 File Offset: 0x00001898
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

		// Token: 0x0600007D RID: 125 RVA: 0x000036E8 File Offset: 0x000018E8
		private void ReplaceTabPages(TabPage Source, TabPage Destination)
		{
			object obj = base.TabPages.IndexOf(Source);
			object obj2 = base.TabPages.IndexOf(Destination);
			if (CustomTabControl.<>o__58.<>p__0 == null)
			{
				CustomTabControl.<>o__58.<>p__0 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			object obj3 = CustomTabControl.<>o__58.<>p__0.Target(CustomTabControl.<>o__58.<>p__0, obj, -1);
			if (CustomTabControl.<>o__58.<>p__1 == null)
			{
				CustomTabControl.<>o__58.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (!CustomTabControl.<>o__58.<>p__1.Target(CustomTabControl.<>o__58.<>p__1, obj3))
			{
				if (CustomTabControl.<>o__58.<>p__4 == null)
				{
					CustomTabControl.<>o__58.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = CustomTabControl.<>o__58.<>p__4.Target;
				CallSite <>p__ = CustomTabControl.<>o__58.<>p__4;
				if (CustomTabControl.<>o__58.<>p__3 == null)
				{
					CustomTabControl.<>o__58.<>p__3 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Or, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target2 = CustomTabControl.<>o__58.<>p__3.Target;
				CallSite <>p__2 = CustomTabControl.<>o__58.<>p__3;
				object arg = obj3;
				if (CustomTabControl.<>o__58.<>p__2 == null)
				{
					CustomTabControl.<>o__58.<>p__2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (!target(<>p__, target2(<>p__2, arg, CustomTabControl.<>o__58.<>p__2.Target(CustomTabControl.<>o__58.<>p__2, obj2, -1))))
				{
					if (CustomTabControl.<>o__58.<>p__5 == null)
					{
						CustomTabControl.<>o__58.<>p__5 = CallSite<Func<CallSite, TabControl.TabPageCollection, object, TabPage, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					CustomTabControl.<>o__58.<>p__5.Target(CustomTabControl.<>o__58.<>p__5, base.TabPages, obj2, Source);
					if (CustomTabControl.<>o__58.<>p__6 == null)
					{
						CustomTabControl.<>o__58.<>p__6 = CallSite<Func<CallSite, TabControl.TabPageCollection, object, TabPage, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					CustomTabControl.<>o__58.<>p__6.Target(CustomTabControl.<>o__58.<>p__6, base.TabPages, obj, Destination);
					if (CustomTabControl.<>o__58.<>p__8 == null)
					{
						CustomTabControl.<>o__58.<>p__8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target3 = CustomTabControl.<>o__58.<>p__8.Target;
					CallSite <>p__3 = CustomTabControl.<>o__58.<>p__8;
					if (CustomTabControl.<>o__58.<>p__7 == null)
					{
						CustomTabControl.<>o__58.<>p__7 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (target3(<>p__3, CustomTabControl.<>o__58.<>p__7.Target(CustomTabControl.<>o__58.<>p__7, base.SelectedIndex, obj)))
					{
						if (CustomTabControl.<>o__58.<>p__9 == null)
						{
							CustomTabControl.<>o__58.<>p__9 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(CustomTabControl)));
						}
						base.SelectedIndex = CustomTabControl.<>o__58.<>p__9.Target(CustomTabControl.<>o__58.<>p__9, obj2);
					}
					else
					{
						if (CustomTabControl.<>o__58.<>p__11 == null)
						{
							CustomTabControl.<>o__58.<>p__11 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target4 = CustomTabControl.<>o__58.<>p__11.Target;
						CallSite <>p__4 = CustomTabControl.<>o__58.<>p__11;
						if (CustomTabControl.<>o__58.<>p__10 == null)
						{
							CustomTabControl.<>o__58.<>p__10 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(CustomTabControl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (target4(<>p__4, CustomTabControl.<>o__58.<>p__10.Target(CustomTabControl.<>o__58.<>p__10, base.SelectedIndex, obj2)))
						{
							if (CustomTabControl.<>o__58.<>p__12 == null)
							{
								CustomTabControl.<>o__58.<>p__12 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(CustomTabControl)));
							}
							base.SelectedIndex = CustomTabControl.<>o__58.<>p__12.Target(CustomTabControl.<>o__58.<>p__12, obj);
						}
					}
					this.Refresh();
				}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003B54 File Offset: 0x00001D54
		public void CloseTab(TabPage tab)
		{
			Scintilla scintilla = tab.Controls[0] as Scintilla;
			int num = base.TabPages.IndexOf(tab);
			if (num != 0 || base.TabCount > 2)
			{
				base.TabPages.RemoveAt(num);
				this.count--;
				return;
			}
			TabPage tabPage = base.TabPages[0];
			tab.Text = "Untitled.lua";
			scintilla.Text = "";
			scintilla.Refresh();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003BD0 File Offset: 0x00001DD0
		private void DragOverEnterHandler(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003BF4 File Offset: 0x00001DF4
		private void DragDropHandler(object sender, DragEventArgs e)
		{
			foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop, false))
			{
				this.AddEvent(Path.GetFileNameWithoutExtension(path), File.ReadAllText(path));
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003C3C File Offset: 0x00001E3C
		public Scintilla NewEditor(string script)
		{
			Scintilla scintilla = new Scintilla();
			scintilla.AllowDrop = true;
			scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
			scintilla.BackColor = Color.Black;
			scintilla.BorderStyle = BorderStyle.None;
			scintilla.Lexer = Lexer.Lua;
			scintilla.Name = "scintilla";
			scintilla.Dock = DockStyle.Fill;
			scintilla.ScrollWidth = 1;
			scintilla.TabIndex = 0;
			scintilla.Styles[32].Size = 15;
			scintilla.Styles[32].Size = 15;
			scintilla.Styles[32].Size = 15;
			scintilla.SetSelectionBackColor(true, Color.FromArgb(17, 177, 255));
			scintilla.SetSelectionForeColor(true, Color.Black);
			scintilla.Margins[1].Width = 0;
			scintilla.StyleResetDefault();
			scintilla.Styles[32].Font = "Consolas";
			scintilla.Styles[32].Size = 10;
			scintilla.Styles[32].BackColor = Color.FromArgb(40, 40, 40);
			scintilla.Styles[32].ForeColor = Color.White;
			scintilla.StyleClearAll();
			scintilla.Styles[11].ForeColor = Color.White;
			scintilla.Styles[1].ForeColor = Color.FromArgb(79, 81, 98);
			scintilla.Styles[2].ForeColor = Color.FromArgb(79, 81, 98);
			scintilla.Styles[3].ForeColor = Color.FromArgb(58, 64, 34);
			scintilla.Styles[4].ForeColor = Color.FromArgb(165, 112, 255);
			scintilla.Styles[6].ForeColor = Color.FromArgb(255, 192, 115);
			scintilla.Styles[7].ForeColor = Color.FromArgb(255, 192, 115);
			scintilla.Styles[8].ForeColor = Color.FromArgb(255, 192, 115);
			scintilla.Styles[9].ForeColor = Color.FromArgb(138, 175, 238);
			scintilla.Styles[10].ForeColor = Color.White;
			scintilla.Styles[5].ForeColor = Color.FromArgb(255, 60, 122);
			scintilla.Styles[13].ForeColor = Color.FromArgb(89, 255, 172);
			scintilla.Styles[13].Bold = true;
			scintilla.Styles[14].ForeColor = Color.FromArgb(89, 255, 172);
			scintilla.Styles[14].Bold = true;
			scintilla.Lexer = Lexer.Lua;
			scintilla.SetProperty("fold", "1");
			scintilla.SetProperty("fold.compact", "1");
			scintilla.Margins[0].Width = 15;
			scintilla.Margins[0].Type = MarginType.Number;
			scintilla.Margins[1].Type = MarginType.Symbol;
			scintilla.Margins[1].Mask = 4261412864U;
			scintilla.Margins[1].Sensitive = true;
			scintilla.Margins[1].Width = 8;
			for (int i = 25; i <= 31; i++)
			{
				scintilla.Markers[i].SetForeColor(Color.White);
				scintilla.Markers[i].SetBackColor(Color.White);
			}
			scintilla.Markers[30].Symbol = MarkerSymbol.BoxPlus;
			scintilla.Markers[31].Symbol = MarkerSymbol.BoxMinus;
			scintilla.Markers[25].Symbol = MarkerSymbol.BoxPlusConnected;
			scintilla.Markers[27].Symbol = MarkerSymbol.TCorner;
			scintilla.Markers[26].Symbol = MarkerSymbol.BoxMinusConnected;
			scintilla.Markers[29].Symbol = MarkerSymbol.VLine;
			scintilla.Markers[28].Symbol = MarkerSymbol.LCorner;
			scintilla.Styles[33].BackColor = Color.FromArgb(40, 40, 40);
			scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
			scintilla.SetFoldMarginColor(true, Color.FromArgb(40, 40, 40));
			scintilla.SetFoldMarginHighlightColor(true, Color.FromArgb(40, 40, 40));
			scintilla.SetKeywords(0, "and break do else elseif end false for function if in local nil not or repeat return then true until while continue");
			scintilla.SetKeywords(1, "warn CFrame CFrame.fromEulerAnglesXYZ Synapse Decompile Synapse Copy Synapse Write CFrame.Angles CFrame.fromAxisAngle CFrame.new gcinfo os os.difftime os.time tick UDim UDim.new Instance Instance.Lock Instance.Unlock Instance.new pairs NumberSequence NumberSequence.new assert tonumber getmetatable Color3 Color3.fromHSV Color3.toHSV Color3.fromRGB Color3.new load Stats _G UserSettings Ray Ray.new coroutine coroutine.resume coroutine.yield coroutine.status coroutine.wrap coroutine.create coroutine.running NumberRange NumberRange.new PhysicalProperties Physicalnew printidentity PluginManager loadstring NumberSequenceKeypoint NumberSequenceKeypoint.new Version Vector2 Vector2.new wait game. game.Players game.ReplicatedStorage Game delay spawn string string.sub string.upper string.len string.gfind string.rep string.find string.match string.char string.dump string.gmatch string.reverse string.byte string.format string.gsub string.lower CellId CellId.new Delay version stats typeof UDim2 UDim2.new table table.setn table.insert table.getn table.foreachi table.maxn table.foreach table.concat table.sort table.remove settings LoadLibrary require Vector3 Vector3.FromNormalId Vector3.FromAxis Vector3.new Vector3int16 Vector3int16.new setmetatable next ypcall ipairs Wait rawequal Region3int16 Region3int16.new collectgarbage game newproxy Spawn elapsedTime Region3 Region3.new time xpcall shared rawset tostring print Workspace Vector2int16 Vector2int16.new workspace unpack math math.log math.noise math.acos math.huge math.ldexp math.pi math.cos math.tanh math.pow math.deg math.tan math.cosh math.sinh math.random math.randomseed math.frexp math.ceil math.floor math.rad math.abs math.sqrt math.modf math.asin math.min math.max math.fmod math.log10 math.atan2 math.exp math.sin math.atan ColorSequenceKeypoint ColorSequenceKeypoint.new pcall getfenv ColorSequence ColorSequence.new type ElapsedTime select Faces Faces.new rawget debug debug.traceback debug.profileend debug.profilebegin Rect Rect.new BrickColor BrickColor.Blue BrickColor.White BrickColor.Yellow BrickColor.Red BrickColor.Gray BrickColor.palette BrickColor.New BrickColor.Black BrickColor.Green BrickColor.Random BrickColor.DarkGray BrickColor.random BrickColor.new setfenv dofile Axes Axes.new error loadfile ");
			scintilla.SetKeywords(2, "getrawmetatable loadstring getnamecallmethod setreadonly islclosure getgenv unlockModule lockModule mousemoverel debug.getupvalue debug.getupvalues debug.setupvalue debug.getmetatable debug.getregistry setclipboard setthreadcontext getthreadcontext checkcaller getgc debug.getconstant getrenv getreg ");
			scintilla.ScrollWidth = 1;
			scintilla.ScrollWidthTracking = true;
			scintilla.CaretForeColor = Color.White;
			scintilla.BackColor = Color.White;
			scintilla.BorderStyle = BorderStyle.None;
			scintilla.TextChanged += this.scintilla1_TextChanged;
			scintilla.WrapIndentMode = WrapIndentMode.Indent;
			scintilla.WrapVisualFlagLocation = WrapVisualFlagLocation.EndByText;
			scintilla.BorderStyle = BorderStyle.None;
			scintilla.Text = script;
			return scintilla;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004154 File Offset: 0x00002354
		private void scintilla1_TextChanged(object sender, EventArgs e)
		{
			Scintilla scintilla = (Scintilla)sender;
			int length = scintilla.Lines.Count.ToString().Length;
			scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', length + 1)) + 2;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000041A8 File Offset: 0x000023A8
		public void addnewtab()
		{
			int num = base.TabCount - 1;
			base.TabPages.Insert(num, string.Format("Script{0}.lua", base.TabCount));
			base.TabPages[num].Controls.Add(this.NewEditor(""));
			base.SelectedIndex = num;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004208 File Offset: 0x00002408
		public Scintilla GetWorkingTextEditor()
		{
			if (base.SelectedTab.Controls.Count == 0)
			{
				return null;
			}
			if (base.SelectedTab == null)
			{
				this.addnewtab();
				return base.SelectedTab.Controls[0] as Scintilla;
			}
			return base.SelectedTab.Controls[0] as Scintilla;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004264 File Offset: 0x00002464
		public void AddEvent(string name = "Script.lua", string content = "")
		{
			if (string.IsNullOrEmpty(this.GetWorkingTextEditor().Text) && !string.IsNullOrEmpty(content))
			{
				this.addnewtab();
				base.SelectedTab.Text = "Script " + this.count.ToString() + ".lua";
				base.SelectedTab.Controls[0].Text = content;
				base.SelectedTab.Controls[0].Refresh();
			}
			else
			{
				this.addnewtab();
				if (name.Contains("Script" + this.count.ToString() + ".lua"))
				{
					base.SelectedTab.Text = "Script " + this.count.ToString() + ".lua";
				}
			}
			this.count++;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004340 File Offset: 0x00002540
		public void TabChanging(object sender, TabControlCancelEventArgs e)
		{
			if (e.TabPageIndex == base.TabCount - 1)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000435C File Offset: 0x0000255C
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
					File.WriteAllText(saveFileDialog.FileName, text);
					result = new FileInfo(saveFileDialog.FileName).Name;
				}
				else
				{
					result = tab.Text;
				}
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000043DC File Offset: 0x000025DC
		public void RenameTab(string text)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000043E0 File Offset: 0x000025E0
		public bool OpenFileDialog(TabPage tab)
		{
			bool result;
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.GetWorkingTextEditor().Text = File.ReadAllText(openFileDialog.FileName);
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

		// Token: 0x04000018 RID: 24
		private readonly StringFormat CenterSringFormat = new StringFormat
		{
			Alignment = StringAlignment.Near,
			LineAlignment = StringAlignment.Center
		};

		// Token: 0x04000019 RID: 25
		private Color activeColor = Color.FromArgb(36, 36, 36);

		// Token: 0x0400001A RID: 26
		private Color backTabColor = Color.FromArgb(0, 0, 0);

		// Token: 0x0400001B RID: 27
		private Color borderColor = Color.FromArgb(30, 30, 30);

		// Token: 0x0400001C RID: 28
		private Color closingButtonColor = Color.WhiteSmoke;

		// Token: 0x0400001D RID: 29
		private string closingMessage;

		// Token: 0x0400001E RID: 30
		private Color headerColor = Color.FromArgb(45, 45, 48);

		// Token: 0x0400001F RID: 31
		private Color horizLineColor = Color.FromArgb(36, 36, 36);

		// Token: 0x04000020 RID: 32
		private TabPage predraggedTab;

		// Token: 0x04000021 RID: 33
		public TabPage contextTab;

		// Token: 0x04000022 RID: 34
		private Color textColor = Color.FromArgb(255, 255, 255);

		// Token: 0x04000023 RID: 35
		public Color selectedTextColor = Color.FromArgb(255, 255, 255);

		// Token: 0x04000024 RID: 36
		public static krnl Form1;

		// Token: 0x04000025 RID: 37
		private int count = 1;
	}
}

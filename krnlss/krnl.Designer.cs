namespace krnlss
{
	// Token: 0x02000011 RID: 17
	public partial class krnl : global::System.Windows.Forms.Form
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0000D3E7 File Offset: 0x0000B5E7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000D408 File Offset: 0x0000B608
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::krnlss.krnl));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.TabContextMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.clearToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openIntoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ScriptView = new global::System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.executeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loadIntoEditorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteFileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.changePathToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.reloadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bunifuFlatButton1 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton2 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton3 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton4 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton5 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton6 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.injectToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.killRobloxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gamesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.hotScriptsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openGuiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.remoteSpyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.unnamedESPToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cMDXToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.errorProvider1 = new global::System.Windows.Forms.ErrorProvider(this.components);
			this.customTabControl1 = new global::Controls.CustomTabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.TabContextMenu.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.errorProvider1).BeginInit();
			this.customTabControl1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(690, 33);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel3.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.panel3.Location = new global::System.Drawing.Point(-1, -1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(693, 3);
			this.panel3.TabIndex = 5;
			this.panel3.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.krnl_MouseMove);
			this.button2.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Corbel", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button2.Image");
			this.button2.Location = new global::System.Drawing.Point(620, 0);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(35, 33);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Corbel", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			this.button1.Location = new global::System.Drawing.Point(655, 0);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(35, 33);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.krnl_MouseMove);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(25, 25);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.label1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(328, 7);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(45, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "KRNL";
			this.label1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.TabContextMenu.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.TabContextMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.clearToolStripMenuItem,
				this.openIntoToolStripMenuItem,
				this.saveToolStripMenuItem,
				this.renameToolStripMenuItem
			});
			this.TabContextMenu.Name = "TabContextMenu";
			this.TabContextMenu.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.TabContextMenu.Size = new global::System.Drawing.Size(128, 92);
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new global::System.Drawing.Size(127, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new global::System.EventHandler(this.clearToolStripMenuItem_Click);
			this.openIntoToolStripMenuItem.Name = "openIntoToolStripMenuItem";
			this.openIntoToolStripMenuItem.Size = new global::System.Drawing.Size(127, 22);
			this.openIntoToolStripMenuItem.Text = "Open Into";
			this.openIntoToolStripMenuItem.Click += new global::System.EventHandler(this.openIntoToolStripMenuItem_Click);
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new global::System.Drawing.Size(127, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new global::System.EventHandler(this.saveToolStripMenuItem_Click);
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new global::System.Drawing.Size(127, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new global::System.EventHandler(this.renameToolStripMenuItem_Click_1);
			this.ScriptView.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.ScriptView.BackColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.ScriptView.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ScriptView.ContextMenuStrip = this.contextMenuStrip1;
			this.ScriptView.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ScriptView.ForeColor = global::System.Drawing.Color.White;
			this.ScriptView.HideSelection = false;
			this.ScriptView.LineColor = global::System.Drawing.Color.White;
			this.ScriptView.Location = new global::System.Drawing.Point(565, 59);
			this.ScriptView.Name = "ScriptView";
			this.ScriptView.Size = new global::System.Drawing.Size(121, 259);
			this.ScriptView.TabIndex = 4;
			this.ScriptView.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.ScriptView_AfterSelect);
			this.ScriptView.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.krnl_MouseMove);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.executeToolStripMenuItem,
				this.loadIntoEditorToolStripMenuItem,
				this.deleteFileToolStripMenuItem,
				this.changePathToolStripMenuItem,
				this.reloadToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(159, 114);
			this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
			this.executeToolStripMenuItem.Size = new global::System.Drawing.Size(158, 22);
			this.executeToolStripMenuItem.Text = "Execute";
			this.executeToolStripMenuItem.Click += new global::System.EventHandler(this.executeToolStripMenuItem_Click);
			this.loadIntoEditorToolStripMenuItem.Name = "loadIntoEditorToolStripMenuItem";
			this.loadIntoEditorToolStripMenuItem.Size = new global::System.Drawing.Size(158, 22);
			this.loadIntoEditorToolStripMenuItem.Text = "Load Into Editor";
			this.loadIntoEditorToolStripMenuItem.Click += new global::System.EventHandler(this.loadIntoEditorToolStripMenuItem_Click);
			this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
			this.deleteFileToolStripMenuItem.Size = new global::System.Drawing.Size(158, 22);
			this.deleteFileToolStripMenuItem.Text = "Delete File";
			this.deleteFileToolStripMenuItem.Click += new global::System.EventHandler(this.deleteFileToolStripMenuItem_Click);
			this.changePathToolStripMenuItem.Name = "changePathToolStripMenuItem";
			this.changePathToolStripMenuItem.Size = new global::System.Drawing.Size(158, 22);
			this.changePathToolStripMenuItem.Text = "Change Path";
			this.changePathToolStripMenuItem.Click += new global::System.EventHandler(this.changePathToolStripMenuItem_Click);
			this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
			this.reloadToolStripMenuItem.Size = new global::System.Drawing.Size(158, 22);
			this.reloadToolStripMenuItem.Text = "Reload";
			this.reloadToolStripMenuItem.Click += new global::System.EventHandler(this.reloadToolStripMenuItem_Click);
			this.bunifuFlatButton1.Activecolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.bunifuFlatButton1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "EXECUTE";
			this.bunifuFlatButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton1.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = null;
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0.0;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 20.0;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new global::System.Drawing.Point(4, 321);
			this.bunifuFlatButton1.Margin = new global::System.Windows.Forms.Padding(0, 3, 3, 3);
			this.bunifuFlatButton1.MinimumSize = new global::System.Drawing.Size(84, 25);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton1.OnHovercolor = global::System.Drawing.Color.FromArgb(39, 39, 39);
			this.bunifuFlatButton1.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton1.Padding = new global::System.Windows.Forms.Padding(0, 4, 0, 0);
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new global::System.Drawing.Size(100, 25);
			this.bunifuFlatButton1.TabIndex = 7;
			this.bunifuFlatButton1.Text = "EXECUTE";
			this.bunifuFlatButton1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton1.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton1.Click += new global::System.EventHandler(this.bunifuFlatButton1_Click);
			this.bunifuFlatButton2.Activecolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.bunifuFlatButton2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 0;
			this.bunifuFlatButton2.ButtonText = "CLEAR";
			this.bunifuFlatButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton2.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton2.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.Iconimage = null;
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 0;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = true;
			this.bunifuFlatButton2.IconRightZoom = 0.0;
			this.bunifuFlatButton2.IconVisible = true;
			this.bunifuFlatButton2.IconZoom = 20.0;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new global::System.Drawing.Point(107, 321);
			this.bunifuFlatButton2.Margin = new global::System.Windows.Forms.Padding(0, 3, 3, 3);
			this.bunifuFlatButton2.MinimumSize = new global::System.Drawing.Size(84, 25);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton2.OnHovercolor = global::System.Drawing.Color.FromArgb(39, 39, 39);
			this.bunifuFlatButton2.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton2.Padding = new global::System.Windows.Forms.Padding(0, 4, 0, 0);
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new global::System.Drawing.Size(100, 25);
			this.bunifuFlatButton2.TabIndex = 8;
			this.bunifuFlatButton2.Text = "CLEAR";
			this.bunifuFlatButton2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton2.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton2.Click += new global::System.EventHandler(this.bunifuFlatButton2_Click);
			this.bunifuFlatButton3.Activecolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.bunifuFlatButton3.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton3.BorderRadius = 0;
			this.bunifuFlatButton3.ButtonText = "OPEN FILE";
			this.bunifuFlatButton3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton3.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton3.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton3.Iconimage = null;
			this.bunifuFlatButton3.Iconimage_right = null;
			this.bunifuFlatButton3.Iconimage_right_Selected = null;
			this.bunifuFlatButton3.Iconimage_Selected = null;
			this.bunifuFlatButton3.IconMarginLeft = 0;
			this.bunifuFlatButton3.IconMarginRight = 0;
			this.bunifuFlatButton3.IconRightVisible = true;
			this.bunifuFlatButton3.IconRightZoom = 0.0;
			this.bunifuFlatButton3.IconVisible = true;
			this.bunifuFlatButton3.IconZoom = 20.0;
			this.bunifuFlatButton3.IsTab = false;
			this.bunifuFlatButton3.Location = new global::System.Drawing.Point(210, 321);
			this.bunifuFlatButton3.Margin = new global::System.Windows.Forms.Padding(0, 3, 3, 3);
			this.bunifuFlatButton3.MinimumSize = new global::System.Drawing.Size(84, 25);
			this.bunifuFlatButton3.Name = "bunifuFlatButton3";
			this.bunifuFlatButton3.Normalcolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton3.OnHovercolor = global::System.Drawing.Color.FromArgb(39, 39, 39);
			this.bunifuFlatButton3.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton3.Padding = new global::System.Windows.Forms.Padding(0, 4, 0, 0);
			this.bunifuFlatButton3.selected = false;
			this.bunifuFlatButton3.Size = new global::System.Drawing.Size(100, 25);
			this.bunifuFlatButton3.TabIndex = 9;
			this.bunifuFlatButton3.Text = "OPEN FILE";
			this.bunifuFlatButton3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton3.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton3.TextFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton3.Click += new global::System.EventHandler(this.bunifuFlatButton3_Click);
			this.bunifuFlatButton4.Activecolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.bunifuFlatButton4.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton4.BorderRadius = 0;
			this.bunifuFlatButton4.ButtonText = "SAVE FILE";
			this.bunifuFlatButton4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton4.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton4.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton4.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton4.Iconimage = null;
			this.bunifuFlatButton4.Iconimage_right = null;
			this.bunifuFlatButton4.Iconimage_right_Selected = null;
			this.bunifuFlatButton4.Iconimage_Selected = null;
			this.bunifuFlatButton4.IconMarginLeft = 0;
			this.bunifuFlatButton4.IconMarginRight = 0;
			this.bunifuFlatButton4.IconRightVisible = true;
			this.bunifuFlatButton4.IconRightZoom = 0.0;
			this.bunifuFlatButton4.IconVisible = true;
			this.bunifuFlatButton4.IconZoom = 20.0;
			this.bunifuFlatButton4.IsTab = false;
			this.bunifuFlatButton4.Location = new global::System.Drawing.Point(313, 321);
			this.bunifuFlatButton4.Margin = new global::System.Windows.Forms.Padding(0, 3, 3, 3);
			this.bunifuFlatButton4.MinimumSize = new global::System.Drawing.Size(84, 25);
			this.bunifuFlatButton4.Name = "bunifuFlatButton4";
			this.bunifuFlatButton4.Normalcolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton4.OnHovercolor = global::System.Drawing.Color.FromArgb(39, 39, 39);
			this.bunifuFlatButton4.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton4.Padding = new global::System.Windows.Forms.Padding(0, 4, 0, 0);
			this.bunifuFlatButton4.selected = false;
			this.bunifuFlatButton4.Size = new global::System.Drawing.Size(100, 25);
			this.bunifuFlatButton4.TabIndex = 10;
			this.bunifuFlatButton4.Text = "SAVE FILE";
			this.bunifuFlatButton4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton4.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton4.TextFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton4.Click += new global::System.EventHandler(this.bunifuFlatButton4_Click);
			this.bunifuFlatButton5.Activecolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton5.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.bunifuFlatButton5.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton5.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton5.BorderRadius = 0;
			this.bunifuFlatButton5.ButtonText = "INJECT";
			this.bunifuFlatButton5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton5.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton5.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton5.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton5.Iconimage = null;
			this.bunifuFlatButton5.Iconimage_right = null;
			this.bunifuFlatButton5.Iconimage_right_Selected = null;
			this.bunifuFlatButton5.Iconimage_Selected = null;
			this.bunifuFlatButton5.IconMarginLeft = 0;
			this.bunifuFlatButton5.IconMarginRight = 0;
			this.bunifuFlatButton5.IconRightVisible = true;
			this.bunifuFlatButton5.IconRightZoom = 0.0;
			this.bunifuFlatButton5.IconVisible = true;
			this.bunifuFlatButton5.IconZoom = 20.0;
			this.bunifuFlatButton5.IsTab = false;
			this.bunifuFlatButton5.Location = new global::System.Drawing.Point(416, 321);
			this.bunifuFlatButton5.Margin = new global::System.Windows.Forms.Padding(0, 3, 3, 3);
			this.bunifuFlatButton5.MinimumSize = new global::System.Drawing.Size(84, 25);
			this.bunifuFlatButton5.Name = "bunifuFlatButton5";
			this.bunifuFlatButton5.Normalcolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton5.OnHovercolor = global::System.Drawing.Color.FromArgb(39, 39, 39);
			this.bunifuFlatButton5.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton5.Padding = new global::System.Windows.Forms.Padding(0, 4, 0, 0);
			this.bunifuFlatButton5.selected = false;
			this.bunifuFlatButton5.Size = new global::System.Drawing.Size(100, 25);
			this.bunifuFlatButton5.TabIndex = 11;
			this.bunifuFlatButton5.Text = "INJECT";
			this.bunifuFlatButton5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton5.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton5.TextFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton5.Click += new global::System.EventHandler(this.bunifuFlatButton5_Click);
			this.bunifuFlatButton6.Activecolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton6.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuFlatButton6.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton6.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton6.BorderRadius = 0;
			this.bunifuFlatButton6.ButtonText = "OPTIONS";
			this.bunifuFlatButton6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton6.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton6.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton6.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton6.Iconimage = null;
			this.bunifuFlatButton6.Iconimage_right = null;
			this.bunifuFlatButton6.Iconimage_right_Selected = null;
			this.bunifuFlatButton6.Iconimage_Selected = null;
			this.bunifuFlatButton6.IconMarginLeft = 0;
			this.bunifuFlatButton6.IconMarginRight = 0;
			this.bunifuFlatButton6.IconRightVisible = true;
			this.bunifuFlatButton6.IconRightZoom = 0.0;
			this.bunifuFlatButton6.IconVisible = true;
			this.bunifuFlatButton6.IconZoom = 20.0;
			this.bunifuFlatButton6.IsTab = false;
			this.bunifuFlatButton6.Location = new global::System.Drawing.Point(586, 321);
			this.bunifuFlatButton6.Margin = new global::System.Windows.Forms.Padding(0, 3, 3, 3);
			this.bunifuFlatButton6.MinimumSize = new global::System.Drawing.Size(84, 25);
			this.bunifuFlatButton6.Name = "bunifuFlatButton6";
			this.bunifuFlatButton6.Normalcolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton6.OnHovercolor = global::System.Drawing.Color.FromArgb(39, 39, 39);
			this.bunifuFlatButton6.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton6.Padding = new global::System.Windows.Forms.Padding(0, 4, 0, 0);
			this.bunifuFlatButton6.selected = false;
			this.bunifuFlatButton6.Size = new global::System.Drawing.Size(100, 25);
			this.bunifuFlatButton6.TabIndex = 12;
			this.bunifuFlatButton6.Text = "OPTIONS";
			this.bunifuFlatButton6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton6.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton6.TextFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton6.Click += new global::System.EventHandler(this.bunifuFlatButton6_Click);
			this.menuStrip1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.menuStrip1.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.menuStrip1.Dock = global::System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem,
				this.aboutToolStripMenuItem,
				this.gamesToolStripMenuItem,
				this.hotScriptsToolStripMenuItem,
				this.toolStripMenuItem5
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 33);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(289, 24);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.injectToolStripMenuItem,
				this.killRobloxToolStripMenuItem
			});
			this.fileToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.fileToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			this.injectToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.injectToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.injectToolStripMenuItem.Name = "injectToolStripMenuItem";
			this.injectToolStripMenuItem.Size = new global::System.Drawing.Size(130, 22);
			this.injectToolStripMenuItem.Text = "Inject";
			this.injectToolStripMenuItem.Click += new global::System.EventHandler(this.injectToolStripMenuItem_Click_1);
			this.killRobloxToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.killRobloxToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.killRobloxToolStripMenuItem.Name = "killRobloxToolStripMenuItem";
			this.killRobloxToolStripMenuItem.Size = new global::System.Drawing.Size(130, 22);
			this.killRobloxToolStripMenuItem.Text = "Kill Roblox";
			this.killRobloxToolStripMenuItem.Click += new global::System.EventHandler(this.killRobloxToolStripMenuItem_Click);
			this.aboutToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.aboutToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new global::System.Drawing.Size(56, 20);
			this.aboutToolStripMenuItem.Text = "Credits";
			this.aboutToolStripMenuItem.Click += new global::System.EventHandler(this.aboutToolStripMenuItem_Click_1);
			this.gamesToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.gamesToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
			this.gamesToolStripMenuItem.Size = new global::System.Drawing.Size(55, 20);
			this.gamesToolStripMenuItem.Text = "Games";
			this.gamesToolStripMenuItem.Click += new global::System.EventHandler(this.gamesToolStripMenuItem_Click_1);
			this.hotScriptsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem2,
				this.openGuiToolStripMenuItem,
				this.toolStripMenuItem4,
				this.toolStripMenuItem1,
				this.remoteSpyToolStripMenuItem,
				this.toolStripMenuItem3,
				this.unnamedESPToolStripMenuItem,
				this.toolStripMenuItem8,
				this.cMDXToolStripMenuItem
			});
			this.hotScriptsToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.hotScriptsToolStripMenuItem.Name = "hotScriptsToolStripMenuItem";
			this.hotScriptsToolStripMenuItem.Size = new global::System.Drawing.Size(79, 20);
			this.hotScriptsToolStripMenuItem.Text = "Hot-Scripts";
			this.toolStripMenuItem2.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.toolStripMenuItem2.ForeColor = global::System.Drawing.Color.White;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new global::System.Drawing.Size(148, 22);
			this.toolStripMenuItem2.Text = "DarkDex";
			this.toolStripMenuItem2.Click += new global::System.EventHandler(this.toolStripMenuItem2_Click);
			this.openGuiToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.openGuiToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.openGuiToolStripMenuItem.Name = "openGuiToolStripMenuItem";
			this.openGuiToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.openGuiToolStripMenuItem.Text = "OpenGui";
			this.openGuiToolStripMenuItem.Click += new global::System.EventHandler(this.openGuiToolStripMenuItem_Click_1);
			this.toolStripMenuItem4.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.toolStripMenuItem4.ForeColor = global::System.Drawing.Color.White;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new global::System.Drawing.Size(148, 22);
			this.toolStripMenuItem4.Text = "Owl Hub";
			this.toolStripMenuItem4.Click += new global::System.EventHandler(this.toolStripMenuItem4_Click);
			this.toolStripMenuItem1.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.toolStripMenuItem1.ForeColor = global::System.Drawing.Color.White;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(148, 22);
			this.toolStripMenuItem1.Text = "Galaxy Hub";
			this.toolStripMenuItem1.Click += new global::System.EventHandler(this.toolStripMenuItem1_Click_2);
			this.remoteSpyToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.remoteSpyToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.remoteSpyToolStripMenuItem.Name = "remoteSpyToolStripMenuItem";
			this.remoteSpyToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.remoteSpyToolStripMenuItem.Text = "Remote Spy";
			this.remoteSpyToolStripMenuItem.Click += new global::System.EventHandler(this.remoteSpyToolStripMenuItem_Click);
			this.toolStripMenuItem3.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.toolStripMenuItem3.ForeColor = global::System.Drawing.Color.White;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new global::System.Drawing.Size(148, 22);
			this.toolStripMenuItem3.Text = "Game Sense";
			this.toolStripMenuItem3.Click += new global::System.EventHandler(this.gameSenseToolStripMenuItem_Click);
			this.unnamedESPToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.unnamedESPToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.unnamedESPToolStripMenuItem.Name = "unnamedESPToolStripMenuItem";
			this.unnamedESPToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.unnamedESPToolStripMenuItem.Text = "Unnamed ESP";
			this.unnamedESPToolStripMenuItem.Click += new global::System.EventHandler(this.unnamedESPToolStripMenuItem_Click);
			this.toolStripMenuItem8.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.toolStripMenuItem8.ForeColor = global::System.Drawing.Color.White;
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new global::System.Drawing.Size(148, 22);
			this.toolStripMenuItem8.Text = "Infinite Yield";
			this.toolStripMenuItem8.Click += new global::System.EventHandler(this.toolStripMenuItem8_Click);
			this.cMDXToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.cMDXToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.cMDXToolStripMenuItem.Name = "cMDXToolStripMenuItem";
			this.cMDXToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.cMDXToolStripMenuItem.Text = "CMD-X";
			this.cMDXToolStripMenuItem.Click += new global::System.EventHandler(this.cMDXToolStripMenuItem_Click);
			this.toolStripMenuItem5.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem6,
				this.toolStripMenuItem7
			});
			this.toolStripMenuItem5.ForeColor = global::System.Drawing.Color.White;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new global::System.Drawing.Size(54, 20);
			this.toolStripMenuItem5.Text = "Others";
			this.toolStripMenuItem6.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.toolStripMenuItem6.ForeColor = global::System.Drawing.Color.White;
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new global::System.Drawing.Size(173, 22);
			this.toolStripMenuItem6.Text = "Get Key";
			this.toolStripMenuItem6.Click += new global::System.EventHandler(this.bunifuFlatButton8_Click);
			this.toolStripMenuItem7.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.toolStripMenuItem7.ForeColor = global::System.Drawing.Color.White;
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new global::System.Drawing.Size(173, 22);
			this.toolStripMenuItem7.Text = "Join Discord Server";
			this.toolStripMenuItem7.Click += new global::System.EventHandler(this.toolStripMenuItem7_Click);
			this.timer1.Interval = 300;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.panel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.panel2.Location = new global::System.Drawing.Point(288, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(402, 25);
			this.panel2.TabIndex = 0;
			this.panel2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.krnl_MouseMove);
			this.errorProvider1.ContainerControl = this;
			this.customTabControl1.ActiveColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.customTabControl1.AllowDrop = true;
			this.customTabControl1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.customTabControl1.BackTabColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.customTabControl1.BorderColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.customTabControl1.ClosingButtonColor = global::System.Drawing.Color.WhiteSmoke;
			this.customTabControl1.ClosingMessage = null;
			this.customTabControl1.Controls.Add(this.tabPage1);
			this.customTabControl1.HeaderColor = global::System.Drawing.Color.FromArgb(45, 45, 48);
			this.customTabControl1.HorizontalLineColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.customTabControl1.ItemSize = new global::System.Drawing.Size(240, 16);
			this.customTabControl1.Location = new global::System.Drawing.Point(4, 59);
			this.customTabControl1.Name = "customTabControl1";
			this.customTabControl1.SelectedIndex = 0;
			this.customTabControl1.SelectedTextColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.customTabControl1.ShowClosingButton = false;
			this.customTabControl1.ShowClosingMessage = false;
			this.customTabControl1.Size = new global::System.Drawing.Size(556, 259);
			this.customTabControl1.TabIndex = 3;
			this.customTabControl1.TextColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.customTabControl1.SelectedIndexChanged += new global::System.EventHandler(this.customTabControl1_SelectedIndexChanged);
			this.tabPage1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 20);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new global::System.Drawing.Size(548, 235);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Click += new global::System.EventHandler(this.tabPage1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			base.ClientSize = new global::System.Drawing.Size(690, 350);
			base.Controls.Add(this.menuStrip1);
			base.Controls.Add(this.ScriptView);
			base.Controls.Add(this.customTabControl1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.bunifuFlatButton5);
			base.Controls.Add(this.bunifuFlatButton4);
			base.Controls.Add(this.bunifuFlatButton3);
			base.Controls.Add(this.bunifuFlatButton2);
			base.Controls.Add(this.bunifuFlatButton1);
			base.Controls.Add(this.bunifuFlatButton6);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "krnl";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "krnl";
			base.TopMost = true;
			base.Activated += new global::System.EventHandler(this.krnl_Activated);
			base.Deactivate += new global::System.EventHandler(this.krnl_Deactivate);
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.krnl_FormClosing);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.krnl_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.krnl_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.krnl_MouseUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.TabContextMenu.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.errorProvider1).EndInit();
			this.customTabControl1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000A1 RID: 161
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A2 RID: 162
		public global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.ToolStripMenuItem openIntoToolStripMenuItem;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

		// Token: 0x040000A8 RID: 168
		public global::System.Windows.Forms.ContextMenuStrip TabContextMenu;

		// Token: 0x040000A9 RID: 169
		public global::Controls.CustomTabControl customTabControl1;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.TreeView ScriptView;

		// Token: 0x040000AC RID: 172
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;

		// Token: 0x040000AD RID: 173
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;

		// Token: 0x040000AE RID: 174
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;

		// Token: 0x040000AF RID: 175
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;

		// Token: 0x040000B0 RID: 176
		public global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.ToolStripMenuItem loadIntoEditorToolStripMenuItem;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.ToolStripMenuItem changePathToolStripMenuItem;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;

		// Token: 0x040000B7 RID: 183
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.ToolStripMenuItem injectToolStripMenuItem;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.ToolStripMenuItem hotScriptsToolStripMenuItem;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.ToolStripMenuItem openGuiToolStripMenuItem;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.ToolStripMenuItem killRobloxToolStripMenuItem;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.ToolStripMenuItem remoteSpyToolStripMenuItem;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.ErrorProvider errorProvider1;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.ToolStripMenuItem unnamedESPToolStripMenuItem;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.ToolStripMenuItem cMDXToolStripMenuItem;
	}
}

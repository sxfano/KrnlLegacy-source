using System;
using System.Windows.Forms;

namespace SirhurtUI.Controls
{
	// Token: 0x02000009 RID: 9
	public class TabPanelControl : UserControl
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public TabPanelControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002AC2 File Offset: 0x00000CC2
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.Name = "TabPanelControl";
			base.Load += this.TabPanelControl_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002AEE File Offset: 0x00000CEE
		private void TabPanelControl_Load(object sender, EventArgs e)
		{
		}
	}
}

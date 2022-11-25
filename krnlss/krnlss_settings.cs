using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000006 RID: 6
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class krnlss_settings
{
	// Token: 0x06000034 RID: 52 RVA: 0x0000250D File Offset: 0x0000070D
	internal krnlss_settings()
	{
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000035 RID: 53 RVA: 0x00002515 File Offset: 0x00000715
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (krnlss_settings.resourceMan == null)
			{
				krnlss_settings.resourceMan = new ResourceManager("krnlss.settings", typeof(krnlss_settings).Assembly);
			}
			return krnlss_settings.resourceMan;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000036 RID: 54 RVA: 0x00002541 File Offset: 0x00000741
	// (set) Token: 0x06000037 RID: 55 RVA: 0x00002548 File Offset: 0x00000748
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return krnlss_settings.resourceCulture;
		}
		set
		{
			krnlss_settings.resourceCulture = value;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000038 RID: 56 RVA: 0x00002550 File Offset: 0x00000750
	internal static Bitmap pictureBox1_Image
	{
		get
		{
			return (Bitmap)krnlss_settings.ResourceManager.GetObject("pictureBox1.Image", krnlss_settings.resourceCulture);
		}
	}

	// Token: 0x04000009 RID: 9
	private static ResourceManager resourceMan;

	// Token: 0x0400000A RID: 10
	private static CultureInfo resourceCulture;
}

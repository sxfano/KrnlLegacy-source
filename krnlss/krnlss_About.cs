using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000002 RID: 2
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class krnlss_About
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	internal krnlss_About()
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (krnlss_About.resourceMan == null)
			{
				krnlss_About.resourceMan = new ResourceManager("krnlss.About", typeof(krnlss_About).Assembly);
			}
			return krnlss_About.resourceMan;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002084 File Offset: 0x00000284
	// (set) Token: 0x06000004 RID: 4 RVA: 0x0000208B File Offset: 0x0000028B
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return krnlss_About.resourceCulture;
		}
		set
		{
			krnlss_About.resourceCulture = value;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000005 RID: 5 RVA: 0x00002093 File Offset: 0x00000293
	internal static Bitmap button1_Image
	{
		get
		{
			return (Bitmap)krnlss_About.ResourceManager.GetObject("button1.Image", krnlss_About.resourceCulture);
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000006 RID: 6 RVA: 0x000020AE File Offset: 0x000002AE
	internal static Bitmap pictureBox1_Image
	{
		get
		{
			return (Bitmap)krnlss_About.ResourceManager.GetObject("pictureBox1.Image", krnlss_About.resourceCulture);
		}
	}

	// Token: 0x04000001 RID: 1
	private static ResourceManager resourceMan;

	// Token: 0x04000002 RID: 2
	private static CultureInfo resourceCulture;
}

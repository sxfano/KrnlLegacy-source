using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class krnlss_krnl
{
	// Token: 0x06000026 RID: 38 RVA: 0x000023E5 File Offset: 0x000005E5
	internal krnlss_krnl()
	{
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000027 RID: 39 RVA: 0x000023ED File Offset: 0x000005ED
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (krnlss_krnl.resourceMan == null)
			{
				krnlss_krnl.resourceMan = new ResourceManager("krnlss.krnl", typeof(krnlss_krnl).Assembly);
			}
			return krnlss_krnl.resourceMan;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000028 RID: 40 RVA: 0x00002419 File Offset: 0x00000619
	// (set) Token: 0x06000029 RID: 41 RVA: 0x00002420 File Offset: 0x00000620
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return krnlss_krnl.resourceCulture;
		}
		set
		{
			krnlss_krnl.resourceCulture = value;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600002A RID: 42 RVA: 0x00002428 File Offset: 0x00000628
	internal static Bitmap button1_Image
	{
		get
		{
			return (Bitmap)krnlss_krnl.ResourceManager.GetObject("button1.Image", krnlss_krnl.resourceCulture);
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600002B RID: 43 RVA: 0x00002443 File Offset: 0x00000643
	internal static Bitmap button2_Image
	{
		get
		{
			return (Bitmap)krnlss_krnl.ResourceManager.GetObject("button2.Image", krnlss_krnl.resourceCulture);
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600002C RID: 44 RVA: 0x0000245E File Offset: 0x0000065E
	internal static Bitmap pictureBox1_Image
	{
		get
		{
			return (Bitmap)krnlss_krnl.ResourceManager.GetObject("pictureBox1.Image", krnlss_krnl.resourceCulture);
		}
	}

	// Token: 0x04000005 RID: 5
	private static ResourceManager resourceMan;

	// Token: 0x04000006 RID: 6
	private static CultureInfo resourceCulture;
}

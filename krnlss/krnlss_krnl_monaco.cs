using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000005 RID: 5
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class krnlss_krnl_monaco
{
	// Token: 0x0600002D RID: 45 RVA: 0x00002479 File Offset: 0x00000679
	internal krnlss_krnl_monaco()
	{
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600002E RID: 46 RVA: 0x00002481 File Offset: 0x00000681
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (krnlss_krnl_monaco.resourceMan == null)
			{
				krnlss_krnl_monaco.resourceMan = new ResourceManager("krnlss.krnl_monaco", typeof(krnlss_krnl_monaco).Assembly);
			}
			return krnlss_krnl_monaco.resourceMan;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600002F RID: 47 RVA: 0x000024AD File Offset: 0x000006AD
	// (set) Token: 0x06000030 RID: 48 RVA: 0x000024B4 File Offset: 0x000006B4
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return krnlss_krnl_monaco.resourceCulture;
		}
		set
		{
			krnlss_krnl_monaco.resourceCulture = value;
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000031 RID: 49 RVA: 0x000024BC File Offset: 0x000006BC
	internal static Bitmap button1_Image
	{
		get
		{
			return (Bitmap)krnlss_krnl_monaco.ResourceManager.GetObject("button1.Image", krnlss_krnl_monaco.resourceCulture);
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000032 RID: 50 RVA: 0x000024D7 File Offset: 0x000006D7
	internal static Bitmap button2_Image
	{
		get
		{
			return (Bitmap)krnlss_krnl_monaco.ResourceManager.GetObject("button2.Image", krnlss_krnl_monaco.resourceCulture);
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000033 RID: 51 RVA: 0x000024F2 File Offset: 0x000006F2
	internal static Bitmap pictureBox2_Image
	{
		get
		{
			return (Bitmap)krnlss_krnl_monaco.ResourceManager.GetObject("pictureBox2.Image", krnlss_krnl_monaco.resourceCulture);
		}
	}

	// Token: 0x04000007 RID: 7
	private static ResourceManager resourceMan;

	// Token: 0x04000008 RID: 8
	private static CultureInfo resourceCulture;
}

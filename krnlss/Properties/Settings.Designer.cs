using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace krnlss.Properties
{
	// Token: 0x02000015 RID: 21
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00016BB5 File Offset: 0x00014DB5
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00016BBC File Offset: 0x00014DBC
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00016BCE File Offset: 0x00014DCE
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Environment.CurrentDirectory + \"\\\\scripts\"")]
		public string ScriptPath
		{
			get
			{
				return (string)this["ScriptPath"];
			}
			set
			{
				this["ScriptPath"] = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00016BDC File Offset: 0x00014DDC
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00016BEE File Offset: 0x00014DEE
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("false")]
		public bool autoinject
		{
			get
			{
				return (bool)this["autoinject"];
			}
			set
			{
				this["autoinject"] = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00016C01 File Offset: 0x00014E01
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00016C13 File Offset: 0x00014E13
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("false")]
		public bool topmostchecked
		{
			get
			{
				return (bool)this["topmostchecked"];
			}
			set
			{
				this["topmostchecked"] = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00016C26 File Offset: 0x00014E26
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00016C38 File Offset: 0x00014E38
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("true")]
		public bool fadein_out_opacity
		{
			get
			{
				return (bool)this["fadein_out_opacity"];
			}
			set
			{
				this["fadein_out_opacity"] = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00016C4B File Offset: 0x00014E4B
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00016C5D File Offset: 0x00014E5D
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("false")]
		public bool remove_crash_logs
		{
			get
			{
				return (bool)this["remove_crash_logs"];
			}
			set
			{
				this["remove_crash_logs"] = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00016C70 File Offset: 0x00014E70
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00016C82 File Offset: 0x00014E82
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string cachedkey
		{
			get
			{
				return (string)this["cachedkey"];
			}
			set
			{
				this["cachedkey"] = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00016C90 File Offset: 0x00014E90
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00016CA2 File Offset: 0x00014EA2
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("false")]
		public bool monaco
		{
			get
			{
				return (bool)this["monaco"];
			}
			set
			{
				this["monaco"] = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00016CB5 File Offset: 0x00014EB5
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00016CDF File Offset: 0x00014EDF
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public DateTime timer
		{
			get
			{
				if (this["timer"] != null)
				{
					return Convert.ToDateTime(this["timer"]);
				}
				return Convert.ToDateTime(DateTime.Now);
			}
			set
			{
				this["timer"] = value;
			}
		}

		// Token: 0x0400014A RID: 330
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}

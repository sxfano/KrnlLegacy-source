using System;
using System.Runtime.InteropServices;

namespace injection
{
	// Token: 0x0200000A RID: 10
	public class Injector
	{
		// Token: 0x06000050 RID: 80
		[DllImport("injector.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern Injector.inject_status inject(string dll_path);

		// Token: 0x02000016 RID: 22
		public enum inject_status
		{
			// Token: 0x0400014C RID: 332
			failure = -1,
			// Token: 0x0400014D RID: 333
			success,
			// Token: 0x0400014E RID: 334
			loadimage_fail,
			// Token: 0x0400014F RID: 335
			no_rbx_proc
		}
	}
}

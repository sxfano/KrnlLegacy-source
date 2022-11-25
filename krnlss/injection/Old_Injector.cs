using System;
using System.Runtime.InteropServices;
using System.Text;
using krnlss;

namespace injection
{
	// Token: 0x0200000B RID: 11
	public class Old_Injector
	{
		// Token: 0x06000052 RID: 82
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x06000053 RID: 83
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int CloseHandle(IntPtr hObject);

		// Token: 0x06000054 RID: 84
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x06000055 RID: 85
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x06000056 RID: 86
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x06000057 RID: 87
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x06000058 RID: 88
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		// Token: 0x06000059 RID: 89
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x0600005A RID: 90
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

		// Token: 0x0600005B RID: 91 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public static bool inject_dll(uint pid)
		{
			IntPtr intPtr = Old_Injector.OpenProcess(1082U, 1, pid);
			if (intPtr == Old_Injector.zero)
			{
				return false;
			}
			IntPtr procAddress = Old_Injector.GetProcAddress(Old_Injector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			if (procAddress == Old_Injector.zero)
			{
				return false;
			}
			IntPtr intPtr2 = Old_Injector.VirtualAllocEx(intPtr, Old_Injector.zero, (IntPtr)Program.dll_path.Length, 12288U, 64U);
			IntPtr value = Old_Injector.CreateRemoteThread(intPtr, Old_Injector.zero, Old_Injector.zero, procAddress, intPtr2, 0U, Old_Injector.zero);
			if (intPtr2 == Old_Injector.zero)
			{
				return false;
			}
			if (Old_Injector.WriteProcessMemory(intPtr, intPtr2, Encoding.ASCII.GetBytes(Program.dll_path), (uint)Encoding.ASCII.GetBytes(Program.dll_path).Length, 0) == 0)
			{
				return false;
			}
			if (value != Old_Injector.zero)
			{
				Old_Injector.CloseHandle(intPtr);
				return true;
			}
			return false;
		}

		// Token: 0x04000017 RID: 23
		public static IntPtr zero = IntPtr.Zero;

		// Token: 0x02000017 RID: 23
		public enum inject_status
		{
			// Token: 0x04000151 RID: 337
			DllNotFound,
			// Token: 0x04000152 RID: 338
			ProcessNotFound,
			// Token: 0x04000153 RID: 339
			Failed,
			// Token: 0x04000154 RID: 340
			Success,
			// Token: 0x04000155 RID: 341
			threaderr
		}
	}
}

using System;
using System.Runtime.InteropServices;

namespace Rose.Protections
{
	// Token: 0x02000015 RID: 21
	internal class HeaderErase
	{
		// Token: 0x06000035 RID: 53
		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		// Token: 0x06000036 RID: 54
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		// Token: 0x06000037 RID: 55
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x06000038 RID: 56 RVA: 0x00007E1C File Offset: 0x0000601C
		public static void OIURC()
		{
			short num = 0;
			do
			{
				IntPtr moduleHandle;
				if (num == 2)
				{
					moduleHandle = HeaderErase.GetModuleHandle(null);
					num = 3;
				}
				if (num == 3)
				{
					IntPtr intPtr;
					HeaderErase.VirtualProtect(moduleHandle, (IntPtr)4096, (IntPtr)4, ref intPtr);
					num = 4;
				}
				if (num == 4)
				{
					HeaderErase.ZeroMemory(moduleHandle, (IntPtr)4096);
					num = 5;
				}
				if (num == 1)
				{
					IntPtr intPtr = (IntPtr)0;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}
	}
}

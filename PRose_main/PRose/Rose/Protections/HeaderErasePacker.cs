using System;
using System.Runtime.InteropServices;

namespace Rose.Protections
{
	// Token: 0x0200004E RID: 78
	internal class HeaderErasePacker
	{
		// Token: 0x060000F9 RID: 249
		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		// Token: 0x060000FA RID: 250
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		// Token: 0x060000FB RID: 251
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x060000FC RID: 252 RVA: 0x00011B44 File Offset: 0x0000FD44
		public static void KOISZ()
		{
			short num = 0;
			do
			{
				IntPtr moduleHandle;
				if (num == 4)
				{
					HeaderErasePacker.ZeroMemory(moduleHandle, (IntPtr)4096);
					num = 5;
				}
				if (num == 3)
				{
					IntPtr intPtr;
					HeaderErasePacker.VirtualProtect(moduleHandle, (IntPtr)4096, (IntPtr)4, ref intPtr);
					num = 4;
				}
				if (num == 1)
				{
					IntPtr intPtr = (IntPtr)0;
					num = 2;
				}
				if (num == 2)
				{
					moduleHandle = HeaderErasePacker.GetModuleHandle(null);
					num = 3;
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

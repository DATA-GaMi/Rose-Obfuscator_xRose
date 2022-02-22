using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rose.Protections
{
	// Token: 0x0200000E RID: 14
	internal static class AntiDump2
	{
		// Token: 0x06000025 RID: 37
		[DllImport("kernel32.dll")]
		public static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		// Token: 0x06000026 RID: 38
		[DllImport("kernel32.dll")]
		public static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		// Token: 0x06000027 RID: 39 RVA: 0x00007030 File Offset: 0x00005230
		public static void EraseSection(IntPtr address, int size)
		{
			short num = 0;
			do
			{
				IntPtr intPtr;
				IntPtr zero;
				if (num == 6)
				{
					IntPtr zero2;
					AntiDump2.VirtualProtect(address, intPtr, zero, ref zero2);
					num = 7;
				}
				if (num == 4)
				{
					AntiDump2.ZeroMemory(address, intPtr);
					num = 5;
				}
				if (num == 1)
				{
					intPtr = (IntPtr)size;
					num = 2;
				}
				if (num == 3)
				{
					AntiDump2.VirtualProtect(address, intPtr, (IntPtr)64, ref zero);
					num = 4;
				}
				if (num == 5)
				{
					IntPtr zero2 = IntPtr.Zero;
					num = 6;
				}
				if (num == 2)
				{
					zero = IntPtr.Zero;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000717C File Offset: 0x0000537C
		public static void WUIOL()
		{
			short num = 0;
			for (;;)
			{
				int num2;
				if (num == 11)
				{
					num2++;
					num = 12;
				}
				if (num == 9)
				{
					goto IL_2F1;
				}
				int num3;
				if (num == 18)
				{
					num3 = 0;
					num = 19;
				}
				IntPtr baseAddress;
				if (num == 5)
				{
					Process currentProcess;
					baseAddress = currentProcess.MainModule.BaseAddress;
					num = 6;
				}
				List<int> list;
				if (num == 3)
				{
					list = new List<int>
					{
						4,
						22,
						24,
						64,
						66,
						68,
						70,
						72,
						74,
						76,
						92,
						94
					};
					num = 4;
				}
				if (num == 15)
				{
					goto IL_15C;
				}
				goto IL_190;
				IL_513:
				int num4;
				if (num == 6)
				{
					num4 = Marshal.ReadInt32((IntPtr)(baseAddress.ToInt32() + 60));
					num = 7;
				}
				int num5;
				if (num == 16)
				{
					num5++;
					num = 17;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 28)
				{
					break;
				}
				continue;
				IL_4A2:
				int num6;
				if (num == 24)
				{
					List<int> list2;
					if (num6 != list2.Count)
					{
						goto IL_2A7;
					}
					num = 25;
				}
				if (num == 10)
				{
					goto IL_4DF;
				}
				goto IL_513;
				IL_3DE:
				if (num == 25)
				{
					num3++;
					num = 26;
				}
				if (num == 1)
				{
					List<int> list2 = new List<int>
					{
						8,
						12,
						16,
						20,
						24,
						28,
						36
					};
					num = 2;
				}
				if (num == 17)
				{
					goto IL_487;
				}
				goto IL_4A2;
				IL_30C:
				if (num == 22)
				{
					AntiDump2.EraseSection((IntPtr)(baseAddress.ToInt32() + num4 + 250 + 40 * num3 + 32), 2);
					num = 23;
				}
				if (num == 19)
				{
					num6 = 0;
					num = 20;
				}
				List<int> list3;
				if (num == 2)
				{
					list3 = new List<int>
					{
						26,
						27
					};
					num = 3;
				}
				if (num == 23)
				{
					goto IL_3C7;
				}
				goto IL_3DE;
				IL_2BD:
				if (num == 13)
				{
					num5 = 0;
					num = 14;
				}
				if (num == 12)
				{
					goto IL_2F1;
				}
				goto IL_30C;
				IL_1B3:
				if (num == 26)
				{
					num6 = 0;
					num = 27;
				}
				if (num == 14)
				{
					goto IL_487;
				}
				short num7;
				if (num == 7)
				{
					num7 = Marshal.ReadInt16((IntPtr)(baseAddress.ToInt32() + num4 + 6));
					num = 8;
				}
				if (num == 4)
				{
					Process currentProcess = Process.GetCurrentProcess();
					num = 5;
				}
				if (num == 8)
				{
					num2 = 0;
					num = 9;
				}
				if (num == 20)
				{
					goto IL_2A7;
				}
				if (num == 27)
				{
					goto IL_2A7;
				}
				goto IL_2BD;
				IL_190:
				if (num == 21)
				{
					goto IL_1A1;
				}
				goto IL_1B3;
				IL_4DF:
				AntiDump2.EraseSection((IntPtr)(baseAddress.ToInt32() + num4 + list[num2]), 1);
				num = 11;
				goto IL_513;
				IL_2F1:
				if (num2 >= list.Count)
				{
					num = 13;
					goto IL_30C;
				}
				goto IL_4DF;
				IL_487:
				if (num5 >= list3.Count)
				{
					num = 18;
					goto IL_4A2;
				}
				goto IL_15C;
				IL_3C7:
				num6++;
				num = 24;
				goto IL_3DE;
				IL_1A1:
				if (num6 == 0)
				{
					num = 22;
					goto IL_1B3;
				}
				goto IL_3C7;
				IL_2A7:
				if (num3 > (int)num7)
				{
					num = 28;
					goto IL_2BD;
				}
				goto IL_1A1;
				IL_15C:
				AntiDump2.EraseSection((IntPtr)(baseAddress.ToInt32() + num4 + list3[num5]), 2);
				num = 16;
				goto IL_190;
			}
		}
	}
}

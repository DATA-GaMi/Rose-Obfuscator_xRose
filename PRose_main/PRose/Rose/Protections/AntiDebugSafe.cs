using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rose.Protections
{
	// Token: 0x02000009 RID: 9
	internal static class AntiDebugSafe
	{
		// Token: 0x06000019 RID: 25
		[DllImport("ntdll.dll", CharSet = CharSet.Auto)]
		public static extern int NtQueryInformationProcess(IntPtr test, int test2, int[] test3, int test4, ref int test5);

		// Token: 0x0600001A RID: 26 RVA: 0x00004304 File Offset: 0x00002504
		private static void xEQAW()
		{
			short num = 0;
			for (;;)
			{
				if (num == 20)
				{
					goto IL_1F;
				}
				goto IL_48;
				IL_262:
				if (num == 7)
				{
					goto IL_273;
				}
				IL_29A:
				if (num == 2)
				{
					Environment.Exit(0);
					num = 3;
				}
				if (num == 21)
				{
					break;
				}
				if (num == 19)
				{
					Environment.Exit(0);
					num = 20;
				}
				IntPtr intPtr;
				IntPtr intPtr2;
				if (num == 32)
				{
					Marshal.WriteInt32(intPtr, 4, (int)intPtr2);
					num = 33;
				}
				IntPtr intPtr3;
				int[] array;
				int num2;
				if (num == 14)
				{
					if (AntiDebugSafe.NtQueryInformationProcess(intPtr3, 31, array, 4, ref num2) != 0)
					{
						goto IL_239;
					}
					num = 15;
				}
				if (num == 5)
				{
					goto IL_379;
				}
				IL_391:
				if (num == 26)
				{
					goto IL_3A2;
				}
				IL_3BD:
				if (num != 28)
				{
					goto IL_3F9;
				}
				IntPtr ptr;
				if (Marshal.ReadInt32(Marshal.ReadIntPtr(ptr, 48), 0) == 7536749)
				{
					num = 29;
					goto IL_3F9;
				}
				goto IL_484;
				IL_4F5:
				if (num == 8)
				{
					Environment.Exit(0);
					num = 9;
				}
				if (num == 10)
				{
					return;
				}
				if (num == 30)
				{
					intPtr2 = Marshal.ReadIntPtr(ptr, 12);
					num = 31;
				}
				if (num == 13)
				{
					intPtr3 = Process.GetCurrentProcess().Handle;
					num = 14;
				}
				if (num == 16)
				{
					Environment.Exit(0);
					num = 17;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 34)
				{
					return;
				}
				continue;
				IL_4A4:
				if (num == 23)
				{
					Marshal.WriteInt32(intPtr3, 32, 0);
					num = 24;
				}
				if (num == 3)
				{
					goto IL_4E2;
				}
				goto IL_4F5;
				IL_3F9:
				if (num == 27)
				{
					if (Marshal.ReadInt32(ptr, 44) != 1572886)
					{
						goto IL_484;
					}
					num = 28;
				}
				if (num == 1)
				{
					if (!Debugger.IsLogging())
					{
						goto IL_4E2;
					}
					num = 2;
				}
				if (num == 6)
				{
					Environment.Exit(0);
					num = 7;
				}
				if (num == 33)
				{
					goto IL_484;
				}
				goto IL_4A4;
				IL_4E2:
				if (Debugger.IsAttached)
				{
					num = 4;
					goto IL_4F5;
				}
				goto IL_379;
				IL_484:
				IntPtr intPtr4;
				if (ptr.Equals(intPtr4))
				{
					num = 34;
					goto IL_4A4;
				}
				IL_3A2:
				ptr = Marshal.ReadIntPtr(ptr, 0);
				num = 27;
				goto IL_3BD;
				IL_379:
				if (Environment.GetEnvironmentVariable("complus_profapi_profilercompatibilitysetting") != null)
				{
					num = 6;
					goto IL_391;
				}
				IL_273:
				if (string.Compare(Environment.GetEnvironmentVariable("COR_ENABLE_PROFILING"), "1", StringComparison.Ordinal) == 0)
				{
					num = 8;
					goto IL_29A;
				}
				goto IL_12A;
				IL_1B1:
				if (num == 25)
				{
					ptr = intPtr4;
					num = 26;
				}
				if (num == 4)
				{
					Environment.Exit(0);
					num = 5;
				}
				if (num == 31)
				{
					Marshal.WriteInt32(intPtr2, 0, (int)intPtr);
					num = 32;
				}
				if (num == 17)
				{
					goto IL_239;
				}
				goto IL_262;
				IL_147:
				if (num == 18)
				{
					if (array[0] == 0)
					{
						goto IL_1F;
					}
					num = 19;
				}
				if (num == 22)
				{
					goto IL_181;
				}
				goto IL_1B1;
				IL_9C:
				if (num == 29)
				{
					intPtr = Marshal.ReadIntPtr(ptr, 8);
					num = 30;
				}
				if (num == 12)
				{
					num2 = 0;
					num = 13;
				}
				if (num == 15)
				{
					if (array[0] == 1)
					{
						goto IL_239;
					}
					num = 16;
				}
				if (num == 9)
				{
					goto IL_12A;
				}
				goto IL_147;
				IL_48:
				if (num == 24)
				{
					intPtr4 = Marshal.ReadIntPtr(intPtr3, 0);
					num = 25;
				}
				if (num == 11)
				{
					goto IL_85;
				}
				goto IL_9C;
				IL_1F:
				if (AntiDebugSafe.NtQueryInformationProcess(intPtr3, 0, array, 24, ref num2) != 0)
				{
					num = 21;
					goto IL_48;
				}
				IL_181:
				intPtr3 = Marshal.ReadIntPtr(Marshal.ReadIntPtr((IntPtr)array[1], 12), 12);
				num = 23;
				goto IL_1B1;
				IL_12A:
				if (Environment.OSVersion.Platform != PlatformID.Win32NT)
				{
					num = 10;
					goto IL_147;
				}
				IL_85:
				array = new int[6];
				num = 12;
				goto IL_9C;
				IL_239:
				if (AntiDebugSafe.NtQueryInformationProcess(intPtr3, 30, array, 4, ref num2) == 0)
				{
					num = 18;
					goto IL_262;
				}
				goto IL_1F;
			}
		}
	}
}

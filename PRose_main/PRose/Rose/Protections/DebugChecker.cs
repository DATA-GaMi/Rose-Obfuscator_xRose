using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rose.Protections
{
	// Token: 0x0200000C RID: 12
	internal class DebugChecker
	{
		// Token: 0x06000020 RID: 32
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x06000021 RID: 33 RVA: 0x00004B20 File Offset: 0x00002D20
		public static void CEKQW()
		{
			short num = 0;
			for (;;)
			{
				if (num == 8)
				{
					Application.Exit();
					num = 9;
				}
				if (num == 4)
				{
					goto IL_3E;
				}
				goto IL_51;
				IL_93:
				Stopwatch stopwatch;
				if (num == 7)
				{
					if (stopwatch.ElapsedMilliseconds <= 2500L)
					{
						break;
					}
					num = 8;
				}
				if (num == 2)
				{
					if (!Debugger.IsAttached)
					{
						goto IL_3E;
					}
					num = 3;
				}
				if (num == 3)
				{
					Application.Exit();
					num = 4;
				}
				if (num == 1)
				{
					stopwatch = Stopwatch.StartNew();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					break;
				}
				continue;
				IL_51:
				if (num == 5)
				{
					Application.Exit();
					num = 6;
				}
				if (num != 6)
				{
					goto IL_93;
				}
				IL_81:
				stopwatch.Stop();
				num = 7;
				goto IL_93;
				IL_3E:
				if (DebugChecker.IsDebuggerPresent())
				{
					num = 5;
					goto IL_51;
				}
				goto IL_81;
			}
		}
	}
}

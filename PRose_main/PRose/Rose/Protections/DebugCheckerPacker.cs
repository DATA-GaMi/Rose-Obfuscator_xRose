using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rose.Protections
{
	// Token: 0x0200004D RID: 77
	internal class DebugCheckerPacker
	{
		// Token: 0x060000F6 RID: 246
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x060000F7 RID: 247 RVA: 0x000119D8 File Offset: 0x0000FBD8
		public static void XERPO()
		{
			short num = 0;
			for (;;)
			{
				Stopwatch stopwatch;
				if (num == 7)
				{
					if (stopwatch.ElapsedMilliseconds <= 2500L)
					{
						break;
					}
					num = 8;
				}
				if (num == 3)
				{
					Application.Exit();
					num = 4;
				}
				if (num == 6)
				{
					goto IL_6C;
				}
				IL_7E:
				if (num == 8)
				{
					Application.Exit();
					num = 9;
				}
				if (num == 5)
				{
					Application.Exit();
					num = 6;
				}
				if (num == 4)
				{
					goto IL_CD;
				}
				IL_E0:
				if (num == 2)
				{
					if (!Debugger.IsAttached)
					{
						goto IL_CD;
					}
					num = 3;
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
				IL_CD:
				if (DebugCheckerPacker.IsDebuggerPresent())
				{
					num = 5;
					goto IL_E0;
				}
				IL_6C:
				stopwatch.Stop();
				num = 7;
				goto IL_7E;
			}
		}
	}
}

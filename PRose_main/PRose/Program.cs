using System;
using System.Windows.Forms;

namespace PRose
{
	// Token: 0x02000078 RID: 120
	internal static class Program
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00034EDC File Offset: 0x000330DC
		[STAThread]
		private static void Main()
		{
			short num = 0;
			do
			{
				if (num == 3)
				{
					Application.Run(new Form2());
					num = 4;
				}
				if (num == 2)
				{
					Application.SetCompatibleTextRenderingDefault(false);
					num = 3;
				}
				if (num == 1)
				{
					Application.EnableVisualStyles();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}
	}
}

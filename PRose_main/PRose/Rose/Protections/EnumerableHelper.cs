using System;
using System.Collections.Generic;
using System.Linq;

namespace Rose.Protections
{
	// Token: 0x02000055 RID: 85
	public static class EnumerableHelper
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00013950 File Offset: 0x00011B50
		public static TE Random<TE>(IEnumerable<TE> input)
		{
			short num = 0;
			TE[] array2;
			for (;;)
			{
				TE[] array;
				if (num == 2)
				{
					array = input.ToArray<TE>();
					goto IL_28;
				}
				IL_35:
				if (num == 1)
				{
					if ((array = (input as !!0[])) != null)
					{
						goto IL_28;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					break;
				}
				continue;
				IL_28:
				array2 = array;
				num = 3;
				goto IL_35;
			}
			return array2.ElementAt(EnumerableHelper.R.Next(array2.Length));
		}

		// Token: 0x04000064 RID: 100
		private static readonly Random R = new Random();
	}
}

using System;
using System.Collections.Generic;

namespace Rose.Protections
{
	// Token: 0x02000056 RID: 86
	public static class EnumerableExtensions
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00013A0C File Offset: 0x00011C0C
		public static T Random<T>(this IEnumerable<T> input)
		{
			short num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return EnumerableHelper.Random<T>(input);
		}
	}
}

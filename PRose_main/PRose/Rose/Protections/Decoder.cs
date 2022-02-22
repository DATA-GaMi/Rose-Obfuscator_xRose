using System;
using System.Reflection;
using System.Text;

namespace Rose.Protections
{
	// Token: 0x0200006D RID: 109
	internal static class Decoder
	{
		// Token: 0x0600015B RID: 347 RVA: 0x00019A80 File Offset: 0x00017C80
		public static string ZExtO(string encodedString, int key)
		{
			short num = 0;
			StringBuilder stringBuilder;
			for (;;)
			{
				if (num == 3)
				{
					num = 4;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 5)
				{
					goto IL_183;
				}
				if (num == 6)
				{
					goto IL_84;
				}
				goto IL_9E;
				IL_19E:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					goto Block_12;
				}
				continue;
				IL_9E:
				int num2;
				if (num == 8)
				{
					num2++;
					num = 9;
				}
				if (num == 1)
				{
					if (!(Assembly.GetExecutingAssembly().FullName == Assembly.GetCallingAssembly().FullName))
					{
						goto IL_1D4;
					}
					num = 2;
				}
				char c;
				if (num == 7)
				{
					stringBuilder.Append((char)((int)c ^ key));
					num = 8;
				}
				if (num == 4)
				{
					num2 = 0;
					num = 5;
				}
				if (num == 2)
				{
					stringBuilder = new StringBuilder();
					num = 3;
				}
				if (num != 9)
				{
					goto IL_19E;
				}
				IL_183:
				if (num2 >= encodedString.Length)
				{
					num = 10;
					goto IL_19E;
				}
				IL_84:
				c = encodedString[num2];
				num = 7;
				goto IL_9E;
			}
			return stringBuilder.ToString();
			Block_12:
			IL_1D4:
			return null;
		}
	}
}

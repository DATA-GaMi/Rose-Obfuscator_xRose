using System;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x02000004 RID: 4
	internal static class AddJunk
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0000353C File Offset: 0x0000173C
		public static void Execute(ModuleDefMD module)
		{
			short num = 0;
			for (;;)
			{
				if (num == 10)
				{
					goto IL_1F;
				}
				goto IL_3C;
				IL_277:
				TypeDefUser item;
				if (num == 5)
				{
					item = new TypeDefUser(RUtils.GenerateRandomString2(xd.thelength), module.CorLibTypes.Object.TypeDefOrRef);
					num = 6;
				}
				if (num == 3)
				{
					goto IL_1DF;
				}
				if (num == 8)
				{
					TypeDefUser item2 = new TypeDefUser(RUtils.RandomNum(xd.thelength), module.CorLibTypes.Object.TypeDefOrRef);
					num = 9;
				}
				int num2;
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 18)
				{
					break;
				}
				continue;
				IL_249:
				if (num == 7)
				{
					goto IL_25A;
				}
				goto IL_277;
				IL_1F5:
				if (num == 9)
				{
					TypeDefUser item2;
					module.Types.Add(item2);
					num = 10;
				}
				if (num == 16)
				{
					goto IL_232;
				}
				goto IL_249;
				IL_1CE:
				if (num == 17)
				{
					goto IL_1DF;
				}
				goto IL_1F5;
				IL_6A:
				TypeDefUser item3;
				if (num == 11)
				{
					item3 = new TypeDefUser(RUtils.RandomSymbols(xd.thelength), module.CorLibTypes.Object.TypeDefOrRef);
					num = 12;
				}
				if (num == 12)
				{
					module.Types.Add(item3);
					num = 13;
				}
				if (num == 6)
				{
					module.Types.Add(item);
					num = 7;
				}
				if (num == 15)
				{
					TypeDefUser item4;
					module.Types.Add(item4);
					num = 16;
				}
				if (num == 14)
				{
					TypeDefUser item4 = new TypeDefUser(RUtils.RandomChinese(xd.thelength), module.CorLibTypes.Object.TypeDefOrRef);
					num = 15;
				}
				int num3;
				if (num == 1)
				{
					num3 = Convert.ToInt32(10);
					num = 2;
				}
				if (num == 13)
				{
					goto IL_1B1;
				}
				goto IL_1CE;
				IL_3C:
				if (num == 4)
				{
					goto IL_4D;
				}
				goto IL_6A;
				IL_1F:
				if (xd.renamertype == "Symbols")
				{
					num = 11;
					goto IL_3C;
				}
				goto IL_1B1;
				IL_25A:
				if (xd.renamertype == "Numbers")
				{
					num = 8;
					goto IL_277;
				}
				goto IL_1F;
				IL_4D:
				if (xd.renamertype == "Ascii")
				{
					num = 5;
					goto IL_6A;
				}
				goto IL_25A;
				IL_232:
				num2++;
				num = 17;
				goto IL_249;
				IL_1B1:
				if (xd.renamertype == "Chinese")
				{
					num = 14;
					goto IL_1CE;
				}
				goto IL_232;
				IL_1DF:
				if (num2 >= num3)
				{
					num = 18;
					goto IL_1F5;
				}
				goto IL_4D;
			}
		}
	}
}

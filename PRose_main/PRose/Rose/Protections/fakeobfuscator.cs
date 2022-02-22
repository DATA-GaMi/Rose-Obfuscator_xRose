using System;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x0200003C RID: 60
	internal static class fakeobfuscator
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x0000E158 File Offset: 0x0000C358
		public static void Execute(ModuleDefMD module)
		{
			short num = 0;
			for (;;)
			{
				if (num == 3)
				{
					goto IL_1F;
				}
				IL_62:
				int num2;
				if (num == 6)
				{
					num2++;
					num = 7;
				}
				if (num == 2)
				{
					goto IL_10E;
				}
				TypeDefUser typeDefUser;
				if (num == 5)
				{
					module.Types.Add(typeDefUser);
					num = 6;
				}
				if (num == 4)
				{
					typeDefUser.Attributes = TypeAttributes.WindowsRuntime;
					num = 5;
				}
				if (num == 7)
				{
					goto IL_10E;
				}
				IL_127:
				if (num == 1)
				{
					num2 = 0;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
				IL_10E:
				if (num2 >= fakeobfuscator.attrib.Length)
				{
					num = 8;
					goto IL_127;
				}
				IL_1F:
				typeDefUser = new TypeDefUser(fakeobfuscator.attrib[num2], fakeobfuscator.attrib[num2], module.CorLibTypes.Object.TypeDefOrRef);
				num = 4;
				goto IL_62;
			}
		}

		// Token: 0x04000052 RID: 82
		private static string[] attrib = new string[]
		{
			RUtils.RandomSymbols(xd.thelength),
			"RoseObfuscator",
			"ObfuscatedByRose",
			"Yano",
			"Xenocode",
			"PoweredByAttribute",
			"ObfuscatedByGoliath",
			"NineRays.Obfuscator.Evaluation",
			"NetGuard",
			"dotNetProtector",
			"DotNetPatcher",
			"Dotfuscator",
			"CryptoObfuscator",
			"BabelObfuscator"
		};
	}
}

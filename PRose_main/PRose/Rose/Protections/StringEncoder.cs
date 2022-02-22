using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Rose.Helper;

namespace Rose.Protections
{
	// Token: 0x0200006A RID: 106
	internal static class StringEncoder
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00018F2C File Offset: 0x0001712C
		public static void Execute(ModuleDefMD moduleDefMd)
		{
			short num = 0;
			MethodDef method;
			IEnumerator<TypeDef> enumerator;
			CryptoRandom cryptoRandom;
			do
			{
				if (num == 3)
				{
					TypeDef typeDef;
					method = (InjectHelper.Inject(typeDef, moduleDefMd.GlobalType, moduleDefMd).SingleOrDefault<IDnlibDef>() as MethodDef);
					num = 4;
				}
				ModuleDefMD moduleDefMD;
				if (num == 1)
				{
					moduleDefMD = ModuleDefMD.Load(typeof(Decoder).Module);
					num = 2;
				}
				if (num == 5)
				{
					enumerator = (from x in moduleDefMd.GetTypes()
					where x.HasMethods
					select x).GetEnumerator();
					num = 6;
				}
				if (num == 2)
				{
					TypeDef typeDef = moduleDefMD.ResolveTypeDef(MDToken.ToRID(typeof(Decoder).MetadataToken));
					num = 3;
				}
				if (num == 4)
				{
					cryptoRandom = new CryptoRandom();
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			try
			{
				while (enumerator.MoveNext())
				{
					TypeDef typeDef2 = enumerator.Current;
					foreach (MethodDef methodDef in from x in typeDef2.Methods
					where x.HasBody
					select x)
					{
						IList<Instruction> instructions = methodDef.Body.Instructions;
						for (int i = 0; i < instructions.Count; i++)
						{
							if (instructions[i].OpCode == OpCodes.Ldstr && !string.IsNullOrEmpty(instructions[i].Operand.ToString()))
							{
								int num2 = methodDef.Name.Length + cryptoRandom.Next();
								string operand = StringEncoder.EncryptString(new Tuple<string, int>(instructions[i].Operand.ToString(), num2));
								instructions[i].OpCode = OpCodes.Ldstr;
								instructions[i].Operand = operand;
								instructions.Insert(i + 1, OpCodes.Ldc_I4.ToInstruction(num2));
								instructions.Insert(i + 2, OpCodes.Call.ToInstruction(method));
								i += 2;
							}
						}
						methodDef.Body.SimplifyMacros(methodDef.Parameters);
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000192D4 File Offset: 0x000174D4
		private static string EncryptString(Tuple<string, int> values)
		{
			short num = 0;
			StringBuilder stringBuilder;
			for (;;)
			{
				int num2;
				if (num == 8)
				{
					num2++;
					num = 9;
				}
				string item;
				if (num == 3)
				{
					item = values.Item1;
					num = 4;
				}
				char c;
				if (num == 7)
				{
					int item2;
					stringBuilder.Append((char)((int)c ^ item2));
					num = 8;
				}
				if (num == 6)
				{
					goto IL_9C;
				}
				IL_B6:
				if (num == 5)
				{
					goto IL_E6;
				}
				if (num == 9)
				{
					goto IL_E6;
				}
				IL_101:
				if (num == 1)
				{
					stringBuilder = new StringBuilder();
					num = 2;
				}
				if (num == 2)
				{
					int item2 = values.Item2;
					num = 3;
				}
				if (num == 4)
				{
					num2 = 0;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 10)
				{
					break;
				}
				continue;
				IL_E6:
				if (num2 >= item.Length)
				{
					num = 10;
					goto IL_101;
				}
				IL_9C:
				c = item[num2];
				num = 7;
				goto IL_B6;
			}
			return stringBuilder.ToString();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200004B RID: 75
	internal class RandomOutlinedMethods : SecureRandoms
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00011070 File Offset: 0x0000F270
		public static void Execute(ModuleDef module)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = module.Types.GetEnumerator();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			try
			{
				while (enumerator.MoveNext())
				{
					TypeDef typeDef = enumerator.Current;
					foreach (MethodDef source_method in typeDef.Methods.ToArray<MethodDef>())
					{
						if (xd.renamertype == "Ascii")
						{
							MethodDef item = RandomOutlinedMethods.CreateReturnMethodDef(RUtils.GenerateRandomString2(xd.thelength), source_method);
							MethodDef item2 = RandomOutlinedMethods.CreateReturnMethodDef(SecureRandoms.Next(10, 20), source_method);
							typeDef.Methods.Add(item);
							typeDef.Methods.Add(item2);
						}
						if (xd.renamertype == "Numbers")
						{
							MethodDef item3 = RandomOutlinedMethods.CreateReturnMethodDef(RUtils.RandomNum(xd.thelength), source_method);
							MethodDef item4 = RandomOutlinedMethods.CreateReturnMethodDef(SecureRandoms.Next(5, 20), source_method);
							typeDef.Methods.Add(item3);
							typeDef.Methods.Add(item4);
						}
						if (xd.renamertype == "Symbols")
						{
							MethodDef item5 = RandomOutlinedMethods.CreateReturnMethodDef(RUtils.RandomSymbols(xd.thelength), source_method);
							MethodDef item6 = RandomOutlinedMethods.CreateReturnMethodDef(SecureRandoms.Next(5, 20), source_method);
							typeDef.Methods.Add(item5);
							typeDef.Methods.Add(item6);
						}
						if (xd.renamertype == "Chinese")
						{
							MethodDef item7 = RandomOutlinedMethods.CreateReturnMethodDef(RUtils.RandomChinese(xd.thelength), source_method);
							MethodDef item8 = RandomOutlinedMethods.CreateReturnMethodDef(SecureRandoms.Next(5, 20), source_method);
							typeDef.Methods.Add(item7);
							typeDef.Methods.Add(item8);
						}
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

		// Token: 0x060000EE RID: 238 RVA: 0x0001134C File Offset: 0x0000F54C
		public static MethodDef CreateReturnMethodDef(object value, MethodDef source_method)
		{
			short num = 0;
			MethodDef methodDef;
			for (;;)
			{
				if (num == 9)
				{
					methodDef.Body.Instructions.Add(Instruction.Create(OpCodes.Ldc_I4, (int)value));
					num = 10;
				}
				if (num == 10)
				{
					goto IL_226;
				}
				CorLibTypeSig retType;
				if (num == 3)
				{
					retType = source_method.Module.CorLibTypes.Int32;
					num = 4;
				}
				if (num == 8)
				{
					if (!(value is int))
					{
						goto IL_1FE;
					}
					num = 9;
				}
				if (num == 7)
				{
					goto IL_D7;
				}
				goto IL_116;
				IL_24C:
				if (num == 2)
				{
					if (!(value is int))
					{
						goto IL_158;
					}
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 14)
				{
					break;
				}
				continue;
				IL_215:
				if (num == 13)
				{
					goto IL_226;
				}
				goto IL_24C;
				IL_16F:
				if (num == 1)
				{
					retType = null;
					num = 2;
				}
				if (num == 4)
				{
					goto IL_D7;
				}
				if (num == 12)
				{
					methodDef.Body.Instructions.Add(Instruction.Create(OpCodes.Ldstr, (string)value));
					num = 13;
				}
				if (num == 11)
				{
					goto IL_1FE;
				}
				goto IL_215;
				IL_116:
				if (num == 6)
				{
					retType = source_method.Module.CorLibTypes.String;
					num = 7;
				}
				if (num == 5)
				{
					goto IL_158;
				}
				goto IL_16F;
				IL_226:
				methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ret));
				num = 14;
				goto IL_24C;
				IL_1FE:
				if (value is string)
				{
					num = 12;
					goto IL_215;
				}
				goto IL_226;
				IL_158:
				if (value is string)
				{
					num = 6;
					goto IL_16F;
				}
				IL_D7:
				methodDef = new MethodDefUser(RUtils.GenerateRandomString2(xd.thelength), MethodSig.CreateStatic(retType), MethodImplAttributes.IL, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static | MethodAttributes.HideBySig)
				{
					Body = new CilBody()
				};
				num = 8;
				goto IL_116;
			}
			return methodDef;
		}
	}
}

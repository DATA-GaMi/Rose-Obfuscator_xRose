using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000049 RID: 73
	internal static class Mutation
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00010824 File Offset: 0x0000EA24
		public static void Execute(ModuleDefMD moduleDefMd)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			CryptoRandom cryptoRandom;
			do
			{
				if (num == 3)
				{
					enumerator = moduleDefMd.GetTypes().GetEnumerator();
					num = 4;
				}
				if (num == 1)
				{
					Mutation._moduleDefMd = moduleDefMd;
					num = 2;
				}
				if (num == 2)
				{
					cryptoRandom = new CryptoRandom();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			try
			{
				while (enumerator.MoveNext())
				{
					TypeDef typeDef = enumerator.Current;
					List<MethodDef> list = new List<MethodDef>();
					foreach (MethodDef methodDef in from x in typeDef.Methods
					where x.HasBody
					select x)
					{
						IList<Instruction> instructions = methodDef.Body.Instructions;
						for (int i = 0; i < instructions.Count; i++)
						{
							if (instructions[i].IsLdcI4() && Mutation.IsSafe(instructions.ToList<Instruction>(), i))
							{
								MethodDef methodDef2 = null;
								int ldcI4Value = instructions[i].GetLdcI4Value();
								instructions[i].OpCode = OpCodes.Ldc_R8;
								switch (cryptoRandom.Next(0, 0))
								{
								case 0:
									methodDef2 = Mutation.GenerateRefMethod("Floor");
									instructions[i].Operand = Convert.ToDouble((double)ldcI4Value + cryptoRandom.NextDouble());
									break;
								case 1:
									methodDef2 = Mutation.GenerateRefMethod("Sqrt");
									instructions[i].Operand = Math.Pow(Convert.ToDouble(ldcI4Value), 2.0);
									break;
								case 2:
									methodDef2 = Mutation.GenerateRefMethod("Round");
									instructions[i].Operand = Convert.ToDouble(ldcI4Value);
									break;
								}
								instructions.Insert(i + 1, OpCodes.Call.ToInstruction(methodDef2));
								instructions.Insert(i + 2, OpCodes.Conv_I4.ToInstruction());
								i += 2;
								list.Add(methodDef2);
							}
						}
						methodDef.Body.SimplifyMacros(methodDef.Parameters);
					}
					foreach (MethodDef item in list)
					{
						typeDef.Methods.Add(item);
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

		// Token: 0x060000E7 RID: 231 RVA: 0x00010C28 File Offset: 0x0000EE28
		private static MethodDef GenerateRefMethod(string methodName)
		{
			short num = 0;
			MethodDefUser methodDefUser;
			do
			{
				if (num == 11)
				{
					CilBody body;
					methodDefUser.Body = body;
					num = 12;
				}
				MethodDefUser methodDefUser2;
				if (num == 3)
				{
					methodDefUser = methodDefUser2;
					num = 4;
				}
				CilBody cilBody;
				if (num == 5)
				{
					cilBody.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
					num = 6;
				}
				if (num == 9)
				{
					cilBody.Instructions.Add(OpCodes.Ret.ToInstruction());
					num = 10;
				}
				if (num == 12)
				{
					methodDefUser.Body.Variables.Add(new Local(Mutation._moduleDefMd.ImportAsTypeSig(typeof(double))));
					num = 13;
				}
				if (num == 2)
				{
					methodDefUser2.Signature = new MethodSig
					{
						Params = 
						{
							Mutation._moduleDefMd.ImportAsTypeSig(typeof(double))
						},
						RetType = Mutation._moduleDefMd.ImportAsTypeSig(typeof(double))
					};
					num = 3;
				}
				if (num == 7)
				{
					cilBody.Instructions.Add(OpCodes.Stloc_0.ToInstruction());
					num = 8;
				}
				if (num == 10)
				{
					CilBody body = cilBody;
					num = 11;
				}
				if (num == 8)
				{
					cilBody.Instructions.Add(OpCodes.Ldloc_0.ToInstruction());
					num = 9;
				}
				if (num == 4)
				{
					cilBody = new CilBody();
					num = 5;
				}
				if (num == 1)
				{
					methodDefUser2 = new MethodDefUser(RUtils.RandomSymbols(5), MethodSig.CreateStatic(Mutation._moduleDefMd.ImportAsTypeSig(typeof(double))), MethodAttributes.Private | MethodAttributes.Static | MethodAttributes.HideBySig);
					num = 2;
				}
				if (num == 6)
				{
					cilBody.Instructions.Add(OpCodes.Call.ToInstruction(Mutation.GetMethod(typeof(Math), methodName, new Type[]
					{
						typeof(double)
					})));
					num = 7;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 13);
			return methodDefUser.ResolveMethodDef();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00010F40 File Offset: 0x0000F140
		private static bool IsSafe(List<Instruction> instructions, int i)
		{
			short num = 0;
			while (num != 2)
			{
				if (num == 1)
				{
					if (!new int[]
					{
						-2,
						-1,
						0,
						1,
						2
					}.Contains(instructions[i].GetLdcI4Value()))
					{
						return true;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 3)
				{
					continue;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00011004 File Offset: 0x0000F204
		private static IMethod GetMethod(Type type, string methodName, Type[] types)
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
			return Mutation._moduleDefMd.Import(type.GetMethod(methodName, types));
		}

		// Token: 0x04000055 RID: 85
		private static ModuleDefMD _moduleDefMd;
	}
}

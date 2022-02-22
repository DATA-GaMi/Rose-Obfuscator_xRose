using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200001A RID: 26
	public class Arithmetic
	{
		// Token: 0x06000043 RID: 67 RVA: 0x0000854C File Offset: 0x0000674C
		public static void Execute(ModuleDef moduleDef)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			Generator generator;
			do
			{
				if (num == 1)
				{
					Arithmetic.moduleDef1 = moduleDef;
					num = 2;
				}
				if (num == 3)
				{
					enumerator = moduleDef.Types.GetEnumerator();
					num = 4;
				}
				if (num == 2)
				{
					generator = new Generator();
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
					foreach (MethodDef methodDef in typeDef.Methods)
					{
						if (methodDef.HasBody && !methodDef.DeclaringType.IsGlobalModuleType)
						{
							for (int i = 0; i < methodDef.Body.Instructions.Count; i++)
							{
								if (ArithmeticUtils.CheckArithmetic(methodDef.Body.Instructions[i]))
								{
									if (methodDef.Body.Instructions[i].GetLdcI4Value() < 0)
									{
										iFunction iFunction = Arithmetic.Tasks[generator.Next(5)];
										List<Instruction> list = Arithmetic.GenerateBody(iFunction.Arithmetic(methodDef.Body.Instructions[i], moduleDef));
										if (list == null)
										{
											goto IL_32F;
										}
										methodDef.Body.Instructions[i].OpCode = OpCodes.Nop;
										using (List<Instruction>.Enumerator enumerator3 = list.GetEnumerator())
										{
											while (enumerator3.MoveNext())
											{
												Instruction item = enumerator3.Current;
												methodDef.Body.Instructions.Insert(i + 1, item);
												i++;
											}
											goto IL_32F;
										}
									}
									iFunction iFunction2 = Arithmetic.Tasks[generator.Next(Arithmetic.Tasks.Count)];
									List<Instruction> list2 = Arithmetic.GenerateBody(iFunction2.Arithmetic(methodDef.Body.Instructions[i], moduleDef));
									if (list2 != null)
									{
										methodDef.Body.Instructions[i].OpCode = OpCodes.Nop;
										foreach (Instruction item2 in list2)
										{
											methodDef.Body.Instructions.Insert(i + 1, item2);
											i++;
										}
									}
								}
								IL_32F:;
							}
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

		// Token: 0x06000044 RID: 68 RVA: 0x00008964 File Offset: 0x00006B64
		private static List<Instruction> GenerateBody(ArithmeticVT arithmeticVTs)
		{
			short num = 0;
			List<Instruction> list;
			for (;;)
			{
				if (num == 7)
				{
					goto IL_1F;
				}
				IL_44:
				if (num == 5)
				{
					if (arithmeticVTs.GetToken().GetOperand() == null)
					{
						goto IL_1F;
					}
					num = 6;
				}
				if (num == 1)
				{
					list = new List<Instruction>();
					num = 2;
				}
				if (num != 2)
				{
					goto IL_C1;
				}
				if (Arithmetic.IsArithmetic(arithmeticVTs.GetArithmetic()))
				{
					num = 3;
					goto IL_C1;
				}
				goto IL_1F3;
				IL_20F:
				if (num == 8)
				{
					list.Add(new Instruction(OpCodes.Call, Arithmetic.moduleDef1.Import(typeof(Convert).GetMethod("ToInt32", new Type[]
					{
						typeof(double)
					}))));
					num = 9;
				}
				if (num == 6)
				{
					list.Add(new Instruction(OpCodes.Call, arithmeticVTs.GetToken().GetOperand()));
					num = 7;
				}
				if (num == 13)
				{
					list.Add(new Instruction(arithmeticVTs.GetToken().GetOpCode()));
					num = 14;
				}
				if (num == 14)
				{
					list.Add(new Instruction(OpCodes.Conv_I4));
					num = 15;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 15)
				{
					break;
				}
				continue;
				IL_C1:
				if (num == 12)
				{
					list.Add(new Instruction(OpCodes.Ldc_I4, (int)arithmeticVTs.GetValue().GetY()));
					num = 13;
				}
				if (num == 4)
				{
					list.Add(new Instruction(OpCodes.Ldc_R8, arithmeticVTs.GetValue().GetY()));
					num = 5;
				}
				if (num == 11)
				{
					list.Add(new Instruction(OpCodes.Ldc_I4, (int)arithmeticVTs.GetValue().GetX()));
					num = 12;
				}
				if (num == 3)
				{
					list.Add(new Instruction(OpCodes.Ldc_R8, arithmeticVTs.GetValue().GetX()));
					num = 4;
				}
				if (num == 9)
				{
					break;
				}
				if (num != 10)
				{
					goto IL_20F;
				}
				IL_1F3:
				if (Arithmetic.IsXor(arithmeticVTs.GetArithmetic()))
				{
					num = 11;
					goto IL_20F;
				}
				break;
				IL_1F:
				list.Add(new Instruction(arithmeticVTs.GetToken().GetOpCode()));
				num = 8;
				goto IL_44;
			}
			return list;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00008CC0 File Offset: 0x00006EC0
		private static bool IsArithmetic(ArithmeticTypes arithmetic)
		{
			short num = 0;
			for (;;)
			{
				if (num == 14)
				{
					if (arithmetic == ArithmeticTypes.Tanh)
					{
						return true;
					}
					num = 15;
				}
				if (num == 10)
				{
					if (arithmetic == ArithmeticTypes.Cos)
					{
						return true;
					}
					num = 11;
				}
				if (num == 9)
				{
					if (arithmetic == ArithmeticTypes.Sin)
					{
						return true;
					}
					num = 10;
				}
				if (num == 2)
				{
					if (arithmetic == ArithmeticTypes.Sub)
					{
						return true;
					}
					num = 3;
				}
				if (num == 7)
				{
					if (arithmetic == ArithmeticTypes.Log10)
					{
						return true;
					}
					num = 8;
				}
				if (num == 16)
				{
					break;
				}
				if (num == 8)
				{
					if (arithmetic == ArithmeticTypes.Truncate)
					{
						return true;
					}
					num = 9;
				}
				if (num == 5)
				{
					if (arithmetic == ArithmeticTypes.Abs)
					{
						return true;
					}
					num = 6;
				}
				if (num == 11)
				{
					if (arithmetic == ArithmeticTypes.Floor)
					{
						return true;
					}
					num = 12;
				}
				if (num == 1)
				{
					if (arithmetic == ArithmeticTypes.Add)
					{
						return true;
					}
					num = 2;
				}
				if (num == 3)
				{
					if (arithmetic == ArithmeticTypes.Div)
					{
						return true;
					}
					num = 4;
				}
				if (num == 6)
				{
					if (arithmetic == ArithmeticTypes.Log)
					{
						return true;
					}
					num = 7;
				}
				if (num == 13)
				{
					if (arithmetic == ArithmeticTypes.Tan)
					{
						return true;
					}
					num = 14;
				}
				if (num == 4)
				{
					if (arithmetic == ArithmeticTypes.Mul)
					{
						return true;
					}
					num = 5;
				}
				if (num == 12)
				{
					if (arithmetic == ArithmeticTypes.Round)
					{
						return true;
					}
					num = 13;
				}
				if (num == 15)
				{
					if (arithmetic == ArithmeticTypes.Sqrt)
					{
						return true;
					}
					num = 16;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 17)
				{
					return true;
				}
			}
			return arithmetic == ArithmeticTypes.Ceiling;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00008F90 File Offset: 0x00007190
		private static bool IsXor(ArithmeticTypes arithmetic)
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
			return arithmetic == ArithmeticTypes.Xor;
		}

		// Token: 0x0400001A RID: 26
		public static ModuleDef moduleDef1;

		// Token: 0x0400001B RID: 27
		public static List<iFunction> Tasks = new List<iFunction>
		{
			new Add(),
			new Sub(),
			new Div(),
			new Mul(),
			new Xor(),
			new Abs(),
			new Log(),
			new Log10(),
			new Sin(),
			new Cos(),
			new Floor(),
			new Round(),
			new Tan(),
			new Tanh(),
			new Sqrt(),
			new Ceiling(),
			new Truncate()
		};
	}
}

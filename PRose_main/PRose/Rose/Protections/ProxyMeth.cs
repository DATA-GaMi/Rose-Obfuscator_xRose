using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000053 RID: 83
	public static class ProxyMeth
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00012FA0 File Offset: 0x000111A0
		public static void ScanMemberRef(ModuleDef module)
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
					foreach (MethodDef methodDef in typeDef.Methods)
					{
						if (methodDef.HasBody && methodDef.Body.HasInstructions)
						{
							for (int i = 0; i < methodDef.Body.Instructions.Count - 1; i++)
							{
								if (methodDef.Body.Instructions[i].OpCode == OpCodes.Call)
								{
									try
									{
										MemberRef memberRef = (MemberRef)methodDef.Body.Instructions[i].Operand;
										if (!memberRef.HasThis)
										{
											ProxyMeth.MemberRefList.Add(memberRef);
										}
									}
									catch
									{
									}
								}
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

		// Token: 0x0600010C RID: 268 RVA: 0x000131C0 File Offset: 0x000113C0
		public static MethodDef GenerateSwitch(MemberRef original, ModuleDef md)
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
			MethodDef result;
			try
			{
				List<TypeSig> list = original.MethodSig.Params.ToList<TypeSig>();
				list.Add(md.CorLibTypes.Int32);
				MethodImplAttributes implFlags = MethodImplAttributes.IL;
				MethodAttributes flags = MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static | MethodAttributes.HideBySig;
				MethodDef methodDef = new MethodDefUser(string.Format("ProxyMeth{0}", ProxyMeth.rand.Next(0, int.MinValue)), MethodSig.CreateStatic(original.MethodSig.RetType, list.ToArray()), implFlags, flags)
				{
					Body = new CilBody()
				};
				methodDef.Body.Variables.Add(new Local(md.CorLibTypes.Int32));
				methodDef.Body.Variables.Add(new Local(md.CorLibTypes.Int32));
				methodDef.Body.Instructions.Add(Instruction.Create(OpCodes.Ldarg_0));
				List<Instruction> list2 = new List<Instruction>();
				Instruction instruction = new Instruction(OpCodes.Switch);
				methodDef.Body.Instructions.Add(instruction);
				Instruction instruction2 = new Instruction(OpCodes.Br_S);
				methodDef.Body.Instructions.Add(instruction2);
				for (int i = 0; i < 5; i++)
				{
					for (int j = 0; j <= original.MethodSig.Params.Count - 1; j++)
					{
						methodDef.Body.Instructions.Add(Instruction.Create(OpCodes.Ldarg, methodDef.Parameters[j]));
						if (j == 0)
						{
							list2.Add(Instruction.Create(OpCodes.Ldarg, methodDef.Parameters[j]));
						}
					}
					Instruction item = Instruction.Create(OpCodes.Ldc_I4, i);
					methodDef.Body.Instructions.Add(item);
					methodDef.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));
				}
				Instruction instruction3 = Instruction.Create(OpCodes.Ldnull);
				methodDef.Body.Instructions.Add(instruction3);
				methodDef.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));
				instruction2.Operand = instruction3;
				instruction.Operand = list2;
				result = methodDef;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00013510 File Offset: 0x00011710
		public static void Execute(ModuleDef module)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			do
			{
				if (num == 1)
				{
					ProxyMeth.ScanMemberRef(module);
					num = 2;
				}
				if (num == 2)
				{
					enumerator = module.GetTypes().GetEnumerator();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					TypeDef typeDef = enumerator.Current;
					if (!typeDef.IsGlobalModuleType)
					{
						foreach (MethodDef methodDef in typeDef.Methods.ToArray<MethodDef>())
						{
							if (methodDef.HasBody && !methodDef.Name.Contains("ProxyMeth"))
							{
								IList<Instruction> instructions = methodDef.Body.Instructions;
								for (int j = 0; j < instructions.Count; j++)
								{
									if (methodDef.Body.Instructions[j].OpCode == OpCodes.Call)
									{
										try
										{
											MemberRef original = (MemberRef)methodDef.Body.Instructions[j].Operand;
											if (!original.HasThis)
											{
												MethodDef methodDef2 = ProxyMeth.GenerateSwitch(original, module);
												methodDef.DeclaringType.Methods.Add(methodDef2);
												instructions[j].OpCode = OpCodes.Call;
												instructions[j].Operand = methodDef2;
												int value = ProxyMeth.rand.Next(0, 5);
												Func<MemberRef, bool> <>9__0;
												for (int k = 0; k < methodDef2.Body.Instructions.Count - 1; k++)
												{
													if (methodDef2.Body.Instructions[k].OpCode == OpCodes.Ldc_I4)
													{
														if (string.Compare(methodDef2.Body.Instructions[k].Operand.ToString(), value.ToString(), StringComparison.Ordinal) != 0)
														{
															methodDef2.Body.Instructions[k].OpCode = OpCodes.Call;
															Instruction instruction = methodDef2.Body.Instructions[k];
															IEnumerable<MemberRef> memberRefList = ProxyMeth.MemberRefList;
															Func<MemberRef, bool> predicate;
															if ((predicate = <>9__0) == null)
															{
																predicate = (<>9__0 = ((MemberRef m) => m.MethodSig.Params.Count == original.MethodSig.Params.Count));
															}
															instruction.Operand = memberRefList.Where(predicate).ToList<MemberRef>().Random<MemberRef>();
														}
														else
														{
															methodDef2.Body.Instructions[k].OpCode = OpCodes.Call;
															methodDef2.Body.Instructions[k].Operand = original;
														}
													}
												}
												methodDef.Body.Instructions.Insert(j, Instruction.CreateLdcI4(value));
											}
										}
										catch
										{
										}
									}
								}
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

		// Token: 0x04000060 RID: 96
		public static Random rand;

		// Token: 0x04000061 RID: 97
		public static List<MemberRef> MemberRefList;
	}
}

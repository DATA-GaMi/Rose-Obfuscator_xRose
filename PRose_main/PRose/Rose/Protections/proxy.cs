using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Rose.Helper;

namespace Rose.Protections
{
	// Token: 0x02000051 RID: 81
	internal class proxy
	{
		// Token: 0x06000106 RID: 262 RVA: 0x00012690 File Offset: 0x00010890
		public static void Execute(ModuleDefMD mod)
		{
			short num = 0;
			for (;;)
			{
				int num2;
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				int num3;
				if (num == 1)
				{
					num3 = 1;
					num = 2;
				}
				if (num == 4)
				{
					goto IL_65;
				}
				IL_80:
				IEnumerator<TypeDef> enumerator;
				if (num != 3)
				{
					if (num == 0)
					{
						num = 1;
					}
					if (num != 5)
					{
						continue;
					}
					try
					{
						while (enumerator.MoveNext())
						{
							TypeDef typeDef = enumerator.Current;
							if (!typeDef.IsGlobalModuleType)
							{
								int count = typeDef.Methods.Count;
								for (int i = 0; i < count; i++)
								{
									MethodDef methodDef = typeDef.Methods[i];
									if (methodDef.HasBody)
									{
										IList<Instruction> instructions = methodDef.Body.Instructions;
										for (int j = 0; j < instructions.Count; j++)
										{
											if (instructions[j].OpCode == OpCodes.Call)
											{
												try
												{
													MethodDef methodDef2 = instructions[j].Operand as MethodDef;
													if (methodDef2.FullName.Contains(mod.Assembly.Name))
													{
														if (methodDef2.Parameters.Count != 0)
														{
															if (methodDef2.Parameters.Count <= 4)
															{
																MethodDef methodDef3 = methodDef2.copyMethod(mod);
																TypeDef declaringType = methodDef2.DeclaringType;
																declaringType.Methods.Add(methodDef3);
																proxy.proxyMethod.Add(methodDef3);
																proxy.Clonesignature(methodDef2, methodDef3);
																CilBody cilBody = new CilBody();
																cilBody.Instructions.Add(OpCodes.Nop.ToInstruction());
																for (int k = 0; k < methodDef2.Parameters.Count; k++)
																{
																	Parameter parameter = methodDef2.Parameters[k];
																	switch (k)
																	{
																	case 0:
																		cilBody.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
																		break;
																	case 1:
																		cilBody.Instructions.Add(OpCodes.Ldarg_1.ToInstruction());
																		break;
																	case 2:
																		cilBody.Instructions.Add(OpCodes.Ldarg_2.ToInstruction());
																		break;
																	case 3:
																		cilBody.Instructions.Add(OpCodes.Ldarg_3.ToInstruction());
																		break;
																	}
																}
																cilBody.Instructions.Add(Instruction.Create(OpCodes.Call, methodDef3));
																cilBody.Instructions.Add(OpCodes.Ret.ToInstruction());
																methodDef2.Body = cilBody;
															}
														}
													}
												}
												catch (Exception)
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
					num2++;
				}
				if (num2 >= num3)
				{
					break;
				}
				IL_65:
				enumerator = mod.Types.GetEnumerator();
				num = 5;
				goto IL_80;
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00012ACC File Offset: 0x00010CCC
		public static MethodDef Clonesignature(MethodDef from, MethodDef to)
		{
			short num = 0;
			do
			{
				if (num == 2)
				{
					if (!from.IsHideBySig)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					to.Attributes = from.Attributes;
					num = 2;
				}
				if (num == 3)
				{
					to.IsHideBySig = true;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			return to;
		}

		// Token: 0x0400005F RID: 95
		public static List<MethodDef> proxyMethod = new List<MethodDef>();
	}
}

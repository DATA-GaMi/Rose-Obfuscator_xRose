using System;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000062 RID: 98
	internal class Calli
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00016D1C File Offset: 0x00014F1C
		public static void Execute(ModuleDef module)
		{
			short num = 0;
			for (;;)
			{
				if (num == 17)
				{
					goto IL_4EA;
				}
				MethodDef methodDef;
				if (num == 14)
				{
					if (methodDef.IsConstructor)
					{
						goto IL_50C;
					}
					num = 15;
				}
				int num2;
				if (num == 6)
				{
					num2 = 0;
					num = 7;
				}
				if (num == 3)
				{
					goto IL_5B5;
				}
				if (num == 12)
				{
					if (methodDef.FullName.Contains(".My"))
					{
						goto IL_50C;
					}
					num = 13;
				}
				if (num == 8)
				{
					goto IL_DA;
				}
				goto IL_F0;
				IL_288:
				if (num == 13)
				{
					if (methodDef.FullName.Contains("Costura"))
					{
						goto IL_50C;
					}
					num = 14;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 18)
				{
					goto IL_2F0;
				}
				continue;
				IL_F0:
				if (num == 11)
				{
					if (methodDef.FullName.Contains("My."))
					{
						goto IL_50C;
					}
					num = 12;
				}
				TypeDef typeDef;
				MethodDef[] array;
				if (num == 5)
				{
					array = typeDef.Methods.ToArray<MethodDef>();
					num = 6;
				}
				if (num == 9)
				{
					if (!methodDef.HasBody)
					{
						goto IL_50C;
					}
					num = 10;
				}
				TypeDef[] array2;
				if (num == 1)
				{
					array2 = module.Types.ToArray<TypeDef>();
					num = 2;
				}
				int num3;
				if (num == 16)
				{
					num3 = 0;
					num = 17;
				}
				int num4;
				if (num == 2)
				{
					num4 = 0;
					num = 3;
				}
				if (num == 10)
				{
					if (!methodDef.Body.HasInstructions)
					{
						goto IL_50C;
					}
					num = 11;
				}
				if (num == 15)
				{
					if (methodDef.DeclaringType.IsGlobalModuleType)
					{
						goto IL_50C;
					}
					num = 16;
				}
				if (num == 7)
				{
					goto IL_51A;
				}
				if (num != 4)
				{
					goto IL_288;
				}
				IL_272:
				typeDef = array2[num4];
				num = 5;
				goto IL_288;
				IL_5B5:
				if (num4 >= array2.Length)
				{
					break;
				}
				goto IL_272;
				IL_51A:
				if (num2 >= array.Length)
				{
					foreach (MethodDef methodDef2 in module.GlobalType.Methods)
					{
						if (!(methodDef2.Name != ".ctor"))
						{
							module.GlobalType.Remove(methodDef2);
							break;
						}
					}
					num4++;
					goto IL_5B5;
				}
				goto IL_DA;
				IL_50C:
				num2++;
				goto IL_51A;
				IL_DA:
				methodDef = array[num2];
				num = 9;
				goto IL_F0;
				IL_4EA:
				if (num3 >= methodDef.Body.Instructions.Count - 1)
				{
					goto IL_50C;
				}
				IL_2F0:
				try
				{
					if (!methodDef.Body.Instructions[num3].ToString().Contains("ISupportInitialize") && (methodDef.Body.Instructions[num3].OpCode == OpCodes.Call || methodDef.Body.Instructions[num3].OpCode == OpCodes.Callvirt || methodDef.Body.Instructions[num3].OpCode == OpCodes.Ldloc_S))
					{
						if (!methodDef.Body.Instructions[num3].ToString().Contains("Object") && (methodDef.Body.Instructions[num3].OpCode == OpCodes.Call || methodDef.Body.Instructions[num3].OpCode == OpCodes.Callvirt || methodDef.Body.Instructions[num3].OpCode == OpCodes.Ldloc_S))
						{
							try
							{
								MemberRef memberRef = (MemberRef)methodDef.Body.Instructions[num3].Operand;
								methodDef.Body.Instructions[num3].OpCode = OpCodes.Calli;
								methodDef.Body.Instructions[num3].Operand = memberRef.MethodSig;
								methodDef.Body.Instructions.Insert(num3, Instruction.Create(OpCodes.Ldftn, memberRef));
							}
							catch (Exception)
							{
							}
						}
					}
				}
				catch (Exception)
				{
				}
				num3++;
				goto IL_4EA;
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000064 RID: 100
	public static class First
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00017698 File Offset: 0x00015898
		public static void Execute(ModuleDef md)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					First.StringEncrypting(md);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001770C File Offset: 0x0001590C
		public static void StringEncrypting(ModuleDef moduleDef)
		{
			short num = 0;
			TypeDef typeDef;
			IEnumerator<TypeDef> enumerator;
			do
			{
				if (num == 1)
				{
					typeDef = null;
					num = 2;
				}
				if (num == 2)
				{
					First.DefType(moduleDef);
					num = 3;
				}
				if (num == 3)
				{
					enumerator = moduleDef.Types.GetEnumerator();
					num = 4;
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
					TypeDef typeDef2 = enumerator.Current;
					if (typeDef2.Name == First.x)
					{
						typeDef = typeDef2;
						break;
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
			foreach (TypeDef typeDef3 in moduleDef.Types)
			{
				foreach (MethodDef methodDef in typeDef3.Methods)
				{
					if (methodDef.Body != null)
					{
						for (int i = 0; i < methodDef.Body.Instructions.Count<Instruction>(); i++)
						{
							if (methodDef.Body.Instructions[i].OpCode == OpCodes.Ldstr)
							{
								string str = methodDef.Body.Instructions[i].Operand.ToString();
								string operand = First.EncryptString(str);
								methodDef.Body.Instructions[i].OpCode = OpCodes.Nop;
								methodDef.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Ldstr, operand));
								methodDef.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Call, typeDef.FindMethod(First.y)));
								i += 2;
							}
							methodDef.Body.OptimizeBranches();
							methodDef.Body.SimplifyBranches();
						}
					}
				}
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00017A58 File Offset: 0x00015C58
		public static void DefType(ModuleDef moduleDef)
		{
			short num = 0;
			do
			{
				MethodDef methodDef;
				if (num == 22)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4_0));
					num = 23;
				}
				if (num == 17)
				{
					methodDef.Body.Variables.Locals.Add(new Local(methodDef.Module.CorLibTypes.Int32));
					num = 18;
				}
				MethodImplAttributes implFlags;
				if (num == 6)
				{
					implFlags = MethodImplAttributes.IL;
					num = 7;
				}
				if (num == 27)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldelema, moduleDef.Import(typeof(byte))));
					num = 28;
				}
				if (num == 29)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldind_U1));
					num = 30;
				}
				if (num == 34)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldloc_1));
					num = 35;
				}
				Instruction instruction;
				if (num == 24)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Br_S, instruction));
					num = 25;
				}
				if (num == 48)
				{
					methodDef.Body.SimplifyBranches();
					num = 49;
				}
				if (num == 41)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Conv_I4));
					num = 42;
				}
				Importer importer;
				if (num == 12)
				{
					importer = new Importer(moduleDef);
					num = 13;
				}
				if (num == 46)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ret));
					num = 47;
				}
				if (num == 18)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Call, moduleDef.Import(typeof(Encoding).GetMethod("get_ASCII", new Type[0]))));
					num = 19;
				}
				Instruction instruction2;
				if (num == 25)
				{
					methodDef.Body.Instructions.Add(instruction2);
					num = 26;
				}
				if (num == 16)
				{
					ITypeDefOrRef type;
					methodDef.Body.Variables.Locals.Add(new Local(type.ToTypeSig()));
					num = 17;
				}
				if (num == 23)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Stloc_1));
					num = 24;
				}
				TypeDefUser typeDefUser;
				if (num == 2)
				{
					typeDefUser.Attributes = (TypeAttributes.Public | TypeAttributes.Abstract | TypeAttributes.Sealed);
					num = 3;
				}
				if (num == 26)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldloc_1));
					num = 27;
				}
				if (num == 13)
				{
					ITypeDefOrRef type = importer.Import(typeof(byte[]));
					num = 14;
				}
				if (num == 39)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldloc_0));
					num = 40;
				}
				MethodDefUser item;
				if (num == 8)
				{
					MethodAttributes flags;
					item = new MethodDefUser(First.y, MethodSig.CreateStatic(moduleDef.CorLibTypes.String, moduleDef.CorLibTypes.String), implFlags, flags);
					num = 9;
				}
				if (num == 31)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Sub));
					num = 32;
				}
				if (num == 35)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4_1));
					num = 36;
				}
				if (num == 43)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Call, moduleDef.Import(typeof(Encoding).GetMethod("get_ASCII", new Type[0]))));
					num = 44;
				}
				if (num == 19)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldarg_0));
					num = 20;
				}
				if (num == 14)
				{
					instruction = Instruction.Create(OpCodes.Ldloc_1);
					num = 15;
				}
				if (num == 7)
				{
					MethodAttributes flags = MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static;
					num = 8;
				}
				if (num == 20)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Callvirt, moduleDef.Import(typeof(Encoding).GetMethod("GetBytes", new Type[]
					{
						typeof(string)
					}))));
					num = 21;
				}
				if (num == 11)
				{
					methodDef.MethodBody = new CilBody();
					num = 12;
				}
				if (num == 10)
				{
					methodDef = typeDefUser.FindMethod(First.y);
					num = 11;
				}
				if (num == 44)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldloc_0));
					num = 45;
				}
				if (num == 38)
				{
					methodDef.Body.Instructions.Add(instruction);
					num = 39;
				}
				if (num == 28)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Dup));
					num = 29;
				}
				FieldDefUser item2;
				if (num == 4)
				{
					item2 = new FieldDefUser(First.f, new FieldSig(moduleDef.CorLibTypes.Int32), FieldAttributes.FamANDAssem | FieldAttributes.Family | FieldAttributes.Static);
					num = 5;
				}
				if (num == 42)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Blt_S, instruction2));
					num = 43;
				}
				if (num == 40)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldlen));
					num = 41;
				}
				if (num == 30)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4_1));
					num = 31;
				}
				if (num == 3)
				{
					moduleDef.Types.Add(typeDefUser);
					num = 4;
				}
				if (num == 21)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Stloc_0));
					num = 22;
				}
				if (num == 37)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Stloc_1));
					num = 38;
				}
				if (num == 5)
				{
					typeDefUser.Fields.Add(item2);
					num = 6;
				}
				if (num == 1)
				{
					typeDefUser = new TypeDefUser(First.xx, First.x, moduleDef.CorLibTypes.Object.TypeDefOrRef);
					num = 2;
				}
				if (num == 36)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Add));
					num = 37;
				}
				if (num == 47)
				{
					methodDef.Body.OptimizeBranches();
					num = 48;
				}
				if (num == 9)
				{
					typeDefUser.Methods.Add(item);
					num = 10;
				}
				if (num == 45)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Callvirt, moduleDef.Import(typeof(Encoding).GetMethod("GetString", new Type[]
					{
						typeof(byte[])
					}))));
					num = 46;
				}
				if (num == 33)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Stind_I1));
					num = 34;
				}
				if (num == 32)
				{
					methodDef.Body.Instructions.Add(new Instruction(OpCodes.Conv_U1));
					num = 33;
				}
				if (num == 15)
				{
					instruction2 = Instruction.Create(OpCodes.Ldloc_0);
					num = 16;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 49);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00018564 File Offset: 0x00016764
		private static byte[] StrToBytes(string str)
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
			return Encoding.ASCII.GetBytes(str);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000185C4 File Offset: 0x000167C4
		private static string EncryptString(string str)
		{
			short num = 0;
			byte[] array;
			for (;;)
			{
				int num2;
				if (num == 7)
				{
					num2++;
					num = 8;
				}
				if (num == 8)
				{
					goto IL_47;
				}
				goto IL_5F;
				IL_D4:
				if (num == 1)
				{
					array = First.StrToBytes(str);
					num = 2;
				}
				if (num == 3)
				{
					goto IL_47;
				}
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					break;
				}
				continue;
				IL_5F:
				int num3;
				if (num == 5)
				{
					num3 = num2;
					num = 6;
				}
				byte[] array3;
				if (num == 6)
				{
					byte[] array2 = array3;
					int num4 = num3;
					array2[num4] += 1;
					num = 7;
				}
				if (num != 4)
				{
					goto IL_D4;
				}
				IL_C3:
				array3 = array;
				num = 5;
				goto IL_D4;
				IL_47:
				if (num2 >= array.Length)
				{
					num = 9;
					goto IL_5F;
				}
				goto IL_C3;
			}
			return Encoding.ASCII.GetString(array);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00018754 File Offset: 0x00016954
		private static string DecryptString(string str)
		{
			short num = 0;
			byte[] bytes;
			for (;;)
			{
				if (num == 8)
				{
					goto IL_1F;
				}
				goto IL_37;
				IL_CF:
				if (num == 1)
				{
					bytes = Encoding.ASCII.GetBytes(str);
					num = 2;
				}
				if (num == 3)
				{
					goto IL_1F;
				}
				int num2;
				if (num == 7)
				{
					num2++;
					num = 8;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					break;
				}
				continue;
				IL_37:
				byte[] array2;
				if (num == 6)
				{
					byte[] array = array2;
					int num4;
					int num3 = num4;
					array[num3] -= 1;
					num = 7;
				}
				if (num == 5)
				{
					int num4 = num2;
					num = 6;
				}
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				if (num == 4)
				{
					goto IL_BE;
				}
				goto IL_CF;
				IL_1F:
				if (num2 >= bytes.Length)
				{
					num = 9;
					goto IL_37;
				}
				IL_BE:
				array2 = bytes;
				num = 5;
				goto IL_CF;
			}
			return Encoding.ASCII.GetString(bytes);
		}

		// Token: 0x0400006E RID: 110
		public static string x = RUtils.GenerateRandomString2(5);

		// Token: 0x0400006F RID: 111
		public static string xx = RUtils.GenerateRandomString2(5);

		// Token: 0x04000070 RID: 112
		public static string y = RUtils.GenerateRandomString2(5);

		// Token: 0x04000071 RID: 113
		public static string f = RUtils.GenerateRandomString2(5);
	}
}

using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Writer;

namespace Rose.Protections
{
	// Token: 0x02000005 RID: 5
	public class AntiDe4dot
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000038C4 File Offset: 0x00001AC4
		public static void Execute1(AssemblyDef mod)
		{
			short num = 0;
			IEnumerator<ModuleDef> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = mod.Modules.GetEnumerator();
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
					ModuleDef moduleDef = enumerator.Current;
					InterfaceImplUser item = new InterfaceImplUser(moduleDef.GlobalType);
					for (int i = 0; i < 1; i++)
					{
						TypeDefUser typeDefUser = new TypeDefUser(string.Empty, RUtils.GenerateRandomString2(5), moduleDef.CorLibTypes.GetTypeRef("System", "Attribute"));
						InterfaceImplUser item2 = new InterfaceImplUser(typeDefUser);
						moduleDef.Types.Add(typeDefUser);
						typeDefUser.Interfaces.Add(item2);
						typeDefUser.Interfaces.Add(item);
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

		// Token: 0x06000011 RID: 17 RVA: 0x00003A44 File Offset: 0x00001C44
		public static void Execute2(Context context, ModuleDef moduleDef)
		{
			short num = 0;
			for (;;)
			{
				if (num == 4)
				{
					goto IL_1F;
				}
				IL_59:
				TypeDef typeDef;
				MethodDefUser methodDefUser;
				if (num == 20)
				{
					typeDef.Methods.Add(methodDefUser);
					num = 21;
				}
				if (num == 18)
				{
					methodDefUser.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(moduleDef, ".cctor", MethodSig.CreateInstance(moduleDef.CorLibTypes.Void), typeDef)));
					num = 19;
				}
				if (num == 3)
				{
					goto IL_14D;
				}
				if (num == 17)
				{
					methodDefUser.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
					num = 18;
				}
				if (num == 22)
				{
					goto IL_14D;
				}
				IL_164:
				MethodDefUser methodDefUser2;
				if (num == 12)
				{
					methodDefUser2.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(moduleDef, ".ctor", MethodSig.CreateInstance(moduleDef.CorLibTypes.Void), typeDef)));
					num = 13;
				}
				if (num == 14)
				{
					typeDef.Methods.Add(methodDefUser2);
					num = 15;
				}
				if (num == 19)
				{
					methodDefUser.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
					num = 20;
				}
				if (num == 6)
				{
					moduleDef.Types.Add(typeDef);
					num = 7;
				}
				int num2;
				if (num == 21)
				{
					num2++;
					num = 22;
				}
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				if (num == 8)
				{
					InterfaceImpl item;
					typeDef.Interfaces.Add(item);
					num = 9;
				}
				if (num == 13)
				{
					methodDefUser2.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
					num = 14;
				}
				if (num == 16)
				{
					methodDefUser.Body.MaxStack = 1;
					num = 17;
				}
				if (num == 1)
				{
					InterfaceImpl item = new InterfaceImplUser(moduleDef.GlobalType);
					num = 2;
				}
				if (num == 15)
				{
					methodDefUser = new MethodDefUser(".cctor", MethodSig.CreateInstance(moduleDef.CorLibTypes.Void, moduleDef.CorLibTypes.String), MethodImplAttributes.IL, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName)
					{
						Body = new CilBody()
					};
					num = 16;
				}
				if (num == 11)
				{
					methodDefUser2.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
					num = 12;
				}
				if (num == 7)
				{
					InterfaceImpl item2;
					typeDef.Interfaces.Add(item2);
					num = 8;
				}
				if (num == 5)
				{
					InterfaceImpl item2 = new InterfaceImplUser(typeDef);
					num = 6;
				}
				if (num == 10)
				{
					methodDefUser2.Body.MaxStack = 1;
					num = 11;
				}
				if (num == 9)
				{
					methodDefUser2 = new MethodDefUser(".ctor", MethodSig.CreateInstance(moduleDef.CorLibTypes.Void, moduleDef.CorLibTypes.String), MethodImplAttributes.IL, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName)
					{
						Body = new CilBody()
					};
					num = 10;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 23)
				{
					break;
				}
				continue;
				IL_14D:
				if (num2 >= 1)
				{
					num = 23;
					goto IL_164;
				}
				IL_1F:
				typeDef = new TypeDefUser(null, RUtils.GenerateRandomString2(5), moduleDef.CorLibTypes.GetTypeRef("System", "Attribute"));
				num = 5;
				goto IL_59;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003F60 File Offset: 0x00002160
		public static ModuleWriterOptions Execute(ModuleDef moduleDef)
		{
			short num = 0;
			ModuleWriterOptions moduleWriterOptions;
			do
			{
				Context context;
				if (num == 3)
				{
					moduleWriterOptions = new ModuleWriterOptions(context.ManifestModule);
					num = 4;
				}
				if (num == 1)
				{
					context = new Context(moduleDef);
					num = 2;
				}
				if (num == 2)
				{
					AntiDe4dot.Execute2(context, moduleDef);
					num = 3;
				}
				if (num == 4)
				{
					moduleWriterOptions.Logger = DummyLogger.NoThrowInstance;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			return moduleWriterOptions;
		}
	}
}

using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200006E RID: 110
	internal class Watermark
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00019C64 File Offset: 0x00017E64
		public static void Execute(ModuleDefMD md)
		{
			short num = 0;
			IEnumerator<ModuleDef> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = md.Assembly.Modules.GetEnumerator();
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
					moduleDef.Name = "⨳ R O S E ⨳";
					moduleDef.Assembly.Name = "⨳ R O S E ⨳";
					ModuleDefMD moduleDefMD = (ModuleDefMD)moduleDef;
					TypeRef typeRef = moduleDefMD.CorLibTypes.GetTypeRef("System", "Attribute");
					TypeDefUser typeDefUser = new TypeDefUser("", "ROSE", typeRef);
					MethodDefUser methodDefUser = new MethodDefUser(".ctor", MethodSig.CreateInstance(moduleDefMD.CorLibTypes.Void, moduleDefMD.CorLibTypes.String), MethodImplAttributes.IL, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName)
					{
						Body = new CilBody()
					};
					methodDefUser.Body.MaxStack = 1;
					methodDefUser.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
					methodDefUser.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(moduleDefMD, ".ctor", MethodSig.CreateInstance(moduleDefMD.CorLibTypes.Void), typeRef)));
					methodDefUser.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
					typeDefUser.Methods.Add(methodDefUser);
					MethodDefUser methodDefUser2 = new MethodDefUser(".cctor", MethodSig.CreateInstance(moduleDefMD.CorLibTypes.Void, moduleDefMD.CorLibTypes.String), MethodImplAttributes.IL, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName)
					{
						Body = new CilBody()
					};
					methodDefUser2.Body.MaxStack = 1;
					methodDefUser2.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
					methodDefUser2.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(moduleDefMD, ".cctor", MethodSig.CreateInstance(moduleDefMD.CorLibTypes.Void), typeRef)));
					methodDefUser2.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
					typeDefUser.Methods.Add(methodDefUser2);
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
	}
}

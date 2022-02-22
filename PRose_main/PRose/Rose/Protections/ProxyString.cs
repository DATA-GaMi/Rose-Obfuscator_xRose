using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000057 RID: 87
	internal class ProxyString
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00013A68 File Offset: 0x00011C68
		public static void Execute(ModuleDef module)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = module.GetTypes().GetEnumerator();
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
					if (!typeDef.IsGlobalModuleType)
					{
						foreach (MethodDef methodDef in typeDef.Methods)
						{
							if (methodDef.HasBody)
							{
								IList<Instruction> instructions = methodDef.Body.Instructions;
								foreach (Instruction instruction in instructions)
								{
									if (instruction.OpCode == OpCodes.Ldstr)
									{
										MethodImplAttributes implFlags = MethodImplAttributes.IL;
										MethodAttributes flags = MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static | MethodAttributes.HideBySig;
										MethodDefUser methodDefUser = new MethodDefUser(RUtils.RandomChinese(xd.thelength), MethodSig.CreateStatic(module.CorLibTypes.String), implFlags, flags);
										module.GlobalType.Methods.Add(methodDefUser);
										methodDefUser.Body = new CilBody();
										methodDefUser.Body.Variables.Add(new Local(module.CorLibTypes.String));
										methodDefUser.Body.Instructions.Add(Instruction.Create(OpCodes.Ldstr, instruction.Operand.ToString()));
										methodDefUser.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));
										instruction.OpCode = OpCodes.Call;
										instruction.Operand = methodDefUser;
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
	}
}

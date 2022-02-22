using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200003F RID: 63
	internal class hideStrings
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000EB98 File Offset: 0x0000CD98
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
								for (int i = 0; i < instructions.Count; i++)
								{
									if (instructions[i].OpCode == OpCodes.Ldstr)
									{
										MethodImplAttributes implFlags = MethodImplAttributes.IL;
										MethodAttributes flags = MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static | MethodAttributes.HideBySig;
										MethodDefUser methodDefUser = new MethodDefUser(RUtils.RandomSymbols(xd.thelength), MethodSig.CreateStatic(module.CorLibTypes.String), implFlags, flags);
										module.GlobalType.Methods.Add(methodDefUser);
										methodDefUser.Body = new CilBody();
										methodDefUser.Body.Variables.Add(new Local(module.CorLibTypes.String));
										methodDefUser.Body.Instructions.Add(Instruction.Create(OpCodes.Ldstr, instructions[i].Operand.ToString()));
										methodDefUser.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));
										instructions[i].OpCode = OpCodes.Call;
										instructions[i].Operand = methodDefUser;
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

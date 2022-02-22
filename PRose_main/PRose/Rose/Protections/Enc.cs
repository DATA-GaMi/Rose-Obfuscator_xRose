using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Rose.Helper;

namespace Rose.Protections
{
	// Token: 0x02000067 RID: 103
	public static class Enc
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00018A00 File Offset: 0x00016C00
		private static MethodDef InjectMethod(ModuleDef module, string methodName)
		{
			short num = 0;
			IEnumerator<MethodDef> enumerator;
			MethodDef result;
			do
			{
				TypeDef typeDef;
				if (num == 4)
				{
					ModuleDefMD moduleDefMD;
					typeDef = moduleDefMD.ResolveTypeDef(MDToken.ToRID(typeof(DecryptionHelper).MetadataToken));
					num = 5;
				}
				if (num == 3)
				{
					ModuleDefMD moduleDefMD = ModuleDefMD.Load(typeof(DecryptionHelper).Module);
					num = 4;
				}
				if (num == 7)
				{
					enumerator = module.GlobalType.Methods.GetEnumerator();
					num = 8;
				}
				IEnumerable<IDnlibDef> source;
				if (num == 5)
				{
					source = InjectHelper.Inject(typeDef, module.GlobalType, module);
					num = 6;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 2)
				{
					CS$<>8__locals1.methodName = methodName2;
					num = 3;
				}
				if (num == 6)
				{
					result = (MethodDef)source.Single((IDnlibDef method) => method.Name == CS$<>8__locals1.methodName);
					num = 7;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
			try
			{
				while (enumerator.MoveNext())
				{
					MethodDef methodDef = enumerator.Current;
					if (methodDef.Name == ".ctor")
					{
						module.GlobalType.Remove(methodDef);
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
			return result;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00018C24 File Offset: 0x00016E24
		public static ModuleDef EncryptStrings(ModuleDef inModule)
		{
			short num = 0;
			MethodDef methodDef;
			IEnumerator<TypeDef> enumerator;
			ICrypto crypto;
			do
			{
				if (num == 3)
				{
					methodDef = Enc.InjectMethod(inModule, "qUSxo");
					num = 4;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 4)
				{
					enumerator = inModule.Types.GetEnumerator();
					num = 5;
				}
				if (num == 2)
				{
					crypto = new Base64();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			try
			{
				while (enumerator.MoveNext())
				{
					TypeDef typeDef = enumerator.Current;
					if (!typeDef.IsGlobalModuleType && !(typeDef.Name == "Resources") && !(typeDef.Name == "Settings"))
					{
						foreach (MethodDef methodDef2 in typeDef.Methods)
						{
							if (methodDef2.HasBody && methodDef2 != methodDef)
							{
								methodDef2.Body.KeepOldMaxStack = true;
								for (int i = 0; i < methodDef2.Body.Instructions.Count; i++)
								{
									if (methodDef2.Body.Instructions[i].OpCode == OpCodes.Ldstr)
									{
										string dataPlain = methodDef2.Body.Instructions[i].Operand.ToString();
										methodDef2.Body.Instructions[i].Operand = crypto.Encrypt(dataPlain);
										methodDef2.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, methodDef));
									}
								}
								methodDef2.Body.SimplifyBranches();
								methodDef2.Body.OptimizeBranches();
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
			return inModule;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Rose.Helper;

namespace Rose.Protections
{
	// Token: 0x02000007 RID: 7
	public static class AntiDebug
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000040B0 File Offset: 0x000022B0
		public static void Execute(ModuleDef module)
		{
			short num = 0;
			IEnumerator<MethodDef> enumerator;
			do
			{
				ModuleDefMD moduleDefMD;
				if (num == 1)
				{
					moduleDefMD = ModuleDefMD.Load(typeof(AntiDebugSafe).Module);
					num = 2;
				}
				if (num == 6)
				{
					MethodDef methodDef;
					MethodDef method2;
					methodDef.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, method2));
					num = 7;
				}
				if (num == 5)
				{
					IEnumerable<IDnlibDef> source;
					MethodDef method2 = (MethodDef)source.Single((IDnlibDef method) => method.Name == "xEQAW");
					num = 6;
				}
				if (num == 4)
				{
					TypeDef typeDef;
					IEnumerable<IDnlibDef> source = InjectHelper.Inject(typeDef, module.GlobalType, module);
					num = 5;
				}
				if (num == 3)
				{
					TypeDef typeDef = moduleDefMD.ResolveTypeDef(MDToken.ToRID(typeof(AntiDebugSafe).MetadataToken));
					num = 4;
				}
				if (num == 2)
				{
					MethodDef methodDef = module.GlobalType.FindOrCreateStaticConstructor();
					num = 3;
				}
				if (num == 7)
				{
					enumerator = module.GlobalType.Methods.GetEnumerator();
					num = 8;
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
					MethodDef methodDef2 = enumerator.Current;
					if (!(methodDef2.Name != ".ctor"))
					{
						module.GlobalType.Remove(methodDef2);
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
		}
	}
}

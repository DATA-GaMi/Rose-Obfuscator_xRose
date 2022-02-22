using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Rose.Helper;

namespace Rose.Protections
{
	// Token: 0x02000011 RID: 17
	public static class AntiDumpMethod2
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00007988 File Offset: 0x00005B88
		public static void Execute(ModuleDef module)
		{
			short num = 0;
			IEnumerator<MethodDef> enumerator;
			do
			{
				if (num == 6)
				{
					MethodDef methodDef;
					MethodDef method2;
					methodDef.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, method2));
					num = 7;
				}
				TypeDef typeDef;
				if (num == 3)
				{
					ModuleDefMD moduleDefMD;
					typeDef = moduleDefMD.ResolveTypeDef(MDToken.ToRID(typeof(AntiDump2).MetadataToken));
					num = 4;
				}
				if (num == 2)
				{
					MethodDef methodDef = module.GlobalType.FindOrCreateStaticConstructor();
					num = 3;
				}
				if (num == 1)
				{
					ModuleDefMD moduleDefMD = ModuleDefMD.Load(typeof(AntiDump2).Module);
					num = 2;
				}
				if (num == 5)
				{
					IEnumerable<IDnlibDef> source;
					MethodDef method2 = (MethodDef)source.Single((IDnlibDef method) => method.Name == "WUIOL");
					num = 6;
				}
				if (num == 4)
				{
					IEnumerable<IDnlibDef> source = InjectHelper.Inject(typeDef, module.GlobalType, module);
					num = 5;
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

using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Rose.Helper;

namespace Rose.Protections
{
	// Token: 0x02000013 RID: 19
	public static class AntiDumpMethod3
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00007BDC File Offset: 0x00005DDC
		public static void InjectEraseMethod(ModuleDef module)
		{
			short num = 0;
			IEnumerator<MethodDef> enumerator;
			do
			{
				if (num == 4)
				{
					IEnumerable<IDnlibDef> source;
					AntiDumpMethod3.eraseMethod = (MethodDef)source.Single((IDnlibDef method) => method.Name == "OIURC");
					num = 5;
				}
				ModuleDefMD moduleDefMD;
				if (num == 1)
				{
					moduleDefMD = ModuleDefMD.Load(typeof(HeaderErase).Module);
					num = 2;
				}
				if (num == 6)
				{
					enumerator = module.GlobalType.Methods.GetEnumerator();
					num = 7;
				}
				if (num == 3)
				{
					TypeDef typeDef;
					IEnumerable<IDnlibDef> source = InjectHelper.Inject(typeDef, module.GlobalType, module);
					num = 4;
				}
				if (num == 5)
				{
					AntiDumpMethod3.eraseMethod.Body.Instructions.Insert(AntiDumpMethod3.eraseMethod.Body.Instructions.Count - 2, Instruction.Create(OpCodes.Call, AntiDumpMethod3.eraseMethod));
					num = 6;
				}
				if (num == 2)
				{
					TypeDef typeDef = moduleDefMD.ResolveTypeDef(MDToken.ToRID(typeof(HeaderErase).MetadataToken));
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
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
		}

		// Token: 0x04000015 RID: 21
		private static MethodDef eraseMethod;
	}
}

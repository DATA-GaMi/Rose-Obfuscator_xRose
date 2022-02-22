using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Rose.Helper;

namespace Rose.Protections
{
	// Token: 0x0200000A RID: 10
	public class AntiDebug2
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000048F4 File Offset: 0x00002AF4
		public static void Execute(ModuleDef module)
		{
			short num = 0;
			IEnumerator<MethodDef> enumerator;
			do
			{
				if (num == 5)
				{
					AntiDebug2.debuggerMethod.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, AntiDebug2.debuggerMethod));
					num = 6;
				}
				IEnumerable<IDnlibDef> source;
				if (num == 3)
				{
					TypeDef typeDef;
					source = InjectHelper.Inject(typeDef, module.GlobalType, module);
					num = 4;
				}
				ModuleDefMD moduleDefMD;
				if (num == 1)
				{
					moduleDefMD = ModuleDefMD.Load(typeof(DebugChecker).Module);
					num = 2;
				}
				if (num == 4)
				{
					AntiDebug2.debuggerMethod = (MethodDef)source.Single((IDnlibDef method) => method.Name == "CEKQW");
					num = 5;
				}
				if (num == 2)
				{
					TypeDef typeDef = moduleDefMD.ResolveTypeDef(MDToken.ToRID(typeof(DebugChecker).MetadataToken));
					num = 3;
				}
				if (num == 6)
				{
					enumerator = module.GlobalType.Methods.GetEnumerator();
					num = 7;
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

		// Token: 0x0400000E RID: 14
		private static MethodDef debuggerMethod;
	}
}

using System;
using System.Collections.Generic;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x0200005B RID: 91
	public class MethodsRenaming : IRenaming
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00014930 File Offset: 0x00012B30
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			do
			{
				if (num == 1)
				{
					num = 2;
				}
				if (num == 2)
				{
					enumerator = module.GetTypes().GetEnumerator();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					TypeDef typeDef = enumerator.Current;
					if (!typeDef.IsGlobalModuleType && !(typeDef.Name == "GeneratedInternalTypeHelper"))
					{
						foreach (MethodDef methodDef in typeDef.Methods)
						{
							if (methodDef.HasBody && !(methodDef.Name == ".ctor") && !(methodDef.Name == ".cctor"))
							{
								if (xd.renamertype == "Ascii")
								{
									methodDef.Name = RUtils.GenerateRandomString2(xd.thelength);
								}
								if (xd.renamertype == "Numbers")
								{
									methodDef.Name = RUtils.RandomNum(xd.thelength);
								}
								if (xd.renamertype == "Symbols")
								{
									methodDef.Name = RUtils.RandomSymbols(xd.thelength);
								}
								if (xd.renamertype == "Chinese")
								{
									methodDef.Name = RUtils.RandomChinese(xd.thelength);
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
			return module;
		}
	}
}

using System;
using System.Collections.Generic;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x0200005E RID: 94
	public class PropertiesRenaming : IRenaming
	{
		// Token: 0x06000126 RID: 294 RVA: 0x000154FC File Offset: 0x000136FC
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			do
			{
				if (num == 2)
				{
					enumerator = module.GetTypes().GetEnumerator();
					num = 3;
				}
				if (num == 1)
				{
					num = 2;
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
					if (!typeDef.IsGlobalModuleType)
					{
						foreach (PropertyDef propertyDef in typeDef.Properties)
						{
							if (xd.renamertype == "Ascii")
							{
								propertyDef.Name = RUtils.GenerateRandomString2(xd.thelength);
							}
							if (xd.renamertype == "Numbers")
							{
								propertyDef.Name = RUtils.RandomNum(xd.thelength);
							}
							if (xd.renamertype == "Symbols")
							{
								propertyDef.Name = RUtils.RandomSymbols(xd.thelength);
							}
							if (xd.renamertype == "Chinese")
							{
								propertyDef.Name = RUtils.RandomChinese(xd.thelength);
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

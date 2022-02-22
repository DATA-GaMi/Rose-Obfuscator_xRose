using System;
using System.Collections.Generic;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x02000061 RID: 97
	internal static class RenamerObfuscation
	{
		// Token: 0x06000137 RID: 311 RVA: 0x000162A8 File Offset: 0x000144A8
		public static void Execute(ModuleDef module)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = module.Types.GetEnumerator();
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
					if (!typeDef.IsGlobalModuleType && !typeDef.IsRuntimeSpecialName && !typeDef.IsSpecialName && !typeDef.IsWindowsRuntime && !typeDef.IsInterface)
					{
						if (xd.renamertype == "Ascii")
						{
							typeDef.Name = RUtils.GenerateRandomString2(xd.thelength);
							typeDef.Namespace = RUtils.GenerateRandomString2(xd.thelength);
							foreach (PropertyDef propertyDef in typeDef.Properties)
							{
								propertyDef.Name = RUtils.GenerateRandomString2(xd.thelength);
							}
							foreach (FieldDef fieldDef in typeDef.Fields)
							{
								fieldDef.Name = RUtils.GenerateRandomString2(xd.thelength);
							}
							foreach (EventDef eventDef in typeDef.Events)
							{
								eventDef.Name = RUtils.GenerateRandomString2(xd.thelength);
							}
							foreach (MethodDef methodDef in typeDef.Methods)
							{
								if (!methodDef.Name.ToLower().Contains("main") && !methodDef.IsConstructor)
								{
									methodDef.Name = RUtils.GenerateRandomString2(xd.thelength);
								}
							}
						}
						if (xd.renamertype == "Numbers")
						{
							typeDef.Name = RUtils.RandomNum(xd.thelength);
							typeDef.Namespace = RUtils.RandomNum(xd.thelength);
							foreach (PropertyDef propertyDef2 in typeDef.Properties)
							{
								propertyDef2.Name = RUtils.RandomNum(xd.thelength);
							}
							foreach (FieldDef fieldDef2 in typeDef.Fields)
							{
								fieldDef2.Name = RUtils.RandomNum(xd.thelength);
							}
							foreach (EventDef eventDef2 in typeDef.Events)
							{
								eventDef2.Name = RUtils.RandomNum(xd.thelength);
							}
							foreach (MethodDef methodDef2 in typeDef.Methods)
							{
								if (!methodDef2.Name.ToLower().Contains("main") && !methodDef2.IsConstructor)
								{
									methodDef2.Name = RUtils.RandomNum(xd.thelength);
								}
							}
						}
						if (xd.renamertype == "Symbols")
						{
							typeDef.Name = RUtils.RandomSymbols(xd.thelength);
							typeDef.Namespace = RUtils.RandomSymbols(xd.thelength);
							foreach (PropertyDef propertyDef3 in typeDef.Properties)
							{
								propertyDef3.Name = RUtils.RandomSymbols(xd.thelength);
							}
							foreach (FieldDef fieldDef3 in typeDef.Fields)
							{
								fieldDef3.Name = RUtils.RandomSymbols(xd.thelength);
							}
							foreach (EventDef eventDef3 in typeDef.Events)
							{
								eventDef3.Name = RUtils.RandomSymbols(xd.thelength);
							}
							foreach (MethodDef methodDef3 in typeDef.Methods)
							{
								if (!methodDef3.Name.ToLower().Contains("main") && !methodDef3.IsConstructor)
								{
									methodDef3.Name = RUtils.RandomSymbols(xd.thelength);
								}
							}
						}
						if (xd.renamertype == "Chinese")
						{
							typeDef.Name = RUtils.RandomChinese(xd.thelength);
							typeDef.Namespace = RUtils.RandomChinese(xd.thelength);
							foreach (PropertyDef propertyDef4 in typeDef.Properties)
							{
								propertyDef4.Name = RUtils.RandomChinese(xd.thelength);
							}
							foreach (FieldDef fieldDef4 in typeDef.Fields)
							{
								fieldDef4.Name = RUtils.RandomChinese(xd.thelength);
							}
							foreach (EventDef eventDef4 in typeDef.Events)
							{
								eventDef4.Name = RUtils.RandomChinese(xd.thelength);
							}
							foreach (MethodDef methodDef4 in typeDef.Methods)
							{
								if (!methodDef4.Name.ToLower().Contains("main") && !methodDef4.IsConstructor)
								{
									methodDef4.Name = RUtils.RandomChinese(xd.thelength);
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

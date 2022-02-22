using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200005C RID: 92
	public class NamespacesRenaming : IRenaming
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00014BA0 File Offset: 0x00012DA0
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
					if (!typeDef.IsGlobalModuleType && !(typeDef.Namespace == ""))
					{
						string text;
						if (NamespacesRenaming._names.TryGetValue(typeDef.Namespace, out text) && xd.renamertype == "Ascii")
						{
							typeDef.Namespace = RUtils.GenerateRandomString2(xd.thelength);
						}
						if (xd.renamertype == "Numbers")
						{
							typeDef.Namespace = RUtils.RandomNum(xd.thelength);
						}
						if (xd.renamertype == "Symbols")
						{
							typeDef.Namespace = RUtils.RandomSymbols(xd.thelength);
						}
						if (xd.renamertype == "Chinese")
						{
							typeDef.Namespace = RUtils.RandomChinese(xd.thelength);
						}
						else
						{
							if (xd.renamertype == "Ascii")
							{
								string value = RUtils.GenerateRandomString2(xd.thelength);
								NamespacesRenaming._names.Add(typeDef.Namespace, value);
								typeDef.Namespace = RUtils.GenerateRandomString2(xd.thelength);
							}
							if (xd.renamertype == "Numbers")
							{
								string value2 = RUtils.RandomNum(xd.thelength);
								NamespacesRenaming._names.Add(typeDef.Namespace, value2);
								typeDef.Namespace = RUtils.RandomNum(xd.thelength);
							}
							if (xd.renamertype == "Symbols")
							{
								string value3 = RUtils.RandomSymbols(xd.thelength);
								NamespacesRenaming._names.Add(typeDef.Namespace, value3);
								typeDef.Namespace = RUtils.RandomSymbols(xd.thelength);
							}
							if (xd.renamertype == "Chinese")
							{
								string value4 = RUtils.RandomChinese(xd.thelength);
								NamespacesRenaming._names.Add(typeDef.Namespace, value4);
								typeDef.Namespace = RUtils.RandomChinese(xd.thelength);
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
			return NamespacesRenaming.ApplyChangesToResources(module);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00014EF0 File Offset: 0x000130F0
		private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
		{
			short num = 0;
			IEnumerator<Resource> enumerator;
			do
			{
				if (num == 1)
				{
					num = 2;
				}
				if (num == 2)
				{
					enumerator = module.Resources.GetEnumerator();
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
					Resource resource = enumerator.Current;
					foreach (KeyValuePair<string, string> keyValuePair in NamespacesRenaming._names)
					{
						if (resource.Name.Contains(keyValuePair.Key))
						{
							resource.Name = resource.Name.Replace(keyValuePair.Key, keyValuePair.Value);
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
			foreach (TypeDef typeDef in module.GetTypes())
			{
				foreach (PropertyDef propertyDef in typeDef.Properties)
				{
					if (!(propertyDef.Name != "ResourceManager"))
					{
						IList<Instruction> instructions = propertyDef.GetMethod.Body.Instructions;
						for (int i = 0; i < instructions.Count; i++)
						{
							if (instructions[i].OpCode == OpCodes.Ldstr)
							{
								foreach (KeyValuePair<string, string> keyValuePair2 in NamespacesRenaming._names)
								{
									if (instructions[i].ToString().Contains(keyValuePair2.Key))
									{
										instructions[i].Operand = instructions[i].Operand.ToString().Replace(keyValuePair2.Key, keyValuePair2.Value);
									}
								}
							}
						}
					}
				}
			}
			return module;
		}

		// Token: 0x04000067 RID: 103
		private static Dictionary<string, string> _names = new Dictionary<string, string>();
	}
}

using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000058 RID: 88
	public class ClassesRenaming : IRenaming
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00013D30 File Offset: 0x00011F30
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
					if (!typeDef.IsGlobalModuleType && !(typeDef.Name == "GeneratedInternalTypeHelper") && !(typeDef.Name == "Resources") && !(typeDef.Name == "Settings"))
					{
						string s;
						if (ClassesRenaming._names.TryGetValue(typeDef.Name, out s))
						{
							typeDef.Name = s;
						}
						else
						{
							if (xd.renamertype == "Ascii")
							{
								string value = RUtils.GenerateRandomString2(xd.thelength);
								ClassesRenaming._names.Add(typeDef.Name, value);
								typeDef.Name = RUtils.GenerateRandomString2(xd.thelength);
							}
							if (xd.renamertype == "Numbers")
							{
								string value2 = RUtils.RandomNum(xd.thelength);
								ClassesRenaming._names.Add(typeDef.Name, value2);
								typeDef.Name = RUtils.RandomNum(xd.thelength);
							}
							if (xd.renamertype == "Symbols")
							{
								string value3 = RUtils.RandomSymbols(xd.thelength);
								ClassesRenaming._names.Add(typeDef.Name, value3);
								typeDef.Name = RUtils.RandomSymbols(xd.thelength);
							}
							if (xd.renamertype == "Chinese")
							{
								string value4 = RUtils.RandomChinese(xd.thelength);
								ClassesRenaming._names.Add(typeDef.Name, value4);
								typeDef.Name = RUtils.RandomChinese(xd.thelength);
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
			return ClassesRenaming.ApplyChangesToResources(module);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00014014 File Offset: 0x00012214
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
					foreach (KeyValuePair<string, string> keyValuePair in ClassesRenaming._names)
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
								foreach (KeyValuePair<string, string> keyValuePair2 in ClassesRenaming._names)
								{
									if (instructions[i].Operand.ToString().Contains(keyValuePair2.Key))
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

		// Token: 0x04000065 RID: 101
		private static Dictionary<string, string> _names = new Dictionary<string, string>();
	}
}

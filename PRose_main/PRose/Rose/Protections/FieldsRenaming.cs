using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000059 RID: 89
	public class FieldsRenaming : IRenaming
	{
		// Token: 0x06000119 RID: 281 RVA: 0x000143B0 File Offset: 0x000125B0
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
						foreach (FieldDef fieldDef in typeDef.Fields)
						{
							string s;
							if (FieldsRenaming._names.TryGetValue(fieldDef.Name, out s))
							{
								fieldDef.Name = s;
							}
							else
							{
								if (xd.renamertype == "Ascii")
								{
									string value = RUtils.GenerateRandomString2(xd.thelength);
									FieldsRenaming._names.Add(fieldDef.Name, value);
									fieldDef.Name = RUtils.GenerateRandomString2(xd.thelength);
								}
								if (xd.renamertype == "Numbers")
								{
									string value2 = RUtils.RandomNum(xd.thelength);
									FieldsRenaming._names.Add(fieldDef.Name, value2);
									fieldDef.Name = RUtils.RandomNum(xd.thelength);
								}
								if (xd.renamertype == "Symbols")
								{
									string value3 = RUtils.RandomSymbols(xd.thelength);
									FieldsRenaming._names.Add(fieldDef.Name, value3);
									fieldDef.Name = RUtils.RandomSymbols(xd.thelength);
								}
								if (xd.renamertype == "Chinese")
								{
									string value4 = RUtils.RandomChinese(xd.thelength);
									FieldsRenaming._names.Add(fieldDef.Name, value4);
									fieldDef.Name = RUtils.RandomChinese(xd.thelength);
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
			return FieldsRenaming.ApplyChangesToResources(module);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000146AC File Offset: 0x000128AC
		private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
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
						foreach (MethodDef methodDef in typeDef.Methods)
						{
							if (!(methodDef.Name != "InitializeComponent"))
							{
								IList<Instruction> instructions = methodDef.Body.Instructions;
								for (int i = 0; i < instructions.Count - 3; i++)
								{
									if (instructions[i].OpCode == OpCodes.Ldstr)
									{
										foreach (KeyValuePair<string, string> keyValuePair in FieldsRenaming._names)
										{
											if (keyValuePair.Key == instructions[i].Operand.ToString())
											{
												instructions[i].Operand = keyValuePair.Value;
											}
										}
									}
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

		// Token: 0x04000066 RID: 102
		private static Dictionary<string, string> _names = new Dictionary<string, string>();
	}
}

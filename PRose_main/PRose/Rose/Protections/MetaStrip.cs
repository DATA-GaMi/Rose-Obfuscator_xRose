using System;
using System.Collections.Generic;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x02000045 RID: 69
	internal class MetaStrip
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x0000F864 File Offset: 0x0000DA64
		public static bool CanRename(object obj)
		{
			short num = 0;
			iAnalyze iAnalyze;
			for (;;)
			{
				if (num == 7)
				{
					goto IL_1E7;
				}
				if (num == 5)
				{
					goto IL_3E;
				}
				goto IL_55;
				IL_178:
				if (num == 14)
				{
					break;
				}
				if (num == 1)
				{
					iAnalyze = null;
					num = 2;
				}
				if (num == 10)
				{
					goto IL_1E7;
				}
				if (num == 13)
				{
					goto IL_1E7;
				}
				goto IL_1F9;
				IL_BF:
				if (num == 3)
				{
					iAnalyze = new TypeDefAnalyzer();
					num = 4;
				}
				if (num == 9)
				{
					iAnalyze = new EventDefAnalyzer();
					num = 10;
				}
				if (num == 2)
				{
					if (!(obj is TypeDef))
					{
						goto IL_3E;
					}
					num = 3;
				}
				if (num == 6)
				{
					iAnalyze = new MethodDefAnalyzer();
					num = 7;
				}
				if (num == 8)
				{
					goto IL_161;
				}
				goto IL_178;
				IL_55:
				if (num == 12)
				{
					iAnalyze = new FieldDefAnalyzer();
					num = 13;
				}
				if (num == 4)
				{
					goto IL_1E7;
				}
				if (num != 11)
				{
					goto IL_BF;
				}
				IL_A8:
				if (obj is FieldDef)
				{
					num = 12;
					goto IL_BF;
				}
				goto IL_1E7;
				IL_3E:
				if (obj is MethodDef)
				{
					num = 6;
					goto IL_55;
				}
				IL_161:
				if (obj is EventDef)
				{
					num = 9;
					goto IL_178;
				}
				goto IL_A8;
				IL_1F9:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 15)
				{
					goto Block_17;
				}
				continue;
				IL_1E7:
				if (iAnalyze == null)
				{
					num = 14;
					goto IL_1F9;
				}
				goto IL_22F;
			}
			return false;
			Block_17:
			IL_22F:
			return iAnalyze.Execute(obj);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		public static void Execute(ModuleDefMD module)
		{
			short num = 0;
			IEnumerator<CustomAttribute> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = module.Assembly.CustomAttributes.GetEnumerator();
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
					CustomAttribute customAttribute = enumerator.Current;
					if (MetaStrip.CanRename(customAttribute))
					{
						module.Assembly.CustomAttributes.Remove(customAttribute);
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
			module.Mvid = null;
			module.Name = null;
			foreach (TypeDef typeDef in module.Types)
			{
				foreach (CustomAttribute customAttribute2 in typeDef.CustomAttributes)
				{
					if (MetaStrip.CanRename(customAttribute2))
					{
						typeDef.CustomAttributes.Remove(customAttribute2);
					}
				}
				foreach (MethodDef methodDef in typeDef.Methods)
				{
					foreach (CustomAttribute customAttribute3 in methodDef.CustomAttributes)
					{
						if (MetaStrip.CanRename(customAttribute3))
						{
							methodDef.CustomAttributes.Remove(customAttribute3);
						}
					}
				}
				foreach (PropertyDef propertyDef in typeDef.Properties)
				{
					foreach (CustomAttribute customAttribute4 in propertyDef.CustomAttributes)
					{
						if (MetaStrip.CanRename(customAttribute4))
						{
							propertyDef.CustomAttributes.Remove(customAttribute4);
						}
					}
				}
				foreach (FieldDef fieldDef in typeDef.Fields)
				{
					foreach (CustomAttribute customAttribute5 in fieldDef.CustomAttributes)
					{
						if (MetaStrip.CanRename(customAttribute5))
						{
							fieldDef.CustomAttributes.Remove(customAttribute5);
						}
					}
				}
				foreach (EventDef eventDef in typeDef.Events)
				{
					foreach (CustomAttribute customAttribute6 in eventDef.CustomAttributes)
					{
						if (MetaStrip.CanRename(customAttribute6))
						{
							eventDef.CustomAttributes.Remove(customAttribute6);
						}
					}
				}
			}
		}
	}
}

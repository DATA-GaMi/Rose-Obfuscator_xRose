using System;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x02000043 RID: 67
	public class FieldDefAnalyzer : iAnalyze
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x0000F75C File Offset: 0x0000D95C
		public override bool Execute(object context)
		{
			short num = 0;
			while (num != 3)
			{
				FieldDef fieldDef;
				if (num == 2)
				{
					if (!fieldDef.IsRuntimeSpecialName)
					{
						goto IL_8E;
					}
					num = 3;
				}
				if (num == 1)
				{
					fieldDef = (FieldDef)context;
					num = 2;
				}
				if (num != 4)
				{
					if (num == 0)
					{
						num = 1;
					}
					if (num == 5)
					{
						return true;
					}
					continue;
				}
				IL_8E:
				if (fieldDef.IsLiteral && fieldDef.DeclaringType.IsEnum)
				{
					return false;
				}
				return true;
			}
			return false;
		}
	}
}

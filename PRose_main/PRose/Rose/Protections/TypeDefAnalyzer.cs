using System;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x02000047 RID: 71
	public class TypeDefAnalyzer : iAnalyze
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00010140 File Offset: 0x0000E340
		public override bool Execute(object context)
		{
			short num = 0;
			TypeDef typeDef;
			for (;;)
			{
				if (num == 2)
				{
					if (!typeDef.IsRuntimeSpecialName)
					{
						goto IL_8E;
					}
					num = 3;
				}
				if (num == 3)
				{
					break;
				}
				if (num == 1)
				{
					typeDef = (TypeDef)context;
					num = 2;
				}
				if (num == 4)
				{
					goto IL_8E;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					return true;
				}
			}
			return false;
			IL_8E:
			if (typeDef.IsGlobalModuleType)
			{
				return false;
			}
			return true;
		}
	}
}

using System;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x02000042 RID: 66
	public class EventDefAnalyzer : iAnalyze
	{
		// Token: 0x060000CF RID: 207 RVA: 0x0000F694 File Offset: 0x0000D894
		public override bool Execute(object context)
		{
			short num = 0;
			while (num != 3)
			{
				if (num == 2)
				{
					EventDef eventDef;
					if (!eventDef.IsRuntimeSpecialName)
					{
						return true;
					}
					num = 3;
				}
				if (num == 1)
				{
					EventDef eventDef = (EventDef)context;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 4)
				{
					continue;
				}
				return true;
			}
			return false;
		}
	}
}

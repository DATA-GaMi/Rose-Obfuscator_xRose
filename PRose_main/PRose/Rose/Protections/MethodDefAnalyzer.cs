using System;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x02000046 RID: 70
	public class MethodDefAnalyzer : iAnalyze
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00010048 File Offset: 0x0000E248
		public override bool Execute(object context)
		{
			short num = 0;
			while (num != 3)
			{
				MethodDef methodDef;
				if (num != 4)
				{
					if (num == 1)
					{
						methodDef = (MethodDef)context;
						num = 2;
					}
					if (num == 2)
					{
						if (!methodDef.IsRuntimeSpecialName)
						{
							goto IL_3F;
						}
						num = 3;
					}
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
				IL_3F:
				if (methodDef.DeclaringType.IsForwarder)
				{
					return false;
				}
				return true;
			}
			return false;
		}
	}
}

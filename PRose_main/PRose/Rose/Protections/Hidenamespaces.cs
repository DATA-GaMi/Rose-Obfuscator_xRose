using System;
using System.Collections.Generic;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x0200003E RID: 62
	public static class Hidenamespaces
	{
		// Token: 0x060000CA RID: 202 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		public static void Execute(ModuleDefMD md)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = md.Types.GetEnumerator();
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
					typeDef.Namespace = "";
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

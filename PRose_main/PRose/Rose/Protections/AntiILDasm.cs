using System;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x02000019 RID: 25
	public class AntiILDasm
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00008428 File Offset: 0x00006628
		public static void Execute(ModuleDefMD module)
		{
			short num = 0;
			do
			{
				TypeRef typeRef;
				if (num == 1)
				{
					typeRef = module.CorLibTypes.GetTypeRef("System.Runtime.CompilerServices", "SuppressIldasmAttribute");
					num = 2;
				}
				if (num == 4)
				{
					CustomAttribute item;
					module.CustomAttributes.Add(item);
					num = 5;
				}
				MemberRefUser ctor;
				if (num == 2)
				{
					ctor = new MemberRefUser(module, ".ctor", MethodSig.CreateInstance(module.CorLibTypes.Void), typeRef);
					num = 3;
				}
				if (num == 3)
				{
					CustomAttribute item = new CustomAttribute(ctor);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}
	}
}

using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200001E RID: 30
	public class Add : iFunction
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000021F7 File Offset: 0x000003F7
		public override ArithmeticTypes ArithmeticTypes
		{
			get
			{
				return ArithmeticTypes.Add;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00009D98 File Offset: 0x00007F98
		public override ArithmeticVT Arithmetic(Instruction instruction, ModuleDef module)
		{
			short num = 0;
			for (;;)
			{
				if (num == 1)
				{
					if (ArithmeticUtils.CheckArithmetic(instruction))
					{
						goto IL_88;
					}
					num = 2;
				}
				if (num == 2)
				{
					break;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					goto Block_5;
				}
			}
			return null;
			Block_5:
			IL_88:
			ArithmeticEmulator arithmeticEmulator = new ArithmeticEmulator((double)instruction.GetLdcI4Value(), ArithmeticUtils.GetY((double)instruction.GetLdcI4Value()), this.ArithmeticTypes);
			return new ArithmeticVT(new Value(arithmeticEmulator.GetValue(), arithmeticEmulator.GetY()), new Token(OpCodes.Add), this.ArithmeticTypes);
		}
	}
}

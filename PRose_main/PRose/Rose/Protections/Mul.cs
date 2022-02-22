using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200002C RID: 44
	public class Mul : iFunction
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002231 File Offset: 0x00000431
		public override ArithmeticTypes ArithmeticTypes
		{
			get
			{
				return ArithmeticTypes.Mul;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000A1E0 File Offset: 0x000083E0
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
			return new ArithmeticVT(new Value(arithmeticEmulator.GetValue(), arithmeticEmulator.GetY()), new Token(OpCodes.Mul), this.ArithmeticTypes);
		}
	}
}

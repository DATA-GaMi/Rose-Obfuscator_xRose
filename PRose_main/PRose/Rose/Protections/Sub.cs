using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200002D RID: 45
	public class Sub : iFunction
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002234 File Offset: 0x00000434
		public override ArithmeticTypes ArithmeticTypes
		{
			get
			{
				return ArithmeticTypes.Sub;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000A2D0 File Offset: 0x000084D0
		public override ArithmeticVT Arithmetic(Instruction instruction, ModuleDef module)
		{
			short num = 0;
			while (num != 2)
			{
				if (num == 1)
				{
					if (ArithmeticUtils.CheckArithmetic(instruction))
					{
						goto IL_88;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 3)
				{
					continue;
				}
				IL_88:
				ArithmeticEmulator arithmeticEmulator = new ArithmeticEmulator((double)instruction.GetLdcI4Value(), ArithmeticUtils.GetY((double)instruction.GetLdcI4Value()), this.ArithmeticTypes);
				return new ArithmeticVT(new Value(arithmeticEmulator.GetValue(), arithmeticEmulator.GetY()), new Token(OpCodes.Sub), this.ArithmeticTypes);
			}
			return null;
		}
	}
}

using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200001F RID: 31
	public class Div : iFunction
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002202 File Offset: 0x00000402
		public override ArithmeticTypes ArithmeticTypes
		{
			get
			{
				return ArithmeticTypes.Div;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00009E88 File Offset: 0x00008088
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
			return new ArithmeticVT(new Value(arithmeticEmulator.GetValue(), arithmeticEmulator.GetY()), new Token(OpCodes.Div), this.ArithmeticTypes);
		}
	}
}

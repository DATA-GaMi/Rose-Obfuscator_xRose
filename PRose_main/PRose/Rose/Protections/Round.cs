using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000026 RID: 38
	public class Round : iFunction
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000221A File Offset: 0x0000041A
		public override ArithmeticTypes ArithmeticTypes
		{
			get
			{
				return ArithmeticTypes.Round;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00009F78 File Offset: 0x00008178
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
				List<ArithmeticTypes> arithmetics = new List<ArithmeticTypes>
				{
					ArithmeticTypes.Add,
					ArithmeticTypes.Sub
				};
				ArithmeticEmulator arithmeticEmulator = new ArithmeticEmulator((double)instruction.GetLdcI4Value(), ArithmeticUtils.GetY((double)instruction.GetLdcI4Value()), this.ArithmeticTypes);
				return new ArithmeticVT(new Value(arithmeticEmulator.GetValue(arithmetics), arithmeticEmulator.GetY()), new Token(ArithmeticUtils.GetOpCode(arithmeticEmulator.GetType), module.Import(ArithmeticUtils.GetMethod(this.ArithmeticTypes))), this.ArithmeticTypes);
			}
			return null;
		}
	}
}

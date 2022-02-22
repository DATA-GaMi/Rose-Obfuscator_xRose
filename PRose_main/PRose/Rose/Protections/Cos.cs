using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000022 RID: 34
	public class Cos : iFunction
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000220C File Offset: 0x0000040C
		public override ArithmeticTypes ArithmeticTypes
		{
			get
			{
				return ArithmeticTypes.Cos;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000A0AC File Offset: 0x000082AC
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
			List<ArithmeticTypes> arithmetics = new List<ArithmeticTypes>
			{
				ArithmeticTypes.Add,
				ArithmeticTypes.Sub
			};
			ArithmeticEmulator arithmeticEmulator = new ArithmeticEmulator((double)instruction.GetLdcI4Value(), ArithmeticUtils.GetY((double)instruction.GetLdcI4Value()), this.ArithmeticTypes);
			return new ArithmeticVT(new Value(arithmeticEmulator.GetValue(arithmetics), arithmeticEmulator.GetY()), new Token(ArithmeticUtils.GetOpCode(arithmeticEmulator.GetType), module.Import(ArithmeticUtils.GetMethod(this.ArithmeticTypes))), this.ArithmeticTypes);
		}
	}
}

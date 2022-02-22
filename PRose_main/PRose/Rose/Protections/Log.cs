using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000024 RID: 36
	public class Log : iFunction
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002214 File Offset: 0x00000414
		public override ArithmeticTypes ArithmeticTypes
		{
			get
			{
				return ArithmeticTypes.Log;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00009F78 File Offset: 0x00008178
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

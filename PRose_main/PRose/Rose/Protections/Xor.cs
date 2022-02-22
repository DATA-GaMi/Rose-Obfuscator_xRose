using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x0200002E RID: 46
	public class Xor : iFunction
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002237 File Offset: 0x00000437
		public override ArithmeticTypes ArithmeticTypes
		{
			get
			{
				return ArithmeticTypes.Xor;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000A3C0 File Offset: 0x000085C0
		public override ArithmeticVT Arithmetic(Instruction instruction, ModuleDef module)
		{
			short num = 0;
			Generator generator;
			for (;;)
			{
				if (num == 1)
				{
					generator = new Generator();
					num = 2;
				}
				if (num == 2)
				{
					if (ArithmeticUtils.CheckArithmetic(instruction))
					{
						goto IL_AB;
					}
					num = 3;
				}
				if (num == 3)
				{
					break;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 4)
				{
					goto Block_6;
				}
			}
			return null;
			Block_6:
			IL_AB:
			ArithmeticEmulator arithmeticEmulator = new ArithmeticEmulator((double)instruction.GetLdcI4Value(), (double)generator.Next(), this.ArithmeticTypes);
			return new ArithmeticVT(new Value(arithmeticEmulator.GetValue(), arithmeticEmulator.GetY()), new Token(OpCodes.Xor), this.ArithmeticTypes);
		}
	}
}

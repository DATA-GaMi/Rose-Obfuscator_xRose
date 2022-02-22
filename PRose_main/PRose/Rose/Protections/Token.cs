using System;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000031 RID: 49
	public class Token
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0000223A File Offset: 0x0000043A
		public Token(OpCode opCode, object Operand)
		{
			this.opCode = opCode;
			this.Operand = Operand;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002250 File Offset: 0x00000450
		public Token(OpCode opCode)
		{
			this.opCode = opCode;
			this.Operand = null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000A634 File Offset: 0x00008834
		public OpCode GetOpCode()
		{
			short num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return this.opCode;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000A690 File Offset: 0x00008890
		public object GetOperand()
		{
			short num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return this.Operand;
		}

		// Token: 0x04000036 RID: 54
		private readonly OpCode opCode;

		// Token: 0x04000037 RID: 55
		private readonly object Operand;
	}
}

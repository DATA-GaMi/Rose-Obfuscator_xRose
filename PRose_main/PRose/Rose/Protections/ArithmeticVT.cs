using System;

namespace Rose.Protections
{
	// Token: 0x0200001D RID: 29
	public class ArithmeticVT
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000021DA File Offset: 0x000003DA
		public ArithmeticVT(Value value, Token token, ArithmeticTypes arithmeticTypes)
		{
			this.value = value;
			this.token = token;
			this.arithmeticTypes = arithmeticTypes;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00009C84 File Offset: 0x00007E84
		public Value GetValue()
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
			return this.value;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00009CE0 File Offset: 0x00007EE0
		public Token GetToken()
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
			return this.token;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00009D3C File Offset: 0x00007F3C
		public ArithmeticTypes GetArithmetic()
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
			return this.arithmeticTypes;
		}

		// Token: 0x04000032 RID: 50
		private readonly Value value;

		// Token: 0x04000033 RID: 51
		private readonly Token token;

		// Token: 0x04000034 RID: 52
		private readonly ArithmeticTypes arithmeticTypes;
	}
}

using System;

namespace Rose.Protections
{
	// Token: 0x02000033 RID: 51
	public class Value
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00002266 File Offset: 0x00000466
		public Value(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000AD68 File Offset: 0x00008F68
		public double GetX()
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
			return this.x;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		public double GetY()
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
			return this.y;
		}

		// Token: 0x04000038 RID: 56
		private readonly double x;

		// Token: 0x04000039 RID: 57
		private readonly double y;
	}
}

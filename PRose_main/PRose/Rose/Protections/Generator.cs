using System;

namespace Rose.Protections
{
	// Token: 0x0200002F RID: 47
	public class Generator
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0000A4D0 File Offset: 0x000086D0
		public Generator()
		{
			this.random = new Random(Guid.NewGuid().GetHashCode());
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000A504 File Offset: 0x00008704
		public int Next()
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
			return this.random.Next(int.MaxValue);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000A568 File Offset: 0x00008768
		public int Next(int value)
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
			return this.random.Next(value);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000A5CC File Offset: 0x000087CC
		public int Next(int min, int max)
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
			return this.random.Next(min, max);
		}

		// Token: 0x04000035 RID: 53
		private readonly Random random;
	}
}

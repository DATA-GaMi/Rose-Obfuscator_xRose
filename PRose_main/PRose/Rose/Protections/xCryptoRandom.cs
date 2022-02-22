using System;
using System.Security.Cryptography;

namespace Rose.Protections
{
	// Token: 0x0200006C RID: 108
	public sealed class xCryptoRandom : Random, IDisposable
	{
		// Token: 0x06000151 RID: 337 RVA: 0x000024C3 File Offset: 0x000006C3
		public xCryptoRandom()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000024C3 File Offset: 0x000006C3
		public xCryptoRandom(int seedIgnored)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00019490 File Offset: 0x00017690
		public override int Next()
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					this.cryptoProvider.GetBytes(this.uint32Buffer);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			return BitConverter.ToInt32(this.uint32Buffer, 0) & int.MaxValue;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0001952C File Offset: 0x0001772C
		public override int Next(int maxValue)
		{
			short num = 0;
			for (;;)
			{
				if (num == 1)
				{
					if (maxValue >= 0)
					{
						goto IL_91;
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
			throw new ArgumentOutOfRangeException("maxValue");
			Block_5:
			IL_91:
			return this.Next(0, maxValue);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000195DC File Offset: 0x000177DC
		public override int Next(int minValue, int maxValue)
		{
			short num = 0;
			for (;;)
			{
				if (num != 1)
				{
					goto IL_35;
				}
				if (minValue > maxValue)
				{
					num = 2;
					goto IL_35;
				}
				goto IL_6B;
				IL_81:
				if (num == 4)
				{
					return minValue;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					goto Block_7;
				}
				continue;
				IL_35:
				if (num == 2)
				{
					break;
				}
				if (num != 3)
				{
					goto IL_81;
				}
				IL_6B:
				if (minValue == maxValue)
				{
					num = 4;
					goto IL_81;
				}
				goto IL_D6;
			}
			throw new ArgumentOutOfRangeException("minValue");
			Block_7:
			IL_D6:
			long num2 = (long)(maxValue - minValue);
			long num3 = 4294967296L;
			long num4 = num3 % num2;
			uint num5;
			do
			{
				this.cryptoProvider.GetBytes(this.uint32Buffer);
				num5 = BitConverter.ToUInt32(this.uint32Buffer, 0);
			}
			while ((ulong)num5 >= (ulong)(num3 - num4));
			return (int)((long)minValue + (long)((ulong)num5 % (ulong)num2));
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0001973C File Offset: 0x0001793C
		public override double NextDouble()
		{
			short num = 0;
			uint num2;
			do
			{
				if (num == 1)
				{
					this.cryptoProvider.GetBytes(this.uint32Buffer);
					num = 2;
				}
				if (num == 2)
				{
					num2 = BitConverter.ToUInt32(this.uint32Buffer, 0);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			return num2 / 4294967296.0;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00019800 File Offset: 0x00017A00
		public override void NextBytes(byte[] buffer)
		{
			short num = 0;
			for (;;)
			{
				if (num != 1)
				{
					goto IL_31;
				}
				if (buffer == null)
				{
					num = 2;
					goto IL_31;
				}
				goto IL_67;
				IL_82:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 4)
				{
					return;
				}
				continue;
				IL_31:
				if (num == 2)
				{
					break;
				}
				if (num != 3)
				{
					goto IL_82;
				}
				IL_67:
				this.cryptoProvider.GetBytes(buffer);
				num = 4;
				goto IL_82;
			}
			throw new ArgumentNullException("buffer");
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000198C8 File Offset: 0x00017AC8
		public void Dispose()
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					this.InternalDispose();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0001993C File Offset: 0x00017B3C
		protected override void Finalize()
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
			try
			{
				this.InternalDispose();
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000199B8 File Offset: 0x00017BB8
		private void InternalDispose()
		{
			short num = 0;
			do
			{
				if (num == 3)
				{
					this.cryptoProvider = null;
					num = 4;
				}
				if (num == 1)
				{
					if (this.cryptoProvider == null)
					{
						break;
					}
					num = 2;
				}
				if (num == 2)
				{
					this.cryptoProvider.Dispose();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x04000076 RID: 118
		private RNGCryptoServiceProvider cryptoProvider = new RNGCryptoServiceProvider();

		// Token: 0x04000077 RID: 119
		private byte[] uint32Buffer = new byte[4];
	}
}

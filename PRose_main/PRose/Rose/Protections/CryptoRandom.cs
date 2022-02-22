using System;
using System.Security.Cryptography;

namespace Rose.Protections
{
	// Token: 0x02000048 RID: 72
	public sealed class CryptoRandom : Random, IDisposable
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00002349 File Offset: 0x00000549
		public CryptoRandom()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002349 File Offset: 0x00000549
		public CryptoRandom(int seedIgnored)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00010234 File Offset: 0x0000E434
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

		// Token: 0x060000DF RID: 223 RVA: 0x000102D0 File Offset: 0x0000E4D0
		public override int Next(int maxValue)
		{
			short num = 0;
			while (num != 2)
			{
				if (num == 1)
				{
					if (maxValue >= 0)
					{
						goto IL_91;
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
				IL_91:
				return this.Next(0, maxValue);
			}
			throw new ArgumentOutOfRangeException("maxValue");
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00010380 File Offset: 0x0000E580
		public override int Next(int minValue, int maxValue)
		{
			short num = 0;
			while (num != 4)
			{
				if (num == 2)
				{
					throw new ArgumentOutOfRangeException("minValue");
				}
				if (num != 1)
				{
					goto IL_79;
				}
				if (minValue > maxValue)
				{
					num = 2;
					goto IL_79;
				}
				goto IL_8A;
				IL_A0:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					goto IL_D6;
				}
				continue;
				IL_79:
				if (num != 3)
				{
					goto IL_A0;
				}
				IL_8A:
				if (minValue == maxValue)
				{
					num = 4;
					goto IL_A0;
				}
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
			return minValue;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000104E0 File Offset: 0x0000E6E0
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

		// Token: 0x060000E2 RID: 226 RVA: 0x000105A4 File Offset: 0x0000E7A4
		public override void NextBytes(byte[] buffer)
		{
			short num = 0;
			while (num != 2)
			{
				if (num == 3)
				{
					goto IL_44;
				}
				IL_5F:
				if (num == 1)
				{
					if (buffer != null)
					{
						goto IL_44;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 4)
				{
					return;
				}
				continue;
				IL_44:
				this.cryptoProvider.GetBytes(buffer);
				num = 4;
				goto IL_5F;
			}
			throw new ArgumentNullException("buffer");
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001066C File Offset: 0x0000E86C
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

		// Token: 0x060000E4 RID: 228 RVA: 0x000106E0 File Offset: 0x0000E8E0
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

		// Token: 0x060000E5 RID: 229 RVA: 0x0001075C File Offset: 0x0000E95C
		private void InternalDispose()
		{
			short num = 0;
			do
			{
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
				if (num == 3)
				{
					this.cryptoProvider = null;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x04000053 RID: 83
		private RNGCryptoServiceProvider cryptoProvider = new RNGCryptoServiceProvider();

		// Token: 0x04000054 RID: 84
		private byte[] uint32Buffer = new byte[4];
	}
}

using System;
using System.Security.Cryptography;
using System.Text;

namespace Rose.Protections
{
	// Token: 0x0200004C RID: 76
	public class SecureRandoms
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00011608 File Offset: 0x0000F808
		public static int Next(int minValue, int maxExclusiveValue)
		{
			short num = 0;
			uint randomUInt;
			long num3;
			for (;;)
			{
				if (num != 6)
				{
					goto IL_36;
				}
				long num2;
				if ((ulong)randomUInt < (ulong)num2)
				{
					num = 7;
					goto IL_36;
				}
				goto IL_6E;
				IL_A9:
				if (num == 4)
				{
					num2 = (long)((ulong)-1 / (ulong)num3 * (ulong)num3);
					num = 5;
				}
				if (num == 2)
				{
					break;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 7)
				{
					goto Block_8;
				}
				continue;
				IL_80:
				if (num == 3)
				{
					goto IL_91;
				}
				goto IL_A9;
				IL_36:
				if (num == 1)
				{
					if (minValue < maxExclusiveValue)
					{
						goto IL_91;
					}
					num = 2;
				}
				if (num == 5)
				{
					goto IL_6E;
				}
				goto IL_80;
				IL_91:
				num3 = (long)maxExclusiveValue - (long)minValue;
				num = 4;
				goto IL_A9;
				IL_6E:
				randomUInt = SecureRandoms.GetRandomUInt();
				num = 6;
				goto IL_80;
			}
			throw new ArgumentOutOfRangeException("minValue must be lower than maxExclusiveValue");
			Block_8:
			return (int)((long)minValue + (long)((ulong)randomUInt % (ulong)num3));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00011758 File Offset: 0x0000F958
		public static uint GetRandomUInt()
		{
			short num = 0;
			byte[] value;
			do
			{
				if (num == 1)
				{
					value = SecureRandoms.GenerateRandomBytes(4);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			return BitConverter.ToUInt32(value, 0);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000117E0 File Offset: 0x0000F9E0
		public static byte[] GenerateRandomBytes(int bytesNumber)
		{
			short num = 0;
			byte[] array;
			do
			{
				if (num == 2)
				{
					SecureRandoms.csp.GetBytes(array);
					num = 3;
				}
				if (num == 1)
				{
					array = new byte[bytesNumber];
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			return array;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00011884 File Offset: 0x0000FA84
		public static string GenerateRandomString(int size)
		{
			short num = 0;
			byte[] array;
			RNGCryptoServiceProvider rngcryptoServiceProvider;
			do
			{
				if (num == 1)
				{
					array = new byte[4 * size];
					num = 2;
				}
				if (num == 2)
				{
					rngcryptoServiceProvider = new RNGCryptoServiceProvider();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			finally
			{
				if (rngcryptoServiceProvider != null)
				{
					((IDisposable)rngcryptoServiceProvider).Dispose();
				}
			}
			StringBuilder stringBuilder = new StringBuilder(size);
			for (int i = 0; i < size; i++)
			{
				uint num2 = BitConverter.ToUInt32(array, i * 4);
				long num3 = (long)((ulong)num2 % (ulong)((long)SecureRandoms.chars.Length));
				stringBuilder.Append(SecureRandoms.chars[(int)(checked((IntPtr)num3))]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000058 RID: 88
		private static readonly RNGCryptoServiceProvider csp = new RNGCryptoServiceProvider();

		// Token: 0x04000059 RID: 89
		internal static readonly char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Rose.Protections
{
	// Token: 0x0200005F RID: 95
	public static class RUtils
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00015714 File Offset: 0x00013914
		public static string GenerateRandomString()
		{
			short num = 0;
			string text;
			for (;;)
			{
				if (num == 3)
				{
					string input;
					text = RUtils.MD5Hash(input);
					num = 4;
				}
				if (num != 4)
				{
					goto IL_67;
				}
				if (char.IsDigit(text[0]))
				{
					num = 5;
					goto IL_67;
				}
				goto IL_9B;
				IL_16C:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					break;
				}
				continue;
				IL_B2:
				if (num == 6)
				{
					char letter;
					text = text.Replace(text[0], letter);
					num = 7;
				}
				Random random;
				if (num == 2)
				{
					string input = RUtils.GenerateRandomString(random.Next(2, 24));
					num = 3;
				}
				if (num == 8)
				{
					RUtils.used_names.Add(text);
					num = 9;
				}
				if (num == 1)
				{
					goto IL_15A;
				}
				goto IL_16C;
				IL_67:
				if (num == 5)
				{
					char letter = RUtils.GetLetter();
					num = 6;
				}
				if (num == 7)
				{
					goto IL_9B;
				}
				goto IL_B2;
				IL_15A:
				random = new Random();
				num = 2;
				goto IL_16C;
				IL_9B:
				if (!RUtils.CheckStringExists(text))
				{
					num = 8;
					goto IL_B2;
				}
				goto IL_15A;
			}
			return text;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000158C8 File Offset: 0x00013AC8
		private static string GenerateRandomString(int size)
		{
			short num = 0;
			StringBuilder stringBuilder;
			for (;;)
			{
				char[] array;
				if (num == 2)
				{
					string text;
					array = text.ToCharArray();
					num = 3;
				}
				int num2;
				if (num == 10)
				{
					num2 = 0;
					num = 11;
				}
				byte[] array2;
				if (num == 6)
				{
					array2 = new byte[size];
					num = 7;
				}
				if (num == 8)
				{
					stringBuilder = new StringBuilder(size);
					num = 9;
				}
				RNGCryptoServiceProvider rngcryptoServiceProvider;
				if (num == 7)
				{
					rngcryptoServiceProvider.GetNonZeroBytes(array2);
					num = 8;
				}
				if (num == 1)
				{
					string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
					num = 2;
				}
				if (num == 3)
				{
					array2 = new byte[1];
					num = 4;
				}
				if (num == 4)
				{
					rngcryptoServiceProvider = new RNGCryptoServiceProvider();
					num = 5;
				}
				if (num == 15)
				{
					goto IL_14C;
				}
				goto IL_164;
				IL_1AA:
				byte[] array3;
				if (num == 9)
				{
					array3 = array2;
					num = 10;
				}
				if (num == 14)
				{
					num2++;
					num = 15;
				}
				byte b;
				if (num == 13)
				{
					stringBuilder.Append(array[(int)b % array.Length]);
					num = 14;
				}
				if (num == 5)
				{
					rngcryptoServiceProvider.GetNonZeroBytes(array2);
					num = 6;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					break;
				}
				continue;
				IL_164:
				if (num == 11)
				{
					goto IL_14C;
				}
				if (num != 12)
				{
					goto IL_1AA;
				}
				IL_194:
				b = array3[num2];
				num = 13;
				goto IL_1AA;
				IL_14C:
				if (num2 >= array3.Length)
				{
					num = 16;
					goto IL_164;
				}
				goto IL_194;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00015B64 File Offset: 0x00013D64
		public static string GenerateRandomString2(int size)
		{
			short num = 0;
			StringBuilder stringBuilder;
			for (;;)
			{
				RNGCryptoServiceProvider rngcryptoServiceProvider;
				byte[] array;
				if (num == 5)
				{
					rngcryptoServiceProvider.GetNonZeroBytes(array);
					num = 6;
				}
				if (num == 6)
				{
					array = new byte[size];
					num = 7;
				}
				int num2;
				if (num == 14)
				{
					num2++;
					num = 15;
				}
				if (num == 3)
				{
					array = new byte[1];
					num = 4;
				}
				if (num == 4)
				{
					rngcryptoServiceProvider = new RNGCryptoServiceProvider();
					num = 5;
				}
				byte[] array2;
				if (num == 9)
				{
					array2 = array;
					num = 10;
				}
				if (num == 8)
				{
					stringBuilder = new StringBuilder(size);
					num = 9;
				}
				if (num == 15)
				{
					goto IL_129;
				}
				goto IL_141;
				IL_1B2:
				byte b;
				if (num == 13)
				{
					char[] array3;
					stringBuilder.Append(array3[(int)b % array3.Length]);
					num = 14;
				}
				string text;
				if (num == 1)
				{
					text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
					num = 2;
				}
				if (num == 11)
				{
					goto IL_129;
				}
				if (num == 2)
				{
					char[] array3 = text.ToCharArray();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					break;
				}
				continue;
				IL_141:
				if (num == 10)
				{
					num2 = 0;
					num = 11;
				}
				if (num == 7)
				{
					rngcryptoServiceProvider.GetNonZeroBytes(array);
					num = 8;
				}
				if (num != 12)
				{
					goto IL_1B2;
				}
				IL_19C:
				b = array2[num2];
				num = 13;
				goto IL_1B2;
				IL_129:
				if (num2 >= array2.Length)
				{
					num = 16;
					goto IL_141;
				}
				goto IL_19C;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00015E00 File Offset: 0x00014000
		public static string RandomNum(int length)
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
			return new string((from s in Enumerable.Repeat<string>("0123456789", length)
			select s[RUtils.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00015E90 File Offset: 0x00014090
		public static string RandomSymbols(int length)
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
			return new string((from s in Enumerable.Repeat<string>("ﭢٷٯړڔڕږﺈﺂﺁﺇﻌﻐۄۅۈﻲ۶ۋڙڟڑڋٱٺڿۓےﻬڈګڪﻬ", length)
			select s[RUtils.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00015F20 File Offset: 0x00014120
		public static string RandomChinese(int length)
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
			return new string((from s in Enumerable.Repeat<string>("埃克斯大波留艾儿波留豆", length)
			select s[RUtils.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00015FB0 File Offset: 0x000141B0
		private static string MD5Hash(string input)
		{
			short num = 0;
			StringBuilder stringBuilder;
			for (;;)
			{
				if (num == 5)
				{
					goto IL_66;
				}
				int num2;
				if (num == 7)
				{
					num2++;
					num = 8;
				}
				if (num == 8)
				{
					goto IL_66;
				}
				goto IL_7E;
				IL_DC:
				if (num == 1)
				{
					stringBuilder = new StringBuilder();
					num = 2;
				}
				byte[] array;
				if (num == 3)
				{
					MD5CryptoServiceProvider md5CryptoServiceProvider;
					array = md5CryptoServiceProvider.ComputeHash(new UTF8Encoding().GetBytes(input));
					num = 4;
				}
				if (num == 2)
				{
					MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					break;
				}
				continue;
				IL_7E:
				if (num == 4)
				{
					num2 = 0;
					num = 5;
				}
				if (num != 6)
				{
					goto IL_DC;
				}
				IL_B2:
				stringBuilder.Append(array[num2].ToString("x2"));
				num = 7;
				goto IL_DC;
				IL_66:
				if (num2 >= array.Length)
				{
					num = 9;
					goto IL_7E;
				}
				goto IL_B2;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00016154 File Offset: 0x00014354
		private static char GetLetter()
		{
			short num = 0;
			int num2;
			do
			{
				if (num == 2)
				{
					Random random;
					num2 = random.Next(0, 25);
					num = 3;
				}
				if (num == 1)
				{
					Random random = new Random();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			return (char)(97 + num2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00016204 File Offset: 0x00014404
		private static bool CheckStringExists(string stringToCheck)
		{
			short num = 0;
			while (num != 2)
			{
				if (num == 1)
				{
					if (!RUtils.used_names.Contains(stringToCheck))
					{
						return false;
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
				return false;
			}
			return true;
		}

		// Token: 0x04000068 RID: 104
		private static List<string> used_names = new List<string>();

		// Token: 0x04000069 RID: 105
		private static Random random = new Random();
	}
}

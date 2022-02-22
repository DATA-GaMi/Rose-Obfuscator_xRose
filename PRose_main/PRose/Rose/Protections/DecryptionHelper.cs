using System;
using System.Text;

namespace Rose.Protections
{
	// Token: 0x02000066 RID: 102
	internal static class DecryptionHelper
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00018974 File Offset: 0x00016B74
		public static string qUSxo(string dataEnc)
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
			string result;
			try
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(dataEnc));
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}
	}
}

using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace Rose.Protections
{
	// Token: 0x02000018 RID: 24
	internal class EofAntiTamper
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00008268 File Offset: 0x00006468
		private static void MARWA()
		{
			short num = 0;
			while (num != 8)
			{
				string location;
				Stream baseStream;
				if (num == 2)
				{
					baseStream = new StreamReader(location).BaseStream;
					num = 3;
				}
				if (num == 1)
				{
					location = Assembly.GetExecutingAssembly().Location;
					num = 2;
				}
				BinaryReader binaryReader;
				string a;
				if (num == 4)
				{
					a = BitConverter.ToString(SHA256.Create().ComputeHash(binaryReader.ReadBytes(File.ReadAllBytes(location).Length - 32)));
					num = 5;
				}
				if (num == 3)
				{
					binaryReader = new BinaryReader(baseStream);
					num = 4;
				}
				string b;
				if (num == 6)
				{
					b = BitConverter.ToString(binaryReader.ReadBytes(32));
					num = 7;
				}
				if (num == 7)
				{
					if (!(a != b))
					{
						return;
					}
					num = 8;
				}
				if (num == 5)
				{
					baseStream.Seek(-32L, SeekOrigin.End);
					num = 6;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 9)
				{
					continue;
				}
				return;
			}
			throw new BadImageFormatException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Rose.Helper;

namespace Rose.Protections
{
	// Token: 0x02000016 RID: 22
	public static class AntiTamper
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00007F24 File Offset: 0x00006124
		public static void Sha256(string filePath)
		{
			short num = 0;
			FileStream fileStream;
			byte[] array;
			do
			{
				if (num == 2)
				{
					fileStream = new FileStream(filePath, FileMode.Append);
					num = 3;
				}
				if (num == 1)
				{
					array = SHA256.Create().ComputeHash(File.ReadAllBytes(filePath));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				fileStream.Write(array, 0, array.Length);
			}
			finally
			{
				if (fileStream != null)
				{
					((IDisposable)fileStream).Dispose();
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00008014 File Offset: 0x00006214
		public static void Execute(ModuleDef module)
		{
			short num = 0;
			IEnumerator<MethodDef> enumerator;
			do
			{
				ModuleDefMD moduleDefMD;
				if (num == 1)
				{
					moduleDefMD = ModuleDefMD.Load(typeof(EofAntiTamper).Module);
					num = 2;
				}
				TypeDef typeDef;
				if (num == 3)
				{
					typeDef = moduleDefMD.ResolveTypeDef(MDToken.ToRID(typeof(EofAntiTamper).MetadataToken));
					num = 4;
				}
				IEnumerable<IDnlibDef> source;
				if (num == 4)
				{
					source = InjectHelper.Inject(typeDef, module.GlobalType, module);
					num = 5;
				}
				MethodDef methodDef;
				if (num == 2)
				{
					methodDef = module.GlobalType.FindOrCreateStaticConstructor();
					num = 3;
				}
				if (num == 6)
				{
					MethodDef method2;
					methodDef.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, method2));
					num = 7;
				}
				if (num == 7)
				{
					enumerator = module.GlobalType.Methods.GetEnumerator();
					num = 8;
				}
				if (num == 5)
				{
					MethodDef method2 = (MethodDef)source.Single((IDnlibDef method) => method.Name == "MARWA");
					num = 6;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
			try
			{
				while (enumerator.MoveNext())
				{
					MethodDef methodDef2 = enumerator.Current;
					if (!(methodDef2.Name != ".ctor"))
					{
						module.GlobalType.Remove(methodDef2);
						break;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}
	}
}

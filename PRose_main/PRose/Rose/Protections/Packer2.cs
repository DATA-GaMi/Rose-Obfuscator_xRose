using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Writer;
using Microsoft.CSharp;
using PRose.Properties;
using Rose.Helper;

namespace Rose.Protections
{
	// Token: 0x0200004F RID: 79
	internal class Packer2
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00011C4C File Offset: 0x0000FE4C
		private static void InjectEraseMethod(ModuleDef module)
		{
			short num = 0;
			IEnumerator<MethodDef> enumerator;
			do
			{
				if (num == 4)
				{
					IEnumerable<IDnlibDef> source;
					Packer2.eraseMethod = (MethodDef)source.Single((IDnlibDef method) => method.Name == "KOISZ");
					num = 5;
				}
				ModuleDefMD moduleDefMD;
				if (num == 1)
				{
					moduleDefMD = ModuleDefMD.Load(typeof(HeaderErasePacker).Module);
					num = 2;
				}
				TypeDef typeDef;
				if (num == 2)
				{
					typeDef = moduleDefMD.ResolveTypeDef(MDToken.ToRID(typeof(HeaderErasePacker).MetadataToken));
					num = 3;
				}
				if (num == 5)
				{
					enumerator = module.GlobalType.Methods.GetEnumerator();
					num = 6;
				}
				if (num == 3)
				{
					IEnumerable<IDnlibDef> source = InjectHelper.Inject(typeDef, module.GlobalType, module);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			try
			{
				while (enumerator.MoveNext())
				{
					MethodDef methodDef = enumerator.Current;
					if (methodDef.Name == ".ctor")
					{
						module.GlobalType.Remove(methodDef);
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

		// Token: 0x060000FF RID: 255 RVA: 0x00011E38 File Offset: 0x00010038
		private static void InjectAntiDebugMethod(ModuleDef module)
		{
			short num = 0;
			IEnumerator<MethodDef> enumerator;
			do
			{
				TypeDef typeDef;
				if (num == 2)
				{
					ModuleDefMD moduleDefMD;
					typeDef = moduleDefMD.ResolveTypeDef(MDToken.ToRID(typeof(DebugCheckerPacker).MetadataToken));
					num = 3;
				}
				if (num == 1)
				{
					ModuleDefMD moduleDefMD = ModuleDefMD.Load(typeof(DebugCheckerPacker).Module);
					num = 2;
				}
				IEnumerable<IDnlibDef> source;
				if (num == 3)
				{
					source = InjectHelper.Inject(typeDef, module.GlobalType, module);
					num = 4;
				}
				if (num == 4)
				{
					Packer2.debuggerMethod = (MethodDef)source.Single((IDnlibDef method) => method.Name == "XERPO");
					num = 5;
				}
				if (num == 5)
				{
					enumerator = module.GlobalType.Methods.GetEnumerator();
					num = 6;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			try
			{
				while (enumerator.MoveNext())
				{
					MethodDef methodDef = enumerator.Current;
					if (methodDef.Name == ".ctor")
					{
						module.GlobalType.Remove(methodDef);
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

		// Token: 0x06000100 RID: 256 RVA: 0x00012024 File Offset: 0x00010224
		public static byte[] Pack(string outputPath, string inputPath, string encryptKey, bool erasePE, bool antiDebug)
		{
			short num = 0;
			ModuleDefMD moduleDefMD;
			byte[] array;
			string text;
			IEnumerator<TypeDef> enumerator;
			for (;;)
			{
				if (num == 4)
				{
					if (!erasePE && !antiDebug)
					{
						goto IL_335;
					}
					num = 5;
				}
				if (num == 8)
				{
					goto IL_47;
				}
				goto IL_59;
				IL_AC:
				if (num == 9)
				{
					Packer2.InjectAntiDebugMethod(moduleDefMD);
					num = 10;
				}
				if (num == 5)
				{
					moduleDefMD = ModuleDefMD.Load(array);
					num = 6;
				}
				if (num == 7)
				{
					Packer2.InjectEraseMethod(moduleDefMD);
					num = 8;
				}
				if (num != 3)
				{
					goto IL_141;
				}
				if (!File.Exists(text))
				{
					num = 4;
					goto IL_141;
				}
				goto IL_175;
				IL_1A9:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					break;
				}
				continue;
				IL_141:
				if (num == 6)
				{
					if (!erasePE)
					{
						goto IL_47;
					}
					num = 7;
				}
				if (num != 2)
				{
					goto IL_1A9;
				}
				IL_175:
				text = Path.GetTempPath() + Guid.NewGuid().ToString() + ".exe";
				num = 3;
				goto IL_1A9;
				IL_59:
				if (num == 1)
				{
					array = File.ReadAllBytes(inputPath);
					num = 2;
				}
				if (num != 10)
				{
					goto IL_AC;
				}
				IL_91:
				enumerator = moduleDefMD.GetTypes().GetEnumerator();
				num = 11;
				goto IL_AC;
				IL_47:
				if (antiDebug)
				{
					num = 9;
					goto IL_59;
				}
				goto IL_91;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					TypeDef typeDef = enumerator.Current;
					if (!typeDef.IsGlobalModuleType)
					{
						foreach (MethodDef methodDef in typeDef.Methods)
						{
							if (methodDef.HasBody && methodDef.Name.Contains("Main"))
							{
								if (antiDebug)
								{
									methodDef.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, Packer2.debuggerMethod));
								}
								if (erasePE)
								{
									methodDef.Body.Instructions.Insert(methodDef.Body.Instructions.Count - 2, Instruction.Create(OpCodes.Call, Packer2.eraseMethod));
								}
							}
						}
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
			moduleDefMD.Write(text, new ModuleWriterOptions(moduleDefMD)
			{
				Logger = DummyLogger.NoThrowInstance
			});
			IL_335:
			byte[] salt = new byte[]
			{
				5,
				10,
				15,
				20,
				25,
				30,
				35,
				40
			};
			byte[] array2;
			if (erasePE)
			{
				array2 = File.ReadAllBytes(text);
			}
			else
			{
				array2 = array;
			}
			MemoryStream memoryStream = new MemoryStream();
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 128;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(encryptKey, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.Close();
			array2 = memoryStream.ToArray();
			string newValue = Convert.ToBase64String(memoryStream.ToArray());
			string text2 = Resources.XROSE;
			text2 = text2.Replace("%ASSEMBLY%", newValue);
			text2 = text2.Replace("%KEY%", encryptKey);
			Assembly assembly = Assembly.Load(array);
			CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider(new Dictionary<string, string>
			{
				{
					"CompilerVersion",
					"v4.0"
				}
			});
			CompilerParameters compilerParameters = new CompilerParameters();
			compilerParameters.CompilerOptions = "/target:winexe";
			compilerParameters.GenerateExecutable = true;
			AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
			foreach (AssemblyName assemblyName in referencedAssemblies)
			{
				if (assemblyName.Name.Contains("System.") || assemblyName.Name.Contains("Microsoft."))
				{
					compilerParameters.ReferencedAssemblies.Add(assemblyName.Name + ".dll");
				}
			}
			CompilerResults compilerResults = csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
			{
				text2
			});
			FileStream fileStream = compilerResults.CompiledAssembly.GetFiles()[0];
			byte[] result;
			using (MemoryStream memoryStream2 = new MemoryStream())
			{
				fileStream.CopyTo(memoryStream2);
				result = memoryStream2.ToArray();
			}
			return result;
		}

		// Token: 0x0400005A RID: 90
		private static MethodDef eraseMethod;

		// Token: 0x0400005B RID: 91
		private static MethodDef debuggerMethod;
	}
}

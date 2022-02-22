using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Writer;

// Token: 0x02000002 RID: 2
public static class Context
{
	// Token: 0x06000001 RID: 1 RVA: 0x000026F0 File Offset: 0x000008F0
	public static void LoadModule(string filename)
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
			Context.FileName = filename;
			byte[] data = File.ReadAllBytes(filename);
			ModuleContext context = ModuleDef.CreateModuleContext();
			Context.module = ModuleDefMD.Load(data, context);
			foreach (AssemblyRef assemblyRef in Context.module.GetAssemblyRefs())
			{
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000027E4 File Offset: 0x000009E4
	public static void SaveModule()
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
			string filename = string.Concat(new string[]
			{
				Path.GetDirectoryName(Context.FileName),
				"\\",
				Path.GetFileNameWithoutExtension(Context.FileName),
				Path.GetExtension(Context.FileName)
			});
			if (Context.module.IsILOnly)
			{
				ModuleWriterOptions moduleWriterOptions = new ModuleWriterOptions(Context.module);
				moduleWriterOptions.MetaDataOptions.Flags = MetaDataFlags.PreserveAll;
				moduleWriterOptions.MetaDataLogger = DummyLogger.NoThrowInstance;
				Context.module.Write(filename, moduleWriterOptions);
			}
			else
			{
				NativeModuleWriterOptions nativeModuleWriterOptions = new NativeModuleWriterOptions(Context.module);
				nativeModuleWriterOptions.MetaDataOptions.Flags = MetaDataFlags.PreserveAll;
				nativeModuleWriterOptions.MetaDataLogger = DummyLogger.NoThrowInstance;
				Context.module.NativeWrite(filename, nativeModuleWriterOptions);
			}
		}
		catch (ModuleWriterException ex)
		{
		}
		Console.ReadLine();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002944 File Offset: 0x00000B44
	public static byte[] Compress(byte[] data)
	{
		short num = 0;
		MemoryStream memoryStream;
		DeflateStream deflateStream;
		do
		{
			if (num == 2)
			{
				deflateStream = new DeflateStream(memoryStream, CompressionLevel.Optimal);
				num = 3;
			}
			if (num == 1)
			{
				memoryStream = new MemoryStream();
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
			deflateStream.Write(data, 0, data.Length);
		}
		finally
		{
			if (deflateStream != null)
			{
				((IDisposable)deflateStream).Dispose();
			}
		}
		return memoryStream.ToArray();
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002A30 File Offset: 0x00000C30
	public static void PackerPhase()
	{
		short num = 0;
		do
		{
			ModuleDefMD moduleDefMD;
			if (num == 7)
			{
				moduleDefMD.EncId = Context.module.EncId;
				num = 8;
			}
			string text;
			if (num == 15)
			{
				text = Context.RandomString(20);
				num = 16;
			}
			if (num == 6)
			{
				moduleDefMD.EncBaseId = Context.module.EncBaseId;
				num = 7;
			}
			MethodDef entryPoint;
			if (num == 14)
			{
				entryPoint = moduleDefMD.EntryPoint;
				num = 15;
			}
			if (num == 12)
			{
				moduleDefMD.TablesHeaderVersion = Context.module.TablesHeaderVersion;
				num = 13;
			}
			Instruction instruction;
			if (num == 17)
			{
				instruction = (from op in entryPoint.Body.Instructions
				where op.OpCode == OpCodes.Ldstr && op.Operand.ToString().Equals("xROSE")
				select op).First<Instruction>();
				num = 18;
			}
			if (num == 2)
			{
				moduleDefMD.Characteristics = Context.module.Characteristics;
				num = 3;
			}
			if (num == 5)
			{
				moduleDefMD.DllCharacteristics = Context.module.DllCharacteristics;
				num = 6;
			}
			if (num == 1)
			{
				moduleDefMD = ModuleDefMD.Load(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ROSED.exe");
				num = 2;
			}
			if (num == 11)
			{
				moduleDefMD.RuntimeVersion = Context.module.RuntimeVersion;
				num = 12;
			}
			if (num == 21)
			{
				byte[] ilasByteArray;
				moduleDefMD.Resources.Add(new EmbeddedResource(text, Context.Encrypt(Context.GetCurrentModule(Context.module), ilasByteArray)));
				num = 22;
			}
			if (num == 18)
			{
				Instruction instruction2;
				instruction2.Operand = entryPoint.MDToken.ToInt32();
				num = 19;
			}
			if (num == 19)
			{
				instruction.Operand = text;
				num = 20;
			}
			if (num == 13)
			{
				moduleDefMD.Win32Resources = Context.module.Win32Resources;
				num = 14;
			}
			if (num == 10)
			{
				moduleDefMD.Machine = Context.module.Machine;
				num = 11;
			}
			if (num == 22)
			{
				Context.module = moduleDefMD;
				num = 23;
			}
			if (num == 16)
			{
				Instruction instruction2 = (from op in entryPoint.Body.Instructions
				where op.OpCode == OpCodes.Ldc_I4 && op.GetLdcI4Value() == 123456789
				select op).First<Instruction>();
				num = 17;
			}
			if (num == 20)
			{
				byte[] ilasByteArray = Assembly.Load(Context.GetCurrentModule(moduleDefMD)).ManifestModule.ResolveMethod(entryPoint.MDToken.ToInt32()).GetMethodBody().GetILAsByteArray();
				num = 21;
			}
			if (num == 8)
			{
				moduleDefMD.Generation = Context.module.Generation;
				num = 9;
			}
			if (num == 4)
			{
				moduleDefMD.Cor20HeaderRuntimeVersion = Context.module.Cor20HeaderRuntimeVersion;
				num = 5;
			}
			if (num == 9)
			{
				moduleDefMD.Kind = Context.module.Kind;
				num = 10;
			}
			if (num == 3)
			{
				moduleDefMD.Cor20HeaderFlags = Context.module.Cor20HeaderFlags;
				num = 4;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 23);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002F00 File Offset: 0x00001100
	public static byte[] GetCurrentModule(ModuleDefMD module)
	{
		short num = 0;
		byte[] array;
		for (;;)
		{
			MemoryStream memoryStream;
			if (num == 14)
			{
				memoryStream.Read(array, 0, (int)memoryStream.Length);
				num = 15;
			}
			NativeModuleWriterOptions nativeModuleWriterOptions;
			if (num == 10)
			{
				nativeModuleWriterOptions.MetaDataLogger = DummyLogger.NoThrowInstance;
				num = 11;
			}
			ModuleWriterOptions moduleWriterOptions;
			if (num == 3)
			{
				moduleWriterOptions = new ModuleWriterOptions(module);
				num = 4;
			}
			if (num == 4)
			{
				moduleWriterOptions.MetaDataOptions.Flags = MetaDataFlags.PreserveAll;
				num = 5;
			}
			if (num == 11)
			{
				module.NativeWrite(memoryStream, nativeModuleWriterOptions);
				num = 12;
			}
			if (num == 7)
			{
				goto IL_192;
			}
			if (num == 6)
			{
				module.Write(memoryStream, moduleWriterOptions);
				num = 7;
			}
			if (num == 1)
			{
				memoryStream = new MemoryStream();
				num = 2;
			}
			if (num == 2)
			{
				if (!module.IsILOnly)
				{
					goto IL_210;
				}
				num = 3;
			}
			if (num == 12)
			{
				goto IL_192;
			}
			goto IL_1AE;
			IL_226:
			if (num == 9)
			{
				nativeModuleWriterOptions.MetaDataOptions.Flags = MetaDataFlags.PreserveAll;
				num = 10;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 15)
			{
				break;
			}
			continue;
			IL_1AE:
			if (num == 13)
			{
				memoryStream.Position = 0L;
				num = 14;
			}
			if (num == 5)
			{
				moduleWriterOptions.MetaDataLogger = DummyLogger.NoThrowInstance;
				num = 6;
			}
			if (num != 8)
			{
				goto IL_226;
			}
			IL_210:
			nativeModuleWriterOptions = new NativeModuleWriterOptions(module);
			num = 9;
			goto IL_226;
			IL_192:
			array = new byte[memoryStream.Length];
			num = 13;
			goto IL_1AE;
		}
		return array;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000319C File Offset: 0x0000139C
	public static byte[] Encrypt(byte[] plain, byte[] Key)
	{
		short num = 0;
		for (;;)
		{
			if (num == 3)
			{
				goto IL_159;
			}
			int num2;
			if (num == 12)
			{
				num2++;
				num = 13;
			}
			int num3;
			if (num == 2)
			{
				num3 = 0;
				num = 3;
			}
			if (num == 11)
			{
				goto IL_89;
			}
			goto IL_A1;
			IL_22B:
			if (num == 14)
			{
				num3++;
				num = 15;
			}
			if (num == 8)
			{
				goto IL_89;
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
			IL_1DF:
			if (num == 9)
			{
				goto IL_1F0;
			}
			goto IL_22B;
			IL_1BC:
			if (num == 4)
			{
				goto IL_1CD;
			}
			goto IL_1DF;
			IL_170:
			int num4;
			if (num == 7)
			{
				num4 = 0;
				num = 8;
			}
			if (num == 13)
			{
				goto IL_1A4;
			}
			goto IL_1BC;
			IL_107:
			if (num == 1)
			{
				num = 2;
			}
			if (num == 5)
			{
				goto IL_1A4;
			}
			if (num == 15)
			{
				goto IL_159;
			}
			goto IL_170;
			IL_A1:
			if (num == 10)
			{
				num4++;
				num = 11;
			}
			if (num == 6)
			{
				goto IL_DA;
			}
			goto IL_107;
			IL_1F0:
			plain[num2] = (byte)((int)plain[num2] ^ ((int)Key[num4] << num3 ^ num4) + num2);
			num = 10;
			goto IL_22B;
			IL_89:
			if (num4 >= Key.Length)
			{
				num = 12;
				goto IL_A1;
			}
			goto IL_1F0;
			IL_1CD:
			num2 = 0;
			num = 5;
			goto IL_1DF;
			IL_159:
			if (num3 >= 5)
			{
				num = 16;
				goto IL_170;
			}
			goto IL_1CD;
			IL_1A4:
			if (num2 >= plain.Length)
			{
				num = 14;
				goto IL_1BC;
			}
			IL_DA:
			plain[num2] ^= Key[num2 % Key.Length];
			num = 7;
			goto IL_107;
		}
		return plain;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00003458 File Offset: 0x00001658
	public static string RandomString(int length)
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
		return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
		select s[Context.random.Next(s.Length)]).ToArray<char>());
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000034E8 File Offset: 0x000016E8
	public static void Welcome()
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
	}

	// Token: 0x04000001 RID: 1
	private static Random random = new Random();

	// Token: 0x04000002 RID: 2
	public static ModuleDefMD module = null;

	// Token: 0x04000003 RID: 3
	public static string FileName = null;
}

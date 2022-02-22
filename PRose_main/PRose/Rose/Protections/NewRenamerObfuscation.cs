using System;
using dnlib.DotNet;

namespace Rose.Protections
{
	// Token: 0x0200005D RID: 93
	public static class NewRenamerObfuscation
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00015284 File Offset: 0x00013484
		public static void DoRenaming(ModuleDefMD md)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					md = NewRenamerObfuscation.RenamingObfuscation(md);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000152FC File Offset: 0x000134FC
		private static ModuleDefMD RenamingObfuscation(ModuleDefMD inModule)
		{
			short num = 0;
			ModuleDefMD moduleDefMD;
			do
			{
				IRenaming renaming;
				if (num == 5)
				{
					moduleDefMD = renaming.Rename(moduleDefMD);
					num = 6;
				}
				if (num == 8)
				{
					renaming = new PropertiesRenaming();
					num = 9;
				}
				if (num == 2)
				{
					renaming = new NamespacesRenaming();
					num = 3;
				}
				if (num == 4)
				{
					renaming = new ClassesRenaming();
					num = 5;
				}
				if (num == 1)
				{
					moduleDefMD = inModule;
					num = 2;
				}
				if (num == 9)
				{
					moduleDefMD = renaming.Rename(moduleDefMD);
					num = 10;
				}
				if (num == 6)
				{
					renaming = new MethodsRenaming();
					num = 7;
				}
				if (num == 10)
				{
					renaming = new FieldsRenaming();
					num = 11;
				}
				if (num == 3)
				{
					moduleDefMD = renaming.Rename(moduleDefMD);
					num = 4;
				}
				if (num == 11)
				{
					moduleDefMD = renaming.Rename(moduleDefMD);
					num = 12;
				}
				if (num == 7)
				{
					moduleDefMD = renaming.Rename(moduleDefMD);
					num = 8;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 12);
			return moduleDefMD;
		}
	}
}

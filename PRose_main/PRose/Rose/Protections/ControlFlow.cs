using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000036 RID: 54
	internal class ControlFlow
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x0000B268 File Offset: 0x00009468
		public static void Execute(ModuleDefMD Module)
		{
			short num = 0;
			for (;;)
			{
				if (num != 10)
				{
					goto IL_36;
				}
				MethodDef methodDef;
				if (methodDef.HasBody)
				{
					num = 11;
					goto IL_36;
				}
				goto IL_43C;
				IL_5C2:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 37)
				{
					break;
				}
				continue;
				IL_599:
				if (num == 27)
				{
					goto IL_5AA;
				}
				goto IL_5C2;
				IL_453:
				if (num == 31)
				{
					ControlFlow.ExecuteMethod4(methodDef, Module);
					num = 32;
				}
				int num2;
				if (num == 5)
				{
					num2 = 0;
					num = 6;
				}
				TypeDef typeDef;
				if (num == 4)
				{
					if (typeDef == Module.GlobalType)
					{
						goto IL_47;
					}
					num = 5;
				}
				if (num == 8)
				{
					if (methodDef.Name.StartsWith("get_"))
					{
						goto IL_43C;
					}
					num = 9;
				}
				if (num == 23)
				{
					ControlFlow.ExecuteMethod(methodDef, Module);
					num = 24;
				}
				if (num == 6)
				{
					goto IL_2A3;
				}
				if (num == 30)
				{
					ControlFlow.ExecuteMethod3(methodDef, Module);
					num = 31;
				}
				if (num == 36)
				{
					goto IL_579;
				}
				goto IL_599;
				IL_404:
				if (num == 20)
				{
					ControlFlow.ExecuteMethod2(methodDef, Module);
					num = 21;
				}
				if (num == 33)
				{
					goto IL_43C;
				}
				goto IL_453;
				IL_3D4:
				if (num == 3)
				{
					goto IL_3E5;
				}
				goto IL_404;
				IL_33A:
				if (num == 28)
				{
					ControlFlow.ExecuteMethod(methodDef, Module);
					num = 29;
				}
				int num3;
				if (num == 1)
				{
					num3 = 0;
					num = 2;
				}
				if (num == 19)
				{
					ControlFlow.ExecuteMethod(methodDef, Module);
					num = 20;
				}
				if (num == 22)
				{
					goto IL_3BC;
				}
				goto IL_3D4;
				IL_2C3:
				if (num == 29)
				{
					ControlFlow.ExecuteMethod2(methodDef, Module);
					num = 30;
				}
				if (num == 14)
				{
					ControlFlow.ExecuteMethod(methodDef, Module);
					num = 15;
				}
				if (num == 18)
				{
					goto IL_322;
				}
				goto IL_33A;
				IL_DC:
				if (num == 9)
				{
					if (methodDef.Name.StartsWith("set_"))
					{
						goto IL_43C;
					}
					num = 10;
				}
				if (num == 2)
				{
					goto IL_579;
				}
				if (num != 13)
				{
					goto IL_156;
				}
				if (xd.cflowint == 1)
				{
					num = 14;
					goto IL_156;
				}
				goto IL_18E;
				IL_1A6:
				if (num == 17)
				{
					ControlFlow.ExecuteMethod2(methodDef, Module);
					num = 18;
				}
				if (num == 11)
				{
					if (methodDef.IsConstructor)
					{
						goto IL_43C;
					}
					num = 12;
				}
				if (num == 25)
				{
					ControlFlow.ExecuteMethod3(methodDef, Module);
					num = 26;
				}
				if (num == 21)
				{
					ControlFlow.ExecuteMethod3(methodDef, Module);
					num = 22;
				}
				if (num == 24)
				{
					ControlFlow.ExecuteMethod2(methodDef, Module);
					num = 25;
				}
				if (num == 12)
				{
					methodDef.Body.SimplifyBranches();
					num = 13;
				}
				if (num == 34)
				{
					goto IL_2A3;
				}
				goto IL_2C3;
				IL_156:
				if (num == 26)
				{
					ControlFlow.ExecuteMethod4(methodDef, Module);
					num = 27;
				}
				if (num != 15)
				{
					goto IL_1A6;
				}
				IL_18E:
				if (xd.cflowint == 2)
				{
					num = 16;
					goto IL_1A6;
				}
				goto IL_322;
				IL_5E:
				if (num == 16)
				{
					ControlFlow.ExecuteMethod(methodDef, Module);
					num = 17;
				}
				if (num == 32)
				{
					ControlFlow.ExecuteMethod6(methodDef, Module);
					num = 33;
				}
				if (num == 7)
				{
					goto IL_BD;
				}
				goto IL_DC;
				IL_36:
				if (num == 35)
				{
					goto IL_47;
				}
				goto IL_5E;
				IL_5AA:
				if (xd.cflowint == 5)
				{
					num = 28;
					goto IL_5C2;
				}
				goto IL_43C;
				IL_3BC:
				if (xd.cflowint == 4)
				{
					num = 23;
					goto IL_3D4;
				}
				goto IL_5AA;
				IL_322:
				if (xd.cflowint == 3)
				{
					num = 19;
					goto IL_33A;
				}
				goto IL_3BC;
				IL_579:
				if (num3 >= Module.Types.Count)
				{
					num = 37;
					goto IL_599;
				}
				goto IL_3E5;
				IL_43C:
				num2++;
				num = 34;
				goto IL_453;
				IL_3E5:
				typeDef = Module.Types[num3];
				num = 4;
				goto IL_404;
				IL_2A3:
				if (num2 >= typeDef.Methods.Count)
				{
					num = 35;
					goto IL_2C3;
				}
				IL_BD:
				methodDef = typeDef.Methods[num2];
				num = 8;
				goto IL_DC;
				IL_47:
				num3++;
				num = 36;
				goto IL_5E;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000B870 File Offset: 0x00009A70
		public static void ExecuteMethod4(MethodDef method, ModuleDefMD Module)
		{
			short num = 0;
			Instruction instruction2;
			Instruction instruction;
			Local local;
			List<Instruction>.Enumerator enumerator;
			do
			{
				if (num == 2)
				{
					method.Body.SimplifyMacros(method.Parameters);
					num = 3;
				}
				if (num == 9)
				{
					instruction = Instruction.Create(OpCodes.Br, instruction2);
					num = 10;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 8)
				{
					instruction2 = Instruction.Create(OpCodes.Nop);
					num = 9;
				}
				if (num == 5)
				{
					method.Body.Instructions.Clear();
					num = 6;
				}
				if (num == 3)
				{
					CS$<>8__locals1.blocks = Blocks.Block(method);
					num = 4;
				}
				if (num == 6)
				{
					local = new Local(Module.CorLibTypes.UInt32);
					num = 7;
				}
				if (num == 4)
				{
					CS$<>8__locals1.blocks = ControlFlow.Randomize(CS$<>8__locals1.blocks);
					num = 5;
				}
				if (num == 7)
				{
					method.Body.Variables.Add(local);
					num = 8;
				}
				if (num == 10)
				{
					enumerator = ControlFlow.Calc(0).GetEnumerator();
					num = 11;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
			try
			{
				while (enumerator.MoveNext())
				{
					Instruction item = enumerator.Current;
					method.Body.Instructions.Add(item);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, instruction));
			method.Body.Instructions.Add(instruction2);
			IEnumerable<Block> blocks3 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate;
			if ((predicate = CS$<>8__locals1.<>9__0) == null)
			{
				predicate = (CS$<>8__locals1.<>9__0 = delegate(Block block)
				{
					IEnumerable<Block> blocks4 = CS$<>8__locals1.blocks;
					Func<Block, bool> predicate3;
					if ((predicate3 = CS$<>8__locals1.<>9__1) == null)
					{
						predicate3 = (CS$<>8__locals1.<>9__1 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
					}
					return block != blocks4.Single(predicate3);
				});
			}
			foreach (Block block2 in blocks3.Where(predicate))
			{
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
				foreach (Instruction item2 in ControlFlow.Calc(block2.Number))
				{
					method.Body.Instructions.Add(item2);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
				Instruction instruction3 = Instruction.Create(OpCodes.Nop);
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction3));
				foreach (Instruction item3 in block2.Instructions)
				{
					method.Body.Instructions.Add(item3);
				}
				foreach (Instruction item4 in ControlFlow.Calc(block2.Number + 1))
				{
					method.Body.Instructions.Add(item4);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
				method.Body.Instructions.Add(instruction3);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
			foreach (Instruction item5 in ControlFlow.Calc(CS$<>8__locals1.blocks.Count - 1))
			{
				method.Body.Instructions.Add(item5);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, CS$<>8__locals1.blocks.Single((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1).Instructions[0]));
			method.Body.Instructions.Add(instruction);
			IEnumerable<Block> blocks2 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate2;
			if ((predicate2 = CS$<>8__locals1.<>9__3) == null)
			{
				predicate2 = (CS$<>8__locals1.<>9__3 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
			}
			foreach (Instruction item6 in blocks2.Single(predicate2).Instructions)
			{
				method.Body.Instructions.Add(item6);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		public static void ExecuteMethod6(MethodDef method, ModuleDefMD Module)
		{
			short num = 0;
			Instruction instruction;
			Local local;
			List<Instruction>.Enumerator enumerator;
			Instruction instruction2;
			do
			{
				if (num == 4)
				{
					CS$<>8__locals1.blocks = ControlFlow.Randomize(CS$<>8__locals1.blocks);
					num = 5;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 8)
				{
					instruction = Instruction.Create(OpCodes.Nop);
					num = 9;
				}
				if (num == 7)
				{
					method.Body.Variables.Add(local);
					num = 8;
				}
				if (num == 10)
				{
					enumerator = ControlFlow.Calc(0).GetEnumerator();
					num = 11;
				}
				if (num == 9)
				{
					instruction2 = Instruction.Create(OpCodes.Br, instruction);
					num = 10;
				}
				if (num == 3)
				{
					CS$<>8__locals1.blocks = Blocks.Block(method);
					num = 4;
				}
				if (num == 2)
				{
					method.Body.SimplifyMacros(method.Parameters);
					num = 3;
				}
				if (num == 6)
				{
					local = new Local(Module.CorLibTypes.Int16);
					num = 7;
				}
				if (num == 5)
				{
					method.Body.Instructions.Clear();
					num = 6;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
			try
			{
				while (enumerator.MoveNext())
				{
					Instruction item = enumerator.Current;
					method.Body.Instructions.Add(item);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, instruction2));
			method.Body.Instructions.Add(instruction);
			IEnumerable<Block> blocks3 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate;
			if ((predicate = CS$<>8__locals1.<>9__0) == null)
			{
				predicate = (CS$<>8__locals1.<>9__0 = delegate(Block block)
				{
					IEnumerable<Block> blocks4 = CS$<>8__locals1.blocks;
					Func<Block, bool> predicate3;
					if ((predicate3 = CS$<>8__locals1.<>9__1) == null)
					{
						predicate3 = (CS$<>8__locals1.<>9__1 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
					}
					return block != blocks4.Single(predicate3);
				});
			}
			foreach (Block block2 in blocks3.Where(predicate))
			{
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
				foreach (Instruction item2 in ControlFlow.Calc(block2.Number))
				{
					method.Body.Instructions.Add(item2);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
				Instruction instruction3 = Instruction.Create(OpCodes.Nop);
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction3));
				foreach (Instruction item3 in block2.Instructions)
				{
					method.Body.Instructions.Add(item3);
				}
				foreach (Instruction item4 in ControlFlow.Calc(block2.Number + 1))
				{
					method.Body.Instructions.Add(item4);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
				method.Body.Instructions.Add(instruction3);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
			foreach (Instruction item5 in ControlFlow.Calc(CS$<>8__locals1.blocks.Count - 1))
			{
				method.Body.Instructions.Add(item5);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction2));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, CS$<>8__locals1.blocks.Single((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1).Instructions[0]));
			method.Body.Instructions.Add(instruction2);
			IEnumerable<Block> blocks2 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate2;
			if ((predicate2 = CS$<>8__locals1.<>9__3) == null)
			{
				predicate2 = (CS$<>8__locals1.<>9__3 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
			}
			foreach (Instruction item6 in blocks2.Single(predicate2).Instructions)
			{
				method.Body.Instructions.Add(item6);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000C768 File Offset: 0x0000A968
		public static void ExecuteMethod3(MethodDef method, ModuleDefMD Module)
		{
			short num = 0;
			Instruction instruction2;
			Instruction instruction;
			Local local;
			List<Instruction>.Enumerator enumerator;
			do
			{
				if (num == 3)
				{
					CS$<>8__locals1.blocks = Blocks.Block(method);
					num = 4;
				}
				if (num == 9)
				{
					instruction = Instruction.Create(OpCodes.Br, instruction2);
					num = 10;
				}
				if (num == 4)
				{
					CS$<>8__locals1.blocks = ControlFlow.Randomize(CS$<>8__locals1.blocks);
					num = 5;
				}
				if (num == 2)
				{
					method.Body.SimplifyMacros(method.Parameters);
					num = 3;
				}
				if (num == 8)
				{
					instruction2 = Instruction.Create(OpCodes.Nop);
					num = 9;
				}
				if (num == 7)
				{
					method.Body.Variables.Add(local);
					num = 8;
				}
				if (num == 5)
				{
					method.Body.Instructions.Clear();
					num = 6;
				}
				if (num == 10)
				{
					enumerator = ControlFlow.Calc(0).GetEnumerator();
					num = 11;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 6)
				{
					local = new Local(Module.CorLibTypes.UInt16);
					num = 7;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
			try
			{
				while (enumerator.MoveNext())
				{
					Instruction item = enumerator.Current;
					method.Body.Instructions.Add(item);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, instruction));
			method.Body.Instructions.Add(instruction2);
			IEnumerable<Block> blocks3 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate;
			if ((predicate = CS$<>8__locals1.<>9__0) == null)
			{
				predicate = (CS$<>8__locals1.<>9__0 = delegate(Block block)
				{
					IEnumerable<Block> blocks4 = CS$<>8__locals1.blocks;
					Func<Block, bool> predicate3;
					if ((predicate3 = CS$<>8__locals1.<>9__1) == null)
					{
						predicate3 = (CS$<>8__locals1.<>9__1 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
					}
					return block != blocks4.Single(predicate3);
				});
			}
			foreach (Block block2 in blocks3.Where(predicate))
			{
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
				foreach (Instruction item2 in ControlFlow.Calc(block2.Number))
				{
					method.Body.Instructions.Add(item2);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
				Instruction instruction3 = Instruction.Create(OpCodes.Nop);
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction3));
				foreach (Instruction item3 in block2.Instructions)
				{
					method.Body.Instructions.Add(item3);
				}
				foreach (Instruction item4 in ControlFlow.Calc(block2.Number + 1))
				{
					method.Body.Instructions.Add(item4);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
				method.Body.Instructions.Add(instruction3);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
			foreach (Instruction item5 in ControlFlow.Calc(CS$<>8__locals1.blocks.Count - 1))
			{
				method.Body.Instructions.Add(item5);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, CS$<>8__locals1.blocks.Single((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1).Instructions[0]));
			method.Body.Instructions.Add(instruction);
			IEnumerable<Block> blocks2 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate2;
			if ((predicate2 = CS$<>8__locals1.<>9__3) == null)
			{
				predicate2 = (CS$<>8__locals1.<>9__3 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
			}
			foreach (Instruction item6 in blocks2.Single(predicate2).Instructions)
			{
				method.Body.Instructions.Add(item6);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		public static void ExecuteMethod2(MethodDef method, ModuleDefMD Module)
		{
			short num = 0;
			Instruction instruction;
			Instruction instruction2;
			Local local;
			List<Instruction>.Enumerator enumerator;
			do
			{
				if (num == 8)
				{
					instruction = Instruction.Create(OpCodes.Nop);
					num = 9;
				}
				if (num == 9)
				{
					instruction2 = Instruction.Create(OpCodes.Br, instruction);
					num = 10;
				}
				if (num == 7)
				{
					method.Body.Variables.Add(local);
					num = 8;
				}
				if (num == 6)
				{
					local = new Local(Module.CorLibTypes.IntPtr);
					num = 7;
				}
				if (num == 4)
				{
					CS$<>8__locals1.blocks = ControlFlow.Randomize(CS$<>8__locals1.blocks);
					num = 5;
				}
				if (num == 3)
				{
					CS$<>8__locals1.blocks = Blocks.Block(method);
					num = 4;
				}
				if (num == 5)
				{
					method.Body.Instructions.Clear();
					num = 6;
				}
				if (num == 10)
				{
					enumerator = ControlFlow.Calc(0).GetEnumerator();
					num = 11;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 2)
				{
					method.Body.SimplifyMacros(method.Parameters);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
			try
			{
				while (enumerator.MoveNext())
				{
					Instruction item = enumerator.Current;
					method.Body.Instructions.Add(item);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, instruction2));
			method.Body.Instructions.Add(instruction);
			IEnumerable<Block> blocks3 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate;
			if ((predicate = CS$<>8__locals1.<>9__0) == null)
			{
				predicate = (CS$<>8__locals1.<>9__0 = delegate(Block block)
				{
					IEnumerable<Block> blocks4 = CS$<>8__locals1.blocks;
					Func<Block, bool> predicate3;
					if ((predicate3 = CS$<>8__locals1.<>9__1) == null)
					{
						predicate3 = (CS$<>8__locals1.<>9__1 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
					}
					return block != blocks4.Single(predicate3);
				});
			}
			foreach (Block block2 in blocks3.Where(predicate))
			{
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
				foreach (Instruction item2 in ControlFlow.Calc(block2.Number))
				{
					method.Body.Instructions.Add(item2);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
				Instruction instruction3 = Instruction.Create(OpCodes.Nop);
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction3));
				foreach (Instruction item3 in block2.Instructions)
				{
					method.Body.Instructions.Add(item3);
				}
				foreach (Instruction item4 in ControlFlow.Calc(block2.Number + 1))
				{
					method.Body.Instructions.Add(item4);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
				method.Body.Instructions.Add(instruction3);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
			foreach (Instruction item5 in ControlFlow.Calc(CS$<>8__locals1.blocks.Count - 1))
			{
				method.Body.Instructions.Add(item5);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction2));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, CS$<>8__locals1.blocks.Single((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1).Instructions[0]));
			method.Body.Instructions.Add(instruction2);
			IEnumerable<Block> blocks2 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate2;
			if ((predicate2 = CS$<>8__locals1.<>9__3) == null)
			{
				predicate2 = (CS$<>8__locals1.<>9__3 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
			}
			foreach (Instruction item6 in blocks2.Single(predicate2).Instructions)
			{
				method.Body.Instructions.Add(item6);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000D660 File Offset: 0x0000B860
		public static void ExecuteMethod(MethodDef method, ModuleDefMD Module)
		{
			short num = 0;
			Instruction instruction2;
			Instruction instruction;
			Local local;
			List<Instruction>.Enumerator enumerator;
			do
			{
				if (num == 1)
				{
					num = 2;
				}
				if (num == 9)
				{
					instruction = Instruction.Create(OpCodes.Br, instruction2);
					num = 10;
				}
				if (num == 7)
				{
					method.Body.Variables.Add(local);
					num = 8;
				}
				if (num == 4)
				{
					CS$<>8__locals1.blocks = ControlFlow.Randomize(CS$<>8__locals1.blocks);
					num = 5;
				}
				if (num == 10)
				{
					enumerator = ControlFlow.Calc(0).GetEnumerator();
					num = 11;
				}
				if (num == 8)
				{
					instruction2 = Instruction.Create(OpCodes.Nop);
					num = 9;
				}
				if (num == 5)
				{
					method.Body.Instructions.Clear();
					num = 6;
				}
				if (num == 6)
				{
					local = new Local(Module.CorLibTypes.UIntPtr);
					num = 7;
				}
				if (num == 3)
				{
					CS$<>8__locals1.blocks = Blocks.Block(method);
					num = 4;
				}
				if (num == 2)
				{
					method.Body.SimplifyMacros(method.Parameters);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
			try
			{
				while (enumerator.MoveNext())
				{
					Instruction item = enumerator.Current;
					method.Body.Instructions.Add(item);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, instruction));
			method.Body.Instructions.Add(instruction2);
			IEnumerable<Block> blocks3 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate;
			if ((predicate = CS$<>8__locals1.<>9__0) == null)
			{
				predicate = (CS$<>8__locals1.<>9__0 = delegate(Block block)
				{
					IEnumerable<Block> blocks4 = CS$<>8__locals1.blocks;
					Func<Block, bool> predicate3;
					if ((predicate3 = CS$<>8__locals1.<>9__1) == null)
					{
						predicate3 = (CS$<>8__locals1.<>9__1 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
					}
					return block != blocks4.Single(predicate3);
				});
			}
			foreach (Block block2 in blocks3.Where(predicate))
			{
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
				foreach (Instruction item2 in ControlFlow.Calc(block2.Number))
				{
					method.Body.Instructions.Add(item2);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
				Instruction instruction3 = Instruction.Create(OpCodes.Nop);
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction3));
				foreach (Instruction item3 in block2.Instructions)
				{
					method.Body.Instructions.Add(item3);
				}
				foreach (Instruction item4 in ControlFlow.Calc(block2.Number + 1))
				{
					method.Body.Instructions.Add(item4);
				}
				method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
				method.Body.Instructions.Add(instruction3);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
			foreach (Instruction item5 in ControlFlow.Calc(CS$<>8__locals1.blocks.Count - 1))
			{
				method.Body.Instructions.Add(item5);
			}
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction));
			method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, CS$<>8__locals1.blocks.Single((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1).Instructions[0]));
			method.Body.Instructions.Add(instruction);
			IEnumerable<Block> blocks2 = CS$<>8__locals1.blocks;
			Func<Block, bool> predicate2;
			if ((predicate2 = CS$<>8__locals1.<>9__3) == null)
			{
				predicate2 = (CS$<>8__locals1.<>9__3 = ((Block x) => x.Number == CS$<>8__locals1.blocks.Count - 1));
			}
			foreach (Instruction item6 in blocks2.Single(predicate2).Instructions)
			{
				method.Body.Instructions.Add(item6);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		public static List<Block> Randomize(List<Block> input)
		{
			short num = 0;
			List<Block> list;
			List<Block>.Enumerator enumerator;
			do
			{
				if (num == 1)
				{
					list = new List<Block>();
					num = 2;
				}
				if (num == 2)
				{
					enumerator = input.GetEnumerator();
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
				while (enumerator.MoveNext())
				{
					Block item = enumerator.Current;
					list.Insert(ControlFlow.Random.Next(0, list.Count), item);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return list;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
		public static List<Instruction> Calc(int value)
		{
			short num = 0;
			List<Instruction> list;
			do
			{
				if (num == 2)
				{
					list.Add(Instruction.Create(OpCodes.Ldc_I4, value));
					num = 3;
				}
				if (num == 1)
				{
					list = new List<Instruction>();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			return list;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000DF94 File Offset: 0x0000C194
		public static void AddJump(IList<Instruction> instrs, Instruction target)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					instrs.Add(Instruction.Create(OpCodes.Br, target));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0400003D RID: 61
		public static Random Random = new Random();
	}
}

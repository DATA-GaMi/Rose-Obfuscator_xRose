using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000035 RID: 53
	internal class Blocks
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000AE20 File Offset: 0x00009020
		public static List<Block> Block(MethodDef method)
		{
			short num = 0;
			Block block;
			List<Block> list;
			IEnumerator<Instruction> enumerator;
			int num2;
			int num3;
			Stack<ExceptionHandler> stack;
			do
			{
				if (num == 3)
				{
					block = new Block();
					num = 4;
				}
				if (num == 1)
				{
					list = new List<Block>();
					num = 2;
				}
				if (num == 11)
				{
					enumerator = method.Body.Instructions.GetEnumerator();
					num = 12;
				}
				if (num == 6)
				{
					block.Number = num2;
					num = 7;
				}
				if (num == 5)
				{
					num3 = 0;
					num = 6;
				}
				if (num == 10)
				{
					stack = new Stack<ExceptionHandler>();
					num = 11;
				}
				if (num == 2)
				{
					List<Instruction> list2 = new List<Instruction>(method.Body.Instructions);
					num = 3;
				}
				if (num == 9)
				{
					block = new Block();
					num = 10;
				}
				if (num == 7)
				{
					block.Instructions.Add(Instruction.Create(OpCodes.Nop));
					num = 8;
				}
				if (num == 8)
				{
					list.Add(block);
					num = 9;
				}
				if (num == 4)
				{
					num2 = 0;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 12);
			try
			{
				while (enumerator.MoveNext())
				{
					Instruction instruction = enumerator.Current;
					foreach (ExceptionHandler exceptionHandler in method.Body.ExceptionHandlers)
					{
						if (exceptionHandler.HandlerStart == instruction || exceptionHandler.TryStart == instruction || exceptionHandler.FilterStart == instruction)
						{
							stack.Push(exceptionHandler);
						}
					}
					foreach (ExceptionHandler exceptionHandler2 in method.Body.ExceptionHandlers)
					{
						if (exceptionHandler2.HandlerEnd == instruction || exceptionHandler2.TryEnd == instruction)
						{
							stack.Pop();
						}
					}
					int num4;
					int num5;
					instruction.CalculateStackUsage(out num4, out num5);
					block.Instructions.Add(instruction);
					num3 += num4 - num5;
					if (num4 == 0 && instruction.OpCode != OpCodes.Nop && (num3 == 0 || instruction.OpCode == OpCodes.Ret) && stack.Count == 0)
					{
						num2 = (block.Number = num2 + 1);
						list.Add(block);
						block = new Block();
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
			return list;
		}
	}
}

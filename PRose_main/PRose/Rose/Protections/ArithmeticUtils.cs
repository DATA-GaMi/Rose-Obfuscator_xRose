using System;
using System.Reflection;
using dnlib.DotNet.Emit;

namespace Rose.Protections
{
	// Token: 0x02000032 RID: 50
	public class ArithmeticUtils
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000A6EC File Offset: 0x000088EC
		public static bool CheckArithmetic(Instruction instruction)
		{
			short num = 0;
			while (num != 2)
			{
				if (num == 1)
				{
					if (instruction.IsLdcI4())
					{
						goto IL_67;
					}
					num = 2;
				}
				if (num != 3)
				{
					if (num == 0)
					{
						num = 1;
					}
					if (num == 4)
					{
						goto IL_BF;
					}
					continue;
				}
				IL_67:
				if (instruction.GetLdcI4Value() == 1)
				{
					return false;
				}
				IL_BF:
				return instruction.GetLdcI4Value() != 0;
			}
			return false;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000A7C8 File Offset: 0x000089C8
		public static double GetY(double x)
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
			return x / 2.0;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000A828 File Offset: 0x00008A28
		public static MethodInfo GetMethod(ArithmeticTypes mathType)
		{
			short num = 0;
			while (num != 6)
			{
				if (num != 7)
				{
					if (num != 10)
					{
						if (num != 3)
						{
							if (num != 2)
							{
								if (num != 14)
								{
									if (num != 13)
									{
										if (num != 12)
										{
											if (num != 4)
											{
												if (num != 8)
												{
													if (num != 9)
													{
														if (num != 11)
														{
															if (num == 1)
															{
																switch (mathType)
																{
																case ArithmeticTypes.Abs:
																	goto IL_FD;
																case ArithmeticTypes.Log:
																	goto IL_69;
																case ArithmeticTypes.Log10:
																	goto IL_28E;
																case ArithmeticTypes.Sin:
																	goto IL_3C5;
																case ArithmeticTypes.Cos:
																	goto IL_1F;
																case ArithmeticTypes.Round:
																	goto IL_244;
																case ArithmeticTypes.Sqrt:
																	goto IL_2D8;
																case ArithmeticTypes.Ceiling:
																	goto IL_B3;
																case ArithmeticTypes.Floor:
																	goto IL_322;
																case ArithmeticTypes.Tan:
																	goto IL_1FA;
																case ArithmeticTypes.Tanh:
																	goto IL_1B0;
																case ArithmeticTypes.Truncate:
																	goto IL_166;
																default:
																	num = 2;
																	break;
																}
															}
															if (num != 5)
															{
																if (num == 0)
																{
																	num = 1;
																}
																if (num == 15)
																{
																	goto IL_434;
																}
																continue;
															}
															IL_3C5:
															return typeof(Math).GetMethod("Sin", new Type[]
															{
																typeof(double)
															});
														}
														IL_322:
														return typeof(Math).GetMethod("Floor", new Type[]
														{
															typeof(double)
														});
													}
													IL_2D8:
													return typeof(Math).GetMethod("Sqrt", new Type[]
													{
														typeof(double)
													});
												}
												IL_28E:
												return typeof(Math).GetMethod("Log10", new Type[]
												{
													typeof(double)
												});
											}
											IL_244:
											return typeof(Math).GetMethod("Round", new Type[]
											{
												typeof(double)
											});
										}
										IL_1FA:
										return typeof(Math).GetMethod("Tan", new Type[]
										{
											typeof(double)
										});
									}
									IL_1B0:
									return typeof(Math).GetMethod("Tanh", new Type[]
									{
										typeof(double)
									});
								}
								IL_166:
								return typeof(Math).GetMethod("Truncate", new Type[]
								{
									typeof(double)
								});
							}
							IL_434:
							return null;
						}
						IL_FD:
						return typeof(Math).GetMethod("Abs", new Type[]
						{
							typeof(double)
						});
					}
					IL_B3:
					return typeof(Math).GetMethod("Ceiling", new Type[]
					{
						typeof(double)
					});
				}
				IL_69:
				return typeof(Math).GetMethod("Log", new Type[]
				{
					typeof(double)
				});
			}
			IL_1F:
			return typeof(Math).GetMethod("Cos", new Type[]
			{
				typeof(double)
			});
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000AC6C File Offset: 0x00008E6C
		public static OpCode GetOpCode(ArithmeticTypes arithmetic)
		{
			short num = 0;
			for (;;)
			{
				if (num == 1)
				{
					if (arithmetic == ArithmeticTypes.Add)
					{
						goto IL_62;
					}
					num = 2;
				}
				if (num == 5)
				{
					break;
				}
				if (num == 4)
				{
					goto IL_62;
				}
				if (num == 2)
				{
					if (arithmetic == ArithmeticTypes.Sub)
					{
						break;
					}
					num = 3;
				}
				if (num == 3)
				{
					goto Block_5;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					goto Block_7;
				}
			}
			return OpCodes.Sub;
			IL_62:
			return OpCodes.Add;
			Block_5:
			Block_7:
			return null;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Rose.Protections
{
	// Token: 0x0200001B RID: 27
	public class ArithmeticEmulator
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000021AC File Offset: 0x000003AC
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000021B4 File Offset: 0x000003B4
		public new ArithmeticTypes GetType { get; private set; }

		// Token: 0x0600004B RID: 75 RVA: 0x000021BD File Offset: 0x000003BD
		public ArithmeticEmulator(double x, double y, ArithmeticTypes arithmeticTypes)
		{
			this.x = x;
			this.y = y;
			this.arithmeticTypes = arithmeticTypes;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000090C0 File Offset: 0x000072C0
		public double GetValue()
		{
			short num = 0;
			while (num != 8)
			{
				if (num == 2)
				{
					ArithmeticTypes arithmeticTypes;
					switch (arithmeticTypes)
					{
					case ArithmeticTypes.Add:
						goto IL_157;
					case ArithmeticTypes.Sub:
						goto IL_FB;
					case ArithmeticTypes.Div:
						goto IL_87;
					case ArithmeticTypes.Mul:
						goto IL_129;
					case ArithmeticTypes.Xor:
						goto IL_1F;
					default:
						num = 3;
						break;
					}
				}
				if (num != 6)
				{
					if (num == 1)
					{
						ArithmeticTypes arithmeticTypes = this.arithmeticTypes;
						num = 2;
					}
					if (num != 3)
					{
						if (num == 5)
						{
							goto IL_FB;
						}
						if (num == 7)
						{
							goto IL_129;
						}
						if (num == 4)
						{
							goto IL_157;
						}
						if (num == 0)
						{
							num = 1;
						}
						if (num != 9)
						{
							continue;
						}
					}
					return -1.0;
				}
				IL_87:
				return this.x * this.y;
				IL_FB:
				return this.x + this.y;
				IL_129:
				return this.x / this.y;
				IL_157:
				return this.x - this.y;
			}
			IL_1F:
			return (double)((int)this.x ^ (int)this.y);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00009280 File Offset: 0x00007480
		public double GetValue(List<ArithmeticTypes> arithmetics)
		{
			short num = 0;
			while (num != 39)
			{
				ArithmeticTypes arithmeticTypes2;
				if (num != 28)
				{
					if (num != 14)
					{
						if (num != 16)
						{
							if (num != 32)
							{
								if (num != 5)
								{
									goto IL_18F;
								}
								ArithmeticTypes arithmeticTypes;
								switch (arithmeticTypes)
								{
								case ArithmeticTypes.Abs:
									goto IL_675;
								case ArithmeticTypes.Log:
									goto IL_4E4;
								case ArithmeticTypes.Log10:
									goto IL_C5;
								case ArithmeticTypes.Sin:
									goto IL_82C;
								case ArithmeticTypes.Cos:
									goto IL_3B3;
								case ArithmeticTypes.Round:
									goto IL_43;
								case ArithmeticTypes.Sqrt:
									goto IL_698;
								case ArithmeticTypes.Ceiling:
									goto IL_557;
								case ArithmeticTypes.Floor:
									goto IL_626;
								case ArithmeticTypes.Tan:
									goto IL_89E;
								case ArithmeticTypes.Tanh:
									goto IL_7AA;
								case ArithmeticTypes.Truncate:
									goto IL_1F7;
								default:
									num = 6;
									goto IL_18F;
								}
								IL_687:
								if (num == 37)
								{
									goto IL_698;
								}
								if (num == 18)
								{
									goto IL_6E7;
								}
								if (num == 26)
								{
									goto IL_70B;
								}
								if (num == 41)
								{
									goto IL_73E;
								}
								if (num == 2)
								{
									Generator generator;
									arithmeticTypes2 = arithmetics[generator.Next(arithmetics.Count)];
									num = 3;
								}
								if (num == 34)
								{
									goto IL_7AA;
								}
								if (num == 38)
								{
									goto IL_7F9;
								}
								if (num == 19)
								{
									goto IL_82C;
								}
								if (num == 1)
								{
									Generator generator = new Generator();
									num = 2;
								}
								if (num == 31)
								{
									goto IL_89E;
								}
								if (num == 4)
								{
									arithmeticTypes = this.arithmeticTypes;
									num = 5;
								}
								if (num == 33)
								{
									goto IL_914;
								}
								if (num == 17)
								{
									goto IL_938;
								}
								if (num == 0)
								{
									num = 1;
								}
								if (num == 46)
								{
									goto IL_990;
								}
								continue;
								IL_18F:
								if (num == 30)
								{
									goto IL_1A0;
								}
								if (num == 44)
								{
									goto IL_1C4;
								}
								if (num == 43)
								{
									goto IL_1F7;
								}
								if (num == 29)
								{
									goto IL_246;
								}
								if (num == 20)
								{
									goto IL_279;
								}
								if (num == 36)
								{
									goto IL_2AC;
								}
								if (num == 3)
								{
									this.GetType = arithmeticTypes2;
									num = 4;
								}
								if (num == 10)
								{
									goto IL_2F7;
								}
								if (num == 45)
								{
									goto IL_334;
								}
								if (num == 8)
								{
									if (arithmeticTypes2 == ArithmeticTypes.Sub)
									{
										goto IL_5A6;
									}
									num = 9;
								}
								if (num == 35)
								{
									goto IL_380;
								}
								if (num == 22)
								{
									goto IL_3B3;
								}
								if (num == 15)
								{
									goto IL_402;
								}
								if (num == 24)
								{
									goto IL_426;
								}
								if (num == 6)
								{
									goto IL_990;
								}
								if (num == 21)
								{
									goto IL_469;
								}
								if (num == 23)
								{
									goto IL_48D;
								}
								if (num != 12)
								{
									if (num == 13)
									{
										goto IL_4E4;
									}
									if (num == 27)
									{
										goto IL_533;
									}
									if (num == 40)
									{
										goto IL_557;
									}
									if (num == 11)
									{
										goto IL_5A6;
									}
									if (num == 42)
									{
										goto IL_5E3;
									}
									if (num != 9)
									{
										if (num == 25)
										{
											goto IL_626;
										}
										if (num == 7)
										{
											goto IL_675;
										}
										goto IL_687;
									}
								}
								return -1.0;
								IL_5A6:
								return this.x - Math.Abs(this.y) * -1.0;
								IL_675:
								if (arithmeticTypes2 != ArithmeticTypes.Add)
								{
									num = 8;
									goto IL_687;
								}
								goto IL_2F7;
								IL_1C4:
								return this.x + Math.Truncate(this.y);
								IL_1F7:
								if (arithmeticTypes2 == ArithmeticTypes.Add)
								{
									return this.x - Math.Truncate(this.y);
								}
								if (arithmeticTypes2 != ArithmeticTypes.Sub)
								{
									goto IL_334;
								}
								goto IL_1C4;
								IL_279:
								return this.x + Math.Sin(this.y);
								IL_2AC:
								return -1.0;
								IL_2F7:
								return this.x + Math.Abs(this.y) * -1.0;
								IL_334:
								return -1.0;
								IL_380:
								return this.x + Math.Tanh(this.y);
								IL_3B3:
								if (arithmeticTypes2 == ArithmeticTypes.Add)
								{
									return this.x - Math.Cos(this.y);
								}
								if (arithmeticTypes2 != ArithmeticTypes.Sub)
								{
									goto IL_426;
								}
								goto IL_48D;
								IL_402:
								return -1.0;
								IL_426:
								return -1.0;
								IL_469:
								return -1.0;
								IL_48D:
								return this.x + Math.Cos(this.y);
								IL_4E4:
								if (arithmeticTypes2 == ArithmeticTypes.Add)
								{
									return this.x - Math.Log(this.y);
								}
								if (arithmeticTypes2 != ArithmeticTypes.Sub)
								{
									goto IL_402;
								}
								goto IL_92;
								IL_533:
								return -1.0;
								IL_557:
								if (arithmeticTypes2 == ArithmeticTypes.Add)
								{
									return this.x - Math.Ceiling(this.y);
								}
								if (arithmeticTypes2 == ArithmeticTypes.Sub)
								{
									goto IL_73E;
								}
								IL_5E3:
								return -1.0;
								IL_626:
								if (arithmeticTypes2 == ArithmeticTypes.Add)
								{
									return this.x - Math.Floor(this.y);
								}
								if (arithmeticTypes2 != ArithmeticTypes.Sub)
								{
									goto IL_533;
								}
								goto IL_70B;
								IL_698:
								if (arithmeticTypes2 == ArithmeticTypes.Add)
								{
									return this.x - Math.Sqrt(this.y);
								}
								if (arithmeticTypes2 != ArithmeticTypes.Sub)
								{
									break;
								}
								goto IL_7F9;
								IL_70B:
								return this.x + Math.Floor(this.y);
								IL_73E:
								return this.x + Math.Ceiling(this.y);
								IL_7AA:
								if (arithmeticTypes2 == ArithmeticTypes.Add)
								{
									return this.x - Math.Tanh(this.y);
								}
								if (arithmeticTypes2 != ArithmeticTypes.Sub)
								{
									goto IL_2AC;
								}
								goto IL_380;
								IL_7F9:
								return this.x + Math.Sqrt(this.y);
								IL_82C:
								if (arithmeticTypes2 == ArithmeticTypes.Add)
								{
									return this.x - Math.Sin(this.y);
								}
								if (arithmeticTypes2 != ArithmeticTypes.Sub)
								{
									goto IL_469;
								}
								goto IL_279;
								IL_89E:
								if (arithmeticTypes2 == ArithmeticTypes.Add)
								{
									return this.x - Math.Tan(this.y);
								}
								if (arithmeticTypes2 == ArithmeticTypes.Sub)
								{
									goto IL_114;
								}
								IL_914:
								return -1.0;
								IL_990:
								return -1.0;
							}
							IL_114:
							return this.x + Math.Tan(this.y);
						}
						IL_C5:
						if (arithmeticTypes2 == ArithmeticTypes.Add)
						{
							return this.x - Math.Log10(this.y);
						}
						if (arithmeticTypes2 == ArithmeticTypes.Sub)
						{
							goto IL_938;
						}
						IL_6E7:
						return -1.0;
						IL_938:
						return this.x + Math.Log10(this.y);
					}
					IL_92:
					return this.x + Math.Log(this.y);
				}
				IL_43:
				if (arithmeticTypes2 == ArithmeticTypes.Add)
				{
					return this.x - Math.Round(this.y);
				}
				if (arithmeticTypes2 == ArithmeticTypes.Sub)
				{
					goto IL_246;
				}
				IL_1A0:
				return -1.0;
				IL_246:
				return this.x + Math.Round(this.y);
			}
			return -1.0;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00009C28 File Offset: 0x00007E28
		public double GetY()
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
			return this.y;
		}

		// Token: 0x0400001C RID: 28
		private readonly double x;

		// Token: 0x0400001D RID: 29
		private readonly double y;

		// Token: 0x0400001E RID: 30
		private readonly ArithmeticTypes arithmeticTypes;
	}
}

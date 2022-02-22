using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Rose.Protections
{
	// Token: 0x0200000D RID: 13
	internal static class AntiDump
	{
		// Token: 0x06000023 RID: 35
		[DllImport("kernel32.dll")]
		private unsafe static extern bool VirtualProtect(byte* lpAddress, int dwSize, uint flNewProtect, out uint lpflOldProtect);

		// Token: 0x06000024 RID: 36 RVA: 0x00004C8C File Offset: 0x00002E8C
		public unsafe static void ZETRO()
		{
			short num = 0;
			for (;;)
			{
				if (num != 165)
				{
					goto IL_44;
				}
				uint num2;
				uint[] array;
				int num3;
				uint[] array2;
				if (num2 < array[num3] + array2[num3])
				{
					num = 166;
					goto IL_44;
				}
				goto IL_15C9;
				IL_229D:
				byte* ptr;
				if (num == 208)
				{
					ptr++;
					num = 209;
				}
				if (num == 206)
				{
					goto IL_115;
				}
				byte* ptr2;
				if (num == 74)
				{
					if (*ptr2 != 0)
					{
						goto IL_1CBB;
					}
					num = 75;
				}
				byte* ptr3;
				if (num == 49)
				{
					*(int*)(ptr3 + (IntPtr)2 * 4) = 0;
					num = 50;
				}
				byte* ptr5;
				byte* ptr4;
				if (num == 3)
				{
					ptr4 = ptr5 + 60;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 223)
				{
					return;
				}
				continue;
				IL_224E:
				if (num == 75)
				{
					ptr2 += 2;
					num = 76;
				}
				if (num == 222)
				{
					goto IL_2287;
				}
				goto IL_229D;
				IL_21CD:
				int num4;
				if (num == 157)
				{
					num4 = 0;
					num = 158;
				}
				byte* ptr6;
				if (num == 10)
				{
					ptr6 = stackalloc byte[checked(unchecked((UIntPtr)11) * 1)];
					num = 11;
				}
				if (num == 61)
				{
					goto IL_222D;
				}
				goto IL_224E;
				IL_1F2B:
				int num5;
				if (num == 94)
				{
					num5 = 0;
					num = 95;
				}
				uint num6;
				int num7;
				if (num == 108)
				{
					if (num6 >= array[num7] + array2[num7])
					{
						goto IL_13C9;
					}
					num = 109;
				}
				if (num == 53)
				{
					ptr2 += 12;
					num = 54;
				}
				if (num == 32)
				{
					ptr6[10] = 0;
					num = 33;
				}
				if (num == 63)
				{
					ptr2 += 4;
					num = 64;
				}
				int num8;
				if (num == 23)
				{
					num8 = 0;
					num = 24;
				}
				if (num == 39)
				{
					goto IL_1D34;
				}
				if (num == 42)
				{
					ptr4 += 40;
					num = 43;
				}
				if (num == 69)
				{
					if (*ptr2 != 0)
					{
						goto IL_13F1;
					}
					num = 70;
				}
				int num9;
				if (num == 36)
				{
					num9++;
					num = 37;
				}
				if (num == 47)
				{
					*(int*)ptr3 = 0;
					num = 48;
				}
				uint num10;
				int num11;
				if (num == 176)
				{
					if (num10 >= array[num11] + array2[num11])
					{
						goto IL_ED;
					}
					num = 177;
				}
				if (num == 178)
				{
					goto IL_1733;
				}
				uint num12;
				if (num == 45)
				{
					AntiDump.VirtualProtect(ptr3, 72, 64U, out num12);
					num = 46;
				}
				if (num == 216)
				{
					goto IL_115;
				}
				ushort num13;
				if (num == 57)
				{
					num13 = (ushort)(*ptr2);
					num = 58;
				}
				if (num == 164)
				{
					goto IL_21B2;
				}
				goto IL_21CD;
				IL_1EA4:
				byte* ptr7;
				if (num == 172)
				{
					num10 = *(uint*)(ptr7 + 8);
					num = 173;
				}
				uint[] array3;
				if (num == 166)
				{
					num2 = num2 - array[num3] + array3[num3];
					num = 167;
				}
				if (num == 220)
				{
					goto IL_1F14;
				}
				goto IL_1F2B;
				IL_1E31:
				if (num == 7)
				{
					ptr4 += 14;
					num = 8;
				}
				int num14;
				if (num == 147)
				{
					num14 = 0;
					num = 148;
				}
				if (num == 27)
				{
					goto IL_1E8D;
				}
				goto IL_1EA4;
				IL_1DA3:
				if (num == 174)
				{
					goto IL_28D;
				}
				if (num == 187)
				{
					*(int*)ptr = 0;
					num = 188;
				}
				ushort num15;
				if (num == 192)
				{
					num15 = (ushort)(*ptr);
					num = 193;
				}
				if (num == 151)
				{
					goto IL_1E1A;
				}
				goto IL_1E31;
				IL_1D71:
				if (num == 201)
				{
					goto IL_1D82;
				}
				goto IL_1DA3;
				IL_1D4A:
				if (num == 112)
				{
					goto IL_1D5B;
				}
				goto IL_1D71;
				IL_1CCE:
				if (num == 171)
				{
					AntiDump.VirtualProtect(ptr7, 72, 64U, out num12);
					num = 172;
				}
				ushort num16;
				if (num == 6)
				{
					num16 = *(ushort*)ptr4;
					num = 7;
				}
				if (num == 44)
				{
					goto IL_1D34;
				}
				goto IL_1D4A;
				IL_1C50:
				uint num17;
				int num18;
				if (num == 138)
				{
					num17 = num17 - array[num18] + array3[num18];
					num = 139;
				}
				if (num == 153)
				{
					*(int*)ptr6 = 1866691662;
					num = 154;
				}
				if (num == 77)
				{
					goto IL_1CBB;
				}
				goto IL_1CCE;
				IL_1BAF:
				if (num == 81)
				{
					goto IL_157E;
				}
				if (num == 41)
				{
					Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr4), 8);
					num = 42;
				}
				if (num == 200)
				{
					goto IL_1F14;
				}
				if (num == 141)
				{
					goto IL_1C3A;
				}
				goto IL_1C50;
				IL_1B8B:
				if (num == 82)
				{
					goto IL_1B9C;
				}
				goto IL_1BAF;
				IL_1AF8:
				if (num == 12)
				{
					ptr3 = ptr5 + *(uint*)(ptr4 - 16);
					num = 13;
				}
				uint num19;
				int num20;
				if (num == 118)
				{
					if (num19 >= array[num20] + array2[num20])
					{
						goto IL_67C;
					}
					num = 119;
				}
				if (num == 25)
				{
					goto IL_1B6E;
				}
				goto IL_1B8B;
				IL_1ACC:
				if (num == 175)
				{
					goto IL_1ADD;
				}
				goto IL_1AF8;
				IL_19F8:
				if (num == 31)
				{
					*(short*)(ptr6 + (IntPtr)4 * 2) = 25973;
					num = 32;
				}
				if (num == 20)
				{
					*(int*)(ptr6 + 4) = 1818504812;
					num = 21;
				}
				if (num == 156)
				{
					ptr6[10] = 0;
					num = 157;
				}
				if (num == 104)
				{
					if (num6 == 0U)
					{
						goto IL_659;
					}
					num = 105;
				}
				if (num == 107)
				{
					goto IL_1AB1;
				}
				goto IL_1ACC;
				IL_19A3:
				if (num == 9)
				{
					ushort num21;
					ptr4 = ptr4 + 4 + num21;
					num = 10;
				}
				if (num == 38)
				{
					goto IL_19E6;
				}
				goto IL_19F8;
				IL_18D9:
				if (num == 100)
				{
					array3[num5] = *(uint*)(ptr4 + 20);
					num = 101;
				}
				if (num == 26)
				{
					num8++;
					num = 27;
				}
				byte* ptr8;
				uint num22;
				if (num == 124)
				{
					num22 = *(uint*)(ptr8 + 12);
					num = 125;
				}
				if (num == 106)
				{
					goto IL_1D5B;
				}
				if (num == 117)
				{
					goto IL_1988;
				}
				goto IL_19A3;
				IL_1826:
				if (num == 198)
				{
					ptr += 4;
					num = 199;
				}
				int num23;
				if (num == 129)
				{
					num22 = num22 - array[num23] + array3[num23];
					num = 130;
				}
				if (num == 99)
				{
					array2[num5] = *(uint*)(ptr4 + 8);
					num = 100;
				}
				if (num == 169)
				{
					goto IL_18C3;
				}
				goto IL_18D9;
				IL_17C9:
				if (num == 177)
				{
					num10 = num10 - array[num11] + array3[num11];
					num = 178;
				}
				if (num == 132)
				{
					goto IL_1810;
				}
				goto IL_1826;
				IL_1746:
				if (num == 13)
				{
					if (*(uint*)(ptr4 - 120) == 0U)
					{
						goto IL_19E6;
					}
					num = 14;
				}
				if (num == 145)
				{
					*(short*)(ptr6 + (IntPtr)4 * 2) = 108;
					num = 146;
				}
				if (num == 37)
				{
					goto IL_17B2;
				}
				goto IL_17C9;
				IL_1722:
				if (num == 181)
				{
					goto IL_1733;
				}
				goto IL_1746;
				IL_15E0:
				if (num == 76)
				{
					goto IL_157E;
				}
				if (num == 5)
				{
					ptr4 += 6;
					num = 6;
				}
				if (num == 143)
				{
					*(int*)ptr6 = 1818522734;
					num = 144;
				}
				if (num == 184)
				{
					*(int*)(ptr7 + (IntPtr)3 * 4) = 0;
					num = 185;
				}
				if (num == 105)
				{
					num7 = 0;
					num = 106;
				}
				if (num == 71)
				{
					goto IL_157E;
				}
				if (num == 190)
				{
					ptr = (ptr + 7L & -4L);
					num = 191;
				}
				if (num == 196)
				{
					goto IL_1701;
				}
				goto IL_1722;
				IL_1595:
				int num24;
				if (num == 59)
				{
					num24 = 0;
					num = 60;
				}
				if (num == 168)
				{
					goto IL_15C9;
				}
				goto IL_15E0;
				IL_1404:
				if (num == 58)
				{
					ptr2 += 2;
					num = 59;
				}
				if (num == 213)
				{
					ptr++;
					num = 214;
				}
				if (num == 128)
				{
					if (num22 >= array[num23] + array2[num23])
					{
						goto IL_107E;
					}
					num = 129;
				}
				if (num == 185)
				{
					ptr = ptr5 + num10;
					num = 186;
				}
				byte* ptr9;
				if (num == 28)
				{
					AntiDump.VirtualProtect(ptr9, 11, 64U, out num12);
					num = 29;
				}
				if (num == 158)
				{
					goto IL_A47;
				}
				if (num == 120)
				{
					goto IL_118A;
				}
				if (num == 83)
				{
					ptr2++;
					num = 84;
				}
				if (num == 134)
				{
					num18 = 0;
					num = 135;
				}
				if (num == 86)
				{
					goto IL_157E;
				}
				goto IL_1595;
				IL_13E0:
				if (num == 72)
				{
					goto IL_13F1;
				}
				goto IL_1404;
				IL_13B8:
				if (num == 111)
				{
					goto IL_13C9;
				}
				goto IL_13E0;
				IL_1235:
				if (num == 21)
				{
					*(short*)(ptr6 + (IntPtr)4 * 2) = 108;
					num = 22;
				}
				if (num == 68)
				{
					ptr2++;
					num = 69;
				}
				if (num == 14)
				{
					byte* ptr10 = ptr5 + *(uint*)(ptr4 - 120);
					num = 15;
				}
				if (num == 210)
				{
					ptr += 2;
					num = 211;
				}
				if (num == 144)
				{
					*(int*)(ptr6 + 4) = 1818504812;
					num = 145;
				}
				int num25;
				if (num == 199)
				{
					num25 = 0;
					num = 200;
				}
				if (num == 218)
				{
					ptr++;
					num = 219;
				}
				if (num == 2)
				{
					Module module;
					ptr5 = (byte*)((void*)Marshal.GetHINSTANCE(module));
					num = 3;
				}
				if (num == 96)
				{
					goto IL_1397;
				}
				goto IL_13B8;
				IL_11A1:
				if (num == 110)
				{
					goto IL_839;
				}
				if (num == 80)
				{
					ptr2++;
					num = 81;
				}
				if (num == 126)
				{
					goto IL_1810;
				}
				if (num == 35)
				{
					goto IL_1218;
				}
				goto IL_1235;
				IL_1123:
				if (num == 4)
				{
					ptr4 = ptr5 + *(uint*)ptr4;
					num = 5;
				}
				if (num == 215)
				{
					ptr++;
					num = 216;
				}
				if (num == 123)
				{
					goto IL_118A;
				}
				goto IL_11A1;
				IL_10FA:
				if (num == 133)
				{
					goto IL_110B;
				}
				goto IL_1123;
				IL_1095:
				if (num == 155)
				{
					*(short*)(ptr6 + (IntPtr)4 * 2) = 25973;
					num = 156;
				}
				if (num == 159)
				{
					goto IL_10D7;
				}
				goto IL_10FA;
				IL_F94:
				if (num == 137)
				{
					if (num17 >= array[num18] + array2[num18])
					{
						goto IL_E89;
					}
					num = 138;
				}
				if (num == 139)
				{
					goto IL_925;
				}
				if (num == 1)
				{
					Module module = typeof(AntiDump).Module;
					num = 2;
				}
				int num26;
				if (num == 43)
				{
					num26++;
					num = 44;
				}
				if (num == 46)
				{
					ptr2 = ptr5 + *(uint*)(ptr3 + 8);
					num = 47;
				}
				if (num == 131)
				{
					goto IL_107E;
				}
				goto IL_1095;
				IL_EA0:
				if (num == 135)
				{
					goto IL_1C3A;
				}
				if (num == 130)
				{
					goto IL_110B;
				}
				byte* ptr11;
				if (num == 18)
				{
					AntiDump.VirtualProtect(ptr11, 11, 64U, out num12);
					num = 19;
				}
				if (num == 73)
				{
					ptr2++;
					num = 74;
				}
				if (num == 102)
				{
					num5++;
					num = 103;
				}
				if (num == 149)
				{
					goto IL_F71;
				}
				goto IL_F94;
				IL_D95:
				if (num == 219)
				{
					num25++;
					num = 220;
				}
				if (num == 188)
				{
					ptr += 12;
					num = 189;
				}
				if (num == 214)
				{
					if (*ptr != 0)
					{
						goto IL_7C;
					}
					num = 215;
				}
				if (num == 33)
				{
					num9 = 0;
					num = 34;
				}
				if (num == 115)
				{
					num20 = 0;
					num = 116;
				}
				if (num == 54)
				{
					ptr2 += *(uint*)ptr2;
					num = 55;
				}
				if (num == 140)
				{
					goto IL_E89;
				}
				goto IL_EA0;
				IL_C1B:
				int num27;
				if (num == 64)
				{
					num27 = 0;
					num = 65;
				}
				if (num == 203)
				{
					ptr++;
					num = 204;
				}
				if (num == 167)
				{
					goto IL_4D4;
				}
				if (num == 193)
				{
					ptr += 2;
					num = 194;
				}
				if (num == 182)
				{
					*(int*)(ptr7 + 4) = 0;
					num = 183;
				}
				if (num == 152)
				{
					AntiDump.VirtualProtect(ptr5 + num17, 11, 64U, out num12);
					num = 153;
				}
				if (num == 109)
				{
					num6 = num6 - array[num7] + array3[num7];
					num = 110;
				}
				if (num == 29)
				{
					*(int*)ptr6 = 1866691662;
					num = 30;
				}
				if (num == 127)
				{
					goto IL_D7A;
				}
				goto IL_D95;
				IL_B08:
				if (num == 173)
				{
					num11 = 0;
					num = 174;
				}
				if (num == 191)
				{
					ptr += 2;
					num = 192;
				}
				if (num == 209)
				{
					if (*ptr != 0)
					{
						goto IL_C9;
					}
					num = 210;
				}
				if (num == 79)
				{
					if (*ptr2 != 0)
					{
						goto IL_1B9C;
					}
					num = 80;
				}
				if (num == 30)
				{
					*(int*)(ptr6 + 4) = 1852404846;
					num = 31;
				}
				if (num == 67)
				{
					*ptr2 = 0;
					num = 68;
				}
				if (num == 40)
				{
					goto IL_BFA;
				}
				goto IL_C1B;
				IL_A5E:
				if (num == 50)
				{
					*(int*)(ptr3 + (IntPtr)3 * 4) = 0;
					num = 51;
				}
				int num28;
				if (num == 194)
				{
					num28 = 0;
					num = 195;
				}
				if (num == 204)
				{
					if (*ptr != 0)
					{
						goto IL_158;
					}
					num = 205;
				}
				if (num == 66)
				{
					goto IL_AE7;
				}
				goto IL_B08;
				IL_9EF:
				if (num == 70)
				{
					ptr2 += 3;
					num = 71;
				}
				if (num == 95)
				{
					goto IL_8AD;
				}
				if (num == 161)
				{
					goto IL_A47;
				}
				goto IL_A5E;
				IL_9C8:
				if (num == 122)
				{
					goto IL_9D9;
				}
				goto IL_9EF;
				IL_94C:
				if (num == 62)
				{
					ptr2 += 4;
					num = 63;
				}
				if (num == 56)
				{
					ptr2 += 2;
					num = 57;
				}
				if (num == 136)
				{
					goto IL_9AD;
				}
				goto IL_9C8;
				IL_8C3:
				if (num == 116)
				{
					goto IL_9D9;
				}
				if (num == 51)
				{
					AntiDump.VirtualProtect(ptr2, 4, 64U, out num12);
					num = 52;
				}
				if (num == 142)
				{
					goto IL_925;
				}
				goto IL_94C;
				IL_850:
				if (num == 15)
				{
					byte* ptr10;
					byte* ptr12 = ptr5 + *(uint*)ptr10;
					num = 16;
				}
				if (num == 125)
				{
					num23 = 0;
					num = 126;
				}
				if (num == 103)
				{
					goto IL_8AD;
				}
				goto IL_8C3;
				IL_693:
				if (num == 163)
				{
					goto IL_18C3;
				}
				if (num == 52)
				{
					*(int*)ptr2 = 0;
					num = 53;
				}
				if (num == 17)
				{
					byte* ptr12;
					ptr9 = ptr5 + *(uint*)ptr12 + 2;
					num = 18;
				}
				if (num == 90)
				{
					num6 = *(uint*)(ptr4 - 120);
					num = 91;
				}
				if (num == 48)
				{
					*(int*)(ptr3 + 4) = 0;
					num = 49;
				}
				if (num == 146)
				{
					ptr6[10] = 0;
					num = 147;
				}
				if (num == 205)
				{
					ptr += 3;
					num = 206;
				}
				if (num == 19)
				{
					*(int*)ptr6 = 1818522734;
					num = 20;
				}
				if (num == 119)
				{
					num19 = num19 - array[num20] + array3[num20];
					num = 120;
				}
				if (num == 202)
				{
					*ptr = 0;
					num = 203;
				}
				if (num == 113)
				{
					goto IL_839;
				}
				goto IL_850;
				IL_66B:
				if (num == 121)
				{
					goto IL_67C;
				}
				goto IL_693;
				IL_4EB:
				if (num == 189)
				{
					ptr += *(uint*)ptr;
					num = 190;
				}
				if (num == 93)
				{
					array3 = new uint[(int)num16];
					num = 94;
				}
				if (num == 16)
				{
					byte* ptr10;
					ptr11 = ptr5 + *(uint*)(ptr10 + 12);
					num = 17;
				}
				if (num == 160)
				{
					num4++;
					num = 161;
				}
				if (num == 60)
				{
					goto IL_47B;
				}
				if (num == 183)
				{
					*(int*)(ptr7 + (IntPtr)2 * 4) = 0;
					num = 184;
				}
				if (num == 65)
				{
					goto IL_453;
				}
				if (num == 24)
				{
					goto IL_1E8D;
				}
				if (num == 78)
				{
					ptr2++;
					num = 79;
				}
				if (num == 162)
				{
					goto IL_659;
				}
				goto IL_66B;
				IL_491:
				if (num == 186)
				{
					AntiDump.VirtualProtect(ptr, 4, 64U, out num12);
					num = 187;
				}
				if (num == 170)
				{
					goto IL_4D4;
				}
				goto IL_4EB;
				IL_46A:
				if (num == 87)
				{
					goto IL_47B;
				}
				goto IL_491;
				IL_2A3:
				if (num == 22)
				{
					ptr6[10] = 0;
					num = 23;
				}
				if (num == 197)
				{
					ptr += 4;
					num = 198;
				}
				if (num == 11)
				{
					Module module;
					if (module.FullyQualifiedName[0] == '<')
					{
						goto IL_A0;
					}
					num = 12;
				}
				if (num == 114)
				{
					num19 = *(uint*)ptr8;
					num = 115;
				}
				if (num == 154)
				{
					*(int*)(ptr6 + 4) = 1852404846;
					num = 155;
				}
				if (num == 211)
				{
					goto IL_115;
				}
				if (num == 195)
				{
					goto IL_2287;
				}
				if (num == 92)
				{
					array2 = new uint[(int)num16];
					num = 93;
				}
				if (num == 97)
				{
					Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr4), 8);
					num = 98;
				}
				if (num == 84)
				{
					num27++;
					num = 85;
				}
				if (num == 85)
				{
					goto IL_453;
				}
				goto IL_46A;
				IL_16B:
				if (num == 8)
				{
					ushort num21 = *(ushort*)ptr4;
					num = 9;
				}
				if (num == 101)
				{
					ptr4 += 40;
					num = 102;
				}
				if (num == 150)
				{
					num14++;
					num = 151;
				}
				if (num == 148)
				{
					goto IL_1E1A;
				}
				if (num == 55)
				{
					ptr2 = (ptr2 + 7L & -4L);
					num = 56;
				}
				if (num == 98)
				{
					array[num5] = *(uint*)(ptr4 + 12);
					num = 99;
				}
				if (num == 34)
				{
					goto IL_17B2;
				}
				if (num == 180)
				{
					goto IL_28D;
				}
				goto IL_2A3;
				IL_12C:
				if (num == 88)
				{
					break;
				}
				if (num == 207)
				{
					goto IL_158;
				}
				goto IL_16B;
				IL_104:
				if (num == 221)
				{
					goto IL_115;
				}
				goto IL_12C;
				IL_DC:
				if (num == 179)
				{
					goto IL_ED;
				}
				goto IL_104;
				IL_B8:
				if (num == 212)
				{
					goto IL_C9;
				}
				goto IL_DC;
				IL_8F:
				if (num == 89)
				{
					goto IL_A0;
				}
				goto IL_B8;
				IL_44:
				if (num == 91)
				{
					array = new uint[(int)num16];
					num = 92;
				}
				if (num == 217)
				{
					goto IL_7C;
				}
				goto IL_8F;
				IL_2287:
				if (num28 >= (int)num15)
				{
					num = 223;
					goto IL_229D;
				}
				goto IL_1701;
				IL_222D:
				AntiDump.VirtualProtect(ptr2, 8, 64U, out num12);
				num = 62;
				goto IL_224E;
				IL_47B:
				if (num24 >= (int)num13)
				{
					num = 88;
					goto IL_491;
				}
				goto IL_222D;
				IL_21B2:
				if (array[num3] <= num2)
				{
					num = 165;
					goto IL_21CD;
				}
				goto IL_15C9;
				IL_18C3:
				if (num3 >= (int)num16)
				{
					num = 170;
					goto IL_18D9;
				}
				goto IL_21B2;
				IL_1F14:
				if (num25 >= 8)
				{
					num = 221;
					goto IL_1F2B;
				}
				goto IL_1D82;
				IL_1E8D:
				if (num8 >= 11)
				{
					num = 28;
					goto IL_1EA4;
				}
				goto IL_1B6E;
				IL_1E1A:
				if (num14 >= 11)
				{
					num = 152;
					goto IL_1E31;
				}
				goto IL_F71;
				IL_1D82:
				AntiDump.VirtualProtect(ptr, 4, 64U, out num12);
				num = 202;
				goto IL_1DA3;
				IL_1D5B:
				if (num7 >= (int)num16)
				{
					num = 113;
					goto IL_1D71;
				}
				goto IL_1AB1;
				IL_1D34:
				if (num26 >= (int)num16)
				{
					num = 45;
					goto IL_1D4A;
				}
				goto IL_BFA;
				IL_1CBB:
				*ptr2 = 0;
				num = 78;
				goto IL_1CCE;
				IL_1C3A:
				if (num18 >= (int)num16)
				{
					num = 142;
					goto IL_1C50;
				}
				goto IL_9AD;
				IL_1B9C:
				*ptr2 = 0;
				num = 83;
				goto IL_1BAF;
				IL_1B6E:
				ptr11[num8] = ptr6[num8];
				num = 26;
				goto IL_1B8B;
				IL_1ADD:
				if (array[num11] <= num10)
				{
					num = 176;
					goto IL_1AF8;
				}
				goto IL_ED;
				IL_28D:
				if (num11 >= (int)num16)
				{
					num = 181;
					goto IL_2A3;
				}
				goto IL_1ADD;
				IL_1AB1:
				if (array[num7] <= num6)
				{
					num = 108;
					goto IL_1ACC;
				}
				goto IL_13C9;
				IL_19E6:
				num26 = 0;
				num = 39;
				goto IL_19F8;
				IL_1988:
				if (array[num20] <= num19)
				{
					num = 118;
					goto IL_19A3;
				}
				goto IL_67C;
				IL_9D9:
				if (num20 >= (int)num16)
				{
					num = 123;
					goto IL_9EF;
				}
				goto IL_1988;
				IL_1810:
				if (num23 >= (int)num16)
				{
					num = 133;
					goto IL_1826;
				}
				goto IL_D7A;
				IL_17B2:
				if (num9 >= 11)
				{
					num = 38;
					goto IL_17C9;
				}
				goto IL_1218;
				IL_1733:
				*(int*)ptr7 = 0;
				num = 182;
				goto IL_1746;
				IL_1701:
				AntiDump.VirtualProtect(ptr, 8, 64U, out num12);
				num = 197;
				goto IL_1722;
				IL_15C9:
				num3++;
				num = 169;
				goto IL_15E0;
				IL_157E:
				num24++;
				num = 87;
				goto IL_1595;
				IL_13F1:
				*ptr2 = 0;
				num = 73;
				goto IL_1404;
				IL_13C9:
				num7++;
				num = 112;
				goto IL_13E0;
				IL_1397:
				AntiDump.VirtualProtect(ptr4, 8, 64U, out num12);
				num = 97;
				goto IL_13B8;
				IL_8AD:
				if (num5 >= (int)num16)
				{
					num = 104;
					goto IL_8C3;
				}
				goto IL_1397;
				IL_1218:
				ptr9[num9] = ptr6[num9];
				num = 36;
				goto IL_1235;
				IL_118A:
				byte* ptr13 = ptr5 + num19;
				num = 124;
				goto IL_11A1;
				IL_110B:
				num17 = *(uint*)ptr13 + 2U;
				num = 134;
				goto IL_1123;
				IL_10D7:
				(ptr5 + num17)[num4] = ptr6[num4];
				num = 160;
				goto IL_10FA;
				IL_A47:
				if (num4 >= 11)
				{
					num = 162;
					goto IL_A5E;
				}
				goto IL_10D7;
				IL_107E:
				num23++;
				num = 132;
				goto IL_1095;
				IL_D7A:
				if (array[num23] <= num22)
				{
					num = 128;
					goto IL_D95;
				}
				goto IL_107E;
				IL_F71:
				(ptr5 + num22)[num14] = ptr6[num14];
				num = 150;
				goto IL_F94;
				IL_E89:
				num18++;
				num = 141;
				goto IL_EA0;
				IL_9AD:
				if (array[num18] <= num17)
				{
					num = 137;
					goto IL_9C8;
				}
				goto IL_E89;
				IL_BFA:
				AntiDump.VirtualProtect(ptr4, 8, 64U, out num12);
				num = 41;
				goto IL_C1B;
				IL_AE7:
				AntiDump.VirtualProtect(ptr2, 4, 64U, out num12);
				num = 67;
				goto IL_B08;
				IL_453:
				if (num27 >= 8)
				{
					num = 86;
					goto IL_46A;
				}
				goto IL_AE7;
				IL_925:
				AntiDump.VirtualProtect(ptr5 + num22, 11, 64U, out num12);
				num = 143;
				goto IL_94C;
				IL_839:
				ptr8 = ptr5 + num6;
				num = 114;
				goto IL_850;
				IL_67C:
				num20++;
				num = 122;
				goto IL_693;
				IL_659:
				num3 = 0;
				num = 163;
				goto IL_66B;
				IL_4D4:
				ptr7 = ptr5 + num2;
				num = 171;
				goto IL_4EB;
				IL_158:
				*ptr = 0;
				num = 208;
				goto IL_16B;
				IL_115:
				num28++;
				num = 222;
				goto IL_12C;
				IL_ED:
				num11++;
				num = 180;
				goto IL_104;
				IL_C9:
				*ptr = 0;
				num = 213;
				goto IL_DC;
				IL_A0:
				num2 = *(uint*)(ptr4 - 16);
				num = 90;
				goto IL_B8;
				IL_7C:
				*ptr = 0;
				num = 218;
				goto IL_8F;
			}
		}
	}
}

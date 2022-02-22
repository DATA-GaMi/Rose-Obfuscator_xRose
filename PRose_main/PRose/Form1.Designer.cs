namespace PRose
{
	// Token: 0x02000076 RID: 118
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x0001FDD4 File Offset: 0x0001DFD4
		protected override void Dispose(bool disposing)
		{
			short num = 0;
			for (;;)
			{
				if (num != 1)
				{
					goto IL_31;
				}
				if (disposing)
				{
					num = 2;
					goto IL_31;
				}
				goto IL_6A;
				IL_80:
				if (num == 2)
				{
					if (this.components == null)
					{
						goto IL_6A;
					}
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					break;
				}
				continue;
				IL_31:
				if (num == 3)
				{
					this.components.Dispose();
					num = 4;
				}
				if (num != 4)
				{
					goto IL_80;
				}
				IL_6A:
				base.Dispose(disposing);
				num = 5;
				goto IL_80;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
		private void InitializeComponent()
		{
			short num = 0;
			do
			{
				if (num == 681)
				{
					this.siticoneLabel6.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 682;
				}
				if (num == 1530)
				{
					base.Controls.Add(this.siticonePanel2);
					num = 1531;
				}
				if (num == 1192)
				{
					this.siticoneLabel12.IsContextMenuEnabled = false;
					num = 1193;
				}
				if (num == 830)
				{
					this.facebook.BackColor = global::System.Drawing.Color.Transparent;
					num = 831;
				}
				if (num == 93)
				{
					this.siticonePanel7 = new global::ns1.SiticonePanel();
					num = 94;
				}
				if (num == 963)
				{
					this.adump.Location = new global::System.Drawing.Point(15, 57);
					num = 964;
				}
				if (num == 215)
				{
					this.siticonePanel6.Name = "siticonePanel6";
					num = 216;
				}
				if (num == 173)
				{
					this.hnamespaces.AutoSize = true;
					num = 174;
				}
				if (num == 1185)
				{
					this.siticoneLabel11.Size = new global::System.Drawing.Size(75, 17);
					num = 1186;
				}
				if (num == 658)
				{
					this.cflow.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 659;
				}
				if (num == 1123)
				{
					this.siticoneSeparator1.Location = new global::System.Drawing.Point(162, 270);
					num = 1124;
				}
				if (num == 556)
				{
					this.sconfusion.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 557;
				}
				if (num == 1210)
				{
					this.SymbolsType.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1211;
				}
				if (num == 765)
				{
					this.siticoneLabel8.UseGdiPlusTextRendering = true;
					num = 766;
				}
				if (num == 642)
				{
					this.adebug.Name = "adebug";
					num = 643;
				}
				if (num == 1369)
				{
					this.renamer2.TextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1370;
				}
				if (num == 899)
				{
					this.asciisenc.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 900;
				}
				if (num == 184)
				{
					this.hnamespaces.TabIndex = 22;
					num = 185;
				}
				if (num == 773)
				{
					this.siticoneLabel2.Name = "siticoneLabel2";
					num = 774;
				}
				if (num == 1113)
				{
					this.siticoneLabel18.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1114;
				}
				if (num == 481)
				{
					this.mstrip.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 482;
				}
				if (num == 824)
				{
					this.logo.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 825;
				}
				if (num == 131)
				{
					this.pint.UncheckedState.BorderRadius = 1;
					num = 132;
				}
				if (num == 334)
				{
					this.siticoneLabel1.Location = new global::System.Drawing.Point(310, 129);
					num = 335;
				}
				if (num == 445)
				{
					this.invalidmd.Size = new global::System.Drawing.Size(163, 21);
					num = 446;
				}
				if (num == 754)
				{
					this.siticoneLabel9.Click += new global::System.EventHandler(this.siticoneLabel9_Click);
					num = 755;
				}
				if (num == 53)
				{
					this.min = new global::ns1.SiticoneImageButton();
					num = 54;
				}
				if (num == 314)
				{
					this.browse.CustomImages.Parent = this.browse;
					num = 315;
				}
				if (num == 150)
				{
					this.cryptosenc.UncheckedState.BorderRadius = 1;
					num = 151;
				}
				if (num == 288)
				{
					this.assemblytext.DisabledState.Parent = this.assemblytext;
					num = 289;
				}
				if (num == 550)
				{
					this.omethods.UseVisualStyleBackColor = true;
					num = 551;
				}
				if (num == 1)
				{
					this.components = new global::System.ComponentModel.Container();
					num = 2;
				}
				if (num == 1342)
				{
					this.siticoneLabel10.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1343;
				}
				if (num == 269)
				{
					this.siticoneSeparator3.Location = new global::System.Drawing.Point(171, 7);
					num = 270;
				}
				if (num == 669)
				{
					this.cflow.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 670;
				}
				if (num == 345)
				{
					this.packer.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 346;
				}
				if (num == 18)
				{
					this.assemblytext = new global::ns1.SiticoneTextBox();
					num = 19;
				}
				if (num == 1044)
				{
					this.siticonePanel2.Controls.Add(this.BaseSenc);
					num = 1045;
				}
				if (num == 388)
				{
					this.signer.Name = "signer";
					num = 389;
				}
				if (num == 1157)
				{
					this.BaseSenc.CheckedChanged += new global::System.EventHandler(this.BaseSenc_CheckedChanged);
					num = 1158;
				}
				if (num == 570)
				{
					this.siticonePanel11.Controls.Add(this.siticoneSeparator9);
					num = 571;
				}
				if (num == 244)
				{
					this.siticoneLabel4.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 245;
				}
				if (num == 1525)
				{
					base.Controls.Add(this.siticonePanel4);
					num = 1526;
				}
				if (num == 1214)
				{
					this.SymbolsType.CheckedFillColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
					num = 1215;
				}
				if (num == 1298)
				{
					this.siticoneLabel13.Location = new global::System.Drawing.Point(15, 128);
					num = 1299;
				}
				if (num == 634)
				{
					this.adebug.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 635;
				}
				if (num == 543)
				{
					this.omethods.TabIndex = 11;
					num = 544;
				}
				if (num == 538)
				{
					this.omethods.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 539;
				}
				if (num == 1151)
				{
					this.BaseSenc.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 1152;
				}
				if (num == 1037)
				{
					this.apacker.UseVisualStyleBackColor = true;
					num = 1038;
				}
				if (num == 1021)
				{
					this.apacker.CheckedState.BorderRadius = 2;
					num = 1022;
				}
				if (num == 503)
				{
					this.hmethods.Size = new global::System.Drawing.Size(184, 21);
					num = 504;
				}
				if (num == 1102)
				{
					this.alllength.Maximum = 50;
					num = 1103;
				}
				if (num == 684)
				{
					this.siticoneLabel6.IsSelectionEnabled = false;
					num = 685;
				}
				if (num == 1156)
				{
					this.BaseSenc.UseVisualStyleBackColor = true;
					num = 1157;
				}
				if (num == 1253)
				{
					this.NumbersType.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
					num = 1254;
				}
				if (num == 539)
				{
					this.omethods.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 540;
				}
				if (num == 1521)
				{
					base.Controls.Add(this.siticonePanel6);
					num = 1522;
				}
				if (num == 1130)
				{
					this.siticoneLabel17.IsContextMenuEnabled = false;
					num = 1131;
				}
				if (num == 808)
				{
					this.exit.CheckedState.Parent = this.exit;
					num = 809;
				}
				if (num == 840)
				{
					this.facebook.TabIndex = 10;
					num = 841;
				}
				if (num == 964)
				{
					this.adump.Name = "adump";
					num = 965;
				}
				if (num == 1042)
				{
					this.siticonePanel2.Controls.Add(this.siticoneSeparator1);
					num = 1043;
				}
				if (num == 651)
				{
					this.adebug.UseVisualStyleBackColor = true;
					num = 652;
				}
				if (num == 706)
				{
					this.pobf.UncheckedState.BorderRadius = 1;
					num = 707;
				}
				if (num == 862)
				{
					this.movelbl2.TabIndex = 3;
					num = 863;
				}
				if (num == 416)
				{
					this.mutation.AutoSize = true;
					num = 417;
				}
				if (num == 1332)
				{
					this.cflowTrackBar.Minimum = 1;
					num = 1333;
				}
				if (num == 1352)
				{
					this.renamer2.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1353;
				}
				if (num == 849)
				{
					this.discord.Name = "discord";
					num = 850;
				}
				if (num == 1443)
				{
					this.siticoneSeparator11.FillThickness = 2;
					num = 1444;
				}
				if (num == 902)
				{
					this.asciisenc.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 903;
				}
				if (num == 129)
				{
					this.pint.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 130;
				}
				if (num == 889)
				{
					this.virt.TabIndex = 28;
					num = 890;
				}
				if (num == 997)
				{
					this.atamper.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 998;
				}
				if (num == 717)
				{
					this.movepnl.Controls.Add(this.min);
					num = 718;
				}
				if (num == 153)
				{
					this.cryptosenc.UseVisualStyleBackColor = true;
					num = 154;
				}
				if (num == 1534)
				{
					this.MaximumSize = new global::System.Drawing.Size(797, 514);
					num = 1535;
				}
				if (num == 992)
				{
					this.atamper.AutoSize = true;
					num = 993;
				}
				if (num == 1254)
				{
					this.NumbersType.Checked = false;
					num = 1255;
				}
				if (num == 1558)
				{
					this.siticonePanel8.ResumeLayout(false);
					num = 1559;
				}
				if (num == 1118)
				{
					this.siticoneLabel18.Size = new global::System.Drawing.Size(50, 17);
					num = 1119;
				}
				if (num == 151)
				{
					this.cryptosenc.UncheckedState.BorderThickness = 1;
					num = 152;
				}
				if (num == 1405)
				{
					this.uncheckall.CheckedState.Parent = this.uncheckall;
					num = 1406;
				}
				if (num == 942)
				{
					this.ade4dot.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 943;
				}
				if (num == 620)
				{
					this.cconfusion.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 621;
				}
				if (num == 1318)
				{
					this.siticoneLabel14.IsContextMenuEnabled = false;
					num = 1319;
				}
				if (num == 886)
				{
					this.virt.Location = new global::System.Drawing.Point(13, 61);
					num = 887;
				}
				if (num == 798)
				{
					this.min.HoveredState.Parent = this.min;
					num = 799;
				}
				if (num == 494)
				{
					this.hmethods.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 495;
				}
				if (num == 900)
				{
					this.asciisenc.CheckedState.BorderRadius = 2;
					num = 901;
				}
				if (num == 665)
				{
					this.cflow.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 666;
				}
				if (num == 1246)
				{
					this.ChineseType.TabIndex = 42;
					num = 1247;
				}
				if (num == 896)
				{
					this.virt.UseVisualStyleBackColor = true;
					num = 897;
				}
				if (num == 78)
				{
					this.siticoneLabel12 = new global::ns1.SiticoneLabel();
					num = 79;
				}
				if (num == 544)
				{
					this.omethods.Text = " Outline Methods";
					num = 545;
				}
				if (num == 597)
				{
					this.siticonePanel10.Name = "siticonePanel10";
					num = 598;
				}
				if (num == 1028)
				{
					this.apacker.Name = "apacker";
					num = 1029;
				}
				if (num == 309)
				{
					this.assemblytext.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.assemblytext_DragEnter);
					num = 310;
				}
				if (num == 89)
				{
					this.renamer2 = new global::ns1.SiticoneMaterialRadioButton();
					num = 90;
				}
				if (num == 1374)
				{
					this.renamer.CausesValidation = false;
					num = 1375;
				}
				if (num == 113)
				{
					base.SuspendLayout();
					num = 114;
				}
				if (num == 961)
				{
					this.adump.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 962;
				}
				if (num == 83)
				{
					this.AsciiType = new global::ns1.SiticoneMaterialRadioButton();
					num = 84;
				}
				if (num == 953)
				{
					this.ade4dot.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 954;
				}
				if (num == 1024)
				{
					this.apacker.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 1025;
				}
				if (num == 1522)
				{
					base.Controls.Add(this.siticonePanel8);
					num = 1523;
				}
				if (num == 563)
				{
					this.sconfusion.Text = " Stack Confusion";
					num = 564;
				}
				if (num == 657)
				{
					this.cflow.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 658;
				}
				if (num == 1083)
				{
					this.siticonePanel2.Name = "siticonePanel2";
					num = 1084;
				}
				if (num == 1160)
				{
					this.RenamerOFF.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
					num = 1161;
				}
				if (num == 1134)
				{
					this.siticoneLabel17.Size = new global::System.Drawing.Size(129, 17);
					num = 1135;
				}
				if (num == 1244)
				{
					this.ChineseType.ReadOnly = false;
					num = 1245;
				}
				if (num == 1471)
				{
					this.BrowseSNK.CheckedState.Parent = this.BrowseSNK;
					num = 1472;
				}
				if (num == 1465)
				{
					this.siticoneLabel3.TabIndex = 25;
					num = 1466;
				}
				if (num == 45)
				{
					this.pobf = new global::ns1.SiticoneCheckBox();
					num = 46;
				}
				if (num == 1277)
				{
					this.AsciiType.CheckedFillColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
					num = 1278;
				}
				if (num == 21)
				{
					this.packer = new global::ns1.SiticoneCheckBox();
					num = 22;
				}
				if (num == 38)
				{
					this.siticoneSeparator8 = new global::ns1.SiticoneSeparator();
					num = 39;
				}
				if (num == 1182)
				{
					this.siticoneLabel11.IsSelectionEnabled = false;
					num = 1183;
				}
				if (num == 668)
				{
					this.cflow.UncheckedState.BorderThickness = 1;
					num = 669;
				}
				if (num == 874)
				{
					this.movelbl.TabIndex = 2;
					num = 875;
				}
				if (num == 760)
				{
					this.siticoneLabel8.Location = new global::System.Drawing.Point(217, 11);
					num = 761;
				}
				if (num == 1072)
				{
					this.siticonePanel2.Controls.Add(this.cflow);
					num = 1073;
				}
				if (num == 1241)
				{
					this.ChineseType.HoverTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1242;
				}
				if (num == 1032)
				{
					this.apacker.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 1033;
				}
				if (num == 1197)
				{
					this.siticoneLabel12.TabIndex = 40;
					num = 1198;
				}
				if (num == 291)
				{
					this.assemblytext.FocusedState.BorderColor = global::System.Drawing.Color.LightCoral;
					num = 292;
				}
				if (num == 1189)
				{
					this.siticoneLabel12.BackColor = global::System.Drawing.Color.Transparent;
					num = 1190;
				}
				if (num == 1486)
				{
					this.BrowseSNK.Click += new global::System.EventHandler(this.BrowseSNK_Click);
					num = 1487;
				}
				if (num == 59)
				{
					this.movelbl = new global::ns1.SiticoneLabel();
					num = 60;
				}
				if (num == 1070)
				{
					this.siticonePanel2.Controls.Add(this.cconfusion);
					num = 1071;
				}
				if (num == 449)
				{
					this.invalidmd.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 450;
				}
				if (num == 385)
				{
					this.signer.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 386;
				}
				if (num == 389)
				{
					this.signer.Size = new global::System.Drawing.Size(110, 21);
					num = 390;
				}
				if (num == 1550)
				{
					this.movepnl.PerformLayout();
					num = 1551;
				}
				if (num == 581)
				{
					this.siticoneSeparator10.Name = "siticoneSeparator10";
					num = 582;
				}
				if (num == 742)
				{
					this.siticoneLabel16.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.siticoneLabel16_MouseDown);
					num = 743;
				}
				if (num == 856)
				{
					this.movelbl2.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 857;
				}
				if (num == 1317)
				{
					this.siticoneLabel14.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1318;
				}
				if (num == 548)
				{
					this.omethods.UncheckedState.BorderThickness = 1;
					num = 549;
				}
				if (num == 126)
				{
					this.pint.Size = new global::System.Drawing.Size(81, 21);
					num = 127;
				}
				if (num == 683)
				{
					this.siticoneLabel6.IsContextMenuEnabled = false;
					num = 684;
				}
				if (num == 128)
				{
					this.pint.Text = " Proxy Int";
					num = 129;
				}
				if (num == 112)
				{
					this.siticonePanel8.SuspendLayout();
					num = 113;
				}
				if (num == 200)
				{
					this.obfuscate.HoveredState.Parent = this.obfuscate;
					num = 201;
				}
				if (num == 210)
				{
					this.obfuscate.Click += new global::System.EventHandler(this.obfuscate_Click_1);
					num = 211;
				}
				if (num == 547)
				{
					this.omethods.UncheckedState.BorderRadius = 1;
					num = 548;
				}
				if (num == 204)
				{
					this.obfuscate.Name = "obfuscate";
					num = 205;
				}
				if (num == 783)
				{
					this.donation.BackColor = global::System.Drawing.Color.Transparent;
					num = 784;
				}
				if (num == 318)
				{
					this.browse.HoveredState.Parent = this.browse;
					num = 319;
				}
				if (num == 1148)
				{
					this.BaseSenc.Size = new global::System.Drawing.Size(68, 21);
					num = 1149;
				}
				if (num == 88)
				{
					this.siticoneLabel10 = new global::ns1.SiticoneLabel();
					num = 89;
				}
				if (num == 87)
				{
					this.cflowTrackBar = new global::ns1.SiticoneMetroTrackBar();
					num = 88;
				}
				if (num == 1517)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 1518;
				}
				if (num == 348)
				{
					this.packer.Location = new global::System.Drawing.Point(13, 11);
					num = 349;
				}
				if (num == 1436)
				{
					this.siticoneLabel15.Location = new global::System.Drawing.Point(63, 1);
					num = 1437;
				}
				if (num == 555)
				{
					this.sconfusion.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 556;
				}
				if (num == 1297)
				{
					this.siticoneLabel13.IsSelectionEnabled = false;
					num = 1298;
				}
				if (num == 1029)
				{
					this.apacker.Size = new global::System.Drawing.Size(119, 21);
					num = 1030;
				}
				if (num == 164)
				{
					this.pmobf.Size = new global::System.Drawing.Size(97, 21);
					num = 165;
				}
				if (num == 1448)
				{
					this.siticonePanel8.Controls.Add(this.siticoneLabel3);
					num = 1449;
				}
				if (num == 988)
				{
					this.aildasm.UncheckedState.BorderRadius = 1;
					num = 989;
				}
				if (num == 1274)
				{
					this.AsciiType.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
					num = 1275;
				}
				if (num == 474)
				{
					this.mstrip.AutoSize = true;
					num = 475;
				}
				if (num == 784)
				{
					this.donation.CheckedState.Parent = this.donation;
					num = 785;
				}
				if (num == 938)
				{
					this.ade4dot.CheckedState.BorderRadius = 2;
					num = 939;
				}
				if (num == 1080)
				{
					this.siticonePanel2.Controls.Add(this.checkall);
					num = 1081;
				}
				if (num == 393)
				{
					this.signer.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 394;
				}
				if (num == 841)
				{
					this.facebook.Click += new global::System.EventHandler(this.facebook_Click);
					num = 842;
				}
				if (num == 1265)
				{
					this.NumbersType.ReadOnly = false;
					num = 1266;
				}
				if (num == 1163)
				{
					this.RenamerOFF.CheckedFillColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
					num = 1164;
				}
				if (num == 456)
				{
					this.ajunk.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 457;
				}
				if (num == 978)
				{
					this.aildasm.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 979;
				}
				if (num == 185)
				{
					this.hnamespaces.Text = " Hide Namespaces";
					num = 186;
				}
				if (num == 1502)
				{
					this.SNKText.Location = new global::System.Drawing.Point(18, 19);
					num = 1503;
				}
				if (num == 1346)
				{
					this.siticoneLabel10.Name = "siticoneLabel10";
					num = 1347;
				}
				if (num == 613)
				{
					this.cconfusion.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 614;
				}
				if (num == 1275)
				{
					this.AsciiType.Checked = false;
					num = 1276;
				}
				if (num == 1366)
				{
					this.renamer2.Size = new global::System.Drawing.Size(92, 20);
					num = 1367;
				}
				if (num == 1089)
				{
					this.siticoneLabel19.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1090;
				}
				if (num == 1303)
				{
					this.siticoneLabel13.UseGdiPlusTextRendering = true;
					num = 1304;
				}
				if (num == 867)
				{
					this.movelbl.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 868;
				}
				if (num == 463)
				{
					this.ajunk.Location = new global::System.Drawing.Point(162, 197);
					num = 464;
				}
				if (num == 1361)
				{
					this.renamer2.HoverFillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
					num = 1362;
				}
				if (num == 1226)
				{
					this.SymbolsType.Text = "Arabic";
					num = 1227;
				}
				if (num == 1547)
				{
					this.siticonePanel9.ResumeLayout(false);
					num = 1548;
				}
				if (num == 325)
				{
					this.browse.TabIndex = 1;
					num = 326;
				}
				if (num == 212)
				{
					this.siticonePanel6.Controls.Add(this.siticoneLabel5);
					num = 213;
				}
				if (num == 1171)
				{
					this.RenamerOFF.Name = "RenamerOFF";
					num = 1172;
				}
				if (num == 301)
				{
					this.assemblytext.SelectedText = "";
					num = 302;
				}
				if (num == 633)
				{
					this.adebug.AutoSize = true;
					num = 634;
				}
				if (num == 1539)
				{
					this.siticonePanel6.ResumeLayout(false);
					num = 1540;
				}
				if (num == 417)
				{
					this.mutation.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 418;
				}
				if (num == 216)
				{
					this.siticonePanel6.ShadowDecoration.Parent = this.siticonePanel6;
					num = 217;
				}
				if (num == 991)
				{
					this.aildasm.UseVisualStyleBackColor = true;
					num = 992;
				}
				if (num == 1068)
				{
					this.siticonePanel2.Controls.Add(this.omethods);
					num = 1069;
				}
				if (num == 819)
				{
					this.logo.BackColor = global::System.Drawing.Color.Transparent;
					num = 820;
				}
				if (num == 1181)
				{
					this.siticoneLabel11.IsContextMenuEnabled = false;
					num = 1182;
				}
				if (num == 1285)
				{
					this.AsciiType.Name = "AsciiType";
					num = 1286;
				}
				if (num == 1364)
				{
					this.renamer2.Name = "renamer2";
					num = 1365;
				}
				if (num == 686)
				{
					this.siticoneLabel6.Name = "siticoneLabel6";
					num = 687;
				}
				if (num == 725)
				{
					this.movepnl.Location = new global::System.Drawing.Point(0, 0);
					num = 726;
				}
				if (num == 1239)
				{
					this.ChineseType.HoverBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1240;
				}
				if (num == 365)
				{
					this.arith.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 366;
				}
				if (num == 1461)
				{
					this.siticoneLabel3.IsSelectionEnabled = false;
					num = 1462;
				}
				if (num == 1407)
				{
					this.uncheckall.HoveredState.Parent = this.uncheckall;
					num = 1408;
				}
				if (num == 1203)
				{
					this.siticonePanel1.Controls.Add(this.AsciiType);
					num = 1204;
				}
				if (num == 702)
				{
					this.pobf.TabIndex = 6;
					num = 703;
				}
				if (num == 532)
				{
					this.omethods.AutoSize = true;
					num = 533;
				}
				if (num == 569)
				{
					this.sconfusion.UseVisualStyleBackColor = true;
					num = 570;
				}
				if (num == 1485)
				{
					this.BrowseSNK.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.AntiAlias;
					num = 1486;
				}
				if (num == 922)
				{
					this.hstr.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 923;
				}
				if (num == 583)
				{
					this.siticoneSeparator10.TabIndex = 24;
					num = 584;
				}
				if (num == 1043)
				{
					this.siticonePanel2.Controls.Add(this.siticoneLabel17);
					num = 1044;
				}
				if (num == 1559)
				{
					this.siticonePanel8.PerformLayout();
					num = 1560;
				}
				if (num == 284)
				{
					this.assemblytext.DefaultText = "Drag & Drop Supported";
					num = 285;
				}
				if (num == 542)
				{
					this.omethods.Size = new global::System.Drawing.Size(128, 21);
					num = 543;
				}
				if (num == 1027)
				{
					this.apacker.Location = new global::System.Drawing.Point(13, 36);
					num = 1028;
				}
				if (num == 748)
				{
					this.siticoneLabel9.Location = new global::System.Drawing.Point(636, 11);
					num = 749;
				}
				if (num == 293)
				{
					this.assemblytext.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 294;
				}
				if (num == 213)
				{
					this.siticonePanel6.Controls.Add(this.siticoneSeparator6);
					num = 214;
				}
				if (num == 1339)
				{
					this.cflowTrackBar.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.cflowTrackBar_Scroll);
					num = 1340;
				}
				if (num == 317)
				{
					this.browse.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 318;
				}
				if (num == 1228)
				{
					this.SymbolsType.TextLeftAlign = 0;
					num = 1229;
				}
				if (num == 904)
				{
					this.asciisenc.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 905;
				}
				if (num == 609)
				{
					this.cconfusion.CheckedState.BorderRadius = 2;
					num = 610;
				}
				if (num == 768)
				{
					this.siticoneLabel2.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 769;
				}
				if (num == 662)
				{
					this.cflow.Size = new global::System.Drawing.Size(70, 21);
					num = 663;
				}
				if (num == 985)
				{
					this.aildasm.Text = " Anti ILDasm";
					num = 986;
				}
				if (num == 413)
				{
					this.siticoneLabel7.TabIndex = 23;
					num = 414;
				}
				if (num == 512)
				{
					this.hmethods.CheckedChanged += new global::System.EventHandler(this.hmethods_CheckedChanged);
					num = 513;
				}
				if (num == 858)
				{
					this.movelbl2.IsSelectionEnabled = false;
					num = 859;
				}
				if (num == 1454)
				{
					this.siticonePanel8.ShadowDecoration.Parent = this.siticonePanel8;
					num = 1455;
				}
				if (num == 703)
				{
					this.pobf.Text = " Proxy";
					num = 704;
				}
				if (num == 1018)
				{
					this.siticonePanel3.TabIndex = 34;
					num = 1019;
				}
				if (num == 552)
				{
					this.sconfusion.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 553;
				}
				if (num == 33)
				{
					this.sconfusion = new global::ns1.SiticoneCheckBox();
					num = 34;
				}
				if (num == 224)
				{
					this.siticoneSeparator5.TabIndex = 22;
					num = 225;
				}
				if (num == 32)
				{
					this.omethods = new global::ns1.SiticoneCheckBox();
					num = 33;
				}
				if (num == 817)
				{
					this.exit.TabIndex = 12;
					num = 818;
				}
				if (num == 1095)
				{
					this.siticoneLabel19.TabIndex = 49;
					num = 1096;
				}
				if (num == 659)
				{
					this.cflow.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 660;
				}
				if (num == 540)
				{
					this.omethods.Location = new global::System.Drawing.Point(162, 221);
					num = 541;
				}
				if (num == 189)
				{
					this.hnamespaces.UncheckedState.BorderThickness = 1;
					num = 190;
				}
				if (num == 1047)
				{
					this.siticonePanel2.Controls.Add(this.siticoneLabel12);
					num = 1048;
				}
				if (num == 795)
				{
					this.min.BackColor = global::System.Drawing.Color.Transparent;
					num = 796;
				}
				if (num == 1307)
				{
					this.cflowStatus.IsContextMenuEnabled = false;
					num = 1308;
				}
				if (num == 57)
				{
					this.discord = new global::ns1.SiticoneImageButton();
					num = 58;
				}
				if (num == 541)
				{
					this.omethods.Name = "omethods";
					num = 542;
				}
				if (num == 803)
				{
					this.min.PressedState.Parent = this.min;
					num = 804;
				}
				if (num == 1542)
				{
					this.siticonePanel4.PerformLayout();
					num = 1543;
				}
				if (num == 1311)
				{
					this.cflowStatus.Size = new global::System.Drawing.Size(33, 17);
					num = 1312;
				}
				if (num == 208)
				{
					this.obfuscate.Text = "Obfuscate !";
					num = 209;
				}
				if (num == 697)
				{
					this.pobf.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 698;
				}
				if (num == 1509)
				{
					this.SNKText.ShortcutsEnabled = false;
					num = 1510;
				}
				if (num == 432)
				{
					this.mutation.UncheckedState.BorderThickness = 1;
					num = 433;
				}
				if (num == 381)
				{
					this.signer.CheckedState.BorderRadius = 2;
					num = 382;
				}
				if (num == 1204)
				{
					this.siticonePanel1.Location = new global::System.Drawing.Point(310, 223);
					num = 1205;
				}
				if (num == 1138)
				{
					this.BaseSenc.AutoSize = true;
					num = 1139;
				}
				if (num == 751)
				{
					this.siticoneLabel9.TabIndex = 17;
					num = 752;
				}
				if (num == 375)
				{
					this.arith.UncheckedState.BorderRadius = 1;
					num = 376;
				}
				if (num == 1504)
				{
					this.SNKText.PasswordChar = '\0';
					num = 1505;
				}
				if (num == 1141)
				{
					this.BaseSenc.CheckedState.BorderThickness = 0;
					num = 1142;
				}
				if (num == 1002)
				{
					this.atamper.TabIndex = 0;
					num = 1003;
				}
				if (num == 1224)
				{
					this.SymbolsType.Size = new global::System.Drawing.Size(79, 20);
					num = 1225;
				}
				if (num == 1129)
				{
					this.siticoneLabel17.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1130;
				}
				if (num == 939)
				{
					this.ade4dot.CheckedState.BorderThickness = 0;
					num = 940;
				}
				if (num == 1398)
				{
					this.checkall.Location = new global::System.Drawing.Point(468, 288);
					num = 1399;
				}
				if (num == 1341)
				{
					this.siticoneLabel10.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1342;
				}
				if (num == 1323)
				{
					this.siticoneLabel14.TabIndex = 38;
					num = 1324;
				}
				if (num == 1100)
				{
					this.alllength.LargeChange = 1;
					num = 1101;
				}
				if (num == 1227)
				{
					this.SymbolsType.TextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1228;
				}
				if (num == 1267)
				{
					this.NumbersType.TabIndex = 41;
					num = 1268;
				}
				if (num == 1446)
				{
					this.siticoneSeparator11.Size = new global::System.Drawing.Size(30, 10);
					num = 1447;
				}
				if (num == 289)
				{
					this.assemblytext.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
					num = 290;
				}
				if (num == 409)
				{
					this.siticoneLabel7.IsSelectionEnabled = false;
					num = 410;
				}
				if (num == 227)
				{
					this.siticoneLabel5.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 228;
				}
				if (num == 575)
				{
					this.siticonePanel11.ShadowDecoration.Parent = this.siticonePanel11;
					num = 576;
				}
				if (num == 35)
				{
					this.siticoneSeparator10 = new global::ns1.SiticoneSeparator();
					num = 36;
				}
				if (num == 61)
				{
					this.asciisenc = new global::ns1.SiticoneCheckBox();
					num = 62;
				}
				if (num == 1293)
				{
					this.siticoneLabel13.BackColor = global::System.Drawing.Color.Transparent;
					num = 1294;
				}
				if (num == 70)
				{
					this.siticoneLabel19 = new global::ns1.SiticoneLabel();
					num = 71;
				}
				if (num == 1512)
				{
					this.SNKText.TabStop = false;
					num = 1513;
				}
				if (num == 1354)
				{
					this.renamer2.Checked = false;
					num = 1355;
				}
				if (num == 420)
				{
					this.mutation.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 421;
				}
				if (num == 130)
				{
					this.pint.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 131;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 2)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PRose.Form1));
					num = 3;
				}
				if (num == 1127)
				{
					this.siticoneLabel17.BackColor = global::System.Drawing.Color.Transparent;
					num = 1128;
				}
				if (num == 573)
				{
					this.siticonePanel11.Location = new global::System.Drawing.Point(509, 324);
					num = 574;
				}
				if (num == 1121)
				{
					this.siticoneLabel18.UseGdiPlusTextRendering = true;
					num = 1122;
				}
				if (num == 726)
				{
					this.movepnl.Name = "movepnl";
					num = 727;
				}
				if (num == 1424)
				{
					this.siticonePanel7.TabIndex = 38;
					num = 1425;
				}
				if (num == 648)
				{
					this.adebug.UncheckedState.BorderRadius = 1;
					num = 649;
				}
				if (num == 10)
				{
					this.siticoneSeparator5 = new global::ns1.SiticoneSeparator();
					num = 11;
				}
				if (num == 335)
				{
					this.siticoneLabel1.Name = "siticoneLabel1";
					num = 336;
				}
				if (num == 590)
				{
					this.log.Items.AddRange(new object[]
					{
						"I'm waiting ...."
					});
					num = 591;
				}
				if (num == 738)
				{
					this.siticoneLabel16.Size = new global::System.Drawing.Size(74, 17);
					num = 739;
				}
				if (num == 526)
				{
					this.fobf.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 527;
				}
				if (num == 26)
				{
					this.mutation = new global::ns1.SiticoneCheckBox();
					num = 27;
				}
				if (num == 278)
				{
					this.siticonePanel5.ShadowDecoration.Parent = this.siticonePanel5;
					num = 279;
				}
				if (num == 1005)
				{
					this.atamper.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1006;
				}
				if (num == 677)
				{
					this.siticonePanel9.ShadowDecoration.Parent = this.siticonePanel9;
					num = 678;
				}
				if (num == 1400)
				{
					this.checkall.PressedState.Parent = this.checkall;
					num = 1401;
				}
				if (num == 823)
				{
					this.logo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("logo.Image");
					num = 824;
				}
				if (num == 373)
				{
					this.arith.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 374;
				}
				if (num == 1165)
				{
					this.RenamerOFF.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
					num = 1166;
				}
				if (num == 106)
				{
					this.siticonePanel9.SuspendLayout();
					num = 107;
				}
				if (num == 537)
				{
					this.omethods.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 538;
				}
				if (num == 524)
				{
					this.fobf.TabIndex = 12;
					num = 525;
				}
				if (num == 1458)
				{
					this.siticoneLabel3.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1459;
				}
				if (num == 422)
				{
					this.mutation.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 423;
				}
				if (num == 1312)
				{
					this.cflowStatus.TabIndex = 25;
					num = 1313;
				}
				if (num == 121)
				{
					this.pint.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 122;
				}
				if (num == 1142)
				{
					this.BaseSenc.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 1143;
				}
				if (num == 1220)
				{
					this.SymbolsType.HoverTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1221;
				}
				if (num == 851)
				{
					this.discord.Size = new global::System.Drawing.Size(24, 24);
					num = 852;
				}
				if (num == 270)
				{
					this.siticoneSeparator3.Name = "siticoneSeparator3";
					num = 271;
				}
				if (num == 94)
				{
					this.siticoneSeparator2 = new global::ns1.SiticoneSeparator();
					num = 95;
				}
				if (num == 305)
				{
					this.assemblytext.TabIndex = 0;
					num = 306;
				}
				if (num == 903)
				{
					this.asciisenc.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 904;
				}
				if (num == 1363)
				{
					this.renamer2.Location = new global::System.Drawing.Point(402, 151);
					num = 1364;
				}
				if (num == 829)
				{
					this.logo.TabIndex = 11;
					num = 830;
				}
				if (num == 708)
				{
					this.pobf.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 709;
				}
				if (num == 626)
				{
					this.cconfusion.CheckedChanged += new global::System.EventHandler(this.cconfusion_CheckedChanged);
					num = 627;
				}
				if (num == 647)
				{
					this.adebug.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 648;
				}
				if (num == 749)
				{
					this.siticoneLabel9.Name = "siticoneLabel9";
					num = 750;
				}
				if (num == 223)
				{
					this.siticoneSeparator5.Size = new global::System.Drawing.Size(20, 10);
					num = 224;
				}
				if (num == 1380)
				{
					this.renamer.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1381;
				}
				if (num == 1187)
				{
					this.siticoneLabel11.Text = "Flood & Junk";
					num = 1188;
				}
				if (num == 8)
				{
					this.obfuscate = new global::ns1.SiticoneButton();
					num = 9;
				}
				if (num == 1382)
				{
					this.renamer.HoverFillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
					num = 1383;
				}
				if (num == 1125)
				{
					this.siticoneSeparator1.Size = new global::System.Drawing.Size(123, 10);
					num = 1126;
				}
				if (num == 696)
				{
					this.pobf.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 697;
				}
				if (num == 535)
				{
					this.omethods.CheckedState.BorderThickness = 0;
					num = 536;
				}
				if (num == 1229)
				{
					this.SymbolsType.CheckedChanged += new global::System.EventHandler(this.SymbolsType_CheckedChanged);
					num = 1230;
				}
				if (num == 771)
				{
					this.siticoneLabel2.IsSelectionEnabled = false;
					num = 772;
				}
				if (num == 1111)
				{
					this.siticoneLabel18.BackColor = global::System.Drawing.Color.Transparent;
					num = 1112;
				}
				if (num == 265)
				{
					this.siticoneSeparator4.Size = new global::System.Drawing.Size(20, 10);
					num = 266;
				}
				if (num == 498)
				{
					this.hmethods.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 499;
				}
				if (num == 1162)
				{
					this.RenamerOFF.CheckedBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1163;
				}
				if (num == 1351)
				{
					this.renamer2.BackColor = global::System.Drawing.Color.Transparent;
					num = 1352;
				}
				if (num == 1300)
				{
					this.siticoneLabel13.Size = new global::System.Drawing.Size(108, 17);
					num = 1301;
				}
				if (num == 1179)
				{
					this.siticoneLabel11.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1180;
				}
				if (num == 1261)
				{
					this.NumbersType.HoverFillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
					num = 1262;
				}
				if (num == 714)
				{
					this.movepnl.Controls.Add(this.siticoneLabel2);
					num = 715;
				}
				if (num == 146)
				{
					this.cryptosenc.TabIndex = 26;
					num = 147;
				}
				if (num == 104)
				{
					this.siticonePanel11.SuspendLayout();
					num = 105;
				}
				if (num == 1494)
				{
					this.SNKText.DisabledState.Parent = this.SNKText;
					num = 1495;
				}
				if (num == 895)
				{
					this.virt.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 896;
				}
				if (num == 916)
				{
					this.asciisenc.UseVisualStyleBackColor = true;
					num = 917;
				}
				if (num == 813)
				{
					this.exit.Location = new global::System.Drawing.Point(763, 8);
					num = 814;
				}
				if (num == 384)
				{
					this.signer.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 385;
				}
				if (num == 46)
				{
					this.movepnl = new global::ns1.SiticonePanel();
					num = 47;
				}
				if (num == 1128)
				{
					this.siticoneLabel17.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1129;
				}
				if (num == 1372)
				{
					this.renamer.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1373;
				}
				if (num == 402)
				{
					this.siticoneSeparator9.Name = "siticoneSeparator9";
					num = 403;
				}
				if (num == 860)
				{
					this.movelbl2.Name = "movelbl2";
					num = 861;
				}
				if (num == 559)
				{
					this.sconfusion.Location = new global::System.Drawing.Point(162, 150);
					num = 560;
				}
				if (num == 892)
				{
					this.virt.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 893;
				}
				if (num == 496)
				{
					this.hmethods.CheckedState.BorderThickness = 0;
					num = 497;
				}
				if (num == 482)
				{
					this.mstrip.Location = new global::System.Drawing.Point(310, 34);
					num = 483;
				}
				if (num == 103)
				{
					this.siticonePanel5.SuspendLayout();
					num = 104;
				}
				if (num == 999)
				{
					this.atamper.Location = new global::System.Drawing.Point(15, 11);
					num = 1000;
				}
				if (num == 136)
				{
					this.cryptosenc.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 137;
				}
				if (num == 490)
				{
					this.mstrip.UncheckedState.BorderThickness = 1;
					num = 491;
				}
				if (num == 1213)
				{
					this.SymbolsType.CheckedBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1214;
				}
				if (num == 263)
				{
					this.siticoneSeparator4.Location = new global::System.Drawing.Point(80, 7);
					num = 264;
				}
				if (num == 366)
				{
					this.arith.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 367;
				}
				if (num == 518)
				{
					this.fobf.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 519;
				}
				if (num == 43)
				{
					this.siticonePanel9 = new global::ns1.SiticonePanel();
					num = 44;
				}
				if (num == 367)
				{
					this.arith.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 368;
				}
				if (num == 1305)
				{
					this.cflowStatus.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1306;
				}
				if (num == 1288)
				{
					this.AsciiType.TabIndex = 40;
					num = 1289;
				}
				if (num == 398)
				{
					this.signer.CheckedChanged += new global::System.EventHandler(this.signer_CheckedChanged);
					num = 399;
				}
				if (num == 1256)
				{
					this.NumbersType.CheckedFillColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
					num = 1257;
				}
				if (num == 941)
				{
					this.ade4dot.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 942;
				}
				if (num == 1234)
				{
					this.ChineseType.CheckedBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1235;
				}
				if (num == 780)
				{
					this.siticoneVSeparator1.Name = "siticoneVSeparator1";
					num = 781;
				}
				if (num == 678)
				{
					this.siticonePanel9.Size = new global::System.Drawing.Size(502, 22);
					num = 679;
				}
				if (num == 1122)
				{
					this.siticoneSeparator1.FillColor = global::System.Drawing.Color.IndianRed;
					num = 1123;
				}
				if (num == 1480)
				{
					this.BrowseSNK.Name = "BrowseSNK";
					num = 1481;
				}
				if (num == 1556)
				{
					this.siticonePanel7.ResumeLayout(false);
					num = 1557;
				}
				if (num == 319)
				{
					this.browse.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("browse.Image");
					num = 320;
				}
				if (num == 965)
				{
					this.adump.Size = new global::System.Drawing.Size(92, 21);
					num = 966;
				}
				if (num == 1153)
				{
					this.BaseSenc.UncheckedState.BorderRadius = 1;
					num = 1154;
				}
				if (num == 818)
				{
					this.exit.Click += new global::System.EventHandler(this.exit_Click);
					num = 819;
				}
				if (num == 762)
				{
					this.siticoneLabel8.Size = new global::System.Drawing.Size(43, 17);
					num = 763;
				}
				if (num == 735)
				{
					this.siticoneLabel16.IsSelectionEnabled = false;
					num = 736;
				}
				if (num == 533)
				{
					this.omethods.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 534;
				}
				if (num == 883)
				{
					this.virt.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 884;
				}
				if (num == 623)
				{
					this.cconfusion.UncheckedState.BorderThickness = 1;
					num = 624;
				}
				if (num == 810)
				{
					this.exit.HoveredState.Parent = this.exit;
					num = 811;
				}
				if (num == 1079)
				{
					this.siticonePanel2.Controls.Add(this.atamper);
					num = 1080;
				}
				if (num == 90)
				{
					this.renamer = new global::ns1.SiticoneMaterialRadioButton();
					num = 91;
				}
				if (num == 1088)
				{
					this.siticoneLabel19.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1089;
				}
				if (num == 421)
				{
					this.mutation.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 422;
				}
				if (num == 84)
				{
					this.siticoneLabel13 = new global::ns1.SiticoneLabel();
					num = 85;
				}
				if (num == 1209)
				{
					this.SymbolsType.BackColor = global::System.Drawing.Color.Transparent;
					num = 1210;
				}
				if (num == 1199)
				{
					this.siticoneLabel12.UseGdiPlusTextRendering = true;
					num = 1200;
				}
				if (num == 351)
				{
					this.packer.TabIndex = 26;
					num = 352;
				}
				if (num == 1094)
				{
					this.siticoneLabel19.Size = new global::System.Drawing.Size(10, 17);
					num = 1095;
				}
				if (num == 705)
				{
					this.pobf.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 706;
				}
				if (num == 1511)
				{
					this.SNKText.TabIndex = 0;
					num = 1512;
				}
				if (num == 379)
				{
					this.signer.AutoSize = true;
					num = 380;
				}
				if (num == 1545)
				{
					this.siticonePanel11.PerformLayout();
					num = 1546;
				}
				if (num == 1170)
				{
					this.RenamerOFF.Location = new global::System.Drawing.Point(310, 175);
					num = 1171;
				}
				if (num == 340)
				{
					this.packer.AutoSize = true;
					num = 341;
				}
				if (num == 252)
				{
					this.siticoneLabel4.UseGdiPlusTextRendering = true;
					num = 253;
				}
				if (num == 452)
				{
					this.invalidmd.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 453;
				}
				if (num == 980)
				{
					this.aildasm.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 981;
				}
				if (num == 1532)
				{
					base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
					num = 1533;
				}
				if (num == 300)
				{
					this.assemblytext.ReadOnly = true;
					num = 301;
				}
				if (num == 1058)
				{
					this.siticonePanel2.Controls.Add(this.pmobf);
					num = 1059;
				}
				if (num == 1077)
				{
					this.siticonePanel2.Controls.Add(this.adump);
					num = 1078;
				}
				if (num == 951)
				{
					this.ade4dot.UncheckedState.BorderRadius = 1;
					num = 952;
				}
				if (num == 1414)
				{
					this.uncheckall.TabIndex = 31;
					num = 1415;
				}
				if (num == 99)
				{
					this.BrowseSNK = new global::ns1.SiticoneButton();
					num = 100;
				}
				if (num == 218)
				{
					this.siticonePanel6.TabIndex = 36;
					num = 219;
				}
				if (num == 466)
				{
					this.ajunk.TabIndex = 16;
					num = 467;
				}
				if (num == 1524)
				{
					base.Controls.Add(this.siticonePanel10);
					num = 1525;
				}
				if (num == 822)
				{
					this.logo.HoveredState.Parent = this.logo;
					num = 823;
				}
				if (num == 407)
				{
					this.siticoneLabel7.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 408;
				}
				if (num == 433)
				{
					this.mutation.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 434;
				}
				if (num == 1395)
				{
					this.checkall.HoveredState.Parent = this.checkall;
					num = 1396;
				}
				if (num == 163)
				{
					this.pmobf.Name = "pmobf";
					num = 164;
				}
				if (num == 423)
				{
					this.mutation.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 424;
				}
				if (num == 13)
				{
					this.siticoneLabel4 = new global::ns1.SiticoneLabel();
					num = 14;
				}
				if (num == 640)
				{
					this.adebug.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 641;
				}
				if (num == 156)
				{
					this.pmobf.CheckedState.BorderRadius = 2;
					num = 157;
				}
				if (num == 689)
				{
					this.siticoneLabel6.Text = "Packer & Virtualizer";
					num = 690;
				}
				if (num == 279)
				{
					this.siticonePanel5.Size = new global::System.Drawing.Size(280, 92);
					num = 280;
				}
				if (num == 850)
				{
					this.discord.PressedState.Parent = this.discord;
					num = 851;
				}
				if (num == 788)
				{
					this.donation.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 789;
				}
				if (num == 1497)
				{
					this.SNKText.FocusedState.BorderColor = global::System.Drawing.Color.LightCoral;
					num = 1498;
				}
				if (num == 277)
				{
					this.siticonePanel5.Name = "siticonePanel5";
					num = 278;
				}
				if (num == 1101)
				{
					this.alllength.Location = new global::System.Drawing.Point(365, 277);
					num = 1102;
				}
				if (num == 418)
				{
					this.mutation.CheckedState.BorderRadius = 2;
					num = 419;
				}
				if (num == 403)
				{
					this.siticoneSeparator9.Size = new global::System.Drawing.Size(20, 10);
					num = 404;
				}
				if (num == 756)
				{
					this.siticoneLabel8.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 757;
				}
				if (num == 1211)
				{
					this.SymbolsType.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
					num = 1212;
				}
				if (num == 119)
				{
					this.pint.CheckedState.BorderThickness = 0;
					num = 120;
				}
				if (num == 530)
				{
					this.fobf.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 531;
				}
				if (num == 1358)
				{
					this.renamer2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
					num = 1359;
				}
				if (num == 324)
				{
					this.browse.Size = new global::System.Drawing.Size(107, 30);
					num = 325;
				}
				if (num == 1266)
				{
					this.NumbersType.Size = new global::System.Drawing.Size(82, 20);
					num = 1267;
				}
				if (num == 1518)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 1519;
				}
				if (num == 1048)
				{
					this.siticonePanel2.Controls.Add(this.siticonePanel1);
					num = 1049;
				}
				if (num == 1108)
				{
					this.alllength.ThumbColor = global::System.Drawing.Color.IndianRed;
					num = 1109;
				}
				if (num == 16)
				{
					this.siticoneSeparator3 = new global::ns1.SiticoneSeparator();
					num = 17;
				}
				if (num == 307)
				{
					this.assemblytext.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
					num = 308;
				}
				if (num == 687)
				{
					this.siticoneLabel6.Size = new global::System.Drawing.Size(117, 17);
					num = 688;
				}
				if (num == 776)
				{
					this.siticoneLabel2.Text = "V E R S I O N";
					num = 777;
				}
				if (num == 926)
				{
					this.hstr.Name = "hstr";
					num = 927;
				}
				if (num == 404)
				{
					this.siticoneSeparator9.TabIndex = 22;
					num = 405;
				}
				if (num == 1014)
				{
					this.siticonePanel3.Location = new global::System.Drawing.Point(8, 413);
					num = 1015;
				}
				if (num == 1236)
				{
					this.ChineseType.CheckedTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1237;
				}
				if (num == 251)
				{
					this.siticoneLabel4.Text = "Assembly";
					num = 252;
				}
				if (num == 1233)
				{
					this.ChineseType.Checked = false;
					num = 1234;
				}
				if (num == 828)
				{
					this.logo.Size = new global::System.Drawing.Size(24, 24);
					num = 829;
				}
				if (num == 1313)
				{
					this.cflowStatus.Text = "None";
					num = 1314;
				}
				if (num == 261)
				{
					this.siticoneSeparator4.FillColor = global::System.Drawing.Color.IndianRed;
					num = 262;
				}
				if (num == 154)
				{
					this.pmobf.AutoSize = true;
					num = 155;
				}
				if (num == 733)
				{
					this.siticoneLabel16.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 734;
				}
				if (num == 806)
				{
					this.min.Click += new global::System.EventHandler(this.min_Click);
					num = 807;
				}
				if (num == 171)
				{
					this.pmobf.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 172;
				}
				if (num == 554)
				{
					this.sconfusion.CheckedState.BorderThickness = 0;
					num = 555;
				}
				if (num == 1343)
				{
					this.siticoneLabel10.IsContextMenuEnabled = false;
					num = 1344;
				}
				if (num == 698)
				{
					this.pobf.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 699;
				}
				if (num == 1505)
				{
					this.SNKText.PlaceholderText = "";
					num = 1506;
				}
				if (num == 401)
				{
					this.siticoneSeparator9.Location = new global::System.Drawing.Point(85, 7);
					num = 402;
				}
				if (num == 728)
				{
					this.movepnl.Size = new global::System.Drawing.Size(797, 40);
					num = 729;
				}
				if (num == 137)
				{
					this.cryptosenc.CheckedState.BorderRadius = 2;
					num = 138;
				}
				if (num == 239)
				{
					this.siticoneSeparator6.Name = "siticoneSeparator6";
					num = 240;
				}
				if (num == 1269)
				{
					this.NumbersType.TextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1270;
				}
				if (num == 602)
				{
					this.siticoneSeparator8.FillThickness = 2;
					num = 603;
				}
				if (num == 1376)
				{
					this.renamer.CheckedBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1377;
				}
				if (num == 1541)
				{
					this.siticonePanel4.ResumeLayout(false);
					num = 1542;
				}
				if (num == 592)
				{
					this.log.Name = "log";
					num = 593;
				}
				if (num == 586)
				{
					this.log.Font = new global::System.Drawing.Font("Corbel", 9f, global::System.Drawing.FontStyle.Bold);
					num = 587;
				}
				if (num == 1423)
				{
					this.siticonePanel7.Size = new global::System.Drawing.Size(280, 22);
					num = 1424;
				}
				if (num == 438)
				{
					this.invalidmd.CheckedState.BorderThickness = 0;
					num = 439;
				}
				if (num == 359)
				{
					this.packer.CheckedChanged += new global::System.EventHandler(this.packer_CheckedChanged);
					num = 360;
				}
				if (num == 1345)
				{
					this.siticoneLabel10.Location = new global::System.Drawing.Point(15, 222);
					num = 1346;
				}
				if (num == 182)
				{
					this.hnamespaces.Name = "hnamespaces";
					num = 183;
				}
				if (num == 1296)
				{
					this.siticoneLabel13.IsContextMenuEnabled = false;
					num = 1297;
				}
				if (num == 891)
				{
					this.virt.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 892;
				}
				if (num == 435)
				{
					this.invalidmd.AutoSize = true;
					num = 436;
				}
				if (num == 477)
				{
					this.mstrip.CheckedState.BorderThickness = 0;
					num = 478;
				}
				if (num == 321)
				{
					this.browse.Location = new global::System.Drawing.Point(18, 46);
					num = 322;
				}
				if (num == 354)
				{
					this.packer.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 355;
				}
				if (num == 1501)
				{
					this.SNKText.HoveredState.Parent = this.SNKText;
					num = 1502;
				}
				if (num == 520)
				{
					this.fobf.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 521;
				}
				if (num == 826)
				{
					this.logo.Name = "logo";
					num = 827;
				}
				if (num == 1291)
				{
					this.AsciiType.TextLeftAlign = 0;
					num = 1292;
				}
				if (num == 108)
				{
					this.siticonePanel3.SuspendLayout();
					num = 109;
				}
				if (num == 1411)
				{
					this.uncheckall.Name = "uncheckall";
					num = 1412;
				}
				if (num == 280)
				{
					this.siticonePanel5.TabIndex = 37;
					num = 281;
				}
				if (num == 376)
				{
					this.arith.UncheckedState.BorderThickness = 1;
					num = 377;
				}
				if (num == 1434)
				{
					this.siticoneLabel15.IsContextMenuEnabled = false;
					num = 1435;
				}
				if (num == 330)
				{
					this.siticoneLabel1.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 331;
				}
				if (num == 514)
				{
					this.fobf.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 515;
				}
				if (num == 927)
				{
					this.hstr.Size = new global::System.Drawing.Size(102, 21);
					num = 928;
				}
				if (num == 1503)
				{
					this.SNKText.Name = "SNKText";
					num = 1504;
				}
				if (num == 757)
				{
					this.siticoneLabel8.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 758;
				}
				if (num == 956)
				{
					this.adump.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 957;
				}
				if (num == 715)
				{
					this.movepnl.Controls.Add(this.siticoneVSeparator1);
					num = 716;
				}
				if (num == 561)
				{
					this.sconfusion.Size = new global::System.Drawing.Size(123, 21);
					num = 562;
				}
				if (num == 217)
				{
					this.siticonePanel6.Size = new global::System.Drawing.Size(502, 22);
					num = 218;
				}
				if (num == 274)
				{
					this.siticonePanel5.Controls.Add(this.assemblytext);
					num = 275;
				}
				if (num == 1325)
				{
					this.siticoneLabel14.UseGdiPlusTextRendering = true;
					num = 1326;
				}
				if (num == 1074)
				{
					this.siticonePanel2.Controls.Add(this.asciisenc);
					num = 1075;
				}
				if (num == 109)
				{
					this.siticonePanel2.SuspendLayout();
					num = 110;
				}
				if (num == 660)
				{
					this.cflow.Location = new global::System.Drawing.Point(15, 245);
					num = 661;
				}
				if (num == 1003)
				{
					this.atamper.Text = " EOF Anti Tamper";
					num = 1004;
				}
				if (num == 1392)
				{
					this.checkall.BackColor = global::System.Drawing.Color.Transparent;
					num = 1393;
				}
				if (num == 241)
				{
					this.siticoneSeparator6.TabIndex = 24;
					num = 242;
				}
				if (num == 1321)
				{
					this.siticoneLabel14.Name = "siticoneLabel14";
					num = 1322;
				}
				if (num == 1478)
				{
					this.BrowseSNK.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 1479;
				}
				if (num == 778)
				{
					this.siticoneLabel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.siticoneLabel2_MouseDown);
					num = 779;
				}
				if (num == 785)
				{
					this.donation.HoveredState.ImageSize = new global::System.Drawing.Size(22, 22);
					num = 786;
				}
				if (num == 147)
				{
					this.cryptosenc.Text = " Crypto";
					num = 148;
				}
				if (num == 894)
				{
					this.virt.UncheckedState.BorderThickness = 1;
					num = 895;
				}
				if (num == 880)
				{
					this.virt.CheckedState.BorderRadius = 2;
					num = 881;
				}
				if (num == 1286)
				{
					this.AsciiType.ReadOnly = false;
					num = 1287;
				}
				if (num == 1064)
				{
					this.siticonePanel2.Controls.Add(this.ajunk);
					num = 1065;
				}
				if (num == 1260)
				{
					this.NumbersType.HoverBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1261;
				}
				if (num == 838)
				{
					this.facebook.PressedState.Parent = this.facebook;
					num = 839;
				}
				if (num == 467)
				{
					this.ajunk.Text = " Add Junk";
					num = 468;
				}
				if (num == 11)
				{
					this.siticoneLabel5 = new global::ns1.SiticoneLabel();
					num = 12;
				}
				if (num == 167)
				{
					this.pmobf.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 168;
				}
				if (num == 928)
				{
					this.hstr.TabIndex = 4;
					num = 929;
				}
				if (num == 807)
				{
					this.exit.BackColor = global::System.Drawing.Color.Transparent;
					num = 808;
				}
				if (num == 66)
				{
					this.atamper = new global::ns1.SiticoneCheckBox();
					num = 67;
				}
				if (num == 259)
				{
					this.siticonePanel4.Size = new global::System.Drawing.Size(280, 22);
					num = 260;
				}
				if (num == 946)
				{
					this.ade4dot.Size = new global::System.Drawing.Size(100, 21);
					num = 947;
				}
				if (num == 1112)
				{
					this.siticoneLabel18.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1113;
				}
				if (num == 796)
				{
					this.min.CheckedState.Parent = this.min;
					num = 797;
				}
				if (num == 968)
				{
					this.adump.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 969;
				}
				if (num == 931)
				{
					this.hstr.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 932;
				}
				if (num == 333)
				{
					this.siticoneLabel1.IsSelectionEnabled = false;
					num = 334;
				}
				if (num == 763)
				{
					this.siticoneLabel8.TabIndex = 16;
					num = 764;
				}
				if (num == 801)
				{
					this.min.Location = new global::System.Drawing.Point(737, 8);
					num = 802;
				}
				if (num == 995)
				{
					this.atamper.CheckedState.BorderThickness = 0;
					num = 996;
				}
				if (num == 775)
				{
					this.siticoneLabel2.TabIndex = 15;
					num = 776;
				}
				if (num == 152)
				{
					this.cryptosenc.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 153;
				}
				if (num == 594)
				{
					this.log.TabIndex = 0;
					num = 595;
				}
				if (num == 1281)
				{
					this.AsciiType.HoverBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1282;
				}
				if (num == 565)
				{
					this.sconfusion.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 566;
				}
				if (num == 693)
				{
					this.pobf.CheckedState.BorderRadius = 2;
					num = 694;
				}
				if (num == 454)
				{
					this.invalidmd.CheckedChanged += new global::System.EventHandler(this.invalidmd_CheckedChanged);
					num = 455;
				}
				if (num == 958)
				{
					this.adump.CheckedState.BorderThickness = 0;
					num = 959;
				}
				if (num == 774)
				{
					this.siticoneLabel2.Size = new global::System.Drawing.Size(75, 17);
					num = 775;
				}
				if (num == 641)
				{
					this.adebug.Location = new global::System.Drawing.Point(15, 80);
					num = 642;
				}
				if (num == 582)
				{
					this.siticoneSeparator10.Size = new global::System.Drawing.Size(30, 10);
					num = 583;
				}
				if (num == 752)
				{
					this.siticoneLabel9.Text = "Support me";
					num = 753;
				}
				if (num == 391)
				{
					this.signer.Text = " Enable signer";
					num = 392;
				}
				if (num == 837)
				{
					this.facebook.Name = "facebook";
					num = 838;
				}
				if (num == 982)
				{
					this.aildasm.Name = "aildasm";
					num = 983;
				}
				if (num == 368)
				{
					this.arith.Location = new global::System.Drawing.Point(310, 11);
					num = 369;
				}
				if (num == 536)
				{
					this.omethods.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 537;
				}
				if (num == 91)
				{
					this.checkall = new global::ns1.SiticoneImageButton();
					num = 92;
				}
				if (num == 425)
				{
					this.mutation.Name = "mutation";
					num = 426;
				}
				if (num == 1012)
				{
					this.siticonePanel3.Controls.Add(this.virt);
					num = 1013;
				}
				if (num == 1195)
				{
					this.siticoneLabel12.Name = "siticoneLabel12";
					num = 1196;
				}
				if (num == 497)
				{
					this.hmethods.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 498;
				}
				if (num == 934)
				{
					this.hstr.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 935;
				}
				if (num == 437)
				{
					this.invalidmd.CheckedState.BorderRadius = 2;
					num = 438;
				}
				if (num == 415)
				{
					this.siticoneLabel7.UseGdiPlusTextRendering = true;
					num = 416;
				}
				if (num == 247)
				{
					this.siticoneLabel4.Location = new global::System.Drawing.Point(106, 1);
					num = 248;
				}
				if (num == 954)
				{
					this.ade4dot.UseVisualStyleBackColor = true;
					num = 955;
				}
				if (num == 322)
				{
					this.browse.Name = "browse";
					num = 323;
				}
				if (num == 1393)
				{
					this.checkall.CheckedState.Parent = this.checkall;
					num = 1394;
				}
				if (num == 52)
				{
					this.donation = new global::ns1.SiticoneImageButton();
					num = 53;
				}
				if (num == 811)
				{
					this.exit.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("exit.Image");
					num = 812;
				}
				if (num == 1450)
				{
					this.siticonePanel8.Controls.Add(this.SNKText);
					num = 1451;
				}
				if (num == 287)
				{
					this.assemblytext.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
					num = 288;
				}
				if (num == 721)
				{
					this.movepnl.Controls.Add(this.discord);
					num = 722;
				}
				if (num == 308)
				{
					this.assemblytext.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.assemblytext_DragDrop);
					num = 309;
				}
				if (num == 168)
				{
					this.pmobf.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 169;
				}
				if (num == 584)
				{
					this.log.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 585;
				}
				if (num == 652)
				{
					this.cflow.AutoSize = true;
					num = 653;
				}
				if (num == 207)
				{
					this.obfuscate.TabIndex = 2;
					num = 208;
				}
				if (num == 447)
				{
					this.invalidmd.Text = " Invalid MD : 32bit Only";
					num = 448;
				}
				if (num == 357)
				{
					this.packer.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 358;
				}
				if (num == 945)
				{
					this.ade4dot.Name = "ade4dot";
					num = 946;
				}
				if (num == 577)
				{
					this.siticonePanel11.TabIndex = 39;
					num = 578;
				}
				if (num == 1344)
				{
					this.siticoneLabel10.IsSelectionEnabled = false;
					num = 1345;
				}
				if (num == 1516)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 1517;
				}
				if (num == 1065)
				{
					this.siticonePanel2.Controls.Add(this.mstrip);
					num = 1066;
				}
				if (num == 1472)
				{
					this.BrowseSNK.CustomImages.Parent = this.BrowseSNK;
					num = 1473;
				}
				if (num == 906)
				{
					this.asciisenc.Location = new global::System.Drawing.Point(15, 151);
					num = 907;
				}
				if (num == 1531)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 1532;
				}
				if (num == 1403)
				{
					this.checkall.Click += new global::System.EventHandler(this.checkall_Click);
					num = 1404;
				}
				if (num == 1367)
				{
					this.renamer2.TabIndex = 37;
					num = 1368;
				}
				if (num == 358)
				{
					this.packer.UseVisualStyleBackColor = true;
					num = 359;
				}
				if (num == 1284)
				{
					this.AsciiType.Location = new global::System.Drawing.Point(0, 2);
					num = 1285;
				}
				if (num == 1295)
				{
					this.siticoneLabel13.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1296;
				}
				if (num == 469)
				{
					this.ajunk.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 470;
				}
				if (num == 1438)
				{
					this.siticoneLabel15.Size = new global::System.Drawing.Size(146, 17);
					num = 1439;
				}
				if (num == 426)
				{
					this.mutation.Size = new global::System.Drawing.Size(83, 21);
					num = 427;
				}
				if (num == 1022)
				{
					this.apacker.CheckedState.BorderThickness = 0;
					num = 1023;
				}
				if (num == 313)
				{
					this.browse.CheckedState.Parent = this.browse;
					num = 314;
				}
				if (num == 553)
				{
					this.sconfusion.CheckedState.BorderRadius = 2;
					num = 554;
				}
				if (num == 724)
				{
					this.movepnl.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 725;
				}
				if (num == 460)
				{
					this.ajunk.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 461;
				}
				if (num == 679)
				{
					this.siticonePanel9.TabIndex = 38;
					num = 680;
				}
				if (num == 551)
				{
					this.sconfusion.AutoSize = true;
					num = 552;
				}
				if (num == 1348)
				{
					this.siticoneLabel10.TabIndex = 25;
					num = 1349;
				}
				if (num == 930)
				{
					this.hstr.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 931;
				}
				if (num == 515)
				{
					this.fobf.CheckedState.BorderRadius = 2;
					num = 516;
				}
				if (num == 1418)
				{
					this.siticonePanel7.Controls.Add(this.siticoneLabel15);
					num = 1419;
				}
				if (num == 98)
				{
					this.siticoneLabel3 = new global::ns1.SiticoneLabel();
					num = 99;
				}
				if (num == 1340)
				{
					this.siticoneLabel10.BackColor = global::System.Drawing.Color.Transparent;
					num = 1341;
				}
				if (num == 761)
				{
					this.siticoneLabel8.Name = "siticoneLabel8";
					num = 762;
				}
				if (num == 1273)
				{
					this.AsciiType.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1274;
				}
				if (num == 1370)
				{
					this.renamer2.TextLeftAlign = 0;
					num = 1371;
				}
				if (num == 793)
				{
					this.donation.TabIndex = 14;
					num = 794;
				}
				if (num == 1206)
				{
					this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
					num = 1207;
				}
				if (num == 1103)
				{
					this.alllength.Minimum = 5;
					num = 1104;
				}
				if (num == 1078)
				{
					this.siticonePanel2.Controls.Add(this.aildasm);
					num = 1079;
				}
				if (num == 975)
				{
					this.aildasm.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 976;
				}
				if (num == 1035)
				{
					this.apacker.UncheckedState.BorderThickness = 1;
					num = 1036;
				}
				if (num == 781)
				{
					this.siticoneVSeparator1.Size = new global::System.Drawing.Size(10, 20);
					num = 782;
				}
				if (num == 1493)
				{
					this.SNKText.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
					num = 1494;
				}
				if (num == 753)
				{
					this.siticoneLabel9.UseGdiPlusTextRendering = true;
					num = 754;
				}
				if (num == 821)
				{
					this.logo.HoveredState.ImageSize = new global::System.Drawing.Size(22, 22);
					num = 822;
				}
				if (num == 1404)
				{
					this.uncheckall.BackColor = global::System.Drawing.Color.Transparent;
					num = 1405;
				}
				if (num == 377)
				{
					this.arith.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 378;
				}
				if (num == 493)
				{
					this.hmethods.AutoSize = true;
					num = 494;
				}
				if (num == 692)
				{
					this.pobf.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 693;
				}
				if (num == 937)
				{
					this.ade4dot.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 938;
				}
				if (num == 77)
				{
					this.siticoneLabel11 = new global::ns1.SiticoneLabel();
					num = 78;
				}
				if (num == 1428)
				{
					this.siticoneSeparator2.Name = "siticoneSeparator2";
					num = 1429;
				}
				if (num == 159)
				{
					this.pmobf.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 160;
				}
				if (num == 296)
				{
					this.assemblytext.Location = new global::System.Drawing.Point(18, 16);
					num = 297;
				}
				if (num == 139)
				{
					this.cryptosenc.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 140;
				}
				if (num == 50)
				{
					this.siticoneLabel2 = new global::ns1.SiticoneLabel();
					num = 51;
				}
				if (num == 940)
				{
					this.ade4dot.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 941;
				}
				if (num == 411)
				{
					this.siticoneLabel7.Name = "siticoneLabel7";
					num = 412;
				}
				if (num == 637)
				{
					this.adebug.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 638;
				}
				if (num == 1546)
				{
					this.siticonePanel10.ResumeLayout(false);
					num = 1547;
				}
				if (num == 331)
				{
					this.siticoneLabel1.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 332;
				}
				if (num == 722)
				{
					this.movepnl.Controls.Add(this.movelbl2);
					num = 723;
				}
				if (num == 341)
				{
					this.packer.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 342;
				}
				if (num == 598)
				{
					this.siticonePanel10.ShadowDecoration.Parent = this.siticonePanel10;
					num = 599;
				}
				if (num == 1452)
				{
					this.siticonePanel8.Location = new global::System.Drawing.Point(509, 182);
					num = 1453;
				}
				if (num == 911)
				{
					this.asciisenc.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 912;
				}
				if (num == 1425)
				{
					this.siticoneSeparator2.FillColor = global::System.Drawing.Color.IndianRed;
					num = 1426;
				}
				if (num == 1194)
				{
					this.siticoneLabel12.Location = new global::System.Drawing.Point(162, 12);
					num = 1195;
				}
				if (num == 1528)
				{
					base.Controls.Add(this.movepnl);
					num = 1529;
				}
				if (num == 144)
				{
					this.cryptosenc.Name = "cryptosenc";
					num = 145;
				}
				if (num == 545)
				{
					this.omethods.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 546;
				}
				if (num == 118)
				{
					this.pint.CheckedState.BorderRadius = 2;
					num = 119;
				}
				if (num == 529)
				{
					this.fobf.UncheckedState.BorderThickness = 1;
					num = 530;
				}
				if (num == 1217)
				{
					this.SymbolsType.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1218;
				}
				if (num == 507)
				{
					this.hmethods.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 508;
				}
				if (num == 267)
				{
					this.siticoneSeparator3.FillColor = global::System.Drawing.Color.IndianRed;
					num = 268;
				}
				if (num == 1023)
				{
					this.apacker.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 1024;
				}
				if (num == 1533)
				{
					base.MaximizeBox = false;
					num = 1534;
				}
				if (num == 1557)
				{
					this.siticonePanel7.PerformLayout();
					num = 1558;
				}
				if (num == 1060)
				{
					this.siticonePanel2.Controls.Add(this.arith);
					num = 1061;
				}
				if (num == 1484)
				{
					this.BrowseSNK.Text = "Browse";
					num = 1485;
				}
				if (num == 479)
				{
					this.mstrip.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 480;
				}
				if (num == 1149)
				{
					this.BaseSenc.TabIndex = 45;
					num = 1150;
				}
				if (num == 1061)
				{
					this.siticonePanel2.Controls.Add(this.mutation);
					num = 1062;
				}
				if (num == 1255)
				{
					this.NumbersType.CheckedBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1256;
				}
				if (num == 879)
				{
					this.virt.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 880;
				}
				if (num == 1310)
				{
					this.cflowStatus.Name = "cflowStatus";
					num = 1311;
				}
				if (num == 434)
				{
					this.mutation.UseVisualStyleBackColor = true;
					num = 435;
				}
				if (num == 448)
				{
					this.invalidmd.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 449;
				}
				if (num == 1248)
				{
					this.ChineseType.TextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1249;
				}
				if (num == 470)
				{
					this.ajunk.UncheckedState.BorderRadius = 1;
					num = 471;
				}
				if (num == 338)
				{
					this.siticoneLabel1.Text = "Renamer";
					num = 339;
				}
				if (num == 140)
				{
					this.cryptosenc.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 141;
				}
				if (num == 522)
				{
					this.fobf.Name = "fobf";
					num = 523;
				}
				if (num == 909)
				{
					this.asciisenc.TabIndex = 5;
					num = 910;
				}
				if (num == 429)
				{
					this.mutation.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 430;
				}
				if (num == 501)
				{
					this.hmethods.Location = new global::System.Drawing.Point(310, 80);
					num = 502;
				}
				if (num == 1537)
				{
					this.Text = "Rose V4";
					num = 1538;
				}
				if (num == 1334)
				{
					this.cflowTrackBar.Name = "cflowTrackBar";
					num = 1335;
				}
				if (num == 1107)
				{
					this.alllength.TabIndex = 48;
					num = 1108;
				}
				if (num == 390)
				{
					this.signer.TabIndex = 29;
					num = 391;
				}
				if (num == 439)
				{
					this.invalidmd.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 440;
				}
				if (num == 527)
				{
					this.fobf.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 528;
				}
				if (num == 786)
				{
					this.donation.HoveredState.Parent = this.donation;
					num = 787;
				}
				if (num == 228)
				{
					this.siticoneLabel5.IsContextMenuEnabled = false;
					num = 229;
				}
				if (num == 842)
				{
					this.discord.BackColor = global::System.Drawing.Color.Transparent;
					num = 843;
				}
				if (num == 424)
				{
					this.mutation.Location = new global::System.Drawing.Point(162, 246);
					num = 425;
				}
				if (num == 1526)
				{
					base.Controls.Add(this.siticonePanel5);
					num = 1527;
				}
				if (num == 955)
				{
					this.adump.AutoSize = true;
					num = 956;
				}
				if (num == 1263)
				{
					this.NumbersType.Location = new global::System.Drawing.Point(0, 28);
					num = 1264;
				}
				if (num == 857)
				{
					this.movelbl2.IsContextMenuEnabled = false;
					num = 858;
				}
				if (num == 73)
				{
					this.siticoneSeparator1 = new global::ns1.SiticoneSeparator();
					num = 74;
				}
				if (num == 1259)
				{
					this.NumbersType.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1260;
				}
				if (num == 974)
				{
					this.aildasm.AutoSize = true;
					num = 975;
				}
				if (num == 901)
				{
					this.asciisenc.CheckedState.BorderThickness = 0;
					num = 902;
				}
				if (num == 525)
				{
					this.fobf.Text = " Fake Obfuscator";
					num = 526;
				}
				if (num == 513)
				{
					this.fobf.AutoSize = true;
					num = 514;
				}
				if (num == 531)
				{
					this.fobf.UseVisualStyleBackColor = true;
					num = 532;
				}
				if (num == 294)
				{
					this.assemblytext.HoveredState.BorderColor = global::System.Drawing.Color.LightCoral;
					num = 295;
				}
				if (num == 1132)
				{
					this.siticoneLabel17.Location = new global::System.Drawing.Point(162, 104);
					num = 1133;
				}
				if (num == 1158)
				{
					this.RenamerOFF.BackColor = global::System.Drawing.Color.Transparent;
					num = 1159;
				}
				if (num == 1144)
				{
					this.BaseSenc.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 1145;
				}
				if (num == 770)
				{
					this.siticoneLabel2.IsContextMenuEnabled = false;
					num = 771;
				}
				if (num == 1137)
				{
					this.siticoneLabel17.UseGdiPlusTextRendering = true;
					num = 1138;
				}
				if (num == 1468)
				{
					this.BrowseSNK.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1469;
				}
				if (num == 1498)
				{
					this.SNKText.FocusedState.Parent = this.SNKText;
					num = 1499;
				}
				if (num == 394)
				{
					this.signer.UncheckedState.BorderRadius = 1;
					num = 395;
				}
				if (num == 1432)
				{
					this.siticoneLabel15.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1433;
				}
				if (num == 875)
				{
					this.movelbl.Text = "R O S E";
					num = 876;
				}
				if (num == 799)
				{
					this.min.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("min.Image");
					num = 800;
				}
				if (num == 176)
				{
					this.hnamespaces.CheckedState.BorderThickness = 0;
					num = 177;
				}
				if (num == 323)
				{
					this.browse.ShadowDecoration.Parent = this.browse;
					num = 324;
				}
				if (num == 1205)
				{
					this.siticonePanel1.Name = "siticonePanel1";
					num = 1206;
				}
				if (num == 979)
				{
					this.aildasm.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 980;
				}
				if (num == 827)
				{
					this.logo.PressedState.Parent = this.logo;
					num = 828;
				}
				if (num == 1319)
				{
					this.siticoneLabel14.IsSelectionEnabled = false;
					num = 1320;
				}
				if (num == 1538)
				{
					base.Load += new global::System.EventHandler(this.Form1_Load);
					num = 1539;
				}
				if (num == 764)
				{
					this.siticoneLabel8.Text = "L A S T ";
					num = 765;
				}
				if (num == 444)
				{
					this.invalidmd.Name = "invalidmd";
					num = 445;
				}
				if (num == 1084)
				{
					this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
					num = 1085;
				}
				if (num == 944)
				{
					this.ade4dot.Location = new global::System.Drawing.Point(15, 103);
					num = 945;
				}
				if (num == 170)
				{
					this.pmobf.UncheckedState.BorderThickness = 1;
					num = 171;
				}
				if (num == 1193)
				{
					this.siticoneLabel12.IsSelectionEnabled = false;
					num = 1194;
				}
				if (num == 315)
				{
					this.browse.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 316;
				}
				if (num == 1519)
				{
					base.ClientSize = new global::System.Drawing.Size(797, 514);
					num = 1520;
				}
				if (num == 306)
				{
					this.assemblytext.TabStop = false;
					num = 307;
				}
				if (num == 1056)
				{
					this.siticonePanel2.Controls.Add(this.cryptosenc);
					num = 1057;
				}
				if (num == 1249)
				{
					this.ChineseType.TextLeftAlign = 0;
					num = 1250;
				}
				if (num == 1495)
				{
					this.SNKText.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
					num = 1496;
				}
				if (num == 1131)
				{
					this.siticoneLabel17.IsSelectionEnabled = false;
					num = 1132;
				}
				if (num == 688)
				{
					this.siticoneLabel6.TabIndex = 23;
					num = 689;
				}
				if (num == 442)
				{
					this.invalidmd.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 443;
				}
				if (num == 304)
				{
					this.assemblytext.Size = new global::System.Drawing.Size(244, 24);
					num = 305;
				}
				if (num == 92)
				{
					this.uncheckall = new global::ns1.SiticoneImageButton();
					num = 93;
				}
				if (num == 1073)
				{
					this.siticonePanel2.Controls.Add(this.pobf);
					num = 1074;
				}
				if (num == 1152)
				{
					this.BaseSenc.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1153;
				}
				if (num == 1212)
				{
					this.SymbolsType.Checked = false;
					num = 1213;
				}
				if (num == 1316)
				{
					this.siticoneLabel14.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1317;
				}
				if (num == 960)
				{
					this.adump.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 961;
				}
				if (num == 1506)
				{
					this.SNKText.ReadOnly = true;
					num = 1507;
				}
				if (num == 962)
				{
					this.adump.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 963;
				}
				if (num == 957)
				{
					this.adump.CheckedState.BorderRadius = 2;
					num = 958;
				}
				if (num == 352)
				{
					this.packer.Text = " Packer can be used with some protections";
					num = 353;
				}
				if (num == 1387)
				{
					this.renamer.Size = new global::System.Drawing.Size(88, 20);
					num = 1388;
				}
				if (num == 1290)
				{
					this.AsciiType.TextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1291;
				}
				if (num == 124)
				{
					this.pint.Location = new global::System.Drawing.Point(162, 81);
					num = 125;
				}
				if (num == 430)
				{
					this.mutation.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 431;
				}
				if (num == 933)
				{
					this.hstr.UncheckedState.BorderThickness = 1;
					num = 934;
				}
				if (num == 744)
				{
					this.siticoneLabel9.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 745;
				}
				if (num == 1359)
				{
					this.renamer2.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1360;
				}
				if (num == 3)
				{
					this.siticoneElipse1 = new global::ns1.SiticoneElipse(this.components);
					num = 4;
				}
				if (num == 1087)
				{
					this.siticoneLabel19.BackColor = global::System.Drawing.Color.Transparent;
					num = 1088;
				}
				if (num == 475)
				{
					this.mstrip.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 476;
				}
				if (num == 1143)
				{
					this.BaseSenc.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 1144;
				}
				if (num == 508)
				{
					this.hmethods.UncheckedState.BorderRadius = 1;
					num = 509;
				}
				if (num == 193)
				{
					this.obfuscate.BorderRadius = 2;
					num = 194;
				}
				if (num == 1435)
				{
					this.siticoneLabel15.IsSelectionEnabled = false;
					num = 1436;
				}
				if (num == 9)
				{
					this.siticonePanel6 = new global::ns1.SiticonePanel();
					num = 10;
				}
				if (num == 1067)
				{
					this.siticonePanel2.Controls.Add(this.fobf);
					num = 1068;
				}
				if (num == 188)
				{
					this.hnamespaces.UncheckedState.BorderRadius = 1;
					num = 189;
				}
				if (num == 295)
				{
					this.assemblytext.HoveredState.Parent = this.assemblytext;
					num = 296;
				}
				if (num == 893)
				{
					this.virt.UncheckedState.BorderRadius = 1;
					num = 894;
				}
				if (num == 967)
				{
					this.adump.Text = " Anti Dump";
					num = 968;
				}
				if (num == 674)
				{
					this.siticonePanel9.Controls.Add(this.siticoneSeparator8);
					num = 675;
				}
				if (num == 878)
				{
					this.virt.AutoSize = true;
					num = 879;
				}
				if (num == 617)
				{
					this.cconfusion.Size = new global::System.Drawing.Size(117, 21);
					num = 618;
				}
				if (num == 161)
				{
					this.pmobf.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 162;
				}
				if (num == 1529)
				{
					base.Controls.Add(this.siticonePanel3);
					num = 1530;
				}
				if (num == 1139)
				{
					this.BaseSenc.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1140;
				}
				if (num == 122)
				{
					this.pint.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 123;
				}
				if (num == 734)
				{
					this.siticoneLabel16.IsContextMenuEnabled = false;
					num = 735;
				}
				if (num == 1408)
				{
					this.uncheckall.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("uncheckall.Image");
					num = 1409;
				}
				if (num == 571)
				{
					this.siticonePanel11.Controls.Add(this.siticoneLabel7);
					num = 572;
				}
				if (num == 55)
				{
					this.logo = new global::ns1.SiticoneImageButton();
					num = 56;
				}
				if (num == 852)
				{
					this.discord.TabIndex = 9;
					num = 853;
				}
				if (num == 787)
				{
					this.donation.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("donation.Image");
					num = 788;
				}
				if (num == 625)
				{
					this.cconfusion.UseVisualStyleBackColor = true;
					num = 626;
				}
				if (num == 1431)
				{
					this.siticoneLabel15.BackColor = global::System.Drawing.Color.Transparent;
					num = 1432;
				}
				if (num == 255)
				{
					this.siticonePanel4.Controls.Add(this.siticoneSeparator3);
					num = 256;
				}
				if (num == 638)
				{
					this.adebug.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 639;
				}
				if (num == 998)
				{
					this.atamper.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 999;
				}
				if (num == 1445)
				{
					this.siticoneSeparator11.Name = "siticoneSeparator11";
					num = 1446;
				}
				if (num == 1394)
				{
					this.checkall.HoveredState.ImageSize = new global::System.Drawing.Size(22, 22);
					num = 1395;
				}
				if (num == 206)
				{
					this.obfuscate.Size = new global::System.Drawing.Size(131, 30);
					num = 207;
				}
				if (num == 117)
				{
					this.pint.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 118;
				}
				if (num == 238)
				{
					this.siticoneSeparator6.Location = new global::System.Drawing.Point(287, 7);
					num = 239;
				}
				if (num == 631)
				{
					this.siticoneSeparator7.Size = new global::System.Drawing.Size(20, 10);
					num = 632;
				}
				if (num == 730)
				{
					this.movepnl.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.movepnl_MouseDown);
					num = 731;
				}
				if (num == 664)
				{
					this.cflow.Text = " Enable";
					num = 665;
				}
				if (num == 148)
				{
					this.cryptosenc.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 149;
				}
				if (num == 1031)
				{
					this.apacker.Text = " Another Packer";
					num = 1032;
				}
				if (num == 947)
				{
					this.ade4dot.TabIndex = 3;
					num = 948;
				}
				if (num == 141)
				{
					this.cryptosenc.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 142;
				}
				if (num == 42)
				{
					this.cflow = new global::ns1.SiticoneCheckBox();
					num = 43;
				}
				if (num == 1457)
				{
					this.siticoneLabel3.BackColor = global::System.Drawing.Color.Transparent;
					num = 1458;
				}
				if (num == 1245)
				{
					this.ChineseType.Size = new global::System.Drawing.Size(74, 20);
					num = 1246;
				}
				if (num == 462)
				{
					this.ajunk.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 463;
				}
				if (num == 363)
				{
					this.arith.CheckedState.BorderThickness = 0;
					num = 364;
				}
				if (num == 871)
				{
					this.movelbl.Location = new global::System.Drawing.Point(38, 11);
					num = 872;
				}
				if (num == 1379)
				{
					this.renamer.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
					num = 1380;
				}
				if (num == 192)
				{
					this.obfuscate.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 193;
				}
				if (num == 65)
				{
					this.aildasm = new global::ns1.SiticoneCheckBox();
					num = 66;
				}
				if (num == 178)
				{
					this.hnamespaces.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 179;
				}
				if (num == 1513)
				{
					this.SNKText.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
					num = 1514;
				}
				if (num == 743)
				{
					this.siticoneLabel9.BackColor = global::System.Drawing.Color.Transparent;
					num = 744;
				}
				if (num == 1063)
				{
					this.siticonePanel2.Controls.Add(this.invalidmd);
					num = 1064;
				}
				if (num == 79)
				{
					this.siticonePanel1 = new global::ns1.SiticonePanel();
					num = 80;
				}
				if (num == 175)
				{
					this.hnamespaces.CheckedState.BorderRadius = 2;
					num = 176;
				}
				if (num == 49)
				{
					this.siticoneLabel8 = new global::ns1.SiticoneLabel();
					num = 50;
				}
				if (num == 1426)
				{
					this.siticoneSeparator2.FillThickness = 2;
					num = 1427;
				}
				if (num == 914)
				{
					this.asciisenc.UncheckedState.BorderThickness = 1;
					num = 915;
				}
				if (num == 1490)
				{
					this.SNKText.DefaultText = "Drag & Drop Supported";
					num = 1491;
				}
				if (num == 782)
				{
					this.siticoneVSeparator1.TabIndex = 4;
					num = 783;
				}
				if (num == 605)
				{
					this.siticoneSeparator8.Size = new global::System.Drawing.Size(30, 10);
					num = 606;
				}
				if (num == 360)
				{
					this.arith.AutoSize = true;
					num = 361;
				}
				if (num == 596)
				{
					this.siticonePanel10.Location = new global::System.Drawing.Point(509, 345);
					num = 597;
				}
				if (num == 1218)
				{
					this.SymbolsType.HoverBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1219;
				}
				if (num == 866)
				{
					this.movelbl.BackColor = global::System.Drawing.Color.Transparent;
					num = 867;
				}
				if (num == 406)
				{
					this.siticoneLabel7.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 407;
				}
				if (num == 1097)
				{
					this.siticoneLabel19.UseGdiPlusTextRendering = true;
					num = 1098;
				}
				if (num == 281)
				{
					this.assemblytext.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 282;
				}
				if (num == 392)
				{
					this.signer.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 393;
				}
				if (num == 1251)
				{
					this.NumbersType.BackColor = global::System.Drawing.Color.Transparent;
					num = 1252;
				}
				if (num == 492)
				{
					this.mstrip.UseVisualStyleBackColor = true;
					num = 493;
				}
				if (num == 332)
				{
					this.siticoneLabel1.IsContextMenuEnabled = false;
					num = 333;
				}
				if (num == 47)
				{
					this.siticoneLabel16 = new global::ns1.SiticoneLabel();
					num = 48;
				}
				if (num == 450)
				{
					this.invalidmd.UncheckedState.BorderRadius = 1;
					num = 451;
				}
				if (num == 694)
				{
					this.pobf.CheckedState.BorderThickness = 0;
					num = 695;
				}
				if (num == 1216)
				{
					this.SymbolsType.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
					num = 1217;
				}
				if (num == 197)
				{
					this.obfuscate.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 198;
				}
				if (num == 1146)
				{
					this.BaseSenc.Location = new global::System.Drawing.Point(74, 151);
					num = 1147;
				}
				if (num == 959)
				{
					this.adump.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 960;
				}
				if (num == 399)
				{
					this.siticoneSeparator9.FillColor = global::System.Drawing.Color.IndianRed;
					num = 400;
				}
				if (num == 591)
				{
					this.log.Location = new global::System.Drawing.Point(8, 10);
					num = 592;
				}
				if (num == 1460)
				{
					this.siticoneLabel3.IsContextMenuEnabled = false;
					num = 1461;
				}
				if (num == 1365)
				{
					this.renamer2.ReadOnly = false;
					num = 1366;
				}
				if (num == 1191)
				{
					this.siticoneLabel12.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1192;
				}
				if (num == 755)
				{
					this.siticoneLabel8.BackColor = global::System.Drawing.Color.Transparent;
					num = 756;
				}
				if (num == 855)
				{
					this.movelbl2.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 856;
				}
				if (num == 779)
				{
					this.siticoneVSeparator1.Location = new global::System.Drawing.Point(621, 10);
					num = 780;
				}
				if (num == 246)
				{
					this.siticoneLabel4.IsSelectionEnabled = false;
					num = 247;
				}
				if (num == 814)
				{
					this.exit.Name = "exit";
					num = 815;
				}
				if (num == 943)
				{
					this.ade4dot.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 944;
				}
				if (num == 805)
				{
					this.min.TabIndex = 13;
					num = 806;
				}
				if (num == 1221)
				{
					this.SymbolsType.Location = new global::System.Drawing.Point(88, 28);
					num = 1222;
				}
				if (num == 767)
				{
					this.siticoneLabel2.BackColor = global::System.Drawing.Color.Transparent;
					num = 768;
				}
				if (num == 831)
				{
					this.facebook.CheckedState.Parent = this.facebook;
					num = 832;
				}
				if (num == 397)
				{
					this.signer.UseVisualStyleBackColor = true;
					num = 398;
				}
				if (num == 576)
				{
					this.siticonePanel11.Size = new global::System.Drawing.Size(280, 22);
					num = 577;
				}
				if (num == 589)
				{
					this.log.ItemHeight = 14;
					num = 590;
				}
				if (num == 1242)
				{
					this.ChineseType.Location = new global::System.Drawing.Point(88, 2);
					num = 1243;
				}
				if (num == 707)
				{
					this.pobf.UncheckedState.BorderThickness = 1;
					num = 708;
				}
				if (num == 1419)
				{
					this.siticonePanel7.Controls.Add(this.siticoneSeparator11);
					num = 1420;
				}
				if (num == 610)
				{
					this.cconfusion.CheckedState.BorderThickness = 0;
					num = 611;
				}
				if (num == 976)
				{
					this.aildasm.CheckedState.BorderRadius = 2;
					num = 977;
				}
				if (num == 791)
				{
					this.donation.PressedState.Parent = this.donation;
					num = 792;
				}
				if (num == 346)
				{
					this.packer.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 347;
				}
				if (num == 1389)
				{
					this.renamer.Text = "Method 1";
					num = 1390;
				}
				if (num == 1006)
				{
					this.atamper.UncheckedState.BorderRadius = 1;
					num = 1007;
				}
				if (num == 408)
				{
					this.siticoneLabel7.IsContextMenuEnabled = false;
					num = 409;
				}
				if (num == 96)
				{
					this.siticoneSeparator11 = new global::ns1.SiticoneSeparator();
					num = 97;
				}
				if (num == 839)
				{
					this.facebook.Size = new global::System.Drawing.Size(24, 24);
					num = 840;
				}
				if (num == 1178)
				{
					this.siticoneLabel11.BackColor = global::System.Drawing.Color.Transparent;
					num = 1179;
				}
				if (num == 1252)
				{
					this.NumbersType.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1253;
				}
				if (num == 486)
				{
					this.mstrip.Text = " Meta Strip";
					num = 487;
				}
				if (num == 1362)
				{
					this.renamer2.HoverTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1363;
				}
				if (num == 846)
				{
					this.discord.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("discord.Image");
					num = 847;
				}
				if (num == 1455)
				{
					this.siticonePanel8.Size = new global::System.Drawing.Size(280, 143);
					num = 1456;
				}
				if (num == 990)
				{
					this.aildasm.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 991;
				}
				if (num == 993)
				{
					this.atamper.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 994;
				}
				if (num == 1173)
				{
					this.RenamerOFF.Size = new global::System.Drawing.Size(88, 20);
					num = 1174;
				}
				if (num == 86)
				{
					this.siticoneLabel14 = new global::ns1.SiticoneLabel();
					num = 87;
				}
				if (num == 310)
				{
					this.browse.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 311;
				}
				if (num == 1119)
				{
					this.siticoneLabel18.TabIndex = 47;
					num = 1120;
				}
				if (num == 1447)
				{
					this.siticoneSeparator11.TabIndex = 24;
					num = 1448;
				}
				if (num == 820)
				{
					this.logo.CheckedState.Parent = this.logo;
					num = 821;
				}
				if (num == 740)
				{
					this.siticoneLabel16.Text = "R E L E A S E";
					num = 741;
				}
				if (num == 1353)
				{
					this.renamer2.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
					num = 1354;
				}
				if (num == 353)
				{
					this.packer.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 354;
				}
				if (num == 155)
				{
					this.pmobf.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 156;
				}
				if (num == 1136)
				{
					this.siticoneLabel17.Text = "Calli / Stack Confusion";
					num = 1137;
				}
				if (num == 282)
				{
					this.assemblytext.BorderRadius = 2;
					num = 283;
				}
				if (num == 60)
				{
					this.virt = new global::ns1.SiticoneCheckBox();
					num = 61;
				}
				if (num == 453)
				{
					this.invalidmd.UseVisualStyleBackColor = true;
					num = 454;
				}
				if (num == 645)
				{
					this.adebug.Text = " Anti Debug";
					num = 646;
				}
				if (num == 646)
				{
					this.adebug.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 647;
				}
				if (num == 62)
				{
					this.hstr = new global::ns1.SiticoneCheckBox();
					num = 63;
				}
				if (num == 1410)
				{
					this.uncheckall.Location = new global::System.Drawing.Point(468, 288);
					num = 1411;
				}
				if (num == 190)
				{
					this.hnamespaces.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 191;
				}
				if (num == 102)
				{
					this.siticonePanel4.SuspendLayout();
					num = 103;
				}
				if (num == 580)
				{
					this.siticoneSeparator10.Location = new global::System.Drawing.Point(166, 7);
					num = 581;
				}
				if (num == 923)
				{
					this.hstr.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 924;
				}
				if (num == 114)
				{
					this.siticoneElipse1.BorderRadius = 4;
					num = 115;
				}
				if (num == 915)
				{
					this.asciisenc.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 916;
				}
				if (num == 1150)
				{
					this.BaseSenc.Text = "Base64";
					num = 1151;
				}
				if (num == 1116)
				{
					this.siticoneLabel18.Location = new global::System.Drawing.Point(310, 278);
					num = 1117;
				}
				if (num == 983)
				{
					this.aildasm.Size = new global::System.Drawing.Size(99, 21);
					num = 984;
				}
				if (num == 977)
				{
					this.aildasm.CheckedState.BorderThickness = 0;
					num = 978;
				}
				if (num == 1040)
				{
					this.siticonePanel2.Controls.Add(this.alllength);
					num = 1041;
				}
				if (num == 1336)
				{
					this.cflowTrackBar.TabIndex = 33;
					num = 1337;
				}
				if (num == 1174)
				{
					this.RenamerOFF.TabIndex = 43;
					num = 1175;
				}
				if (num == 1385)
				{
					this.renamer.Name = "renamer";
					num = 1386;
				}
				if (num == 1515)
				{
					this.SNKText.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.SNKText_DragEnter);
					num = 1516;
				}
				if (num == 1409)
				{
					this.uncheckall.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 1410;
				}
				if (num == 451)
				{
					this.invalidmd.UncheckedState.BorderThickness = 1;
					num = 452;
				}
				if (num == 320)
				{
					this.browse.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 321;
				}
				if (num == 455)
				{
					this.ajunk.AutoSize = true;
					num = 456;
				}
				if (num == 845)
				{
					this.discord.HoveredState.Parent = this.discord;
					num = 846;
				}
				if (num == 1271)
				{
					this.NumbersType.CheckedChanged += new global::System.EventHandler(this.NumbersType_CheckedChanged);
					num = 1272;
				}
				if (num == 440)
				{
					this.invalidmd.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 441;
				}
				if (num == 1020)
				{
					this.apacker.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1021;
				}
				if (num == 1167)
				{
					this.RenamerOFF.HoverBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1168;
				}
				if (num == 1184)
				{
					this.siticoneLabel11.Name = "siticoneLabel11";
					num = 1185;
				}
				if (num == 910)
				{
					this.asciisenc.Text = " Ascii";
					num = 911;
				}
				if (num == 149)
				{
					this.cryptosenc.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 150;
				}
				if (num == 671)
				{
					this.cflow.CheckedChanged += new global::System.EventHandler(this.cflow_CheckedChanged);
					num = 672;
				}
				if (num == 297)
				{
					this.assemblytext.Name = "assemblytext";
					num = 298;
				}
				if (num == 237)
				{
					this.siticoneSeparator6.FillThickness = 2;
					num = 238;
				}
				if (num == 834)
				{
					this.facebook.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("facebook.Image");
					num = 835;
				}
				if (num == 1264)
				{
					this.NumbersType.Name = "NumbersType";
					num = 1265;
				}
				if (num == 347)
				{
					this.packer.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 348;
				}
				if (num == 1440)
				{
					this.siticoneLabel15.Text = "Signer : strong name key";
					num = 1441;
				}
				if (num == 71)
				{
					this.alllength = new global::ns1.SiticoneMetroTrackBar();
					num = 72;
				}
				if (num == 487)
				{
					this.mstrip.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 488;
				}
				if (num == 1491)
				{
					this.SNKText.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
					num = 1492;
				}
				if (num == 183)
				{
					this.hnamespaces.Size = new global::System.Drawing.Size(137, 21);
					num = 184;
				}
				if (num == 24)
				{
					this.siticoneSeparator9 = new global::ns1.SiticoneSeparator();
					num = 25;
				}
				if (num == 1357)
				{
					this.renamer2.CheckedTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1358;
				}
				if (num == 1464)
				{
					this.siticoneLabel3.Size = new global::System.Drawing.Size(229, 17);
					num = 1465;
				}
				if (num == 395)
				{
					this.signer.UncheckedState.BorderThickness = 1;
					num = 396;
				}
				if (num == 936)
				{
					this.ade4dot.AutoSize = true;
					num = 937;
				}
				if (num == 1375)
				{
					this.renamer.Checked = false;
					num = 1376;
				}
				if (num == 1555)
				{
					this.siticonePanel1.ResumeLayout(false);
					num = 1556;
				}
				if (num == 741)
				{
					this.siticoneLabel16.UseGdiPlusTextRendering = true;
					num = 742;
				}
				if (num == 843)
				{
					this.discord.CheckedState.Parent = this.discord;
					num = 844;
				}
				if (num == 1326)
				{
					this.cflowTrackBar.Enabled = false;
					num = 1327;
				}
				if (num == 58)
				{
					this.movelbl2 = new global::ns1.SiticoneLabel();
					num = 59;
				}
				if (num == 1328)
				{
					this.cflowTrackBar.HoveredState.Parent = this.cflowTrackBar;
					num = 1329;
				}
				if (num == 34)
				{
					this.siticonePanel11 = new global::ns1.SiticonePanel();
					num = 35;
				}
				if (num == 1081)
				{
					this.siticonePanel2.Controls.Add(this.uncheckall);
					num = 1082;
				}
				if (num == 1053)
				{
					this.siticonePanel2.Controls.Add(this.siticoneLabel10);
					num = 1054;
				}
				if (num == 925)
				{
					this.hstr.Location = new global::System.Drawing.Point(15, 197);
					num = 926;
				}
				if (num == 1086)
				{
					this.siticonePanel2.TabIndex = 33;
					num = 1087;
				}
				if (num == 196)
				{
					this.obfuscate.CustomImages.Parent = this.obfuscate;
					num = 197;
				}
				if (num == 499)
				{
					this.hmethods.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 500;
				}
				if (num == 328)
				{
					this.browse.Click += new global::System.EventHandler(this.browse_Click);
					num = 329;
				}
				if (num == 412)
				{
					this.siticoneLabel7.Size = new global::System.Drawing.Size(49, 17);
					num = 413;
				}
				if (num == 1240)
				{
					this.ChineseType.HoverFillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
					num = 1241;
				}
				if (num == 685)
				{
					this.siticoneLabel6.Location = new global::System.Drawing.Point(188, 1);
					num = 686;
				}
				if (num == 562)
				{
					this.sconfusion.TabIndex = 10;
					num = 563;
				}
				if (num == 1327)
				{
					this.cflowTrackBar.FillColor = global::System.Drawing.Color.FromArgb(193, 200, 207);
					num = 1328;
				}
				if (num == 1175)
				{
					this.RenamerOFF.Text = "Disable";
					num = 1176;
				}
				if (num == 312)
				{
					this.browse.BorderThickness = 1;
					num = 313;
				}
				if (num == 1161)
				{
					this.RenamerOFF.Checked = false;
					num = 1162;
				}
				if (num == 1396)
				{
					this.checkall.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("checkall.Image");
					num = 1397;
				}
				if (num == 897)
				{
					this.virt.CheckedChanged += new global::System.EventHandler(this.virt_CheckedChanged);
					num = 898;
				}
				if (num == 882)
				{
					this.virt.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 883;
				}
				if (num == 1036)
				{
					this.apacker.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 1037;
				}
				if (num == 606)
				{
					this.siticoneSeparator8.TabIndex = 24;
					num = 607;
				}
				if (num == 1008)
				{
					this.atamper.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 1009;
				}
				if (num == 921)
				{
					this.hstr.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 922;
				}
				if (num == 564)
				{
					this.sconfusion.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 565;
				}
				if (num == 1470)
				{
					this.BrowseSNK.BorderThickness = 1;
					num = 1471;
				}
				if (num == 111)
				{
					this.siticonePanel7.SuspendLayout();
					num = 112;
				}
				if (num == 615)
				{
					this.cconfusion.Location = new global::System.Drawing.Point(162, 127);
					num = 616;
				}
				if (num == 166)
				{
					this.pmobf.Text = " Proxy Meth";
					num = 167;
				}
				if (num == 480)
				{
					this.mstrip.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 481;
				}
				if (num == 67)
				{
					this.siticonePanel3 = new global::ns1.SiticonePanel();
					num = 68;
				}
				if (num == 1337)
				{
					this.cflowTrackBar.ThumbColor = global::System.Drawing.Color.IndianRed;
					num = 1338;
				}
				if (num == 383)
				{
					this.signer.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 384;
				}
				if (num == 1453)
				{
					this.siticonePanel8.Name = "siticonePanel8";
					num = 1454;
				}
				if (num == 611)
				{
					this.cconfusion.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 612;
				}
				if (num == 1377)
				{
					this.renamer.CheckedFillColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
					num = 1378;
				}
				if (num == 268)
				{
					this.siticoneSeparator3.FillThickness = 2;
					num = 269;
				}
				if (num == 695)
				{
					this.pobf.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 696;
				}
				if (num == 1388)
				{
					this.renamer.TabIndex = 36;
					num = 1389;
				}
				if (num == 1243)
				{
					this.ChineseType.Name = "ChineseType";
					num = 1244;
				}
				if (num == 1483)
				{
					this.BrowseSNK.TabIndex = 3;
					num = 1484;
				}
				if (num == 868)
				{
					this.movelbl.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 869;
				}
				if (num == 1238)
				{
					this.ChineseType.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1239;
				}
				if (num == 635)
				{
					this.adebug.CheckedState.BorderRadius = 2;
					num = 636;
				}
				if (num == 194)
				{
					this.obfuscate.BorderThickness = 1;
					num = 195;
				}
				if (num == 234)
				{
					this.siticoneLabel5.Text = "Protections";
					num = 235;
				}
				if (num == 969)
				{
					this.adump.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 970;
				}
				if (num == 172)
				{
					this.pmobf.UseVisualStyleBackColor = true;
					num = 173;
				}
				if (num == 1543)
				{
					this.siticonePanel5.ResumeLayout(false);
					num = 1544;
				}
				if (num == 713)
				{
					this.movepnl.Controls.Add(this.siticoneLabel8);
					num = 714;
				}
				if (num == 36)
				{
					this.log = new global::System.Windows.Forms.ListBox();
					num = 37;
				}
				if (num == 380)
				{
					this.signer.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 381;
				}
				if (num == 1492)
				{
					this.SNKText.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
					num = 1493;
				}
				if (num == 427)
				{
					this.mutation.TabIndex = 17;
					num = 428;
				}
				if (num == 28)
				{
					this.ajunk = new global::ns1.SiticoneCheckBox();
					num = 29;
				}
				if (num == 1500)
				{
					this.SNKText.HoveredState.BorderColor = global::System.Drawing.Color.LightCoral;
					num = 1501;
				}
				if (num == 1421)
				{
					this.siticonePanel7.Name = "siticonePanel7";
					num = 1422;
				}
				if (num == 604)
				{
					this.siticoneSeparator8.Name = "siticoneSeparator8";
					num = 605;
				}
				if (num == 1172)
				{
					this.RenamerOFF.ReadOnly = false;
					num = 1173;
				}
				if (num == 1473)
				{
					this.BrowseSNK.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 1474;
				}
				if (num == 1360)
				{
					this.renamer2.HoverBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1361;
				}
				if (num == 180)
				{
					this.hnamespaces.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 181;
				}
				if (num == 1030)
				{
					this.apacker.TabIndex = 30;
					num = 1031;
				}
				if (num == 249)
				{
					this.siticoneLabel4.Size = new global::System.Drawing.Size(59, 17);
					num = 250;
				}
				if (num == 1054)
				{
					this.siticonePanel2.Controls.Add(this.renamer2);
					num = 1055;
				}
				if (num == 1549)
				{
					this.movepnl.ResumeLayout(false);
					num = 1550;
				}
				if (num == 80)
				{
					this.SymbolsType = new global::ns1.SiticoneMaterialRadioButton();
					num = 81;
				}
				if (num == 1050)
				{
					this.siticonePanel2.Controls.Add(this.cflowStatus);
					num = 1051;
				}
				if (num == 191)
				{
					this.hnamespaces.UseVisualStyleBackColor = true;
					num = 192;
				}
				if (num == 920)
				{
					this.hstr.CheckedState.BorderThickness = 0;
					num = 921;
				}
				if (num == 82)
				{
					this.NumbersType = new global::ns1.SiticoneMaterialRadioButton();
					num = 83;
				}
				if (num == 802)
				{
					this.min.Name = "min";
					num = 803;
				}
				if (num == 630)
				{
					this.siticoneSeparator7.Name = "siticoneSeparator7";
					num = 631;
				}
				if (num == 157)
				{
					this.pmobf.CheckedState.BorderThickness = 0;
					num = 158;
				}
				if (num == 1270)
				{
					this.NumbersType.TextLeftAlign = 0;
					num = 1271;
				}
				if (num == 614)
				{
					this.cconfusion.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 615;
				}
				if (num == 1099)
				{
					this.alllength.HoveredState.Parent = this.alllength;
					num = 1100;
				}
				if (num == 986)
				{
					this.aildasm.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 987;
				}
				if (num == 881)
				{
					this.virt.CheckedState.BorderThickness = 0;
					num = 882;
				}
				if (num == 690)
				{
					this.siticoneLabel6.UseGdiPlusTextRendering = true;
					num = 691;
				}
				if (num == 410)
				{
					this.siticoneLabel7.Location = new global::System.Drawing.Point(111, 1);
					num = 411;
				}
				if (num == 1548)
				{
					this.siticonePanel9.PerformLayout();
					num = 1549;
				}
				if (num == 198)
				{
					this.obfuscate.Font = new global::System.Drawing.Font("Corbel", 11f, global::System.Drawing.FontStyle.Bold);
					num = 199;
				}
				if (num == 27)
				{
					this.invalidmd = new global::ns1.SiticoneCheckBox();
					num = 28;
				}
				if (num == 271)
				{
					this.siticoneSeparator3.Size = new global::System.Drawing.Size(30, 10);
					num = 272;
				}
				if (num == 534)
				{
					this.omethods.CheckedState.BorderRadius = 2;
					num = 535;
				}
				if (num == 987)
				{
					this.aildasm.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 988;
				}
				if (num == 1279)
				{
					this.AsciiType.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
					num = 1280;
				}
				if (num == 1476)
				{
					this.BrowseSNK.HoveredState.Parent = this.BrowseSNK;
					num = 1477;
				}
				if (num == 1280)
				{
					this.AsciiType.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1281;
				}
				if (num == 1055)
				{
					this.siticonePanel2.Controls.Add(this.pint);
					num = 1056;
				}
				if (num == 869)
				{
					this.movelbl.IsContextMenuEnabled = false;
					num = 870;
				}
				if (num == 1066)
				{
					this.siticonePanel2.Controls.Add(this.hmethods);
					num = 1067;
				}
				if (num == 382)
				{
					this.signer.CheckedState.BorderThickness = 0;
					num = 383;
				}
				if (num == 1230)
				{
					this.ChineseType.BackColor = global::System.Drawing.Color.Transparent;
					num = 1231;
				}
				if (num == 1540)
				{
					this.siticonePanel6.PerformLayout();
					num = 1541;
				}
				if (num == 661)
				{
					this.cflow.Name = "cflow";
					num = 662;
				}
				if (num == 737)
				{
					this.siticoneLabel16.Name = "siticoneLabel16";
					num = 738;
				}
				if (num == 1208)
				{
					this.siticonePanel1.TabIndex = 39;
					num = 1209;
				}
				if (num == 504)
				{
					this.hmethods.TabIndex = 13;
					num = 505;
				}
				if (num == 727)
				{
					this.movepnl.ShadowDecoration.Parent = this.movepnl;
					num = 728;
				}
				if (num == 177)
				{
					this.hnamespaces.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 178;
				}
				if (num == 1110)
				{
					this.alllength.ValueChanged += new global::System.EventHandler(this.alllength_ValueChanged);
					num = 1111;
				}
				if (num == 258)
				{
					this.siticonePanel4.ShadowDecoration.Parent = this.siticonePanel4;
					num = 259;
				}
				if (num == 877)
				{
					this.movelbl.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.movelbl_MouseDown);
					num = 878;
				}
				if (num == 666)
				{
					this.cflow.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 667;
				}
				if (num == 654)
				{
					this.cflow.CheckedState.BorderRadius = 2;
					num = 655;
				}
				if (num == 211)
				{
					this.siticonePanel6.Controls.Add(this.siticoneSeparator5);
					num = 212;
				}
				if (num == 1180)
				{
					this.siticoneLabel11.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1181;
				}
				if (num == 344)
				{
					this.packer.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 345;
				}
				if (num == 1508)
				{
					this.SNKText.ShadowDecoration.Parent = this.SNKText;
					num = 1509;
				}
				if (num == 116)
				{
					this.pint.AutoSize = true;
					num = 117;
				}
				if (num == 186)
				{
					this.hnamespaces.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 187;
				}
				if (num == 1283)
				{
					this.AsciiType.HoverTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1284;
				}
				if (num == 1071)
				{
					this.siticonePanel2.Controls.Add(this.adebug);
					num = 1072;
				}
				if (num == 864)
				{
					this.movelbl2.UseGdiPlusTextRendering = true;
					num = 865;
				}
				if (num == 549)
				{
					this.omethods.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 550;
				}
				if (num == 1039)
				{
					this.siticonePanel2.Controls.Add(this.siticoneLabel19);
					num = 1040;
				}
				if (num == 574)
				{
					this.siticonePanel11.Name = "siticonePanel11";
					num = 575;
				}
				if (num == 243)
				{
					this.siticoneLabel4.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 244;
				}
				if (num == 847)
				{
					this.discord.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 848;
				}
				if (num == 815)
				{
					this.exit.PressedState.Parent = this.exit;
					num = 816;
				}
				if (num == 809)
				{
					this.exit.HoveredState.ImageSize = new global::System.Drawing.Size(22, 22);
					num = 810;
				}
				if (num == 502)
				{
					this.hmethods.Name = "hmethods";
					num = 503;
				}
				if (num == 1347)
				{
					this.siticoneLabel10.Size = new global::System.Drawing.Size(75, 17);
					num = 1348;
				}
				if (num == 303)
				{
					this.assemblytext.ShortcutsEnabled = false;
					num = 304;
				}
				if (num == 873)
				{
					this.movelbl.Size = new global::System.Drawing.Size(45, 17);
					num = 874;
				}
				if (num == 419)
				{
					this.mutation.CheckedState.BorderThickness = 0;
					num = 420;
				}
				if (num == 994)
				{
					this.atamper.CheckedState.BorderRadius = 2;
					num = 995;
				}
				if (num == 521)
				{
					this.fobf.Location = new global::System.Drawing.Point(162, 284);
					num = 522;
				}
				if (num == 516)
				{
					this.fobf.CheckedState.BorderThickness = 0;
					num = 517;
				}
				if (num == 1000)
				{
					this.atamper.Name = "atamper";
					num = 1001;
				}
				if (num == 19)
				{
					this.browse = new global::ns1.SiticoneButton();
					num = 20;
				}
				if (num == 566)
				{
					this.sconfusion.UncheckedState.BorderRadius = 1;
					num = 567;
				}
				if (num == 1479)
				{
					this.BrowseSNK.Location = new global::System.Drawing.Point(18, 49);
					num = 1480;
				}
				if (num == 165)
				{
					this.pmobf.TabIndex = 27;
					num = 166;
				}
				if (num == 1523)
				{
					base.Controls.Add(this.siticonePanel11);
					num = 1524;
				}
				if (num == 653)
				{
					this.cflow.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 654;
				}
				if (num == 618)
				{
					this.cconfusion.TabIndex = 9;
					num = 619;
				}
				if (num == 966)
				{
					this.adump.TabIndex = 2;
					num = 967;
				}
				if (num == 471)
				{
					this.ajunk.UncheckedState.BorderThickness = 1;
					num = 472;
				}
				if (num == 560)
				{
					this.sconfusion.Name = "sconfusion";
					num = 561;
				}
				if (num == 253)
				{
					this.siticonePanel4.Controls.Add(this.siticoneSeparator4);
					num = 254;
				}
				if (num == 1015)
				{
					this.siticonePanel3.Name = "siticonePanel3";
					num = 1016;
				}
				if (num == 952)
				{
					this.ade4dot.UncheckedState.BorderThickness = 1;
					num = 953;
				}
				if (num == 972)
				{
					this.adump.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 973;
				}
				if (num == 285)
				{
					this.assemblytext.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
					num = 286;
				}
				if (num == 865)
				{
					this.movelbl2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.movelbl2_MouseDown);
					num = 866;
				}
				if (num == 1420)
				{
					this.siticonePanel7.Location = new global::System.Drawing.Point(509, 161);
					num = 1421;
				}
				if (num == 22)
				{
					this.arith = new global::ns1.SiticoneCheckBox();
					num = 23;
				}
				if (num == 701)
				{
					this.pobf.Size = new global::System.Drawing.Size(63, 21);
					num = 702;
				}
				if (num == 483)
				{
					this.mstrip.Name = "mstrip";
					num = 484;
				}
				if (num == 1159)
				{
					this.RenamerOFF.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1160;
				}
				if (num == 361)
				{
					this.arith.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 362;
				}
				if (num == 350)
				{
					this.packer.Size = new global::System.Drawing.Size(277, 21);
					num = 351;
				}
				if (num == 1016)
				{
					this.siticonePanel3.ShadowDecoration.Parent = this.siticonePanel3;
					num = 1017;
				}
				if (num == 1222)
				{
					this.SymbolsType.Name = "SymbolsType";
					num = 1223;
				}
				if (num == 599)
				{
					this.siticonePanel10.Size = new global::System.Drawing.Size(280, 160);
					num = 600;
				}
				if (num == 464)
				{
					this.ajunk.Name = "ajunk";
					num = 465;
				}
				if (num == 95)
				{
					this.siticoneLabel15 = new global::ns1.SiticoneLabel();
					num = 96;
				}
				if (num == 844)
				{
					this.discord.HoveredState.ImageSize = new global::System.Drawing.Size(22, 22);
					num = 845;
				}
				if (num == 266)
				{
					this.siticoneSeparator4.TabIndex = 22;
					num = 267;
				}
				if (num == 1041)
				{
					this.siticonePanel2.Controls.Add(this.siticoneLabel18);
					num = 1042;
				}
				if (num == 495)
				{
					this.hmethods.CheckedState.BorderRadius = 2;
					num = 496;
				}
				if (num == 1463)
				{
					this.siticoneLabel3.Name = "siticoneLabel3";
					num = 1464;
				}
				if (num == 221)
				{
					this.siticoneSeparator5.Location = new global::System.Drawing.Point(186, 7);
					num = 222;
				}
				if (num == 286)
				{
					this.assemblytext.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
					num = 287;
				}
				if (num == 675)
				{
					this.siticonePanel9.Location = new global::System.Drawing.Point(8, 392);
					num = 676;
				}
				if (num == 441)
				{
					this.invalidmd.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 442;
				}
				if (num == 1441)
				{
					this.siticoneLabel15.UseGdiPlusTextRendering = true;
					num = 1442;
				}
				if (num == 414)
				{
					this.siticoneLabel7.Text = "Log Box";
					num = 415;
				}
				if (num == 85)
				{
					this.cflowStatus = new global::ns1.SiticoneLabel();
					num = 86;
				}
				if (num == 913)
				{
					this.asciisenc.UncheckedState.BorderRadius = 1;
					num = 914;
				}
				if (num == 396)
				{
					this.signer.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 397;
				}
				if (num == 468)
				{
					this.ajunk.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 469;
				}
				if (num == 1477)
				{
					this.BrowseSNK.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BrowseSNK.Image");
					num = 1478;
				}
				if (num == 1219)
				{
					this.SymbolsType.HoverFillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
					num = 1220;
				}
				if (num == 691)
				{
					this.pobf.AutoSize = true;
					num = 692;
				}
				if (num == 608)
				{
					this.cconfusion.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 609;
				}
				if (num == 248)
				{
					this.siticoneLabel4.Name = "siticoneLabel4";
					num = 249;
				}
				if (num == 587)
				{
					this.log.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 588;
				}
				if (num == 1235)
				{
					this.ChineseType.CheckedFillColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
					num = 1236;
				}
				if (num == 1415)
				{
					this.uncheckall.Visible = false;
					num = 1416;
				}
				if (num == 1225)
				{
					this.SymbolsType.TabIndex = 44;
					num = 1226;
				}
				if (num == 1329)
				{
					this.cflowTrackBar.LargeChange = 1;
					num = 1330;
				}
				if (num == 110)
				{
					this.siticonePanel1.SuspendLayout();
					num = 111;
				}
				if (num == 1164)
				{
					this.RenamerOFF.CheckedTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1165;
				}
				if (num == 600)
				{
					this.siticonePanel10.TabIndex = 40;
					num = 601;
				}
				if (num == 29)
				{
					this.mstrip = new global::ns1.SiticoneCheckBox();
					num = 30;
				}
				if (num == 794)
				{
					this.donation.Click += new global::System.EventHandler(this.donation_Click);
					num = 795;
				}
				if (num == 179)
				{
					this.hnamespaces.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 180;
				}
				if (num == 1462)
				{
					this.siticoneLabel3.Location = new global::System.Drawing.Point(26, 110);
					num = 1463;
				}
				if (num == 63)
				{
					this.ade4dot = new global::ns1.SiticoneCheckBox();
					num = 64;
				}
				if (num == 326)
				{
					this.browse.Text = "Browse";
					num = 327;
				}
				if (num == 932)
				{
					this.hstr.UncheckedState.BorderRadius = 1;
					num = 933;
				}
				if (num == 1145)
				{
					this.BaseSenc.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1146;
				}
				if (num == 1401)
				{
					this.checkall.Size = new global::System.Drawing.Size(25, 24);
					num = 1402;
				}
				if (num == 362)
				{
					this.arith.CheckedState.BorderRadius = 2;
					num = 363;
				}
				if (num == 275)
				{
					this.siticonePanel5.Controls.Add(this.browse);
					num = 276;
				}
				if (num == 370)
				{
					this.arith.Size = new global::System.Drawing.Size(163, 21);
					num = 371;
				}
				if (num == 336)
				{
					this.siticoneLabel1.Size = new global::System.Drawing.Size(55, 17);
					num = 337;
				}
				if (num == 619)
				{
					this.cconfusion.Text = " Calli Confusion";
					num = 620;
				}
				if (num == 1306)
				{
					this.cflowStatus.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1307;
				}
				if (num == 1011)
				{
					this.siticonePanel3.Controls.Add(this.apacker);
					num = 1012;
				}
				if (num == 1057)
				{
					this.siticonePanel2.Controls.Add(this.renamer);
					num = 1058;
				}
				if (num == 169)
				{
					this.pmobf.UncheckedState.BorderRadius = 1;
					num = 170;
				}
				if (num == 134)
				{
					this.pint.UseVisualStyleBackColor = true;
					num = 135;
				}
				if (num == 115)
				{
					this.siticoneElipse1.TargetControl = this;
					num = 116;
				}
				if (num == 649)
				{
					this.adebug.UncheckedState.BorderThickness = 1;
					num = 650;
				}
				if (num == 240)
				{
					this.siticoneSeparator6.Size = new global::System.Drawing.Size(30, 10);
					num = 241;
				}
				if (num == 797)
				{
					this.min.HoveredState.ImageSize = new global::System.Drawing.Size(22, 22);
					num = 798;
				}
				if (num == 205)
				{
					this.obfuscate.ShadowDecoration.Parent = this.obfuscate;
					num = 206;
				}
				if (num == 1282)
				{
					this.AsciiType.HoverFillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
					num = 1283;
				}
				if (num == 199)
				{
					this.obfuscate.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 200;
				}
				if (num == 30)
				{
					this.hmethods = new global::ns1.SiticoneCheckBox();
					num = 31;
				}
				if (num == 12)
				{
					this.siticoneSeparator6 = new global::ns1.SiticoneSeparator();
					num = 13;
				}
				if (num == 311)
				{
					this.browse.BorderRadius = 2;
					num = 312;
				}
				if (num == 69)
				{
					this.siticonePanel2 = new global::ns1.SiticonePanel();
					num = 70;
				}
				if (num == 446)
				{
					this.invalidmd.TabIndex = 14;
					num = 447;
				}
				if (num == 372)
				{
					this.arith.Text = " Arithmetic Obfuscation";
					num = 373;
				}
				if (num == 973)
				{
					this.adump.UseVisualStyleBackColor = true;
					num = 974;
				}
				if (num == 579)
				{
					this.siticoneSeparator10.FillThickness = 2;
					num = 580;
				}
				if (num == 1514)
				{
					this.SNKText.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.SNKText_DragDrop);
					num = 1515;
				}
				if (num == 428)
				{
					this.mutation.Text = " Mutation";
					num = 429;
				}
				if (num == 1046)
				{
					this.siticonePanel2.Controls.Add(this.siticoneLabel11);
					num = 1047;
				}
				if (num == 145)
				{
					this.cryptosenc.Size = new global::System.Drawing.Size(70, 21);
					num = 146;
				}
				if (num == 1133)
				{
					this.siticoneLabel17.Name = "siticoneLabel17";
					num = 1134;
				}
				if (num == 1177)
				{
					this.RenamerOFF.TextLeftAlign = 0;
					num = 1178;
				}
				if (num == 506)
				{
					this.hmethods.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 507;
				}
				if (num == 327)
				{
					this.browse.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.AntiAlias;
					num = 328;
				}
				if (num == 1166)
				{
					this.RenamerOFF.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1167;
				}
				if (num == 804)
				{
					this.min.Size = new global::System.Drawing.Size(24, 24);
					num = 805;
				}
				if (num == 996)
				{
					this.atamper.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 997;
				}
				if (num == 1026)
				{
					this.apacker.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1027;
				}
				if (num == 1198)
				{
					this.siticoneLabel12.Text = "Proxy Obfuscation";
					num = 1199;
				}
				if (num == 949)
				{
					this.ade4dot.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 950;
				}
				if (num == 364)
				{
					this.arith.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 365;
				}
				if (num == 655)
				{
					this.cflow.CheckedState.BorderThickness = 0;
					num = 656;
				}
				if (num == 758)
				{
					this.siticoneLabel8.IsContextMenuEnabled = false;
					num = 759;
				}
				if (num == 75)
				{
					this.BaseSenc = new global::ns1.SiticoneCheckBox();
					num = 76;
				}
				if (num == 1482)
				{
					this.BrowseSNK.Size = new global::System.Drawing.Size(244, 30);
					num = 1483;
				}
				if (num == 836)
				{
					this.facebook.Location = new global::System.Drawing.Point(561, 8);
					num = 837;
				}
				if (num == 1247)
				{
					this.ChineseType.Text = "Chinese";
					num = 1248;
				}
				if (num == 1439)
				{
					this.siticoneLabel15.TabIndex = 23;
					num = 1440;
				}
				if (num == 1422)
				{
					this.siticonePanel7.ShadowDecoration.Parent = this.siticonePanel7;
					num = 1423;
				}
				if (num == 905)
				{
					this.asciisenc.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 906;
				}
				if (num == 1109)
				{
					this.alllength.Value = 5;
					num = 1110;
				}
				if (num == 750)
				{
					this.siticoneLabel9.Size = new global::System.Drawing.Size(70, 17);
					num = 751;
				}
				if (num == 1262)
				{
					this.NumbersType.HoverTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1263;
				}
				if (num == 500)
				{
					this.hmethods.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 501;
				}
				if (num == 1147)
				{
					this.BaseSenc.Name = "BaseSenc";
					num = 1148;
				}
				if (num == 20)
				{
					this.siticoneLabel1 = new global::ns1.SiticoneLabel();
					num = 21;
				}
				if (num == 1085)
				{
					this.siticonePanel2.Size = new global::System.Drawing.Size(502, 323);
					num = 1086;
				}
				if (num == 101)
				{
					this.siticonePanel6.SuspendLayout();
					num = 102;
				}
				if (num == 1489)
				{
					this.SNKText.Cursor = global::System.Windows.Forms.Cursors.IBeam;
					num = 1490;
				}
				if (num == 1417)
				{
					this.siticonePanel7.Controls.Add(this.siticoneSeparator2);
					num = 1418;
				}
				if (num == 1034)
				{
					this.apacker.UncheckedState.BorderRadius = 1;
					num = 1035;
				}
				if (num == 1004)
				{
					this.atamper.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 1005;
				}
				if (num == 254)
				{
					this.siticonePanel4.Controls.Add(this.siticoneLabel4);
					num = 255;
				}
				if (num == 1302)
				{
					this.siticoneLabel13.Text = "Strings Encryption";
					num = 1303;
				}
				if (num == 257)
				{
					this.siticonePanel4.Name = "siticonePanel4";
					num = 258;
				}
				if (num == 1278)
				{
					this.AsciiType.CheckedTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1279;
				}
				if (num == 572)
				{
					this.siticonePanel11.Controls.Add(this.siticoneSeparator10);
					num = 573;
				}
				if (num == 235)
				{
					this.siticoneLabel5.UseGdiPlusTextRendering = true;
					num = 236;
				}
				if (num == 97)
				{
					this.siticonePanel8 = new global::ns1.SiticonePanel();
					num = 98;
				}
				if (num == 1413)
				{
					this.uncheckall.Size = new global::System.Drawing.Size(25, 24);
					num = 1414;
				}
				if (num == 1335)
				{
					this.cflowTrackBar.Size = new global::System.Drawing.Size(82, 23);
					num = 1336;
				}
				if (num == 1320)
				{
					this.siticoneLabel14.Location = new global::System.Drawing.Point(310, 201);
					num = 1321;
				}
				if (num == 636)
				{
					this.adebug.CheckedState.BorderThickness = 0;
					num = 637;
				}
				if (num == 1092)
				{
					this.siticoneLabel19.Location = new global::System.Drawing.Point(439, 278);
					num = 1093;
				}
				if (num == 981)
				{
					this.aildasm.Location = new global::System.Drawing.Point(15, 34);
					num = 982;
				}
				if (num == 214)
				{
					this.siticonePanel6.Location = new global::System.Drawing.Point(8, 49);
					num = 215;
				}
				if (num == 568)
				{
					this.sconfusion.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 569;
				}
				if (num == 100)
				{
					this.SNKText = new global::ns1.SiticoneTextBox();
					num = 101;
				}
				if (num == 1507)
				{
					this.SNKText.SelectedText = "";
					num = 1508;
				}
				if (num == 1120)
				{
					this.siticoneLabel18.Text = "Length :";
					num = 1121;
				}
				if (num == 405)
				{
					this.siticoneLabel7.BackColor = global::System.Drawing.Color.Transparent;
					num = 406;
				}
				if (num == 476)
				{
					this.mstrip.CheckedState.BorderRadius = 2;
					num = 477;
				}
				if (num == 431)
				{
					this.mutation.UncheckedState.BorderRadius = 1;
					num = 432;
				}
				if (num == 1314)
				{
					this.cflowStatus.UseGdiPlusTextRendering = true;
					num = 1315;
				}
				if (num == 316)
				{
					this.browse.Font = new global::System.Drawing.Font("Corbel", 11f, global::System.Drawing.FontStyle.Bold);
					num = 317;
				}
				if (num == 747)
				{
					this.siticoneLabel9.IsSelectionEnabled = false;
					num = 748;
				}
				if (num == 510)
				{
					this.hmethods.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 511;
				}
				if (num == 759)
				{
					this.siticoneLabel8.IsSelectionEnabled = false;
					num = 760;
				}
				if (num == 1449)
				{
					this.siticonePanel8.Controls.Add(this.BrowseSNK);
					num = 1450;
				}
				if (num == 298)
				{
					this.assemblytext.PasswordChar = '\0';
					num = 299;
				}
				if (num == 1469)
				{
					this.BrowseSNK.BorderRadius = 2;
					num = 1470;
				}
				if (num == 643)
				{
					this.adebug.Size = new global::System.Drawing.Size(96, 21);
					num = 644;
				}
				if (num == 378)
				{
					this.arith.UseVisualStyleBackColor = true;
					num = 379;
				}
				if (num == 1378)
				{
					this.renamer.CheckedTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1379;
				}
				if (num == 711)
				{
					this.movepnl.Controls.Add(this.siticoneLabel16);
					num = 712;
				}
				if (num == 1294)
				{
					this.siticoneLabel13.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1295;
				}
				if (num == 682)
				{
					this.siticoneLabel6.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 683;
				}
				if (num == 557)
				{
					this.sconfusion.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 558;
				}
				if (num == 1272)
				{
					this.AsciiType.BackColor = global::System.Drawing.Color.Transparent;
					num = 1273;
				}
				if (num == 1383)
				{
					this.renamer.HoverTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1384;
				}
				if (num == 1429)
				{
					this.siticoneSeparator2.Size = new global::System.Drawing.Size(20, 10);
					num = 1430;
				}
				if (num == 1183)
				{
					this.siticoneLabel11.Location = new global::System.Drawing.Point(162, 174);
					num = 1184;
				}
				if (num == 1106)
				{
					this.alllength.Size = new global::System.Drawing.Size(67, 23);
					num = 1107;
				}
				if (num == 595)
				{
					this.siticonePanel10.Controls.Add(this.log);
					num = 596;
				}
				if (num == 356)
				{
					this.packer.UncheckedState.BorderThickness = 1;
					num = 357;
				}
				if (num == 1190)
				{
					this.siticoneLabel12.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 1191;
				}
				if (num == 528)
				{
					this.fobf.UncheckedState.BorderRadius = 1;
					num = 529;
				}
				if (num == 739)
				{
					this.siticoneLabel16.TabIndex = 18;
					num = 740;
				}
				if (num == 1488)
				{
					this.SNKText.BorderRadius = 2;
					num = 1489;
				}
				if (num == 290)
				{
					this.assemblytext.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 291;
				}
				if (num == 511)
				{
					this.hmethods.UseVisualStyleBackColor = true;
					num = 512;
				}
				if (num == 203)
				{
					this.obfuscate.Location = new global::System.Drawing.Point(131, 46);
					num = 204;
				}
				if (num == 731)
				{
					this.siticoneLabel16.BackColor = global::System.Drawing.Color.Transparent;
					num = 732;
				}
				if (num == 242)
				{
					this.siticoneLabel4.BackColor = global::System.Drawing.Color.Transparent;
					num = 243;
				}
				if (num == 1114)
				{
					this.siticoneLabel18.IsContextMenuEnabled = false;
					num = 1115;
				}
				if (num == 723)
				{
					this.movepnl.Controls.Add(this.movelbl);
					num = 724;
				}
				if (num == 1330)
				{
					this.cflowTrackBar.Location = new global::System.Drawing.Point(15, 270);
					num = 1331;
				}
				if (num == 519)
				{
					this.fobf.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 520;
				}
				if (num == 1117)
				{
					this.siticoneLabel18.Name = "siticoneLabel18";
					num = 1118;
				}
				if (num == 1098)
				{
					this.alllength.FillColor = global::System.Drawing.Color.FromArgb(193, 200, 207);
					num = 1099;
				}
				if (num == 917)
				{
					this.hstr.AutoSize = true;
					num = 918;
				}
				if (num == 885)
				{
					this.virt.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 886;
				}
				if (num == 872)
				{
					this.movelbl.Name = "movelbl";
					num = 873;
				}
				if (num == 1349)
				{
					this.siticoneLabel10.Text = "Control Flow";
					num = 1350;
				}
				if (num == 1412)
				{
					this.uncheckall.PressedState.Parent = this.uncheckall;
					num = 1413;
				}
				if (num == 710)
				{
					this.movepnl.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 711;
				}
				if (num == 718)
				{
					this.movepnl.Controls.Add(this.exit);
					num = 719;
				}
				if (num == 890)
				{
					this.virt.Text = " Virtualizer [ Available in private version ]";
					num = 891;
				}
				if (num == 1038)
				{
					this.apacker.CheckedChanged += new global::System.EventHandler(this.apacker_CheckedChanged);
					num = 1039;
				}
				if (num == 1384)
				{
					this.renamer.Location = new global::System.Drawing.Point(310, 151);
					num = 1385;
				}
				if (num == 578)
				{
					this.siticoneSeparator10.FillColor = global::System.Drawing.Color.IndianRed;
					num = 579;
				}
				if (num == 971)
				{
					this.adump.UncheckedState.BorderThickness = 1;
					num = 972;
				}
				if (num == 1397)
				{
					this.checkall.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 1398;
				}
				if (num == 593)
				{
					this.log.Size = new global::System.Drawing.Size(265, 140);
					num = 594;
				}
				if (num == 1333)
				{
					this.cflowTrackBar.MouseWheelBarPartitions = 5;
					num = 1334;
				}
				if (num == 1289)
				{
					this.AsciiType.Text = "Ascii";
					num = 1290;
				}
				if (num == 181)
				{
					this.hnamespaces.Location = new global::System.Drawing.Point(310, 103);
					num = 182;
				}
				if (num == 1304)
				{
					this.cflowStatus.BackColor = global::System.Drawing.Color.Transparent;
					num = 1305;
				}
				if (num == 233)
				{
					this.siticoneLabel5.TabIndex = 23;
					num = 234;
				}
				if (num == 133)
				{
					this.pint.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 134;
				}
				if (num == 472)
				{
					this.ajunk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 473;
				}
				if (num == 302)
				{
					this.assemblytext.ShadowDecoration.Parent = this.assemblytext;
					num = 303;
				}
				if (num == 1402)
				{
					this.checkall.TabIndex = 16;
					num = 1403;
				}
				if (num == 907)
				{
					this.asciisenc.Name = "asciisenc";
					num = 908;
				}
				if (num == 517)
				{
					this.fobf.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 518;
				}
				if (num == 74)
				{
					this.siticoneLabel17 = new global::ns1.SiticoneLabel();
					num = 75;
				}
				if (num == 127)
				{
					this.pint.TabIndex = 30;
					num = 128;
				}
				if (num == 1390)
				{
					this.renamer.TextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1391;
				}
				if (num == 628)
				{
					this.siticoneSeparator7.FillThickness = 2;
					num = 629;
				}
				if (num == 650)
				{
					this.adebug.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 651;
				}
				if (num == 1045)
				{
					this.siticonePanel2.Controls.Add(this.RenamerOFF);
					num = 1046;
				}
				if (num == 1115)
				{
					this.siticoneLabel18.IsSelectionEnabled = false;
					num = 1116;
				}
				if (num == 225)
				{
					this.siticoneLabel5.BackColor = global::System.Drawing.Color.Transparent;
					num = 226;
				}
				if (num == 478)
				{
					this.mstrip.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 479;
				}
				if (num == 160)
				{
					this.pmobf.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 161;
				}
				if (num == 712)
				{
					this.movepnl.Controls.Add(this.siticoneLabel9);
					num = 713;
				}
				if (num == 861)
				{
					this.movelbl2.Size = new global::System.Drawing.Size(41, 17);
					num = 862;
				}
				if (num == 39)
				{
					this.cconfusion = new global::ns1.SiticoneCheckBox();
					num = 40;
				}
				if (num == 1437)
				{
					this.siticoneLabel15.Name = "siticoneLabel15";
					num = 1438;
				}
				if (num == 1487)
				{
					this.SNKText.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1488;
				}
				if (num == 1250)
				{
					this.ChineseType.CheckedChanged += new global::System.EventHandler(this.ChineseType_CheckedChanged);
					num = 1251;
				}
				if (num == 1324)
				{
					this.siticoneLabel14.Text = "- Renaming type";
					num = 1325;
				}
				if (num == 1202)
				{
					this.siticonePanel1.Controls.Add(this.NumbersType);
					num = 1203;
				}
				if (num == 673)
				{
					this.siticonePanel9.Controls.Add(this.siticoneLabel6);
					num = 674;
				}
				if (num == 209)
				{
					this.obfuscate.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.AntiAlias;
					num = 210;
				}
				if (num == 400)
				{
					this.siticoneSeparator9.FillThickness = 2;
					num = 401;
				}
				if (num == 670)
				{
					this.cflow.UseVisualStyleBackColor = true;
					num = 671;
				}
				if (num == 15)
				{
					this.siticoneSeparator4 = new global::ns1.SiticoneSeparator();
					num = 16;
				}
				if (num == 1135)
				{
					this.siticoneLabel17.TabIndex = 46;
					num = 1136;
				}
				if (num == 44)
				{
					this.siticoneLabel6 = new global::ns1.SiticoneLabel();
					num = 45;
				}
				if (num == 143)
				{
					this.cryptosenc.Location = new global::System.Drawing.Point(15, 174);
					num = 144;
				}
				if (num == 226)
				{
					this.siticoneLabel5.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 227;
				}
				if (num == 1096)
				{
					this.siticoneLabel19.Text = "5";
					num = 1097;
				}
				if (num == 283)
				{
					this.assemblytext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
					num = 284;
				}
				if (num == 473)
				{
					this.ajunk.UseVisualStyleBackColor = true;
					num = 474;
				}
				if (num == 458)
				{
					this.ajunk.CheckedState.BorderThickness = 0;
					num = 459;
				}
				if (num == 863)
				{
					this.movelbl2.Text = "F R E E";
					num = 864;
				}
				if (num == 1386)
				{
					this.renamer.ReadOnly = false;
					num = 1387;
				}
				if (num == 489)
				{
					this.mstrip.UncheckedState.BorderRadius = 1;
					num = 490;
				}
				if (num == 663)
				{
					this.cflow.TabIndex = 7;
					num = 664;
				}
				if (num == 1399)
				{
					this.checkall.Name = "checkall";
					num = 1400;
				}
				if (num == 250)
				{
					this.siticoneLabel4.TabIndex = 23;
					num = 251;
				}
				if (num == 1536)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
					num = 1537;
				}
				if (num == 465)
				{
					this.ajunk.Size = new global::System.Drawing.Size(84, 21);
					num = 466;
				}
				if (num == 745)
				{
					this.siticoneLabel9.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 746;
				}
				if (num == 924)
				{
					this.hstr.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 925;
				}
				if (num == 832)
				{
					this.facebook.HoveredState.ImageSize = new global::System.Drawing.Size(22, 22);
					num = 833;
				}
				if (num == 1001)
				{
					this.atamper.Size = new global::System.Drawing.Size(129, 21);
					num = 1002;
				}
				if (num == 142)
				{
					this.cryptosenc.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 143;
				}
				if (num == 1451)
				{
					this.siticonePanel8.Controls.Add(this.signer);
					num = 1452;
				}
				if (num == 236)
				{
					this.siticoneSeparator6.FillColor = global::System.Drawing.Color.IndianRed;
					num = 237;
				}
				if (num == 505)
				{
					this.hmethods.Text = " Hide Methods : 32bit Only";
					num = 506;
				}
				if (num == 1223)
				{
					this.SymbolsType.ReadOnly = false;
					num = 1224;
				}
				if (num == 1082)
				{
					this.siticonePanel2.Location = new global::System.Drawing.Point(8, 70);
					num = 1083;
				}
				if (num == 639)
				{
					this.adebug.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 640;
				}
				if (num == 848)
				{
					this.discord.Location = new global::System.Drawing.Point(591, 8);
					num = 849;
				}
				if (num == 1371)
				{
					this.renamer.BackColor = global::System.Drawing.Color.Transparent;
					num = 1372;
				}
				if (num == 546)
				{
					this.omethods.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 547;
				}
				if (num == 716)
				{
					this.movepnl.Controls.Add(this.donation);
					num = 717;
				}
				if (num == 1427)
				{
					this.siticoneSeparator2.Location = new global::System.Drawing.Point(37, 7);
					num = 1428;
				}
				if (num == 859)
				{
					this.movelbl2.Location = new global::System.Drawing.Point(88, 11);
					num = 860;
				}
				if (num == 984)
				{
					this.aildasm.TabIndex = 1;
					num = 985;
				}
				if (num == 929)
				{
					this.hstr.Text = " Hide Strings";
					num = 930;
				}
				if (num == 1560)
				{
					base.ResumeLayout(false);
					num = 1561;
				}
				if (num == 76)
				{
					this.RenamerOFF = new global::ns1.SiticoneMaterialRadioButton();
					num = 77;
				}
				if (num == 1338)
				{
					this.cflowTrackBar.Value = 1;
					num = 1339;
				}
				if (num == 1544)
				{
					this.siticonePanel11.ResumeLayout(false);
					num = 1545;
				}
				if (num == 369)
				{
					this.arith.Name = "arith";
					num = 370;
				}
				if (num == 729)
				{
					this.movepnl.TabIndex = 32;
					num = 730;
				}
				if (num == 908)
				{
					this.asciisenc.Size = new global::System.Drawing.Size(57, 21);
					num = 909;
				}
				if (num == 1025)
				{
					this.apacker.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 1026;
				}
				if (num == 1467)
				{
					this.siticoneLabel3.UseGdiPlusTextRendering = true;
					num = 1468;
				}
				if (num == 558)
				{
					this.sconfusion.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 559;
				}
				if (num == 1368)
				{
					this.renamer2.Text = "Method 2";
					num = 1369;
				}
				if (num == 5)
				{
					this.cryptosenc = new global::ns1.SiticoneCheckBox();
					num = 6;
				}
				if (num == 23)
				{
					this.signer = new global::ns1.SiticoneCheckBox();
					num = 24;
				}
				if (num == 1466)
				{
					this.siticoneLabel3.Text = "[ Assembly may not work after signing ]";
					num = 1467;
				}
				if (num == 919)
				{
					this.hstr.CheckedState.BorderRadius = 2;
					num = 920;
				}
				if (num == 1154)
				{
					this.BaseSenc.UncheckedState.BorderThickness = 1;
					num = 1155;
				}
				if (num == 772)
				{
					this.siticoneLabel2.Location = new global::System.Drawing.Point(136, 11);
					num = 773;
				}
				if (num == 81)
				{
					this.ChineseType = new global::ns1.SiticoneMaterialRadioButton();
					num = 82;
				}
				if (num == 1051)
				{
					this.siticonePanel2.Controls.Add(this.siticoneLabel14);
					num = 1052;
				}
				if (num == 585)
				{
					this.log.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
					num = 586;
				}
				if (num == 667)
				{
					this.cflow.UncheckedState.BorderRadius = 1;
					num = 668;
				}
				if (num == 629)
				{
					this.siticoneSeparator7.Location = new global::System.Drawing.Point(162, 7);
					num = 630;
				}
				if (num == 299)
				{
					this.assemblytext.PlaceholderText = "";
					num = 300;
				}
				if (num == 523)
				{
					this.fobf.Size = new global::System.Drawing.Size(126, 21);
					num = 524;
				}
				if (num == 158)
				{
					this.pmobf.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 159;
				}
				if (num == 1075)
				{
					this.siticonePanel2.Controls.Add(this.hstr);
					num = 1076;
				}
				if (num == 1062)
				{
					this.siticonePanel2.Controls.Add(this.siticoneLabel1);
					num = 1063;
				}
				if (num == 1091)
				{
					this.siticoneLabel19.IsSelectionEnabled = false;
					num = 1092;
				}
				if (num == 138)
				{
					this.cryptosenc.CheckedState.BorderThickness = 0;
					num = 139;
				}
				if (num == 736)
				{
					this.siticoneLabel16.Location = new global::System.Drawing.Point(266, 11);
					num = 737;
				}
				if (num == 816)
				{
					this.exit.Size = new global::System.Drawing.Size(24, 24);
					num = 817;
				}
				if (num == 833)
				{
					this.facebook.HoveredState.Parent = this.facebook;
					num = 834;
				}
				if (num == 72)
				{
					this.siticoneLabel18 = new global::ns1.SiticoneLabel();
					num = 73;
				}
				if (num == 31)
				{
					this.fobf = new global::ns1.SiticoneCheckBox();
					num = 32;
				}
				if (num == 1069)
				{
					this.siticonePanel2.Controls.Add(this.sconfusion);
					num = 1070;
				}
				if (num == 1188)
				{
					this.siticoneLabel11.UseGdiPlusTextRendering = true;
					num = 1189;
				}
				if (num == 135)
				{
					this.cryptosenc.AutoSize = true;
					num = 136;
				}
				if (num == 125)
				{
					this.pint.Name = "pint";
					num = 126;
				}
				if (num == 1033)
				{
					this.apacker.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1034;
				}
				if (num == 337)
				{
					this.siticoneLabel1.TabIndex = 25;
					num = 338;
				}
				if (num == 1301)
				{
					this.siticoneLabel13.TabIndex = 35;
					num = 1302;
				}
				if (num == 1355)
				{
					this.renamer2.CheckedBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1356;
				}
				if (num == 746)
				{
					this.siticoneLabel9.IsContextMenuEnabled = false;
					num = 747;
				}
				if (num == 935)
				{
					this.hstr.UseVisualStyleBackColor = true;
					num = 936;
				}
				if (num == 509)
				{
					this.hmethods.UncheckedState.BorderThickness = 1;
					num = 510;
				}
				if (num == 461)
				{
					this.ajunk.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 462;
				}
				if (num == 1551)
				{
					this.siticonePanel3.ResumeLayout(false);
					num = 1552;
				}
				if (num == 1010)
				{
					this.atamper.CheckedChanged += new global::System.EventHandler(this.atamper_CheckedChanged);
					num = 1011;
				}
				if (num == 1017)
				{
					this.siticonePanel3.Size = new global::System.Drawing.Size(502, 92);
					num = 1018;
				}
				if (num == 329)
				{
					this.siticoneLabel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 330;
				}
				if (num == 1126)
				{
					this.siticoneSeparator1.TabIndex = 25;
					num = 1127;
				}
				if (num == 1331)
				{
					this.cflowTrackBar.Maximum = 5;
					num = 1332;
				}
				if (num == 6)
				{
					this.pmobf = new global::ns1.SiticoneCheckBox();
					num = 7;
				}
				if (num == 1013)
				{
					this.siticonePanel3.Controls.Add(this.packer);
					num = 1014;
				}
				if (num == 835)
				{
					this.facebook.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 836;
				}
				if (num == 1231)
				{
					this.ChineseType.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 1232;
				}
				if (num == 443)
				{
					this.invalidmd.Location = new global::System.Drawing.Point(310, 57);
					num = 444;
				}
				if (num == 732)
				{
					this.siticoneLabel16.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 733;
				}
				if (num == 854)
				{
					this.movelbl2.BackColor = global::System.Drawing.Color.Transparent;
					num = 855;
				}
				if (num == 792)
				{
					this.donation.Size = new global::System.Drawing.Size(24, 24);
					num = 793;
				}
				if (num == 201)
				{
					this.obfuscate.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("obfuscate.Image");
					num = 202;
				}
				if (num == 1093)
				{
					this.siticoneLabel19.Name = "siticoneLabel19";
					num = 1094;
				}
				if (num == 485)
				{
					this.mstrip.TabIndex = 15;
					num = 486;
				}
				if (num == 484)
				{
					this.mstrip.Size = new global::System.Drawing.Size(92, 21);
					num = 485;
				}
				if (num == 1019)
				{
					this.apacker.AutoSize = true;
					num = 1020;
				}
				if (num == 825)
				{
					this.logo.Location = new global::System.Drawing.Point(8, 8);
					num = 826;
				}
				if (num == 567)
				{
					this.sconfusion.UncheckedState.BorderThickness = 1;
					num = 568;
				}
				if (num == 1052)
				{
					this.siticonePanel2.Controls.Add(this.cflowTrackBar);
					num = 1053;
				}
				if (num == 1510)
				{
					this.SNKText.Size = new global::System.Drawing.Size(244, 24);
					num = 1511;
				}
				if (num == 1416)
				{
					this.uncheckall.Click += new global::System.EventHandler(this.uncheckall_Click);
					num = 1417;
				}
				if (num == 272)
				{
					this.siticoneSeparator3.TabIndex = 24;
					num = 273;
				}
				if (num == 766)
				{
					this.siticoneLabel8.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.siticoneLabel8_MouseDown);
					num = 767;
				}
				if (num == 1104)
				{
					this.alllength.MouseWheelBarPartitions = 5;
					num = 1105;
				}
				if (num == 162)
				{
					this.pmobf.Location = new global::System.Drawing.Point(162, 58);
					num = 163;
				}
				if (num == 777)
				{
					this.siticoneLabel2.UseGdiPlusTextRendering = true;
					num = 778;
				}
				if (num == 1059)
				{
					this.siticonePanel2.Controls.Add(this.hnamespaces);
					num = 1060;
				}
				if (num == 1499)
				{
					this.SNKText.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1500;
				}
				if (num == 40)
				{
					this.siticoneSeparator7 = new global::ns1.SiticoneSeparator();
					num = 41;
				}
				if (num == 1350)
				{
					this.siticoneLabel10.UseGdiPlusTextRendering = true;
					num = 1351;
				}
				if (num == 719)
				{
					this.movepnl.Controls.Add(this.logo);
					num = 720;
				}
				if (num == 870)
				{
					this.movelbl.IsSelectionEnabled = false;
					num = 871;
				}
				if (num == 1207)
				{
					this.siticonePanel1.Size = new global::System.Drawing.Size(170, 50);
					num = 1208;
				}
				if (num == 174)
				{
					this.hnamespaces.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 175;
				}
				if (num == 700)
				{
					this.pobf.Name = "pobf";
					num = 701;
				}
				if (num == 704)
				{
					this.pobf.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 705;
				}
				if (num == 1373)
				{
					this.renamer.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
					num = 1374;
				}
				if (num == 37)
				{
					this.siticonePanel10 = new global::ns1.SiticonePanel();
					num = 38;
				}
				if (num == 222)
				{
					this.siticoneSeparator5.Name = "siticoneSeparator5";
					num = 223;
				}
				if (num == 887)
				{
					this.virt.Name = "virt";
					num = 888;
				}
				if (num == 371)
				{
					this.arith.TabIndex = 18;
					num = 372;
				}
				if (num == 918)
				{
					this.hstr.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 919;
				}
				if (num == 264)
				{
					this.siticoneSeparator4.Name = "siticoneSeparator4";
					num = 265;
				}
				if (num == 1554)
				{
					this.siticonePanel2.PerformLayout();
					num = 1555;
				}
				if (num == 989)
				{
					this.aildasm.UncheckedState.BorderThickness = 1;
					num = 990;
				}
				if (num == 1381)
				{
					this.renamer.HoverBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1382;
				}
				if (num == 245)
				{
					this.siticoneLabel4.IsContextMenuEnabled = false;
					num = 246;
				}
				if (num == 105)
				{
					this.siticonePanel10.SuspendLayout();
					num = 106;
				}
				if (num == 488)
				{
					this.mstrip.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 489;
				}
				if (num == 588)
				{
					this.log.FormattingEnabled = true;
					num = 589;
				}
				if (num == 260)
				{
					this.siticonePanel4.TabIndex = 35;
					num = 261;
				}
				if (num == 123)
				{
					this.pint.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 124;
				}
				if (num == 187)
				{
					this.hnamespaces.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 188;
				}
				if (num == 884)
				{
					this.virt.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 885;
				}
				if (num == 14)
				{
					this.siticonePanel4 = new global::ns1.SiticonePanel();
					num = 15;
				}
				if (num == 459)
				{
					this.ajunk.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 460;
				}
				if (num == 231)
				{
					this.siticoneLabel5.Name = "siticoneLabel5";
					num = 232;
				}
				if (num == 339)
				{
					this.siticoneLabel1.UseGdiPlusTextRendering = true;
					num = 340;
				}
				if (num == 292)
				{
					this.assemblytext.FocusedState.Parent = this.assemblytext;
					num = 293;
				}
				if (num == 25)
				{
					this.siticoneLabel7 = new global::ns1.SiticoneLabel();
					num = 26;
				}
				if (num == 898)
				{
					this.asciisenc.AutoSize = true;
					num = 899;
				}
				if (num == 1168)
				{
					this.RenamerOFF.HoverFillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
					num = 1169;
				}
				if (num == 1308)
				{
					this.cflowStatus.IsSelectionEnabled = false;
					num = 1309;
				}
				if (num == 1090)
				{
					this.siticoneLabel19.IsContextMenuEnabled = false;
					num = 1091;
				}
				if (num == 230)
				{
					this.siticoneLabel5.Location = new global::System.Drawing.Point(212, 1);
					num = 231;
				}
				if (num == 720)
				{
					this.movepnl.Controls.Add(this.facebook);
					num = 721;
				}
				if (num == 853)
				{
					this.discord.Click += new global::System.EventHandler(this.discord_Click);
					num = 854;
				}
				if (num == 680)
				{
					this.siticoneLabel6.BackColor = global::System.Drawing.Color.Transparent;
					num = 681;
				}
				if (num == 1535)
				{
					base.Name = "Form1";
					num = 1536;
				}
				if (num == 1322)
				{
					this.siticoneLabel14.Size = new global::System.Drawing.Size(96, 17);
					num = 1323;
				}
				if (num == 17)
				{
					this.siticonePanel5 = new global::ns1.SiticonePanel();
					num = 18;
				}
				if (num == 1007)
				{
					this.atamper.UncheckedState.BorderThickness = 1;
					num = 1008;
				}
				if (num == 1309)
				{
					this.cflowStatus.Location = new global::System.Drawing.Point(15, 294);
					num = 1310;
				}
				if (num == 276)
				{
					this.siticonePanel5.Location = new global::System.Drawing.Point(509, 70);
					num = 277;
				}
				if (num == 436)
				{
					this.invalidmd.CheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 437;
				}
				if (num == 1124)
				{
					this.siticoneSeparator1.Name = "siticoneSeparator1";
					num = 1125;
				}
				if (num == 56)
				{
					this.facebook = new global::ns1.SiticoneImageButton();
					num = 57;
				}
				if (num == 48)
				{
					this.siticoneLabel9 = new global::ns1.SiticoneLabel();
					num = 49;
				}
				if (num == 603)
				{
					this.siticoneSeparator8.Location = new global::System.Drawing.Point(310, 7);
					num = 604;
				}
				if (num == 624)
				{
					this.cconfusion.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 625;
				}
				if (num == 229)
				{
					this.siticoneLabel5.IsSelectionEnabled = false;
					num = 230;
				}
				if (num == 1433)
				{
					this.siticoneLabel15.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1434;
				}
				if (num == 1237)
				{
					this.ChineseType.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
					num = 1238;
				}
				if (num == 355)
				{
					this.packer.UncheckedState.BorderRadius = 1;
					num = 356;
				}
				if (num == 1201)
				{
					this.siticonePanel1.Controls.Add(this.ChineseType);
					num = 1202;
				}
				if (num == 1215)
				{
					this.SymbolsType.CheckedTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1216;
				}
				if (num == 601)
				{
					this.siticoneSeparator8.FillColor = global::System.Drawing.Color.IndianRed;
					num = 602;
				}
				if (num == 789)
				{
					this.donation.Location = new global::System.Drawing.Point(709, 8);
					num = 790;
				}
				if (num == 1196)
				{
					this.siticoneLabel12.Size = new global::System.Drawing.Size(109, 17);
					num = 1197;
				}
				if (num == 800)
				{
					this.min.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 801;
				}
				if (num == 699)
				{
					this.pobf.Location = new global::System.Drawing.Point(162, 35);
					num = 700;
				}
				if (num == 1356)
				{
					this.renamer2.CheckedFillColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
					num = 1357;
				}
				if (num == 457)
				{
					this.ajunk.CheckedState.BorderRadius = 2;
					num = 458;
				}
				if (num == 4)
				{
					this.pint = new global::ns1.SiticoneCheckBox();
					num = 5;
				}
				if (num == 876)
				{
					this.movelbl.UseGdiPlusTextRendering = true;
					num = 877;
				}
				if (num == 262)
				{
					this.siticoneSeparator4.FillThickness = 2;
					num = 263;
				}
				if (num == 1287)
				{
					this.AsciiType.Size = new global::System.Drawing.Size(62, 20);
					num = 1288;
				}
				if (num == 709)
				{
					this.pobf.UseVisualStyleBackColor = true;
					num = 710;
				}
				if (num == 607)
				{
					this.cconfusion.AutoSize = true;
					num = 608;
				}
				if (num == 1474)
				{
					this.BrowseSNK.Font = new global::System.Drawing.Font("Corbel", 11f, global::System.Drawing.FontStyle.Bold);
					num = 1475;
				}
				if (num == 64)
				{
					this.adump = new global::ns1.SiticoneCheckBox();
					num = 65;
				}
				if (num == 195)
				{
					this.obfuscate.CheckedState.Parent = this.obfuscate;
					num = 196;
				}
				if (num == 948)
				{
					this.ade4dot.Text = " Anti De4dot";
					num = 949;
				}
				if (num == 621)
				{
					this.cconfusion.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 622;
				}
				if (num == 1481)
				{
					this.BrowseSNK.ShadowDecoration.Parent = this.BrowseSNK;
					num = 1482;
				}
				if (num == 676)
				{
					this.siticonePanel9.Name = "siticonePanel9";
					num = 677;
				}
				if (num == 1258)
				{
					this.NumbersType.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
					num = 1259;
				}
				if (num == 790)
				{
					this.donation.Name = "donation";
					num = 791;
				}
				if (num == 202)
				{
					this.obfuscate.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 203;
				}
				if (num == 1299)
				{
					this.siticoneLabel13.Name = "siticoneLabel13";
					num = 1300;
				}
				if (num == 627)
				{
					this.siticoneSeparator7.FillColor = global::System.Drawing.Color.IndianRed;
					num = 628;
				}
				if (num == 912)
				{
					this.asciisenc.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 913;
				}
				if (num == 1169)
				{
					this.RenamerOFF.HoverTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1170;
				}
				if (num == 386)
				{
					this.signer.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 387;
				}
				if (num == 68)
				{
					this.apacker = new global::ns1.SiticoneCheckBox();
					num = 69;
				}
				if (num == 1105)
				{
					this.alllength.Name = "alllength";
					num = 1106;
				}
				if (num == 1009)
				{
					this.atamper.UseVisualStyleBackColor = true;
					num = 1010;
				}
				if (num == 632)
				{
					this.siticoneSeparator7.TabIndex = 22;
					num = 633;
				}
				if (num == 41)
				{
					this.adebug = new global::ns1.SiticoneCheckBox();
					num = 42;
				}
				if (num == 7)
				{
					this.hnamespaces = new global::ns1.SiticoneCheckBox();
					num = 8;
				}
				if (num == 132)
				{
					this.pint.UncheckedState.BorderThickness = 1;
					num = 133;
				}
				if (num == 1456)
				{
					this.siticonePanel8.TabIndex = 39;
					num = 1457;
				}
				if (num == 1200)
				{
					this.siticonePanel1.Controls.Add(this.SymbolsType);
					num = 1201;
				}
				if (num == 120)
				{
					this.pint.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 121;
				}
				if (num == 343)
				{
					this.packer.CheckedState.BorderThickness = 0;
					num = 344;
				}
				if (num == 769)
				{
					this.siticoneLabel2.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 770;
				}
				if (num == 616)
				{
					this.cconfusion.Name = "cconfusion";
					num = 617;
				}
				if (num == 1140)
				{
					this.BaseSenc.CheckedState.BorderRadius = 2;
					num = 1141;
				}
				if (num == 273)
				{
					this.siticonePanel5.Controls.Add(this.obfuscate);
					num = 274;
				}
				if (num == 1257)
				{
					this.NumbersType.CheckedTextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1258;
				}
				if (num == 622)
				{
					this.cconfusion.UncheckedState.BorderRadius = 1;
					num = 623;
				}
				if (num == 1176)
				{
					this.RenamerOFF.TextColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1177;
				}
				if (num == 656)
				{
					this.cflow.CheckedState.FillColor = global::System.Drawing.Color.IndianRed;
					num = 657;
				}
				if (num == 51)
				{
					this.siticoneVSeparator1 = new global::ns1.SiticoneVSeparator();
					num = 52;
				}
				if (num == 256)
				{
					this.siticonePanel4.Location = new global::System.Drawing.Point(509, 49);
					num = 257;
				}
				if (num == 888)
				{
					this.virt.Size = new global::System.Drawing.Size(265, 21);
					num = 889;
				}
				if (num == 970)
				{
					this.adump.UncheckedState.BorderRadius = 1;
					num = 971;
				}
				if (num == 1444)
				{
					this.siticoneSeparator11.Location = new global::System.Drawing.Point(214, 7);
					num = 1445;
				}
				if (num == 1391)
				{
					this.renamer.TextLeftAlign = 0;
					num = 1392;
				}
				if (num == 1442)
				{
					this.siticoneSeparator11.FillColor = global::System.Drawing.Color.IndianRed;
					num = 1443;
				}
				if (num == 107)
				{
					this.movepnl.SuspendLayout();
					num = 108;
				}
				if (num == 1527)
				{
					base.Controls.Add(this.siticonePanel9);
					num = 1528;
				}
				if (num == 1315)
				{
					this.siticoneLabel14.BackColor = global::System.Drawing.Color.Transparent;
					num = 1316;
				}
				if (num == 612)
				{
					this.cconfusion.CheckMarkColor = global::System.Drawing.Color.WhiteSmoke;
					num = 613;
				}
				if (num == 387)
				{
					this.signer.Location = new global::System.Drawing.Point(18, 85);
					num = 388;
				}
				if (num == 1292)
				{
					this.AsciiType.CheckedChanged += new global::System.EventHandler(this.AsciiType_CheckedChanged);
					num = 1293;
				}
				if (num == 1430)
				{
					this.siticoneSeparator2.TabIndex = 22;
					num = 1431;
				}
				if (num == 54)
				{
					this.exit = new global::ns1.SiticoneImageButton();
					num = 55;
				}
				if (num == 491)
				{
					this.mstrip.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 492;
				}
				if (num == 1496)
				{
					this.SNKText.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 1497;
				}
				if (num == 812)
				{
					this.exit.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 813;
				}
				if (num == 1475)
				{
					this.BrowseSNK.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1476;
				}
				if (num == 1553)
				{
					this.siticonePanel2.ResumeLayout(false);
					num = 1554;
				}
				if (num == 1459)
				{
					this.siticoneLabel3.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 1460;
				}
				if (num == 1155)
				{
					this.BaseSenc.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 1156;
				}
				if (num == 1406)
				{
					this.uncheckall.HoveredState.ImageSize = new global::System.Drawing.Size(22, 22);
					num = 1407;
				}
				if (num == 1049)
				{
					this.siticonePanel2.Controls.Add(this.siticoneLabel13);
					num = 1050;
				}
				if (num == 1520)
				{
					base.Controls.Add(this.siticonePanel7);
					num = 1521;
				}
				if (num == 349)
				{
					this.packer.Name = "packer";
					num = 350;
				}
				if (num == 1552)
				{
					this.siticonePanel3.PerformLayout();
					num = 1553;
				}
				if (num == 219)
				{
					this.siticoneSeparator5.FillColor = global::System.Drawing.Color.IndianRed;
					num = 220;
				}
				if (num == 1268)
				{
					this.NumbersType.Text = "Numbers";
					num = 1269;
				}
				if (num == 1076)
				{
					this.siticonePanel2.Controls.Add(this.ade4dot);
					num = 1077;
				}
				if (num == 220)
				{
					this.siticoneSeparator5.FillThickness = 2;
					num = 221;
				}
				if (num == 1186)
				{
					this.siticoneLabel11.TabIndex = 41;
					num = 1187;
				}
				if (num == 1232)
				{
					this.ChineseType.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
					num = 1233;
				}
				if (num == 374)
				{
					this.arith.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 375;
				}
				if (num == 672)
				{
					this.siticonePanel9.Controls.Add(this.siticoneSeparator7);
					num = 673;
				}
				if (num == 1276)
				{
					this.AsciiType.CheckedBorderColor = global::System.Drawing.Color.IndianRed;
					num = 1277;
				}
				if (num == 342)
				{
					this.packer.CheckedState.BorderRadius = 2;
					num = 343;
				}
				if (num == 950)
				{
					this.ade4dot.UncheckedState.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 951;
				}
				if (num == 232)
				{
					this.siticoneLabel5.Size = new global::System.Drawing.Size(69, 17);
					num = 233;
				}
				if (num == 644)
				{
					this.adebug.TabIndex = 8;
					num = 645;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1561);
		}

		// Token: 0x0400008A RID: 138
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400008B RID: 139
		private global::ns1.SiticoneElipse siticoneElipse1;

		// Token: 0x0400008C RID: 140
		private global::ns1.SiticonePanel siticonePanel6;

		// Token: 0x0400008D RID: 141
		private global::ns1.SiticoneSeparator siticoneSeparator5;

		// Token: 0x0400008E RID: 142
		private global::ns1.SiticoneLabel siticoneLabel5;

		// Token: 0x0400008F RID: 143
		private global::ns1.SiticoneSeparator siticoneSeparator6;

		// Token: 0x04000090 RID: 144
		private global::ns1.SiticonePanel siticonePanel4;

		// Token: 0x04000091 RID: 145
		private global::ns1.SiticoneSeparator siticoneSeparator4;

		// Token: 0x04000092 RID: 146
		private global::ns1.SiticoneLabel siticoneLabel4;

		// Token: 0x04000093 RID: 147
		private global::ns1.SiticoneSeparator siticoneSeparator3;

		// Token: 0x04000094 RID: 148
		private global::ns1.SiticonePanel siticonePanel5;

		// Token: 0x04000095 RID: 149
		private global::ns1.SiticoneButton obfuscate;

		// Token: 0x04000096 RID: 150
		private global::ns1.SiticoneTextBox assemblytext;

		// Token: 0x04000097 RID: 151
		private global::ns1.SiticoneButton browse;

		// Token: 0x04000098 RID: 152
		private global::ns1.SiticonePanel siticonePanel11;

		// Token: 0x04000099 RID: 153
		private global::ns1.SiticoneSeparator siticoneSeparator9;

		// Token: 0x0400009A RID: 154
		private global::ns1.SiticoneLabel siticoneLabel7;

		// Token: 0x0400009B RID: 155
		private global::ns1.SiticoneSeparator siticoneSeparator10;

		// Token: 0x0400009C RID: 156
		private global::ns1.SiticonePanel siticonePanel10;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.ListBox log;

		// Token: 0x0400009E RID: 158
		private global::ns1.SiticonePanel siticonePanel9;

		// Token: 0x0400009F RID: 159
		private global::ns1.SiticoneSeparator siticoneSeparator7;

		// Token: 0x040000A0 RID: 160
		private global::ns1.SiticoneLabel siticoneLabel6;

		// Token: 0x040000A1 RID: 161
		private global::ns1.SiticoneSeparator siticoneSeparator8;

		// Token: 0x040000A2 RID: 162
		private global::ns1.SiticonePanel movepnl;

		// Token: 0x040000A3 RID: 163
		private global::ns1.SiticoneLabel siticoneLabel2;

		// Token: 0x040000A4 RID: 164
		private global::ns1.SiticoneVSeparator siticoneVSeparator1;

		// Token: 0x040000A5 RID: 165
		private global::ns1.SiticoneImageButton donation;

		// Token: 0x040000A6 RID: 166
		private global::ns1.SiticoneImageButton min;

		// Token: 0x040000A7 RID: 167
		private global::ns1.SiticoneImageButton exit;

		// Token: 0x040000A8 RID: 168
		private global::ns1.SiticoneImageButton logo;

		// Token: 0x040000A9 RID: 169
		private global::ns1.SiticoneImageButton facebook;

		// Token: 0x040000AA RID: 170
		private global::ns1.SiticoneImageButton discord;

		// Token: 0x040000AB RID: 171
		private global::ns1.SiticoneLabel movelbl2;

		// Token: 0x040000AC RID: 172
		private global::ns1.SiticoneLabel movelbl;

		// Token: 0x040000AD RID: 173
		private global::ns1.SiticonePanel siticonePanel3;

		// Token: 0x040000AE RID: 174
		private global::ns1.SiticoneCheckBox signer;

		// Token: 0x040000AF RID: 175
		private global::ns1.SiticoneCheckBox virt;

		// Token: 0x040000B0 RID: 176
		private global::ns1.SiticoneCheckBox packer;

		// Token: 0x040000B1 RID: 177
		private global::ns1.SiticonePanel siticonePanel2;

		// Token: 0x040000B2 RID: 178
		private global::ns1.SiticoneCheckBox pint;

		// Token: 0x040000B3 RID: 179
		private global::ns1.SiticoneLabel siticoneLabel1;

		// Token: 0x040000B4 RID: 180
		private global::ns1.SiticoneCheckBox cryptosenc;

		// Token: 0x040000B5 RID: 181
		private global::ns1.SiticoneCheckBox pmobf;

		// Token: 0x040000B6 RID: 182
		private global::ns1.SiticoneCheckBox hnamespaces;

		// Token: 0x040000B7 RID: 183
		private global::ns1.SiticoneCheckBox arith;

		// Token: 0x040000B8 RID: 184
		private global::ns1.SiticoneCheckBox mutation;

		// Token: 0x040000B9 RID: 185
		private global::ns1.SiticoneCheckBox invalidmd;

		// Token: 0x040000BA RID: 186
		private global::ns1.SiticoneCheckBox ajunk;

		// Token: 0x040000BB RID: 187
		private global::ns1.SiticoneCheckBox mstrip;

		// Token: 0x040000BC RID: 188
		private global::ns1.SiticoneCheckBox hmethods;

		// Token: 0x040000BD RID: 189
		private global::ns1.SiticoneCheckBox fobf;

		// Token: 0x040000BE RID: 190
		private global::ns1.SiticoneCheckBox omethods;

		// Token: 0x040000BF RID: 191
		private global::ns1.SiticoneCheckBox sconfusion;

		// Token: 0x040000C0 RID: 192
		private global::ns1.SiticoneCheckBox cconfusion;

		// Token: 0x040000C1 RID: 193
		private global::ns1.SiticoneCheckBox adebug;

		// Token: 0x040000C2 RID: 194
		private global::ns1.SiticoneCheckBox cflow;

		// Token: 0x040000C3 RID: 195
		private global::ns1.SiticoneCheckBox pobf;

		// Token: 0x040000C4 RID: 196
		private global::ns1.SiticoneCheckBox asciisenc;

		// Token: 0x040000C5 RID: 197
		private global::ns1.SiticoneCheckBox hstr;

		// Token: 0x040000C6 RID: 198
		private global::ns1.SiticoneCheckBox ade4dot;

		// Token: 0x040000C7 RID: 199
		private global::ns1.SiticoneCheckBox adump;

		// Token: 0x040000C8 RID: 200
		private global::ns1.SiticoneCheckBox aildasm;

		// Token: 0x040000C9 RID: 201
		private global::ns1.SiticoneCheckBox atamper;

		// Token: 0x040000CA RID: 202
		private global::ns1.SiticoneCheckBox apacker;

		// Token: 0x040000CB RID: 203
		private global::ns1.SiticoneImageButton checkall;

		// Token: 0x040000CC RID: 204
		private global::ns1.SiticoneImageButton uncheckall;

		// Token: 0x040000CD RID: 205
		private global::ns1.SiticoneLabel siticoneLabel8;

		// Token: 0x040000CE RID: 206
		private global::ns1.SiticoneLabel siticoneLabel9;

		// Token: 0x040000CF RID: 207
		private global::ns1.SiticoneLabel cflowStatus;

		// Token: 0x040000D0 RID: 208
		private global::ns1.SiticoneMetroTrackBar cflowTrackBar;

		// Token: 0x040000D1 RID: 209
		private global::ns1.SiticoneLabel siticoneLabel10;

		// Token: 0x040000D2 RID: 210
		private global::ns1.SiticonePanel siticonePanel1;

		// Token: 0x040000D3 RID: 211
		private global::ns1.SiticoneMaterialRadioButton NumbersType;

		// Token: 0x040000D4 RID: 212
		private global::ns1.SiticoneMaterialRadioButton AsciiType;

		// Token: 0x040000D5 RID: 213
		private global::ns1.SiticoneLabel siticoneLabel14;

		// Token: 0x040000D6 RID: 214
		private global::ns1.SiticoneMaterialRadioButton renamer2;

		// Token: 0x040000D7 RID: 215
		private global::ns1.SiticoneMaterialRadioButton renamer;

		// Token: 0x040000D8 RID: 216
		private global::ns1.SiticoneLabel siticoneLabel13;

		// Token: 0x040000D9 RID: 217
		private global::ns1.SiticoneLabel siticoneLabel12;

		// Token: 0x040000DA RID: 218
		private global::ns1.SiticoneMaterialRadioButton ChineseType;

		// Token: 0x040000DB RID: 219
		private global::ns1.SiticoneLabel siticoneLabel11;

		// Token: 0x040000DC RID: 220
		private global::ns1.SiticonePanel siticonePanel7;

		// Token: 0x040000DD RID: 221
		private global::ns1.SiticoneSeparator siticoneSeparator2;

		// Token: 0x040000DE RID: 222
		private global::ns1.SiticoneLabel siticoneLabel15;

		// Token: 0x040000DF RID: 223
		private global::ns1.SiticoneSeparator siticoneSeparator11;

		// Token: 0x040000E0 RID: 224
		private global::ns1.SiticonePanel siticonePanel8;

		// Token: 0x040000E1 RID: 225
		private global::ns1.SiticoneTextBox SNKText;

		// Token: 0x040000E2 RID: 226
		private global::ns1.SiticoneLabel siticoneLabel3;

		// Token: 0x040000E3 RID: 227
		private global::ns1.SiticoneButton BrowseSNK;

		// Token: 0x040000E4 RID: 228
		private global::ns1.SiticoneMaterialRadioButton RenamerOFF;

		// Token: 0x040000E5 RID: 229
		private global::ns1.SiticoneMaterialRadioButton SymbolsType;

		// Token: 0x040000E6 RID: 230
		private global::ns1.SiticoneCheckBox BaseSenc;

		// Token: 0x040000E7 RID: 231
		private global::ns1.SiticoneLabel siticoneLabel16;

		// Token: 0x040000E8 RID: 232
		private global::ns1.SiticoneSeparator siticoneSeparator1;

		// Token: 0x040000E9 RID: 233
		private global::ns1.SiticoneLabel siticoneLabel17;

		// Token: 0x040000EA RID: 234
		private global::ns1.SiticoneLabel siticoneLabel18;

		// Token: 0x040000EB RID: 235
		private global::ns1.SiticoneLabel siticoneLabel19;

		// Token: 0x040000EC RID: 236
		private global::ns1.SiticoneMetroTrackBar alllength;
	}
}

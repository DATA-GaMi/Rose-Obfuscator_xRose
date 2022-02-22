namespace PRose
{
	// Token: 0x02000077 RID: 119
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x060001AA RID: 426 RVA: 0x0003319C File Offset: 0x0003139C
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
				goto IL_42;
				IL_58:
				if (num == 2)
				{
					if (this.components == null)
					{
						goto IL_42;
					}
					num = 3;
				}
				if (num == 3)
				{
					this.components.Dispose();
					num = 4;
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
				if (num != 4)
				{
					goto IL_58;
				}
				IL_42:
				base.Dispose(disposing);
				num = 5;
				goto IL_58;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00033288 File Offset: 0x00031488
		private void InitializeComponent()
		{
			short num = 0;
			do
			{
				if (num == 71)
				{
					this.siticoneLabel6.ForeColor = global::System.Drawing.Color.LightCoral;
					num = 72;
				}
				if (num == 145)
				{
					this.Text = "Form2";
					num = 146;
				}
				if (num == 112)
				{
					this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
					num = 113;
				}
				if (num == 44)
				{
					this.siticoneLabel2.TabIndex = 26;
					num = 45;
				}
				if (num == 121)
				{
					this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
					num = 122;
				}
				if (num == 6)
				{
					this.siticoneLabel3 = new global::ns1.SiticoneLabel();
					num = 7;
				}
				if (num == 123)
				{
					this.siticoneButton1.TabIndex = 33;
					num = 124;
				}
				if (num == 40)
				{
					this.siticoneLabel2.IsSelectionEnabled = false;
					num = 41;
				}
				if (num == 34)
				{
					this.siticoneLabel1.Text = "this is the latest update";
					num = 35;
				}
				if (num == 3)
				{
					this.siticoneLabel5 = new global::ns1.SiticoneLabel();
					num = 4;
				}
				if (num == 63)
				{
					this.siticoneLabel4.Location = new global::System.Drawing.Point(106, 95);
					num = 64;
				}
				if (num == 45)
				{
					this.siticoneLabel2.Text = "and i will not update or fix it any more";
					num = 46;
				}
				if (num == 16)
				{
					this.siticoneLabel5.ForeColor = global::System.Drawing.Color.White;
					num = 17;
				}
				if (num == 88)
				{
					this.siticoneLabel7.TabIndex = 30;
					num = 89;
				}
				if (num == 41)
				{
					this.siticoneLabel2.Location = new global::System.Drawing.Point(32, 61);
					num = 42;
				}
				if (num == 144)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
					num = 145;
				}
				if (num == 26)
				{
					this.siticoneLabel1.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 27;
				}
				if (num == 140)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 141;
				}
				if (num == 8)
				{
					this.siticoneLabel6 = new global::ns1.SiticoneLabel();
					num = 9;
				}
				if (num == 135)
				{
					base.Controls.Add(this.siticoneLabel4);
					num = 136;
				}
				if (num == 37)
				{
					this.siticoneLabel2.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 38;
				}
				if (num == 29)
				{
					this.siticoneLabel1.IsSelectionEnabled = false;
					num = 30;
				}
				if (num == 141)
				{
					base.MaximizeBox = false;
					num = 142;
				}
				if (num == 43)
				{
					this.siticoneLabel2.Size = new global::System.Drawing.Size(217, 17);
					num = 44;
				}
				if (num == 75)
				{
					this.siticoneLabel6.Name = "siticoneLabel6";
					num = 76;
				}
				if (num == 104)
				{
					this.obfuscate.Size = new global::System.Drawing.Size(100, 30);
					num = 105;
				}
				if (num == 95)
				{
					this.obfuscate.CustomImages.Parent = this.obfuscate;
					num = 96;
				}
				if (num == 73)
				{
					this.siticoneLabel6.IsSelectionEnabled = false;
					num = 74;
				}
				if (num == 30)
				{
					this.siticoneLabel1.Location = new global::System.Drawing.Point(72, 44);
					num = 31;
				}
				if (num == 110)
				{
					this.siticoneButton1.BorderRadius = 2;
					num = 111;
				}
				if (num == 46)
				{
					this.siticoneLabel2.UseGdiPlusTextRendering = true;
					num = 47;
				}
				if (num == 60)
				{
					this.siticoneLabel4.ForeColor = global::System.Drawing.Color.FromArgb(230, 230, 230);
					num = 61;
				}
				if (num == 102)
				{
					this.obfuscate.Name = "obfuscate";
					num = 103;
				}
				if (num == 64)
				{
					this.siticoneLabel4.Name = "siticoneLabel4";
					num = 65;
				}
				if (num == 124)
				{
					this.siticoneButton1.Text = "Exit";
					num = 125;
				}
				if (num == 129)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 130;
				}
				if (num == 48)
				{
					this.siticoneLabel3.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 49;
				}
				if (num == 100)
				{
					this.obfuscate.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 101;
				}
				if (num == 114)
				{
					this.siticoneButton1.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 115;
				}
				if (num == 15)
				{
					this.siticoneLabel5.Font = new global::System.Drawing.Font("Corbel", 14f, global::System.Drawing.FontStyle.Bold);
					num = 16;
				}
				if (num == 27)
				{
					this.siticoneLabel1.ForeColor = global::System.Drawing.Color.FromArgb(230, 230, 230);
					num = 28;
				}
				if (num == 21)
				{
					this.siticoneLabel5.Size = new global::System.Drawing.Size(95, 25);
					num = 22;
				}
				if (num == 109)
				{
					this.siticoneButton1.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 110;
				}
				if (num == 99)
				{
					this.obfuscate.HoveredState.Parent = this.obfuscate;
					num = 100;
				}
				if (num == 89)
				{
					this.siticoneLabel7.Text = "and extra protections contact me !";
					num = 90;
				}
				if (num == 7)
				{
					this.siticoneLabel4 = new global::ns1.SiticoneLabel();
					num = 8;
				}
				if (num == 126)
				{
					this.siticoneButton1.Click += new global::System.EventHandler(this.siticoneButton1_Click);
					num = 127;
				}
				if (num == 142)
				{
					this.MaximumSize = new global::System.Drawing.Size(280, 220);
					num = 143;
				}
				if (num == 68)
				{
					this.siticoneLabel4.UseGdiPlusTextRendering = true;
					num = 69;
				}
				if (num == 72)
				{
					this.siticoneLabel6.IsContextMenuEnabled = false;
					num = 73;
				}
				if (num == 20)
				{
					this.siticoneLabel5.Name = "siticoneLabel5";
					num = 21;
				}
				if (num == 14)
				{
					this.siticoneLabel5.BackColor = global::System.Drawing.Color.Transparent;
					num = 15;
				}
				if (num == 13)
				{
					this.siticoneElipse1.TargetControl = this;
					num = 14;
				}
				if (num == 77)
				{
					this.siticoneLabel6.TabIndex = 29;
					num = 78;
				}
				if (num == 133)
				{
					base.Controls.Add(this.siticoneLabel7);
					num = 134;
				}
				if (num == 136)
				{
					base.Controls.Add(this.siticoneLabel3);
					num = 137;
				}
				if (num == 19)
				{
					this.siticoneLabel5.Location = new global::System.Drawing.Point(93, 20);
					num = 20;
				}
				if (num == 106)
				{
					this.obfuscate.Text = "Continue";
					num = 107;
				}
				if (num == 74)
				{
					this.siticoneLabel6.Location = new global::System.Drawing.Point(18, 116);
					num = 75;
				}
				if (num == 10)
				{
					this.obfuscate = new global::ns1.SiticoneButton();
					num = 11;
				}
				if (num == 12)
				{
					base.SuspendLayout();
					num = 13;
				}
				if (num == 54)
				{
					this.siticoneLabel3.Size = new global::System.Drawing.Size(206, 17);
					num = 55;
				}
				if (num == 137)
				{
					base.Controls.Add(this.siticoneLabel2);
					num = 138;
				}
				if (num == 58)
				{
					this.siticoneLabel4.BackColor = global::System.Drawing.Color.Transparent;
					num = 59;
				}
				if (num == 35)
				{
					this.siticoneLabel1.UseGdiPlusTextRendering = true;
					num = 36;
				}
				if (num == 132)
				{
					base.Controls.Add(this.obfuscate);
					num = 133;
				}
				if (num == 47)
				{
					this.siticoneLabel3.BackColor = global::System.Drawing.Color.Transparent;
					num = 48;
				}
				if (num == 36)
				{
					this.siticoneLabel2.BackColor = global::System.Drawing.Color.Transparent;
					num = 37;
				}
				if (num == 85)
				{
					this.siticoneLabel7.Location = new global::System.Drawing.Point(41, 133);
					num = 86;
				}
				if (num == 148)
				{
					base.PerformLayout();
					num = 149;
				}
				if (num == 9)
				{
					this.siticoneLabel7 = new global::ns1.SiticoneLabel();
					num = 10;
				}
				if (num == 101)
				{
					this.obfuscate.Location = new global::System.Drawing.Point(53, 160);
					num = 102;
				}
				if (num == 76)
				{
					this.siticoneLabel6.Size = new global::System.Drawing.Size(244, 17);
					num = 77;
				}
				if (num == 134)
				{
					base.Controls.Add(this.siticoneLabel6);
					num = 135;
				}
				if (num == 38)
				{
					this.siticoneLabel2.ForeColor = global::System.Drawing.Color.FromArgb(230, 230, 230);
					num = 39;
				}
				if (num == 62)
				{
					this.siticoneLabel4.IsSelectionEnabled = false;
					num = 63;
				}
				if (num == 103)
				{
					this.obfuscate.ShadowDecoration.Parent = this.obfuscate;
					num = 104;
				}
				if (num == 94)
				{
					this.obfuscate.CheckedState.Parent = this.obfuscate;
					num = 95;
				}
				if (num == 108)
				{
					this.obfuscate.Click += new global::System.EventHandler(this.obfuscate_Click);
					num = 109;
				}
				if (num == 118)
				{
					this.siticoneButton1.ImageSize = new global::System.Drawing.Size(24, 24);
					num = 119;
				}
				if (num == 50)
				{
					this.siticoneLabel3.IsContextMenuEnabled = false;
					num = 51;
				}
				if (num == 111)
				{
					this.siticoneButton1.BorderThickness = 1;
					num = 112;
				}
				if (num == 84)
				{
					this.siticoneLabel7.IsSelectionEnabled = false;
					num = 85;
				}
				if (num == 90)
				{
					this.siticoneLabel7.UseGdiPlusTextRendering = true;
					num = 91;
				}
				if (num == 22)
				{
					this.siticoneLabel5.TabIndex = 24;
					num = 23;
				}
				if (num == 81)
				{
					this.siticoneLabel7.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 82;
				}
				if (num == 96)
				{
					this.obfuscate.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
					num = 97;
				}
				if (num == 33)
				{
					this.siticoneLabel1.TabIndex = 25;
					num = 34;
				}
				if (num == 80)
				{
					this.siticoneLabel7.BackColor = global::System.Drawing.Color.Transparent;
					num = 81;
				}
				if (num == 23)
				{
					this.siticoneLabel5.Text = "Important\r\n !";
					num = 24;
				}
				if (num == 105)
				{
					this.obfuscate.TabIndex = 32;
					num = 106;
				}
				if (num == 117)
				{
					this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
					num = 118;
				}
				if (num == 127)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 128;
				}
				if (num == 130)
				{
					base.ClientSize = new global::System.Drawing.Size(280, 220);
					num = 131;
				}
				if (num == 2)
				{
					this.siticoneElipse1 = new global::ns1.SiticoneElipse(this.components);
					num = 3;
				}
				if (num == 78)
				{
					this.siticoneLabel6.Text = "If you want private version with Virtualizer\r\n";
					num = 79;
				}
				if (num == 97)
				{
					this.obfuscate.Font = new global::System.Drawing.Font("Corbel", 11f, global::System.Drawing.FontStyle.Bold);
					num = 98;
				}
				if (num == 57)
				{
					this.siticoneLabel3.UseGdiPlusTextRendering = true;
					num = 58;
				}
				if (num == 115)
				{
					this.siticoneButton1.Font = new global::System.Drawing.Font("Corbel", 11f, global::System.Drawing.FontStyle.Bold);
					num = 116;
				}
				if (num == 11)
				{
					this.siticoneButton1 = new global::ns1.SiticoneButton();
					num = 12;
				}
				if (num == 51)
				{
					this.siticoneLabel3.IsSelectionEnabled = false;
					num = 52;
				}
				if (num == 107)
				{
					this.obfuscate.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.AntiAlias;
					num = 108;
				}
				if (num == 128)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 129;
				}
				if (num == 42)
				{
					this.siticoneLabel2.Name = "siticoneLabel2";
					num = 43;
				}
				if (num == 92)
				{
					this.obfuscate.BorderRadius = 2;
					num = 93;
				}
				if (num == 55)
				{
					this.siticoneLabel3.TabIndex = 27;
					num = 56;
				}
				if (num == 122)
				{
					this.siticoneButton1.Size = new global::System.Drawing.Size(68, 30);
					num = 123;
				}
				if (num == 65)
				{
					this.siticoneLabel4.Size = new global::System.Drawing.Size(69, 17);
					num = 66;
				}
				if (num == 79)
				{
					this.siticoneLabel6.UseGdiPlusTextRendering = true;
					num = 80;
				}
				if (num == 31)
				{
					this.siticoneLabel1.Name = "siticoneLabel1";
					num = 32;
				}
				if (num == 113)
				{
					this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
					num = 114;
				}
				if (num == 138)
				{
					base.Controls.Add(this.siticoneLabel1);
					num = 139;
				}
				if (num == 93)
				{
					this.obfuscate.BorderThickness = 1;
					num = 94;
				}
				if (num == 70)
				{
					this.siticoneLabel6.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 71;
				}
				if (num == 5)
				{
					this.siticoneLabel2 = new global::ns1.SiticoneLabel();
					num = 6;
				}
				if (num == 119)
				{
					this.siticoneButton1.Location = new global::System.Drawing.Point(159, 160);
					num = 120;
				}
				if (num == 39)
				{
					this.siticoneLabel2.IsContextMenuEnabled = false;
					num = 40;
				}
				if (num == 1)
				{
					this.components = new global::System.ComponentModel.Container();
					num = 2;
				}
				if (num == 32)
				{
					this.siticoneLabel1.Size = new global::System.Drawing.Size(136, 17);
					num = 33;
				}
				if (num == 24)
				{
					this.siticoneLabel5.UseGdiPlusTextRendering = true;
					num = 25;
				}
				if (num == 143)
				{
					base.Name = "Form2";
					num = 144;
				}
				if (num == 69)
				{
					this.siticoneLabel6.BackColor = global::System.Drawing.Color.Transparent;
					num = 70;
				}
				if (num == 49)
				{
					this.siticoneLabel3.ForeColor = global::System.Drawing.Color.FromArgb(230, 230, 230);
					num = 50;
				}
				if (num == 86)
				{
					this.siticoneLabel7.Name = "siticoneLabel7";
					num = 87;
				}
				if (num == 67)
				{
					this.siticoneLabel4.Text = "or fix bugs !";
					num = 68;
				}
				if (num == 125)
				{
					this.siticoneButton1.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.AntiAlias;
					num = 126;
				}
				if (num == 146)
				{
					base.Load += new global::System.EventHandler(this.Form2_Load);
					num = 147;
				}
				if (num == 59)
				{
					this.siticoneLabel4.Font = new global::System.Drawing.Font("Corbel", 10f, global::System.Drawing.FontStyle.Bold);
					num = 60;
				}
				if (num == 87)
				{
					this.siticoneLabel7.Size = new global::System.Drawing.Size(199, 17);
					num = 88;
				}
				if (num == 61)
				{
					this.siticoneLabel4.IsContextMenuEnabled = false;
					num = 62;
				}
				if (num == 91)
				{
					this.obfuscate.BorderColor = global::System.Drawing.Color.IndianRed;
					num = 92;
				}
				if (num == 66)
				{
					this.siticoneLabel4.TabIndex = 28;
					num = 67;
				}
				if (num == 52)
				{
					this.siticoneLabel3.Location = new global::System.Drawing.Point(37, 78);
					num = 53;
				}
				if (num == 120)
				{
					this.siticoneButton1.Name = "siticoneButton1";
					num = 121;
				}
				if (num == 28)
				{
					this.siticoneLabel1.IsContextMenuEnabled = false;
					num = 29;
				}
				if (num == 131)
				{
					base.Controls.Add(this.siticoneButton1);
					num = 132;
				}
				if (num == 4)
				{
					this.siticoneLabel1 = new global::ns1.SiticoneLabel();
					num = 5;
				}
				if (num == 147)
				{
					base.ResumeLayout(false);
					num = 148;
				}
				if (num == 139)
				{
					base.Controls.Add(this.siticoneLabel5);
					num = 140;
				}
				if (num == 116)
				{
					this.siticoneButton1.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 117;
				}
				if (num == 82)
				{
					this.siticoneLabel7.ForeColor = global::System.Drawing.Color.LightCoral;
					num = 83;
				}
				if (num == 83)
				{
					this.siticoneLabel7.IsContextMenuEnabled = false;
					num = 84;
				}
				if (num == 25)
				{
					this.siticoneLabel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 26;
				}
				if (num == 53)
				{
					this.siticoneLabel3.Name = "siticoneLabel3";
					num = 54;
				}
				if (num == 56)
				{
					this.siticoneLabel3.Text = "so please don't ask me to update it !";
					num = 57;
				}
				if (num == 98)
				{
					this.obfuscate.ForeColor = global::System.Drawing.Color.FromArgb(222, 222, 222);
					num = 99;
				}
				if (num == 17)
				{
					this.siticoneLabel5.IsContextMenuEnabled = false;
					num = 18;
				}
				if (num == 18)
				{
					this.siticoneLabel5.IsSelectionEnabled = false;
					num = 19;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 149);
		}

		// Token: 0x040000ED RID: 237
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000EE RID: 238
		private global::ns1.SiticoneElipse siticoneElipse1;

		// Token: 0x040000EF RID: 239
		private global::ns1.SiticoneLabel siticoneLabel5;

		// Token: 0x040000F0 RID: 240
		private global::ns1.SiticoneLabel siticoneLabel7;

		// Token: 0x040000F1 RID: 241
		private global::ns1.SiticoneLabel siticoneLabel6;

		// Token: 0x040000F2 RID: 242
		private global::ns1.SiticoneLabel siticoneLabel4;

		// Token: 0x040000F3 RID: 243
		private global::ns1.SiticoneLabel siticoneLabel3;

		// Token: 0x040000F4 RID: 244
		private global::ns1.SiticoneLabel siticoneLabel2;

		// Token: 0x040000F5 RID: 245
		private global::ns1.SiticoneLabel siticoneLabel1;

		// Token: 0x040000F6 RID: 246
		private global::ns1.SiticoneButton siticoneButton1;

		// Token: 0x040000F7 RID: 247
		private global::ns1.SiticoneButton obfuscate;
	}
}

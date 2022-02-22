using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Writer;
using ns1;
using Rose.Protections;

namespace PRose
{
	// Token: 0x02000076 RID: 118
	public partial class Form1 : Form
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00002672 File Offset: 0x00000872
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001BCA8 File Offset: 0x00019EA8
		private void Form1_Load(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 9)
				{
					xd.renamertype = "Ascii";
					num = 10;
				}
				if (num == 2)
				{
					base.Opacity = 0.9;
					num = 3;
				}
				if (num == 3)
				{
					this.siticonePanel5.AllowDrop = true;
					num = 4;
				}
				if (num == 4)
				{
					this.siticonePanel8.AllowDrop = true;
					num = 5;
				}
				if (num == 5)
				{
					this.assemblytext.AllowDrop = true;
					num = 6;
				}
				if (num == 8)
				{
					this.AsciiType.Checked = true;
					num = 9;
				}
				if (num == 7)
				{
					this.SNKText.Text = Directory.GetCurrentDirectory() + "\\snk.snk";
					num = 8;
				}
				if (num == 1)
				{
					base.Activate();
					num = 2;
				}
				if (num == 6)
				{
					this.SNKText.AllowDrop = true;
					num = 7;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		// Token: 0x0600017B RID: 379
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600017C RID: 380
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600017D RID: 381 RVA: 0x0001BE84 File Offset: 0x0001A084
		private void movelbl_MouseDown(object sender, MouseEventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					Form1.ReleaseCapture();
					num = 2;
				}
				if (num == 2)
				{
					Form1.SendMessage(base.Handle, 161, 2, 0);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0001BE84 File Offset: 0x0001A084
		private void movelbl2_MouseDown(object sender, MouseEventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					Form1.ReleaseCapture();
					num = 2;
				}
				if (num == 2)
				{
					Form1.SendMessage(base.Handle, 161, 2, 0);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0001BE84 File Offset: 0x0001A084
		private void siticoneLabel2_MouseDown(object sender, MouseEventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					Form1.ReleaseCapture();
					num = 2;
				}
				if (num == 2)
				{
					Form1.SendMessage(base.Handle, 161, 2, 0);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001BE84 File Offset: 0x0001A084
		private void movepnl_MouseDown(object sender, MouseEventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					Form1.ReleaseCapture();
					num = 2;
				}
				if (num == 2)
				{
					Form1.SendMessage(base.Handle, 161, 2, 0);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0001BF30 File Offset: 0x0001A130
		private void siticoneLabel8_MouseDown(object sender, MouseEventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 2)
				{
					Form1.SendMessage(base.Handle, 161, 2, 0);
					num = 3;
				}
				if (num == 1)
				{
					Form1.ReleaseCapture();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0001BE84 File Offset: 0x0001A084
		private void siticoneLabel16_MouseDown(object sender, MouseEventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					Form1.ReleaseCapture();
					num = 2;
				}
				if (num == 2)
				{
					Form1.SendMessage(base.Handle, 161, 2, 0);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001BFDC File Offset: 0x0001A1DC
		private void exit_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					Environment.Exit(0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001C054 File Offset: 0x0001A254
		private void min_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					base.WindowState = FormWindowState.Minimized;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0001C0D0 File Offset: 0x0001A2D0
		private void renamer_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					if (!this.renamer.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 2)
				{
					this.renamer2.Checked = false;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001C17C File Offset: 0x0001A37C
		private void renamer2_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 2)
				{
					this.renamer.Checked = false;
					num = 3;
				}
				if (num == 1)
				{
					if (!this.renamer2.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001C228 File Offset: 0x0001A428
		private void packer_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 3)
				{
					this.atamper.Checked = false;
					num = 4;
				}
				if (num == 2)
				{
					this.virt.Checked = false;
					num = 3;
				}
				if (num == 4)
				{
					this.apacker.Checked = false;
					num = 5;
				}
				if (num == 1)
				{
					if (!this.packer.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001C330 File Offset: 0x0001A530
		private void apacker_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 5)
				{
					this.invalidmd.Checked = false;
					num = 6;
				}
				if (num == 1)
				{
					if (!this.apacker.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 3)
				{
					this.packer.Checked = false;
					num = 4;
				}
				if (num == 6)
				{
					this.hmethods.Checked = false;
					num = 7;
				}
				if (num == 2)
				{
					this.virt.Checked = false;
					num = 3;
				}
				if (num == 4)
				{
					this.atamper.Checked = false;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0001C490 File Offset: 0x0001A690
		private void virt_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 2)
				{
					this.virt.Checked = false;
					num = 3;
				}
				if (num == 1)
				{
					if (!this.virt.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001C53C File Offset: 0x0001A73C
		private void signer_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 2)
				{
					this.virt.Checked = false;
					num = 3;
				}
				if (num == 1)
				{
					if (!this.signer.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001C5E8 File Offset: 0x0001A7E8
		private void atamper_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 2)
				{
					this.packer.Checked = false;
					num = 3;
				}
				if (num == 1)
				{
					if (!this.atamper.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 3)
				{
					this.apacker.Checked = false;
					num = 4;
				}
				if (num == 4)
				{
					this.virt.Checked = false;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		private void invalidmd_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 3)
				{
					this.apacker.Checked = false;
					num = 4;
				}
				if (num == 2)
				{
					this.virt.Checked = false;
					num = 3;
				}
				if (num == 1)
				{
					if (!this.invalidmd.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0001C7C8 File Offset: 0x0001A9C8
		private void hmethods_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 2)
				{
					this.virt.Checked = false;
					num = 3;
				}
				if (num == 1)
				{
					if (!this.hmethods.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 3)
				{
					this.apacker.Checked = false;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001C8A0 File Offset: 0x0001AAA0
		private void BaseSenc_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					if (!this.BaseSenc.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 2)
				{
					this.cconfusion.Checked = false;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001C94C File Offset: 0x0001AB4C
		private void cconfusion_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					if (!this.cconfusion.Checked)
					{
						break;
					}
					num = 2;
				}
				if (num == 2)
				{
					this.BaseSenc.Checked = false;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
		private void alllength_ValueChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					xd.thelength = this.alllength.Value;
					num = 2;
				}
				if (num == 2)
				{
					this.siticoneLabel19.Text = this.alllength.Value.ToString();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001CABC File Offset: 0x0001ACBC
		private void checkall_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 24)
				{
					this.mstrip.Checked = true;
					num = 25;
				}
				if (num == 10)
				{
					this.hmethods.Checked = true;
					num = 11;
				}
				if (num == 27)
				{
					this.pmobf.Checked = true;
					num = 28;
				}
				if (num == 12)
				{
					this.BaseSenc.Checked = true;
					num = 13;
				}
				if (num == 6)
				{
					this.adump.Checked = true;
					num = 7;
				}
				if (num == 26)
				{
					this.cryptosenc.Checked = true;
					num = 27;
				}
				if (num == 21)
				{
					this.renamer.Checked = true;
					num = 22;
				}
				if (num == 3)
				{
					this.pint.Checked = true;
					num = 4;
				}
				if (num == 14)
				{
					this.pobf.Checked = true;
					num = 15;
				}
				if (num == 4)
				{
					this.hnamespaces.Checked = true;
					num = 5;
				}
				if (num == 2)
				{
					this.uncheckall.Visible = true;
					num = 3;
				}
				if (num == 1)
				{
					this.checkall.Visible = false;
					num = 2;
				}
				if (num == 16)
				{
					this.ade4dot.Checked = true;
					num = 17;
				}
				if (num == 11)
				{
					this.asciisenc.Checked = true;
					num = 12;
				}
				if (num == 18)
				{
					this.cconfusion.Checked = true;
					num = 19;
				}
				if (num == 8)
				{
					this.adebug.Checked = true;
					num = 9;
				}
				if (num == 25)
				{
					this.invalidmd.Checked = true;
					num = 26;
				}
				if (num == 17)
				{
					this.ajunk.Checked = true;
					num = 18;
				}
				if (num == 23)
				{
					this.omethods.Checked = true;
					num = 24;
				}
				if (num == 5)
				{
					this.aildasm.Checked = true;
					num = 6;
				}
				if (num == 15)
				{
					this.fobf.Checked = true;
					num = 16;
				}
				if (num == 13)
				{
					this.hstr.Checked = true;
					num = 14;
				}
				if (num == 19)
				{
					this.mutation.Checked = true;
					num = 20;
				}
				if (num == 7)
				{
					this.atamper.Checked = true;
					num = 8;
				}
				if (num == 22)
				{
					this.arith.Checked = true;
					num = 23;
				}
				if (num == 9)
				{
					this.cflow.Checked = true;
					num = 10;
				}
				if (num == 20)
				{
					this.sconfusion.Checked = true;
					num = 21;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 28);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001CFCC File Offset: 0x0001B1CC
		private void uncheckall_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 4)
				{
					this.hnamespaces.Checked = false;
					num = 5;
				}
				if (num == 8)
				{
					this.adebug.Checked = false;
					num = 9;
				}
				if (num == 11)
				{
					this.asciisenc.Checked = false;
					num = 12;
				}
				if (num == 10)
				{
					this.hmethods.Checked = false;
					num = 11;
				}
				if (num == 17)
				{
					this.ajunk.Checked = false;
					num = 18;
				}
				if (num == 14)
				{
					this.pobf.Checked = false;
					num = 15;
				}
				if (num == 16)
				{
					this.ade4dot.Checked = false;
					num = 17;
				}
				if (num == 13)
				{
					this.hstr.Checked = false;
					num = 14;
				}
				if (num == 19)
				{
					this.mutation.Checked = false;
					num = 20;
				}
				if (num == 22)
				{
					this.arith.Checked = false;
					num = 23;
				}
				if (num == 21)
				{
					this.renamer.Checked = false;
					num = 22;
				}
				if (num == 5)
				{
					this.aildasm.Checked = false;
					num = 6;
				}
				if (num == 6)
				{
					this.adump.Checked = false;
					num = 7;
				}
				if (num == 18)
				{
					this.cconfusion.Checked = false;
					num = 19;
				}
				if (num == 2)
				{
					this.uncheckall.Visible = false;
					num = 3;
				}
				if (num == 24)
				{
					this.mstrip.Checked = false;
					num = 25;
				}
				if (num == 9)
				{
					this.cflow.Checked = false;
					num = 10;
				}
				if (num == 25)
				{
					this.invalidmd.Checked = false;
					num = 26;
				}
				if (num == 1)
				{
					this.checkall.Visible = true;
					num = 2;
				}
				if (num == 26)
				{
					this.cryptosenc.Checked = false;
					num = 27;
				}
				if (num == 27)
				{
					this.pmobf.Checked = false;
					num = 28;
				}
				if (num == 3)
				{
					this.pint.Checked = false;
					num = 4;
				}
				if (num == 7)
				{
					this.atamper.Checked = false;
					num = 8;
				}
				if (num == 23)
				{
					this.omethods.Checked = false;
					num = 24;
				}
				if (num == 20)
				{
					this.sconfusion.Checked = false;
					num = 21;
				}
				if (num == 12)
				{
					this.BaseSenc.Checked = false;
					num = 13;
				}
				if (num == 15)
				{
					this.fobf.Checked = false;
					num = 16;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 28);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001D4DC File Offset: 0x0001B6DC
		private void discord_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 3)
				{
					Clipboard.SetText("xRose#0308");
					num = 4;
				}
				DialogResult dialogResult;
				if (num == 1)
				{
					dialogResult = MessageBox.Show("Discord : xRose#0308" + Environment.NewLine + "Press ok to Copy it .", "Discord", MessageBoxButtons.OK);
					num = 2;
				}
				if (num == 2)
				{
					if (dialogResult != DialogResult.OK)
					{
						break;
					}
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001D5BC File Offset: 0x0001B7BC
		private void facebook_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://www.facebook.com/String.xRose");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001D634 File Offset: 0x0001B834
		private void donation_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://www.paypal.com/paypalme/inx707");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001D634 File Offset: 0x0001B834
		private void siticoneLabel9_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://www.paypal.com/paypalme/inx707");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001D6AC File Offset: 0x0001B8AC
		private void browse_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				OpenFileDialog openFileDialog;
				if (num == 3)
				{
					openFileDialog.Filter = ".NET Assembly (*.exe)|*.exe|(*.dll)|*.dll";
					num = 4;
				}
				if (num == 1)
				{
					openFileDialog = new OpenFileDialog();
					num = 2;
				}
				if (num == 8)
				{
					this.assemblytext.Text = openFileDialog.FileName;
					num = 9;
				}
				if (num == 5)
				{
					if (openFileDialog.ShowDialog() != DialogResult.OK)
					{
						break;
					}
					num = 6;
				}
				if (num == 2)
				{
					openFileDialog.Title = "Load Assembly";
					num = 3;
				}
				if (num == 9)
				{
					this.log.Items.Add("Loaded : " + this.assembly);
					num = 10;
				}
				if (num == 7)
				{
					this.assembly = openFileDialog.FileName;
					num = 8;
				}
				if (num == 6)
				{
					this.log.Items.Clear();
					num = 7;
				}
				if (num == 4)
				{
					openFileDialog.Multiselect = false;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001D890 File Offset: 0x0001BA90
		private void assemblytext_DragDrop(object sender, DragEventArgs e)
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
				Array array = (Array)e.Data.GetData(DataFormats.FileDrop);
				if (array != null)
				{
					string text = array.GetValue(0).ToString();
					int num2 = text.LastIndexOf(".");
					int startIndex = text.LastIndexOf("\\");
					if (num2 != -1)
					{
						string text2 = text.Substring(num2);
						text2 = text2.ToLower();
						if (text2 == ".exe" || text2 == ".dll")
						{
							base.Activate();
							this.assemblytext.Text = text;
							this.assembly = this.assemblytext.Text;
							string text3 = text.Substring(startIndex);
							this.log.Items.Clear();
							this.log.Items.Add("Loaded : " + text3.Replace("\\", null));
							this.log.SelectedIndex = 0;
						}
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please load .net assembly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.assemblytext.Clear();
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001DA78 File Offset: 0x0001BC78
		private void assemblytext_DragEnter(object sender, DragEventArgs e)
		{
			short num = 0;
			for (;;)
			{
				if (num == 2)
				{
					e.Effect = DragDropEffects.Copy;
					num = 3;
				}
				if (num == 4)
				{
					goto IL_47;
				}
				IL_5E:
				if (num == 3)
				{
					break;
				}
				if (num == 1)
				{
					if (!e.Data.GetDataPresent(DataFormats.FileDrop))
					{
						goto IL_47;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					return;
				}
				continue;
				IL_47:
				e.Effect = DragDropEffects.None;
				num = 5;
				goto IL_5E;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001DB68 File Offset: 0x0001BD68
		private void obfuscate_Click_1(object sender, EventArgs e)
		{
			short num = 0;
			for (;;)
			{
				if (num == 116)
				{
					global::Context.PackerPhase();
					num = 117;
				}
				if (num == 50)
				{
					this.log.Items.Add("Executed : Proxy Obfuscation");
					num = 51;
				}
				if (num != 101)
				{
					goto IL_8D;
				}
				if (this.signer.Checked)
				{
					num = 102;
					goto IL_8D;
				}
				goto IL_6BE;
				IL_17C1:
				ModuleDefMD moduleDefMD;
				if (num == 11)
				{
					Enc.EncryptStrings(moduleDefMD);
					num = 12;
				}
				if (num == 28)
				{
					if (!this.apacker.Checked)
					{
						goto IL_3C6;
					}
					num = 29;
				}
				string text;
				if (num == 112)
				{
					File.WriteAllBytes(text, Packer2.Pack(text, text, RUtils.GenerateRandomString2(5), true, true));
					num = 113;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 146)
				{
					break;
				}
				continue;
				IL_173E:
				if (num == 86)
				{
					MetaStrip.Execute(moduleDefMD);
					num = 87;
				}
				if (num == 21)
				{
					this.log.Items.Add("Executed : Hide Strings");
					num = 22;
				}
				if (num == 19)
				{
					goto IL_17A5;
				}
				goto IL_17C1;
				IL_1711:
				if (num == 129)
				{
					goto IL_1722;
				}
				goto IL_173E;
				IL_16CF:
				if (num == 49)
				{
					proxy.Execute(moduleDefMD);
					num = 50;
				}
				if (num == 119)
				{
					goto IL_1703;
				}
				goto IL_1711;
				IL_1625:
				if (num == 5)
				{
					AssemblyDef assemblyDef = moduleDefMD.Assembly;
					num = 6;
				}
				if (num == 132)
				{
					this.log.Items.Add("Obfuscated Successfully");
					num = 133;
				}
				ModuleContext context;
				if (num == 2)
				{
					context = ModuleDef.CreateModuleContext();
					num = 3;
				}
				if (num == 111)
				{
					goto IL_16B3;
				}
				goto IL_16CF;
				IL_15A2:
				if (num == 30)
				{
					this.log.Items.Add("Executed : Anti Dump For Packer");
					num = 31;
				}
				if (num == 110)
				{
					AntiTamper.Sha256(text);
					num = 111;
				}
				if (num == 88)
				{
					goto IL_1609;
				}
				goto IL_1625;
				IL_1542:
				if (num == 59)
				{
					this.log.Items.Add("Executed : Mutation");
					num = 60;
				}
				if (num == 91)
				{
					goto IL_1586;
				}
				goto IL_15A2;
				IL_1446:
				ModuleWriterOptions moduleWriterOptions;
				if (num == 100)
				{
					moduleWriterOptions = new ModuleWriterOptions(moduleDefMD);
					num = 101;
				}
				if (num == 47)
				{
					this.log.Items.Add("Executed : Stack Confusion");
					num = 48;
				}
				if (num == 3)
				{
					num = 4;
				}
				if (num == 40)
				{
					AntiTamper.Execute(moduleDefMD);
					num = 41;
				}
				if (num == 37)
				{
					this.log.Items.Add("Executed : Anti ILDasm");
					num = 38;
				}
				if (num == 48)
				{
					goto IL_1526;
				}
				goto IL_1542;
				IL_12A8:
				if (num == 31)
				{
					goto IL_CA1;
				}
				if (num == 18)
				{
					this.log.Items.Add("Executed : Crypto Strings Encryption");
					num = 19;
				}
				string text2;
				if (num == 134)
				{
					AntiTamper.Sha256(text2);
					num = 135;
				}
				if (num == 71)
				{
					this.log.Items.Add("Executed : Hide Namespaces");
					num = 72;
				}
				if (num == 52)
				{
					ProxyMeth.Execute(moduleDefMD);
					num = 53;
				}
				if (num == 1)
				{
					this.log.Items.Clear();
					num = 2;
				}
				if (num == 104)
				{
					this.log.Items.Add("Assembly Signed Successfully");
					num = 105;
				}
				if (num == 139)
				{
					global::Context.LoadModule(text2);
					num = 140;
				}
				bool flag;
				if (num == 133)
				{
					if (!flag)
					{
						goto IL_43B;
					}
					num = 134;
				}
				if (num == 66)
				{
					goto IL_142A;
				}
				goto IL_1446;
				IL_127B:
				if (num == 22)
				{
					goto IL_128C;
				}
				goto IL_12A8;
				IL_124E:
				if (num == 75)
				{
					goto IL_125F;
				}
				goto IL_127B;
				IL_1221:
				if (num == 85)
				{
					goto IL_1232;
				}
				goto IL_124E;
				IL_1194:
				if (num == 113)
				{
					this.log.Items.Add("Packed Successfully");
					num = 114;
				}
				if (num == 9)
				{
					this.invalidmd.Checked = false;
					num = 10;
				}
				if (num == 81)
				{
					goto IL_1205;
				}
				goto IL_1221;
				IL_10EE:
				if (num == 64)
				{
					RandomOutlinedMethods.Execute(moduleDefMD);
					num = 65;
				}
				if (num == 87)
				{
					this.log.Items.Add("Executed : Meta Strip");
					num = 88;
				}
				if (num == 109)
				{
					if (!flag)
					{
						goto IL_16B3;
					}
					num = 110;
				}
				if (num == 69)
				{
					goto IL_1178;
				}
				goto IL_1194;
				IL_108E:
				if (num == 12)
				{
					this.log.Items.Add("Executed : Base64 Strings Encryption");
					num = 13;
				}
				if (num == 114)
				{
					goto IL_10D2;
				}
				goto IL_10EE;
				IL_1061:
				if (num == 16)
				{
					goto IL_1072;
				}
				goto IL_108E;
				IL_FDA:
				if (num == 34)
				{
					this.log.Items.Add("Executed : Anti Dump");
					num = 35;
				}
				ModuleWriterOptions moduleWriterOptions2;
				if (num == 124)
				{
					moduleWriterOptions2 = new ModuleWriterOptions(moduleDefMD);
					num = 125;
				}
				if (num == 45)
				{
					goto IL_1045;
				}
				goto IL_1061;
				IL_EFE:
				if (num == 120)
				{
					moduleDefMD = null;
					num = 121;
				}
				if (num == 82)
				{
					ModuleWriterOptions moduleWriterOptions3 = AntiDe4dot.Execute(moduleDefMD);
					num = 83;
				}
				if (num == 61)
				{
					ControlFlow.Execute(moduleDefMD);
					num = 62;
				}
				if (num == 79)
				{
					AddJunk.Execute(moduleDefMD);
					num = 80;
				}
				if (num == 23)
				{
					AntiDebug2.Execute(moduleDefMD);
					num = 24;
				}
				if (num == 72)
				{
					goto IL_FBE;
				}
				goto IL_FDA;
				IL_CBD:
				if (num == 98)
				{
					if (!this.assembly.EndsWith(".exe"))
					{
						goto IL_5CE;
					}
					num = 99;
				}
				if (num == 115)
				{
					global::Context.LoadModule(text);
					num = 116;
				}
				if (num == 27)
				{
					if (this.packer.Checked)
					{
						goto IL_198;
					}
					num = 28;
				}
				if (num == 92)
				{
					fakeobfuscator.Execute(moduleDefMD);
					num = 93;
				}
				if (num == 4)
				{
					moduleDefMD = ModuleDefMD.Load(this.assembly, context);
					num = 5;
				}
				if (num == 65)
				{
					this.log.Items.Add("Executed : Random Outline Methods");
					num = 66;
				}
				if (num == 53)
				{
					this.log.Items.Add("Executed : Proxy Meth Obfuscation");
					num = 54;
				}
				if (num == 76)
				{
					RenamerObfuscation.Execute(moduleDefMD);
					num = 77;
				}
				if (num == 99)
				{
					text = this.assembly + "-ROSED.exe";
					num = 100;
				}
				if (num == 41)
				{
					this.log.Items.Add("Executed : Anti Tamper");
					num = 42;
				}
				if (num == 93)
				{
					this.log.Items.Add("Executed : Fake Obfuscator");
					num = 94;
				}
				if (num == 141)
				{
					global::Context.SaveModule();
					num = 142;
				}
				if (num == 26)
				{
					goto IL_EE2;
				}
				goto IL_EFE;
				IL_C3A:
				if (num == 55)
				{
					ProxyInt.Execute(moduleDefMD);
					num = 56;
				}
				if (num == 68)
				{
					this.log.Items.Add("Executed : Arithmetic");
					num = 69;
				}
				if (num == 35)
				{
					goto IL_CA1;
				}
				goto IL_CBD;
				IL_BE2:
				if (num == 131)
				{
					moduleDefMD.Write(text2, moduleWriterOptions2);
					num = 132;
				}
				if (num == 38)
				{
					goto IL_C1E;
				}
				goto IL_C3A;
				IL_A50:
				if (num == 15)
				{
					this.log.Items.Add("Executed : Ascii Strings Encryption");
					num = 16;
				}
				if (num == 136)
				{
					File.WriteAllBytes(text2, Packer2.Pack(text2, text2, RUtils.GenerateRandomString2(5), true, true));
					num = 137;
				}
				if (num == 137)
				{
					this.log.Items.Add("Packed Successfully");
					num = 138;
				}
				if (num == 25)
				{
					this.log.Items.Add("Executed : Anti Debug");
					num = 26;
				}
				if (num == 77)
				{
					this.log.Items.Add("Executed : Renamer 2");
					num = 78;
				}
				if (num == 8)
				{
					this.hmethods.Checked = false;
					num = 9;
				}
				if (num == 106)
				{
					moduleWriterOptions.Logger = DummyLogger.NoThrowInstance;
					num = 107;
				}
				if (num == 54)
				{
					goto IL_BC6;
				}
				goto IL_BE2;
				IL_9BF:
				if (num == 123)
				{
					text2 = this.assembly + "-ROSED.dll";
					num = 124;
				}
				if (num == 96)
				{
					this.log.Items.Add("Executed : Invalid Meta Data");
					num = 97;
				}
				if (num == 57)
				{
					goto IL_A34;
				}
				goto IL_A50;
				IL_911:
				if (num == 107)
				{
					moduleDefMD.Write(text, moduleWriterOptions);
					num = 108;
				}
				if (num == 56)
				{
					this.log.Items.Add("Executed : Proxy Int Obfuscation");
					num = 57;
				}
				if (num == 73)
				{
					NewRenamerObfuscation.DoRenaming(moduleDefMD);
					num = 74;
				}
				if (num == 78)
				{
					goto IL_9A3;
				}
				goto IL_9BF;
				IL_7ED:
				if (num == 142)
				{
					this.log.Items.Add("Packed Successfully");
					num = 143;
				}
				if (num == 130)
				{
					moduleWriterOptions2.Logger = DummyLogger.NoThrowInstance;
					num = 131;
				}
				if (num == 33)
				{
					AntiDumpMethod1.Execute(moduleDefMD);
					num = 34;
				}
				if (num == 58)
				{
					Mutation.Execute(moduleDefMD);
					num = 59;
				}
				if (num == 39)
				{
					flag = true;
					num = 40;
				}
				if (num == 108)
				{
					this.log.Items.Add("Obfuscated Successfully");
					num = 109;
				}
				if (num == 42)
				{
					goto IL_8F5;
				}
				goto IL_911;
				IL_76C:
				StrongNameKey signatureKey;
				if (num == 102)
				{
					signatureKey = new StrongNameKey(this.SNKText.Text);
					num = 103;
				}
				if (num == 36)
				{
					AntiILDasm.Execute(moduleDefMD);
					num = 37;
				}
				if (num == 10)
				{
					goto IL_7D1;
				}
				goto IL_7ED;
				IL_6DA:
				if (num == 20)
				{
					hideStrings.Execute(moduleDefMD);
					num = 21;
				}
				if (num == 6)
				{
					flag = false;
					num = 7;
				}
				if (num == 140)
				{
					global::Context.PackerPhase();
					num = 141;
				}
				if (num == 63)
				{
					goto IL_750;
				}
				goto IL_76C;
				IL_6AD:
				if (num == 105)
				{
					goto IL_6BE;
				}
				goto IL_6DA;
				IL_61C:
				if (num == 128)
				{
					this.log.Items.Add("Assembly Signed Successfully");
					num = 129;
				}
				StrongNameKey signatureKey2;
				if (num == 126)
				{
					signatureKey2 = new StrongNameKey(this.SNKText.Text);
					num = 127;
				}
				if (num == 60)
				{
					goto IL_691;
				}
				goto IL_6AD;
				IL_5EF:
				if (num == 138)
				{
					goto IL_600;
				}
				goto IL_61C;
				IL_4EF:
				if (num == 125)
				{
					if (!this.signer.Checked)
					{
						goto IL_1722;
					}
					num = 126;
				}
				if (num == 95)
				{
					InvalidMDPhase.Execute(moduleDefMD.Assembly);
					num = 96;
				}
				if (num == 24)
				{
					AntiDebug.Execute(moduleDefMD);
					num = 25;
				}
				if (num == 80)
				{
					this.log.Items.Add("Executed : Add Junks");
					num = 81;
				}
				if (num == 43)
				{
					Calli.Execute(moduleDefMD);
					num = 44;
				}
				if (num == 122)
				{
					goto IL_5CE;
				}
				goto IL_5EF;
				IL_457:
				if (num == 67)
				{
					Arithmetic.Execute(moduleDefMD);
					num = 68;
				}
				if (num == 118)
				{
					this.log.Items.Add("Packed Successfully");
					num = 119;
				}
				if (num == 46)
				{
					StackUnfConfusion.Execute(moduleDefMD);
					num = 47;
				}
				if (num == 143)
				{
					goto IL_4E1;
				}
				goto IL_4EF;
				IL_3D8:
				if (num == 74)
				{
					this.log.Items.Add("Executed : Renamer");
					num = 75;
				}
				if (num == 144)
				{
					moduleDefMD = null;
					num = 145;
				}
				if (num == 135)
				{
					goto IL_43B;
				}
				goto IL_457;
				IL_2B6:
				if (num == 14)
				{
					First.Execute(moduleDefMD);
					num = 15;
				}
				if (num == 62)
				{
					this.log.Items.Add("Executed : Control Flow");
					num = 63;
				}
				if (num == 70)
				{
					Hidenamespaces.Execute(moduleDefMD);
					num = 71;
				}
				if (num == 103)
				{
					moduleWriterOptions.InitializeStrongNameSigning(moduleDefMD, signatureKey);
					num = 104;
				}
				if (num == 44)
				{
					this.log.Items.Add("Executed : Calli Confusion");
					num = 45;
				}
				if (num == 7)
				{
					if (moduleDefMD.Is32BitRequired)
					{
						goto IL_7D1;
					}
					num = 8;
				}
				if (num == 32)
				{
					goto IL_3C6;
				}
				goto IL_3D8;
				IL_1CD:
				if (num == 84)
				{
					this.log.Items.Add("Executed : Anti De4dot");
					num = 85;
				}
				if (num == 83)
				{
					AntiDe4dot.Execute1(moduleDefMD.Assembly);
					num = 84;
				}
				if (num == 121)
				{
					num = 122;
				}
				if (num == 145)
				{
					num = 146;
				}
				if (num == 89)
				{
					hideMethods.Execute(moduleDefMD);
					num = 90;
				}
				if (num == 94)
				{
					goto IL_29A;
				}
				goto IL_2B6;
				IL_1AA:
				if (num == 97)
				{
					goto IL_1BB;
				}
				goto IL_1CD;
				IL_129:
				if (num == 127)
				{
					moduleWriterOptions2.InitializeStrongNameSigning(moduleDefMD, signatureKey2);
					num = 128;
				}
				if (num == 90)
				{
					this.log.Items.Add("Executed : Hide Methods");
					num = 91;
				}
				if (num == 29)
				{
					goto IL_198;
				}
				goto IL_1AA;
				IL_DD:
				if (num == 117)
				{
					global::Context.SaveModule();
					num = 118;
				}
				if (num == 13)
				{
					goto IL_10D;
				}
				goto IL_129;
				IL_8D:
				if (num == 17)
				{
					StringEncoder.Execute(moduleDefMD);
					num = 18;
				}
				if (num == 51)
				{
					goto IL_C1;
				}
				goto IL_DD;
				IL_17A5:
				if (this.hstr.Checked)
				{
					num = 20;
					goto IL_17C1;
				}
				goto IL_128C;
				IL_1072:
				if (this.cryptosenc.Checked)
				{
					num = 17;
					goto IL_108E;
				}
				goto IL_17A5;
				IL_10D:
				if (this.asciisenc.Checked)
				{
					num = 14;
					goto IL_129;
				}
				goto IL_1072;
				IL_7D1:
				if (this.BaseSenc.Checked)
				{
					num = 11;
					goto IL_7ED;
				}
				goto IL_10D;
				IL_1722:
				moduleWriterOptions2.MetaDataOptions.Flags = MetaDataFlags.PreserveAll;
				num = 130;
				goto IL_173E;
				IL_1703:
				context = null;
				num = 120;
				goto IL_1711;
				IL_10D2:
				if (this.packer.Checked)
				{
					num = 115;
					goto IL_10EE;
				}
				goto IL_1703;
				IL_16B3:
				if (this.apacker.Checked)
				{
					num = 112;
					goto IL_16CF;
				}
				goto IL_10D2;
				IL_1609:
				if (this.hmethods.Checked)
				{
					num = 89;
					goto IL_1625;
				}
				goto IL_1586;
				IL_1232:
				if (this.mstrip.Checked)
				{
					num = 86;
					goto IL_124E;
				}
				goto IL_1609;
				IL_1205:
				if (this.ade4dot.Checked)
				{
					num = 82;
					goto IL_1221;
				}
				goto IL_1232;
				IL_9A3:
				if (this.ajunk.Checked)
				{
					num = 79;
					goto IL_9BF;
				}
				goto IL_1205;
				IL_125F:
				if (this.renamer2.Checked)
				{
					num = 76;
					goto IL_127B;
				}
				goto IL_9A3;
				IL_FBE:
				if (this.renamer.Checked)
				{
					num = 73;
					goto IL_FDA;
				}
				goto IL_125F;
				IL_1178:
				if (this.hnamespaces.Checked)
				{
					num = 70;
					goto IL_1194;
				}
				goto IL_FBE;
				IL_142A:
				if (this.arith.Checked)
				{
					num = 67;
					goto IL_1446;
				}
				goto IL_1178;
				IL_750:
				if (this.omethods.Checked)
				{
					num = 64;
					goto IL_76C;
				}
				goto IL_142A;
				IL_691:
				if (this.cflow.Checked)
				{
					num = 61;
					goto IL_6AD;
				}
				goto IL_750;
				IL_A34:
				if (this.mutation.Checked)
				{
					num = 58;
					goto IL_A50;
				}
				goto IL_691;
				IL_BC6:
				if (this.pint.Checked)
				{
					num = 55;
					goto IL_BE2;
				}
				goto IL_A34;
				IL_C1:
				if (this.pmobf.Checked)
				{
					num = 52;
					goto IL_DD;
				}
				goto IL_BC6;
				IL_1526:
				if (this.pobf.Checked)
				{
					num = 49;
					goto IL_1542;
				}
				goto IL_C1;
				IL_1045:
				if (this.sconfusion.Checked)
				{
					num = 46;
					goto IL_1061;
				}
				goto IL_1526;
				IL_8F5:
				if (this.cconfusion.Checked)
				{
					num = 43;
					goto IL_911;
				}
				goto IL_1045;
				IL_C1E:
				if (this.atamper.Checked)
				{
					num = 39;
					goto IL_C3A;
				}
				goto IL_8F5;
				IL_CA1:
				if (this.aildasm.Checked)
				{
					num = 36;
					goto IL_CBD;
				}
				goto IL_C1E;
				IL_EE2:
				if (this.adump.Checked)
				{
					num = 27;
					goto IL_EFE;
				}
				goto IL_CA1;
				IL_128C:
				if (this.adebug.Checked)
				{
					num = 23;
					goto IL_12A8;
				}
				goto IL_EE2;
				IL_1586:
				if (this.fobf.Checked)
				{
					num = 92;
					goto IL_15A2;
				}
				goto IL_29A;
				IL_6BE:
				moduleWriterOptions.MetaDataOptions.Flags = MetaDataFlags.PreserveAll;
				num = 106;
				goto IL_6DA;
				IL_600:
				if (this.packer.Checked)
				{
					num = 139;
					goto IL_61C;
				}
				goto IL_4E1;
				IL_43B:
				if (this.apacker.Checked)
				{
					num = 136;
					goto IL_457;
				}
				goto IL_600;
				IL_5CE:
				if (this.assembly.EndsWith(".dll"))
				{
					num = 123;
					goto IL_5EF;
				}
				break;
				IL_4E1:
				context = null;
				num = 144;
				goto IL_4EF;
				IL_3C6:
				AntiDumpMethod3.InjectEraseMethod(moduleDefMD);
				num = 33;
				goto IL_3D8;
				IL_29A:
				if (this.invalidmd.Checked)
				{
					num = 95;
					goto IL_2B6;
				}
				IL_1BB:
				Watermark.Execute(moduleDefMD);
				num = 98;
				goto IL_1CD;
				IL_198:
				AntiDumpMethod3.InjectEraseMethod(moduleDefMD);
				num = 30;
				goto IL_1AA;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001F404 File Offset: 0x0001D604
		private void cflow_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			while (num != 3)
			{
				if (num == 4)
				{
					goto IL_3A;
				}
				IL_56:
				if (num == 1)
				{
					if (!this.cflow.Checked)
					{
						goto IL_3A;
					}
					num = 2;
				}
				if (num == 2)
				{
					this.cflowTrackBar.Enabled = true;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					return;
				}
				continue;
				IL_3A:
				this.cflowTrackBar.Enabled = false;
				num = 5;
				goto IL_56;
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		private void cflowTrackBar_Scroll(object sender, ScrollEventArgs e)
		{
			short num = 0;
			for (;;)
			{
				if (num == 13)
				{
					goto IL_1F;
				}
				IL_40:
				if (num == 9)
				{
					this.cflowStatus.Text = "Normal";
					num = 10;
				}
				if (num == 14)
				{
					xd.cflowint = 5;
					num = 15;
				}
				if (num == 7)
				{
					goto IL_A2;
				}
				goto IL_C3;
				IL_29D:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					break;
				}
				continue;
				IL_127:
				if (num == 11)
				{
					xd.cflowint = 4;
					num = 12;
				}
				if (num == 12)
				{
					this.cflowStatus.Text = "Aggressive";
					num = 13;
				}
				if (num == 2)
				{
					xd.cflowint = 1;
					num = 3;
				}
				if (num == 8)
				{
					xd.cflowint = 3;
					num = 9;
				}
				if (num == 5)
				{
					xd.cflowint = 2;
					num = 6;
				}
				if (num == 6)
				{
					this.cflowStatus.Text = "Minimum";
					num = 7;
				}
				if (num == 3)
				{
					this.cflowStatus.Text = "None";
					num = 4;
				}
				if (num == 15)
				{
					this.cflowStatus.Text = "Maximum";
					num = 16;
				}
				if (num == 4)
				{
					goto IL_27C;
				}
				goto IL_29D;
				IL_C3:
				if (num == 1)
				{
					if (this.cflowTrackBar.Value != 1)
					{
						goto IL_27C;
					}
					num = 2;
				}
				if (num != 10)
				{
					goto IL_127;
				}
				IL_106:
				if (this.cflowTrackBar.Value == 4)
				{
					num = 11;
					goto IL_127;
				}
				goto IL_1F;
				IL_A2:
				if (this.cflowTrackBar.Value == 3)
				{
					num = 8;
					goto IL_C3;
				}
				goto IL_106;
				IL_27C:
				if (this.cflowTrackBar.Value == 2)
				{
					num = 5;
					goto IL_29D;
				}
				goto IL_A2;
				IL_1F:
				if (this.cflowTrackBar.Value == 5)
				{
					num = 14;
					goto IL_40;
				}
				break;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		private void AsciiType_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					xd.renamertype = "Ascii";
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001F850 File Offset: 0x0001DA50
		private void NumbersType_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					xd.renamertype = "Numbers";
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
		private void ChineseType_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					xd.renamertype = "Chinese";
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001F940 File Offset: 0x0001DB40
		private void SymbolsType_CheckedChanged(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					xd.renamertype = "Symbols";
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
		private void BrowseSNK_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				OpenFileDialog openFileDialog;
				if (num == 7)
				{
					this.assembly = openFileDialog.FileName;
					num = 8;
				}
				if (num == 1)
				{
					openFileDialog = new OpenFileDialog();
					num = 2;
				}
				if (num == 5)
				{
					if (openFileDialog.ShowDialog() != DialogResult.OK)
					{
						break;
					}
					num = 6;
				}
				if (num == 8)
				{
					this.SNKText.Text = openFileDialog.FileName;
					num = 9;
				}
				if (num == 2)
				{
					openFileDialog.Title = "Load Assembly";
					num = 3;
				}
				if (num == 4)
				{
					openFileDialog.Multiselect = false;
					num = 5;
				}
				if (num == 3)
				{
					openFileDialog.Filter = "Strong name key (*.snk)|*.snk";
					num = 4;
				}
				if (num == 6)
				{
					this.log.Items.Clear();
					num = 7;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001FB5C File Offset: 0x0001DD5C
		private void SNKText_DragDrop(object sender, DragEventArgs e)
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
				Array array = (Array)e.Data.GetData(DataFormats.FileDrop);
				if (array != null)
				{
					string text = array.GetValue(0).ToString();
					int num2 = text.LastIndexOf(".");
					int startIndex = text.LastIndexOf("\\");
					if (num2 != -1)
					{
						string text2 = text.Substring(num2);
						text2 = text2.ToLower();
						if (text2 == ".snk")
						{
							base.Activate();
							this.SNKText.Text = text;
							string text3 = text.Substring(startIndex);
							this.log.Items.Clear();
							this.log.SelectedIndex = 0;
						}
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please load .snk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.SNKText.Clear();
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001FCE4 File Offset: 0x0001DEE4
		private void SNKText_DragEnter(object sender, DragEventArgs e)
		{
			short num = 0;
			for (;;)
			{
				if (num == 2)
				{
					e.Effect = DragDropEffects.Copy;
					num = 3;
				}
				if (num != 1)
				{
					goto IL_68;
				}
				if (e.Data.GetDataPresent(DataFormats.FileDrop))
				{
					num = 2;
					goto IL_68;
				}
				goto IL_94;
				IL_AB:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					return;
				}
				continue;
				IL_68:
				if (num == 3)
				{
					break;
				}
				if (num != 4)
				{
					goto IL_AB;
				}
				IL_94:
				e.Effect = DragDropEffects.None;
				num = 5;
				goto IL_AB;
			}
		}

		// Token: 0x04000087 RID: 135
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000088 RID: 136
		public const int HT_CAPTION = 2;

		// Token: 0x04000089 RID: 137
		private string assembly;
	}
}

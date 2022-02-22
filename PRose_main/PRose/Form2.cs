using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using ns1;

namespace PRose
{
	// Token: 0x02000077 RID: 119
	public partial class Form2 : Form
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x00002680 File Offset: 0x00000880
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00033060 File Offset: 0x00031260
		private void Form2_Load(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					base.Opacity = 0.9;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000330E0 File Offset: 0x000312E0
		private void obfuscate_Click(object sender, EventArgs e)
		{
			short num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				if (num == 3)
				{
					Form form;
					form.Show();
					num = 4;
				}
				if (num == 2)
				{
					Form form = new Form1();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001BFDC File Offset: 0x0001A1DC
		private void siticoneButton1_Click(object sender, EventArgs e)
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
	}
}

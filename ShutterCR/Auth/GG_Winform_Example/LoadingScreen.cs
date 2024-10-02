using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace Auth.GG_Winform_Example
{
	public partial class LoadingScreen : Form
	{
		public LoadingScreen()
		{
			InitializeComponent();
		}

		private void lrHG20CGA4(object sender, EventArgs e)
		{
			this.panel2.Width += 3;
			if (this.panel2.Width > 700)
			{
				this.timer1.Stop();
				Login login = new Login();
				login.Show();
				base.Hide();
			}
		}

		private void bMFGivT61k(object sender, EventArgs e)
		{
		}

		private void DrjGxUIRGU(object sender, EventArgs e)
		{
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void KVXGEPft1K(object sender, MouseEventArgs e)
		{
			this.tgjaRCrMyC = new Point(e.X, e.Y);
		}

		private void lesGnjhNL0(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - this.tgjaRCrMyC.X;
				base.Top += e.Y - this.tgjaRCrMyC.Y;
			}
		}

		private void OPkGzYVHEE(object sender, EventArgs e)
		{
		}

	}
}

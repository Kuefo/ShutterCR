using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Auth.GG_Winform_Example
{
	public partial class Register : Form
	{
		public Register()
		{
			InitializeComponent();
		}

		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			base.Hide();
			Login login = new Login();
			login.Show();
		}

		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			
		}

		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{

		}

		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("If you need a license Contact Read On Discord\n\nDiscord: Read#4363", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void pwMmv0UGaj(object sender, EventArgs e)
		{

		}

		private void siticoneImageButton1_Click(object sender, EventArgs e)
		{

		}
	}
}

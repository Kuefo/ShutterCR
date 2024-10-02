using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Auth.GG_Winform_Example
{
	public partial class Login : Form
	{
		public Login()
		{
            InitializeComponent();
		}

		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			base.Hide();
			Register register = new Register();
			register.Show();
		}

		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Main main = new Main();
			main.Show();
			base.Hide();
		}

		private void PkImT3OKDH(object sender, EventArgs e)
		{

		}

        private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Main main = new Main();
            main.Show();
            base.Hide();
        }
    }
}

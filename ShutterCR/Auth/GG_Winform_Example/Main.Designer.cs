using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Siticone.Desktop.UI.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
    partial class Main 
	{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation2 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.variable = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.email = new Siticone.UI.WinForms.SiticoneLabel();
            this.hwid = new Siticone.UI.WinForms.SiticoneLabel();
            this.uservariable = new Siticone.UI.WinForms.SiticoneLabel();
            this.userrank = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel7 = new Siticone.UI.WinForms.SiticoneLabel();
            this.expiry = new Siticone.UI.WinForms.SiticoneLabel();
            this.ip = new Siticone.UI.WinForms.SiticoneLabel();
            this.welcome = new Siticone.UI.WinForms.SiticoneLabel();
            this.lastlogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.registerdate = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel5 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel6 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.siticoneTrackBar1 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.siticoneRoundedTextBox44 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox42 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton109 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.siticoneLabel24 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel25 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneRoundedButton165 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton10 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton9 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton8 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton7 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton6 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton5 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox2 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton4 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox1 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton3 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneLabel23 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel22 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel21 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel20 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel19 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel18 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel17 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel16 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel15 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel14 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.siticoneLabel13 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel12 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel11 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel10 = new Siticone.UI.WinForms.SiticoneLabel();
            this.WelcomeText = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneLabel8 = new Siticone.UI.WinForms.SiticoneLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.siticoneRoundedButton168 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton125 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox11 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton105 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton59 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton49 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton54 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton55 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton56 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton57 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton58 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton47 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton48 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton50 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton51 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton52 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton53 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton43 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton44 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton45 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton46 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton40 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton39 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox9 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton38 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox7 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton36 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton37 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton34 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton35 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton32 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton33 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton30 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton31 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox8 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton29 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox6 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton27 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton26 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton25 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton24 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton23 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton22 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton21 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton20 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton19 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton18 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton17 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton16 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton15 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneCheckBox5 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox4 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox3 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox2 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticoneRoundedButton14 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox4 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton13 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox3 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.siticoneRoundedButton101 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox35 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton74 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton73 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton72 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton71 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton70 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton69 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton68 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton67 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton65 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton64 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox23 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox24 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox25 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox26 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox27 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox28 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox29 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox30 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox31 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox32 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton62 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton63 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox33 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox22 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox21 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox20 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox19 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox18 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox17 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox16 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox15 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox14 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox13 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton61 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton60 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox12 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton163 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton161 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton162 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton160 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton159 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton158 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton157 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton156 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton155 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton154 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton153 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton152 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton151 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton150 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton149 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton148 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton147 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton146 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton145 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton144 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton143 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton142 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton141 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton140 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton139 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton138 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton137 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton136 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton135 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton42 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton131 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.siticoneRoundedButton164 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton134 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton41 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox10 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton115 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox40 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton117 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox41 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedTextBox36 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton123 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton124 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton121 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton122 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton119 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton120 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton118 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton116 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton111 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton114 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton113 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton112 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton110 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton104 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton100 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton76 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton98 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton99 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton96 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton97 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton95 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton94 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton93 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton92 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton91 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton90 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton89 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton88 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton87 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton86 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton85 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton84 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton83 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton81 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton80 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton79 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton78 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton77 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton75 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton66 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.siticoneRoundedButton28 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox5 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton12 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton11 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.siticoneRoundedButton166 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton171 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.siticoneRoundedButton172 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton130 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton132 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton133 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton129 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton128 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton127 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton126 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox39 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton103 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox38 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton82 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox34 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton102 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox37 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.siticoneRoundedButton108 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton107 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton106 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.siticoneShadowForm1 = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.siticoneTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1023, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(978, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.siticoneTransition1.DefaultAnimation = animation2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Shutter CR | Rekt By Heaventh";
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton2.BorderThickness = 1;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(6, 6);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton2.TabIndex = 28;
            this.siticoneRoundedButton2.Text = "Connect To Console";
            this.siticoneRoundedButton2.Click += new System.EventHandler(this.siticoneRoundedButton2_Click);
            // 
            // variable
            // 
            this.variable.AllowDrop = true;
            this.variable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.variable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.variable, Siticone.UI.AnimatorNS.DecorationType.None);
            this.variable.DefaultText = "XNotify";
            this.variable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.variable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.variable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.variable.DisabledState.Parent = this.variable;
            this.variable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.variable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.variable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variable.FocusedState.Parent = this.variable;
            this.variable.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variable.HoveredState.Parent = this.variable;
            this.variable.Location = new System.Drawing.Point(13, 502);
            this.variable.Margin = new System.Windows.Forms.Padding(4);
            this.variable.Name = "variable";
            this.variable.PasswordChar = '\0';
            this.variable.PlaceholderText = "";
            this.variable.SelectedText = "";
            this.variable.ShadowDecoration.Parent = this.variable;
            this.variable.Size = new System.Drawing.Size(146, 24);
            this.variable.TabIndex = 36;
            this.variable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.email, Siticone.UI.AnimatorNS.DecorationType.None);
            this.email.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(825, 286);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(3, 2);
            this.email.TabIndex = 39;
            this.email.Text = null;
            // 
            // hwid
            // 
            this.hwid.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.hwid, Siticone.UI.AnimatorNS.DecorationType.None);
            this.hwid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hwid.Location = new System.Drawing.Point(825, 306);
            this.hwid.Margin = new System.Windows.Forms.Padding(2);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(3, 2);
            this.hwid.TabIndex = 40;
            this.hwid.Text = null;
            // 
            // uservariable
            // 
            this.uservariable.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.uservariable, Siticone.UI.AnimatorNS.DecorationType.None);
            this.uservariable.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uservariable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uservariable.Location = new System.Drawing.Point(825, 326);
            this.uservariable.Margin = new System.Windows.Forms.Padding(2);
            this.uservariable.Name = "uservariable";
            this.uservariable.Size = new System.Drawing.Size(3, 2);
            this.uservariable.TabIndex = 41;
            this.uservariable.Text = null;
            // 
            // userrank
            // 
            this.userrank.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.userrank, Siticone.UI.AnimatorNS.DecorationType.None);
            this.userrank.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userrank.Location = new System.Drawing.Point(825, 347);
            this.userrank.Margin = new System.Windows.Forms.Padding(2);
            this.userrank.Name = "userrank";
            this.userrank.Size = new System.Drawing.Size(3, 2);
            this.userrank.TabIndex = 42;
            this.userrank.Text = null;
            // 
            // siticoneLabel7
            // 
            this.siticoneLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel7.Location = new System.Drawing.Point(13, 35);
            this.siticoneLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel7.Name = "siticoneLabel7";
            this.siticoneLabel7.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel7.TabIndex = 58;
            this.siticoneLabel7.Text = "N/A";
            this.siticoneLabel7.Click += new System.EventHandler(this.siticoneLabel7_Click);
            // 
            // expiry
            // 
            this.expiry.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.expiry, Siticone.UI.AnimatorNS.DecorationType.None);
            this.expiry.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expiry.Location = new System.Drawing.Point(417, 3);
            this.expiry.Margin = new System.Windows.Forms.Padding(2);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(3, 2);
            this.expiry.TabIndex = 44;
            this.expiry.Text = null;
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.ip, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ip.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ip.Location = new System.Drawing.Point(211, 3);
            this.ip.Margin = new System.Windows.Forms.Padding(2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(3, 2);
            this.ip.TabIndex = 43;
            this.ip.Text = null;
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.welcome, Siticone.UI.AnimatorNS.DecorationType.None);
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcome.Location = new System.Drawing.Point(14, 3);
            this.welcome.Margin = new System.Windows.Forms.Padding(2);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(3, 2);
            this.welcome.TabIndex = 50;
            this.welcome.Text = null;
            // 
            // lastlogin
            // 
            this.lastlogin.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.lastlogin, Siticone.UI.AnimatorNS.DecorationType.None);
            this.lastlogin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastlogin.Location = new System.Drawing.Point(582, 3);
            this.lastlogin.Margin = new System.Windows.Forms.Padding(2);
            this.lastlogin.Name = "lastlogin";
            this.lastlogin.Size = new System.Drawing.Size(3, 2);
            this.lastlogin.TabIndex = 45;
            this.lastlogin.Text = null;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel1.Location = new System.Drawing.Point(134, 3);
            this.siticoneLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(6, 14);
            this.siticoneLabel1.TabIndex = 52;
            this.siticoneLabel1.Text = "|";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel2.Location = new System.Drawing.Point(361, 3);
            this.siticoneLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(6, 14);
            this.siticoneLabel2.TabIndex = 53;
            this.siticoneLabel2.Text = "|";
            // 
            // registerdate
            // 
            this.registerdate.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.registerdate, Siticone.UI.AnimatorNS.DecorationType.None);
            this.registerdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerdate.Location = new System.Drawing.Point(748, 3);
            this.registerdate.Margin = new System.Windows.Forms.Padding(2);
            this.registerdate.Name = "registerdate";
            this.registerdate.Size = new System.Drawing.Size(3, 2);
            this.registerdate.TabIndex = 46;
            this.registerdate.Text = null;
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel3.Location = new System.Drawing.Point(537, 3);
            this.siticoneLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(6, 14);
            this.siticoneLabel3.TabIndex = 54;
            this.siticoneLabel3.Text = "|";
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel4.Location = new System.Drawing.Point(696, 3);
            this.siticoneLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(6, 14);
            this.siticoneLabel4.TabIndex = 55;
            this.siticoneLabel4.Text = "|";
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel5.Location = new System.Drawing.Point(851, 2);
            this.siticoneLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(6, 14);
            this.siticoneLabel5.TabIndex = 56;
            this.siticoneLabel5.Text = "|";
            // 
            // siticoneLabel6
            // 
            this.siticoneLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel6.Location = new System.Drawing.Point(887, 3);
            this.siticoneLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel6.Name = "siticoneLabel6";
            this.siticoneLabel6.Size = new System.Drawing.Size(3, 2);
            this.siticoneLabel6.TabIndex = 57;
            this.siticoneLabel6.Text = null;
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.siticoneTabControl1.Controls.Add(this.tabPage1);
            this.siticoneTabControl1.Controls.Add(this.tabPage2);
            this.siticoneTabControl1.Controls.Add(this.tabPage3);
            this.siticoneTabControl1.Controls.Add(this.tabPage8);
            this.siticoneTabControl1.Controls.Add(this.tabPage5);
            this.siticoneTabControl1.Controls.Add(this.tabPage4);
            this.siticoneTabControl1.Controls.Add(this.tabPage6);
            this.siticoneTabControl1.Controls.Add(this.tabPage7);
            this.siticoneTransition1.SetDecoration(this.siticoneTabControl1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.Location = new System.Drawing.Point(2, 33);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(1066, 548);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.TabIndex = 52;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage1.Controls.Add(this.siticoneTrackBar1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.siticoneRoundedTextBox44);
            this.tabPage1.Controls.Add(this.siticoneRoundedTextBox42);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton109);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.siticoneLabel24);
            this.tabPage1.Controls.Add(this.siticoneLabel25);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton165);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton10);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton9);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton8);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton7);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton6);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton5);
            this.tabPage1.Controls.Add(this.siticoneRoundedTextBox2);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton4);
            this.tabPage1.Controls.Add(this.siticoneRoundedTextBox1);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton3);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton1);
            this.tabPage1.Controls.Add(this.siticoneLabel23);
            this.tabPage1.Controls.Add(this.siticoneLabel22);
            this.tabPage1.Controls.Add(this.siticoneLabel21);
            this.tabPage1.Controls.Add(this.siticoneLabel20);
            this.tabPage1.Controls.Add(this.siticoneLabel19);
            this.tabPage1.Controls.Add(this.siticoneLabel18);
            this.tabPage1.Controls.Add(this.siticoneLabel17);
            this.tabPage1.Controls.Add(this.siticoneLabel16);
            this.tabPage1.Controls.Add(this.siticoneLabel15);
            this.tabPage1.Controls.Add(this.siticoneLabel14);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.siticoneLabel13);
            this.tabPage1.Controls.Add(this.siticoneLabel12);
            this.tabPage1.Controls.Add(this.siticoneLabel11);
            this.tabPage1.Controls.Add(this.siticoneLabel10);
            this.tabPage1.Controls.Add(this.WelcomeText);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.siticoneLabel8);
            this.tabPage1.Controls.Add(this.siticoneLabel7);
            this.tabPage1.Controls.Add(this.variable);
            this.tabPage1.Controls.Add(this.siticoneRoundedButton2);
            this.siticoneTransition1.SetDecoration(this.tabPage1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection/Commands";
            // 
            // siticoneTrackBar1
            // 
            this.siticoneTransition1.SetDecoration(this.siticoneTrackBar1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneTrackBar1.HoverState.Parent = this.siticoneTrackBar1;
            this.siticoneTrackBar1.Location = new System.Drawing.Point(14, 435);
            this.siticoneTrackBar1.Name = "siticoneTrackBar1";
            this.siticoneTrackBar1.Size = new System.Drawing.Size(254, 23);
            this.siticoneTrackBar1.TabIndex = 184;
            this.siticoneTrackBar1.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.siticoneTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siticoneTransition1.SetDecoration(this.textBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(657, 300);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 168);
            this.textBox1.TabIndex = 183;
            this.textBox1.Text = "Body Text";
            // 
            // siticoneRoundedTextBox44
            // 
            this.siticoneRoundedTextBox44.AllowDrop = true;
            this.siticoneRoundedTextBox44.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox44.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox44, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox44.DefaultText = "Button Text";
            this.siticoneRoundedTextBox44.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox44.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox44.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox44.DisabledState.Parent = this.siticoneRoundedTextBox44;
            this.siticoneRoundedTextBox44.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox44.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox44.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox44.FocusedState.Parent = this.siticoneRoundedTextBox44;
            this.siticoneRoundedTextBox44.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox44.HoveredState.Parent = this.siticoneRoundedTextBox44;
            this.siticoneRoundedTextBox44.Location = new System.Drawing.Point(657, 475);
            this.siticoneRoundedTextBox44.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox44.Name = "siticoneRoundedTextBox44";
            this.siticoneRoundedTextBox44.PasswordChar = '\0';
            this.siticoneRoundedTextBox44.PlaceholderText = "";
            this.siticoneRoundedTextBox44.SelectedText = "";
            this.siticoneRoundedTextBox44.ShadowDecoration.Parent = this.siticoneRoundedTextBox44;
            this.siticoneRoundedTextBox44.Size = new System.Drawing.Size(214, 24);
            this.siticoneRoundedTextBox44.TabIndex = 182;
            this.siticoneRoundedTextBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox42
            // 
            this.siticoneRoundedTextBox42.AllowDrop = true;
            this.siticoneRoundedTextBox42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox42.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox42, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox42.DefaultText = "Title Text";
            this.siticoneRoundedTextBox42.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox42.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox42.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox42.DisabledState.Parent = this.siticoneRoundedTextBox42;
            this.siticoneRoundedTextBox42.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox42.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox42.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox42.FocusedState.Parent = this.siticoneRoundedTextBox42;
            this.siticoneRoundedTextBox42.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox42.HoveredState.Parent = this.siticoneRoundedTextBox42;
            this.siticoneRoundedTextBox42.Location = new System.Drawing.Point(657, 269);
            this.siticoneRoundedTextBox42.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox42.Name = "siticoneRoundedTextBox42";
            this.siticoneRoundedTextBox42.PasswordChar = '\0';
            this.siticoneRoundedTextBox42.PlaceholderText = "";
            this.siticoneRoundedTextBox42.SelectedText = "";
            this.siticoneRoundedTextBox42.ShadowDecoration.Parent = this.siticoneRoundedTextBox42;
            this.siticoneRoundedTextBox42.Size = new System.Drawing.Size(214, 24);
            this.siticoneRoundedTextBox42.TabIndex = 180;
            this.siticoneRoundedTextBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton109
            // 
            this.siticoneRoundedButton109.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton109.BorderThickness = 1;
            this.siticoneRoundedButton109.CheckedState.Parent = this.siticoneRoundedButton109;
            this.siticoneRoundedButton109.CustomImages.Parent = this.siticoneRoundedButton109;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton109, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton109.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton109.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton109.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton109.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton109.HoveredState.Parent = this.siticoneRoundedButton109;
            this.siticoneRoundedButton109.Location = new System.Drawing.Point(691, 506);
            this.siticoneRoundedButton109.Name = "siticoneRoundedButton109";
            this.siticoneRoundedButton109.ShadowDecoration.Parent = this.siticoneRoundedButton109;
            this.siticoneRoundedButton109.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton109.TabIndex = 179;
            this.siticoneRoundedButton109.Text = "Send Box Text";
            this.siticoneRoundedButton109.Click += new System.EventHandler(this.siticoneRoundedButton109_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(273, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "50";
            // 
            // siticoneLabel24
            // 
            this.siticoneLabel24.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel24, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel24.Location = new System.Drawing.Point(13, 288);
            this.siticoneLabel24.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel24.Name = "siticoneLabel24";
            this.siticoneLabel24.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel24.TabIndex = 95;
            this.siticoneLabel24.Text = "N/A";
            // 
            // siticoneLabel25
            // 
            this.siticoneLabel25.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel25, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel25.Location = new System.Drawing.Point(655, 154);
            this.siticoneLabel25.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel25.Name = "siticoneLabel25";
            this.siticoneLabel25.Size = new System.Drawing.Size(25, 17);
            this.siticoneLabel25.TabIndex = 94;
            this.siticoneLabel25.Text = "N/A";
            // 
            // siticoneRoundedButton165
            // 
            this.siticoneRoundedButton165.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton165.BorderThickness = 1;
            this.siticoneRoundedButton165.CheckedState.Parent = this.siticoneRoundedButton165;
            this.siticoneRoundedButton165.CustomImages.Parent = this.siticoneRoundedButton165;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton165, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton165.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton165.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton165.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton165.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton165.HoveredState.Parent = this.siticoneRoundedButton165;
            this.siticoneRoundedButton165.Location = new System.Drawing.Point(13, 402);
            this.siticoneRoundedButton165.Name = "siticoneRoundedButton165";
            this.siticoneRoundedButton165.ShadowDecoration.Parent = this.siticoneRoundedButton165;
            this.siticoneRoundedButton165.Size = new System.Drawing.Size(255, 24);
            this.siticoneRoundedButton165.TabIndex = 175;
            this.siticoneRoundedButton165.Text = "Set Fan Speed";
            this.siticoneRoundedButton165.Click += new System.EventHandler(this.siticoneRoundedButton165_Click);
            // 
            // siticoneRoundedButton10
            // 
            this.siticoneRoundedButton10.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton10.BorderThickness = 1;
            this.siticoneRoundedButton10.CheckedState.Parent = this.siticoneRoundedButton10;
            this.siticoneRoundedButton10.CustomImages.Parent = this.siticoneRoundedButton10;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton10.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton10.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton10.HoveredState.Parent = this.siticoneRoundedButton10;
            this.siticoneRoundedButton10.Location = new System.Drawing.Point(495, 72);
            this.siticoneRoundedButton10.Name = "siticoneRoundedButton10";
            this.siticoneRoundedButton10.ShadowDecoration.Parent = this.siticoneRoundedButton10;
            this.siticoneRoundedButton10.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton10.TabIndex = 92;
            this.siticoneRoundedButton10.Text = "Close Discord";
            this.siticoneRoundedButton10.Click += new System.EventHandler(this.siticoneRoundedButton10_Click);
            // 
            // siticoneRoundedButton9
            // 
            this.siticoneRoundedButton9.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton9.BorderThickness = 1;
            this.siticoneRoundedButton9.CheckedState.Parent = this.siticoneRoundedButton9;
            this.siticoneRoundedButton9.CustomImages.Parent = this.siticoneRoundedButton9;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton9.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton9.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton9.HoveredState.Parent = this.siticoneRoundedButton9;
            this.siticoneRoundedButton9.Location = new System.Drawing.Point(343, 42);
            this.siticoneRoundedButton9.Name = "siticoneRoundedButton9";
            this.siticoneRoundedButton9.ShadowDecoration.Parent = this.siticoneRoundedButton9;
            this.siticoneRoundedButton9.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton9.TabIndex = 91;
            this.siticoneRoundedButton9.Text = "Cold Reboot Console";
            this.siticoneRoundedButton9.Click += new System.EventHandler(this.siticoneRoundedButton9_Click);
            // 
            // siticoneRoundedButton8
            // 
            this.siticoneRoundedButton8.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton8.BorderThickness = 1;
            this.siticoneRoundedButton8.CheckedState.Parent = this.siticoneRoundedButton8;
            this.siticoneRoundedButton8.CustomImages.Parent = this.siticoneRoundedButton8;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton8.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton8.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton8.HoveredState.Parent = this.siticoneRoundedButton8;
            this.siticoneRoundedButton8.Location = new System.Drawing.Point(495, 42);
            this.siticoneRoundedButton8.Name = "siticoneRoundedButton8";
            this.siticoneRoundedButton8.ShadowDecoration.Parent = this.siticoneRoundedButton8;
            this.siticoneRoundedButton8.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton8.TabIndex = 90;
            this.siticoneRoundedButton8.Text = "Shut Down Console";
            this.siticoneRoundedButton8.Click += new System.EventHandler(this.siticoneRoundedButton8_Click);
            // 
            // siticoneRoundedButton7
            // 
            this.siticoneRoundedButton7.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton7.BorderThickness = 1;
            this.siticoneRoundedButton7.CheckedState.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.CustomImages.Parent = this.siticoneRoundedButton7;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton7.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton7.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton7.HoveredState.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.Location = new System.Drawing.Point(343, 12);
            this.siticoneRoundedButton7.Name = "siticoneRoundedButton7";
            this.siticoneRoundedButton7.ShadowDecoration.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton7.TabIndex = 89;
            this.siticoneRoundedButton7.Text = "Colours";
            this.siticoneRoundedButton7.Click += new System.EventHandler(this.siticoneRoundedButton7_Click);
            // 
            // siticoneRoundedButton6
            // 
            this.siticoneRoundedButton6.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton6.BorderThickness = 1;
            this.siticoneRoundedButton6.CheckedState.Parent = this.siticoneRoundedButton6;
            this.siticoneRoundedButton6.CustomImages.Parent = this.siticoneRoundedButton6;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton6.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton6.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton6.HoveredState.Parent = this.siticoneRoundedButton6;
            this.siticoneRoundedButton6.Location = new System.Drawing.Point(495, 12);
            this.siticoneRoundedButton6.Name = "siticoneRoundedButton6";
            this.siticoneRoundedButton6.ShadowDecoration.Parent = this.siticoneRoundedButton6;
            this.siticoneRoundedButton6.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton6.TabIndex = 88;
            this.siticoneRoundedButton6.Text = "Fake RROD";
            this.siticoneRoundedButton6.Click += new System.EventHandler(this.siticoneRoundedButton6_Click);
            // 
            // siticoneRoundedButton5
            // 
            this.siticoneRoundedButton5.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton5.BorderThickness = 1;
            this.siticoneRoundedButton5.CheckedState.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.CustomImages.Parent = this.siticoneRoundedButton5;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton5.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton5.HoveredState.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.Location = new System.Drawing.Point(165, 471);
            this.siticoneRoundedButton5.Name = "siticoneRoundedButton5";
            this.siticoneRoundedButton5.ShadowDecoration.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton5.TabIndex = 87;
            this.siticoneRoundedButton5.Text = "Send Server Command";
            this.siticoneRoundedButton5.Click += new System.EventHandler(this.siticoneRoundedButton5_Click);
            // 
            // siticoneRoundedTextBox2
            // 
            this.siticoneRoundedTextBox2.AllowDrop = true;
            this.siticoneRoundedTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox2.DefaultText = "Server Command";
            this.siticoneRoundedTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox2.DisabledState.Parent = this.siticoneRoundedTextBox2;
            this.siticoneRoundedTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox2.FocusedState.Parent = this.siticoneRoundedTextBox2;
            this.siticoneRoundedTextBox2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox2.HoveredState.Parent = this.siticoneRoundedTextBox2;
            this.siticoneRoundedTextBox2.Location = new System.Drawing.Point(165, 502);
            this.siticoneRoundedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox2.Name = "siticoneRoundedTextBox2";
            this.siticoneRoundedTextBox2.PasswordChar = '\0';
            this.siticoneRoundedTextBox2.PlaceholderText = "";
            this.siticoneRoundedTextBox2.SelectedText = "";
            this.siticoneRoundedTextBox2.ShadowDecoration.Parent = this.siticoneRoundedTextBox2;
            this.siticoneRoundedTextBox2.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox2.TabIndex = 86;
            this.siticoneRoundedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton4
            // 
            this.siticoneRoundedButton4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton4.BorderThickness = 1;
            this.siticoneRoundedButton4.CheckedState.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.CustomImages.Parent = this.siticoneRoundedButton4;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton4.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton4.HoveredState.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.Location = new System.Drawing.Point(317, 471);
            this.siticoneRoundedButton4.Name = "siticoneRoundedButton4";
            this.siticoneRoundedButton4.ShadowDecoration.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton4.TabIndex = 85;
            this.siticoneRoundedButton4.Text = "Send Console Command";
            this.siticoneRoundedButton4.Click += new System.EventHandler(this.siticoneRoundedButton4_Click);
            // 
            // siticoneRoundedTextBox1
            // 
            this.siticoneRoundedTextBox1.AllowDrop = true;
            this.siticoneRoundedTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox1.DefaultText = "Console Command";
            this.siticoneRoundedTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox1.DisabledState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox1.FocusedState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox1.HoveredState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.Location = new System.Drawing.Point(317, 502);
            this.siticoneRoundedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox1.Name = "siticoneRoundedTextBox1";
            this.siticoneRoundedTextBox1.PasswordChar = '\0';
            this.siticoneRoundedTextBox1.PlaceholderText = "";
            this.siticoneRoundedTextBox1.SelectedText = "";
            this.siticoneRoundedTextBox1.ShadowDecoration.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox1.TabIndex = 84;
            this.siticoneRoundedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton3
            // 
            this.siticoneRoundedButton3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton3.BorderThickness = 1;
            this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton3.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Location = new System.Drawing.Point(158, 6);
            this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
            this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Size = new System.Drawing.Size(53, 24);
            this.siticoneRoundedButton3.TabIndex = 83;
            this.siticoneRoundedButton3.Text = "Refesh";
            this.siticoneRoundedButton3.Click += new System.EventHandler(this.siticoneRoundedButton3_Click);
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton1.BorderThickness = 1;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(13, 471);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton1.TabIndex = 82;
            this.siticoneRoundedButton1.Text = "Send XNotify";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // siticoneLabel23
            // 
            this.siticoneLabel23.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel23, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel23.Location = new System.Drawing.Point(13, 265);
            this.siticoneLabel23.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel23.Name = "siticoneLabel23";
            this.siticoneLabel23.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel23.TabIndex = 80;
            this.siticoneLabel23.Text = "N/A";
            // 
            // siticoneLabel22
            // 
            this.siticoneLabel22.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel22, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel22.Location = new System.Drawing.Point(13, 242);
            this.siticoneLabel22.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel22.Name = "siticoneLabel22";
            this.siticoneLabel22.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel22.TabIndex = 79;
            this.siticoneLabel22.Text = "N/A";
            // 
            // siticoneLabel21
            // 
            this.siticoneLabel21.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel21, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel21.Location = new System.Drawing.Point(13, 219);
            this.siticoneLabel21.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel21.Name = "siticoneLabel21";
            this.siticoneLabel21.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel21.TabIndex = 78;
            this.siticoneLabel21.Text = "N/A";
            // 
            // siticoneLabel20
            // 
            this.siticoneLabel20.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel20, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel20.Location = new System.Drawing.Point(13, 196);
            this.siticoneLabel20.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel20.Name = "siticoneLabel20";
            this.siticoneLabel20.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel20.TabIndex = 77;
            this.siticoneLabel20.Text = "N/A";
            // 
            // siticoneLabel19
            // 
            this.siticoneLabel19.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel19, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel19.Location = new System.Drawing.Point(13, 173);
            this.siticoneLabel19.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel19.Name = "siticoneLabel19";
            this.siticoneLabel19.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel19.TabIndex = 76;
            this.siticoneLabel19.Text = "N/A";
            // 
            // siticoneLabel18
            // 
            this.siticoneLabel18.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel18, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel18.Location = new System.Drawing.Point(13, 150);
            this.siticoneLabel18.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel18.Name = "siticoneLabel18";
            this.siticoneLabel18.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel18.TabIndex = 75;
            this.siticoneLabel18.Text = "N/A";
            // 
            // siticoneLabel17
            // 
            this.siticoneLabel17.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel17, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel17.Location = new System.Drawing.Point(13, 127);
            this.siticoneLabel17.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel17.Name = "siticoneLabel17";
            this.siticoneLabel17.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel17.TabIndex = 74;
            this.siticoneLabel17.Text = "N/A";
            // 
            // siticoneLabel16
            // 
            this.siticoneLabel16.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel16, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel16.Location = new System.Drawing.Point(13, 104);
            this.siticoneLabel16.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel16.Name = "siticoneLabel16";
            this.siticoneLabel16.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel16.TabIndex = 73;
            this.siticoneLabel16.Text = "N/A";
            // 
            // siticoneLabel15
            // 
            this.siticoneLabel15.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel15, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel15.Location = new System.Drawing.Point(13, 81);
            this.siticoneLabel15.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel15.Name = "siticoneLabel15";
            this.siticoneLabel15.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel15.TabIndex = 72;
            this.siticoneLabel15.Text = "N/A";
            // 
            // siticoneLabel14
            // 
            this.siticoneLabel14.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel14, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel14.Location = new System.Drawing.Point(13, 58);
            this.siticoneLabel14.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel14.Name = "siticoneLabel14";
            this.siticoneLabel14.Size = new System.Drawing.Size(28, 19);
            this.siticoneLabel14.TabIndex = 71;
            this.siticoneLabel14.Text = "N/A";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.siticoneTransition1.SetDecoration(this.panel7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel7.Location = new System.Drawing.Point(647, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(224, 3);
            this.panel7.TabIndex = 62;
            // 
            // siticoneLabel13
            // 
            this.siticoneLabel13.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel13, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel13.Location = new System.Drawing.Point(655, 70);
            this.siticoneLabel13.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel13.Name = "siticoneLabel13";
            this.siticoneLabel13.Size = new System.Drawing.Size(25, 17);
            this.siticoneLabel13.TabIndex = 70;
            this.siticoneLabel13.Text = "N/A";
            // 
            // siticoneLabel12
            // 
            this.siticoneLabel12.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel12.Location = new System.Drawing.Point(655, 91);
            this.siticoneLabel12.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel12.Name = "siticoneLabel12";
            this.siticoneLabel12.Size = new System.Drawing.Size(25, 17);
            this.siticoneLabel12.TabIndex = 69;
            this.siticoneLabel12.Text = "N/A";
            // 
            // siticoneLabel11
            // 
            this.siticoneLabel11.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel11.Location = new System.Drawing.Point(655, 112);
            this.siticoneLabel11.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel11.Name = "siticoneLabel11";
            this.siticoneLabel11.Size = new System.Drawing.Size(25, 17);
            this.siticoneLabel11.TabIndex = 68;
            this.siticoneLabel11.Text = "N/A";
            // 
            // siticoneLabel10
            // 
            this.siticoneLabel10.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel10.Location = new System.Drawing.Point(655, 133);
            this.siticoneLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel10.Name = "siticoneLabel10";
            this.siticoneLabel10.Size = new System.Drawing.Size(25, 17);
            this.siticoneLabel10.TabIndex = 67;
            this.siticoneLabel10.Text = "N/A";
            // 
            // WelcomeText
            // 
            this.WelcomeText.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.WelcomeText, Siticone.UI.AnimatorNS.DecorationType.None);
            this.WelcomeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WelcomeText.Location = new System.Drawing.Point(655, 49);
            this.WelcomeText.Margin = new System.Windows.Forms.Padding(2);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(25, 17);
            this.WelcomeText.TabIndex = 66;
            this.WelcomeText.Text = "N/A";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.siticoneTransition1.SetDecoration(this.panel6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(869, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 134);
            this.panel6.TabIndex = 65;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.siticoneTransition1.SetDecoration(this.panel5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(647, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 134);
            this.panel5.TabIndex = 64;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.siticoneTransition1.SetDecoration(this.panel4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(869, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 37);
            this.panel4.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.siticoneTransition1.SetDecoration(this.panel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(647, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 37);
            this.panel3.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.siticoneTransition1.SetDecoration(this.panel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(647, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 3);
            this.panel2.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.siticoneTransition1.SetDecoration(this.panel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(648, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 3);
            this.panel1.TabIndex = 60;
            // 
            // siticoneLabel8
            // 
            this.siticoneLabel8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel8.Location = new System.Drawing.Point(721, 14);
            this.siticoneLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel8.Name = "siticoneLabel8";
            this.siticoneLabel8.Size = new System.Drawing.Size(88, 22);
            this.siticoneLabel8.TabIndex = 59;
            this.siticoneLabel8.Text = "Information";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage2.Controls.Add(this.siticoneRoundedButton168);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton125);
            this.tabPage2.Controls.Add(this.siticoneRoundedTextBox11);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton105);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton59);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton49);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton54);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton55);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton56);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton57);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton58);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton47);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton48);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton50);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton51);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton52);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton53);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton43);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton44);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton45);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton46);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton40);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton39);
            this.tabPage2.Controls.Add(this.siticoneRoundedTextBox9);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton38);
            this.tabPage2.Controls.Add(this.siticoneRoundedTextBox7);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton36);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton37);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton34);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton35);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton32);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton33);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton30);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton31);
            this.tabPage2.Controls.Add(this.siticoneRoundedTextBox8);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton29);
            this.tabPage2.Controls.Add(this.siticoneRoundedTextBox6);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton27);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton26);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton25);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton24);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton23);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton22);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton21);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton20);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton19);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton18);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton17);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton16);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton15);
            this.tabPage2.Controls.Add(this.siticoneCheckBox5);
            this.tabPage2.Controls.Add(this.siticoneCheckBox4);
            this.tabPage2.Controls.Add(this.siticoneCheckBox3);
            this.tabPage2.Controls.Add(this.siticoneCheckBox2);
            this.tabPage2.Controls.Add(this.siticoneCheckBox1);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton14);
            this.tabPage2.Controls.Add(this.siticoneRoundedTextBox4);
            this.tabPage2.Controls.Add(this.siticoneRoundedButton13);
            this.tabPage2.Controls.Add(this.siticoneRoundedTextBox3);
            this.siticoneTransition1.SetDecoration(this.tabPage2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main";
            // 
            // siticoneRoundedButton168
            // 
            this.siticoneRoundedButton168.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton168.BorderThickness = 1;
            this.siticoneRoundedButton168.CheckedState.Parent = this.siticoneRoundedButton168;
            this.siticoneRoundedButton168.CustomImages.Parent = this.siticoneRoundedButton168;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton168, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton168.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton168.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton168.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton168.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton168.HoveredState.Parent = this.siticoneRoundedButton168;
            this.siticoneRoundedButton168.Location = new System.Drawing.Point(158, 452);
            this.siticoneRoundedButton168.Name = "siticoneRoundedButton168";
            this.siticoneRoundedButton168.ShadowDecoration.Parent = this.siticoneRoundedButton168;
            this.siticoneRoundedButton168.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton168.TabIndex = 151;
            this.siticoneRoundedButton168.Text = "Create Party";
            this.siticoneRoundedButton168.Click += new System.EventHandler(this.siticoneRoundedButton168_Click);
            // 
            // siticoneRoundedButton125
            // 
            this.siticoneRoundedButton125.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton125.BorderThickness = 1;
            this.siticoneRoundedButton125.CheckedState.Parent = this.siticoneRoundedButton125;
            this.siticoneRoundedButton125.CustomImages.Parent = this.siticoneRoundedButton125;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton125, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton125.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton125.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton125.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton125.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton125.HoveredState.Parent = this.siticoneRoundedButton125;
            this.siticoneRoundedButton125.Location = new System.Drawing.Point(454, 15);
            this.siticoneRoundedButton125.Name = "siticoneRoundedButton125";
            this.siticoneRoundedButton125.ShadowDecoration.Parent = this.siticoneRoundedButton125;
            this.siticoneRoundedButton125.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton125.TabIndex = 148;
            this.siticoneRoundedButton125.Text = "Set Clan Tag";
            this.siticoneRoundedButton125.Click += new System.EventHandler(this.siticoneRoundedButton125_Click);
            // 
            // siticoneRoundedTextBox11
            // 
            this.siticoneRoundedTextBox11.AllowDrop = true;
            this.siticoneRoundedTextBox11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox11.DefaultText = "Clan Tag";
            this.siticoneRoundedTextBox11.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox11.DisabledState.Parent = this.siticoneRoundedTextBox11;
            this.siticoneRoundedTextBox11.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox11.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox11.FocusedState.Parent = this.siticoneRoundedTextBox11;
            this.siticoneRoundedTextBox11.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox11.HoveredState.Parent = this.siticoneRoundedTextBox11;
            this.siticoneRoundedTextBox11.Location = new System.Drawing.Point(454, 46);
            this.siticoneRoundedTextBox11.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox11.Name = "siticoneRoundedTextBox11";
            this.siticoneRoundedTextBox11.PasswordChar = '\0';
            this.siticoneRoundedTextBox11.PlaceholderText = "";
            this.siticoneRoundedTextBox11.SelectedText = "";
            this.siticoneRoundedTextBox11.ShadowDecoration.Parent = this.siticoneRoundedTextBox11;
            this.siticoneRoundedTextBox11.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox11.TabIndex = 147;
            this.siticoneRoundedTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton105
            // 
            this.siticoneRoundedButton105.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton105.BorderThickness = 1;
            this.siticoneRoundedButton105.CheckedState.Parent = this.siticoneRoundedButton105;
            this.siticoneRoundedButton105.CustomImages.Parent = this.siticoneRoundedButton105;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton105, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton105.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton105.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton105.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton105.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton105.HoveredState.Parent = this.siticoneRoundedButton105;
            this.siticoneRoundedButton105.Location = new System.Drawing.Point(6, 452);
            this.siticoneRoundedButton105.Name = "siticoneRoundedButton105";
            this.siticoneRoundedButton105.ShadowDecoration.Parent = this.siticoneRoundedButton105;
            this.siticoneRoundedButton105.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton105.TabIndex = 146;
            this.siticoneRoundedButton105.Text = "Freeze Host Count Down";
            this.siticoneRoundedButton105.Click += new System.EventHandler(this.siticoneRoundedButton105_Click);
            // 
            // siticoneRoundedButton59
            // 
            this.siticoneRoundedButton59.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton59.BorderThickness = 1;
            this.siticoneRoundedButton59.CheckedState.Parent = this.siticoneRoundedButton59;
            this.siticoneRoundedButton59.CustomImages.Parent = this.siticoneRoundedButton59;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton59, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton59.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton59.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton59.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton59.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton59.HoveredState.Parent = this.siticoneRoundedButton59;
            this.siticoneRoundedButton59.Location = new System.Drawing.Point(606, 45);
            this.siticoneRoundedButton59.Name = "siticoneRoundedButton59";
            this.siticoneRoundedButton59.ShadowDecoration.Parent = this.siticoneRoundedButton59;
            this.siticoneRoundedButton59.Size = new System.Drawing.Size(113, 24);
            this.siticoneRoundedButton59.TabIndex = 145;
            this.siticoneRoundedButton59.Text = "Lag Lobby";
            this.siticoneRoundedButton59.Click += new System.EventHandler(this.siticoneRoundedButton59_Click);
            // 
            // siticoneRoundedButton49
            // 
            this.siticoneRoundedButton49.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton49.BorderThickness = 1;
            this.siticoneRoundedButton49.CheckedState.Parent = this.siticoneRoundedButton49;
            this.siticoneRoundedButton49.CustomImages.Parent = this.siticoneRoundedButton49;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton49, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton49.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton49.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton49.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton49.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton49.HoveredState.Parent = this.siticoneRoundedButton49;
            this.siticoneRoundedButton49.Location = new System.Drawing.Point(470, 470);
            this.siticoneRoundedButton49.Name = "siticoneRoundedButton49";
            this.siticoneRoundedButton49.ShadowDecoration.Parent = this.siticoneRoundedButton49;
            this.siticoneRoundedButton49.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton49.TabIndex = 144;
            this.siticoneRoundedButton49.Text = "Lazar [OFF]";
            this.siticoneRoundedButton49.Click += new System.EventHandler(this.siticoneRoundedButton49_Click);
            // 
            // siticoneRoundedButton54
            // 
            this.siticoneRoundedButton54.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton54.BorderThickness = 1;
            this.siticoneRoundedButton54.CheckedState.Parent = this.siticoneRoundedButton54;
            this.siticoneRoundedButton54.CustomImages.Parent = this.siticoneRoundedButton54;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton54, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton54.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton54.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton54.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton54.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton54.HoveredState.Parent = this.siticoneRoundedButton54;
            this.siticoneRoundedButton54.Location = new System.Drawing.Point(318, 500);
            this.siticoneRoundedButton54.Name = "siticoneRoundedButton54";
            this.siticoneRoundedButton54.ShadowDecoration.Parent = this.siticoneRoundedButton54;
            this.siticoneRoundedButton54.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton54.TabIndex = 143;
            this.siticoneRoundedButton54.Text = "Red Boxes [OFF]";
            this.siticoneRoundedButton54.Click += new System.EventHandler(this.siticoneRoundedButton54_Click);
            // 
            // siticoneRoundedButton55
            // 
            this.siticoneRoundedButton55.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton55.BorderThickness = 1;
            this.siticoneRoundedButton55.CheckedState.Parent = this.siticoneRoundedButton55;
            this.siticoneRoundedButton55.CustomImages.Parent = this.siticoneRoundedButton55;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton55, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton55.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton55.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton55.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton55.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton55.HoveredState.Parent = this.siticoneRoundedButton55;
            this.siticoneRoundedButton55.Location = new System.Drawing.Point(318, 470);
            this.siticoneRoundedButton55.Name = "siticoneRoundedButton55";
            this.siticoneRoundedButton55.ShadowDecoration.Parent = this.siticoneRoundedButton55;
            this.siticoneRoundedButton55.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton55.TabIndex = 142;
            this.siticoneRoundedButton55.Text = "No Recoil [OFF]";
            this.siticoneRoundedButton55.Click += new System.EventHandler(this.siticoneRoundedButton55_Click);
            // 
            // siticoneRoundedButton56
            // 
            this.siticoneRoundedButton56.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton56.BorderThickness = 1;
            this.siticoneRoundedButton56.CheckedState.Parent = this.siticoneRoundedButton56;
            this.siticoneRoundedButton56.CustomImages.Parent = this.siticoneRoundedButton56;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton56, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton56.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton56.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton56.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton56.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton56.HoveredState.Parent = this.siticoneRoundedButton56;
            this.siticoneRoundedButton56.Location = new System.Drawing.Point(470, 500);
            this.siticoneRoundedButton56.Name = "siticoneRoundedButton56";
            this.siticoneRoundedButton56.ShadowDecoration.Parent = this.siticoneRoundedButton56;
            this.siticoneRoundedButton56.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton56.TabIndex = 141;
            this.siticoneRoundedButton56.Text = "No Sway [OFF]";
            this.siticoneRoundedButton56.Click += new System.EventHandler(this.siticoneRoundedButton56_Click);
            // 
            // siticoneRoundedButton57
            // 
            this.siticoneRoundedButton57.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton57.BorderThickness = 1;
            this.siticoneRoundedButton57.CheckedState.Parent = this.siticoneRoundedButton57;
            this.siticoneRoundedButton57.CustomImages.Parent = this.siticoneRoundedButton57;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton57, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton57.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton57.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton57.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton57.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton57.HoveredState.Parent = this.siticoneRoundedButton57;
            this.siticoneRoundedButton57.Location = new System.Drawing.Point(318, 440);
            this.siticoneRoundedButton57.Name = "siticoneRoundedButton57";
            this.siticoneRoundedButton57.ShadowDecoration.Parent = this.siticoneRoundedButton57;
            this.siticoneRoundedButton57.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton57.TabIndex = 140;
            this.siticoneRoundedButton57.Text = "Wall Hack [OFF]";
            this.siticoneRoundedButton57.Click += new System.EventHandler(this.siticoneRoundedButton57_Click);
            // 
            // siticoneRoundedButton58
            // 
            this.siticoneRoundedButton58.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton58.BorderThickness = 1;
            this.siticoneRoundedButton58.CheckedState.Parent = this.siticoneRoundedButton58;
            this.siticoneRoundedButton58.CustomImages.Parent = this.siticoneRoundedButton58;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton58, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton58.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton58.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton58.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton58.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton58.HoveredState.Parent = this.siticoneRoundedButton58;
            this.siticoneRoundedButton58.Location = new System.Drawing.Point(470, 440);
            this.siticoneRoundedButton58.Name = "siticoneRoundedButton58";
            this.siticoneRoundedButton58.ShadowDecoration.Parent = this.siticoneRoundedButton58;
            this.siticoneRoundedButton58.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton58.TabIndex = 139;
            this.siticoneRoundedButton58.Text = "VSAT [OFF]";
            this.siticoneRoundedButton58.Click += new System.EventHandler(this.siticoneRoundedButton58_Click);
            // 
            // siticoneRoundedButton47
            // 
            this.siticoneRoundedButton47.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton47.BorderThickness = 1;
            this.siticoneRoundedButton47.CheckedState.Parent = this.siticoneRoundedButton47;
            this.siticoneRoundedButton47.CustomImages.Parent = this.siticoneRoundedButton47;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton47, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton47.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton47.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton47.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton47.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton47.HoveredState.Parent = this.siticoneRoundedButton47;
            this.siticoneRoundedButton47.Location = new System.Drawing.Point(470, 362);
            this.siticoneRoundedButton47.Name = "siticoneRoundedButton47";
            this.siticoneRoundedButton47.ShadowDecoration.Parent = this.siticoneRoundedButton47;
            this.siticoneRoundedButton47.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton47.TabIndex = 138;
            this.siticoneRoundedButton47.Text = "Super Speed [OFF]";
            this.siticoneRoundedButton47.Click += new System.EventHandler(this.siticoneRoundedButton47_Click);
            // 
            // siticoneRoundedButton48
            // 
            this.siticoneRoundedButton48.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton48.BorderThickness = 1;
            this.siticoneRoundedButton48.CheckedState.Parent = this.siticoneRoundedButton48;
            this.siticoneRoundedButton48.CustomImages.Parent = this.siticoneRoundedButton48;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton48, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton48.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton48.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton48.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton48.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton48.HoveredState.Parent = this.siticoneRoundedButton48;
            this.siticoneRoundedButton48.Location = new System.Drawing.Point(318, 392);
            this.siticoneRoundedButton48.Name = "siticoneRoundedButton48";
            this.siticoneRoundedButton48.ShadowDecoration.Parent = this.siticoneRoundedButton48;
            this.siticoneRoundedButton48.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton48.TabIndex = 137;
            this.siticoneRoundedButton48.Text = "Change Teams";
            this.siticoneRoundedButton48.Click += new System.EventHandler(this.siticoneRoundedButton48_Click);
            // 
            // siticoneRoundedButton50
            // 
            this.siticoneRoundedButton50.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton50.BorderThickness = 1;
            this.siticoneRoundedButton50.CheckedState.Parent = this.siticoneRoundedButton50;
            this.siticoneRoundedButton50.CustomImages.Parent = this.siticoneRoundedButton50;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton50, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton50.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton50.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton50.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton50.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton50.HoveredState.Parent = this.siticoneRoundedButton50;
            this.siticoneRoundedButton50.Location = new System.Drawing.Point(318, 362);
            this.siticoneRoundedButton50.Name = "siticoneRoundedButton50";
            this.siticoneRoundedButton50.ShadowDecoration.Parent = this.siticoneRoundedButton50;
            this.siticoneRoundedButton50.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton50.TabIndex = 135;
            this.siticoneRoundedButton50.Text = "Anti End Game [OFF]";
            this.siticoneRoundedButton50.Click += new System.EventHandler(this.siticoneRoundedButton50_Click);
            // 
            // siticoneRoundedButton51
            // 
            this.siticoneRoundedButton51.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton51.BorderThickness = 1;
            this.siticoneRoundedButton51.CheckedState.Parent = this.siticoneRoundedButton51;
            this.siticoneRoundedButton51.CustomImages.Parent = this.siticoneRoundedButton51;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton51, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton51.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton51.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton51.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton51.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton51.HoveredState.Parent = this.siticoneRoundedButton51;
            this.siticoneRoundedButton51.Location = new System.Drawing.Point(470, 392);
            this.siticoneRoundedButton51.Name = "siticoneRoundedButton51";
            this.siticoneRoundedButton51.ShadowDecoration.Parent = this.siticoneRoundedButton51;
            this.siticoneRoundedButton51.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton51.TabIndex = 134;
            this.siticoneRoundedButton51.Text = "Unlimted Ammo";
            this.siticoneRoundedButton51.Click += new System.EventHandler(this.siticoneRoundedButton51_Click);
            // 
            // siticoneRoundedButton52
            // 
            this.siticoneRoundedButton52.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton52.BorderThickness = 1;
            this.siticoneRoundedButton52.CheckedState.Parent = this.siticoneRoundedButton52;
            this.siticoneRoundedButton52.CustomImages.Parent = this.siticoneRoundedButton52;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton52, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton52.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton52.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton52.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton52.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton52.HoveredState.Parent = this.siticoneRoundedButton52;
            this.siticoneRoundedButton52.Location = new System.Drawing.Point(318, 332);
            this.siticoneRoundedButton52.Name = "siticoneRoundedButton52";
            this.siticoneRoundedButton52.ShadowDecoration.Parent = this.siticoneRoundedButton52;
            this.siticoneRoundedButton52.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton52.TabIndex = 133;
            this.siticoneRoundedButton52.Text = "Gode Mode All [OFF]";
            this.siticoneRoundedButton52.Click += new System.EventHandler(this.siticoneRoundedButton52_Click);
            // 
            // siticoneRoundedButton53
            // 
            this.siticoneRoundedButton53.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton53.BorderThickness = 1;
            this.siticoneRoundedButton53.CheckedState.Parent = this.siticoneRoundedButton53;
            this.siticoneRoundedButton53.CustomImages.Parent = this.siticoneRoundedButton53;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton53, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton53.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton53.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton53.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton53.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton53.HoveredState.Parent = this.siticoneRoundedButton53;
            this.siticoneRoundedButton53.Location = new System.Drawing.Point(470, 332);
            this.siticoneRoundedButton53.Name = "siticoneRoundedButton53";
            this.siticoneRoundedButton53.ShadowDecoration.Parent = this.siticoneRoundedButton53;
            this.siticoneRoundedButton53.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton53.TabIndex = 132;
            this.siticoneRoundedButton53.Text = "Gravity [OFF]";
            this.siticoneRoundedButton53.Click += new System.EventHandler(this.siticoneRoundedButton53_Click);
            // 
            // siticoneRoundedButton43
            // 
            this.siticoneRoundedButton43.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton43.BorderThickness = 1;
            this.siticoneRoundedButton43.CheckedState.Parent = this.siticoneRoundedButton43;
            this.siticoneRoundedButton43.CustomImages.Parent = this.siticoneRoundedButton43;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton43, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton43.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton43.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton43.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton43.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton43.HoveredState.Parent = this.siticoneRoundedButton43;
            this.siticoneRoundedButton43.Location = new System.Drawing.Point(462, 201);
            this.siticoneRoundedButton43.Name = "siticoneRoundedButton43";
            this.siticoneRoundedButton43.ShadowDecoration.Parent = this.siticoneRoundedButton43;
            this.siticoneRoundedButton43.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton43.TabIndex = 130;
            this.siticoneRoundedButton43.Text = "Freeze Host";
            this.siticoneRoundedButton43.Click += new System.EventHandler(this.siticoneRoundedButton43_Click);
            // 
            // siticoneRoundedButton44
            // 
            this.siticoneRoundedButton44.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton44.BorderThickness = 1;
            this.siticoneRoundedButton44.CheckedState.Parent = this.siticoneRoundedButton44;
            this.siticoneRoundedButton44.CustomImages.Parent = this.siticoneRoundedButton44;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton44, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton44.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton44.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton44.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton44.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton44.HoveredState.Parent = this.siticoneRoundedButton44;
            this.siticoneRoundedButton44.Location = new System.Drawing.Point(462, 171);
            this.siticoneRoundedButton44.Name = "siticoneRoundedButton44";
            this.siticoneRoundedButton44.ShadowDecoration.Parent = this.siticoneRoundedButton44;
            this.siticoneRoundedButton44.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton44.TabIndex = 129;
            this.siticoneRoundedButton44.Text = "Infection Police";
            this.siticoneRoundedButton44.Click += new System.EventHandler(this.siticoneRoundedButton44_Click);
            // 
            // siticoneRoundedButton45
            // 
            this.siticoneRoundedButton45.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton45.BorderThickness = 1;
            this.siticoneRoundedButton45.CheckedState.Parent = this.siticoneRoundedButton45;
            this.siticoneRoundedButton45.CustomImages.Parent = this.siticoneRoundedButton45;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton45, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton45.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton45.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton45.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton45.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton45.HoveredState.Parent = this.siticoneRoundedButton45;
            this.siticoneRoundedButton45.Location = new System.Drawing.Point(462, 141);
            this.siticoneRoundedButton45.Name = "siticoneRoundedButton45";
            this.siticoneRoundedButton45.ShadowDecoration.Parent = this.siticoneRoundedButton45;
            this.siticoneRoundedButton45.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton45.TabIndex = 128;
            this.siticoneRoundedButton45.Text = "Freeze All";
            this.siticoneRoundedButton45.Click += new System.EventHandler(this.siticoneRoundedButton45_Click);
            // 
            // siticoneRoundedButton46
            // 
            this.siticoneRoundedButton46.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton46.BorderThickness = 1;
            this.siticoneRoundedButton46.CheckedState.Parent = this.siticoneRoundedButton46;
            this.siticoneRoundedButton46.CustomImages.Parent = this.siticoneRoundedButton46;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton46, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton46.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton46.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton46.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton46.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton46.HoveredState.Parent = this.siticoneRoundedButton46;
            this.siticoneRoundedButton46.Location = new System.Drawing.Point(462, 111);
            this.siticoneRoundedButton46.Name = "siticoneRoundedButton46";
            this.siticoneRoundedButton46.ShadowDecoration.Parent = this.siticoneRoundedButton46;
            this.siticoneRoundedButton46.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton46.TabIndex = 127;
            this.siticoneRoundedButton46.Text = "Kick All";
            this.siticoneRoundedButton46.Click += new System.EventHandler(this.siticoneRoundedButton46_Click);
            // 
            // siticoneRoundedButton40
            // 
            this.siticoneRoundedButton40.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton40.BorderThickness = 1;
            this.siticoneRoundedButton40.CheckedState.Parent = this.siticoneRoundedButton40;
            this.siticoneRoundedButton40.CustomImages.Parent = this.siticoneRoundedButton40;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton40, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton40.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton40.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton40.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton40.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton40.HoveredState.Parent = this.siticoneRoundedButton40;
            this.siticoneRoundedButton40.Location = new System.Drawing.Point(158, 422);
            this.siticoneRoundedButton40.Name = "siticoneRoundedButton40";
            this.siticoneRoundedButton40.ShadowDecoration.Parent = this.siticoneRoundedButton40;
            this.siticoneRoundedButton40.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton40.TabIndex = 122;
            this.siticoneRoundedButton40.Text = "360 View";
            this.siticoneRoundedButton40.Click += new System.EventHandler(this.siticoneRoundedButton40_Click);
            // 
            // siticoneRoundedButton39
            // 
            this.siticoneRoundedButton39.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton39.BorderThickness = 1;
            this.siticoneRoundedButton39.CheckedState.Parent = this.siticoneRoundedButton39;
            this.siticoneRoundedButton39.CustomImages.Parent = this.siticoneRoundedButton39;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton39, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton39.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton39.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton39.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton39.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton39.HoveredState.Parent = this.siticoneRoundedButton39;
            this.siticoneRoundedButton39.Location = new System.Drawing.Point(459, 251);
            this.siticoneRoundedButton39.Name = "siticoneRoundedButton39";
            this.siticoneRoundedButton39.ShadowDecoration.Parent = this.siticoneRoundedButton39;
            this.siticoneRoundedButton39.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton39.TabIndex = 121;
            this.siticoneRoundedButton39.Text = "HostName/FPS [OFF]";
            this.siticoneRoundedButton39.Click += new System.EventHandler(this.siticoneRoundedButton39_Click);
            // 
            // siticoneRoundedTextBox9
            // 
            this.siticoneRoundedTextBox9.AllowDrop = true;
            this.siticoneRoundedTextBox9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox9.DefaultText = "^5Read";
            this.siticoneRoundedTextBox9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox9.DisabledState.Parent = this.siticoneRoundedTextBox9;
            this.siticoneRoundedTextBox9.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox9.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox9.FocusedState.Parent = this.siticoneRoundedTextBox9;
            this.siticoneRoundedTextBox9.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox9.HoveredState.Parent = this.siticoneRoundedTextBox9;
            this.siticoneRoundedTextBox9.Location = new System.Drawing.Point(459, 282);
            this.siticoneRoundedTextBox9.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox9.Name = "siticoneRoundedTextBox9";
            this.siticoneRoundedTextBox9.PasswordChar = '\0';
            this.siticoneRoundedTextBox9.PlaceholderText = "";
            this.siticoneRoundedTextBox9.SelectedText = "";
            this.siticoneRoundedTextBox9.ShadowDecoration.Parent = this.siticoneRoundedTextBox9;
            this.siticoneRoundedTextBox9.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox9.TabIndex = 120;
            this.siticoneRoundedTextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton38
            // 
            this.siticoneRoundedButton38.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton38.BorderThickness = 1;
            this.siticoneRoundedButton38.CheckedState.Parent = this.siticoneRoundedButton38;
            this.siticoneRoundedButton38.CustomImages.Parent = this.siticoneRoundedButton38;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton38, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton38.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton38.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton38.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton38.HoveredState.Parent = this.siticoneRoundedButton38;
            this.siticoneRoundedButton38.Location = new System.Drawing.Point(307, 251);
            this.siticoneRoundedButton38.Name = "siticoneRoundedButton38";
            this.siticoneRoundedButton38.ShadowDecoration.Parent = this.siticoneRoundedButton38;
            this.siticoneRoundedButton38.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton38.TabIndex = 119;
            this.siticoneRoundedButton38.Text = "Set Field Of View";
            this.siticoneRoundedButton38.Click += new System.EventHandler(this.siticoneRoundedButton38_Click);
            // 
            // siticoneRoundedTextBox7
            // 
            this.siticoneRoundedTextBox7.AllowDrop = true;
            this.siticoneRoundedTextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox7.DefaultText = "65";
            this.siticoneRoundedTextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox7.DisabledState.Parent = this.siticoneRoundedTextBox7;
            this.siticoneRoundedTextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox7.FocusedState.Parent = this.siticoneRoundedTextBox7;
            this.siticoneRoundedTextBox7.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox7.HoveredState.Parent = this.siticoneRoundedTextBox7;
            this.siticoneRoundedTextBox7.Location = new System.Drawing.Point(307, 282);
            this.siticoneRoundedTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox7.Name = "siticoneRoundedTextBox7";
            this.siticoneRoundedTextBox7.PasswordChar = '\0';
            this.siticoneRoundedTextBox7.PlaceholderText = "";
            this.siticoneRoundedTextBox7.SelectedText = "";
            this.siticoneRoundedTextBox7.ShadowDecoration.Parent = this.siticoneRoundedTextBox7;
            this.siticoneRoundedTextBox7.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox7.TabIndex = 118;
            this.siticoneRoundedTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton36
            // 
            this.siticoneRoundedButton36.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton36.BorderThickness = 1;
            this.siticoneRoundedButton36.CheckedState.Parent = this.siticoneRoundedButton36;
            this.siticoneRoundedButton36.CustomImages.Parent = this.siticoneRoundedButton36;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton36, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton36.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton36.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton36.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton36.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton36.HoveredState.Parent = this.siticoneRoundedButton36;
            this.siticoneRoundedButton36.Location = new System.Drawing.Point(6, 392);
            this.siticoneRoundedButton36.Name = "siticoneRoundedButton36";
            this.siticoneRoundedButton36.ShadowDecoration.Parent = this.siticoneRoundedButton36;
            this.siticoneRoundedButton36.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton36.TabIndex = 117;
            this.siticoneRoundedButton36.Text = "Upside Down Screen";
            this.siticoneRoundedButton36.Click += new System.EventHandler(this.siticoneRoundedButton36_Click);
            // 
            // siticoneRoundedButton37
            // 
            this.siticoneRoundedButton37.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton37.BorderThickness = 1;
            this.siticoneRoundedButton37.CheckedState.Parent = this.siticoneRoundedButton37;
            this.siticoneRoundedButton37.CustomImages.Parent = this.siticoneRoundedButton37;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton37, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton37.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton37.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton37.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton37.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton37.HoveredState.Parent = this.siticoneRoundedButton37;
            this.siticoneRoundedButton37.Location = new System.Drawing.Point(158, 392);
            this.siticoneRoundedButton37.Name = "siticoneRoundedButton37";
            this.siticoneRoundedButton37.ShadowDecoration.Parent = this.siticoneRoundedButton37;
            this.siticoneRoundedButton37.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton37.TabIndex = 116;
            this.siticoneRoundedButton37.Text = "Need help to fix?";
            this.siticoneRoundedButton37.Click += new System.EventHandler(this.siticoneRoundedButton37_Click);
            // 
            // siticoneRoundedButton34
            // 
            this.siticoneRoundedButton34.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton34.BorderThickness = 1;
            this.siticoneRoundedButton34.CheckedState.Parent = this.siticoneRoundedButton34;
            this.siticoneRoundedButton34.CustomImages.Parent = this.siticoneRoundedButton34;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton34, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton34.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton34.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton34.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton34.HoveredState.Parent = this.siticoneRoundedButton34;
            this.siticoneRoundedButton34.Location = new System.Drawing.Point(6, 362);
            this.siticoneRoundedButton34.Name = "siticoneRoundedButton34";
            this.siticoneRoundedButton34.ShadowDecoration.Parent = this.siticoneRoundedButton34;
            this.siticoneRoundedButton34.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton34.TabIndex = 115;
            this.siticoneRoundedButton34.Text = "Save Emblem To Bin File";
            this.siticoneRoundedButton34.Click += new System.EventHandler(this.siticoneRoundedButton34_Click);
            // 
            // siticoneRoundedButton35
            // 
            this.siticoneRoundedButton35.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton35.BorderThickness = 1;
            this.siticoneRoundedButton35.CheckedState.Parent = this.siticoneRoundedButton35;
            this.siticoneRoundedButton35.CustomImages.Parent = this.siticoneRoundedButton35;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton35, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton35.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton35.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton35.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton35.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton35.HoveredState.Parent = this.siticoneRoundedButton35;
            this.siticoneRoundedButton35.Location = new System.Drawing.Point(158, 362);
            this.siticoneRoundedButton35.Name = "siticoneRoundedButton35";
            this.siticoneRoundedButton35.ShadowDecoration.Parent = this.siticoneRoundedButton35;
            this.siticoneRoundedButton35.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton35.TabIndex = 114;
            this.siticoneRoundedButton35.Text = "Load Emblem To Bin File";
            this.siticoneRoundedButton35.Click += new System.EventHandler(this.siticoneRoundedButton35_Click);
            // 
            // siticoneRoundedButton32
            // 
            this.siticoneRoundedButton32.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton32.BorderThickness = 1;
            this.siticoneRoundedButton32.CheckedState.Parent = this.siticoneRoundedButton32;
            this.siticoneRoundedButton32.CustomImages.Parent = this.siticoneRoundedButton32;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton32, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton32.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton32.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton32.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton32.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton32.HoveredState.Parent = this.siticoneRoundedButton32;
            this.siticoneRoundedButton32.Location = new System.Drawing.Point(6, 332);
            this.siticoneRoundedButton32.Name = "siticoneRoundedButton32";
            this.siticoneRoundedButton32.ShadowDecoration.Parent = this.siticoneRoundedButton32;
            this.siticoneRoundedButton32.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton32.TabIndex = 113;
            this.siticoneRoundedButton32.Text = "Save Classes";
            this.siticoneRoundedButton32.Click += new System.EventHandler(this.siticoneRoundedButton32_Click);
            // 
            // siticoneRoundedButton33
            // 
            this.siticoneRoundedButton33.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton33.BorderThickness = 1;
            this.siticoneRoundedButton33.CheckedState.Parent = this.siticoneRoundedButton33;
            this.siticoneRoundedButton33.CustomImages.Parent = this.siticoneRoundedButton33;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton33, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton33.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton33.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton33.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton33.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton33.HoveredState.Parent = this.siticoneRoundedButton33;
            this.siticoneRoundedButton33.Location = new System.Drawing.Point(158, 332);
            this.siticoneRoundedButton33.Name = "siticoneRoundedButton33";
            this.siticoneRoundedButton33.ShadowDecoration.Parent = this.siticoneRoundedButton33;
            this.siticoneRoundedButton33.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton33.TabIndex = 112;
            this.siticoneRoundedButton33.Text = "Set Classes";
            this.siticoneRoundedButton33.Click += new System.EventHandler(this.siticoneRoundedButton33_Click);
            // 
            // siticoneRoundedButton30
            // 
            this.siticoneRoundedButton30.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton30.BorderThickness = 1;
            this.siticoneRoundedButton30.CheckedState.Parent = this.siticoneRoundedButton30;
            this.siticoneRoundedButton30.CustomImages.Parent = this.siticoneRoundedButton30;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton30, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton30.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton30.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton30.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton30.HoveredState.Parent = this.siticoneRoundedButton30;
            this.siticoneRoundedButton30.Location = new System.Drawing.Point(6, 422);
            this.siticoneRoundedButton30.Name = "siticoneRoundedButton30";
            this.siticoneRoundedButton30.ShadowDecoration.Parent = this.siticoneRoundedButton30;
            this.siticoneRoundedButton30.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton30.TabIndex = 111;
            this.siticoneRoundedButton30.Text = "Flashing Reload";
            this.siticoneRoundedButton30.Click += new System.EventHandler(this.siticoneRoundedButton30_Click);
            // 
            // siticoneRoundedButton31
            // 
            this.siticoneRoundedButton31.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton31.BorderThickness = 1;
            this.siticoneRoundedButton31.CheckedState.Parent = this.siticoneRoundedButton31;
            this.siticoneRoundedButton31.CustomImages.Parent = this.siticoneRoundedButton31;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton31, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton31.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton31.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton31.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton31.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton31.HoveredState.Parent = this.siticoneRoundedButton31;
            this.siticoneRoundedButton31.Location = new System.Drawing.Point(155, 251);
            this.siticoneRoundedButton31.Name = "siticoneRoundedButton31";
            this.siticoneRoundedButton31.ShadowDecoration.Parent = this.siticoneRoundedButton31;
            this.siticoneRoundedButton31.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton31.TabIndex = 110;
            this.siticoneRoundedButton31.Text = "Set All Clients Names";
            this.siticoneRoundedButton31.Click += new System.EventHandler(this.siticoneRoundedButton31_Click);
            // 
            // siticoneRoundedTextBox8
            // 
            this.siticoneRoundedTextBox8.AllowDrop = true;
            this.siticoneRoundedTextBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox8.DefaultText = "Name Here";
            this.siticoneRoundedTextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox8.DisabledState.Parent = this.siticoneRoundedTextBox8;
            this.siticoneRoundedTextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox8.FocusedState.Parent = this.siticoneRoundedTextBox8;
            this.siticoneRoundedTextBox8.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox8.HoveredState.Parent = this.siticoneRoundedTextBox8;
            this.siticoneRoundedTextBox8.Location = new System.Drawing.Point(155, 282);
            this.siticoneRoundedTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox8.Name = "siticoneRoundedTextBox8";
            this.siticoneRoundedTextBox8.PasswordChar = '\0';
            this.siticoneRoundedTextBox8.PlaceholderText = "";
            this.siticoneRoundedTextBox8.SelectedText = "";
            this.siticoneRoundedTextBox8.ShadowDecoration.Parent = this.siticoneRoundedTextBox8;
            this.siticoneRoundedTextBox8.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox8.TabIndex = 109;
            this.siticoneRoundedTextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton29
            // 
            this.siticoneRoundedButton29.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton29.BorderThickness = 1;
            this.siticoneRoundedButton29.CheckedState.Parent = this.siticoneRoundedButton29;
            this.siticoneRoundedButton29.CustomImages.Parent = this.siticoneRoundedButton29;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton29, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton29.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton29.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton29.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton29.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton29.HoveredState.Parent = this.siticoneRoundedButton29;
            this.siticoneRoundedButton29.Location = new System.Drawing.Point(6, 251);
            this.siticoneRoundedButton29.Name = "siticoneRoundedButton29";
            this.siticoneRoundedButton29.ShadowDecoration.Parent = this.siticoneRoundedButton29;
            this.siticoneRoundedButton29.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton29.TabIndex = 106;
            this.siticoneRoundedButton29.Text = "Kick All";
            this.siticoneRoundedButton29.Click += new System.EventHandler(this.siticoneRoundedButton29_Click);
            // 
            // siticoneRoundedTextBox6
            // 
            this.siticoneRoundedTextBox6.AllowDrop = true;
            this.siticoneRoundedTextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox6.DefaultText = "Message Here";
            this.siticoneRoundedTextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox6.DisabledState.Parent = this.siticoneRoundedTextBox6;
            this.siticoneRoundedTextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox6.FocusedState.Parent = this.siticoneRoundedTextBox6;
            this.siticoneRoundedTextBox6.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox6.HoveredState.Parent = this.siticoneRoundedTextBox6;
            this.siticoneRoundedTextBox6.Location = new System.Drawing.Point(6, 282);
            this.siticoneRoundedTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox6.Name = "siticoneRoundedTextBox6";
            this.siticoneRoundedTextBox6.PasswordChar = '\0';
            this.siticoneRoundedTextBox6.PlaceholderText = "";
            this.siticoneRoundedTextBox6.SelectedText = "";
            this.siticoneRoundedTextBox6.ShadowDecoration.Parent = this.siticoneRoundedTextBox6;
            this.siticoneRoundedTextBox6.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox6.TabIndex = 105;
            this.siticoneRoundedTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton27
            // 
            this.siticoneRoundedButton27.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton27.BorderThickness = 1;
            this.siticoneRoundedButton27.CheckedState.Parent = this.siticoneRoundedButton27;
            this.siticoneRoundedButton27.CustomImages.Parent = this.siticoneRoundedButton27;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton27, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton27.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton27.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton27.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton27.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton27.HoveredState.Parent = this.siticoneRoundedButton27;
            this.siticoneRoundedButton27.Location = new System.Drawing.Point(606, 15);
            this.siticoneRoundedButton27.Name = "siticoneRoundedButton27";
            this.siticoneRoundedButton27.ShadowDecoration.Parent = this.siticoneRoundedButton27;
            this.siticoneRoundedButton27.Size = new System.Drawing.Size(113, 24);
            this.siticoneRoundedButton27.TabIndex = 104;
            this.siticoneRoundedButton27.Text = "Reset Gamertag";
            this.siticoneRoundedButton27.Click += new System.EventHandler(this.siticoneRoundedButton27_Click);
            // 
            // siticoneRoundedButton26
            // 
            this.siticoneRoundedButton26.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton26.BorderThickness = 1;
            this.siticoneRoundedButton26.CheckedState.Parent = this.siticoneRoundedButton26;
            this.siticoneRoundedButton26.CustomImages.Parent = this.siticoneRoundedButton26;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton26, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton26.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton26.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton26.HoveredState.Parent = this.siticoneRoundedButton26;
            this.siticoneRoundedButton26.Location = new System.Drawing.Point(158, 201);
            this.siticoneRoundedButton26.Name = "siticoneRoundedButton26";
            this.siticoneRoundedButton26.ShadowDecoration.Parent = this.siticoneRoundedButton26;
            this.siticoneRoundedButton26.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton26.TabIndex = 103;
            this.siticoneRoundedButton26.Text = "Show Host [OFF]";
            this.siticoneRoundedButton26.Click += new System.EventHandler(this.siticoneRoundedButton26_Click);
            // 
            // siticoneRoundedButton25
            // 
            this.siticoneRoundedButton25.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton25.BorderThickness = 1;
            this.siticoneRoundedButton25.CheckedState.Parent = this.siticoneRoundedButton25;
            this.siticoneRoundedButton25.CustomImages.Parent = this.siticoneRoundedButton25;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton25, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton25.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton25.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton25.HoveredState.Parent = this.siticoneRoundedButton25;
            this.siticoneRoundedButton25.Location = new System.Drawing.Point(310, 201);
            this.siticoneRoundedButton25.Name = "siticoneRoundedButton25";
            this.siticoneRoundedButton25.ShadowDecoration.Parent = this.siticoneRoundedButton25;
            this.siticoneRoundedButton25.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton25.TabIndex = 102;
            this.siticoneRoundedButton25.Text = "Lag Meter [OFF]";
            this.siticoneRoundedButton25.Click += new System.EventHandler(this.siticoneRoundedButton25_Click);
            // 
            // siticoneRoundedButton24
            // 
            this.siticoneRoundedButton24.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton24.BorderThickness = 1;
            this.siticoneRoundedButton24.CheckedState.Parent = this.siticoneRoundedButton24;
            this.siticoneRoundedButton24.CustomImages.Parent = this.siticoneRoundedButton24;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton24, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton24.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton24.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton24.HoveredState.Parent = this.siticoneRoundedButton24;
            this.siticoneRoundedButton24.Location = new System.Drawing.Point(310, 171);
            this.siticoneRoundedButton24.Name = "siticoneRoundedButton24";
            this.siticoneRoundedButton24.ShadowDecoration.Parent = this.siticoneRoundedButton24;
            this.siticoneRoundedButton24.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton24.TabIndex = 101;
            this.siticoneRoundedButton24.Text = "Leave Game";
            this.siticoneRoundedButton24.Click += new System.EventHandler(this.siticoneRoundedButton24_Click);
            // 
            // siticoneRoundedButton23
            // 
            this.siticoneRoundedButton23.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton23.BorderThickness = 1;
            this.siticoneRoundedButton23.CheckedState.Parent = this.siticoneRoundedButton23;
            this.siticoneRoundedButton23.CustomImages.Parent = this.siticoneRoundedButton23;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton23, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton23.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton23.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton23.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton23.HoveredState.Parent = this.siticoneRoundedButton23;
            this.siticoneRoundedButton23.Location = new System.Drawing.Point(6, 200);
            this.siticoneRoundedButton23.Name = "siticoneRoundedButton23";
            this.siticoneRoundedButton23.ShadowDecoration.Parent = this.siticoneRoundedButton23;
            this.siticoneRoundedButton23.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton23.TabIndex = 100;
            this.siticoneRoundedButton23.Text = "Anti-Freeze";
            this.siticoneRoundedButton23.Click += new System.EventHandler(this.siticoneRoundedButton23_Click);
            // 
            // siticoneRoundedButton22
            // 
            this.siticoneRoundedButton22.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton22.BorderThickness = 1;
            this.siticoneRoundedButton22.CheckedState.Parent = this.siticoneRoundedButton22;
            this.siticoneRoundedButton22.CustomImages.Parent = this.siticoneRoundedButton22;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton22, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton22.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton22.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton22.HoveredState.Parent = this.siticoneRoundedButton22;
            this.siticoneRoundedButton22.Location = new System.Drawing.Point(158, 171);
            this.siticoneRoundedButton22.Name = "siticoneRoundedButton22";
            this.siticoneRoundedButton22.ShadowDecoration.Parent = this.siticoneRoundedButton22;
            this.siticoneRoundedButton22.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton22.TabIndex = 99;
            this.siticoneRoundedButton22.Text = "Instant Host";
            this.siticoneRoundedButton22.Click += new System.EventHandler(this.siticoneRoundedButton22_Click);
            // 
            // siticoneRoundedButton21
            // 
            this.siticoneRoundedButton21.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton21.BorderThickness = 1;
            this.siticoneRoundedButton21.CheckedState.Parent = this.siticoneRoundedButton21;
            this.siticoneRoundedButton21.CustomImages.Parent = this.siticoneRoundedButton21;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton21, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton21.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton21.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton21.HoveredState.Parent = this.siticoneRoundedButton21;
            this.siticoneRoundedButton21.Location = new System.Drawing.Point(6, 171);
            this.siticoneRoundedButton21.Name = "siticoneRoundedButton21";
            this.siticoneRoundedButton21.ShadowDecoration.Parent = this.siticoneRoundedButton21;
            this.siticoneRoundedButton21.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton21.TabIndex = 98;
            this.siticoneRoundedButton21.Text = "Crash Game";
            this.siticoneRoundedButton21.Click += new System.EventHandler(this.siticoneRoundedButton21_Click);
            // 
            // siticoneRoundedButton20
            // 
            this.siticoneRoundedButton20.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton20.BorderThickness = 1;
            this.siticoneRoundedButton20.CheckedState.Parent = this.siticoneRoundedButton20;
            this.siticoneRoundedButton20.CustomImages.Parent = this.siticoneRoundedButton20;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton20, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton20.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton20.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton20.HoveredState.Parent = this.siticoneRoundedButton20;
            this.siticoneRoundedButton20.Location = new System.Drawing.Point(310, 141);
            this.siticoneRoundedButton20.Name = "siticoneRoundedButton20";
            this.siticoneRoundedButton20.ShadowDecoration.Parent = this.siticoneRoundedButton20;
            this.siticoneRoundedButton20.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton20.TabIndex = 97;
            this.siticoneRoundedButton20.Text = "End Game V2";
            this.siticoneRoundedButton20.Click += new System.EventHandler(this.siticoneRoundedButton20_Click);
            // 
            // siticoneRoundedButton19
            // 
            this.siticoneRoundedButton19.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton19.BorderThickness = 1;
            this.siticoneRoundedButton19.CheckedState.Parent = this.siticoneRoundedButton19;
            this.siticoneRoundedButton19.CustomImages.Parent = this.siticoneRoundedButton19;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton19, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton19.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton19.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton19.HoveredState.Parent = this.siticoneRoundedButton19;
            this.siticoneRoundedButton19.Location = new System.Drawing.Point(158, 141);
            this.siticoneRoundedButton19.Name = "siticoneRoundedButton19";
            this.siticoneRoundedButton19.ShadowDecoration.Parent = this.siticoneRoundedButton19;
            this.siticoneRoundedButton19.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton19.TabIndex = 96;
            this.siticoneRoundedButton19.Text = "End Game";
            this.siticoneRoundedButton19.Click += new System.EventHandler(this.siticoneRoundedButton19_Click);
            // 
            // siticoneRoundedButton18
            // 
            this.siticoneRoundedButton18.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton18.BorderThickness = 1;
            this.siticoneRoundedButton18.CheckedState.Parent = this.siticoneRoundedButton18;
            this.siticoneRoundedButton18.CustomImages.Parent = this.siticoneRoundedButton18;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton18, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton18.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton18.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton18.HoveredState.Parent = this.siticoneRoundedButton18;
            this.siticoneRoundedButton18.Location = new System.Drawing.Point(6, 141);
            this.siticoneRoundedButton18.Name = "siticoneRoundedButton18";
            this.siticoneRoundedButton18.ShadowDecoration.Parent = this.siticoneRoundedButton18;
            this.siticoneRoundedButton18.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton18.TabIndex = 95;
            this.siticoneRoundedButton18.Text = "Restart Game";
            this.siticoneRoundedButton18.Click += new System.EventHandler(this.siticoneRoundedButton18_Click);
            // 
            // siticoneRoundedButton17
            // 
            this.siticoneRoundedButton17.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton17.BorderThickness = 1;
            this.siticoneRoundedButton17.CheckedState.Parent = this.siticoneRoundedButton17;
            this.siticoneRoundedButton17.CustomImages.Parent = this.siticoneRoundedButton17;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton17, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton17.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton17.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton17.HoveredState.Parent = this.siticoneRoundedButton17;
            this.siticoneRoundedButton17.Location = new System.Drawing.Point(310, 111);
            this.siticoneRoundedButton17.Name = "siticoneRoundedButton17";
            this.siticoneRoundedButton17.ShadowDecoration.Parent = this.siticoneRoundedButton17;
            this.siticoneRoundedButton17.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton17.TabIndex = 94;
            this.siticoneRoundedButton17.Text = "Spoof Mic [OFF]";
            this.siticoneRoundedButton17.Click += new System.EventHandler(this.siticoneRoundedButton17_Click);
            // 
            // siticoneRoundedButton16
            // 
            this.siticoneRoundedButton16.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton16.BorderThickness = 1;
            this.siticoneRoundedButton16.CheckedState.Parent = this.siticoneRoundedButton16;
            this.siticoneRoundedButton16.CustomImages.Parent = this.siticoneRoundedButton16;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton16, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton16.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton16.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton16.HoveredState.Parent = this.siticoneRoundedButton16;
            this.siticoneRoundedButton16.Location = new System.Drawing.Point(158, 111);
            this.siticoneRoundedButton16.Name = "siticoneRoundedButton16";
            this.siticoneRoundedButton16.ShadowDecoration.Parent = this.siticoneRoundedButton16;
            this.siticoneRoundedButton16.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton16.TabIndex = 93;
            this.siticoneRoundedButton16.Text = "Force Start Game";
            this.siticoneRoundedButton16.Click += new System.EventHandler(this.siticoneRoundedButton16_Click);
            // 
            // siticoneRoundedButton15
            // 
            this.siticoneRoundedButton15.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton15.BorderThickness = 1;
            this.siticoneRoundedButton15.CheckedState.Parent = this.siticoneRoundedButton15;
            this.siticoneRoundedButton15.CustomImages.Parent = this.siticoneRoundedButton15;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton15, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton15.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton15.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton15.HoveredState.Parent = this.siticoneRoundedButton15;
            this.siticoneRoundedButton15.Location = new System.Drawing.Point(6, 111);
            this.siticoneRoundedButton15.Name = "siticoneRoundedButton15";
            this.siticoneRoundedButton15.ShadowDecoration.Parent = this.siticoneRoundedButton15;
            this.siticoneRoundedButton15.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton15.TabIndex = 92;
            this.siticoneRoundedButton15.Text = "Force Host [OFF]";
            this.siticoneRoundedButton15.Click += new System.EventHandler(this.siticoneRoundedButton15_Click);
            // 
            // siticoneCheckBox5
            // 
            this.siticoneCheckBox5.AutoSize = true;
            this.siticoneCheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox5.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox5.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTransition1.SetDecoration(this.siticoneCheckBox5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCheckBox5.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox5.Location = new System.Drawing.Point(256, 77);
            this.siticoneCheckBox5.Name = "siticoneCheckBox5";
            this.siticoneCheckBox5.Size = new System.Drawing.Size(75, 17);
            this.siticoneCheckBox5.TabIndex = 91;
            this.siticoneCheckBox5.Text = "Small Icon";
            this.siticoneCheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox5.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox5.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // siticoneCheckBox4
            // 
            this.siticoneCheckBox4.AutoSize = true;
            this.siticoneCheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox4.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox4.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTransition1.SetDecoration(this.siticoneCheckBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCheckBox4.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox4.Location = new System.Drawing.Point(337, 77);
            this.siticoneCheckBox4.Name = "siticoneCheckBox4";
            this.siticoneCheckBox4.Size = new System.Drawing.Size(70, 17);
            this.siticoneCheckBox4.TabIndex = 90;
            this.siticoneCheckBox4.Text = "Tiny Icon";
            this.siticoneCheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox4.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox4.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // siticoneCheckBox3
            // 
            this.siticoneCheckBox3.AutoSize = true;
            this.siticoneCheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox3.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox3.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTransition1.SetDecoration(this.siticoneCheckBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCheckBox3.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox3.Location = new System.Drawing.Point(70, 77);
            this.siticoneCheckBox3.Name = "siticoneCheckBox3";
            this.siticoneCheckBox3.Size = new System.Drawing.Size(81, 17);
            this.siticoneCheckBox3.TabIndex = 89;
            this.siticoneCheckBox3.Text = "Type Writer";
            this.siticoneCheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox3.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox3.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox3.CheckedChanged += new System.EventHandler(this.siticoneCheckBox3_CheckChanged);
            // 
            // siticoneCheckBox2
            // 
            this.siticoneCheckBox2.AutoSize = true;
            this.siticoneCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox2.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTransition1.SetDecoration(this.siticoneCheckBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.siticoneCheckBox2.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox2.Location = new System.Drawing.Point(155, 77);
            this.siticoneCheckBox2.Name = "siticoneCheckBox2";
            this.siticoneCheckBox2.Size = new System.Drawing.Size(51, 17);
            this.siticoneCheckBox2.TabIndex = 88;
            this.siticoneCheckBox2.Text = "Flash";
            this.siticoneCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox2.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.CheckedChanged += new System.EventHandler(this.siticoneCheckBox2_CheckChanged);
            // 
            // siticoneCheckBox1
            // 
            this.siticoneCheckBox1.AutoSize = true;
            this.siticoneCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTransition1.SetDecoration(this.siticoneCheckBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCheckBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox1.Location = new System.Drawing.Point(16, 77);
            this.siticoneCheckBox1.Name = "siticoneCheckBox1";
            this.siticoneCheckBox1.Size = new System.Drawing.Size(48, 17);
            this.siticoneCheckBox1.TabIndex = 87;
            this.siticoneCheckBox1.Text = "RTE";
            this.siticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.CheckedChanged += new System.EventHandler(this.siticoneCheckBox1_CheckChanged);
            // 
            // siticoneRoundedButton14
            // 
            this.siticoneRoundedButton14.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton14.BorderThickness = 1;
            this.siticoneRoundedButton14.CheckedState.Parent = this.siticoneRoundedButton14;
            this.siticoneRoundedButton14.CustomImages.Parent = this.siticoneRoundedButton14;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton14, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton14.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton14.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton14.HoveredState.Parent = this.siticoneRoundedButton14;
            this.siticoneRoundedButton14.Location = new System.Drawing.Point(230, 15);
            this.siticoneRoundedButton14.Name = "siticoneRoundedButton14";
            this.siticoneRoundedButton14.ShadowDecoration.Parent = this.siticoneRoundedButton14;
            this.siticoneRoundedButton14.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedButton14.TabIndex = 86;
            this.siticoneRoundedButton14.Text = "Set Shader\'s";
            this.siticoneRoundedButton14.Click += new System.EventHandler(this.siticoneRoundedButton14_Click);
            // 
            // siticoneRoundedTextBox4
            // 
            this.siticoneRoundedTextBox4.AllowDrop = true;
            this.siticoneRoundedTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox4.DefaultText = "ui_globe";
            this.siticoneRoundedTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox4.DisabledState.Parent = this.siticoneRoundedTextBox4;
            this.siticoneRoundedTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox4.FocusedState.Parent = this.siticoneRoundedTextBox4;
            this.siticoneRoundedTextBox4.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox4.HoveredState.Parent = this.siticoneRoundedTextBox4;
            this.siticoneRoundedTextBox4.Location = new System.Drawing.Point(230, 46);
            this.siticoneRoundedTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox4.Name = "siticoneRoundedTextBox4";
            this.siticoneRoundedTextBox4.PasswordChar = '\0';
            this.siticoneRoundedTextBox4.PlaceholderText = "";
            this.siticoneRoundedTextBox4.SelectedText = "";
            this.siticoneRoundedTextBox4.ShadowDecoration.Parent = this.siticoneRoundedTextBox4;
            this.siticoneRoundedTextBox4.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox4.TabIndex = 85;
            this.siticoneRoundedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton13
            // 
            this.siticoneRoundedButton13.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton13.BorderThickness = 1;
            this.siticoneRoundedButton13.CheckedState.Parent = this.siticoneRoundedButton13;
            this.siticoneRoundedButton13.CustomImages.Parent = this.siticoneRoundedButton13;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton13, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton13.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton13.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton13.HoveredState.Parent = this.siticoneRoundedButton13;
            this.siticoneRoundedButton13.Location = new System.Drawing.Point(6, 15);
            this.siticoneRoundedButton13.Name = "siticoneRoundedButton13";
            this.siticoneRoundedButton13.ShadowDecoration.Parent = this.siticoneRoundedButton13;
            this.siticoneRoundedButton13.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedButton13.TabIndex = 84;
            this.siticoneRoundedButton13.Text = "Set Gamertag";
            this.siticoneRoundedButton13.Click += new System.EventHandler(this.siticoneRoundedButton12_Click);
            // 
            // siticoneRoundedTextBox3
            // 
            this.siticoneRoundedTextBox3.AllowDrop = true;
            this.siticoneRoundedTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox3.DefaultText = "";
            this.siticoneRoundedTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox3.DisabledState.Parent = this.siticoneRoundedTextBox3;
            this.siticoneRoundedTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox3.FocusedState.Parent = this.siticoneRoundedTextBox3;
            this.siticoneRoundedTextBox3.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox3.HoveredState.Parent = this.siticoneRoundedTextBox3;
            this.siticoneRoundedTextBox3.Location = new System.Drawing.Point(6, 46);
            this.siticoneRoundedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox3.Name = "siticoneRoundedTextBox3";
            this.siticoneRoundedTextBox3.PasswordChar = '\0';
            this.siticoneRoundedTextBox3.PlaceholderText = "";
            this.siticoneRoundedTextBox3.SelectedText = "";
            this.siticoneRoundedTextBox3.ShadowDecoration.Parent = this.siticoneRoundedTextBox3;
            this.siticoneRoundedTextBox3.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox3.TabIndex = 83;
            this.siticoneRoundedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneRoundedTextBox3.TextChanged += new System.EventHandler(this.email_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage3.Controls.Add(this.siticoneRoundedButton101);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox35);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton74);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton73);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton72);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton71);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton70);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton69);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton68);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton67);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton65);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton64);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox23);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox24);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox25);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox26);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox27);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox28);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox29);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox30);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox31);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox32);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton62);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton63);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox33);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox22);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox21);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox20);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox19);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox18);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox17);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox16);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox15);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox14);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox13);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton61);
            this.tabPage3.Controls.Add(this.siticoneRoundedButton60);
            this.tabPage3.Controls.Add(this.siticoneRoundedTextBox12);
            this.siticoneTransition1.SetDecoration(this.tabPage3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(878, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recovery Stuff";
            // 
            // siticoneRoundedButton101
            // 
            this.siticoneRoundedButton101.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton101.BorderThickness = 1;
            this.siticoneRoundedButton101.CheckedState.Parent = this.siticoneRoundedButton101;
            this.siticoneRoundedButton101.CustomImages.Parent = this.siticoneRoundedButton101;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton101, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton101.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton101.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton101.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton101.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton101.HoveredState.Parent = this.siticoneRoundedButton101;
            this.siticoneRoundedButton101.Location = new System.Drawing.Point(452, 15);
            this.siticoneRoundedButton101.Name = "siticoneRoundedButton101";
            this.siticoneRoundedButton101.ShadowDecoration.Parent = this.siticoneRoundedButton101;
            this.siticoneRoundedButton101.Size = new System.Drawing.Size(190, 24);
            this.siticoneRoundedButton101.TabIndex = 123;
            this.siticoneRoundedButton101.Text = "Set Prestige";
            this.siticoneRoundedButton101.Click += new System.EventHandler(this.siticoneRoundedButton101_Click);
            // 
            // siticoneRoundedTextBox35
            // 
            this.siticoneRoundedTextBox35.AllowDrop = true;
            this.siticoneRoundedTextBox35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox35.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox35, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox35.DefaultText = "11";
            this.siticoneRoundedTextBox35.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox35.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox35.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox35.DisabledState.Parent = this.siticoneRoundedTextBox35;
            this.siticoneRoundedTextBox35.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox35.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox35.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox35.FocusedState.Parent = this.siticoneRoundedTextBox35;
            this.siticoneRoundedTextBox35.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox35.HoveredState.Parent = this.siticoneRoundedTextBox35;
            this.siticoneRoundedTextBox35.Location = new System.Drawing.Point(452, 46);
            this.siticoneRoundedTextBox35.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox35.Name = "siticoneRoundedTextBox35";
            this.siticoneRoundedTextBox35.PasswordChar = '\0';
            this.siticoneRoundedTextBox35.PlaceholderText = "";
            this.siticoneRoundedTextBox35.SelectedText = "";
            this.siticoneRoundedTextBox35.ShadowDecoration.Parent = this.siticoneRoundedTextBox35;
            this.siticoneRoundedTextBox35.Size = new System.Drawing.Size(190, 24);
            this.siticoneRoundedTextBox35.TabIndex = 122;
            this.siticoneRoundedTextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton74
            // 
            this.siticoneRoundedButton74.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton74.BorderThickness = 1;
            this.siticoneRoundedButton74.CheckedState.Parent = this.siticoneRoundedButton74;
            this.siticoneRoundedButton74.CustomImages.Parent = this.siticoneRoundedButton74;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton74, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton74.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton74.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton74.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton74.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton74.HoveredState.Parent = this.siticoneRoundedButton74;
            this.siticoneRoundedButton74.Location = new System.Drawing.Point(310, 503);
            this.siticoneRoundedButton74.Name = "siticoneRoundedButton74";
            this.siticoneRoundedButton74.ShadowDecoration.Parent = this.siticoneRoundedButton74;
            this.siticoneRoundedButton74.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton74.TabIndex = 121;
            this.siticoneRoundedButton74.Text = "Unfreeze Classes";
            this.siticoneRoundedButton74.Click += new System.EventHandler(this.siticoneRoundedButton74_Click);
            // 
            // siticoneRoundedButton73
            // 
            this.siticoneRoundedButton73.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton73.BorderThickness = 1;
            this.siticoneRoundedButton73.CheckedState.Parent = this.siticoneRoundedButton73;
            this.siticoneRoundedButton73.CustomImages.Parent = this.siticoneRoundedButton73;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton73, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton73.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton73.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton73.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton73.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton73.HoveredState.Parent = this.siticoneRoundedButton73;
            this.siticoneRoundedButton73.Location = new System.Drawing.Point(6, 443);
            this.siticoneRoundedButton73.Name = "siticoneRoundedButton73";
            this.siticoneRoundedButton73.ShadowDecoration.Parent = this.siticoneRoundedButton73;
            this.siticoneRoundedButton73.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton73.TabIndex = 120;
            this.siticoneRoundedButton73.Text = "Quick Recovery";
            this.siticoneRoundedButton73.Click += new System.EventHandler(this.siticoneRoundedButton73_Click);
            // 
            // siticoneRoundedButton72
            // 
            this.siticoneRoundedButton72.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton72.BorderThickness = 1;
            this.siticoneRoundedButton72.CheckedState.Parent = this.siticoneRoundedButton72;
            this.siticoneRoundedButton72.CustomImages.Parent = this.siticoneRoundedButton72;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton72, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton72.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton72.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton72.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton72.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton72.HoveredState.Parent = this.siticoneRoundedButton72;
            this.siticoneRoundedButton72.Location = new System.Drawing.Point(158, 443);
            this.siticoneRoundedButton72.Name = "siticoneRoundedButton72";
            this.siticoneRoundedButton72.ShadowDecoration.Parent = this.siticoneRoundedButton72;
            this.siticoneRoundedButton72.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton72.TabIndex = 119;
            this.siticoneRoundedButton72.Text = "Reset Stats";
            this.siticoneRoundedButton72.Click += new System.EventHandler(this.siticoneRoundedButton72_Click);
            // 
            // siticoneRoundedButton71
            // 
            this.siticoneRoundedButton71.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton71.BorderThickness = 1;
            this.siticoneRoundedButton71.CheckedState.Parent = this.siticoneRoundedButton71;
            this.siticoneRoundedButton71.CustomImages.Parent = this.siticoneRoundedButton71;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton71, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton71.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton71.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton71.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton71.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton71.HoveredState.Parent = this.siticoneRoundedButton71;
            this.siticoneRoundedButton71.Location = new System.Drawing.Point(310, 443);
            this.siticoneRoundedButton71.Name = "siticoneRoundedButton71";
            this.siticoneRoundedButton71.ShadowDecoration.Parent = this.siticoneRoundedButton71;
            this.siticoneRoundedButton71.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton71.TabIndex = 118;
            this.siticoneRoundedButton71.Text = "Anti Probation";
            this.siticoneRoundedButton71.Click += new System.EventHandler(this.siticoneRoundedButton71_Click);
            // 
            // siticoneRoundedButton70
            // 
            this.siticoneRoundedButton70.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton70.BorderThickness = 1;
            this.siticoneRoundedButton70.CheckedState.Parent = this.siticoneRoundedButton70;
            this.siticoneRoundedButton70.CustomImages.Parent = this.siticoneRoundedButton70;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton70, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton70.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton70.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton70.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton70.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton70.HoveredState.Parent = this.siticoneRoundedButton70;
            this.siticoneRoundedButton70.Location = new System.Drawing.Point(462, 443);
            this.siticoneRoundedButton70.Name = "siticoneRoundedButton70";
            this.siticoneRoundedButton70.ShadowDecoration.Parent = this.siticoneRoundedButton70;
            this.siticoneRoundedButton70.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton70.TabIndex = 117;
            this.siticoneRoundedButton70.Text = "Unlock Tokens";
            this.siticoneRoundedButton70.Click += new System.EventHandler(this.siticoneRoundedButton70_Click);
            // 
            // siticoneRoundedButton69
            // 
            this.siticoneRoundedButton69.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton69.BorderThickness = 1;
            this.siticoneRoundedButton69.CheckedState.Parent = this.siticoneRoundedButton69;
            this.siticoneRoundedButton69.CustomImages.Parent = this.siticoneRoundedButton69;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton69, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton69.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton69.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton69.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton69.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton69.HoveredState.Parent = this.siticoneRoundedButton69;
            this.siticoneRoundedButton69.Location = new System.Drawing.Point(6, 473);
            this.siticoneRoundedButton69.Name = "siticoneRoundedButton69";
            this.siticoneRoundedButton69.ShadowDecoration.Parent = this.siticoneRoundedButton69;
            this.siticoneRoundedButton69.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton69.TabIndex = 116;
            this.siticoneRoundedButton69.Text = "Unlimited Classes";
            this.siticoneRoundedButton69.Click += new System.EventHandler(this.siticoneRoundedButton69_Click);
            // 
            // siticoneRoundedButton68
            // 
            this.siticoneRoundedButton68.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton68.BorderThickness = 1;
            this.siticoneRoundedButton68.CheckedState.Parent = this.siticoneRoundedButton68;
            this.siticoneRoundedButton68.CustomImages.Parent = this.siticoneRoundedButton68;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton68, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton68.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton68.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton68.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton68.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton68.HoveredState.Parent = this.siticoneRoundedButton68;
            this.siticoneRoundedButton68.Location = new System.Drawing.Point(158, 473);
            this.siticoneRoundedButton68.Name = "siticoneRoundedButton68";
            this.siticoneRoundedButton68.ShadowDecoration.Parent = this.siticoneRoundedButton68;
            this.siticoneRoundedButton68.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton68.TabIndex = 115;
            this.siticoneRoundedButton68.Text = "Unlock 10 Classes";
            this.siticoneRoundedButton68.Click += new System.EventHandler(this.siticoneRoundedButton68_Click);
            // 
            // siticoneRoundedButton67
            // 
            this.siticoneRoundedButton67.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton67.BorderThickness = 1;
            this.siticoneRoundedButton67.CheckedState.Parent = this.siticoneRoundedButton67;
            this.siticoneRoundedButton67.CustomImages.Parent = this.siticoneRoundedButton67;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton67, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton67.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton67.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton67.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton67.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton67.HoveredState.Parent = this.siticoneRoundedButton67;
            this.siticoneRoundedButton67.Location = new System.Drawing.Point(310, 473);
            this.siticoneRoundedButton67.Name = "siticoneRoundedButton67";
            this.siticoneRoundedButton67.ShadowDecoration.Parent = this.siticoneRoundedButton67;
            this.siticoneRoundedButton67.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton67.TabIndex = 114;
            this.siticoneRoundedButton67.Text = "Ghost Camo";
            this.siticoneRoundedButton67.Click += new System.EventHandler(this.siticoneRoundedButton67_Click);
            // 
            // siticoneRoundedButton65
            // 
            this.siticoneRoundedButton65.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton65.BorderThickness = 1;
            this.siticoneRoundedButton65.CheckedState.Parent = this.siticoneRoundedButton65;
            this.siticoneRoundedButton65.CustomImages.Parent = this.siticoneRoundedButton65;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton65, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton65.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton65.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton65.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton65.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton65.HoveredState.Parent = this.siticoneRoundedButton65;
            this.siticoneRoundedButton65.Location = new System.Drawing.Point(6, 503);
            this.siticoneRoundedButton65.Name = "siticoneRoundedButton65";
            this.siticoneRoundedButton65.ShadowDecoration.Parent = this.siticoneRoundedButton65;
            this.siticoneRoundedButton65.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton65.TabIndex = 112;
            this.siticoneRoundedButton65.Text = "Break Account";
            this.siticoneRoundedButton65.Click += new System.EventHandler(this.siticoneRoundedButton65_Click);
            // 
            // siticoneRoundedButton64
            // 
            this.siticoneRoundedButton64.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton64.BorderThickness = 1;
            this.siticoneRoundedButton64.CheckedState.Parent = this.siticoneRoundedButton64;
            this.siticoneRoundedButton64.CustomImages.Parent = this.siticoneRoundedButton64;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton64, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton64.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton64.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton64.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton64.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton64.HoveredState.Parent = this.siticoneRoundedButton64;
            this.siticoneRoundedButton64.Location = new System.Drawing.Point(158, 503);
            this.siticoneRoundedButton64.Name = "siticoneRoundedButton64";
            this.siticoneRoundedButton64.ShadowDecoration.Parent = this.siticoneRoundedButton64;
            this.siticoneRoundedButton64.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton64.TabIndex = 111;
            this.siticoneRoundedButton64.Text = "Freeze Classes";
            this.siticoneRoundedButton64.Click += new System.EventHandler(this.siticoneRoundedButton64_Click);
            // 
            // siticoneRoundedTextBox23
            // 
            this.siticoneRoundedTextBox23.AllowDrop = true;
            this.siticoneRoundedTextBox23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox23.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox23, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox23.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox23.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox23.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox23.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox23.DisabledState.Parent = this.siticoneRoundedTextBox23;
            this.siticoneRoundedTextBox23.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox23.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox23.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox23.FocusedState.Parent = this.siticoneRoundedTextBox23;
            this.siticoneRoundedTextBox23.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox23.HoveredState.Parent = this.siticoneRoundedTextBox23;
            this.siticoneRoundedTextBox23.Location = new System.Drawing.Point(228, 302);
            this.siticoneRoundedTextBox23.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox23.Name = "siticoneRoundedTextBox23";
            this.siticoneRoundedTextBox23.PasswordChar = '\0';
            this.siticoneRoundedTextBox23.PlaceholderText = "";
            this.siticoneRoundedTextBox23.SelectedText = "";
            this.siticoneRoundedTextBox23.ShadowDecoration.Parent = this.siticoneRoundedTextBox23;
            this.siticoneRoundedTextBox23.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox23.TabIndex = 110;
            this.siticoneRoundedTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox24
            // 
            this.siticoneRoundedTextBox24.AllowDrop = true;
            this.siticoneRoundedTextBox24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox24.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox24, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox24.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox24.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox24.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox24.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox24.DisabledState.Parent = this.siticoneRoundedTextBox24;
            this.siticoneRoundedTextBox24.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox24.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox24.FocusedState.Parent = this.siticoneRoundedTextBox24;
            this.siticoneRoundedTextBox24.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox24.HoveredState.Parent = this.siticoneRoundedTextBox24;
            this.siticoneRoundedTextBox24.Location = new System.Drawing.Point(229, 334);
            this.siticoneRoundedTextBox24.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox24.Name = "siticoneRoundedTextBox24";
            this.siticoneRoundedTextBox24.PasswordChar = '\0';
            this.siticoneRoundedTextBox24.PlaceholderText = "";
            this.siticoneRoundedTextBox24.SelectedText = "";
            this.siticoneRoundedTextBox24.ShadowDecoration.Parent = this.siticoneRoundedTextBox24;
            this.siticoneRoundedTextBox24.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox24.TabIndex = 109;
            this.siticoneRoundedTextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox25
            // 
            this.siticoneRoundedTextBox25.AllowDrop = true;
            this.siticoneRoundedTextBox25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox25.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox25, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox25.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox25.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox25.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox25.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox25.DisabledState.Parent = this.siticoneRoundedTextBox25;
            this.siticoneRoundedTextBox25.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox25.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox25.FocusedState.Parent = this.siticoneRoundedTextBox25;
            this.siticoneRoundedTextBox25.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox25.HoveredState.Parent = this.siticoneRoundedTextBox25;
            this.siticoneRoundedTextBox25.Location = new System.Drawing.Point(229, 366);
            this.siticoneRoundedTextBox25.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox25.Name = "siticoneRoundedTextBox25";
            this.siticoneRoundedTextBox25.PasswordChar = '\0';
            this.siticoneRoundedTextBox25.PlaceholderText = "";
            this.siticoneRoundedTextBox25.SelectedText = "";
            this.siticoneRoundedTextBox25.ShadowDecoration.Parent = this.siticoneRoundedTextBox25;
            this.siticoneRoundedTextBox25.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox25.TabIndex = 108;
            this.siticoneRoundedTextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox26
            // 
            this.siticoneRoundedTextBox26.AllowDrop = true;
            this.siticoneRoundedTextBox26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox26.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox26, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox26.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox26.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox26.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox26.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox26.DisabledState.Parent = this.siticoneRoundedTextBox26;
            this.siticoneRoundedTextBox26.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox26.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox26.FocusedState.Parent = this.siticoneRoundedTextBox26;
            this.siticoneRoundedTextBox26.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox26.HoveredState.Parent = this.siticoneRoundedTextBox26;
            this.siticoneRoundedTextBox26.Location = new System.Drawing.Point(228, 270);
            this.siticoneRoundedTextBox26.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox26.Name = "siticoneRoundedTextBox26";
            this.siticoneRoundedTextBox26.PasswordChar = '\0';
            this.siticoneRoundedTextBox26.PlaceholderText = "";
            this.siticoneRoundedTextBox26.SelectedText = "";
            this.siticoneRoundedTextBox26.ShadowDecoration.Parent = this.siticoneRoundedTextBox26;
            this.siticoneRoundedTextBox26.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox26.TabIndex = 107;
            this.siticoneRoundedTextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox27
            // 
            this.siticoneRoundedTextBox27.AllowDrop = true;
            this.siticoneRoundedTextBox27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox27.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox27, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox27.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox27.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox27.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox27.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox27.DisabledState.Parent = this.siticoneRoundedTextBox27;
            this.siticoneRoundedTextBox27.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox27.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox27.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox27.FocusedState.Parent = this.siticoneRoundedTextBox27;
            this.siticoneRoundedTextBox27.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox27.HoveredState.Parent = this.siticoneRoundedTextBox27;
            this.siticoneRoundedTextBox27.Location = new System.Drawing.Point(228, 206);
            this.siticoneRoundedTextBox27.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox27.Name = "siticoneRoundedTextBox27";
            this.siticoneRoundedTextBox27.PasswordChar = '\0';
            this.siticoneRoundedTextBox27.PlaceholderText = "";
            this.siticoneRoundedTextBox27.SelectedText = "";
            this.siticoneRoundedTextBox27.ShadowDecoration.Parent = this.siticoneRoundedTextBox27;
            this.siticoneRoundedTextBox27.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox27.TabIndex = 106;
            this.siticoneRoundedTextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox28
            // 
            this.siticoneRoundedTextBox28.AllowDrop = true;
            this.siticoneRoundedTextBox28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox28.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox28, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox28.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox28.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox28.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox28.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox28.DisabledState.Parent = this.siticoneRoundedTextBox28;
            this.siticoneRoundedTextBox28.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox28.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox28.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox28.FocusedState.Parent = this.siticoneRoundedTextBox28;
            this.siticoneRoundedTextBox28.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox28.HoveredState.Parent = this.siticoneRoundedTextBox28;
            this.siticoneRoundedTextBox28.Location = new System.Drawing.Point(228, 238);
            this.siticoneRoundedTextBox28.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox28.Name = "siticoneRoundedTextBox28";
            this.siticoneRoundedTextBox28.PasswordChar = '\0';
            this.siticoneRoundedTextBox28.PlaceholderText = "";
            this.siticoneRoundedTextBox28.SelectedText = "";
            this.siticoneRoundedTextBox28.ShadowDecoration.Parent = this.siticoneRoundedTextBox28;
            this.siticoneRoundedTextBox28.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox28.TabIndex = 105;
            this.siticoneRoundedTextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox29
            // 
            this.siticoneRoundedTextBox29.AllowDrop = true;
            this.siticoneRoundedTextBox29.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox29.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox29, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox29.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox29.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox29.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox29.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox29.DisabledState.Parent = this.siticoneRoundedTextBox29;
            this.siticoneRoundedTextBox29.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox29.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox29.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox29.FocusedState.Parent = this.siticoneRoundedTextBox29;
            this.siticoneRoundedTextBox29.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox29.HoveredState.Parent = this.siticoneRoundedTextBox29;
            this.siticoneRoundedTextBox29.Location = new System.Drawing.Point(228, 174);
            this.siticoneRoundedTextBox29.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox29.Name = "siticoneRoundedTextBox29";
            this.siticoneRoundedTextBox29.PasswordChar = '\0';
            this.siticoneRoundedTextBox29.PlaceholderText = "";
            this.siticoneRoundedTextBox29.SelectedText = "";
            this.siticoneRoundedTextBox29.ShadowDecoration.Parent = this.siticoneRoundedTextBox29;
            this.siticoneRoundedTextBox29.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox29.TabIndex = 104;
            this.siticoneRoundedTextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox30
            // 
            this.siticoneRoundedTextBox30.AllowDrop = true;
            this.siticoneRoundedTextBox30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox30.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox30, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox30.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox30.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox30.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox30.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox30.DisabledState.Parent = this.siticoneRoundedTextBox30;
            this.siticoneRoundedTextBox30.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox30.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox30.FocusedState.Parent = this.siticoneRoundedTextBox30;
            this.siticoneRoundedTextBox30.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox30.HoveredState.Parent = this.siticoneRoundedTextBox30;
            this.siticoneRoundedTextBox30.Location = new System.Drawing.Point(228, 142);
            this.siticoneRoundedTextBox30.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox30.Name = "siticoneRoundedTextBox30";
            this.siticoneRoundedTextBox30.PasswordChar = '\0';
            this.siticoneRoundedTextBox30.PlaceholderText = "";
            this.siticoneRoundedTextBox30.SelectedText = "";
            this.siticoneRoundedTextBox30.ShadowDecoration.Parent = this.siticoneRoundedTextBox30;
            this.siticoneRoundedTextBox30.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox30.TabIndex = 103;
            this.siticoneRoundedTextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox31
            // 
            this.siticoneRoundedTextBox31.AllowDrop = true;
            this.siticoneRoundedTextBox31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox31.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox31, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox31.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox31.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox31.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox31.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox31.DisabledState.Parent = this.siticoneRoundedTextBox31;
            this.siticoneRoundedTextBox31.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox31.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox31.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox31.FocusedState.Parent = this.siticoneRoundedTextBox31;
            this.siticoneRoundedTextBox31.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox31.HoveredState.Parent = this.siticoneRoundedTextBox31;
            this.siticoneRoundedTextBox31.Location = new System.Drawing.Point(228, 110);
            this.siticoneRoundedTextBox31.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox31.Name = "siticoneRoundedTextBox31";
            this.siticoneRoundedTextBox31.PasswordChar = '\0';
            this.siticoneRoundedTextBox31.PlaceholderText = "";
            this.siticoneRoundedTextBox31.SelectedText = "";
            this.siticoneRoundedTextBox31.ShadowDecoration.Parent = this.siticoneRoundedTextBox31;
            this.siticoneRoundedTextBox31.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox31.TabIndex = 102;
            this.siticoneRoundedTextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox32
            // 
            this.siticoneRoundedTextBox32.AllowDrop = true;
            this.siticoneRoundedTextBox32.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox32.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox32, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox32.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox32.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox32.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox32.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox32.DisabledState.Parent = this.siticoneRoundedTextBox32;
            this.siticoneRoundedTextBox32.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox32.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox32.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox32.FocusedState.Parent = this.siticoneRoundedTextBox32;
            this.siticoneRoundedTextBox32.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox32.HoveredState.Parent = this.siticoneRoundedTextBox32;
            this.siticoneRoundedTextBox32.Location = new System.Drawing.Point(228, 78);
            this.siticoneRoundedTextBox32.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox32.Name = "siticoneRoundedTextBox32";
            this.siticoneRoundedTextBox32.PasswordChar = '\0';
            this.siticoneRoundedTextBox32.PlaceholderText = "";
            this.siticoneRoundedTextBox32.SelectedText = "";
            this.siticoneRoundedTextBox32.ShadowDecoration.Parent = this.siticoneRoundedTextBox32;
            this.siticoneRoundedTextBox32.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox32.TabIndex = 101;
            this.siticoneRoundedTextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton62
            // 
            this.siticoneRoundedButton62.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton62.BorderThickness = 1;
            this.siticoneRoundedButton62.CheckedState.Parent = this.siticoneRoundedButton62;
            this.siticoneRoundedButton62.CustomImages.Parent = this.siticoneRoundedButton62;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton62, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton62.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton62.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton62.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton62.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton62.HoveredState.Parent = this.siticoneRoundedButton62;
            this.siticoneRoundedButton62.Location = new System.Drawing.Point(228, 397);
            this.siticoneRoundedButton62.Name = "siticoneRoundedButton62";
            this.siticoneRoundedButton62.ShadowDecoration.Parent = this.siticoneRoundedButton62;
            this.siticoneRoundedButton62.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedButton62.TabIndex = 100;
            this.siticoneRoundedButton62.Text = "Read\'s Class Names";
            this.siticoneRoundedButton62.Click += new System.EventHandler(this.siticoneRoundedButton62_Click);
            // 
            // siticoneRoundedButton63
            // 
            this.siticoneRoundedButton63.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton63.BorderThickness = 1;
            this.siticoneRoundedButton63.CheckedState.Parent = this.siticoneRoundedButton63;
            this.siticoneRoundedButton63.CustomImages.Parent = this.siticoneRoundedButton63;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton63, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton63.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton63.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton63.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton63.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton63.HoveredState.Parent = this.siticoneRoundedButton63;
            this.siticoneRoundedButton63.Location = new System.Drawing.Point(228, 15);
            this.siticoneRoundedButton63.Name = "siticoneRoundedButton63";
            this.siticoneRoundedButton63.ShadowDecoration.Parent = this.siticoneRoundedButton63;
            this.siticoneRoundedButton63.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedButton63.TabIndex = 99;
            this.siticoneRoundedButton63.Text = "Set All Class Names";
            this.siticoneRoundedButton63.Click += new System.EventHandler(this.siticoneRoundedButton63_Click);
            // 
            // siticoneRoundedTextBox33
            // 
            this.siticoneRoundedTextBox33.AllowDrop = true;
            this.siticoneRoundedTextBox33.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox33.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox33, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox33.DefaultText = "Read^5#4363";
            this.siticoneRoundedTextBox33.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox33.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox33.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox33.DisabledState.Parent = this.siticoneRoundedTextBox33;
            this.siticoneRoundedTextBox33.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox33.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox33.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox33.FocusedState.Parent = this.siticoneRoundedTextBox33;
            this.siticoneRoundedTextBox33.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox33.HoveredState.Parent = this.siticoneRoundedTextBox33;
            this.siticoneRoundedTextBox33.Location = new System.Drawing.Point(228, 46);
            this.siticoneRoundedTextBox33.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox33.Name = "siticoneRoundedTextBox33";
            this.siticoneRoundedTextBox33.PasswordChar = '\0';
            this.siticoneRoundedTextBox33.PlaceholderText = "";
            this.siticoneRoundedTextBox33.SelectedText = "";
            this.siticoneRoundedTextBox33.ShadowDecoration.Parent = this.siticoneRoundedTextBox33;
            this.siticoneRoundedTextBox33.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox33.TabIndex = 98;
            this.siticoneRoundedTextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox22
            // 
            this.siticoneRoundedTextBox22.AllowDrop = true;
            this.siticoneRoundedTextBox22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox22, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox22.DefaultText = "System Link";
            this.siticoneRoundedTextBox22.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox22.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox22.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox22.DisabledState.Parent = this.siticoneRoundedTextBox22;
            this.siticoneRoundedTextBox22.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox22.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox22.FocusedState.Parent = this.siticoneRoundedTextBox22;
            this.siticoneRoundedTextBox22.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox22.HoveredState.Parent = this.siticoneRoundedTextBox22;
            this.siticoneRoundedTextBox22.Location = new System.Drawing.Point(3, 302);
            this.siticoneRoundedTextBox22.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox22.Name = "siticoneRoundedTextBox22";
            this.siticoneRoundedTextBox22.PasswordChar = '\0';
            this.siticoneRoundedTextBox22.PlaceholderText = "";
            this.siticoneRoundedTextBox22.SelectedText = "";
            this.siticoneRoundedTextBox22.ShadowDecoration.Parent = this.siticoneRoundedTextBox22;
            this.siticoneRoundedTextBox22.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox22.TabIndex = 97;
            this.siticoneRoundedTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox21
            // 
            this.siticoneRoundedTextBox21.AllowDrop = true;
            this.siticoneRoundedTextBox21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox21, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox21.DefaultText = "Main Menu";
            this.siticoneRoundedTextBox21.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox21.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox21.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox21.DisabledState.Parent = this.siticoneRoundedTextBox21;
            this.siticoneRoundedTextBox21.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox21.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox21.FocusedState.Parent = this.siticoneRoundedTextBox21;
            this.siticoneRoundedTextBox21.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox21.HoveredState.Parent = this.siticoneRoundedTextBox21;
            this.siticoneRoundedTextBox21.Location = new System.Drawing.Point(4, 334);
            this.siticoneRoundedTextBox21.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox21.Name = "siticoneRoundedTextBox21";
            this.siticoneRoundedTextBox21.PasswordChar = '\0';
            this.siticoneRoundedTextBox21.PlaceholderText = "";
            this.siticoneRoundedTextBox21.SelectedText = "";
            this.siticoneRoundedTextBox21.ShadowDecoration.Parent = this.siticoneRoundedTextBox21;
            this.siticoneRoundedTextBox21.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox21.TabIndex = 96;
            this.siticoneRoundedTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox20
            // 
            this.siticoneRoundedTextBox20.AllowDrop = true;
            this.siticoneRoundedTextBox20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox20.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox20, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox20.DefaultText = "Score Streaks";
            this.siticoneRoundedTextBox20.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox20.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox20.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox20.DisabledState.Parent = this.siticoneRoundedTextBox20;
            this.siticoneRoundedTextBox20.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox20.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox20.FocusedState.Parent = this.siticoneRoundedTextBox20;
            this.siticoneRoundedTextBox20.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox20.HoveredState.Parent = this.siticoneRoundedTextBox20;
            this.siticoneRoundedTextBox20.Location = new System.Drawing.Point(4, 366);
            this.siticoneRoundedTextBox20.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox20.Name = "siticoneRoundedTextBox20";
            this.siticoneRoundedTextBox20.PasswordChar = '\0';
            this.siticoneRoundedTextBox20.PlaceholderText = "";
            this.siticoneRoundedTextBox20.SelectedText = "";
            this.siticoneRoundedTextBox20.ShadowDecoration.Parent = this.siticoneRoundedTextBox20;
            this.siticoneRoundedTextBox20.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox20.TabIndex = 95;
            this.siticoneRoundedTextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox19
            // 
            this.siticoneRoundedTextBox19.AllowDrop = true;
            this.siticoneRoundedTextBox19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox19, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox19.DefaultText = "Xbox Live";
            this.siticoneRoundedTextBox19.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox19.DisabledState.Parent = this.siticoneRoundedTextBox19;
            this.siticoneRoundedTextBox19.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox19.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox19.FocusedState.Parent = this.siticoneRoundedTextBox19;
            this.siticoneRoundedTextBox19.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox19.HoveredState.Parent = this.siticoneRoundedTextBox19;
            this.siticoneRoundedTextBox19.Location = new System.Drawing.Point(3, 270);
            this.siticoneRoundedTextBox19.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox19.Name = "siticoneRoundedTextBox19";
            this.siticoneRoundedTextBox19.PasswordChar = '\0';
            this.siticoneRoundedTextBox19.PlaceholderText = "";
            this.siticoneRoundedTextBox19.SelectedText = "";
            this.siticoneRoundedTextBox19.ShadowDecoration.Parent = this.siticoneRoundedTextBox19;
            this.siticoneRoundedTextBox19.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox19.TabIndex = 94;
            this.siticoneRoundedTextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox18
            // 
            this.siticoneRoundedTextBox18.AllowDrop = true;
            this.siticoneRoundedTextBox18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox18.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox18, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox18.DefaultText = "League";
            this.siticoneRoundedTextBox18.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox18.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox18.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox18.DisabledState.Parent = this.siticoneRoundedTextBox18;
            this.siticoneRoundedTextBox18.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox18.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox18.FocusedState.Parent = this.siticoneRoundedTextBox18;
            this.siticoneRoundedTextBox18.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox18.HoveredState.Parent = this.siticoneRoundedTextBox18;
            this.siticoneRoundedTextBox18.Location = new System.Drawing.Point(3, 206);
            this.siticoneRoundedTextBox18.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox18.Name = "siticoneRoundedTextBox18";
            this.siticoneRoundedTextBox18.PasswordChar = '\0';
            this.siticoneRoundedTextBox18.PlaceholderText = "";
            this.siticoneRoundedTextBox18.SelectedText = "";
            this.siticoneRoundedTextBox18.ShadowDecoration.Parent = this.siticoneRoundedTextBox18;
            this.siticoneRoundedTextBox18.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox18.TabIndex = 93;
            this.siticoneRoundedTextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox17
            // 
            this.siticoneRoundedTextBox17.AllowDrop = true;
            this.siticoneRoundedTextBox17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox17.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox17, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox17.DefaultText = "Store";
            this.siticoneRoundedTextBox17.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox17.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox17.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox17.DisabledState.Parent = this.siticoneRoundedTextBox17;
            this.siticoneRoundedTextBox17.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox17.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox17.FocusedState.Parent = this.siticoneRoundedTextBox17;
            this.siticoneRoundedTextBox17.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox17.HoveredState.Parent = this.siticoneRoundedTextBox17;
            this.siticoneRoundedTextBox17.Location = new System.Drawing.Point(3, 238);
            this.siticoneRoundedTextBox17.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox17.Name = "siticoneRoundedTextBox17";
            this.siticoneRoundedTextBox17.PasswordChar = '\0';
            this.siticoneRoundedTextBox17.PlaceholderText = "";
            this.siticoneRoundedTextBox17.SelectedText = "";
            this.siticoneRoundedTextBox17.ShadowDecoration.Parent = this.siticoneRoundedTextBox17;
            this.siticoneRoundedTextBox17.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox17.TabIndex = 92;
            this.siticoneRoundedTextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox16
            // 
            this.siticoneRoundedTextBox16.AllowDrop = true;
            this.siticoneRoundedTextBox16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox16.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox16, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox16.DefaultText = "Theater";
            this.siticoneRoundedTextBox16.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox16.DisabledState.Parent = this.siticoneRoundedTextBox16;
            this.siticoneRoundedTextBox16.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox16.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox16.FocusedState.Parent = this.siticoneRoundedTextBox16;
            this.siticoneRoundedTextBox16.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox16.HoveredState.Parent = this.siticoneRoundedTextBox16;
            this.siticoneRoundedTextBox16.Location = new System.Drawing.Point(3, 174);
            this.siticoneRoundedTextBox16.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox16.Name = "siticoneRoundedTextBox16";
            this.siticoneRoundedTextBox16.PasswordChar = '\0';
            this.siticoneRoundedTextBox16.PlaceholderText = "";
            this.siticoneRoundedTextBox16.SelectedText = "";
            this.siticoneRoundedTextBox16.ShadowDecoration.Parent = this.siticoneRoundedTextBox16;
            this.siticoneRoundedTextBox16.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox16.TabIndex = 91;
            this.siticoneRoundedTextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox15
            // 
            this.siticoneRoundedTextBox15.AllowDrop = true;
            this.siticoneRoundedTextBox15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox15.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox15, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox15.DefaultText = "Barracks";
            this.siticoneRoundedTextBox15.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox15.DisabledState.Parent = this.siticoneRoundedTextBox15;
            this.siticoneRoundedTextBox15.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox15.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox15.FocusedState.Parent = this.siticoneRoundedTextBox15;
            this.siticoneRoundedTextBox15.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox15.HoveredState.Parent = this.siticoneRoundedTextBox15;
            this.siticoneRoundedTextBox15.Location = new System.Drawing.Point(3, 142);
            this.siticoneRoundedTextBox15.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox15.Name = "siticoneRoundedTextBox15";
            this.siticoneRoundedTextBox15.PasswordChar = '\0';
            this.siticoneRoundedTextBox15.PlaceholderText = "";
            this.siticoneRoundedTextBox15.SelectedText = "";
            this.siticoneRoundedTextBox15.ShadowDecoration.Parent = this.siticoneRoundedTextBox15;
            this.siticoneRoundedTextBox15.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox15.TabIndex = 90;
            this.siticoneRoundedTextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox14
            // 
            this.siticoneRoundedTextBox14.AllowDrop = true;
            this.siticoneRoundedTextBox14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox14, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox14.DefaultText = "Create A Class";
            this.siticoneRoundedTextBox14.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox14.DisabledState.Parent = this.siticoneRoundedTextBox14;
            this.siticoneRoundedTextBox14.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox14.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox14.FocusedState.Parent = this.siticoneRoundedTextBox14;
            this.siticoneRoundedTextBox14.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox14.HoveredState.Parent = this.siticoneRoundedTextBox14;
            this.siticoneRoundedTextBox14.Location = new System.Drawing.Point(3, 110);
            this.siticoneRoundedTextBox14.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox14.Name = "siticoneRoundedTextBox14";
            this.siticoneRoundedTextBox14.PasswordChar = '\0';
            this.siticoneRoundedTextBox14.PlaceholderText = "";
            this.siticoneRoundedTextBox14.SelectedText = "";
            this.siticoneRoundedTextBox14.ShadowDecoration.Parent = this.siticoneRoundedTextBox14;
            this.siticoneRoundedTextBox14.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox14.TabIndex = 89;
            this.siticoneRoundedTextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox13
            // 
            this.siticoneRoundedTextBox13.AllowDrop = true;
            this.siticoneRoundedTextBox13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox13, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox13.DefaultText = "Custom Games";
            this.siticoneRoundedTextBox13.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox13.DisabledState.Parent = this.siticoneRoundedTextBox13;
            this.siticoneRoundedTextBox13.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox13.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox13.FocusedState.Parent = this.siticoneRoundedTextBox13;
            this.siticoneRoundedTextBox13.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox13.HoveredState.Parent = this.siticoneRoundedTextBox13;
            this.siticoneRoundedTextBox13.Location = new System.Drawing.Point(3, 78);
            this.siticoneRoundedTextBox13.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox13.Name = "siticoneRoundedTextBox13";
            this.siticoneRoundedTextBox13.PasswordChar = '\0';
            this.siticoneRoundedTextBox13.PlaceholderText = "";
            this.siticoneRoundedTextBox13.SelectedText = "";
            this.siticoneRoundedTextBox13.ShadowDecoration.Parent = this.siticoneRoundedTextBox13;
            this.siticoneRoundedTextBox13.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox13.TabIndex = 88;
            this.siticoneRoundedTextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton61
            // 
            this.siticoneRoundedButton61.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton61.BorderThickness = 1;
            this.siticoneRoundedButton61.CheckedState.Parent = this.siticoneRoundedButton61;
            this.siticoneRoundedButton61.CustomImages.Parent = this.siticoneRoundedButton61;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton61, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton61.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton61.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton61.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton61.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton61.HoveredState.Parent = this.siticoneRoundedButton61;
            this.siticoneRoundedButton61.Location = new System.Drawing.Point(3, 397);
            this.siticoneRoundedButton61.Name = "siticoneRoundedButton61";
            this.siticoneRoundedButton61.ShadowDecoration.Parent = this.siticoneRoundedButton61;
            this.siticoneRoundedButton61.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedButton61.TabIndex = 87;
            this.siticoneRoundedButton61.Text = "Reset Zones";
            this.siticoneRoundedButton61.Click += new System.EventHandler(this.siticoneRoundedButton61_Click);
            // 
            // siticoneRoundedButton60
            // 
            this.siticoneRoundedButton60.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton60.BorderThickness = 1;
            this.siticoneRoundedButton60.CheckedState.Parent = this.siticoneRoundedButton60;
            this.siticoneRoundedButton60.CustomImages.Parent = this.siticoneRoundedButton60;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton60, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton60.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton60.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton60.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton60.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton60.HoveredState.Parent = this.siticoneRoundedButton60;
            this.siticoneRoundedButton60.Location = new System.Drawing.Point(3, 15);
            this.siticoneRoundedButton60.Name = "siticoneRoundedButton60";
            this.siticoneRoundedButton60.ShadowDecoration.Parent = this.siticoneRoundedButton60;
            this.siticoneRoundedButton60.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedButton60.TabIndex = 86;
            this.siticoneRoundedButton60.Text = "Set Zones";
            this.siticoneRoundedButton60.Click += new System.EventHandler(this.siticoneRoundedButton60_Click);
            // 
            // siticoneRoundedTextBox12
            // 
            this.siticoneRoundedTextBox12.AllowDrop = true;
            this.siticoneRoundedTextBox12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox12.DefaultText = "Public Match";
            this.siticoneRoundedTextBox12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox12.DisabledState.Parent = this.siticoneRoundedTextBox12;
            this.siticoneRoundedTextBox12.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox12.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox12.FocusedState.Parent = this.siticoneRoundedTextBox12;
            this.siticoneRoundedTextBox12.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox12.HoveredState.Parent = this.siticoneRoundedTextBox12;
            this.siticoneRoundedTextBox12.Location = new System.Drawing.Point(3, 46);
            this.siticoneRoundedTextBox12.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox12.Name = "siticoneRoundedTextBox12";
            this.siticoneRoundedTextBox12.PasswordChar = '\0';
            this.siticoneRoundedTextBox12.PlaceholderText = "";
            this.siticoneRoundedTextBox12.SelectedText = "";
            this.siticoneRoundedTextBox12.ShadowDecoration.Parent = this.siticoneRoundedTextBox12;
            this.siticoneRoundedTextBox12.Size = new System.Drawing.Size(218, 24);
            this.siticoneRoundedTextBox12.TabIndex = 85;
            this.siticoneRoundedTextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage8.Controls.Add(this.label5);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton163);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton161);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton162);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton160);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton159);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton158);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton157);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton156);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton155);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton154);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton153);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton152);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton151);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton150);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton149);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton148);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton147);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton146);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton145);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton144);
            this.tabPage8.Controls.Add(this.label3);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton143);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton142);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton141);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton140);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton139);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton138);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton137);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton136);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton135);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton42);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton131);
            this.siticoneTransition1.SetDecoration(this.tabPage8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage8.Location = new System.Drawing.Point(184, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(878, 540);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Change Maps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(289, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 19);
            this.label5.TabIndex = 200;
            this.label5.Text = "Use These Buttons For In-Game";
            // 
            // siticoneRoundedButton163
            // 
            this.siticoneRoundedButton163.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton163.BorderThickness = 1;
            this.siticoneRoundedButton163.CheckedState.Parent = this.siticoneRoundedButton163;
            this.siticoneRoundedButton163.CustomImages.Parent = this.siticoneRoundedButton163;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton163, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton163.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton163.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton163.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton163.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton163.HoveredState.Parent = this.siticoneRoundedButton163;
            this.siticoneRoundedButton163.Location = new System.Drawing.Point(576, 50);
            this.siticoneRoundedButton163.Name = "siticoneRoundedButton163";
            this.siticoneRoundedButton163.ShadowDecoration.Parent = this.siticoneRoundedButton163;
            this.siticoneRoundedButton163.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton163.TabIndex = 199;
            this.siticoneRoundedButton163.Text = "Pod";
            this.siticoneRoundedButton163.Click += new System.EventHandler(this.siticoneRoundedButton163_Click);
            // 
            // siticoneRoundedButton161
            // 
            this.siticoneRoundedButton161.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton161.BorderThickness = 1;
            this.siticoneRoundedButton161.CheckedState.Parent = this.siticoneRoundedButton161;
            this.siticoneRoundedButton161.CustomImages.Parent = this.siticoneRoundedButton161;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton161, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton161.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton161.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton161.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton161.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton161.HoveredState.Parent = this.siticoneRoundedButton161;
            this.siticoneRoundedButton161.Location = new System.Drawing.Point(576, 85);
            this.siticoneRoundedButton161.Name = "siticoneRoundedButton161";
            this.siticoneRoundedButton161.ShadowDecoration.Parent = this.siticoneRoundedButton161;
            this.siticoneRoundedButton161.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton161.TabIndex = 198;
            this.siticoneRoundedButton161.Text = "Takeoff";
            this.siticoneRoundedButton161.Click += new System.EventHandler(this.siticoneRoundedButton161_Click);
            // 
            // siticoneRoundedButton162
            // 
            this.siticoneRoundedButton162.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton162.BorderThickness = 1;
            this.siticoneRoundedButton162.CheckedState.Parent = this.siticoneRoundedButton162;
            this.siticoneRoundedButton162.CustomImages.Parent = this.siticoneRoundedButton162;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton162, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton162.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton162.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton162.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton162.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton162.HoveredState.Parent = this.siticoneRoundedButton162;
            this.siticoneRoundedButton162.Location = new System.Drawing.Point(398, 503);
            this.siticoneRoundedButton162.Name = "siticoneRoundedButton162";
            this.siticoneRoundedButton162.ShadowDecoration.Parent = this.siticoneRoundedButton162;
            this.siticoneRoundedButton162.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton162.TabIndex = 197;
            this.siticoneRoundedButton162.Text = "Frost";
            this.siticoneRoundedButton162.Click += new System.EventHandler(this.siticoneRoundedButton162_Click);
            // 
            // siticoneRoundedButton160
            // 
            this.siticoneRoundedButton160.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton160.BorderThickness = 1;
            this.siticoneRoundedButton160.CheckedState.Parent = this.siticoneRoundedButton160;
            this.siticoneRoundedButton160.CustomImages.Parent = this.siticoneRoundedButton160;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton160, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton160.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton160.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton160.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton160.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton160.HoveredState.Parent = this.siticoneRoundedButton160;
            this.siticoneRoundedButton160.Location = new System.Drawing.Point(398, 435);
            this.siticoneRoundedButton160.Name = "siticoneRoundedButton160";
            this.siticoneRoundedButton160.ShadowDecoration.Parent = this.siticoneRoundedButton160;
            this.siticoneRoundedButton160.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton160.TabIndex = 195;
            this.siticoneRoundedButton160.Text = "Rush";
            this.siticoneRoundedButton160.Click += new System.EventHandler(this.siticoneRoundedButton160_Click);
            // 
            // siticoneRoundedButton159
            // 
            this.siticoneRoundedButton159.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton159.BorderThickness = 1;
            this.siticoneRoundedButton159.CheckedState.Parent = this.siticoneRoundedButton159;
            this.siticoneRoundedButton159.CustomImages.Parent = this.siticoneRoundedButton159;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton159, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton159.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton159.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton159.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton159.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton159.HoveredState.Parent = this.siticoneRoundedButton159;
            this.siticoneRoundedButton159.Location = new System.Drawing.Point(398, 400);
            this.siticoneRoundedButton159.Name = "siticoneRoundedButton159";
            this.siticoneRoundedButton159.ShadowDecoration.Parent = this.siticoneRoundedButton159;
            this.siticoneRoundedButton159.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton159.TabIndex = 194;
            this.siticoneRoundedButton159.Text = "Cove";
            this.siticoneRoundedButton159.Click += new System.EventHandler(this.siticoneRoundedButton159_Click);
            // 
            // siticoneRoundedButton158
            // 
            this.siticoneRoundedButton158.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton158.BorderThickness = 1;
            this.siticoneRoundedButton158.CheckedState.Parent = this.siticoneRoundedButton158;
            this.siticoneRoundedButton158.CustomImages.Parent = this.siticoneRoundedButton158;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton158, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton158.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton158.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton158.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton158.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton158.HoveredState.Parent = this.siticoneRoundedButton158;
            this.siticoneRoundedButton158.Location = new System.Drawing.Point(398, 365);
            this.siticoneRoundedButton158.Name = "siticoneRoundedButton158";
            this.siticoneRoundedButton158.ShadowDecoration.Parent = this.siticoneRoundedButton158;
            this.siticoneRoundedButton158.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton158.TabIndex = 193;
            this.siticoneRoundedButton158.Text = "Detour";
            this.siticoneRoundedButton158.Click += new System.EventHandler(this.siticoneRoundedButton158_Click);
            // 
            // siticoneRoundedButton157
            // 
            this.siticoneRoundedButton157.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton157.BorderThickness = 1;
            this.siticoneRoundedButton157.CheckedState.Parent = this.siticoneRoundedButton157;
            this.siticoneRoundedButton157.CustomImages.Parent = this.siticoneRoundedButton157;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton157, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton157.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton157.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton157.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton157.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton157.HoveredState.Parent = this.siticoneRoundedButton157;
            this.siticoneRoundedButton157.Location = new System.Drawing.Point(398, 330);
            this.siticoneRoundedButton157.Name = "siticoneRoundedButton157";
            this.siticoneRoundedButton157.ShadowDecoration.Parent = this.siticoneRoundedButton157;
            this.siticoneRoundedButton157.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton157.TabIndex = 192;
            this.siticoneRoundedButton157.Text = "Uplink";
            this.siticoneRoundedButton157.Click += new System.EventHandler(this.siticoneRoundedButton157_Click);
            // 
            // siticoneRoundedButton156
            // 
            this.siticoneRoundedButton156.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton156.BorderThickness = 1;
            this.siticoneRoundedButton156.CheckedState.Parent = this.siticoneRoundedButton156;
            this.siticoneRoundedButton156.CustomImages.Parent = this.siticoneRoundedButton156;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton156, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton156.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton156.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton156.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton156.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton156.HoveredState.Parent = this.siticoneRoundedButton156;
            this.siticoneRoundedButton156.Location = new System.Drawing.Point(398, 295);
            this.siticoneRoundedButton156.Name = "siticoneRoundedButton156";
            this.siticoneRoundedButton156.ShadowDecoration.Parent = this.siticoneRoundedButton156;
            this.siticoneRoundedButton156.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton156.TabIndex = 191;
            this.siticoneRoundedButton156.Text = "Vertigo";
            this.siticoneRoundedButton156.Click += new System.EventHandler(this.siticoneRoundedButton156_Click);
            // 
            // siticoneRoundedButton155
            // 
            this.siticoneRoundedButton155.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton155.BorderThickness = 1;
            this.siticoneRoundedButton155.CheckedState.Parent = this.siticoneRoundedButton155;
            this.siticoneRoundedButton155.CustomImages.Parent = this.siticoneRoundedButton155;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton155, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton155.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton155.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton155.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton155.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton155.HoveredState.Parent = this.siticoneRoundedButton155;
            this.siticoneRoundedButton155.Location = new System.Drawing.Point(398, 260);
            this.siticoneRoundedButton155.Name = "siticoneRoundedButton155";
            this.siticoneRoundedButton155.ShadowDecoration.Parent = this.siticoneRoundedButton155;
            this.siticoneRoundedButton155.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton155.TabIndex = 190;
            this.siticoneRoundedButton155.Text = "Magma";
            this.siticoneRoundedButton155.Click += new System.EventHandler(this.siticoneRoundedButton155_Click);
            // 
            // siticoneRoundedButton154
            // 
            this.siticoneRoundedButton154.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton154.BorderThickness = 1;
            this.siticoneRoundedButton154.CheckedState.Parent = this.siticoneRoundedButton154;
            this.siticoneRoundedButton154.CustomImages.Parent = this.siticoneRoundedButton154;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton154, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton154.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton154.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton154.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton154.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton154.HoveredState.Parent = this.siticoneRoundedButton154;
            this.siticoneRoundedButton154.Location = new System.Drawing.Point(398, 120);
            this.siticoneRoundedButton154.Name = "siticoneRoundedButton154";
            this.siticoneRoundedButton154.ShadowDecoration.Parent = this.siticoneRoundedButton154;
            this.siticoneRoundedButton154.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton154.TabIndex = 189;
            this.siticoneRoundedButton154.Text = "Mirage";
            this.siticoneRoundedButton154.Click += new System.EventHandler(this.siticoneRoundedButton154_Click);
            // 
            // siticoneRoundedButton153
            // 
            this.siticoneRoundedButton153.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton153.BorderThickness = 1;
            this.siticoneRoundedButton153.CheckedState.Parent = this.siticoneRoundedButton153;
            this.siticoneRoundedButton153.CustomImages.Parent = this.siticoneRoundedButton153;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton153, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton153.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton153.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton153.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton153.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton153.HoveredState.Parent = this.siticoneRoundedButton153;
            this.siticoneRoundedButton153.Location = new System.Drawing.Point(398, 155);
            this.siticoneRoundedButton153.Name = "siticoneRoundedButton153";
            this.siticoneRoundedButton153.ShadowDecoration.Parent = this.siticoneRoundedButton153;
            this.siticoneRoundedButton153.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton153.TabIndex = 188;
            this.siticoneRoundedButton153.Text = "Hydro";
            this.siticoneRoundedButton153.Click += new System.EventHandler(this.siticoneRoundedButton153_Click);
            // 
            // siticoneRoundedButton152
            // 
            this.siticoneRoundedButton152.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton152.BorderThickness = 1;
            this.siticoneRoundedButton152.CheckedState.Parent = this.siticoneRoundedButton152;
            this.siticoneRoundedButton152.CustomImages.Parent = this.siticoneRoundedButton152;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton152, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton152.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton152.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton152.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton152.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton152.HoveredState.Parent = this.siticoneRoundedButton152;
            this.siticoneRoundedButton152.Location = new System.Drawing.Point(398, 190);
            this.siticoneRoundedButton152.Name = "siticoneRoundedButton152";
            this.siticoneRoundedButton152.ShadowDecoration.Parent = this.siticoneRoundedButton152;
            this.siticoneRoundedButton152.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton152.TabIndex = 187;
            this.siticoneRoundedButton152.Text = "Grind";
            this.siticoneRoundedButton152.Click += new System.EventHandler(this.siticoneRoundedButton152_Click);
            // 
            // siticoneRoundedButton151
            // 
            this.siticoneRoundedButton151.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton151.BorderThickness = 1;
            this.siticoneRoundedButton151.CheckedState.Parent = this.siticoneRoundedButton151;
            this.siticoneRoundedButton151.CustomImages.Parent = this.siticoneRoundedButton151;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton151, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton151.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton151.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton151.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton151.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton151.HoveredState.Parent = this.siticoneRoundedButton151;
            this.siticoneRoundedButton151.Location = new System.Drawing.Point(398, 470);
            this.siticoneRoundedButton151.Name = "siticoneRoundedButton151";
            this.siticoneRoundedButton151.ShadowDecoration.Parent = this.siticoneRoundedButton151;
            this.siticoneRoundedButton151.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton151.TabIndex = 186;
            this.siticoneRoundedButton151.Text = "Dig";
            this.siticoneRoundedButton151.Click += new System.EventHandler(this.siticoneRoundedButton151_Click);
            // 
            // siticoneRoundedButton150
            // 
            this.siticoneRoundedButton150.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton150.BorderThickness = 1;
            this.siticoneRoundedButton150.CheckedState.Parent = this.siticoneRoundedButton150;
            this.siticoneRoundedButton150.CustomImages.Parent = this.siticoneRoundedButton150;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton150, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton150.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton150.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton150.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton150.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton150.HoveredState.Parent = this.siticoneRoundedButton150;
            this.siticoneRoundedButton150.Location = new System.Drawing.Point(398, 225);
            this.siticoneRoundedButton150.Name = "siticoneRoundedButton150";
            this.siticoneRoundedButton150.ShadowDecoration.Parent = this.siticoneRoundedButton150;
            this.siticoneRoundedButton150.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton150.TabIndex = 185;
            this.siticoneRoundedButton150.Text = "Encore";
            this.siticoneRoundedButton150.Click += new System.EventHandler(this.siticoneRoundedButton150_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(553, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 184;
            this.label4.Text = "DLC\'s";
            // 
            // siticoneRoundedButton149
            // 
            this.siticoneRoundedButton149.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton149.BorderThickness = 1;
            this.siticoneRoundedButton149.CheckedState.Parent = this.siticoneRoundedButton149;
            this.siticoneRoundedButton149.CustomImages.Parent = this.siticoneRoundedButton149;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton149, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton149.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton149.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton149.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton149.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton149.HoveredState.Parent = this.siticoneRoundedButton149;
            this.siticoneRoundedButton149.Location = new System.Drawing.Point(184, 50);
            this.siticoneRoundedButton149.Name = "siticoneRoundedButton149";
            this.siticoneRoundedButton149.ShadowDecoration.Parent = this.siticoneRoundedButton149;
            this.siticoneRoundedButton149.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton149.TabIndex = 183;
            this.siticoneRoundedButton149.Text = "Aftermath";
            this.siticoneRoundedButton149.Click += new System.EventHandler(this.siticoneRoundedButton149_Click);
            // 
            // siticoneRoundedButton148
            // 
            this.siticoneRoundedButton148.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton148.BorderThickness = 1;
            this.siticoneRoundedButton148.CheckedState.Parent = this.siticoneRoundedButton148;
            this.siticoneRoundedButton148.CustomImages.Parent = this.siticoneRoundedButton148;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton148, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton148.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton148.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton148.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton148.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton148.HoveredState.Parent = this.siticoneRoundedButton148;
            this.siticoneRoundedButton148.Location = new System.Drawing.Point(6, 503);
            this.siticoneRoundedButton148.Name = "siticoneRoundedButton148";
            this.siticoneRoundedButton148.ShadowDecoration.Parent = this.siticoneRoundedButton148;
            this.siticoneRoundedButton148.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton148.TabIndex = 182;
            this.siticoneRoundedButton148.Text = "Overflow";
            this.siticoneRoundedButton148.Click += new System.EventHandler(this.siticoneRoundedButton148_Click);
            // 
            // siticoneRoundedButton147
            // 
            this.siticoneRoundedButton147.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton147.BorderThickness = 1;
            this.siticoneRoundedButton147.CheckedState.Parent = this.siticoneRoundedButton147;
            this.siticoneRoundedButton147.CustomImages.Parent = this.siticoneRoundedButton147;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton147, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton147.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton147.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton147.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton147.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton147.HoveredState.Parent = this.siticoneRoundedButton147;
            this.siticoneRoundedButton147.Location = new System.Drawing.Point(6, 363);
            this.siticoneRoundedButton147.Name = "siticoneRoundedButton147";
            this.siticoneRoundedButton147.ShadowDecoration.Parent = this.siticoneRoundedButton147;
            this.siticoneRoundedButton147.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton147.TabIndex = 181;
            this.siticoneRoundedButton147.Text = "Standoff";
            this.siticoneRoundedButton147.Click += new System.EventHandler(this.siticoneRoundedButton147_Click);
            // 
            // siticoneRoundedButton146
            // 
            this.siticoneRoundedButton146.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton146.BorderThickness = 1;
            this.siticoneRoundedButton146.CheckedState.Parent = this.siticoneRoundedButton146;
            this.siticoneRoundedButton146.CustomImages.Parent = this.siticoneRoundedButton146;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton146, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton146.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton146.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton146.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton146.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton146.HoveredState.Parent = this.siticoneRoundedButton146;
            this.siticoneRoundedButton146.Location = new System.Drawing.Point(6, 398);
            this.siticoneRoundedButton146.Name = "siticoneRoundedButton146";
            this.siticoneRoundedButton146.ShadowDecoration.Parent = this.siticoneRoundedButton146;
            this.siticoneRoundedButton146.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton146.TabIndex = 180;
            this.siticoneRoundedButton146.Text = "Turbine";
            this.siticoneRoundedButton146.Click += new System.EventHandler(this.siticoneRoundedButton146_Click);
            // 
            // siticoneRoundedButton145
            // 
            this.siticoneRoundedButton145.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton145.BorderThickness = 1;
            this.siticoneRoundedButton145.CheckedState.Parent = this.siticoneRoundedButton145;
            this.siticoneRoundedButton145.CustomImages.Parent = this.siticoneRoundedButton145;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton145, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton145.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton145.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton145.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton145.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton145.HoveredState.Parent = this.siticoneRoundedButton145;
            this.siticoneRoundedButton145.Location = new System.Drawing.Point(6, 468);
            this.siticoneRoundedButton145.Name = "siticoneRoundedButton145";
            this.siticoneRoundedButton145.ShadowDecoration.Parent = this.siticoneRoundedButton145;
            this.siticoneRoundedButton145.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton145.TabIndex = 179;
            this.siticoneRoundedButton145.Text = "Slums";
            this.siticoneRoundedButton145.Click += new System.EventHandler(this.siticoneRoundedButton145_Click);
            // 
            // siticoneRoundedButton144
            // 
            this.siticoneRoundedButton144.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton144.BorderThickness = 1;
            this.siticoneRoundedButton144.CheckedState.Parent = this.siticoneRoundedButton144;
            this.siticoneRoundedButton144.CustomImages.Parent = this.siticoneRoundedButton144;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton144, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton144.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton144.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton144.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton144.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton144.HoveredState.Parent = this.siticoneRoundedButton144;
            this.siticoneRoundedButton144.Location = new System.Drawing.Point(6, 433);
            this.siticoneRoundedButton144.Name = "siticoneRoundedButton144";
            this.siticoneRoundedButton144.ShadowDecoration.Parent = this.siticoneRoundedButton144;
            this.siticoneRoundedButton144.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton144.TabIndex = 178;
            this.siticoneRoundedButton144.Text = "Raid";
            this.siticoneRoundedButton144.Click += new System.EventHandler(this.siticoneRoundedButton144_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(146, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Non-DLC\'s";
            // 
            // siticoneRoundedButton143
            // 
            this.siticoneRoundedButton143.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton143.BorderThickness = 1;
            this.siticoneRoundedButton143.CheckedState.Parent = this.siticoneRoundedButton143;
            this.siticoneRoundedButton143.CustomImages.Parent = this.siticoneRoundedButton143;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton143, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton143.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton143.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton143.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton143.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton143.HoveredState.Parent = this.siticoneRoundedButton143;
            this.siticoneRoundedButton143.Location = new System.Drawing.Point(6, 85);
            this.siticoneRoundedButton143.Name = "siticoneRoundedButton143";
            this.siticoneRoundedButton143.ShadowDecoration.Parent = this.siticoneRoundedButton143;
            this.siticoneRoundedButton143.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton143.TabIndex = 177;
            this.siticoneRoundedButton143.Text = "Nuketown";
            this.siticoneRoundedButton143.Click += new System.EventHandler(this.siticoneRoundedButton143_Click);
            // 
            // siticoneRoundedButton142
            // 
            this.siticoneRoundedButton142.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton142.BorderThickness = 1;
            this.siticoneRoundedButton142.CheckedState.Parent = this.siticoneRoundedButton142;
            this.siticoneRoundedButton142.CustomImages.Parent = this.siticoneRoundedButton142;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton142, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton142.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton142.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton142.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton142.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton142.HoveredState.Parent = this.siticoneRoundedButton142;
            this.siticoneRoundedButton142.Location = new System.Drawing.Point(6, 120);
            this.siticoneRoundedButton142.Name = "siticoneRoundedButton142";
            this.siticoneRoundedButton142.ShadowDecoration.Parent = this.siticoneRoundedButton142;
            this.siticoneRoundedButton142.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton142.TabIndex = 176;
            this.siticoneRoundedButton142.Text = "Yemen";
            this.siticoneRoundedButton142.Click += new System.EventHandler(this.siticoneRoundedButton142_Click);
            // 
            // siticoneRoundedButton141
            // 
            this.siticoneRoundedButton141.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton141.BorderThickness = 1;
            this.siticoneRoundedButton141.CheckedState.Parent = this.siticoneRoundedButton141;
            this.siticoneRoundedButton141.CustomImages.Parent = this.siticoneRoundedButton141;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton141, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton141.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton141.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton141.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton141.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton141.HoveredState.Parent = this.siticoneRoundedButton141;
            this.siticoneRoundedButton141.Location = new System.Drawing.Point(6, 155);
            this.siticoneRoundedButton141.Name = "siticoneRoundedButton141";
            this.siticoneRoundedButton141.ShadowDecoration.Parent = this.siticoneRoundedButton141;
            this.siticoneRoundedButton141.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton141.TabIndex = 175;
            this.siticoneRoundedButton141.Text = "Hijacked";
            this.siticoneRoundedButton141.Click += new System.EventHandler(this.siticoneRoundedButton141_Click);
            // 
            // siticoneRoundedButton140
            // 
            this.siticoneRoundedButton140.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton140.BorderThickness = 1;
            this.siticoneRoundedButton140.CheckedState.Parent = this.siticoneRoundedButton140;
            this.siticoneRoundedButton140.CustomImages.Parent = this.siticoneRoundedButton140;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton140, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton140.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton140.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton140.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton140.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton140.HoveredState.Parent = this.siticoneRoundedButton140;
            this.siticoneRoundedButton140.Location = new System.Drawing.Point(6, 190);
            this.siticoneRoundedButton140.Name = "siticoneRoundedButton140";
            this.siticoneRoundedButton140.ShadowDecoration.Parent = this.siticoneRoundedButton140;
            this.siticoneRoundedButton140.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton140.TabIndex = 174;
            this.siticoneRoundedButton140.Text = "Cargo";
            this.siticoneRoundedButton140.Click += new System.EventHandler(this.siticoneRoundedButton140_Click);
            // 
            // siticoneRoundedButton139
            // 
            this.siticoneRoundedButton139.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton139.BorderThickness = 1;
            this.siticoneRoundedButton139.CheckedState.Parent = this.siticoneRoundedButton139;
            this.siticoneRoundedButton139.CustomImages.Parent = this.siticoneRoundedButton139;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton139, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton139.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton139.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton139.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton139.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton139.HoveredState.Parent = this.siticoneRoundedButton139;
            this.siticoneRoundedButton139.Location = new System.Drawing.Point(6, 225);
            this.siticoneRoundedButton139.Name = "siticoneRoundedButton139";
            this.siticoneRoundedButton139.ShadowDecoration.Parent = this.siticoneRoundedButton139;
            this.siticoneRoundedButton139.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton139.TabIndex = 173;
            this.siticoneRoundedButton139.Text = "Carrier";
            this.siticoneRoundedButton139.Click += new System.EventHandler(this.siticoneRoundedButton139_Click);
            // 
            // siticoneRoundedButton138
            // 
            this.siticoneRoundedButton138.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton138.BorderThickness = 1;
            this.siticoneRoundedButton138.CheckedState.Parent = this.siticoneRoundedButton138;
            this.siticoneRoundedButton138.CustomImages.Parent = this.siticoneRoundedButton138;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton138, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton138.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton138.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton138.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton138.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton138.HoveredState.Parent = this.siticoneRoundedButton138;
            this.siticoneRoundedButton138.Location = new System.Drawing.Point(6, 260);
            this.siticoneRoundedButton138.Name = "siticoneRoundedButton138";
            this.siticoneRoundedButton138.ShadowDecoration.Parent = this.siticoneRoundedButton138;
            this.siticoneRoundedButton138.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton138.TabIndex = 172;
            this.siticoneRoundedButton138.Text = "Express";
            this.siticoneRoundedButton138.Click += new System.EventHandler(this.siticoneRoundedButton138_Click);
            // 
            // siticoneRoundedButton137
            // 
            this.siticoneRoundedButton137.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton137.BorderThickness = 1;
            this.siticoneRoundedButton137.CheckedState.Parent = this.siticoneRoundedButton137;
            this.siticoneRoundedButton137.CustomImages.Parent = this.siticoneRoundedButton137;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton137, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton137.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton137.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton137.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton137.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton137.HoveredState.Parent = this.siticoneRoundedButton137;
            this.siticoneRoundedButton137.Location = new System.Drawing.Point(6, 293);
            this.siticoneRoundedButton137.Name = "siticoneRoundedButton137";
            this.siticoneRoundedButton137.ShadowDecoration.Parent = this.siticoneRoundedButton137;
            this.siticoneRoundedButton137.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton137.TabIndex = 171;
            this.siticoneRoundedButton137.Text = "Meltdown";
            this.siticoneRoundedButton137.Click += new System.EventHandler(this.siticoneRoundedButton137_Click);
            // 
            // siticoneRoundedButton136
            // 
            this.siticoneRoundedButton136.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton136.BorderThickness = 1;
            this.siticoneRoundedButton136.CheckedState.Parent = this.siticoneRoundedButton136;
            this.siticoneRoundedButton136.CustomImages.Parent = this.siticoneRoundedButton136;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton136, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton136.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton136.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton136.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton136.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton136.HoveredState.Parent = this.siticoneRoundedButton136;
            this.siticoneRoundedButton136.Location = new System.Drawing.Point(6, 328);
            this.siticoneRoundedButton136.Name = "siticoneRoundedButton136";
            this.siticoneRoundedButton136.ShadowDecoration.Parent = this.siticoneRoundedButton136;
            this.siticoneRoundedButton136.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton136.TabIndex = 170;
            this.siticoneRoundedButton136.Text = "Plaza";
            this.siticoneRoundedButton136.Click += new System.EventHandler(this.siticoneRoundedButton136_Click);
            // 
            // siticoneRoundedButton135
            // 
            this.siticoneRoundedButton135.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton135.BorderThickness = 1;
            this.siticoneRoundedButton135.CheckedState.Parent = this.siticoneRoundedButton135;
            this.siticoneRoundedButton135.CustomImages.Parent = this.siticoneRoundedButton135;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton135, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton135.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton135.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton135.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton135.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton135.HoveredState.Parent = this.siticoneRoundedButton135;
            this.siticoneRoundedButton135.Location = new System.Drawing.Point(398, 85);
            this.siticoneRoundedButton135.Name = "siticoneRoundedButton135";
            this.siticoneRoundedButton135.ShadowDecoration.Parent = this.siticoneRoundedButton135;
            this.siticoneRoundedButton135.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton135.TabIndex = 169;
            this.siticoneRoundedButton135.Text = "Downhill";
            this.siticoneRoundedButton135.Click += new System.EventHandler(this.siticoneRoundedButton135_Click);
            // 
            // siticoneRoundedButton42
            // 
            this.siticoneRoundedButton42.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton42.BorderThickness = 1;
            this.siticoneRoundedButton42.CheckedState.Parent = this.siticoneRoundedButton42;
            this.siticoneRoundedButton42.CustomImages.Parent = this.siticoneRoundedButton42;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton42, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton42.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton42.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton42.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton42.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton42.HoveredState.Parent = this.siticoneRoundedButton42;
            this.siticoneRoundedButton42.Location = new System.Drawing.Point(398, 50);
            this.siticoneRoundedButton42.Name = "siticoneRoundedButton42";
            this.siticoneRoundedButton42.ShadowDecoration.Parent = this.siticoneRoundedButton42;
            this.siticoneRoundedButton42.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton42.TabIndex = 168;
            this.siticoneRoundedButton42.Text = "Studio";
            this.siticoneRoundedButton42.Click += new System.EventHandler(this.siticoneRoundedButton42_Click);
            // 
            // siticoneRoundedButton131
            // 
            this.siticoneRoundedButton131.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton131.BorderThickness = 1;
            this.siticoneRoundedButton131.CheckedState.Parent = this.siticoneRoundedButton131;
            this.siticoneRoundedButton131.CustomImages.Parent = this.siticoneRoundedButton131;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton131, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton131.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton131.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton131.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton131.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton131.HoveredState.Parent = this.siticoneRoundedButton131;
            this.siticoneRoundedButton131.Location = new System.Drawing.Point(6, 50);
            this.siticoneRoundedButton131.Name = "siticoneRoundedButton131";
            this.siticoneRoundedButton131.ShadowDecoration.Parent = this.siticoneRoundedButton131;
            this.siticoneRoundedButton131.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton131.TabIndex = 167;
            this.siticoneRoundedButton131.Text = "Drone";
            this.siticoneRoundedButton131.Click += new System.EventHandler(this.siticoneRoundedButton131_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage5.Controls.Add(this.siticoneRoundedButton164);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton134);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton41);
            this.tabPage5.Controls.Add(this.siticoneRoundedTextBox10);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton115);
            this.tabPage5.Controls.Add(this.siticoneRoundedTextBox40);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton117);
            this.tabPage5.Controls.Add(this.siticoneRoundedTextBox41);
            this.tabPage5.Controls.Add(this.siticoneRoundedTextBox36);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton123);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton124);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton121);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton122);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton119);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton120);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton118);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton116);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton111);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton114);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton113);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton112);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton110);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton104);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton100);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton76);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton98);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton99);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton96);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton97);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton95);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton94);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton93);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton92);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton91);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton90);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton89);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton88);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton87);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton86);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton85);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton84);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton83);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton81);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton80);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton79);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton78);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton77);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton75);
            this.tabPage5.Controls.Add(this.siticoneRoundedButton66);
            this.siticoneTransition1.SetDecoration(this.tabPage5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage5.Location = new System.Drawing.Point(184, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(878, 540);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Preset Gamertags";
            // 
            // siticoneRoundedButton164
            // 
            this.siticoneRoundedButton164.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton164.BorderThickness = 1;
            this.siticoneRoundedButton164.CheckedState.Parent = this.siticoneRoundedButton164;
            this.siticoneRoundedButton164.CustomImages.Parent = this.siticoneRoundedButton164;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton164, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton164.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton164.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton164.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton164.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton164.HoveredState.Parent = this.siticoneRoundedButton164;
            this.siticoneRoundedButton164.Location = new System.Drawing.Point(724, 135);
            this.siticoneRoundedButton164.Name = "siticoneRoundedButton164";
            this.siticoneRoundedButton164.ShadowDecoration.Parent = this.siticoneRoundedButton164;
            this.siticoneRoundedButton164.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton164.TabIndex = 144;
            this.siticoneRoundedButton164.Text = "Roast 11";
            this.siticoneRoundedButton164.Click += new System.EventHandler(this.siticoneRoundedButton164_Click);
            // 
            // siticoneRoundedButton134
            // 
            this.siticoneRoundedButton134.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton134.BorderThickness = 1;
            this.siticoneRoundedButton134.CheckedState.Parent = this.siticoneRoundedButton134;
            this.siticoneRoundedButton134.CustomImages.Parent = this.siticoneRoundedButton134;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton134, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton134.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton134.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton134.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton134.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton134.HoveredState.Parent = this.siticoneRoundedButton134;
            this.siticoneRoundedButton134.Location = new System.Drawing.Point(724, 165);
            this.siticoneRoundedButton134.Name = "siticoneRoundedButton134";
            this.siticoneRoundedButton134.ShadowDecoration.Parent = this.siticoneRoundedButton134;
            this.siticoneRoundedButton134.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton134.TabIndex = 143;
            this.siticoneRoundedButton134.Text = "Roast 12";
            this.siticoneRoundedButton134.Click += new System.EventHandler(this.siticoneRoundedButton134_Click);
            // 
            // siticoneRoundedButton41
            // 
            this.siticoneRoundedButton41.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton41.BorderThickness = 1;
            this.siticoneRoundedButton41.CheckedState.Parent = this.siticoneRoundedButton41;
            this.siticoneRoundedButton41.CustomImages.Parent = this.siticoneRoundedButton41;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton41, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton41.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton41.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton41.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton41.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton41.HoveredState.Parent = this.siticoneRoundedButton41;
            this.siticoneRoundedButton41.Location = new System.Drawing.Point(310, 474);
            this.siticoneRoundedButton41.Name = "siticoneRoundedButton41";
            this.siticoneRoundedButton41.ShadowDecoration.Parent = this.siticoneRoundedButton41;
            this.siticoneRoundedButton41.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton41.TabIndex = 142;
            this.siticoneRoundedButton41.Text = "DDOS Troll V2";
            this.siticoneRoundedButton41.Click += new System.EventHandler(this.siticoneRoundedButton41_Click);
            // 
            // siticoneRoundedTextBox10
            // 
            this.siticoneRoundedTextBox10.AllowDrop = true;
            this.siticoneRoundedTextBox10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox10.DefaultText = "Gamertag";
            this.siticoneRoundedTextBox10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox10.DisabledState.Parent = this.siticoneRoundedTextBox10;
            this.siticoneRoundedTextBox10.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox10.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox10.FocusedState.Parent = this.siticoneRoundedTextBox10;
            this.siticoneRoundedTextBox10.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox10.HoveredState.Parent = this.siticoneRoundedTextBox10;
            this.siticoneRoundedTextBox10.Location = new System.Drawing.Point(310, 505);
            this.siticoneRoundedTextBox10.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox10.Name = "siticoneRoundedTextBox10";
            this.siticoneRoundedTextBox10.PasswordChar = '\0';
            this.siticoneRoundedTextBox10.PlaceholderText = "";
            this.siticoneRoundedTextBox10.SelectedText = "";
            this.siticoneRoundedTextBox10.ShadowDecoration.Parent = this.siticoneRoundedTextBox10;
            this.siticoneRoundedTextBox10.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox10.TabIndex = 141;
            this.siticoneRoundedTextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton115
            // 
            this.siticoneRoundedButton115.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton115.BorderThickness = 1;
            this.siticoneRoundedButton115.CheckedState.Parent = this.siticoneRoundedButton115;
            this.siticoneRoundedButton115.CustomImages.Parent = this.siticoneRoundedButton115;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton115, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton115.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton115.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton115.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton115.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton115.HoveredState.Parent = this.siticoneRoundedButton115;
            this.siticoneRoundedButton115.Location = new System.Drawing.Point(158, 474);
            this.siticoneRoundedButton115.Name = "siticoneRoundedButton115";
            this.siticoneRoundedButton115.ShadowDecoration.Parent = this.siticoneRoundedButton115;
            this.siticoneRoundedButton115.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton115.TabIndex = 140;
            this.siticoneRoundedButton115.Text = "Funny Troll";
            this.siticoneRoundedButton115.Click += new System.EventHandler(this.siticoneRoundedButton115_Click);
            // 
            // siticoneRoundedTextBox40
            // 
            this.siticoneRoundedTextBox40.AllowDrop = true;
            this.siticoneRoundedTextBox40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox40.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox40, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox40.DefaultText = "Gamertag";
            this.siticoneRoundedTextBox40.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox40.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox40.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox40.DisabledState.Parent = this.siticoneRoundedTextBox40;
            this.siticoneRoundedTextBox40.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox40.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox40.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox40.FocusedState.Parent = this.siticoneRoundedTextBox40;
            this.siticoneRoundedTextBox40.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox40.HoveredState.Parent = this.siticoneRoundedTextBox40;
            this.siticoneRoundedTextBox40.Location = new System.Drawing.Point(158, 505);
            this.siticoneRoundedTextBox40.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox40.Name = "siticoneRoundedTextBox40";
            this.siticoneRoundedTextBox40.PasswordChar = '\0';
            this.siticoneRoundedTextBox40.PlaceholderText = "";
            this.siticoneRoundedTextBox40.SelectedText = "";
            this.siticoneRoundedTextBox40.ShadowDecoration.Parent = this.siticoneRoundedTextBox40;
            this.siticoneRoundedTextBox40.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox40.TabIndex = 139;
            this.siticoneRoundedTextBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton117
            // 
            this.siticoneRoundedButton117.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton117.BorderThickness = 1;
            this.siticoneRoundedButton117.CheckedState.Parent = this.siticoneRoundedButton117;
            this.siticoneRoundedButton117.CustomImages.Parent = this.siticoneRoundedButton117;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton117, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton117.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton117.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton117.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton117.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton117.HoveredState.Parent = this.siticoneRoundedButton117;
            this.siticoneRoundedButton117.Location = new System.Drawing.Point(6, 474);
            this.siticoneRoundedButton117.Name = "siticoneRoundedButton117";
            this.siticoneRoundedButton117.ShadowDecoration.Parent = this.siticoneRoundedButton117;
            this.siticoneRoundedButton117.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton117.TabIndex = 138;
            this.siticoneRoundedButton117.Text = "DDOS Troll";
            this.siticoneRoundedButton117.Click += new System.EventHandler(this.siticoneRoundedButton117_Click);
            // 
            // siticoneRoundedTextBox41
            // 
            this.siticoneRoundedTextBox41.AllowDrop = true;
            this.siticoneRoundedTextBox41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox41.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox41, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox41.DefaultText = "Gamertag";
            this.siticoneRoundedTextBox41.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox41.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox41.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox41.DisabledState.Parent = this.siticoneRoundedTextBox41;
            this.siticoneRoundedTextBox41.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox41.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox41.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox41.FocusedState.Parent = this.siticoneRoundedTextBox41;
            this.siticoneRoundedTextBox41.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox41.HoveredState.Parent = this.siticoneRoundedTextBox41;
            this.siticoneRoundedTextBox41.Location = new System.Drawing.Point(6, 505);
            this.siticoneRoundedTextBox41.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox41.Name = "siticoneRoundedTextBox41";
            this.siticoneRoundedTextBox41.PasswordChar = '\0';
            this.siticoneRoundedTextBox41.PlaceholderText = "";
            this.siticoneRoundedTextBox41.SelectedText = "";
            this.siticoneRoundedTextBox41.ShadowDecoration.Parent = this.siticoneRoundedTextBox41;
            this.siticoneRoundedTextBox41.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox41.TabIndex = 137;
            this.siticoneRoundedTextBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedTextBox36
            // 
            this.siticoneRoundedTextBox36.AllowDrop = true;
            this.siticoneRoundedTextBox36.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox36.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox36, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox36.DefaultText = "Gamertag Here";
            this.siticoneRoundedTextBox36.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox36.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox36.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox36.DisabledState.Parent = this.siticoneRoundedTextBox36;
            this.siticoneRoundedTextBox36.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox36.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox36.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox36.FocusedState.Parent = this.siticoneRoundedTextBox36;
            this.siticoneRoundedTextBox36.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox36.HoveredState.Parent = this.siticoneRoundedTextBox36;
            this.siticoneRoundedTextBox36.Location = new System.Drawing.Point(652, 195);
            this.siticoneRoundedTextBox36.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox36.Name = "siticoneRoundedTextBox36";
            this.siticoneRoundedTextBox36.PasswordChar = '\0';
            this.siticoneRoundedTextBox36.PlaceholderText = "";
            this.siticoneRoundedTextBox36.SelectedText = "";
            this.siticoneRoundedTextBox36.ShadowDecoration.Parent = this.siticoneRoundedTextBox36;
            this.siticoneRoundedTextBox36.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox36.TabIndex = 136;
            this.siticoneRoundedTextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton123
            // 
            this.siticoneRoundedButton123.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton123.BorderThickness = 1;
            this.siticoneRoundedButton123.CheckedState.Parent = this.siticoneRoundedButton123;
            this.siticoneRoundedButton123.CustomImages.Parent = this.siticoneRoundedButton123;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton123, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton123.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton123.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton123.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton123.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton123.HoveredState.Parent = this.siticoneRoundedButton123;
            this.siticoneRoundedButton123.Location = new System.Drawing.Point(724, 45);
            this.siticoneRoundedButton123.Name = "siticoneRoundedButton123";
            this.siticoneRoundedButton123.ShadowDecoration.Parent = this.siticoneRoundedButton123;
            this.siticoneRoundedButton123.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton123.TabIndex = 135;
            this.siticoneRoundedButton123.Text = "Roast 8";
            this.siticoneRoundedButton123.Click += new System.EventHandler(this.siticoneRoundedButton123_Click);
            // 
            // siticoneRoundedButton124
            // 
            this.siticoneRoundedButton124.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton124.BorderThickness = 1;
            this.siticoneRoundedButton124.CheckedState.Parent = this.siticoneRoundedButton124;
            this.siticoneRoundedButton124.CustomImages.Parent = this.siticoneRoundedButton124;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton124, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton124.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton124.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton124.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton124.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton124.HoveredState.Parent = this.siticoneRoundedButton124;
            this.siticoneRoundedButton124.Location = new System.Drawing.Point(572, 45);
            this.siticoneRoundedButton124.Name = "siticoneRoundedButton124";
            this.siticoneRoundedButton124.ShadowDecoration.Parent = this.siticoneRoundedButton124;
            this.siticoneRoundedButton124.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton124.TabIndex = 134;
            this.siticoneRoundedButton124.Text = "Roast 2";
            this.siticoneRoundedButton124.Click += new System.EventHandler(this.siticoneRoundedButton124_Click);
            // 
            // siticoneRoundedButton121
            // 
            this.siticoneRoundedButton121.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton121.BorderThickness = 1;
            this.siticoneRoundedButton121.CheckedState.Parent = this.siticoneRoundedButton121;
            this.siticoneRoundedButton121.CustomImages.Parent = this.siticoneRoundedButton121;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton121, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton121.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton121.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton121.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton121.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton121.HoveredState.Parent = this.siticoneRoundedButton121;
            this.siticoneRoundedButton121.Location = new System.Drawing.Point(724, 75);
            this.siticoneRoundedButton121.Name = "siticoneRoundedButton121";
            this.siticoneRoundedButton121.ShadowDecoration.Parent = this.siticoneRoundedButton121;
            this.siticoneRoundedButton121.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton121.TabIndex = 133;
            this.siticoneRoundedButton121.Text = "Roast 9";
            this.siticoneRoundedButton121.Click += new System.EventHandler(this.siticoneRoundedButton121_Click);
            // 
            // siticoneRoundedButton122
            // 
            this.siticoneRoundedButton122.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton122.BorderThickness = 1;
            this.siticoneRoundedButton122.CheckedState.Parent = this.siticoneRoundedButton122;
            this.siticoneRoundedButton122.CustomImages.Parent = this.siticoneRoundedButton122;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton122, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton122.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton122.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton122.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton122.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton122.HoveredState.Parent = this.siticoneRoundedButton122;
            this.siticoneRoundedButton122.Location = new System.Drawing.Point(572, 75);
            this.siticoneRoundedButton122.Name = "siticoneRoundedButton122";
            this.siticoneRoundedButton122.ShadowDecoration.Parent = this.siticoneRoundedButton122;
            this.siticoneRoundedButton122.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton122.TabIndex = 132;
            this.siticoneRoundedButton122.Text = "Roast 3";
            this.siticoneRoundedButton122.Click += new System.EventHandler(this.siticoneRoundedButton112_Click);
            // 
            // siticoneRoundedButton119
            // 
            this.siticoneRoundedButton119.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton119.BorderThickness = 1;
            this.siticoneRoundedButton119.CheckedState.Parent = this.siticoneRoundedButton119;
            this.siticoneRoundedButton119.CustomImages.Parent = this.siticoneRoundedButton119;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton119, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton119.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton119.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton119.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton119.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton119.HoveredState.Parent = this.siticoneRoundedButton119;
            this.siticoneRoundedButton119.Location = new System.Drawing.Point(724, 105);
            this.siticoneRoundedButton119.Name = "siticoneRoundedButton119";
            this.siticoneRoundedButton119.ShadowDecoration.Parent = this.siticoneRoundedButton119;
            this.siticoneRoundedButton119.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton119.TabIndex = 131;
            this.siticoneRoundedButton119.Text = "Roast 10";
            this.siticoneRoundedButton119.Click += new System.EventHandler(this.siticoneRoundedButton119_Click);
            // 
            // siticoneRoundedButton120
            // 
            this.siticoneRoundedButton120.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton120.BorderThickness = 1;
            this.siticoneRoundedButton120.CheckedState.Parent = this.siticoneRoundedButton120;
            this.siticoneRoundedButton120.CustomImages.Parent = this.siticoneRoundedButton120;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton120, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton120.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton120.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton120.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton120.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton120.HoveredState.Parent = this.siticoneRoundedButton120;
            this.siticoneRoundedButton120.Location = new System.Drawing.Point(572, 105);
            this.siticoneRoundedButton120.Name = "siticoneRoundedButton120";
            this.siticoneRoundedButton120.ShadowDecoration.Parent = this.siticoneRoundedButton120;
            this.siticoneRoundedButton120.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton120.TabIndex = 130;
            this.siticoneRoundedButton120.Text = "Roast 4";
            this.siticoneRoundedButton120.Click += new System.EventHandler(this.siticoneRoundedButton120_Click);
            // 
            // siticoneRoundedButton118
            // 
            this.siticoneRoundedButton118.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton118.BorderThickness = 1;
            this.siticoneRoundedButton118.CheckedState.Parent = this.siticoneRoundedButton118;
            this.siticoneRoundedButton118.CustomImages.Parent = this.siticoneRoundedButton118;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton118, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton118.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton118.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton118.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton118.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton118.HoveredState.Parent = this.siticoneRoundedButton118;
            this.siticoneRoundedButton118.Location = new System.Drawing.Point(572, 135);
            this.siticoneRoundedButton118.Name = "siticoneRoundedButton118";
            this.siticoneRoundedButton118.ShadowDecoration.Parent = this.siticoneRoundedButton118;
            this.siticoneRoundedButton118.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton118.TabIndex = 128;
            this.siticoneRoundedButton118.Text = "Roast 5";
            this.siticoneRoundedButton118.Click += new System.EventHandler(this.siticoneRoundedButton118_Click);
            // 
            // siticoneRoundedButton116
            // 
            this.siticoneRoundedButton116.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton116.BorderThickness = 1;
            this.siticoneRoundedButton116.CheckedState.Parent = this.siticoneRoundedButton116;
            this.siticoneRoundedButton116.CustomImages.Parent = this.siticoneRoundedButton116;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton116, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton116.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton116.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton116.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton116.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton116.HoveredState.Parent = this.siticoneRoundedButton116;
            this.siticoneRoundedButton116.Location = new System.Drawing.Point(572, 165);
            this.siticoneRoundedButton116.Name = "siticoneRoundedButton116";
            this.siticoneRoundedButton116.ShadowDecoration.Parent = this.siticoneRoundedButton116;
            this.siticoneRoundedButton116.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton116.TabIndex = 126;
            this.siticoneRoundedButton116.Text = "Roast 6";
            this.siticoneRoundedButton116.Click += new System.EventHandler(this.siticoneRoundedButton116_Click);
            // 
            // siticoneRoundedButton111
            // 
            this.siticoneRoundedButton111.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton111.BorderThickness = 1;
            this.siticoneRoundedButton111.CheckedState.Parent = this.siticoneRoundedButton111;
            this.siticoneRoundedButton111.CustomImages.Parent = this.siticoneRoundedButton111;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton111, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton111.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton111.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton111.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton111.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton111.HoveredState.Parent = this.siticoneRoundedButton111;
            this.siticoneRoundedButton111.Location = new System.Drawing.Point(724, 15);
            this.siticoneRoundedButton111.Name = "siticoneRoundedButton111";
            this.siticoneRoundedButton111.ShadowDecoration.Parent = this.siticoneRoundedButton111;
            this.siticoneRoundedButton111.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton111.TabIndex = 125;
            this.siticoneRoundedButton111.Text = "Roast 7";
            this.siticoneRoundedButton111.Click += new System.EventHandler(this.siticoneRoundedButton111_Click);
            // 
            // siticoneRoundedButton114
            // 
            this.siticoneRoundedButton114.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton114.BorderThickness = 1;
            this.siticoneRoundedButton114.CheckedState.Parent = this.siticoneRoundedButton114;
            this.siticoneRoundedButton114.CustomImages.Parent = this.siticoneRoundedButton114;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton114, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton114.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton114.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton114.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton114.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton114.HoveredState.Parent = this.siticoneRoundedButton114;
            this.siticoneRoundedButton114.Location = new System.Drawing.Point(572, 15);
            this.siticoneRoundedButton114.Name = "siticoneRoundedButton114";
            this.siticoneRoundedButton114.ShadowDecoration.Parent = this.siticoneRoundedButton114;
            this.siticoneRoundedButton114.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton114.TabIndex = 124;
            this.siticoneRoundedButton114.Text = "Roast 1";
            this.siticoneRoundedButton114.Click += new System.EventHandler(this.siticoneRoundedButton114_Click);
            // 
            // siticoneRoundedButton113
            // 
            this.siticoneRoundedButton113.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton113.BorderThickness = 1;
            this.siticoneRoundedButton113.CheckedState.Parent = this.siticoneRoundedButton113;
            this.siticoneRoundedButton113.CustomImages.Parent = this.siticoneRoundedButton113;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton113, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton113.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton113.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton113.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton113.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton113.HoveredState.Parent = this.siticoneRoundedButton113;
            this.siticoneRoundedButton113.Location = new System.Drawing.Point(158, 435);
            this.siticoneRoundedButton113.Name = "siticoneRoundedButton113";
            this.siticoneRoundedButton113.ShadowDecoration.Parent = this.siticoneRoundedButton113;
            this.siticoneRoundedButton113.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton113.TabIndex = 123;
            this.siticoneRoundedButton113.Text = "COD TV";
            this.siticoneRoundedButton113.Click += new System.EventHandler(this.siticoneRoundedButton113_Click);
            // 
            // siticoneRoundedButton112
            // 
            this.siticoneRoundedButton112.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton112.BorderThickness = 1;
            this.siticoneRoundedButton112.CheckedState.Parent = this.siticoneRoundedButton112;
            this.siticoneRoundedButton112.CustomImages.Parent = this.siticoneRoundedButton112;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton112, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton112.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton112.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton112.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton112.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton112.HoveredState.Parent = this.siticoneRoundedButton112;
            this.siticoneRoundedButton112.Location = new System.Drawing.Point(6, 435);
            this.siticoneRoundedButton112.Name = "siticoneRoundedButton112";
            this.siticoneRoundedButton112.ShadowDecoration.Parent = this.siticoneRoundedButton112;
            this.siticoneRoundedButton112.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton112.TabIndex = 120;
            this.siticoneRoundedButton112.Text = "Flicker";
            this.siticoneRoundedButton112.Click += new System.EventHandler(this.siticoneRoundedButton112_Click);
            // 
            // siticoneRoundedButton110
            // 
            this.siticoneRoundedButton110.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton110.BorderThickness = 1;
            this.siticoneRoundedButton110.CheckedState.Parent = this.siticoneRoundedButton110;
            this.siticoneRoundedButton110.CustomImages.Parent = this.siticoneRoundedButton110;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton110, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton110.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton110.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton110.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton110.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton110.HoveredState.Parent = this.siticoneRoundedButton110;
            this.siticoneRoundedButton110.Location = new System.Drawing.Point(158, 405);
            this.siticoneRoundedButton110.Name = "siticoneRoundedButton110";
            this.siticoneRoundedButton110.ShadowDecoration.Parent = this.siticoneRoundedButton110;
            this.siticoneRoundedButton110.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton110.TabIndex = 119;
            this.siticoneRoundedButton110.Text = "Fags Above+Down";
            this.siticoneRoundedButton110.Click += new System.EventHandler(this.siticoneRoundedButton110_Click);
            // 
            // siticoneRoundedButton104
            // 
            this.siticoneRoundedButton104.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton104.BorderThickness = 1;
            this.siticoneRoundedButton104.CheckedState.Parent = this.siticoneRoundedButton104;
            this.siticoneRoundedButton104.CustomImages.Parent = this.siticoneRoundedButton104;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton104, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton104.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton104.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton104.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton104.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton104.HoveredState.Parent = this.siticoneRoundedButton104;
            this.siticoneRoundedButton104.Location = new System.Drawing.Point(158, 375);
            this.siticoneRoundedButton104.Name = "siticoneRoundedButton104";
            this.siticoneRoundedButton104.ShadowDecoration.Parent = this.siticoneRoundedButton104;
            this.siticoneRoundedButton104.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton104.TabIndex = 118;
            this.siticoneRoundedButton104.Text = "Steal Menu []";
            this.siticoneRoundedButton104.Click += new System.EventHandler(this.siticoneRoundedButton104_Click);
            // 
            // siticoneRoundedButton100
            // 
            this.siticoneRoundedButton100.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton100.BorderThickness = 1;
            this.siticoneRoundedButton100.CheckedState.Parent = this.siticoneRoundedButton100;
            this.siticoneRoundedButton100.CustomImages.Parent = this.siticoneRoundedButton100;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton100, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton100.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton100.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton100.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton100.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton100.HoveredState.Parent = this.siticoneRoundedButton100;
            this.siticoneRoundedButton100.Location = new System.Drawing.Point(158, 345);
            this.siticoneRoundedButton100.Name = "siticoneRoundedButton100";
            this.siticoneRoundedButton100.ShadowDecoration.Parent = this.siticoneRoundedButton100;
            this.siticoneRoundedButton100.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton100.TabIndex = 117;
            this.siticoneRoundedButton100.Text = "Read";
            this.siticoneRoundedButton100.Click += new System.EventHandler(this.siticoneRoundedButton100_Click);
            // 
            // siticoneRoundedButton76
            // 
            this.siticoneRoundedButton76.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton76.BorderThickness = 1;
            this.siticoneRoundedButton76.CheckedState.Parent = this.siticoneRoundedButton76;
            this.siticoneRoundedButton76.CustomImages.Parent = this.siticoneRoundedButton76;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton76, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton76.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton76.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton76.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton76.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton76.HoveredState.Parent = this.siticoneRoundedButton76;
            this.siticoneRoundedButton76.Location = new System.Drawing.Point(6, 405);
            this.siticoneRoundedButton76.Name = "siticoneRoundedButton76";
            this.siticoneRoundedButton76.ShadowDecoration.Parent = this.siticoneRoundedButton76;
            this.siticoneRoundedButton76.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton76.TabIndex = 116;
            this.siticoneRoundedButton76.Text = "BO2 Admin";
            this.siticoneRoundedButton76.Click += new System.EventHandler(this.siticoneRoundedButton76_Click);
            // 
            // siticoneRoundedButton98
            // 
            this.siticoneRoundedButton98.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton98.BorderThickness = 1;
            this.siticoneRoundedButton98.CheckedState.Parent = this.siticoneRoundedButton98;
            this.siticoneRoundedButton98.CustomImages.Parent = this.siticoneRoundedButton98;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton98, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton98.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton98.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton98.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton98.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton98.HoveredState.Parent = this.siticoneRoundedButton98;
            this.siticoneRoundedButton98.Location = new System.Drawing.Point(158, 285);
            this.siticoneRoundedButton98.Name = "siticoneRoundedButton98";
            this.siticoneRoundedButton98.ShadowDecoration.Parent = this.siticoneRoundedButton98;
            this.siticoneRoundedButton98.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton98.TabIndex = 114;
            this.siticoneRoundedButton98.Text = "X";
            this.siticoneRoundedButton98.Click += new System.EventHandler(this.siticoneRoundedButton98_Click);
            // 
            // siticoneRoundedButton99
            // 
            this.siticoneRoundedButton99.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton99.BorderThickness = 1;
            this.siticoneRoundedButton99.CheckedState.Parent = this.siticoneRoundedButton99;
            this.siticoneRoundedButton99.CustomImages.Parent = this.siticoneRoundedButton99;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton99, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton99.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton99.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton99.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton99.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton99.HoveredState.Parent = this.siticoneRoundedButton99;
            this.siticoneRoundedButton99.Location = new System.Drawing.Point(6, 315);
            this.siticoneRoundedButton99.Name = "siticoneRoundedButton99";
            this.siticoneRoundedButton99.ShadowDecoration.Parent = this.siticoneRoundedButton99;
            this.siticoneRoundedButton99.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton99.TabIndex = 113;
            this.siticoneRoundedButton99.Text = "A";
            this.siticoneRoundedButton99.Click += new System.EventHandler(this.siticoneRoundedButton99_Click);
            // 
            // siticoneRoundedButton96
            // 
            this.siticoneRoundedButton96.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton96.BorderThickness = 1;
            this.siticoneRoundedButton96.CheckedState.Parent = this.siticoneRoundedButton96;
            this.siticoneRoundedButton96.CustomImages.Parent = this.siticoneRoundedButton96;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton96, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton96.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton96.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton96.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton96.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton96.HoveredState.Parent = this.siticoneRoundedButton96;
            this.siticoneRoundedButton96.Location = new System.Drawing.Point(158, 315);
            this.siticoneRoundedButton96.Name = "siticoneRoundedButton96";
            this.siticoneRoundedButton96.ShadowDecoration.Parent = this.siticoneRoundedButton96;
            this.siticoneRoundedButton96.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton96.TabIndex = 112;
            this.siticoneRoundedButton96.Text = "B";
            this.siticoneRoundedButton96.Click += new System.EventHandler(this.siticoneRoundedButton96_Click);
            // 
            // siticoneRoundedButton97
            // 
            this.siticoneRoundedButton97.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton97.BorderThickness = 1;
            this.siticoneRoundedButton97.CheckedState.Parent = this.siticoneRoundedButton97;
            this.siticoneRoundedButton97.CustomImages.Parent = this.siticoneRoundedButton97;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton97, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton97.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton97.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton97.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton97.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton97.HoveredState.Parent = this.siticoneRoundedButton97;
            this.siticoneRoundedButton97.Location = new System.Drawing.Point(6, 345);
            this.siticoneRoundedButton97.Name = "siticoneRoundedButton97";
            this.siticoneRoundedButton97.ShadowDecoration.Parent = this.siticoneRoundedButton97;
            this.siticoneRoundedButton97.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton97.TabIndex = 111;
            this.siticoneRoundedButton97.Text = "Y";
            this.siticoneRoundedButton97.Click += new System.EventHandler(this.siticoneRoundedButton97_Click);
            // 
            // siticoneRoundedButton95
            // 
            this.siticoneRoundedButton95.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton95.BorderThickness = 1;
            this.siticoneRoundedButton95.CheckedState.Parent = this.siticoneRoundedButton95;
            this.siticoneRoundedButton95.CustomImages.Parent = this.siticoneRoundedButton95;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton95, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton95.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton95.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton95.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton95.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton95.HoveredState.Parent = this.siticoneRoundedButton95;
            this.siticoneRoundedButton95.Location = new System.Drawing.Point(158, 225);
            this.siticoneRoundedButton95.Name = "siticoneRoundedButton95";
            this.siticoneRoundedButton95.ShadowDecoration.Parent = this.siticoneRoundedButton95;
            this.siticoneRoundedButton95.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton95.TabIndex = 110;
            this.siticoneRoundedButton95.Text = "Smoke";
            this.siticoneRoundedButton95.Click += new System.EventHandler(this.siticoneRoundedButton95_Click);
            // 
            // siticoneRoundedButton94
            // 
            this.siticoneRoundedButton94.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton94.BorderThickness = 1;
            this.siticoneRoundedButton94.CheckedState.Parent = this.siticoneRoundedButton94;
            this.siticoneRoundedButton94.CustomImages.Parent = this.siticoneRoundedButton94;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton94, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton94.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton94.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton94.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton94.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton94.HoveredState.Parent = this.siticoneRoundedButton94;
            this.siticoneRoundedButton94.Location = new System.Drawing.Point(158, 255);
            this.siticoneRoundedButton94.Name = "siticoneRoundedButton94";
            this.siticoneRoundedButton94.ShadowDecoration.Parent = this.siticoneRoundedButton94;
            this.siticoneRoundedButton94.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton94.TabIndex = 109;
            this.siticoneRoundedButton94.Text = "Heli";
            this.siticoneRoundedButton94.Click += new System.EventHandler(this.siticoneRoundedButton94_Click);
            // 
            // siticoneRoundedButton93
            // 
            this.siticoneRoundedButton93.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton93.BorderThickness = 1;
            this.siticoneRoundedButton93.CheckedState.Parent = this.siticoneRoundedButton93;
            this.siticoneRoundedButton93.CustomImages.Parent = this.siticoneRoundedButton93;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton93, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton93.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton93.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton93.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton93.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton93.HoveredState.Parent = this.siticoneRoundedButton93;
            this.siticoneRoundedButton93.Location = new System.Drawing.Point(6, 375);
            this.siticoneRoundedButton93.Name = "siticoneRoundedButton93";
            this.siticoneRoundedButton93.ShadowDecoration.Parent = this.siticoneRoundedButton93;
            this.siticoneRoundedButton93.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton93.TabIndex = 108;
            this.siticoneRoundedButton93.Text = "Dual Wield";
            this.siticoneRoundedButton93.Click += new System.EventHandler(this.siticoneRoundedButton93_Click);
            // 
            // siticoneRoundedButton92
            // 
            this.siticoneRoundedButton92.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton92.BorderThickness = 1;
            this.siticoneRoundedButton92.CheckedState.Parent = this.siticoneRoundedButton92;
            this.siticoneRoundedButton92.CustomImages.Parent = this.siticoneRoundedButton92;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton92, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton92.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton92.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton92.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton92.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton92.HoveredState.Parent = this.siticoneRoundedButton92;
            this.siticoneRoundedButton92.Location = new System.Drawing.Point(158, 105);
            this.siticoneRoundedButton92.Name = "siticoneRoundedButton92";
            this.siticoneRoundedButton92.ShadowDecoration.Parent = this.siticoneRoundedButton92;
            this.siticoneRoundedButton92.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton92.TabIndex = 107;
            this.siticoneRoundedButton92.Text = "Youtube";
            this.siticoneRoundedButton92.Click += new System.EventHandler(this.siticoneRoundedButton92_Click);
            // 
            // siticoneRoundedButton91
            // 
            this.siticoneRoundedButton91.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton91.BorderThickness = 1;
            this.siticoneRoundedButton91.CheckedState.Parent = this.siticoneRoundedButton91;
            this.siticoneRoundedButton91.CustomImages.Parent = this.siticoneRoundedButton91;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton91, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton91.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton91.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton91.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton91.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton91.HoveredState.Parent = this.siticoneRoundedButton91;
            this.siticoneRoundedButton91.Location = new System.Drawing.Point(158, 135);
            this.siticoneRoundedButton91.Name = "siticoneRoundedButton91";
            this.siticoneRoundedButton91.ShadowDecoration.Parent = this.siticoneRoundedButton91;
            this.siticoneRoundedButton91.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton91.TabIndex = 106;
            this.siticoneRoundedButton91.Text = "Hes Gay";
            this.siticoneRoundedButton91.Click += new System.EventHandler(this.siticoneRoundedButton91_Click);
            // 
            // siticoneRoundedButton90
            // 
            this.siticoneRoundedButton90.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton90.BorderThickness = 1;
            this.siticoneRoundedButton90.CheckedState.Parent = this.siticoneRoundedButton90;
            this.siticoneRoundedButton90.CustomImages.Parent = this.siticoneRoundedButton90;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton90, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton90.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton90.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton90.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton90.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton90.HoveredState.Parent = this.siticoneRoundedButton90;
            this.siticoneRoundedButton90.Location = new System.Drawing.Point(158, 165);
            this.siticoneRoundedButton90.Name = "siticoneRoundedButton90";
            this.siticoneRoundedButton90.ShadowDecoration.Parent = this.siticoneRoundedButton90;
            this.siticoneRoundedButton90.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton90.TabIndex = 105;
            this.siticoneRoundedButton90.Text = "Search And Destroy";
            this.siticoneRoundedButton90.Click += new System.EventHandler(this.siticoneRoundedButton90_Click);
            // 
            // siticoneRoundedButton89
            // 
            this.siticoneRoundedButton89.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton89.BorderThickness = 1;
            this.siticoneRoundedButton89.CheckedState.Parent = this.siticoneRoundedButton89;
            this.siticoneRoundedButton89.CustomImages.Parent = this.siticoneRoundedButton89;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton89, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton89.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton89.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton89.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton89.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton89.HoveredState.Parent = this.siticoneRoundedButton89;
            this.siticoneRoundedButton89.Location = new System.Drawing.Point(158, 195);
            this.siticoneRoundedButton89.Name = "siticoneRoundedButton89";
            this.siticoneRoundedButton89.ShadowDecoration.Parent = this.siticoneRoundedButton89;
            this.siticoneRoundedButton89.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton89.TabIndex = 104;
            this.siticoneRoundedButton89.Text = "This fgt Tho";
            this.siticoneRoundedButton89.Click += new System.EventHandler(this.siticoneRoundedButton89_Click);
            // 
            // siticoneRoundedButton88
            // 
            this.siticoneRoundedButton88.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton88.BorderThickness = 1;
            this.siticoneRoundedButton88.CheckedState.Parent = this.siticoneRoundedButton88;
            this.siticoneRoundedButton88.CustomImages.Parent = this.siticoneRoundedButton88;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton88, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton88.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton88.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton88.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton88.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton88.HoveredState.Parent = this.siticoneRoundedButton88;
            this.siticoneRoundedButton88.Location = new System.Drawing.Point(6, 225);
            this.siticoneRoundedButton88.Name = "siticoneRoundedButton88";
            this.siticoneRoundedButton88.ShadowDecoration.Parent = this.siticoneRoundedButton88;
            this.siticoneRoundedButton88.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton88.TabIndex = 103;
            this.siticoneRoundedButton88.Text = "You Suck";
            this.siticoneRoundedButton88.Click += new System.EventHandler(this.siticoneRoundedButton88_Click);
            // 
            // siticoneRoundedButton87
            // 
            this.siticoneRoundedButton87.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton87.BorderThickness = 1;
            this.siticoneRoundedButton87.CheckedState.Parent = this.siticoneRoundedButton87;
            this.siticoneRoundedButton87.CustomImages.Parent = this.siticoneRoundedButton87;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton87, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton87.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton87.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton87.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton87.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton87.HoveredState.Parent = this.siticoneRoundedButton87;
            this.siticoneRoundedButton87.Location = new System.Drawing.Point(6, 255);
            this.siticoneRoundedButton87.Name = "siticoneRoundedButton87";
            this.siticoneRoundedButton87.ShadowDecoration.Parent = this.siticoneRoundedButton87;
            this.siticoneRoundedButton87.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton87.TabIndex = 102;
            this.siticoneRoundedButton87.Text = "Hacker";
            this.siticoneRoundedButton87.Click += new System.EventHandler(this.siticoneRoundedButton87_Click);
            // 
            // siticoneRoundedButton86
            // 
            this.siticoneRoundedButton86.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton86.BorderThickness = 1;
            this.siticoneRoundedButton86.CheckedState.Parent = this.siticoneRoundedButton86;
            this.siticoneRoundedButton86.CustomImages.Parent = this.siticoneRoundedButton86;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton86, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton86.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton86.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton86.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton86.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton86.HoveredState.Parent = this.siticoneRoundedButton86;
            this.siticoneRoundedButton86.Location = new System.Drawing.Point(6, 285);
            this.siticoneRoundedButton86.Name = "siticoneRoundedButton86";
            this.siticoneRoundedButton86.ShadowDecoration.Parent = this.siticoneRoundedButton86;
            this.siticoneRoundedButton86.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton86.TabIndex = 101;
            this.siticoneRoundedButton86.Text = "^B^";
            this.siticoneRoundedButton86.Click += new System.EventHandler(this.siticoneRoundedButton86_Click);
            // 
            // siticoneRoundedButton85
            // 
            this.siticoneRoundedButton85.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton85.BorderThickness = 1;
            this.siticoneRoundedButton85.CheckedState.Parent = this.siticoneRoundedButton85;
            this.siticoneRoundedButton85.CustomImages.Parent = this.siticoneRoundedButton85;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton85, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton85.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton85.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton85.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton85.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton85.HoveredState.Parent = this.siticoneRoundedButton85;
            this.siticoneRoundedButton85.Location = new System.Drawing.Point(158, 15);
            this.siticoneRoundedButton85.Name = "siticoneRoundedButton85";
            this.siticoneRoundedButton85.ShadowDecoration.Parent = this.siticoneRoundedButton85;
            this.siticoneRoundedButton85.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton85.TabIndex = 100;
            this.siticoneRoundedButton85.Text = "Pie Chart";
            this.siticoneRoundedButton85.Click += new System.EventHandler(this.siticoneRoundedButton85_Click);
            // 
            // siticoneRoundedButton84
            // 
            this.siticoneRoundedButton84.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton84.BorderThickness = 1;
            this.siticoneRoundedButton84.CheckedState.Parent = this.siticoneRoundedButton84;
            this.siticoneRoundedButton84.CustomImages.Parent = this.siticoneRoundedButton84;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton84, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton84.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton84.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton84.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton84.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton84.HoveredState.Parent = this.siticoneRoundedButton84;
            this.siticoneRoundedButton84.Location = new System.Drawing.Point(158, 45);
            this.siticoneRoundedButton84.Name = "siticoneRoundedButton84";
            this.siticoneRoundedButton84.ShadowDecoration.Parent = this.siticoneRoundedButton84;
            this.siticoneRoundedButton84.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton84.TabIndex = 99;
            this.siticoneRoundedButton84.Text = "Fags Ahead";
            this.siticoneRoundedButton84.Click += new System.EventHandler(this.siticoneRoundedButton84_Click);
            // 
            // siticoneRoundedButton83
            // 
            this.siticoneRoundedButton83.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton83.BorderThickness = 1;
            this.siticoneRoundedButton83.CheckedState.Parent = this.siticoneRoundedButton83;
            this.siticoneRoundedButton83.CustomImages.Parent = this.siticoneRoundedButton83;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton83, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton83.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton83.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton83.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton83.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton83.HoveredState.Parent = this.siticoneRoundedButton83;
            this.siticoneRoundedButton83.Location = new System.Drawing.Point(158, 75);
            this.siticoneRoundedButton83.Name = "siticoneRoundedButton83";
            this.siticoneRoundedButton83.ShadowDecoration.Parent = this.siticoneRoundedButton83;
            this.siticoneRoundedButton83.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton83.TabIndex = 98;
            this.siticoneRoundedButton83.Text = "Twitter";
            this.siticoneRoundedButton83.Click += new System.EventHandler(this.siticoneRoundedButton83_Click);
            // 
            // siticoneRoundedButton81
            // 
            this.siticoneRoundedButton81.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton81.BorderThickness = 1;
            this.siticoneRoundedButton81.CheckedState.Parent = this.siticoneRoundedButton81;
            this.siticoneRoundedButton81.CustomImages.Parent = this.siticoneRoundedButton81;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton81, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton81.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton81.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton81.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton81.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton81.HoveredState.Parent = this.siticoneRoundedButton81;
            this.siticoneRoundedButton81.Location = new System.Drawing.Point(6, 195);
            this.siticoneRoundedButton81.Name = "siticoneRoundedButton81";
            this.siticoneRoundedButton81.ShadowDecoration.Parent = this.siticoneRoundedButton81;
            this.siticoneRoundedButton81.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton81.TabIndex = 96;
            this.siticoneRoundedButton81.Text = "Hi Im Gay";
            this.siticoneRoundedButton81.Click += new System.EventHandler(this.siticoneRoundedButton81_Click);
            // 
            // siticoneRoundedButton80
            // 
            this.siticoneRoundedButton80.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton80.BorderThickness = 1;
            this.siticoneRoundedButton80.CheckedState.Parent = this.siticoneRoundedButton80;
            this.siticoneRoundedButton80.CustomImages.Parent = this.siticoneRoundedButton80;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton80, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton80.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton80.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton80.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton80.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton80.HoveredState.Parent = this.siticoneRoundedButton80;
            this.siticoneRoundedButton80.Location = new System.Drawing.Point(6, 135);
            this.siticoneRoundedButton80.Name = "siticoneRoundedButton80";
            this.siticoneRoundedButton80.ShadowDecoration.Parent = this.siticoneRoundedButton80;
            this.siticoneRoundedButton80.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton80.TabIndex = 95;
            this.siticoneRoundedButton80.Text = "Marry Me";
            this.siticoneRoundedButton80.Click += new System.EventHandler(this.siticoneRoundedButton80_Click);
            // 
            // siticoneRoundedButton79
            // 
            this.siticoneRoundedButton79.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton79.BorderThickness = 1;
            this.siticoneRoundedButton79.CheckedState.Parent = this.siticoneRoundedButton79;
            this.siticoneRoundedButton79.CustomImages.Parent = this.siticoneRoundedButton79;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton79, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton79.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton79.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton79.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton79.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton79.HoveredState.Parent = this.siticoneRoundedButton79;
            this.siticoneRoundedButton79.Location = new System.Drawing.Point(6, 165);
            this.siticoneRoundedButton79.Name = "siticoneRoundedButton79";
            this.siticoneRoundedButton79.ShadowDecoration.Parent = this.siticoneRoundedButton79;
            this.siticoneRoundedButton79.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton79.TabIndex = 94;
            this.siticoneRoundedButton79.Text = "Cheat Codes";
            this.siticoneRoundedButton79.Click += new System.EventHandler(this.siticoneRoundedButton79_Click);
            // 
            // siticoneRoundedButton78
            // 
            this.siticoneRoundedButton78.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton78.BorderThickness = 1;
            this.siticoneRoundedButton78.CheckedState.Parent = this.siticoneRoundedButton78;
            this.siticoneRoundedButton78.CustomImages.Parent = this.siticoneRoundedButton78;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton78, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton78.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton78.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton78.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton78.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton78.HoveredState.Parent = this.siticoneRoundedButton78;
            this.siticoneRoundedButton78.Location = new System.Drawing.Point(6, 105);
            this.siticoneRoundedButton78.Name = "siticoneRoundedButton78";
            this.siticoneRoundedButton78.ShadowDecoration.Parent = this.siticoneRoundedButton78;
            this.siticoneRoundedButton78.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton78.TabIndex = 93;
            this.siticoneRoundedButton78.Text = "Hey Catch";
            this.siticoneRoundedButton78.Click += new System.EventHandler(this.siticoneRoundedButton78_Click);
            // 
            // siticoneRoundedButton77
            // 
            this.siticoneRoundedButton77.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton77.BorderThickness = 1;
            this.siticoneRoundedButton77.CheckedState.Parent = this.siticoneRoundedButton77;
            this.siticoneRoundedButton77.CustomImages.Parent = this.siticoneRoundedButton77;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton77, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton77.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton77.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton77.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton77.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton77.HoveredState.Parent = this.siticoneRoundedButton77;
            this.siticoneRoundedButton77.Location = new System.Drawing.Point(6, 75);
            this.siticoneRoundedButton77.Name = "siticoneRoundedButton77";
            this.siticoneRoundedButton77.ShadowDecoration.Parent = this.siticoneRoundedButton77;
            this.siticoneRoundedButton77.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton77.TabIndex = 92;
            this.siticoneRoundedButton77.Text = "Virgin";
            this.siticoneRoundedButton77.Click += new System.EventHandler(this.siticoneRoundedButton77_Click);
            // 
            // siticoneRoundedButton75
            // 
            this.siticoneRoundedButton75.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton75.BorderThickness = 1;
            this.siticoneRoundedButton75.CheckedState.Parent = this.siticoneRoundedButton75;
            this.siticoneRoundedButton75.CustomImages.Parent = this.siticoneRoundedButton75;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton75, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton75.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton75.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton75.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton75.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton75.HoveredState.Parent = this.siticoneRoundedButton75;
            this.siticoneRoundedButton75.Location = new System.Drawing.Point(6, 15);
            this.siticoneRoundedButton75.Name = "siticoneRoundedButton75";
            this.siticoneRoundedButton75.ShadowDecoration.Parent = this.siticoneRoundedButton75;
            this.siticoneRoundedButton75.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton75.TabIndex = 90;
            this.siticoneRoundedButton75.Text = "Jerk Off";
            this.siticoneRoundedButton75.Click += new System.EventHandler(this.siticoneRoundedButton75_Click);
            // 
            // siticoneRoundedButton66
            // 
            this.siticoneRoundedButton66.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton66.BorderThickness = 1;
            this.siticoneRoundedButton66.CheckedState.Parent = this.siticoneRoundedButton66;
            this.siticoneRoundedButton66.CustomImages.Parent = this.siticoneRoundedButton66;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton66, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton66.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton66.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton66.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton66.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton66.HoveredState.Parent = this.siticoneRoundedButton66;
            this.siticoneRoundedButton66.Location = new System.Drawing.Point(6, 45);
            this.siticoneRoundedButton66.Name = "siticoneRoundedButton66";
            this.siticoneRoundedButton66.ShadowDecoration.Parent = this.siticoneRoundedButton66;
            this.siticoneRoundedButton66.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton66.TabIndex = 89;
            this.siticoneRoundedButton66.Text = "Spotify";
            this.siticoneRoundedButton66.Click += new System.EventHandler(this.siticoneRoundedButton66_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage4.Controls.Add(this.siticoneRoundedButton28);
            this.tabPage4.Controls.Add(this.siticoneRoundedTextBox5);
            this.tabPage4.Controls.Add(this.siticoneRoundedButton12);
            this.tabPage4.Controls.Add(this.siticoneRoundedButton11);
            this.tabPage4.Controls.Add(this.gridControl1);
            this.siticoneTransition1.SetDecoration(this.tabPage4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(878, 540);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IP Puller";
            // 
            // siticoneRoundedButton28
            // 
            this.siticoneRoundedButton28.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton28.BorderThickness = 1;
            this.siticoneRoundedButton28.CheckedState.Parent = this.siticoneRoundedButton28;
            this.siticoneRoundedButton28.CustomImages.Parent = this.siticoneRoundedButton28;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton28, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton28.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton28.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton28.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton28.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton28.HoveredState.Parent = this.siticoneRoundedButton28;
            this.siticoneRoundedButton28.Location = new System.Drawing.Point(6, 458);
            this.siticoneRoundedButton28.Name = "siticoneRoundedButton28";
            this.siticoneRoundedButton28.ShadowDecoration.Parent = this.siticoneRoundedButton28;
            this.siticoneRoundedButton28.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton28.TabIndex = 88;
            this.siticoneRoundedButton28.Text = "Use As Host (IP)";
            this.siticoneRoundedButton28.Click += new System.EventHandler(this.siticoneRoundedButton28_Click);
            // 
            // siticoneRoundedTextBox5
            // 
            this.siticoneRoundedTextBox5.AllowDrop = true;
            this.siticoneRoundedTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox5.DefaultText = "0.0.0.0";
            this.siticoneRoundedTextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox5.DisabledState.Parent = this.siticoneRoundedTextBox5;
            this.siticoneRoundedTextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox5.FocusedState.Parent = this.siticoneRoundedTextBox5;
            this.siticoneRoundedTextBox5.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox5.HoveredState.Parent = this.siticoneRoundedTextBox5;
            this.siticoneRoundedTextBox5.Location = new System.Drawing.Point(716, 458);
            this.siticoneRoundedTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox5.Name = "siticoneRoundedTextBox5";
            this.siticoneRoundedTextBox5.PasswordChar = '\0';
            this.siticoneRoundedTextBox5.PlaceholderText = "";
            this.siticoneRoundedTextBox5.SelectedText = "";
            this.siticoneRoundedTextBox5.ShadowDecoration.Parent = this.siticoneRoundedTextBox5;
            this.siticoneRoundedTextBox5.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedTextBox5.TabIndex = 87;
            this.siticoneRoundedTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton12
            // 
            this.siticoneRoundedButton12.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton12.BorderThickness = 1;
            this.siticoneRoundedButton12.CheckedState.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.CustomImages.Parent = this.siticoneRoundedButton12;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton12.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton12.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton12.HoveredState.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.Location = new System.Drawing.Point(716, 427);
            this.siticoneRoundedButton12.Name = "siticoneRoundedButton12";
            this.siticoneRoundedButton12.ShadowDecoration.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton12.TabIndex = 30;
            this.siticoneRoundedButton12.Text = "Ping IP";
            this.siticoneRoundedButton12.Click += new System.EventHandler(this.siticoneRoundedButton12_Click);
            // 
            // siticoneRoundedButton11
            // 
            this.siticoneRoundedButton11.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton11.BorderThickness = 1;
            this.siticoneRoundedButton11.CheckedState.Parent = this.siticoneRoundedButton11;
            this.siticoneRoundedButton11.CustomImages.Parent = this.siticoneRoundedButton11;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton11.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton11.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton11.HoveredState.Parent = this.siticoneRoundedButton11;
            this.siticoneRoundedButton11.Location = new System.Drawing.Point(6, 427);
            this.siticoneRoundedButton11.Name = "siticoneRoundedButton11";
            this.siticoneRoundedButton11.ShadowDecoration.Parent = this.siticoneRoundedButton11;
            this.siticoneRoundedButton11.Size = new System.Drawing.Size(146, 24);
            this.siticoneRoundedButton11.TabIndex = 29;
            this.siticoneRoundedButton11.Text = "Grab IP\'s";
            this.siticoneRoundedButton11.Click += new System.EventHandler(this.siticoneRoundedButton11_Click);
            // 
            // gridControl1
            // 
            this.siticoneTransition1.SetDecoration(this.gridControl1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.LookAndFeel.SkinName = "Office 2016 Black";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(856, 415);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage6.Controls.Add(this.siticoneRoundedButton166);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton171);
            this.tabPage6.Controls.Add(this.listView1);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton172);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton130);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton132);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton133);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton129);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton128);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton127);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton126);
            this.tabPage6.Controls.Add(this.siticoneRoundedTextBox39);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton103);
            this.tabPage6.Controls.Add(this.siticoneRoundedTextBox38);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton82);
            this.tabPage6.Controls.Add(this.siticoneRoundedTextBox34);
            this.tabPage6.Controls.Add(this.siticoneRoundedButton102);
            this.tabPage6.Controls.Add(this.siticoneRoundedTextBox37);
            this.siticoneTransition1.SetDecoration(this.tabPage6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage6.Location = new System.Drawing.Point(184, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(878, 540);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Extra";
            // 
            // siticoneRoundedButton166
            // 
            this.siticoneRoundedButton166.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton166.BorderThickness = 1;
            this.siticoneRoundedButton166.CheckedState.Parent = this.siticoneRoundedButton166;
            this.siticoneRoundedButton166.CustomImages.Parent = this.siticoneRoundedButton166;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton166, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton166.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton166.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton166.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton166.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton166.HoveredState.Parent = this.siticoneRoundedButton166;
            this.siticoneRoundedButton166.Location = new System.Drawing.Point(6, 340);
            this.siticoneRoundedButton166.Name = "siticoneRoundedButton166";
            this.siticoneRoundedButton166.ShadowDecoration.Parent = this.siticoneRoundedButton166;
            this.siticoneRoundedButton166.Size = new System.Drawing.Size(147, 36);
            this.siticoneRoundedButton166.TabIndex = 176;
            this.siticoneRoundedButton166.Text = "Set all clinets";
            this.siticoneRoundedButton166.Click += new System.EventHandler(this.siticoneRoundedButton166_Click);
            // 
            // siticoneRoundedButton171
            // 
            this.siticoneRoundedButton171.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton171.BorderThickness = 1;
            this.siticoneRoundedButton171.CheckedState.Parent = this.siticoneRoundedButton171;
            this.siticoneRoundedButton171.CustomImages.Parent = this.siticoneRoundedButton171;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton171, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton171.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton171.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton171.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton171.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton171.HoveredState.Parent = this.siticoneRoundedButton171;
            this.siticoneRoundedButton171.Location = new System.Drawing.Point(661, 15);
            this.siticoneRoundedButton171.Name = "siticoneRoundedButton171";
            this.siticoneRoundedButton171.ShadowDecoration.Parent = this.siticoneRoundedButton171;
            this.siticoneRoundedButton171.Size = new System.Drawing.Size(115, 24);
            this.siticoneRoundedButton171.TabIndex = 175;
            this.siticoneRoundedButton171.Text = "Freeze Client";
            this.siticoneRoundedButton171.Click += new System.EventHandler(this.siticoneRoundedButton171_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.listView1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(395, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(260, 303);
            this.listView1.TabIndex = 174;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // siticoneRoundedButton172
            // 
            this.siticoneRoundedButton172.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton172.BorderThickness = 1;
            this.siticoneRoundedButton172.CheckedState.Parent = this.siticoneRoundedButton172;
            this.siticoneRoundedButton172.CustomImages.Parent = this.siticoneRoundedButton172;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton172, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton172.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton172.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton172.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton172.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton172.HoveredState.Parent = this.siticoneRoundedButton172;
            this.siticoneRoundedButton172.Location = new System.Drawing.Point(440, 324);
            this.siticoneRoundedButton172.Name = "siticoneRoundedButton172";
            this.siticoneRoundedButton172.ShadowDecoration.Parent = this.siticoneRoundedButton172;
            this.siticoneRoundedButton172.Size = new System.Drawing.Size(182, 24);
            this.siticoneRoundedButton172.TabIndex = 173;
            this.siticoneRoundedButton172.Text = "Grab Clients";
            this.siticoneRoundedButton172.Click += new System.EventHandler(this.siticoneRoundedButton172_Click);
            // 
            // siticoneRoundedButton130
            // 
            this.siticoneRoundedButton130.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton130.BorderThickness = 1;
            this.siticoneRoundedButton130.CheckedState.Parent = this.siticoneRoundedButton130;
            this.siticoneRoundedButton130.CustomImages.Parent = this.siticoneRoundedButton130;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton130, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton130.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton130.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton130.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton130.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton130.HoveredState.Parent = this.siticoneRoundedButton130;
            this.siticoneRoundedButton130.Location = new System.Drawing.Point(362, 282);
            this.siticoneRoundedButton130.Name = "siticoneRoundedButton130";
            this.siticoneRoundedButton130.ShadowDecoration.Parent = this.siticoneRoundedButton130;
            this.siticoneRoundedButton130.Size = new System.Drawing.Size(27, 29);
            this.siticoneRoundedButton130.TabIndex = 172;
            this.siticoneRoundedButton130.Text = "?";
            this.siticoneRoundedButton130.Click += new System.EventHandler(this.siticoneRoundedButton130_Click);
            // 
            // siticoneRoundedButton132
            // 
            this.siticoneRoundedButton132.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton132.BorderThickness = 1;
            this.siticoneRoundedButton132.CheckedState.Parent = this.siticoneRoundedButton132;
            this.siticoneRoundedButton132.CustomImages.Parent = this.siticoneRoundedButton132;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton132, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton132.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton132.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton132.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton132.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton132.HoveredState.Parent = this.siticoneRoundedButton132;
            this.siticoneRoundedButton132.Location = new System.Drawing.Point(6, 282);
            this.siticoneRoundedButton132.Name = "siticoneRoundedButton132";
            this.siticoneRoundedButton132.ShadowDecoration.Parent = this.siticoneRoundedButton132;
            this.siticoneRoundedButton132.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton132.TabIndex = 171;
            this.siticoneRoundedButton132.Text = "Send To Zombies";
            this.siticoneRoundedButton132.Click += new System.EventHandler(this.siticoneRoundedButton132_Click);
            // 
            // siticoneRoundedButton133
            // 
            this.siticoneRoundedButton133.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton133.BorderThickness = 1;
            this.siticoneRoundedButton133.CheckedState.Parent = this.siticoneRoundedButton133;
            this.siticoneRoundedButton133.CustomImages.Parent = this.siticoneRoundedButton133;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton133, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton133.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton133.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton133.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton133.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton133.HoveredState.Parent = this.siticoneRoundedButton133;
            this.siticoneRoundedButton133.Location = new System.Drawing.Point(184, 282);
            this.siticoneRoundedButton133.Name = "siticoneRoundedButton133";
            this.siticoneRoundedButton133.ShadowDecoration.Parent = this.siticoneRoundedButton133;
            this.siticoneRoundedButton133.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton133.TabIndex = 170;
            this.siticoneRoundedButton133.Text = "Freeze Console";
            this.siticoneRoundedButton133.Click += new System.EventHandler(this.siticoneRoundedButton133_Click);
            // 
            // siticoneRoundedButton129
            // 
            this.siticoneRoundedButton129.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton129.BorderThickness = 1;
            this.siticoneRoundedButton129.CheckedState.Parent = this.siticoneRoundedButton129;
            this.siticoneRoundedButton129.CustomImages.Parent = this.siticoneRoundedButton129;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton129, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton129.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton129.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton129.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton129.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton129.HoveredState.Parent = this.siticoneRoundedButton129;
            this.siticoneRoundedButton129.Location = new System.Drawing.Point(184, 212);
            this.siticoneRoundedButton129.Name = "siticoneRoundedButton129";
            this.siticoneRoundedButton129.ShadowDecoration.Parent = this.siticoneRoundedButton129;
            this.siticoneRoundedButton129.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton129.TabIndex = 167;
            this.siticoneRoundedButton129.Text = "Freeze Controls";
            this.siticoneRoundedButton129.Click += new System.EventHandler(this.siticoneRoundedButton129_Click);
            // 
            // siticoneRoundedButton128
            // 
            this.siticoneRoundedButton128.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton128.BorderThickness = 1;
            this.siticoneRoundedButton128.CheckedState.Parent = this.siticoneRoundedButton128;
            this.siticoneRoundedButton128.CustomImages.Parent = this.siticoneRoundedButton128;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton128, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton128.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton128.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton128.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton128.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton128.HoveredState.Parent = this.siticoneRoundedButton128;
            this.siticoneRoundedButton128.Location = new System.Drawing.Point(6, 247);
            this.siticoneRoundedButton128.Name = "siticoneRoundedButton128";
            this.siticoneRoundedButton128.ShadowDecoration.Parent = this.siticoneRoundedButton128;
            this.siticoneRoundedButton128.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton128.TabIndex = 166;
            this.siticoneRoundedButton128.Text = "Send To Dash";
            this.siticoneRoundedButton128.Click += new System.EventHandler(this.siticoneRoundedButton128_Click);
            // 
            // siticoneRoundedButton127
            // 
            this.siticoneRoundedButton127.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton127.BorderThickness = 1;
            this.siticoneRoundedButton127.CheckedState.Parent = this.siticoneRoundedButton127;
            this.siticoneRoundedButton127.CustomImages.Parent = this.siticoneRoundedButton127;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton127, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton127.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton127.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton127.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton127.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton127.HoveredState.Parent = this.siticoneRoundedButton127;
            this.siticoneRoundedButton127.Location = new System.Drawing.Point(184, 247);
            this.siticoneRoundedButton127.Name = "siticoneRoundedButton127";
            this.siticoneRoundedButton127.ShadowDecoration.Parent = this.siticoneRoundedButton127;
            this.siticoneRoundedButton127.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton127.TabIndex = 165;
            this.siticoneRoundedButton127.Text = "Send To Single Player";
            this.siticoneRoundedButton127.Click += new System.EventHandler(this.siticoneRoundedButton127_Click);
            // 
            // siticoneRoundedButton126
            // 
            this.siticoneRoundedButton126.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton126.BorderThickness = 1;
            this.siticoneRoundedButton126.CheckedState.Parent = this.siticoneRoundedButton126;
            this.siticoneRoundedButton126.CustomImages.Parent = this.siticoneRoundedButton126;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton126, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton126.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton126.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton126.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton126.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton126.HoveredState.Parent = this.siticoneRoundedButton126;
            this.siticoneRoundedButton126.Location = new System.Drawing.Point(6, 212);
            this.siticoneRoundedButton126.Name = "siticoneRoundedButton126";
            this.siticoneRoundedButton126.ShadowDecoration.Parent = this.siticoneRoundedButton126;
            this.siticoneRoundedButton126.Size = new System.Drawing.Size(172, 29);
            this.siticoneRoundedButton126.TabIndex = 164;
            this.siticoneRoundedButton126.Text = "Derank";
            this.siticoneRoundedButton126.Click += new System.EventHandler(this.siticoneRoundedButton126_Click);
            // 
            // siticoneRoundedTextBox39
            // 
            this.siticoneRoundedTextBox39.AllowDrop = true;
            this.siticoneRoundedTextBox39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox39.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox39, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox39.DefaultText = "Kill Feed";
            this.siticoneRoundedTextBox39.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox39.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox39.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox39.DisabledState.Parent = this.siticoneRoundedTextBox39;
            this.siticoneRoundedTextBox39.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox39.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox39.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox39.FocusedState.Parent = this.siticoneRoundedTextBox39;
            this.siticoneRoundedTextBox39.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox39.HoveredState.Parent = this.siticoneRoundedTextBox39;
            this.siticoneRoundedTextBox39.Location = new System.Drawing.Point(6, 160);
            this.siticoneRoundedTextBox39.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox39.Name = "siticoneRoundedTextBox39";
            this.siticoneRoundedTextBox39.PasswordChar = '\0';
            this.siticoneRoundedTextBox39.PlaceholderText = "";
            this.siticoneRoundedTextBox39.SelectedText = "";
            this.siticoneRoundedTextBox39.ShadowDecoration.Parent = this.siticoneRoundedTextBox39;
            this.siticoneRoundedTextBox39.Size = new System.Drawing.Size(370, 29);
            this.siticoneRoundedTextBox39.TabIndex = 158;
            this.siticoneRoundedTextBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton103
            // 
            this.siticoneRoundedButton103.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton103.BorderThickness = 1;
            this.siticoneRoundedButton103.CheckedState.Parent = this.siticoneRoundedButton103;
            this.siticoneRoundedButton103.CustomImages.Parent = this.siticoneRoundedButton103;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton103, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton103.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton103.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton103.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton103.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton103.HoveredState.Parent = this.siticoneRoundedButton103;
            this.siticoneRoundedButton103.Location = new System.Drawing.Point(6, 87);
            this.siticoneRoundedButton103.Name = "siticoneRoundedButton103";
            this.siticoneRoundedButton103.ShadowDecoration.Parent = this.siticoneRoundedButton103;
            this.siticoneRoundedButton103.Size = new System.Drawing.Size(370, 29);
            this.siticoneRoundedButton103.TabIndex = 157;
            this.siticoneRoundedButton103.Text = "Spam Killfeed + Center Message [OFF]";
            this.siticoneRoundedButton103.Click += new System.EventHandler(this.siticoneRoundedButton103_Click);
            // 
            // siticoneRoundedTextBox38
            // 
            this.siticoneRoundedTextBox38.AllowDrop = true;
            this.siticoneRoundedTextBox38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox38.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox38, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox38.DefaultText = "Center";
            this.siticoneRoundedTextBox38.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox38.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox38.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox38.DisabledState.Parent = this.siticoneRoundedTextBox38;
            this.siticoneRoundedTextBox38.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox38.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox38.FocusedState.Parent = this.siticoneRoundedTextBox38;
            this.siticoneRoundedTextBox38.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox38.HoveredState.Parent = this.siticoneRoundedTextBox38;
            this.siticoneRoundedTextBox38.Location = new System.Drawing.Point(6, 123);
            this.siticoneRoundedTextBox38.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox38.Name = "siticoneRoundedTextBox38";
            this.siticoneRoundedTextBox38.PasswordChar = '\0';
            this.siticoneRoundedTextBox38.PlaceholderText = "";
            this.siticoneRoundedTextBox38.SelectedText = "";
            this.siticoneRoundedTextBox38.ShadowDecoration.Parent = this.siticoneRoundedTextBox38;
            this.siticoneRoundedTextBox38.Size = new System.Drawing.Size(370, 29);
            this.siticoneRoundedTextBox38.TabIndex = 156;
            this.siticoneRoundedTextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton82
            // 
            this.siticoneRoundedButton82.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton82.BorderThickness = 1;
            this.siticoneRoundedButton82.CheckedState.Parent = this.siticoneRoundedButton82;
            this.siticoneRoundedButton82.CustomImages.Parent = this.siticoneRoundedButton82;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton82, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton82.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton82.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton82.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton82.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton82.HoveredState.Parent = this.siticoneRoundedButton82;
            this.siticoneRoundedButton82.Location = new System.Drawing.Point(6, 15);
            this.siticoneRoundedButton82.Name = "siticoneRoundedButton82";
            this.siticoneRoundedButton82.ShadowDecoration.Parent = this.siticoneRoundedButton82;
            this.siticoneRoundedButton82.Size = new System.Drawing.Size(182, 29);
            this.siticoneRoundedButton82.TabIndex = 155;
            this.siticoneRoundedButton82.Text = "Send Center Message";
            this.siticoneRoundedButton82.Click += new System.EventHandler(this.siticoneRoundedButton82_Click);
            // 
            // siticoneRoundedTextBox34
            // 
            this.siticoneRoundedTextBox34.AllowDrop = true;
            this.siticoneRoundedTextBox34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox34.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox34, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox34.DefaultText = "^6Shutter CR";
            this.siticoneRoundedTextBox34.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox34.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox34.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox34.DisabledState.Parent = this.siticoneRoundedTextBox34;
            this.siticoneRoundedTextBox34.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox34.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox34.FocusedState.Parent = this.siticoneRoundedTextBox34;
            this.siticoneRoundedTextBox34.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox34.HoveredState.Parent = this.siticoneRoundedTextBox34;
            this.siticoneRoundedTextBox34.Location = new System.Drawing.Point(6, 51);
            this.siticoneRoundedTextBox34.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox34.Name = "siticoneRoundedTextBox34";
            this.siticoneRoundedTextBox34.PasswordChar = '\0';
            this.siticoneRoundedTextBox34.PlaceholderText = "";
            this.siticoneRoundedTextBox34.SelectedText = "";
            this.siticoneRoundedTextBox34.ShadowDecoration.Parent = this.siticoneRoundedTextBox34;
            this.siticoneRoundedTextBox34.Size = new System.Drawing.Size(182, 29);
            this.siticoneRoundedTextBox34.TabIndex = 154;
            this.siticoneRoundedTextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneRoundedButton102
            // 
            this.siticoneRoundedButton102.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton102.BorderThickness = 1;
            this.siticoneRoundedButton102.CheckedState.Parent = this.siticoneRoundedButton102;
            this.siticoneRoundedButton102.CustomImages.Parent = this.siticoneRoundedButton102;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton102, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton102.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton102.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton102.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton102.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton102.HoveredState.Parent = this.siticoneRoundedButton102;
            this.siticoneRoundedButton102.Location = new System.Drawing.Point(194, 15);
            this.siticoneRoundedButton102.Name = "siticoneRoundedButton102";
            this.siticoneRoundedButton102.ShadowDecoration.Parent = this.siticoneRoundedButton102;
            this.siticoneRoundedButton102.Size = new System.Drawing.Size(182, 29);
            this.siticoneRoundedButton102.TabIndex = 153;
            this.siticoneRoundedButton102.Text = "Send Kill Feed Message";
            this.siticoneRoundedButton102.Click += new System.EventHandler(this.siticoneRoundedButton102_Click);
            // 
            // siticoneRoundedTextBox37
            // 
            this.siticoneRoundedTextBox37.AllowDrop = true;
            this.siticoneRoundedTextBox37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedTextBox37.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedTextBox37, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedTextBox37.DefaultText = "^6Shutter CR";
            this.siticoneRoundedTextBox37.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox37.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox37.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox37.DisabledState.Parent = this.siticoneRoundedTextBox37;
            this.siticoneRoundedTextBox37.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox37.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedTextBox37.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox37.FocusedState.Parent = this.siticoneRoundedTextBox37;
            this.siticoneRoundedTextBox37.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox37.HoveredState.Parent = this.siticoneRoundedTextBox37;
            this.siticoneRoundedTextBox37.Location = new System.Drawing.Point(194, 51);
            this.siticoneRoundedTextBox37.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedTextBox37.Name = "siticoneRoundedTextBox37";
            this.siticoneRoundedTextBox37.PasswordChar = '\0';
            this.siticoneRoundedTextBox37.PlaceholderText = "";
            this.siticoneRoundedTextBox37.SelectedText = "";
            this.siticoneRoundedTextBox37.ShadowDecoration.Parent = this.siticoneRoundedTextBox37;
            this.siticoneRoundedTextBox37.Size = new System.Drawing.Size(182, 29);
            this.siticoneRoundedTextBox37.TabIndex = 152;
            this.siticoneRoundedTextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage7.Controls.Add(this.siticoneRoundedButton108);
            this.tabPage7.Controls.Add(this.siticoneRoundedButton107);
            this.tabPage7.Controls.Add(this.siticoneRoundedButton106);
            this.tabPage7.Controls.Add(this.pictureEdit1);
            this.siticoneTransition1.SetDecoration(this.tabPage7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage7.Location = new System.Drawing.Point(184, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(878, 540);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Screenshot";
            // 
            // siticoneRoundedButton108
            // 
            this.siticoneRoundedButton108.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton108.BorderThickness = 1;
            this.siticoneRoundedButton108.CheckedState.Parent = this.siticoneRoundedButton108;
            this.siticoneRoundedButton108.CustomImages.Parent = this.siticoneRoundedButton108;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton108, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton108.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton108.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton108.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton108.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton108.HoveredState.Parent = this.siticoneRoundedButton108;
            this.siticoneRoundedButton108.Location = new System.Drawing.Point(742, 36);
            this.siticoneRoundedButton108.Name = "siticoneRoundedButton108";
            this.siticoneRoundedButton108.ShadowDecoration.Parent = this.siticoneRoundedButton108;
            this.siticoneRoundedButton108.Size = new System.Drawing.Size(130, 24);
            this.siticoneRoundedButton108.TabIndex = 92;
            this.siticoneRoundedButton108.Text = "Copy Screenshot";
            this.siticoneRoundedButton108.Click += new System.EventHandler(this.siticoneRoundedButton108_Click);
            // 
            // siticoneRoundedButton107
            // 
            this.siticoneRoundedButton107.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton107.BorderThickness = 1;
            this.siticoneRoundedButton107.CheckedState.Parent = this.siticoneRoundedButton107;
            this.siticoneRoundedButton107.CustomImages.Parent = this.siticoneRoundedButton107;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton107, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton107.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton107.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton107.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton107.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton107.HoveredState.Parent = this.siticoneRoundedButton107;
            this.siticoneRoundedButton107.Location = new System.Drawing.Point(742, 66);
            this.siticoneRoundedButton107.Name = "siticoneRoundedButton107";
            this.siticoneRoundedButton107.ShadowDecoration.Parent = this.siticoneRoundedButton107;
            this.siticoneRoundedButton107.Size = new System.Drawing.Size(130, 24);
            this.siticoneRoundedButton107.TabIndex = 91;
            this.siticoneRoundedButton107.Text = "Save Screenshot";
            this.siticoneRoundedButton107.Click += new System.EventHandler(this.siticoneRoundedButton107_Click);
            // 
            // siticoneRoundedButton106
            // 
            this.siticoneRoundedButton106.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton106.BorderThickness = 1;
            this.siticoneRoundedButton106.CheckedState.Parent = this.siticoneRoundedButton106;
            this.siticoneRoundedButton106.CustomImages.Parent = this.siticoneRoundedButton106;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton106, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton106.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton106.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton106.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton106.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton106.HoveredState.Parent = this.siticoneRoundedButton106;
            this.siticoneRoundedButton106.Location = new System.Drawing.Point(742, 6);
            this.siticoneRoundedButton106.Name = "siticoneRoundedButton106";
            this.siticoneRoundedButton106.ShadowDecoration.Parent = this.siticoneRoundedButton106;
            this.siticoneRoundedButton106.Size = new System.Drawing.Size(130, 24);
            this.siticoneRoundedButton106.TabIndex = 90;
            this.siticoneRoundedButton106.Text = "Take Screenshot";
            this.siticoneRoundedButton106.Click += new System.EventHandler(this.siticoneRoundedButton106_Click);
            // 
            // pictureEdit1
            // 
            this.siticoneTransition1.SetDecoration(this.pictureEdit1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureEdit1.Location = new System.Drawing.Point(6, 6);
            this.pictureEdit1.Name = "pictureEdit1";
            // 
            // 
            // 
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(730, 515);
            this.pictureEdit1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // styleController1
            // 
            this.styleController1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.styleController1.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1072, 582);
            this.Controls.Add(this.siticoneTabControl1);
            this.Controls.Add(this.userrank);
            this.Controls.Add(this.uservariable);
            this.Controls.Add(this.hwid);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutter CR";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.siticoneTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public string MapChangeForceStartName;

        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        private Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        private Label label1;

        private Label label2;

        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

        private SiticoneRoundedTextBox variable;

        private SiticoneLabel hwid;

        private SiticoneLabel email;

        private SiticoneLabel userrank;

        private SiticoneLabel uservariable;

        private SiticoneLabel siticoneLabel7;

        private SiticoneLabel expiry;

        private SiticoneLabel ip;

        private SiticoneLabel welcome;

        private SiticoneLabel lastlogin;

        private SiticoneLabel siticoneLabel1;

        private SiticoneLabel siticoneLabel2;

        private SiticoneLabel registerdate;

        private SiticoneLabel siticoneLabel3;

        private SiticoneLabel siticoneLabel4;

        private SiticoneLabel siticoneLabel5;

        private SiticoneLabel siticoneLabel6;

        private SiticoneTabControl siticoneTabControl1;

        private TabPage tabPage1;

        private TabPage tabPage2;

        private TabPage tabPage3;

        private SiticoneLabel siticoneLabel8;

        private Panel panel4;

        private Panel panel3;

        private Panel panel2;

        private Panel panel1;

        private SiticoneLabel siticoneLabel13;

        private SiticoneLabel siticoneLabel12;

        private SiticoneLabel siticoneLabel11;

        private SiticoneLabel siticoneLabel10;

        private SiticoneLabel WelcomeText;

        private Panel panel6;

        private Panel panel5;

        private Panel panel7;

        private SiticoneLabel siticoneLabel19;

        private SiticoneLabel siticoneLabel18;

        private SiticoneLabel siticoneLabel17;

        private SiticoneLabel siticoneLabel16;

        private SiticoneLabel siticoneLabel15;

        private SiticoneLabel siticoneLabel14;

        private SiticoneLabel siticoneLabel22;

        private SiticoneLabel siticoneLabel21;

        private SiticoneLabel siticoneLabel20;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton5;

        private SiticoneRoundedTextBox siticoneRoundedTextBox2;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton4;

        private SiticoneRoundedTextBox siticoneRoundedTextBox1;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton9;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton8;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton7;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton6;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton10;

        private TabPage tabPage4;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton12;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton11;

        private GridControl gridControl1;

        private GridView gridView1;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton13;

        private SiticoneRoundedTextBox siticoneRoundedTextBox3;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton14;

        private SiticoneRoundedTextBox siticoneRoundedTextBox4;

        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox3;

        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox2;

        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Timer timer2;

        private System.Windows.Forms.Timer timer3;

        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox5;

        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox4;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton26;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton25;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton24;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton23;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton22;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton21;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton20;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton19;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton18;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton17;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton16;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton15;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton27;

        private SiticoneRoundedTextBox siticoneRoundedTextBox5;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton28;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton30;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton31;

        private SiticoneRoundedTextBox siticoneRoundedTextBox8;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton29;

        private SiticoneRoundedTextBox siticoneRoundedTextBox6;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton34;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton35;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton32;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton33;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton36;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton37;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton38;

        private SiticoneRoundedTextBox siticoneRoundedTextBox7;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton39;

        private SiticoneRoundedTextBox siticoneRoundedTextBox9;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton40;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton43;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton44;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton45;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton46;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton48;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton50;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton51;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton52;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton53;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton47;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton59;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton49;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton54;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton55;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton56;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton57;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton58;

        private TabPage tabPage5;

        private SiticoneRoundedTextBox siticoneRoundedTextBox22;

        private SiticoneRoundedTextBox siticoneRoundedTextBox21;

        private SiticoneRoundedTextBox siticoneRoundedTextBox20;

        private SiticoneRoundedTextBox siticoneRoundedTextBox19;

        private SiticoneRoundedTextBox siticoneRoundedTextBox18;

        private SiticoneRoundedTextBox siticoneRoundedTextBox17;

        private SiticoneRoundedTextBox siticoneRoundedTextBox16;

        private SiticoneRoundedTextBox siticoneRoundedTextBox15;

        private SiticoneRoundedTextBox siticoneRoundedTextBox14;

        private SiticoneRoundedTextBox siticoneRoundedTextBox13;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton61;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton60;

        private SiticoneRoundedTextBox siticoneRoundedTextBox12;

        private SiticoneRoundedTextBox siticoneRoundedTextBox23;

        private SiticoneRoundedTextBox siticoneRoundedTextBox24;

        private SiticoneRoundedTextBox siticoneRoundedTextBox25;

        private SiticoneRoundedTextBox siticoneRoundedTextBox26;

        private SiticoneRoundedTextBox siticoneRoundedTextBox27;

        private SiticoneRoundedTextBox siticoneRoundedTextBox28;

        private SiticoneRoundedTextBox siticoneRoundedTextBox29;

        private SiticoneRoundedTextBox siticoneRoundedTextBox30;

        private SiticoneRoundedTextBox siticoneRoundedTextBox31;

        private SiticoneRoundedTextBox siticoneRoundedTextBox32;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton62;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton63;

        private SiticoneRoundedTextBox siticoneRoundedTextBox33;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton74;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton73;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton72;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton71;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton70;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton69;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton68;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton67;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton65;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton64;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton88;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton87;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton86;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton85;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton84;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton83;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton81;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton80;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton79;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton78;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton77;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton75;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton66;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton92;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton91;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton90;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton89;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton95;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton94;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton93;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton98;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton99;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton96;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton97;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton76;

        private System.Windows.Forms.Timer timer4;

        private TabPage tabPage6;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton103;

        private SiticoneRoundedTextBox siticoneRoundedTextBox38;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton82;

        private SiticoneRoundedTextBox siticoneRoundedTextBox34;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton102;

        private SiticoneRoundedTextBox siticoneRoundedTextBox37;

        private SiticoneRoundedTextBox siticoneRoundedTextBox39;

        private System.Windows.Forms.Timer timer5;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton100;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton101;

        private SiticoneRoundedTextBox siticoneRoundedTextBox35;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton104;

        private TabPage tabPage7;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton108;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton107;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton106;

        private PictureEdit pictureEdit1;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton105;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton110;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton113;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton112;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton123;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton124;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton121;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton122;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton119;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton120;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton118;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton116;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton111;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton114;

        private SiticoneRoundedTextBox siticoneRoundedTextBox36;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton115;

        private SiticoneRoundedTextBox siticoneRoundedTextBox40;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton117;

        private SiticoneRoundedTextBox siticoneRoundedTextBox41;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton41;

        private SiticoneRoundedTextBox siticoneRoundedTextBox10;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton125;

        private SiticoneRoundedTextBox siticoneRoundedTextBox11;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton132;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton133;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton129;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton128;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton127;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton126;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton130;

        private TabPage tabPage8;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton131;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton160;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton159;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton158;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton157;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton156;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton155;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton154;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton153;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton152;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton151;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton150;

        private Label label4;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton149;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton148;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton147;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton146;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton145;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton144;

        private Label label3;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton143;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton142;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton141;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton140;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton139;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton138;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton137;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton136;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton135;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton42;

        private Label label5;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton163;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton161;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton162;

        private SiticoneLabel siticoneLabel25;

        private SiticoneLabel siticoneLabel23;

        private SiticoneLabel siticoneLabel24;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton165;

        private Label label6;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton168;

        private SiticoneRoundedTextBox siticoneRoundedTextBox44;

        private SiticoneRoundedTextBox siticoneRoundedTextBox42;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton109;

        private TextBox textBox1;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton164;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton134;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton171;

        private ListView listView1;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton172;

        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar siticoneTrackBar1;

        private StyleController styleController1;

        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton166;
        #endregion

        private Button button1;
        private Button button2;
    }
}

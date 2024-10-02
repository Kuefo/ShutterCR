using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DiscordRPC;
using Imaging.DDSReader;
using JRPC_Client;
using SafeGuard;
using Siticone.Desktop.UI.WinForms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using XDevkit;

namespace Auth.GG_Winform_Example
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			ShutterRPC.Initialize();
		}
        public void Toast(int client, string Icon, string Title, string Desc, int Dur)
		{
			try
			{
				Console.CallVoid(0x82454800, new object[]
				{
					client,
					Icon,
					Title,
					Desc,
					Dur * 1000
				});
			}
			catch (Exception)
			{
			}
		}

		private async void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			if (Console.Connect(out Console, "default"))
			{
                siticoneRoundedButton2.Text = "Re-Connect To Console";
				siticoneRoundedButton2.ForeColor = Color.White;
				Console.XNotify("Connected to Shutter successfully");
				Console.XNotify("Welcome '" + Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]) + "' To Shutter CR!");
				siticoneRoundedTextBox3.Text = (Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]) ?? "");
			}
			else
			{
				if (MessageBox.Show("Make Sure you have JRPC2 as a plugin.\n\n1. Make sure you have your console set as default in neighbourhood!\n2. Make sure the folder has the following .dlls!\n(xdevkit.dll + JRPC.dll)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand) != DialogResult.OK)
				{
				}
				siticoneRoundedButton2.Text = "Unable To Connect";
				siticoneRoundedButton2.ForeColor = Color.Red;
			}
			WelcomeText.Text = "Welcome back, Gonzo!";
			siticoneLabel13.Text = "IP: 1.1.1.1";
			siticoneLabel12.Text = "Expiry: Gonzo";
			siticoneLabel11.Text = "Last Login: Right now";
			siticoneLabel10.Text = "Register Date: Uhh, Yesterday?";
			siticoneLabel25.Text = "Email: Gonzo@FreeCore.com";
			siticoneLabel7.Text = "CPU Key: " + Console.GetCPUKey();
			siticoneLabel14.Text = "Kernel: " + Console.GetKernalVersion();
			siticoneLabel15.Text = "Internal IP: " + Console.XboxIP();
			siticoneLabel16.Text = "Console Type: " + Console.ConsoleType();
			siticoneLabel16.Text = "GPU Temperature: " + Console.GetTemperature(JRPC.TemperatureType.GPU);
			siticoneLabel17.Text = "CPU Temperature: " + Console.GetTemperature(JRPC.TemperatureType.CPU);
			siticoneLabel18.Text = "MotherBoard Temperature: " + Console.GetTemperature(JRPC.TemperatureType.MotherBoard);
			siticoneLabel19.Text = "RAM Temperature: " + Console.GetTemperature(JRPC.TemperatureType.EDRAM);
			siticoneLabel20.Text = "Hash: " + Console.GetHashCode();
			siticoneLabel21.Text = "Console Name: " + Console.Name;
			siticoneLabel22.Text = "Title ID: " + Console.XamGetCurrentTitleId().ToString();
			siticoneLabel23.Text = "Game ID: " + Console.XamGetCurrentTitleId().ToString("X");
			siticoneLabel24.Text = "Gamertag: " + Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]);
			new SpeechSynthesizer().Speak("Shutter CR Connected!");
			timer4.Start();
			ShutterRPC.SetPresence(new RichPresence
			{
				Details = "Connected",
				State = "Copy Pasted By Read#4363 - Rekt By Heaventh",
				Timestamps = Timestamps.Now,
				Assets = new Assets
				{
					LargeImageKey = "giths",
					LargeImageText = "Copy Pasted By Read#4363",
					SmallImageKey = "dys",
					SmallImageText = "Rekt By Heaventh"
				}
			});
		}

        public int fuck;

		public void dashmessage(string string_9, string string_10, string string_11)
		{
			object[] arguments = new object[]
			{
				255,
				1
			};
			uint num = Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments);
			object[] arguments2 = new object[]
			{
				1024,
				1
			};
			uint num2 = Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments2);
            
            object[] arguments3 = new object[]
			{
				8,
				1
			};
			uint num3 = Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments3);
			object[] arguments4 = new object[]
			{
				12,
				1
			};
			uint num4 = Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments4);
			object[] arguments5 = new object[]
			{
				32,
				1
			};
			uint num5 = Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments5);
			object[] arguments6 = new object[]
			{
				32,
				1
			};
			uint num6 = Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments6);
			Console.SetMemory(num, messagemethod(string_9));
			Console.SetMemory(num2, messagemethod(string_10));
			Console.WriteUInt32(num3, num6);
			Console.SetMemory(num6, messagemethod(string_11));
			uint address = Console.ResolveFunction("xam.xex", 714U);
			object[] arguments7 = new object[]
			{
				0,
				num,
				num2,
				1,
				num3,
				0,
				2,
				num4,
				num5
			};
			Console.CallVoid(address, arguments7);
			object[] arguments8 = new object[]
			{
				num,
				1
			};
			Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments8);
			object[] arguments9 = new object[]
			{
				num2,
				1
			};
			Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments9);
			object[] arguments10 = new object[]
			{
				num3,
				1
			};
			Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments10);
			object[] arguments11 = new object[]
			{
				num4,
				1
			};
			Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments11);
			object[] arguments12 = new object[]
			{
				num5,
				1
			};
			Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments12);
			object[] arguments13 = new object[]
			{
				num6,
				1
			};
			Console.Call<uint>(Console.ResolveFunction("xam.xex", 1161), arguments13);
		}

		private byte[] messagemethod(string string_0)
		{
			byte[] array = new byte[string_0.Length * 2 + 2];
			int num = 1;
			array[0] = 0;
			foreach (char value in string_0)
			{
				array[num] = Convert.ToByte(value);
				num += 2;
			}
			return array;
		}

		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			siticoneLabel16.Text = "GPU Temperature: " + Console.GetTemperature(JRPC.TemperatureType.GPU);
			siticoneLabel17.Text = "CPU Temperature: " + Console.GetTemperature(JRPC.TemperatureType.CPU);
			siticoneLabel18.Text = "MotherBoard Temperature: " + Console.GetTemperature(JRPC.TemperatureType.MotherBoard);
			siticoneLabel19.Text = "RAM Temperature: " + Console.GetTemperature(JRPC.TemperatureType.EDRAM);
		}

		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			Console.XNotify(variable.Text);
		}

		private void siticoneRoundedButton4_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				siticoneRoundedTextBox1.Text
			});
		}

		private void siticoneRoundedButton5_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x8242FB70, new object[]
			{
				0,
				siticoneRoundedTextBox2.Text
			});
		}

		private void siticoneRoundedButton9_Click(object sender, EventArgs e)
		{
			Console.Reboot(null, null, null, XboxRebootFlags.Cold);
		}

		private void siticoneRoundedButton8_Click(object sender, EventArgs e)
		{
			Console.ShutDownConsole();
		}

		private void SetGamertag(string gamertag)
		{
			Console.SetMemory(0x82C55D00, new byte[] { 0x7C,0x83,0x23,0x78,0x3D,0x60,0x82,0xC5,0x38,0x8B,0x5D,0x60,0x3D,0x60,0x82,0x4A,0x39,0x6B,0xDC,0xA0,0x38,0xA0,0x0,0x20,0x7D,0x69,0x3,0xA6,0x4E,0x80,0x4,0x20 });
			Console.SetMemory(0x8293D724, new byte[] { 0x3D, 0x60, 0x82, 0xC5, 0x39, 0x6B, 0x5D, 0x0, 0x7D, 0x69, 0x3, 0xA6, 0x4E, 0x80, 0x4, 0x20 });
			Console.SetMemory(0x8259B6A7, new byte[1]);
			Console.SetMemory(0x822D1110, new byte[] { 0x40 });
			Console.SetMemory(0x82C55D60, Encoding.UTF8.GetBytes(gamertag + "\0"));
		}

		private void siticoneRoundedButton6_Click(object sender, EventArgs e)
		{
			Console.CallVoid("xboxkrnl.exe", 434, new object[]
			{
				0x45
			});
		}

		private void siticoneRoundedButton7_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("^1 - Red\n^2 - Green\n^3 - Light Yellow\n^4 - Blue\n^5 - Cyan\n^6 - Pink\n^7 - Yellow\n^8 - Grey\n^9 - Brown", "Colours", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) != DialogResult.OK)
			{
			}
		}

		private void siticoneRoundedButton10_Click(object sender, EventArgs e)
		{
			foreach (Process process in Process.GetProcessesByName("Discord"))
			{
				process.Kill();
			}
		}

		public string Length { get; private set; }

		public static object i { get; private set; }

		private void siticoneRoundedButton11_Click(object sender, EventArgs e)
		{
			gridControl1.DataSource = null;
			GrabbedClients.Clear();
			for (int i = 0; i < 18; i++)
			{
				string gamertag = Encoding.ASCII.GetString(Console.GetMemory((uint)(-1006386264 + 328 * i), 15U)).TrimEnd(new char[1]);
				string externalIP = new IPAddress(Console.GetMemory((uint)(-1006386148 + 328 * i), 4U)).ToString();
				string internalIP = new IPAddress(Console.GetMemory((uint)(-1006386152 + 328 * i), 4U)).ToString();
				string text = BitConverter.ToString(Console.GetMemory((uint)(-1006386272 + 328 * i), 8U)).Replace("-", "");
				string port = int.Parse(BitConverter.ToString(Console.GetMemory((uint)(-1006386145 + 328 * i), 2U)).Replace("-", ""), NumberStyles.HexNumber).ToString();
				string mac = BitConverter.ToString(Console.GetMemory((uint)(-1006386142 + 328 * i), 6U)).Replace("-", "");
				new WebClient();
				if (text != "0000000000000000")
				{
					GrabbedClients.Add(new Client
					{
						Index = i,
						Gamertag = gamertag,
						XUID = text,
						ExternalIP = externalIP,
						InternalIP = internalIP,
						Port = port,
						Mac = mac
					});
				}
			}
			gridControl1.DataSource = GrabbedClients;
		}

		private void siticoneCheckBox3_CheckChanged(object sender, EventArgs e)
		{
			if (siticoneCheckBox3.Checked)
			{
				timer2.Start();
			}
			else
			{
				timer2.Stop();
				SetGamertag(siticoneRoundedTextBox3.Text);
			}
		}

		private void siticoneCheckBox2_CheckChanged(object sender, EventArgs e)
		{
			if (siticoneCheckBox2.Checked)
			{
				timer3.Start();
			}
			else
			{
				timer3.Stop();
				SetGamertag(siticoneRoundedTextBox3.Text);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (strlen(siticoneRoundedTextBox3.Text) < 31)
			{
				SetGamertag(siticoneRoundedTextBox3.Text);
			}
		}

		public static int strlen(string s)
		{
			int num = 0;
			foreach (char c in s)
			{
				num++;
			}
			return num;
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			int num = new Random().Next(1, 9);
			if (strlen("^" + num + siticoneRoundedTextBox3.Text) < 31)
			{
				SetGamertag("^" + num + siticoneRoundedTextBox3.Text);
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (strlen(siticoneRoundedTextBox3.Text + "_") < 31)
			{
				SetGamertag(siticoneRoundedTextBox3.Text + "_");
			}
		}

		private void siticoneRoundedButton13_Click(object sender, EventArgs e)
		{
			SetGamertag(siticoneRoundedTextBox3.Text);
			Console.ReadString(0x81AA285C, 0x8);
			Console.CallVoid(0x822786E0, new object[]
			{
				0,
				"userinfo \"\\name\\" + siticoneRoundedTextBox3.Text + "\\xuid\\"
			});
		}

		private void siticoneRoundedButton14_Click(object sender, EventArgs e)
		{
			int num = strlen(siticoneRoundedTextBox4.Text);
			if (num == 1)
			{
				Length = "\u0001";
			}
			if (num == 2)
			{
				Length = "\u0002";
			}
			if (num == 3)
			{
				Length = "\u0003";
			}
			if (num == 4)
			{
				Length = "\u0004";
			}
			if (num == 5)
			{
				Length = "\u0005";
			}
			if (num == 6)
			{
				Length = "\u0006";
			}
			if (num == 7)
			{
				Length = "\a";
			}
			if (num == 8)
			{
				Length = "\b";
			}
			if (num == 9)
			{
				Length = "\t";
			}
			if (num == 10)
			{
				Length = "\n";
			}
			if (num == 11)
			{
				Length = "\v";
			}
			if (num == 12)
			{
				Length = "\f";
			}
			if (num == 13)
			{
				Length = "\r";
			}
			if (num == 14)
			{
				Length = "\u000e";
			}
			if (num == 15)
			{
				Length = "\u000f";
			}
			if (num == 16)
			{
				Length = "\u0010";
			}
			if (num == 17)
			{
				Length = "\u0011";
			}
			if (num == 18)
			{
				Length = "\u0012";
			}
			if (num == 19)
			{
				Length = "\u0013";
			}
			if (num == 20)
			{
				Length = "\u0014";
			}
			if (num == 21)
			{
				Length = "\u0015";
			}
			if (num == 22)
			{
				Length = "\u0016";
			}
			if (num == 23)
			{
				Length = "\u0017";
			}
			if (num == 24)
			{
				Length = "\u0018";
			}
			if (num == 25)
			{
				Length = "\u0019";
			}
			if (num == 26)
			{
				Length = "\u001a";
			}
			if (num == 27)
			{
				Length = "\u001b";
			}
			if (siticoneCheckBox5.Checked)
			{
				if (num <= 27)
				{
					SetGamertag("^H\u007f?" + Length + siticoneRoundedTextBox4.Text);
				}
			}
			else if (siticoneCheckBox4.Checked)
			{
				if (num <= 27)
				{
					SetGamertag("^H//" + Length + siticoneRoundedTextBox4.Text);
				}
			}
			else if (num <= 27)
			{
				SetGamertag("^H\u007f\u007f" + Length + siticoneRoundedTextBox4.Text);
			}
		}

		private void siticoneRoundedButton15_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton15.Text == "Force Host [OFF]")
			{
				siticoneRoundedButton15.Text = "Force Host [ON]";
				Console.CallVoid(0x824015E0, new object[]
				{
					0,
					"party_connectToOthers 00; partyMigrate_disabled 01; sv_endGameIfISuck 0; badhost_endgameifisuck 0​; set allowAllNAT 1"
				});
			}
			else
			{
				siticoneRoundedButton15.Text = "Force Host [OFF]";
				Console.CallVoid(0x824015E0, new object[]
				{
					0,
					"party_connectToOthers 01; partyMigrate_disabled 00"
				});
			}
		}

		private void siticoneRoundedButton16_Click(object sender, EventArgs e)
		{
			Console.XNotify("Read ~ Game Has Started!");
            Console.SetMemory(0x8227A500, new byte[] { 0x60, 0x00, 0x00, 0x00 });
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"set party_minplayers 1; xpartygo"
			});
		}

		private void siticoneRoundedButton17_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton17.Text == "Spoof Mic [OFF]")
			{
				siticoneRoundedButton17.Text = "Spoof Mic [ON]";
				Console.WriteUInt32(0x8228D108, 0x38600001);
			}
			else
			{
				siticoneRoundedButton17.Text = "Spoof Mic [OFF]";
				Console.WriteUInt32(0x8228D108, 0x38600000);
			}
		}

		private void siticoneRoundedButton18_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"wait 320; fast_restart"
			});
			Console.CallVoid(0x8242FB70, new object[]
			{
				-1,
				0,
				"< \"^5Restarting..... ^6Please Wait.....^1Made By Read\""
			});
		}

		private void siticoneRoundedButton19_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"cmd mr " + Console.ReadInt32(2193708888U) + " -1 endround"
			});
		}

		private void siticoneRoundedButton20_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				string.Format("cmd mr {0} -1 killserverpc", Console.ReadInt32(2193708888U))
			});
		}

		private void siticoneRoundedButton21_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"cmd sl"
			});
		}

		private void siticoneRoundedButton22_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"xstartpartyhost"
			});
		}

		private void siticoneRoundedButton24_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"disconnect"
			});
		}

		private void siticoneRoundedButton23_Click(object sender, EventArgs e)
		{
			IXboxConsole c148gwv4y = Console;
			uint address = 0x82717D48;
			byte[] array = new byte[4];
			array[0] = 96;
			c148gwv4y.SetMemory(address, array);
			Console.XNotify("Anti-Freeze ON, Restart game to undo turn it off");
		}

		private void siticoneRoundedButton27_Click(object sender, EventArgs e)
		{
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]) ?? "");
		}

		private void siticoneRoundedButton26_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton26.Text == "Show Host [OFF]")
			{
				siticoneRoundedButton26.Text = "Show Host [ON]";
				Console.SetMemory(0x82003F70, new byte[18]);
				Console.WriteBool(0x83C5A3BB, true);
			}
			else
			{
				siticoneRoundedButton26.Text = "Show Host [OFF]";
				Console.SetMemory(0x82003F70, new byte[18]);
				Console.WriteBool(0x83C5A3BB, false);
			}
		}

		private void siticoneRoundedButton25_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton25.Text == "Lag Meter [OFF]")
			{
				siticoneRoundedButton25.Text = "Lag Meter [ON]";
				Console.WriteBool(0x821C5567, true);
			}
			else
			{
				siticoneRoundedButton25.Text = "Lag Meter [OFF]";
				Console.WriteBool(0x821C5567, false);
			}
		}

		private void siticoneRoundedButton12_Click(object sender, EventArgs e)
		{
			Tools.Ping(siticoneRoundedTextBox5.Text);
		}

		private void siticoneRoundedButton28_Click(object sender, EventArgs e)
		{
			Console.SetMemory(0xC37586FC, new byte[66]);
			Console.SetMemory(0xC3771F34, new byte[66]);
			Console.SetMemory(0xC376271C, new byte[66]);
			Console.SetMemory(0xC378C73C, new byte[66]);
			Console.SetMemory(0xC377CF24, new byte[66]);
			Console.SetMemory(0xC377772C, new byte[66]);
			Console.SetMemory(0xC3767F14, new byte[66]);
			Console.SetMemory(0xC37436EC, new byte[66]);
			Console.SetMemory(0xC3752F04, new byte[66]);
			Console.SetMemory(0xC375DEF4, new byte[66]);
			Console.SetMemory(0xC376D70C, new byte[66]);
			Console.SetMemory(0xC3786F44, new byte[66]);
			string str = new WebClient().DownloadString("http://icanhazip.com");
			byte[] bytes = Encoding.ASCII.GetBytes("^6Slam Me ^5-> ^1" + str);
			Console.SetMemory(0xC37586FC, bytes);
			Console.SetMemory(0xC3771F34, bytes);
			Console.SetMemory(0xC376271C, bytes);
			Console.SetMemory(0xC378C73C, bytes);
			Console.SetMemory(0xC377CF24, bytes);
			Console.SetMemory(0xC377772C, bytes);
			Console.SetMemory(0xC3767F14, bytes);
			Console.SetMemory(0xC37436EC, bytes);
			Console.SetMemory(0xC3752F04, bytes);
			Console.SetMemory(0xC375DEF4, bytes);
			Console.SetMemory(0xC376D70C, bytes);
			Console.SetMemory(0xC3786F44, bytes);
		}

		private void siticoneRoundedButton29_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x8242FB70, new object[]
			{
				-1,
				0,
				"5 \"" + siticoneRoundedTextBox6.Text + "\""
			});
		}

		private void siticoneRoundedButton31_Click(object sender, EventArgs e)
		{
			Console.SetMemory(3279259388U, new byte[66]);
			Console.SetMemory(3279363892U, new byte[66]);
			Console.SetMemory(3279300380U, new byte[66]);
			Console.SetMemory(3279472444U, new byte[66]);
			Console.SetMemory(3279408932U, new byte[66]);
			Console.SetMemory(3279386412U, new byte[66]);
			Console.SetMemory(3279322900U, new byte[66]);
			Console.SetMemory(3279173356U, new byte[66]);
			Console.SetMemory(3279236868U, new byte[66]);
			Console.SetMemory(3279281908U, new byte[66]);
			Console.SetMemory(3279345420U, new byte[66]);
			Console.SetMemory(3279449924U, new byte[66]);
			byte[] bytes = Encoding.ASCII.GetBytes(siticoneRoundedTextBox8.Text);
			Console.SetMemory(3279259388U, bytes);
			Console.SetMemory(3279363892U, bytes);
			Console.SetMemory(3279300380U, bytes);
			Console.SetMemory(3279472444U, bytes);
			Console.SetMemory(3279408932U, bytes);
			Console.SetMemory(3279386412U, bytes);
			Console.SetMemory(3279322900U, bytes);
			Console.SetMemory(3279173356U, bytes);
			Console.SetMemory(3279236868U, bytes);
			Console.SetMemory(3279281908U, bytes);
			Console.SetMemory(3279345420U, bytes);
			Console.SetMemory(3279449924U, bytes);
		}

		private void siticoneRoundedButton30_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"set lowAmmoWarningNoReloadColor1 0 1 1 1; set lowAmmoWarningNoReloadColor2 0 0 0 1; set lowAmmoWarningColor1 0 1 1 1; set lowAmmoWarningColor2 0 0 0 1; set lowAmmoWarningNoAmmoColor1 0 1 1 1;"
			});
		}

		private void siticoneRoundedButton34_Click(object sender, EventArgs e)
		{
			File.WriteAllBytes("Saved Emblem.bin", Console.GetMemory(Console.ReadUInt32(0x83BA0798), 0x57C));
			if (MessageBox.Show("Emblem Saved To \"Saved Emblem.bin\"", "Message From Devloper", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) != DialogResult.OK)
			{
                //Again?
			}
		}

		private void siticoneRoundedButton32_Click(object sender, EventArgs e)
		{
			byte[] memory = Console.GetMemory(0x84353A45, 0x216);
			File.WriteAllBytes("Saved Classes.bin", memory);
			MessageBox.Show("Classes Saved To \"Saved Classes.bin\"");
		}

		private void siticoneRoundedButton33_Click(object sender, EventArgs e)
		{
			byte[] data = File.ReadAllBytes("Saved Classes.bin");
			Console.SetMemory(2218080837U, data);
			MessageBox.Show("Classes Set From \"Saved Classes.bin\"");
		}

		private void siticoneRoundedButton35_Click(object sender, EventArgs e)
		{
			if (!File.Exists("Saved Emblem.bin"))
			{
				if (MessageBox.Show("Try Saving an Emblem First", "Message From Developer", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
				{
                    //This dude
				}
			}
			else
			{
				byte[] array = File.ReadAllBytes("Saved Emblem.bin");
				array.Reverse<byte>();
				Console.SetMemory(Console.ReadUInt32(0x83BA0798), array);
				if (MessageBox.Show("Emblem Set From \"Saved Emblem.bin\"", "Message From Developer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) != DialogResult.OK)
				{
				}
			}
		}

		private void siticoneRoundedButton36_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"cg_fov 160; cg_fovscale 2"
			});
		}

		private void siticoneRoundedButton37_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Just End or leave the game, then itll be fixed", "Message From Devloper", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) != DialogResult.OK)
			{
                //What is this for?
			}
		}

		private void _360View()
		{
			Console.WriteFloat(0x83C3FE98, 360f);
		}

		private void _360View2()
		{
			Console.WriteFloat(0x83C3FE38, 360f);
		}

		private void _360View3()
		{
			Console.WriteFloat(0x83C40078, 360f);
		}

		private void siticoneRoundedButton38_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"cg_fov " + siticoneRoundedTextBox7.Text
			});
		}
		private void siticoneRoundedButton39_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton39.Text == "HostName/FPS [OFF]")
			{
				siticoneRoundedButton39.Text = "HostName/FPS [ON]";
				Console.WriteString(0x82003F70, siticoneRoundedTextBox9.Text + "\0");
				Console.WriteBool(0x83C5A3BB, true);
			}
			else
			{
				siticoneRoundedButton39.Text = "HostName/FPS [OFF]";
				Console.WriteString(0x82003F70, siticoneRoundedTextBox9.Text + "\0");
				Console.WriteBool(0x83C5A3BB, false);
			}
		}

		private void siticoneRoundedButton40_Click(object sender, EventArgs e)
		{
			_360View();
			_360View2();
			_360View3();
			if (MessageBox.Show("Look all the way up/down for maximum ownage.\nResets after every game!\nPress it again to re-enable", "Message From Dev", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) != DialogResult.OK)
			{
			}
		}

		private void siticoneRoundedButton46_Click(object sender, EventArgs e)
		{
			Console.SetMemory(0x82717D48, new byte[] { 0x60, 0x00, 0x00, 0x00 });
           
			Console.CallVoid(0x822786E0, new object[] { 0, "userinfo \"\\name\\^6Get Kicked Kid\\clanabbrev\\^1\\xuid\\1E0200F003F252F7\\invited\\1\"" });
		}

		private void siticoneRoundedButton45_Click(object sender, EventArgs e)
		{
			int num = -1;
			try
			{
                Console.CallVoid(0x8242FB70, new object[]
				{
					num,
					0,
					"; \"^5Get Fucked\""
				});
                Console.CallVoid(0x8242FB70, new object[]
				{
					num,
					0,
					"< \"^6You Are Now Frozen ^1Nigger\""
				});
				Thread.Sleep(200);
                Console.CallVoid(0x8242FB70, new object[]
				{
					num,
					0,
					"7 30 90"
				});
			}
			catch
			{
			}
		}

		private void siticoneRoundedButton44_Click(object sender, EventArgs e)
		{
			SetGamertag("^1Infection ^4Police");
			Thread.Sleep(500);
			SetGamertag("^4Infection ^1Police");
			Thread.Sleep(500);
			SetGamertag("^1Infection ^4Police");
			Thread.Sleep(500);
			SetGamertag("^4Infection ^1Police");
			Thread.Sleep(500);
			SetGamertag("^1Infection ^4Police");
			Thread.Sleep(500);
			SetGamertag("^4Infection ^1Police");
			Thread.Sleep(500);
			SetGamertag("^1Infection ^4Police");
			Thread.Sleep(500);
			SetGamertag("^4Infection ^1Police");
			Thread.Sleep(500);
			SetGamertag("^1Infection ^4Police");
			Thread.Sleep(500);
			SetGamertag("^4Infection ^1Police");
			Thread.Sleep(500);
			SetGamertag("^1Infection ^4Police");
			Thread.Sleep(500);
			SetGamertag("^4Infection ^1Police");
			Thread.Sleep(500);
			SetGamertag("^1Infection ^4Police");
			Thread.Sleep(500);
			SetGamertag("^4Infection ^1Police");
			Thread.Sleep(500);
			SetGamertag("^1Infection ^4Police");
			Thread.Sleep(500);
			SetGamertag("^Hÿÿÿ\u0001\u0002\n\u0015SHÿÿÿ\0");
			SetGamertag("^Hÿÿÿ\u0001\u0002\n\u0015SIÿÿÿ\0");
			Thread.Sleep(750);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(2175412476U, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton43_Click(object sender, EventArgs e)
		{
			SetGamertag("^Hÿÿÿ\u0001\u0002\n\u0015SHÿÿÿ\0");
			SetGamertag("^Hÿÿÿ\u0001\u0002\n\u0015SIÿÿÿ\0");
			Thread.Sleep(250);
			Console.XNotify("Read ~ Pre-Game Host Frozen!");
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FU, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton52_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton52.Text == "God Mode All [OFF]")
			{
				siticoneRoundedButton52.Text = "God Mode All [ON]";
				for (int i = 0; i < 4; i++)
				{
					Console.SetMemory((uint)(i * 0x57F8 -0x7CAAE5F0 + 0x1B), new byte[]
					{
						5
					});
					Console.CallVoid(0x8242FB70, new object[]
					{
						i,
						0,
						"; \"^7God Mode All - [^2ON^7]\""
					});
				}
			}
			else
			{
				siticoneRoundedButton52.Text = "God Mode All [OFF]";
				for (int j = 0; j < 4; j++)
				{
					Console.SetMemory((uint)(j * 0x57F8 -0x7CAAE5F0 + 0x1B), new byte[]
					{
						4
					});
					Console.CallVoid(0x8242FB70, new object[]
					{
						j,
						0,
						"; \"^7God Mode All - [^1OFF^7]\""
					});
				}
			}
		}

		private void siticoneRoundedButton53_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton53.Text == "Gravity [OFF]")
			{
				siticoneRoundedButton53.Text = "Gravity [ON]";
				Console.CallVoid(0x8242FB70, new object[]
				{
					0,
					0,
					"; \"^Gravity - [^2ON^7]\""
				});
			}
			else
			{
				siticoneRoundedButton53.Text = "Gravity [OFF]";
				Console.CallVoid(0x8242FB70, new object[]
				{
					0,
					0,
					"; \"^7Gravity - [^1OFF^7]\""
				});
			}
		}

		private void siticoneRoundedButton50_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton50.Text == "Anti EndGame [OFF]")
			{
				siticoneRoundedButton50.Text = "Anti EndGame [ON]";
				Console.WriteUInt32(0x840000A0, 0x0);
			}
			else
			{
				siticoneRoundedButton50.Text = "Anti EndGame [OFF]";
				Console.WriteUInt32(0x840000A0, 0x1);
			}
		}

		private void siticoneRoundedButton47_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton47.Text == "Super Speed [OFF]")
			{
				siticoneRoundedButton47.Text = "Super Speed [ON]";
				Console.CallVoid(0x824015E0, new object[]
				{
					0,
					"seta g_speed 999"
				});
				Console.CallVoid(0x8242FB70, new object[]
				{
					-1,
					0,
					"< \"Super Speed: [^2ON^7]\""
				});
			}
			else
			{
				siticoneRoundedButton47.Text = "Super Speed [OFF]";
				Console.CallVoid(0x824015E0, new object[]
				{
					0,
					"seta g_speed 165"
				});
				Console.CallVoid(0x8242FB70, new object[]
				{
					-1,
					0,
					"< \"Super Speed: [^1OFF^7]\""
				});
			}
		}

		private void siticoneRoundedButton48_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"cmd mr " + Console.ReadUInt32(0x82C15758) + " -1 changeteam;"
			});
		}

		private void siticoneRoundedButton51_Click(object sender, EventArgs e)
		{
			uint address = 2188109596U;
			byte[] array = new byte[4];
			array[0] = 96;
            Console.SetMemory(address, array);
			Console.CallVoid(0x8242FB70, new object[]
			{
				-1,
				0,
				"< \"Unlimited Ammo: ^2Enabled\""
			});
		}

		private void siticoneRoundedButton59_Click(object sender, EventArgs e)
		{
			Console.ReadString(0x81AA285C, 0x8);
			Console.CallVoid(0x822786E0, new object[]
			{
				0,
				"userinfo \"\\name\\[{+}][{+}][{+}][{+}][{+}][{+}][[S]\\xuid\\"
			});
			SetGamertag("[{+}][{+}][{+}][{+}][{+}][{+}][[S]");
		}

		private void siticoneRoundedButton57_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton57.Text == "Wall Hack [OFF]")
			{
				siticoneRoundedButton57.Text = "Wall Hack [ON]";
				Console.SetMemory(0x821FC04C, new byte[]
				{
					0x38,
					0xC0,
					0xFF,
					0xFF
				});
			}
			else
			{
				siticoneRoundedButton57.Text = "Wall Hack [OFF]";
				Console.SetMemory(0x821FC04C, new byte[]
				{
					0x7F,
					0xA6,
					0xEB,
					0x78
				});
			}
		}

		private void siticoneRoundedButton58_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton58.Text == "VSAT [OFF]")
			{
				siticoneRoundedButton58.Text = "VSAT [ON]";
				Console.SetMemory(0x821B8FD3, new byte[]
				{
					1
				});
			}
			else
			{
				siticoneRoundedButton58.Text = "VSAT [OFF]";
				Console.SetMemory(0x821B8FD3, new byte[1]);
			}
		}

		private void siticoneRoundedButton55_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton55.Text == "Recoil [OFF]")
			{
				siticoneRoundedButton55.Text = "Recoil [ON]";
				uint address = 0x82259BC8;
				byte[] array = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                Console.SetMemory(address, array);
			}
			else
			{
				siticoneRoundedButton55.Text = "Recoil [OFF]";
				Console.SetMemory(0x82259BC8, new byte[] { 0x48, 0x46, 0x13, 0x41 });
			}
		}

		private void siticoneRoundedButton49_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton49.Text == "Lazer [OFF]")
			{
				siticoneRoundedButton49.Text = "Lazer [ON]";
				Console.SetMemory(0x82255E1C, new byte[] { 0x2B, 0xB, 0x0, 0x1 });
			}
			else
			{
				siticoneRoundedButton49.Text = "Lazer [OFF]";
				uint address = 0x82255E1C;
				byte[] array = new byte[] { 0x2B, 0xB0, 0x00, 0x00};
                Console.SetMemory(address, array);
			}
		}

		private void siticoneRoundedButton54_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton54.Text == "Red Boxes [OFF]")
			{
				siticoneRoundedButton54.Text = "Red Boxes [ON]";
				Console.WriteByte(0x821F5B7F, 0x1);
			}
			else
			{
				siticoneRoundedButton54.Text = "Red Boxes [OFF]";
				Console.WriteByte(0x821F5B7F, 0x0);
			}
		}

		private void siticoneRoundedButton56_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton56.Text == "No Sway [OFF]")
			{
				siticoneRoundedButton56.Text = "No Sway [ON]";
                Console.SetMemory(0x826C6E6C, new byte[] { 0x60, 0x00, 0x00, 0x00 });
			}
			else
			{
				siticoneRoundedButton56.Text = "No Sway [OFF]";
				Console.SetMemory(0x826C6E6C, new byte[] { 0x4B,0xFF,0xE9,0x75 });
			}
		}

		private void siticoneRoundedButton60_Click(object sender, EventArgs e)
		{
			Console.WriteString(0xA679CE32, siticoneRoundedTextBox12.Text);
			Console.WriteString(0xA67AD112, siticoneRoundedTextBox13.Text);
			Console.WriteString(0xA6791F2C, siticoneRoundedTextBox14.Text);
			Console.WriteString(0xA67A0650, siticoneRoundedTextBox15.Text);
			Console.WriteString(0xA67A2CB4, siticoneRoundedTextBox16.Text);
			Console.WriteString(0xA67C7918, siticoneRoundedTextBox18.Text);
			Console.WriteString(0xA67BEF33, siticoneRoundedTextBox17.Text);
			Console.WriteString(0xA67764D2, siticoneRoundedTextBox19.Text);
			Console.WriteString(0xA6775FF0, siticoneRoundedTextBox22.Text);
			Console.WriteString(0xA679B1DE, siticoneRoundedTextBox21.Text);
			Console.WriteString(0xA6792191, siticoneRoundedTextBox20.Text);
			Console.XNotify("Zones Set Successfully!");
		}
        
		private void siticoneRoundedButton61_Click(object sender, EventArgs e)
		{
			Console.WriteString(0xA679CE32, "Public Match");
			Console.WriteString(0xA67AD112, "Custom Games");
			Console.WriteString(0xA6791F2C, "Create a Class");
			Console.WriteString(0xA67A0650, "Barracks");
			Console.WriteString(0xA67A2CB4, "Theater");
			Console.WriteString(0xA67C7918, "League");
			Console.WriteString(0xA67BEF33, "Store");
			Console.WriteString(0xA67764D2, "Xbox Live");
			Console.WriteString(0xA6775FF0, "System Link");
			Console.WriteString(0xA679B1DE, "Main Menu");
			Console.WriteString(0xA6792191, "SCORESTREAKS");
			Console.XNotify("Reseted Zones Set Successfully!");
		}

		private void siticoneRoundedButton62_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 0 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 1 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 2 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 3 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 4 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 5 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 6 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 7 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 8 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 9 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setPublicMatchClassSetNameFromLocString 0 \"^5~^6Read#4363^5~\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 0 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 1 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 2 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 3 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 4 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 0 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 1 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 2 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 3 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 4 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setCustomMatchClassSetNameFromLocString 0 \"^5~^6Read#4363^5~\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updatestats"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updategamerprofile"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updatestats"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updategamerprofile"
			});
			Console.XNotify("Read ~ Class Names Set!");
		}

		private void siticoneRoundedButton63_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 0 " + siticoneRoundedTextBox33.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 1 " + siticoneRoundedTextBox32.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 2 " + siticoneRoundedTextBox31.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 3 " + siticoneRoundedTextBox30.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 4 " + siticoneRoundedTextBox29.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 5 " + siticoneRoundedTextBox27.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 6 " + siticoneRoundedTextBox28.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 7 " + siticoneRoundedTextBox26.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 8 " + siticoneRoundedTextBox23.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 9 " + siticoneRoundedTextBox24.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setPublicMatchClassSetNameFromLocString 0 " + siticoneRoundedTextBox25.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 0 " + siticoneRoundedTextBox33.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 1 " + siticoneRoundedTextBox32.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 2 " + siticoneRoundedTextBox31.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 3 " + siticoneRoundedTextBox30.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 4 " + siticoneRoundedTextBox29.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setCustomMatchClassSetNameFromLocString 0 " + siticoneRoundedTextBox25.Text + "\0"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updatestats"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updategamerprofile"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updatestats"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updategamerprofile"
			});
		}

		private void siticoneRoundedButton73_Click(object sender, EventArgs e)
		{
			Console.XNotify("Unlock All [50]");
			Console.SetMemory(0x843491BC, BitConverter.GetBytes(Convert.ToInt32("4354399")));
			Console.SetMemory(0x843491A4, BitConverter.GetBytes(Convert.ToInt32(0xB)));
			Console.SetMemory(0x8435429F, AccountBytes);
			byte[] data = new byte[]
			{
				0xFF
			};
			Console.SetMemory(0x843543AC, data);
			byte[] data2 = new byte[]
			{
				0xFF
			};
			Console.SetMemory(0x843543A9, data2);
			Console.SetMemory(0x8434AF80, UnlockBytes);
			byte[] data3 = new byte[]
			{
				192,
				63
			};
			Console.SetMemory(0x84352AC8, data3);
			byte[] data4 = new byte[]
			{
				0xC0,
				0x3F
			};
			Console.SetMemory(0x84352AC8, data4);
			Console.XNotify("Unlock All [100] Completed!");
		}

		private void siticoneRoundedButton72_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"resetStats"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"PrestigeStatsResetAll"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"uploadstats; updategamerprofile"
			});
		}

		private void siticoneRoundedButton71_Click(object sender, EventArgs e)
		{
			byte[] data = new byte[]
			{
				0x48,
				0,
				0,
				0xC8
			};
			Console.SetMemory(0x825C5394, data);
		}

		private void siticoneRoundedButton70_Click(object sender, EventArgs e)
		{
			Console.SetMemory(0x84352AC8, new byte[]
			{
				0xC0,
				0x3F
			});
			MessageBox.Show("Unlock Token Sent", "Message From Developer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void siticoneRoundedButton69_Click(object sender, EventArgs e)
		{
			Console.XNotify("Read ~ Setting Unlimted Classes");
			byte[] data = new byte[]
			{
				0x3B,
				0x55,
				0x55,
				0x55
			};
			Console.SetMemory(0x826A5FBC, data);
			Console.XNotify("Read ~ Set Unlimted Classes");
		}

		private void siticoneRoundedButton68_Click(object sender, EventArgs e)
		{
			Console.SetMemory(0x843546B2, new byte[]{ 0x44, 0x80, 0x8, 0x10, 0x1, 0x22, 0x40, 0x4});
		}

		private void siticoneRoundedButton67_Click(object sender, EventArgs e)
		{
			Console.SetMemory(0x84353A50, new byte[] { 0x51, 0xA1 });
			Console.SetMemory(0x84353A5D, new byte[] { 0x00, 0xA8 });
			Console.SetMemory(0x84353A83, new byte[] { 0x00, 0x0, 0x15 });
			Console.SetMemory(0x84353A92, new byte[] { 0x00, 0xA8 });
			Console.SetMemory(0x84353AB9, new byte[] { 0x50, 0x1 });
			Console.SetMemory(0x84353AC6, new byte[] { 0x00, 0xA8 });
			Console.SetMemory(0x84353AED, new byte[] { 0x00, 0x15 });
			Console.SetMemory(0x84353AFB, new byte[] { 0x80, 0xA });
			Console.SetMemory(0x84353B22, new byte[] { 0x50, 0x1 });
            Console.SetMemory(0x84353B30, new byte[] { 0xA8, 0x00 });
			Console.SetMemory(0x84353B56, new byte[] { 0x00, 0x15 });
			Console.SetMemory(0x84353B64, new byte[] { 0x80, 0xA });
			Console.SetMemory(0x84353B8B, new byte[] { 0x50, 0x1 });
			Console.SetMemory(0x84353B99, new byte[] { 0x80, 0xA });
			Console.SetMemory(0x84353BBF, new byte[] { 0x0, 0x15 });
			Console.SetMemory(0x84353BCD, new byte[] { 0x80, 0xA });
			Console.SetMemory(0x84353BF4, new byte[] { 0x50, 0x1 });
            Console.SetMemory(0x84353C02, new byte[] { 0xA8, 0x00 });
			Console.SetMemory(0x84353C28, new byte[] { 0x0, 0x15 });
			Console.SetMemory(0x84353C36, new byte[] { 0x80, 0xA });
			Console.XNotify("Read ~ Ghost Camo Set! [Make Sure You Have Rogue Camo]");
		}

		private void siticoneRoundedButton65_Click(object sender, EventArgs e)
		{
			Console.SetMemory(0x843491A4, AccountBytes);
		}

		public string GeoLocationCityState(string IP)
		{
			string result;
			try
			{
				WebClient webClient = new WebClient();
				string[] array = webClient.DownloadString("http://ip-api.com/csv/" + IP + "?fields=regionName,city").Replace(",", Environment.NewLine).Replace("\"", "").Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.None);
				string text = array[1] + ", " + array[0];
				result = text;
			}
			catch
			{
				result = "Error";
			}
			return result;
		}

		public string GeoLocationCity(string IP)
		{
			string result;
			try
			{
				WebClient webClient = new WebClient();
				string[] array = webClient.DownloadString("http://ip-api.com/csv/" + IP + "?fields=city").Replace(",", Environment.NewLine).Replace("\"", "").Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.None);
				string text = array[0];
				result = text;
			}
			catch
			{
				result = "Error";
			}
			return result;
		}

		public string ISP(string IP)
		{
			string result;
			try
			{
				WebClient webClient = new WebClient();
				string[] array = webClient.DownloadString("http://ip-api.com/csv/" + IP + "?fields=isp").Replace(",", Environment.NewLine).Replace("\"", "").Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.None);
				string text = array[0];
				result = text;
			}
			catch
			{
				result = "Error";
			}
			return result;
		}

		public string GeoLocationState(string IP)
		{
			string result;
			try
			{
				WebClient webClient = new WebClient();
				string[] array = webClient.DownloadString("http://ip-api.com/csv/" + IP + "?fields=regionName").Replace(",", Environment.NewLine).Replace("\"", "").Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.None);
				string text = array[0];
				result = text;
			}
			catch
			{
				result = "Error";
			}
			return result;
		}

		private void siticoneRoundedButton64_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 0 \"^H¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 1 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 2 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 3 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 4 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 5 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 6 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 7 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 8 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 9 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setPublicMatchClassSetNameFromLocString 0 \"^H¤¤¤¤¤¤ ^B¤¤¤¤^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 0 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 1 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 2 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 3 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 4 \"^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setCustomMatchClassSetNameFromLocString 0 \"^H¤¤¤¤¤¤ ^B¤¤¤¤^H¤¤¤¤¤¤ ^B¤¤¤¤\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updatestats"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updategamerprofile"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updatestats"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updategamerprofile"
			});
			Console.XNotify("Read ~ All Classes Are Now Frozen");
		}

		private void siticoneRoundedButton74_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 0 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 1 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 2 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 3 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 4 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 5 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 6 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 7 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 8 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 9 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setPublicMatchClassSetNameFromLocString 0 \"^6Read\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 0 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 1 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 2 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 3 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 4 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 0 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 1 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 2 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 3 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setStatFromLocString leaguecacloadouts customclassname 4 \"Read^5#4363\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"setCustomMatchClassSetNameFromLocString 0 \"^6Read\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updatestats"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updategamerprofile"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updatestats"
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"updategamerprofile"
			});
			Console.XNotify("Read ~ Classes Unfrozen!");
		}

		private void siticoneRoundedButton83_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\u0017menu_lobby_icon_twitter");
		}

		private void email_Click(object sender, EventArgs e)
		{

		}

		private void siticoneLabel7_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(siticoneLabel7.Text);
			MessageBox.Show("You have Copied your CPUKey To Clipboard", "Copied To Clipbord");
		}

		private void siticoneRoundedButton89_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\vhint_mantlethis fgt tho");
		}

		private async Task SpotifyGamertag(object sender, EventArgs e)
		{
			Process proc = Process.GetProcessesByName("Spotify")[0];
			if (proc != null)
			{
			}
			if (!string.Equals(proc.MainWindowTitle, "Spotify", StringComparison.InvariantCultureIgnoreCase))
			{
			}
			SetGamertag("^6L");
			await Task.Delay(250);
			SetGamertag("^5Li");
			await Task.Delay(250);
			SetGamertag("^6Lis");
			await Task.Delay(250);
			SetGamertag("^5List");
			await Task.Delay(250);
			SetGamertag("^6Liste");
			await Task.Delay(250);
			SetGamertag("^5Listen");
			await Task.Delay(250);
			SetGamertag("^6Listeni");
			await Task.Delay(250);
			SetGamertag("^5Listenin");
			await Task.Delay(250);
			SetGamertag("^6Listening");
			await Task.Delay(250);
			SetGamertag("^5Listening T");
			await Task.Delay(250);
			SetGamertag("^6Listening To");
			await Task.Delay(250);
			SetGamertag("^5Listening To.");
			await Task.Delay(250);
			SetGamertag("^6Listening To..");
			await Task.Delay(250);
			SetGamertag("^5Listening To...");
			await Task.Delay(250);
			SetGamertag("^6Listening To.");
			await Task.Delay(250);
			SetGamertag("^5Listening To..");
			await Task.Delay(250);
			SetGamertag("^6Listening To...");
			await Task.Delay(250);
			SetGamertag("^5" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^6" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^5" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^6" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^5" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^6" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^5" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^6" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("on ^2Spotify");
			await Task.Delay(2500);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FCU, 0x1E)).Trim().Trim(new char[1]));
		}

		private async void siticoneRoundedButton75_Click(object sender, EventArgs e)
		{
			SetGamertag("8m===D");
			await Task.Delay(500);
			SetGamertag("8=m==D");
			await Task.Delay(500);
			SetGamertag("8==m=D");
			await Task.Delay(500);
			SetGamertag("8===mD");
			await Task.Delay(500);
			SetGamertag("8==m=D");
			await Task.Delay(500);
			SetGamertag("8=m==D");
			await Task.Delay(500);
			SetGamertag("8m===D");
			await Task.Delay(500);
			SetGamertag("8=m==D");
			await Task.Delay(500);
			SetGamertag("8==m=D ~");
			await Task.Delay(500);
			SetGamertag("8===mD ~ ~");
			await Task.Delay(500);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FCU, 0x1E)).Trim().Trim(new char[1]));
		}

		private async void siticoneRoundedButton77_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\vhint_mantle^5is a virgin");
		}

		private void siticoneRoundedButton78_Click(object sender, EventArgs e)
		{
			SetGamertag("Hey catch! ^H\u007f\u007f\vhud_icon_c4");
		}

		private void siticoneRoundedButton79_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\fmenu_mp_esrb< cheat codes");
		}

		private void siticoneRoundedButton80_Click(object sender, EventArgs e)
		{
			SetGamertag("Marry Me^H\u007f\u007f\u0010dualoptic_down_9");
		}

		private void siticoneRoundedButton81_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\breflex_8Hi im gay");
		}

		private void siticoneRoundedButton84_Click(object sender, EventArgs e)
		{
			SetGamertag("^H//\u000ecac_restrictedFAGS AHEAD!");
		}

		private void siticoneRoundedButton85_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\bthumbsup");
		}

		private void siticoneRoundedButton86_Click(object sender, EventArgs e)
		{
			SetGamertag("^B^");
		}

		private void siticoneRoundedButton87_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\vperk_hacker");
		}

		private void siticoneRoundedButton88_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f?\u0014headiconyouinkillcamSUCK!");
		}

		private void siticoneRoundedButton90_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\u0017playlist_search_destroy");
		}

		private void siticoneRoundedButton91_Click(object sender, EventArgs e)
		{
			SetGamertag("^H//\u000ehud_arrow_downHe's Gay!");
		}

		private void siticoneRoundedButton92_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\fyoutube_logo");
		}

		private void siticoneRoundedButton94_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\u000ehud_anim_cobra");
		}

		private void siticoneRoundedButton99_Click(object sender, EventArgs e)
		{
			SetGamertag("^H//\rxenonbutton_a");
		}

		private void siticoneRoundedButton97_Click(object sender, EventArgs e)
		{
			SetGamertag("^H//\rxenonbutton_y");
		}

		private void siticoneRoundedButton98_Click(object sender, EventArgs e)
		{
			SetGamertag("^H//\rxenonbutton_x");
		}

		private void siticoneRoundedButton96_Click(object sender, EventArgs e)
		{
			SetGamertag("^H//\rxenonbutton_b");
		}

		private void siticoneRoundedButton93_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\u0013cac_mods_dual_wield");
		}

		private void siticoneRoundedButton76_Click(object sender, EventArgs e)
		{
			SetGamertag("Official^H\u007f\u007f\u0004logoAdmin");
		}

		private void siticoneRoundedButton95_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\bui_smoke");
		}

		private void timer4_Tick(object sender, EventArgs e)
		{
			siticoneLabel16.Text = "GPU Temperature: " + Console.GetTemperature(JRPC.TemperatureType.GPU);
			siticoneLabel17.Text = "CPU Temperature: " + Console.GetTemperature(JRPC.TemperatureType.CPU);
			siticoneLabel18.Text = "MotherBoard Temperature: " + Console.GetTemperature(JRPC.TemperatureType.MotherBoard);
			siticoneLabel19.Text = "RAM Temperature: " + Console.GetTemperature(JRPC.TemperatureType.EDRAM);
			siticoneLabel23.Text = "Game ID: " + Console.XamGetCurrentTitleId().ToString("X");
		}

		private void siticoneRoundedButton102_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x8242FB70, new object[]
			{
				0,
				0,
				"; \"" + siticoneRoundedTextBox37.Text + "\""
			});
		}

		private void siticoneRoundedButton82_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x8242FB70, new object[]
			{
				0,
				0,
				"< \"" + siticoneRoundedTextBox34.Text + "\""
			});
		}

		private void siticoneRoundedButton103_Click(object sender, EventArgs e)
		{
			if (siticoneRoundedButton103.Text == "Spam Killfeed + Center Message [OFF]")
			{
				siticoneRoundedButton103.Text = "Spam Killfeed + Center Message [ON]";
				timer5.Start();
			}
			else
			{
				siticoneRoundedButton103.Text = "Spam Killfeed + Center Message [OFF]";
				timer5.Stop();
			}
		}

		private void timer5_Tick(object sender, EventArgs e)
		{
			int num = new Random().Next(0, 7);
			Console.CallVoid(0x8242FB70, new object[]
			{
				-1,
				0,
				string.Concat(new object[]
				{
					"< \"^",
					num,
					siticoneRoundedTextBox38.Text,
					"\""
				})
			});
			Console.CallVoid(0x8242FB70, new object[]
			{
				-1,
				0,
				string.Concat(new object[]
				{
					"; \"^",
					num,
					siticoneRoundedTextBox39.Text,
					"\""
				})
			});
		}

		private async void siticoneRoundedButton100_Click(object sender, EventArgs e)
		{
			SetGamertag("^6R^7ead");
			await Task.Delay(500);
			SetGamertag("^7R^6e^7ad");
			await Task.Delay(500);
			SetGamertag("^7R^7e^6a^7d");
			await Task.Delay(500);
			SetGamertag("^7R^7e^7a^6d");
			await Task.Delay(500);
			SetGamertag("^7R^7e^6a^7d");
			await Task.Delay(500);
			SetGamertag("^7R^6e^7a^7d");
			await Task.Delay(500);
			SetGamertag("^6R^7e^7a^7d");
			await Task.Delay(500);
			SetGamertag("^6Read");
			await Task.Delay(630);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton101_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(siticoneRoundedTextBox35.Text));
			Console.SetMemory(0x843491A4, bytes);
			siticoneRoundedTextBox35.Text = BitConverter.ToInt32(Console.GetMemory(0x843491A4, 0x4), 0).ToString();
		}

		private void siticoneRoundedButton104_Click(object sender, EventArgs e)
		{
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]) + "^0[]");
		}

		private void siticoneRoundedButton106_Click(object sender, EventArgs e)
		{
			if (File.Exists("screenshot.dds"))
			{
				File.Delete("screenshot.dds");
			}
			Console.ScreenShot("screenshot.dds");
			if (File.Exists("screenshot.dds"))
			{
				pictureEdit1.Image = DDS.LoadImage("screenshot.dds", true);
				File.Delete("screenshot.dds");
			}
			GC.Collect();
		}

		private void siticoneRoundedButton108_Click(object sender, EventArgs e)
		{
			if (pictureEdit1.Image == null)
			{
				MessageBox.Show("Try taking a screenshot first.");
			}
			else
			{
				Clipboard.SetImage(pictureEdit1.Image);
			}
			if (MessageBox.Show("Screenshot\nCopied To Clipboard.", "Message From Devloper", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) != DialogResult.OK)
			{
			}
		}

		private void SendCMD(string Command) //I gave this to read it would've cleaned up his code ¯\_(ツ)_/¯
        {
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
                Command
            });
		}

		private void siticoneRoundedButton107_Click(object sender, EventArgs e)
		{
			if (pictureEdit1.Image == null)
			{
				MessageBox.Show("Try taking a screenshot first.");
			}
			else
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "*Images|*.png";
				ImageFormat png = ImageFormat.Png;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureEdit1.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
				}
			}
		}

		private async void siticoneRoundedButton105_Click(object sender, EventArgs e)
		{
			SetGamertag("^1Freezing Hosts Console in...");
			await Task.Delay(2000);
			SetGamertag("^H//\u0010hud_mp_num_big_3");
			await Task.Delay(1000);
			SetGamertag("^H//\u0010hud_mp_num_big_2");
			await Task.Delay(1000);
			SetGamertag("^H//\u0010hud_mp_num_big_1");
			await Task.Delay(1000);
			SetGamertag("^H//\u0010hud_mp_num_big_0");
			await Task.Delay(1000);
			SetGamertag("^1Bye^H\u007f/\u000ecompass_staticRetard!");
			await Task.Delay(450);
			SetGamertag("^Hÿÿÿ\u0001\u0002\n\u0015SHÿÿÿ\0");
			SetGamertag("^Hÿÿÿ\u0001\u0002\n\u0015SIÿÿÿ\0");
			await Task.Delay(250);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

        private async void siticoneRoundedButton110_Click(object sender, EventArgs e) //Read still can't use async LOOL
        {
            SetGamertag("[{+forward}] FAGS [{+back}]");
        }

		private void siticoneRoundedButton113_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\u0019menu_codtv_icon_mychannel");
		}

		private void siticoneRoundedButton112_Click(object sender, EventArgs e)
		{
			SetGamertag("^H\u007f\u007f\u0013compass_map_flicker");
		}

		private void siticoneRoundedButton114_Click(object sender, EventArgs e)
		{
			SetGamertag("Listen here ^1" + siticoneRoundedTextBox36.Text);
			Thread.Sleep(2000);
			SetGamertag("gotta tape up my speakers cuz..");
			Thread.Sleep(2000);
			SetGamertag("ur queer ass smells like cheese");
			Thread.Sleep(2000);
			SetGamertag("go drown in a bowl of soup");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton124_Click(object sender, EventArgs e)
		{
			SetGamertag("Aye ^1" + siticoneRoundedTextBox36.Text + "!");
			Thread.Sleep(2000);
			SetGamertag("ima stick my pp in ur fat bitch");
			Thread.Sleep(2000);
			SetGamertag("then gonna pee in her butthole");
			Thread.Sleep(2000);
			SetGamertag("hoe got dinner plate nipples");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton122_Click(object sender, EventArgs e)
		{
			SetGamertag("Dis nigga ^1" + siticoneRoundedTextBox36.Text);
			Thread.Sleep(2000);
			SetGamertag("is the type of dumbass to..");
			Thread.Sleep(2000);
			SetGamertag("lick his fingers before");
			Thread.Sleep(2000);
			SetGamertag("flippin the page on an ipad");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton120_Click(object sender, EventArgs e)
		{
			SetGamertag("Hey ^1" + siticoneRoundedTextBox36.Text);
			Thread.Sleep(2000);
			SetGamertag("go slit ur wrists and");
			Thread.Sleep(2000);
			SetGamertag("do a handstand in lemonade");
			Thread.Sleep(2000);
			SetGamertag("u smelly crosseyed dickwad");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton118_Click(object sender, EventArgs e)
		{
			SetGamertag("Stfu ^1" + siticoneRoundedTextBox36.Text);
			Thread.Sleep(2000);
			SetGamertag("go papercut ur entire body");
			Thread.Sleep(2000);
			SetGamertag("and roll around in piss");
			Thread.Sleep(2000);
			SetGamertag("you flappy titt'd slob");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton116_Click(object sender, EventArgs e)
		{
			SetGamertag("kill urself ^1" + siticoneRoundedTextBox36.Text);
			Thread.Sleep(2000);
			SetGamertag("go slit your eyes");
			Thread.Sleep(2000);
			SetGamertag("and stare at the sun");
			Thread.Sleep(2000);
			SetGamertag("you clearly have foreskin");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton111_Click(object sender, EventArgs e)
		{
			SetGamertag("Yoohoo ^1" + siticoneRoundedTextBox36.Text + "!");
			Thread.Sleep(2000);
			SetGamertag("U FCKN INDIAN RESTROOM SCENTED..");
			Thread.Sleep(2000);
			SetGamertag("ABORTION TUBESOCK SIMULATOR");
			Thread.Sleep(2000);
			SetGamertag("HEAR MY ICE FISHING FAGGOT");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton123_Click(object sender, EventArgs e)
		{
			SetGamertag(" ^1" + siticoneRoundedTextBox36.Text + " is..");
			Thread.Sleep(2000);
			SetGamertag("that one nigga that..");
			Thread.Sleep(2000);
			SetGamertag("sat at the back of class with..");
			Thread.Sleep(2000);
			SetGamertag("a pencil up his nose");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton121_Click(object sender, EventArgs e)
		{
			SetGamertag("Listen here ^1" + siticoneRoundedTextBox36.Text);
			Thread.Sleep(2000);
			SetGamertag("ur big ass nose looks like..");
			Thread.Sleep(2000);
			SetGamertag("the iceburg that..");
			Thread.Sleep(2000);
			SetGamertag("sunk the titanic");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton119_Click(object sender, EventArgs e)
		{
			SetGamertag("Hey ^1" + siticoneRoundedTextBox36.Text);
			Thread.Sleep(2000);
			SetGamertag("Stfu u smelly fucking..");
			Thread.Sleep(2000);
			SetGamertag("empty jar of peanutbutter..");
			Thread.Sleep(2000);
			SetGamertag("rusty guitar string lookin ass..");
			Thread.Sleep(2000);
			SetGamertag("bag of doughnuts");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton117_Click(object sender, EventArgs e)
		{
			Console.XNotify("Troll Activated Against: \"" + siticoneRoundedTextBox41.Text + "\"");
			SetGamertag("^6Hey, ^5 \"" + siticoneRoundedTextBox41.Text + "\"");
			Thread.Sleep(2200);
			SetGamertag("^1Liking that Wifi??");
			Thread.Sleep(2200);
			SetGamertag("^5Keep being a ^6Retard...");
			Thread.Sleep(2200);
			SetGamertag("^3And that shit's gonna go");
			Thread.Sleep(1750);
			SetGamertag("^H\u007f\u007f\vping_bar_04");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\vping_bar_03");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\vping_bar_02");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\vping_bar_01");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\u0011net_new_animation");
			Thread.Sleep(2750);
			SetGamertag("^H\u007f\u007f\u000ecompass_static");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\u000ecompass_static #OFFLINE");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\u000ecompass_static");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\u000ecompass_static #OFFLINE");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\u000ecompass_static");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\u000ecompass_static #OFFLINE");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\u000ecompass_static");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\u000ecompass_static #OFFLINE");
			Thread.Sleep(750);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton115_Click(object sender, EventArgs e)
		{
			Console.XNotify("Troll Activated Against: \"" + siticoneRoundedTextBox40.Text + "\"");
			SetGamertag("^6Hey, ^5 \"" + siticoneRoundedTextBox40.Text + "\"");
			Thread.Sleep(2200);
			SetGamertag("^1Shut the fuck up");
			Thread.Sleep(2200);
			SetGamertag("^5You Utter Retard...");
			Thread.Sleep(2200);
			SetGamertag("^3Or that wifi will go");
			Thread.Sleep(1750);
			SetGamertag("^H\u007f\u007f\vping_bar_04");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\vping_bar_03");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\vping_bar_02");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\vping_bar_01");
			Thread.Sleep(750);
			SetGamertag("^H\u007f\u007f\u0011net_new_animation");
			Thread.Sleep(2750);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton41_Click(object sender, EventArgs e)
		{
			SetGamertag("Hey ^5" + siticoneRoundedTextBox10.Text);
			Thread.Sleep(2000);
			SetGamertag("Ya wanna fokin go offline m8 ??");
			Thread.Sleep(2000);
			SetGamertag("Quit being a retard or");
			Thread.Sleep(2000);
			SetGamertag("Ur router bouta be like..");
			Thread.Sleep(2000);
			SetGamertag("^H\u007f\u007f\vping_bar_04");
			Thread.Sleep(300);
			SetGamertag("^H\u007f\u007f\vping_bar_03");
			Thread.Sleep(300);
			SetGamertag("^H\u007f\u007f\vping_bar_02");
			Thread.Sleep(300);
			SetGamertag("^H\u007f\u007f\vping_bar_01");
			Thread.Sleep(300);
			SetGamertag("^H\u007f\u007f\u0011net_new_animation");
			Thread.Sleep(3000);
			SetGamertag("^H\u007f\u007f\u000ecompass_static");
			Thread.Sleep(500);
			SetGamertag("^H\u007f\u007f\u000ecompass_static #OFFLINE");
			Thread.Sleep(500);
			SetGamertag("^H\u007f\u007f\u000ecompass_static");
			Thread.Sleep(500);
			SetGamertag("^H\u007f\u007f\u000ecompass_static #OFFLINE");
			Thread.Sleep(500);
			SetGamertag("^H\u007f\u007f\u000ecompass_static");
			Thread.Sleep(500);
			SetGamertag("^H\u007f\u007f\u000ecompass_static #OFFLINE");
			Thread.Sleep(500);
			SetGamertag("^H\u007f\u007f\u000ecompass_static");
			Thread.Sleep(500);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton125_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				";statwriteddl clantagstats clanname " + siticoneRoundedTextBox11.Text + ";"
			});
		}

		private void siticoneRoundedButton126_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x822786E0, new object[]
			{
				0,
				"callvote map \"mp_hijacked\rstatsetbyname RANKXP 1\rstatsetbyname PLEVEL 0\rstatsetbyname RANK 1\r\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"disconnect"
			});
		}

		private void siticoneRoundedButton129_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x822786E0, new object[]
			{
				0,
				"callvote map \"mp_hijacked\runbindall\runbindallaxis\r\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"disconnect"
			});
		}

		private void siticoneRoundedButton128_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x822786E0, new object[]
			{
				0,
				"callvote map \"mp_hijacked\rquit\r\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"disconnect"
			});
		}

		private void siticoneRoundedButton127_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x822786E0, new object[]
			{
				0,
				"callvote map \"mp_hijacked\rstartSingleplayer\r\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"disconnect"
			});
		}

		private void siticoneRoundedButton132_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x822786E0, new object[]
			{
				0,
				"callvote map \"mp_hijacked\rstartZombies\r\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"disconnect"
			});
		}

		private void siticoneRoundedButton133_Click(object sender, EventArgs e)
		{
			Console.CallVoid(0x822786E0, new object[]
			{
				0,
				"callvote map \"mp_hijackedÜg_fov 90\r\""
			});
			Console.CallVoid(0x824015E0, new object[]
			{
				0,
				"disconnect"
			});
		}

		private void siticoneRoundedButton130_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Go into a private match with the victim you want as host, Just have it be you and him, Choose any option once you are in the game, It will kick you from the game and pass the vote to them!", "Call Vote Help!");
		}

        private void ChangeMap(string mapname) //Had to
        {
            byte[] memory = Console.GetMemory(0x82497ED8, 0x4);
            byte[] array = new byte[] { 0x39, 0x60, 0x00, 0x00 };

            if (!memory.SequenceEqual(array))
            {
                Console.SetMemory(0x82497ED8, array);
            }

            Console.CallVoid(0x824015E0, new object[] { 0, mapname });
        }

		private void siticoneRoundedButton131_Click(object sender, EventArgs e)
		{
			
		}

		private void siticoneRoundedButton154_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_mirage");
		}

		private void siticoneRoundedButton143_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_nuketown_2020");
		}

		private void siticoneRoundedButton142_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_socotra");
		}

		private void siticoneRoundedButton141_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_hijacked");
		}

		private void siticoneRoundedButton140_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_dockside");
		}

		private void siticoneRoundedButton139_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_carrier");
		}

		private void siticoneRoundedButton138_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_express");
		}

		private void siticoneRoundedButton137_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_meltdown");
		}

		private void siticoneRoundedButton136_Click(object sender, EventArgs e)
		{

            ChangeMap("map mp_nightclub");
		}

		private void siticoneRoundedButton147_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_village");
		}

		private void siticoneRoundedButton146_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_turbine");
		}

		private void siticoneRoundedButton144_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_raid");
		}

		private void siticoneRoundedButton145_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_slums");
		}

		private void siticoneRoundedButton148_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_overflow");
		}

		private void siticoneRoundedButton149_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_aftermath");
		}

		private void siticoneRoundedButton42_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_Studio");
		}

		private void siticoneRoundedButton135_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_downhill");
		}

		private void siticoneRoundedButton153_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_hydro");
		}

		private void siticoneRoundedButton152_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_skate");
		}

		private void siticoneRoundedButton150_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_concert");
		}

		private void siticoneRoundedButton155_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_magma");
		}

		private void siticoneRoundedButton156_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_vertigo");
		}

		private void siticoneRoundedButton157_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_Uplink");
		}

		private void siticoneRoundedButton158_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_Detour");
		}

		private void siticoneRoundedButton159_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_Cove");
		}

		private void siticoneRoundedButton160_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_paintball");
		}

		private void siticoneRoundedButton151_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_dig");
		}

		private void siticoneRoundedButton163_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_pod");
		}

		private void siticoneRoundedButton161_Click(object sender, EventArgs e)
		{
            ChangeMap("map mp_takeoff");
		}

		private void tabPage8_Click(object sender, EventArgs e)
		{

		}

		private void siticoneRoundedButton165_Click(object sender, EventArgs e)
		{
			Array.Clear(SMCMessage, 0, SMCMessage.Length);
			SMCMessage[0] = 148;
			if (siticoneTrackBar1.Value < 45)
			{
				SMCMessage[1] = 127;
			}
			else
			{
				byte b = Convert.ToByte(siticoneTrackBar1.Value);
				SMCMessage[1] = b;
			}
			object[] array = new object[2];
			array[0] = SMCMessage;
			Console.Call<uint>(Console.ResolveFunction("xboxkrnl.exe", 41), array);
			SMCMessage[0] = 137;
			object[] array2 = new object[2];
			array2[0] = SMCMessage;
			Console.Call<uint>(Console.ResolveFunction("xboxkrnl.exe", 41), array2);
		}

		public string smethod_19(string string_14)
		{
			byte[] data = new byte[8];
			Console.SetMemory(0x81AA18F0, data);
			object[] arguments = new object[]
			{
				0x9000006F93463,
				0x0,
				string_14,
				0x18,
				0x81AA18F0,
				0x0
			};
			Console.CallVoid(0x81829158, arguments);
			Thread.Sleep(1000);
			byte[] memory = Console.GetMemory(0x81AA18F0, 0x8);
			string result = BitConverter.ToString(memory).Replace("-", "");
			Console.SetMemory(0x81AA18F0, data);
			return result;
		}

		private void siticoneRoundedButton168_Click(object sender, EventArgs e)
		{
			Console.CallVoid(Console.ResolveFunction("xam.xex", 2812U), new object[]
			{
				0
			});
		}

		private void siticoneRoundedButton109_Click(object sender, EventArgs e)
		{
			dashmessage(siticoneRoundedTextBox42.Text, textBox1.Text, siticoneRoundedTextBox44.Text);
		}

		public string GetXUID(string gt)
		{
			byte[] data = new byte[8];
			Console.SetMemory(0x81AA1922, data);
			Console.CallVoid(0x81829158, new object[]
			{
				0x9000006F93463,
				0x0,
				gt,
				0x18,
				0x81AA1922,
				0x0
			});
			Thread.Sleep(1000);
			return BitConverter.ToString(Console.GetMemory(0x81AA1922, 0x8)).Replace("-", "");
		}

		public static byte[] smethod_xuid2(string gamertag)
		{
			byte[] array = new byte[gamertag.Length * 2 + 2];
			array[0] = 0;
			uint num = 1U;
			foreach (char c in gamertag)
			{
				array[(int)((uint)((UIntPtr)num))] = (byte)c;
				uint num2 = num + 1U;
				array[(int)((uint)((UIntPtr)num2))] = 0;
				num = num2 + 1U;
			}
			array[(int)((uint)((UIntPtr)num))] = 0;
			return array;
		}

		public static byte[] hexString(string string_1)
		{
            int length = string_1.Length;
            byte[] array = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                array[i / 2] = Convert.ToByte(string_1.Substring(i, 2), 16);
            }
            return array;
        }

		private async void siticoneRoundedButton66_Click(object sender, EventArgs e)
		{
			Process proc = Process.GetProcessesByName("Spotify")[0];
			if (proc != null)
			{
			}
			if (!string.Equals(proc.MainWindowTitle, "Spotify", StringComparison.InvariantCultureIgnoreCase))
			{
			}
			SetGamertag("^6L");
			await Task.Delay(250);
			SetGamertag("^5Li");
			await Task.Delay(250);
			SetGamertag("^6Lis");
			await Task.Delay(250);
			SetGamertag("^5List");
			await Task.Delay(250);
			SetGamertag("^6Liste");
			await Task.Delay(250);
			SetGamertag("^5Listen");
			await Task.Delay(250);
			SetGamertag("^6Listeni");
			await Task.Delay(250);
			SetGamertag("^5Listenin");
			await Task.Delay(250);
			SetGamertag("^6Listening");
			await Task.Delay(250);
			SetGamertag("^5Listening T");
			await Task.Delay(250);
			SetGamertag("^6Listening To");
			await Task.Delay(250);
			SetGamertag("^5Listening To.");
			await Task.Delay(250);
			SetGamertag("^6Listening To..");
			await Task.Delay(250);
			SetGamertag("^5Listening To...");
			await Task.Delay(250);
			SetGamertag("^6Listening To.");
			await Task.Delay(250);
			SetGamertag("^5Listening To..");
			await Task.Delay(250);
			SetGamertag("^6Listening To...");
			await Task.Delay(250);
			SetGamertag("^5" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^6" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^5" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^6" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^5" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^6" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^5" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("^6" + proc.MainWindowTitle);
			await Task.Delay(250);
			SetGamertag("on ^2Spotify");
			await Task.Delay(2500);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton164_Click(object sender, EventArgs e)
		{
			SetGamertag("OI ^1" + siticoneRoundedTextBox36.Text);
			Thread.Sleep(2000);
			SetGamertag("Your secrets are always safe..");
			Thread.Sleep(2000);
			SetGamertag("With me");
			Thread.Sleep(2000);
			SetGamertag("I never even listen when");
			Thread.Sleep(2000);
			SetGamertag("you tell me them.");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton134_Click(object sender, EventArgs e)
		{
			SetGamertag("Hey ^1" + siticoneRoundedTextBox36.Text);
			Thread.Sleep(2000);
			SetGamertag("If your brain was dynamite");
			Thread.Sleep(2000);
			SetGamertag("there wouldn’t be enough..");
			Thread.Sleep(2000);
			SetGamertag("to blow your hat off");
			Thread.Sleep(2000);
			SetGamertag("You sad fuck");
			Thread.Sleep(2000);
			SetGamertag(Encoding.BigEndianUnicode.GetString(Console.GetMemory(0x81AA28FC, 0x1E)).Trim().Trim(new char[1]));
		}

		private void siticoneRoundedButton172_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			try
			{
				listView1.Items.Add("0 = " + Console.ReadString(0x83556EBC, 0x10));
				listView1.Items.Add("1 = " + Console.ReadString(0x8355C6B4, 0x10));
				listView1.Items.Add("2 = " + Console.ReadString(0x83561EAC, 0x10));
				listView1.Items.Add("3 = " + Console.ReadString(0x835676A4, 0x10));
				listView1.Items.Add("4 = " + Console.ReadString(0x8356CE9C, 0x10));
				listView1.Items.Add("5 = " + Console.ReadString(0x83572694, 0x10));
				listView1.Items.Add("6 = " + Console.ReadString(0x83577E8C, 0x10));
				listView1.Items.Add("7 = " + Console.ReadString(0x8357D684, 0x10));
				listView1.Items.Add("8 = " + Console.ReadString(0x83582E7C, 0x10));
				listView1.Items.Add("9 = " + Console.ReadString(0x83588674, 0x10));
				listView1.Items.Add("10 = " + Console.ReadString(0x8358DE6C, 0x10));
				listView1.Items.Add("11 = " + Console.ReadString(0x83593664, 0x10));
				listView1.Items.Add("12 = " + Console.ReadString(0x83598E5C, 0x10));
				listView1.Items.Add("13 = " + Console.ReadString(0x8359E654, 0x10));
				listView1.Items.Add("14 = " + Console.ReadString(0x835A3E4C, 0x10));
				listView1.Items.Add("15 = " + Console.ReadString(0x835A9644, 0x10));
				listView1.Items.Add("16 = " + Console.ReadString(0x835AEE3C, 0x10));
				listView1.Items.Add("17 = " + Console.ReadString(0x835B4634, 0x10));
			}
			catch
			{
			}
		}

		private void siticoneRoundedButton171_Click(object sender, EventArgs e)
		{
			int index = listView1.SelectedItems[0].Index;
			if (index != 21)
			{
				try
				{
					if (index < 19 && index > -1)
					{
						Console.CallVoid(0x8242FB70, new object[]
						{
							index,
							0,
							"; \"^2Frozen By Read#4363\""
						});
						Console.CallVoid(0x8242FB70, new object[]
						{
							index,
							0,
							"< \"^1Shutter CR sucks ass\""
						});
						Thread.Sleep(200);
						Console.CallVoid(0x8242FB70, new object[]
						{
							index,
							0,
							"7 30 90"
						});
					}
				}
				catch
				{
				}
			}
		}

		public Tuple<string, string, string> GrabBO2(int int_0)
		{
			uint num = (uint)(int_0 * 0x148 - 0x7D353C60);
			string item = BitConverter.ToString(Console.GetMemory(num, 0x8)).Replace("-", "");
			return Tuple.Create<string, string, string>(Console.ReadString(num + 0x8, 0xF), convertMem(Console.GetMemory(num + 0x7C, 0x4)), item);
		}

		public string convertMem(byte[] bytee)
		{
			string text = string.Empty;
			for (int i = 0; i < 4; i++)
			{
				decimal value = Convert.ToDecimal(bytee[i]);
				text = ((i == 3) ? (text + Convert.ToString(value)) : (text + Convert.ToString(value) + "."));
			}
			return text;
		}

		private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
			int value = siticoneTrackBar1.Value;
			label6.Text = siticoneTrackBar1.Value.ToString();
		}

		public string NatType(int i)
		{
			string result;
			switch (i)
			{
			case 1:
				result = "Open";
				break;
			case 2:
				result = "Moderate";
				break;
			case 3:
				result = "Strict";
				break;
			default:
				result = "Unknown";
				break;
			}
			return result;
		}

		private void siticoneRoundedButton166_Click(object sender, EventArgs e)
		{

		}

		private IXboxConsole Console;

		private byte[] SMCMessage = new byte[16];

		private static readonly DiscordRpcClient ShutterRPC = new DiscordRpcClient("849412256252297236");

		public static List<Client> GrabbedClients = new List<Client>();

		private byte[] AccountBytes = new byte[]
		{
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF,
			0xFF
		};

		private byte[] UnlockBytes = new byte[]
		{
			140,
			20,
			5,
			0,
			0,
			0,
			128,
			17,
			1,
			0,
			0,
			0,
			128,
			252,
			1,
			0,
			0,
			0,
			128,
			156,
			62,
			0,
			0,
			0,
			0,
			190,
			13,
			0,
			0,
			0,
			0,
			109,
			0,
			0,
			0,
			50,
			128,
			215,
			83,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			57,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			128,
			161,
			0,
			0,
			0,
			15,
			128,
			207,
			1,
			0,
			0,
			75,
			128,
			108,
			0,
			0,
			0,
			75,
			0,
			165,
			0,
			0,
			0,
			10,
			128,
			70,
			0,
			0,
			0,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			29,
			1,
			36,
			53,
			162,
			55,
			32,
			131,
			53,
			1,
			0,
			0,
			0,
			128,
			34,
			0,
			0,
			0,
			0,
			0,
			94,
			0,
			0,
			0,
			0,
			96,
			135,
			9,
			0,
			0,
			0,
			0,
			157,
			2,
			0,
			0,
			0,
			192,
			21,
			0,
			0,
			128,
			12,
			0,
			204,
			16,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			9,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			32,
			36,
			0,
			0,
			192,
			3,
			32,
			41,
			0,
			0,
			192,
			18,
			64,
			30,
			0,
			0,
			192,
			18,
			32,
			39,
			0,
			0,
			128,
			2,
			0,
			18,
			0,
			0,
			64,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			64,
			71,
			0,
			73,
			101,
			210,
			15,
			200,
			216,
			70,
			0,
			0,
			0,
			0,
			240,
			19,
			0,
			0,
			0,
			0,
			168,
			21,
			0,
			0,
			0,
			0,
			232,
			95,
			3,
			0,
			0,
			0,
			8,
			194,
			0,
			0,
			0,
			0,
			168,
			5,
			0,
			0,
			32,
			3,
			0,
			175,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			80,
			2,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			120,
			0,
			0,
			0,
			120,
			0,
			104,
			8,
			0,
			0,
			240,
			0,
			144,
			13,
			0,
			0,
			176,
			4,
			128,
			8,
			0,
			0,
			176,
			4,
			96,
			8,
			0,
			0,
			160,
			0,
			136,
			3,
			0,
			0,
			80,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			208,
			17,
			64,
			82,
			145,
			212,
			3,
			50,
			252,
			14,
			0,
			0,
			0,
			0,
			248,
			0,
			0,
			0,
			0,
			0,
			68,
			6,
			0,
			0,
			0,
			0,
			178,
			61,
			0,
			0,
			0,
			0,
			58,
			6,
			0,
			0,
			0,
			0,
			138,
			1,
			0,
			0,
			200,
			0,
			218,
			250,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			188,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			174,
			1,
			0,
			0,
			60,
			0,
			108,
			1,
			0,
			0,
			44,
			1,
			80,
			2,
			0,
			0,
			44,
			1,
			114,
			1,
			0,
			0,
			40,
			0,
			198,
			0,
			0,
			0,
			20,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			52,
			4,
			144,
			212,
			56,
			202,
			128,
			136,
			164,
			4,
			0,
			0,
			0,
			0,
			116,
			0,
			0,
			0,
			0,
			0,
			94,
			1,
			0,
			0,
			0,
			0,
			223,
			48,
			0,
			0,
			0,
			128,
			187,
			11,
			0,
			0,
			0,
			128,
			91,
			0,
			0,
			0,
			50,
			0,
			80,
			56,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			42,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			128,
			139,
			0,
			0,
			0,
			15,
			0,
			157,
			0,
			0,
			0,
			75,
			0,
			133,
			0,
			0,
			0,
			75,
			0,
			158,
			0,
			0,
			0,
			10,
			128,
			66,
			0,
			0,
			0,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			29,
			1,
			36,
			165,
			43,
			62,
			32,
			192,
			8,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			0,
			0,
			128,
			2,
			0,
			0,
			0,
			0,
			224,
			128,
			0,
			0,
			0,
			0,
			0,
			27,
			0,
			0,
			0,
			0,
			0,
			1,
			0,
			0,
			0,
			1,
			64,
			120,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			32,
			0,
			0,
			0,
			32,
			0,
			192,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			3,
			0,
			0,
			0,
			0,
			32,
			1,
			0,
			0,
			0,
			0,
			160,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			80,
			145,
			0,
			0,
			248,
			1,
			0,
			0,
			0,
			0,
			32,
			0,
			0,
			0,
			0,
			0,
			200,
			0,
			0,
			0,
			0,
			0,
			96,
			21,
			0,
			0,
			0,
			0,
			72,
			4,
			0,
			0,
			0,
			0,
			40,
			0,
			0,
			0,
			40,
			0,
			120,
			26,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			8,
			0,
			0,
			0,
			8,
			0,
			64,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			112,
			0,
			0,
			0,
			0,
			0,
			72,
			0,
			0,
			0,
			0,
			0,
			32,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			228,
			37,
			0,
			0,
			122,
			0,
			0,
			0,
			0,
			0,
			6,
			0,
			0,
			0,
			0,
			0,
			36,
			0,
			0,
			0,
			0,
			0,
			18,
			6,
			0,
			0,
			0,
			0,
			34,
			1,
			0,
			0,
			0,
			0,
			14,
			0,
			0,
			0,
			14,
			0,
			242,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			2,
			0,
			0,
			0,
			2,
			0,
			16,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			6,
			0,
			0,
			0,
			0,
			0,
			12,
			0,
			0,
			0,
			0,
			0,
			10,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			246,
			9,
			0,
			128,
			7,
			0,
			0,
			0,
			0,
			0,
			1,
			0,
			0,
			0,
			0,
			128,
			1,
			0,
			0,
			0,
			0,
			128,
			35,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1,
			0,
			0,
			0,
			1,
			128,
			146,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			0,
			0,
			0,
			0,
			0,
			0,
			1,
			0,
			0,
			0,
			0,
			0,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			125,
			0,
			0,
			128,
			4,
			0,
			0,
			0,
			0,
			160,
			0,
			0,
			0,
			0,
			0,
			96,
			1,
			0,
			0,
			0,
			0,
			96,
			79,
			0,
			0,
			0,
			0,
			0,
			15,
			0,
			0,
			0,
			0,
			64,
			0,
			0,
			0,
			64,
			0,
			160,
			49,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			96,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			192,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			0,
			0,
			0,
			0,
			0,
			128,
			0,
			0,
			0,
			0,
			0,
			64,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			64,
			106,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			32,
			82,
			22,
			0,
			0,
			0,
			0,
			190,
			19,
			0,
			0,
			0,
			0,
			100,
			7,
			0,
			0,
			0,
			0,
			110,
			202,
			1,
			0,
			0,
			0,
			246,
			97,
			0,
			0,
			0,
			0,
			192,
			1,
			0,
			0,
			200,
			0,
			38,
			96,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			142,
			2,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			246,
			1,
			0,
			0,
			60,
			0,
			122,
			2,
			0,
			0,
			44,
			1,
			234,
			1,
			0,
			0,
			44,
			1,
			88,
			3,
			0,
			0,
			40,
			0,
			160,
			1,
			0,
			0,
			20,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			100,
			53,
			252,
			134,
			158,
			246,
			128,
			12,
			102,
			5,
			0,
			0,
			0,
			128,
			108,
			2,
			0,
			0,
			0,
			128,
			13,
			2,
			0,
			0,
			0,
			0,
			197,
			111,
			0,
			0,
			0,
			0,
			77,
			26,
			0,
			0,
			0,
			128,
			112,
			0,
			0,
			0,
			50,
			128,
			140,
			90,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			135,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			0,
			147,
			0,
			0,
			0,
			15,
			0,
			110,
			0,
			0,
			0,
			75,
			0,
			117,
			0,
			0,
			0,
			75,
			0,
			171,
			0,
			0,
			0,
			10,
			128,
			80,
			0,
			0,
			0,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			89,
			13,
			191,
			1,
			213,
			52,
			32,
			67,
			99,
			1,
			0,
			0,
			0,
			160,
			117,
			1,
			0,
			0,
			0,
			160,
			139,
			0,
			0,
			0,
			0,
			64,
			136,
			27,
			0,
			0,
			0,
			128,
			66,
			5,
			0,
			0,
			0,
			96,
			27,
			0,
			0,
			128,
			12,
			224,
			205,
			22,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			96,
			42,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			32,
			35,
			0,
			0,
			192,
			3,
			224,
			25,
			0,
			0,
			192,
			18,
			64,
			24,
			0,
			0,
			192,
			18,
			96,
			55,
			0,
			0,
			128,
			2,
			224,
			21,
			0,
			0,
			64,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			64,
			86,
			195,
			111,
			100,
			79,
			16,
			200,
			0,
			98,
			0,
			0,
			0,
			0,
			144,
			15,
			0,
			0,
			0,
			0,
			40,
			32,
			0,
			0,
			0,
			0,
			8,
			172,
			7,
			0,
			0,
			0,
			168,
			209,
			1,
			0,
			0,
			0,
			40,
			8,
			0,
			0,
			32,
			3,
			224,
			62,
			6,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			16,
			9,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			120,
			0,
			0,
			0,
			120,
			0,
			232,
			10,
			0,
			0,
			240,
			0,
			168,
			7,
			0,
			0,
			176,
			4,
			176,
			7,
			0,
			0,
			176,
			4,
			88,
			12,
			0,
			0,
			160,
			0,
			96,
			6,
			0,
			0,
			80,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			144,
			213,
			240,
			27,
			242,
			225,
			3,
			50,
			102,
			37,
			0,
			0,
			0,
			0,
			16,
			29,
			0,
			0,
			0,
			0,
			8,
			25,
			0,
			0,
			0,
			0,
			114,
			218,
			2,
			0,
			0,
			0,
			252,
			133,
			0,
			0,
			0,
			0,
			128,
			2,
			0,
			0,
			200,
			0,
			88,
			67,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			124,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			84,
			5,
			0,
			0,
			60,
			0,
			78,
			2,
			0,
			0,
			44,
			1,
			16,
			2,
			0,
			0,
			44,
			1,
			184,
			4,
			0,
			0,
			40,
			0,
			52,
			1,
			0,
			0,
			20,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			100,
			53,
			252,
			70,
			123,
			218,
			128,
			140,
			178,
			7,
			0,
			0,
			0,
			128,
			71,
			2,
			0,
			0,
			0,
			0,
			152,
			3,
			0,
			0,
			0,
			0,
			112,
			170,
			0,
			0,
			0,
			128,
			136,
			36,
			0,
			0,
			0,
			128,
			174,
			0,
			0,
			0,
			50,
			128,
			128,
			154,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			229,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			0,
			207,
			0,
			0,
			0,
			15,
			0,
			118,
			0,
			0,
			0,
			75,
			0,
			91,
			0,
			0,
			0,
			75,
			0,
			0xFF,
			0,
			0,
			0,
			10,
			128,
			121,
			0,
			0,
			0,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			89,
			13,
			191,
			49,
			3,
			119,
			32,
			98,
			164,
			1,
			0,
			0,
			0,
			0,
			96,
			0,
			0,
			0,
			0,
			128,
			100,
			0,
			0,
			0,
			0,
			160,
			62,
			28,
			0,
			0,
			0,
			160,
			250,
			6,
			0,
			0,
			0,
			128,
			50,
			0,
			0,
			128,
			12,
			0,
			117,
			22,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			32,
			49,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			192,
			36,
			0,
			0,
			192,
			3,
			192,
			28,
			0,
			0,
			192,
			18,
			96,
			20,
			0,
			0,
			192,
			18,
			64,
			65,
			0,
			0,
			128,
			2,
			160,
			33,
			0,
			0,
			64,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			64,
			86,
			195,
			111,
			172,
			208,
			30,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			192,
			40,
			66,
			0,
			0,
			0,
			0,
			136,
			17,
			0,
			0,
			0,
			0,
			96,
			17,
			0,
			0,
			0,
			0,
			240,
			248,
			3,
			0,
			0,
			0,
			112,
			43,
			1,
			0,
			0,
			0,
			168,
			5,
			0,
			0,
			32,
			3,
			40,
			45,
			4,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			152,
			6,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			120,
			0,
			0,
			0,
			120,
			0,
			56,
			3,
			0,
			0,
			80,
			0,
			128,
			5,
			0,
			0,
			176,
			4,
			136,
			6,
			0,
			0,
			176,
			4,
			224,
			9,
			0,
			0,
			160,
			0,
			96,
			5,
			0,
			0,
			80,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			56,
			245,
			112,
			27,
			162,
			61,
			2,
			50,
			80,
			21,
			0,
			0,
			0,
			0,
			138,
			5,
			0,
			0,
			0,
			0,
			80,
			6,
			0,
			0,
			0,
			0,
			230,
			64,
			1,
			0,
			0,
			0,
			90,
			67,
			0,
			0,
			0,
			0,
			160,
			2,
			0,
			0,
			200,
			0,
			254,
			79,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			28,
			2,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			78,
			0,
			0,
			0,
			20,
			0,
			144,
			1,
			0,
			0,
			44,
			1,
			98,
			1,
			0,
			0,
			44,
			1,
			4,
			3,
			0,
			0,
			40,
			0,
			196,
			1,
			0,
			0,
			20,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			78,
			61,
			220,
			70,
			203,
			238,
			128,
			136,
			246,
			7,
			0,
			0,
			0,
			0,
			131,
			3,
			0,
			0,
			0,
			0,
			182,
			3,
			0,
			0,
			0,
			128,
			118,
			136,
			0,
			0,
			0,
			0,
			107,
			27,
			0,
			0,
			0,
			128,
			197,
			0,
			0,
			0,
			50,
			0,
			62,
			137,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			245,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			0,
			50,
			0,
			0,
			0,
			5,
			128,
			99,
			0,
			0,
			0,
			75,
			128,
			113,
			0,
			0,
			0,
			75,
			128,
			14,
			1,
			0,
			0,
			10,
			128,
			97,
			0,
			0,
			0,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			83,
			15,
			183,
			225,
			48,
			58,
			32,
			67,
			23,
			1,
			0,
			0,
			0,
			160,
			48,
			0,
			0,
			0,
			0,
			64,
			69,
			0,
			0,
			0,
			0,
			224,
			155,
			14,
			0,
			0,
			0,
			64,
			216,
			3,
			0,
			0,
			0,
			96,
			29,
			0,
			0,
			128,
			12,
			32,
			36,
			17,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			160,
			26,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			64,
			17,
			0,
			0,
			64,
			1,
			224,
			24,
			0,
			0,
			192,
			18,
			32,
			23,
			0,
			0,
			192,
			18,
			192,
			42,
			0,
			0,
			128,
			2,
			64,
			22,
			0,
			0,
			64,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			212,
			195,
			109,
			240,
			250,
			10,
			200,
			40,
			90,
			0,
			0,
			0,
			0,
			32,
			35,
			0,
			0,
			0,
			0,
			160,
			30,
			0,
			0,
			0,
			0,
			240,
			0xFF,
			6,
			0,
			0,
			0,
			24,
			139,
			1,
			0,
			0,
			0,
			168,
			6,
			0,
			0,
			32,
			3,
			168,
			239,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			144,
			9,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			120,
			0,
			0,
			0,
			120,
			0,
			48,
			1,
			0,
			0,
			80,
			0,
			168,
			6,
			0,
			0,
			176,
			4,
			240,
			5,
			0,
			0,
			176,
			4,
			152,
			11,
			0,
			0,
			160,
			0,
			24,
			6,
			0,
			0,
			80,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			56,
			245,
			112,
			27,
			105,
			71,
			4,
			50,
			32,
			14,
			0,
			0,
			0,
			0,
			80,
			7,
			0,
			0,
			0,
			0,
			12,
			3,
			0,
			0,
			0,
			0,
			240,
			139,
			0,
			0,
			0,
			0,
			64,
			38,
			0,
			0,
			0,
			0,
			74,
			1,
			0,
			0,
			200,
			0,
			150,
			219,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			40,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			14,
			1,
			0,
			0,
			20,
			0,
			64,
			1,
			0,
			0,
			44,
			1,
			122,
			1,
			0,
			0,
			44,
			1,
			30,
			2,
			0,
			0,
			40,
			0,
			40,
			1,
			0,
			0,
			20,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			78,
			61,
			220,
			70,
			68,
			123,
			128,
			12,
			172,
			4,
			0,
			0,
			0,
			128,
			120,
			0,
			0,
			0,
			0,
			0,
			218,
			0,
			0,
			0,
			0,
			128,
			42,
			40,
			0,
			0,
			0,
			0,
			222,
			10,
			0,
			0,
			0,
			128,
			129,
			0,
			0,
			0,
			50,
			0,
			237,
			77,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			85,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			0,
			65,
			0,
			0,
			0,
			5,
			0,
			77,
			0,
			0,
			0,
			75,
			0,
			99,
			0,
			0,
			0,
			75,
			128,
			175,
			0,
			0,
			0,
			10,
			0,
			87,
			0,
			0,
			0,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			83,
			15,
			183,
			97,
			176,
			43,
			32,
			163,
			109,
			1,
			0,
			0,
			0,
			96,
			146,
			0,
			0,
			0,
			0,
			160,
			117,
			0,
			0,
			0,
			0,
			96,
			251,
			26,
			0,
			0,
			0,
			192,
			49,
			6,
			0,
			0,
			0,
			96,
			30,
			0,
			0,
			128,
			12,
			160,
			28,
			23,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			160,
			44,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			192,
			7,
			0,
			0,
			64,
			1,
			32,
			30,
			0,
			0,
			192,
			18,
			160,
			31,
			0,
			0,
			192,
			18,
			224,
			51,
			0,
			0,
			128,
			2,
			64,
			23,
			0,
			0,
			64,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			212,
			195,
			109,
			64,
			116,
			15,
			136,
			232,
			87,
			0,
			0,
			0,
			0,
			232,
			37,
			0,
			0,
			0,
			0,
			64,
			26,
			0,
			0,
			0,
			0,
			248,
			24,
			6,
			0,
			0,
			0,
			248,
			80,
			1,
			0,
			0,
			0,
			136,
			7,
			0,
			0,
			32,
			3,
			96,
			128,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			200,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			120,
			0,
			0,
			0,
			120,
			0,
			72,
			1,
			0,
			0,
			80,
			0,
			0,
			8,
			0,
			0,
			176,
			4,
			56,
			6,
			0,
			0,
			176,
			4,
			240,
			11,
			0,
			0,
			160,
			0,
			16,
			7,
			0,
			0,
			80,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			56,
			245,
			112,
			27,
			153,
			238,
			3,
			2,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			136,
			66,
			0,
			0,
			0,
			0,
			48,
			14,
			0,
			0,
			0,
			0,
			120,
			16,
			0,
			0,
			0,
			0,
			48,
			120,
			4,
			0,
			0,
			0,
			160,
			213,
			0,
			0,
			0,
			0,
			224,
			7,
			0,
			0,
			32,
			3,
			200,
			136,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			112,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			120,
			0,
			0,
			0,
			120,
			0,
			168,
			5,
			0,
			0,
			80,
			0,
			96,
			6,
			0,
			0,
			176,
			4,
			232,
			7,
			0,
			0,
			176,
			4,
			24,
			11,
			0,
			0,
			160,
			0,
			240,
			4,
			0,
			0,
			80,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			40,
			213,
			225,
			154,
			45,
			168,
			2,
			50,
			8,
			14,
			0,
			0,
			0,
			0,
			134,
			1,
			0,
			0,
			0,
			0,
			128,
			3,
			0,
			0,
			0,
			0,
			218,
			33,
			1,
			0,
			0,
			0,
			226,
			60,
			0,
			0,
			0,
			0,
			62,
			1,
			0,
			0,
			200,
			0,
			102,
			196,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			108,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			128,
			0,
			0,
			0,
			20,
			0,
			98,
			1,
			0,
			0,
			44,
			1,
			148,
			1,
			0,
			0,
			44,
			1,
			70,
			2,
			0,
			0,
			40,
			0,
			48,
			1,
			0,
			0,
			20,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			74,
			117,
			184,
			102,
			112,
			149,
			128,
			12,
			224,
			3,
			0,
			0,
			0,
			128,
			244,
			0,
			0,
			0,
			0,
			128,
			233,
			0,
			0,
			0,
			0,
			0,
			165,
			75,
			0,
			0,
			0,
			128,
			121,
			13,
			0,
			0,
			0,
			0,
			87,
			0,
			0,
			0,
			50,
			128,
			223,
			50,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			88,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			0,
			62,
			0,
			0,
			0,
			5,
			0,
			86,
			0,
			0,
			0,
			75,
			0,
			102,
			0,
			0,
			0,
			75,
			0,
			186,
			0,
			0,
			0,
			10,
			128,
			77,
			0,
			0,
			0,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			82,
			29,
			174,
			233,
			218,
			38,
			32,
			131,
			226,
			0,
			0,
			0,
			0,
			192,
			33,
			0,
			0,
			0,
			0,
			64,
			67,
			0,
			0,
			0,
			0,
			96,
			22,
			17,
			0,
			0,
			0,
			0,
			47,
			3,
			0,
			0,
			0,
			160,
			24,
			0,
			0,
			128,
			12,
			192,
			201,
			13,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			22,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			0,
			11,
			0,
			0,
			64,
			1,
			160,
			22,
			0,
			0,
			192,
			18,
			32,
			22,
			0,
			0,
			192,
			18,
			128,
			33,
			0,
			0,
			128,
			2,
			96,
			16,
			0,
			0,
			64,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			160,
			84,
			135,
			107,
			130,
			133,
			9,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			140,
			209,
			5,
			0,
			0,
			0,
			0,
			165,
			0,
			0,
			0,
			0,
			128,
			175,
			1,
			0,
			0,
			0,
			128,
			160,
			11,
			0,
			0,
			0,
			128,
			219,
			6,
			0,
			0,
			0,
			0,
			222,
			0,
			0,
			0,
			0,
			128,
			88,
			110,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			55,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			128,
			4,
			5,
			0,
			0,
			125,
			128,
			177,
			0,
			0,
			0,
			5,
			0,
			130,
			0,
			0,
			0,
			25,
			0,
			39,
			0,
			0,
			0,
			25,
			128,
			172,
			0,
			0,
			128,
			2,
			0,
			97,
			0,
			0,
			0,
			5,
			128,
			17,
			49,
			32,
			11,
			249,
			71,
			32,
			2,
			216,
			0,
			0,
			0,
			0,
			160,
			37,
			0,
			0,
			0,
			0,
			64,
			53,
			0,
			0,
			0,
			0,
			128,
			192,
			3,
			0,
			0,
			0,
			224,
			140,
			1,
			0,
			0,
			0,
			160,
			35,
			0,
			0,
			0,
			0,
			128,
			57,
			14,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			11,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			192,
			59,
			0,
			0,
			64,
			31,
			160,
			19,
			0,
			0,
			64,
			1,
			128,
			12,
			0,
			0,
			64,
			6,
			192,
			18,
			0,
			0,
			64,
			6,
			160,
			30,
			0,
			0,
			160,
			0,
			64,
			15,
			0,
			0,
			64,
			1,
			96,
			68,
			4,
			200,
			246,
			41,
			10,
			200,
			192,
			107,
			0,
			0,
			0,
			0,
			168,
			32,
			0,
			0,
			0,
			0,
			16,
			27,
			0,
			0,
			0,
			0,
			40,
			192,
			0,
			0,
			0,
			0,
			24,
			113,
			0,
			0,
			0,
			0,
			248,
			12,
			0,
			0,
			0,
			0,
			64,
			117,
			7,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			120,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			120,
			0,
			0,
			0,
			120,
			0,
			24,
			97,
			0,
			0,
			208,
			7,
			248,
			14,
			0,
			0,
			80,
			0,
			184,
			13,
			0,
			0,
			144,
			1,
			112,
			3,
			0,
			0,
			144,
			1,
			128,
			13,
			0,
			0,
			40,
			0,
			16,
			7,
			0,
			0,
			80,
			0,
			24,
			17,
			1,
			178,
			170,
			175,
			5,
			34,
			136,
			16,
			0,
			0,
			0,
			0,
			42,
			1,
			0,
			0,
			0,
			0,
			102,
			3,
			0,
			0,
			0,
			0,
			216,
			39,
			0,
			0,
			0,
			0,
			30,
			20,
			0,
			0,
			0,
			0,
			234,
			2,
			0,
			0,
			0,
			0,
			174,
			19,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			104,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			170,
			12,
			0,
			0,
			244,
			1,
			30,
			2,
			0,
			0,
			20,
			0,
			142,
			0,
			0,
			0,
			100,
			0,
			146,
			0,
			0,
			0,
			100,
			0,
			58,
			2,
			0,
			0,
			10,
			0,
			50,
			1,
			0,
			0,
			20,
			0,
			70,
			68,
			128,
			172,
			96,
			211,
			128,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			34,
			117,
			1,
			0,
			0,
			0,
			64,
			173,
			0,
			0,
			0,
			0,
			32,
			118,
			0,
			0,
			0,
			0,
			128,
			63,
			2,
			0,
			0,
			0,
			192,
			202,
			1,
			0,
			0,
			0,
			192,
			20,
			0,
			0,
			0,
			0,
			0,
			164,
			20,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			96,
			11,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			224,
			29,
			1,
			0,
			64,
			31,
			0,
			34,
			0,
			0,
			192,
			3,
			96,
			14,
			0,
			0,
			64,
			6,
			96,
			18,
			0,
			0,
			64,
			6,
			128,
			60,
			0,
			0,
			160,
			0,
			64,
			26,
			0,
			0,
			64,
			1,
			64,
			22,
			64,
			105,
			104,
			220,
			16,
			136,
			184,
			100,
			0,
			0,
			0,
			0,
			128,
			4,
			0,
			0,
			0,
			0,
			40,
			36,
			0,
			0,
			0,
			0,
			56,
			8,
			2,
			0,
			0,
			0,
			224,
			227,
			0,
			0,
			0,
			0,
			120,
			7,
			0,
			0,
			0,
			0,
			168,
			156,
			6,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			192,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			120,
			0,
			0,
			0,
			120,
			0,
			8,
			30,
			0,
			0,
			208,
			7,
			224,
			9,
			0,
			0,
			240,
			0,
			32,
			2,
			0,
			0,
			144,
			1,
			24,
			2,
			0,
			0,
			144,
			1,
			192,
			12,
			0,
			0,
			40,
			0,
			80,
			7,
			0,
			0,
			80,
			0,
			144,
			5,
			80,
			26,
			228,
			7,
			5,
			50,
			40,
			27,
			0,
			0,
			0,
			0,
			92,
			2,
			0,
			0,
			0,
			0,
			60,
			9,
			0,
			0,
			0,
			0,
			20,
			119,
			0,
			0,
			0,
			0,
			190,
			59,
			0,
			0,
			0,
			0,
			228,
			1,
			0,
			0,
			0,
			0,
			26,
			164,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			156,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			222,
			8,
			0,
			0,
			244,
			1,
			210,
			2,
			0,
			0,
			60,
			0,
			242,
			0,
			0,
			0,
			100,
			0,
			190,
			0,
			0,
			0,
			100,
			0,
			238,
			3,
			0,
			0,
			10,
			0,
			2,
			2,
			0,
			0,
			20,
			0,
			100,
			1,
			148,
			198,
			207,
			74,
			129,
			140,
			4,
			6,
			0,
			0,
			0,
			0,
			178,
			0,
			0,
			0,
			0,
			0,
			250,
			1,
			0,
			0,
			0,
			128,
			54,
			11,
			0,
			0,
			0,
			0,
			211,
			6,
			0,
			0,
			0,
			128,
			86,
			0,
			0,
			0,
			0,
			128,
			37,
			89,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			34,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			128,
			205,
			4,
			0,
			0,
			125,
			128,
			156,
			0,
			0,
			0,
			15,
			0,
			67,
			0,
			0,
			0,
			25,
			0,
			36,
			0,
			0,
			0,
			25,
			0,
			234,
			0,
			0,
			128,
			2,
			128,
			113,
			0,
			0,
			0,
			5,
			0,
			89,
			0,
			165,
			113,
			123,
			75,
			32,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			32,
			208,
			2,
			0,
			0,
			0,
			0,
			236,
			0,
			0,
			0,
			0,
			0,
			252,
			0,
			0,
			0,
			0,
			0,
			148,
			6,
			0,
			0,
			0,
			0,
			60,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			150,
			37,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			48,
			1,
			0,
			0,
			200,
			0,
			110,
			0,
			0,
			0,
			20,
			0,
			18,
			0,
			0,
			0,
			2,
			0,
			6,
			0,
			0,
			0,
			2,
			0,
			106,
			0,
			0,
			0,
			10,
			0,
			6,
			0,
			0,
			0,
			2,
			0,
			0,
			0,
			0,
			192,
			140,
			38,
			128,
			12,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			35,
			0,
			0,
			0,
			0,
			128,
			221,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			136,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			6,
			0,
			0,
			128,
			6,
			0,
			184,
			0,
			0,
			0,
			50,
			0,
			163,
			0,
			0,
			0,
			5,
			128,
			8,
			0,
			0,
			128,
			0,
			0,
			7,
			0,
			0,
			128,
			0,
			128,
			1,
			0,
			0,
			0,
			1,
			128,
			1,
			0,
			0,
			128,
			0,
			0,
			0,
			0,
			0,
			32,
			23,
			5,
			32,
			227,
			34,
			0,
			0,
			128,
			12,
			96,
			10,
			0,
			0,
			0,
			0,
			64,
			12,
			0,
			0,
			0,
			0,
			160,
			76,
			0,
			0,
			0,
			0,
			192,
			44,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			160,
			154,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			64,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			96,
			6,
			0,
			0,
			64,
			1,
			32,
			0,
			0,
			0,
			32,
			0,
			0,
			1,
			0,
			0,
			32,
			0,
			0,
			4,
			0,
			0,
			160,
			0,
			32,
			1,
			0,
			0,
			32,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			88,
			177,
			0,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			32,
			118,
			2,
			0,
			0,
			200,
			0,
			30,
			0,
			0,
			0,
			0,
			0,
			24,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			34,
			164,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			26,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			146,
			69,
			0,
			0,
			248,
			7,
			154,
			1,
			0,
			0,
			50,
			0,
			180,
			1,
			0,
			0,
			50,
			0,
			160,
			0,
			0,
			0,
			50,
			0,
			52,
			0,
			0,
			0,
			50,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			64,
			115,
			11,
			128,
			12,
			237,
			1,
			0,
			0,
			150,
			128,
			55,
			0,
			0,
			0,
			0,
			0,
			211,
			0,
			0,
			0,
			0,
			128,
			113,
			8,
			0,
			0,
			0,
			0,
			166,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			43,
			30,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			23,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			7,
			0,
			0,
			128,
			7,
			128,
			33,
			0,
			0,
			128,
			0,
			128,
			56,
			0,
			0,
			128,
			2,
			0,
			6,
			0,
			0,
			128,
			0,
			128,
			4,
			0,
			0,
			128,
			0,
			128,
			21,
			0,
			0,
			128,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			0,
			16,
			68,
			184,
			153,
			21,
			32,
			163,
			106,
			0,
			0,
			0,
			0,
			64,
			19,
			0,
			0,
			0,
			0,
			64,
			55,
			0,
			0,
			0,
			0,
			32,
			151,
			0,
			0,
			0,
			0,
			0,
			38,
			0,
			0,
			0,
			0,
			0,
			3,
			0,
			0,
			0,
			0,
			192,
			176,
			7,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			1,
			0,
			0,
			224,
			1,
			160,
			106,
			0,
			0,
			128,
			37,
			128,
			12,
			0,
			0,
			160,
			0,
			160,
			17,
			0,
			0,
			32,
			3,
			64,
			63,
			0,
			0,
			32,
			3,
			128,
			12,
			0,
			0,
			32,
			0,
			0,
			5,
			0,
			0,
			64,
			0,
			0,
			0,
			0,
			0,
			176,
			55,
			4,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			86,
			0,
			0,
			0,
			0,
			0,
			6,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			220,
			0,
			0,
			0,
			0,
			0,
			144,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			188,
			25,
			0,
			0,
			0,
			0,
			16,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			2,
			51,
			0,
			0,
			128,
			37,
			224,
			30,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			192,
			109,
			1,
			0,
			0,
			0,
			128,
			114,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			32,
			23,
			245,
			0,
			0,
			0,
			128,
			103,
			1,
			0,
			0,
			0,
			96,
			11,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			144,
			164,
			2,
			128,
			24,
			21,
			0,
			0,
			96,
			9,
			168,
			2,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			240,
			80,
			0,
			0,
			0,
			0,
			80,
			21,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			248,
			17,
			5,
			0,
			0,
			0,
			248,
			76,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			16,
			8,
			1,
			32,
			92,
			3,
			0,
			0,
			88,
			2,
			196,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			94,
			26,
			0,
			0,
			0,
			0,
			164,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			72,
			6,
			5,
			0,
			0,
			0,
			98,
			25,
			0,
			0,
			0,
			0,
			194,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			155,
			47,
			0,
			136,
			17,
			3,
			0,
			0,
			150,
			128,
			48,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			70,
			9,
			0,
			0,
			0,
			128,
			159,
			4,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			215,
			103,
			1,
			0,
			0,
			0,
			19,
			9,
			0,
			0,
			0,
			128,
			43,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			96,
			33,
			46,
			0,
			34,
			165,
			0,
			0,
			128,
			37,
			160,
			18,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			32,
			117,
			2,
			0,
			0,
			0,
			96,
			235,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			83,
			110,
			0,
			0,
			0,
			192,
			238,
			2,
			0,
			0,
			0,
			160,
			7,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			84,
			113,
			8,
			128,
			88,
			51,
			0,
			0,
			96,
			9,
			56,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			136,
			244,
			0,
			0,
			0,
			0,
			48,
			72,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			160,
			122,
			57,
			0,
			0,
			0,
			176,
			244,
			0,
			0,
			0,
			0,
			80,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			45,
			193,
			2,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			133,
			0,
			0,
			0,
			0,
			0,
			6,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			74,
			56,
			0,
			0,
			0,
			0,
			133,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			66,
			1,
			0,
			0,
			0,
			0,
			128,
			2,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			96,
			251,
			0,
			0,
			0,
			0,
			64,
			138,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			192,
			0,
			37,
			0,
			0,
			0,
			64,
			138,
			0,
			0,
			0,
			0,
			0,
			11,
			0,
			0,
			0,
			0,
			224,
			78,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			160,
			15,
			0,
			192,
			120,
			0,
			0,
			0,
			0,
			0,
			16,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			88,
			79,
			0,
			0,
			0,
			0,
			224,
			63,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			172,
			15,
			0,
			0,
			0,
			64,
			78,
			0,
			0,
			0,
			0,
			88,
			18,
			0,
			0,
			0,
			0,
			152,
			19,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			124,
			21,
			0,
			48,
			6,
			0,
			0,
			0,
			0,
			0,
			4,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			82,
			7,
			0,
			0,
			0,
			0,
			68,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			12,
			123,
			1,
			0,
			0,
			0,
			66,
			7,
			0,
			0,
			0,
			0,
			42,
			0,
			0,
			0,
			0,
			0,
			222,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			175,
			0,
			0,
			12,
			2,
			0,
			0,
			0,
			0,
			0,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			12,
			3,
			0,
			0,
			0,
			0,
			38,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			79,
			238,
			0,
			0,
			0,
			0,
			121,
			1,
			0,
			0,
			0,
			0,
			63,
			0,
			0,
			0,
			0,
			0,
			75,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			25,
			0,
			0,
			195,
			1,
			0,
			0,
			0,
			0,
			0,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			96,
			184,
			1,
			0,
			0,
			0,
			192,
			115,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			192,
			114,
			116,
			0,
			0,
			0,
			224,
			222,
			1,
			0,
			0,
			0,
			64,
			34,
			0,
			0,
			0,
			0,
			224,
			67,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			80,
			20,
			0,
			128,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			248,
			112,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			192,
			247,
			30,
			0,
			0,
			0,
			64,
			85,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			224,
			49,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			22,
			113,
			0,
			48,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			66,
			16,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			154,
			0,
			0,
			0,
			0,
			0,
			32,
			74,
			5,
			0,
			0,
			0,
			190,
			9,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			118,
			4,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			136,
			2,
			0,
			0,
			0,
			0,
			128,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			96,
			2,
			0,
			0,
			0,
			128,
			30,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			31,
			146,
			0,
			0,
			0,
			128,
			79,
			2,
			0,
			0,
			0,
			0,
			1,
			0,
			0,
			0,
			0,
			0,
			82,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			128,
			37,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			108,
			4,
			0,
			0,
			144,
			1,
			38,
			2,
			0,
			0,
			0,
			0,
			228,
			4,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			88,
			162,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			30,
			0,
			0,
			0,
			30,
			0,
			240,
			0,
			0,
			0,
			20,
			0,
			66,
			0,
			0,
			0,
			10,
			0,
			142,
			0,
			0,
			0,
			10,
			0,
			66,
			0,
			0,
			0,
			10,
			0,
			26,
			0,
			0,
			0,
			10,
			0,
			0
		};

		public class Client
		{
			public int Index { get; set; }

			public string Gamertag { get; set; }

			public string XUID { get; set; }

			public string InternalIP { get; set; }

			public string ExternalIP { get; set; }

			public string Port { get; set; }

			public string Mac { get; set; }

			
		}

        private void siticoneRoundedButton162_Click(object sender, EventArgs e)
        {
            ChangeMap("map mp_frostbite"); //Read really? 
        }

        private void siticoneCheckBox1_CheckChanged(object sender, EventArgs e)
        {

        }
    }
}

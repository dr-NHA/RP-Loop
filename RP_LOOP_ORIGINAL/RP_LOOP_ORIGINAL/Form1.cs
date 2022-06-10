using Memory;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace RP_LOOP_ORIGINAL{
    public partial class Form1 : Form{

		public Mem MemLib = new Mem();

		public Form1(){
            InitializeComponent();
            MemLib.OpenProcess("GTA5");
            Thread.Sleep(100);
        }
		private void checkBox1_CheckedChanged(object sender, EventArgs e){
			timer1.Interval = 1000;
			timer1.Enabled = checkBox1.Checked;
		}

		private void timer1_Tick(object sender, EventArgs e){
			if (this.checkBox1.Checked){
				this.MemLib.WriteMemory("base+02DB12E8,10", "float", "500", "", null, true);
				this.MemLib.WriteMemory("base+026A4120,60,888", "int", "1", "", null, true);
				Thread.Sleep(1000);
				this.MemLib.WriteMemory("base+026A4120,60,888", "int", "0", "", null, true);
				Thread.Sleep(1000);
				return;
			}
			this.MemLib.WriteMemory("base+02DB12E8,10", "float", "1", "", null, true);
			this.MemLib.WriteMemory("base+026A4120,60,888", "int", "0", "", null, true);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
			Process.Start("https://discordapp.com/users/933639027616280646");
		}

    }
}

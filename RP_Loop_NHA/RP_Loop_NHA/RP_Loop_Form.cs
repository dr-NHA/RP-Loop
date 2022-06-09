using RP_Loop_NHA;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP_Loop_NHA{
public partial class RP_Loop_Form : Form{

[System.Runtime.InteropServices.DllImport("user32.dll")]
private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
[System.Runtime.InteropServices.DllImport("user32.dll")]
private static extern bool ReleaseCapture();


		
private Process GTA_PROCESS=null;
private Mem MemLib = new Mem();
private bool IsProcessOpen = false;


private bool IsLooperEnabled = false;

private void ToggleLooperEnabled(){
IsLooperEnabled = !IsLooperEnabled;
ToggleLoopCheckBox.Checked= IsLooperEnabled;
}


public RP_Loop_Form(){
InitializeComponent();
//Add Drag To The Form
//Added Right Click Popup To Close Form Down
MouseEventHandler MEH=(sender, e)=>{
if (e.Button == MouseButtons.Left){
ReleaseCapture();
SendMessage(Handle, 0xA1, 0x2, 0);
}else if (e.Button == MouseButtons.Right){
var dialogResult = MessageBox.Show("Are You Sure?", "Want To Exit RP Loop", MessageBoxButtons.YesNo);
if(dialogResult == DialogResult.Yes){
this.Close();
Application.Exit();
}

}
}; 

this.MouseDown+= MEH;
ConnectionText.MouseDown += MEH;
Side.MouseDown+= MEH;

ToggleLoopLabel.Click += (X, E) => ToggleLooperEnabled();
ToggleLoopLabel.MouseDown+= MEH;

ToggleLoopCheckBox.Click += (X, E) => ToggleLooperEnabled();
			
void D()=> Process.Start("https://discord.gg/thhxdEG2T3");

CreatorLabel.Click += (X, E) => D();

MadeByLabel.Click += (X, E) => D();

var T="";
Task.Run(async () => {
while (true) {
		
if (GTA_PROCESS != null) { 
if (GTA_PROCESS.HasExited){
GTA_PROCESS=null;
IsProcessOpen = false;}}

AttemptOpenProcess();
AutoRP_Loop();
T=IsProcessOpen?"Connected: "+MemLib.mProc.Process.Id.ToString("X2"):"Please Open GTA V!";
if(ConnectionText.Text!=T)
ConnectionText.Text=T;
await Task.Delay(100);
}
});

}

private bool IsConnectionAttempting = false;
private async Task AttemptOpenProcess() { 
if(!IsProcessOpen&&!IsConnectionAttempting){
IsConnectionAttempting = true;
if (MemLib.OpenProcess("GTA5")) {
IsProcessOpen = true;
GTA_PROCESS=	MemLib.mProc.Process;
}
IsConnectionAttempting = false;
}
}

private bool AutoRP_Loop_IsLooping = false;
private async Task AutoRP_Loop(){
if (IsLooperEnabled && !AutoRP_Loop_IsLooping){
AutoRP_Loop_IsLooping = true;
MemLib.WriteMemory("base+02DB12E8,10", "float", "500", "", null, true);
MemLib.WriteMemory("base+026A4120,60,888", "int", "1", "", null, true);
await Task.Delay(1000);
MemLib.WriteMemory("base+026A4120,60,888", "int", "0", "", null, true);
await Task.Delay(1000);
//Reset States!
MemLib.WriteMemory("base+02DB12E8,10", "float", "1", "", null, true);
MemLib.WriteMemory("base+026A4120,60,888", "int", "0", "", null, true);
AutoRP_Loop_IsLooping = false;
}else{
}}



	}
}

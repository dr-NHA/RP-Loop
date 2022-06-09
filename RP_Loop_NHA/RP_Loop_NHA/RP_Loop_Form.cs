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
private static Mem MemLib = new Mem();
private bool IsProcessOpen = false;


private bool IsLooperEnabled = false;

private void ToggleLooperEnabled(){
IsLooperEnabled = !IsLooperEnabled;
ToggleLoopCheckBox.Checked= IsLooperEnabled;
}


public RP_Loop_Form(){
InitializeComponent();

#if DEBUG
this.Height=100+BackPanel.Height+ ConnectionText.Height+1;
this.Width= this.Width+30;
#else
this.Height=BackPanel.Height+ ConnectionText.Height+1;
#endif

//Add Drag To The Form
//Added Right Click Popup To Close Form Down
Action<MouseEventArgs> MEH =(e)=>{
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

this.MouseDown+=(X,E)=> { MEH.Invoke(E); };
ConnectionText.MouseDown+=(X,E)=> { MEH.Invoke(E); };
Side.MouseDown+=(X,E)=> { MEH.Invoke(E); };
BackPanel.MouseDown+=(X,E)=> { MEH.Invoke(E); };
DBPanel.MouseDown +=(X,E)=> { MEH.Invoke(E); };
DA_Panel.MouseDown +=(X,E)=> { MEH.Invoke(E); };
MadeByLabel.MouseDown+=(X,E)=> { MEH.Invoke(E); };

ToggleLoopLabel.MouseDown+=(X,E)=> { ToggleLooperEnabled(); MEH.Invoke(E); };

ToggleLoopCheckBox.MouseDown+=(X,E)=> { ToggleLooperEnabled(); MEH.Invoke(E); };
			
CreatorLabel.MouseDown+=(X,E)=> { Process.Start("https://discord.gg/thhxdEG2T3"); MEH.Invoke(E); };

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
await ConnectWorld();
GTA_PROCESS=	MemLib.mProc.Process;
}
IsConnectionAttempting = false;
}
}


private string WorldAssemblyAddress="";
private string WorldBaseAddress="";
private string WorldPlayersBaseAddress => MemLib.ReadLong(WorldBaseAddress).ToString("X2");
private string LocalPlayerAddress => MemLib.ReadLong(WorldPlayersBaseAddress + "+8").ToString("X2");
private string LocalPlayerInfoAddress => MemLib.ReadLong(LocalPlayerAddress + "+10C8").ToString("X2");
private string WantedOffset=>(0x7D0+0xB8).ToString("X2");//Ripped From The Games Assembly Code

public int WantedLevel { 
get=>MemLib.ReadInt(LocalPlayerInfoAddress+"+"+WantedOffset);
set=>MemLib.WriteMemory(LocalPlayerInfoAddress + "+" + WantedOffset,"int",value.ToString());
}

		
private string GlobalAssemblyAddress="";
private string GlobalBaseAddress = "";
private string GlobalRP_Address=> (MemLib.ReadLong(GlobalBaseAddress+"+8") +0x10).ToString("X2");
		
public float GlobalRPValue { 
get=>MemLib.ReadFloat(GlobalRP_Address);
set=>MemLib.WriteMemory(GlobalRP_Address, "float", value.ToString());
}

private bool IsWorldConnectionAttempting = false;
private async Task ConnectWorld() { 
if(!IsWorldConnectionAttempting){
IsWorldConnectionAttempting = true;
var WorldHook= await MemLib.AoBScan(
MemLib.mProc.MainModule.BaseAddress.ToInt64(),
MemLib.mProc.MainModule.BaseAddress.ToInt64()+ MemLib.mProc.MainModule.ModuleMemorySize,
"48 8B 05 ?? ?? ?? ?? 45 ?? ?? ?? ?? 48 8B 48 08 48 85 C9 74 07",true,true,true,"");

long Address= WorldHook[0];
WorldAssemblyAddress =(Address.ToString("X2"));	
WorldBaseAddress=(Address+ MemLib.ReadInt((Address+3).ToString("X2"))+7).ToString("X2");	



var GlobalHook= await MemLib.AoBScan(
MemLib.mProc.MainModule.BaseAddress.ToInt64(),
MemLib.mProc.MainModule.BaseAddress.ToInt64()+ MemLib.mProc.MainModule.ModuleMemorySize,
"48 8D 3D ?? ?? ?? 0? 80 3E", true,true,true,"");
				
Address= GlobalHook[0];
GlobalAssemblyAddress=(Address.ToString("X2"));	
GlobalBaseAddress=(Address+ MemLib.ReadInt((Address+3).ToString("X2"))+7).ToString("X2");	



DebugBox.Text=
"WorldAssemblyAddress: " + WorldAssemblyAddress
+ "\n"+
"WorldBaseAddress: " + WorldBaseAddress
+ "\n"+
"WorldPlayersBaseAddress: " + WorldPlayersBaseAddress
+ "\n"+
"LocalPlayerAddress: " + LocalPlayerAddress
+ "\n" +
"LocalPlayerInfoAddress: " + LocalPlayerInfoAddress
+"\n"+"\n" +
"GlobalAssemblyAddress: " + GlobalAssemblyAddress
+ "\n" +
"GlobalBaseAddress: " + GlobalBaseAddress
;

IsWorldConnectionAttempting = false;

}
}


private bool AutoRP_Loop_IsLooping = false;
private async Task AutoRP_Loop(){
if (IsLooperEnabled && !AutoRP_Loop_IsLooping){
AutoRP_Loop_IsLooping = true;
GlobalRPValue=500f;
WantedLevel=1;
await Task.Delay(1000);
WantedLevel=0;
await Task.Delay(1000);
//Reset RP State!
GlobalRPValue=1;
AutoRP_Loop_IsLooping = false;
}else{
}}



	}
}

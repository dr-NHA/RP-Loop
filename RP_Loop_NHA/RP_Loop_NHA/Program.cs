using System;
using System.Windows.Forms;

namespace RP_Loop_NHA{
    internal static class Program{
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RP_Loop_Form());
        }
    }
}

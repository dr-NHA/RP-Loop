using System;
using System.Windows.Forms;

namespace RP_LOOP_ORIGINAL{
    internal static class Program{
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace SGE
{
    static class Program
    {
        [STAThread]
        static void Main(params string[] Args)
        {
            File.WriteAllBytes(Application.StartupPath + @"\blank.swf", RES.blank);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string SWF = Args.Length > 0 ? Args[0].Trim() : "";
            Application.Run(new Forms.Main(SWF));
        }
    }
}

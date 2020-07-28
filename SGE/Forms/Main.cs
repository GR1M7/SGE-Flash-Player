using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SGE.Forms
{
    public partial class Main : Form
    {
        public Main(string SWF = "")
        {
            InitializeComponent();
            PlaySWF(SWF);
        }

        private void BTN_HowToUse_Click(object sender, EventArgs e)
        {
            string body =
                "Files can be opened trough the GUI or you can set this application as the default " +
                "application to open SWF files." +
                "\r\n\r\n" +
                "To do the latter: Right click on a SWF file and press \"Open with...\", make sure the " +
                "checkbox \"Always use this app to open .swf files\" is checked, scroll all the way to " +
                "the bottom and press on \"Look for another app on this PC\", navigate to this " +
                "application folder and select the executable of the app. This will make so that all " +
                "SWF files when clicked will be opened with this software automatically.";
            MessageBox.Show(body, "How to use", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTN_About_Click(object sender, EventArgs e)
        {
            using (About frm = new About())
                frm.ShowDialog();
        }

        private void BTN_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open SWF file";
                ofd.DefaultExt = "swf";
                ofd.Filter = "swf files (*.swf)|*.swf";
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.ShowDialog();
                PlaySWF(ofd.FileName);
            }
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            CloseSWF();
        }

        private void BTN_ClearCache_Click(object sender, EventArgs e)
        {
            string cacheFolder = 
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\Macromedia\Flash Player\#SharedObjects";

            if (Directory.Exists(cacheFolder))
                Directory.Delete(cacheFolder, true);
        }

        private void PlaySWF(string File)
        {
            if (!string.IsNullOrEmpty(File))
            {
                Text += " - " + Path.GetFileNameWithoutExtension(File);
                SWF_Player.Movie = File;
                SWF_Player.Play();
            }
        }

        private void CloseSWF()
        {
            SWF_Player.Movie = "blank.swf";
            Text = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        }
    }
}

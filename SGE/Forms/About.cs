using System.Diagnostics;
using System.Windows.Forms;

namespace SGE.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void LNK_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(LNK_GitHub.Text);
        }
    }
}

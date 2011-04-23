using System.Diagnostics;
using System.Windows.Forms;

namespace GoogleResults
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.seoze.com");
        }
    }
}

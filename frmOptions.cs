using System;
using System.Windows.Forms;

namespace GoogleResults
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtResultPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmOptions_Load(object sender, EventArgs e)
        {

        }
    }
}

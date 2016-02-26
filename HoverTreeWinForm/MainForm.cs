using System;
using System.Windows.Forms;

namespace HoverTreeWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem_apiForm_Click(object sender, EventArgs e)
        {
            FormHewenqi h_form = new FormHewenqi();
            h_form.MdiParent = this;
            h_form.Show();
        }
    }
}

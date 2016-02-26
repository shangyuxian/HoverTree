using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HoverTreeWinForm
{
    public partial class FormHewenqi : Form
    {

        

        /// <summary>
        /// http://hovertree.com/h/bjaf/v4y0b2l6.htm
        /// </summary>
        /// <param name="h"></param>
        /// <param name="m"></param>
        /// <param name="c"></param>
        /// <param name="type"></param>
        /// <returns></returns>

        [DllImport("User32.dll")]
        public static extern int MessageBox(int h, string m, string c, int type);
        public FormHewenqi()
        {
            InitializeComponent();
            //使控件不透明
            this.TransparencyKey = BackColor;
        }

        private void button_hewenqi_Click(object sender, EventArgs e)
        {
            MessageBox(0, "Hello Win32 API HoverTree", "何问起网", 4);
        }

        private void linkLabel_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://hovertree.com/h/bjaf/v4y0b2l6.htm");
        }

        private void button_hoverc_Click(object sender, EventArgs e)
        {
            //获取主窗体句柄
            IntPtr h_handle = HewenqiUser32.GetCurrentWindowHandle();
            int h_jubing = 0; ;
            if (h_handle != IntPtr.Zero)
                h_jubing = (int)(h_handle);
            MessageBox(h_jubing, "Hello hovertree.com", "欢迎光临何问起", 4);
        }
    }
}

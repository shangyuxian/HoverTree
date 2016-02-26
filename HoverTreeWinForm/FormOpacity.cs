using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HoverTreeWinForm
{
    public partial class FormOpacity : Form
    {

        /// <summary>
        /// 使窗体透明 by 何问起
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {

                CreateParams parameter = base.CreateParams;
                parameter.ExStyle |= 0x00080000;
                return parameter;

            }
        }

        public FormOpacity()
        {
            InitializeComponent();
            //使控件不透明
            this.TransparencyKey = BackColor;
        }

        private void FormOpacity_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("何问起");
        }
    }
}

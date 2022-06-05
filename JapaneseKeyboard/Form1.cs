using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;
        }

		protected override CreateParams CreateParams
        {
            get {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;

                return param; 
            }
        }

		private void SendKey(object sender, EventArgs e)
		{
            Button btn = (Button)sender;

            SendKeys.Send(btn.Text);
		}
	}
}

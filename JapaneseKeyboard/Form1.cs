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

                private void ToggleButton(CheckBox button)
                {
                        button.BackColor = button.Checked ? System.Drawing.Color.FromArgb(180, 180, 220) : System.Drawing.Color.FromArgb(128, 255, 255);
                        button.FlatAppearance.BorderColor = button.Checked ? System.Drawing.Color.FromArgb(0, 128, 128) : System.Drawing.Color.FromArgb(0, 192, 192);
                }

                private void RightShift_CheckedChanged(object sender, EventArgs e)
                {
                        if (rightShift.Checked && dakuten.Checked)
                                dakuten.Checked = false;

                        ToggleButton(rightShift);

                        int aux = rightShift.Checked ? 1 : -1;
                        for (int i = 0; i < 8; i++)
                        {
                                string buttonName = "kana" + i;
                                Controls[buttonName].Text = ((char)(Controls[buttonName].Text.ToCharArray()[0] - 1 * aux)).ToString();
                        }

                        kana20.Text = ((char)(kana20.Text.ToCharArray()[0] - 1 * aux)).ToString();
                        kana43.Text = ((char)(kana43.Text.ToCharArray()[0] + 3 * aux)).ToString();
        }

                private void Dakuten_CheckedChanged(object sender, EventArgs e)
                {
                        if (dakuten.Checked)
                        {
                                if (rightShift.Checked)
                                        rightShift.Checked = false;
                                if(handakuten.Checked)
                                        handakuten.Checked = false;
                        }

                        ToggleButton(dakuten);

                        int aux = dakuten.Checked ? 1 : -1;
                        for (int i = 8; i < 28; i++)
                        {
                                string buttonName = "kana" + i;
                                Controls[buttonName].Text = ((char)(Controls[buttonName].Text.ToCharArray()[0] + 1 * aux)).ToString();
                        }
                }

                private void Handakuten_CheckedChanged(object sender, EventArgs e)
                {
                        if (handakuten.Checked && dakuten.Checked)
                                dakuten.Checked = false;

                        ToggleButton(handakuten);

                        int aux = handakuten.Checked ? 1 : -1;
                        for (int i = 23; i < 28; i++)
                        {
                                string buttonName = "kana" + i;
                                Controls[buttonName].Text = ((char)(Controls[buttonName].Text.ToCharArray()[0] + 2 * aux)).ToString();
                        }
                }

                private void LeftShift_CheckedChanged(object sender, EventArgs e) 
                {
                        ToggleButton(leftShift);

                        int aux = leftShift.Checked ? 1 : -1;
                        for (int i = 0; i < 45; i++) 
                        {
                                string buttonName = "kana" + i;
                                Controls[buttonName].Text = ((char)(Controls[buttonName].Text.ToCharArray()[0] + 96 * aux)).ToString();
                        }
                }
        }
}

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

                private void Handakuten_CheckedChanged(object sender, EventArgs e)
                {
                        if(handakuten.Checked)
                        {
                                if (dakuten.Checked)
                                        dakuten.Checked = false;

                                handakuten.BackColor = System.Drawing.Color.FromArgb(180, 180, 220);
                                handakuten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 128, 128);

                                ha.Text = "ぱ";
                                hi.Text = "ぴ";
                                fu.Text = "ぷ";
                                he.Text = "ぺ";
                                ho.Text = "ぽ";
                        } else
                        {
                                handakuten.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
                                handakuten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 192, 192);

                                ha.Text = "は";
                                hi.Text = "ひ";
                                fu.Text = "ふ";
                                he.Text = "へ";
                                ho.Text = "ほ";
                        }
                }

                private void Dakuten_CheckedChanged(object sender, EventArgs e)
                {
                        if (dakuten.Checked)
                        {
                                if(handakuten.Checked)
                                        handakuten.Checked = false;

                                dakuten.BackColor = System.Drawing.Color.FromArgb(180, 180, 220);
                                dakuten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 128, 128);
                
                                ka.Text = "が";
                                ki.Text = "ぎ";
                                ku.Text = "ぐ";
                                ku.Text = "げ";
                                ko.Text = "ご";

                                sa.Text = "ざ";
                                shi.Text = "じ";
                                su.Text = "ず";
                                se.Text = "ぜ";
                                so.Text = "ぞ";

                                ta.Text = "だ";
                                chi.Text = "ぢ";
                                tsu.Text = "づ";
                                te.Text = "で";
                                to.Text = "ど";

                                ha.Text = "ば";
                                hi.Text = "び";
                                fu.Text = "ぶ";
                                he.Text = "べ";
                                ho.Text = "ぼ";
                        }
                        else
                        {
                                dakuten.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
                                dakuten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 192, 192);

                                ka.Text = "か";
                                ki.Text = "き";
                                ku.Text = "く";
                                ku.Text = "け";
                                ko.Text = "こ";

                                sa.Text = "さ";
                                shi.Text = "し";
                                su.Text = "す";
                                se.Text = "せ";
                                so.Text = "そ";

                                ta.Text = "た";
                                chi.Text = "ち";
                                tsu.Text = "つ";
                                te.Text = "て";
                                to.Text = "と";

                                ha.Text = "は";
                                hi.Text = "ひ";
                                fu.Text = "ふ";
                                he.Text = "へ";
                                ho.Text = "ほ";
                        }
                }

                private void Shift_CheckedChanged(object sender, EventArgs e)
                {
                        if (shift.Checked)
                        {
                                shift.BackColor = System.Drawing.Color.FromArgb(180, 180, 220);
                                shift.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 128, 128);

                                a.Text = "ぁ";
                                i.Text = "ぃ";
                                u.Text = "ぅ";
                                this.e.Text = "ぇ";
                                o.Text = "ぉ";

                                ya.Text = "ゃ";
                                yu.Text = "ゅ";
                                yo.Text = "ょ";
                                tsu.Text = "っ";
                                wa.Text = "を";
                        }
                        else
                        {
                                shift.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
                                shift.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 192, 192);

                                a.Text = "あ";
                                i.Text = "い";
                                u.Text = "う";
                                this.e.Text = "え";
                                o.Text = "お";

                                ya.Text = "や";
                                yu.Text = "ゆ";
                                yo.Text = "よ";
                                tsu.Text = "つ";
                                wa.Text = "わ";
                        }
                }
        }
}

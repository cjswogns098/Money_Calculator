using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_calculater
{
    public partial class Form1 : Form
    {
        long v_50th;
        long v_10th;
        long v_5th;
        long v_1th;
        long v_5hu;
        long v_1hu;
        long v_5ten;
        long v_1ten;
        long sum_num;
        long input_num;

        public Form1()
        {
            InitializeComponent();
            v_50th = 0;
            v_10th = 0;
            v_5th = 0;
            v_1th = 0;
            v_5hu = 0;
            v_1hu = 0;
            v_5ten = 0;
            v_1ten = 0;
            sum_num = 0;
            input_num = 0;
            num_50th.KeyPress += new KeyPressEventHandler(numeric_input);
            num_10th.KeyPress += new KeyPressEventHandler(numeric_input);
            num_5th.KeyPress += new KeyPressEventHandler(numeric_input);
            num_1th.KeyPress += new KeyPressEventHandler(numeric_input);
            num_5hu.KeyPress += new KeyPressEventHandler(numeric_input);
            num_1hu.KeyPress += new KeyPressEventHandler(numeric_input);
            num_5ten.KeyPress += new KeyPressEventHandler(numeric_input);
            num_1ten.KeyPress += new KeyPressEventHandler(numeric_input);
            input_box.KeyPress += new KeyPressEventHandler(numeric_input);
        }

        private void Comma_Set(TextBox send)
        {
            string lgsText;
            if (!(send.Text.Equals("")))
            {
                lgsText = send.Text.Replace(",", "");//숫자변환시 콤마로 발생하는 에러 방지
                send.Text = String.Format("{0:#,#}", Convert.ToInt32(lgsText));//천 단위 찍어주기m_txtBuyItemPrice.SelectionStart = m_txtBuyItemPrice.TextLength;
                send.SelectionLength = 0;
                send.Select(send.Text.Length, 0);
            }
        }


        private void numeric_input(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ActiveControl.TabIndex == 11)
                {
                    num_10th.Focus();
                }
                else if (ActiveControl.TabIndex == 12)
                {
                    num_5th.Focus();
                }
                else if (ActiveControl.TabIndex == 13)
                {
                    num_1th.Focus();
                }
                else if (ActiveControl.TabIndex == 14)
                {
                    num_5hu.Focus();
                }
                else if (ActiveControl.TabIndex == 15)
                {
                    num_1hu.Focus();
                }
                else if (ActiveControl.TabIndex == 16)
                {
                    num_5ten.Focus();
                }
                else if (ActiveControl.TabIndex == 17)
                {
                    num_1ten.Focus();
                }
                else if (ActiveControl.TabIndex == 18)
                {
                    num_50th.Focus();
                }
                else;
            }

            if (!(char.IsDigit(e.KeyChar)))
            { //키를 조사해서 숫자만입력 !을 없애만 문자만 입력 받게된다.
                if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
                {
                    e.Handled = true;
                }
            }


        }



        private void num_50th_TextChanged(object sender, EventArgs e)
        {
            Comma_Set(num_50th);
            if (num_50th.Text != "")
            {
                v_50th = long.Parse(num_50th.Text.Replace(",", "")) * 50000;
                value_50th.Text = v_50th.ToString();
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                Comma_Set(value_50th);
                Comma_Set(sum_box);
            }
            else
            {
                value_50th.Text = "0";
                v_50th = 0;
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                if (sum_num == 0)
                    sum_box.Text = "0";
                else
                    Comma_Set(sum_box);
            }
        }

        private void num_10th_TextChanged(object sender, EventArgs e)
        {
            Comma_Set(num_10th);
            if (num_10th.Text != "")
            {
                Comma_Set(num_10th);
                v_10th = long.Parse(num_10th.Text.Replace(",", "")) * 10000;
                value_10th.Text = v_10th.ToString();
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                Comma_Set(value_10th);
                Comma_Set(sum_box);
            }
            else
            {
                value_10th.Text = "0";
                v_10th = 0;
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                if (sum_num == 0)
                    sum_box.Text = "0";
                else
                    Comma_Set(sum_box);
            }
        }

        private void num_5th_TextChanged(object sender, EventArgs e)
        {
            Comma_Set(num_5th);
            if (num_5th.Text != "")
            {
                Comma_Set(num_5th);
                v_5th = long.Parse(num_5th.Text.Replace(",", "")) * 5000;
                value_5th.Text = v_5th.ToString();
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                Comma_Set(value_5th);
                Comma_Set(sum_box);
            }
            else
            {
                value_5th.Text = "0";
                v_5th = 0;
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                if (sum_num == 0)
                    sum_box.Text = "0";
                else
                    Comma_Set(sum_box);
            }
        }

        private void num_1th_TextChanged(object sender, EventArgs e)
        {
            Comma_Set(num_1th);
            if (num_1th.Text != "")
            {
                Comma_Set(num_1th);
                v_1th = long.Parse(num_1th.Text.Replace(",", "")) * 1000;
                value_1th.Text = v_1th.ToString();
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                Comma_Set(value_1th);
                Comma_Set(sum_box);
            }
            else
            {
                value_1th.Text = "0";
                v_1th = 0;
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                if (sum_num == 0)
                    sum_box.Text = "0";
                else
                    Comma_Set(sum_box);
            }
        }

        private void num_5hu_TextChanged(object sender, EventArgs e)
        {
            Comma_Set(num_5hu);
            if (num_5hu.Text != "")
            {
                Comma_Set(num_5hu);
                v_5hu = long.Parse(num_5hu.Text.Replace(",", "")) * 500;
                value_5hu.Text = v_5hu.ToString();
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                Comma_Set(value_5hu);
                Comma_Set(sum_box);
            }
            else
            {
                value_5hu.Text = "0";
                v_5hu = 0;
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                if (sum_num == 0)
                    sum_box.Text = "0";
                else
                    Comma_Set(sum_box);
            }
        }

        private void num_1hu_TextChanged(object sender, EventArgs e)
        {
            Comma_Set(num_1hu);
            if (num_1hu.Text != "")
            {
                Comma_Set(num_1hu);
                v_1hu = long.Parse(num_1hu.Text.Replace(",", "")) * 100;
                value_1hu.Text = v_1hu.ToString();
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                Comma_Set(value_1hu);
                Comma_Set(sum_box);
            }
            else
            {
                value_1hu.Text = "0";
                v_1hu = 0;
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                if (sum_num == 0)
                    sum_box.Text = "0";
                else
                    Comma_Set(sum_box);
            }
        }

        private void num_5ten_TextChanged(object sender, EventArgs e)
        {
            Comma_Set(num_5ten);
            if (num_5ten.Text != "")
            {
                Comma_Set(num_5ten);
                v_5ten = long.Parse(num_5ten.Text.Replace(",", "")) * 50;
                value_5ten.Text = v_5ten.ToString();
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                Comma_Set(value_5ten);
                Comma_Set(sum_box);
            }
            else
            {
                value_5ten.Text = "0";
                v_5ten = 0;
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                if (sum_num == 0)
                    sum_box.Text = "0";
                else
                    Comma_Set(sum_box);
            }
        }

        private void num_1ten_TextChanged(object sender, EventArgs e)
        {
            Comma_Set(num_1ten);
            if (num_1ten.Text != "")
            {
                Comma_Set(num_1ten);
                v_1ten = long.Parse(num_1ten.Text.Replace(",", "")) * 10;
                value_1ten.Text = v_1ten.ToString();
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                Comma_Set(value_1ten);
                Comma_Set(sum_box);
            }
            else
            {
                value_1ten.Text = "0";
                v_1ten = 0;
                sum_num = v_50th + v_10th + v_5th + v_1th + v_5hu + v_1hu + v_5ten + v_1ten;
                sum_box.Text = sum_num.ToString();
                if (sum_num == 0)
                    sum_box.Text = "0";
                else
                    Comma_Set(sum_box);
            }
        }

        private void input_box_TextChanged(object sender, EventArgs e)
        {
            Comma_Set(input_box);
            if (input_box.Text != "")
            {
                input_num = long.Parse(input_box.Text.Replace(",", ""));
                sub_box.Text = (sum_num - input_num).ToString();
                Comma_Set(sub_box);
                if ((sum_num - input_num) != 0)
                {
                    checker.Text = "마! 잘 좀 맞춰봐라!";
                }
                else
                {
                    sub_box.Text = "0";
                    checker.Text = "마! 일 좀 잘하네!";
                }
            }
            else
            {
                input_num = 0;
                sub_box.Text = sum_num.ToString();
                Comma_Set(sub_box);
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.IO;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Text.RegularExpressions;

namespace RSA_Application
{
    public partial class Form3 : Form
    {
        public object TextBox1 { get; private set; }

        public Form3()
        {
            InitializeComponent();
        }

        bool isdigit(Control con)
        {
            Regex reExp = new Regex(@"[^\d]");
            string temp = reExp.Replace(con.Text, "");
            if (con.Text == temp) return true;
            else
            {
                con.Text = temp;
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void getRandom()
        {
            int total, randNum1, randNum2;
            bool swap = true;
            FileStream fp = new FileStream("prime_data.txt", FileMode.OpenOrCreate);
            StreamReader rp = new StreamReader(fp);
            total = Convert.ToInt32(rp.ReadLine());
            Random randObj = new Random();
            randNum1 = randObj.Next(total);
            randNum2 = randObj.Next(total);
            while (randNum2 == randNum1) randNum2 = randObj.Next(total);
            if (randNum2 < randNum1)
            {
                randNum2 ^= randNum1;
                randNum1 ^= randNum2;
                randNum2 ^= randNum1;
                swap = !swap;
            }
            for (int i = 0; i < randNum1; i++)
            {
                rp.ReadLine();
            }
            if (swap) textBox1.Text = rp.ReadLine();
            else textBox2.Text = rp.ReadLine();
            for (int i = randNum1 + 1; i < randNum2; i++)
            {
                rp.ReadLine();
            }
            if (swap) textBox2.Text = rp.ReadLine();
            else textBox1.Text = rp.ReadLine();
            rp.Close();
            fp.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getRandom();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (isdigit(textBox1) && isdigit(textBox2))
                {
                    Int64 ans = Convert.ToInt64(textBox1.Text) * Convert.ToInt64(textBox2.Text);
                    textBox3.Text = ans.ToString();
                }
                else
                {
                    isdigit(textBox2);
                    MessageBox.Show("亲，非法输入，文本框只能输入数字", "提示", MessageBoxButtons.OK);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (isdigit(textBox1) && isdigit(textBox2))
                {
                    Int64 ans = (Convert.ToInt64(textBox1.Text) - 1) * (Convert.ToInt64(textBox2.Text) - 1);
                    textBox4.Text = ans.ToString();
                }
                else
                {
                    isdigit(textBox2);
                    MessageBox.Show("亲，非法输入，文本框只能输入数字", "提示", MessageBoxButtons.OK);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total, randNum;
            FileStream fp = new FileStream("prime_data.txt", FileMode.OpenOrCreate);
            StreamReader rp = new StreamReader(fp);
            total = Convert.ToInt32(rp.ReadLine());
            Random randObj = new Random();
            randNum = randObj.Next(total);
            for (int i = 0; i < randNum; i++) rp.ReadLine();
            textBox5.Text = rp.ReadLine();
            rp.Close();
            fp.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (isdigit(textBox5)) textBox6.Text = textBox5.Text + "x+" + textBox4.Text + "y=1";
            else MessageBox.Show("亲，非法输入，文本框只能输入数字", "提示", MessageBoxButtons.OK);
        }

        void expgcd(Int64 a, Int64 b, ref Int64 x, ref Int64 y)
        {
            if (b == 0)
            {
                x = 1;
                y = 0;
                return;
            }
            expgcd(b, a % b, ref x, ref y);
            Int64 t = x;
            x = y;
            y = t - (a / b) * y;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                string str = textBox6.Text;
                str = str.Replace("x+", " ");
                str = str.Replace("y=", " ");
                string[] part = str.Split(' ');
                try
                {
                    Int64 a = Convert.ToInt64(part[0]), b = Convert.ToInt64(part[1]), x = 0, y = 0;
                    expgcd(a, b, ref x, ref y);
                    textBox7.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    Int64 temp = Convert.ToInt64(textBox4.Text);
                    while (x < 0) x = (x + temp) % temp;
                    textBox8.Text = x.ToString();
                }
                catch
                {
                    MessageBox.Show("亲，请检查你输入的表达式哦！", "提示", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox9.Text = "(" + textBox3.Text + "," + textBox5.Text + ")";
            textBox10.Text = "(" + textBox3.Text + "," + textBox8.Text + ")";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox11.Text != "" && textBox5.Text != "")
            {
                if (isdigit(textBox3) && isdigit(textBox11) && isdigit(textBox5))
                {
                    if (textBox4.Text.Length - 1 >= textBox11.Text.Length)
                    {
                        ScriptRuntime pyRumTime = Python.CreateRuntime();
                        dynamic obj = pyRumTime.UseFile("rsa.py");
                        textBox12.Text = obj.demo_cal(textBox11.Text, textBox5.Text, textBox3.Text);
                        textBox11.Text = "";
                    }
                    else MessageBox.Show("输入数字过长，请输入" + (textBox4.Text.Length - 1).ToString() + "位及" + (textBox4.Text.Length - 1).ToString() + "位以下长度的数字", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    isdigit(textBox11);
                    isdigit(textBox5);
                    MessageBox.Show("亲，非法输入，文本框只能输入数字", "提示", MessageBoxButtons.OK);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox12.Text != "" && textBox5.Text != "")
            {
                if (isdigit(textBox3) && isdigit(textBox12) && isdigit(textBox5))
                {
                    ScriptRuntime pyRumTime = Python.CreateRuntime();
                    dynamic obj = pyRumTime.UseFile("rsa.py");
                    textBox11.Text = obj.demo_cal(textBox12.Text, textBox8.Text, textBox3.Text);
                    textBox12.Text = "";
                }
                else
                {
                    isdigit(textBox12);
                    isdigit(textBox5);
                    MessageBox.Show("亲，非法输入，文本框只能输入数字", "提示", MessageBoxButtons.OK);
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (isdigit(textBox4)) textBox6.Text = textBox5.Text + "x+" + textBox4.Text + "y=1";
            else MessageBox.Show("亲，非法输入，文本框只能输入数字", "提示", MessageBoxButtons.OK);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

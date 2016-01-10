using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace RSA_Application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathPubkey = this.folderBrowserDialog1.SelectedPath;
                textBox4.Text = pathPubkey;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("内容不完整，请重新检查所填内容", "提示", MessageBoxButtons.OK);
            }
            else
            {
                string pubkey = textBox2.Text + " " + textBox1.Text;
                string prikey = textBox2.Text + " " + textBox3.Text;
                string outpath;
                if (textBox4.Text != "") outpath = textBox4.Text;
                else outpath = "..";
                FileStream fp = new FileStream(outpath+@"\publicKey.txt",FileMode.Create);
                StreamWriter fpub = new StreamWriter(fp);
                fpub.Write(pubkey);
                fpub.Close();
                fp.Close();
                fp = new FileStream(outpath + @"\privateKey.txt", FileMode.Create);
                StreamWriter fpri = new StreamWriter(fp);
                fpri.Write(prikey);
                fpri.Close();
                fp.Close();
                MessageBox.Show("生成密钥对成功！", "祝贺：", MessageBoxButtons.OK);
                Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

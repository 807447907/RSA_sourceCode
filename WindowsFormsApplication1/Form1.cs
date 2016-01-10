using System;
using System.ComponentModel;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security.Cryptography;


namespace RSA_Application
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.File_input.ShowDialog() == DialogResult.OK)
            {
                string pathInput = this.File_input.FileName;
                textBox_input.Text = pathInput;
                Regex reExp = new Regex(@"\\{1}[^\\]+$", RegexOptions.RightToLeft);
                textBox_output.Text = reExp.Replace(textBox_input.Text, "\\");
            }
            warning.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog_priKey_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox_pub_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_pub_open_Click(object sender, EventArgs e)
        {
            if (this.File_pubKey.ShowDialog() == DialogResult.OK)
            {
                string pathPubkey = this.File_pubKey.FileName;
                textBox_pub.Text = pathPubkey;
            }
        }

        private void button_pri_open_Click(object sender, EventArgs e)
        {
            
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            if (File_save.ShowDialog() == DialogResult.OK)
            {
                string pathOutput = this.File_save.SelectedPath;
                textBox_output.Text = pathOutput;
            }
            warning.Text = "";
        }

        private void textBox_pri_TextChanged(object sender, EventArgs e)
        {

        }

        private void File_input_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_pub_Click(object sender, EventArgs e)
        {
            if (this.File_pubKey.ShowDialog() == DialogResult.OK)
            {
                string pathPubkey = this.File_pubKey.FileName;
                textBox_pub.Text = pathPubkey;
            }
            warning.Text = "";
        }

        private void button_pri_Click(object sender, EventArgs e)
        {
            if (File_priKey.ShowDialog() == DialogResult.OK)
            {
                string pathPrikey = this.File_priKey.FileName;
                textBox_pri.Text = pathPrikey;
            }
            warning.Text = "";
        }

        byte[] keyArray=new byte[32];
        string fileName, outPath;
        void encryptFileName()
        {
            FileStream fp2 = new FileStream("temp_data.txt", FileMode.Create);
            StreamWriter wp = new StreamWriter(fp2);
            for (int i = 0; i < 32; i++) wp.WriteLine(keyArray[i]);
            Regex reExp = new Regex(@"\\{1}[^\\]+$", RegexOptions.RightToLeft);
            string title = reExp.Match(textBox_input.Text).ToString();
            title = title.Remove(0, 1);
            wp.WriteLine(title.Length);
            while (title != "")
            {
                while (title != "")
                {
                    wp.WriteLine(char.ConvertToUtf32(title, 0));
                    title = title.Remove(0, 1);
                }
            }
            wp.Close();
            fp2.Close();
            ScriptRuntime pyRumTime = Python.CreateRuntime();
            dynamic obj = pyRumTime.UseFile("rsa.py");
            obj.ras_pub(textBox_pub.Text, "temp_data.txt", outPath + ".txt");
            File.Delete("temp_data.txt");
        }

        void encryptData()
        {
            byte[] toEncryptArray = File.ReadAllBytes(textBox_input.Text);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            File.WriteAllBytes(outPath + ".dat", resultArray);
            toEncryptArray = null;
            resultArray = null;
        }

        private void button_encode_Click(object sender, EventArgs e)
        {
            if (textBox_pub.Text != "" && textBox_input.Text != "" && textBox_output.Text != "")
            {
                try
                {
                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Start();
                    Random randObj = new Random();
                    randObj.NextBytes(keyArray);
                    fileName=randObj.Next(1 << 30).ToString("X8");
                    outPath = textBox_output.Text + "RSA_" + fileName;
                    Thread t1 = new Thread(encryptFileName);
                    t1.Start();
                    encryptData();
                    sw.Stop();
                    FileInfo fileInfo = new FileInfo(textBox_input.Text);
                    label5.Text = "加密时间：" + (sw.ElapsedMilliseconds / 1000.0).ToString() + "s";
                    label6.Text = "速度：" +Math.Round(((double)fileInfo.Length/1024/1024/sw.ElapsedMilliseconds*1000),2).ToString()+"MB/s";
                    GC.Collect();
                    warning.Text = "亲，祝贺，加密成功了哦~~";
                }
                catch 
                {
                    warning.Text = "亲，您的文件不存在，请重新输入^_^";
                    return;
                }
            }
            else
            {
                warning.Text = "亲，您的输入有误，请重新输入^_^";
            }
        }

        private string str(int actual)
        {
            throw new NotImplementedException();
        }

        private void button_decode_Click(object sender, EventArgs e)
        {
            
            if (textBox_pri.Text!= "" && textBox_input.Text != "" && textBox_output.Text != "")
            {
                try
                {
                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Start();
                    ScriptRuntime pyRumTime = Python.CreateRuntime();
                    dynamic obj = pyRumTime.UseFile("rsa.py");
                    string fileName = textBox_input.Text;
                    fileName=fileName.Remove(fileName.Length - 4);
                    obj.ras_pri(textBox_pri.Text, fileName+".txt", "temp_data.txt");
                    FileStream fp = new FileStream("temp_data.txt", FileMode.Open);
                    StreamReader rp = new StreamReader(fp);
                    byte[] keyArray = new byte[32];
                    for(int i=0;i<32;i++)
                    {
                        keyArray[i] = Convert.ToByte(rp.ReadLine());
                    }
                    int fileNameLen=Convert.ToInt32(rp.ReadLine());
                    string title ="";
                    for (int i = 0; i < fileNameLen; i++) title += char.ConvertFromUtf32(Convert.ToInt32(rp.ReadLine()));
                    rp.Close();
                    fp.Close();
                    byte[] toEncryptArray = File.ReadAllBytes(fileName+".dat");
                    RijndaelManaged rDel = new RijndaelManaged();
                    rDel.Key = keyArray;
                    rDel.Mode = CipherMode.ECB;
                    ICryptoTransform cTransform = rDel.CreateDecryptor();
                    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                    File.WriteAllBytes(textBox_output.Text + title, resultArray);
                    sw.Stop();
                    FileInfo fileInfo = new FileInfo(textBox_input.Text);
                    label5.Text = "加密时间：" + (sw.ElapsedMilliseconds / 1000.0).ToString() + "s";
                    label6.Text = "速度：" + Math.Round(((double)fileInfo.Length / 1024 / 1024 / sw.ElapsedMilliseconds * 1000), 2).ToString() + "MB/s";
                    File.Delete("temp_data.txt");
                    warning.Text = "亲，解密成功了哦~~";
                    GC.Collect();
                }
                catch
                {
                    warning.Text = "亲，您的文件不存在，请重新输入^_^";
                    return;
                }
            }
            else
            {
                warning.Text = "亲，您的输入有误，请重新输入^_^";
            }
        }

        private void File_output_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void File_output_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
        void start_rsatool()
        {
            System.Diagnostics.Process.Start(@"RSATool\RSATool.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(start_rsatool);
            t.Start();
            new Form2().ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UI_Load(object sender, EventArgs e)
        {

        }

        const string dllPath = "prime.dll";
        [DllImport(dllPath, EntryPoint = "prime_produce")]
        public static extern void prime_produce();

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(prime_produce);
            t.Start();
            new Form3().ShowDialog();
            File.Delete("prime_data.txt");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}

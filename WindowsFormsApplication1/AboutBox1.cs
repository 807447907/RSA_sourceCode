using System;
using System.Reflection;
using System.Windows.Forms;

namespace RSA_Application
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            Text = string.Format("关于 {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = string.Format("版本 {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }

        #region 程序集特性访问器

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            textBoxDescription.Text = @"2016.01.04 v3.0
1.采用RSA与AES相结合的技术，在保证同等安全性的基础上，加解密速度提升千倍。
2.增强程序稳定性。
3.将AES密钥与数据分开存放，保证了数据的安全性。
4.引入内存回收机制，节省内存。
5.加入计时函数，显示加/解密时间与实时速度。

2016.01.01 v2.1
1.修复加密数字长度在某些情况下可能溢出的问题。
2.修复输入框允许输入非法内容的问题。

2015.12.31 v2.0
1.增加What is RSA功能，以直观的界面演示如何生成并封装密钥对，并演示RSA加密过程。
2.改进算法，加快运算速度。
3.修复文件最后一个byte输出异常的bug。
4.增加加密文件名与自动恢复文件名的功能。
5.增加多线程运行，加快速度。

2015.12.28 v1.1
1.增加生成密钥功能，使用RSATool生成密钥对，本软件完成封装密钥对。
2.界面改版，以不同颜色区分不同功能，界面更直观，逻辑更清晰。
3.使用C的动态链接库生成质数表，速度更快。

2015.12.26 v1.0
1.本软件基于C#与Python，具有按byte加密文件的功能。
2.本软件支持RSA 32-4096位加密，用户可根据实际情况选择加密等级。";
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

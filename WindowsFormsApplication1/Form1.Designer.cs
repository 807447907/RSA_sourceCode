namespace RSA_Application
{
    partial class UI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.File_pubKey = new System.Windows.Forms.OpenFileDialog();
            this.File_priKey = new System.Windows.Forms.OpenFileDialog();
            this.File_input = new System.Windows.Forms.OpenFileDialog();
            this.textBox_pub = new System.Windows.Forms.TextBox();
            this.button_pub = new System.Windows.Forms.Button();
            this.button_pri = new System.Windows.Forms.Button();
            this.button_encode = new System.Windows.Forms.Button();
            this.button_decode = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_pri = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.File_save = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // File_pubKey
            // 
            this.File_pubKey.DefaultExt = "txt";
            this.File_pubKey.FileName = "publicKey.txt";
            this.File_pubKey.Filter = "*.txt|";
            this.File_pubKey.Title = "选择您的公钥";
            this.File_pubKey.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // File_priKey
            // 
            this.File_priKey.DefaultExt = "txt";
            this.File_priKey.FileName = "privateKey.txt";
            this.File_priKey.Filter = "*.txt|";
            this.File_priKey.Title = "选择您的私钥";
            this.File_priKey.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_priKey_FileOk);
            // 
            // File_input
            // 
            this.File_input.CheckPathExists = false;
            this.File_input.Filter = "所有文件|";
            this.File_input.Title = "选择输出文件";
            this.File_input.FileOk += new System.ComponentModel.CancelEventHandler(this.File_output_FileOk);
            // 
            // textBox_pub
            // 
            this.textBox_pub.Location = new System.Drawing.Point(203, 205);
            this.textBox_pub.Name = "textBox_pub";
            this.textBox_pub.ReadOnly = true;
            this.textBox_pub.Size = new System.Drawing.Size(200, 21);
            this.textBox_pub.TabIndex = 0;
            this.textBox_pub.TextChanged += new System.EventHandler(this.textBox_pub_TextChanged);
            // 
            // button_pub
            // 
            this.button_pub.Location = new System.Drawing.Point(328, 232);
            this.button_pub.Name = "button_pub";
            this.button_pub.Size = new System.Drawing.Size(75, 23);
            this.button_pub.TabIndex = 1;
            this.button_pub.Text = "公钥";
            this.button_pub.UseVisualStyleBackColor = true;
            this.button_pub.Click += new System.EventHandler(this.button_pub_Click);
            // 
            // button_pri
            // 
            this.button_pri.Location = new System.Drawing.Point(571, 232);
            this.button_pri.Name = "button_pri";
            this.button_pri.Size = new System.Drawing.Size(75, 23);
            this.button_pri.TabIndex = 2;
            this.button_pri.Text = "私钥";
            this.button_pri.UseVisualStyleBackColor = true;
            this.button_pri.Click += new System.EventHandler(this.button_pri_Click);
            // 
            // button_encode
            // 
            this.button_encode.BackColor = System.Drawing.Color.LightGreen;
            this.button_encode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_encode.Location = new System.Drawing.Point(546, 277);
            this.button_encode.Name = "button_encode";
            this.button_encode.Size = new System.Drawing.Size(100, 40);
            this.button_encode.TabIndex = 3;
            this.button_encode.Text = "加密文件";
            this.button_encode.UseVisualStyleBackColor = false;
            this.button_encode.Click += new System.EventHandler(this.button_encode_Click);
            // 
            // button_decode
            // 
            this.button_decode.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_decode.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.button_decode.Location = new System.Drawing.Point(546, 338);
            this.button_decode.Name = "button_decode";
            this.button_decode.Size = new System.Drawing.Size(100, 40);
            this.button_decode.TabIndex = 4;
            this.button_decode.Text = "解密文件";
            this.button_decode.UseVisualStyleBackColor = false;
            this.button_decode.Click += new System.EventHandler(this.button_decode_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(119, 296);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.ReadOnly = true;
            this.textBox_input.Size = new System.Drawing.Size(350, 21);
            this.textBox_input.TabIndex = 5;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_pri
            // 
            this.textBox_pri.Location = new System.Drawing.Point(446, 205);
            this.textBox_pri.Name = "textBox_pri";
            this.textBox_pri.ReadOnly = true;
            this.textBox_pri.Size = new System.Drawing.Size(200, 21);
            this.textBox_pri.TabIndex = 6;
            this.textBox_pri.TextChanged += new System.EventHandler(this.textBox_pri_TextChanged);
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(119, 353);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(350, 21);
            this.textBox_output.TabIndex = 7;
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(475, 294);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(38, 23);
            this.button_input.TabIndex = 11;
            this.button_input.Text = "...";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button8_Click);
            // 
            // button_output
            // 
            this.button_output.Location = new System.Drawing.Point(475, 353);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(38, 23);
            this.button_output.TabIndex = 15;
            this.button_output.Text = "...";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.ForeColor = System.Drawing.Color.Orange;
            this.label_title.Location = new System.Drawing.Point(56, 31);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(601, 75);
            this.label_title.TabIndex = 16;
            this.label_title.Text = "RSA 加密解密工具v3.0";
            this.label_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.warning.Location = new System.Drawing.Point(218, 395);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 21);
            this.warning.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "打开文件";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "输出路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(296, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "My Skills：支持RSA32-4096位加密";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(43, 205);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "生成密钥对";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(466, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Powered By LZY";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(57, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 33);
            this.button2.TabIndex = 23;
            this.button2.Text = "What is RSA?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(627, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "版本日志";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(39, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 25;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(39, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 26;
            // 
            // UI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(714, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_pri);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button_decode);
            this.Controls.Add(this.button_encode);
            this.Controls.Add(this.button_pri);
            this.Controls.Add(this.button_pub);
            this.Controls.Add(this.textBox_pub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(730, 480);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA加密解密工具 V3.0";
            this.Load += new System.EventHandler(this.UI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog File_pubKey;
        private System.Windows.Forms.OpenFileDialog File_priKey;
        private System.Windows.Forms.OpenFileDialog File_input;
        private System.Windows.Forms.TextBox textBox_pub;
        private System.Windows.Forms.Button button_pub;
        private System.Windows.Forms.Button button_pri;
        private System.Windows.Forms.Button button_encode;
        private System.Windows.Forms.Button button_decode;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_pri;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog File_save;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


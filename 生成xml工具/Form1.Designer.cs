namespace 生成xml工具
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.labProMun = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBtime = new System.Windows.Forms.NumericUpDown();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBtime)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "点击生成XML文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "保存路径:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "选择路径";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(94, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item个数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "门诊号长度：";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(108, 6);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(125, 27);
            this.txtPatientID.TabIndex = 8;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(343, 10);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(125, 27);
            this.txtDept.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "科室:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(598, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "患者姓名:";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(94, 69);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(125, 27);
            this.txtSex.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "性别:";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(598, 68);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(125, 27);
            this.txtDoctorName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "医生姓名:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(343, 72);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(125, 27);
            this.txtAge.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "年龄:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 41);
            this.button3.TabIndex = 25;
            this.button3.Text = "点击生成json文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "时间间隔：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(526, 313);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 24);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "开启自动生成json文件";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(526, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "剩余时间：";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(616, 279);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(0, 20);
            this.labTime.TabIndex = 31;
            // 
            // labProMun
            // 
            this.labProMun.AutoSize = true;
            this.labProMun.Location = new System.Drawing.Point(616, 192);
            this.labProMun.Name = "labProMun";
            this.labProMun.Size = new System.Drawing.Size(18, 20);
            this.labProMun.TabIndex = 33;
            this.labProMun.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "文件数量：";
            // 
            // tBtime
            // 
            this.tBtime.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tBtime.Location = new System.Drawing.Point(616, 234);
            this.tBtime.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.tBtime.Minimum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.tBtime.Name = "tBtime";
            this.tBtime.Size = new System.Drawing.Size(150, 27);
            this.tBtime.TabIndex = 34;
            this.tBtime.Value = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            // 
            // tBCode
            // 
            this.tBCode.Location = new System.Drawing.Point(598, 121);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(125, 27);
            this.tBCode.TabIndex = 35;
            this.tBCode.Text = "100000";
            this.tBCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCode_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "条码长度: 2X位数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tBCode);
            this.Controls.Add(this.tBtime);
            this.Controls.Add(this.labProMun);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成json-xml文件";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBtime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox txtPatientID;
        private TextBox txtDept;
        private Label label5;
        private TextBox txtName;
        private Label label6;
        private TextBox txtSex;
        private Label label8;
        private TextBox txtDoctorName;
        private Label label4;
        private TextBox txtAge;
        private Label label7;
        private Button button3;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBox1;
        private Label label10;
        private Label labTime;
        private Label labProMun;
        private Label label12;
        private NumericUpDown tBtime;
        private TextBox tBCode;
        private Label label11;
    }
}
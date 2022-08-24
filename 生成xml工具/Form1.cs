using System.Configuration;
using System.Xml;
using Newtonsoft.Json;

namespace 生成xml工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string printDate = DateTime.Now.ToString(format: "yyyy.MM.dd HH:mm:ss");//2022.04.10 14:14:56
        Random rd = new Random();// 随机数
        private void Form1_Load(object sender, EventArgs e)
        {
            #region 初始化数据

            this.textBox1.Text = @"D:\datalab";
            txtPatientID.Text = "2352628";
            txtDept.Text = "体检科";
            txtName.Text = "李德胜";
            txtSex.Text = "男";
            txtAge.Text = "23岁10月";
            txtDoctorName.Text = "吴宗盛";
            comboBox1.Text = "3";
            #endregion

            #region 读取App.config 中的内容

            Console.WriteLine("ConnectionStrings:");
            // ConfigurationManager.ConnectionStrings是一个ConnectionStringSettingsCollection对象
            // 按数字循环得到一个个ConnectionStringSettings对象
            // 每个ConnectionStringSettings对象有Name和ConnectionString属性
            for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count; i++)
            {
                string name = ConfigurationManager.ConnectionStrings[i].Name;
                string connectionString = ConfigurationManager.ConnectionStrings[i].ConnectionString;
                Console.WriteLine(i.ToString() + ". " + name + " = " + connectionString);
            }
            //也可以如下操作，使用ConnectionStringSettings类型来进行foreach遍历
            foreach (ConnectionStringSettings conn in ConfigurationManager.ConnectionStrings)
            {
                string name = conn.Name;
                string connectionString = conn.ConnectionString;
                Console.WriteLine(name + " = " + connectionString);
            }
            //直接获取conn的值
            Console.WriteLine("\r\nGet the value of the node named \"conn\":");
            Console.WriteLine(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            Console.WriteLine("");

            Console.WriteLine("AppSettings:");
            //AppSettings是NameValueConnection类型，使用AllKeys返回一个所有Key组成的字符串数组
            string[] keys = ConfigurationManager.AppSettings.AllKeys;
            for (int i = 0; i < keys.Length; i++)
            {
                string key = keys[i];
                //通过Key来索引Value
                string value = ConfigurationManager.AppSettings[key];
                Console.WriteLine(i.ToString() + ". " + key + " = " + value);
            }
            // 没有NameValuePair这样的对象，所以无法使用foreach来进行循环

            //直接获取key1的值
            Console.WriteLine("\r\nGet the value of the key named \"key1\":");
            Console.WriteLine(ConfigurationManager.AppSettings["key1"]);




            #endregion



        }



        private void button1_Click(object sender, EventArgs e)
        {
            //XML 可扩展的标记语言 ,存储数据
            //注意:1 XML严格区分大小写
            //2 XML的标签成对出现
            //3 XML 有且只有一个根节点
            //通过代码创建XML文档
            //1,引用命名空间

            //2,创建XML文档对象
            XmlDocument doc = new XmlDocument();

            //3,创建第一个行描述信息, 并且添加到doc文档中
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            //4,创建根节点,并将根节点加入到文档中
            XmlElement caseInfors = doc.CreateElement("CaseInfor");
            doc.AppendChild(caseInfors);

            //5,给根节点CaseInfors创建子节点, 并将ResultStatus加入根节点
            XmlElement resultStatus = doc.CreateElement("ResultStatus");
            resultStatus.InnerText = "成功";
            caseInfors.AppendChild(resultStatus);

            //5,给根节点CaseInfors创建子节点, 并将ItemInfor加入根节点
            XmlElement itemInfor = doc.CreateElement("ItemInfor");
            caseInfors.AppendChild(itemInfor);

            // 6, 给ItemInfor添加子节点(BaseInfo 和 ItemList)
            XmlElement baseInfo = doc.CreateElement("BaseInfo");
            itemInfor.AppendChild(baseInfo);

            //7, 给BaseInfo添加子节点
            //GetBaseInfo(doc, baseInfo, "2352628", "小儿科", "罗玺琳", "女", "17岁10个月5天", "2022.04.10 14:14:56", "蒋先红");
            GetBaseInfo(doc, baseInfo, txtPatientID.Text, txtDept.Text, txtName.Text, txtSex.Text, txtAge.Text, printDate, txtDoctorName.Text);

            XmlElement itemList = doc.CreateElement("ItemList");
            itemInfor.AppendChild(itemList);

            int itemLength = int.Parse(comboBox1.Text);
            for (int i = 0; i < itemLength; i++)
            {
                //8.给ItemList 添加子节点(Item,如果有多个Item 就往这里加)
                GetItem(doc, itemList, "020011201" + i, GetRandomColor() + "管", i + "*梅毒螺旋体特异抗体测定（免疫法）" + i, GetRandomSpecimen(), "", "");
            }

            string tims = DateTime.Now.ToString("yyyyMMddHHmmss");
            // 指定你要操作的目录. 
            //string path = @"D:\datalabs";
            string path = this.textBox1.Text;
            try
            {
                // 判断目录是否存在. 
                if (!Directory.Exists(path))
                {
                    // 如果不存在就创建它. 
                    Directory.CreateDirectory(path);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }

            doc.Save(path + "/" + tims + ".xml");
            MessageBox.Show("生成" + tims + ".xml文件成功");

        }


        public string GetRandomColor()
        {

            int i = rd.Next(1, 10); //[1,10)
            switch (i)
            {
                case 1: return "红";
                case 2: return "橙";
                case 3: return "黄";
                case 4: return "绿";
                case 5: return "紫";
                case 6: return "蓝";
                case 7: return "黑";
                case 8: return "灰";
                default: return "白";
            }
        }
        public string GetRandomSpecimen()
        {

            int i = rd.Next(1, 5); //[1,5)
            switch (i)
            {
                case 1: return "全血";
                case 2: return "尿液";
                case 3: return "血清";
                case 4: return "血浆";
                default: return "全血";
            }
        }
        public string GetRandomType()
        {

            int i = rd.Next(1, 5); //[1,5)
            switch (i)
            {
                case 1: return "PCR";
                case 2: return "发光-肿";
                case 3: return "生化";
                case 4: return "免疫";
                default: return "临检";
            }
        }
        public string GetRandomIsInstance()
        {

            int i = rd.Next(0, 2); //[1,5)
            switch (i)
            {
                case 1: return "";
                default: return "0";
            }
        }
        private static void GetData(XmlDocument doc, XmlElement itemList,
            string PatientID, string Dept, string Name, string Sex, string Age, string PrintDate, string Doctor
            , string BARCODE, string TUBECOLOR, string PROJECT, string sampleType, string REPRINT, string emergency
            , string patientType
            )
        {
            XmlElement pitem = doc.CreateElement("returnContent");
            itemList.AppendChild(pitem);

            XmlElement patientID = doc.CreateElement("PatientId");
            patientID.InnerText = PatientID;
            pitem.AppendChild(patientID);

            XmlElement name = doc.CreateElement("PatientName");
            name.InnerText = Name;
            pitem.AppendChild(name);

            XmlElement sex = doc.CreateElement("PatientSex");
            sex.InnerText = Sex;
            pitem.AppendChild(sex);

            XmlElement age = doc.CreateElement("PatientAge");
            age.InnerText = Age;
            pitem.AppendChild(age);

            XmlElement PatientType = doc.CreateElement("PatientType");
            PatientType.InnerText = patientType;
            pitem.AppendChild(PatientType);

            XmlElement barcode = doc.CreateElement("TubeBarcode");
            barcode.InnerText = BARCODE;
            pitem.AppendChild(barcode);

            XmlElement tubeColor = doc.CreateElement("TubeColor");
            tubeColor.InnerText = TUBECOLOR;
            pitem.AppendChild(tubeColor);

            //XmlElement project = doc.CreateElement("Project");
            //project.InnerText = PROJECT;
            //pitem.AppendChild(project);

            XmlElement SampleType = doc.CreateElement("SampleType");
            SampleType.InnerText = sampleType;
            pitem.AppendChild(SampleType);

            XmlElement Mark = doc.CreateElement("Mark");
            Mark.InnerText = "";
            pitem.AppendChild(Mark);

            XmlElement RequestTime = doc.CreateElement("RequestTime");
            RequestTime.InnerText = "";
            pitem.AppendChild(RequestTime);

            XmlElement ExamDepartment = doc.CreateElement("ExamDepartment");
            ExamDepartment.InnerText = "";
            pitem.AppendChild(ExamDepartment);

            XmlElement ReportTime = doc.CreateElement("ReportTime");
            ReportTime.InnerText = "";
            pitem.AppendChild(ReportTime);

            XmlElement Emergency = doc.CreateElement("Emergency");
            Emergency.InnerText = emergency;
            pitem.AppendChild(Emergency);

            XmlElement isInstancy = doc.CreateElement("IsInstancy");
            isInstancy.InnerText = emergency;
            pitem.AppendChild(isInstancy);



            XmlElement dept = doc.CreateElement("RequestDepartMent");
            dept.InnerText = Dept;
            pitem.AppendChild(dept);



            XmlElement printDate = doc.CreateElement("PrintDate");
            printDate.InnerText = PrintDate;
            pitem.AppendChild(printDate);

            XmlElement doctor = doc.CreateElement("Doctor");
            doctor.InnerText = Doctor;
            pitem.AppendChild(doctor);

            XmlElement Items = doc.CreateElement("Items");
            pitem.AppendChild(Items);

            XmlElement Item = doc.CreateElement("Item");
            Items.AppendChild(Item);

            XmlElement ItemId = doc.CreateElement("ItemId");
            ItemId.InnerText = PROJECT;
            Item.AppendChild(ItemId);

            XmlElement ItemName = doc.CreateElement("ItemName");
            ItemName.InnerText = PROJECT;
            Item.AppendChild(ItemName);

            XmlElement ItemShortName = doc.CreateElement("ItemShortName");
            ItemShortName.InnerText = PROJECT;
            Item.AppendChild(ItemShortName);


        }
        private static void GetBaseInfo(XmlDocument doc, XmlElement baseInfo,
            string PatientID, string Dept, string Name, string Sex, string Age, string PrintDate, string Doctor)
        {
            XmlElement patientID = doc.CreateElement("PatientID");
            patientID.InnerText = PatientID;
            baseInfo.AppendChild(patientID);

            XmlElement dept = doc.CreateElement("Dept");
            dept.InnerText = Dept;
            baseInfo.AppendChild(dept);

            XmlElement name = doc.CreateElement("Name");
            name.InnerText = Name;
            baseInfo.AppendChild(name);

            XmlElement sex = doc.CreateElement("Sex");
            sex.InnerText = Sex;
            baseInfo.AppendChild(sex);

            XmlElement age = doc.CreateElement("Age");
            age.InnerText = Age;
            baseInfo.AppendChild(age);

            XmlElement printDate = doc.CreateElement("PrintDate");
            printDate.InnerText = PrintDate;
            baseInfo.AppendChild(printDate);

            XmlElement doctor = doc.CreateElement("Doctor");
            doctor.InnerText = Doctor;
            baseInfo.AppendChild(doctor);
        }

        public void GetItem(XmlDocument doc, XmlElement itemList,
            string BARCODE, string TUBECOLOR, string PROJECT, string SPECIMEN, string REPRINT, string ISINSTANCY)
        {

            XmlElement item = doc.CreateElement("Item");
            itemList.AppendChild(item);

            XmlElement barcode = doc.CreateElement("Barcode");
            barcode.InnerText = BARCODE;
            item.AppendChild(barcode);

            XmlElement tubeColor = doc.CreateElement("TubeColor");
            tubeColor.InnerText = TUBECOLOR;
            item.AppendChild(tubeColor);

            XmlElement project = doc.CreateElement("Project");
            project.InnerText = PROJECT;
            item.AppendChild(project);

            XmlElement specimen = doc.CreateElement("Specimen");
            specimen.InnerText = SPECIMEN;
            item.AppendChild(specimen);

            XmlElement reprint = doc.CreateElement("Reprint");
            reprint.InnerText = REPRINT;
            item.AppendChild(reprint);

            XmlElement isInstancy = doc.CreateElement("IsInstancy");
            isInstancy.InnerText = ISINSTANCY;
            item.AppendChild(isInstancy);
        }


        /// <summary>
        /// 选择路径  的触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            //dialog.SelectedPath = path;
            //dialog.RootFolder = Environment.SpecialFolder.Programs;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                this.textBox1.Text = foldPath;
            }
        }
        //生成json文件
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //2,创建XML文档对象
                XmlDocument doc = new XmlDocument();

                //3,创建第一个行描述信息, 并且添加到doc文档中
                //XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                //doc.AppendChild(dec);

                //4,创建根节点,并将根节点加入到文档中
                XmlElement caseInfors = doc.CreateElement("data");
                doc.AppendChild(caseInfors);

                //5,给根节点CaseInfors创建子节点, 并将ResultStatus加入根节点
                XmlElement resultStatus = doc.CreateElement("code");
                resultStatus.InnerText = "成功";
                caseInfors.AppendChild(resultStatus);

                //5,给根节点CaseInfors创建子节点, 并将ItemInfor加入根节点
                //XmlElement itemInfor = doc.CreateElement("returnContent");
                //caseInfors.AppendChild(itemInfor);

                // 6, 给ItemInfor添加子节点(BaseInfo 和 ItemList)


                //7, 给BaseInfo添加子节点
                //GetBaseInfo(doc, baseInfo, "2352628", "小儿科", "罗玺琳", "女", "17岁10个月5天", "2022.04.10 14:14:56", "蒋先红");

                //XmlElement itemList = doc.CreateElement("returnContent");
                //caseInfors.AppendChild(itemList);

                int itemLength = int.Parse(comboBox1.Text);
                if (checkBox1.Checked == true)
                {
                    itemLength = random(1,10);
                }
                //只随机获取一次的
                string patientId = random(int.Parse(txtPatientID.Text), int.Parse(txtPatientID.Text + 0)).ToString();
                string patientNmae = txtName.Text;
                string patientDept = txtDept.Text;
                string patientSex = txtSex.Text;
                string patientAge = txtAge.Text;
                string doctor = txtDoctorName.Text;
                string printDate = DateTime.Now.ToString(format: "yyyy.MM.dd HH:mm:ss");//2022.04.10 14:14:56
                for (int i = 0; i < itemLength; i++)
                {
                    //随机获取多次
                    string barcode = random(int.Parse(tBCode.Text), int.Parse(tBCode.Text + 0)).ToString() + random(int.Parse(tBCode.Text), int.Parse(tBCode.Text + 0));
                    string tubeColor = GetRandomColor() + "管";
                    string project = "全血五分类;肝功能"+i +"项"+ random(1000,10000);
                    string sampleName = GetRandomSpecimen();
                    string isInstancy = GetRandomIsInstance();//紧急
                    string type = GetRandomType();

                    GetData(doc, caseInfors, patientId, patientDept, patientNmae, patientSex, patientAge
                           , printDate, doctor, barcode, tubeColor, project, sampleName,"", isInstancy,type);
                }
                string tims = DateTime.Now.ToString("yyyyMMddHHmmss");
                // 指定你要操作的目录. 
                //string path = @"D:\datalabs";
                string path = this.textBox1.Text;

                // 判断目录是否存在. 
                if (!Directory.Exists(path))
                {
                    // 如果不存在就创建它. 
                    Directory.CreateDirectory(path);
                }
                string json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
                //doc.Save(path + "/" + tims + ".json");
                //MessageBox.Show("生成" + tims + ".xml文件成功");
                //MessageBox.Show(json);
                WriteJsonFile(json);

            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
        }
        public void WriteJsonFile(string jsonConents)
        {
            try
            {
                string tims = DateTime.Now.ToString("yyyyMMddHHmmss");
                string path = this.textBox1.Text;
                using (FileStream fs = new FileStream(path + "/" + tims + ".json", FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))//要保存的文件夹
                {
                    using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine(jsonConents);
                        labProMun.Text = (1 + int.Parse(labProMun.Text)).ToString();
                        //return Json(new { Result = "成功" });
                    }
                }
            }
            catch (Exception)
            {

                //return Json(new { Result = "失败" });

            }
        }
        //随机数
        public int random(int minvalue,int maxvalue)
        {
            Random r = new Random();
            return r.Next(minvalue, maxvalue);
        }

        public void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)//毫秒
            {
                int times1 = (milliSecond - Math.Abs(Environment.TickCount - start));
                if (times1 < 1000)
                {
                    labTime.Text = "0" + "秒";
                }
                else
                {
                    labTime.Text = times1.ToString().Substring(0, times1.ToString().Length - 3) + "秒";
                }
                Application.DoEvents();//可执行某无聊的操作
            }
        }

        public void Delay1(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)//毫秒
            {
                Application.DoEvents();//可执行某无聊的操作
            }
        }

        int counts1 = 0;
        /// <summary>
        /// 时钟时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //counts1 += 1;
            //int d = 10;
            //int count1 = int.Parse(counts1.ToString()) / d;
            //int times = int.Parse(this.textBox3.Text);
            //int sum = times - count1;
            //label1.Text = "剩余：" + sum.ToString() + "秒";
            Delay(int.Parse(this.tBtime.Text));
            //MessageBox.Show(Delay(int.Parse(this.textBox3.Text)).ToString());
            if (this.checkBox1.Checked == true)
            {
                //生成文件
                button3_Click(null, null);

                //启动定时任务
                //延迟
                Delay1(3000);
                timer1.Stop();
                timer1.Start();
            }
        }
        /// <summary>
        /// 自动生成json文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                labProMun.Text = "0";
                timer1.Start();
            }
            else //(bustr == "关闭自动贴标")
            {
                timer1.Stop();
            }
        }
        //校验
        private void tBCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //阻止从键盘输入键
            e.Handled = true;

            //当输入为0-9的数字、小数点、回车和退格键时不阻止e.KeyChar == '.'||
            if (e.KeyChar >= '0' && e.KeyChar <= '9' ||  e.KeyChar == 13 || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //if (e.KeyChar < 48 || e.KeyChar > 57)

            //{

            //    if (e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 46)

            //    {

            //        MessageBox.Show("警告：必须输入数字！");

            //        tBCode.Focus();

            //        tBCode.SelectAll();

            //        e.KeyChar = '\0';

            //    }

            //}
        }
    }
}
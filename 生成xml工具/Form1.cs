using System.Xml;

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

            this.textBox1.Text = @"D:\ZZDYTM";
            txtPatientID.Text = "2352628";
            txtDept.Text = "小儿科";
            txtName.Text = "罗玺琳";
            txtSex.Text = "女";
            txtAge.Text = "17岁10个月5天";
            txtDoctorName.Text = "蒋先红";
            comboBox1.Text = "3";
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
                GetItem(doc, itemList, "020011201"+i, GetRandomColor()+"管", i+"*梅毒螺旋体特异抗体测定（免疫法）"+i, GetRandomSpecimen(), "", "");
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
            MessageBox.Show("生成"+ tims + ".XML文件成功");

        }


        public string  GetRandomColor()
        {
           
            int i = rd.Next(1, 10); //[1,10)
            switch (i)
            {
                case 1:return "红";
                case 2:return "橙";
                case 3:return "黄";
                case 4:return "绿";
                case 5:return "紫";
                case 6:return "蓝";
                case 7:return "黑";
                case 8:return "灰";
                default:return "白";
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

        private static void GetBaseInfo(XmlDocument doc, XmlElement baseInfo,
            string PatientID,string Dept,string Name,string Sex,string Age,string PrintDate,string Doctor)
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
            string BARCODE,string TUBECOLOR,string PROJECT,string SPECIMEN,string REPRINT,string ISINSTANCY)
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
    }
}
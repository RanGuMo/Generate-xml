using System.Xml;

namespace 生成xml工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



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
            GetBaseInfo(doc, baseInfo);

            XmlElement itemList = doc.CreateElement("ItemList");
            itemInfor.AppendChild(itemList);

            //8.给ItemList 添加子节点(Item,如果有多个Item 就往这里加)
            GetItem(doc, itemList, "0200112012", "紫管", "*梅毒螺旋体特异抗体测定（免疫法）", "全血", "", "");



            DateTime tim = DateTime.Parse(DateTime.Now.ToString());
            string tims = tim.ToString("yyyyMMddHHmmss");
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
            MessageBox.Show("保存成功");

        }

        private static void GetBaseInfo(XmlDocument doc, XmlElement baseInfo)
        {
            XmlElement patientID = doc.CreateElement("PatientID");
            patientID.InnerText = "2352628";
            baseInfo.AppendChild(patientID);

            XmlElement dept = doc.CreateElement("Dept");
            dept.InnerText = "小儿科";
            baseInfo.AppendChild(dept);

            XmlElement name = doc.CreateElement("Name");
            name.InnerText = "罗玺琳";
            baseInfo.AppendChild(name);

            XmlElement sex = doc.CreateElement("Sex");
            sex.InnerText = "罗玺琳";
            baseInfo.AppendChild(sex);

            XmlElement age = doc.CreateElement("Age");
            age.InnerText = "女";
            baseInfo.AppendChild(age);

            XmlElement printDate = doc.CreateElement("PrintDate");
            printDate.InnerText = "2022.04.10 14:14:56";
            baseInfo.AppendChild(printDate);

            XmlElement doctor = doc.CreateElement("Doctor");
            doctor.InnerText = "蒋先红";
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
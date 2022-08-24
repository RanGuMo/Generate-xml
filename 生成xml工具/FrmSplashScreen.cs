using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 生成xml工具
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {

        }

        private void timerProgressbar_Tick(object sender, EventArgs e)
        {
            panelProgressbar.Width += 15;
            if (panelProgressbar.Width>=700)
            {
                this.DialogResult = DialogResult.OK;
                timerProgressbar.Stop();
            }
        }
    }
}

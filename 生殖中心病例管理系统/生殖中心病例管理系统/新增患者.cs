using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace 生殖中心病例管理系统
{
    public partial class 新增患者 : Form
    {
        private mainInterface f1;
        public 新增患者()
        {
            InitializeComponent();
        }
        public 新增患者(mainInterface for1)
        {
            InitializeComponent();
            f1 = for1;
        }

        private void 基本信息_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 196, 231, 239);//设置当前窗体背景颜色
            this.Visible = false;//默认隐藏
            this.TopLevel = false;
        }

        private void date_MouseDown(object sender, MouseEventArgs e)
        {
            女方HIS_textBox.Text = DateTime.Now.ToString("D");//单击显示当前时间
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 新增患者_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.表格_listView.Visible = true;
          
        
           
         }
    }
}

// 属性：背景主色196, 231, 239   英文字体Georgia   中文微软雅黑 


// 修改时间2016年11月29日15:03:01       修改显示日期控件为DateTimePicker(可直接选择日期)
// 修改时间2016年12月1日15:51:49       修改主界面单击隐藏，再次单击出现，新增界面出现在主窗体内部。
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 public  delegate void Mydelegate(bool ss);

namespace 生殖中心病例管理系统
{
    
    public partial class mainInterface : Form
    {
        
        //private void Draw(Graphics graphics, Control control)
        //{
        //    float X = float.Parse(control.Width.ToString()) - 1;
        //    float Y = float.Parse(control.Height.ToString()) - 1;
        //    PointF[] pointfs = {  
        //        new PointF(2,     0),  
        //        new PointF(X-2,   0),  
        //        new PointF(X-1,   1),  
        //        new PointF(X,     2),  
        //        new PointF(X,     Y-2),  
        //        new PointF(X-1,   Y-1),  
        //        new PointF(X-2,   Y),  
        //        new PointF(2,     Y),  
        //        new PointF(1,     Y-1),  
        //        new PointF(0,     Y-2),  
        //        new PointF(0,     2),  
        //        new PointF(1,     1)  
        //        };

        //    GraphicsPath path = new GraphicsPath();
        //    path.AddLines(pointfs);

        //    Pen pen = new Pen(Color.FromArgb(150, Color.Blue), 1);
        //    pen.DashStyle = DashStyle.Solid;
        //    graphics.DrawPath(pen, path);
        //}  
         
     
        // 定义全局变量，防止多次出现同一个窗体
        查询界面 查询界面 = null;
        男方病例form caseOfTheManform = null;
        女方病例 diaoyong = null;
        新增患者 diao = null;
        public mainInterface()
        {
            InitializeComponent();
        }

        // 加载
        private void Form2_Load(object sender, EventArgs e)
        {
            
            panel1.AutoScroll = false;   //关闭滚动条
            //this.查询_but.Size  =病例_but.Size  = this.监测_but. Size  = this.新增_but.Size  =  this.记录单_but.Size  = this.待办_but.Size  =  this.医嘱_but.Size  = this.流程_but.Size  = this.同意书_but. Size  = this.打印_but.Size  = this.扫描_but.Size  =  this.报表_but.Size  = new Size (111,109);
           
          

            //this.查询_but.BackgroundImage = Properties.Resources.查询1;//设置背景图片
            //this.病例_but.BackgroundImage = Properties.Resources.病历1;
            //this.监测_but.BackgroundImage = Properties.Resources.监测;
            //this.新增_but.BackgroundImage = Properties.Resources.新增1;
            //this.记录单_but.BackgroundImage = Properties.Resources.记录单1;
            //this.待办_but.BackgroundImage = Properties.Resources.待办1;
            //this.医嘱_but.BackgroundImage = Properties.Resources.医嘱1;
            //this.流程_but.BackgroundImage = Properties.Resources.流程1;
            //this.同意书_but.BackgroundImage = Properties.Resources.同意书1;
            //this.打印_but.BackgroundImage = Properties.Resources.打印1;
            //this.扫描_but.BackgroundImage = Properties.Resources.扫描2;
            //this.报表_but.BackgroundImage = Properties.Resources.报表;
        
            //pictureBox1.BackgroundImage = Properties.Resources.功能2;//标题图片
            //pictureBox13.BackgroundImage = Properties.Resources.病历信息;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;

          
            this.查询_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4, (panel1.Height - 4 * 查询_but.Height) / 5);//第一排第一个 高度=（容器高度—容器内控件高度）/空为数*需要的空位数+上方控件高度
            this.待办_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 2 + 查询_but.Height, (panel1.Height - 4 * 查询_but.Height) / 5);//
            this.监测_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 3 + 查询_but.Height * 2, (panel1.Height - 4 * 查询_but.Height) / 5);//

            this.新增_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4, (panel1.Height - 4 * 查询_but.Height) / 5 * 2 + 查询_but.Height);//
            this.病例_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 2 + 查询_but.Height, (panel1.Height - 4 * 查询_but.Height) / 5 * 2 + 查询_but.Height);//第二排第一个
            this.流程_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 3 + 查询_but.Height * 2, (panel1.Height - 4 * 查询_but.Height) / 5 * 2 + 查询_but.Height);//第二排第一个

            this.医嘱_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4, (panel1.Height - 4 * 查询_but.Height) / 5 * 3 + 查询_but.Height * 2);//
            this.记录单_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 2 + 查询_but.Height, (panel1.Height - 4 * 查询_but.Height) / 5 * 3 + 查询_but.Height * 2);//
            this.同意书_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 3 + 查询_but.Height * 2, (panel1.Height - 4 * 查询_but.Height) / 5 * 3 + 查询_but.Height * 2);//

            this.打印_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4, (panel1.Height - 4 * 查询_but.Height) / 5 * 4 + 查询_but.Height * 3);//
            this.扫描_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 2 + 查询_but.Height, (panel1.Height - 4 * 查询_but.Height) / 5 * 4 + 查询_but.Height * 3);//
            this.报表_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 3 + 查询_but.Height*2, (panel1.Height - 4 * 查询_but.Height) / 5 * 4 + 查询_but.Height * 3);//
          
           
            this.timer1.Interval = 1000; //时间控件
            this.timer1.Start();
            splitContainer1.SplitterDistance = this.Width / 3;

            pictureBox1 .  Width =   this . Width / 3;// 标题图片的宽度是窗体宽度的1/3
            pictureBox13.Width =  this . Width / 3 * 2;
            //this.BackColor = Color .FromArgb (255,196,231,239 );//设置当前窗体背景颜色
            //splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            //splitContainer2.BorderStyle = BorderStyle.Fixed3D;//设置两个split样式，但是未能解决焦点问题
           
            表格_listView.GridLines = true;//表格是否显示网格线
            表格_listView.FullRowSelect = true;//是否选中整行



            表格_listView.View = View.Details;//设置显示方式
            表格_listView.Scrollable = true;//是否自动显示滚动条
            表格_listView.MultiSelect = false;//是否可以选择多行

            ////添加表头（列）
            //表格_listView.Columns.Add("日期", 160, HorizontalAlignment.Center);
            //表格_listView.Columns.Add("序号", 100, HorizontalAlignment.Center);
            //表格_listView.Columns.Add("病历号", 100, HorizontalAlignment.Center);
            //表格_listView.Columns.Add("姓名", 100, HorizontalAlignment.Center);

            //表格_listView.Columns.Add("年龄", 160, HorizontalAlignment.Center);
            //表格_listView.Columns.Add("职业", 100, HorizontalAlignment.Center);
            //表格_listView.Columns.Add("地址/电话", 100, HorizontalAlignment.Center);
            //表格_listView.Columns.Add("诊断", 100, HorizontalAlignment.Center);

            //表格_listView.Columns.Add("周期", 160, HorizontalAlignment.Center);

            //表格_listView.Columns.Add("护士", 100, HorizontalAlignment.Center);
            //for (int i = 0; i < 10; i++)
            //{
            //    表格_listView.Columns[i].Width = -1;//根据内容设置宽度
            //}
           
            //添加表格内容
            //for (int i = 0; i < 6; i++)
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.SubItems.Clear();

            //    item.SubItems[0].Text = "日期" + i.ToString();
            //    item.SubItems.Add(i.ToString());
            //    item.SubItems.Add((i + 7).ToString());
            //    item.SubItems.Add((i * i).ToString());
            //    listView_CaseRegistration.Items.Add(item);
            //}
            

        }

        //退出事件
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void 女方病例模板_Paint(object sender, PaintEventArgs e)
        {
            //this.女方病例模板 .HorizontalScroll.Visible = true;
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {
          
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            if (diaoyong ==null ||diaoyong .IsDisposed )
            {
                diaoyong = new 女方病例();
            }
            diaoyong.Show();//调用女方病例
        }
      
        
        private void 男方病例_Click(object sender, EventArgs e)
        {

            if (caseOfTheManform   == null || caseOfTheManform .IsDisposed)
            {
                caseOfTheManform = new 男方病例form ();
            }
            caseOfTheManform.Show();//调用男方病例
          
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void mainInterface_Resize(object sender, EventArgs e)
        {
            
           
            pictureBox1.Width = this.Width / 3;// 图片宽度是窗体宽度的1/3
            pictureBox13.Width = this.Width / 3 * 2;
        }

       

        private void 查询_but_Click(object sender, EventArgs e)
        {
            查询_but.Width = 查询_but.Width - 2;
            查询_but.Height   = 查询_but.Height  - 2;
       
            查询_but.Width = 查询_but.Width + 2;
            查询_but.Height = 查询_but.Height + 2;
            if (查询界面 == null || 查询界面.IsDisposed)
            {
                查询界面 = new 查询界面();
            }
            查询界面.Show();//调用查询界面
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            时间_tool.Text = System.DateTime.Now.ToString();
            Application.DoEvents();
        }

        private void 新增_but_Click(object sender, EventArgs e)
        {
            
            //if (diao == null || diao.IsDisposed)
            //{
            //    diao = new 新增患者();
            //    diao.MdiParent = this;
            //    diao.Show();//显示基本信息窗体
            //}
            if (diao == null || diao.IsDisposed)
            {
                  diao =  new 新增患者(this );  
                  diao.TopLevel = false;   //顶级窗体属性false
                  窗体容器_panel.Controls.Add(diao);//添加进Panel
                  diao.Show();//调用 
                  表格_listView.Visible = false;//隐藏表格
                  //pictureBox13.Visible = false;//隐藏上方图片
                  diao.Dock = DockStyle.Fill;   //DOCK 父窗体停靠
            }
           
          
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       void op(bool   s)
    {
        this.表格_listView.Visible=s;
    }

       private void label1_Click(object sender, EventArgs e)
       {
           if (this .label1 .Text =="<")
           {
               splitContainer1.SplitterDistance  = this.Width / 3/3+10;
               this.label1.Text = ">";
               panel1.Width = splitContainer1.Width;
               panel1.AutoScroll = true;  //打开滚动条

               //pictureBox1.BackgroundImage = Properties.Resources.功能1;
               //pictureBox13.BackgroundImage = Properties.Resources.病例信息1 ;


               panel1.AutoScrollMinSize = new Size(10, (10*8 + 扫描_but.Height * 12));
               this.查询_but.Location = new Point(10, 10);//
               this.待办_but.Location = new Point(10,  10*2+扫描_but .Height );//
               this.监测_but.Location = new Point(10, 10 * 3 + 扫描_but.Height * 2);//
               this.新增_but.Location = new Point(10, 10 * 4 + 扫描_but.Height * 3);//
               this.病例_but.Location = new Point(10, 10 * 5 + 扫描_but.Height * 4);//
               this.流程_but.Location = new Point(10, 10 * 6 + 扫描_but.Height * 5);//
               this.医嘱_but.Location = new Point(10, 10 * 7 + 扫描_but.Height * 6);//
               this.记录单_but.Location = new Point(10, 10 * 8 + 扫描_but.Height * 7);//
               this.同意书_but.Location = new Point(10, 10 * 9 + 扫描_but.Height * 8);//
               this.打印_but.Location = new Point(10,   10*10 + 扫描_but.Height * 9);//
               this.扫描_but.Location = new Point(10,  10*11 + 扫描_but.Height * 10);//

               this.报表_but.Location = new Point(10, 10 * 12 + 扫描_but.Height * 11);//

              
           }
           else if (this.label1.Text == ">")
           {
               splitContainer1.SplitterDistance  = this.Width / 3;
               this.label1.Text = "<";
               panel1.Width = splitContainer1.Width;
               panel1.AutoScroll = false;   //关闭滚动条
           
               this.查询_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4, (panel1.Height - 4 * 查询_but.Height) / 5);//第一排第一个 高度=（容器高度—容器内控件高度）/空为数*需要的空位数+上方控件高度
               this.待办_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 2 + 查询_but.Height, (panel1.Height - 4 * 查询_but.Height) / 5);//
               this.监测_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 3 + 查询_but.Height * 2, (panel1.Height - 4 * 查询_but.Height) / 5);//

               this.新增_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4, (panel1.Height - 4 * 查询_but.Height) / 5 * 2 + 查询_but.Height);//
               this.病例_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 2 + 查询_but.Height, (panel1.Height - 4 * 查询_but.Height) / 5 * 2 + 查询_but.Height);//第二排第一个
               this.流程_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 3 + 查询_but.Height * 2, (panel1.Height - 4 * 查询_but.Height) / 5 * 2 + 查询_but.Height);//第二排第一个

               this.医嘱_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4, (panel1.Height - 4 * 查询_but.Height) / 5 * 3 + 查询_but.Height * 2);//
               this.记录单_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 2 + 查询_but.Height, (panel1.Height - 4 * 查询_but.Height) / 5 * 3 + 查询_but.Height * 2);//
               this.同意书_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 3 + 查询_but.Height * 2, (panel1.Height - 4 * 查询_but.Height) / 5 * 3 + 查询_but.Height * 2);//

               this.打印_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4, (panel1.Height - 4 * 查询_but.Height) / 5 * 4 + 查询_but.Height * 3);//
               this.扫描_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 2 + 查询_but.Height, (panel1.Height - 4 * 查询_but.Height) / 5 * 4 + 查询_but.Height * 3);//
               this.报表_but.Location = new Point((this.Width / 3 - 查询_but.Height * 3) / 4 * 3 + 查询_but.Height * 2, (panel1.Height - 4 * 查询_but.Height) / 5 * 4 + 查询_but.Height * 3);//
          
           }
           
       }

       private void textBox1_TextChanged(object sender, EventArgs e)
       {
           
       }

       void textBox1_Paint(object sender, PaintEventArgs e)
       {
         
       }

       private void button1_Click(object sender, EventArgs e)
       {
           caseOfTheManform = new 男方病例form();
           caseOfTheManform.Show();
           diaoyong = new 女方病例();
           diaoyong.Show();
       }

    

      
    }
}

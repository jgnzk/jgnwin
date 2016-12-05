namespace 生殖中心病例管理系统
{
    partial  class mainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "2016"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("01");
            this.状态栏 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.时间_tool = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.窗体容器_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.表格_listView = new System.Windows.Forms.ListView();
            this.登记日期 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.序号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.病历号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.周期 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.诊断 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.诊断方案 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.女方姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.女方年龄 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.男方姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.男方年龄 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.登记护士 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病例ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iUI记录单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.护理记录单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.流程及进度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.打印_but = new System.Windows.Forms.Button();
            this.报表_but = new System.Windows.Forms.Button();
            this.扫描_but = new System.Windows.Forms.Button();
            this.监测_but = new System.Windows.Forms.Button();
            this.医嘱_but = new System.Windows.Forms.Button();
            this.查询_but = new System.Windows.Forms.Button();
            this.同意书_but = new System.Windows.Forms.Button();
            this.新增_but = new System.Windows.Forms.Button();
            this.待办_but = new System.Windows.Forms.Button();
            this.病例_but = new System.Windows.Forms.Button();
            this.记录单_but = new System.Windows.Forms.Button();
            this.流程_but = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.状态栏.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.窗体容器_panel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // 状态栏
            // 
            this.状态栏.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.状态栏.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.时间_tool,
            this.toolStripLabel3});
            this.状态栏.Location = new System.Drawing.Point(0, 629);
            this.状态栏.Name = "状态栏";
            this.状态栏.Size = new System.Drawing.Size(1362, 25);
            this.状态栏.TabIndex = 7;
            this.状态栏.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(274, 22);
            this.toolStripLabel1.Text = "     北京杰格纳科技有限公司（0373-3041935）  ";
            // 
            // 时间_tool
            // 
            this.时间_tool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.时间_tool.Name = "时间_tool";
            this.时间_tool.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel3.Text = "当前时间：";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(1, 10);
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.窗体容器_panel);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox13);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1362, 629);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 9;
            this.splitContainer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.打印_but);
            this.panel1.Controls.Add(this.报表_but);
            this.panel1.Controls.Add(this.扫描_but);
            this.panel1.Controls.Add(this.监测_but);
            this.panel1.Controls.Add(this.医嘱_but);
            this.panel1.Controls.Add(this.查询_but);
            this.panel1.Controls.Add(this.同意书_but);
            this.panel1.Controls.Add(this.新增_but);
            this.panel1.Controls.Add(this.待办_but);
            this.panel1.Controls.Add(this.病例_but);
            this.panel1.Controls.Add(this.记录单_but);
            this.panel1.Controls.Add(this.流程_but);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 562);
            this.panel1.TabIndex = 8;
            // 
            // 窗体容器_panel
            // 
            this.窗体容器_panel.AutoScroll = true;
            this.窗体容器_panel.Controls.Add(this.label1);
            this.窗体容器_panel.Controls.Add(this.表格_listView);
            this.窗体容器_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.窗体容器_panel.Location = new System.Drawing.Point(0, 65);
            this.窗体容器_panel.Name = "窗体容器_panel";
            this.窗体容器_panel.Size = new System.Drawing.Size(882, 562);
            this.窗体容器_panel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "<";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // 表格_listView
            // 
            this.表格_listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.表格_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.登记日期,
            this.序号,
            this.病历号,
            this.周期,
            this.诊断,
            this.诊断方案,
            this.女方姓名,
            this.女方年龄,
            this.男方姓名,
            this.男方年龄,
            this.登记护士});
            this.表格_listView.ContextMenuStrip = this.contextMenuStrip1;
            this.表格_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.表格_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.表格_listView.Location = new System.Drawing.Point(0, 0);
            this.表格_listView.Name = "表格_listView";
            this.表格_listView.Size = new System.Drawing.Size(882, 562);
            this.表格_listView.TabIndex = 3;
            this.表格_listView.UseCompatibleStateImageBehavior = false;
            // 
            // 登记日期
            // 
            this.登记日期.Text = "登记日期";
            // 
            // 序号
            // 
            this.序号.Text = "序号";
            this.序号.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 病历号
            // 
            this.病历号.Text = "病历号";
            // 
            // 周期
            // 
            this.周期.Text = "周期";
            this.周期.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 诊断
            // 
            this.诊断.Text = "诊断";
            this.诊断.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 诊断方案
            // 
            this.诊断方案.Text = "诊断方案";
            this.诊断方案.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 女方年龄
            // 
            this.女方年龄.Text = "女方年龄";
            this.女方年龄.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 男方姓名
            // 
            this.男方姓名.Text = "男方姓名";
            // 
            // 男方年龄
            // 
            this.男方年龄.Text = "男方年龄";
            this.男方年龄.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 登记护士
            // 
            this.登记护士.Text = "登记护士";
            this.登记护士.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.详细信息ToolStripMenuItem,
            this.病例ToolStripMenuItem,
            this.病例ToolStripMenuItem1,
            this.iUI记录单ToolStripMenuItem,
            this.护理记录单ToolStripMenuItem,
            this.流程及进度ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 136);
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            // 
            // 病例ToolStripMenuItem
            // 
            this.病例ToolStripMenuItem.Name = "病例ToolStripMenuItem";
            this.病例ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.病例ToolStripMenuItem.Text = " 病  例";
            // 
            // 病例ToolStripMenuItem1
            // 
            this.病例ToolStripMenuItem1.Name = "病例ToolStripMenuItem1";
            this.病例ToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.病例ToolStripMenuItem1.Text = " 病 例";
            // 
            // iUI记录单ToolStripMenuItem
            // 
            this.iUI记录单ToolStripMenuItem.Name = "iUI记录单ToolStripMenuItem";
            this.iUI记录单ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.iUI记录单ToolStripMenuItem.Text = "IUI工作记录";
            // 
            // 护理记录单ToolStripMenuItem
            // 
            this.护理记录单ToolStripMenuItem.Name = "护理记录单ToolStripMenuItem";
            this.护理记录单ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.护理记录单ToolStripMenuItem.Text = " 护理记录单";
            // 
            // 流程及进度ToolStripMenuItem
            // 
            this.流程及进度ToolStripMenuItem.Name = "流程及进度ToolStripMenuItem";
            this.流程及进度ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.流程及进度ToolStripMenuItem.Text = "流程及进度";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.新增患者;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(132, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "  ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // 打印_but
            // 
            this.打印_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.打印_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.打印1;
            this.打印_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.打印_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.打印_but.Location = new System.Drawing.Point(29, 432);
            this.打印_but.Name = "打印_but";
            this.打印_but.Size = new System.Drawing.Size(111, 109);
            this.打印_but.TabIndex = 1;
            this.打印_but.Text = "   ";
            this.打印_but.UseVisualStyleBackColor = true;
            // 
            // 报表_but
            // 
            this.报表_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.报表_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.报表;
            this.报表_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.报表_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.报表_but.Location = new System.Drawing.Point(322, 431);
            this.报表_but.Name = "报表_but";
            this.报表_but.Size = new System.Drawing.Size(111, 109);
            this.报表_but.TabIndex = 2;
            this.报表_but.Text = "   ";
            this.报表_but.UseVisualStyleBackColor = true;
            // 
            // 扫描_but
            // 
            this.扫描_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.扫描_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.扫描2;
            this.扫描_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.扫描_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.扫描_but.Location = new System.Drawing.Point(177, 432);
            this.扫描_but.Name = "扫描_but";
            this.扫描_but.Size = new System.Drawing.Size(111, 109);
            this.扫描_but.TabIndex = 2;
            this.扫描_but.Text = "   ";
            this.扫描_but.UseVisualStyleBackColor = true;
            // 
            // 监测_but
            // 
            this.监测_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.监测_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.检测;
            this.监测_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.监测_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.监测_but.Location = new System.Drawing.Point(322, 20);
            this.监测_but.Name = "监测_but";
            this.监测_but.Size = new System.Drawing.Size(111, 109);
            this.监测_but.TabIndex = 8;
            this.监测_but.Text = "   ";
            this.监测_but.UseVisualStyleBackColor = true;
            // 
            // 医嘱_but
            // 
            this.医嘱_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.医嘱_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.医嘱1;
            this.医嘱_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.医嘱_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.医嘱_but.Location = new System.Drawing.Point(29, 296);
            this.医嘱_but.Name = "医嘱_but";
            this.医嘱_but.Size = new System.Drawing.Size(111, 109);
            this.医嘱_but.TabIndex = 7;
            this.医嘱_but.Text = "   ";
            this.医嘱_but.UseVisualStyleBackColor = true;
            // 
            // 查询_but
            // 
            this.查询_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.查询_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.查询1;
            this.查询_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.查询_but.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.查询_but.FlatAppearance.BorderSize = 2;
            this.查询_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.查询_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.查询_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.查询_but.Location = new System.Drawing.Point(29, 20);
            this.查询_but.Name = "查询_but";
            this.查询_but.Size = new System.Drawing.Size(111, 109);
            this.查询_but.TabIndex = 0;
            this.查询_but.Text = "   ";
            this.查询_but.UseVisualStyleBackColor = true;
            this.查询_but.Click += new System.EventHandler(this.查询_but_Click);
            // 
            // 同意书_but
            // 
            this.同意书_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.同意书_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.同意书1;
            this.同意书_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.同意书_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.同意书_but.Location = new System.Drawing.Point(322, 299);
            this.同意书_but.Name = "同意书_but";
            this.同意书_but.Size = new System.Drawing.Size(111, 109);
            this.同意书_but.TabIndex = 4;
            this.同意书_but.Text = "   ";
            this.同意书_but.UseVisualStyleBackColor = true;
            // 
            // 新增_but
            // 
            this.新增_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.新增_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.新增1;
            this.新增_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.新增_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.新增_but.Location = new System.Drawing.Point(29, 161);
            this.新增_but.Name = "新增_but";
            this.新增_but.Size = new System.Drawing.Size(111, 109);
            this.新增_but.TabIndex = 3;
            this.新增_but.Text = "   ";
            this.新增_but.UseVisualStyleBackColor = true;
            this.新增_but.Click += new System.EventHandler(this.新增_but_Click);
            // 
            // 待办_but
            // 
            this.待办_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.待办_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.待办2;
            this.待办_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.待办_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.待办_but.Location = new System.Drawing.Point(177, 20);
            this.待办_but.Name = "待办_but";
            this.待办_but.Size = new System.Drawing.Size(111, 109);
            this.待办_but.TabIndex = 10;
            this.待办_but.Text = "   ";
            this.待办_but.UseVisualStyleBackColor = true;
            // 
            // 病例_but
            // 
            this.病例_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.病例_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.病历2;
            this.病例_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.病例_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.病例_but.Location = new System.Drawing.Point(177, 161);
            this.病例_but.Name = "病例_but";
            this.病例_but.Size = new System.Drawing.Size(111, 109);
            this.病例_but.TabIndex = 6;
            this.病例_but.Text = "   ";
            this.病例_but.UseVisualStyleBackColor = true;
            // 
            // 记录单_but
            // 
            this.记录单_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.记录单_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.记录单2;
            this.记录单_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.记录单_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.记录单_but.Location = new System.Drawing.Point(177, 296);
            this.记录单_but.Name = "记录单_but";
            this.记录单_but.Size = new System.Drawing.Size(111, 109);
            this.记录单_but.TabIndex = 5;
            this.记录单_but.Text = "   ";
            this.记录单_but.UseVisualStyleBackColor = true;
            // 
            // 流程_but
            // 
            this.流程_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.流程_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.流程2;
            this.流程_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.流程_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.流程_but.Location = new System.Drawing.Point(322, 164);
            this.流程_but.Name = "流程_but";
            this.流程_but.Size = new System.Drawing.Size(111, 109);
            this.流程_but.TabIndex = 9;
            this.流程_but.Text = "   ";
            this.流程_but.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pictureBox1.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.功能11;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 65);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pictureBox13.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.病历信息1;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox13.Location = new System.Drawing.Point(0, 0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(882, 65);
            this.pictureBox13.TabIndex = 4;
            this.pictureBox13.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.新增周期方案;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(132, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 57);
            this.button2.TabIndex = 11;
            this.button2.Text = "  ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1362, 654);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.状态栏);
            this.IsMdiContainer = true;
            this.Name = "mainInterface";
            this.Text = "生殖中心病历管理系统      授权用户：新乡市中心医院生殖医疗中心（1.1.1.1）";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.mainInterface_Resize);
            this.状态栏.ResumeLayout(false);
            this.状态栏.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.窗体容器_panel.ResumeLayout(false);
            this.窗体容器_panel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip 状态栏;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel 时间_tool;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button 扫描_but;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button 查询_but;
        private System.Windows.Forms.Button 新增_but;
        private System.Windows.Forms.Button 病例_but;
        private System.Windows.Forms.Button 打印_but;
        private System.Windows.Forms.Button 流程_but;
        private System.Windows.Forms.Button 记录单_but;
        private System.Windows.Forms.Button 待办_but;
        private System.Windows.Forms.Button 同意书_but;
        private System.Windows.Forms.Button 医嘱_but;
        private System.Windows.Forms.Button 监测_but;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Panel 窗体容器_panel;
        public System.Windows.Forms.ListView 表格_listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button 报表_but;
        private System.Windows.Forms.ColumnHeader 登记日期;
        private System.Windows.Forms.ColumnHeader 序号;
        private System.Windows.Forms.ColumnHeader 病历号;
        private System.Windows.Forms.ColumnHeader 周期;
        private System.Windows.Forms.ColumnHeader 诊断;
        private System.Windows.Forms.ColumnHeader 诊断方案;
        private System.Windows.Forms.ColumnHeader 女方姓名;
        private System.Windows.Forms.ColumnHeader 女方年龄;
        private System.Windows.Forms.ColumnHeader 男方姓名;
        private System.Windows.Forms.ColumnHeader 男方年龄;
        private System.Windows.Forms.ColumnHeader 登记护士;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病例ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iUI记录单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 护理记录单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 流程及进度ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;


    }
}
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
            this.状态栏 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.时间_tool = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.扫描_but = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.查询_but = new System.Windows.Forms.Button();
            this.新增_but = new System.Windows.Forms.Button();
            this.病例_but = new System.Windows.Forms.Button();
            this.打印_but = new System.Windows.Forms.Button();
            this.流程_but = new System.Windows.Forms.Button();
            this.记录单_but = new System.Windows.Forms.Button();
            this.待办_but = new System.Windows.Forms.Button();
            this.同意书_but = new System.Windows.Forms.Button();
            this.医嘱_but = new System.Windows.Forms.Button();
            this.监测_but = new System.Windows.Forms.Button();
            this.窗体容器_panel = new System.Windows.Forms.Panel();
            this.表格_listView = new System.Windows.Forms.ListView();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.状态栏.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.窗体容器_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 9;
            this.splitContainer1.TabStop = false;
            // 
            // 扫描_but
            // 
            this.扫描_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.扫描_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.扫描;
            this.扫描_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.扫描_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.扫描_but.Location = new System.Drawing.Point(296, 19);
            this.扫描_but.Name = "扫描_but";
            this.扫描_but.Size = new System.Drawing.Size(131, 129);
            this.扫描_but.TabIndex = 2;
            this.扫描_but.Text = "   ";
            this.扫描_but.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(167)))), ((int)(((byte)(186)))));
            this.pictureBox1.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.功能;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 65);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // 查询_but
            // 
            this.查询_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.查询_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.查询;
            this.查询_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.查询_but.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.查询_but.FlatAppearance.BorderSize = 2;
            this.查询_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.查询_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.查询_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.查询_but.Location = new System.Drawing.Point(22, 19);
            this.查询_but.Name = "查询_but";
            this.查询_but.Size = new System.Drawing.Size(131, 129);
            this.查询_but.TabIndex = 0;
            this.查询_but.Text = "   ";
            this.查询_but.UseVisualStyleBackColor = true;
            this.查询_but.Click += new System.EventHandler(this.查询_but_Click);
            // 
            // 新增_but
            // 
            this.新增_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.新增_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.新增;
            this.新增_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.新增_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.新增_but.Location = new System.Drawing.Point(22, 154);
            this.新增_but.Name = "新增_but";
            this.新增_but.Size = new System.Drawing.Size(131, 129);
            this.新增_but.TabIndex = 3;
            this.新增_but.Text = "   ";
            this.新增_but.UseVisualStyleBackColor = true;
            this.新增_but.Click += new System.EventHandler(this.新增_but_Click);
            // 
            // 病例_but
            // 
            this.病例_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.病例_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.病历;
            this.病例_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.病例_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.病例_but.Location = new System.Drawing.Point(22, 289);
            this.病例_but.Name = "病例_but";
            this.病例_but.Size = new System.Drawing.Size(131, 129);
            this.病例_but.TabIndex = 6;
            this.病例_but.Text = "   ";
            this.病例_but.UseVisualStyleBackColor = true;
            // 
            // 打印_but
            // 
            this.打印_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.打印_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.打印;
            this.打印_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.打印_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.打印_but.Location = new System.Drawing.Point(159, 19);
            this.打印_but.Name = "打印_but";
            this.打印_but.Size = new System.Drawing.Size(131, 129);
            this.打印_but.TabIndex = 1;
            this.打印_but.Text = "   ";
            this.打印_but.UseVisualStyleBackColor = true;
            // 
            // 流程_but
            // 
            this.流程_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.流程_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.流程;
            this.流程_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.流程_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.流程_but.Location = new System.Drawing.Point(22, 424);
            this.流程_but.Name = "流程_but";
            this.流程_but.Size = new System.Drawing.Size(131, 129);
            this.流程_but.TabIndex = 9;
            this.流程_but.Text = "   ";
            this.流程_but.UseVisualStyleBackColor = true;
            // 
            // 记录单_but
            // 
            this.记录单_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.记录单_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.记录单;
            this.记录单_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.记录单_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.记录单_but.Location = new System.Drawing.Point(296, 154);
            this.记录单_but.Name = "记录单_but";
            this.记录单_but.Size = new System.Drawing.Size(131, 129);
            this.记录单_but.TabIndex = 5;
            this.记录单_but.Text = "   ";
            this.记录单_but.UseVisualStyleBackColor = true;
            // 
            // 待办_but
            // 
            this.待办_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.待办_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.待办;
            this.待办_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.待办_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.待办_but.Location = new System.Drawing.Point(159, 424);
            this.待办_but.Name = "待办_but";
            this.待办_but.Size = new System.Drawing.Size(131, 129);
            this.待办_but.TabIndex = 10;
            this.待办_but.Text = "   ";
            this.待办_but.UseVisualStyleBackColor = true;
            // 
            // 同意书_but
            // 
            this.同意书_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.同意书_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.同意书;
            this.同意书_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.同意书_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.同意书_but.Location = new System.Drawing.Point(159, 154);
            this.同意书_but.Name = "同意书_but";
            this.同意书_but.Size = new System.Drawing.Size(131, 129);
            this.同意书_but.TabIndex = 4;
            this.同意书_but.Text = "   ";
            this.同意书_but.UseVisualStyleBackColor = true;
            // 
            // 医嘱_but
            // 
            this.医嘱_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.医嘱_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.医嘱;
            this.医嘱_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.医嘱_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.医嘱_but.Location = new System.Drawing.Point(159, 289);
            this.医嘱_but.Name = "医嘱_but";
            this.医嘱_but.Size = new System.Drawing.Size(131, 129);
            this.医嘱_but.TabIndex = 7;
            this.医嘱_but.Text = "   ";
            this.医嘱_but.UseVisualStyleBackColor = true;
            // 
            // 监测_but
            // 
            this.监测_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.监测_but.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.检测;
            this.监测_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.监测_but.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.监测_but.Location = new System.Drawing.Point(296, 289);
            this.监测_but.Name = "监测_but";
            this.监测_but.Size = new System.Drawing.Size(131, 129);
            this.监测_but.TabIndex = 8;
            this.监测_but.Text = "   ";
            this.监测_but.UseVisualStyleBackColor = true;
            // 
            // 窗体容器_panel
            // 
            this.窗体容器_panel.AutoScroll = true;
            this.窗体容器_panel.Controls.Add(this.label1);
            this.窗体容器_panel.Controls.Add(this.表格_listView);
            this.窗体容器_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.窗体容器_panel.Location = new System.Drawing.Point(0, 65);
            this.窗体容器_panel.Name = "窗体容器_panel";
            this.窗体容器_panel.Size = new System.Drawing.Size(899, 562);
            this.窗体容器_panel.TabIndex = 5;
            // 
            // 表格_listView
            // 
            this.表格_listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.表格_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.表格_listView.Location = new System.Drawing.Point(0, 0);
            this.表格_listView.Name = "表格_listView";
            this.表格_listView.Size = new System.Drawing.Size(899, 562);
            this.表格_listView.TabIndex = 3;
            this.表格_listView.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(167)))), ((int)(((byte)(186)))));
            this.pictureBox13.BackgroundImage = global::生殖中心病例管理系统.Properties.Resources.功能;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox13.Location = new System.Drawing.Point(0, 0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(899, 65);
            this.pictureBox13.TabIndex = 4;
            this.pictureBox13.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "<";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.打印_but);
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
            this.panel1.Size = new System.Drawing.Size(458, 562);
            this.panel1.TabIndex = 8;
            // 
            // mainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.窗体容器_panel.ResumeLayout(false);
            this.窗体容器_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel1.ResumeLayout(false);
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


    }
}
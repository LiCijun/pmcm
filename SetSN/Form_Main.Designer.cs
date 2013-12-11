namespace SetSN
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.lDeviceStatus = new System.Windows.Forms.Label();
            this.lConnectStatus = new System.Windows.Forms.Label();
            this.textBox_MSN = new System.Windows.Forms.TextBox();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户申请ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印预览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加型号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除型号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.掌机型号查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.箱号查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.序列号查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.授权码查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日期查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lDeviceStatus
            // 
            this.lDeviceStatus.AutoSize = true;
            this.lDeviceStatus.BackColor = System.Drawing.Color.Red;
            this.lDeviceStatus.Font = new System.Drawing.Font("宋体", 22F);
            this.lDeviceStatus.Location = new System.Drawing.Point(7, 445);
            this.lDeviceStatus.Name = "lDeviceStatus";
            this.lDeviceStatus.Size = new System.Drawing.Size(103, 30);
            this.lDeviceStatus.TabIndex = 2;
            this.lDeviceStatus.Text = "无设备";
            // 
            // lConnectStatus
            // 
            this.lConnectStatus.AutoSize = true;
            this.lConnectStatus.BackColor = System.Drawing.Color.Red;
            this.lConnectStatus.Font = new System.Drawing.Font("宋体", 22F);
            this.lConnectStatus.Location = new System.Drawing.Point(247, 445);
            this.lConnectStatus.Name = "lConnectStatus";
            this.lConnectStatus.Size = new System.Drawing.Size(103, 30);
            this.lConnectStatus.TabIndex = 3;
            this.lConnectStatus.Text = "未连接";
            // 
            // textBox_MSN
            // 
            this.textBox_MSN.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_MSN.Location = new System.Drawing.Point(7, 366);
            this.textBox_MSN.MaxLength = 14;
            this.textBox_MSN.Name = "textBox_MSN";
            this.textBox_MSN.Size = new System.Drawing.Size(342, 50);
            this.textBox_MSN.TabIndex = 1;
            this.textBox_MSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MSN_KeyDown);
            // 
            // textBox_SN
            // 
            this.textBox_SN.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_SN.Location = new System.Drawing.Point(7, 265);
            this.textBox_SN.MaxLength = 16;
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(342, 50);
            this.textBox_SN.TabIndex = 0;
            this.textBox_SN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SN_KeyDown);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.ItemHeight = 37;
            this.comboBox_Type.Items.AddRange(new object[] {
            "K36掌机",
            "K25全能终端",
            "P31全能终端",
            "P31抄表终端",
            "P31用电检查终端",
            "P31计量维护终端",
            "P31应急处理终端",
            "P38"});
            this.comboBox_Type.Location = new System.Drawing.Point(8, 170);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(341, 45);
            this.comboBox_Type.TabIndex = 5;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "序列号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "授权码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "型号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Salmon;
            this.label6.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 33);
            this.label6.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(10, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 50);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "箱号";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户登录ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.参数设置ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户登录ToolStripMenuItem
            // 
            this.用户登录ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.用户登录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员登录ToolStripMenuItem,
            this.操作员登录ToolStripMenuItem,
            this.用户申请ToolStripMenuItem,
            this.用户注销ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.用户登录ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.用户登录ToolStripMenuItem.Name = "用户登录ToolStripMenuItem";
            this.用户登录ToolStripMenuItem.Size = new System.Drawing.Size(149, 23);
            this.用户登录ToolStripMenuItem.Text = "       用户登录          ";
            this.用户登录ToolStripMenuItem.Click += new System.EventHandler(this.用户登录ToolStripMenuItem_Click);
            // 
            // 管理员登录ToolStripMenuItem
            // 
            this.管理员登录ToolStripMenuItem.AutoSize = false;
            this.管理员登录ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.管理员登录ToolStripMenuItem.Name = "管理员登录ToolStripMenuItem";
            this.管理员登录ToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.管理员登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.管理员登录ToolStripMenuItem.Text = "管理员登录";
            this.管理员登录ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // 操作员登录ToolStripMenuItem
            // 
            this.操作员登录ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.操作员登录ToolStripMenuItem.Name = "操作员登录ToolStripMenuItem";
            this.操作员登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.操作员登录ToolStripMenuItem.Text = "操作员登录";
            // 
            // 用户申请ToolStripMenuItem
            // 
            this.用户申请ToolStripMenuItem.Name = "用户申请ToolStripMenuItem";
            this.用户申请ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.用户申请ToolStripMenuItem.Text = "用户申请";
            // 
            // 用户注销ToolStripMenuItem
            // 
            this.用户注销ToolStripMenuItem.Name = "用户注销ToolStripMenuItem";
            this.用户注销ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.用户注销ToolStripMenuItem.Text = "用户注销";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.页面设置ToolStripMenuItem,
            this.打印预览ToolStripMenuItem,
            this.打印ToolStripMenuItem1});
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(139, 23);
            this.打印ToolStripMenuItem.Text = "       打印               ";
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.页面设置ToolStripMenuItem.Text = "页面设置";
            // 
            // 打印预览ToolStripMenuItem
            // 
            this.打印预览ToolStripMenuItem.Name = "打印预览ToolStripMenuItem";
            this.打印预览ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.打印预览ToolStripMenuItem.Text = "打印预览";
            // 
            // 打印ToolStripMenuItem1
            // 
            this.打印ToolStripMenuItem1.Name = "打印ToolStripMenuItem1";
            this.打印ToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.打印ToolStripMenuItem1.Text = "打印";
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加型号ToolStripMenuItem,
            this.删除型号ToolStripMenuItem,
            this.更改参数ToolStripMenuItem});
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(137, 23);
            this.参数设置ToolStripMenuItem.Text = "       参数设置       ";
            // 
            // 添加型号ToolStripMenuItem
            // 
            this.添加型号ToolStripMenuItem.Name = "添加型号ToolStripMenuItem";
            this.添加型号ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.添加型号ToolStripMenuItem.Text = "添加型号";
            // 
            // 删除型号ToolStripMenuItem
            // 
            this.删除型号ToolStripMenuItem.Name = "删除型号ToolStripMenuItem";
            this.删除型号ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.删除型号ToolStripMenuItem.Text = "删除型号";
            // 
            // 更改参数ToolStripMenuItem
            // 
            this.更改参数ToolStripMenuItem.Name = "更改参数ToolStripMenuItem";
            this.更改参数ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.更改参数ToolStripMenuItem.Text = "更改参数";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.掌机型号查询ToolStripMenuItem,
            this.箱号查询ToolStripMenuItem,
            this.序列号查询ToolStripMenuItem,
            this.授权码查询ToolStripMenuItem,
            this.用户查询ToolStripMenuItem,
            this.日期查询ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(155, 23);
            this.查询ToolStripMenuItem.Text = "       查询                   ";
            // 
            // 掌机型号查询ToolStripMenuItem
            // 
            this.掌机型号查询ToolStripMenuItem.Name = "掌机型号查询ToolStripMenuItem";
            this.掌机型号查询ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.掌机型号查询ToolStripMenuItem.Text = "型号查询";
            // 
            // 箱号查询ToolStripMenuItem
            // 
            this.箱号查询ToolStripMenuItem.Name = "箱号查询ToolStripMenuItem";
            this.箱号查询ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.箱号查询ToolStripMenuItem.Text = "箱号查询";
            // 
            // 序列号查询ToolStripMenuItem
            // 
            this.序列号查询ToolStripMenuItem.Name = "序列号查询ToolStripMenuItem";
            this.序列号查询ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.序列号查询ToolStripMenuItem.Text = "序列号查询";
            // 
            // 授权码查询ToolStripMenuItem
            // 
            this.授权码查询ToolStripMenuItem.Name = "授权码查询ToolStripMenuItem";
            this.授权码查询ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.授权码查询ToolStripMenuItem.Text = "授权码查询";
            // 
            // 用户查询ToolStripMenuItem
            // 
            this.用户查询ToolStripMenuItem.Name = "用户查询ToolStripMenuItem";
            this.用户查询ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.用户查询ToolStripMenuItem.Text = "用户查询";
            // 
            // 日期查询ToolStripMenuItem
            // 
            this.日期查询ToolStripMenuItem.Name = "日期查询ToolStripMenuItem";
            this.日期查询ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.日期查询ToolStripMenuItem.Text = "日期查询";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助文档ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(139, 23);
            this.帮助ToolStripMenuItem.Text = "       帮助               ";
            // 
            // 帮助文档ToolStripMenuItem
            // 
            this.帮助文档ToolStripMenuItem.Name = "帮助文档ToolStripMenuItem";
            this.帮助文档ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.帮助文档ToolStripMenuItem.Text = "帮助文档";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.关于ToolStripMenuItem.Text = "关于 ...";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.textBox_SN);
            this.Controls.Add(this.textBox_MSN);
            this.Controls.Add(this.lConnectStatus);
            this.Controls.Add(this.lDeviceStatus);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置掌机序列号";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDeviceStatus;
        private System.Windows.Forms.Label lConnectStatus;
        private System.Windows.Forms.TextBox textBox_MSN;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作员登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户申请ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加型号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除型号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 掌机型号查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 箱号查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 序列号查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 授权码查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日期查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}


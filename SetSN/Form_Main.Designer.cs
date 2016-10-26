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
            this.comboBoxDeviceType = new System.Windows.Forms.ComboBox();
            this.comboBoxFunID = new System.Windows.Forms.ComboBox();
            this.comboBoxFunMask = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.comboBoxHardVersion = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxFun = new System.Windows.Forms.ComboBox();
            this.comboBoxCheckItem = new System.Windows.Forms.ComboBox();
            this.buttonFunCheckItem = new System.Windows.Forms.Button();
            this.textBoxFunValue = new System.Windows.Forms.TextBox();
            this.buttonAddFunList = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCloneDeviceType = new System.Windows.Forms.Button();
            this.tabControlHHU = new System.Windows.Forms.TabControl();
            this.tabPageHHUType = new System.Windows.Forms.TabPage();
            this.tabPageAuth = new System.Windows.Forms.TabPage();
            this.buttonAuthAdd = new System.Windows.Forms.Button();
            this.comboBoxRoleItem = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonGetAllType = new System.Windows.Forms.Button();
            this.tabControlHHU.SuspendLayout();
            this.tabPageHHUType.SuspendLayout();
            this.tabPageAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDeviceType
            // 
            this.comboBoxDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBoxDeviceType.FormattingEnabled = true;
            this.comboBoxDeviceType.Location = new System.Drawing.Point(6, 6);
            this.comboBoxDeviceType.Name = "comboBoxDeviceType";
            this.comboBoxDeviceType.Size = new System.Drawing.Size(434, 27);
            this.comboBoxDeviceType.TabIndex = 0;
            this.comboBoxDeviceType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeviceType_SelectedIndexChanged);
            // 
            // comboBoxFunID
            // 
            this.comboBoxFunID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunID.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBoxFunID.FormattingEnabled = true;
            this.comboBoxFunID.Location = new System.Drawing.Point(0, 42);
            this.comboBoxFunID.Name = "comboBoxFunID";
            this.comboBoxFunID.Size = new System.Drawing.Size(295, 29);
            this.comboBoxFunID.TabIndex = 0;
            this.comboBoxFunID.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunID_SelectedIndexChanged);
            // 
            // comboBoxFunMask
            // 
            this.comboBoxFunMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunMask.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBoxFunMask.FormattingEnabled = true;
            this.comboBoxFunMask.Location = new System.Drawing.Point(3, 77);
            this.comboBoxFunMask.Name = "comboBoxFunMask";
            this.comboBoxFunMask.Size = new System.Drawing.Size(210, 29);
            this.comboBoxFunMask.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "增加修改功能";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerial.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(446, 4);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(190, 29);
            this.comboBoxSerial.TabIndex = 0;
            // 
            // comboBoxHardVersion
            // 
            this.comboBoxHardVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHardVersion.Font = new System.Drawing.Font("宋体", 24F);
            this.comboBoxHardVersion.FormattingEnabled = true;
            this.comboBoxHardVersion.Location = new System.Drawing.Point(642, 3);
            this.comboBoxHardVersion.Name = "comboBoxHardVersion";
            this.comboBoxHardVersion.Size = new System.Drawing.Size(98, 41);
            this.comboBoxHardVersion.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(758, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "修改系列版本";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxFun
            // 
            this.comboBoxFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFun.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBoxFun.FormattingEnabled = true;
            this.comboBoxFun.Location = new System.Drawing.Point(24, 227);
            this.comboBoxFun.Name = "comboBoxFun";
            this.comboBoxFun.Size = new System.Drawing.Size(210, 29);
            this.comboBoxFun.TabIndex = 0;
            // 
            // comboBoxCheckItem
            // 
            this.comboBoxCheckItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckItem.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBoxCheckItem.FormattingEnabled = true;
            this.comboBoxCheckItem.Location = new System.Drawing.Point(268, 227);
            this.comboBoxCheckItem.Name = "comboBoxCheckItem";
            this.comboBoxCheckItem.Size = new System.Drawing.Size(210, 29);
            this.comboBoxCheckItem.TabIndex = 0;
            // 
            // buttonFunCheckItem
            // 
            this.buttonFunCheckItem.Location = new System.Drawing.Point(495, 214);
            this.buttonFunCheckItem.Name = "buttonFunCheckItem";
            this.buttonFunCheckItem.Size = new System.Drawing.Size(141, 61);
            this.buttonFunCheckItem.TabIndex = 1;
            this.buttonFunCheckItem.Text = "功能检测项关联";
            this.buttonFunCheckItem.UseVisualStyleBackColor = true;
            this.buttonFunCheckItem.Click += new System.EventHandler(this.buttonFunCheckItem_Click);
            // 
            // textBoxFunValue
            // 
            this.textBoxFunValue.Location = new System.Drawing.Point(316, 50);
            this.textBoxFunValue.Name = "textBoxFunValue";
            this.textBoxFunValue.Size = new System.Drawing.Size(100, 21);
            this.textBoxFunValue.TabIndex = 2;
            // 
            // buttonAddFunList
            // 
            this.buttonAddFunList.Location = new System.Drawing.Point(422, 39);
            this.buttonAddFunList.Name = "buttonAddFunList";
            this.buttonAddFunList.Size = new System.Drawing.Size(110, 44);
            this.buttonAddFunList.TabIndex = 1;
            this.buttonAddFunList.Text = "增加可用功能";
            this.buttonAddFunList.UseVisualStyleBackColor = true;
            this.buttonAddFunList.Click += new System.EventHandler(this.buttonAddFunList_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "删除功能";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCloneDeviceType
            // 
            this.buttonCloneDeviceType.Location = new System.Drawing.Point(6, 162);
            this.buttonCloneDeviceType.Name = "buttonCloneDeviceType";
            this.buttonCloneDeviceType.Size = new System.Drawing.Size(172, 40);
            this.buttonCloneDeviceType.TabIndex = 1;
            this.buttonCloneDeviceType.Text = "克隆型号-后续改系列";
            this.buttonCloneDeviceType.UseVisualStyleBackColor = true;
            this.buttonCloneDeviceType.Click += new System.EventHandler(this.buttonCloneDeviceType_Click);
            // 
            // tabControlHHU
            // 
            this.tabControlHHU.Controls.Add(this.tabPageHHUType);
            this.tabControlHHU.Controls.Add(this.tabPageAuth);
            this.tabControlHHU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHHU.Location = new System.Drawing.Point(0, 0);
            this.tabControlHHU.Name = "tabControlHHU";
            this.tabControlHHU.SelectedIndex = 0;
            this.tabControlHHU.Size = new System.Drawing.Size(984, 687);
            this.tabControlHHU.TabIndex = 3;
            // 
            // tabPageHHUType
            // 
            this.tabPageHHUType.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.tabPageHHUType.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageHHUType.Controls.Add(this.comboBoxDeviceType);
            this.tabPageHHUType.Controls.Add(this.textBoxFunValue);
            this.tabPageHHUType.Controls.Add(this.buttonFunCheckItem);
            this.tabPageHHUType.Controls.Add(this.buttonGetAllType);
            this.tabPageHHUType.Controls.Add(this.buttonAddFunList);
            this.tabPageHHUType.Controls.Add(this.button2);
            this.tabPageHHUType.Controls.Add(this.comboBoxCheckItem);
            this.tabPageHHUType.Controls.Add(this.comboBoxFunID);
            this.tabPageHHUType.Controls.Add(this.comboBoxFun);
            this.tabPageHHUType.Controls.Add(this.buttonCloneDeviceType);
            this.tabPageHHUType.Controls.Add(this.button3);
            this.tabPageHHUType.Controls.Add(this.comboBoxFunMask);
            this.tabPageHHUType.Controls.Add(this.button1);
            this.tabPageHHUType.Controls.Add(this.comboBoxHardVersion);
            this.tabPageHHUType.Controls.Add(this.comboBoxSerial);
            this.tabPageHHUType.Location = new System.Drawing.Point(4, 22);
            this.tabPageHHUType.Name = "tabPageHHUType";
            this.tabPageHHUType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHHUType.Size = new System.Drawing.Size(976, 661);
            this.tabPageHHUType.TabIndex = 0;
            this.tabPageHHUType.Text = "型号相关";
            // 
            // tabPageAuth
            // 
            this.tabPageAuth.Controls.Add(this.buttonAuthAdd);
            this.tabPageAuth.Controls.Add(this.comboBoxRoleItem);
            this.tabPageAuth.Controls.Add(this.comboBoxRole);
            this.tabPageAuth.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuth.Name = "tabPageAuth";
            this.tabPageAuth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuth.Size = new System.Drawing.Size(976, 661);
            this.tabPageAuth.TabIndex = 1;
            this.tabPageAuth.Text = "权限相关";
            this.tabPageAuth.UseVisualStyleBackColor = true;
            // 
            // buttonAuthAdd
            // 
            this.buttonAuthAdd.Location = new System.Drawing.Point(485, 6);
            this.buttonAuthAdd.Name = "buttonAuthAdd";
            this.buttonAuthAdd.Size = new System.Drawing.Size(141, 61);
            this.buttonAuthAdd.TabIndex = 4;
            this.buttonAuthAdd.Text = "权限添加";
            this.buttonAuthAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxRoleItem
            // 
            this.comboBoxRoleItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoleItem.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBoxRoleItem.FormattingEnabled = true;
            this.comboBoxRoleItem.Location = new System.Drawing.Point(258, 19);
            this.comboBoxRoleItem.Name = "comboBoxRoleItem";
            this.comboBoxRoleItem.Size = new System.Drawing.Size(210, 29);
            this.comboBoxRoleItem.TabIndex = 3;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(14, 19);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(210, 29);
            this.comboBoxRole.TabIndex = 2;
            // 
            // buttonGetAllType
            // 
            this.buttonGetAllType.Location = new System.Drawing.Point(789, 67);
            this.buttonGetAllType.Name = "buttonGetAllType";
            this.buttonGetAllType.Size = new System.Drawing.Size(110, 44);
            this.buttonGetAllType.TabIndex = 1;
            this.buttonGetAllType.Text = "显示所有型号";
            this.buttonGetAllType.UseVisualStyleBackColor = true;
            this.buttonGetAllType.Click += new System.EventHandler(this.buttonGetAllType_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.tabControlHHU);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置掌机序列号";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlHHU.ResumeLayout(false);
            this.tabPageHHUType.ResumeLayout(false);
            this.tabPageHHUType.PerformLayout();
            this.tabPageAuth.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDeviceType;
        private System.Windows.Forms.ComboBox comboBoxFunID;
        private System.Windows.Forms.ComboBox comboBoxFunMask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxSerial;
        private System.Windows.Forms.ComboBox comboBoxHardVersion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxFun;
        private System.Windows.Forms.ComboBox comboBoxCheckItem;
        private System.Windows.Forms.Button buttonFunCheckItem;
        private System.Windows.Forms.TextBox textBoxFunValue;
        private System.Windows.Forms.Button buttonAddFunList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCloneDeviceType;
        private System.Windows.Forms.TabControl tabControlHHU;
        private System.Windows.Forms.TabPage tabPageHHUType;
        private System.Windows.Forms.TabPage tabPageAuth;
        private System.Windows.Forms.Button buttonAuthAdd;
        private System.Windows.Forms.ComboBox comboBoxRoleItem;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonGetAllType;

    }
}


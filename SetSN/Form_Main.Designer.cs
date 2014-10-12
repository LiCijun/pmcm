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
            this.SuspendLayout();
            // 
            // comboBoxDeviceType
            // 
            this.comboBoxDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBoxDeviceType.FormattingEnabled = true;
            this.comboBoxDeviceType.Location = new System.Drawing.Point(35, 54);
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
            this.comboBoxFunID.Location = new System.Drawing.Point(35, 115);
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
            this.comboBoxFunMask.Location = new System.Drawing.Point(35, 174);
            this.comboBoxFunMask.Name = "comboBoxFunMask";
            this.comboBoxFunMask.Size = new System.Drawing.Size(210, 29);
            this.comboBoxFunMask.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 233);
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
            this.comboBoxSerial.Location = new System.Drawing.Point(487, 54);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(190, 29);
            this.comboBoxSerial.TabIndex = 0;
            // 
            // comboBoxHardVersion
            // 
            this.comboBoxHardVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHardVersion.Font = new System.Drawing.Font("宋体", 24F);
            this.comboBoxHardVersion.FormattingEnabled = true;
            this.comboBoxHardVersion.Location = new System.Drawing.Point(697, 54);
            this.comboBoxHardVersion.Name = "comboBoxHardVersion";
            this.comboBoxHardVersion.Size = new System.Drawing.Size(98, 41);
            this.comboBoxHardVersion.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(819, 51);
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
            this.comboBoxFun.Location = new System.Drawing.Point(35, 441);
            this.comboBoxFun.Name = "comboBoxFun";
            this.comboBoxFun.Size = new System.Drawing.Size(210, 29);
            this.comboBoxFun.TabIndex = 0;
            // 
            // comboBoxCheckItem
            // 
            this.comboBoxCheckItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckItem.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBoxCheckItem.FormattingEnabled = true;
            this.comboBoxCheckItem.Location = new System.Drawing.Point(279, 441);
            this.comboBoxCheckItem.Name = "comboBoxCheckItem";
            this.comboBoxCheckItem.Size = new System.Drawing.Size(210, 29);
            this.comboBoxCheckItem.TabIndex = 0;
            // 
            // buttonFunCheckItem
            // 
            this.buttonFunCheckItem.Location = new System.Drawing.Point(506, 427);
            this.buttonFunCheckItem.Name = "buttonFunCheckItem";
            this.buttonFunCheckItem.Size = new System.Drawing.Size(141, 61);
            this.buttonFunCheckItem.TabIndex = 1;
            this.buttonFunCheckItem.Text = "功能检测项关联";
            this.buttonFunCheckItem.UseVisualStyleBackColor = true;
            this.buttonFunCheckItem.Click += new System.EventHandler(this.buttonFunCheckItem_Click);
            // 
            // textBoxFunValue
            // 
            this.textBoxFunValue.Location = new System.Drawing.Point(336, 122);
            this.textBoxFunValue.Name = "textBoxFunValue";
            this.textBoxFunValue.Size = new System.Drawing.Size(100, 21);
            this.textBoxFunValue.TabIndex = 2;
            // 
            // buttonAddFunList
            // 
            this.buttonAddFunList.Location = new System.Drawing.Point(457, 112);
            this.buttonAddFunList.Name = "buttonAddFunList";
            this.buttonAddFunList.Size = new System.Drawing.Size(110, 44);
            this.buttonAddFunList.TabIndex = 1;
            this.buttonAddFunList.Text = "增加可用功能";
            this.buttonAddFunList.UseVisualStyleBackColor = true;
            this.buttonAddFunList.Click += new System.EventHandler(this.buttonAddFunList_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "删除功能";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.textBoxFunValue);
            this.Controls.Add(this.buttonFunCheckItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddFunList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCheckItem);
            this.Controls.Add(this.comboBoxFun);
            this.Controls.Add(this.comboBoxFunMask);
            this.Controls.Add(this.comboBoxFunID);
            this.Controls.Add(this.comboBoxSerial);
            this.Controls.Add(this.comboBoxHardVersion);
            this.Controls.Add(this.comboBoxDeviceType);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置掌机序列号";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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

    }
}


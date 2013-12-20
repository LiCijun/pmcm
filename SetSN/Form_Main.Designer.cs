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
            this.SuspendLayout();
            // 
            // comboBoxDeviceType
            // 
            this.comboBoxDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceType.Font = new System.Drawing.Font("宋体", 24F);
            this.comboBoxDeviceType.FormattingEnabled = true;
            this.comboBoxDeviceType.Location = new System.Drawing.Point(35, 54);
            this.comboBoxDeviceType.Name = "comboBoxDeviceType";
            this.comboBoxDeviceType.Size = new System.Drawing.Size(581, 41);
            this.comboBoxDeviceType.TabIndex = 0;
            this.comboBoxDeviceType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeviceType_SelectedIndexChanged);
            // 
            // comboBoxFunID
            // 
            this.comboBoxFunID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunID.Font = new System.Drawing.Font("宋体", 24F);
            this.comboBoxFunID.FormattingEnabled = true;
            this.comboBoxFunID.Location = new System.Drawing.Point(35, 139);
            this.comboBoxFunID.Name = "comboBoxFunID";
            this.comboBoxFunID.Size = new System.Drawing.Size(295, 41);
            this.comboBoxFunID.TabIndex = 0;
            this.comboBoxFunID.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunID_SelectedIndexChanged);
            // 
            // comboBoxFunMask
            // 
            this.comboBoxFunMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunMask.Font = new System.Drawing.Font("宋体", 24F);
            this.comboBoxFunMask.FormattingEnabled = true;
            this.comboBoxFunMask.Location = new System.Drawing.Point(35, 217);
            this.comboBoxFunMask.Name = "comboBoxFunMask";
            this.comboBoxFunMask.Size = new System.Drawing.Size(210, 41);
            this.comboBoxFunMask.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "增加修改功能";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerial.Font = new System.Drawing.Font("宋体", 24F);
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(355, 139);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(248, 41);
            this.comboBoxSerial.TabIndex = 0;
            // 
            // comboBoxHardVersion
            // 
            this.comboBoxHardVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHardVersion.Font = new System.Drawing.Font("宋体", 24F);
            this.comboBoxHardVersion.FormattingEnabled = true;
            this.comboBoxHardVersion.Location = new System.Drawing.Point(355, 224);
            this.comboBoxHardVersion.Name = "comboBoxHardVersion";
            this.comboBoxHardVersion.Size = new System.Drawing.Size(261, 41);
            this.comboBoxHardVersion.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "修改系列版本";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDeviceType;
        private System.Windows.Forms.ComboBox comboBoxFunID;
        private System.Windows.Forms.ComboBox comboBoxFunMask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxSerial;
        private System.Windows.Forms.ComboBox comboBoxHardVersion;
        private System.Windows.Forms.Button button2;

    }
}


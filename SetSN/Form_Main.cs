using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using System.IO;
using OpenNETCF.Desktop.Communication;
using MySql.Data.MySqlClient;

namespace SetSN
{
    public partial class Form_Main : Form
    {
        public static string CurrPath = System.Windows.Forms.Application.StartupPath;
        static string Dbfile = CurrPath + @"\bsdata.db";
        static string Cfgfile = CurrPath + @"\cfg.sys";
        static string Outfile = CurrPath + @"\out.sys";
        static string Infile = CurrPath + @"\in.sys";
        static string Runfile = CurrPath + @"\Update.exe";
        static string sType = "";
        static string return_pdt_sn = "";
        static string return_pdt_msn = "";
        static string return_pdt_type = "";
        static string return_pdt_time = "";
        static int cntnum = 0;
        bool bUsed = false;
        ListView listView1 = new ListView();
        private RAPI myrapi;
        Timer timer = new Timer();
        static string connStr = String.Format("server={0};uid={1};pwd={2};database={3}", "10.0.0.123", "PMC", "km2014", "PMC");

        public Form_Main()
        {
            InitializeComponent();
        }
        private void ConnectDevice()
        {
            myrapi.Connect(false, -1);
        }
        private void ActiveSync_Active()
        {
            ConnectDevice();
        }
        private void ActiveSync_Disconnect()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lDeviceStatus.Text = "正在断开设备...";
                lDeviceStatus.BackColor = System.Drawing.Color.Yellow;
            }));
        }
        private void ActiveSync_Listen()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lDeviceStatus.Text = "无设备";
                lDeviceStatus.BackColor = System.Drawing.Color.Red;
            }));
        }
        private void ActiveSync_Answer()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lDeviceStatus.Text = "正在接入设备...";
                lDeviceStatus.BackColor = System.Drawing.Color.Yellow;
            }));
        }
        private void myrapi_RAPIConnected()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lDeviceStatus.Text = "设备正常";
                lConnectStatus.Text = "已连接";
                lDeviceStatus.BackColor = System.Drawing.Color.YellowGreen;
                lConnectStatus.BackColor = System.Drawing.Color.YellowGreen;
            }));
        }
        private void myrapi_RAPIDisconnected()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lConnectStatus.Text = "未连接";
                lConnectStatus.BackColor = System.Drawing.Color.Red;
            }));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            myrapi = new RAPI();
            myrapi.ActiveSync.Active += new ActiveHandler(ActiveSync_Active);
            myrapi.ActiveSync.Disconnect += new DisconnectHandler(ActiveSync_Disconnect);
            myrapi.ActiveSync.Listen += new ListenHandler(ActiveSync_Listen);
            myrapi.ActiveSync.Answer += new AnswerHandler(ActiveSync_Answer);

            myrapi.RAPIConnected += new RAPIConnectedHandler(myrapi_RAPIConnected);
            myrapi.RAPIDisconnected += new RAPIConnectedHandler(myrapi_RAPIDisconnected);

            ConnectDevice();

            timer.Interval = 1500;
            timer.Tick += new EventHandler(ontimer);
            timer.Enabled = false;

            comboBox_Type.SelectedIndex = 0;
            textBox_SN.Focus();
            textBox_SN.SelectAll();

            listView1.Bounds = new Rectangle(new Point(380, 30), new Size(400, 529));

            listView1.View = View.Details;
            listView1.AllowColumnReorder = true;
            listView1.GridLines = true;
            listView1.BackColor = System.Drawing.Color.Goldenrod;
            listView1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            listView1.Columns.Add(" 数量 ", -2, HorizontalAlignment.Left);
            listView1.Columns.Add(" 型号 ", -2, HorizontalAlignment.Left);
            listView1.Columns.Add(" 序列号 ", -2, HorizontalAlignment.Left);


            /******* Cbsdata mysql check  *******
            string connStr = String.Format("server={0};uid={1};pwd={2};database={3}", "10.0.0.123", "PMC", "km2014", "PMC");
            Cbsdata.Create(connStr);
            Cdata box = new Cdata();
            box.BOXSN = "KM20131201";
            box.TYPE = "P31-1";
            box.PSN = "1234567890123453";
            box.MSSN = "12345678901234";
            box.DAY = "20131211";
            Cbsdata.Insert(connStr, box);
            box.PSN = "1234567890123452";
            box.MSSN = "12345678901234";
            box.DAY = "";
            Cbsdata.Insert(connStr, box);
            box.PSN = "1234567890123453";
            box.MSSN = "12345678900001";
            Cbsdata.Update(connStr, box);       
            box.PSN = "";
            box.TYPE = "";
            box.MSSN = "";
            box.BOXSN = "";
            box.DAY = "20131211";
            Cbsdata.Getdata(connStr, box);

            Cbsdata.Delete(connStr, box);
            */
            /******  Cbspda mysql check  ******* 
            Cbspda.Create(connStr);
            Cpda pda = new Cpda();
            pda.PDA = "P31";
            pda.FUNCTION = "bt=4,;bt_type=1,gprs=1,irda=2,;scan=1,wifi=1";
            Cbspda.Insert(connStr, pda);
            pda.PDA = "K25";
            pda.FUNCTION = "bt=4,;bt_type=1,gprs=1,irda=3,scan=2,;rfid=3,wifi=1";
            Cbspda.Insert(connStr, pda);
            pda.PDA = "K36";
            pda.FUNCTION = "bt=2,;bt_type=1,gprs=1,irda=4,;gps=2,scan=4,wifi=1";
            Cbspda.Insert(connStr, pda);
            pda.FUNCTION = "bt=2,irda=4,;gps=2,scan=4,wifi=1";
            Cbspda.Update(connStr, pda);
            pda.PDA = "K25";
            Cbspda.Getpda(connStr, pda);
            string func = pda.FUNCTION;
            if (!(func.Trim() == ""))
            {
                string[] TmpRecord = func.Split(',');
                int i = TmpRecord.Length;

                i=i + 10;
            }
            Cbspda.Delete(connStr, pda);
           ****/

            /******
            Cbsuser.Create(connStr);
            Cuser user = new Cuser();
            user.USER = "shenfushan";
            user.PASSWORD = WinCE.Security.Hash.MD5("123456890hello",Encoding.UTF8);
            Cbsuser.Insert(connStr, user);
            user.PASSWORD = WinCE.Security.Hash.MD5("12345689hello", Encoding.UTF8);

            Cbsuser.Update(connStr, user);

            Cbsuser.Getuser(connStr, user);

            Cbsuser.Delete(connStr, user);
             ******/
            this.Controls.Add(listView1);

        }
        public bool BeforeHandler()
        {
            bool bResult = false;

            if (myrapi.DevicePresent)
            {
                try
                {
                    if (!myrapi.Connected)
                    {
                        ConnectDevice();
                        System.Threading.Thread.Sleep(100);
                    }
                    if (myrapi.Connected)
                    {
                        if (myrapi.DeviceFileExists(@"\Windows\cfg.sys"))
                        {
                            myrapi.DeleteDeviceFile(@"\Windows\cfg.sys");
                        }
                        if (myrapi.DeviceFileExists(@"\Windows\out.sys"))
                        {
                            myrapi.DeleteDeviceFile(@"\Windows\out.sys");
                        }
                        if (myrapi.DeviceFileExists(@"\Windows\Update.exe"))
                        {
                            myrapi.DeleteDeviceFile(@"\Windows\Update.exe");
                        }
                        myrapi.CopyFileToDevice(Cfgfile, @"\Windows\cfg.sys", true);
                        myrapi.CopyFileToDevice(Outfile, @"\Windows\out.sys", true);
                        myrapi.CopyFileToDevice(Runfile, @"\Windows\Update.exe", true);
                        myrapi.CreateProcess(@"\Windows\Update.exe", "");

                        bResult = true;
                    }
                }
                catch
                {
                    myrapi.Disconnect();
                    ConnectDevice();
                    System.Threading.Thread.Sleep(100);
                    bResult = false;
                }
            }
            return bResult;
        }
        public bool AfterHandler()
        {
            bool bResult = false;

            if (myrapi.DevicePresent)
            {
                try
                {
                    if (!myrapi.Connected)
                    {
                        ConnectDevice();
                        System.Threading.Thread.Sleep(100);
                    }
                    if (myrapi.Connected)
                    {
                        if (myrapi.DeviceFileExists(@"\Windows\in.sys"))
                        {
                            myrapi.CopyFileFromDevice(Infile, @"\Windows\in.sys", true);
                        }
                        if (myrapi.DeviceFileExists(@"\Windows\in.sys"))
                        {
                            myrapi.DeleteDeviceFile(@"\Windows\in.sys");
                        }
                        if (myrapi.DeviceFileExists(@"\Windows\out.sys"))
                        {
                            myrapi.DeleteDeviceFile(@"\Windows\out.sys");
                        }
                        if (myrapi.DeviceFileExists(@"\Windows\cfg.sys"))
                        {
                            myrapi.DeleteDeviceFile(@"\Windows\cfg.sys");
                        }
                        if (myrapi.DeviceFileExists(@"\Windows\Update.exe"))
                        {
                            myrapi.DeleteDeviceFile(@"\Windows\Update.exe");
                        }

                        bResult = true;
                    }
                }
                catch
                {
                    myrapi.Disconnect();
                    ConnectDevice();
                    System.Threading.Thread.Sleep(100);
                    bResult = false;
                }
            }
            return bResult;
        }
        public static bool LoadInfo()
        {
            bool bResult = false;

            System.IO.FileStream FS = null;
            System.IO.StreamReader SR = null;
            if (System.IO.File.Exists(Infile))
            {
                try
                {
                    FS = new System.IO.FileStream(Infile, System.IO.FileMode.Open);
                    SR = new System.IO.StreamReader(FS, System.Text.Encoding.Default);
                    string Line = SR.ReadLine();

                    if (!(Line.Trim() == ""))
                    {
                        string[] TmpRecord = Line.Split(',');
                        return_pdt_sn = TmpRecord[0];
                        return_pdt_msn = TmpRecord[1];
                        return_pdt_type = TmpRecord[2];
                        return_pdt_time = TmpRecord[3];
                    }

                    bResult = true;
                }
                catch
                {
                    bResult = false;
                }
                finally
                {
                    if (SR != null)
                    {
                        SR.Close();
                    }
                    if (FS != null)
                    {
                        FS.Close();
                    }
                    if (File.Exists(Infile))
                    {
                        File.Delete(Infile);
                    }
                }
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }
        private void ontimer(object sender, EventArgs e)
        {
            timer.Enabled = false;
            label6.Text = "";
            if (AfterHandler())
            {
                if (LoadInfo())
                {
                    if ((return_pdt_sn == textBox_SN.Text) && (return_pdt_msn == textBox_MSN.Text) && (return_pdt_type == sType))
                    {
                        cntnum++;
                        if (21 == cntnum)
                        {
                            cntnum = 1;
                            listView1.Items.Clear();
                        }
                        ListViewItem item1 = new ListViewItem(cntnum.ToString("D3"));
                        item1.SubItems.Add(return_pdt_sn);
                        listView1.Items.AddRange(new ListViewItem[] { item1 });
                        this.Controls.Add(listView1);

                        //save data to bsdata.db
                        


                       

                        label6.BackColor = System.Drawing.Color.YellowGreen;
                        label6.Text = "设置序列号成功";


                    }
                    else
                        label6.Text = "!设置序列号失败";
                    textBox_MSN.Text = "";
                }
                else
                    label6.Text = "!设置失败";
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;


            bUsed = false;

        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myrapi != null)
            {
                if (myrapi.Connected)
                {
                    myrapi.Disconnect();
                }
                myrapi.Dispose();
            }
        }
        public static bool IsNumberic(string value)
        {
            return Regex.IsMatch(value, @"^\d+$");
        }
        private void textBox_MSN_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (bUsed)
                        return;
                    bUsed = true;
                    Cursor = Cursors.WaitCursor;
                    timer.Enabled = true;
                    label6.Text = "";

                    if (((comboBox_Type.SelectedItem.ToString().Equals("K36掌机") ? 14 : 16) == textBox_SN.Text.Length) &&
                        (14 == textBox_MSN.Text.Length) && IsNumberic(textBox_MSN.Text))
                    {
                        //
                        string[] cfg = { "[config]", "bt=4", "rfid=3", "wifi=1" };
                        System.IO.File.WriteAllLines(Cfgfile, cfg);

                        //
                        sType = "4b00000";
                        Ini ini = new Ini(Outfile);
                        ini.WriteValue("Info", "sn", textBox_SN.Text);
                        ini.WriteValue("Info", "license", textBox_MSN.Text);
                        ini.WriteValue("Info", "date", System.DateTime.Now.ToString("yyyy-MM-dd"));
                        ini.WriteValue("Info", "type", sType);



                        if (BeforeHandler())
                        {
                            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                        }
                        else
                        {
                            label6.Text = "!设备未就绪?";
                            bUsed = false;
                        }
                    }
                    else
                    {
                        label6.Text = "!输入数据长度不够";
                        textBox_MSN.Focus();
                        textBox_MSN.SelectAll();
                        bUsed = false;
                    }

                    Cursor = Cursors.Default;
                    break;
            }
        }
        private void textBox_SN_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Cursor = Cursors.WaitCursor;
                    label6.Text = "";
                    if (6 < textBox_SN.Text.Length)
                    {
                        textBox_MSN.Focus();
                        textBox_MSN.SelectAll();
                    }
                    else
                        label6.Text = "!输入数据长度不够";
                    Cursor = Cursors.Default;
                    break;
            }
        }
        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Type.SelectedItem.ToString().Equals("K36掌机"))
                textBox_SN.MaxLength = 14;
            else
                textBox_SN.MaxLength = 16;
        }

        private void 用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }


    public class Ini
    {
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);

        public void WriteValue(string section, string key, string value)
        {
            // section=配置节，key=键名，value=键值，path=路径
            WritePrivateProfileString(section, key, value, sPath);
        }
        public string ReadValue(string section, string key)
        {
            // 每次从ini中读取多少字节
            System.Text.StringBuilder temp = new System.Text.StringBuilder(255);
            // section=配置节，key=键名，temp=上面，path=路径
            GetPrivateProfileString(section, key, "", temp, 255, sPath);
            return temp.ToString();
        }

        private string sPath = null;
        public Ini(string path)
        {
            this.sPath = path;
        }
    }

}

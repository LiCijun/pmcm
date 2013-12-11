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

using System.Runtime.InteropServices;

namespace SetSN
{
    public partial class Form_Main : Form
    {
        public static string CurrPath = System.Windows.Forms.Application.StartupPath;
        static string RTfile = CurrPath + @"\rt.sys";
        static string SNfile = CurrPath + @"\kmt.sys";
        static string Runfile = CurrPath + @"\Update.exe";
        static string Sndfile = CurrPath + @"\0.wav";
        static string logfile = CurrPath + @"\data.kdb";

        static string returnsn = "";
        static string returntime = "";

        private RAPI myrapi;

        [DllImport("winmm")]
        public static extern bool PlaySound(string szSound, IntPtr hMod, int flags);

        public Form_Main()
        {
            InitializeComponent();            
        }
        
        private void ActiveSync_Active()
        {
            ConnectDevice();
        }
        private void ConnectDevice()
        {
            myrapi.RAPIConnected += new RAPIConnectedHandler(myrapi_RAPIConnected);
            myrapi.RAPIDisconnected += new RAPIConnectedHandler(myrapi_RAPIDisconnected);
            myrapi.Connect(false, -1);
        }
        private void ActiveSync_Disconnect()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lDeviceStatus.Text = "正在断开设备...";
            }));
        }

        private void ActiveSync_Listen()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lDeviceStatus.Text = "无设备";
                label_Info.Text = "";
            }));
        }

        private void ActiveSync_Answer()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lDeviceStatus.Text = "正在接入设备...";
            }));
        }
        private void myrapi_RAPIConnected()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lDeviceStatus.Text = "设备正常";
                lConnectStatus.Text = "已连接";
            }));
        }

        private void myrapi_RAPIDisconnected()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                lConnectStatus.Text = "未连接";
                label_Info.Text = "";
            }));
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (myrapi.Connected)
            {
                myrapi.Disconnect();
            }
            myrapi.Dispose();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ActiveSync_Active();
        }

        public static void SaveData(string ToWrFile,string Currdata,Boolean bAppend)
        {
            System.IO.FileStream FS = null;
            System.IO.StreamWriter SW = null;
            if (System.IO.File.Exists(ToWrFile))
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(ToWrFile);
                fi.Attributes = fi.Attributes & ~System.IO.FileAttributes.ReadOnly;
            }
            try
            {
                if (bAppend)
                    FS = new System.IO.FileStream(ToWrFile, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                else
                    FS = new System.IO.FileStream(ToWrFile, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                SW = new System.IO.StreamWriter(FS, System.Text.Encoding.Default);
                if (bAppend)
                    FS.Seek(0, SeekOrigin.End);
                SW.Write(Currdata);
            }
            finally
            {
                if (SW != null)
                {
                    SW.Close();
                }
                if (FS != null)
                {
                    FS.Close();
                }
            }
        }

        Timer timer = new Timer();
        private void ontimer(object sender, EventArgs e)
        {
            timer.Enabled = false;
            if (myrapi.Connected)
            {
                if (myrapi.DeviceFileExists(@"\Windows\rt.sys"))
                {
                    myrapi.CopyFileFromDevice(RTfile,@"\Windows\rt.sys",true);

                    if (myrapi.DeviceFileExists(@"\Windows\rt.sys"))
                    {
                        myrapi.DeleteDeviceFile(@"\Windows\rt.sys");
                    }
                    if (myrapi.DeviceFileExists(@"\Windows\kmt.sys"))
                    {
                        myrapi.DeleteDeviceFile(@"\Windows\kmt.sys");
                    }
                    if (myrapi.DeviceFileExists(@"\Windows\Update.exe"))
                    {
                        myrapi.DeleteDeviceFile(@"\Windows\Update.exe");
                    }

                    if (LoadInfo())
                    {
                        if (returnsn == textBox_SN.Text)
                        {
                            label_Info.Text = "       ^_^ 设置序列号成功";
                            SaveData(logfile, string.Format("{0},{1},{2}\r\n", returnsn, System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), comboBox_Type.SelectedItem.ToString() ), true);
                            try
                            {
                                TimeSpan ts1 = new TimeSpan(DateTime.Parse(returntime).Ticks);
                                TimeSpan ts2 = new TimeSpan(DateTime.Now.Ticks);
                                TimeSpan ts = ts1.Subtract(ts2).Duration();
                                if (ts.Ticks / 10000000 > 5 * 60)
                                    label_Info.Text += "\n掌机时间与当前电脑相差超过5分钟\n请设置掌机时间";
                            }
                            catch
                            {
                                label_Info.Text += "\n掌机时间异常，请重新设置掌机时间";
                            }
                            textBox_SN.Focus();
                            textBox_SN.SelectAll();
                        }
                        else
                            label_Info.Text = "!!!:设置序列号失败";
                        textBox_MSN.Text = "";
                    }
                    else
                        label_Info.Text = "!!!:设置序列号失败";
                }
                else
                    label_Info.Text = "!!!:设置失败";
            }
        }
        public static bool LoadInfo()
        {
            bool bResult = false;

            System.IO.FileStream FS = null;
            System.IO.StreamReader SR = null;
            if (System.IO.File.Exists(RTfile))
            {
                try
                {
                    FS = new System.IO.FileStream(RTfile, System.IO.FileMode.Open);
                    SR = new System.IO.StreamReader(FS, System.Text.Encoding.Default);
                    string Line = SR.ReadLine();
                    
                   if (!(Line.Trim() == ""))
                    {
                         string[] TmpRecord = Line.Split(',');
                         returnsn = TmpRecord[0];
                         returntime = TmpRecord[3];
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
                    if (File.Exists(RTfile))
                    {
                        File.Delete(RTfile);
                    }
                }
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }
        public static bool IsNumberic(string value)
        {
            return Regex.IsMatch(value, @"^\d+$");
        }
        private void textBox_SN_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Cursor = Cursors.WaitCursor;
                    label_Info.Text = "";
                    try
                    {
                        if ((6 < textBox_MSN.Text.Length) && (textBox_MSN.Text.Equals(textBox_SN.Text)) /*&& IsNumberic(textBox_SN.Text)*/)
                        {
                            string sType = "";
                            switch (comboBox_Type.SelectedItem.ToString())                           
                            {
                                case "K36掌机":
                                    sType = Convert.ToString(1300 << 16, 16);
                                    break;
                                case "K25全能终端":
                                    sType = Convert.ToString(1100 << 16, 16);
                                    break;
                                case "P31全能终端":
                                    sType = Convert.ToString(1200 << 16, 16);
                                    break;
                                case "P31抄表终端":
                                    sType = Convert.ToString(1201 << 16, 16);
                                    break;
                                case "P31用电检查终端":
                                    sType = Convert.ToString(1202 << 16, 16);
                                    break;
                                case "P31计量维护终端":
                                    sType = Convert.ToString(1203 << 16, 16);
                                    break;
                                case "P31应急处理终端":
                                    sType = Convert.ToString(1204 << 16, 16);
                                    break;
                                default:
                                    break;
                            }
                            SaveData(SNfile,string.Format("{0},{1},{2},{3},{4},{5}\r\n",
                            System.DateTime.Now.ToString("yyyy-MM-dd"),//"2011-06-15",//strDate,
                            textBox_MSN.Text,//strSN,
                            "WinCE",//strDescription,
                            sType,//strVer,
                            "30.40",//"24.32",//strZB,
                            "80.21"//"80.20"//strFB
                        ),false);
                            if (!myrapi.Connected)
                            {
                                ActiveSync_Active();
                            }
                            System.Threading.Thread.Sleep(100);
                            if (myrapi.Connected)
                            {
                                if (myrapi.DeviceFileExists(@"\Windows\rt.sys"))
                                {
                                    myrapi.DeleteDeviceFile(@"\Windows\rt.sys");
                                }
                                if (myrapi.DeviceFileExists(@"\Windows\kmt.sys"))
                                {
                                    myrapi.DeleteDeviceFile(@"\Windows\kmt.sys");
                                }
                                if (myrapi.DeviceFileExists(@"\Windows\Update.exe"))
                                {
                                    myrapi.DeleteDeviceFile(@"\Windows\Update.exe");
                                }

                                myrapi.CopyFileToDevice(SNfile, @"\Windows\kmt.sys", true);
                                myrapi.CopyFileToDevice(Runfile, @"\Windows\Update.exe", true);
                                myrapi.CreateProcess(@"\Windows\Update.exe", "");                                

                                
                                timer.Enabled = true;
                            }
                            else
                                label_Info.Text = "!!!:设备未连接";
                        }
                        else
                        {
                            label_Info.Text = "!!!:输入不正确";
                            textBox_MSN.Focus();
                            textBox_MSN.SelectAll();
                        }
                    }
                    catch
                    {
                        label_Info.Text = "!!!:运行异常";
                    }                   
                    
                    Cursor = Cursors.Default;
                    break;
            }
        }       

        private void label_Info_Paint(object sender, PaintEventArgs e)
        {
            string str = label_Info.Text;
            string strA = "";

            int index = str.IndexOf('\n');
            if (-1 != index)
            {
                strA = str.Substring(0, index);
            }            
                
            Point point = new Point(label_Info.Padding.Left, label_Info.Padding.Top);
            TextRenderer.DrawText(e.Graphics, str, label_Info.Font, point, Color.Red);
            if (true == str.Contains("^_^"))
                TextRenderer.DrawText(e.Graphics, str, label_Info.Font, point, Color.Green);
            else
                PlaySound(Sndfile, IntPtr.Zero, 0x00020000 | 0x0001);
            TextRenderer.DrawText(e.Graphics, strA, label_Info.Font, point, Color.Red);
        }

        private void textBox_FirstSN_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Cursor = Cursors.WaitCursor;
                    label_Info.Text = "";
                    if (6 < textBox_SN.Text.Length)
                    {
                        textBox_MSN.Focus();
                        textBox_MSN.SelectAll();
                    }
                    else
                        label_Info.Text = "!!!:输入不正确,数据长度不够";
                    Cursor = Cursors.Default;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myrapi = new RAPI();
            myrapi.ActiveSync.Active += new ActiveHandler(ActiveSync_Active);
            myrapi.ActiveSync.Disconnect += new DisconnectHandler(ActiveSync_Disconnect);
            myrapi.ActiveSync.Listen += new ListenHandler(ActiveSync_Listen);
            myrapi.ActiveSync.Answer += new AnswerHandler(ActiveSync_Answer);
            ConnectDevice();

            timer.Interval = 1500;
            timer.Tick += new EventHandler(ontimer);
            timer.Enabled = false;

            comboBox_Type.SelectedIndex = 0;
            textBox_SN.Focus();
            textBox_SN.SelectAll();
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
    }
}

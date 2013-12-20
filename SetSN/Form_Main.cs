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

        static string connStr = String.Format("server={0};uid={1};pwd={2};database={3}", "10.0.0.123", "PMCM", "zL6NVHnw2y3FrPcD", "PMC");
        DataTable deviceItem = new DataTable();
        DataTable deviceType = new DataTable();
        DataTable function = new DataTable();
        DataTable user = new DataTable();
        DataTable boxType = new DataTable();

        public Form_Main()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


            MySqlConnection sqlCon = new MySqlConnection(connStr);
            sqlCon.Open();
            MySqlCommand sqlcmd = sqlCon.CreateCommand();

            sqlcmd.CommandText = "SELECT `ID`, `TypeName`, `Enabled`, `DeviceSerialID`, `DeviceHardVersionID`, `UpdateTime` FROM `DeviceType` order by TypeName";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
            sda.Fill(boxType);

            comboBoxDeviceType.DataSource = boxType;
            comboBoxDeviceType.DisplayMember = boxType.Columns["TypeName"].ToString();
            comboBoxDeviceType.ValueMember = boxType.Columns["ID"].ToString();



            sqlcmd.CommandText = "SELECT `ID`, `Name`, `CodeName`, `UpdateTime` FROM `Function` WHERE 1";
            sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
            sda.Fill(deviceType);

            comboBoxFunID.DataSource = deviceType;
            comboBoxFunID.DisplayMember = deviceType.Columns["Name"].ToString();
            comboBoxFunID.ValueMember = deviceType.Columns["id"].ToString();
            sqlCon.Close();

        }

        public static bool IsNumberic(string value)
        {
            return Regex.IsMatch(value, @"^\d+$");
        }

        private void comboBoxFunID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFunID.SelectedValue != null && !string.IsNullOrEmpty(comboBoxFunID.SelectedValue.ToString()))
            {
                string funid = comboBoxFunID.SelectedValue.ToString();

                MySqlConnection sqlCon = new MySqlConnection(connStr);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);

                sqlcmd.CommandText = "SELECT `ID`, `FunctionID`, `FunMask`, `UpdateTime` FROM `FunEnum`  WHERE `FunctionID` ='" + funid + "'";
                sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
                DataTable FunMask = new DataTable();
                sda.Fill(FunMask);
                comboBoxFunMask.DataSource = FunMask;
                comboBoxFunMask.DisplayMember = FunMask.Columns["FunMask"].ToString();
                comboBoxFunMask.ValueMember = FunMask.Columns["id"].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection sqlCon = new MySqlConnection(connStr);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                sqlcmd.CommandText = string.Format("delete from DeviceFunList where DeviceTypeID='{0}' and FunID='{1}'; INSERT INTO `DeviceFunList`(`ID`, `DeviceTypeID`, `FunID`, `FunMaskID`) VALUES (UUID(),'{0}','{1}','{2}')", comboBoxDeviceType.SelectedValue.ToString(), comboBoxFunID.SelectedValue.ToString(), comboBoxFunMask.SelectedValue.ToString());
                sqlcmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("OK");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFunID.SelectedValue != null && !string.IsNullOrEmpty(comboBoxFunID.SelectedValue.ToString()))
            {
                string funid = comboBoxFunID.SelectedValue.ToString();

                MySqlConnection sqlCon = new MySqlConnection(connStr);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
 


                sqlcmd.CommandText = "SELECT `ID`, `DeviceSerialName`, `DeviceSerialCode` FROM `DeviceSerial` WHERE 1";
                sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
                DataTable FunMask = new DataTable();
                sda.Fill(FunMask);
                comboBoxSerial.DataSource = FunMask;
                comboBoxSerial.DisplayMember = FunMask.Columns["DeviceSerialName"].ToString();
                comboBoxSerial.ValueMember = FunMask.Columns["id"].ToString();



                sqlcmd.CommandText = "SELECT `ID`, `DeviceHardVersionName`, `DeviceHardVersionCode`, `UpdateTime` FROM `DeviceHardVersion` WHERE 1";
                sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
                DataTable FunMask2 = new DataTable();
                sda.Fill(FunMask2);
                comboBoxHardVersion.DataSource = FunMask2;
                comboBoxHardVersion.DisplayMember = FunMask2.Columns["DeviceHardVersionName"].ToString();
                comboBoxHardVersion.ValueMember = FunMask2.Columns["id"].ToString();
               

                sqlCon.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection sqlCon = new MySqlConnection(connStr);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                sqlcmd.CommandText = string.Format("UPDATE DeviceType  SET DeviceSerialID='{1}',`DeviceHardVersionID`='{2}' WHERE id='{0}'", comboBoxDeviceType.SelectedValue.ToString(), comboBoxSerial.SelectedValue.ToString(), comboBoxHardVersion.SelectedValue.ToString());
                sqlcmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("OK");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}

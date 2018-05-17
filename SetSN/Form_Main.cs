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

        static string connStr = String.Format("server={0};uid={1};pwd={2};database={3}", "10.0.1.167", "PMCM", "zL6NVHnw2y3FrPcD", "PMC");
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

            sqlcmd.CommandText = "SELECT `ID`, `TypeName`, `Enabled`, `DeviceSerialID`, `DeviceHardVersionID`, `UpdateTime` FROM `DeviceType` where SYSEnabled=2 order by TypeName";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
            sda.Fill(boxType);

            comboBoxDeviceType.DataSource = boxType;
            comboBoxDeviceType.DisplayMember = boxType.Columns["TypeName"].ToString();
            comboBoxDeviceType.ValueMember = boxType.Columns["ID"].ToString();



            sqlcmd.CommandText = "SELECT `ID`, `Name`, `CodeName`, `UpdateTime` FROM `Function` where  `Enabled` = true  order by Name ";
            sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
            sda.Fill(deviceType);
            comboBoxFunID.DataSource = deviceType;
            comboBoxFunID.DisplayMember = deviceType.Columns["Name"].ToString();
            comboBoxFunID.ValueMember = deviceType.Columns["id"].ToString();


            sqlcmd.CommandText = "SELECT `ID`, `Name` FROM `Function` where  `Enabled` = true order by Name";
            sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBoxFun.DataSource = dt;
            comboBoxFun.DisplayMember = dt.Columns["Name"].ToString();
            comboBoxFun.ValueMember = dt.Columns["id"].ToString();


            sqlcmd.CommandText = "SELECT `ID`,  `Name` FROM `ProductionProcessItem` WHERE code is not null order by name ";
            sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
            dt = new DataTable();
            sda.Fill(dt);
            comboBoxCheckItem.DataSource = dt;
            comboBoxCheckItem.DisplayMember = dt.Columns["Name"].ToString();
            comboBoxCheckItem.ValueMember = dt.Columns["id"].ToString();


            sqlcmd.CommandText = "SELECT `ID`, `Name` FROM `Role` order by name";
            sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
            DataTable dtrole = new DataTable();
            sda.Fill(dtrole);
            comboBoxRole.DataSource = dtrole;
            comboBoxRole.DisplayMember = dtrole.Columns["Name"].ToString();
            comboBoxRole.ValueMember = dtrole.Columns["ID"].ToString();

            sqlcmd.CommandText = "SELECT `ID`, `Name` FROM `AuthorityItem` order by name";
            sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
            DataTable dtroleitem = new DataTable();
            sda.Fill(dtroleitem);
            comboBoxRoleItem.DataSource = dtroleitem;
            comboBoxRoleItem.DisplayMember = dtroleitem.Columns["Name"].ToString();
            comboBoxRoleItem.ValueMember = dtroleitem.Columns["id"].ToString();

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



                sqlcmd.CommandText = "SELECT `ID`, `DeviceSerialName`, `DeviceSerialCode` FROM `DeviceSerial` WHERE  `Enabled`=true order by DeviceSerialName ";
                sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
                DataTable FunMask = new DataTable();
                sda.Fill(FunMask);
                comboBoxSerial.DataSource = FunMask;
                comboBoxSerial.DisplayMember = FunMask.Columns["DeviceSerialName"].ToString();
                comboBoxSerial.ValueMember = FunMask.Columns["id"].ToString();



                sqlcmd.CommandText = "SELECT `ID`, `DeviceHardVersionName`, `DeviceHardVersionCode`, `UpdateTime` FROM `DeviceHardVersion` WHERE 1 order by  DeviceHardVersionName";
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
        private void buttonFunCheckItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(connStr);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                sqlcmd.CommandText = string.Format("INSERT INTO `FunctionProductionProcessItem`(`ID`, `FunctionID`, `ProductionProcessItemID`) VALUES (UUID(),'{0}','{1}')", comboBoxFun.SelectedValue.ToString(), comboBoxCheckItem.SelectedValue.ToString());

                sqlcmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("OK");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddFunList_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(connStr);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                sqlcmd.CommandText = string.Format("INSERT INTO `FunEnum`(`ID`, `FunctionID`, `FunMask`) VALUES (UUID(),'{0}','{1}')", comboBoxFunID.SelectedValue.ToString(), textBoxFunValue.Text);

                sqlcmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("OK");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定要删除", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                MySqlConnection sqlCon = new MySqlConnection(connStr);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                sqlcmd.CommandText = string.Format("delete from DeviceFunList where DeviceTypeID='{0}' and FunID='{1}';", comboBoxDeviceType.SelectedValue.ToString(), comboBoxFunID.SelectedValue.ToString());
                sqlcmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("OK");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCloneDeviceType_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(connStr);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                sqlcmd.Transaction = sqlcmd.Connection.BeginTransaction();
                string devicetypeid = comboBoxDeviceType.SelectedValue.ToString();
                string id = Guid.NewGuid().ToString();
                sqlcmd.CommandText = string.Format(" INSERT INTO `DeviceType`(`ID`, `TypeName`, `Detail`, `Enabled`, `DeviceSerialID`, `DeviceHardVersionID`, `HHUCheckAppVersion`, `SecUnitVersion`) select '{1}', concat(TypeName,' 克隆待修改'),Detail,0,'dcf0ace2-3d3f-11e4-89a3-000c29344e67',DeviceHardVersionID,HHUCheckAppVersion,SecUnitVersion from  DeviceType where id='{0}'; ", devicetypeid, id);
                int x = sqlcmd.ExecuteNonQuery();
                if (x > 0)
                {
                    sqlcmd.CommandText = string.Format("INSERT INTO `DeviceFunList`(`ID`, `DeviceTypeID`, `FunID`, `FunMaskID`) select UUID(),'{0}',FunID,FunMaskID from DeviceFunList where  DeviceTypeID='{1}'", id, devicetypeid);
                    x = sqlcmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        sqlcmd.Transaction.Commit();
                    }
                    else
                    {
                        sqlcmd.Transaction.Rollback();
                    }
                }
                else
                {
                    sqlcmd.Transaction.Rollback();
                }
                sqlCon.Close();
                MessageBox.Show("OK");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAuthAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(connStr);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                sqlcmd.CommandText = string.Format("INSERT INTO `RoleAuthorityList`(`ID`, `RoleID`, `AuthorityItemID`) VALUES (UUID(),'{0}','{1}')", comboBoxRole.SelectedValue.ToString(), comboBoxRoleItem.SelectedValue.ToString());

                sqlcmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("OK");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetAllType_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection(connStr);
            try
            {
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "SELECT `ID`, `TypeName`, `Enabled`, `DeviceSerialID`, `DeviceHardVersionID`, `UpdateTime` FROM `DeviceType` order by TypeName";
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd.CommandText, sqlCon);
                sda.Fill(boxType);
                comboBoxDeviceType.DataSource = boxType;
                comboBoxDeviceType.DisplayMember = boxType.Columns["TypeName"].ToString();
                comboBoxDeviceType.ValueMember = boxType.Columns["ID"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Clone();
                sqlCon.Dispose();
            }

        }

       
    }
}

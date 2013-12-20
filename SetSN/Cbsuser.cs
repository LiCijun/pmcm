using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace SetSN
{
    class Cbsuser
    {
        public static bool Create(string path)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                //创建表  
                string sql = "CREATE TABLE IF NOT EXISTS `bsuser` (" +
                              "`ID` char(36) NOT NULL COMMENT 'ID'," +
                              "`USER` varchar(15) NOT NULL COMMENT '登录用户名'," +
                              "`PASSWORD` varchar(32) NOT NULL COMMENT '登录密码'," +
                              "`ENTERTIME` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '登录时间'," +
                              "`EXITTIME` time DEFAULT NULL COMMENT '退出时间'," +
                              "PRIMARY KEY (`ID`)" +
                              ") ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='系统用户数据';"; 
                sqlcmd.CommandText = sql;
                int i = sqlcmd.ExecuteNonQuery();

                return i == 0;
            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static bool Insert(string path, Cuser usr)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "INSERT INTO bsuser(ID, USER, PASSWORD, ENTERTIME, EXITTIME) VALUES(uuid(),@USER, @PASSWORD, @ENTERTIME, @EXITTIME);";
                sqlcmd.Parameters.Add(new MySqlParameter("USER", usr.USER));
                sqlcmd.Parameters.Add(new MySqlParameter("PASSWORD", usr.PASSWORD));
                sqlcmd.Parameters.Add(new MySqlParameter("ENTERTIME", usr.ENTERTIME));
                sqlcmd.Parameters.Add(new MySqlParameter("EXITTIME", usr.EXITTIME));
                int i = sqlcmd.ExecuteNonQuery();

                return i == 1;
            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static bool Update(string path, Cuser usr)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "UPDATE bsuser SET PASSWORD=@PASSWORD,EXITTIME=@EXITTIME where USER=@USER;";
                sqlcmd.Parameters.Add(new MySqlParameter("USER", usr.USER));
                sqlcmd.Parameters.Add(new MySqlParameter("PASSWORD", usr.PASSWORD));
                sqlcmd.Parameters.Add(new MySqlParameter("EXITTIME", usr.EXITTIME));
                int i = sqlcmd.ExecuteNonQuery();

                return i == 1;

            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static bool Delete(string path, Cuser usr)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "DELETE FROM `bsuser` WHERE `USER`=@USER";
                sqlcmd.Parameters.AddWithValue("USER", usr.USER);
                
                int i = sqlcmd.ExecuteNonQuery();

                return i == 1;

            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static Cuser Getuser(string path, Cuser usr)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "SELECT  `PASSWORD`, `ENTERTIME`,`EXITTIME` FROM `bsuser` WHERE `USER`=@USER";
                sqlcmd.Parameters.AddWithValue("USER", usr.USER);
                MySqlDataReader sdr = sqlcmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (sdr.Read())
                {

                    usr.PASSWORD = sdr.GetString(0);
                    usr.ENTERTIME = sdr.GetString(1);
                    usr.EXITTIME = sdr.GetString(2);
                    return usr;
                }
                else
                    return null;


            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return null;
            }
        }
    }
}

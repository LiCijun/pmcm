using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace SetSN
{
    class Cbsdata
    {
        public static bool Create(string path)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();
                
                //创建表  
                string sql = "CREATE TABLE IF NOT EXISTS `bsdata` (" +
                              "`ID` char(36) NOT NULL COMMENT 'ID'," +
                              "`BOXSN` varchar(10) NOT NULL COMMENT '箱号'," +
                              "`TYPE` varchar(5) NOT NULL COMMENT '掌机型号'," +
                              "`DAY` date DEFAULT '2000-01-01' COMMENT '生产日期'," +
                              "`PSN` varchar(16) NOT NULL COMMENT '产品序列号'," +
                              "`MSSN` varchar(14) DEFAULT NULL COMMENT '微软授权号'," +
                              "`UPDATETIME` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间'," +
                              "PRIMARY KEY (`ID`)," +
                              "UNIQUE KEY `PSN` (`PSN`)" +
                              ") ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='装箱数据';";
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

        public static bool Insert(string path, Cdata box)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "INSERT INTO bsdata(ID,BOXSN,TYPE,DAY,PSN,MSSN) VALUES(uuid(),@BOXSN,@TYPE,@DAY,@PSN,@MSSN);";
                sqlcmd.Parameters.Add(new MySqlParameter("BOXSN", box.BOXSN));
                sqlcmd.Parameters.Add(new MySqlParameter("TYPE", box.TYPE));
                sqlcmd.Parameters.Add(new MySqlParameter("DAY", box.DAY));
                sqlcmd.Parameters.Add(new MySqlParameter("PSN", box.PSN));
                sqlcmd.Parameters.Add(new MySqlParameter("MSSN", box.MSSN));
                int i = sqlcmd.ExecuteNonQuery();

                return i == 1;
            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static bool Update(string path, Cdata box)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "UPDATE bsdata SET BOXSN=@BOXSN,TYPE=@TYPE,DAY=@DAY,MSSN=@MSSN where PSN=@PSN;";
                sqlcmd.Parameters.Add(new MySqlParameter("BOXSN", box.BOXSN));
                sqlcmd.Parameters.Add(new MySqlParameter("TYPE", box.TYPE));
                sqlcmd.Parameters.Add(new MySqlParameter("DAY", box.DAY));
                sqlcmd.Parameters.Add(new MySqlParameter("PSN", box.PSN));
                sqlcmd.Parameters.Add(new MySqlParameter("MSSN", box.MSSN));
                int i = sqlcmd.ExecuteNonQuery();
                
                return i == 1;

            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static bool Delete(string path, Cdata box)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "DELETE FROM `bsdata` WHERE `DAY`=@DAY OR `BOXSN`=@BOXSN OR `TYPE`=@TYPE OR `PSN`=@PSN OR `MSSN`=@MSSN";
                sqlcmd.Parameters.AddWithValue("DAY", box.DAY);
                sqlcmd.Parameters.AddWithValue("BOXSN", box.BOXSN);
                sqlcmd.Parameters.AddWithValue("TYPE", box.TYPE);
                sqlcmd.Parameters.AddWithValue("PSN", box.PSN);
                sqlcmd.Parameters.AddWithValue("MSSN", box.MSSN);
                int i = sqlcmd.ExecuteNonQuery();
           
                return i == 1;

            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static Cdata Getdata(string path, Cdata box)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "SELECT  `DAY`, `BOXSN` , `TYPE` , `PSN` , `MSSN`, `UPDATETIME` FROM `bsdata` WHERE `DAY`=@DAY OR `BOXSN`=@BOXSN OR `TYPE`=@TYPE OR `PSN`=@PSN OR `MSSN`=@MSSN";
                sqlcmd.Parameters.AddWithValue("DAY", box.DAY);
                sqlcmd.Parameters.AddWithValue("BOXSN", box.BOXSN);
                sqlcmd.Parameters.AddWithValue("TYPE", box.TYPE);
                sqlcmd.Parameters.AddWithValue("PSN", box.PSN);
                sqlcmd.Parameters.AddWithValue("MSSN", box.MSSN);           
                MySqlDataReader sdr = sqlcmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if(sdr.Read())
                {
                    
                    box.DAY = sdr.GetString(0);
                    box.BOXSN = sdr.GetString(1);
                    box.TYPE = sdr.GetString(2);
                    box.PSN= sdr.GetString(3);
                    box.MSSN  = sdr.GetString(4);
                    box.UPDATETIME = sdr.GetString(5);
                    return box;
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

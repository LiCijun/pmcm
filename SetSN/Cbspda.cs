using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace SetSN
{
    class Cbspda
    {
        public static bool Create(string path)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                //创建表  
                string sql = "CREATE TABLE IF NOT EXISTS `bspda` (" +
                              "`ID` char(36) NOT NULL COMMENT 'ID'," +
                              "`PDA` varchar(5) NOT NULL COMMENT '掌机型号'," +
                              "`FUNCTION` varchar(100) NOT NULL COMMENT '掌机硬件功能'," +
                              "`UPDATETIME` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间'," +
                              "PRIMARY KEY (`ID`)," +
                              "UNIQUE KEY `PDA` (`PDA`)" +
                              ") ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='掌机型号数据';";
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

        public static bool Insert(string path, Cpda type)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "INSERT INTO bspda(ID, PDA, FUNCTION) VALUES(uuid(),@PDA, @FUNCTION);";
                sqlcmd.Parameters.Add(new MySqlParameter("PDA", type.PDA));
                sqlcmd.Parameters.Add(new MySqlParameter("FUNCTION", type.FUNCTION));
                int i = sqlcmd.ExecuteNonQuery();

                return i == 1;
            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static bool Update(string path, Cpda type)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "UPDATE bspda SET FUNCTION=@FUNCTION where PDA=@PDA;";
                sqlcmd.Parameters.Add(new MySqlParameter("PDA", type.PDA));
                sqlcmd.Parameters.Add(new MySqlParameter("FUNCTION", type.FUNCTION));
                int i = sqlcmd.ExecuteNonQuery();

                return i == 1;

            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static bool Delete(string path, Cpda type)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "DELETE FROM `bspda` WHERE `PDA`=@PDA";
                sqlcmd.Parameters.AddWithValue("PDA", type.PDA);
                
                int i = sqlcmd.ExecuteNonQuery();

                return i == 1;

            }
            catch (Exception)
            {
                //Do　any　logging　operation　here　if　necessary  
                return false;
            }
        }

        public static Cpda Getpda(string path, Cpda type)
        {
            try
            {
                MySqlConnection sqlCon = new MySqlConnection(path);
                sqlCon.Open();
                MySqlCommand sqlcmd = sqlCon.CreateCommand();

                sqlcmd.CommandText = "SELECT  `FUNCTION` FROM `bspda` WHERE `PDA`=@PDA";
                sqlcmd.Parameters.AddWithValue("PDA", type.PDA);              
                MySqlDataReader sdr = sqlcmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (sdr.Read())
                {
                    type.FUNCTION = sdr.GetString(0);

                    return type;
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

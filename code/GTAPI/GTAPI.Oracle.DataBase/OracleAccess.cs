using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAPI.Oracle.DataBase
{
    public class OracleAccess
    {
        public static string ConnectOracle()
        {
            try
            {
                string connString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.239)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));Persist Security Info=True;User ID=xj_gtapi;Password=gtapi;";
                // "Data Source= (DESCRIPTION =     (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.1.115)(PORT = 1521))     (CONNECT_DATA =       (SERVER = DEDICATED)       (SERVICE_NAME = ORCL)     )   );User ID=PMDB;Password=officialsite;Persist Security Info=True" providerName="Oracle.ManagedDataAccess.Client" 
                OracleConnection conn = new OracleConnection(connString);
                var sql = "select ID from DEP_DEPARTMENT"; 
                OracleCommand cmd = new OracleCommand(); 
                cmd.Connection = conn;
                conn.Open(); 
                cmd.CommandText = sql; 
                Object ret = cmd.ExecuteScalar();


                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}

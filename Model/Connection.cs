using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMdotNet.Model
{
    public class Connection
    {
        private static Connection Con = null;
        public Connection() { }
        public OracleConnection CreateConnection()
        {
            OracleConnection String = new OracleConnection();
            try
            {
                String.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));" +
                                          "User Id=LFADMIN;Password=admin;";

            }
            catch (Exception ex)
            {
                String = null;
                throw ex;
            }
            return String;
        }

        public static Connection getInstance()
        {
            if( Con == null )
            {
                Con = new Connection();
            }
            return Con;
        }
    }
}

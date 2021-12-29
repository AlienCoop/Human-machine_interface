using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_machine_interface.Backend
{
    class DBConnection
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-A116UEN";
            string database = "DataBase";
            string username = "";
            string password = "";
            return DBSQLServerUtils.GetDBConnection(datasource, database, username,  password);
        }
    }
   
}

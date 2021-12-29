using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_machine_interface.Backend
{

    //Data Source = DESKTOP - A116UEN; Initial Catalog = DataBase; Integrated Security = True;
    
    class DBSQLServerUtils
    {
        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security = True;";
            
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}

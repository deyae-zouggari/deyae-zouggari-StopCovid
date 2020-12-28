using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;


namespace stopcovid2
{
    class ConnectSQLServer
    {
        public static SqlConnection GetDBConnection(string datasource, string database)
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=DESKTOP-D7HHOO9;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
            

            return conn;
        }

    }
}


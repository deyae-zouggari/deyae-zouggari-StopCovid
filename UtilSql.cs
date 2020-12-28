using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace stopcovid2
{
    class UtilSql
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-D7HHOO9";

            string database = "StopCovid";
            

            return ConnectSQLServer.GetDBConnection(datasource, database);

        }
    }
}

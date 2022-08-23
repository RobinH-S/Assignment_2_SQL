using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCoding
{
    public static class CustomerDBConfig
    {
        public static string GetConnectionString()                                      //Is called in costumer class. Not working???
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            //(LocalDb)\\MSSQLLocalDB
            conn.DataSource = @"N-NO-01-04-1901\SQLEXPRESS";                          //ADD Correct Path to database 
            conn.InitialCatalog = "Chinook";                                           //database
            conn.IntegratedSecurity = true;
            return conn.ConnectionString;
        }
    }

}

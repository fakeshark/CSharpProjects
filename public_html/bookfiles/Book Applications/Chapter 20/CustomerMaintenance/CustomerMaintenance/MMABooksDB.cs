using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CustomerMaintenance
{
    // This application is described in chapter 20 of
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            // If necessary, change the following connection string
            // so it works for your system
            string connectionString =
                "Data Source=localhost\\SqlExpress;Initial Catalog=MMABooks;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

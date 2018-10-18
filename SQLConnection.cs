using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace HW5
{
    class SQLConnection
    {
        public static string connectionString = "Data Source=AVIAD-PC\\SQLEXPRESS;Initial Catalog=TFL_HW2;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(connectionString);
        public static TFLDataContext dbDataContext = new TFLDataContext(connectionString);
        public static TFLDataContext GetDataContextInstance()
        {
            return dbDataContext;
        }
    }
}

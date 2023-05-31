using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyTk
{
    class Connection
    {
        private static string connection = "Data Source=DESKTOP-CDO0SQ2\\SQLEXPRESS;Initial Catalog=QL_KOL;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(connection);
        }
    }
}

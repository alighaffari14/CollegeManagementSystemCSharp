using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace College_Management_System
{
    class Connection
    {
        static string path = @"Data Source=GHAFFARI\ALIGHAFFARI;Initial Catalog=CMS;Integrated Security=True";
        public static SqlConnection authorize()
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            return con;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gharparapp
{
    class CONNECTION
    {
        public static SqlConnection conn;

         static public SqlConnection GetConnection()
        {
            string strconn = ConfigurationManager.ConnectionStrings["gharparapp.Properties.Settings.GHARPARAPPConnectionString"].ToString();
            conn = new SqlConnection(strconn);
            conn.Open();
            return conn;
        }


    }
}


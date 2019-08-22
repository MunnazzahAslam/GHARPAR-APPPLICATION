using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace gharparapp
{
    class DAL
    {
        
        public static void customerdel(string query,string message)
        {
            SqlCommand cmd = new SqlCommand(query, gharparapp.CONNECTION.GetConnection());
            cmd.ExecuteNonQuery();
            MessageBox.Show(message);
            
           
        }
        public static void Empdel(string query, string message)
        {
            SqlCommand cmd = new SqlCommand(query, gharparapp.CONNECTION.GetConnection());
            cmd.ExecuteNonQuery();
            MessageBox.Show(message);


        }
        public static void Homeserdel(string query, string message)
        {
            SqlCommand cmd = new SqlCommand(query, gharparapp.CONNECTION.GetConnection());
            cmd.ExecuteNonQuery();
            MessageBox.Show(message);


        }
        public static void CookSerdel(string query, string message)
        {
            SqlCommand cmd = new SqlCommand(query, gharparapp.CONNECTION.GetConnection());
            cmd.ExecuteNonQuery();
            MessageBox.Show(message);


        }
        public static void Makeupdel(string query, string message)
        {
            SqlCommand cmd = new SqlCommand(query, gharparapp.CONNECTION.GetConnection());
            cmd.ExecuteNonQuery();
            MessageBox.Show(message);


        }
        public static void Insert(string query, string message)
        {
            SqlCommand cmd = new SqlCommand(query, gharparapp.CONNECTION.GetConnection());
            cmd.ExecuteNonQuery();
            MessageBox.Show(message);


        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace gharparapp
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CYBER\SQLEXPRESS;Initial Catalog=GHARPARAPP;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Customer set review='" + textBox4.Text + "'where Name='"+textBox1.Text+"'" ;
            cmd.ExecuteNonQuery();
            conn.Close();
            Form13 Form13 = new Form13();
            Form13.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

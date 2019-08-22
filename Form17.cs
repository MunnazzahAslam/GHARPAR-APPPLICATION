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
    public partial class Form17 : Form
    {
        
        public Form17()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CYBER\SQLEXPRESS;Initial Catalog=GHARPARAPP;Integrated Security=True");
       
  
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            conn.Open();
            string query = "SELECT * FROM MakeupServices";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            conn.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {

            Form7 Form7 = new Form7();
            Form7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form21 Form21 = new Form21();
            Form21.Show();
            this.Hide();
            
        }

       
    }
}

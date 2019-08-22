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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CYBER\SQLEXPRESS;Initial Catalog=GHARPARAPP;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string CustomerName = textBox1.Text;
            string CustomerPassword = textBox2.Text;
            SqlCommand cmd = new SqlCommand("Select Name, Password from Customer where Name='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", conn);
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Form3 Form3 = new Form3();
                Form3.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Your username or password is incorrect, please signup first!");
            }
            conn.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();

        }
    }
}

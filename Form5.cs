using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
namespace gharparapp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox6.PasswordChar = '*';
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CYBER\SQLEXPRESS;Initial Catalog=GHARPARAPP;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Customer(Name,Phone,CNIC,Address,Email,Password) VALUES('" + textBox1.Text + "','"+textBox2.Text + "','"+ textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
                MessageBox.Show("You've been successfully registered, enjoy our app.");
                Form3 Form3 = new Form3();
                Form3.Show();
                this.Hide();
            
            }
        
        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            Random r = new Random(Environment.TickCount);
            string n = r.Next(0, 10000).ToString();
            textBox7.Text = "0000".Substring(0, 4 - n.Length) + n;
        }
    }
}

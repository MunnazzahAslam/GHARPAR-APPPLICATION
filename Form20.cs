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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        int selectedRowIndex;
        SqlConnection conn = new SqlConnection(@"Data Source=CYBER\SQLEXPRESS;Initial Catalog=GHARPARAPP;Integrated Security=True");

       
       

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Employee";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM CookingServices";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Customer";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            conn.Close();
        }



        private void button10_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM HomeServices";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM MakeupServices";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRowIndex];


            SqlCommand cmd = new SqlCommand(@"INSERT INTO Employee(EmpName,EmpDept,EmpPhone) VALUES( '" + row.Cells[1].Value + "', '" + row.Cells[2].Value + "','" + row.Cells[3].Value+ "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("INSERTED");

        }
        
        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRowIndex];


            SqlCommand cmd = new SqlCommand(@"INSERT INTO CookingServices(Services,Charges) VALUES( '" + row.Cells[1].Value + "', '" + row.Cells[2].Value + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("INSERTED");

        }
                private void button13_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRowIndex];


            SqlCommand cmd = new SqlCommand(@"INSERT INTO HomeServices(Services,Charges) VALUES( '" + row.Cells[1].Value + "', '" + row.Cells[2].Value + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            MessageBox.Show("INSERTED");
        }


        private void button12_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRowIndex];


            SqlCommand cmd = new SqlCommand(@"INSERT INTO MakeupServices(Services,Charges) VALUES( '" + row.Cells[1].Value + "', '" + row.Cells[2].Value + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("INSERTED");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gharparapp.DAL.Empdel("delete from Employee where EmpId=" + dataGridView1.SelectedRows[0].Cells[0].Value + "", "DELETED");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            gharparapp.DAL.customerdel("delete from Customer where Sno="+dataGridView1.SelectedRows[0].Cells[0].Value+"","DELETED");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gharparapp.DAL.CookSerdel("delete from CookingServices where Sno=" + dataGridView1.SelectedRows[0].Cells[0].Value + "", "DELETED");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            gharparapp.DAL.Homeserdel("delete from HomeServices where Sno=" + dataGridView1.SelectedRows[0].Cells[0].Value + "", "DELETED");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            gharparapp.DAL.Makeupdel("delete from MakeupServices where Sno=" + dataGridView1.SelectedRows[0].Cells[0].Value + "", "DELETED");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRowIndex];


            SqlCommand cmd = new SqlCommand(@"INSERT INTO Customer(Name,Phone,CNIC,Email,Address,Review,Password) VALUES( '" + row.Cells[1].Value + "', '" + row.Cells[2].Value + "','"+row.Cells[3]+"','"+row.Cells[4]+"','"+row.Cells[5]+"','"+row.Cells[6]+"','"+row.Cells[7]+"')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("INSERTED");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


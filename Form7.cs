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
using System.Configuration;

namespace gharparapp
{
    public partial class Form7 : Form
    {
       
       
        public Form7()
        { 
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form17 Form17 = new Form17();
            Form17.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form18 Form18 = new Form18();
            Form18.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form19 Form19 = new Form19();
            Form19.Show();
            this.Hide();
        }
    }
}

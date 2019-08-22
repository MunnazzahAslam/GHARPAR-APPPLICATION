using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gharparapp
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin") ;
            comboBox1.Items.Add("User");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Admin")
            {
                MessageBox.Show("Hello Admin");
                Form20 Form20 = new Form20();
                Form20.Show();
                this.Hide();
            }
            else
            {
                Form2 Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*  private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {
              Form7 Form7 = new Form7();
              Form7.Show();
              this.Hide();
          }
          */

    }
}

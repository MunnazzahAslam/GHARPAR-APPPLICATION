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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form15 Form15 = new Form15();
            Form15.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 Form12 = new Form12();
            Form12.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form14 Form14 = new Form14();
            Form14.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form11 Form11 = new Form11();
            Form11.Show();
            this.Hide();
        }
    }
}

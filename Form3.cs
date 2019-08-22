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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
        }
    }
}

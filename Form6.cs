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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form16 Form16 = new Form16();
            Form16.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

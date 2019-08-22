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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form23 Form23 = new Form23();
            Form23.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            
        }
    }
}

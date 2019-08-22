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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            this.Hide();
        }
    }
}

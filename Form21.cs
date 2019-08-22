using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gharparapp
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
            
        }
        Bitmap bmp;
        private void Form21_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Home Services");
            comboBox1.Items.Add("Cooking Services");
            comboBox1.Items.Add("Makeup Services");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 Form22 = new Form22();
            Form22.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Dusting")
            {
                comboBox3.Items.Add("Sana");
                textBox1.Text = "500";
            }
            else if (comboBox2.SelectedItem.ToString() == "Party Makeup")
            {
                comboBox3.Items.Add("Natasha");
                textBox1.Text = "2000";
            }
            else
            {
                comboBox3.Items.Add("Sidra");
                textBox1.Text = "1000";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Home Services")
            {
                comboBox2.Items.Add("Dusting");
                comboBox2.Items.Add("Home Cleaning");
                comboBox2.Items.Add("Laundary");
                comboBox2.Items.Add("Closet Cleaning");
                comboBox2.Items.Add("Dish Washing");

            }

            else if (comboBox1.SelectedItem.ToString() == "Makeup Services")
            {
                comboBox2.Items.Add("Party Makeup");
                comboBox2.Items.Add("Bridal Makeup");
                comboBox2.Items.Add("Half Arm Waxing");
                comboBox2.Items.Add("Full Arm Waxing");
                comboBox2.Items.Add("Half Leg Waxing");
                comboBox2.Items.Add("Full Leg Waxing");
                comboBox2.Items.Add("Facial");
                comboBox2.Items.Add("Bleach");
                comboBox2.Items.Add("Manicure");
                comboBox2.Items.Add("Pedicure");
            }
            else if (comboBox1.SelectedItem.ToString() == "Cooking Services")
            {
                comboBox2.Items.Add("Biryani");
                comboBox2.Items.Add("Korma");
                comboBox2.Items.Add("Karahi");
                comboBox2.Items.Add("Qeema");
                comboBox2.Items.Add("Shami Kabab");
                comboBox2.Items.Add("Kofta");
                comboBox2.Items.Add("Pulao");
                comboBox2.Items.Add("Handi");
                comboBox2.Items.Add("Tikka");
                comboBox2.Items.Add("Pizza");
                comboBox2.Items.Add("Haleem");

            }
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form17 Form17 = new Form17();
            Form17.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reciept:"+"\n"+ "Employee Name:"+comboBox3.Text+ "\n" + "Service:" +comboBox2.Text+    "\n"+    "Total:"+textBox1.Text+"\n"+"Thankyou!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int num2 = 200;
            int sum = num - num2;
            textBox1.Text = sum.ToString();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
    }
    }
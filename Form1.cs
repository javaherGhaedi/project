using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            add_customers ac = new add_customers();
            ac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tourshomal ts = new tourshomal();
            ts.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            personnels ps = new personnels();
            ps.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customers cs = new customers();
            cs.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            booked_flight bf = new booked_flight();
            bf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tourdubai td = new tourdubai();
            td.Show();

        }
    }
}

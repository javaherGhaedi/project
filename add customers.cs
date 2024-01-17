using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class add_customers : Form
    {
        public add_customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string name = textBox1.Text;
                string lastname = textBox2.Text;
                string fathername = textBox3.Text;
                string codemeli = textBox4.Text;
                string birthday = textBox5.Text;
                string gender = textBox6.Text;
                string phonenumber = textBox7.Text;

                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\code barname sazi visual studio\project\project\Database1.mdf"";Integrated Security=True");
                sc.Open();
                string cmd = "INSERT INTO customers-Table (name,lastname,fathername,codemeli,birthday,gender,phonenumber) VALUES ('" + name + "','" + lastname + "','" + fathername + "','" + codemeli + "','" + birthday + "','" + gender + "','" + phonenumber + "')";
                SqlCommand command = new SqlCommand(cmd, sc);
                command.ExecuteNonQuery();
                
                MessageBox.Show("Changes have been save!!!");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
                sc.Close();


            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  
    }
}

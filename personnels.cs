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
    public partial class personnels : Form
    {
        public personnels()
        {
            InitializeComponent();
        }

        private void personnels_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\code barname sazi visual studio\project\project\Database1.mdf"";Integrated Security=True";

                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                string cmd = " SELECT name FROM personels-Table";
                SqlCommand command = new SqlCommand(cmd, connection);

                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    string name = sdr["name"].ToString();
                    comboBox1.Items.Add(name);
                    

                        
                
                }
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

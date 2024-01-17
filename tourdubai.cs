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
    public partial class tourdubai : Form
    {
        public tourdubai()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tourdubai_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\code barname sazi visual studio\project\project\Database1.mdf"";Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                string cmd = "SELECT * FROM tour dubai_Table";
                SqlCommand command = new SqlCommand(cmd, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["from"] + "-" + reader["up to date"] + "-" + reader["leader"] + "-" + reader["hotel"] + "-" + reader["price"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

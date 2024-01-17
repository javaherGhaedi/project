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
    public partial class tourshomal : Form
    {
        public tourshomal()
        {
            InitializeComponent();
        }

        private void tourshomal_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\code barname sazi visual studio\project\project\Database1.mdf"";Integrated Security=True");
                sc.Open();
                string cmd = "SELECT * FROM tour shomals_Table  ";
                SqlCommand command = new SqlCommand(cmd, sc);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["from"] + "-" + reader["up to date"] + "-" + reader["leader"] + "-" + reader["hotel"] + "-" + reader["price"]);
                    string from = reader["from"].ToString();
                    comboBox1.Items.Add(from);
                }
                sc.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class booked_flight : Form
    {
        public booked_flight()
        {
            InitializeComponent();
        }

        private void booked_flight_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\code barname sazi visual studio\project\project\Database1.mdf"";Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                string cmd = "SELECT flight num FROM bookedflight-Table";
                SqlCommand command = new SqlCommand(cmd, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["flight num"]);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

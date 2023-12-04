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

namespace uni_project._3
{
    public partial class showSql : Form
    {
        public showSql()
        {
            InitializeComponent();
        }

        private void showSql_Load(object sender, EventArgs e)
        {

            SqlConnection cnn;
            string conect = @"C:\Users\MosooTech\source\repos\uni-project.3\uni-project.3\Database1.mdf;Integrated Security=True";

            cnn = new SqlConnection(conect);
            string query = "SELECT * FROM MyTable WHERE ID=1";
            cnn.Open();
            SqlCommand command = new SqlCommand(query, cnn);
            DataTable dataTable = new DataTable();
            SqlDataReader reader = command.ExecuteNonQuery();
        }
    }
}

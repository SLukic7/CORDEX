using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CordexZavrsniRad
{
    public partial class AddGroup : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public AddGroup()
        {
            InitializeComponent();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            string query;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("ERROR while adding new group. Check if you have entered all the information!");
            }
            else
            {

                query = "INSERT INTO ItemGroup (ItemGroupName) VALUES('" + txtName.Text + "')";

                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Group successfully added!");
                conn.Close();
            }
        }

        private void AddGroup_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            this.Hide();
        }
    }
}

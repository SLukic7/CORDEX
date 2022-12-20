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
    public partial class NewStorage : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public NewStorage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            string query;
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAdress.Text))
            {
                MessageBox.Show("ERROR while adding new storage. Check if you have entered all the information!");
            }
            else
            {
               
                query = "INSERT INTO StorageInfo (StorageName,StorageAdress) VALUES('" + txtName.Text + "','" + txtAdress.Text +"')";

                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Storage successfully added!");
                conn.Close();
            }
        }

        private void NewStorage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void NewStorage_Load(object sender, EventArgs e)
        {

        }
    }
}

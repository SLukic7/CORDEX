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
    public partial class RemoveStorage : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public RemoveStorage()
        {
            InitializeComponent();
        }

        private void RemoveStorage_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT StorageName From StorageInfo Where StorageID <> " + Storage.storageID, conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbStorage.DataSource = dt;
            cmbStorage.DisplayMember = "StorageName";
            cmbStorage.ValueMember = "StorageName";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_RemoveStorage", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@storage1", Storage.storageID));
            SqlCommand cmdStorage2 = new SqlCommand("Select StorageID From StorageInfo Where StorageName = '" + cmbStorage.SelectedValue + "'", conn);
            int storage2 = int.Parse(cmdStorage2.ExecuteScalar().ToString());
            cmd.Parameters.Add(new SqlParameter("@storage2", storage2));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Storage successfully removed!");
            conn.Close();
        }

        private void RemoveStorage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

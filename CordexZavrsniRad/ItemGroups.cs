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
    public partial class ItemGroups : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        Form newGroup = new AddGroup();
        public ItemGroups()
        {
            InitializeComponent();
        }

        private void ItemGroups_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM ItemGroup",conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvItemGroup.DataSource = dt;
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM ItemGroup WHERE ItemGroupName LIKE '%" + txtSearch.Text + "%'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvItemGroup.DataSource = dt;
            conn.Close();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            dgvItemGroup.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM ItemGroup", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvItemGroup.DataSource = dt;
            conn.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            newGroup.Show();
        }
    }
}

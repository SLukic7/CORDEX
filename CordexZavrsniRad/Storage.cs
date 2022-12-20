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
    public partial class Storage : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        Form newStorage = new NewStorage();
        public static int storageID;
        public Storage()
        {
            InitializeComponent();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT StorageName From StorageInfo", conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbStorage.DataSource = dt;
            cmbStorage.DisplayMember = "StorageName";
            cmbStorage.ValueMember = "StorageName";
            conn.Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM view_Storage WHERE StorageName = '"+cmbStorage.SelectedValue+"'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvStorage.DataSource = dt;
            dgvStorage.Columns[0].ReadOnly = true;
            dgvStorage.Columns[1].ReadOnly = true;
            dgvStorage.Columns[3].ReadOnly = true;
            dgvStorage.Columns[4].ReadOnly = true;
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM view_Storage WHERE StorageName = '" + cmbStorage.SelectedValue + "' AND ArticleName LIKE '%" + txtSearch.Text + "%'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvStorage.DataSource = dt;
            conn.Close();
        }

        private void btnNewStorage_Click(object sender, EventArgs e)
        {
            newStorage.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            string command1 = "Select ArticleNo From STORAGE_ARTICLE Where ArticleNo = (Select ArticleNo From Article Where ArticleName = '"+ dgvStorage.CurrentRow.Cells[0].Value.ToString()+"')";
            SqlCommand cmdArticleNo = new SqlCommand(command1,conn);
            int articleNo = int.Parse(cmdArticleNo.ExecuteScalar().ToString());

            string command2 = "Select StorageID From StorageInfo Where StorageName = '" + cmbStorage.SelectedValue + "'";
            SqlCommand cmdStorageID = new SqlCommand(command2, conn);
            int storageID = int.Parse(cmdStorageID.ExecuteScalar().ToString());

            string command3 = "Select SOH From STORAGE_ARTICLE Where ArticleNo = (Select ArticleNo From Article Where ArticleName = '" + dgvStorage.CurrentRow.Cells[0].Value.ToString() + "')";
            SqlCommand cmdSOH = new SqlCommand(command3, conn);
            int soh = int.Parse(cmdSOH.ExecuteScalar().ToString());

            //DialogResult dialogResult = MessageBox.Show("Do you want to remove selected article from current storage?", "Transfer article", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
                string updateStorage = "UPDATE STORAGE_ARTICLE SET StorageID = " + storageID + "WHERE ArticleNo = " + articleNo;
                if (cmbStorage.SelectedItem != null)
                {
                    SqlCommand cmdUpdate = new SqlCommand(updateStorage, conn);
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Article successfully trasfered!");
                }
                else
                {
                    MessageBox.Show("ERROR while transfering article to storage! Check if you have choosen both storage and article!");
                }
            //}
            //if(dialogResult == DialogResult.No)
            //{
            //    string insertStorage = "INSERT INTO STORAGE_ARTICLE(StorageID, ArticleNo, SOH) VALUES(" + storageID + "," + articleNo + "," + soh + ")";
            //    if (cmbStorage.SelectedItem != null)
            //    {
            //        SqlCommand cmdInsert = new SqlCommand(insertStorage, conn);
            //        cmdInsert.ExecuteNonQuery();
            //        MessageBox.Show("Article successfully trasfered!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("ERROR while transfering article to storage! Check if you have choosen both storage and article!");
            //    }
            //}
            conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cmbStorage.SelectedIndex != -1)
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT StorageName From StorageInfo", conn);
                dt = new DataTable();
                sda.Fill(dt);
                cmbStorage.DataSource = dt;
                cmbStorage.DisplayMember = "StorageName";
                cmbStorage.ValueMember = "StorageName";
                sda = new SqlDataAdapter(@"SELECT * FROM view_Storage WHERE StorageName = '" + cmbStorage.SelectedValue + "'", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvStorage.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Choose the Storage!");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            SqlCommand cmdArticleNo = new SqlCommand("Select ArticleNo From Article Where ArticleName = '" + dgvStorage.CurrentRow.Cells[0].Value.ToString() + "'", conn);
            int articleNo = int.Parse(cmdArticleNo.ExecuteScalar().ToString());
            SqlCommand updateSOH = new SqlCommand("Update STORAGE_ARTICLE Set SOH = " + dgvStorage.CurrentRow.Cells[2].Value.ToString() + " Where ArticleNo = " + articleNo, conn);
            int rowsAffected = updateSOH.ExecuteNonQuery();
            if(rowsAffected > 0)
            {
                MessageBox.Show("Update successfull!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            SqlCommand cmdStorageID = new SqlCommand("Select StorageID From StorageInfo Where StorageName = '" + cmbStorage.SelectedValue + "'", conn);
            storageID = int.Parse(cmdStorageID.ExecuteScalar().ToString());
            RemoveStorage rs = new RemoveStorage();
            rs.Show();
            conn.Close();
        }
    }
}

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
    public partial class Invoices : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Invoices()
        {
            InitializeComponent();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT SupplierFullName From Supplier", conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbSuppliers.DataSource = dt;
            cmbSuppliers.DisplayMember = "SupplierFullName";
            cmbSuppliers.ValueMember = "SupplierFullName";
            sda = new SqlDataAdapter(@"SELECT StorageID,StorageName From StorageInfo", conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbStorage.DataSource = dt;
            cmbStorage.DisplayMember = "StorageName";
            cmbStorage.ValueMember = "StorageID";
            sda = new SqlDataAdapter(@"SELECT * From view_Invoices", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_Invoices WHERE InvoiceNo LIKE '%" + txtSearch.Text + "%'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_Invoices WHERE SupplierFullName='" + cmbSuppliers.SelectedValue + "'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void btnClearSupplier_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_Invoices", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            if (chkDateSupplier.Checked)
            {
                if (cmbSuppliers.SelectedItem != null)
                {
                    conn = new SqlConnection(sn);
                    conn.Open();
                    sda = new SqlDataAdapter(@"SELECT * From view_Invoices WHERE DateInvoice = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND SupplierFullName = '" + cmbSuppliers.SelectedValue + "'", conn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dgvInvoices.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Choose the supplier!");
                }

            }
            else
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT * From view_Invoices WHERE DateInvoice = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvInvoices.DataSource = dt;
                conn.Close();
            }
        }
        private void btnClearDate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_Invoices", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedItem.ToString() == "DATE ADDED (NEWEST)")
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT * From view_Invoices ORDER BY DateInvoice DESC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvInvoices.DataSource = dt;
                conn.Close();
            }
            else if (cmbOrder.SelectedItem.ToString() == "DATE ADDED(OLDEST)")
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT * From view_Invoices ORDER BY DateInvoice ASC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvInvoices.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Choose the way you want to order your Invoices!");
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_Invoices", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void btnResfresh_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_Invoices", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"Select ArticleName, Unit, QTY1 FROM Article JOIN PastOrder ON Article.ArticleNo = PastOrder.ArticleNo1 WHERE PurchaseOrderNo1 IN (Select PurchaseOrderNo FROM PurchaseOrder WHERE InvoiceNo = '"+dgvInvoices.CurrentRow.Cells[0].Value.ToString() +"')", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvOrderedArticles.DataSource = dt;
                conn.Close();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to transfer articles?", "Transfer Articles", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(dgvOrderedArticles.Rows.Count != 0)
                {
                    List<int> articleNos = new List<int>();
                    conn = new SqlConnection(sn);
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select ArticleNo FROM Article JOIN PastOrder ON Article.ArticleNo = PastOrder.ArticleNo1 WHERE PurchaseOrderNo1 IN (Select PurchaseOrderNo FROM PurchaseOrder WHERE InvoiceNo = '" + dgvInvoices.CurrentRow.Cells[0].Value.ToString() + "')", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int articleNo = (int)reader["ArticleNo"];
                        articleNos.Add(articleNo);
                    }
                    reader.Close();
                    
                    foreach (int articleNo in articleNos)
                    {
                        SqlCommand cmd = new SqlCommand("transferToStorage", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@articleNo", articleNo);
                        cmd.Parameters.AddWithValue("@storageID", cmbStorage.SelectedValue);
                        cmd.Parameters.AddWithValue("@invoiceNo", dgvInvoices.CurrentRow.Cells[0].Value.ToString());
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Articles successfully transfered!");
                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM Invoice Where InvoiceNo = '" + dgvInvoices.CurrentRow.Cells[0].Value.ToString() + "'", conn);
                    cmdDelete.ExecuteNonQuery();
                    sda = new SqlDataAdapter(@"SELECT * From view_Invoices", conn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dgvInvoices.DataSource = dt;
                    dgvOrderedArticles.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Inovice not selected!");
                }
                
            }
            
            conn.Close();
        }

    }
}

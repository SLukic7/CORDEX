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
    public partial class PastInvoices : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public PastInvoices()
        {
            InitializeComponent();
        }

        private void PastInvoices_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT SupplierFullName From Supplier", conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbSuppliers.DataSource = dt;
            cmbSuppliers.DisplayMember = "SupplierFullName";
            cmbSuppliers.ValueMember = "SupplierFullName";
            sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices WHERE InvoiceNo1 LIKE '%" + txtSearch.Text + "%'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices WHERE SupplierFullName='" + cmbSuppliers.SelectedValue + "'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void btnClearSupplier_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices", conn);
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
                    sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices WHERE DateInvoice1 = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND SupplierFullName = '" + cmbSuppliers.SelectedValue + "'", conn);
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
                sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices WHERE DateInvoice1 = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'", conn);
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
            sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices", conn);
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
                sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices ORDER BY DateInvoice1 DESC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvInvoices.DataSource = dt;
                conn.Close();
            }
            else if (cmbOrder.SelectedItem.ToString() == "DATE ADDED(OLDEST)")
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices ORDER BY DateInvoice1 ASC", conn);
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
            sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvInvoices.DataSource = dt;
            conn.Close();
        }

        private void btnResfresh_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PastInvoices", conn);
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
                sda = new SqlDataAdapter(@"Select ArticleName, Unit, QTY1 FROM Article JOIN PastOrder ON Article.ArticleNo = PastOrder.ArticleNo1 WHERE PurchaseOrderNo1 IN (Select PurchaseOrderNo FROM PurchaseOrder WHERE InvoiceNo = '" + dgvInvoices.CurrentRow.Cells[0].Value.ToString() + "')", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvOrderedArticles.DataSource = dt;
                conn.Close();
            }
        }
    }
}

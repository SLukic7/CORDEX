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
    public partial class Suppliers : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        Form newSupplier = new NewSupplier();
        public static string fullName;
        public static string abbreviation;
        public static string mb;
        public static string pib;
        public static string ba;
        public static string adress;
        public static string zip;
        public static string city;
        public static string country;
        public static string email;
        public static string phone;
        public static string fax;
        
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM Supplier", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvSuppliers.DataSource = dt;
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM Supplier WHERE SupplierFullName LIKE '%" + txtSearch.Text + "%'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvSuppliers.DataSource = dt;
            conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM Supplier", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvSuppliers.DataSource = dt;
            conn.Close();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            newSupplier.Show();
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            fullName = dgvSuppliers.CurrentRow.Cells[0].Value.ToString();
            abbreviation = dgvSuppliers.CurrentRow.Cells[1].Value.ToString();
            mb = dgvSuppliers.CurrentRow.Cells[2].Value.ToString();
            pib = dgvSuppliers.CurrentRow.Cells[3].Value.ToString();
            ba = dgvSuppliers.CurrentRow.Cells[4].Value.ToString();
            adress = dgvSuppliers.CurrentRow.Cells[5].Value.ToString();
            zip = dgvSuppliers.CurrentRow.Cells[6].Value.ToString();
            city = dgvSuppliers.CurrentRow.Cells[7].Value.ToString();
            country = dgvSuppliers.CurrentRow.Cells[8].Value.ToString();
            email = dgvSuppliers.CurrentRow.Cells[9].Value.ToString();
            phone = dgvSuppliers.CurrentRow.Cells[10].Value.ToString();
            fax = dgvSuppliers.CurrentRow.Cells[11].Value.ToString();
            UpdateSupplier updateSupplier = new UpdateSupplier();
            updateSupplier.Show();
        }
    }
}

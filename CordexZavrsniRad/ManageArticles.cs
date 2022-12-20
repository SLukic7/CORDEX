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
    public partial class ManageArticles : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        Form addArticle = new AddArticle();
        public static int articleNo;
        public static float price;
        public ManageArticles()
        {
            InitializeComponent();
        }

        private void ManageArticles_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT ItemGroupName From ItemGroup",conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbItemGroup.DataSource = dt;
            cmbItemGroup.DisplayMember = "ItemGroupName";
            cmbItemGroup.ValueMember = "ItemGroupName";
            sda = new SqlDataAdapter(@"SELECT ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)] FROM Article", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvArticles.DataSource = dt;
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)] FROM Article WHERE ArticleName LIKE '%" + txtSearch.Text + "%'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvArticles.DataSource = dt;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)] FROM Article WHERE ItemGroupNo in (SELECT ItemGroupNo FROM ItemGroup WHERE ItemGroupName ='" + cmbItemGroup.SelectedValue + "')", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvArticles.DataSource = dt;
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)] FROM Article", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvArticles.DataSource = dt;
            conn.Close();
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            articleNo = int.Parse(dgvArticles.CurrentRow.Cells[0].Value.ToString());
            price = float.Parse(dgvArticles.CurrentRow.Cells[3].Value.ToString());

            UpdateArticle updateArticle = new UpdateArticle();
            updateArticle.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)] FROM Article", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvArticles.DataSource = dt;
            conn.Close();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            addArticle.Show();
        }

        
        
    }
}

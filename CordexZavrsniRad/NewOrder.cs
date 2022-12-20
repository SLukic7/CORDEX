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
    public partial class NewOrder : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From ItemGroup", conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbItemGroup.DataSource = dt;
            cmbItemGroup.DisplayMember = "ItemGroupName";
            cmbItemGroup.ValueMember = "ItemGroupNo";
            sda = new SqlDataAdapter(@"SELECT Article.ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)],SOH FROM Article LEFT JOIN STORAGE_ARTICLE ON Article.ArticleNo = STORAGE_ARTICLE.ArticleNo", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvAddArticles.DataSource = dt;
            conn.Close();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT Article.ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)],SOH FROM Article LEFT JOIN STORAGE_ARTICLE ON Article.ArticleNo = STORAGE_ARTICLE.ArticleNo WHERE ItemGroupNo =" + cmbItemGroup.SelectedValue, conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvAddArticles.DataSource = dt;
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT Article.ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)],SOH FROM Article LEFT JOIN STORAGE_ARTICLE ON Article.ArticleNo = STORAGE_ARTICLE.ArticleNo", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvAddArticles.DataSource = dt;
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT Article.ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)],SOH FROM Article LEFT JOIN STORAGE_ARTICLE ON Article.ArticleNo = STORAGE_ARTICLE.ArticleNo WHERE ArticleName LIKE '%" + txtSearch.Text + "%'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvAddArticles.DataSource = dt;
            conn.Close();
        }

        private void dgvAddArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();

            int articleNo = int.Parse(dgvAddArticles.CurrentRow.Cells[0].Value.ToString());
            sda = new SqlDataAdapter(@"SELECT SupplierFullName, SupplierPIB
                                       FROM Supplier
                                        WHERE SupplierPIB IN  
                                                            (SELECT SupplierPIB FROM SUPPLIER_ITEMGROUP WHERE ItemGroupNo IN
                                                                                    (SELECT ItemGroupNo FROM Article WHERE ArticleNo = " + articleNo + "))", conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbSupplier.DataSource = dt;
            cmbSupplier.DisplayMember = "SupplierFullName";
            cmbSupplier.ValueMember = "SupplierPIB";

            conn.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            int articleNo = int.Parse(dgvAddArticles.CurrentRow.Cells[0].Value.ToString());
            //SqlCommand cmdExcistingArticle = new SqlCommand("Select count(ArticleNo) From \"Order\" Where ArticleNo = " + articleNo, conn);
            //int rowCount = int.Parse(cmdExcistingArticle.ExecuteNonQuery().ToString());
            //if (rowCount != 0)
            //{
            //    SqlCommand cmdQTY = new SqlCommand("Select QTY From \"Order\" Where ArticleNo = " + articleNo, conn);
            //    float qty1 = float.Parse(cmdQTY.ExecuteNonQuery().ToString());
            //    SqlCommand cmdUpdateQTY = new SqlCommand("UPDATE \"Order\" Set QTY =" + qty1 + " + " + float.Parse(txtQuantity.Text) + " Where ArticleNo = " + articleNo, conn);
            //    cmdUpdateQTY.ExecuteNonQuery();
            //    MessageBox.Show("Article successfully added to order!");

            //}
            //else
            //{
                string dateTime = DateTime.Now.ToString("ddMMyy");
                string purchaceOrderNo = dateTime + cmbSupplier.SelectedValue.ToString() + "1";

                float qty = float.Parse(txtQuantity.Text);
                string info = txtInfo.Text;
                string query;
                string commandCount = "Select count(PurchaseOrderNo) FROM PurchaseOrder Where PurchaseOrderNo = '" + purchaceOrderNo + "'";
                SqlCommand cmd = new SqlCommand(commandCount, conn);
                int count = int.Parse(cmd.ExecuteScalar().ToString());
                if (count != 0)
                {
                    string purchaseOrderNoSubstring = purchaceOrderNo.Substring(0, 15);
                    string commandMax = "Select MAX(PurchaseOrderNo) FROM PurchaseOrder Where PurchaseOrderNo LIKE '" + purchaseOrderNoSubstring + "%'";
                    SqlCommand cmd1 = new SqlCommand(commandMax, conn);
                    string purchaseOrderNoMax = cmd1.ExecuteScalar().ToString();
                    char[] countChars = purchaseOrderNoMax.ToCharArray();
                    if (countChars.Length == 16)
                    {
                        purchaceOrderNo = (long.Parse(purchaseOrderNoMax) + 1).ToString();
                    }
                    else
                    {
                        purchaceOrderNo = "0" + (long.Parse(purchaseOrderNoMax) + 1).ToString();
                    }
                }
                if (dgvAddArticles.SelectedRows.Count == 0 || string.IsNullOrEmpty(txtQuantity.Text) || cmbSupplier.SelectedIndex == -1)
                {
                    MessageBox.Show("Error while adding article to order! Check all the required fields!");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtInfo.Text))
                    {

                        query = "INSERT INTO \"Order\" (ArticleNo,QTY,Information,PurchaseOrderNo) VALUES(" + articleNo + "," + qty + ",NULL,'" + purchaceOrderNo + "')";

                    }
                    else
                    {
                        query = "INSERT INTO \"Order\" (ArticleNo,QTY,Information,PurchaseOrderNo) VALUES(" + articleNo + "," + qty + ",'" + info + "','" + purchaceOrderNo + "')";

                    }
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Article successfully added to order!");
                    txtInfo.Text = "";
                    txtQuantity.Text = "";
                    conn.Close();

                }

            //}
        }

        private void dgvAddArticles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = 6;



            foreach (DataGridViewRow row in dgvAddArticles.Rows)
            {
                if (Int32.Parse(row.Cells[6].Value.ToString()) <= 5)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
                //    //float soh;
                //    //if(float.TryParse(row.Cells[columnIndex].Value.ToString(), out soh))
                //    //{
                //    //    if (soh < 5)
                //    //    {
                //    //    for (int i = 0; i < dgvAddArticles.ColumnCount; i++)
                //    //        row.Cells[i].Style.ForeColor = System.Drawing.Color.Red;
                //    //    }   
                //    //}



            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvAddArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn = new SqlConnection(sn);
            conn.Open();
            if (chkDiscount.Checked)
            {
                sda = new SqlDataAdapter(@"SELECT * FROM articlesDiscount", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvAddArticles.DataSource = dt;
            }
            if (chkLowSOH.Checked)
            {
                sda = new SqlDataAdapter(@"SELECT * FROM articlesLowSOH", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvAddArticles.DataSource = dt;
            }
            if (chkLowSOH.Checked && chkDiscount.Checked)
            {
                sda = new SqlDataAdapter(@"SELECT * FROM articlesDiscountLowSOH", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvAddArticles.DataSource = dt;
            }

            conn.Close();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            dgvAddArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT Article.ArticleNo,ArticleName,Unit,Price,Currency,[Discount(%)],SOH FROM Article LEFT JOIN STORAGE_ARTICLE ON Article.ArticleNo = STORAGE_ARTICLE.ArticleNo", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvAddArticles.DataSource = dt;
            conn.Close();
        }

        
    }
}

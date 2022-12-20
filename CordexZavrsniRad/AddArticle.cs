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
    public partial class AddArticle : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public AddArticle()
        {
            InitializeComponent();
        }

        private void AddArticle_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From ItemGroup", conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbItemGroup.DataSource = dt;
            cmbItemGroup.DisplayMember = "ItemGroupName";
            cmbItemGroup.ValueMember = "ItemGroupNo";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            string unit = cmbUnit.GetItemText(cmbUnit.SelectedItem);
            string query;
            
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtCurrency.Text) || cmbItemGroup.SelectedIndex == -1 || cmbUnit.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR while adding new article. Check if you have entered all the information!");
            }
            else
            {
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    query = "INSERT INTO Article (ArticleName,Unit,Price,Currency,[Discount(%)],ItemGroupNo) VALUES('" + txtName.Text + "','" + unit + "'," + float.Parse(txtPrice.Text) + ",'" + txtCurrency.Text + "',NULL,'" + cmbItemGroup.SelectedValue + "')";

                }
                else
                {
                    query = "INSERT INTO Article (ArticleName,Unit,Price,Currency,[Discount(%)],ItemGroupNo) VALUES('" + txtName.Text + "','" + unit + "'," + float.Parse(txtPrice.Text) + ",'" + txtCurrency.Text + "'," + int.Parse(txtDiscount.Text) + ",'" + cmbItemGroup.SelectedValue + "')";

                }

                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Article successfully added!");
                conn.Close();
            }
            //try
            //{
            //    conn.Open();
            //    command.ExecuteNonQuery();
            //    MessageBox.Show("Article successfully added!");
            //}
            //catch
            //{
            //   MessageBox.Show("Error while adding new article. Check if you have entered all the information!");
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void AddArticle_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

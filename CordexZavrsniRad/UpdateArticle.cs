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
    public partial class UpdateArticle : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public UpdateArticle()
        {
            InitializeComponent();
        }

        private void UpdateArticle_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();

            txtArticleNo.Text = ManageArticles.articleNo.ToString();
            txtPrice.Text = ManageArticles.price.ToString();
            SqlCommand cmdName = new SqlCommand("SELECT ArticleName FROM Article WHERE ArticleNo =" + ManageArticles.articleNo, conn);
            txtName.Text = cmdName.ExecuteScalar().ToString();

            SqlCommand cmdUnit = new SqlCommand("SELECT Unit FROM Article WHERE ArticleNo =" + ManageArticles.articleNo, conn);
            cmbUnit.SelectedItem = cmdUnit.ExecuteScalar().ToString();

            SqlCommand cmdDiscount = new SqlCommand("SELECT [Discount(%)] FROM Article WHERE ArticleNo =" + ManageArticles.articleNo, conn);
            txtDiscount.Text = cmdDiscount.ExecuteScalar().ToString();

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();

            SqlCommand cmdItemGroup = new SqlCommand("SELECT ItemGroupNo FROM Article WHERE ArticleNo =" + ManageArticles.articleNo, conn);
            int itemGroupNo = int.Parse(cmdItemGroup.ExecuteScalar().ToString());
            float discount = float.Parse(txtDiscount.Text);
            float price1 = float.Parse(txtPrice.Text);
            
            string command;
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtDiscount.Text))
            {
                MessageBox.Show("You must fill in all fields!");
            }
            else
            {
                //if (price1 != ManageArticles.price)
                //{
                //    SqlCommand enableTrigger = new SqlCommand("enable trigger trig_PastPrice on Article", conn);
                //    enableTrigger.ExecuteNonQuery();

                //}
                //else
                //{
                //    SqlCommand disableTrigger = new SqlCommand("disable trigger trig_PastPrice on Article", conn);
                //    disableTrigger.ExecuteNonQuery();
                //    SqlCommand cmdFunction = new SqlCommand("select dbo.fun_Discount(" + ManageArticles.articleNo + "," + float.Parse(txtPrice.Text) + ")", conn);
                //    float price = float.Parse(cmdFunction.ExecuteScalar().ToString());
                //    //MessageBox.Show(price.ToString());
                //    command = "UPDATE Article SET ArticleName = '" + txtName.Text + "', Unit = '" + cmbUnit.SelectedItem + "', Price = " + price + ",Currency ='" + txtCurrency.Text + "',[Discount(%)] = " + float.Parse(txtDiscount.Text) + ",ItemGroupNo = " + itemGroupNo + " WHERE ArticleNo = " + ManageArticles.articleNo;
                //    SqlCommand cmdUpdate = new SqlCommand(command, conn);
                //    cmdUpdate.ExecuteNonQuery();
                //    MessageBox.Show("Article successfully updated!");
                //}
                if (chkUpdate.Checked)
                {
                    SqlCommand enableTrigger = new SqlCommand("enable trigger trig_PastPrice on Article", conn);
                    enableTrigger.ExecuteNonQuery();

                    
                    float price = float.Parse(txtPrice.Text);
                    //MessageBox.Show(price.ToString());
                    command = "UPDATE Article SET ArticleName = '" + txtName.Text + "', Unit = '" + cmbUnit.SelectedItem + "', Price = " + price + ",Currency ='" + txtCurrency.Text + "',[Discount(%)] = 0, ItemGroupNo = " + itemGroupNo + " WHERE ArticleNo = " + ManageArticles.articleNo;
                    SqlCommand cmdUpdate = new SqlCommand(command, conn);
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Article price successfully updated!");
                }
                else
                {
                    SqlCommand disableTrigger = new SqlCommand("disable trigger trig_PastPrice on Article", conn);
                    disableTrigger.ExecuteNonQuery();
                    
                    
                    if (discount > 0)
                    {
                        SqlCommand cmdFunction = new SqlCommand("select dbo.fun_Discount(" + ManageArticles.articleNo + "," + float.Parse(txtPrice.Text) + "," + float.Parse(txtDiscount.Text) + ")", conn);
                        float price = float.Parse(cmdFunction.ExecuteScalar().ToString());
                        //MessageBox.Show(price.ToString());
                        command = "UPDATE Article SET ArticleName = '" + txtName.Text + "', Unit = '" + cmbUnit.SelectedItem + "', Price = " + price + ",Currency ='" + txtCurrency.Text + "',[Discount(%)] = " + float.Parse(txtDiscount.Text) + ",ItemGroupNo = " + itemGroupNo + " WHERE ArticleNo = " + ManageArticles.articleNo;
                        SqlCommand cmdUpdate = new SqlCommand(command, conn);
                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Article successfully updated!");
                    }
                    else
                    {
                        SqlCommand cmdFunction = new SqlCommand("select PriceAP From ArticlePrice Where ArticleNoAP =" + ManageArticles.articleNo, conn);
                        float price = float.Parse(cmdFunction.ExecuteScalar().ToString());
                        command = "UPDATE Article SET ArticleName = '" + txtName.Text + "', Unit = '" + cmbUnit.SelectedItem + "',Price = " + price + ",Currency ='" + txtCurrency.Text + "',[Discount(%)] = " + float.Parse(txtDiscount.Text) + ",ItemGroupNo = " + itemGroupNo + " WHERE ArticleNo =" + ManageArticles.articleNo;
                        SqlCommand cmdUpdate = new SqlCommand(command, conn);
                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Article successfully updated!");
                    }
                }
                
            }
            conn.Close();
        }

        private void UpdateArticle_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void chkUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdate.Checked)
            {
                txtDiscount.Text = "0";
                txtDiscount.Enabled = false;
                txtDiscount.ReadOnly = true;
                txtPrice.Enabled = true;
                txtPrice.ReadOnly = false;
            }
            else
            {
                conn = new SqlConnection(sn);
                conn.Open();
                SqlCommand command = new SqlCommand("Select [Discount(%)] From Article Where ArticleNo = " + ManageArticles.articleNo,conn);
                
                txtDiscount.Enabled = true;
                txtDiscount.ReadOnly = false;

                txtPrice.Enabled = false;
                txtPrice.ReadOnly = true;
                txtDiscount.Text = command.ExecuteScalar().ToString();
                conn.Close();
            }
        }
    }
}

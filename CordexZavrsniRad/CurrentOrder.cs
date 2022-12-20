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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Image = System.Drawing.Image;
using System.Drawing.Imaging;

namespace CordexZavrsniRad
{
    public partial class CurrentOrder : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        
        public CurrentOrder()
        {
            InitializeComponent();
        }

        private void CurrentOrder_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM view_CurrentOrder", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvCurrentOrder.DataSource = dt;
            string command1 = "Select Sum(Price*QTY) From Article JOIN \"Order\" ON Article.ArticleNo = \"Order\".ArticleNo Where Article.ArticleNo in (Select ArticleNo From \"Order\")";
            SqlCommand cmd1 = new SqlCommand(command1, conn);
            string command2 = "Select count(*) FROM \"Order\"";
            SqlCommand cmd2 = new SqlCommand(command2, conn);
            int count = int.Parse(cmd2.ExecuteScalar().ToString());
            if(count == 0)
            {
                txtTotal.Text = "0 RSD";
                
            }
            else
            {
                txtTotal.Text = Convert.ToString(cmd1.ExecuteScalar()) + " RSD";
            }
            
            conn.Close();
            foreach (DataGridViewColumn column in dgvCurrentOrder.Columns)
            {
                if (column.Index.Equals(2) || column.Index.Equals(4))
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM view_CurrentOrder WHERE ArticleName LIKE '%" + txtSearch.Text + "%'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvCurrentOrder.DataSource = dt;
            conn.Close();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            int orderNo = int.Parse(dgvCurrentOrder.CurrentRow.Cells[0].Value.ToString());
            float qty = float.Parse(dgvCurrentOrder.CurrentRow.Cells[2].Value.ToString());
            string command;
            if (dgvCurrentOrder.CurrentRow.Cells[4].Value == null)
            {
                command = "UPDATE \"Order\" SET QTY=@qty,Information=NULL WHERE OrderNo=@orderNo ";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@orderNo", orderNo);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string information = dgvCurrentOrder.CurrentRow.Cells[4].Value.ToString();
                command = "UPDATE \"Order\" SET QTY=@qty,Information=@info WHERE OrderNo=@orderNo ";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@info", information);
                cmd.Parameters.AddWithValue("@orderNo", orderNo);
                cmd.ExecuteNonQuery();
            }
            sda = new SqlDataAdapter(@"SELECT * FROM view_CurrentOrder", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvCurrentOrder.DataSource = dt;
            string command1 = "Select Sum(Price*QTY) From Article JOIN \"Order\" ON Article.ArticleNo = \"Order\".ArticleNo Where Article.ArticleNo in (Select ArticleNo From \"Order\")";
            SqlCommand cmd1 = new SqlCommand(command1, conn);
            string command2 = "Select count(*) FROM \"Order\"";
            SqlCommand cmd2 = new SqlCommand(command2, conn);
            int count = int.Parse(cmd2.ExecuteScalar().ToString());
            if (count == 0)
            {
                txtTotal.Text = "0 RSD";

            }
            else
            {
                txtTotal.Text = Convert.ToString(cmd1.ExecuteScalar()) + " RSD";
            }
            conn.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string articleName = dgvCurrentOrder.CurrentRow.Cells[1].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove "+articleName+ " article from your order?", "Remove Article", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn = new SqlConnection(sn);
                conn.Open();
                string disableTrigger = "disable trigger trig_PlaceOrder on \"Order\"";
                SqlCommand cmdDisableTrigger = new SqlCommand(disableTrigger, conn);
                cmdDisableTrigger.ExecuteNonQuery();
                int orderNo = int.Parse(dgvCurrentOrder.CurrentRow.Cells[0].Value.ToString());
                string command = command = "DELETE FROM \"Order\" WHERE OrderNo=@orderNo ";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@orderNo", orderNo);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(@"SELECT * FROM view_CurrentOrder", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvCurrentOrder.DataSource = dt;
                string command1 = "Select Sum(Price*QTY) From Article JOIN \"Order\" ON Article.ArticleNo = \"Order\".ArticleNo Where Article.ArticleNo in (Select ArticleNo From \"Order\")";
                SqlCommand cmd1 = new SqlCommand(command1, conn);
                string command2 = "Select count(*) FROM \"Order\"";
                SqlCommand cmd2 = new SqlCommand(command2, conn);
                int count = int.Parse(cmd2.ExecuteScalar().ToString());
                if (count == 0)
                {
                    txtTotal.Text = "0 RSD";

                }
                else
                {
                    txtTotal.Text = Convert.ToString(cmd1.ExecuteScalar()) + " RSD";
                }
                conn.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT * FROM view_CurrentOrder", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvCurrentOrder.DataSource = dt;
                conn.Close();
            }
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
             List<String> purchaseOrderNos = new List<String>();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to place the order?","Place the Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                conn = new SqlConnection(sn);
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT PurchaseOrderNo FROM \"Order\"", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string purchaseOrderNo = (string)reader["PurchaseOrderNo"];
                    purchaseOrderNos.Add(purchaseOrderNo);
                }
                reader.Close();
                purchaseOrderNos = purchaseOrderNos.Distinct().ToList();

                foreach (string purchaseOrderNo in purchaseOrderNos)
                {
                    string commandPIB = "Select CompanyPIB FROM Company";
                    SqlCommand cmdCompanyPIB = new SqlCommand(commandPIB, conn);
                    string companyPIB = cmdCompanyPIB.ExecuteScalar().ToString();

                    string commandMB = "Select CompanyMB FROM Company";
                    SqlCommand cmdCompanyMB = new SqlCommand(commandMB, conn);
                    string companyMB = cmdCompanyMB.ExecuteScalar().ToString();

                    char[] purchaseOrderPIB = purchaseOrderNo.ToCharArray();
                    String supplierPIB = new String(purchaseOrderPIB, 6, 9);

                    string commandSMB = "Select SupplierMB FROM Supplier WHERE SupplierPIB = '" + supplierPIB + "'";
                    SqlCommand cmdSupplierMB = new SqlCommand(commandSMB, conn);
                    string supplierMB = cmdSupplierMB.ExecuteScalar().ToString();

                    string dateTime = DateTime.Now.ToString("ddMMyy");
                    string invoiceNo = dateTime + supplierMB + "1";
                    string commandInvoice = "Select count(InvoiceNo) FROM Invoice Where InvoiceNo = '" + invoiceNo + "'";
                    SqlCommand cmdInvoice = new SqlCommand(commandInvoice, conn);
                    int countInvoice = int.Parse(cmdInvoice.ExecuteScalar().ToString());
                    if (countInvoice != 0)
                    {
                        string invoiceNoSubstring = invoiceNo.Substring(0, 14);
                        string commandMax = "Select MAX(InvoiceNo) FROM Invoice Where InvoiceNo LIKE '" + invoiceNoSubstring + "%'";
                        SqlCommand cmdIn = new SqlCommand(commandMax, conn);
                        string invoiceNoMax = cmdIn.ExecuteScalar().ToString();
                        char[] countChars = invoiceNoMax.ToCharArray();
                        if (countChars.Length == 15)
                        {
                            invoiceNo = (long.Parse(invoiceNoMax) + 1).ToString();
                        }
                        else
                        {
                            invoiceNo = "0" + (long.Parse(invoiceNoMax) + 1).ToString();
                        }
                        
                    }

                    DateTime date = DateTime.Now;

                    string purchaseInfo = txtInformation.Text;

                    frmLogIn login = new frmLogIn();
                    string username = frmLogIn.Username;
                    string commandEmployee = "Select EmployeeNo FROM Employee WHERE EmployeeUsername = '" + username + "'";
                    SqlCommand cmdEmployee = new SqlCommand(commandEmployee, conn);
                    string employeeNo = cmdEmployee.ExecuteScalar().ToString();

                    string command1 = "Select dbo.fun_Total('"+ purchaseOrderNo+"')";
                    SqlCommand cmd1 = new SqlCommand(command1, conn);
                    float total = float.Parse(cmd1.ExecuteScalar().ToString());

                    string insertCommand;
                      if (string.IsNullOrEmpty(txtInformation.Text))
                         {
                            insertCommand = "INSERT INTO PurchaseOrder(PurchaseOrderNo, CompanyMB, CompanyPIB, SupplierMB, SupplierPIB, InvoiceNo, Date, PurchaseInformation, Total, EmployeeNo)" +
                            "VALUES('" + purchaseOrderNo + "','" + companyMB + "','" + companyPIB + "','" + supplierMB + "','" + supplierPIB + "','" + invoiceNo + "','" + date + "',NULL," + total + "," + employeeNo + ")";
                         }
                      else
                         {
                            insertCommand = "INSERT INTO PurchaseOrder(PurchaseOrderNo, CompanyMB, CompanyPIB, SupplierMB, SupplierPIB, InvoiceNo, Date, PurchaseInformation, Total, EmployeeNo)" +
                            "VALUES('" + purchaseOrderNo + "','" + companyMB + "','" + companyPIB + "','" + supplierMB + "','" + supplierPIB + "','" + invoiceNo + "','" + date + "','" + purchaseInfo + "'," + total + "," + employeeNo + ")";
                         }

                    SqlCommand cmdInsert = new SqlCommand(insertCommand, conn);
                    cmdInsert.ExecuteNonQuery();

                    SqlCommand rowcount = new SqlCommand("Select @@ROWCOUNT", conn);
                    int rowsAffected = int.Parse(rowcount.ExecuteScalar().ToString());

                    if (rowsAffected == 1)
                        {
                            string enableTrigger = "enable trigger trig_PlaceOrder on \"Order\"";
                            SqlCommand cmdEnableTrigger = new SqlCommand(enableTrigger, conn);
                            cmdEnableTrigger.ExecuteNonQuery();

                            List<int> orderNos = new List<int>();
                            SqlCommand cmdOrderNo = new SqlCommand("SELECT OrderNo FROM \"Order\" Where PurchaseOrderNo = '" +purchaseOrderNo+"'", conn);
                            SqlDataReader reader1 = cmdOrderNo.ExecuteReader();
                            while (reader1.Read())
                            {
                                int orderNo = (int)reader1["OrderNo"];
                                orderNos.Add(orderNo);
                            }
                            reader1.Close();
                            foreach(int orderNo in orderNos)
                            {
                                string commandDelete = "Delete From \"Order\" WHERE OrderNo ='" + orderNo + "' AND PurchaseOrderNo = '"+purchaseOrderNo+"'";
                                SqlCommand cmdDelete = new SqlCommand(commandDelete, conn);
                                cmdDelete.ExecuteNonQuery();
                            }
                            
                            SqlCommand sqlProcedure = new SqlCommand("sp_Invoice", conn);
                            sqlProcedure.CommandType = CommandType.StoredProcedure;
                            sqlProcedure.Parameters.AddWithValue("@purchaseOrderNo", SqlDbType.VarChar).Value = purchaseOrderNo;
                            sqlProcedure.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Error while placing your order!");
                        }

                }
                MessageBox.Show("Order successfull placed!");
                sda = new SqlDataAdapter(@"SELECT * FROM view_CurrentOrder", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvCurrentOrder.DataSource = dt;
                txtTotal.Text = "0 RSD";
                txtInformation.Text = "";
                purchaseOrderNos.Clear();
                conn.Close();
            }
            else if(dialogResult == DialogResult.No)
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT * FROM view_CurrentOrder", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvCurrentOrder.DataSource = dt;
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM view_CurrentOrder", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvCurrentOrder.DataSource = dt;
            string command1 = "Select Sum(Price*QTY) From Article JOIN \"Order\" ON Article.ArticleNo = \"Order\".ArticleNo Where Article.ArticleNo in (Select ArticleNo From \"Order\")";
            SqlCommand cmd1 = new SqlCommand(command1, conn);
            string command2 = "Select count(*) FROM \"Order\"";
            SqlCommand cmd2 = new SqlCommand(command2, conn);
            int count = int.Parse(cmd2.ExecuteScalar().ToString());
            if (count == 0)
            {
                txtTotal.Text = "0 RSD";

            }
            else
            {
                txtTotal.Text = Convert.ToString(cmd1.ExecuteScalar()) + " RSD";
            }
            conn.Close();
        }
       
    }

    

}

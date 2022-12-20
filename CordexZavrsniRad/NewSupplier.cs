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
    public partial class NewSupplier : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public NewSupplier()
        {
            InitializeComponent();
        }

        private void NewSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void NewSupplier_Load(object sender, EventArgs e)
        {
            List<String> ItemGroupNames = new List<String>();
            conn = new SqlConnection(sn);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT ItemGroupName FROM ItemGroup", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string itemGroupName = (string)reader["ItemGroupName"];
                ItemGroupNames.Add(itemGroupName);
            }
            reader.Close();

            foreach(string itemGroupName in ItemGroupNames)
            {
                chkListBoxItemGroups.Items.Add(itemGroupName);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            string BA = txtBA1.Text + "-" + txtBA2.Text + "-" + txtBA3.Text;
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtAbbreviation.Text) || string.IsNullOrEmpty(txtMB.Text) || string.IsNullOrEmpty(txtPIB.Text) || string.IsNullOrEmpty(BA) || string.IsNullOrEmpty(txtAdress.Text) || string.IsNullOrEmpty(txtZIP.Text) || string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtCountry.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtFAX.Text))
            {
                MessageBox.Show("Action failed! Check if you have filled in all fileds!");
            }
            else
            {
                string commandInsert = "INSERT INTO Supplier(SupplierFullName,SupplierAbbreviation,SupplierMB,SupplierPIB,SupplierBankAcc,SupplierAdress,SupplierZipCode,SupplierCity,SupplierCountry,SupplierEmail,SupplierPhoneNo,SupplierFaxNo)" +
            "VALUES('" + txtFullName.Text + "','" + txtAbbreviation.Text + "','" + txtMB.Text + "','" + txtPIB.Text + "','" + BA + "','" + txtAdress.Text + "','" + txtZIP.Text + "','" + txtCity.Text + "','" + txtCountry.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtFAX.Text + "')";
                SqlCommand cmdInsert = new SqlCommand(commandInsert, conn);
                int rowsAffected = cmdInsert.ExecuteNonQuery();
                if(rowsAffected == 1)
                {
                    List<String> itemGroups = new List<string>();
                    foreach(object item in chkListBoxItemGroups.CheckedItems)
                    {
                        itemGroups.Add(item.ToString());
                    }

                    foreach(string item in itemGroups)
                    {
                        SqlCommand cmdItemGroupNo = new SqlCommand("Select ItemGroupNo From ItemGroup Where ItemGroupName ='"+item+"'", conn);
                        int itemGroupNo = int.Parse(cmdItemGroupNo.ExecuteScalar().ToString());
                        commandInsert = "INSERT INTO SUPPLIER_ITEMGROUP(SupplierMB,SupplierPIB,ItemGroupNo)" +
                        "VALUES(" + txtMB.Text + "," + txtPIB.Text + "," + itemGroupNo + ")";
                        SqlCommand cmdInsertSA = new SqlCommand(commandInsert, conn);
                        cmdInsertSA.ExecuteNonQuery();
                        

                    }
                    txtFullName.Text = "";
                    txtAbbreviation.Text = "";
                    txtBA1.Text = "";
                    txtBA2.Text = "";
                    txtBA3.Text = "";
                    txtPIB.Text = "";
                    txtMB.Text = "";
                    txtZIP.Text = "";
                    txtCity.Text = "";
                    txtAdress.Text = "";
                    txtCountry.Text = "";
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                    txtFAX.Text = "";

                    MessageBox.Show("Supplier successfully added!");
                }
                else
                {
                    MessageBox.Show("Something went wrong while adding new supplier!");
                }
            }
            


            conn.Close();
        }

        
    }
}

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
    public partial class UpdateSupplier : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
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

            foreach (string itemGroupName in ItemGroupNames)
            {
                chkListBoxItemGroups.Items.Add(itemGroupName);
            }
            txtFullName.Text = Suppliers.fullName;
            txtAbbreviation.Text = Suppliers.abbreviation;
            txtMB.Text = Suppliers.mb;
            txtPIB.Text = Suppliers.pib;
            string[] baArray = Suppliers.ba.Split('-');
            txtBA1.Text = baArray[0];
            txtBA2.Text = baArray[1];
            txtBA3.Text = baArray[2];
            txtAdress.Text = Suppliers.adress;
            txtZIP.Text = Suppliers.zip;
            txtCity.Text = Suppliers.city;
            txtCountry.Text = Suppliers.country;
            txtEmail.Text = Suppliers.email;
            txtPhone.Text = Suppliers.phone;
            txtFAX.Text = Suppliers.fax;

            List<string> itemNames = new List<string>();
            SqlCommand command1 = new SqlCommand("SELECT ItemGroupName From ItemGroup Where ItemGroupNo IN (Select ItemGroupNo FROM SUPPLIER_ITEMGROUP WHERE SupplierPIB = '" +Suppliers.pib +"')", conn);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                string itemName = (string)reader1["ItemGroupName"];
                itemNames.Add(itemName);
            }
            reader1.Close();

            foreach(string item in itemNames)
            {
                for(int i = 0; i < chkListBoxItemGroups.Items.Count; i++)
                {
                    if (chkListBoxItemGroups.Items[i].ToString().Equals(item))
                    {
                        chkListBoxItemGroups.SetItemChecked(i, true);
                    }
                }
            }

            conn.Close();
        }

        private void UpdateSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            string BA = txtBA1.Text + "-" + txtBA2.Text + "-" + txtBA3.Text;
            SqlCommand update = new SqlCommand("UPDATE Supplier " +
                "SET SupplierFullName ='"+txtFullName.Text+ "',SupplierAbbreviation = '"+txtAbbreviation.Text+ "',SupplierBankAcc = '"+BA+ "',SupplierAdress='"+txtAdress.Text+ "',SupplierZipCode='"+txtZIP.Text+ "',SupplierCity='"+txtCity.Text+ "',SupplierCountry='"+txtCountry.Text+ "',SupplierEmail='"+txtEmail.Text+ "',SupplierPhoneNo='"+txtPhone.Text+ "',SupplierFaxNo='"+txtFAX.Text+"' WHERE SupplierPIB ='"+Suppliers.pib+"'", conn);
            int rows = update.ExecuteNonQuery();
            if (rows == 1)
            {
                MessageBox.Show("Update successfull");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            SqlCommand cmdDelete = new SqlCommand("Delete from SUPPLIER_ITEMGROUP Where SupplierPIB = '" + Suppliers.pib + "'", conn);
            cmdDelete.ExecuteNonQuery();

            List<String> itemGroups = new List<string>();
            foreach (object item in chkListBoxItemGroups.CheckedItems)
            {
                itemGroups.Add(item.ToString());
            }

            foreach (string item in itemGroups)
            {
                SqlCommand cmdItemGroupNo = new SqlCommand("Select ItemGroupNo From ItemGroup Where ItemGroupName ='" + item + "'", conn);
                int itemGroupNo = int.Parse(cmdItemGroupNo.ExecuteScalar().ToString());
                string commandInsert = "INSERT INTO SUPPLIER_ITEMGROUP(SupplierMB,SupplierPIB,ItemGroupNo)" +
                "VALUES(" + Suppliers.mb + "," + Suppliers.pib + "," + itemGroupNo + ")";
                SqlCommand cmdInsertSA = new SqlCommand(commandInsert, conn);
                cmdInsertSA.ExecuteNonQuery();


            }
            MessageBox.Show("Groups successfully updated!");


            conn.Close();
        }
    }
}

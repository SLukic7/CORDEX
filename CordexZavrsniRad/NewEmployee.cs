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
    public partial class NewEmployee : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void NewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            string insert;
            SqlCommand unique = new SqlCommand("Select count(EmployeeUsername) From Employee Where EmployeeUsername = '" + txtUsername.Text + "'", conn);
            int rowsReturned = int.Parse(unique.ExecuteScalar().ToString());
            if(rowsReturned == 0)
            {
                if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Action failed! All fields are required! Check if you have filled them all!");
                }
                else
                {
                    if (checkBox1.Checked)
                    {
                        insert ="INSERT INTO Employee(EmployeeName,EmployeeSurname,EmployeeUsername,EmployeePassword,EmployeeRole)" +
                "VALUES('" + txtName.Text + "','" + txtSurname.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "', 'admin')";
                    }
                    else
                    {
                        insert = "INSERT INTO Employee(EmployeeName,EmployeeSurname,EmployeeUsername,EmployeePassword,EmployeeRole)" +
                "VALUES('" + txtName.Text + "','" + txtSurname.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "', 'user')";
                    }
                    SqlCommand cmdInsert = new SqlCommand(insert, conn);
                    int rowsAdded = int.Parse(cmdInsert.ExecuteNonQuery().ToString());
                    if (rowsAdded == 1)
                    {
                        MessageBox.Show("Employee successfully added!");
                    }
                    else
                    {
                        MessageBox.Show("Action failed!");
                    }
                }

            }
            conn.Close();
        }
    }
}

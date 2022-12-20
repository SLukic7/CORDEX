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
    public partial class UpdateEmployee : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            txtName.Text = Employees.employeeName;
            txtSurname.Text = Employees.employeeSurname;
            txtUsername.Text = Employees.employeeUsername;
            txtPassword.Text = Employees.employeePassword;
            if (Employees.employeeRole.Equals("admin"))
            {
                checkBox1.Checked = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            string update;
 
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Action failed! All fields are required! Check if you have filled them all!");
                }
                else
                {
                    if (checkBox1.Checked)
                    {
                    update = "UPDATE Employee " +
                "SET EmployeeName ='" + txtName.Text + "',EmployeeSurname ='" + txtSurname.Text + "', EmployeeUsername='" + txtUsername.Text + "',EmployeePassword='" + txtPassword.Text + "', EmployeeRole ='admin' " +
                "WHERE EmployeeNo = "+Employees.employeeNo;
                    }
                    else
                    {
                    update = "UPDATE Employee " +
                "SET EmployeeName ='" + txtName.Text + "',EmployeeSurname ='" + txtSurname.Text + "', EmployeeUsername='" + txtUsername.Text + "',EmployeePassword='" + txtPassword.Text + "', EmployeeRole= 'user' " +
                "WHERE EmployeeNo = " + Employees.employeeNo;
                }
                    SqlCommand cmdUpdate = new SqlCommand(update, conn);
                    int rowsUpdated = int.Parse(cmdUpdate.ExecuteNonQuery().ToString());
                    if (rowsUpdated == 1)
                    {
                        MessageBox.Show("Employee successfully updated!");
                    }
                    else
                    {
                        MessageBox.Show("Action failed!");
                    }
                }

            
            conn.Close();
        }

        private void UpdateEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

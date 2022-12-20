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
    public partial class frmLogIn : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        public static string Username;
        
        public frmLogIn()
        {
            InitializeComponent();
           // Username = username;
        }
        
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            int login;
            string query = "SELECT Count(*) FROM Employee WHERE EmployeeUsername = '" + txtUsername.Text + "' AND EmployeePassword = '" + txtPassword.Text + "'";
            conn = new SqlConnection(sn);
            SqlCommand cmd = new SqlCommand(query, conn);
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Log In Failed! Check if you have entered the correct username or password!");
            }
            else
            { 
                conn.Open();
                login = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                if (login > 0)
                {

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    Username = txtUsername.Text;
                    mainForm.Closed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Log In Failed! Check if you have entered the correct username or password!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            
            
        }
    }
}

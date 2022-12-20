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
    public partial class Employees : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        Form addNew = new NewEmployee();
        public static int employeeNo;
        public static string employeeName;
        public static string employeeSurname;
        public static string employeeUsername;
        public static string employeePassword;
        public static string employeeRole;
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM Employee", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvEmployees.DataSource = dt;
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNew.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM Employee", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvEmployees.DataSource = dt;
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employeeNo = int.Parse(dgvEmployees.CurrentRow.Cells[0].Value.ToString());
            employeeName = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
            employeeSurname = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
            employeeUsername = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
            employeePassword = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
            employeeRole = dgvEmployees.CurrentRow.Cells[5].Value.ToString();
            UpdateEmployee update = new UpdateEmployee();
            update.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            SqlCommand cmdDelete = new SqlCommand("Delete From Employee Where EmployeeNo = " + int.Parse(dgvEmployees.CurrentRow.Cells[0].Value.ToString()), conn);
            DialogResult dialog = MessageBox.Show("Are you sure you want to remove employee?", "Remove Employee", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                int rowsAffected = int.Parse(cmdDelete.ExecuteNonQuery().ToString());
                if(rowsAffected == 1)
                {
                    MessageBox.Show("Employee successfully removed!");
                }
                else
                {
                    MessageBox.Show("Action failed!");
                }
            }
            conn.Close();
        }
    }
}

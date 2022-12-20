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
    public partial class MainForm : Form
    {
        Form manageArticles = new ManageArticles();
        Form itemGroups = new ItemGroups();
        Form newOrder = new NewOrder();
        Form currentOrder = new CurrentOrder();
        Form previousOrders = new PreviousOrders();
        Form storage = new Storage();
        Form invoices = new Invoices();
        Form pastInvoices = new PastInvoices();
        Form suppliers = new Suppliers();
        Form employees = new Employees();

        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            frmLogIn login = new frmLogIn();
            txtUsername.Text = frmLogIn.Username;
            SqlCommand cmdRole = new SqlCommand("Select EmployeeRole From Employee Where EmployeeUsername = '"+frmLogIn.Username+"'", conn);
            string role = cmdRole.ExecuteScalar().ToString();
            if (role.Equals("admin"))
            {
                employeesToolStripMenuItem.Visible = true;
            }
            else
            {
                employeesToolStripMenuItem.Visible = false;
            }
            conn.Close();
            manageArticles.MdiParent = this;
            itemGroups.MdiParent = this;
            newOrder.MdiParent = this;
            currentOrder.MdiParent = this;
            previousOrders.MdiParent = this;
            storage.MdiParent = this;
            invoices.MdiParent = this;
            pastInvoices.MdiParent = this;
            suppliers.MdiParent = this;
            employees.MdiParent = this;
            
        }

        private void manageArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                
                ActiveMdiChild.Hide();
            }
            manageArticles.Show();
        }

        private void itemGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                
                ActiveMdiChild.Hide();
            }
            itemGroups.Show();
            
        }

        private void newPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }
            newOrder.Show();
            
        }

        private void currentOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                
                ActiveMdiChild.Hide();
                
            }
            currentOrder.Show();
        }

        private void manageOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                ActiveMdiChild.Hide();
            }
            previousOrders.Show();
        }

        private void storageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                ActiveMdiChild.Hide();
            }
            storage.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                ActiveMdiChild.Hide();
            }
            invoices.Show();
        }

        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                ActiveMdiChild.Hide();
            }
            pastInvoices.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form frmLogIn = new frmLogIn();
                this.Hide();
                frmLogIn.Show();
            }
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                ActiveMdiChild.Hide();
            }
            suppliers.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                ActiveMdiChild.Hide();
            }
            employees.Show();
        }
    }
}

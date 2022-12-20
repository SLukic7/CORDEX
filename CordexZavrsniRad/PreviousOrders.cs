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
    public partial class PreviousOrders : Form
    {
        string sn = "Data Source=DESKTOP-5U7RN97\\SQLEXPRESS;Initial Catalog=CORDEX;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public PreviousOrders()
        {
            InitializeComponent();
        }

        private void PreviousOrders_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT SupplierFullName From Supplier", conn);
            dt = new DataTable();
            sda.Fill(dt);
            cmbSuppliers.DataSource = dt;
            cmbSuppliers.DisplayMember = "SupplierFullName";
            cmbSuppliers.ValueMember = "SupplierFullName";
            sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvPurchaseOrders.DataSource = dt;
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders WHERE PurchaseOrderNo LIKE '%" + txtSearch.Text + "%'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvPurchaseOrders.DataSource = dt;
            conn.Close();
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders WHERE SupplierFullName='" + cmbSuppliers.SelectedValue + "'", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvPurchaseOrders.DataSource = dt;
            conn.Close();
        }

        private void btnClearSupplier_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvPurchaseOrders.DataSource = dt;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (chkDateSupplier.Checked)
             {
                if(cmbSuppliers.SelectedItem != null)
                {
                    conn = new SqlConnection(sn);
                    conn.Open();
                    sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders WHERE Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND SupplierFullName = '" + cmbSuppliers.SelectedValue + "'", conn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dgvPurchaseOrders.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Choose the supplier!");
                }
                    
             }
            else
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders WHERE Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvPurchaseOrders.DataSource = dt;
                conn.Close();
            }
            
            
        }

        private void btnClearDate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvPurchaseOrders.DataSource = dt;
            conn.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedItem.ToString() == "DATE ADDED (NEWEST)")
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders ORDER BY Date DESC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvPurchaseOrders.DataSource = dt;
                conn.Close();
            }
            else if(cmbOrder.SelectedItem.ToString() == "DATE ADDED(OLDEST)")
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders ORDER BY Date ASC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvPurchaseOrders.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Choose the way you want to order your Purchase Orders!");
            }
            
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvPurchaseOrders.DataSource = dt;
            conn.Close();
        }

        private void dgvPurchaseOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                conn = new SqlConnection(sn);
                conn.Open();
                sda = new SqlDataAdapter(@"Select ArticleName,Unit,QTY1,Information1 FROM PastOrder JOIN Article ON Article.ArticleNo = PastOrder.ArticleNo1 WHERE PurchaseOrderNo1 = '"+dgvPurchaseOrders.CurrentRow.Cells[0].Value.ToString() +"'", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dgvOrderedArticles.DataSource = dt;

                string totalCommand = "SELECT Total From PurchaseOrder WHERE PurchaseOrderNo = '" + dgvPurchaseOrders.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand cmdTotal = new SqlCommand(totalCommand, conn);
                txtTotal.Text = cmdTotal.ExecuteScalar().ToString() + " RSD";

                string employeeCommand = "SELECT EmployeeUsername FROM Employee WHERE EmployeeNo = (SELECT EmployeeNo FROM PurchaseOrder WHERE PurchaseOrderNo = '" + dgvPurchaseOrders.CurrentRow.Cells[0].Value.ToString() + "')";
                SqlCommand cmdEmployee = new SqlCommand(employeeCommand, conn);
                txtEmployee.Text = cmdEmployee.ExecuteScalar().ToString();

                conn.Close();
            }
        }

        private void btnResfresh_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sn);
            conn.Open();
            sda = new SqlDataAdapter(@"SELECT * From view_PreviousPurchaseOrders", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvPurchaseOrders.DataSource = dt;
            conn.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        private void ExportToPDF()
        {
            conn = new SqlConnection(sn);
            conn.Open();
            try
            {
                var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                string path = $"C:\\Users\\HP\\source\\repos\\CordexZavrsniRad\\PDF\\"+dgvPurchaseOrders.CurrentRow.Cells[0].Value.ToString()+".pdf";
                PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
                pdfDoc.Open();


                var imagePath = @"C:\\Users\\HP\\source\\repos\\CordexZavrsniRad\\logo.jpg";
                using (FileStream fs = new FileStream(imagePath, FileMode.Open))
                {
                    var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    png.ScalePercent(35f);
                    png.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top);
                    pdfDoc.Add(png);
                }

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };
                pdfDoc.Add(spacer);

                var headerTable = new PdfPTable(new[] { .75f, 2f })
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f }
                };

                SqlCommand cmdAdress = new SqlCommand("Select SupplierAdress From Supplier Where SupplierFullName = '" + dgvPurchaseOrders.CurrentRow.Cells[1].Value.ToString() + "'", conn);
                string adress = cmdAdress.ExecuteScalar().ToString();

                SqlCommand cmdzip = new SqlCommand("Select SupplierZipCode From Supplier Where SupplierFullName = '" + dgvPurchaseOrders.CurrentRow.Cells[1].Value.ToString() + "'", conn);
                string zip = cmdzip.ExecuteScalar().ToString();

                SqlCommand cmdCity = new SqlCommand("Select SupplierCity From Supplier Where SupplierFullName = '" + dgvPurchaseOrders.CurrentRow.Cells[1].Value.ToString() + "'", conn);
                string city = cmdCity.ExecuteScalar().ToString();

                SqlCommand cmdCountry = new SqlCommand("Select SupplierCountry From Supplier Where SupplierFullName = '" + dgvPurchaseOrders.CurrentRow.Cells[1].Value.ToString() + "'", conn);
                string country = cmdCountry.ExecuteScalar().ToString();

                SqlCommand cmdDate = new SqlCommand("Select Date From PurchaseOrder Where PurchaseOrderNo = '" + dgvPurchaseOrders.CurrentRow.Cells[0].Value.ToString() + "'", conn);
                string date = cmdDate.ExecuteScalar().ToString();

                headerTable.AddCell("PurchaseOrderNo");
                headerTable.AddCell(dgvPurchaseOrders.CurrentRow.Cells[0].Value.ToString());
                headerTable.AddCell("Supplier Name");
                headerTable.AddCell(dgvPurchaseOrders.CurrentRow.Cells[1].Value.ToString());
                headerTable.AddCell("Supplier Adress");
                headerTable.AddCell(adress + ", " + zip + " " + city + " " + country);
                headerTable.AddCell("Date");
                headerTable.AddCell(date);
                headerTable.AddCell("Total");
                headerTable.AddCell(txtTotal.Text);

                pdfDoc.Add(headerTable);
                pdfDoc.Add(spacer);

                var columnCount = dgvOrderedArticles.ColumnCount;
                var columnWidths = new[] {2f, 1f, 0.75f, 2f };

                var table = new PdfPTable(columnWidths)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                dgvOrderedArticles.Columns
                    .OfType<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => table.AddCell(c.Name));
                dgvOrderedArticles.Rows
                    .OfType<DataGridViewRow>()
                    .ToList()
                    .ForEach(r =>
                    {
                        var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                        cells.ForEach(c => table.AddCell(c.Value.ToString()));
                    });

                pdfDoc.Add(table);
                pdfDoc.Close();
                MessageBox.Show("File successfully exported!");
            }
            catch (Exception e)
            {

            }
            conn.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string pdfFileName = "C:\\Users\\HP\\source\\repos\\CordexZavrsniRad\\PDF\\" + dgvPurchaseOrders.CurrentRow.Cells[0].Value.ToString() + ".pdf";
            var fileInfo = new FileInfo(pdfFileName);
            if (!fileInfo.Exists)
            {
                MessageBox.Show("PDF File not found! Export it!");
            }
            else
            {
                System.Diagnostics.Process.Start(pdfFileName);
            }
            
        }
    }
}

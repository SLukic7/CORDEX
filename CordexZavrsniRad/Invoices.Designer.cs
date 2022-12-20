
namespace CordexZavrsniRad
{
    partial class Invoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResfresh = new System.Windows.Forms.Button();
            this.chkDateSupplier = new System.Windows.Forms.CheckBox();
            this.btnClearSupplier = new System.Windows.Forms.Button();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearDate = new System.Windows.Forms.Button();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOrderedArticles = new System.Windows.Forms.DataGridView();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStorage = new System.Windows.Forms.ComboBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResfresh
            // 
            this.btnResfresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResfresh.Location = new System.Drawing.Point(11, 377);
            this.btnResfresh.Name = "btnResfresh";
            this.btnResfresh.Size = new System.Drawing.Size(198, 27);
            this.btnResfresh.TabIndex = 67;
            this.btnResfresh.Text = "Refresh";
            this.btnResfresh.UseVisualStyleBackColor = true;
            this.btnResfresh.Click += new System.EventHandler(this.btnResfresh_Click);
            // 
            // chkDateSupplier
            // 
            this.chkDateSupplier.AutoSize = true;
            this.chkDateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateSupplier.Location = new System.Drawing.Point(11, 246);
            this.chkDateSupplier.Name = "chkDateSupplier";
            this.chkDateSupplier.Size = new System.Drawing.Size(189, 17);
            this.chkDateSupplier.TabIndex = 66;
            this.chkDateSupplier.Text = "Search by Date and Supplier";
            this.chkDateSupplier.UseVisualStyleBackColor = true;
            // 
            // btnClearSupplier
            // 
            this.btnClearSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSupplier.Location = new System.Drawing.Point(114, 174);
            this.btnClearSupplier.Name = "btnClearSupplier";
            this.btnClearSupplier.Size = new System.Drawing.Size(95, 27);
            this.btnClearSupplier.TabIndex = 65;
            this.btnClearSupplier.Text = "Clear Search";
            this.btnClearSupplier.UseVisualStyleBackColor = true;
            this.btnClearSupplier.Click += new System.EventHandler(this.btnClearSupplier_Click);
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.Location = new System.Drawing.Point(11, 174);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(97, 27);
            this.btnSearchSupplier.TabIndex = 64;
            this.btnSearchSupplier.Text = "Search";
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.Location = new System.Drawing.Point(114, 344);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(95, 27);
            this.btnClearOrder.TabIndex = 63;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(11, 344);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(97, 27);
            this.btnOrder.TabIndex = 62;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Order By Date:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "DATE ADDED (NEWEST)",
            "DATE ADDED(OLDEST)"});
            this.cmbOrder.Location = new System.Drawing.Point(11, 317);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(198, 21);
            this.cmbOrder.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Search By Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Search by Supplier:";
            // 
            // btnClearDate
            // 
            this.btnClearDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDate.Location = new System.Drawing.Point(114, 269);
            this.btnClearDate.Name = "btnClearDate";
            this.btnClearDate.Size = new System.Drawing.Size(95, 27);
            this.btnClearDate.TabIndex = 57;
            this.btnClearDate.Text = "Clear Search";
            this.btnClearDate.UseVisualStyleBackColor = true;
            this.btnClearDate.Click += new System.EventHandler(this.btnClearDate_Click);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(11, 269);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(97, 27);
            this.btnSearchDate.TabIndex = 56;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(11, 147);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(198, 21);
            this.cmbSuppliers.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Search by Invoice No:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ordered articles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Invoices:";
            // 
            // dgvOrderedArticles
            // 
            this.dgvOrderedArticles.AllowUserToAddRows = false;
            this.dgvOrderedArticles.AllowUserToDeleteRows = false;
            this.dgvOrderedArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderedArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderedArticles.Location = new System.Drawing.Point(558, 64);
            this.dgvOrderedArticles.Name = "dgvOrderedArticles";
            this.dgvOrderedArticles.ReadOnly = true;
            this.dgvOrderedArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderedArticles.Size = new System.Drawing.Size(316, 351);
            this.dgvOrderedArticles.TabIndex = 45;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(215, 64);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(337, 391);
            this.dgvInvoices.TabIndex = 44;
            this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Storages:";
            // 
            // cmbStorage
            // 
            this.cmbStorage.FormattingEnabled = true;
            this.cmbStorage.Location = new System.Drawing.Point(558, 434);
            this.cmbStorage.Name = "cmbStorage";
            this.cmbStorage.Size = new System.Drawing.Size(153, 21);
            this.cmbStorage.TabIndex = 69;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(717, 421);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(157, 34);
            this.btnTransfer.TabIndex = 68;
            this.btnTransfer.Text = "Transfer Articles";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStorage);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnResfresh);
            this.Controls.Add(this.chkDateSupplier);
            this.Controls.Add(this.btnClearSupplier);
            this.Controls.Add(this.btnSearchSupplier);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClearDate);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOrderedArticles);
            this.Controls.Add(this.dgvInvoices);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResfresh;
        private System.Windows.Forms.CheckBox chkDateSupplier;
        private System.Windows.Forms.Button btnClearSupplier;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearDate;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOrderedArticles;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStorage;
        private System.Windows.Forms.Button btnTransfer;
    }
}
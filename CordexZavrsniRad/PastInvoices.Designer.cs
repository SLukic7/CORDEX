
namespace CordexZavrsniRad
{
    partial class PastInvoices
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
            this.btnResfresh.TabIndex = 90;
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
            this.chkDateSupplier.TabIndex = 89;
            this.chkDateSupplier.Text = "Search by Date and Supplier";
            this.chkDateSupplier.UseVisualStyleBackColor = true;
            // 
            // btnClearSupplier
            // 
            this.btnClearSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSupplier.Location = new System.Drawing.Point(114, 174);
            this.btnClearSupplier.Name = "btnClearSupplier";
            this.btnClearSupplier.Size = new System.Drawing.Size(95, 27);
            this.btnClearSupplier.TabIndex = 88;
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
            this.btnSearchSupplier.TabIndex = 87;
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
            this.btnClearOrder.TabIndex = 86;
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
            this.btnOrder.TabIndex = 85;
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
            this.label8.TabIndex = 84;
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
            this.cmbOrder.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Search By Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Search by Supplier:";
            // 
            // btnClearDate
            // 
            this.btnClearDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDate.Location = new System.Drawing.Point(114, 269);
            this.btnClearDate.Name = "btnClearDate";
            this.btnClearDate.Size = new System.Drawing.Size(95, 27);
            this.btnClearDate.TabIndex = 80;
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
            this.btnSearchDate.TabIndex = 79;
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
            this.cmbSuppliers.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Search by Invoice No:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSearch.TabIndex = 76;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Ordered articles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 73;
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
            this.dgvOrderedArticles.Size = new System.Drawing.Size(316, 391);
            this.dgvOrderedArticles.TabIndex = 72;
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
            this.dgvInvoices.TabIndex = 71;
            this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellClick);
            // 
            // PastInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.ControlBox = false;
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
            this.Name = "PastInvoices";
            this.Text = "PastInvoices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PastInvoices_Load);
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
    }
}
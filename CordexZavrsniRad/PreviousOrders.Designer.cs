
namespace CordexZavrsniRad
{
    partial class PreviousOrders
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
            this.dgvPurchaseOrders = new System.Windows.Forms.DataGridView();
            this.dgvOrderedArticles = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearDate = new System.Windows.Forms.Button();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClearSupplier = new System.Windows.Forms.Button();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.chkDateSupplier = new System.Windows.Forms.CheckBox();
            this.btnResfresh = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchaseOrders
            // 
            this.dgvPurchaseOrders.AllowUserToAddRows = false;
            this.dgvPurchaseOrders.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrders.Location = new System.Drawing.Point(214, 64);
            this.dgvPurchaseOrders.Name = "dgvPurchaseOrders";
            this.dgvPurchaseOrders.ReadOnly = true;
            this.dgvPurchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrders.Size = new System.Drawing.Size(337, 352);
            this.dgvPurchaseOrders.TabIndex = 0;
            this.dgvPurchaseOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrders_CellClick);
            // 
            // dgvOrderedArticles
            // 
            this.dgvOrderedArticles.AllowUserToAddRows = false;
            this.dgvOrderedArticles.AllowUserToDeleteRows = false;
            this.dgvOrderedArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvOrderedArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderedArticles.Location = new System.Drawing.Point(557, 64);
            this.dgvOrderedArticles.Name = "dgvOrderedArticles";
            this.dgvOrderedArticles.ReadOnly = true;
            this.dgvOrderedArticles.Size = new System.Drawing.Size(316, 352);
            this.dgvOrderedArticles.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(557, 435);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(157, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(720, 435);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(153, 20);
            this.txtEmployee.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PurchaseOrders:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ordered articles:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Search by Supplier:";
            // 
            // btnClearDate
            // 
            this.btnClearDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDate.Location = new System.Drawing.Point(113, 269);
            this.btnClearDate.Name = "btnClearDate";
            this.btnClearDate.Size = new System.Drawing.Size(95, 27);
            this.btnClearDate.TabIndex = 33;
            this.btnClearDate.Text = "Clear Search";
            this.btnClearDate.UseVisualStyleBackColor = true;
            this.btnClearDate.Click += new System.EventHandler(this.btnClearDate_Click);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(10, 269);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(97, 27);
            this.btnSearchDate.TabIndex = 32;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(10, 147);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(198, 21);
            this.cmbSuppliers.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Search by Purchase Order No:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Search By Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Order By Date:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "DATE ADDED (NEWEST)",
            "DATE ADDED(OLDEST)"});
            this.cmbOrder.Location = new System.Drawing.Point(10, 317);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(198, 21);
            this.cmbOrder.TabIndex = 36;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.Location = new System.Drawing.Point(113, 344);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(95, 27);
            this.btnClearOrder.TabIndex = 39;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(10, 344);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(97, 27);
            this.btnOrder.TabIndex = 38;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClearSupplier
            // 
            this.btnClearSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSupplier.Location = new System.Drawing.Point(113, 174);
            this.btnClearSupplier.Name = "btnClearSupplier";
            this.btnClearSupplier.Size = new System.Drawing.Size(95, 27);
            this.btnClearSupplier.TabIndex = 41;
            this.btnClearSupplier.Text = "Clear Search";
            this.btnClearSupplier.UseVisualStyleBackColor = true;
            this.btnClearSupplier.Click += new System.EventHandler(this.btnClearSupplier_Click);
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.Location = new System.Drawing.Point(10, 174);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(97, 27);
            this.btnSearchSupplier.TabIndex = 40;
            this.btnSearchSupplier.Text = "Search";
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // chkDateSupplier
            // 
            this.chkDateSupplier.AutoSize = true;
            this.chkDateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateSupplier.Location = new System.Drawing.Point(10, 246);
            this.chkDateSupplier.Name = "chkDateSupplier";
            this.chkDateSupplier.Size = new System.Drawing.Size(189, 17);
            this.chkDateSupplier.TabIndex = 42;
            this.chkDateSupplier.Text = "Search by Date and Supplier";
            this.chkDateSupplier.UseVisualStyleBackColor = true;
            // 
            // btnResfresh
            // 
            this.btnResfresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResfresh.Location = new System.Drawing.Point(10, 377);
            this.btnResfresh.Name = "btnResfresh";
            this.btnResfresh.Size = new System.Drawing.Size(198, 27);
            this.btnResfresh.TabIndex = 43;
            this.btnResfresh.Text = "Refresh";
            this.btnResfresh.UseVisualStyleBackColor = true;
            this.btnResfresh.Click += new System.EventHandler(this.btnResfresh_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(389, 428);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(95, 27);
            this.btnView.TabIndex = 45;
            this.btnView.Text = "View PDF";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(286, 428);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 27);
            this.btnExport.TabIndex = 44;
            this.btnExport.Text = "Export PDF";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // PreviousOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.ControlBox = false;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExport);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvOrderedArticles);
            this.Controls.Add(this.dgvPurchaseOrders);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviousOrders";
            this.Text = "PreviousOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PreviousOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPurchaseOrders;
        private System.Windows.Forms.DataGridView dgvOrderedArticles;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearDate;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClearSupplier;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.CheckBox chkDateSupplier;
        private System.Windows.Forms.Button btnResfresh;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExport;
    }
}
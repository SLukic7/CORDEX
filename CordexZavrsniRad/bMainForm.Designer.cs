
namespace CordexZavrsniRad
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articleToolStripMenuItem,
            this.storageToolStripMenuItem,
            this.purchaseOrdersToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articleToolStripMenuItem
            // 
            this.articleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGroupsToolStripMenuItem,
            this.manageArticlesToolStripMenuItem});
            this.articleToolStripMenuItem.Name = "articleToolStripMenuItem";
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.articleToolStripMenuItem.Text = "Articles";
            // 
            // itemGroupsToolStripMenuItem
            // 
            this.itemGroupsToolStripMenuItem.Name = "itemGroupsToolStripMenuItem";
            this.itemGroupsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.itemGroupsToolStripMenuItem.Text = "Item Groups";
            this.itemGroupsToolStripMenuItem.Click += new System.EventHandler(this.itemGroupsToolStripMenuItem_Click);
            // 
            // manageArticlesToolStripMenuItem
            // 
            this.manageArticlesToolStripMenuItem.Name = "manageArticlesToolStripMenuItem";
            this.manageArticlesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.manageArticlesToolStripMenuItem.Text = "Manage articles";
            this.manageArticlesToolStripMenuItem.Click += new System.EventHandler(this.manageArticlesToolStripMenuItem_Click);
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.storageToolStripMenuItem.Text = "Storage";
            this.storageToolStripMenuItem.Click += new System.EventHandler(this.storageToolStripMenuItem_Click);
            // 
            // purchaseOrdersToolStripMenuItem
            // 
            this.purchaseOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPOToolStripMenuItem,
            this.currentOrderToolStripMenuItem,
            this.manageOrdersToolStripMenuItem});
            this.purchaseOrdersToolStripMenuItem.Name = "purchaseOrdersToolStripMenuItem";
            this.purchaseOrdersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseOrdersToolStripMenuItem.Text = "Purchase";
            // 
            // newPOToolStripMenuItem
            // 
            this.newPOToolStripMenuItem.Name = "newPOToolStripMenuItem";
            this.newPOToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newPOToolStripMenuItem.Text = "Order";
            this.newPOToolStripMenuItem.Click += new System.EventHandler(this.newPOToolStripMenuItem_Click);
            // 
            // currentOrderToolStripMenuItem
            // 
            this.currentOrderToolStripMenuItem.Name = "currentOrderToolStripMenuItem";
            this.currentOrderToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.currentOrderToolStripMenuItem.Text = "Current Order";
            this.currentOrderToolStripMenuItem.Click += new System.EventHandler(this.currentOrderToolStripMenuItem_Click);
            // 
            // manageOrdersToolStripMenuItem
            // 
            this.manageOrdersToolStripMenuItem.Name = "manageOrdersToolStripMenuItem";
            this.manageOrdersToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.manageOrdersToolStripMenuItem.Text = "Previous Orders";
            this.manageOrdersToolStripMenuItem.Click += new System.EventHandler(this.manageOrdersToolStripMenuItem_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.manageInvoicesToolStripMenuItem});
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.addToolStripMenuItem1.Text = "Add invoice";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // manageInvoicesToolStripMenuItem
            // 
            this.manageInvoicesToolStripMenuItem.Name = "manageInvoicesToolStripMenuItem";
            this.manageInvoicesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.manageInvoicesToolStripMenuItem.Text = "Previous invoices";
            this.manageInvoicesToolStripMenuItem.Click += new System.EventHandler(this.manageInvoicesToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(670, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(119, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(795, 30);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "CORDEX";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageInvoicesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem currentOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
    }
}
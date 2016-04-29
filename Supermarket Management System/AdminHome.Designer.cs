namespace Supermarket_Management_System
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.addAdminButton = new System.Windows.Forms.Button();
            this.deleteAdminButton = new System.Windows.Forms.Button();
            this.addCashierButton = new System.Windows.Forms.Button();
            this.deleteCashierButton = new System.Windows.Forms.Button();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.deleteSupplierButton = new System.Windows.Forms.Button();
            this.postOrderButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.allDataButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAdminButton
            // 
            this.addAdminButton.Location = new System.Drawing.Point(13, 12);
            this.addAdminButton.Name = "addAdminButton";
            this.addAdminButton.Size = new System.Drawing.Size(133, 23);
            this.addAdminButton.TabIndex = 0;
            this.addAdminButton.Text = "Add Admin";
            this.addAdminButton.UseVisualStyleBackColor = true;
            this.addAdminButton.Click += new System.EventHandler(this.addAdminButton_Click);
            // 
            // deleteAdminButton
            // 
            this.deleteAdminButton.Location = new System.Drawing.Point(13, 43);
            this.deleteAdminButton.Name = "deleteAdminButton";
            this.deleteAdminButton.Size = new System.Drawing.Size(133, 23);
            this.deleteAdminButton.TabIndex = 1;
            this.deleteAdminButton.Text = "Delete Admin";
            this.deleteAdminButton.UseVisualStyleBackColor = true;
            this.deleteAdminButton.Click += new System.EventHandler(this.deleteAdminButton_Click);
            // 
            // addCashierButton
            // 
            this.addCashierButton.Location = new System.Drawing.Point(13, 92);
            this.addCashierButton.Name = "addCashierButton";
            this.addCashierButton.Size = new System.Drawing.Size(133, 23);
            this.addCashierButton.TabIndex = 2;
            this.addCashierButton.Text = "Add Cashier";
            this.addCashierButton.UseVisualStyleBackColor = true;
            this.addCashierButton.Click += new System.EventHandler(this.addCashierButton_Click);
            // 
            // deleteCashierButton
            // 
            this.deleteCashierButton.Location = new System.Drawing.Point(13, 121);
            this.deleteCashierButton.Name = "deleteCashierButton";
            this.deleteCashierButton.Size = new System.Drawing.Size(133, 23);
            this.deleteCashierButton.TabIndex = 3;
            this.deleteCashierButton.Text = "Delete Cashier";
            this.deleteCashierButton.UseVisualStyleBackColor = true;
            this.deleteCashierButton.Click += new System.EventHandler(this.deleteCashierButton_Click);
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.Location = new System.Drawing.Point(19, 173);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(127, 23);
            this.addSupplierButton.TabIndex = 4;
            this.addSupplierButton.Text = "Add Supplier";
            this.addSupplierButton.UseVisualStyleBackColor = true;
            this.addSupplierButton.Click += new System.EventHandler(this.addSupplierButton_Click);
            // 
            // deleteSupplierButton
            // 
            this.deleteSupplierButton.Location = new System.Drawing.Point(19, 202);
            this.deleteSupplierButton.Name = "deleteSupplierButton";
            this.deleteSupplierButton.Size = new System.Drawing.Size(127, 23);
            this.deleteSupplierButton.TabIndex = 5;
            this.deleteSupplierButton.Text = "Delete Supplier";
            this.deleteSupplierButton.UseVisualStyleBackColor = true;
            this.deleteSupplierButton.Click += new System.EventHandler(this.deleteSupplierButton_Click);
            // 
            // postOrderButton
            // 
            this.postOrderButton.Location = new System.Drawing.Point(258, 17);
            this.postOrderButton.Name = "postOrderButton";
            this.postOrderButton.Size = new System.Drawing.Size(89, 75);
            this.postOrderButton.TabIndex = 7;
            this.postOrderButton.Text = "Post Order";
            this.postOrderButton.UseVisualStyleBackColor = true;
            this.postOrderButton.Click += new System.EventHandler(this.postOrderButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(19, 251);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(127, 23);
            this.addItemButton.TabIndex = 8;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // allDataButton
            // 
            this.allDataButton.Location = new System.Drawing.Point(261, 121);
            this.allDataButton.Name = "allDataButton";
            this.allDataButton.Size = new System.Drawing.Size(89, 72);
            this.allDataButton.TabIndex = 9;
            this.allDataButton.Text = "All Data";
            this.allDataButton.UseVisualStyleBackColor = true;
            this.allDataButton.Click += new System.EventHandler(this.allDataButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(261, 251);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(86, 23);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(365, 290);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.allDataButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.postOrderButton);
            this.Controls.Add(this.deleteSupplierButton);
            this.Controls.Add(this.addSupplierButton);
            this.Controls.Add(this.deleteCashierButton);
            this.Controls.Add(this.addCashierButton);
            this.Controls.Add(this.deleteAdminButton);
            this.Controls.Add(this.addAdminButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminHome";
            this.Text = "Admin Home";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAdminButton;
        private System.Windows.Forms.Button deleteAdminButton;
        private System.Windows.Forms.Button addCashierButton;
        private System.Windows.Forms.Button deleteCashierButton;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.Button deleteSupplierButton;
        private System.Windows.Forms.Button postOrderButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button allDataButton;
        private System.Windows.Forms.Button logoutButton;
    }
}
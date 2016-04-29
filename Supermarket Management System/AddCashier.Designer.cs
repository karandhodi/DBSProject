namespace Supermarket_Management_System
{
    partial class AddCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCashier));
            this.addButton = new System.Windows.Forms.Button();
            this.currentAdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.currentAdminPasswordLabel = new System.Windows.Forms.Label();
            this.cashierPasswordTextBox = new System.Windows.Forms.TextBox();
            this.cashierUsernameTextBox = new System.Windows.Forms.TextBox();
            this.cashierIdTextBox = new System.Windows.Forms.TextBox();
            this.outletIdTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cashierPasswordLabel = new System.Windows.Forms.Label();
            this.cashierUsernameLabel = new System.Windows.Forms.Label();
            this.cashierIdLabel = new System.Windows.Forms.Label();
            this.outletIdLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(372, 84);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 102);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // currentAdminPasswordTextBox
            // 
            this.currentAdminPasswordTextBox.Location = new System.Drawing.Point(363, 33);
            this.currentAdminPasswordTextBox.Name = "currentAdminPasswordTextBox";
            this.currentAdminPasswordTextBox.PasswordChar = '*';
            this.currentAdminPasswordTextBox.Size = new System.Drawing.Size(160, 22);
            this.currentAdminPasswordTextBox.TabIndex = 28;
            // 
            // currentAdminPasswordLabel
            // 
            this.currentAdminPasswordLabel.AutoSize = true;
            this.currentAdminPasswordLabel.Location = new System.Drawing.Point(360, 12);
            this.currentAdminPasswordLabel.Name = "currentAdminPasswordLabel";
            this.currentAdminPasswordLabel.Size = new System.Drawing.Size(163, 17);
            this.currentAdminPasswordLabel.TabIndex = 27;
            this.currentAdminPasswordLabel.Text = "Current Admin Password";
            // 
            // cashierPasswordTextBox
            // 
            this.cashierPasswordTextBox.Location = new System.Drawing.Point(156, 207);
            this.cashierPasswordTextBox.Name = "cashierPasswordTextBox";
            this.cashierPasswordTextBox.PasswordChar = '*';
            this.cashierPasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.cashierPasswordTextBox.TabIndex = 26;
            // 
            // cashierUsernameTextBox
            // 
            this.cashierUsernameTextBox.Location = new System.Drawing.Point(156, 166);
            this.cashierUsernameTextBox.Name = "cashierUsernameTextBox";
            this.cashierUsernameTextBox.Size = new System.Drawing.Size(100, 22);
            this.cashierUsernameTextBox.TabIndex = 25;
            // 
            // cashierIdTextBox
            // 
            this.cashierIdTextBox.Location = new System.Drawing.Point(156, 12);
            this.cashierIdTextBox.Name = "cashierIdTextBox";
            this.cashierIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.cashierIdTextBox.TabIndex = 24;
            // 
            // outletIdTextBox
            // 
            this.outletIdTextBox.Location = new System.Drawing.Point(156, 124);
            this.outletIdTextBox.Name = "outletIdTextBox";
            this.outletIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.outletIdTextBox.TabIndex = 23;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(156, 83);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTextBox.TabIndex = 22;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(156, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 21;
            // 
            // cashierPasswordLabel
            // 
            this.cashierPasswordLabel.AutoSize = true;
            this.cashierPasswordLabel.Location = new System.Drawing.Point(12, 212);
            this.cashierPasswordLabel.Name = "cashierPasswordLabel";
            this.cashierPasswordLabel.Size = new System.Drawing.Size(121, 17);
            this.cashierPasswordLabel.TabIndex = 20;
            this.cashierPasswordLabel.Text = "Cashier Password";
            // 
            // cashierUsernameLabel
            // 
            this.cashierUsernameLabel.AutoSize = true;
            this.cashierUsernameLabel.Location = new System.Drawing.Point(12, 169);
            this.cashierUsernameLabel.Name = "cashierUsernameLabel";
            this.cashierUsernameLabel.Size = new System.Drawing.Size(125, 17);
            this.cashierUsernameLabel.TabIndex = 19;
            this.cashierUsernameLabel.Text = "Cashier Username";
            // 
            // cashierIdLabel
            // 
            this.cashierIdLabel.AutoSize = true;
            this.cashierIdLabel.Location = new System.Drawing.Point(12, 17);
            this.cashierIdLabel.Name = "cashierIdLabel";
            this.cashierIdLabel.Size = new System.Drawing.Size(73, 17);
            this.cashierIdLabel.TabIndex = 18;
            this.cashierIdLabel.Text = "Cashier ID";
            // 
            // outletIdLabel
            // 
            this.outletIdLabel.AutoSize = true;
            this.outletIdLabel.Location = new System.Drawing.Point(12, 127);
            this.outletIdLabel.Name = "outletIdLabel";
            this.outletIdLabel.Size = new System.Drawing.Size(63, 17);
            this.outletIdLabel.TabIndex = 17;
            this.outletIdLabel.Text = "Outlet ID";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(12, 88);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(48, 17);
            this.salaryLabel.TabIndex = 16;
            this.salaryLabel.Text = "Salary";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 52);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(400, 206);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(578, 250);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.currentAdminPasswordTextBox);
            this.Controls.Add(this.currentAdminPasswordLabel);
            this.Controls.Add(this.cashierPasswordTextBox);
            this.Controls.Add(this.cashierUsernameTextBox);
            this.Controls.Add(this.cashierIdTextBox);
            this.Controls.Add(this.outletIdTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cashierPasswordLabel);
            this.Controls.Add(this.cashierUsernameLabel);
            this.Controls.Add(this.cashierIdLabel);
            this.Controls.Add(this.outletIdLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCashier";
            this.Text = "Add Cashier";
            this.Load += new System.EventHandler(this.AddCashier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox currentAdminPasswordTextBox;
        private System.Windows.Forms.Label currentAdminPasswordLabel;
        private System.Windows.Forms.TextBox cashierPasswordTextBox;
        private System.Windows.Forms.TextBox cashierUsernameTextBox;
        private System.Windows.Forms.TextBox cashierIdTextBox;
        private System.Windows.Forms.TextBox outletIdTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label cashierPasswordLabel;
        private System.Windows.Forms.Label cashierUsernameLabel;
        private System.Windows.Forms.Label cashierIdLabel;
        private System.Windows.Forms.Label outletIdLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button backButton;
    }
}
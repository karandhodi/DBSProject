namespace Supermarket_Management_System
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            this.cashierNameLabel = new System.Windows.Forms.Label();
            this.supplierIdLabel = new System.Windows.Forms.Label();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.currentAdminPasswordLabel = new System.Windows.Forms.Label();
            this.currentAdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashierNameLabel
            // 
            this.cashierNameLabel.AutoSize = true;
            this.cashierNameLabel.Location = new System.Drawing.Point(13, 13);
            this.cashierNameLabel.Name = "cashierNameLabel";
            this.cashierNameLabel.Size = new System.Drawing.Size(45, 17);
            this.cashierNameLabel.TabIndex = 0;
            this.cashierNameLabel.Text = "Name";
            // 
            // supplierIdLabel
            // 
            this.supplierIdLabel.AutoSize = true;
            this.supplierIdLabel.Location = new System.Drawing.Point(13, 53);
            this.supplierIdLabel.Name = "supplierIdLabel";
            this.supplierIdLabel.Size = new System.Drawing.Size(77, 17);
            this.supplierIdLabel.TabIndex = 1;
            this.supplierIdLabel.Text = "Supplier ID";
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.Location = new System.Drawing.Point(126, 13);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.supplierNameTextBox.TabIndex = 2;
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.Location = new System.Drawing.Point(126, 50);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.supplierIdTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(68, 201);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 47);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // currentAdminPasswordLabel
            // 
            this.currentAdminPasswordLabel.AutoSize = true;
            this.currentAdminPasswordLabel.Location = new System.Drawing.Point(13, 116);
            this.currentAdminPasswordLabel.Name = "currentAdminPasswordLabel";
            this.currentAdminPasswordLabel.Size = new System.Drawing.Size(163, 17);
            this.currentAdminPasswordLabel.TabIndex = 5;
            this.currentAdminPasswordLabel.Text = "Current Admin Password";
            // 
            // currentAdminPasswordTextBox
            // 
            this.currentAdminPasswordTextBox.Location = new System.Drawing.Point(16, 136);
            this.currentAdminPasswordTextBox.Name = "currentAdminPasswordTextBox";
            this.currentAdminPasswordTextBox.PasswordChar = '*';
            this.currentAdminPasswordTextBox.Size = new System.Drawing.Size(160, 22);
            this.currentAdminPasswordTextBox.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(81, 263);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(233, 312);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.currentAdminPasswordTextBox);
            this.Controls.Add(this.currentAdminPasswordLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.supplierIdTextBox);
            this.Controls.Add(this.supplierNameTextBox);
            this.Controls.Add(this.supplierIdLabel);
            this.Controls.Add(this.cashierNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupplier";
            this.Text = "Add Supplier";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cashierNameLabel;
        private System.Windows.Forms.Label supplierIdLabel;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label currentAdminPasswordLabel;
        private System.Windows.Forms.TextBox currentAdminPasswordTextBox;
        private System.Windows.Forms.Button backButton;
    }
}
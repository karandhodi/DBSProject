namespace Supermarket_Management_System
{
    partial class DeleteSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteSupplier));
            this.supplierIdLabel = new System.Windows.Forms.Label();
            this.currentAdminPasswordLabel = new System.Windows.Forms.Label();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.currentAdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // supplierIdLabel
            // 
            this.supplierIdLabel.AutoSize = true;
            this.supplierIdLabel.Location = new System.Drawing.Point(13, 13);
            this.supplierIdLabel.Name = "supplierIdLabel";
            this.supplierIdLabel.Size = new System.Drawing.Size(75, 17);
            this.supplierIdLabel.TabIndex = 0;
            this.supplierIdLabel.Text = "Supplier Id";
            // 
            // currentAdminPasswordLabel
            // 
            this.currentAdminPasswordLabel.AutoSize = true;
            this.currentAdminPasswordLabel.Location = new System.Drawing.Point(16, 83);
            this.currentAdminPasswordLabel.Name = "currentAdminPasswordLabel";
            this.currentAdminPasswordLabel.Size = new System.Drawing.Size(163, 17);
            this.currentAdminPasswordLabel.TabIndex = 1;
            this.currentAdminPasswordLabel.Text = "Current Admin Password";
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.Location = new System.Drawing.Point(95, 13);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.Size = new System.Drawing.Size(166, 22);
            this.supplierIdTextBox.TabIndex = 2;
            // 
            // currentAdminPasswordTextBox
            // 
            this.currentAdminPasswordTextBox.Location = new System.Drawing.Point(19, 103);
            this.currentAdminPasswordTextBox.Name = "currentAdminPasswordTextBox";
            this.currentAdminPasswordTextBox.PasswordChar = '*';
            this.currentAdminPasswordTextBox.Size = new System.Drawing.Size(160, 22);
            this.currentAdminPasswordTextBox.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(95, 162);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 84);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(114, 265);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DeleteSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(341, 327);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.currentAdminPasswordTextBox);
            this.Controls.Add(this.supplierIdTextBox);
            this.Controls.Add(this.currentAdminPasswordLabel);
            this.Controls.Add(this.supplierIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteSupplier";
            this.Text = "DeleteSupplier";
            this.Load += new System.EventHandler(this.DeleteSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label supplierIdLabel;
        private System.Windows.Forms.Label currentAdminPasswordLabel;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.TextBox currentAdminPasswordTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
    }
}
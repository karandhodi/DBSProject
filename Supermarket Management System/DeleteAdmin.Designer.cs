namespace Supermarket_Management_System
{
    partial class DeleteAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAdmin));
            this.adminIdLabel = new System.Windows.Forms.Label();
            this.adminIdTextBox = new System.Windows.Forms.TextBox();
            this.currentAdminPasswordLabel = new System.Windows.Forms.Label();
            this.currentAdminPassowrdTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminIdLabel
            // 
            this.adminIdLabel.AutoSize = true;
            this.adminIdLabel.Location = new System.Drawing.Point(13, 22);
            this.adminIdLabel.Name = "adminIdLabel";
            this.adminIdLabel.Size = new System.Drawing.Size(64, 17);
            this.adminIdLabel.TabIndex = 0;
            this.adminIdLabel.Text = "Admin ID";
            // 
            // adminIdTextBox
            // 
            this.adminIdTextBox.Location = new System.Drawing.Point(93, 22);
            this.adminIdTextBox.Name = "adminIdTextBox";
            this.adminIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.adminIdTextBox.TabIndex = 1;
            // 
            // currentAdminPasswordLabel
            // 
            this.currentAdminPasswordLabel.AutoSize = true;
            this.currentAdminPasswordLabel.Location = new System.Drawing.Point(12, 74);
            this.currentAdminPasswordLabel.Name = "currentAdminPasswordLabel";
            this.currentAdminPasswordLabel.Size = new System.Drawing.Size(163, 17);
            this.currentAdminPasswordLabel.TabIndex = 2;
            this.currentAdminPasswordLabel.Text = "Current Admin Password";
            // 
            // currentAdminPassowrdTextBox
            // 
            this.currentAdminPassowrdTextBox.Location = new System.Drawing.Point(12, 94);
            this.currentAdminPassowrdTextBox.Name = "currentAdminPassowrdTextBox";
            this.currentAdminPassowrdTextBox.PasswordChar = '*';
            this.currentAdminPassowrdTextBox.Size = new System.Drawing.Size(160, 22);
            this.currentAdminPassowrdTextBox.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(16, 158);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 71);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(46, 253);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DeleteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(201, 298);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.currentAdminPassowrdTextBox);
            this.Controls.Add(this.currentAdminPasswordLabel);
            this.Controls.Add(this.adminIdTextBox);
            this.Controls.Add(this.adminIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteAdmin";
            this.Text = "Delete Admin";
            this.Load += new System.EventHandler(this.DeleteAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminIdLabel;
        private System.Windows.Forms.TextBox adminIdTextBox;
        private System.Windows.Forms.Label currentAdminPasswordLabel;
        private System.Windows.Forms.TextBox currentAdminPassowrdTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
    }
}
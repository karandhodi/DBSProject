namespace Supermarket_Management_System
{
    partial class DeleteCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCashier));
            this.deleteButton = new System.Windows.Forms.Button();
            this.currentAdminPassowrdTextBox = new System.Windows.Forms.TextBox();
            this.currentAdminPasswordLabel = new System.Windows.Forms.Label();
            this.cashierIdTextBox = new System.Windows.Forms.TextBox();
            this.cashierIdLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(25, 133);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 71);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // currentAdminPassowrdTextBox
            // 
            this.currentAdminPassowrdTextBox.Location = new System.Drawing.Point(12, 79);
            this.currentAdminPassowrdTextBox.Name = "currentAdminPassowrdTextBox";
            this.currentAdminPassowrdTextBox.PasswordChar = '*';
            this.currentAdminPassowrdTextBox.Size = new System.Drawing.Size(160, 22);
            this.currentAdminPassowrdTextBox.TabIndex = 8;
            // 
            // currentAdminPasswordLabel
            // 
            this.currentAdminPasswordLabel.AutoSize = true;
            this.currentAdminPasswordLabel.Location = new System.Drawing.Point(12, 59);
            this.currentAdminPasswordLabel.Name = "currentAdminPasswordLabel";
            this.currentAdminPasswordLabel.Size = new System.Drawing.Size(163, 17);
            this.currentAdminPasswordLabel.TabIndex = 7;
            this.currentAdminPasswordLabel.Text = "Current Admin Password";
            // 
            // cashierIdTextBox
            // 
            this.cashierIdTextBox.Location = new System.Drawing.Point(91, 9);
            this.cashierIdTextBox.Name = "cashierIdTextBox";
            this.cashierIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.cashierIdTextBox.TabIndex = 6;
            // 
            // cashierIdLabel
            // 
            this.cashierIdLabel.AutoSize = true;
            this.cashierIdLabel.Location = new System.Drawing.Point(12, 9);
            this.cashierIdLabel.Name = "cashierIdLabel";
            this.cashierIdLabel.Size = new System.Drawing.Size(73, 17);
            this.cashierIdLabel.TabIndex = 5;
            this.cashierIdLabel.Text = "Cashier ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(62, 226);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DeleteCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(199, 277);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.currentAdminPassowrdTextBox);
            this.Controls.Add(this.currentAdminPasswordLabel);
            this.Controls.Add(this.cashierIdTextBox);
            this.Controls.Add(this.cashierIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteCashier";
            this.Text = "Delete Cashier";
            this.Load += new System.EventHandler(this.DeleteCashier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox currentAdminPassowrdTextBox;
        private System.Windows.Forms.Label currentAdminPasswordLabel;
        private System.Windows.Forms.TextBox cashierIdTextBox;
        private System.Windows.Forms.Label cashierIdLabel;
        private System.Windows.Forms.Button backButton;
    }
}
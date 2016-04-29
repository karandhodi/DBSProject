namespace Supermarket_Management_System
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.articleIdLabel = new System.Windows.Forms.Label();
            this.mrpLabel = new System.Windows.Forms.Label();
            this.currentAdminPasswordLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.articleIdTextBox = new System.Windows.Forms.TextBox();
            this.currentAdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 58);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(13, 100);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(92, 17);
            this.manufacturerLabel.TabIndex = 2;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // articleIdLabel
            // 
            this.articleIdLabel.AutoSize = true;
            this.articleIdLabel.Location = new System.Drawing.Point(300, 9);
            this.articleIdLabel.Name = "articleIdLabel";
            this.articleIdLabel.Size = new System.Drawing.Size(64, 17);
            this.articleIdLabel.TabIndex = 3;
            this.articleIdLabel.Text = "Article ID";
            // 
            // mrpLabel
            // 
            this.mrpLabel.AutoSize = true;
            this.mrpLabel.Location = new System.Drawing.Point(13, 148);
            this.mrpLabel.Name = "mrpLabel";
            this.mrpLabel.Size = new System.Drawing.Size(113, 17);
            this.mrpLabel.TabIndex = 4;
            this.mrpLabel.Text = "Max. Retail Price";
            // 
            // currentAdminPasswordLabel
            // 
            this.currentAdminPasswordLabel.AutoSize = true;
            this.currentAdminPasswordLabel.Location = new System.Drawing.Point(127, 206);
            this.currentAdminPasswordLabel.Name = "currentAdminPasswordLabel";
            this.currentAdminPasswordLabel.Size = new System.Drawing.Size(163, 17);
            this.currentAdminPasswordLabel.TabIndex = 5;
            this.currentAdminPasswordLabel.Text = "Current Admin Password";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(130, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(130, 53);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.typeTextBox.TabIndex = 7;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(130, 97);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufacturerTextBox.TabIndex = 8;
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(130, 148);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(100, 22);
            this.mrpTextBox.TabIndex = 9;
            // 
            // articleIdTextBox
            // 
            this.articleIdTextBox.Location = new System.Drawing.Point(303, 29);
            this.articleIdTextBox.Name = "articleIdTextBox";
            this.articleIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.articleIdTextBox.TabIndex = 10;
            // 
            // currentAdminPasswordTextBox
            // 
            this.currentAdminPasswordTextBox.Location = new System.Drawing.Point(130, 226);
            this.currentAdminPasswordTextBox.Name = "currentAdminPasswordTextBox";
            this.currentAdminPasswordTextBox.PasswordChar = '*';
            this.currentAdminPasswordTextBox.Size = new System.Drawing.Size(160, 22);
            this.currentAdminPasswordTextBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(130, 254);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 59);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(177, 338);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(415, 391);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.currentAdminPasswordTextBox);
            this.Controls.Add(this.articleIdTextBox);
            this.Controls.Add(this.mrpTextBox);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.currentAdminPasswordLabel);
            this.Controls.Add(this.mrpLabel);
            this.Controls.Add(this.articleIdLabel);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItem";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label articleIdLabel;
        private System.Windows.Forms.Label mrpLabel;
        private System.Windows.Forms.Label currentAdminPasswordLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.TextBox articleIdTextBox;
        private System.Windows.Forms.TextBox currentAdminPasswordTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
    }
}
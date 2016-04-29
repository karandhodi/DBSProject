namespace Supermarket_Management_System
{
    partial class PostOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostOrder));
            this.articleIdLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.articleIdTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.billNumberTextBox = new System.Windows.Forms.TextBox();
            this.billNumberLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdLabel = new System.Windows.Forms.Label();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // articleIdLabel
            // 
            this.articleIdLabel.AutoSize = true;
            this.articleIdLabel.Location = new System.Drawing.Point(12, 9);
            this.articleIdLabel.Name = "articleIdLabel";
            this.articleIdLabel.Size = new System.Drawing.Size(64, 17);
            this.articleIdLabel.TabIndex = 0;
            this.articleIdLabel.Text = "Article ID";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(12, 43);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity";
            // 
            // articleIdTextBox
            // 
            this.articleIdTextBox.Location = new System.Drawing.Point(113, 12);
            this.articleIdTextBox.Name = "articleIdTextBox";
            this.articleIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.articleIdTextBox.TabIndex = 2;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(113, 43);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 3;
            // 
            // billNumberTextBox
            // 
            this.billNumberTextBox.Location = new System.Drawing.Point(303, 40);
            this.billNumberTextBox.Name = "billNumberTextBox";
            this.billNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.billNumberTextBox.TabIndex = 4;
            // 
            // billNumberLabel
            // 
            this.billNumberLabel.AutoSize = true;
            this.billNumberLabel.Location = new System.Drawing.Point(300, 15);
            this.billNumberLabel.Name = "billNumberLabel";
            this.billNumberLabel.Size = new System.Drawing.Size(80, 17);
            this.billNumberLabel.TabIndex = 5;
            this.billNumberLabel.Text = "Bill Number";
            this.billNumberLabel.Click += new System.EventHandler(this.billNumberLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(15, 78);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(113, 78);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 7;
            // 
            // supplierIdLabel
            // 
            this.supplierIdLabel.AutoSize = true;
            this.supplierIdLabel.Location = new System.Drawing.Point(12, 113);
            this.supplierIdLabel.Name = "supplierIdLabel";
            this.supplierIdLabel.Size = new System.Drawing.Size(77, 17);
            this.supplierIdLabel.TabIndex = 8;
            this.supplierIdLabel.Text = "Supplier ID";
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.Location = new System.Drawing.Point(113, 113);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.supplierIdTextBox.TabIndex = 9;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(153, 167);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 55);
            this.orderButton.TabIndex = 10;
            this.orderButton.Text = "ORDER";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(153, 238);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // PostOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(414, 289);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.supplierIdTextBox);
            this.Controls.Add(this.supplierIdLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.billNumberLabel);
            this.Controls.Add(this.billNumberTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.articleIdTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.articleIdLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostOrder";
            this.Text = "Post Order";
            this.Load += new System.EventHandler(this.PostOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label articleIdLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox articleIdTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox billNumberTextBox;
        private System.Windows.Forms.Label billNumberLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label supplierIdLabel;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button backButton;
    }
}
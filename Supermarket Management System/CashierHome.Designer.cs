namespace Supermarket_Management_System
{
    partial class CashierHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierHome));
            this.label1 = new System.Windows.Forms.Label();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.billNumberLabel = new System.Windows.Forms.Label();
            this.newRadioButton = new System.Windows.Forms.RadioButton();
            this.existingRadioButton = new System.Windows.Forms.RadioButton();
            this.displayBillNumberLabel = new System.Windows.Forms.Label();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.articleIdLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.articleIdTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalDisplayLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.getNameButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdLabel.Location = new System.Drawing.Point(13, 85);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(115, 20);
            this.customerIdLabel.TabIndex = 1;
            this.customerIdLabel.Text = "Customer ID";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(13, 121);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(144, 20);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // billNumberLabel
            // 
            this.billNumberLabel.AutoSize = true;
            this.billNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumberLabel.Location = new System.Drawing.Point(316, 155);
            this.billNumberLabel.Name = "billNumberLabel";
            this.billNumberLabel.Size = new System.Drawing.Size(66, 20);
            this.billNumberLabel.TabIndex = 3;
            this.billNumberLabel.Text = "Bill No";
            // 
            // newRadioButton
            // 
            this.newRadioButton.AutoSize = true;
            this.newRadioButton.Location = new System.Drawing.Point(198, 50);
            this.newRadioButton.Name = "newRadioButton";
            this.newRadioButton.Size = new System.Drawing.Size(120, 21);
            this.newRadioButton.TabIndex = 4;
            this.newRadioButton.TabStop = true;
            this.newRadioButton.Text = "New Customer";
            this.newRadioButton.UseVisualStyleBackColor = true;
            this.newRadioButton.CheckedChanged += new System.EventHandler(this.newRadioButton_CheckedChanged);
            // 
            // existingRadioButton
            // 
            this.existingRadioButton.AutoSize = true;
            this.existingRadioButton.Location = new System.Drawing.Point(345, 50);
            this.existingRadioButton.Name = "existingRadioButton";
            this.existingRadioButton.Size = new System.Drawing.Size(141, 21);
            this.existingRadioButton.TabIndex = 5;
            this.existingRadioButton.TabStop = true;
            this.existingRadioButton.Text = "Existing Customer";
            this.existingRadioButton.UseVisualStyleBackColor = true;
            this.existingRadioButton.CheckedChanged += new System.EventHandler(this.existingRadioButton_CheckedChanged);
            // 
            // displayBillNumberLabel
            // 
            this.displayBillNumberLabel.AutoSize = true;
            this.displayBillNumberLabel.Location = new System.Drawing.Point(388, 157);
            this.displayBillNumberLabel.Name = "displayBillNumberLabel";
            this.displayBillNumberLabel.Size = new System.Drawing.Size(121, 17);
            this.displayBillNumberLabel.TabIndex = 6;
            this.displayBillNumberLabel.Text = "--autogenerated--";
            this.displayBillNumberLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(181, 85);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(221, 22);
            this.customerIdTextBox.TabIndex = 7;
            this.customerIdTextBox.TextChanged += new System.EventHandler(this.customerIdTextBox_TextChanged);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(181, 118);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(221, 22);
            this.customerNameTextBox.TabIndex = 8;
            // 
            // articleIdLabel
            // 
            this.articleIdLabel.AutoSize = true;
            this.articleIdLabel.Location = new System.Drawing.Point(17, 211);
            this.articleIdLabel.Name = "articleIdLabel";
            this.articleIdLabel.Size = new System.Drawing.Size(64, 17);
            this.articleIdLabel.TabIndex = 9;
            this.articleIdLabel.Text = "Article ID";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(226, 211);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "Quantity";
            // 
            // articleIdTextBox
            // 
            this.articleIdTextBox.Location = new System.Drawing.Point(88, 211);
            this.articleIdTextBox.Name = "articleIdTextBox";
            this.articleIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.articleIdTextBox.TabIndex = 11;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(293, 208);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 12;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(317, 397);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(54, 17);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "TOTAL";
            // 
            // totalDisplayLabel
            // 
            this.totalDisplayLabel.AutoSize = true;
            this.totalDisplayLabel.Location = new System.Drawing.Point(391, 397);
            this.totalDisplayLabel.Name = "totalDisplayLabel";
            this.totalDisplayLabel.Size = new System.Drawing.Size(86, 17);
            this.totalDisplayLabel.TabIndex = 14;
            this.totalDisplayLabel.Text = "-show total--";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 139);
            this.dataGridView1.TabIndex = 15;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(46, 397);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(111, 23);
            this.checkoutButton.TabIndex = 16;
            this.checkoutButton.Text = "CHECKOUT";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(445, 208);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // getNameButton
            // 
            this.getNameButton.Location = new System.Drawing.Point(433, 83);
            this.getNameButton.Name = "getNameButton";
            this.getNameButton.Size = new System.Drawing.Size(87, 23);
            this.getNameButton.TabIndex = 18;
            this.getNameButton.Text = "Get Name";
            this.getNameButton.UseVisualStyleBackColor = true;
            this.getNameButton.Click += new System.EventHandler(this.getNameButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 152);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(163, 20);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Date (YY-MM-DD)";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(198, 152);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 20;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(13, 9);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(87, 23);
            this.logOutButton.TabIndex = 21;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // CashierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 432);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.getNameButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalDisplayLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.articleIdTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.articleIdLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.displayBillNumberLabel);
            this.Controls.Add(this.existingRadioButton);
            this.Controls.Add(this.newRadioButton);
            this.Controls.Add(this.billNumberLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashierHome";
            this.Text = "CashierHome";
            this.Load += new System.EventHandler(this.CashierHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label billNumberLabel;
        private System.Windows.Forms.RadioButton newRadioButton;
        private System.Windows.Forms.RadioButton existingRadioButton;
        private System.Windows.Forms.Label displayBillNumberLabel;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label articleIdLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox articleIdTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalDisplayLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button getNameButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button logOutButton;
    }
}
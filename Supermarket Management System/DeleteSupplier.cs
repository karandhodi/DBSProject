﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Supermarket_Management_System
{
    public partial class DeleteSupplier : Form
    {
        string adminusername;
        string adminpassword;

        public DeleteSupplier(string auser, string apass)
        {
            InitializeComponent();

            adminusername = auser;
            adminpassword = apass;
        }

        private void DeleteSupplier_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentAdminPasswordTextBox.Text.Equals(adminpassword))
            {
                try
                {
                    string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                    string Query = "delete from suppliers where supplier_id = " + supplierIdTextBox.Text + ";";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Supplier Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Incorrect password entered");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            AdminHome form = new AdminHome(adminusername, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();
        }
    }
}

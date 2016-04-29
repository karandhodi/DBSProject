using System;
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
    public partial class AddSupplier : Form
    {
        string adminusername;
        string adminpassword;
        string currentSupplierIdString;
        int currentSupplierId;

        public AddSupplier(string auser, string apass)
        {
            InitializeComponent();
            adminusername = auser;
            adminpassword = apass;
            supplierIdTextBox.Enabled = false;
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (supplierNameTextBox.Text.Contains('1') || supplierNameTextBox.Text.Contains('2') || supplierNameTextBox.Text.Contains('3') || supplierNameTextBox.Text.Contains('4') || supplierNameTextBox.Text.Contains('5') || supplierNameTextBox.Text.Contains('6') || supplierNameTextBox.Text.Contains('7') || supplierNameTextBox.Text.Contains('8') || supplierNameTextBox.Text.Contains('9'))
            {
                MessageBox.Show("Name field cannot have numbers !");
                supplierNameTextBox.Text = "";
            }
            else
            {


                if (currentAdminPasswordTextBox.Text.Equals(adminpassword))
                {
                    try
                    {


                        string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                        //Display query  
                        string Query = "select max(supplier_id) from suppliers";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        //  MyConn2.Open();  
                        //For offline connection we weill use  MySqlDataAdapter class.  
                        MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand2;

                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);

                        foreach (DataRow row in dTable.Rows)
                        {
                            currentSupplierIdString = row["max(supplier_id)"].ToString();
                        }

                        currentSupplierId = Int32.Parse(currentSupplierIdString);
                        currentSupplierId++;
                        currentSupplierIdString = currentSupplierId.ToString();
                        supplierIdTextBox.Text = currentSupplierIdString;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        //This is my connection string i have assigned the database file address path  
                        string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                        //This is my insert query in which i am taking input from the user through windows forms  
                        string Query = "insert into suppliers values(" + supplierIdTextBox.Text + ", '" + supplierNameTextBox.Text + "');";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        //This is command class which will handle the query and connection object.  
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Supplier Added");
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


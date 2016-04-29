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
    public partial class AddCashier : Form
        
    {
        string adminusername;
        string adminpassword;
        string currentCashierIdString;
        int currentCashierId;

        public AddCashier(string auser, string apass)
        {
            InitializeComponent();
            adminusername = auser;
            adminpassword = apass;
            cashierIdTextBox.Enabled = false;

        }

        private void AddCashier_Load(object sender, EventArgs e)
        {
           
    }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Contains('1') || nameTextBox.Text.Contains('2') || nameTextBox.Text.Contains('3') || nameTextBox.Text.Contains('4') || nameTextBox.Text.Contains('5') || nameTextBox.Text.Contains('6') || nameTextBox.Text.Contains('7') || nameTextBox.Text.Contains('8') || nameTextBox.Text.Contains('9'))
            {
                MessageBox.Show("Name field cannot have numbers !");
                nameTextBox.Text = "";
            }
            else
            {


                if (currentAdminPasswordTextBox.Text.Equals(adminpassword))
                {
                    try
                    {


                        string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                        //Display query  
                        string Query = "select max(c_id) from cashier";
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
                            currentCashierIdString = row["max(c_id)"].ToString();
                        }

                        currentCashierId = Int32.Parse(currentCashierIdString);
                        currentCashierId++;
                        currentCashierIdString = currentCashierId.ToString();
                        cashierIdTextBox.Text = currentCashierIdString;
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
                        string Query = "insert into cashier values('" + nameTextBox.Text + "', " + salaryTextBox.Text + ", " + outletIdTextBox.Text + ", " + currentCashierIdString + ", '" + cashierUsernameTextBox.Text + "', '" + cashierPasswordTextBox.Text + "');";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        //This is command class which will handle the query and connection object.  
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Cashier Added");
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


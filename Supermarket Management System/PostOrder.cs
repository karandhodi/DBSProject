using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class PostOrder : Form
    {
       
        int intsbill;
        string sbill;

        string adminusername;
        string adminpassword;

        public PostOrder(string auser, string apass)
        {
            InitializeComponent();
            adminusername = auser;
            adminpassword = apass;
            billNumberTextBox.Enabled = false;

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update stock set quantity=quantity+" + quantityTextBox.Text + " where article_id='" + articleIdTextBox.Text + "';";
                //customerNameTextBox.Text = Query;
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //Display query  
                string Query = "select max(s_bill) from supplierorders ;";
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
                    sbill = row["max(s_bill)"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            intsbill = Int32.Parse(sbill+"");
            ++intsbill;
            billNumberTextBox.Text = ""+intsbill;


            try
            {

                string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //This is my  query in which i am taking input from the user through windows forms  
                string Query = "insert into supplierorders values(" + intsbill + "," + supplierIdTextBox.Text + ",'" + dateTextBox.Text + "', "+articleIdTextBox.Text+");";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Order Posted !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            AdminHome form = new AdminHome(adminusername, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {

            AdminHome form = new AdminHome(adminusername, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void billNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void PostOrder_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Supermarket_Management_System
{
    public partial class CashierHome : Form
    {
        int x, y;
        int total = 0;
        string name,a_name,a_mrp;
        DataTable dt = new DataTable();
        public string oid;
        public CashierHome(string s)
        {
            InitializeComponent();
            newRadioButton.Checked = true;
            FileStream F = new FileStream("d:\\custID.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            x = Int32.Parse("" + F.ReadByte());
            F.Close();
            customerIdTextBox.Text = "" + x.ToString();
            FileStream F1 = new FileStream("d:\\billno.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            y = Int32.Parse("" + F1.ReadByte());
            F1.Close();
            displayBillNumberLabel.Text = "" + y.ToString();
            oid = s;
            
            dt.Clear();
            dt.Columns.Add("Article ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Total Price");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CashierHome_Load(object sender, EventArgs e)
        {

        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (newRadioButton.Checked)
            {
                if (customerNameTextBox.Text.Contains('1') || customerNameTextBox.Text.Contains('2') || customerNameTextBox.Text.Contains('3') || customerNameTextBox.Text.Contains('4') || customerNameTextBox.Text.Contains('5') || customerNameTextBox.Text.Contains('6') || customerNameTextBox.Text.Contains('7') || customerNameTextBox.Text.Contains('8') || customerNameTextBox.Text.Contains('9'))
                {
                    MessageBox.Show("Name field cannot have numbers !");
                    customerNameTextBox.Text = "";
                }
                else
                {

                    String type;
                    FileStream F = new FileStream("d:\\custID.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    ++x;
                    F.WriteByte((byte)x);
                    F.Close();

                    try
                    {

                        string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                        //This is my insert query in which i am taking input from the user through windows forms  
                        string Query = "insert into customer values('" + customerNameTextBox.Text + "'," + customerIdTextBox.Text + "," + "'silver'," + "0" + "); ";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        //This is command class which will handle the query and connection object.  
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("New Customer Added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }




                    FileStream F1 = new FileStream("d:\\billno.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    ++y;
                    F1.WriteByte((byte)y);
                    F1.Close();

                    try
                    {
                        //This is my connection string i have assigned the database file address path  
                        string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                        //This is my update query in which i am taking input from the user through windows forms and update the record.  
                        string Query = "update customer set total_purchases=total_purchases+" + total + " where customer_id=" + customerIdTextBox.Text + ";";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Updated");
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
                        //This is my insert query in which i am taking input from the user through windows forms  
                        string Query = "insert into bill values(" + displayBillNumberLabel.Text + "," + customerIdTextBox.Text + "," + total + ",'" + dateTextBox.Text + "'," + oid + ");";
                        //customerIdTextBox.Text = Query;

                        //This is  MySqlConnection here i have created the object and pass my connection string.  
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        //This is command class which will handle the query and connection object.  
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Bill Recorded");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        //This is my connection string i have assigned the database file address path  
                        string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                        //This is my update query in which i am taking input from the user through windows forms and update the record.  
                        string Query = "call custo_status_update(" + customerIdTextBox.Text + ");";
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

                    LoginScreen form = new LoginScreen();
                    form.Tag = this;
                    form.Show(this);
                    Hide();
                }
            }
            


        }

        private void getNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //Display query  
                string Query = "select name from customer where customer_id='" + customerIdTextBox.Text + "';";
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
                    name = row["name"].ToString();

                }

                if(Int32.Parse(customerIdTextBox.Text)<x)
                {
                    customerNameTextBox.Text = name;
                }
                else
                {
                    customerNameTextBox.Text = "";
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginScreen form = new LoginScreen();
            form.Tag = this;
            form.Show(this);
            Hide();

        }

        private void newRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FileStream F = new FileStream("d:\\custID.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            customerIdTextBox.Text = "" + F.ReadByte();
            F.Position = 0;
            x = Int32.Parse("" + F.ReadByte());
            F.Close();
            customerIdTextBox.Text = "" + x.ToString();
            customerIdTextBox.Enabled = false;
            getNameButton.Enabled = false;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into sold values("+quantityTextBox.Text+", "+displayBillNumberLabel.Text+", "+articleIdTextBox.Text+");";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
               
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //Display query  
                string Query = "select name from stock where article_id='" + articleIdTextBox.Text + "';";
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
                    a_name = row["name"].ToString();
                }

                MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //Display query  
                Query = "select mrp from stock where article_id='" + articleIdTextBox.Text + "';";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                
                MyAdapter.SelectCommand = MyCommand3;
                DataTable dTable1 = new DataTable();
                MyAdapter.Fill(dTable1);
                foreach (DataRow row in dTable1.Rows)
                {
                    a_mrp = row["mrp"].ToString();
                }


                DataRow r1 = dt.NewRow();
                r1["Article ID"] = articleIdTextBox.Text;
                r1["Name"] = a_name;
                r1["Quantity"] = quantityTextBox.Text;
                r1["Unit Price"] = a_mrp;
                r1["Total Price"] = (Int32.Parse(a_mrp)) * (Int32.Parse(quantityTextBox.Text));
                total += (Int32.Parse(a_mrp)) * (Int32.Parse(quantityTextBox.Text));
                dt.Rows.Add(r1);
                dataGridView1.DataSource = dt;
                totalDisplayLabel.Text = "Rs."+total;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update stock set quantity=quantity-" + quantityTextBox.Text+ " where article_id='"+articleIdTextBox.Text+"';";
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

        }

        private void existingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customerIdTextBox.Text = "";
            customerIdTextBox.Enabled = true;
            getNameButton.Enabled = true;
        }
    }
}

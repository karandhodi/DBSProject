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
    public partial class LoginScreen : Form
    {
        string password;
        string outletid;





        public LoginScreen()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //Display query  
                string Query = "select a_password from admins where a_username='" + usernameTextBox.Text + "';";
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
                    password = row["a_password"].ToString();

                }

                //usernameTextBox.Text = password;
                if (password.Equals(passwordTextBox.Text))
                {
                    AdminHome form2 = new AdminHome(usernameTextBox.Text, passwordTextBox.Text);
                    form2.Tag = this;
                    form2.Show(this);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username/Password !");
                }


                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Username/Password !");
            }

        }

        private void CashierLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnection2 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //Display query  
                string Query = "select c_password from cashier where c_username='" + usernameTextBox.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);



                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  

                string MyConnection3 = "server=localhost;user id=root;password=greenery;persistsecurityinfo=True;database=user";
                //Display query  
                string Query1 = "select outlet_id from cashier where c_username='" + usernameTextBox.Text + "';";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                MySqlCommand MyCommand3 = new MySqlCommand(Query1, MyConn3);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter1 = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand3;
                DataTable dTable1 = new DataTable();



                MyAdapter.Fill(dTable1);

                foreach (DataRow row in dTable1.Rows)
                {
                    outletid = row["outlet_id"].ToString();

                }
                foreach (DataRow row in dTable.Rows)
                {
                    password = row["c_password"].ToString();

                }

                //usernameTextBox.Text = password;
                if (password.Equals(passwordTextBox.Text))
                {
                    CashierHome form2 = new CashierHome(outletid);
                    form2.Tag = this;
                    form2.Show(this);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username/Password !");
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Username/Password !");
            }

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }




        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}

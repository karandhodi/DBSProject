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
    public partial class AdminHome : Form
    {

        string adminusername;
        string adminpassword;

        public AdminHome(string auser, string apass)
        {
            InitializeComponent();
            adminusername = auser;
            adminpassword = apass;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            AddAdmin form = new AddAdmin(adminusername, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void deleteAdminButton_Click(object sender, EventArgs e)
        {
            DeleteAdmin form = new DeleteAdmin(adminusername, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void addCashierButton_Click(object sender, EventArgs e)
        {
            AddCashier form = new AddCashier(adminusername, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void deleteCashierButton_Click(object sender, EventArgs e)
        {
            DeleteCashier form = new DeleteCashier(adminusername, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            AddSupplier form = new AddSupplier(adminusername, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();

        }

        private void deleteSupplierButton_Click(object sender, EventArgs e)
        {
            DeleteSupplier form = new DeleteSupplier(adminusername, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void postOrderButton_Click(object sender, EventArgs e)
        {
            PostOrder f = new PostOrder(adminusername, adminpassword);
            f.Tag = this;
            f.Show(this);
            Hide();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddItem form = new AddItem(adminpassword, adminpassword);
            form.Tag = this;
            form.Show(this);
            Hide();

        }

        private void stockButton_Click(object sender, EventArgs e)
        {

        }

        private void allDataButton_Click(object sender, EventArgs e)
        {
            AllData o1 = new AllData(adminusername, adminpassword);
            o1.Tag = this;
            o1.Show(this);
            Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginScreen form = new LoginScreen();
            form.Tag = this;
            form.Show(this);
            Hide();
        }
    }
}

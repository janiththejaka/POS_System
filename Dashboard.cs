using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS_System
{
    public partial class Dashboard : Form
    {
        private int currentUserID;
        private string currentUsername;
        private string currentRole;
        public Dashboard(int userID, string username, string role)
        {
            InitializeComponent();

            currentUserID = userID;
            currentUsername = username;
            currentRole = role;

            // Show user info with a line break
            lblWelcome.Text = $"Welcome, {currentUsername}\n({currentRole})";

            // Role-based UI:
            if (currentRole == "Cashier")
            {
                btnManageUsers.Enabled = false;   // Cashier can't manage users

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewSaleForm saleForm = new NewSaleForm(currentUserID, currentUsername, currentRole);
            saleForm.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productForm = new ProductsForm(currentUserID, currentRole);
            productForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm salesReportForm = new SalesReportForm(currentUserID, currentRole);
            salesReportForm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.ShowDialog();
        }
    }
}

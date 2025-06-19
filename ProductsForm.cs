using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_System
{
    public partial class ProductsForm : Form
    {
        private int currentUserID;
        private string currentUserRole;
        private int selectedProductID = 0;
        public ProductsForm(int userID, string userRole)
        {
            InitializeComponent();
            currentUserID = userID;
            currentUserRole = userRole;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();

            // Permission: Allow CRUD only for Admin
            bool isAdmin = currentUserRole == "Admin";
            btnAddProduct.Enabled = isAdmin;
            btnUpdateProduct.Enabled = isAdmin;
            btnDeleteProduct.Enabled = isAdmin;
        }
        private void LoadProducts()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["POSConnectionString"].ConnectionString);

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ProductID, ProductName, UnitPrice, QuantityInStock FROM Products", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                selectedProductID = Convert.ToInt32(row.Cells["ProductID"].Value);
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                nudUnitPrice.Value = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                nudQuantity.Value = Convert.ToInt32(row.Cells["QuantityInStock"].Value);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product name is required.");
                return;
            }

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["POSConnectionString"].ConnectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Products (ProductName, UnitPrice, QuantityInStock) VALUES (@name, @price, @qty)", conn);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@price", nudAddPrice.Value);
                cmd.Parameters.AddWithValue("@qty", nudAddQuantity.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully.");
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (selectedProductID == 0)
            {
                MessageBox.Show("Please select a product from the table to update.");
                return;
            }

            string newName = txtProductName.Text.Trim();
            decimal newPrice = nudUnitPrice.Value;
            int newQty = (int)nudQuantity.Value;
            int productID = 0;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["POSConnectionString"].ConnectionString))
            {
                string sql = "UPDATE Products SET ProductName=@name, UnitPrice=@price, QuantityInStock=@qty WHERE ProductID=@id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@price", newPrice);
                    cmd.Parameters.AddWithValue("@qty", newQty);
                    cmd.Parameters.AddWithValue("@id", productID);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Product updated successfully!");
                        LoadProducts(); // refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (selectedProductID == -1)
            {
                MessageBox.Show("Select a product to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["POSConnectionString"].ConnectionString);

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", selectedProductID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully.");
                    LoadProducts();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void ClearFields()
        {
            selectedProductID = -1;
            txtProductName.Text = "";
            nudUnitPrice.Value = 0;
            nudQuantity.Value = 0;
        }

    }
}

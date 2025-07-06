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
    public partial class NewSaleForm : Form
    {
        int currentUserID;
        string currentUsername;
        string currentRole;
        DataTable saleItemsTable = new DataTable();

        public NewSaleForm(int userID, string userName, string userRole)
        {
            InitializeComponent();
            currentUserID = userID;
        }

        private void NewSaleForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["POSConnectionString"].ConnectionString);

            try
            {
                conn.Open();
                string sql = "SELECT ProductID, ProductName, UnitPrice FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                cmbProduct.DataSource = ds.Tables[0];
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Setup sale items DataTable
            saleItemsTable.Columns.Add("ProductID", typeof(int));
            saleItemsTable.Columns.Add("ProductName", typeof(string));
            saleItemsTable.Columns.Add("UnitPrice", typeof(decimal));
            saleItemsTable.Columns.Add("Quantity", typeof(int));
            saleItemsTable.Columns.Add("LineTotal", typeof(decimal));

            dgvSaleItems.DataSource = saleItemsTable;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex >= 0)
            {
                DataRowView drv = (DataRowView)cmbProduct.SelectedItem;
                txtUnitPrice.Text = drv["UnitPrice"].ToString();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem == null)
                return;

            DataRowView drv = (DataRowView)cmbProduct.SelectedItem;

            int productID = Convert.ToInt32(drv["ProductID"]);
            string productName = drv["ProductName"].ToString();
            decimal unitPrice = Convert.ToDecimal(drv["UnitPrice"]);
            int qty = (int)nudQuantity.Value;
            decimal lineTotal = unitPrice * qty;

            saleItemsTable.Rows.Add(productID, productName, unitPrice, qty, lineTotal);

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in saleItemsTable.Rows)
            {
                total += (decimal)row["LineTotal"];
            }
            lblTotal.Text = $"Total: Rs. {total:F2}";
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            if (saleItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Add items before saving!");
                return;
            }

            decimal total = ParseTotal();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["POSConnectionString"].ConnectionString);

            try
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();

                // 1️⃣ Insert the Sale
                SqlCommand cmdSale = new SqlCommand(
                    "INSERT INTO Sales (UserID, SaleDate, Total) OUTPUT INSERTED.SaleID VALUES (@uid, GETDATE(), @total)",
                    conn, tx
                );
                cmdSale.Parameters.AddWithValue("@uid", currentUserID);
                cmdSale.Parameters.AddWithValue("@total", total);

                int saleID = (int)cmdSale.ExecuteScalar();

                // 2️⃣ Insert each SaleDetail and update stock
                foreach (DataRow row in saleItemsTable.Rows)
                {
                    int productID = (int)row["ProductID"];
                    int qty = (int)row["Quantity"];
                    decimal unitPrice = (decimal)row["UnitPrice"];

                    // Insert SaleDetail
                    SqlCommand cmdItem = new SqlCommand(
                        "INSERT INTO SaleDetails (SaleID, ProductID, Quantity, UnitPrice) VALUES (@sid, @pid, @qty, @unitPrice)",
                        conn, tx
                    );
                    cmdItem.Parameters.AddWithValue("@sid", saleID);
                    cmdItem.Parameters.AddWithValue("@pid", productID);
                    cmdItem.Parameters.AddWithValue("@qty", qty);
                    cmdItem.Parameters.AddWithValue("@unitPrice", unitPrice);
                    cmdItem.ExecuteNonQuery();

                    // ✅ NEW: Update Products stock
                    SqlCommand cmdUpdateStock = new SqlCommand(
                        "UPDATE Products SET QuantityInStock = QuantityInStock - @qty WHERE ProductID = @pid",
                        conn, tx
                    );
                    cmdUpdateStock.Parameters.AddWithValue("@qty", qty);
                    cmdUpdateStock.Parameters.AddWithValue("@pid", productID);
                    cmdUpdateStock.ExecuteNonQuery();
                }

                tx.Commit();
                MessageBox.Show("Sale saved and stock updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private decimal ParseTotal()
        {
            string raw = lblTotal.Text;

            raw = raw.Replace("Total:", "").Replace("Rs.", "").Replace("Rs", "").Replace("$", "").Trim();

            // Parse safely
            return decimal.TryParse(raw, out decimal total) ? total : 0;
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvSaleItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvSaleItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSaleItems.SelectedRows)
                {
                    dgvSaleItems.Rows.RemoveAt(row.Index);
                }
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }
        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(currentUserID, currentUsername, currentRole); // adjust role if needed
            dash.Show();
            this.Close();
        }

        private void btnRemoveItem_Click_1(object sender, EventArgs e)
        {
            // Remove the last item from the DataGridView/DataTable
            if (saleItemsTable.Rows.Count > 0)
            {
                saleItemsTable.Rows.RemoveAt(saleItemsTable.Rows.Count - 1);
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("No items to remove.");
            }
        }
    }
}

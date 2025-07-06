using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace POS_System
{
    public partial class SalesReportForm : Form
        
    {
        int currentUserID;
        string currentUsername;
        string currentRole;

        public SalesReportForm(int userID, string userRole)
        {
            InitializeComponent();
            currentUserID = userID;


        
            
    }

    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public class SalesData
        {
            public string SaleDay { get; set; }
            public decimal Total { get; set; }
        }


        private List<SalesData> GetSalesData()
        {
            var list = new List<SalesData>();

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["POSConnectionString"].ConnectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                    CONVERT(varchar(10), SaleDate, 120) AS SaleDay,
                    SUM(Total) AS Total
                    FROM Sales
                    WHERE SaleDate BETWEEN @from AND @to
                    GROUP BY CONVERT(varchar(10), SaleDate, 120)
                    ORDER BY SaleDay
                ";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new SalesData
                            {
                                SaleDay = reader.GetString(0),
                                Total = reader.GetDecimal(1)
                            });
                        }
                    }
                }

            }

            return list;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["POSConnectionString"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT s.SaleID, s.SaleDate, u.Username, s.Total
                      FROM Sales s
                      JOIN Users u ON s.UserID = u.UserID
                      WHERE s.SaleDate BETWEEN @from AND @to
                      ORDER BY s.SaleDate", conn);

                cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvSales.DataSource = dt;
            }

            // report viewer

            var salesData = GetSalesData();

            var reportViewer = new ReportViewer
            {
                Dock = DockStyle.Bottom,
                ProcessingMode = ProcessingMode.Local,
                Height = 300 // adjust as needed
            };
            this.Controls.Add(reportViewer);

            reportViewer.LocalReport.ReportPath = @"C:\Users\USER\Desktop\POS_System\POS_System\SalesReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", salesData));
            reportViewer.RefreshReport();
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int saleID = Convert.ToInt32(dgvSales.Rows[e.RowIndex].Cells["SaleID"].Value);

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["POSConnectionString"].ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"SELECT p.ProductName, sd.Quantity, sd.UnitPrice, (sd.Quantity * sd.UnitPrice) AS LineTotal
                          FROM SaleDetails sd
                          JOIN Products p ON sd.ProductID = p.ProductID
                          WHERE sd.SaleID = @sid", conn);

                    cmd.Parameters.AddWithValue("@sid", saleID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSaleDetails.DataSource = dt;
                }
            }

        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvSales.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = $"SalesReport_{DateTime.Now:yyyyMMddHHmmss}.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToPDF(dgvSales, sfd.FileName);
                MessageBox.Show("Report exported successfully as PDF!");
            }

        }
        private void ExportDataGridViewToPDF(DataGridView dgv, string fileName)
        {
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            pdfTable.WidthPercentage = 100;

            // Add headers
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                pdfTable.AddCell(cell);
            }

            // Add rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value?.ToString() ?? "");
                }
            }

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph($"Sales Report ({dtpFrom.Value.ToShortDateString()} to {dtpTo.Value.ToShortDateString()})"));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {

        }
        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Dashboard dash = new Dashboard(currentUserID, currentUsername, currentRole); 
            dash.Show();
           
        }
    }
}

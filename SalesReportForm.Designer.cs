namespace POS_System
{
    partial class SalesReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dgvSales = new DataGridView();
            dgvSaleDetails = new DataGridView();
            btnExportPDF = new Button();
            btnBackToDashboard = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(543, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 38);
            label1.TabIndex = 0;
            label1.Text = "Sales Report";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(dtpTo);
            groupBox1.Controls.Add(dtpFrom);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(49, 102);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1121, 109);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select the Date";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.CornflowerBlue;
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(873, 44);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(228, 43);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "View Report";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(490, 49);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(343, 34);
            dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(79, 49);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(343, 34);
            dtpFrom.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 49);
            label3.Name = "label3";
            label3.Size = new Size(44, 28);
            label3.TabIndex = 1;
            label3.Text = "To :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 49);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 0;
            label2.Text = "From :";
            label2.Click += label2_Click;
            // 
            // dgvSales
            // 
            dgvSales.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(49, 237);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.Size = new Size(537, 301);
            dgvSales.TabIndex = 2;
            dgvSales.CellContentClick += dgvSales_CellContentClick;
            // 
            // dgvSaleDetails
            // 
            dgvSaleDetails.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleDetails.Location = new Point(608, 237);
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.Size = new Size(562, 301);
            dgvSaleDetails.TabIndex = 3;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.Crimson;
            btnExportPDF.ForeColor = SystemColors.ButtonHighlight;
            btnExportPDF.Location = new Point(942, 566);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(228, 43);
            btnExportPDF.TabIndex = 5;
            btnExportPDF.Text = "Export as a PDF";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.BackColor = Color.BlueViolet;
            btnBackToDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnBackToDashboard.Location = new Point(46, 568);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(134, 42);
            btnBackToDashboard.TabIndex = 10;
            btnBackToDashboard.Text = "Back to Home";
            btnBackToDashboard.UseVisualStyleBackColor = false;
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 652);
            Controls.Add(btnBackToDashboard);
            Controls.Add(btnExportPDF);
            Controls.Add(dgvSaleDetails);
            Controls.Add(dgvSales);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SalesReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesReportForm";
            Load += SalesReportForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Button btnLoad;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private DataGridView dgvSales;
        private DataGridView dgvSaleDetails;
        private Button btnExportPDF;
        private Button btnBackToDashboard;
    }
}
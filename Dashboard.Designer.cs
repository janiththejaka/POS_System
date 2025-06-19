namespace POS_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            lblWelcome = new Label();
            btnNewSale = new Button();
            btnManageProducts = new Button();
            btnLogout = new Button();
            btnSalesReport = new Button();
            btnManageUsers = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(265, 77);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(23, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = ".";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.Click += label1_Click;
            // 
            // btnNewSale
            // 
            btnNewSale.BackgroundImage = (Image)resources.GetObject("btnNewSale.BackgroundImage");
            btnNewSale.BackgroundImageLayout = ImageLayout.Stretch;
            btnNewSale.FlatAppearance.BorderColor = Color.Black;
            btnNewSale.FlatAppearance.BorderSize = 3;
            btnNewSale.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnNewSale.FlatStyle = FlatStyle.Popup;
            btnNewSale.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewSale.ForeColor = Color.Transparent;
            btnNewSale.Location = new Point(61, 189);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(440, 100);
            btnNewSale.TabIndex = 1;
            btnNewSale.Text = "+ New Bill";
            btnNewSale.UseVisualStyleBackColor = true;
            btnNewSale.Click += button1_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.BackgroundImage = (Image)resources.GetObject("btnManageProducts.BackgroundImage");
            btnManageProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageProducts.ForeColor = Color.Transparent;
            btnManageProducts.Location = new Point(61, 366);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(135, 65);
            btnManageProducts.TabIndex = 2;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = true;
            btnManageProducts.Click += btnManageProducts_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Location = new Point(215, 498);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(144, 53);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.BackgroundImage = (Image)resources.GetObject("btnSalesReport.BackgroundImage");
            btnSalesReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesReport.ForeColor = Color.Transparent;
            btnSalesReport.Location = new Point(215, 366);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(135, 65);
            btnSalesReport.TabIndex = 6;
            btnSalesReport.Text = "Sales Report";
            btnSalesReport.UseVisualStyleBackColor = true;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackgroundImage = (Image)resources.GetObject("btnManageUsers.BackgroundImage");
            btnManageUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageUsers.ForeColor = Color.Transparent;
            btnManageUsers.Location = new Point(366, 366);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(135, 65);
            btnManageUsers.TabIndex = 7;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnManageUsers);
            groupBox1.Controls.Add(btnSalesReport);
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(btnManageProducts);
            groupBox1.Controls.Add(btnNewSale);
            groupBox1.Controls.Add(lblWelcome);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(309, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 599);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 62);
            label1.Name = "label1";
            label1.Size = new Size(0, 53);
            label1.TabIndex = 8;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1155, 678);
            Controls.Add(groupBox1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Button btnNewSale;
        private Button btnManageProducts;
        private Button btnLogout;
        private Button btnSalesReport;
        private Button btnManageUsers;
        private GroupBox groupBox1;
        private Label label1;
    }
}
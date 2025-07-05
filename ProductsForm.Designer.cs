namespace POS_System
{
    partial class ProductsForm
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
            dgvProducts = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            label3 = new Label();
            label2 = new Label();
            nudQuantity = new NumericUpDown();
            nudUnitPrice = new NumericUpDown();
            groupBox2 = new GroupBox();
            txtProductName = new TextBox();
            btnAddProduct = new Button();
            label4 = new Label();
            label5 = new Label();
            nudAddQuantity = new NumericUpDown();
            nudAddPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddPrice).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(26, 101);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(753, 563);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(541, 35);
            label1.Name = "label1";
            label1.Size = new Size(238, 38);
            label1.TabIndex = 1;
            label1.Text = "Product Manager";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnDeleteProduct);
            groupBox1.Controls.Add(btnUpdateProduct);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nudQuantity);
            groupBox1.Controls.Add(nudUnitPrice);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(798, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 271);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select and Update Products";
            groupBox1.UseWaitCursor = true;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.Firebrick;
            btnDeleteProduct.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteProduct.Location = new Point(19, 196);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(353, 39);
            btnDeleteProduct.TabIndex = 5;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.UseWaitCursor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.Green;
            btnUpdateProduct.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateProduct.Location = new Point(19, 142);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(353, 39);
            btnUpdateProduct.TabIndex = 4;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.UseWaitCursor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 55);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 3;
            label3.Text = "Quantity";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 55);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 2;
            label2.Text = "Unit Price :";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(212, 86);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(160, 34);
            nudQuantity.TabIndex = 1;
            nudQuantity.UseWaitCursor = true;
            nudQuantity.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // nudUnitPrice
            // 
            nudUnitPrice.Location = new Point(19, 86);
            nudUnitPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudUnitPrice.Name = "nudUnitPrice";
            nudUnitPrice.Size = new Size(160, 34);
            nudUnitPrice.TabIndex = 0;
            nudUnitPrice.UseWaitCursor = true;
            nudUnitPrice.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(btnAddProduct);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(nudAddQuantity);
            groupBox2.Controls.Add(nudAddPrice);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(798, 393);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 271);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add New Product";
            groupBox2.UseWaitCursor = true;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.ForeColor = SystemColors.ScrollBar;
            txtProductName.Location = new Point(19, 57);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(353, 34);
            txtProductName.TabIndex = 5;
            txtProductName.Text = "Enter the Product Name";
            txtProductName.UseWaitCursor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Green;
            btnAddProduct.ForeColor = SystemColors.ButtonHighlight;
            btnAddProduct.Location = new Point(13, 197);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(359, 39);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.UseWaitCursor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 114);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 114);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 2;
            label5.Text = "Unit Price :";
            label5.UseWaitCursor = true;
            // 
            // nudAddQuantity
            // 
            nudAddQuantity.Location = new Point(212, 145);
            nudAddQuantity.Name = "nudAddQuantity";
            nudAddQuantity.Size = new Size(160, 34);
            nudAddQuantity.TabIndex = 1;
            nudAddQuantity.UseWaitCursor = true;
            // 
            // nudAddPrice
            // 
            nudAddPrice.Location = new Point(19, 145);
            nudAddPrice.Name = "nudAddPrice";
            nudAddPrice.Size = new Size(160, 34);
            nudAddPrice.TabIndex = 0;
            nudAddPrice.UseWaitCursor = true;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 689);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudUnitPrice;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnAddProduct;
        private Label label4;
        private Label label5;
        private NumericUpDown nudAddQuantity;
        private NumericUpDown nudAddPrice;
        private TextBox txtProductName;
    }
}
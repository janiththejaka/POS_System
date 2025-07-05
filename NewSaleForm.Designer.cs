namespace POS_System
{
    partial class NewSaleForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cmbProduct = new ComboBox();
            label1 = new Label();
            txtUnitPrice = new TextBox();
            nudQuantity = new NumericUpDown();
            btnAddItem = new Button();
            dgvSaleItems = new DataGridView();
            lblTotal = new Label();
            btnSaveSale = new Button();
            btnRemoveItem = new Button();
            btnBackToDashboard = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleItems).BeginInit();
            SuspendLayout();
            // 
            // cmbProduct
            // 
            cmbProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProduct.ForeColor = Color.Gray;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(44, 42);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(354, 36);
            cmbProduct.TabIndex = 0;
            cmbProduct.Text = "Select Item";
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(444, 42);
            label1.Name = "label1";
            label1.Size = new Size(126, 31);
            label1.TabIndex = 1;
            label1.Text = " Unit Price:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.ButtonHighlight;
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(576, 43);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(221, 34);
            txtUnitPrice.TabIndex = 2;
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantity.Location = new Point(44, 87);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(154, 34);
            nudQuantity.TabIndex = 3;
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.MediumPurple;
            btnAddItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = SystemColors.ButtonHighlight;
            btnAddItem.Location = new Point(222, 85);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(178, 43);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add Items";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvSaleItems
            // 
            dgvSaleItems.AllowUserToOrderColumns = true;
            dgvSaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleItems.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSaleItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSaleItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSaleItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleItems.GridColor = SystemColors.Desktop;
            dgvSaleItems.Location = new Point(44, 157);
            dgvSaleItems.Name = "dgvSaleItems";
            dgvSaleItems.RowHeadersWidth = 51;
            dgvSaleItems.Size = new Size(1066, 261);
            dgvSaleItems.TabIndex = 5;
            dgvSaleItems.CellContentClick += dgvSaleItems_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(874, 439);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 38);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // btnSaveSale
            // 
            btnSaveSale.BackColor = Color.MediumSeaGreen;
            btnSaveSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveSale.ForeColor = SystemColors.ButtonHighlight;
            btnSaveSale.Location = new Point(875, 489);
            btnSaveSale.Name = "btnSaveSale";
            btnSaveSale.Size = new Size(239, 59);
            btnSaveSale.TabIndex = 7;
            btnSaveSale.Text = "Proceed to Checkout";
            btnSaveSale.UseVisualStyleBackColor = false;
            btnSaveSale.Click += btnSaveSale_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.Firebrick;
            btnRemoveItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveItem.ForeColor = SystemColors.ButtonHighlight;
            btnRemoveItem.Location = new Point(41, 420);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(137, 36);
            btnRemoveItem.TabIndex = 8;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click_1;
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.BackColor = Color.BlueViolet;
            btnBackToDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnBackToDashboard.Location = new Point(42, 506);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(134, 42);
            btnBackToDashboard.TabIndex = 9;
            btnBackToDashboard.Text = "Back to Home";
            btnBackToDashboard.UseVisualStyleBackColor = false;
            // 
            // NewSaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1170, 563);
            Controls.Add(btnBackToDashboard);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnSaveSale);
            Controls.Add(lblTotal);
            Controls.Add(dgvSaleItems);
            Controls.Add(btnAddItem);
            Controls.Add(nudQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(label1);
            Controls.Add(cmbProduct);
            Name = "NewSaleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewSaleForm";
            Load += NewSaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProduct;
        private Label label1;
        private TextBox txtUnitPrice;
        private NumericUpDown nudQuantity;
        private Button btnAddItem;
        private DataGridView dgvSaleItems;
        private Label lblTotal;
        private Button btnSaveSale;
        private Button btnRemoveItem;
        private Button btnBackToDashboard;
    }
}
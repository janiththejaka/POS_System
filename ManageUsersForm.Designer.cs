namespace POS_System
{
    partial class ManageUsersForm
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
            label2 = new Label();
            dgvUsers = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnAddUser = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(518, 30);
            label1.Name = "label1";
            label1.Size = new Size(200, 38);
            label1.TabIndex = 0;
            label1.Text = "User Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 120);
            label2.Name = "label2";
            label2.Size = new Size(227, 28);
            label2.TabIndex = 1;
            label2.Text = "System's User Accounts";
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(55, 160);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(586, 380);
            dgvUsers.TabIndex = 2;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(726, 161);
            label3.Name = "label3";
            label3.Size = new Size(193, 28);
            label3.TabIndex = 3;
            label3.Text = "Add User to System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(726, 218);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 4;
            label4.Text = "Enter User Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(726, 272);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 5;
            label5.Text = "Enter Password :";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(896, 218);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(259, 27);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(896, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 27);
            txtPassword.TabIndex = 7;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.LimeGreen;
            btnAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.ButtonHighlight;
            btnAddUser.Location = new Point(729, 331);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(431, 41);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "+ Add user";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(732, 499);
            button2.Name = "button2";
            button2.Size = new Size(425, 41);
            button2.TabIndex = 9;
            button2.Text = "Delete Selected User";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 624);
            Controls.Add(button2);
            Controls.Add(btnAddUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvUsers);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageUsersForm";
            Text = "ManageUsersForm";
            Load += ManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvUsers;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnAddUser;
        private Button button2;
    }
}
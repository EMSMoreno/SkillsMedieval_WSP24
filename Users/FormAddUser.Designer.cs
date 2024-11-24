namespace WSN24_EduardoMoreno_M3.Users
{
    partial class FormAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dtpRegistrationDate = new DateTimePicker();
            btnCleanFormSearch = new Button();
            btnSearchUsers = new Button();
            txtSearchUser = new TextBox();
            lblSearchOrganizer = new Label();
            dataGridSearchUsers = new DataGridView();
            btnCleanForm = new Button();
            lblRegistrationDate = new Label();
            btnAddUser = new Button();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblRole = new Label();
            txtRole = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchUsers).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1499, 105);
            panel2.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(124, 34);
            label1.Name = "label1";
            label1.Size = new Size(239, 38);
            label1.TabIndex = 21;
            label1.Text = "EraMedieval4all";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(81, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 767);
            panel1.Name = "panel1";
            panel1.Size = new Size(1499, 105);
            panel1.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1384, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(353, 41);
            label2.Name = "label2";
            label2.Size = new Size(723, 28);
            label2.TabIndex = 0;
            label2.Text = "@2024 WorldSkills Portugal Nacional Exam - Portugal, November, 2024";
            // 
            // dtpRegistrationDate
            // 
            dtpRegistrationDate.Location = new Point(831, 214);
            dtpRegistrationDate.Name = "dtpRegistrationDate";
            dtpRegistrationDate.Size = new Size(344, 31);
            dtpRegistrationDate.TabIndex = 147;
            // 
            // btnCleanFormSearch
            // 
            btnCleanFormSearch.FlatAppearance.BorderColor = Color.Black;
            btnCleanFormSearch.FlatStyle = FlatStyle.Flat;
            btnCleanFormSearch.Location = new Point(1179, 457);
            btnCleanFormSearch.Name = "btnCleanFormSearch";
            btnCleanFormSearch.Size = new Size(230, 55);
            btnCleanFormSearch.TabIndex = 144;
            btnCleanFormSearch.Text = "Clean Search Form";
            btnCleanFormSearch.UseVisualStyleBackColor = true;
            btnCleanFormSearch.Click += btnCleanFormSearch_Click;
            // 
            // btnSearchUsers
            // 
            btnSearchUsers.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnSearchUsers.FlatStyle = FlatStyle.Flat;
            btnSearchUsers.Location = new Point(943, 457);
            btnSearchUsers.Name = "btnSearchUsers";
            btnSearchUsers.Size = new Size(230, 55);
            btnSearchUsers.TabIndex = 143;
            btnSearchUsers.Text = "Search User";
            btnSearchUsers.UseVisualStyleBackColor = true;
            btnSearchUsers.Click += btnSearchUsers_Click;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(83, 469);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(629, 31);
            txtSearchUser.TabIndex = 142;
            // 
            // lblSearchOrganizer
            // 
            lblSearchOrganizer.AutoSize = true;
            lblSearchOrganizer.Location = new Point(83, 441);
            lblSearchOrganizer.Name = "lblSearchOrganizer";
            lblSearchOrganizer.Size = new Size(324, 25);
            lblSearchOrganizer.TabIndex = 141;
            lblSearchOrganizer.Text = "Do your Search by the User Name here:";
            // 
            // dataGridSearchUsers
            // 
            dataGridSearchUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSearchUsers.Location = new Point(83, 518);
            dataGridSearchUsers.Name = "dataGridSearchUsers";
            dataGridSearchUsers.ReadOnly = true;
            dataGridSearchUsers.RowHeadersWidth = 62;
            dataGridSearchUsers.Size = new Size(1326, 203);
            dataGridSearchUsers.TabIndex = 140;
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Black;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(1082, 285);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(230, 55);
            btnCleanForm.TabIndex = 139;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // lblRegistrationDate
            // 
            lblRegistrationDate.AutoSize = true;
            lblRegistrationDate.Location = new Point(831, 186);
            lblRegistrationDate.Name = "lblRegistrationDate";
            lblRegistrationDate.Size = new Size(148, 25);
            lblRegistrationDate.TabIndex = 137;
            lblRegistrationDate.Text = "Registration Date";
            // 
            // btnAddUser
            // 
            btnAddUser.FlatAppearance.BorderColor = Color.Lime;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Location = new Point(846, 285);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(230, 55);
            btnAddUser.TabIndex = 136;
            btnAddUser.Text = "Confirm Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(79, 212);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(346, 31);
            txtFirstName.TabIndex = 148;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(81, 184);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 149;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(83, 257);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 151;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(81, 285);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(346, 31);
            txtLastName.TabIndex = 150;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(81, 328);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 153;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(79, 356);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(346, 31);
            txtAddress.TabIndex = 152;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(448, 186);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 155;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(446, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(346, 31);
            txtEmail.TabIndex = 154;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(448, 257);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(132, 25);
            lblPhoneNumber.TabIndex = 157;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(446, 285);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(346, 31);
            txtPhoneNumber.TabIndex = 156;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(450, 330);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 25);
            lblRole.TabIndex = 159;
            lblRole.Text = "Role";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(448, 358);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(217, 31);
            txtRole.TabIndex = 158;
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 869);
            Controls.Add(lblRole);
            Controls.Add(txtRole);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(dtpRegistrationDate);
            Controls.Add(btnCleanFormSearch);
            Controls.Add(btnSearchUsers);
            Controls.Add(txtSearchUser);
            Controls.Add(lblSearchOrganizer);
            Controls.Add(dataGridSearchUsers);
            Controls.Add(btnCleanForm);
            Controls.Add(lblRegistrationDate);
            Controls.Add(btnAddUser);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormAddUser";
            Text = "FormAddUser";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private DateTimePicker dtpRegistrationDate;
        private Button btnCleanFormSearch;
        private Button btnSearchUsers;
        private TextBox txtSearchUser;
        private Label lblSearchOrganizer;
        private DataGridView dataGridSearchUsers;
        private Button btnCleanForm;
        private Label lblRegistrationDate;
        private Button btnAddUser;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblRole;
        private TextBox txtRole;
    }
}
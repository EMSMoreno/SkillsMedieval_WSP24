namespace WinFormsApp1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnCleanFormCreate = new Button();
            btnClearFormLogin = new Button();
            btnCreateUser = new Button();
            btnLoginUser = new Button();
            txtPassword2 = new TextBox();
            txtFirstName = new TextBox();
            txtUsername = new TextBox();
            lbFirstName = new Label();
            lblLoginUser = new Label();
            lblPassword = new Label();
            lblPasswordNew = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 759);
            panel1.Name = "panel1";
            panel1.Size = new Size(1276, 105);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1182, 11);
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
            label2.Location = new Point(299, 40);
            label2.Name = "label2";
            label2.Size = new Size(723, 28);
            label2.TabIndex = 0;
            label2.Text = "@2024 WorldSkills Portugal Nacional Exam - Portugal, November, 2024";
            // 
            // btnCleanFormCreate
            // 
            btnCleanFormCreate.Location = new Point(84, 584);
            btnCleanFormCreate.Name = "btnCleanFormCreate";
            btnCleanFormCreate.Size = new Size(268, 57);
            btnCleanFormCreate.TabIndex = 7;
            btnCleanFormCreate.Text = "Clean Create User Form";
            btnCleanFormCreate.UseVisualStyleBackColor = true;
            btnCleanFormCreate.Click += btnCleanFormCreate_Click;
            // 
            // btnClearFormLogin
            // 
            btnClearFormLogin.Location = new Point(450, 419);
            btnClearFormLogin.Name = "btnClearFormLogin";
            btnClearFormLogin.Size = new Size(265, 57);
            btnClearFormLogin.TabIndex = 8;
            btnClearFormLogin.Text = "Clean Login Form";
            btnClearFormLogin.UseVisualStyleBackColor = true;
            btnClearFormLogin.Click += btnClearFormLogin_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(84, 647);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(268, 57);
            btnCreateUser.TabIndex = 9;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnLoginUser
            // 
            btnLoginUser.Location = new Point(450, 482);
            btnLoginUser.Name = "btnLoginUser";
            btnLoginUser.Size = new Size(265, 57);
            btnLoginUser.TabIndex = 10;
            btnLoginUser.Text = "Login";
            btnLoginUser.UseVisualStyleBackColor = true;
            btnLoginUser.Click += btnLogin_Click;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(87, 495);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.Size = new Size(265, 31);
            txtPassword2.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(84, 246);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(268, 31);
            txtFirstName.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(450, 246);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(265, 31);
            txtUsername.TabIndex = 14;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(84, 218);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(97, 25);
            lbFirstName.TabIndex = 15;
            lbFirstName.Text = "First Name";
            // 
            // lblLoginUser
            // 
            lblLoginUser.AutoSize = true;
            lblLoginUser.Location = new Point(450, 218);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(96, 25);
            lblLoginUser.TabIndex = 16;
            lblLoginUser.Text = "Login User";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(450, 306);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Password";
            // 
            // lblPasswordNew
            // 
            lblPasswordNew.AutoSize = true;
            lblPasswordNew.Location = new Point(84, 467);
            lblPasswordNew.Name = "lblPasswordNew";
            lblPasswordNew.Size = new Size(87, 25);
            lblPasswordNew.TabIndex = 18;
            lblPasswordNew.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1276, 105);
            panel2.TabIndex = 20;
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
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(84, 306);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 22;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(84, 334);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(268, 31);
            txtLastName.TabIndex = 21;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(84, 394);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(84, 422);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 31);
            txtEmail.TabIndex = 23;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(450, 334);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(268, 31);
            txtPassword.TabIndex = 25;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(770, 231);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 862);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(panel2);
            Controls.Add(lblPasswordNew);
            Controls.Add(lblPassword);
            Controls.Add(lblLoginUser);
            Controls.Add(lbFirstName);
            Controls.Add(txtUsername);
            Controls.Add(txtFirstName);
            Controls.Add(txtPassword2);
            Controls.Add(btnLoginUser);
            Controls.Add(btnCreateUser);
            Controls.Add(btnClearFormLogin);
            Controls.Add(btnCleanFormCreate);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnCleanFormCreate;
        private Button btnClearFormLogin;
        private Button btnCreateUser;
        private Button btnLoginUser;
        private TextBox txtPassword2;
        private TextBox txtFirstName;
        private TextBox txtUsername;
        private Label lbFirstName;
        private Label lblLoginUser;
        private Label lblPassword;
        private Label lblPasswordNew;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
    }
}
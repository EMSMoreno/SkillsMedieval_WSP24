namespace WSN24_EduardoMoreno_M3
{
    partial class FormRecoverAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecoverAccount));
            btnSubmit = new Button();
            label1 = new Label();
            txtPIN = new TextBox();
            lblPIN = new Label();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.FlatAppearance.BorderColor = Color.Black;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Location = new Point(66, 486);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.RightToLeft = RightToLeft.Yes;
            btnSubmit.Size = new Size(269, 46);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit New Password";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 71);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 1;
            label1.Text = "Reset Password";
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(66, 207);
            txtPIN.Name = "txtPIN";
            txtPIN.ReadOnly = true;
            txtPIN.Size = new Size(269, 31);
            txtPIN.TabIndex = 2;
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.Location = new Point(66, 179);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(113, 25);
            lblPIN.TabIndex = 3;
            lblPIN.Text = "Random PIN";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(66, 373);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(127, 25);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(66, 401);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(269, 31);
            txtNewPassword.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 626);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 103);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(842, 14);
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
            label2.Location = new Point(46, 42);
            label2.Name = "label2";
            label2.Size = new Size(723, 28);
            label2.TabIndex = 0;
            label2.Text = "@2024 WorldSkills Portugal Nacional Exam - Portugal, November, 2024";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(66, 277);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(94, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Your Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(66, 305);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 31);
            txtEmail.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(495, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 518);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormRecoverAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 726);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblPIN);
            Controls.Add(txtPIN);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Name = "FormRecoverAccount";
            Text = "FormRecoverAccount";
            Load += FormRecoverAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label label1;
        private TextBox txtPIN;
        private Label lblPIN;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label lblEmail;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
    }
}
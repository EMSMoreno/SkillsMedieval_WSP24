namespace WSN24_EduardoMoreno_M3.Cliente
{
    partial class FormEditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditClient));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dataGridEditClients = new DataGridView();
            btnEditClient = new Button();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtTaxPayer = new TextBox();
            lblTaxPayerNumber = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtState = new TextBox();
            lblState = new Label();
            lblRegistrationDate = new Label();
            btnCleanForm = new Button();
            dtpRegistrationDate = new DateTimePicker();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEditClients).BeginInit();
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
            panel2.TabIndex = 22;
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
            panel1.Location = new Point(1, 767);
            panel1.Name = "panel1";
            panel1.Size = new Size(1490, 105);
            panel1.TabIndex = 23;
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
            // dataGridEditClients
            // 
            dataGridEditClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEditClients.Location = new Point(84, 436);
            dataGridEditClients.Name = "dataGridEditClients";
            dataGridEditClients.ReadOnly = true;
            dataGridEditClients.RowHeadersWidth = 62;
            dataGridEditClients.Size = new Size(1326, 313);
            dataGridEditClients.TabIndex = 24;
            dataGridEditClients.CellClick += dataGridViewClients_CellClick;
            // 
            // btnEditClient
            // 
            btnEditClient.FlatAppearance.BorderColor = Color.Yellow;
            btnEditClient.FlatStyle = FlatStyle.Flat;
            btnEditClient.Location = new Point(1180, 375);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(230, 55);
            btnEditClient.TabIndex = 25;
            btnEditClient.Text = "Confirm Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(84, 183);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 26;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(84, 211);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(279, 31);
            txtFirstName.TabIndex = 27;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(84, 283);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(279, 31);
            txtLastName.TabIndex = 29;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(84, 255);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 28;
            lblLastName.Text = "Last Name";
            // 
            // txtTaxPayer
            // 
            txtTaxPayer.Location = new Point(84, 375);
            txtTaxPayer.Name = "txtTaxPayer";
            txtTaxPayer.Size = new Size(279, 31);
            txtTaxPayer.TabIndex = 31;
            // 
            // lblTaxPayerNumber
            // 
            lblTaxPayerNumber.AutoSize = true;
            lblTaxPayerNumber.Location = new Point(84, 347);
            lblTaxPayerNumber.Name = "lblTaxPayerNumber";
            lblTaxPayerNumber.Size = new Size(153, 25);
            lblTaxPayerNumber.TabIndex = 30;
            lblTaxPayerNumber.Text = "Tax Payer Number";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(434, 211);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(627, 31);
            txtAddress.TabIndex = 33;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(434, 183);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 32;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(434, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 31);
            txtEmail.TabIndex = 35;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(434, 255);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(434, 375);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(279, 31);
            txtPhoneNumber.TabIndex = 37;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(434, 347);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(132, 25);
            lblPhoneNumber.TabIndex = 36;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtState
            // 
            txtState.Location = new Point(782, 283);
            txtState.Name = "txtState";
            txtState.ReadOnly = true;
            txtState.Size = new Size(279, 31);
            txtState.TabIndex = 39;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(782, 255);
            lblState.Name = "lblState";
            lblState.Size = new Size(51, 25);
            lblState.TabIndex = 38;
            lblState.Text = "State";
            // 
            // lblRegistrationDate
            // 
            lblRegistrationDate.AutoSize = true;
            lblRegistrationDate.Location = new Point(782, 347);
            lblRegistrationDate.Name = "lblRegistrationDate";
            lblRegistrationDate.Size = new Size(148, 25);
            lblRegistrationDate.TabIndex = 40;
            lblRegistrationDate.Text = "Registration Date";
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Black;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(1180, 314);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(230, 55);
            btnCleanForm.TabIndex = 42;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // dtpRegistrationDate
            // 
            dtpRegistrationDate.Location = new Point(777, 375);
            dtpRegistrationDate.Name = "dtpRegistrationDate";
            dtpRegistrationDate.Size = new Size(284, 31);
            dtpRegistrationDate.TabIndex = 43;
            // 
            // FormEditClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 871);
            Controls.Add(dtpRegistrationDate);
            Controls.Add(btnCleanForm);
            Controls.Add(lblRegistrationDate);
            Controls.Add(txtState);
            Controls.Add(lblState);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtTaxPayer);
            Controls.Add(lblTaxPayerNumber);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(btnEditClient);
            Controls.Add(dataGridEditClients);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditClient";
            Text = "FormEditClient";
            Load += FormEditClients_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEditClients).EndInit();
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
        private DataGridView dataGridEditClients;
        private Button btnEditClient;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtTaxPayer;
        private Label lblTaxPayerNumber;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtState;
        private Label lblState;
        private Label lblRegistrationDate;
        private Button btnCleanForm;
        private DateTimePicker dtpRegistrationDate;
    }
}
namespace WSN24_EduardoMoreno_M3.Cliente
{
    partial class FormAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddClient));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dtpRegistrationDate = new DateTimePicker();
            btnCleanForm = new Button();
            lblRegistrationDate = new Label();
            txtState = new TextBox();
            lblState = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtTaxPayer = new TextBox();
            lblTaxPayerNumber = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            btnAddClient = new Button();
            dataGridSearchClients = new DataGridView();
            txtSearch = new TextBox();
            lblSearchClient = new Label();
            btnCleanFormSearch = new Button();
            btnSearchClient = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchClients).BeginInit();
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
            panel2.TabIndex = 23;
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
            panel1.TabIndex = 24;
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
            dtpRegistrationDate.Location = new Point(776, 344);
            dtpRegistrationDate.Name = "dtpRegistrationDate";
            dtpRegistrationDate.Size = new Size(284, 31);
            dtpRegistrationDate.TabIndex = 62;
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Black;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(1179, 283);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(230, 55);
            btnCleanForm.TabIndex = 61;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // lblRegistrationDate
            // 
            lblRegistrationDate.AutoSize = true;
            lblRegistrationDate.Location = new Point(781, 316);
            lblRegistrationDate.Name = "lblRegistrationDate";
            lblRegistrationDate.Size = new Size(148, 25);
            lblRegistrationDate.TabIndex = 60;
            lblRegistrationDate.Text = "Registration Date";
            // 
            // txtState
            // 
            txtState.Location = new Point(781, 252);
            txtState.Name = "txtState";
            txtState.Size = new Size(279, 31);
            txtState.TabIndex = 59;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(781, 224);
            lblState.Name = "lblState";
            lblState.Size = new Size(51, 25);
            lblState.TabIndex = 58;
            lblState.Text = "State";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(433, 344);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(279, 31);
            txtPhoneNumber.TabIndex = 57;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(433, 316);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(132, 25);
            lblPhoneNumber.TabIndex = 56;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(433, 252);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 31);
            txtEmail.TabIndex = 55;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(433, 224);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 54;
            lblEmail.Text = "Email";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(433, 180);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(627, 31);
            txtAddress.TabIndex = 53;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(433, 152);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 52;
            lblAddress.Text = "Address";
            // 
            // txtTaxPayer
            // 
            txtTaxPayer.Location = new Point(83, 344);
            txtTaxPayer.Name = "txtTaxPayer";
            txtTaxPayer.Size = new Size(279, 31);
            txtTaxPayer.TabIndex = 51;
            // 
            // lblTaxPayerNumber
            // 
            lblTaxPayerNumber.AutoSize = true;
            lblTaxPayerNumber.Location = new Point(83, 316);
            lblTaxPayerNumber.Name = "lblTaxPayerNumber";
            lblTaxPayerNumber.Size = new Size(153, 25);
            lblTaxPayerNumber.TabIndex = 50;
            lblTaxPayerNumber.Text = "Tax Payer Number";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(83, 252);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(279, 31);
            txtLastName.TabIndex = 49;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(83, 224);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 48;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(83, 180);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(279, 31);
            txtFirstName.TabIndex = 47;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(83, 152);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 46;
            lblFirstName.Text = "First Name";
            // 
            // btnAddClient
            // 
            btnAddClient.FlatAppearance.BorderColor = Color.Lime;
            btnAddClient.FlatStyle = FlatStyle.Flat;
            btnAddClient.Location = new Point(1179, 344);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(230, 55);
            btnAddClient.TabIndex = 45;
            btnAddClient.Text = "Confirm Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // dataGridSearchClients
            // 
            dataGridSearchClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSearchClients.Location = new Point(83, 515);
            dataGridSearchClients.Name = "dataGridSearchClients";
            dataGridSearchClients.ReadOnly = true;
            dataGridSearchClients.RowHeadersWidth = 62;
            dataGridSearchClients.Size = new Size(1326, 203);
            dataGridSearchClients.TabIndex = 44;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(83, 466);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(629, 31);
            txtSearch.TabIndex = 64;
            // 
            // lblSearchClient
            // 
            lblSearchClient.AutoSize = true;
            lblSearchClient.Location = new Point(83, 438);
            lblSearchClient.Name = "lblSearchClient";
            lblSearchClient.Size = new Size(281, 25);
            lblSearchClient.TabIndex = 63;
            lblSearchClient.Text = "Do your Search by the Client here:";
            // 
            // btnCleanFormSearch
            // 
            btnCleanFormSearch.FlatAppearance.BorderColor = Color.Black;
            btnCleanFormSearch.FlatStyle = FlatStyle.Flat;
            btnCleanFormSearch.Location = new Point(1008, 442);
            btnCleanFormSearch.Name = "btnCleanFormSearch";
            btnCleanFormSearch.Size = new Size(230, 55);
            btnCleanFormSearch.TabIndex = 66;
            btnCleanFormSearch.Text = "Clean Search Form";
            btnCleanFormSearch.UseVisualStyleBackColor = true;
            btnCleanFormSearch.Click += btnCleanFormSearch_Click;
            // 
            // btnSearchClient
            // 
            btnSearchClient.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnSearchClient.FlatStyle = FlatStyle.Flat;
            btnSearchClient.Location = new Point(772, 442);
            btnSearchClient.Name = "btnSearchClient";
            btnSearchClient.Size = new Size(230, 55);
            btnSearchClient.TabIndex = 65;
            btnSearchClient.Text = "Search Client";
            btnSearchClient.UseVisualStyleBackColor = true;
            btnSearchClient.Click += btnSearchClient_Click;
            // 
            // FormAddClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 871);
            Controls.Add(btnCleanFormSearch);
            Controls.Add(btnSearchClient);
            Controls.Add(txtSearch);
            Controls.Add(lblSearchClient);
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
            Controls.Add(btnAddClient);
            Controls.Add(dataGridSearchClients);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormAddClient";
            Text = "FormAddClient";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchClients).EndInit();
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
        private Button btnCleanForm;
        private Label lblRegistrationDate;
        private TextBox txtState;
        private Label lblState;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtTaxPayer;
        private Label lblTaxPayerNumber;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Button btnAddClient;
        private DataGridView dataGridSearchClients;
        private TextBox txtSearch;
        private Label lblSearchClient;
        private Button btnCleanFormSearch;
        private Button btnSearchClient;
    }
}
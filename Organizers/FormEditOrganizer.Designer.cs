namespace WSN24_EduardoMoreno_M3.Organizers
{
    partial class FormEditOrganizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditOrganizer));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dataGridOrganizers = new DataGridView();
            btnCleanForm = new Button();
            txtTaxpayerNumber = new TextBox();
            lblTaxpayerNumber = new Label();
            txtLocality = new TextBox();
            lblLocality = new Label();
            txtName = new TextBox();
            lblName = new Label();
            btnEditOrganizer = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrganizers).BeginInit();
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
            panel2.TabIndex = 24;
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
            panel1.Location = new Point(0, 826);
            panel1.Name = "panel1";
            panel1.Size = new Size(1490, 105);
            panel1.TabIndex = 25;
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
            // dataGridOrganizers
            // 
            dataGridOrganizers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrganizers.Location = new Point(83, 491);
            dataGridOrganizers.Name = "dataGridOrganizers";
            dataGridOrganizers.ReadOnly = true;
            dataGridOrganizers.RowHeadersWidth = 62;
            dataGridOrganizers.Size = new Size(1326, 313);
            dataGridOrganizers.TabIndex = 45;
            dataGridOrganizers.CellClick += dataGridOrganizers_CellClick;
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Black;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(1179, 369);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(230, 55);
            btnCleanForm.TabIndex = 115;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // txtTaxpayerNumber
            // 
            txtTaxpayerNumber.Location = new Point(697, 393);
            txtTaxpayerNumber.Name = "txtTaxpayerNumber";
            txtTaxpayerNumber.Size = new Size(279, 31);
            txtTaxpayerNumber.TabIndex = 114;
            // 
            // lblTaxpayerNumber
            // 
            lblTaxpayerNumber.AutoSize = true;
            lblTaxpayerNumber.Location = new Point(697, 365);
            lblTaxpayerNumber.Name = "lblTaxpayerNumber";
            lblTaxpayerNumber.Size = new Size(153, 25);
            lblTaxpayerNumber.TabIndex = 113;
            lblTaxpayerNumber.Text = "Tax Payer Number";
            // 
            // txtLocality
            // 
            txtLocality.Location = new Point(257, 393);
            txtLocality.Name = "txtLocality";
            txtLocality.Size = new Size(348, 31);
            txtLocality.TabIndex = 112;
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Location = new Point(257, 354);
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(71, 25);
            lblLocality.TabIndex = 111;
            lblLocality.Text = "Locality";
            // 
            // txtName
            // 
            txtName.Location = new Point(257, 303);
            txtName.Name = "txtName";
            txtName.Size = new Size(348, 31);
            txtName.TabIndex = 110;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(257, 275);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 109;
            lblName.Text = "Name";
            // 
            // btnEditOrganizer
            // 
            btnEditOrganizer.FlatAppearance.BorderColor = Color.Yellow;
            btnEditOrganizer.FlatStyle = FlatStyle.Flat;
            btnEditOrganizer.Location = new Point(1179, 430);
            btnEditOrganizer.Name = "btnEditOrganizer";
            btnEditOrganizer.Size = new Size(230, 55);
            btnEditOrganizer.TabIndex = 108;
            btnEditOrganizer.Text = "Confirm Edit Organizer";
            btnEditOrganizer.UseVisualStyleBackColor = true;
            btnEditOrganizer.Click += btnEditOrganizer_Click;
            // 
            // FormEditOrganizer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 930);
            Controls.Add(btnCleanForm);
            Controls.Add(txtTaxpayerNumber);
            Controls.Add(lblTaxpayerNumber);
            Controls.Add(txtLocality);
            Controls.Add(lblLocality);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnEditOrganizer);
            Controls.Add(dataGridOrganizers);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditOrganizer";
            Text = "FormEditOrganizer";
            Load += FormEditOrganizers_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrganizers).EndInit();
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
        private DataGridView dataGridOrganizers;
        private Button btnCleanForm;
        private TextBox txtTaxpayerNumber;
        private Label lblTaxpayerNumber;
        private TextBox txtLocality;
        private Label lblLocality;
        private TextBox txtName;
        private Label lblName;
        private Button btnEditOrganizer;
    }
}
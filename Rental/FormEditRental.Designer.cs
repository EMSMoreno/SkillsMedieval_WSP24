namespace WSN24_EduardoMoreno_M3.Rental
{
    partial class FormEditRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditRental));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            cmbStatus = new ComboBox();
            dtpRentalDate = new DateTimePicker();
            dtpReturnDate = new DateTimePicker();
            lblStatus = new Label();
            btnCleanForm = new Button();
            lblReturnDate = new Label();
            lblRentalDate = new Label();
            btnEditRental = new Button();
            dataGridRentals = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRentals).BeginInit();
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
            panel2.TabIndex = 25;
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
            panel1.Location = new Point(0, 641);
            panel1.Name = "panel1";
            panel1.Size = new Size(1490, 105);
            panel1.TabIndex = 26;
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
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(829, 222);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(300, 33);
            cmbStatus.TabIndex = 143;
            // 
            // dtpRentalDate
            // 
            dtpRentalDate.Location = new Point(124, 220);
            dtpRentalDate.Name = "dtpRentalDate";
            dtpRentalDate.Size = new Size(300, 31);
            dtpRentalDate.TabIndex = 142;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(475, 224);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(300, 31);
            dtpReturnDate.TabIndex = 141;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(829, 194);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 140;
            lblStatus.Text = "Status";
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Black;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(1168, 200);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(230, 55);
            btnCleanForm.TabIndex = 139;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(475, 196);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(105, 25);
            lblReturnDate.TabIndex = 138;
            lblReturnDate.Text = "Return Date";
            // 
            // lblRentalDate
            // 
            lblRentalDate.AutoSize = true;
            lblRentalDate.Location = new Point(124, 192);
            lblRentalDate.Name = "lblRentalDate";
            lblRentalDate.Size = new Size(102, 25);
            lblRentalDate.TabIndex = 137;
            lblRentalDate.Text = "Rental Date";
            // 
            // btnEditRental
            // 
            btnEditRental.FlatAppearance.BorderColor = Color.Yellow;
            btnEditRental.FlatStyle = FlatStyle.Flat;
            btnEditRental.Location = new Point(1168, 261);
            btnEditRental.Name = "btnEditRental";
            btnEditRental.Size = new Size(230, 55);
            btnEditRental.TabIndex = 136;
            btnEditRental.Text = "Confirm Edit Rental";
            btnEditRental.UseVisualStyleBackColor = true;
            btnEditRental.Click += btnEditRental_Click;
            // 
            // dataGridRentals
            // 
            dataGridRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRentals.Location = new Point(72, 322);
            dataGridRentals.Name = "dataGridRentals";
            dataGridRentals.ReadOnly = true;
            dataGridRentals.RowHeadersWidth = 62;
            dataGridRentals.Size = new Size(1326, 313);
            dataGridRentals.TabIndex = 144;
            dataGridRentals.CellClick += dataGridRentals_CellClick;
            // 
            // FormEditRental
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 745);
            Controls.Add(dataGridRentals);
            Controls.Add(cmbStatus);
            Controls.Add(dtpRentalDate);
            Controls.Add(dtpReturnDate);
            Controls.Add(lblStatus);
            Controls.Add(btnCleanForm);
            Controls.Add(lblReturnDate);
            Controls.Add(lblRentalDate);
            Controls.Add(btnEditRental);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditRental";
            Text = "FormEditRental";
            Load += FormEditRental_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRentals).EndInit();
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
        private ComboBox cmbStatus;
        private DateTimePicker dtpRentalDate;
        private DateTimePicker dtpReturnDate;
        private Label lblStatus;
        private Button btnCleanForm;
        private Label lblReturnDate;
        private Label lblRentalDate;
        private Button btnEditRental;
        private DataGridView dataGridRentals;
    }
}
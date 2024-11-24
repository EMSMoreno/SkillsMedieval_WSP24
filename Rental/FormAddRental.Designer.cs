namespace WSN24_EduardoMoreno_M3.Rental
{
    partial class FormAddRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRental));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnCleanFormSearch = new Button();
            btnSearchOrganizer = new Button();
            txtSearchRental = new TextBox();
            lblSearchOrganizer = new Label();
            dataGridSearchRentals = new DataGridView();
            btnCleanForm = new Button();
            lblReturnDate = new Label();
            lblRentalDate = new Label();
            btnAddRental = new Button();
            lblStatus = new Label();
            dtpReturnDate = new DateTimePicker();
            dtpRentalDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            cmbCostume = new ComboBox();
            lblCostume = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchRentals).BeginInit();
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
            panel2.TabIndex = 26;
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
            panel1.TabIndex = 27;
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
            // btnCleanFormSearch
            // 
            btnCleanFormSearch.FlatAppearance.BorderColor = Color.Black;
            btnCleanFormSearch.FlatStyle = FlatStyle.Flat;
            btnCleanFormSearch.Location = new Point(1183, 497);
            btnCleanFormSearch.Name = "btnCleanFormSearch";
            btnCleanFormSearch.Size = new Size(230, 55);
            btnCleanFormSearch.TabIndex = 131;
            btnCleanFormSearch.Text = "Clean Search Form";
            btnCleanFormSearch.UseVisualStyleBackColor = true;
            btnCleanFormSearch.Click += btnCleanFormSearch_Click;
            // 
            // btnSearchOrganizer
            // 
            btnSearchOrganizer.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnSearchOrganizer.FlatStyle = FlatStyle.Flat;
            btnSearchOrganizer.Location = new Point(947, 497);
            btnSearchOrganizer.Name = "btnSearchOrganizer";
            btnSearchOrganizer.Size = new Size(230, 55);
            btnSearchOrganizer.TabIndex = 130;
            btnSearchOrganizer.Text = "Search Organizer";
            btnSearchOrganizer.UseVisualStyleBackColor = true;
            btnSearchOrganizer.Click += btnSearchOrganizer_Click;
            // 
            // txtSearchRental
            // 
            txtSearchRental.Location = new Point(87, 509);
            txtSearchRental.Name = "txtSearchRental";
            txtSearchRental.Size = new Size(629, 31);
            txtSearchRental.TabIndex = 129;
            // 
            // lblSearchOrganizer
            // 
            lblSearchOrganizer.AutoSize = true;
            lblSearchOrganizer.Location = new Point(87, 481);
            lblSearchOrganizer.Name = "lblSearchOrganizer";
            lblSearchOrganizer.Size = new Size(314, 25);
            lblSearchOrganizer.TabIndex = 128;
            lblSearchOrganizer.Text = "Do your Search by the Organizer here:";
            // 
            // dataGridSearchRentals
            // 
            dataGridSearchRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSearchRentals.Location = new Point(87, 558);
            dataGridSearchRentals.Name = "dataGridSearchRentals";
            dataGridSearchRentals.ReadOnly = true;
            dataGridSearchRentals.RowHeadersWidth = 62;
            dataGridSearchRentals.Size = new Size(1326, 203);
            dataGridSearchRentals.TabIndex = 127;
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Black;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(1183, 261);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(230, 55);
            btnCleanForm.TabIndex = 126;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(412, 259);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(105, 25);
            lblReturnDate.TabIndex = 122;
            lblReturnDate.Text = "Return Date";
            // 
            // lblRentalDate
            // 
            lblRentalDate.AutoSize = true;
            lblRentalDate.Location = new Point(412, 187);
            lblRentalDate.Name = "lblRentalDate";
            lblRentalDate.Size = new Size(102, 25);
            lblRentalDate.TabIndex = 120;
            lblRentalDate.Text = "Rental Date";
            // 
            // btnAddRental
            // 
            btnAddRental.FlatAppearance.BorderColor = Color.Lime;
            btnAddRental.FlatStyle = FlatStyle.Flat;
            btnAddRental.Location = new Point(1183, 322);
            btnAddRental.Name = "btnAddRental";
            btnAddRental.Size = new Size(230, 55);
            btnAddRental.TabIndex = 119;
            btnAddRental.Text = "Confirm Add Rental";
            btnAddRental.UseVisualStyleBackColor = true;
            btnAddRental.Click += btnAddRental_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(412, 352);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 132;
            lblStatus.Text = "Status";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(412, 287);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(300, 31);
            dtpReturnDate.TabIndex = 133;
            // 
            // dtpRentalDate
            // 
            dtpRentalDate.Location = new Point(412, 215);
            dtpRentalDate.Name = "dtpRentalDate";
            dtpRentalDate.Size = new Size(300, 31);
            dtpRentalDate.TabIndex = 134;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(412, 380);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(300, 33);
            cmbStatus.TabIndex = 135;
            // 
            // cmbCostume
            // 
            cmbCostume.FormattingEnabled = true;
            cmbCostume.Location = new Point(776, 380);
            cmbCostume.Name = "cmbCostume";
            cmbCostume.Size = new Size(300, 33);
            cmbCostume.TabIndex = 137;
            // 
            // lblCostume
            // 
            lblCostume.AutoSize = true;
            lblCostume.Location = new Point(776, 352);
            lblCostume.Name = "lblCostume";
            lblCostume.Size = new Size(83, 25);
            lblCostume.TabIndex = 136;
            lblCostume.Text = "Costume";
            // 
            // FormAddRental
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 869);
            Controls.Add(cmbCostume);
            Controls.Add(lblCostume);
            Controls.Add(cmbStatus);
            Controls.Add(dtpRentalDate);
            Controls.Add(dtpReturnDate);
            Controls.Add(lblStatus);
            Controls.Add(btnCleanFormSearch);
            Controls.Add(btnSearchOrganizer);
            Controls.Add(txtSearchRental);
            Controls.Add(lblSearchOrganizer);
            Controls.Add(dataGridSearchRentals);
            Controls.Add(btnCleanForm);
            Controls.Add(lblReturnDate);
            Controls.Add(lblRentalDate);
            Controls.Add(btnAddRental);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormAddRental";
            Text = "FormAddRental";
            Load += FormAddRental_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchRentals).EndInit();
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
        private Button btnCleanFormSearch;
        private Button btnSearchOrganizer;
        private TextBox txtSearchRental;
        private Label lblSearchOrganizer;
        private DataGridView dataGridSearchRentals;
        private Button btnCleanForm;
        private Label lblReturnDate;
        private Label lblRentalDate;
        private Button btnAddRental;
        private Label lblStatus;
        private DateTimePicker dtpReturnDate;
        private DateTimePicker dtpRentalDate;
        private ComboBox cmbStatus;
        private ComboBox cmbCostume;
        private Label lblCostume;
    }
}
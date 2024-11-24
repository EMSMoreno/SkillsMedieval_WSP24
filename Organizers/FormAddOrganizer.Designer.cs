namespace WSN24_EduardoMoreno_M3.Organizers
{
    partial class FormAddOrganizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrganizer));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnCleanFormSearch = new Button();
            btnSearchOrganizer = new Button();
            txtSearchOrganizer = new TextBox();
            lblSearchOrganizer = new Label();
            dataGridSearchOrganizers = new DataGridView();
            btnCleanForm = new Button();
            txtTaxpayerNumber = new TextBox();
            lblTaxpayerNumber = new Label();
            txtLocality = new TextBox();
            lblLocality = new Label();
            txtName = new TextBox();
            lblName = new Label();
            btnAddOrganizer = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchOrganizers).BeginInit();
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
            panel1.Location = new Point(0, 897);
            panel1.Name = "panel1";
            panel1.Size = new Size(1499, 105);
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
            // btnCleanFormSearch
            // 
            btnCleanFormSearch.FlatAppearance.BorderColor = Color.Black;
            btnCleanFormSearch.FlatStyle = FlatStyle.Flat;
            btnCleanFormSearch.Location = new Point(1019, 564);
            btnCleanFormSearch.Name = "btnCleanFormSearch";
            btnCleanFormSearch.Size = new Size(230, 55);
            btnCleanFormSearch.TabIndex = 118;
            btnCleanFormSearch.Text = "Clean Search Form";
            btnCleanFormSearch.UseVisualStyleBackColor = true;
            btnCleanFormSearch.Click += btnCleanFormSearch_Click;
            // 
            // btnSearchOrganizer
            // 
            btnSearchOrganizer.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnSearchOrganizer.FlatStyle = FlatStyle.Flat;
            btnSearchOrganizer.Location = new Point(783, 564);
            btnSearchOrganizer.Name = "btnSearchOrganizer";
            btnSearchOrganizer.Size = new Size(230, 55);
            btnSearchOrganizer.TabIndex = 117;
            btnSearchOrganizer.Text = "Search Organizer";
            btnSearchOrganizer.UseVisualStyleBackColor = true;
            btnSearchOrganizer.Click += btnSearchOrganizer_Click;
            // 
            // txtSearchOrganizer
            // 
            txtSearchOrganizer.Location = new Point(94, 588);
            txtSearchOrganizer.Name = "txtSearchOrganizer";
            txtSearchOrganizer.Size = new Size(629, 31);
            txtSearchOrganizer.TabIndex = 116;
            // 
            // lblSearchOrganizer
            // 
            lblSearchOrganizer.AutoSize = true;
            lblSearchOrganizer.Location = new Point(94, 560);
            lblSearchOrganizer.Name = "lblSearchOrganizer";
            lblSearchOrganizer.Size = new Size(314, 25);
            lblSearchOrganizer.TabIndex = 115;
            lblSearchOrganizer.Text = "Do your Search by the Organizer here:";
            // 
            // dataGridSearchOrganizers
            // 
            dataGridSearchOrganizers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSearchOrganizers.Location = new Point(79, 643);
            dataGridSearchOrganizers.Name = "dataGridSearchOrganizers";
            dataGridSearchOrganizers.ReadOnly = true;
            dataGridSearchOrganizers.RowHeadersWidth = 62;
            dataGridSearchOrganizers.Size = new Size(1326, 203);
            dataGridSearchOrganizers.TabIndex = 114;
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Black;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(783, 268);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(230, 55);
            btnCleanForm.TabIndex = 107;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // txtTaxpayerNumber
            // 
            txtTaxpayerNumber.Location = new Point(180, 419);
            txtTaxpayerNumber.Name = "txtTaxpayerNumber";
            txtTaxpayerNumber.Size = new Size(279, 31);
            txtTaxpayerNumber.TabIndex = 102;
            // 
            // lblTaxpayerNumber
            // 
            lblTaxpayerNumber.AutoSize = true;
            lblTaxpayerNumber.Location = new Point(180, 391);
            lblTaxpayerNumber.Name = "lblTaxpayerNumber";
            lblTaxpayerNumber.Size = new Size(153, 25);
            lblTaxpayerNumber.TabIndex = 101;
            lblTaxpayerNumber.Text = "Tax Payer Number";
            // 
            // txtLocality
            // 
            txtLocality.Location = new Point(180, 337);
            txtLocality.Name = "txtLocality";
            txtLocality.Size = new Size(348, 31);
            txtLocality.TabIndex = 98;
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Location = new Point(180, 298);
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(71, 25);
            lblLocality.TabIndex = 97;
            lblLocality.Text = "Locality";
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 254);
            txtName.Name = "txtName";
            txtName.Size = new Size(348, 31);
            txtName.TabIndex = 96;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(180, 226);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 95;
            lblName.Text = "Name";
            // 
            // btnAddOrganizer
            // 
            btnAddOrganizer.FlatAppearance.BorderColor = Color.Lime;
            btnAddOrganizer.FlatStyle = FlatStyle.Flat;
            btnAddOrganizer.Location = new Point(783, 329);
            btnAddOrganizer.Name = "btnAddOrganizer";
            btnAddOrganizer.Size = new Size(230, 55);
            btnAddOrganizer.TabIndex = 94;
            btnAddOrganizer.Text = "Confirm Add Organizer";
            btnAddOrganizer.UseVisualStyleBackColor = true;
            btnAddOrganizer.Click += btnAddOrganizer_Click;
            // 
            // FormAddOrganizer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 1001);
            Controls.Add(btnCleanFormSearch);
            Controls.Add(btnSearchOrganizer);
            Controls.Add(txtSearchOrganizer);
            Controls.Add(lblSearchOrganizer);
            Controls.Add(dataGridSearchOrganizers);
            Controls.Add(btnCleanForm);
            Controls.Add(txtTaxpayerNumber);
            Controls.Add(lblTaxpayerNumber);
            Controls.Add(txtLocality);
            Controls.Add(lblLocality);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnAddOrganizer);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormAddOrganizer";
            Text = "FormAddOrganizer";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchOrganizers).EndInit();
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
        private TextBox txtSearchOrganizer;
        private Label lblSearchOrganizer;
        private DataGridView dataGridSearchOrganizers;
        private Button btnCleanForm;
        private TextBox txtTaxpayerNumber;
        private Label lblTaxpayerNumber;
        private TextBox txtLocality;
        private Label lblLocality;
        private TextBox txtName;
        private Label lblName;
        private Button btnAddOrganizer;
    }
}
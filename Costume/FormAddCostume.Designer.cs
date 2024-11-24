namespace WSN24_EduardoMoreno_M3.Costume
{
    partial class FormAddCostume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCostume));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnCleanFormSearch = new Button();
            btnSearchClient = new Button();
            txtSearch = new TextBox();
            lblSearchClient = new Label();
            btnCleanForm = new Button();
            lblImagePath = new Label();
            txtWarehouseID = new TextBox();
            lblWarehouse = new Label();
            txtRentalPrice = new TextBox();
            lblRentalPrice = new Label();
            lblAvailableForRent = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtReferenceCode = new TextBox();
            lblReferenceCode = new Label();
            btnAddCostume = new Button();
            dataGridSearchCostumes = new DataGridView();
            chkAvailableForRent = new CheckBox();
            btnSelectImage = new Button();
            pictureBox = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchCostumes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
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
            panel1.Location = new Point(1, 767);
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
            // btnCleanFormSearch
            // 
            btnCleanFormSearch.FlatAppearance.BorderColor = Color.Black;
            btnCleanFormSearch.FlatStyle = FlatStyle.Flat;
            btnCleanFormSearch.Location = new Point(1008, 442);
            btnCleanFormSearch.Name = "btnCleanFormSearch";
            btnCleanFormSearch.Size = new Size(230, 55);
            btnCleanFormSearch.TabIndex = 89;
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
            btnSearchClient.TabIndex = 88;
            btnSearchClient.Text = "Search Costume";
            btnSearchClient.UseVisualStyleBackColor = true;
            btnSearchClient.Click += btnSearchClient_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(83, 466);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(629, 31);
            txtSearch.TabIndex = 87;
            // 
            // lblSearchClient
            // 
            lblSearchClient.AutoSize = true;
            lblSearchClient.Location = new Point(83, 438);
            lblSearchClient.Name = "lblSearchClient";
            lblSearchClient.Size = new Size(308, 25);
            lblSearchClient.TabIndex = 86;
            lblSearchClient.Text = "Do your Search by the Costume here:";
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Black;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(1179, 283);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(230, 55);
            btnCleanForm.TabIndex = 84;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // lblImagePath
            // 
            lblImagePath.AutoSize = true;
            lblImagePath.Location = new Point(772, 152);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(101, 25);
            lblImagePath.TabIndex = 79;
            lblImagePath.Text = "Image Path";
            // 
            // txtWarehouseID
            // 
            txtWarehouseID.Location = new Point(433, 252);
            txtWarehouseID.Name = "txtWarehouseID";
            txtWarehouseID.Size = new Size(279, 31);
            txtWarehouseID.TabIndex = 78;
            // 
            // lblWarehouse
            // 
            lblWarehouse.AutoSize = true;
            lblWarehouse.Location = new Point(433, 224);
            lblWarehouse.Name = "lblWarehouse";
            lblWarehouse.Size = new Size(100, 25);
            lblWarehouse.TabIndex = 77;
            lblWarehouse.Text = "Warehouse";
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Location = new Point(433, 180);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.Size = new Size(279, 31);
            txtRentalPrice.TabIndex = 76;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Location = new Point(433, 152);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(102, 25);
            lblRentalPrice.TabIndex = 75;
            lblRentalPrice.Text = "Rental Price";
            // 
            // lblAvailableForRent
            // 
            lblAvailableForRent.AutoSize = true;
            lblAvailableForRent.Location = new Point(433, 313);
            lblAvailableForRent.Name = "lblAvailableForRent";
            lblAvailableForRent.Size = new Size(154, 25);
            lblAvailableForRent.TabIndex = 73;
            lblAvailableForRent.Text = "Available For Rent";
            // 
            // txtName
            // 
            txtName.Location = new Point(83, 252);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 31);
            txtName.TabIndex = 72;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(83, 224);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 71;
            lblName.Text = "Name";
            // 
            // txtReferenceCode
            // 
            txtReferenceCode.Location = new Point(83, 180);
            txtReferenceCode.Name = "txtReferenceCode";
            txtReferenceCode.Size = new Size(279, 31);
            txtReferenceCode.TabIndex = 70;
            // 
            // lblReferenceCode
            // 
            lblReferenceCode.AutoSize = true;
            lblReferenceCode.Location = new Point(83, 152);
            lblReferenceCode.Name = "lblReferenceCode";
            lblReferenceCode.Size = new Size(135, 25);
            lblReferenceCode.TabIndex = 69;
            lblReferenceCode.Text = "Reference Code";
            // 
            // btnAddCostume
            // 
            btnAddCostume.FlatAppearance.BorderColor = Color.Lime;
            btnAddCostume.FlatStyle = FlatStyle.Flat;
            btnAddCostume.Location = new Point(1179, 344);
            btnAddCostume.Name = "btnAddCostume";
            btnAddCostume.Size = new Size(230, 55);
            btnAddCostume.TabIndex = 68;
            btnAddCostume.Text = "Confirm Add Costume";
            btnAddCostume.UseVisualStyleBackColor = true;
            btnAddCostume.Click += btnAddCostume_Click;
            // 
            // dataGridSearchCostumes
            // 
            dataGridSearchCostumes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSearchCostumes.Location = new Point(83, 515);
            dataGridSearchCostumes.Name = "dataGridSearchCostumes";
            dataGridSearchCostumes.ReadOnly = true;
            dataGridSearchCostumes.RowHeadersWidth = 62;
            dataGridSearchCostumes.Size = new Size(1326, 203);
            dataGridSearchCostumes.TabIndex = 67;
            // 
            // chkAvailableForRent
            // 
            chkAvailableForRent.AutoSize = true;
            chkAvailableForRent.Location = new Point(446, 355);
            chkAvailableForRent.Name = "chkAvailableForRent";
            chkAvailableForRent.Size = new Size(141, 29);
            chkAvailableForRent.TabIndex = 90;
            chkAvailableForRent.Text = "check if \"Yes\"";
            chkAvailableForRent.UseVisualStyleBackColor = true;
            // 
            // btnSelectImage
            // 
            btnSelectImage.FlatAppearance.BorderColor = Color.IndianRed;
            btnSelectImage.FlatStyle = FlatStyle.Flat;
            btnSelectImage.Location = new Point(898, 137);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(230, 55);
            btnSelectImage.TabIndex = 92;
            btnSelectImage.Text = "Select Costume Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(772, 198);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(356, 201);
            pictureBox.TabIndex = 93;
            pictureBox.TabStop = false;
            // 
            // FormAddCostume
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 871);
            Controls.Add(pictureBox);
            Controls.Add(btnSelectImage);
            Controls.Add(chkAvailableForRent);
            Controls.Add(btnCleanFormSearch);
            Controls.Add(btnSearchClient);
            Controls.Add(txtSearch);
            Controls.Add(lblSearchClient);
            Controls.Add(btnCleanForm);
            Controls.Add(lblImagePath);
            Controls.Add(txtWarehouseID);
            Controls.Add(lblWarehouse);
            Controls.Add(txtRentalPrice);
            Controls.Add(lblRentalPrice);
            Controls.Add(lblAvailableForRent);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtReferenceCode);
            Controls.Add(lblReferenceCode);
            Controls.Add(btnAddCostume);
            Controls.Add(dataGridSearchCostumes);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormAddCostume";
            Text = "FormAddCostume";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchCostumes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
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
        private Button btnSearchClient;
        private TextBox txtSearch;
        private Label lblSearchClient;
        private Button btnCleanForm;
        private Label lblImagePath;
        private TextBox txtWarehouseID;
        private Label lblWarehouse;
        private TextBox txtRentalPrice;
        private Label lblRentalPrice;
        private Label lblAvailableForRent;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtReferenceCode;
        private Label lblReferenceCode;
        private Button btnAddCostume;
        private DataGridView dataGridSearchCostumes;
        private CheckBox chkAvailableForRent;
        private Button btnSelectImage;
        private PictureBox pictureBox;
    }
}
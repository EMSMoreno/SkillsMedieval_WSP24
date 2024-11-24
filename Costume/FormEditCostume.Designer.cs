namespace WSN24_EduardoMoreno_M3.Costume
{
    partial class FormEditCostume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCostume));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnSelectImage = new Button();
            chkAvailableForRent = new CheckBox();
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
            btnEditCostume = new Button();
            dataGridEditCostumes = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEditCostumes).BeginInit();
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
            // btnSelectImage
            // 
            btnSelectImage.FlatAppearance.BorderColor = Color.IndianRed;
            btnSelectImage.FlatStyle = FlatStyle.Flat;
            btnSelectImage.Location = new Point(741, 195);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(230, 55);
            btnSelectImage.TabIndex = 107;
            btnSelectImage.Text = "Select Costume Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // chkAvailableForRent
            // 
            chkAvailableForRent.AutoSize = true;
            chkAvailableForRent.Location = new Point(415, 356);
            chkAvailableForRent.Name = "chkAvailableForRent";
            chkAvailableForRent.Size = new Size(141, 29);
            chkAvailableForRent.TabIndex = 106;
            chkAvailableForRent.Text = "check if \"Yes\"";
            chkAvailableForRent.UseVisualStyleBackColor = true;
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Black;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(1148, 284);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(230, 55);
            btnCleanForm.TabIndex = 105;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // lblImagePath
            // 
            lblImagePath.AutoSize = true;
            lblImagePath.Location = new Point(741, 153);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(101, 25);
            lblImagePath.TabIndex = 104;
            lblImagePath.Text = "Image Path";
            // 
            // txtWarehouseID
            // 
            txtWarehouseID.Location = new Point(402, 253);
            txtWarehouseID.Name = "txtWarehouseID";
            txtWarehouseID.Size = new Size(279, 31);
            txtWarehouseID.TabIndex = 103;
            // 
            // lblWarehouse
            // 
            lblWarehouse.AutoSize = true;
            lblWarehouse.Location = new Point(402, 225);
            lblWarehouse.Name = "lblWarehouse";
            lblWarehouse.Size = new Size(100, 25);
            lblWarehouse.TabIndex = 102;
            lblWarehouse.Text = "Warehouse";
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Location = new Point(402, 181);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.Size = new Size(279, 31);
            txtRentalPrice.TabIndex = 101;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Location = new Point(402, 153);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(102, 25);
            lblRentalPrice.TabIndex = 100;
            lblRentalPrice.Text = "Rental Price";
            // 
            // lblAvailableForRent
            // 
            lblAvailableForRent.AutoSize = true;
            lblAvailableForRent.Location = new Point(402, 314);
            lblAvailableForRent.Name = "lblAvailableForRent";
            lblAvailableForRent.Size = new Size(154, 25);
            lblAvailableForRent.TabIndex = 99;
            lblAvailableForRent.Text = "Available For Rent";
            // 
            // txtName
            // 
            txtName.Location = new Point(52, 253);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 31);
            txtName.TabIndex = 98;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(52, 225);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 97;
            lblName.Text = "Name";
            // 
            // txtReferenceCode
            // 
            txtReferenceCode.Location = new Point(52, 181);
            txtReferenceCode.Name = "txtReferenceCode";
            txtReferenceCode.Size = new Size(279, 31);
            txtReferenceCode.TabIndex = 96;
            // 
            // lblReferenceCode
            // 
            lblReferenceCode.AutoSize = true;
            lblReferenceCode.Location = new Point(52, 153);
            lblReferenceCode.Name = "lblReferenceCode";
            lblReferenceCode.Size = new Size(135, 25);
            lblReferenceCode.TabIndex = 95;
            lblReferenceCode.Text = "Reference Code";
            // 
            // btnEditCostume
            // 
            btnEditCostume.FlatAppearance.BorderColor = Color.Yellow;
            btnEditCostume.FlatStyle = FlatStyle.Flat;
            btnEditCostume.Location = new Point(1148, 345);
            btnEditCostume.Name = "btnEditCostume";
            btnEditCostume.Size = new Size(230, 55);
            btnEditCostume.TabIndex = 94;
            btnEditCostume.Text = "Confirm Edit Costume";
            btnEditCostume.UseVisualStyleBackColor = true;
            btnEditCostume.Click += btnEditCostume_Click;
            // 
            // dataGridEditCostumes
            // 
            dataGridEditCostumes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEditCostumes.Location = new Point(52, 450);
            dataGridEditCostumes.Name = "dataGridEditCostumes";
            dataGridEditCostumes.ReadOnly = true;
            dataGridEditCostumes.RowHeadersWidth = 62;
            dataGridEditCostumes.Size = new Size(1326, 295);
            dataGridEditCostumes.TabIndex = 109;
            dataGridEditCostumes.CellClick += dataGridEditCostumes_CellClick;
            // 
            // FormEditCostume
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 871);
            Controls.Add(dataGridEditCostumes);
            Controls.Add(btnSelectImage);
            Controls.Add(chkAvailableForRent);
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
            Controls.Add(btnEditCostume);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditCostume";
            Text = "FormEditCostume";
            Load += FormEditCostume_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEditCostumes).EndInit();
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
        private PictureBox pictureBox;
        private Button btnSelectImage;
        private CheckBox chkAvailableForRent;
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
        private Button btnEditCostume;
        private DataGridView dataGridEditCostumes;
    }
}
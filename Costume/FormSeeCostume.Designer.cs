namespace WSN24_EduardoMoreno_M3.Costume
{
    partial class FormSeeCostume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeeCostume));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnEditCostume = new Button();
            btnAddCostume = new Button();
            dataGridCostumes = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCostumes).BeginInit();
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
            // btnEditCostume
            // 
            btnEditCostume.FlatAppearance.BorderColor = Color.Yellow;
            btnEditCostume.FlatStyle = FlatStyle.Flat;
            btnEditCostume.Location = new Point(723, 664);
            btnEditCostume.Name = "btnEditCostume";
            btnEditCostume.Size = new Size(230, 55);
            btnEditCostume.TabIndex = 26;
            btnEditCostume.Text = "Edit Costume";
            btnEditCostume.UseVisualStyleBackColor = true;
            btnEditCostume.Click += btnEditCostume_Click;
            // 
            // btnAddCostume
            // 
            btnAddCostume.FlatAppearance.BorderColor = Color.Lime;
            btnAddCostume.FlatStyle = FlatStyle.Flat;
            btnAddCostume.Location = new Point(487, 664);
            btnAddCostume.Name = "btnAddCostume";
            btnAddCostume.Size = new Size(230, 55);
            btnAddCostume.TabIndex = 25;
            btnAddCostume.Text = "Add Costume";
            btnAddCostume.UseVisualStyleBackColor = true;
            btnAddCostume.Click += btnAddCostume_Click;
            // 
            // dataGridCostumes
            // 
            dataGridCostumes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCostumes.Location = new Point(83, 151);
            dataGridCostumes.Name = "dataGridCostumes";
            dataGridCostumes.ReadOnly = true;
            dataGridCostumes.RowHeadersWidth = 62;
            dataGridCostumes.Size = new Size(1326, 507);
            dataGridCostumes.TabIndex = 24;
            dataGridCostumes.CellClick += dataGridCostumes_CellClick;
            // 
            // FormSeeCostume
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 871);
            Controls.Add(btnEditCostume);
            Controls.Add(btnAddCostume);
            Controls.Add(dataGridCostumes);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormSeeCostume";
            Text = "FormSeeCostume";
            Load += FormSeeCostumes_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCostumes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button btnEditCostume;
        private Button btnAddCostume;
        private DataGridView dataGridCostumes;
    }
}
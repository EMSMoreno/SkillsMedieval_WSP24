namespace WSN24_EduardoMoreno_M3
{
    partial class FormBlockedUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlockedUser));
            pictureBox1 = new PictureBox();
            lblWarning = new Label();
            label1 = new Label();
            btnAccountRecover = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(690, 407);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Location = new Point(21, 283);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(477, 50);
            lblWarning.TabIndex = 1;
            lblWarning.Text = "Too many login attempts were made. Please complete the \r\naccount recovery process if you want to access the system.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(135, 219);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 2;
            label1.Text = "Account Blocked!";
            // 
            // btnAccountRecover
            // 
            btnAccountRecover.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnAccountRecover.FlatStyle = FlatStyle.Flat;
            btnAccountRecover.Location = new Point(135, 413);
            btnAccountRecover.Name = "btnAccountRecover";
            btnAccountRecover.Size = new Size(220, 41);
            btnAccountRecover.TabIndex = 3;
            btnAccountRecover.Text = "Account Recover";
            btnAccountRecover.UseVisualStyleBackColor = true;
            btnAccountRecover.Click += btnAccountRecover_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(103, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 521);
            panel1.Name = "panel1";
            panel1.Size = new Size(1260, 105);
            panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1165, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(81, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 45);
            label2.Name = "label2";
            label2.Size = new Size(723, 28);
            label2.TabIndex = 0;
            label2.Text = "@2024 WorldSkills Portugal Nacional Exam - Portugal, November, 2024";
            // 
            // FormBlockedUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 624);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(btnAccountRecover);
            Controls.Add(label1);
            Controls.Add(lblWarning);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormBlockedUser";
            Text = "FormBlockedUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblWarning;
        private Label label1;
        private Button btnAccountRecover;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label2;
    }
}
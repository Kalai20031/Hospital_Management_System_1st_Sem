namespace Assignment
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnAddPatient = new Button();
            btnBMI = new Button();
            btnFullHistory = new Button();
            btnsomething1 = new Button();
            label1 = new Label();
            btnExit = new Button();
            pictureBox2 = new PictureBox();
            lblArrow1 = new Label();
            lblArrow2 = new Label();
            lblArrow3 = new Label();
            lblArrow4 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnSleep = new Button();
            lblArrow5 = new Label();
            panel1 = new Panel();
            btnHydration = new Button();
            lblArrow6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = SystemColors.ActiveCaption;
            btnAddPatient.Location = new Point(57, 97);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(177, 37);
            btnAddPatient.TabIndex = 0;
            btnAddPatient.Text = "Add New Patient Record";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // btnBMI
            // 
            btnBMI.BackColor = SystemColors.ActiveCaption;
            btnBMI.Location = new Point(57, 54);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(177, 37);
            btnBMI.TabIndex = 0;
            btnBMI.Text = "BMI Checker";
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnFullHistory_Click;
            // 
            // btnFullHistory
            // 
            btnFullHistory.BackColor = SystemColors.ActiveCaption;
            btnFullHistory.Location = new Point(57, 146);
            btnFullHistory.Name = "btnFullHistory";
            btnFullHistory.Size = new Size(177, 37);
            btnFullHistory.TabIndex = 0;
            btnFullHistory.Text = "Heart Rate Monitor";
            btnFullHistory.UseVisualStyleBackColor = false;
            btnFullHistory.Click += btnBMI_Click;
            // 
            // btnsomething1
            // 
            btnsomething1.BackColor = SystemColors.ActiveCaption;
            btnsomething1.Location = new Point(57, 189);
            btnsomething1.Name = "btnsomething1";
            btnsomething1.Size = new Size(177, 37);
            btnsomething1.TabIndex = 0;
            btnsomething1.Text = "Blood Pressure Checker";
            btnsomething1.UseVisualStyleBackColor = false;
            btnsomething1.Click += btnsomething1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 17);
            label1.Name = "label1";
            label1.Size = new Size(146, 22);
            label1.TabIndex = 1;
            label1.Text = "CONTROLLER";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Salmon;
            btnExit.Location = new Point(85, 320);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(109, 26);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(63, 352);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 166);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lblArrow1
            // 
            lblArrow1.AutoSize = true;
            lblArrow1.BackColor = Color.Linen;
            lblArrow1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrow1.Location = new Point(12, 101);
            lblArrow1.Name = "lblArrow1";
            lblArrow1.Size = new Size(39, 32);
            lblArrow1.TabIndex = 6;
            lblArrow1.Text = "➽";
            // 
            // lblArrow2
            // 
            lblArrow2.AutoSize = true;
            lblArrow2.BackColor = Color.Linen;
            lblArrow2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrow2.Location = new Point(12, 56);
            lblArrow2.Name = "lblArrow2";
            lblArrow2.Size = new Size(39, 32);
            lblArrow2.TabIndex = 6;
            lblArrow2.Text = "➽";
            lblArrow2.Click += lblArrow2_Click;
            // 
            // lblArrow3
            // 
            lblArrow3.AutoSize = true;
            lblArrow3.BackColor = Color.Linen;
            lblArrow3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrow3.Location = new Point(12, 146);
            lblArrow3.Name = "lblArrow3";
            lblArrow3.Size = new Size(39, 32);
            lblArrow3.TabIndex = 6;
            lblArrow3.Text = "➽";
            lblArrow3.Click += label6_Click;
            // 
            // lblArrow4
            // 
            lblArrow4.AutoSize = true;
            lblArrow4.BackColor = Color.Linen;
            lblArrow4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrow4.Location = new Point(12, 189);
            lblArrow4.Name = "lblArrow4";
            lblArrow4.Size = new Size(39, 32);
            lblArrow4.TabIndex = 6;
            lblArrow4.Text = "➽";
            lblArrow4.Click += lblArrow4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(250, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(705, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnSleep
            // 
            btnSleep.BackColor = SystemColors.ActiveCaption;
            btnSleep.Location = new Point(58, 234);
            btnSleep.Name = "btnSleep";
            btnSleep.Size = new Size(177, 37);
            btnSleep.TabIndex = 12;
            btnSleep.Text = "Sleep Quality Tracker";
            btnSleep.UseVisualStyleBackColor = false;
            btnSleep.Click += btnSleep_Click;
            // 
            // lblArrow5
            // 
            lblArrow5.AutoSize = true;
            lblArrow5.BackColor = Color.Linen;
            lblArrow5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrow5.Location = new Point(13, 234);
            lblArrow5.Name = "lblArrow5";
            lblArrow5.Size = new Size(39, 32);
            lblArrow5.TabIndex = 13;
            lblArrow5.Text = "➽";
            lblArrow5.Click += lblArrow5_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(241, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 509);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnHydration
            // 
            btnHydration.BackColor = SystemColors.ActiveCaption;
            btnHydration.Location = new Point(57, 277);
            btnHydration.Name = "btnHydration";
            btnHydration.Size = new Size(177, 37);
            btnHydration.TabIndex = 15;
            btnHydration.Text = "Hydration Checker";
            btnHydration.UseVisualStyleBackColor = false;
            btnHydration.Click += btnHydration_Click;
            // 
            // lblArrow6
            // 
            lblArrow6.AutoSize = true;
            lblArrow6.BackColor = Color.Linen;
            lblArrow6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrow6.Location = new Point(12, 282);
            lblArrow6.Name = "lblArrow6";
            lblArrow6.Size = new Size(39, 32);
            lblArrow6.TabIndex = 16;
            lblArrow6.Text = "➽";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(968, 534);
            Controls.Add(lblArrow6);
            Controls.Add(btnHydration);
            Controls.Add(lblArrow5);
            Controls.Add(btnSleep);
            Controls.Add(label4);
            Controls.Add(lblArrow4);
            Controls.Add(lblArrow3);
            Controls.Add(lblArrow2);
            Controls.Add(lblArrow1);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnsomething1);
            Controls.Add(btnFullHistory);
            Controls.Add(btnBMI);
            Controls.Add(btnAddPatient);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPatient;
        private Button btnBMI;
        private Button btnFullHistory;
        private Button btnsomething1;
        private Label label1;
        private Button btnExit;
        private PictureBox pictureBox2;
        private Label lblArrow1;
        private Label lblArrow2;
        private Label lblArrow3;
        private Label lblArrow4;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnSleep;
        private Label lblArrow5;
        private Panel panel1;
        private Button btnHydration;
        private Label lblArrow6;
    }
}
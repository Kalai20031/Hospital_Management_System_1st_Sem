namespace Assignment
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            label9 = new Label();
            lblWaterIntake = new Label();
            txtWaterIntake = new TextBox();
            lblProgress = new Label();
            lblDailyGoal = new Label();
            txtDailyGoal = new TextBox();
            lblFeedback = new Label();
            btnAdd = new Button();
            btnReset = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Snow;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(281, 52);
            label9.Name = "label9";
            label9.Size = new Size(188, 30);
            label9.TabIndex = 9;
            label9.Text = "Hydration Tracker";
            // 
            // lblWaterIntake
            // 
            lblWaterIntake.AutoSize = true;
            lblWaterIntake.Location = new Point(130, 149);
            lblWaterIntake.Name = "lblWaterIntake";
            lblWaterIntake.Size = new Size(76, 15);
            lblWaterIntake.TabIndex = 10;
            lblWaterIntake.Text = "Water Intake:";
            // 
            // txtWaterIntake
            // 
            txtWaterIntake.Location = new Point(243, 146);
            txtWaterIntake.Name = "txtWaterIntake";
            txtWaterIntake.Size = new Size(322, 23);
            txtWaterIntake.TabIndex = 11;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(130, 236);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(55, 15);
            lblProgress.TabIndex = 13;
            lblProgress.Text = "Progress:";
            // 
            // lblDailyGoal
            // 
            lblDailyGoal.AutoSize = true;
            lblDailyGoal.Location = new Point(130, 113);
            lblDailyGoal.Name = "lblDailyGoal";
            lblDailyGoal.Size = new Size(63, 15);
            lblDailyGoal.TabIndex = 14;
            lblDailyGoal.Text = "Daily Goal:";
            // 
            // txtDailyGoal
            // 
            txtDailyGoal.Location = new Point(243, 110);
            txtDailyGoal.Name = "txtDailyGoal";
            txtDailyGoal.Size = new Size(322, 23);
            txtDailyGoal.TabIndex = 15;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(130, 297);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(60, 15);
            lblFeedback.TabIndex = 16;
            lblFeedback.Text = "Feedback:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkOrange;
            btnAdd.Location = new Point(481, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 30);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DarkOrange;
            btnReset.Location = new Point(348, 186);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 30);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(388, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(698, 475);
            Controls.Add(pictureBox1);
            Controls.Add(btnReset);
            Controls.Add(btnAdd);
            Controls.Add(lblFeedback);
            Controls.Add(txtDailyGoal);
            Controls.Add(lblDailyGoal);
            Controls.Add(lblProgress);
            Controls.Add(txtWaterIntake);
            Controls.Add(lblWaterIntake);
            Controls.Add(label9);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label lblWaterIntake;
        private TextBox txtWaterIntake;
        private Label lblProgress;
        private Label lblDailyGoal;
        private TextBox txtDailyGoal;
        private Label lblFeedback;
        private Button btnAdd;
        private Button btnReset;
        private PictureBox pictureBox1;
    }
}
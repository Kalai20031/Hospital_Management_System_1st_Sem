namespace Assignment
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            lblFeedback = new Label();
            btnclear = new Button();
            btnClick = new Button();
            txtSleepHours = new TextBox();
            lblSleepHours = new Label();
            label9 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.BackColor = Color.White;
            lblFeedback.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeedback.Location = new Point(85, 234);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(74, 20);
            lblFeedback.TabIndex = 13;
            lblFeedback.Text = "Feedback";
            // 
            // btnclear
            // 
            btnclear.Location = new Point(390, 186);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(52, 33);
            btnclear.TabIndex = 12;
            btnclear.Text = "Reset";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(477, 186);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(56, 30);
            btnClick.TabIndex = 11;
            btnClick.Text = "Click";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // txtSleepHours
            // 
            txtSleepHours.Location = new Point(250, 124);
            txtSleepHours.Multiline = true;
            txtSleepHours.Name = "txtSleepHours";
            txtSleepHours.Size = new Size(273, 28);
            txtSleepHours.TabIndex = 10;
            // 
            // lblSleepHours
            // 
            lblSleepHours.AutoSize = true;
            lblSleepHours.BackColor = Color.White;
            lblSleepHours.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSleepHours.Location = new Point(85, 126);
            lblSleepHours.Name = "lblSleepHours";
            lblSleepHours.Size = new Size(150, 20);
            lblSleepHours.TabIndex = 9;
            lblSleepHours.Text = "Enter the sleep hours:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Snow;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(260, 52);
            label9.Name = "label9";
            label9.Size = new Size(217, 30);
            label9.TabIndex = 8;
            label9.Text = "Sleep Quality Cheker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 59);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(395, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(698, 475);
            Controls.Add(pictureBox1);
            Controls.Add(lblFeedback);
            Controls.Add(btnclear);
            Controls.Add(btnClick);
            Controls.Add(txtSleepHours);
            Controls.Add(lblSleepHours);
            Controls.Add(label9);
            Controls.Add(label2);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFeedback;
        private Button btnclear;
        private Button btnClick;
        private TextBox txtSleepHours;
        private Label lblSleepHours;
        private Label label9;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
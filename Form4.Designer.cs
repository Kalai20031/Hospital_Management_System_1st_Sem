namespace Assignment
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            btnback = new Button();
            pictureBox4 = new PictureBox();
            lblHeartRate = new Label();
            lblResult = new Label();
            btnsee = new Button();
            txtHeartRate = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Location = new Point(362, 348);
            btnback.Name = "btnback";
            btnback.Size = new Size(81, 31);
            btnback.TabIndex = 12;
            btnback.Text = "Reset";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(81, 95);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(562, 169);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // lblHeartRate
            // 
            lblHeartRate.AutoSize = true;
            lblHeartRate.BackColor = Color.White;
            lblHeartRate.Location = new Point(99, 295);
            lblHeartRate.Name = "lblHeartRate";
            lblHeartRate.Size = new Size(110, 15);
            lblHeartRate.TabIndex = 9;
            lblHeartRate.Text = "Enter the heart rate:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.WhiteSmoke;
            lblResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(99, 385);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 10;
            lblResult.Text = "Result:";
            // 
            // btnsee
            // 
            btnsee.Location = new Point(458, 348);
            btnsee.Name = "btnsee";
            btnsee.Size = new Size(85, 31);
            btnsee.TabIndex = 8;
            btnsee.Text = "Check";
            btnsee.UseVisualStyleBackColor = true;
            btnsee.Click += btnsee_Click;
            // 
            // txtHeartRate
            // 
            txtHeartRate.Location = new Point(229, 289);
            txtHeartRate.Name = "txtHeartRate";
            txtHeartRate.Size = new Size(305, 23);
            txtHeartRate.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(239, 40);
            label7.Name = "label7";
            label7.Size = new Size(239, 34);
            label7.TabIndex = 6;
            label7.Text = "Heart Rate Monitor";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(698, 475);
            Controls.Add(btnback);
            Controls.Add(pictureBox4);
            Controls.Add(lblHeartRate);
            Controls.Add(lblResult);
            Controls.Add(btnsee);
            Controls.Add(txtHeartRate);
            Controls.Add(label7);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private PictureBox pictureBox4;
        private Label lblHeartRate;
        private Label lblResult;
        private Button btnsee;
        private TextBox txtHeartRate;
        private Label label7;
    }
}
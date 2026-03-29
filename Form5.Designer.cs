namespace Assignment
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox5 = new PictureBox();
            btngoback = new Button();
            lblResults = new Label();
            btnEnter = new Button();
            txtDiastolic = new TextBox();
            lblDiastolic = new Label();
            lblSystolic = new Label();
            txtSystolic = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(348, 271);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(327, 202);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // btngoback
            // 
            btngoback.Location = new Point(365, 208);
            btngoback.Name = "btngoback";
            btngoback.Size = new Size(86, 30);
            btngoback.TabIndex = 16;
            btngoback.Text = "Reset";
            btngoback.UseVisualStyleBackColor = true;
            btngoback.Click += btngoback_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(52, 248);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(56, 21);
            lblResults.TabIndex = 15;
            lblResults.Text = "Result:";
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(461, 210);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(86, 30);
            btnEnter.TabIndex = 14;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtDiastolic
            // 
            txtDiastolic.Location = new Point(151, 162);
            txtDiastolic.Name = "txtDiastolic";
            txtDiastolic.Size = new Size(385, 23);
            txtDiastolic.TabIndex = 13;
            // 
            // lblDiastolic
            // 
            lblDiastolic.AutoSize = true;
            lblDiastolic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiastolic.Location = new Point(50, 162);
            lblDiastolic.Name = "lblDiastolic";
            lblDiastolic.Size = new Size(72, 21);
            lblDiastolic.TabIndex = 12;
            lblDiastolic.Text = "Diastolic:";
            // 
            // lblSystolic
            // 
            lblSystolic.AutoSize = true;
            lblSystolic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSystolic.Location = new Point(50, 97);
            lblSystolic.Name = "lblSystolic";
            lblSystolic.Size = new Size(63, 21);
            lblSystolic.TabIndex = 11;
            lblSystolic.Text = "Systolic";
            // 
            // txtSystolic
            // 
            txtSystolic.Location = new Point(151, 97);
            txtSystolic.Name = "txtSystolic";
            txtSystolic.Size = new Size(385, 23);
            txtSystolic.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(235, 42);
            label8.Name = "label8";
            label8.Size = new Size(243, 30);
            label8.TabIndex = 9;
            label8.Text = "Blood Pressure Checker";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(698, 475);
            Controls.Add(pictureBox5);
            Controls.Add(btngoback);
            Controls.Add(lblResults);
            Controls.Add(btnEnter);
            Controls.Add(txtDiastolic);
            Controls.Add(lblDiastolic);
            Controls.Add(lblSystolic);
            Controls.Add(txtSystolic);
            Controls.Add(label8);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Button btngoback;
        private Label lblResults;
        private Button btnEnter;
        private TextBox txtDiastolic;
        private Label lblDiastolic;
        private Label lblSystolic;
        private TextBox txtSystolic;
        private Label label8;
    }
}
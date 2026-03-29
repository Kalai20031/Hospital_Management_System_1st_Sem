namespace Assignment
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btnReset = new Button();
            txtIndi = new TextBox();
            txtStatus = new TextBox();
            lblIndi = new Label();
            btnCheck = new Button();
            pictureBox3 = new PictureBox();
            txtBMI = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            lblStatus = new Label();
            lblBMI = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(366, 241);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(92, 34);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtIndi
            // 
            txtIndi.Location = new Point(500, 146);
            txtIndi.Multiline = true;
            txtIndi.Name = "txtIndi";
            txtIndi.Size = new Size(75, 27);
            txtIndi.TabIndex = 24;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(500, 80);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(152, 34);
            txtStatus.TabIndex = 23;
            // 
            // lblIndi
            // 
            lblIndi.AutoSize = true;
            lblIndi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndi.Location = new Point(359, 146);
            lblIndi.Name = "lblIndi";
            lblIndi.Size = new Size(99, 25);
            lblIndi.TabIndex = 22;
            lblIndi.Text = "Indicator:";
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(483, 241);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(92, 34);
            btnCheck.TabIndex = 21;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(181, 291);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(346, 172);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // txtBMI
            // 
            txtBMI.Location = new Point(176, 199);
            txtBMI.Multiline = true;
            txtBMI.Name = "txtBMI";
            txtBMI.Size = new Size(71, 25);
            txtBMI.TabIndex = 17;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(176, 146);
            txtHeight.Multiline = true;
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(71, 25);
            txtHeight.TabIndex = 18;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(176, 80);
            txtWeight.Multiline = true;
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(75, 27);
            txtWeight.TabIndex = 19;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(359, 82);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(72, 25);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status:";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBMI.Location = new Point(88, 198);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(53, 25);
            lblBMI.TabIndex = 14;
            lblBMI.Text = "BMI:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeight.Location = new Point(82, 143);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(77, 25);
            lblHeight.TabIndex = 15;
            lblHeight.Text = "Height:";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeight.Location = new Point(82, 82);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(80, 25);
            lblWeight.TabIndex = 16;
            lblWeight.Text = "Weight:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(181, 9);
            label6.Name = "label6";
            label6.Size = new Size(370, 34);
            label6.TabIndex = 12;
            label6.Text = "Adult and Child BMI Calculator";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 10);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 153);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 26;
            label1.Text = "Meters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 85);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 27;
            label2.Text = "Kilograms";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 475);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(txtIndi);
            Controls.Add(txtStatus);
            Controls.Add(lblIndi);
            Controls.Add(btnCheck);
            Controls.Add(pictureBox3);
            Controls.Add(txtBMI);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(lblStatus);
            Controls.Add(lblBMI);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private TextBox txtIndi;
        private TextBox txtStatus;
        private Label lblIndi;
        private Button btnCheck;
        private PictureBox pictureBox3;
        private TextBox txtBMI;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label lblStatus;
        private Label lblBMI;
        private Label lblHeight;
        private Label lblWeight;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label2;
    }
}
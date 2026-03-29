namespace Assignment
{
    partial class Form2
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
            label3 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtContactNumber = new TextBox();
            txtAge = new TextBox();
            txtBlood = new TextBox();
            txtPatientID = new TextBox();
            cmbGender = new ComboBox();
            lblParentID = new Label();
            btnSave = new Button();
            rbtnNo = new RadioButton();
            lblBlood = new Label();
            lblAge = new Label();
            lblNumber = new Label();
            lblDisease = new Label();
            lblAddress = new Label();
            lblName = new Label();
            rbtnYes = new RadioButton();
            lblGender = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 31);
            label3.Name = "label3";
            label3.Size = new Size(254, 30);
            label3.TabIndex = 6;
            label3.Text = "Add New Patient Record";
            // 
            // txtName
            // 
            txtName.Location = new Point(262, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(354, 23);
            txtName.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(262, 127);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(354, 23);
            txtAddress.TabIndex = 14;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(262, 174);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(354, 23);
            txtContactNumber.TabIndex = 15;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(262, 220);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(354, 23);
            txtAge.TabIndex = 19;
            // 
            // txtBlood
            // 
            txtBlood.Location = new Point(262, 299);
            txtBlood.Name = "txtBlood";
            txtBlood.Size = new Size(354, 23);
            txtBlood.TabIndex = 16;
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(53, 426);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(494, 23);
            txtPatientID.TabIndex = 18;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(262, 262);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(354, 23);
            cmbGender.TabIndex = 20;
            // 
            // lblParentID
            // 
            lblParentID.AutoSize = true;
            lblParentID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParentID.Location = new Point(53, 392);
            lblParentID.Name = "lblParentID";
            lblParentID.Size = new Size(74, 17);
            lblParentID.TabIndex = 22;
            lblParentID.Text = "Patient ID:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSkyBlue;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(573, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 34);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // rbtnNo
            // 
            rbtnNo.AutoSize = true;
            rbtnNo.Location = new Point(431, 339);
            rbtnNo.Name = "rbtnNo";
            rbtnNo.Size = new Size(41, 19);
            rbtnNo.TabIndex = 25;
            rbtnNo.TabStop = true;
            rbtnNo.Text = "No";
            rbtnNo.UseVisualStyleBackColor = true;
            // 
            // lblBlood
            // 
            lblBlood.AutoSize = true;
            lblBlood.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBlood.Location = new Point(110, 299);
            lblBlood.Name = "lblBlood";
            lblBlood.Size = new Size(90, 17);
            lblBlood.TabIndex = 11;
            lblBlood.Text = "Blood Group:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(110, 221);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 17);
            lblAge.TabIndex = 9;
            lblAge.Text = "Age:";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(110, 174);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(114, 17);
            lblNumber.TabIndex = 8;
            lblNumber.Text = "Contact Number:";
            // 
            // lblDisease
            // 
            lblDisease.AutoSize = true;
            lblDisease.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisease.Location = new Point(110, 339);
            lblDisease.Name = "lblDisease";
            lblDisease.Size = new Size(227, 17);
            lblDisease.TabIndex = 21;
            lblDisease.Text = "Any Major Disease Suffered Earlier:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(110, 133);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(61, 17);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(110, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 17);
            lblName.TabIndex = 12;
            lblName.Text = "Name:";
            // 
            // rbtnYes
            // 
            rbtnYes.AutoSize = true;
            rbtnYes.Location = new Point(368, 339);
            rbtnYes.Name = "rbtnYes";
            rbtnYes.Size = new Size(42, 19);
            rbtnYes.TabIndex = 24;
            rbtnYes.TabStop = true;
            rbtnYes.Text = "Yes";
            rbtnYes.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(110, 262);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 17);
            lblGender.TabIndex = 27;
            lblGender.Text = "Gender:";
            // 
            // panel1
            // 
            panel1.Location = new Point(-10, -31);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 511);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 472);
            Controls.Add(lblGender);
            Controls.Add(rbtnNo);
            Controls.Add(rbtnYes);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(lblName);
            Controls.Add(lblParentID);
            Controls.Add(lblAddress);
            Controls.Add(lblDisease);
            Controls.Add(lblNumber);
            Controls.Add(cmbGender);
            Controls.Add(lblAge);
            Controls.Add(txtPatientID);
            Controls.Add(lblBlood);
            Controls.Add(txtBlood);
            Controls.Add(txtName);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(txtContactNumber);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtContactNumber;
        private TextBox txtAge;
        private TextBox txtBlood;
        private TextBox txtPatientID;
        private ComboBox cmbGender;
        private Label lblParentID;
        private Button btnSave;
        private RadioButton rbtnNo;
        private Label lblBlood;
        private Label lblAge;
        private Label lblNumber;
        private Label lblDisease;
        private Label lblAddress;
        private Label lblName;
        private RadioButton rbtnYes;
        private Label lblGender;
        private Panel panel1;
    }
}
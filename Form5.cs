using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            // Remove minimize and close buttons
            this.ControlBox = false; // Removes both minimize, maximize, and close buttons.
            this.MinimizeBox = false; // Removes only minimize button if you want to keep others
            this.FormBorderStyle = FormBorderStyle.None; // Remove title bar and form border
            this.MaximizeBox = false; // Removes only maximize button.
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int Systolic = int.Parse(txtSystolic.Text);
            int Diastolic = int.Parse(txtDiastolic.Text);

            if (Systolic < 120 && Diastolic < 80)
            {
                lblResults.Text = "Normal Blood Pressure";
                lblResults.ForeColor = Color.Green; // Green for Normal
            }

            else if (Systolic >= 120 && Systolic <= 129 && Diastolic < 80)
            {
                lblResults.Text = "Elavated Blood Pressure";
                lblResults.ForeColor = Color.Orange; // Orange for elavated
            }

            else if (Systolic >= 130 && Systolic <= 150 && Diastolic >= 80 && Diastolic >= 180)
            {
                lblResults.Text = "Hypertension Stage 1";
                lblResults.ForeColor = Color.Red; // Red for Hypertension
            }


            else
            {
                lblResults.Text = "Hypertension Stage 2";
                lblResults.ForeColor = Color.DarkRed; // DarkRed for severe cases
            }

        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            txtSystolic.Clear();
            txtDiastolic.Clear();
            lblResults.Text = "";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}

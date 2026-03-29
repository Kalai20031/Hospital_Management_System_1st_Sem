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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // Remove minimize and close buttons
            this.ControlBox = false; // Removes both minimize, maximize, and close buttons.
            this.MinimizeBox = false; // Removes only minimize button if you want to keep others
            this.FormBorderStyle = FormBorderStyle.None; // Remove title bar and form border
            this.MaximizeBox = false; // Removes only maximize button.
        }

        private void btnsee_Click(object sender, EventArgs e)
        {
            int heartRate = int.Parse(txtHeartRate.Text);

            if (heartRate >= 60 && heartRate <= 100)
            {
                lblResult.Text = "Resul: Normal Heart Rate.";
                lblResult.ForeColor = Color.Green; // Green for Normal
            }
            else if (heartRate < 60)
            {
                lblResult.Text = "Result: Low Heart Rate.";
                lblResult.ForeColor = Color.Orange; // Orange for Low
            }
            else
            {
                lblResult.Text = "Result: Elevated Heart Rate.";
                lblResult.ForeColor = Color.Red; // Red for Elevated
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            txtHeartRate.Clear();
            lblResult.Text = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

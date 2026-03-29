using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            // Remove minimize and close buttons
            this.ControlBox = false; // Removes both minimize, maximize, and close buttons.
            this.MinimizeBox = false; // Removes only minimize button if you want to keep others
            this.FormBorderStyle = FormBorderStyle.None; // Remove title bar and form border
            this.MaximizeBox = false; // Removes only maximize button.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int intake = int.Parse(txtWaterIntake.Text);
            int goal = int.Parse(txtDailyGoal.Text);

            if (intake > 0)
            {

                if (intake >= goal)
                {
                    lblFeedback.Text = "Good,job! You have reached your goal!";
                }

                else if (intake >= goal * 0.5)
                {
                    lblFeedback.Text = "You're halfway there! Keep going!";
                }

                else
                {
                    lblFeedback.Text = "You need to drink more water";
                }
            }

            else
            {
                MessageBox.Show("Please enter positive number");

            }

            // Update the progress label
            lblProgress.Text = $"{intake}/{goal} ml";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {



            lblFeedback.Text = "";
            lblProgress.Text = "";
            



        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}

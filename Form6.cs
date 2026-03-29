using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            // Remove minimize and close buttons
            this.ControlBox = false; // Removes both minimize, maximize, and close buttons.
            this.MinimizeBox = false; // Removes only minimize button if you want to keep others
            this.FormBorderStyle = FormBorderStyle.None; // Remove title bar and form border
            this.MaximizeBox = false; // Removes only maximize button.
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            double Sleephours = double.Parse(txtSleepHours.Text);

            if (Sleephours > 24 || Sleephours < 0)
            {
                lblFeedback.Text = "Enter a number between 0 to 24";
            }

            else if (Sleephours < 5)
            {
                lblFeedback.Text = "You need more sleep";
            }

            else if (Sleephours <= 7)
            {
                lblFeedback.Text = "Your sleep is okay";
            }

            else
            {
                lblFeedback.Text = "Great job! you have had enough slee";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtSleepHours.Clear();
            lblFeedback.Text = "";
        }
    }
}

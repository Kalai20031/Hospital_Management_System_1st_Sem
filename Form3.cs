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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Remove minimize and close buttons
            this.ControlBox = false; // Removes both minimize, maximize, and close buttons.
            this.MinimizeBox = false; // Removes only minimize button if you want to keep others
            this.FormBorderStyle = FormBorderStyle.None; // Remove title bar and form border
            this.MaximizeBox = false; // Removes only maximize button.
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double height = double.Parse(txtHeight.Text);
            double weight = double.Parse(txtWeight.Text);
            double BMI = weight / (height * height);

            txtBMI.Text = BMI.ToString();

            if (BMI < 18.5)
            {                                                              // Weight: 47, height:1.6
                txtStatus.Text = "Under Weight";
                txtIndi.BackColor = Color.Red; ;
            }
            else if (BMI < 25)
            {                                                             // Weight: 64, height:1.8
                txtStatus.Text = "Normal";
                txtIndi.BackColor = Color.Blue;
            }
            else if (BMI < 30)
            {                                                            // Weight: 96, height:1.8
                txtStatus.Text = "Over Weight";
                txtIndi.BackColor = Color.Green;
            }
            else if (BMI < 35)
            {                                                           // Weight: 113, height:1.8
                txtStatus.Text = "Obesity Class I";
                txtIndi.BackColor = Color.Orange;
            }
            else if (BMI < 40)
            {                                                          // Weight: 129, height:1.8
                txtStatus.Text = "Obesity Class II";
                txtIndi.BackColor = Color.Pink;
            }
            else
            {                                                         // Weight: 102, height:1.6
                txtStatus.Text = "Obesity Class III";
                txtIndi.BackColor = Color.Brown;
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtHeight.Clear();
            txtBMI.Clear();
            txtStatus.Clear();
            // Reset the background color of the indicator box
            txtIndi.BackColor = Color.White; // Resets to the default background color
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

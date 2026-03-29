using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Assignment
{
    public partial class Form2 : Form
    {

        string Name;
        string address;
        string contactnumber;
        string age;
        string gender;
        string bloodgroup;
        string anymajor;
        string patientid;

        public Form2()
        {
            InitializeComponent();

            // Remove minimize and close buttons
            this.ControlBox = false; // Removes both minimize, maximize, and close buttons.
            this.MinimizeBox = false; // Removes only minimize button if you want to keep others
            this.FormBorderStyle = FormBorderStyle.None; // Remove title bar and form border
            this.MaximizeBox = false; // Removes only maximize button.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Get the data from textboxes (assuming you have them on the first form)
            string name = txtName.Text;
            string address = txtAddress.Text;
            string contactNumber = txtContactNumber.Text;
            string age = txtAge.Text;
            string bloodGroup = txtBlood.Text;
            string patientID = txtPatientID.Text;

            // Get selected value from ComboBox
            string gender = cmbGender.SelectedItem.ToString(); // Assuming the ComboBox always has a valid selection

            // Ensure a RadioButton is selected
            string majorDiseases = string.Empty;
            if (rbtnYes.Checked)
            {
                majorDiseases = "Yes";
            }
            else if (rbtnNo.Checked)
            {
                majorDiseases = "No";
            }
            else
            {
                MessageBox.Show("Please selecet whether the patient has sufferef any major disease");
            }




            // Create an instance of the SummaryForm, passing the data
            Summary frm = new Summary(name, address, contactNumber, age, bloodGroup, patientID, gender, majorDiseases);

            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
            panel1.Controls.Add(frm);
            panel1.Visible = true;


















        }

    }
}

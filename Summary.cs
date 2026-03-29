using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Assignment
{
    public partial class Summary : Form
    {
        public Summary(string name, string address, string contactNumber, string age, string bloodGroup, string patientID, string gender, string majorDiseases)
        {
            InitializeComponent();
            // Remove minimize and close buttons
            this.ControlBox = false; // Removes both minimize, maximize, and close buttons.
            this.MinimizeBox = false; // Removes only minimize button if you want to keep others
            this.FormBorderStyle = FormBorderStyle.None; // Remove title bar and form border
            this.MaximizeBox = false; // Removes only maximize button.

            // Set the labels to display the passed data
            lblName.Text = name;
            lblAddress.Text = address;
            lblContact.Text = contactNumber;
            lblAge.Text = age;
            lblBlood.Text = bloodGroup;
            lblID.Text = patientID;
            lblGender.Text = gender;
            lblAny.Text = majorDiseases;



        }

        private void Summary_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

           


        }
    }
}


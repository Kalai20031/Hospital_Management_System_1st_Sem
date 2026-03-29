using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            lblArrow1.ForeColor = System.Drawing.Color.Red;
            lblArrow2.ForeColor = System.Drawing.Color.Black;
            lblArrow3.ForeColor = System.Drawing.Color.Black;
            lblArrow4.ForeColor = System.Drawing.Color.Black;
            lblArrow5.ForeColor = System.Drawing.Color.Black;
            lblArrow6.ForeColor = System.Drawing.Color.Black;

            Form frm = new Form2();
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

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            lblArrow2.ForeColor = System.Drawing.Color.Red;
            lblArrow1.ForeColor = System.Drawing.Color.Black;
            lblArrow3.ForeColor = System.Drawing.Color.Black;
            lblArrow4.ForeColor = System.Drawing.Color.Black;
            lblArrow5.ForeColor = System.Drawing.Color.Black;


            Form frm = new Form3();
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
            panel1.Controls.Add(frm);
            panel1.Controls.Add(frm);
            panel1.Visible = true;



        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            lblArrow3.ForeColor = System.Drawing.Color.Red;
            lblArrow2.ForeColor = System.Drawing.Color.Black;
            lblArrow1.ForeColor = System.Drawing.Color.Black;
            lblArrow4.ForeColor = System.Drawing.Color.Black;
            lblArrow5.ForeColor = System.Drawing.Color.Black;
            lblArrow6.ForeColor = System.Drawing.Color.Black;

            Form frm = new Form4();
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
            panel1.Controls.Add(frm);



        }

        private void btnsomething1_Click(object sender, EventArgs e)
        {
            lblArrow4.ForeColor = System.Drawing.Color.Red;
            lblArrow3.ForeColor = System.Drawing.Color.Black;
            lblArrow2.ForeColor = System.Drawing.Color.Black;
            lblArrow1.ForeColor = System.Drawing.Color.Black;
            lblArrow5.ForeColor = System.Drawing.Color.Black;
            lblArrow6.ForeColor = System.Drawing.Color.Black;

            Form frm = new Form5();
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
            panel1.Controls.Add(frm);



        }






        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblArrow2_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {



        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIndi_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {


        }

        private void btnsee_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            lblArrow5.ForeColor = System.Drawing.Color.Red;
            lblArrow3.ForeColor = System.Drawing.Color.Black;
            lblArrow2.ForeColor = System.Drawing.Color.Black;
            lblArrow1.ForeColor = System.Drawing.Color.Black;
            lblArrow4.ForeColor = System.Drawing.Color.Black;
            lblArrow6.ForeColor = System.Drawing.Color.Black;

            Form frm = new Form6();
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
            panel1.Controls.Add(frm);




        }

        private void btnClick_Click(object sender, EventArgs e)
        {

        }



        private void btngoback_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClick_Click_1(object sender, EventArgs e)
        {

        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnHydration_Click(object sender, EventArgs e)
        {
            lblArrow6.ForeColor = System.Drawing.Color.Red;
            lblArrow5.ForeColor = System.Drawing.Color.Black;
            lblArrow3.ForeColor = System.Drawing.Color.Black;
            lblArrow2.ForeColor = System.Drawing.Color.Black;
            lblArrow1.ForeColor = System.Drawing.Color.Black;
            lblArrow4.ForeColor = System.Drawing.Color.Black;


            Form frm = new Form7();
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
            panel1.Controls.Add(frm);


        }

        private void lblArrow5_Click(object sender, EventArgs e)
        {

        }

        private void lblArrow4_Click(object sender, EventArgs e)
        {

        }
    }

}

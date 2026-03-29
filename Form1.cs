using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Xml.Linq;
using System.Reflection;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            String UserName = txtUserName.Text;
            String Password = txtPassword.Text;

            if (UserName == "hms" && Password == "pass")
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("You have entered the wrong username or passsword");
            }





            // To topen Dashbaord in the panel of Form1
            Form frm = new Dashboard();
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
            panel1.Controls.Add(frm);



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

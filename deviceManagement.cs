using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Management_App
{
    public partial class deviceManagement : Form
    {

       
        public deviceManagement()
        {
           
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
    
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void username_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            errorMessageLabel.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            var username = "Shoeb";
            var password = "Harris";
            if (usernameTxtBx.Text == String.Empty)
            {
                show_Message_Dialog("Please enter username", true);
                return;
            }
            if(passwordTxtBx.Text == String.Empty)
            {
                show_Message_Dialog("Please enter password", true) ;
                return;
            }
            if (usernameTxtBx.Text.ToUpper() == username.ToUpper() && passwordTxtBx.Text == password)
            {
                this.Hide();
                f2.FormClosed += (s, args) => this.Close();
                f2.Show();
            }
            else
            {
                show_Message_Dialog("Credentials Invalid", true);
            }
         

        }
        public void show_Message_Dialog(string message, bool hasError)
        {

            errorMessageLabel.Text = "";
            if (hasError)
            {
                errorMessageLabel.ForeColor = Color.Red;
                errorMessageLabel.Text = message;
            }
            else
            {
                errorMessageLabel.ForeColor = Color.GreenYellow;
                errorMessageLabel.Text = message;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

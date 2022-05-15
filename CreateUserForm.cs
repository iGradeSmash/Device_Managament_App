using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Managament_App
{
    public partial class CreateUserForm : Form
    {
        Regex validate_emailaddress = email_validation();

        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (validate_emailaddress.IsMatch(textBox1.Text) != true)
            {
                errorMessageLabel.Text = "Invalid Email Address!";
                textBox2.Focus();
                return;
            }
            else
            {
                errorMessageLabel.Text = "";
            }
            

            
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDevicesSave_Click(object sender, EventArgs e)
        {
            if (txtPassword != txtConfirmPassword)
            {
                errorMessageConfirmPassword.Text = "Password and Confirm Password do not match!";
            }
        }
    }
}

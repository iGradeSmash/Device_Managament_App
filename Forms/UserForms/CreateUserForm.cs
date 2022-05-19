using Device_Managament_App.Utility;
using Device_Management_App.Classes;
using System;
using System.Windows.Forms;

namespace Device_Managament_App
{
    public partial class CreateUserForm : Form
    {

        Connection con;

        public CreateUserForm()
        {
            InitializeComponent();
            con = new Connection();
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
            errorMessageLabel.Text = "";

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
            errorMessageConfirmPassword.Text = "";
            mtxtTelephone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            User user = new User();
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.Department = txtDepartment.Text;
            user.Telephone = mtxtTelephone.Text;
            user.Address = txtAddress.Text;
            user.Description = txtDescription.Text;
            user.RoleId = 3;
            user.Name = txtName.Text;

            if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Name!");
                txtName.Focus();
                return;
            }
            else if (txtAddress.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Address!");
                txtAddress.Focus();
                return;
            }
            else if (mtxtTelephone.MaskFull != true)
            {
                MessageBox.Show("Please Enter Telephone!");
                mtxtTelephone.Focus();
                return;
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Email!");
                txtEmail.Focus();
                return;
            }
            else if (txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Password!");
                txtName.Focus();
                return;
            }
            else if (txtConfirmPassword.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Password!");
                txtName.Focus();
                return;
            }
            else if (txtDepartment.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Department!");
                txtName.Focus();
                return;
            }
            else if (txtDescription.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Description!");
                txtName.Focus();
                return;
            }
            else if (UtilManager.Validation.IsValidEmail(txtEmail.Text)!=true)
            {
                MessageBox.Show(UtilManager.Constants.ERROR_MESSAGE_IS_EMAIL_VALID);
                txtEmail.Focus();
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match!");
                txtPassword.Focus();
                return;
            }
            else
            {
                con.CreateUser(user);
            }
        }

        private void mtxtTelephone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

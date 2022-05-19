using Device_Managament_App.Utility;
using Device_Management_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Managament_App.Forms.UserForms
{
    public partial class ChangePasswordForm : Form
    {
        Connection con = new Connection();
       
        private bool _isAdmin;
        public ChangePasswordForm( bool isAdmin)
        {
            _isAdmin = isAdmin;
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            if (!_isAdmin)
            {
                if (txtbxCurrentPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Current Password");
                    txtbxCurrentPassword.Focus();
                    return;
                }else if (txtbxPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter New Password");
                    txtbxPassword.Focus();
                    return;
                }
                else if (txtbxConfirmPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Confirm Password");
                    txtbxConfirmPassword.Focus();
                    return;
                }else if (txtbxConfirmPassword.Text != txtbxPassword.Text)
                {
                    MessageBox.Show("New Password and Confirm Password do not match!");
                    txtbxConfirmPassword.Focus();
                    return;
                }else if (!con.IsValidPassword(UtilManager.Validation.PasswordEncode(txtbxCurrentPassword.Text), UtilManager.Variables.UserID))
                {
                    MessageBox.Show("Current Password is Incorrect");
                    txtbxCurrentPassword.Focus();
                    return;
                }
                else
                {
                    con.UpdateUserPassword(UtilManager.Validation.PasswordEncode(txtbxPassword.Text), UtilManager.Variables.UserID);
                }
            }
            else
            {
                if (txtbxPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter New Password");
                    txtbxPassword.Focus();
                    return;
                }
                else if (txtbxConfirmPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Confirm Password");
                    txtbxConfirmPassword.Focus();
                    return;
                }
                else if (txtbxConfirmPassword.Text != txtbxPassword.Text)
                {
                    MessageBox.Show("New Password and Confirm Password do not match!");
                    txtbxConfirmPassword.Focus();
                    return;
                }
                else
                {
                    con.UpdateUserPassword(UtilManager.Validation.PasswordEncode(txtbxPassword.Text), UtilManager.Variables.PasswordChangeId);
                }
            }
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            if (!_isAdmin)
            {
                lblCurrentPassword.Visible = true;
                txtbxCurrentPassword.Visible = true;
            }
        }
    }
}

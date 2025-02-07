﻿using Device_Managament_App;
using Device_Managament_App.Utility;
using Device_Management_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Management_App
{
    public partial class LoginFrom : Form
    {
        Connection conn;


        public LoginFrom()
        {
           
            InitializeComponent();
            conn = new Connection();

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
            
            AvailableDevicesForm f2 = new AvailableDevicesForm();


            if (usernameTxtBx.Text == String.Empty)
            {
                show_Message_Dialog("Please enter username", true);
                usernameTxtBx.Focus();
                return;
            }else if (UtilManager.Validation.IsValidEmail(usernameTxtBx.Text)!=true){

                show_Message_Dialog(UtilManager.Constants.ERROR_MESSAGE_IS_EMAIL_VALID, true);
                usernameTxtBx.Focus();
                return;
            }
            else if (passwordTxtBx.Text == String.Empty)
            {
                show_Message_Dialog("Please enter password", true);
                passwordTxtBx.Focus();
                return;
            }
            
           conn.GetUserID(usernameTxtBx.Text, UtilManager.Validation.PasswordEncode(passwordTxtBx.Text));

            if (UtilManager.Variables.UserID > 0)
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

        private void usernameTxtBx_TextChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
        }

        private void passwordTxtBx_TextChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            this.Hide();
            createUserForm.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string command = $"mailto:{linkLabel1.Text}?subject=Support Request";
            Process.Start(command);
        }
    }
}

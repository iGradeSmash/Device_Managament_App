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
    public partial class ModifyUserForm : Form
    {
        private int Id;
        Connection con;
        public ModifyUserForm()
        {
            InitializeComponent();
            con = new Connection();
        }

        private void ModifyUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDbSetMain.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter2.Fill(this.usersDbSetMain.Users);
            // TODO: This line of code loads data into the 'roleDbSet.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.roleDbSet.Role);
            // TODO: This line of code loads data into the 'users._Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.users._Users);
            // TODO: This line of code loads data into the 'device_Management_dbDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.device_Management_dbDataSet1.Users);

            for (var i = 0; i < dgvUsers.RowCount; i++)
            {
                if ((int)dgvUsers.Rows[i].Cells[1].Value == 1)
                {
                    dgvUsers.Rows[i].Cells[8].Value = "Administrator";
                }
                else if ((int)dgvUsers.Rows[i].Cells[1].Value == 2)
                {
                    dgvUsers.Rows[i].Cells[8].Value = "Technician";
                }
                else if ((int)dgvUsers.Rows[i].Cells[1].Value == 3)
                {
                    dgvUsers.Rows[i].Cells[8].Value = "Teacher";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDevicesSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.Department = txtDepartment.Text;
            user.Telephone = mtbxPhone.Text;
            user.Address = txtAddress.Text;
            user.Description = txtDescription.Text;
            user.RoleId = (int)cmbxRole.SelectedValue;
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
            else if (mtbxPhone.MaskFull != true)
            {
                MessageBox.Show("Please Enter Telephone!");
                mtbxPhone.Focus();
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
            else if (UtilManager.Validation.IsValidEmail(txtEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!");
                txtEmail.Focus();
                return;
            }
            else
            {
                con.CreateUser(user);
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            mtbxPhone.Text = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDepartment.Text = dgvUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDescription.Text = dgvUsers.Rows[e.RowIndex].Cells[7].Value.ToString();

            if ((int)dgvUsers.Rows[e.RowIndex].Cells[1].Value == 1)
            {
                dgvUsers.Rows[e.RowIndex].Cells[8].Value = "Administrator";
            }
            else if ((int)dgvUsers.Rows[e.RowIndex].Cells[1].Value == 2)
            {
                dgvUsers.Rows[e.RowIndex].Cells[8].Value = "Technician";
            }
            else if ((int)dgvUsers.Rows[e.RowIndex].Cells[1].Value == 3)
            {
                dgvUsers.Rows[e.RowIndex].Cells[8].Value = "Teacher";
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = txtEmail.Text;
            user.Department = txtDepartment.Text;
            user.Telephone = mtbxPhone.Text;
            user.Address = txtAddress.Text;
            user.Description = txtDescription.Text;
            user.RoleId = (int)cmbxRole.SelectedValue;
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
            else if (mtbxPhone.MaskFull != true)
            {
                MessageBox.Show("Please Enter Telephone!");
                mtbxPhone.Focus();
                return;
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Email!");
                txtEmail.Focus();
                return;
            }
            else if (txtPassword.Text != String.Empty)
            {
                user.Password = txtPassword.Text;
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
            else if (UtilManager.Validation.IsValidEmail(txtEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!");
                txtEmail.Focus();
                return;
            }
            else
            {
                con.UpdateUser(user);
                con.GetAllUsers(dgvUsers);
            }
        }
    }
}

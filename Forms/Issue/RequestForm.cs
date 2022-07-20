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

namespace Device_Managament_App
{
    public partial class RequestForm : Form
    {
        Connection connection = new Connection();
        private int deviceId = 0;
        public RequestForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'device_Management_dbDataSet.Devices' table. You can move, or remove it, as needed.
            this.devicesTableAdapter.Fill(this.device_Management_dbDataSet.Devices);
            LoadData();
            txtbxDescription.Text = UtilManager.Variables.Description;
            txtbxDepartment.Text = UtilManager.Variables.Department;
            txtbxName.Text = UtilManager.Variables.UserName;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbxRequestorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtbxBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            try
            {
                if (cmbxDevices.SelectedValue == null)
                {
                }
                else
                {
                    deviceId = int.Parse(cmbxDevices.SelectedValue.ToString());
                }
                var device = connection.PopulateRequest(deviceId);
                txtbxBrand.Text = device.Brand;
                txtbxModel.Text = device.Model;
                txtbxType.Text = device.Type;
                txtbxBarcode.Text = device.Barcode;

                if (device.Status == true && device.IsAvailable == true)
                {
                    txtbxStatus.Text = "Available";
                    btnSubmit.Enabled = true;
                }
                else
                {
                    txtbxStatus.Text = "Unavailable";
                    btnSubmit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DeviceManager deviceManager = new  DeviceManager();

            deviceManager.UserId = UtilManager.Variables.UserID;
            deviceManager.DeviceId = deviceId;
            deviceManager.Status = true;
            deviceManager.Brand = txtbxBrand.Text;
            deviceManager.Barcode = txtbxBarcode.Text;
            deviceManager.Model = txtbxModel.Text;
            deviceManager.Type = txtbxType.Text;
            deviceManager.Department = UtilManager.Variables.Department;
            deviceManager.Description = UtilManager.Variables.Description;
            deviceManager.Name = UtilManager.Variables.UserName;
            deviceManager.TransactionType = "Request";
            deviceManager.TransactionDate = dtTransactionDate.Value;

            connection.SubmitRequest(deviceManager);
        }

        private void dtTransactionDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

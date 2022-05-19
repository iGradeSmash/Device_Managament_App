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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                LoadData();

            }catch(Exception ex)
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
            var id = 0;
            try
            {
                if (cmbxDevices.SelectedValue == null)
                {
                }
                else
                {
                    id = int.Parse(cmbxDevices.SelectedValue.ToString());
                }
                var device = connection.PopulateRequest(id);
                txtbxBrand.Text = device.Brand;
                txtbxModel.Text = device.Model;
                txtbxType.Text = device.Type;
                txtbxBarcode.Text = device.Barcode;
              
                if(device.Status == true)
                {
                    txtbxStatus.Text = "Available";
                }
                else
                {
                    txtbxStatus.Text = "unavailable";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}

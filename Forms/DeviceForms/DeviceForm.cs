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
    public partial class DeviceForm : Form
    {
        private readonly Connection con;
        private int Id;
        public DeviceForm()
        {
            InitializeComponent();
            con = new Connection();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'all_Devices_DataSet.Devices' table. You can move, or remove it, as needed.
            this.devicesTableAdapter1.Fill(this.all_Devices_DataSet.Devices);
            // TODO: This line of code loads data into the 'device_Management_dbDataSet1.DeviceTypes' table. You can move, or remove it, as needed.
            this.deviceTypesTableAdapter.Fill(this.device_Management_dbDataSet1.DeviceTypes);
            // TODO: This line of code loads data into the 'device_Management_dbDataSet.Devices' table. You can move, or remove it, as needed.
            this.devicesTableAdapter.Fill(this.device_Management_dbDataSet.Devices);

        }

        private void btnDevicesFrom_Click(object sender, EventArgs e)
        {
            Devices devices = new Devices();
            devices.Description = txtDescription.Text;
            devices.Model = txtModel.Text;
            devices.Barcode = txtBarcode.Text;
            devices.Brand = txtBrand.Text;
            devices.Type = cmbxType.SelectedValue.ToString();
            devices.Status = chkbxStatus.Checked;
            devices.IsAvailable = chbxIsFunctional.Checked;

            con.SaveDeviceData(devices);
            con.GetDeviceData(dgvDevices);
            clear();
        }

        private void clear()
        {
            txtBarcode.Text = "";
            txtModel.Text = "";
            txtBrand.Text = "";
            txtDescription.Text = "";
        }

        private void dgvDevices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dgvDevices.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDescription.Text = dgvDevices.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbxType.Text = dgvDevices.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBrand.Text  = dgvDevices.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtModel.Text = dgvDevices.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBarcode.Text = dgvDevices.Rows[e.RowIndex].Cells[5].Value.ToString();
            chkbxStatus.Checked = (bool)dgvDevices.Rows[e.RowIndex].Cells[6].Value;
            chbxIsFunctional.Checked = (bool)dgvDevices.Rows[e.RowIndex].Cells[7].Value; 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Devices devices = new Devices();
            devices.Id = Id;
            devices.Status = chbxIsFunctional.Checked;
            devices.IsAvailable = chkbxStatus.Checked;
            devices.Description = txtDescription.Text;
            devices.Brand = txtBrand.Text;
            devices.Barcode = txtBarcode.Text;
            devices.Model = txtModel.Text;
            devices.Type = cmbxType.SelectedValue.ToString();

            con.UpdateDeviceData(devices);
            con.GetDeviceData(dgvDevices);
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DeviceForm.ActiveForm.Close();
        }

        private void dgvDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chbxIsFunctional_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvDevices_DataMemberChanged(object sender, EventArgs e)
        {
            con.GetDeviceData(dgvDevices);
        }
    }
}

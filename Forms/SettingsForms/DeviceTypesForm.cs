using Device_Managament_App.Classes;
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

namespace Device_Managament_App.Forms.SettingsForms
{
    public partial class DeviceTypesForm : Form
    {
        private Connection conn = new Connection();
        private int Id = 0;

        public DeviceTypesForm()
        {
            InitializeComponent();
        }

        private void DeviceTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'device_Management_dbDataSet1.DeviceTypes' table. You can move, or remove it, as needed.
            this.deviceTypesTableAdapter.Fill(this.device_Management_dbDataSet1.DeviceTypes);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DeviceTypesModel dType = new DeviceTypesModel
            {
                DeviceType = txtDeviceType.Text
            };

            if(txtDeviceType.Text == String.Empty)
            {
                MessageBox.Show("Enter Device Type");
                txtDeviceType.Focus();
                return;
            }
            conn.SaveDeviceType(dType);
            conn.GetAllDeviceTypes(dgvDeviceTypes);
            ClearData();
        }
        public void ClearData()
        {
            txtDeviceType.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeviceTypesModel deviceTypes = new DeviceTypesModel
            {
                Id = Id,
                DeviceType = txtDeviceType.Text
            };
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if(Id != 0)
            {
               if(dialogResult == DialogResult.Yes)
                {
                    conn.DeleteDeviceType(deviceTypes);
                    conn.GetAllDeviceTypes(dgvDeviceTypes);
                    ClearData();
                }
               btnSave.Enabled = true;
                btnDelete.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Select a Type!");
                return;
            }
        }

        private void dgvDeviceTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            Id = int.Parse(dgvDeviceTypes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDeviceType.Text = dgvDeviceTypes.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}

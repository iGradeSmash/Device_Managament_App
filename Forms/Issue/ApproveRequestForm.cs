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

namespace Device_Managament_App.Forms.Issue
{
    public partial class ApproveRequestForm : Form
    {
        private string title = "";
        private string body = "";
        private int deviceManagerId = 0;
        private int deviceId = 0;
        private int borrowerId = 0;
     
        DeviceManager deviceManager;
        Connection connection;

        public ApproveRequestForm()
        {
            InitializeComponent();
        }

        private void ApproveRequestForm_Load(object sender, EventArgs e)
        {
            connection = new Connection();
            // TODO: This line of code loads data into the 'device_Manager_DbSet.Device_Manager' table. You can move, or remove it, as needed.
            connection.LoadHistory(dgvApproveRequest);

        }

        private void dgvApproveRequest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            deviceManagerId = int.Parse(dgvApproveRequest.Rows[e.RowIndex].Cells[0].Value.ToString());
            borrowerId = int.Parse(dgvApproveRequest.Rows[e.RowIndex].Cells[1].Value.ToString());
            deviceId = int.Parse(dgvApproveRequest.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtbxName.Text = dgvApproveRequest.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbxDepartment.Text = dgvApproveRequest.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtbxDescription.Text = dgvApproveRequest.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtbxBrand.Text = dgvApproveRequest.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtbxModel.Text = dgvApproveRequest.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtbxType.Text = dgvApproveRequest.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtbxBarcode.Text = dgvApproveRequest.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtbxDate.Text = dgvApproveRequest.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            deviceManager = new DeviceManager();
            connection = new Connection();

            deviceManager.Id = deviceManagerId;
            deviceManager.DeviceId = deviceId;
            deviceManager.UserId = borrowerId;
            deviceManager.TransactionType = "Approved";

            title = "Approve Request";
            body = "Are you sure want approve this request?";

            DialogResult dialogResult = MessageBox.Show(body,title, MessageBoxButtons.YesNo);

            if (IsEmptyField())
            {
                return;
            }
            else
            {
                if (dialogResult == DialogResult.Yes)
                {
                    connection.UpdateDeviceManagerRequest(deviceManager.Id, false, deviceManager.UserId,deviceManager.DeviceId, deviceManager.TransactionType, true, UtilManager.Variables.UserID);
                    connection.LoadHistory(dgvApproveRequest);
                    ClearData();
                }
                else
                {
                    return;
                }
            }
           

        }
        private void btnDeny_Click(object sender, EventArgs e)
        {
            deviceManager = new DeviceManager();
            connection = new Connection();

            deviceManager.Id = deviceManagerId;
            deviceManager.DeviceId = deviceId;
            deviceManager.UserId = borrowerId;
            deviceManager.TransactionType = "Denied";

            title = "Deny Request";
            body = "Are you sure want Deny this request?";

            DialogResult dialogResult = MessageBox.Show(body, title, MessageBoxButtons.YesNo);

            if (IsEmptyField())
            {
                return;
            }
            else
            {
                if (dialogResult == DialogResult.Yes)
                {
                    connection.UpdateDeviceManagerRequest(deviceManager.Id, true, deviceManager.UserId, deviceManager.DeviceId, deviceManager.TransactionType, false, UtilManager.Variables.UserID);
                    connection.LoadHistory(dgvApproveRequest);
                    ClearData();
                }
                else
                {
                    return;
                }
            }
        }
        public bool IsEmptyField()
        {
            if(txtbxName.Text == String.Empty)
            {
                MessageBox.Show("Please select a request");
                return true;
            }
            return false;
        }
        public void ClearData()
        {
            txtbxBarcode.Text = "";
            txtbxBrand.Text = "";
            txtbxDate.Text = "";
            txtbxDepartment.Text = "";
            txtbxDescription.Text = "";
            txtbxModel.Text = "";
            txtbxName.Text = "";
            txtbxType.Text = "";
        }

       
    }
}

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Device_Managament_App;
using Device_Managament_App.Forms.Issue;
using Device_Managament_App.Forms.ReportForms;
using Device_Managament_App.Forms.SettingsForms;
using Device_Managament_App.Forms.UserForms;
using Device_Managament_App.Utility;
using Device_Management_App.Classes;

namespace Device_Management_App
{
    public partial class AvailableDevicesForm : Form
    {
     
        private Connection conn;
        
        public AvailableDevicesForm()
        {
      
            InitializeComponent();
            conn = new Connection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'device_Management_dbDataSet1.DeviceTypes' table. You can move, or remove it, as needed.
            //this.deviceTypesTableAdapter.Fill(this.device_Management_dbDataSet1.DeviceTypes);
            // TODO: This line of code loads data into the 'device_Management_dbDataSet.Devices' table. You can move, or remove it, as needed.
           // this.devicesTableAdapter.Fill(this.device_Management_dbDataSet.Devices);
            conn.GetAvailableDeviceData(dgvAvailableDevices);

            if (UtilManager.Variables.RoleId == 1)
            {
                tsSettings.Enabled = true;
                tsSettings.Visible = true;
                btnReports.Enabled = true;
                btnReports.Visible = true;
                btnUsers.Enabled = true;
                btnUsers.Visible = true;
                btnDevicesFrom.Enabled = true;
                btnDevicesFrom.Visible=true;
                lblUser.Text = UtilManager.Variables.UserName.ToString()+", Administrator";
            }
            else if (UtilManager.Variables.RoleId == 2)
            {
                btnReports.Enabled = true;
                btnReports.Visible = true;
                btnDevicesFrom.Enabled = true;
                btnDevicesFrom.Visible = true;
                lblUser.Text = UtilManager.Variables.UserName.ToString() + ", Technician";
            }
            else
            {
                lblUser.Text = UtilManager.Variables.UserName.ToString() + ", Teacher";
            }

        }
        public void sideMenuPanel_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideMenuPanel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "All Devices";
            conn.GetAllData(dgvAvailableDevices);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState= FormWindowState.Normal;
                return;
            }
                this.WindowState= FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Users";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Reports";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void mainLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpAdd_Click(object sender, EventArgs e)
        {

        }

        private void dbDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxDeviceName_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void cbxStatus_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_ClickAsync(object sender, EventArgs e)
        {
            Devices devices = new Devices();

            
            MessageBox.Show(devices.Description);
            conn.SaveDeviceData(devices);
        }
    

        private void tbView_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Search(txtSearch.Text,cmbxSearchBy.Text,"Devices" ,dgvAvailableDevices);
            lblSearching.Text = cmbxSearchBy.Text;
        }

        private void dgvAvailableDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UtilManager.SystemMessages.WarningMessage(UtilManager.Constants.APPLICATION_CLOSE_WARNING_MESSAGE_CONFIRM_EXIT_TITLE, UtilManager.Constants.APPLICATION_CLOSE_WARNING_MESSAGE_CONFIRM_EXIT);
        }

        private void btnDevicesFrom_Click(object sender, EventArgs e)
        {
            DeviceForm deviceForm = new DeviceForm();

            deviceForm.ShowDialog();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            conn.GetAvailableDeviceData(dgvAvailableDevices);
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            conn.GetAvailableDeviceData(dgvAvailableDevices);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoanRequestForm lrf = new LoanRequestForm();
            lrf.ShowDialog();
        }

        private void lblLoginAs_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.devicesTableAdapter.FillBy(this.device_Management_dbDataSet.Devices);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ModifyUserForm modyfyUsersForm = new ModifyUserForm();
            modyfyUsersForm.ShowDialog();
        }

        private void file_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UtilManager.SystemMessages.WarningMessage(UtilManager.Constants.APPLICATION_CLOSE_WARNING_MESSAGE_CONFIRM_EXIT_TITLE, UtilManager.Constants.APPLICATION_CLOSE_WARNING_MESSAGE_CONFIRM_EXIT);
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.GetAvailableDeviceData(dgvAvailableDevices);
        }

        private void changePassordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilManager.Variables.PasswordChangeId = UtilManager.Variables.UserID;
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(false);
            changePasswordForm.ShowDialog();
        }

        private void dgvAvailableDevices_DataMemberChanged(object sender, EventArgs e)
        {
            conn.GetAvailableDeviceData(dgvAvailableDevices);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MainReportForm reportForm = new MainReportForm();
            reportForm.ShowDialog();
        }

        private void deviceTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTypesForm deviceTypesForm = new DeviceTypesForm();
            deviceTypesForm.ShowDialog();
        }

        private void tsDeviceTypes_Click(object sender, EventArgs e)
        {
            DeviceTypesForm deviceTypesForm = new DeviceTypesForm();
            deviceTypesForm.ShowDialog();
        }
    }
}

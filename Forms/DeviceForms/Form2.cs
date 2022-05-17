using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Device_Managament_App;
using Device_Managament_App.Forms.UserForms;
using Device_Managament_App.Utility;
using Device_Management_App.Classes;

namespace Device_Management_App
{
    public partial class Form2 : Form
    {
        private string _tableName = "";
        private Connection conn;
        int Id;
        public Form2()
        {
            
            _tableName = "Devices";
      
            InitializeComponent();
            conn = new Connection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'device_Management_dbDataSet1.DeviceTypes' table. You can move, or remove it, as needed.
            this.deviceTypesTableAdapter.Fill(this.device_Management_dbDataSet1.DeviceTypes);
            // TODO: This line of code loads data into the 'device_Management_dbDataSet.Devices' table. You can move, or remove it, as needed.
            this.devicesTableAdapter.Fill(this.device_Management_dbDataSet.Devices);
            
            if (UtilManager.Variables.RoleId == 1)
            {
                btnReports.Enabled = true;
                btnReports.Visible = true;
                btnUsers.Enabled = true;
                btnUsers.Visible = true;
                lblUser.Text = UtilManager.Variables.UserName.ToString()+", Administrator";
            }
            else if (UtilManager.Variables.RoleId == 2)
            {
                btnReports.Enabled = true;
                btnReports.Visible = true;
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
            saveData();
        }
        public async Task saveData()
        {
       
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
            Application.Exit();
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
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ModifyUserForm modyfyUsersForm = new ModifyUserForm();
            modyfyUsersForm.ShowDialog();
        }
    }
}

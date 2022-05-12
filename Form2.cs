using System;
using System.Windows.Forms;
using Device_Management_App.Classes;

namespace Device_Management_App
{
    public partial class Form2 : Form
    {
        private string _tableName = "";
        private Connection conn = new Connection();

        public Form2()
        {
            
            _tableName = "Devices";
           
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'device_Management_dbDataSet1.DeviceTypes' table. You can move, or remove it, as needed.
            this.deviceTypesTableAdapter.Fill(this.device_Management_dbDataSet1.DeviceTypes);
            // TODO: This line of code loads data into the 'device_Management_dbDataSet.Devices' table. You can move, or remove it, as needed.
            this.devicesTableAdapter.Fill(this.device_Management_dbDataSet.Devices);

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
            conn.GetAllData(dbDataGrid, _tableName);

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
            if (cbxStatus.Checked)
            {
                cbxStatus.Text = "Active";
            }
            else
            {
                cbxStatus.Text = "Inactive";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Devices devices = new Devices();

            devices.Status = cbxStatus.Checked;
            devices.Model = tbxDeviceModel.Text;
            devices.Brand = tbxDeviceBrand.Text;
            devices.Description = tbxDeviceName.Text;
            devices.Type = cbxDeviceType.SelectedValue.ToString();

            MessageBox.Show(devices.Description);
            conn.SaveDeviceData(devices);
        }
    }
}

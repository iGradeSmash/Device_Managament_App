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
    public partial class ViewHistoryForm : Form
    {
        Connection con = new Connection();
        public ViewHistoryForm()
        {
            InitializeComponent();
        }

        private void ViewHistoryForm_Load(object sender, EventArgs e)
        {
          con.LoadHistory(dgvMyHistory, UtilManager.Variables.UserID);

        }

        private void dgvMyHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

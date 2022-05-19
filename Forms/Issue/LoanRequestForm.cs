using Device_Managament_App.Utility;
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
    public partial class LoanRequestForm : Form
    {
        public LoanRequestForm()
        {
            InitializeComponent();
        }

        private void newMDIChildView_Click(object sender, EventArgs e)
        {
            RequestForm request = new RequestForm();
            request.MdiParent = this;
            request.Show();
        }

        private void LoanRequestForm_Load(object sender, EventArgs e)
        {
            if(UtilManager.Variables.RoleId == 1 || UtilManager.Variables.RoleId == 2)
            {
                tsmReviewRequest.Enabled = true;
                tsmReviewRequest.Visible = true;
            }
        }

        private void newMDIViewHistory_Click(object sender, EventArgs e)
        {
            ViewHistoryForm viewHistoryForm = new ViewHistoryForm();
            viewHistoryForm.MdiParent = this;
            viewHistoryForm.Show();
        }

        private void tsmReviewRequest_Click(object sender, EventArgs e)
        {
            ApproveRequestForm approveRequestForm = new ApproveRequestForm();
            approveRequestForm.MdiParent = this;
            approveRequestForm.Show();
        }
    }
}

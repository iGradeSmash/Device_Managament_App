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
            Issues issue = new Issues();
            issue.MdiParent = this;
            issue.Show();
        }
    }
}

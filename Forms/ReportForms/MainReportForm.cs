using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Managament_App.Forms.ReportForms
{
    public partial class MainReportForm : Form
    {
        public MainReportForm()
        {
            InitializeComponent();
        }

        private void MainReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'device_Management_dbDataSet2.TransactionHistory' table. You can move, or remove it, as needed.
            this.transactionHistoryTableAdapter.Fill(this.device_Management_dbDataSet2.TransactionHistory);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransactions.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvTransactions.Columns.Count + 1; i++)
                    {
                        excel.Cells[1, i] = dgvTransactions.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvTransactions.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvTransactions.Columns.Count; j++)
                        {
                            excel.Cells[i + 2, j + 1] = dgvTransactions.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    excel.Columns.AutoFit();
                    excel.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
               this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

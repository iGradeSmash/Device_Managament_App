namespace Device_Managament_App.Forms.ReportForms
{
    partial class MainReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDevices = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.HistoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approverIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approverRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.device_Management_dbDataSet2 = new Device_Managament_App.Device_Management_dbDataSet2();
            this.transactionHistoryTableAdapter = new Device_Managament_App.Device_Management_dbDataSet2TableAdapters.TransactionHistoryTableAdapter();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeDialog = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Management_dbDataSet2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 461);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lblDevices);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(3, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 66);
            this.panel2.TabIndex = 1;
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevices.ForeColor = System.Drawing.Color.White;
            this.lblDevices.Location = new System.Drawing.Point(55, 23);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(71, 19);
            this.lblDevices.TabIndex = 0;
            this.lblDevices.Text = "DEVICES";
            this.lblDevices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoGenerateColumns = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoryId,
            this.borrowerNameDataGridViewTextBoxColumn,
            this.borrowerDepartmentDataGridViewTextBoxColumn,
            this.borrowerDescriptionDataGridViewTextBoxColumn,
            this.deviceNameDataGridViewTextBoxColumn,
            this.deviceBrandDataGridViewTextBoxColumn,
            this.deviceModelDataGridViewTextBoxColumn,
            this.deviceBarcodeDataGridViewTextBoxColumn,
            this.approverIdDataGridViewTextBoxColumn,
            this.approverNameDataGridViewTextBoxColumn,
            this.approverRoleDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn});
            this.dgvTransactions.DataSource = this.transactionHistoryBindingSource;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.Location = new System.Drawing.Point(0, 91);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(168)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.Size = new System.Drawing.Size(1284, 329);
            this.dgvTransactions.TabIndex = 2;
            // 
            // HistoryId
            // 
            this.HistoryId.DataPropertyName = "HistoryId";
            this.HistoryId.HeaderText = "HistoryId";
            this.HistoryId.Name = "HistoryId";
            this.HistoryId.ReadOnly = true;
            // 
            // borrowerNameDataGridViewTextBoxColumn
            // 
            this.borrowerNameDataGridViewTextBoxColumn.DataPropertyName = "BorrowerName";
            this.borrowerNameDataGridViewTextBoxColumn.HeaderText = "BorrowerName";
            this.borrowerNameDataGridViewTextBoxColumn.Name = "borrowerNameDataGridViewTextBoxColumn";
            this.borrowerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowerDepartmentDataGridViewTextBoxColumn
            // 
            this.borrowerDepartmentDataGridViewTextBoxColumn.DataPropertyName = "BorrowerDepartment";
            this.borrowerDepartmentDataGridViewTextBoxColumn.HeaderText = "BorrowerDepartment";
            this.borrowerDepartmentDataGridViewTextBoxColumn.Name = "borrowerDepartmentDataGridViewTextBoxColumn";
            this.borrowerDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowerDescriptionDataGridViewTextBoxColumn
            // 
            this.borrowerDescriptionDataGridViewTextBoxColumn.DataPropertyName = "BorrowerDescription";
            this.borrowerDescriptionDataGridViewTextBoxColumn.HeaderText = "BorrowerDescription";
            this.borrowerDescriptionDataGridViewTextBoxColumn.Name = "borrowerDescriptionDataGridViewTextBoxColumn";
            this.borrowerDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceNameDataGridViewTextBoxColumn
            // 
            this.deviceNameDataGridViewTextBoxColumn.DataPropertyName = "DeviceName";
            this.deviceNameDataGridViewTextBoxColumn.HeaderText = "DeviceName";
            this.deviceNameDataGridViewTextBoxColumn.Name = "deviceNameDataGridViewTextBoxColumn";
            this.deviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceBrandDataGridViewTextBoxColumn
            // 
            this.deviceBrandDataGridViewTextBoxColumn.DataPropertyName = "DeviceBrand";
            this.deviceBrandDataGridViewTextBoxColumn.HeaderText = "DeviceBrand";
            this.deviceBrandDataGridViewTextBoxColumn.Name = "deviceBrandDataGridViewTextBoxColumn";
            this.deviceBrandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceModelDataGridViewTextBoxColumn
            // 
            this.deviceModelDataGridViewTextBoxColumn.DataPropertyName = "DeviceModel";
            this.deviceModelDataGridViewTextBoxColumn.HeaderText = "DeviceModel";
            this.deviceModelDataGridViewTextBoxColumn.Name = "deviceModelDataGridViewTextBoxColumn";
            this.deviceModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceBarcodeDataGridViewTextBoxColumn
            // 
            this.deviceBarcodeDataGridViewTextBoxColumn.DataPropertyName = "DeviceBarcode";
            this.deviceBarcodeDataGridViewTextBoxColumn.HeaderText = "DeviceBarcode";
            this.deviceBarcodeDataGridViewTextBoxColumn.Name = "deviceBarcodeDataGridViewTextBoxColumn";
            this.deviceBarcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approverIdDataGridViewTextBoxColumn
            // 
            this.approverIdDataGridViewTextBoxColumn.DataPropertyName = "ApproverId";
            this.approverIdDataGridViewTextBoxColumn.HeaderText = "ApproverId";
            this.approverIdDataGridViewTextBoxColumn.Name = "approverIdDataGridViewTextBoxColumn";
            this.approverIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approverNameDataGridViewTextBoxColumn
            // 
            this.approverNameDataGridViewTextBoxColumn.DataPropertyName = "ApproverName";
            this.approverNameDataGridViewTextBoxColumn.HeaderText = "ApproverName";
            this.approverNameDataGridViewTextBoxColumn.Name = "approverNameDataGridViewTextBoxColumn";
            this.approverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approverRoleDataGridViewTextBoxColumn
            // 
            this.approverRoleDataGridViewTextBoxColumn.DataPropertyName = "ApproverRole";
            this.approverRoleDataGridViewTextBoxColumn.HeaderText = "ApproverRole";
            this.approverRoleDataGridViewTextBoxColumn.Name = "approverRoleDataGridViewTextBoxColumn";
            this.approverRoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionHistoryBindingSource
            // 
            this.transactionHistoryBindingSource.DataMember = "TransactionHistory";
            this.transactionHistoryBindingSource.DataSource = this.device_Management_dbDataSet2;
            // 
            // device_Management_dbDataSet2
            // 
            this.device_Management_dbDataSet2.DataSetName = "Device_Management_dbDataSet2";
            this.device_Management_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionHistoryTableAdapter
            // 
            this.transactionHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.btnExport.FlatAppearance.BorderSize = 2;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnExport.Location = new System.Drawing.Point(3, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 60);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.closeDialog);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1284, 41);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1234, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.pictureBox1.Size = new System.Drawing.Size(20, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // closeDialog
            // 
            this.closeDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeDialog.FlatAppearance.BorderSize = 0;
            this.closeDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeDialog.ForeColor = System.Drawing.Color.White;
            this.closeDialog.Location = new System.Drawing.Point(1254, 0);
            this.closeDialog.Name = "closeDialog";
            this.closeDialog.Size = new System.Drawing.Size(30, 41);
            this.closeDialog.TabIndex = 0;
            this.closeDialog.Text = "X";
            this.closeDialog.UseVisualStyleBackColor = true;
            this.closeDialog.Click += new System.EventHandler(this.closeDialog_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnExport);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1284, 91);
            this.panel5.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dgvTransactions);
            this.mainPanel.Controls.Add(this.panel5);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 41);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1284, 420);
            this.mainPanel.TabIndex = 3;
            // 
            // MainReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Device_Managament_App.Properties.Resources.computer_512;
            this.ClientSize = new System.Drawing.Size(1484, 461);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainReportForm";
            this.Text = "Report Center";
            this.Load += new System.EventHandler(this.MainReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Management_dbDataSet2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private Device_Management_dbDataSet2 device_Management_dbDataSet2;
        private System.Windows.Forms.BindingSource transactionHistoryBindingSource;
        private Device_Management_dbDataSet2TableAdapters.TransactionHistoryTableAdapter transactionHistoryTableAdapter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel mainPanel;
    }
}
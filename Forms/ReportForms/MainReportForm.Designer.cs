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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDevices = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.HistoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Management_dbDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(3, 3);
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
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoryId,
            this.borrowerIdDataGridViewTextBoxColumn,
            this.borrowerNameDataGridViewTextBoxColumn,
            this.borrowerDepartmentDataGridViewTextBoxColumn,
            this.borrowerDescriptionDataGridViewTextBoxColumn,
            this.deviceIdDataGridViewTextBoxColumn,
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
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTransactions.Location = new System.Drawing.Point(0, 84);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.Size = new System.Drawing.Size(1284, 377);
            this.dgvTransactions.TabIndex = 2;
            // 
            // HistoryId
            // 
            this.HistoryId.DataPropertyName = "HistoryId";
            this.HistoryId.HeaderText = "HistoryId";
            this.HistoryId.Name = "HistoryId";
            this.HistoryId.ReadOnly = true;
            // 
            // borrowerIdDataGridViewTextBoxColumn
            // 
            this.borrowerIdDataGridViewTextBoxColumn.DataPropertyName = "BorrowerId";
            this.borrowerIdDataGridViewTextBoxColumn.HeaderText = "BorrowerId";
            this.borrowerIdDataGridViewTextBoxColumn.Name = "borrowerIdDataGridViewTextBoxColumn";
            this.borrowerIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // deviceIdDataGridViewTextBoxColumn
            // 
            this.deviceIdDataGridViewTextBoxColumn.DataPropertyName = "DeviceId";
            this.deviceIdDataGridViewTextBoxColumn.HeaderText = "DeviceId";
            this.deviceIdDataGridViewTextBoxColumn.Name = "deviceIdDataGridViewTextBoxColumn";
            this.deviceIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.dgvTransactions);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1284, 461);
            this.panel3.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(6, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 60);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MainReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Device_Managament_App.Properties.Resources.computer_512;
            this.ClientSize = new System.Drawing.Size(1484, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
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
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExport;
    }
}
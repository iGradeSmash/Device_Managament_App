namespace Device_Managament_App.Forms.Issue
{
    partial class ViewHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHistoryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMyHistory = new System.Windows.Forms.DataGridView();
            this.deviceManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.device_Manager_DbSet = new Device_Managament_App.Device_Manager_DbSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.device_ManagerTableAdapter = new Device_Managament_App.Device_Manager_DbSetTableAdapters.Device_ManagerTableAdapter();
            this.device_Management_dbDataSet2 = new Device_Managament_App.Device_Management_dbDataSet2();
            this.transactionHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionHistoryTableAdapter = new Device_Managament_App.Device_Management_dbDataSet2TableAdapters.TransactionHistoryTableAdapter();
            this.BorrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowerDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowerDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Manager_DbSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.device_Management_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMyHistory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 461);
            this.panel3.TabIndex = 2;
            // 
            // dgvMyHistory
            // 
            this.dgvMyHistory.AllowUserToAddRows = false;
            this.dgvMyHistory.AllowUserToDeleteRows = false;
            this.dgvMyHistory.AutoGenerateColumns = false;
            this.dgvMyHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyHistory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMyHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMyHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowerName,
            this.BorrowerDepartment,
            this.BorrowerDescription,
            this.DeviceName,
            this.DeviceBrand,
            this.DeviceModel,
            this.DeviceBarcode,
            this.ApproverName,
            this.TransactionType,
            this.TransactionDate});
            this.dgvMyHistory.DataSource = this.transactionHistoryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(76)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMyHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMyHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyHistory.GridColor = System.Drawing.Color.White;
            this.dgvMyHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvMyHistory.MultiSelect = false;
            this.dgvMyHistory.Name = "dgvMyHistory";
            this.dgvMyHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(76)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMyHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMyHistory.Size = new System.Drawing.Size(984, 461);
            this.dgvMyHistory.TabIndex = 0;
            this.dgvMyHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyHistory_CellContentClick);
            // 
            // deviceManagerBindingSource
            // 
            this.deviceManagerBindingSource.DataMember = "Device_Manager";
            this.deviceManagerBindingSource.DataSource = this.device_Manager_DbSet;
            // 
            // device_Manager_DbSet
            // 
            this.device_Manager_DbSet.DataSetName = "Device_Manager_DbSet";
            this.device_Manager_DbSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(76)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Transaction History";
            // 
            // device_ManagerTableAdapter
            // 
            this.device_ManagerTableAdapter.ClearBeforeFill = true;
            // 
            // device_Management_dbDataSet2
            // 
            this.device_Management_dbDataSet2.DataSetName = "Device_Management_dbDataSet2";
            this.device_Management_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionHistoryBindingSource
            // 
            this.transactionHistoryBindingSource.DataMember = "TransactionHistory";
            this.transactionHistoryBindingSource.DataSource = this.device_Management_dbDataSet2;
            // 
            // transactionHistoryTableAdapter
            // 
            this.transactionHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // BorrowerName
            // 
            this.BorrowerName.DataPropertyName = "BorrowerName";
            this.BorrowerName.HeaderText = "Name";
            this.BorrowerName.Name = "BorrowerName";
            this.BorrowerName.ReadOnly = true;
            // 
            // BorrowerDepartment
            // 
            this.BorrowerDepartment.DataPropertyName = "BorrowerDepartment";
            this.BorrowerDepartment.HeaderText = "Department";
            this.BorrowerDepartment.Name = "BorrowerDepartment";
            this.BorrowerDepartment.ReadOnly = true;
            // 
            // BorrowerDescription
            // 
            this.BorrowerDescription.DataPropertyName = "BorrowerDescription";
            this.BorrowerDescription.HeaderText = "Description";
            this.BorrowerDescription.Name = "BorrowerDescription";
            this.BorrowerDescription.ReadOnly = true;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "Device";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            // 
            // DeviceBrand
            // 
            this.DeviceBrand.DataPropertyName = "DeviceBrand";
            this.DeviceBrand.HeaderText = "Brand";
            this.DeviceBrand.Name = "DeviceBrand";
            this.DeviceBrand.ReadOnly = true;
            // 
            // DeviceModel
            // 
            this.DeviceModel.DataPropertyName = "DeviceModel";
            this.DeviceModel.HeaderText = "Model";
            this.DeviceModel.Name = "DeviceModel";
            this.DeviceModel.ReadOnly = true;
            // 
            // DeviceBarcode
            // 
            this.DeviceBarcode.DataPropertyName = "DeviceBarcode";
            this.DeviceBarcode.HeaderText = "Barcode";
            this.DeviceBarcode.Name = "DeviceBarcode";
            this.DeviceBarcode.ReadOnly = true;
            // 
            // ApproverName
            // 
            this.ApproverName.DataPropertyName = "ApproverName";
            this.ApproverName.HeaderText = "Approver";
            this.ApproverName.Name = "ApproverName";
            this.ApproverName.ReadOnly = true;
            // 
            // TransactionType
            // 
            this.TransactionType.DataPropertyName = "TransactionType";
            this.TransactionType.HeaderText = "Action";
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            // 
            // TransactionDate
            // 
            this.TransactionDate.DataPropertyName = "TransactionDate";
            this.TransactionDate.HeaderText = "Date";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            // 
            // ViewHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewHistoryForm";
            this.Text = "My Transaction History";
            this.Load += new System.EventHandler(this.ViewHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Manager_DbSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.device_Management_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMyHistory;
        private Device_Manager_DbSet device_Manager_DbSet;
        private System.Windows.Forms.BindingSource deviceManagerBindingSource;
        private Device_Manager_DbSetTableAdapters.Device_ManagerTableAdapter device_ManagerTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Device_Management_dbDataSet2 device_Management_dbDataSet2;
        private System.Windows.Forms.BindingSource transactionHistoryBindingSource;
        private Device_Management_dbDataSet2TableAdapters.TransactionHistoryTableAdapter transactionHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
    }
}
namespace Device_Managament_App
{
    partial class DeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDeviceDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbxStatus = new System.Windows.Forms.CheckBox();
            this.btnDevicesSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.device_Management_dbDataSet = new Device_Managament_App.Device_Management_dbDataSet();
            this.devicesTableAdapter = new Device_Managament_App.Device_Management_dbDataSetTableAdapters.DevicesTableAdapter();
            this.device_Management_dbDataSet1 = new Device_Managament_App.Device_Management_dbDataSet1();
            this.deviceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceTypesTableAdapter = new Device_Managament_App.Device_Management_dbDataSet1TableAdapters.DeviceTypesTableAdapter();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.deviceTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deviceManagementdbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceTypesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.deviceTypesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbxIsFunctional = new System.Windows.Forms.CheckBox();
            this.devicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.all_Devices_DataSet = new Device_Managament_App.All_Devices_DataSet();
            this.devicesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.devicesTableAdapter1 = new Device_Managament_App.All_Devices_DataSetTableAdapters.DevicesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsAvailable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Management_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Management_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementdbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_Devices_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(78)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(757, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(308, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Device Creation";
            // 
            // lblDeviceDescription
            // 
            this.lblDeviceDescription.AutoSize = true;
            this.lblDeviceDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.lblDeviceDescription.Location = new System.Drawing.Point(60, 62);
            this.lblDeviceDescription.Name = "lblDeviceDescription";
            this.lblDeviceDescription.Size = new System.Drawing.Size(97, 21);
            this.lblDeviceDescription.TabIndex = 1;
            this.lblDeviceDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(212, 62);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(564, 23);
            this.txtDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(60, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(212, 150);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(564, 23);
            this.txtBrand.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(60, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(212, 202);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(564, 23);
            this.txtModel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(60, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(212, 258);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(564, 23);
            this.txtBarcode.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(60, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Barcode";
            // 
            // chkbxStatus
            // 
            this.chkbxStatus.AutoSize = true;
            this.chkbxStatus.Checked = true;
            this.chkbxStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxStatus.Location = new System.Drawing.Point(483, 105);
            this.chkbxStatus.Name = "chkbxStatus";
            this.chkbxStatus.Size = new System.Drawing.Size(77, 24);
            this.chkbxStatus.TabIndex = 12;
            this.chkbxStatus.Text = "Active";
            this.chkbxStatus.UseVisualStyleBackColor = true;
            // 
            // btnDevicesSave
            // 
            this.btnDevicesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(78)))), ((int)(((byte)(245)))));
            this.btnDevicesSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevicesSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnDevicesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevicesSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevicesSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDevicesSave.Location = new System.Drawing.Point(10, 31);
            this.btnDevicesSave.Name = "btnDevicesSave";
            this.btnDevicesSave.Size = new System.Drawing.Size(250, 50);
            this.btnDevicesSave.TabIndex = 13;
            this.btnDevicesSave.Text = "Save";
            this.btnDevicesSave.UseVisualStyleBackColor = false;
            this.btnDevicesSave.Click += new System.EventHandler(this.btnDevicesFrom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUpdate.Location = new System.Drawing.Point(305, 31);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(250, 50);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDevices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 313);
            this.panel2.TabIndex = 15;
            // 
            // dgvDevices
            // 
            this.dgvDevices.AllowUserToAddRows = false;
            this.dgvDevices.AllowUserToDeleteRows = false;
            this.dgvDevices.AutoGenerateColumns = false;
            this.dgvDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.IsAvailable});
            this.dgvDevices.DataSource = this.devicesBindingSource2;
            this.dgvDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevices.Location = new System.Drawing.Point(0, 0);
            this.dgvDevices.Name = "dgvDevices";
            this.dgvDevices.ReadOnly = true;
            this.dgvDevices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(78)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDevices.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevices.Size = new System.Drawing.Size(800, 313);
            this.dgvDevices.TabIndex = 0;
            this.dgvDevices.DataMemberChanged += new System.EventHandler(this.dgvDevices_DataMemberChanged);
            this.dgvDevices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevices_CellContentClick);
            this.dgvDevices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevices_CellDoubleClick);
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            this.devicesBindingSource.DataSource = this.device_Management_dbDataSet;
            // 
            // device_Management_dbDataSet
            // 
            this.device_Management_dbDataSet.DataSetName = "Device_Management_dbDataSet";
            this.device_Management_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // device_Management_dbDataSet1
            // 
            this.device_Management_dbDataSet1.DataSetName = "Device_Management_dbDataSet1";
            this.device_Management_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceTypesBindingSource
            // 
            this.deviceTypesBindingSource.DataMember = "DeviceTypes";
            this.deviceTypesBindingSource.DataSource = this.device_Management_dbDataSet1;
            // 
            // deviceTypesTableAdapter
            // 
            this.deviceTypesTableAdapter.ClearBeforeFill = true;
            // 
            // cmbxType
            // 
            this.cmbxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceTypesBindingSource1, "DeviceTYpes", true));
            this.cmbxType.DataSource = this.deviceTypesBindingSource1;
            this.cmbxType.DisplayMember = "DeviceTYpes";
            this.cmbxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Location = new System.Drawing.Point(212, 108);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(216, 25);
            this.cmbxType.TabIndex = 1;
            this.cmbxType.ValueMember = "DeviceTYpes";
            // 
            // deviceTypesBindingSource1
            // 
            this.deviceTypesBindingSource1.DataMember = "DeviceTypes";
            this.deviceTypesBindingSource1.DataSource = this.deviceManagementdbDataSet1BindingSource;
            // 
            // deviceManagementdbDataSet1BindingSource
            // 
            this.deviceManagementdbDataSet1BindingSource.DataSource = this.device_Management_dbDataSet1;
            this.deviceManagementdbDataSet1BindingSource.Position = 0;
            // 
            // deviceTypesBindingSource3
            // 
            this.deviceTypesBindingSource3.DataMember = "DeviceTypes";
            this.deviceTypesBindingSource3.DataSource = this.deviceManagementdbDataSet1BindingSource;
            // 
            // deviceTypesBindingSource2
            // 
            this.deviceTypesBindingSource2.DataMember = "DeviceTypes";
            this.deviceTypesBindingSource2.DataSource = this.deviceManagementdbDataSet1BindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDevicesSave);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.groupBox1.Location = new System.Drawing.Point(212, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 87);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // chbxIsFunctional
            // 
            this.chbxIsFunctional.AutoSize = true;
            this.chbxIsFunctional.Checked = true;
            this.chbxIsFunctional.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxIsFunctional.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxIsFunctional.Location = new System.Drawing.Point(637, 102);
            this.chbxIsFunctional.Name = "chbxIsFunctional";
            this.chbxIsFunctional.Size = new System.Drawing.Size(103, 24);
            this.chbxIsFunctional.TabIndex = 17;
            this.chbxIsFunctional.Text = "Functional";
            this.chbxIsFunctional.UseVisualStyleBackColor = true;
            this.chbxIsFunctional.CheckedChanged += new System.EventHandler(this.chbxIsFunctional_CheckedChanged);
            // 
            // devicesBindingSource1
            // 
            this.devicesBindingSource1.DataMember = "Devices";
            this.devicesBindingSource1.DataSource = this.device_Management_dbDataSet;
            // 
            // all_Devices_DataSet
            // 
            this.all_Devices_DataSet.DataSetName = "All_Devices_DataSet";
            this.all_Devices_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devicesBindingSource2
            // 
            this.devicesBindingSource2.DataMember = "Devices";
            this.devicesBindingSource2.DataSource = this.all_Devices_DataSet;
            // 
            // devicesTableAdapter1
            // 
            this.devicesTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // IsAvailable
            // 
            this.IsAvailable.DataPropertyName = "IsAvailable";
            this.IsAvailable.HeaderText = "Functional";
            this.IsAvailable.Name = "IsAvailable";
            this.IsAvailable.ReadOnly = true;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 698);
            this.Controls.Add(this.chbxIsFunctional);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbxType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkbxStatus);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDeviceDescription);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceForm";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Management_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Management_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementdbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_Devices_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDeviceDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbxStatus;
        private System.Windows.Forms.Button btnDevicesSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDevices;
        private Device_Management_dbDataSet device_Management_dbDataSet;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private Device_Management_dbDataSetTableAdapters.DevicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.Label label5;
        private Device_Management_dbDataSet1 device_Management_dbDataSet1;
        private System.Windows.Forms.BindingSource deviceTypesBindingSource;
        private Device_Management_dbDataSet1TableAdapters.DeviceTypesTableAdapter deviceTypesTableAdapter;
        private System.Windows.Forms.ComboBox cmbxType;
        private System.Windows.Forms.BindingSource deviceTypesBindingSource1;
        private System.Windows.Forms.BindingSource deviceManagementdbDataSet1BindingSource;
        private System.Windows.Forms.BindingSource deviceTypesBindingSource2;
        private System.Windows.Forms.BindingSource deviceTypesBindingSource3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbxIsFunctional;
        private System.Windows.Forms.BindingSource devicesBindingSource1;
        private All_Devices_DataSet all_Devices_DataSet;
        private System.Windows.Forms.BindingSource devicesBindingSource2;
        private All_Devices_DataSetTableAdapters.DevicesTableAdapter devicesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAvailable;
    }
}
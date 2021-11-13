namespace FLEET_SYSTEM1._0
{
    partial class VehicleMaintenance_Scrn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCompVehicles = new System.Windows.Forms.DataGridView();
            this.txtCompanyVehicles = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSite_GAU = new System.Windows.Forms.Button();
            this.btnSite_KZN = new System.Windows.Forms.Button();
            this.btnSite_CPT = new System.Windows.Forms.Button();
            this.btnSite_LIM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wILDatabaseDataSet = new FLEET_SYSTEM1._0.WILDatabaseDataSet();
            this.vehicleTableAdapter = new FLEET_SYSTEM1._0.WILDatabaseDataSetTableAdapters.VehicleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Vehicles:";
            // 
            // gridCompVehicles
            // 
            this.gridCompVehicles.AllowUserToAddRows = false;
            this.gridCompVehicles.AllowUserToDeleteRows = false;
            this.gridCompVehicles.AutoGenerateColumns = false;
            this.gridCompVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.companyIDDataGridViewTextBoxColumn,
            this.siteIDDataGridViewTextBoxColumn,
            this.cargoTypeIDDataGridViewTextBoxColumn,
            this.vehicleNameDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn});
            this.gridCompVehicles.DataSource = this.vehicleBindingSource;
            this.gridCompVehicles.Location = new System.Drawing.Point(56, 96);
            this.gridCompVehicles.Name = "gridCompVehicles";
            this.gridCompVehicles.ReadOnly = true;
            this.gridCompVehicles.Size = new System.Drawing.Size(703, 389);
            this.gridCompVehicles.TabIndex = 1;
            // 
            // txtCompanyVehicles
            // 
            this.txtCompanyVehicles.Enabled = false;
            this.txtCompanyVehicles.Location = new System.Drawing.Point(190, 56);
            this.txtCompanyVehicles.Name = "txtCompanyVehicles";
            this.txtCompanyVehicles.Size = new System.Drawing.Size(216, 20);
            this.txtCompanyVehicles.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(461, 53);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(117, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show all Vehicles";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSite_GAU
            // 
            this.btnSite_GAU.FlatAppearance.BorderSize = 0;
            this.btnSite_GAU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSite_GAU.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSite_GAU.Location = new System.Drawing.Point(765, 164);
            this.btnSite_GAU.Name = "btnSite_GAU";
            this.btnSite_GAU.Size = new System.Drawing.Size(191, 40);
            this.btnSite_GAU.TabIndex = 4;
            this.btnSite_GAU.Text = "Gauteng";
            this.btnSite_GAU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSite_GAU.UseVisualStyleBackColor = true;
            this.btnSite_GAU.Click += new System.EventHandler(this.btnSite_GAU_Click);
            // 
            // btnSite_KZN
            // 
            this.btnSite_KZN.FlatAppearance.BorderSize = 0;
            this.btnSite_KZN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSite_KZN.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSite_KZN.Location = new System.Drawing.Point(765, 210);
            this.btnSite_KZN.Name = "btnSite_KZN";
            this.btnSite_KZN.Size = new System.Drawing.Size(191, 40);
            this.btnSite_KZN.TabIndex = 5;
            this.btnSite_KZN.Text = "Kwa-Zulu Natal";
            this.btnSite_KZN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSite_KZN.UseVisualStyleBackColor = true;
            this.btnSite_KZN.Click += new System.EventHandler(this.btnSite_KZN_Click);
            // 
            // btnSite_CPT
            // 
            this.btnSite_CPT.FlatAppearance.BorderSize = 0;
            this.btnSite_CPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSite_CPT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSite_CPT.Location = new System.Drawing.Point(765, 256);
            this.btnSite_CPT.Name = "btnSite_CPT";
            this.btnSite_CPT.Size = new System.Drawing.Size(191, 40);
            this.btnSite_CPT.TabIndex = 6;
            this.btnSite_CPT.Text = "Cape Town";
            this.btnSite_CPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSite_CPT.UseVisualStyleBackColor = true;
            this.btnSite_CPT.Click += new System.EventHandler(this.btnSite_CPT_Click);
            // 
            // btnSite_LIM
            // 
            this.btnSite_LIM.FlatAppearance.BorderSize = 0;
            this.btnSite_LIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSite_LIM.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSite_LIM.Location = new System.Drawing.Point(765, 302);
            this.btnSite_LIM.Name = "btnSite_LIM";
            this.btnSite_LIM.Size = new System.Drawing.Size(191, 40);
            this.btnSite_LIM.TabIndex = 7;
            this.btnSite_LIM.Text = "Limpopo";
            this.btnSite_LIM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSite_LIM.UseVisualStyleBackColor = true;
            this.btnSite_LIM.Click += new System.EventHandler(this.btnSite_LIM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter by Site:";
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyIDDataGridViewTextBoxColumn
            // 
            this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "CompanyID";
            this.companyIDDataGridViewTextBoxColumn.HeaderText = "CompanyID";
            this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
            this.companyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siteIDDataGridViewTextBoxColumn
            // 
            this.siteIDDataGridViewTextBoxColumn.DataPropertyName = "SiteID";
            this.siteIDDataGridViewTextBoxColumn.HeaderText = "SiteID";
            this.siteIDDataGridViewTextBoxColumn.Name = "siteIDDataGridViewTextBoxColumn";
            this.siteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoTypeIDDataGridViewTextBoxColumn
            // 
            this.cargoTypeIDDataGridViewTextBoxColumn.DataPropertyName = "CargoTypeID";
            this.cargoTypeIDDataGridViewTextBoxColumn.HeaderText = "CargoTypeID";
            this.cargoTypeIDDataGridViewTextBoxColumn.Name = "cargoTypeIDDataGridViewTextBoxColumn";
            this.cargoTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleNameDataGridViewTextBoxColumn
            // 
            this.vehicleNameDataGridViewTextBoxColumn.DataPropertyName = "VehicleName";
            this.vehicleNameDataGridViewTextBoxColumn.HeaderText = "VehicleName";
            this.vehicleNameDataGridViewTextBoxColumn.Name = "vehicleNameDataGridViewTextBoxColumn";
            this.vehicleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.wILDatabaseDataSet;
            // 
            // wILDatabaseDataSet
            // 
            this.wILDatabaseDataSet.DataSetName = "WILDatabaseDataSet";
            this.wILDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // VehicleMaintenance_Scrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSite_LIM);
            this.Controls.Add(this.btnSite_CPT);
            this.Controls.Add(this.btnSite_KZN);
            this.Controls.Add(this.btnSite_GAU);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtCompanyVehicles);
            this.Controls.Add(this.gridCompVehicles);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VehicleMaintenance_Scrn";
            this.Size = new System.Drawing.Size(959, 587);
            this.Load += new System.EventHandler(this.VehicleMaintenance_Scrn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCompVehicles;
        private System.Windows.Forms.TextBox txtCompanyVehicles;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private WILDatabaseDataSet wILDatabaseDataSet;
        private WILDatabaseDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSite_GAU;
        private System.Windows.Forms.Button btnSite_KZN;
        private System.Windows.Forms.Button btnSite_CPT;
        private System.Windows.Forms.Button btnSite_LIM;
        private System.Windows.Forms.Label label2;
    }
}

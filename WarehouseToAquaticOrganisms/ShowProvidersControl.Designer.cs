namespace WarehouseToAquaticOrganisms
{
    partial class ShowProvidersControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.dataGridViewProviders = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulstatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aquariumDatabaseDataSet = new WarehouseToAquaticOrganisms.AquariumDatabaseDataSet();
            this.providerTableAdapter = new WarehouseToAquaticOrganisms.AquariumDatabaseDataSetTableAdapters.ProviderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "providers";
            // 
            // dataGridViewProviders
            // 
            this.dataGridViewProviders.AllowUserToAddRows = false;
            this.dataGridViewProviders.AllowUserToDeleteRows = false;
            this.dataGridViewProviders.AutoGenerateColumns = false;
            this.dataGridViewProviders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProviders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bulstatDataGridViewTextBoxColumn,
            this.accountpersonDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridViewProviders.DataSource = this.providerBindingSource;
            this.dataGridViewProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProviders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProviders.Name = "dataGridViewProviders";
            this.dataGridViewProviders.ReadOnly = true;
            this.dataGridViewProviders.Size = new System.Drawing.Size(787, 510);
            this.dataGridViewProviders.TabIndex = 1;
            this.dataGridViewProviders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickOnRow);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bulstatDataGridViewTextBoxColumn
            // 
            this.bulstatDataGridViewTextBoxColumn.DataPropertyName = "Bulstat";
            this.bulstatDataGridViewTextBoxColumn.HeaderText = "Bulstat";
            this.bulstatDataGridViewTextBoxColumn.Name = "bulstatDataGridViewTextBoxColumn";
            this.bulstatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountpersonDataGridViewTextBoxColumn
            // 
            this.accountpersonDataGridViewTextBoxColumn.DataPropertyName = "Account_person";
            this.accountpersonDataGridViewTextBoxColumn.HeaderText = "Account_person";
            this.accountpersonDataGridViewTextBoxColumn.Name = "accountpersonDataGridViewTextBoxColumn";
            this.accountpersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.aquariumDatabaseDataSet;
            // 
            // aquariumDatabaseDataSet
            // 
            this.aquariumDatabaseDataSet.DataSetName = "AquariumDatabaseDataSet";
            this.aquariumDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // ShowProvidersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProviders);
            this.Controls.Add(this.label1);
            this.Name = "ShowProvidersControl";
            this.Size = new System.Drawing.Size(787, 510);
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProviders;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulstatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private AquariumDatabaseDataSet aquariumDatabaseDataSet;
        private AquariumDatabaseDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
    }
}

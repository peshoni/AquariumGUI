using System;
using System.Windows.Forms;

namespace WarehouseToAquaticOrganisms
{
    partial class ShowCompaniesControl
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
            this.dataGridViewCompanyes = new System.Windows.Forms.DataGridView();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aquariumDatabaseDataSet = new WarehouseToAquaticOrganisms.AquariumDatabaseDataSet();
            this.companyTableAdapter = new WarehouseToAquaticOrganisms.AquariumDatabaseDataSetTableAdapters.CompanyTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulstatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCompanyes
            // 
            this.dataGridViewCompanyes.AllowUserToAddRows = false;
            this.dataGridViewCompanyes.AutoGenerateColumns = false;
            this.dataGridViewCompanyes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCompanyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanyes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bulstatDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.Account_person});
            this.dataGridViewCompanyes.DataSource = this.companyBindingSource;
            this.dataGridViewCompanyes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompanyes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCompanyes.Name = "dataGridViewCompanyes";
            this.dataGridViewCompanyes.Size = new System.Drawing.Size(781, 557);
            this.dataGridViewCompanyes.TabIndex = 0;
            this.dataGridViewCompanyes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickOnRow);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.aquariumDatabaseDataSet;
            // 
            // aquariumDatabaseDataSet
            // 
            this.aquariumDatabaseDataSet.DataSetName = "AquariumDatabaseDataSet";
            this.aquariumDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
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
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // bulstatDataGridViewTextBoxColumn
            // 
            this.bulstatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bulstatDataGridViewTextBoxColumn.DataPropertyName = "Bulstat";
            this.bulstatDataGridViewTextBoxColumn.HeaderText = "Bulstat";
            this.bulstatDataGridViewTextBoxColumn.Name = "bulstatDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // Account_person
            // 
            this.Account_person.DataPropertyName = "Account_person";
            this.Account_person.HeaderText = "Account_person";
            this.Account_person.Name = "Account_person";
            // 
            // ShowCompaniesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewCompanyes);
            this.Name = "ShowCompaniesControl";
            this.Size = new System.Drawing.Size(781, 557);
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

       


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompanyes;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private AquariumDatabaseDataSet aquariumDatabaseDataSet;
        private AquariumDatabaseDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn accountPersonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bulstatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Account_person;
    }
}

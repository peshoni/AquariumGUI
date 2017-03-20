using System;
using System.Windows.Forms;

namespace AquariumGUI
{
    partial class DataGridForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organism = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMovableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aquariumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aquariumDatabaseDataSet = new AquariumGUI.AquariumDatabaseDataSet();
            this.aquariumTableAdapter = new AquariumGUI.AquariumDatabaseDataSetTableAdapters.AquariumTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Organism,
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.isMovableDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.aquariumBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(712, 546);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickOnRow);
            this.dataGridView2.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.onCellMouseUp);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Organism
            // 
            this.Organism.DataPropertyName = "Organism";
            this.Organism.HeaderText = "Organism";
            this.Organism.Name = "Organism";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // isMovableDataGridViewCheckBoxColumn
            // 
            this.isMovableDataGridViewCheckBoxColumn.DataPropertyName = "IsMovable";
            this.isMovableDataGridViewCheckBoxColumn.HeaderText = "IsMovable";
            this.isMovableDataGridViewCheckBoxColumn.Name = "isMovableDataGridViewCheckBoxColumn";
            // 
            // aquariumBindingSource
            // 
            this.aquariumBindingSource.DataMember = "Aquarium";
            this.aquariumBindingSource.DataSource = this.aquariumDatabaseDataSet;
            // 
            // aquariumDatabaseDataSet
            // 
            this.aquariumDatabaseDataSet.DataSetName = "AquariumDatabaseDataSet";
            this.aquariumDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aquariumTableAdapter
            // 
            this.aquariumTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Fish",
            "Shellfish",
            "Seaweed"});
            this.comboBox1.Location = new System.Drawing.Point(145, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
 
            // 
            // DataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 580);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DataGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DataGridForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hide);
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        } 

        #endregion
        private DataGridView dataGridView2;
        private AquariumDatabaseDataSet aquariumDatabaseDataSet;
        private BindingSource aquariumBindingSource;
        private AquariumDatabaseDataSetTableAdapters.AquariumTableAdapter aquariumTableAdapter;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Organism;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isMovableDataGridViewCheckBoxColumn;
        private ComboBox comboBox1;
    }
}
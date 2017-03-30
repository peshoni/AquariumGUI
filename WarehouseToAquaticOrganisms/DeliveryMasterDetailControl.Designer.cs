using System;
using System.Windows.Forms;

namespace WarehouseToAquaticOrganisms
{
    partial class DeliveryMasterDetailControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMaster = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSaveDelivery = new System.Windows.Forms.Button();
            this._dataGridViewDelivery = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.comboBoxChooseProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainerWithMasterDetails = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDelivery)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWithMasterDetails)).BeginInit();
            this.splitContainerWithMasterDetails.Panel1.SuspendLayout();
            this.splitContainerWithMasterDetails.Panel2.SuspendLayout();
            this.splitContainerWithMasterDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewMaster);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deliveries";
            // 
            // dataGridViewMaster
            // 
            this.dataGridViewMaster.AllowUserToAddRows = false;
            this.dataGridViewMaster.AllowUserToDeleteRows = false;
            this.dataGridViewMaster.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaster.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewMaster.Name = "dataGridViewMaster";
            this.dataGridViewMaster.RowTemplate.ReadOnly = true;
            this.dataGridViewMaster.Size = new System.Drawing.Size(397, 420);
            this.dataGridViewMaster.TabIndex = 0;
            this.dataGridViewMaster.SelectionChanged += new System.EventHandler(this.dataGridViewMaster_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._dataGridViewDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // _dataGridViewDetail
            // 
            this._dataGridViewDetail.AllowUserToAddRows = false;
            this._dataGridViewDetail.AllowUserToDeleteRows = false;
            this._dataGridViewDetail.BackgroundColor = System.Drawing.SystemColors.Window;
            this._dataGridViewDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewDetail.Location = new System.Drawing.Point(3, 16);
            this._dataGridViewDetail.Name = "_dataGridViewDetail";
            this._dataGridViewDetail.RowTemplate.ReadOnly = true;
            this._dataGridViewDetail.Size = new System.Drawing.Size(397, 274);
            this._dataGridViewDetail.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSaveDelivery);
            this.splitContainer1.Panel1.Controls.Add(this._dataGridViewDelivery);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerWithMasterDetails);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1091, 746);
            this.splitContainer1.SplitterDistance = 674;
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonSaveDelivery
            // 
            this.buttonSaveDelivery.Enabled = false;
            this.buttonSaveDelivery.Location = new System.Drawing.Point(517, 561);
            this.buttonSaveDelivery.Name = "buttonSaveDelivery";
            this.buttonSaveDelivery.Size = new System.Drawing.Size(141, 31);
            this.buttonSaveDelivery.TabIndex = 2;
            this.buttonSaveDelivery.Text = "Save";
            this.buttonSaveDelivery.UseVisualStyleBackColor = true;
            this.buttonSaveDelivery.Click += new System.EventHandler(this.buttonSaveDelivery_Click);
            // 
            // _dataGridViewDelivery
            // 
            this._dataGridViewDelivery.BackgroundColor = System.Drawing.SystemColors.Window;
            this._dataGridViewDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewDelivery.GridColor = System.Drawing.SystemColors.Window;
            this._dataGridViewDelivery.Location = new System.Drawing.Point(19, 290);
            this._dataGridViewDelivery.Name = "_dataGridViewDelivery";
            this._dataGridViewDelivery.Size = new System.Drawing.Size(639, 256);
            this._dataGridViewDelivery.TabIndex = 1;
            this._dataGridViewDelivery.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDelivery_RowsAdded);
            this._dataGridViewDelivery.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this._dataGridViewDelivery_RowsRemoved); 
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.propertyGrid1);
            this.groupBox3.Controls.Add(this.comboBoxChooseProvider);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(19, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 260);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Provider";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.AllowDrop = true;
            this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InfoText;
            this.propertyGrid1.CommandsForeColor = System.Drawing.SystemColors.Control;
            this.propertyGrid1.CommandsVisibleIfAvailable = false;
            this.propertyGrid1.DisabledItemForeColor = System.Drawing.SystemColors.Desktop;
            this.propertyGrid1.Enabled = false;
            this.propertyGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propertyGrid1.HelpBorderColor = System.Drawing.SystemColors.Control;
            this.propertyGrid1.HelpForeColor = System.Drawing.SystemColors.Control;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(10, 64);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid1.Size = new System.Drawing.Size(614, 178);
            this.propertyGrid1.TabIndex = 2;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // comboBoxChooseProvider
            // 
            this.comboBoxChooseProvider.FormattingEnabled = true;
            this.comboBoxChooseProvider.Location = new System.Drawing.Point(10, 37);
            this.comboBoxChooseProvider.Name = "comboBoxChooseProvider";
            this.comboBoxChooseProvider.Size = new System.Drawing.Size(251, 21);
            this.comboBoxChooseProvider.TabIndex = 1;
            this.comboBoxChooseProvider.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseProvider_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select";
            // 
            // splitContainerWithMasterDetails
            // 
            this.splitContainerWithMasterDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerWithMasterDetails.Location = new System.Drawing.Point(5, 5);
            this.splitContainerWithMasterDetails.Name = "splitContainerWithMasterDetails";
            this.splitContainerWithMasterDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerWithMasterDetails.Panel1
            // 
            this.splitContainerWithMasterDetails.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainerWithMasterDetails.Panel2
            // 
            this.splitContainerWithMasterDetails.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerWithMasterDetails.Size = new System.Drawing.Size(403, 736);
            this.splitContainerWithMasterDetails.SplitterDistance = 439;
            this.splitContainerWithMasterDetails.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Size = new System.Drawing.Size(1091, 794);
            this.splitContainer3.SplitterDistance = 44;
            this.splitContainer3.TabIndex = 3;
            // 
            // MasterDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer3);
            this.Name = "MasterDetailControl";
            this.Size = new System.Drawing.Size(1091, 794);
            this.Load += new System.EventHandler(this.MasterDetailControl_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDetail)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDelivery)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainerWithMasterDetails.Panel1.ResumeLayout(false);
            this.splitContainerWithMasterDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWithMasterDetails)).EndInit();
            this.splitContainerWithMasterDetails.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMaster;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _dataGridViewDetail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainerWithMasterDetails;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxChooseProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.DataGridView _dataGridViewDelivery;
        private System.Windows.Forms.Button buttonSaveDelivery;
    }
}

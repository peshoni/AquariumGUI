using System;
using System.Windows.Forms;

namespace WarehouseToAquaticOrganisms
{
    partial class SalesMasterDetailControl
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Goldfish");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Swordfish");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Fish", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Crab");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Shellfish", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Seaweed");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Products", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode6});
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.dataGridViewSaleList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelVat = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAvailable = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.propertyGridSelectedClient = new System.Windows.Forms.PropertyGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitMasterDetail = new System.Windows.Forms.SplitContainer();
            this.groupBoxMaster = new System.Windows.Forms.GroupBox();
            this.dataGridViewMaster = new System.Windows.Forms.DataGridView();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMasterDetail)).BeginInit();
            this.splitMasterDetail.Panel1.SuspendLayout();
            this.splitMasterDetail.Panel2.SuspendLayout();
            this.splitMasterDetail.SuspendLayout();
            this.groupBoxMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES CONTROL";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(6, 17);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(56, 13);
            this.labelClientName.TabIndex = 1;
            this.labelClientName.Text = "Client type";
            // 
            // dataGridViewSaleList
            // 
            this.dataGridViewSaleList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleList.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewSaleList.Name = "dataGridViewSaleList";
            this.dataGridViewSaleList.Size = new System.Drawing.Size(483, 263);
            this.dataGridViewSaleList.TabIndex = 3;
            this.dataGridViewSaleList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridViewSaleList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelBase, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelVat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTotal, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(289, 285);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 72);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(101, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(97, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(101, 25);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.MaxLength = 8;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(97, 19);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(101, 48);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.MaxLength = 8;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(97, 19);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(5, 2);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(30, 13);
            this.labelBase.TabIndex = 3;
            this.labelBase.Text = "base";
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(5, 25);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(22, 13);
            this.labelVat.TabIndex = 4;
            this.labelVat.Text = "vat";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(5, 48);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(27, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "total";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(6, 334);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAvailable);
            this.groupBox1.Location = new System.Drawing.Point(0, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 373);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridViewAvailable
            // 
            this.dataGridViewAvailable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAvailable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAvailable.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAvailable.Name = "dataGridViewAvailable";
            this.dataGridViewAvailable.Size = new System.Drawing.Size(311, 354);
            this.dataGridViewAvailable.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1369, 676);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1369, 638);
            this.splitContainer2.SplitterDistance = 320;
            this.splitContainer2.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(16, 33);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Goldfish";
            treeNode1.ToolTipText = "asdasd";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Swordfish";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Fish";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Crab";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Shellfish";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Seaweed";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Products";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(219, 133);
            this.treeView1.TabIndex = 11;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.propertyGridSelectedClient);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel1.Controls.Add(this.maskedTextBox1);
            this.splitContainer3.Panel1.Controls.Add(this.labelClientName);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitMasterDetail);
            this.splitContainer3.Size = new System.Drawing.Size(1045, 638);
            this.splitContainer3.SplitterDistance = 501;
            this.splitContainer3.TabIndex = 11;
            // 
            // propertyGridSelectedClient
            // 
            this.propertyGridSelectedClient.HelpVisible = false;
            this.propertyGridSelectedClient.Location = new System.Drawing.Point(255, 17);
            this.propertyGridSelectedClient.Name = "propertyGridSelectedClient";
            this.propertyGridSelectedClient.Size = new System.Drawing.Size(236, 156);
            this.propertyGridSelectedClient.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSaleList);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Location = new System.Drawing.Point(4, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 364);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(91, 147);
            this.maskedTextBox1.Mask = "00.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ResetOnSpace = false;
            this.maskedTextBox1.Size = new System.Drawing.Size(49, 26);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyEnterPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Profit %";
            // 
            // splitMasterDetail
            // 
            this.splitMasterDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMasterDetail.Location = new System.Drawing.Point(0, 0);
            this.splitMasterDetail.Name = "splitMasterDetail";
            this.splitMasterDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMasterDetail.Panel1
            // 
            this.splitMasterDetail.Panel1.Controls.Add(this.groupBoxMaster);
            // 
            // splitMasterDetail.Panel2
            // 
            this.splitMasterDetail.Panel2.Controls.Add(this.groupBoxDetails);
            this.splitMasterDetail.Size = new System.Drawing.Size(540, 638);
            this.splitMasterDetail.SplitterDistance = 484;
            this.splitMasterDetail.TabIndex = 12;
            // 
            // groupBoxMaster
            // 
            this.groupBoxMaster.Controls.Add(this.dataGridViewMaster);
            this.groupBoxMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMaster.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMaster.Name = "groupBoxMaster";
            this.groupBoxMaster.Size = new System.Drawing.Size(540, 484);
            this.groupBoxMaster.TabIndex = 1;
            this.groupBoxMaster.TabStop = false;
            this.groupBoxMaster.Text = "Sales";
            // 
            // dataGridViewMaster
            // 
            this.dataGridViewMaster.AllowUserToAddRows = false;
            this.dataGridViewMaster.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaster.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewMaster.Name = "dataGridViewMaster";
            this.dataGridViewMaster.Size = new System.Drawing.Size(534, 465);
            this.dataGridViewMaster.TabIndex = 0;
            this.dataGridViewMaster.SelectionChanged += new System.EventHandler(this.dataGridViewMaster_SelectionChanged);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.dataGridViewDetail);
            this.groupBoxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetails.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(540, 150);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.Size = new System.Drawing.Size(534, 131);
            this.dataGridViewDetail.TabIndex = 0;
            // 
            // SalesMasterDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SalesMasterDetailControl";
            this.Size = new System.Drawing.Size(1369, 676);
            this.Load += new System.EventHandler(this.MasterDetailControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailable)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitMasterDetail.Panel1.ResumeLayout(false);
            this.splitMasterDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMasterDetail)).EndInit();
            this.splitMasterDetail.ResumeLayout(false);
            this.groupBoxMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

       




        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.DataGridView dataGridViewSaleList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ContextMenuStrip contextMenuStrip2;
        private Button buttonSave;
        private GroupBox groupBox1;
        private DataGridView dataGridViewAvailable;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label labelBase;
        private Label labelVat;
        private Label labelTotal;
        private GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SplitContainer splitContainer3;
        private SplitContainer splitMasterDetail;
        private GroupBox groupBoxMaster;
        private DataGridView dataGridViewMaster;
        private GroupBox groupBoxDetails;
        private DataGridView dataGridViewDetail;
        private TreeView treeView1;
        private PropertyGrid propertyGridSelectedClient;
    }
}

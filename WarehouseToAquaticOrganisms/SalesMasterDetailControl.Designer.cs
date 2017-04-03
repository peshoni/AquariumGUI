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
            this.splitContainerFooter = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainerSaleAndMaster = new System.Windows.Forms.SplitContainer();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.propertyGridSelectedClient = new System.Windows.Forms.PropertyGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelBullstat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitMasterDetail = new System.Windows.Forms.SplitContainer();
            this.groupBoxMaster = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewMasterCompanies = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewMasterPersons = new System.Windows.Forms.DataGridView();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFooter)).BeginInit();
            this.splitContainerFooter.Panel1.SuspendLayout();
            this.splitContainerFooter.Panel2.SuspendLayout();
            this.splitContainerFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaleAndMaster)).BeginInit();
            this.splitContainerSaleAndMaster.Panel1.SuspendLayout();
            this.splitContainerSaleAndMaster.Panel2.SuspendLayout();
            this.splitContainerSaleAndMaster.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMasterDetail)).BeginInit();
            this.splitMasterDetail.Panel1.SuspendLayout();
            this.splitMasterDetail.Panel2.SuspendLayout();
            this.splitMasterDetail.SuspendLayout();
            this.groupBoxMaster.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasterCompanies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasterPersons)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(548, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
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
            this.dataGridViewSaleList.AllowUserToAddRows = false;
            this.dataGridViewSaleList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleList.Location = new System.Drawing.Point(14, 205);
            this.dataGridViewSaleList.Name = "dataGridViewSaleList";
            this.dataGridViewSaleList.Size = new System.Drawing.Size(751, 246);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(565, 454);
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
            this.labelBase.Size = new System.Drawing.Size(44, 13);
            this.labelBase.TabIndex = 3;
            this.labelBase.Text = "subtotal";
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
            this.buttonSave.Location = new System.Drawing.Point(626, 692);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(153, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAvailable);
            this.groupBox1.Location = new System.Drawing.Point(0, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 309);
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
            this.dataGridViewAvailable.Size = new System.Drawing.Size(184, 290);
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerFooter);
            this.splitContainer1.Size = new System.Drawing.Size(1369, 888);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainerFooter
            // 
            this.splitContainerFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFooter.IsSplitterFixed = true;
            this.splitContainerFooter.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFooter.Name = "splitContainerFooter";
            // 
            // splitContainerFooter.Panel1
            // 
            this.splitContainerFooter.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerFooter.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainerFooter.Panel2
            // 
            this.splitContainerFooter.Panel2.Controls.Add(this.splitContainerSaleAndMaster);
            this.splitContainerFooter.Size = new System.Drawing.Size(1369, 850);
            this.splitContainerFooter.SplitterDistance = 223;
            this.splitContainerFooter.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
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
            this.treeView1.Size = new System.Drawing.Size(223, 850);
            this.treeView1.TabIndex = 11;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainerSaleAndMaster
            // 
            this.splitContainerSaleAndMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSaleAndMaster.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerSaleAndMaster.IsSplitterFixed = true;
            this.splitContainerSaleAndMaster.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSaleAndMaster.Name = "splitContainerSaleAndMaster";
            // 
            // splitContainerSaleAndMaster.Panel1
            // 
            this.splitContainerSaleAndMaster.Panel1.Controls.Add(this.buttonPDF);
            this.splitContainerSaleAndMaster.Panel1.Controls.Add(this.propertyGridSelectedClient);
            this.splitContainerSaleAndMaster.Panel1.Controls.Add(this.buttonSave);
            this.splitContainerSaleAndMaster.Panel1.Controls.Add(this.groupBox2);
            this.splitContainerSaleAndMaster.Panel1.Controls.Add(this.maskedTextBox1);
            this.splitContainerSaleAndMaster.Panel1.Controls.Add(this.labelClientName);
            this.splitContainerSaleAndMaster.Panel1.Controls.Add(this.label2);
            this.splitContainerSaleAndMaster.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainerSaleAndMaster.Panel2
            // 
            this.splitContainerSaleAndMaster.Panel2.Controls.Add(this.splitMasterDetail);
            this.splitContainerSaleAndMaster.Size = new System.Drawing.Size(1142, 850);
            this.splitContainerSaleAndMaster.SplitterDistance = 794;
            this.splitContainerSaleAndMaster.TabIndex = 11;
            // 
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(219, 773);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(75, 23);
            this.buttonPDF.TabIndex = 13;
            this.buttonPDF.Text = "PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // propertyGridSelectedClient
            // 
            this.propertyGridSelectedClient.HelpVisible = false;
            this.propertyGridSelectedClient.Location = new System.Drawing.Point(482, 10);
            this.propertyGridSelectedClient.Name = "propertyGridSelectedClient";
            this.propertyGridSelectedClient.Size = new System.Drawing.Size(98, 51);
            this.propertyGridSelectedClient.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dataGridViewSaleList);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(9, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 574);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.MouseHover += new System.EventHandler(this.groupBox2_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(12, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 180);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receiver";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.62963F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.37037F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelBullstat, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelAddress, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(263, 158);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(1, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(2);
            this.label7.Size = new System.Drawing.Size(261, 30);
            this.label7.TabIndex = 10;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(81, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(2);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(2);
            this.label12.Size = new System.Drawing.Size(179, 28);
            this.label12.TabIndex = 9;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(2);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(2);
            this.label11.Size = new System.Drawing.Size(73, 28);
            this.label11.TabIndex = 8;
            this.label11.Text = " ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBullstat
            // 
            this.labelBullstat.AutoSize = true;
            this.labelBullstat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBullstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBullstat.Location = new System.Drawing.Point(81, 96);
            this.labelBullstat.Margin = new System.Windows.Forms.Padding(2);
            this.labelBullstat.Name = "labelBullstat";
            this.labelBullstat.Padding = new System.Windows.Forms.Padding(2);
            this.labelBullstat.Size = new System.Drawing.Size(179, 26);
            this.labelBullstat.TabIndex = 7;
            this.labelBullstat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(2);
            this.label9.Size = new System.Drawing.Size(73, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Bulstat";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(81, 34);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Padding = new System.Windows.Forms.Padding(2);
            this.labelAddress.Size = new System.Drawing.Size(179, 26);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(81, 3);
            this.labelName.Margin = new System.Windows.Forms.Padding(2);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(2);
            this.labelName.Size = new System.Drawing.Size(179, 26);
            this.labelName.TabIndex = 1;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(737, 9);
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
            this.label2.Location = new System.Drawing.Point(667, 12);
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
            this.splitMasterDetail.Size = new System.Drawing.Size(344, 850);
            this.splitMasterDetail.SplitterDistance = 643;
            this.splitMasterDetail.TabIndex = 12;
            // 
            // groupBoxMaster
            // 
            this.groupBoxMaster.Controls.Add(this.tabControl1);
            this.groupBoxMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMaster.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMaster.Name = "groupBoxMaster";
            this.groupBoxMaster.Size = new System.Drawing.Size(344, 643);
            this.groupBoxMaster.TabIndex = 1;
            this.groupBoxMaster.TabStop = false;
            this.groupBoxMaster.Text = "Sales";
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 624);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = " ";
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewMasterCompanies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Companies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMasterCompanies
            // 
            this.dataGridViewMasterCompanies.AllowUserToAddRows = false;
            this.dataGridViewMasterCompanies.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMasterCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasterCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMasterCompanies.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMasterCompanies.Name = "dataGridViewMasterCompanies";
            this.dataGridViewMasterCompanies.Size = new System.Drawing.Size(324, 592);
            this.dataGridViewMasterCompanies.TabIndex = 0;
            this.dataGridViewMasterCompanies.SelectionChanged += new System.EventHandler(this.dataGridViewMaster_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewMasterPersons);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Persons";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMasterPersons
            // 
            this.dataGridViewMasterPersons.AllowUserToAddRows = false;
            this.dataGridViewMasterPersons.AllowUserToDeleteRows = false;
            this.dataGridViewMasterPersons.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMasterPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasterPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMasterPersons.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMasterPersons.Name = "dataGridViewMasterPersons";
            this.dataGridViewMasterPersons.Size = new System.Drawing.Size(324, 592);
            this.dataGridViewMasterPersons.TabIndex = 0;
            this.dataGridViewMasterPersons.SelectionChanged += new System.EventHandler(this.dataGridViewMaster_SelectionChanged);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.dataGridViewDetail);
            this.groupBoxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetails.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(344, 203);
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
            this.dataGridViewDetail.Size = new System.Drawing.Size(338, 184);
            this.dataGridViewDetail.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SalesMasterDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SalesMasterDetailControl";
            this.Size = new System.Drawing.Size(1369, 888);
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
            this.splitContainerFooter.Panel1.ResumeLayout(false);
            this.splitContainerFooter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFooter)).EndInit();
            this.splitContainerFooter.ResumeLayout(false);
            this.splitContainerSaleAndMaster.Panel1.ResumeLayout(false);
            this.splitContainerSaleAndMaster.Panel1.PerformLayout();
            this.splitContainerSaleAndMaster.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaleAndMaster)).EndInit();
            this.splitContainerSaleAndMaster.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitMasterDetail.Panel1.ResumeLayout(false);
            this.splitMasterDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMasterDetail)).EndInit();
            this.splitMasterDetail.ResumeLayout(false);
            this.groupBoxMaster.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasterCompanies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasterPersons)).EndInit();
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
        private SplitContainer splitContainerFooter;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label labelBase;
        private Label labelVat;
        private Label labelTotal;
        private GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SplitContainer splitContainerSaleAndMaster;
        private SplitContainer splitMasterDetail;
        private GroupBox groupBoxMaster;
        private DataGridView dataGridViewMasterCompanies;
        private GroupBox groupBoxDetails;
        private DataGridView dataGridViewDetail;
        private TreeView treeView1;
        private PropertyGrid propertyGridSelectedClient;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridViewMasterPersons;
        private OpenFileDialog openFileDialog1;
        private Button buttonPDF;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label12;
        private Label label11;
        private Label labelBullstat;
        private Label label9;
        private Label labelAddress;
        private Label label5;
        private Label labelName;
        private Label label3;
        private GroupBox groupBox3;
        private Label label7;
    }
}

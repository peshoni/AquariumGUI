using System;
using System.Windows.Forms;

namespace WarehouseToAquaticOrganisms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonEN = new System.Windows.Forms.Button();
            this.buttonBG = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.aquariumDatabaseDataSet1 = new WarehouseToAquaticOrganisms.AquariumDatabaseDataSet();
            this.buttonDelivery = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonProviders = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonClientPersons = new System.Windows.Forms.Button();
            this.buttonClientsCompanies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonEN);
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonBG);
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            // 
            // buttonEN
            // 
            resources.ApplyResources(this.buttonEN, "buttonEN");
            this.buttonEN.Name = "buttonEN";
            this.buttonEN.UseVisualStyleBackColor = true;
            this.buttonEN.Click += new System.EventHandler(this.changeToEN_click);
            // 
            // buttonBG
            // 
            resources.ApplyResources(this.buttonBG, "buttonBG");
            this.buttonBG.Name = "buttonBG";
            this.buttonBG.UseVisualStyleBackColor = true;
            this.buttonBG.Click += new System.EventHandler(this.changeToBG_click);
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.BackColor = System.Drawing.SystemColors.Window;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.progressBar1);
            this.panelMain.Name = "panelMain";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.BackColor = System.Drawing.SystemColors.Window;
            this.progressBar1.Maximum = 0;
            this.progressBar1.Name = "progressBar1";
            // 
            // aquariumDatabaseDataSet1
            // 
            this.aquariumDatabaseDataSet1.DataSetName = "AquariumDatabaseDataSet";
            this.aquariumDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDelivery
            // 
            this.buttonDelivery.Image = global::WarehouseToAquaticOrganisms.Properties.Resources._009570_simple_red_glossy_icon_arrows_arrow_more;
            resources.ApplyResources(this.buttonDelivery, "buttonDelivery");
            this.buttonDelivery.Name = "buttonDelivery";
            this.buttonDelivery.Tag = 0;
            this.buttonDelivery.UseVisualStyleBackColor = true;
            this.buttonDelivery.Click += new System.EventHandler(this.button_Click);
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelMain);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.buttonProviders);
            this.flowLayoutPanel1.Controls.Add(this.buttonDelivery);
            this.flowLayoutPanel1.Controls.Add(this.buttonSales);
            this.flowLayoutPanel1.Controls.Add(this.buttonClientPersons);
            this.flowLayoutPanel1.Controls.Add(this.buttonClientsCompanies);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // buttonProviders
            // 
            this.buttonProviders.Image = global::WarehouseToAquaticOrganisms.Properties.Resources.provider_icon_jpg;
            resources.ApplyResources(this.buttonProviders, "buttonProviders");
            this.buttonProviders.Name = "buttonProviders";
            this.buttonProviders.Tag = 2;
            this.buttonProviders.UseVisualStyleBackColor = true;
            this.buttonProviders.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSales
            // 
            resources.ApplyResources(this.buttonSales, "buttonSales");
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Tag = 1;
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonClientPersons
            // 
            this.buttonClientPersons.Image = global::WarehouseToAquaticOrganisms.Properties.Resources.user_group_icon;
            resources.ApplyResources(this.buttonClientPersons, "buttonClientPersons");
            this.buttonClientPersons.Name = "buttonClientPersons";
            this.buttonClientPersons.Tag = 3;
            this.buttonClientPersons.UseVisualStyleBackColor = true;
            this.buttonClientPersons.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonClientsCompanies
            // 
            this.buttonClientsCompanies.Image = global::WarehouseToAquaticOrganisms.Properties.Resources.company_customers_icon_12;
            resources.ApplyResources(this.buttonClientsCompanies, "buttonClientsCompanies");
            this.buttonClientsCompanies.Name = "buttonClientsCompanies";
            this.buttonClientsCompanies.Tag = 4;
            this.buttonClientsCompanies.UseVisualStyleBackColor = true;
            this.buttonClientsCompanies.Click += new System.EventHandler(this.button_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeOrNo);
            this.SizeChanged += new System.EventHandler(this.sizeChanged);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button buttonBG;
       
        private System.Windows.Forms.Panel panelMain; 
        private System.Windows.Forms.ProgressBar progressBar1;
        private AquariumDatabaseDataSet aquariumDatabaseDataSet1;
        private Button buttonEN;
        private Button buttonDelivery;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonSales;
        private Button buttonProviders;
        private Button buttonClientPersons;
        private Button buttonClientsCompanies;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}


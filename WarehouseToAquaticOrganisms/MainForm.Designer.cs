﻿using System;
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSupplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVIDERSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.providersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProviderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageStatus = new System.Windows.Forms.ToolStripLabel();
            this.buttonBG = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.aquariumDatabaseDataSet1 = new WarehouseToAquaticOrganisms.AquariumDatabaseDataSet();
            this.buttonEN = new System.Windows.Forms.Button();
            this.buttonDelivery = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonProviders = new System.Windows.Forms.Button();
            this.buttonClientPersons = new System.Windows.Forms.Button();
            this.buttonClientsCompanies = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.pageStatus});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.supplyToolStripMenuItem,
            this.partnersToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeSaleToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            resources.ApplyResources(this.salesToolStripMenuItem, "salesToolStripMenuItem");
            // 
            // makeSaleToolStripMenuItem
            // 
            this.makeSaleToolStripMenuItem.Name = "makeSaleToolStripMenuItem";
            resources.ApplyResources(this.makeSaleToolStripMenuItem, "makeSaleToolStripMenuItem");
            this.makeSaleToolStripMenuItem.Click += new System.EventHandler(this.menuClick);
            // 
            // supplyToolStripMenuItem
            // 
            this.supplyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSupplyToolStripMenuItem});
            this.supplyToolStripMenuItem.Name = "supplyToolStripMenuItem";
            resources.ApplyResources(this.supplyToolStripMenuItem, "supplyToolStripMenuItem");
            // 
            // createSupplyToolStripMenuItem
            // 
            this.createSupplyToolStripMenuItem.Name = "createSupplyToolStripMenuItem";
            resources.ApplyResources(this.createSupplyToolStripMenuItem, "createSupplyToolStripMenuItem");
            this.createSupplyToolStripMenuItem.Click += new System.EventHandler(this.menuClick);
            // 
            // partnersToolStripMenuItem
            // 
            this.partnersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROVIDERSToolStripMenuItem1,
            this.cLIENTSToolStripMenuItem});
            this.partnersToolStripMenuItem.Name = "partnersToolStripMenuItem";
            resources.ApplyResources(this.partnersToolStripMenuItem, "partnersToolStripMenuItem");
            // 
            // pROVIDERSToolStripMenuItem1
            // 
            this.pROVIDERSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.providersToolStripMenuItem,
            this.addNewProviderToolStripMenuItem});
            this.pROVIDERSToolStripMenuItem1.Name = "pROVIDERSToolStripMenuItem1";
            resources.ApplyResources(this.pROVIDERSToolStripMenuItem1, "pROVIDERSToolStripMenuItem1");
            // 
            // providersToolStripMenuItem
            // 
            this.providersToolStripMenuItem.Name = "providersToolStripMenuItem";
            resources.ApplyResources(this.providersToolStripMenuItem, "providersToolStripMenuItem");
            this.providersToolStripMenuItem.Click += new System.EventHandler(this.menuClick);
            // 
            // addNewProviderToolStripMenuItem
            // 
            this.addNewProviderToolStripMenuItem.Name = "addNewProviderToolStripMenuItem";
            resources.ApplyResources(this.addNewProviderToolStripMenuItem, "addNewProviderToolStripMenuItem");
            this.addNewProviderToolStripMenuItem.Click += new System.EventHandler(this.menuClick);
            // 
            // cLIENTSToolStripMenuItem
            // 
            this.cLIENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERSONToolStripMenuItem,
            this.cOMPANYToolStripMenuItem});
            this.cLIENTSToolStripMenuItem.Name = "cLIENTSToolStripMenuItem";
            resources.ApplyResources(this.cLIENTSToolStripMenuItem, "cLIENTSToolStripMenuItem");
            // 
            // pERSONToolStripMenuItem
            // 
            this.pERSONToolStripMenuItem.Name = "pERSONToolStripMenuItem";
            resources.ApplyResources(this.pERSONToolStripMenuItem, "pERSONToolStripMenuItem");
            this.pERSONToolStripMenuItem.Click += new System.EventHandler(this.menuClick);
            // 
            // cOMPANYToolStripMenuItem
            // 
            this.cOMPANYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyesToolStripMenuItem,
            this.insertNewCompanyToolStripMenuItem});
            this.cOMPANYToolStripMenuItem.Name = "cOMPANYToolStripMenuItem";
            resources.ApplyResources(this.cOMPANYToolStripMenuItem, "cOMPANYToolStripMenuItem");
            // 
            // companyesToolStripMenuItem
            // 
            this.companyesToolStripMenuItem.Name = "companyesToolStripMenuItem";
            resources.ApplyResources(this.companyesToolStripMenuItem, "companyesToolStripMenuItem");
            this.companyesToolStripMenuItem.Click += new System.EventHandler(this.menuClick);
            // 
            // insertNewCompanyToolStripMenuItem
            // 
            this.insertNewCompanyToolStripMenuItem.Name = "insertNewCompanyToolStripMenuItem";
            resources.ApplyResources(this.insertNewCompanyToolStripMenuItem, "insertNewCompanyToolStripMenuItem");
            this.insertNewCompanyToolStripMenuItem.Click += new System.EventHandler(this.menuClick);
            // 
            // pageStatus
            // 
            this.pageStatus.Name = "pageStatus";
            resources.ApplyResources(this.pageStatus, "pageStatus");
            // 
            // buttonBG
            // 
            resources.ApplyResources(this.buttonBG, "buttonBG");
            this.buttonBG.Image = global::WarehouseToAquaticOrganisms.Properties.Resources.bg;
            this.buttonBG.Name = "buttonBG";
            this.buttonBG.UseVisualStyleBackColor = true;
            this.buttonBG.Click += new System.EventHandler(this.changeToBG_click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Window;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.progressBar1);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            // 
            // aquariumDatabaseDataSet1
            // 
            this.aquariumDatabaseDataSet1.DataSetName = "AquariumDatabaseDataSet";
            this.aquariumDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonEN
            // 
            resources.ApplyResources(this.buttonEN, "buttonEN");
            this.buttonEN.Image = global::WarehouseToAquaticOrganisms.Properties.Resources.gb;
            this.buttonEN.Name = "buttonEN";
            this.buttonEN.UseVisualStyleBackColor = true;
            this.buttonEN.Click += new System.EventHandler(this.changeToEN_click);
            // 
            // buttonDelivery
            // 
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonDelivery);
            this.flowLayoutPanel1.Controls.Add(this.buttonSales);
            this.flowLayoutPanel1.Controls.Add(this.buttonProviders);
            this.flowLayoutPanel1.Controls.Add(this.buttonClientPersons);
            this.flowLayoutPanel1.Controls.Add(this.buttonClientsCompanies);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // buttonSales
            // 
            resources.ApplyResources(this.buttonSales, "buttonSales");
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Tag = 1;
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonProviders
            // 
            resources.ApplyResources(this.buttonProviders, "buttonProviders");
            this.buttonProviders.Name = "buttonProviders";
            this.buttonProviders.UseVisualStyleBackColor = true;
            // 
            // buttonClientPersons
            // 
            resources.ApplyResources(this.buttonClientPersons, "buttonClientPersons");
            this.buttonClientPersons.Name = "buttonClientPersons";
            this.buttonClientPersons.UseVisualStyleBackColor = true;
            // 
            // buttonClientsCompanies
            // 
            resources.ApplyResources(this.buttonClientsCompanies, "buttonClientsCompanies");
            this.buttonClientsCompanies.Name = "buttonClientsCompanies";
            this.buttonClientsCompanies.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeOrNo);
            this.SizeChanged += new System.EventHandler(this.sizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aquariumDatabaseDataSet1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSupplyToolStripMenuItem;
        private System.Windows.Forms.Button buttonBG;
       
        private System.Windows.Forms.Panel panelMain; 
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem pROVIDERSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem providersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProviderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPANYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSaleToolStripMenuItem;
        private ToolStripLabel pageStatus;
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


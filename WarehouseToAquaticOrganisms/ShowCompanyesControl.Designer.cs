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
            this.dataGridViewCompanyes = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSaveNewClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCompanyes
            // 
            this.dataGridViewCompanyes.AllowUserToAddRows = false;
            this.dataGridViewCompanyes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCompanyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanyes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompanyes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCompanyes.Name = "dataGridViewCompanyes";
            this.dataGridViewCompanyes.Size = new System.Drawing.Size(781, 513);
            this.dataGridViewCompanyes.TabIndex = 0;
            this.dataGridViewCompanyes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickOnRow);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSaveNewClient);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1MinSize = 40;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewCompanyes);
            this.splitContainer1.Size = new System.Drawing.Size(781, 557);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonSaveNewClient
            // 
            this.buttonSaveNewClient.Location = new System.Drawing.Point(95, 15);
            this.buttonSaveNewClient.Name = "buttonSaveNewClient";
            this.buttonSaveNewClient.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveNewClient.TabIndex = 1;
            this.buttonSaveNewClient.Text = "Add new";
            this.buttonSaveNewClient.UseVisualStyleBackColor = true;
            this.buttonSaveNewClient.Click += new System.EventHandler(this.buttonSaveNewClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Companies";
            // 
            // ShowCompaniesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ShowCompaniesControl";
            this.Size = new System.Drawing.Size(781, 557);
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyes)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompanyes;
        private SplitContainer splitContainer1;
        private Label label1;
        private Button buttonSaveNewClient;
    }
}

using System;
using System.Windows.Forms;

namespace WarehouseToAquaticOrganisms
{
    partial class ShowPersonsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPersonsControl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainerShowPersons = new System.Windows.Forms.SplitContainer();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerShowPersons)).BeginInit();
            this.splitContainerShowPersons.Panel1.SuspendLayout();
            this.splitContainerShowPersons.Panel2.SuspendLayout();
            this.splitContainerShowPersons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickOnRow);
            // 
            // splitContainerShowPersons
            // 
            resources.ApplyResources(this.splitContainerShowPersons, "splitContainerShowPersons");
            this.splitContainerShowPersons.Name = "splitContainerShowPersons";
            // 
            // splitContainerShowPersons.Panel1
            // 
            this.splitContainerShowPersons.Panel1.Controls.Add(this.buttonAddPerson);
            this.splitContainerShowPersons.Panel1.Controls.Add(this.label1);
            // 
            // splitContainerShowPersons.Panel2
            // 
            this.splitContainerShowPersons.Panel2.Controls.Add(this.dataGridView1);
            // 
            // buttonAddPerson
            // 
            resources.ApplyResources(this.buttonAddPerson, "buttonAddPerson");
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ShowPersonsControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerShowPersons);
            this.Name = "ShowPersonsControl";
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainerShowPersons.Panel1.ResumeLayout(false);
            this.splitContainerShowPersons.Panel1.PerformLayout();
            this.splitContainerShowPersons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerShowPersons)).EndInit();
            this.splitContainerShowPersons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

      



        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SplitContainer splitContainerShowPersons;
        private Label label1;
        private Button buttonAddPerson;
    }
}

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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyes)).BeginInit();
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
            this.dataGridViewCompanyes.Size = new System.Drawing.Size(781, 557);
            this.dataGridViewCompanyes.TabIndex = 0;
            this.dataGridViewCompanyes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickOnRow);
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
            this.ResumeLayout(false);

        }

       


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompanyes;
    }
}

namespace WarehouseToAquaticOrganisms
{
    partial class ShowProvidersControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProviders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "providers";
            // 
            // dataGridViewProviders
            // 
            this.dataGridViewProviders.AllowUserToAddRows = false;
            this.dataGridViewProviders.AllowUserToDeleteRows = false;
            this.dataGridViewProviders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProviders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProviders.Name = "dataGridViewProviders";
            this.dataGridViewProviders.ReadOnly = true;
            this.dataGridViewProviders.Size = new System.Drawing.Size(787, 510);
            this.dataGridViewProviders.TabIndex = 1;
            this.dataGridViewProviders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickOnRow);
            // 
            // ShowProvidersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProviders);
            this.Controls.Add(this.label1);
            this.Name = "ShowProvidersControl";
            this.Size = new System.Drawing.Size(787, 510);
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProviders;
    }
}

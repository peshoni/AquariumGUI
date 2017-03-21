namespace WarehouseToAquaticOrganisms
{
    partial class ShowDeliveryControl
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
            this.dataGridViewForDeliveries = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForDeliveries
            // 
            this.dataGridViewForDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewForDeliveries.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewForDeliveries.Name = "dataGridViewForDeliveries";
            this.dataGridViewForDeliveries.Size = new System.Drawing.Size(885, 591);
            this.dataGridViewForDeliveries.TabIndex = 0;
            // 
            // ShowDeliveryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewForDeliveries);
            this.Name = "ShowDeliveryControl";
            this.Size = new System.Drawing.Size(885, 591);
            this.Load += new System.EventHandler(this.ShowDeliveryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForDeliveries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForDeliveries;
    }
}

using System;

namespace WarehouseToAquaticOrganisms
{
    partial class MakeDeliveryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeDeliveryControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentProfitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameColumn,
            this.quantityColumn,
            this.deliveryPriceColumn,
            this.percentProfitColumn,
            this.salePriceColumn});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // productNameColumn
            // 
            this.productNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.productNameColumn, "productNameColumn");
            this.productNameColumn.Name = "productNameColumn";
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.quantityColumn, "quantityColumn");
            this.quantityColumn.MaxInputLength = 10;
            this.quantityColumn.Name = "quantityColumn";
            // 
            // deliveryPriceColumn
            // 
            this.deliveryPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.deliveryPriceColumn, "deliveryPriceColumn");
            this.deliveryPriceColumn.Name = "deliveryPriceColumn";
            // 
            // percentProfitColumn
            // 
            this.percentProfitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.percentProfitColumn, "percentProfitColumn");
            this.percentProfitColumn.Name = "percentProfitColumn";
            // 
            // salePriceColumn
            // 
            this.salePriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.salePriceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.salePriceColumn, "salePriceColumn");
            this.salePriceColumn.Name = "salePriceColumn";
            this.salePriceColumn.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MakeDeliveryControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Name = "MakeDeliveryControl";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentProfitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceColumn;
        private System.Windows.Forms.Button button1;
    }
}

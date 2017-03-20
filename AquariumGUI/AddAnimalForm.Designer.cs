using System.Windows.Forms;

namespace AquariumGUI
{
    partial class AddAnimalForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxNameOfAnimal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(283, 272);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Crab",
            "Goldfish",
            "Spirogira"});
            this.comboBox1.Location = new System.Drawing.Point(216, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // labelType
            // 
            this.labelType.Location = new System.Drawing.Point(12, 117);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(120, 20);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "label1";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(12, 145);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 20);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "labelName";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWeight
            // 
            this.labelWeight.Location = new System.Drawing.Point(12, 172);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(120, 20);
            this.labelWeight.TabIndex = 6;
            this.labelWeight.Text = "labelWeight";
            this.labelWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(216, 172);
            this.textBoxWeight.MaxLength = 10;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(141, 20);
            this.textBoxWeight.TabIndex = 6;
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNameOfAnimal
            // 
            this.textBoxNameOfAnimal.Location = new System.Drawing.Point(216, 145);
            this.textBoxNameOfAnimal.MaxLength = 15;
            this.textBoxNameOfAnimal.Name = "textBoxNameOfAnimal";
            this.textBoxNameOfAnimal.Size = new System.Drawing.Size(141, 20);
            this.textBoxNameOfAnimal.TabIndex = 10;
            this.textBoxNameOfAnimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(257, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNameOfAnimal);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSave);
            this.Name = "AddAnimalForm";
            this.Text = "FormAddAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxNameOfAnimal;
        private PictureBox pictureBox1;
    }
}
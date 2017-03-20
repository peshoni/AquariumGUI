using System;
using System.Drawing;
using System.Windows.Forms;

namespace AquariumGUI
{
    partial class FormMain
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
            this.tabControlMainView = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDelleteAllRecordsInDB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTurnLightOn = new System.Windows.Forms.Button();
            this.buttonLightTurnOf = new System.Windows.Forms.Button();
            this.buttonOpenGridForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonAeratorOff = new System.Windows.Forms.Button();
            this.buttonAeratorOn = new System.Windows.Forms.Button();
            this.buttonCreateObject = new System.Windows.Forms.Button();
            this.textBoxSeaweedsCount = new System.Windows.Forms.TextBox();
            this.textBoxShellfishCount = new System.Windows.Forms.TextBox();
            this.textBoxFishCount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSeaweeds = new System.Windows.Forms.Label();
            this.labelShellfish = new System.Windows.Forms.Label();
            this.labelFish = new System.Windows.Forms.Label();
            this.buttonIncreaseSeaweed = new System.Windows.Forms.Button();
            this.buttonReduceSeaweed = new System.Windows.Forms.Button();
            this.buttonIncreaseShellfish = new System.Windows.Forms.Button();
            this.buttonReduceShellfish = new System.Windows.Forms.Button();
            this.buttonIncreaseFish = new System.Windows.Forms.Button();
            this.buttonReduceFish = new System.Windows.Forms.Button();
            this.tabControlMainView.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMainView
            // 
            this.tabControlMainView.Controls.Add(this.tabPage2);
            this.tabControlMainView.Location = new System.Drawing.Point(1, 0);
            this.tabControlMainView.Name = "tabControlMainView";
            this.tabControlMainView.SelectedIndex = 0;
            this.tabControlMainView.Size = new System.Drawing.Size(1111, 597);
            this.tabControlMainView.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDelleteAllRecordsInDB);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.buttonOpenGridForm);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.buttonCreateObject);
            this.tabPage2.Controls.Add(this.textBoxSeaweedsCount);
            this.tabPage2.Controls.Add(this.textBoxShellfishCount);
            this.tabPage2.Controls.Add(this.textBoxFishCount);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.labelSeaweeds);
            this.tabPage2.Controls.Add(this.labelShellfish);
            this.tabPage2.Controls.Add(this.labelFish);
            this.tabPage2.Controls.Add(this.buttonIncreaseSeaweed);
            this.tabPage2.Controls.Add(this.buttonReduceSeaweed);
            this.tabPage2.Controls.Add(this.buttonIncreaseShellfish);
            this.tabPage2.Controls.Add(this.buttonReduceShellfish);
            this.tabPage2.Controls.Add(this.buttonIncreaseFish);
            this.tabPage2.Controls.Add(this.buttonReduceFish);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1103, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aquarium";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDelleteAllRecordsInDB
            // 
            this.buttonDelleteAllRecordsInDB.Location = new System.Drawing.Point(7, 330);
            this.buttonDelleteAllRecordsInDB.Name = "buttonDelleteAllRecordsInDB";
            this.buttonDelleteAllRecordsInDB.Size = new System.Drawing.Size(135, 23);
            this.buttonDelleteAllRecordsInDB.TabIndex = 34;
            this.buttonDelleteAllRecordsInDB.Text = "buttonClearDB";
            this.buttonDelleteAllRecordsInDB.UseVisualStyleBackColor = true;
            this.buttonDelleteAllRecordsInDB.Click += new System.EventHandler(this.buttonDelleteAllRecordsInDB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTurnLightOn);
            this.groupBox2.Controls.Add(this.buttonLightTurnOf);
            this.groupBox2.Location = new System.Drawing.Point(4, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 54);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // buttonTurnLightOn
            // 
            this.buttonTurnLightOn.Enabled = false;
            this.buttonTurnLightOn.Location = new System.Drawing.Point(14, 19);
            this.buttonTurnLightOn.Name = "buttonTurnLightOn";
            this.buttonTurnLightOn.Size = new System.Drawing.Size(75, 23);
            this.buttonTurnLightOn.TabIndex = 30;
            this.buttonTurnLightOn.Text = "button1";
            this.buttonTurnLightOn.UseVisualStyleBackColor = true;
            this.buttonTurnLightOn.Click += new System.EventHandler(this.button_Click_LightTurnOn);
            // 
            // buttonLightTurnOf
            // 
            this.buttonLightTurnOf.Location = new System.Drawing.Point(86, 19);
            this.buttonLightTurnOf.Name = "buttonLightTurnOf";
            this.buttonLightTurnOf.Size = new System.Drawing.Size(75, 23);
            this.buttonLightTurnOf.TabIndex = 31;
            this.buttonLightTurnOf.Text = "button1";
            this.buttonLightTurnOf.UseVisualStyleBackColor = true;
            this.buttonLightTurnOf.Click += new System.EventHandler(this.button1_Click_LightTurnOf);
            // 
            // buttonOpenGridForm
            // 
            this.buttonOpenGridForm.Location = new System.Drawing.Point(4, 153);
            this.buttonOpenGridForm.Name = "buttonOpenGridForm";
            this.buttonOpenGridForm.Size = new System.Drawing.Size(103, 23);
            this.buttonOpenGridForm.TabIndex = 29;
            this.buttonOpenGridForm.Text = "buttonGridDB";
            this.buttonOpenGridForm.UseVisualStyleBackColor = true;
            this.buttonOpenGridForm.Click += new System.EventHandler(this.buttonOpenGridForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonAeratorOff);
            this.groupBox1.Controls.Add(this.buttonAeratorOn);
            this.groupBox1.Location = new System.Drawing.Point(6, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 70);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 43);
            this.progressBar1.Maximum = 500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(166, 21);
            this.progressBar1.TabIndex = 22;
            // 
            // buttonAeratorOff
            // 
            this.buttonAeratorOff.Enabled = false;
            this.buttonAeratorOff.Location = new System.Drawing.Point(84, 15);
            this.buttonAeratorOff.Name = "buttonAeratorOff";
            this.buttonAeratorOff.Size = new System.Drawing.Size(75, 23);
            this.buttonAeratorOff.TabIndex = 22;
            this.buttonAeratorOff.Text = "button2";
            this.buttonAeratorOff.UseVisualStyleBackColor = true;
            this.buttonAeratorOff.Click += new System.EventHandler(this.buttonAerator_Click_TurnOf);
            // 
            // buttonAeratorOn
            // 
            this.buttonAeratorOn.Location = new System.Drawing.Point(12, 15);
            this.buttonAeratorOn.Name = "buttonAeratorOn";
            this.buttonAeratorOn.Size = new System.Drawing.Size(75, 23);
            this.buttonAeratorOn.TabIndex = 21;
            this.buttonAeratorOn.Text = "AIR";
            this.buttonAeratorOn.UseVisualStyleBackColor = true;
            this.buttonAeratorOn.Click += new System.EventHandler(this.buttonAerator_Click_TurnOn);
            // 
            // buttonCreateObject
            // 
            this.buttonCreateObject.Location = new System.Drawing.Point(4, 124);
            this.buttonCreateObject.Name = "buttonCreateObject";
            this.buttonCreateObject.Size = new System.Drawing.Size(103, 23);
            this.buttonCreateObject.TabIndex = 27;
            this.buttonCreateObject.Text = "button2";
            this.buttonCreateObject.UseVisualStyleBackColor = true;
            this.buttonCreateObject.Click += new System.EventHandler(this.buttonCreateObject_Click);
            // 
            // textBoxSeaweedsCount
            // 
            this.textBoxSeaweedsCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSeaweedsCount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSeaweedsCount.Location = new System.Drawing.Point(148, 72);
            this.textBoxSeaweedsCount.MaxLength = 50;
            this.textBoxSeaweedsCount.Name = "textBoxSeaweedsCount";
            this.textBoxSeaweedsCount.ReadOnly = true;
            this.textBoxSeaweedsCount.Size = new System.Drawing.Size(33, 22);
            this.textBoxSeaweedsCount.TabIndex = 26;
            this.textBoxSeaweedsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxShellfishCount
            // 
            this.textBoxShellfishCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShellfishCount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShellfishCount.Location = new System.Drawing.Point(148, 42);
            this.textBoxShellfishCount.MaxLength = 50;
            this.textBoxShellfishCount.Name = "textBoxShellfishCount";
            this.textBoxShellfishCount.ReadOnly = true;
            this.textBoxShellfishCount.Size = new System.Drawing.Size(33, 22);
            this.textBoxShellfishCount.TabIndex = 25;
            this.textBoxShellfishCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxFishCount
            // 
            this.textBoxFishCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFishCount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFishCount.Location = new System.Drawing.Point(148, 13);
            this.textBoxFishCount.MaxLength = 50;
            this.textBoxFishCount.Name = "textBoxFishCount";
            this.textBoxFishCount.ReadOnly = true;
            this.textBoxFishCount.Size = new System.Drawing.Size(33, 22);
            this.textBoxFishCount.TabIndex = 24;
            this.textBoxFishCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(187, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(904, 545);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // labelSeaweeds
            // 
            this.labelSeaweeds.Location = new System.Drawing.Point(36, 72);
            this.labelSeaweeds.Name = "labelSeaweeds";
            this.labelSeaweeds.Size = new System.Drawing.Size(75, 25);
            this.labelSeaweeds.TabIndex = 20;
            this.labelSeaweeds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShellfish
            // 
            this.labelShellfish.Location = new System.Drawing.Point(36, 42);
            this.labelShellfish.Name = "labelShellfish";
            this.labelShellfish.Size = new System.Drawing.Size(75, 25);
            this.labelShellfish.TabIndex = 19;
            this.labelShellfish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFish
            // 
            this.labelFish.Location = new System.Drawing.Point(36, 13);
            this.labelFish.Name = "labelFish";
            this.labelFish.Size = new System.Drawing.Size(75, 25);
            this.labelFish.TabIndex = 18;
            this.labelFish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonIncreaseSeaweed
            // 
            this.buttonIncreaseSeaweed.Location = new System.Drawing.Point(117, 72);
            this.buttonIncreaseSeaweed.Name = "buttonIncreaseSeaweed";
            this.buttonIncreaseSeaweed.Size = new System.Drawing.Size(25, 25);
            this.buttonIncreaseSeaweed.TabIndex = 17;
            this.buttonIncreaseSeaweed.Text = "+";
            this.buttonIncreaseSeaweed.UseVisualStyleBackColor = true;
            this.buttonIncreaseSeaweed.Click += new System.EventHandler(this.buttonIncreaseSeaweed_Click);
            // 
            // buttonReduceSeaweed
            // 
            this.buttonReduceSeaweed.Location = new System.Drawing.Point(6, 72);
            this.buttonReduceSeaweed.Name = "buttonReduceSeaweed";
            this.buttonReduceSeaweed.Size = new System.Drawing.Size(25, 25);
            this.buttonReduceSeaweed.TabIndex = 16;
            this.buttonReduceSeaweed.Text = "-";
            this.buttonReduceSeaweed.UseVisualStyleBackColor = true;
            this.buttonReduceSeaweed.Click += new System.EventHandler(this.buttonReduceSeaweed_Click);
            // 
            // buttonIncreaseShellfish
            // 
            this.buttonIncreaseShellfish.Location = new System.Drawing.Point(117, 42);
            this.buttonIncreaseShellfish.Name = "buttonIncreaseShellfish";
            this.buttonIncreaseShellfish.Size = new System.Drawing.Size(25, 25);
            this.buttonIncreaseShellfish.TabIndex = 15;
            this.buttonIncreaseShellfish.Text = "+";
            this.buttonIncreaseShellfish.UseVisualStyleBackColor = true;
            this.buttonIncreaseShellfish.Click += new System.EventHandler(this.buttonIncreaseShellfish_Click);
            // 
            // buttonReduceShellfish
            // 
            this.buttonReduceShellfish.Location = new System.Drawing.Point(6, 42);
            this.buttonReduceShellfish.Name = "buttonReduceShellfish";
            this.buttonReduceShellfish.Size = new System.Drawing.Size(25, 25);
            this.buttonReduceShellfish.TabIndex = 14;
            this.buttonReduceShellfish.Text = "-";
            this.buttonReduceShellfish.UseVisualStyleBackColor = true;
            this.buttonReduceShellfish.Click += new System.EventHandler(this.buttonReduceShellfish_Click);
            // 
            // buttonIncreaseFish
            // 
            this.buttonIncreaseFish.Location = new System.Drawing.Point(117, 13);
            this.buttonIncreaseFish.Name = "buttonIncreaseFish";
            this.buttonIncreaseFish.Size = new System.Drawing.Size(25, 25);
            this.buttonIncreaseFish.TabIndex = 13;
            this.buttonIncreaseFish.Text = "+";
            this.buttonIncreaseFish.UseVisualStyleBackColor = true;
            this.buttonIncreaseFish.Click += new System.EventHandler(this.buttonIncreaseFish_Click);
            // 
            // buttonReduceFish
            // 
            this.buttonReduceFish.Location = new System.Drawing.Point(6, 13);
            this.buttonReduceFish.Name = "buttonReduceFish";
            this.buttonReduceFish.Size = new System.Drawing.Size(25, 25);
            this.buttonReduceFish.TabIndex = 12;
            this.buttonReduceFish.Text = "-";
            this.buttonReduceFish.UseVisualStyleBackColor = true;
            this.buttonReduceFish.Click += new System.EventHandler(this.buttonReduceFish_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1114, 600);
            this.Controls.Add(this.tabControlMainView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Aquarium manager";
            this.tabControlMainView.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        } 
        #endregion
        private System.Windows.Forms.TabControl tabControlMainView;
        private TabPage tabPage2;
        private Button buttonDelleteAllRecordsInDB;
        private GroupBox groupBox2;
        public Button buttonOpenGridForm;
        private GroupBox groupBox1;
        private Button buttonCreateObject;
        private TextBox textBoxSeaweedsCount;
        private TextBox textBoxShellfishCount;
        private TextBox textBoxFishCount;
        private PictureBox pictureBox1;
        private Label labelSeaweeds;
        private Label labelShellfish;
        private Label labelFish;
        private Button buttonIncreaseSeaweed;
        private Button buttonReduceSeaweed;
        private Button buttonIncreaseShellfish;
        private Button buttonReduceShellfish;
        private Button buttonIncreaseFish;
        private Button buttonReduceFish;
        private ProgressBar progressBar1;
        private Button buttonAeratorOn;
        private Button buttonAeratorOff;
        private Button buttonLightTurnOf;
        private Button buttonTurnLightOn;
    }
}


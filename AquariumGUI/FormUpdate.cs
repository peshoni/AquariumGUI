using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AquariumGUI.AquariumDatabaseDataSetTableAdapters;

namespace AquariumGUI
{
    public partial class FormUpdate : Form
    {
        private Aquarium.AquaticOrganism organism;
        private string oldValueOfNameTextField;
        private string newName;
        
        public FormUpdate(Aquarium.AquaticOrganism aOrganism)
        {
            InitializeComponent();
            this.organism = aOrganism;
            textBox1.Text = aOrganism.Name;
        }

        private void textBox1_TextChanged( object sender, EventArgs e )
        {

            newName = textBox1.Text;  
            if (Validator.isValidName(newName))
            {
                textBox1.Text = newName;
                oldValueOfNameTextField = newName; 
                button1.Enabled = true;
            }
            else
            {
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(this.textBox1, labels.AllowedLetters);
                if (newName.Length == 0)
                {
                    oldValueOfNameTextField = ""; 
                    button1.Enabled = false;
                }
                textBox1.Text = oldValueOfNameTextField;
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void buttonSave_Click( object sender, EventArgs e )
        {
            organism.Name = newName;
            Dispose();
        } 
    }
}

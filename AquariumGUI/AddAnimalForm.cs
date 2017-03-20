using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Aquarium.Residents;
using Aquarium;

namespace AquariumGUI
{

    public partial class AddAnimalForm : Form
    {
        private enum Type{ Crab, Goldfish, Spirogira }
      //  private Regex weightPattern;
       // private Regex namePattern;
        private Image imgFish;
        private Image imgCrab; 
        private Image imgSpirogira;
        private string oldValueOfWeightTextFiel;
        private string oldValueOfNameTextField;
        private FormMain parentForm;
        private bool indexChanged;
        private bool nameEntered;
        private bool weightEntered; 
      
        public AddAnimalForm(FormMain aParentForm)

        {
            InitializeComponent();
            this.parentForm = aParentForm;
            buttonSave.Enabled = false;
            textBoxWeight.TextChanged += new EventHandler(TextOfWeightChanged);
            textBoxNameOfAnimal.TextChanged += new EventHandler(TextOfNameChanged);
         //   weightPattern = new Regex("\\b\\d{1,}\\b");
         //   namePattern = new Regex("\\b[a-zA-Z]+\\b");
            addTextToTheLabels();
            loadImages();
           
        }

        private void loadImages()
        {
            imgSpirogira = AquariumGUI.Properties.Resources.seaWeed;
            imgFish = AquariumGUI.Properties.Resources.fish;
            imgCrab = AquariumGUI.Properties.Resources.crab; 
        }

        #region Validate input
        /// <summary>
        /// Clears field if content is not correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextOfNameChanged( object sender, EventArgs e )
        {
            string text = textBoxNameOfAnimal.Text;
            if (Validator.isValidName(text)) 
            {
                textBoxNameOfAnimal.Text = text;
                oldValueOfNameTextField = text;
                nameEntered = true;
            }
            else
            {
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(this.textBoxNameOfAnimal,labels.AllowedLetters);
                if (text.Length == 0)
                {
                    oldValueOfNameTextField = "";
                    nameEntered = false;
                    buttonSave.Enabled = false;
                }  
                textBoxNameOfAnimal.Text = oldValueOfNameTextField;
                textBoxNameOfAnimal.SelectionStart = textBoxNameOfAnimal.Text.Length;
            }
            tryEnableSaveButton();
        }

       

        /// <summary>
        /// Clears field if content is not correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextOfWeightChanged( object sender, EventArgs e )
        {
            string text = textBoxWeight.Text;
            // if (weightPattern.IsMatch(text))
            if (Validator.isValidWeight(text))
            {
                textBoxWeight.Text = text;
                oldValueOfWeightTextFiel = text;
                weightEntered = true; 
            }
            else {
                System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
                ToolTip2.SetToolTip(this.textBoxWeight, labels.AllowedIntegers);
                if (text.Length==0)
                {
                    oldValueOfWeightTextFiel = "";
                    weightEntered = false;
                    buttonSave.Enabled = false;
                }
                textBoxWeight.Text = oldValueOfWeightTextFiel;
                textBoxWeight.SelectionStart = textBoxWeight.Text.Length;               
            }
            tryEnableSaveButton();
        }
        #endregion
        
        private void addTextToTheLabels()
        {
            this.Text = labels.Choose;
            labelType.Text = labels.select; 
            labelName.Text = labels.name; 
            labelWeight.Text = labels.grammes; 
            buttonSave.Text = labels.create; 
        } 

        private void buttonSave_Click( object sender, EventArgs e )
        {
            saveInfo();            
            oldValueOfNameTextField = null;
            oldValueOfWeightTextFiel = null;
        }

        private void saveInfo()
        {
            Crab crab=null;
            Goldfish goldFish = null;
            Spirogira spiro = null;
            string type = comboBox1.Text;
            string nameOfAnimal = textBoxNameOfAnimal.Text;
            int weightOfAnimal = int.Parse(textBoxWeight.Text);

          //  Graphics graphics; 
            switch (type)
            {
                case "Crab":
                    crab = Activator.CreateInstance<Crab>();
                    crab.Name = nameOfAnimal;
                    crab.Weight = weightOfAnimal;
                    crab.IsMovable = true;     
                    parentForm.addToAquariumLists(crab);
                                      
                  /*  using (graphics = Graphics.FromImage(imgCrab))
                        graphics.DrawString(crab.Name, new Font("Arial", 10), Brushes.Yellow, new PointF(20, 40));*/
                    parentForm.animateObject(crab, imgCrab, parentForm.WidthOfPictureBox, parentForm.HeightOfPictureBox );
                    break;
                case "Goldfish":
                    goldFish = Activator.CreateInstance<Goldfish>();
                    goldFish.Name = nameOfAnimal;
                    goldFish.Weight = weightOfAnimal;
                    goldFish.IsMovable = true;
                    parentForm.addToAquariumLists(goldFish);
                  /*  using (graphics = Graphics.FromImage(imgFish))
                        graphics.DrawString(goldFish.Name, new Font("Arial", 10), Brushes.Yellow, new PointF(0,0));*/
                    parentForm.animateObject(goldFish, imgFish, parentForm.WidthOfPictureBox, parentForm.HeightOfPictureBox );
                    break;
                case "Spirogira":
                    spiro = Activator.CreateInstance<Spirogira>();
                    spiro.Name = nameOfAnimal;
                    spiro.Weight = weightOfAnimal;
                    spiro.IsMovable = false; 
                    parentForm.addToAquariumLists(spiro);

                    parentForm.animateObject(spiro,imgSpirogira, parentForm.WidthOfPictureBox, parentForm.HeightOfPictureBox );
                    break;
                default:
                    break;
            }
            parentForm.DataGridForm.refreshBindingList();
          this.Close();
        } 

        private void comboBox1_SelectedIndexChanged_1( object sender, EventArgs e )
        {
            indexChanged = true; 
            int number = comboBox1.SelectedIndex;
            switch (number)
            {
                case 0:                    
                    pictureBox1.Image = imgCrab;
                    break;
                case 1:
                    pictureBox1.Image = imgFish;
                    break;
                case 2:
                    pictureBox1.Image = imgSpirogira;
                    break;
                default:
                    break;
            }
            tryEnableSaveButton();
        }
        private void tryEnableSaveButton()
        {
            if (indexChanged&&nameEntered&&weightEntered)
            {
                buttonSave.Enabled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aquarium;
using Aquarium.Residents;

namespace AquariumGUI
{
    public partial class DataGridForm : Form
    {
       private FormMain parentForm;
      //  private BindingList<AquaticOrganism> list;
       private Aquarium.Aquarium aquarium;
       private DataGridViewButtonColumn buttonColumnDelete;
       private DataGridViewButtonColumn buttonColumnUpdate;
      
     //  private DataGridViewCheckBoxColumn checkBoxColumn_isMovable; 
    //   private DataGridViewTextBoxColumn hashColumn;
    //   private DataGridViewTextBoxColumn typeColumn;
   //    private DataGridViewTextBoxColumn nameColumn;
        

        public DataGridForm(FormMain aParentForm,  Aquarium.Aquarium aAquarium ) 
        {
            InitializeComponent();


            this.Location = new Point((aParentForm.Width + 5), 20);
            this.parentForm = aParentForm;
            this.aquarium = aAquarium;
            buttonColumnDelete = createDatagridViewButtonColumn("Delete", "delete", "buttonDelete"); 
            buttonColumnUpdate = createDatagridViewButtonColumn("Update", "update", "buttonUpdate"); 
         //   checkBoxColumn_isMovable = createDataGridViewCheckBoxColumn("Movable", "IsMovable"); 
          //  hashColumn = createDatagridViewTextBoxColumn("ID", "id","ID",60,true);
         //   typeColumn = createDatagridViewTextBoxColumn("Organism", "type", "Type", 60, true);
         //   nameColumn = createDatagridViewTextBoxColumn("Name","name","Name",80,false);

            dataGridView2.Columns.AddRange(buttonColumnDelete, buttonColumnUpdate  ); 
           // refreshBindingList();



           dataGridView2.CellPainting += DataGridView1_CellPainting;
            this.Refresh();      
        }

        private void DataGridView1_CellPainting( object sender, DataGridViewCellPaintingEventArgs e )
        {
            if (e.RowIndex >= 0)
            { 
                int ID = (int)dataGridView2.Rows [e.RowIndex].Cells ["iDDataGridViewTextBoxColumn"].Value; ; 
                AquaticOrganism forProcessing = aquarium.MyList.List.Find/* list.ToList<AquaticOrganism>().Find*/(organism => organism.ID == ID); 
                if (forProcessing.GetType().BaseType.Equals(typeof(Seaweed)))
                {
                    DataGridViewCell cell = dataGridView2.Rows [e.RowIndex].Cells ["isMovableDataGridViewCheckBoxColumn"]; 
                    var dataGridViewCellStyle2 = new DataGridViewCellStyle { Padding = new Padding(100, 0, 0, 0) };
                    cell.Style = dataGridViewCellStyle2; 
                    cell.ReadOnly = true; 
                }
            }
        }

        public void refreshBindingList()
        {
            //list = null;
            //list = new BindingList<AquaticOrganism>( aquarium.MyList.List);//.List);
            //dataGridView1.DataSource = list;
            // list = new BindingList<AquaticOrganism>(aquariumDatabaseDataSet.Aquarium);//.List);
            // aquariumBindingSource.SuspendBinding();
         
            this.aquariumTableAdapter.Fill(this.aquariumDatabaseDataSet.Aquarium);
        }
        #region Column factory
        /// <summary>
        /// Create column with textBoxes..
        /// </summary>
        /// <param name="aHeader"></param>
        /// <param name="aText"></param>
        /// <param name="aDataPropertyName"></param>
        /// <param name="aWidth"></param>
        /// <returns></returns>
        //private DataGridViewTextBoxColumn createDatagridViewTextBoxColumn( string aHeader, string aText, string aDataPropertyName,int aWidth, bool aReadOnly )
        //{
        //    DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
        //    textBoxColumn.Width = aWidth;
        //    textBoxColumn.HeaderText = aHeader; 
        //    textBoxColumn.Name = aText;
        //    textBoxColumn.DataPropertyName = aDataPropertyName;
        //    textBoxColumn.ReadOnly = aReadOnly;
        //    return textBoxColumn;
        //} 
        /// <summary>
        /// Creates column with buttons.
        /// </summary>
        /// <param name="aHeader">Header text</param>
        /// <param name="aText"> Button text</param>
        /// <param name="aButtonName">Button name</param>
        /// <returns></returns>
        private DataGridViewButtonColumn createDatagridViewButtonColumn(string aHeader, string aText, string aButtonName)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Width = 60;
            buttonColumn.HeaderText = aHeader;
            buttonColumn.Text = aText;
            buttonColumn.Name = aButtonName;
            buttonColumn.UseColumnTextForButtonValue = true;
            return buttonColumn;
        }

        ///// <summary>
        ///// Creates column with checkboxes.
        ///// </summary>
        ///// <param name = "aHeader" ></ param >
        ///// < returns ></ returns >
        //private DataGridViewCheckBoxColumn createDataGridViewCheckBoxColumn( string aHeader, string aDataPropertyName )
        //{
        //    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
        //    checkBoxColumn.HeaderText = aHeader;
        //    checkBoxColumn.Width = 60;
        //    checkBoxColumn.DataPropertyName = aDataPropertyName;
        //    return checkBoxColumn;
        //}
        #endregion

        private void clickOnRow( object sender, DataGridViewCellEventArgs e )
        {
            int row = e.RowIndex;
            if (row >= 0 )
            { 
                int ID = (int)dataGridView2.Rows [row].Cells ["iDDataGridViewTextBoxColumn"].Value; ;
                if (e.ColumnIndex==buttonColumnUpdate.Index) {
                     AquaticOrganism forProcessing = aquarium.MyList.List.Find(organism => organism.ID == ID);
                     FormUpdate form = new FormUpdate(forProcessing);
                        form.ShowDialog(this);                    
                        DialogResult result =  form.DialogResult; 
                        aquarium.MyList.updateObjectPropertiesIntoDB(forProcessing);
                        refreshBindingList();
                        if (form.DialogResult.Equals(DialogResult.Cancel))
                        {
                            this.Refresh(); 
                        }
                }  
                if (e.ColumnIndex == isMovableDataGridViewCheckBoxColumn.Index  ) { 
                    bool isMove = (bool)dataGridView2.Rows [row].Cells ["isMovableDataGridViewCheckBoxColumn"].Value ;  
                    MoveManager someObject = parentForm.ListWithMovingObjects.Find(element => element.Organism.ID == ID);
                    AquaticOrganism organismForChangeIsMovableProperties = someObject.Organism;
                    if (!organismForChangeIsMovableProperties.GetType().BaseType.Equals(typeof(Seaweed)))
                    {
                        switch (isMove)
                        {
                            case true:
                                someObject.Organism.IsMovable = false;
                                aquarium.MyList.updateObjectPropertiesIntoDB(organismForChangeIsMovableProperties);
                                break;
                            case false:
                                someObject.Organism.IsMovable = true;
                                aquarium.MyList.updateObjectPropertiesIntoDB(organismForChangeIsMovableProperties);
                                break;
                            default:
                                break;
                        }
                    } 
                } 
                if (e.ColumnIndex == buttonColumnDelete.Index  ) { 
                    DialogResult result = MessageBox.Show("Are you sure?"," Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            {
                                MoveManager mover = parentForm.ListWithMovingObjects.Find(element => element.Organism.ID == ID);


                                 //   (element.Organism != null ? element.Organism.ID : -1) == ID);
                                
                                 
                                    parentForm.ListWithMovingObjects.Remove(mover); 
                                    aquarium.MyList.List.Remove(mover.Organism);
                                    aquarium.MyList.deleteObjectFromDB(mover.Organism);
                                    parentForm.refreshTextBosesWithCounters();
                                    parentForm.drawImage();
                                    refreshBindingList();                       
                                break;
                            }
                        default:
                            break;
                    }  
                }
            }
        }


        /// <summary>
        /// Save the checkbox changes after on cell mouse up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCellMouseUp( object sender, DataGridViewCellMouseEventArgs e )
        {
            int count = aquarium.MyList.List.Count;
            if (  e.RowIndex >= -1 && e.RowIndex<= count-1)
            { 
                dataGridView2.EndEdit();
                this.Refresh();
            }
        }
        /// <summary>
        /// Only hides form when user closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hide( object sender, FormClosingEventArgs e )
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                parentForm.buttonOpenGridForm.Enabled = true;
                e.Cancel = true;
                Hide();
            }
        }

        private void DataGridForm_Load( object sender, EventArgs e )
        {
            aquariumBindingSource.ResetBindings(false);
            // TODO: This line of code loads data into the 'aquariumDatabaseDataSet.Aquarium' table. You can move, or remove it, as needed.
            this.aquariumTableAdapter.Fill(this.aquariumDatabaseDataSet.Aquarium);
           
        }

        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            int number = comboBox1.SelectedIndex;
            switch (number)
            {
                case 0:
                   // pictureBox1.Image = imgCrab;
                    break;
                case 1:
                   // pictureBox1.Image = imgFish;
                    break;
                case 2:
                   // pictureBox1.Image = imgSpirogira;
                    break;
                default:
                    break;
            }
        }
    }
}

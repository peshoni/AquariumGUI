using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseToAquaticOrganisms.Classes;
using WarehouseToAquaticOrganisms.DBClasses;
using System.Resources;
using System.Reflection;

namespace WarehouseToAquaticOrganisms
{
    public partial class ShowPersonsControl : UserControl
    {
        private DataGridViewButtonColumn buttonColumnUpdate;
        private DataGridViewButtonColumn buttonColumnDelete;
        private PersonManager _personManager;
        
        public ShowPersonsControl(PersonManager manager)
        {
            InitializeComponent();
            this._personManager = manager;
            buttonColumnUpdate = Utillity.createDatagridViewButtonColumn("Update", "update", "buttonUpdate");
            buttonColumnDelete = Utillity.createDatagridViewButtonColumn("Delete", "delete", "buttonDelete");
            dataGridView1.Columns.AddRange(buttonColumnUpdate, buttonColumnDelete);
        }
        private void DataGridForm_Load( object sender, EventArgs e )
        { 
            personBindingSource.ResetBindings(false);
            this.personTableAdapter.Fill(this.aquariumDatabaseDataSet.Person); 
        }
       
        private void clickOnRow( object sender, DataGridViewCellEventArgs e )
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                int ID = (int)dataGridView1.Rows [row].Cells ["iDDataGridViewTextBoxColumn"].Value; ;
                Person handle = _personManager.Find(element => element.ID == ID);
                if (e.ColumnIndex == buttonColumnUpdate.Index)
                {                   
                    FormPerson form = new FormPerson(handle, _personManager, this);
                    form.ShowDialog(this); 
                                
                }
                if (e.ColumnIndex==buttonColumnDelete.Index)
                {
                    ////////////////////////////////////////////////////////////////////////////////////////
                    String str = WarehouseToAquaticOrganisms.Properties.Resources.questionEN;
                  DialogResult result = MessageBox.Show(str, " Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            {
                                _personManager.Remove(handle);
                                break;
                            }
                        default:
                            break;
                    } 
                }
                refreshBindingList();
            }
        }

        public void refreshBindingList()
        { 
            this.personTableAdapter.Fill(this.aquariumDatabaseDataSet.Person);
        }
    }
}

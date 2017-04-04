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

        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn egnColumn;
        private DataGridViewTextBoxColumn addressColumn;
        private DataGridViewTextBoxColumn phoneColumn;
        private DataGridViewTextBoxColumn idColumn;

        private PersonManager _personManager;
        
        public ShowPersonsControl(PersonManager manager)
        {
            InitializeComponent();
            this._personManager = manager; 
            dataGridView1.DataSource = _personManager;

            DataGridViewUtillity.clearGrid(dataGridView1); 
            nameColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Name","columnName","Name",false);
            egnColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Egn","columnEGN", "EGN", false);
            addressColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Address","columnAddress", "Address", false);
            phoneColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Phone", "columnPhone","PhoneNumber", false);
            idColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("ID","ColumnID", "ID", false); 
            buttonColumnUpdate = DataGridViewUtillity.createDatagridViewButtonColumn("Update", "update", "buttonUpdate");
            buttonColumnDelete = DataGridViewUtillity.createDatagridViewButtonColumn("Delete", "delete", "buttonDelete");
            dataGridView1.Columns.AddRange(idColumn,nameColumn, egnColumn, addressColumn, phoneColumn, buttonColumnUpdate, buttonColumnDelete); 
        }
        private void DataGridForm_Load( object sender, EventArgs e )
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _personManager; 
        }
       
        private void clickOnRow( object sender, DataGridViewCellEventArgs e )
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                int ID = (int)dataGridView1.Rows [row].Cells ["ColumnID"].Value; ;
                Person person = _personManager.Find(element => element.ID == ID);
                if (e.ColumnIndex == buttonColumnUpdate.Index)
                {                   
                    FormPerson form = new FormPerson(person, _personManager, this);
                    form.ShowDialog(this); 
                                
                }
                if (e.ColumnIndex==buttonColumnDelete.Index)
                { 
                  string str = WarehouseToAquaticOrganisms.Properties.Resources.questionEN;
                  DialogResult result = MessageBox.Show(str, " Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            {
                                _personManager.Remove(person);
                                break;
                            }
                        default:
                            break;
                    } 
                } 
               refreshList();
            }
        }

        public void refreshList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _personManager; 
        }

        private void buttonAddPerson_Click( object sender, EventArgs e )
        {
            FormPerson form = new FormPerson(_personManager, this);
            form.ShowDialog(this);
        }
    }
}

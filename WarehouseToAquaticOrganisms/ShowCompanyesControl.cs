using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseToAquaticOrganisms.DBClasses;
using WarehouseToAquaticOrganisms.Classes;

namespace WarehouseToAquaticOrganisms
{
    public partial class ShowCompaniesControl : UserControl
    {
        private DataGridViewButtonColumn buttonColumnUpdate;
        private DataGridViewButtonColumn buttonColumnDelete;

        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn bulstatColumn;
        private DataGridViewTextBoxColumn accountPersonColumn;
        private DataGridViewTextBoxColumn addressColumn;
        private DataGridViewTextBoxColumn phoneColumn;


        private CompanyManager _companyManager;
        public ShowCompaniesControl(CompanyManager manager)
        {
            InitializeComponent();
            this._companyManager = manager;
            dataGridViewCompanyes.DataSource = manager;
            dataGridViewCompanyes.AutoGenerateColumns = false;
            dataGridViewCompanyes.Columns.Clear();

            buttonColumnUpdate = Utillity.createDatagridViewButtonColumn("Update", "update", "buttonUpdate");
            buttonColumnDelete = Utillity.createDatagridViewButtonColumn("Delete", "delete", "buttonDelete");

            idColumn = Utillity.createDatagridViewTextBoxColumn("ID", "columnID", "ID", true);
            nameColumn = Utillity.createDatagridViewTextBoxColumn("Name", "columnName", "Name", true);
            bulstatColumn = Utillity.createDatagridViewTextBoxColumn("Bulstat", "columnBulstat", "Bulstat", true);
            accountPersonColumn = Utillity.createDatagridViewTextBoxColumn("Account person", "columnAccountPerson", "Account_person", true);
            addressColumn = Utillity.createDatagridViewTextBoxColumn("Address", "columnAddress", "Address", true);
            phoneColumn = Utillity.createDatagridViewTextBoxColumn("Phone", "columnPhone", "Phone", true);


            dataGridViewCompanyes.Columns.AddRange(idColumn, nameColumn, bulstatColumn, accountPersonColumn, phoneColumn, buttonColumnUpdate, buttonColumnDelete);
        }
        private void DataGridForm_Load( object sender, EventArgs e )
        {
            Refresh();
        } 
        private void clickOnRow( object sender, DataGridViewCellEventArgs e ) 
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                int ID = (int)dataGridViewCompanyes.Rows [row].Cells ["columnID"].Value; ;
                Company handle = _companyManager.Find(element => element.ID == ID);
                if (e.ColumnIndex == buttonColumnUpdate.Index)
                {
                    FormCompany form = new FormCompany(handle, _companyManager,this);
                    form.ShowDialog(this); 
                }
                if (e.ColumnIndex == buttonColumnDelete.Index)
                {
                    String str = WarehouseToAquaticOrganisms.Properties.Resources.questionEN;
                    DialogResult result = MessageBox.Show(str, " Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            {
                                _companyManager.Remove(handle);
                                break;
                            }
                        default:
                            break;
                    }
                }
                Refresh();
             }
        }
        

        public override void Refresh()
        {
            dataGridViewCompanyes.DataSource = null;
            dataGridViewCompanyes.DataSource = _companyManager;
        }
    }
}

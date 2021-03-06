﻿using System;
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
            createGridColumns(); 
        }
 

        private void createGridColumns()
        {
            DataGridViewUtillity.clearGrid(dataGridViewCompanyes);
            buttonColumnUpdate = DataGridViewUtillity.createDatagridViewButtonColumn("Update", "update", "buttonUpdate");
            buttonColumnDelete = DataGridViewUtillity.createDatagridViewButtonColumn("Delete", "delete", "buttonDelete");

            idColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("ID", "columnID", "ID", true);
            nameColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Name", "columnName", "Name", true);
            bulstatColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Bulstat", "columnBulstat", "Bulstat", true);
            accountPersonColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Account person", "columnAccountPerson", "AcountablePerson", true);
            addressColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Address", "columnAddress", "Address", true);
            phoneColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Phone", "columnPhone", "PhoneNumber", true);
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

        private void buttonSaveNewClient_Click( object sender, EventArgs e )
        {
            using (FormCompany formCom = new FormCompany(_companyManager, this)) {
                formCom.ShowDialog(this);
            } 
        }
    }
}

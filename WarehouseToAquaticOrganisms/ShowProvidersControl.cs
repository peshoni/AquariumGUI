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
    public partial class ShowProvidersControl : UserControl 
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
        public ShowProvidersControl( CompanyManager manager )
        {
            InitializeComponent();
            this._companyManager = manager;
            dataGridViewProviders.DataSource = manager;
            dataGridViewProviders.AutoGenerateColumns = false;
            dataGridViewProviders.Columns.Clear();

            buttonColumnUpdate = DataGridViewUtillity.createDatagridViewButtonColumn("Update", "update", "buttonUpdate");
            buttonColumnDelete = DataGridViewUtillity.createDatagridViewButtonColumn("Delete", "delete", "buttonDelete");

            idColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("ID", "columnID", "ID", true);
            nameColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Name", "columnName", "Name", true);
            bulstatColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Bulstat", "columnBulstat", "Bulstat", true);
            accountPersonColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Account person", "columnAccountPerson", "Account_person", true);
            addressColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Address", "columnAddress", "Address", true);
            phoneColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Phone", "columnPhone", "Phone", true);

            dataGridViewProviders.Columns.AddRange(idColumn, nameColumn, bulstatColumn, accountPersonColumn, phoneColumn, buttonColumnUpdate, buttonColumnDelete);
        }
        private void DataGridForm_Load( object sender, EventArgs e )
        {
            dataGridViewProviders.DataSource = null;
            dataGridViewProviders.DataSource = _companyManager;
        }
        private void clickOnRow( object sender, DataGridViewCellEventArgs e )
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                int ID = (int)dataGridViewProviders.Rows [row].Cells ["columnID"].Value; ;
                Company handle = _companyManager.Find(element => element.ID == ID);
                if (e.ColumnIndex == buttonColumnUpdate.Index)
                {
                    FormCompany form = new FormCompany(handle, _companyManager, this);
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
            dataGridViewProviders.DataSource = null;
            dataGridViewProviders.DataSource = _companyManager;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            FormCompany formForProviders = new FormCompany(_companyManager, this);
            formForProviders.ShowDialog(this);
        }
    }
}

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
    public partial class ShowProvidersControl : UserControl 
    {
        private DataGridViewButtonColumn buttonColumnUpdate;
        private DataGridViewButtonColumn buttonColumnDelete;
        private CompanyManager _companyManager;
        public ShowProvidersControl( CompanyManager manager )
        {
            InitializeComponent();
            this._companyManager = manager;
            buttonColumnUpdate = Utillity.createDatagridViewButtonColumn("Update", "update", "buttonUpdate");
            buttonColumnDelete = Utillity.createDatagridViewButtonColumn("Delete", "delete", "buttonDelete");
            dataGridViewProviders.Columns.AddRange(buttonColumnUpdate, buttonColumnDelete);
        }
        private void DataGridForm_Load( object sender, EventArgs e )
        { 
            providerBindingSource.ResetBindings(false);
            this.providerTableAdapter.Fill(this.aquariumDatabaseDataSet.Provider);
        }
        private void clickOnRow( object sender, DataGridViewCellEventArgs e )
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                int ID = (int)dataGridViewProviders.Rows [row].Cells ["iDDataGridViewTextBoxColumn"].Value; ;
                Company handle = _companyManager.List.Find(element => element.ID == ID);
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
            this.providerTableAdapter.Fill(this.aquariumDatabaseDataSet.Provider);
            base.Refresh();
        }
        ////public new void Refresh()
        ////{
        ////    this.providerTableAdapter.Fill(this.aquariumDatabaseDataSet.Provider);
        ////}
        //public void refreshBindingList()
        //{
        //    this.providerTableAdapter.Fill(this.aquariumDatabaseDataSet.Provider);
        //}

    }
}

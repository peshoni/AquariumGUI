using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseToAquaticOrganisms.Contragents;
using System.Data.SqlClient;
using WarehouseToAquaticOrganisms.DBClasses;

namespace WarehouseToAquaticOrganisms
{
    public partial class MasterDetailControl : UserControl
    {
        private DataGridViewTextBoxColumn docIDColumn;
        private DataGridViewTextBoxColumn providerNameColumn;
        private DataGridViewTextBoxColumn isPaidColumn;
        private DataGridViewTextBoxColumn accountablePersonColumn;
        private DataGridViewTextBoxColumn bulstatColumn;
        private DataGridViewTextBoxColumn dateTimeColumn;
        private DataGridViewTextBoxColumn phoneColumn;


        private DataGridViewTextBoxColumn productNameColumn;
        private DataGridViewTextBoxColumn quantityColumn;

      
        private BindingList<TestDeliveryClass> bindingList;
        private BindingList<TestDeliveryClass> secondBindingList;
        private DeliveryManager2 deliveryManager;




        public MasterDetailControl()
        {
            InitializeComponent();
            deliveryManager = new DeliveryManager2();
            createMasterColumns();
            createDetailsColumns();
           
            ////////////////////////////
           

        }

        /// <summary>
        /// Master columns
        /// </summary>
        private void createMasterColumns()
        {
            docIDColumn = Utillity.createDatagridViewTextBoxColumn("Delivery number", "Document", "DocID", true);
            providerNameColumn = Utillity.createDatagridViewTextBoxColumn("Provider", "ProviderName", "ProviderName", true);
            isPaidColumn = Utillity.createDatagridViewTextBoxColumn("Is paid", "isPayidColumn", "IsPaid", true); 

            accountablePersonColumn=Utillity.createDatagridViewTextBoxColumn("Acc person", "accountablePersonColumn", "AccountablePerson", true);
            bulstatColumn=Utillity.createDatagridViewTextBoxColumn("Bulstat", "bulstatColumn", "Bulstat", true);
            dateTimeColumn=Utillity.createDatagridViewTextBoxColumn("Date", "dateTimeColumn", "DateTime", true);
            phoneColumn=Utillity.createDatagridViewTextBoxColumn("Phone number", "phoneColumn", "Phone", true);


            List<TestDeliveryClass> list = deliveryManager.getList();
            bindingList = new BindingList<TestDeliveryClass>(list);
            dataGridViewMaster.DataSource = bindingList;

            dataGridViewMaster.AutoGenerateColumns = false;
            dataGridViewMaster.Columns.Clear();

            //dataGridViewMaster.Columns.Add(docIDColumn);
            //dataGridViewMaster.Columns.Add(providerNameColumn);
            //dataGridViewMaster.Columns.Add(isPaidColumn);
            dataGridViewMaster.Columns.AddRange( new DataGridViewColumn[]{ docIDColumn, dateTimeColumn,
                providerNameColumn, bulstatColumn, accountablePersonColumn, phoneColumn, isPaidColumn });
        }
        /// <summary>
        /// Details columns
        /// </summary>
        private void createDetailsColumns()
        {
            productNameColumn = Utillity.createDatagridViewTextBoxColumn("Product", "ProductName", "ProductName", true);
            quantityColumn = Utillity.createDatagridViewTextBoxColumn("Quantity", "quantity", "Quantity", true);

            dataGridViewDetail.AutoGenerateColumns = false;
            dataGridViewDetail.Columns.Clear();

            dataGridViewDetail.Columns.Add(productNameColumn);
            dataGridViewDetail.Columns.Add(quantityColumn);
        }
        private void MasterDetailControl_Load( object sender, EventArgs e )
        {
          //  rebind();
        }
        public  void rebind()
        {
            dataGridViewMaster.DataSource = null;
            dataGridViewMaster.DataSource = bindingList;
        }

        private void dataGridViewMaster_RowEnter( object sender, DataGridViewCellEventArgs e )
        { 
           MessageBox.Show(dataGridViewMaster [e.RowIndex, docIDColumn.Index].Value.ToString());
        }

        private void dataGridViewMaster_SelectionChanged( object sender, EventArgs e )
        { 
            int index = ((DataGridView)sender).CurrentCell.RowIndex;
            DataGridViewCell cell = (DataGridViewCell)((DataGridView)sender) [docIDColumn.Index, index];
            int DocID= int.Parse(cell.Value.ToString());
            List<TestDeliveryClass> secondList = deliveryManager.getListWithDeliveryDetails(DocID);
            secondBindingList = new BindingList<TestDeliveryClass>(secondList);
            dataGridViewDetail.DataSource = secondBindingList; 
        }
    }
}

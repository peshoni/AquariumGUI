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
using System.Data.SqlClient; 
using WarehouseToAquaticOrganisms.Classes;
using Observer;

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


        private BindingList<TestDeliveryClass> bindingList;
        private BindingList<TestDeliveryClass> secondBindingList;


        private BindingList<TestDeliveryClass> deliveryList;
        private DeliveryManager2 deliveryManager;
        private CompanyManager _proviederCompanyManager;
        List<TestDeliveryClass> list;


        private Company _company;
        private Warehouse _warehouse;
      



        public MasterDetailControl(CompanyManager companyManager , Warehouse warehouse)
        {
            InitializeComponent();


            this._proviederCompanyManager = companyManager;
            this._warehouse = warehouse;
            deliveryManager = new DeliveryManager2(_warehouse);

            createMasterColumns();

            _dataGridViewDetail.AutoGenerateColumns = false;
            _dataGridViewDetail.Columns.Clear();
            _dataGridViewDetail.Columns.AddRange(createDetailsColumns());

            comboBoxChooseProvider.DataSource = _proviederCompanyManager;
            comboBoxChooseProvider.DisplayMember = "Name";

           
            // new list for creating deliveries
            deliveryList = new BindingList<TestDeliveryClass>();
         //   dataGridViewDelivery.Visible = false;

            _dataGridViewDelivery.DataSource = deliveryList;
            _dataGridViewDelivery.AutoGenerateColumns = false;
            _dataGridViewDelivery.Columns.Clear(); 
            _dataGridViewDelivery.AllowUserToAddRows = true;
            _dataGridViewDelivery.Columns.AddRange(createDeliveryColumns());

       
            
        }

        /// <summary>
        /// Creates controls for 'Delivery'.
        /// </summary>
        /// <returns></returns>
        private DataGridViewColumn [] createDeliveryColumns()
        {
            var combods = deliveryManager.getProducts();
           
            combods.Add(new TestDeliveryClass() { ProductName = "Select product" });

            DataGridViewColumn [] array = {
            Utillity.createDataGridViewComboboxColumn("Product", combods, "ProductID", "ProductName", "ProductID"),
            Utillity.createDatagridViewTextBoxColumn("Quantity", "quantity", "Quantity", false),
            Utillity.createDatagridViewTextBoxColumn("Delivery price", "Price", "DeliveryPrice", false) };
            return array;
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


             list = deliveryManager.getList().OrderByDescending(e=> e.DocID).ToList();
        //   List<TestDeliveryClass> sec = list.OrderByDescending(e => e.DocID).ToList();

            bindingList = new BindingList<TestDeliveryClass>(list);
            dataGridViewMaster.DataSource = bindingList;

            //bindingList.OrderBy(x=>x.DocID);
            dataGridViewMaster.AutoGenerateColumns = false;
            dataGridViewMaster.Columns.Clear();
            dataGridViewMaster.Columns.AddRange( new DataGridViewColumn[]{ docIDColumn, dateTimeColumn,
                providerNameColumn, bulstatColumn, accountablePersonColumn, phoneColumn, isPaidColumn });
           // this.dataGridViewMaster.Sort(dataGridViewMaster.Columns ["Document"], ListSortDirection.Descending);

        }
     /// <summary>
     /// Creates column for product info. 
     /// </summary>
     /// <returns>Array with columns for datagridview order details.</returns>
        private DataGridViewColumn [] createDetailsColumns()
        {
            DataGridViewColumn [] array = {
            Utillity.createDatagridViewTextBoxColumn("DocumentID", "DocumentID", "DocID", true),
            Utillity.createDatagridViewTextBoxColumn("Product", "ProductName", "ProductName", true),
            Utillity.createDatagridViewTextBoxColumn("Quantity", "quantity", "Quantity", true),
            Utillity.createDatagridViewTextBoxColumn("Delivery price", "DeliveryPrice", "DeliveryPrice", true)}; 
            return array;
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
            _dataGridViewDetail.DataSource = secondBindingList; 
        }

        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            int index = comboBoxChooseProvider.SelectedIndex;
            _company =  _proviederCompanyManager.ElementAt(index);
            propertyGrid1.SelectedObject = _company; 
        }

        private void button1_Click( object sender, EventArgs e )
        {

        
           _warehouse.MakeDelivery(_company, deliveryList.ToList());


            dataGridViewMaster.DataSource = null;//.Update();
            list = deliveryManager.getList().OrderByDescending(element => element.DocID).ToList();
            dataGridViewMaster.DataSource = list; 
            deliveryList.Clear();
            buttonSaveDelivery.Enabled = false;


        }

        private void dataGridViewDelivery_RowsAdded( object sender, DataGridViewRowsAddedEventArgs e )
        {
            //if (e.RowIndex>1)
            //{
            //    TestDeliveryClass test = deliveryList.ElementAt(0);
            //    MessageBox.Show(test.ProductID.ToString() + " " + deliveryList.Count.ToString());
            //}
            if (e.RowIndex>0)
            {
                 buttonSaveDelivery.Enabled = true;
            } 
        }

    }
}

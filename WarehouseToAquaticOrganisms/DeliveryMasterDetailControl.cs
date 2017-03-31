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
using System.Threading;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WarehouseToAquaticOrganisms
{
    public partial class DeliveryMasterDetailControl : UserControl
    {
        private MainForm parent;
        private BindingList<Delivery> bindingList; 
        private BindingList<Delivery> deliveryList;
        private DeliveryManager _deliveryManager;
        private CompanyManager _proviederCompanyManager;
        List<Delivery> list;
       


        private Company _company;
       // private Warehouse _warehouse; 


        public DeliveryMasterDetailControl(CompanyManager companyManager , /*Warehouse warehouse,*/ DeliveryManager deliveryManager)
        {
            InitializeComponent();

            this._proviederCompanyManager = companyManager;
            this._deliveryManager = deliveryManager;

            createMasterColumns();
            
            _dataGridViewDetail.AutoGenerateColumns = false;
            _dataGridViewDetail.Columns.Clear();
            _dataGridViewDetail.Columns.AddRange(createDetailsColumns());

            comboBoxChooseProvider.DataSource = _proviederCompanyManager;
            comboBoxChooseProvider.DisplayMember = "Name";

           
            // new list for creating deliveries
            deliveryList = new BindingList<Delivery>(); 
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
            var combods = _deliveryManager.getProducts();           
            combods.Add(new Delivery() { ProductName = "Select product" });

            DataGridViewColumn [] array = {
            DataGridViewUtillity.createDataGridViewComboboxColumn("Product", combods, "ProductID", "ProductName", "ProductID"),
            DataGridViewUtillity.createDatagridViewTextBoxColumn("Quantity", "quantity", "Quantity", false),
            DataGridViewUtillity.createDatagridViewTextBoxColumn("Delivery price", "Price", "DeliveryPrice", false) };
            return array;
        }

        /// <summary>
        /// Master columns
        /// </summary>
        private void createMasterColumns()
        {
            DataGridViewColumn [] array = {
             DataGridViewUtillity.createDatagridViewTextBoxColumn("Delivery number", "Document", "DocID", true),
             DataGridViewUtillity.createDatagridViewTextBoxColumn("Provider", "ProviderName", "ProviderName", true),
             DataGridViewUtillity.createDatagridViewTextBoxColumn("Is paid", "isPayidColumn", "IsPaid", true),
             DataGridViewUtillity.createDatagridViewTextBoxColumn("Acc person", "accountablePersonColumn", "AccountablePerson", true),
             DataGridViewUtillity.createDatagridViewTextBoxColumn("Bulstat", "bulstatColumn", "Bulstat", true),
             DataGridViewUtillity.createDatagridViewTextBoxColumn("Date", "dateTimeColumn", "DateTime", true),
             DataGridViewUtillity.createDatagridViewTextBoxColumn("Phone number", "phoneColumn", "Phone", true)
            }; 

            list = _deliveryManager.getList(DateTime.Today,null).OrderByDescending(e=> e.DocID).ToList(); 
            bindingList = new BindingList<Delivery>(list);
            dataGridViewMaster.DataSource = bindingList; 
            dataGridViewMaster.AutoGenerateColumns = false;
            dataGridViewMaster.Columns.Clear();
            dataGridViewMaster.Columns.AddRange(array); 
        }
     /// <summary>
     /// Creates column for product info. 
     /// </summary>
     /// <returns>Array with columns for datagridview order details.</returns>
        private DataGridViewColumn [] createDetailsColumns()
        {
            DataGridViewColumn [] array = {
            DataGridViewUtillity.createDatagridViewTextBoxColumn("DocumentID", "DocumentID", "DocID", true),
            DataGridViewUtillity.createDatagridViewTextBoxColumn("Product", "ProductName", "ProductName", true),
            DataGridViewUtillity.createDatagridViewTextBoxColumn("Quantity", "quantity", "Quantity", true),
            DataGridViewUtillity.createDatagridViewTextBoxColumn("Delivery price", "DeliveryPrice", "DeliveryPrice", true)}; 
            return array;
        }
        private void MasterDetailControl_Load( object sender, EventArgs e )
        {
           rebind();
        }
        public  void rebind()
        {
            dataGridViewMaster.DataSource = null;
            dataGridViewMaster.DataSource = bindingList;
        }

        /// <summary>
        /// Catch delivery ID by selected row and shows details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMaster_SelectionChanged( object sender, EventArgs e )
        { 
            int index = ((DataGridView)sender).CurrentCell.RowIndex;
            DataGridViewCell cell = (DataGridViewCell)((DataGridView)sender) [dataGridViewMaster.Columns["Document"].Index, index];
            int DocID= int.Parse(cell.Value.ToString()); 
            _dataGridViewDetail.DataSource = new BindingList<Delivery>(_deliveryManager.getListWithDeliveryDetails(DocID)); 
        }
        /// <summary>
        /// Visualize choosen company properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxChooseProvider_SelectedIndexChanged( object sender, EventArgs e )
        { 
            _company = _proviederCompanyManager.ElementAt(comboBoxChooseProvider.SelectedIndex);
            propertyGrid1.SelectedObject = _company;
        }
        /// <summary>
        /// Save delivery by Warehouse. Visualize changed list with deliveries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveDelivery_Click( object sender, EventArgs e )
        {
            _deliveryManager.makeDelivery(_company, deliveryList.ToList());
            RefreshDataGridWithMasterValues(DateTime.Now,null); 
            deliveryList.Clear();
            buttonSaveDelivery.Enabled = false;
        }

        private void dateTimePickerSearch_ValueChanged( object sender, EventArgs e )
        {
          RefreshDataGridWithMasterValues(dateTimePickerSearch.Value,null);//   Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
          
          //  MessageBox.Show(dateTimePickerSearch.Value.ToShortDateString() + "plus one day " + dateTimePickerSearch.Value.AddDays(1).ToShortDateString());

        }
        private void RefreshDataGridWithMasterValues(DateTime dateTime, string nameClause)
        {
            dataGridViewMaster.DataSource = null;
            list = _deliveryManager.getList(dateTime, nameClause).OrderByDescending(element => element.DocID).ToList();
            dataGridViewMaster.DataSource = list;
        }

        /// <summary>
        /// If one rows added, unlock save button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDelivery_RowsAdded( object sender, DataGridViewRowsAddedEventArgs e )
        {

            if (e.RowIndex > 0)
            {
                buttonSaveDelivery.Enabled = true; 
            }  
        }
        /// <summary>
        /// Lock save button if grid is empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _dataGridViewDelivery_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
        {
            if (e.RowIndex==0)
            {
                buttonSaveDelivery.Enabled = false;
            }
        }

        private void groupBox1_Enter( object sender, EventArgs e )
        {

        }

        private void textBoxSearchName_TextChanged( object sender, EventArgs e )
        { 
            RefreshDataGridWithMasterValues(DateTime.Now, textBoxSearchName.Text); 
        }
    }
}

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
using System.Globalization;

namespace WarehouseToAquaticOrganisms
{
    public partial class SalesMasterDetailControl : UserControl
    {
        private enum TypeOfPartner {Type = 0, Person = 1, Company = 2 }
       // private DataGridViewTextBoxColumn _productId;
        private DataGridViewTextBoxColumn _productName;
        private DataGridViewTextBoxColumn _quantity;
        private DataGridViewTextBoxColumn _averagePrice;
        /// <summary>
        /// //////////////////////////////////////////////////////////////// opravi kato napravish tablica v bazata
        /// </summary>
     //   private enum Goods { Fish, Crab, Seaweed}
        private PersonManager _personManager;
        private CompanyManager _companyManager;
        private DeliveryManager _deliveryManager;
        private SaleManager _saleManager;
        private ComboBox personCombo;
        private ComboBox companyCombo;
        private static decimal percentProfit;

      //  private decimal suma;
       // private decimal total;
        private System.Drawing.Point hide=new System.Drawing.Point(-100, -100);
        private BindingList<Sale> saleList;
        private BindingList<Sale> statisticList;


        private DataGridViewTextBoxColumn textColumnProductId;
        private DataGridViewTextBoxColumn textColumnArticle;
        private DataGridViewTextBoxColumn textColumnPieces; 
        private DataGridViewTextBoxColumn textColumnPrice;
        //  private DataGridViewTextBoxColumn textColumnVAT;
     //   private DataGridViewComboBoxColumn comboWithArticles;

        /// <summary>
        /// company Master columns
        /// </summary>
        private DataGridViewTextBoxColumn masterCompanyNameColumn;
        private DataGridViewTextBoxColumn masterCompanyBulstatColumn;
        private DataGridViewCheckBoxColumn masterIsPaidColumn; 
        private DataGridViewTextBoxColumn masterDocID;
        /// <summary>
        ///  company detail column
        /// </summary>
        private DataGridViewTextBoxColumn detailProductName;
        private DataGridViewTextBoxColumn detailDocId;
        private DataGridViewTextBoxColumn detailQuantity;
        private DataGridViewTextBoxColumn detailSalePrice;

        private Partner partner;

        public SalesMasterDetailControl(PersonManager personManager, CompanyManager companyManager,DeliveryManager deliveryManager,SaleManager salesManager)
        {
            InitializeComponent();
            this._personManager = personManager;
            this._companyManager = companyManager;
            this._deliveryManager = deliveryManager;
            this._saleManager = salesManager;
            comboBox1.DataSource = Enum.GetValues(typeof(TypeOfPartner));  
            loadComboBoxes();
            percentProfit = 10.00m;
            maskedTextBox1.Text = percentProfit.ToString();

            createAvailableGridContent();
            createSaleGrid();

            createMasterGrid();
            cerateDetailGrid();
        }


        private void createMasterGrid()
        {
           clearGrid(dataGridViewMaster);
            masterCompanyNameColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Company", "CompanyName", "CompanyName", true);
            masterCompanyBulstatColumn = DataGridViewUtillity.createDatagridViewTextBoxColumn("Bulstat", "CompanyBulstat", "CompanyBulstat", true);
            masterIsPaidColumn = DataGridViewUtillity.createDataGridViewCheckBoxColumn("Is paid", "Is paid", "IsPaid", false);
            masterIsPaidColumn.ReadOnly = true;
            masterDocID=DataGridViewUtillity.createDatagridViewTextBoxColumn("ID", "DocumentId", "DocId", false);
             
             //   clearGrid(dataGridViewDetail);
            dataGridViewMaster.Columns.AddRange(new DataGridViewColumn [] { masterDocID,masterCompanyNameColumn, masterCompanyBulstatColumn , masterIsPaidColumn });

            loadMasterInfo();
           

        }

        private void loadMasterInfo()
        {
            statisticList = new BindingList<Sale>(_saleManager.getListWithCompanySales()); 
            dataGridViewMaster.DataSource = statisticList;
            dataGridViewMaster.Refresh();
        }

        /// <summary>
        /// Creates detail grid
        /// </summary>
        private void cerateDetailGrid()
        {           
            clearGrid(dataGridViewDetail);
            detailDocId = DataGridViewUtillity.createDatagridViewTextBoxColumn("ID", "DocId", "DocId", true);
            detailProductName = DataGridViewUtillity.createDatagridViewTextBoxColumn("Product", "ProductName", "ProductName", true); 
            detailQuantity= DataGridViewUtillity.createDatagridViewTextBoxColumn("Quantity", "Quantity", "Quantity", true);
            detailSalePrice= DataGridViewUtillity.createDatagridViewTextBoxColumn("Price", "SalePrice", "SalePrice", true);
            dataGridViewDetail.Columns.AddRange(new DataGridViewColumn [] {detailDocId,detailProductName,detailQuantity,detailSalePrice});  
        }

  
       

        private void createSaleGrid()
        {
            // textColumnNumberOfRow= Utillity.createDatagridViewTextBoxColumn("Product", "ProductID", "ProductName", true);
            textColumnProductId = DataGridViewUtillity.createDatagridViewTextBoxColumn("ID", "ProductID", "ProductId", true);
            textColumnArticle = DataGridViewUtillity.createDatagridViewTextBoxColumn("Product", "ProductID", "ProductName", true);
            textColumnPieces = DataGridViewUtillity.createDatagridViewTextBoxColumn("Quantity", "Quantity", "Quantity", false);
            textColumnPrice = DataGridViewUtillity.createDatagridViewTextBoxColumn("Sale Price", "SalePrice", "SalePrice", true);
            this.textColumnPrice.DefaultCellStyle = getPriceStyle();
            dataGridViewSaleList.AllowUserToAddRows = false;
            clearGrid(dataGridViewSaleList);
            dataGridViewSaleList.Columns.AddRange(new DataGridViewColumn [] { textColumnProductId, textColumnArticle, textColumnPieces  , textColumnPrice });

            saleList = new BindingList<Sale>();
            dataGridViewSaleList.DataSource = saleList;
           // createMasterGrid();
            enableSaleProperies(false);
        }
/// <summary>
/// Enable or disable grid for sales.
/// </summary>
/// <param name="enabled"></param>
        private void enableSaleProperies(bool enabled)
        {
            if (enabled)
            {
            dataGridViewSaleList.Show();
            tableLayoutPanel1.Show();
            buttonSave.Show();
            } else { 
            dataGridViewSaleList.Hide();
            tableLayoutPanel1.Hide();
            buttonSave.Hide();
            }
        }

        private void createAvailableGridContent()
        {
          
            _productName = DataGridViewUtillity.createDatagridViewTextBoxColumn("Product", "ProductName", "ProductName", true);
            _quantity = DataGridViewUtillity.createDatagridViewTextBoxColumn("Quantity", "quantity", "Quantity", false);
            _averagePrice= DataGridViewUtillity.createDatagridViewTextBoxColumn("Delivery price", "Price", "DeliveryPrice", false);          
            this._averagePrice.DefaultCellStyle = getPriceStyle();  

            clearGrid(dataGridViewAvailable);

            dataGridViewAvailable.Columns.AddRange(new DataGridViewColumn[] { _productName, _quantity, _averagePrice });
            dataGridViewAvailable.DataSource = _deliveryManager.GetAvailableProductsproperties();
            dataGridViewAvailable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick); 
        }
        /// <summary>
        /// Setter method for Currency style of DataGridViewTextBox column.
        /// </summary>
        /// <returns><see cref="DataGridViewCellStyle"/></returns>
        private DataGridViewCellStyle getPriceStyle(){
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0,00";
            return dataGridViewCellStyle1;
        } 
        private void clearGrid( DataGridView dataGridView )
        {
            if (dataGridView != null)
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.Columns.Clear();
            }
        } 
        private void dataGridView2_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            int row = e.RowIndex; 
            List<Delivery> availableProductsList = _deliveryManager.GetAvailableProductsproperties();
            Delivery choosenObject = availableProductsList.ElementAt(row);
            Sale newRowOfSaleList = new Sale();
            newRowOfSaleList.ProductId = choosenObject.ProductID;
            newRowOfSaleList.ProductName = choosenObject.ProductName;  
            newRowOfSaleList.DeliveryPrice = choosenObject.DeliveryPrice;
            newRowOfSaleList.SalePrice = choosenObject.DeliveryPrice * ((percentProfit / 100) + 1); 

            refreshSaleList(); 
            saleList.Add(newRowOfSaleList); 
        } 
        private void loadComboBoxes()
        {
            personCombo = new ComboBox();
            personCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;//.DropDownList;
            personCombo.Location = hide;
            personCombo.SelectedIndexChanged += new System.EventHandler(this.personCombo_SelectedIndexChanged);
            this.splitContainer3.Panel1.Controls.Add(personCombo);
            

            companyCombo = new ComboBox();
            companyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;// List;
            companyCombo.Location = hide;
            companyCombo.SelectedIndexChanged += new System.EventHandler(this.companyCombo_SelectedIndexChanged);
            this.splitContainer3.Panel1.Controls.Add (companyCombo);
        }

        private void personCombo_SelectedIndexChanged( object sender, EventArgs e )
        { 
            partner = _personManager.ElementAt(personCombo.SelectedIndex);
            propertyGridSelectedClient.SelectedObject = partner; 
        }

        private void companyCombo_SelectedIndexChanged( object sender, EventArgs e )
        { 
            partner = _companyManager.ElementAt(companyCombo.SelectedIndex);
            propertyGridSelectedClient.SelectedObject = partner; 
        }

        public  void RefreshLists()
        {
            personCombo.DataSource = _personManager; 
            personCombo.DisplayMember = "Name";

            companyCombo.DataSource = _companyManager; 
            companyCombo.DisplayMember = "Name";
        }
        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        { 
            TypeOfPartner type = (TypeOfPartner)comboBox1.SelectedItem; 
            switch (type)
            {
                case TypeOfPartner.Person:
                    RefreshLists(); 
                    personCombo.Location = new System.Drawing.Point(comboBox1.Location.X, comboBox1.Location.Y + 30);
                    companyCombo.Location = hide; 
                    break;
                case TypeOfPartner.Company:
                    RefreshLists();
                    companyCombo.Location = new System.Drawing.Point(comboBox1.Location.X, comboBox1.Location.Y + 30);
                    personCombo.Location = hide; 
                    break;
                default:
                    break; 
            }
            enableSaleProperies(true);
            this.Update(); 
        } 
        /// <summary>
        /// Save created sale list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click( object sender, EventArgs e )
        {
            saleList.ToList().ForEach(element => element.Quantity *=-1);
            _saleManager.makeSale(partner, saleList.ToList());
            saleList.Clear();
            loadMasterInfo();
        }

        private void dataGridView1_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            //int row = e.RowIndex;
            //if (row >= 0)
            //{
            //   // int ID = (int)dataGridView1.Rows [row].Cells ["iDDataGridViewTextBoxColumn"].Value; ;
            //    if (e.ColumnIndex == columnPieces.Index)
            //    {
            //        DataGridViewRow done = dataGridView1.Rows [row];
            //        MessageBox.Show(done.Cells[2].Value.ToString());
            //    }
                
               
            //}
        }
        /// <summary>
        /// Calculates sum of sale if grid state is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellEndEdit( object sender, DataGridViewCellEventArgs e )
        { 
            int row = e.RowIndex;
            if (row >= 0)
            { 
                if (e.ColumnIndex == textColumnPieces.Index) 
                {
                    calculate(); 
                } 
            }
        }

       

        private void refreshSaleList()
        {
            dataGridViewSaleList.DataSource = null;
            dataGridViewSaleList.DataSource = saleList;
        }
 

        private void maskedTextBox1_KeyEnterPress( object sender, KeyEventArgs e )
        {
            e.Handled = e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
            {
                decimal.TryParse(maskedTextBox1.Text, out percentProfit);
                saleList.ToList().ForEach(element =>
                {
                    element.SalePrice = element.DeliveryPrice * ((percentProfit / 100) + 1);
                });
                refreshSaleList();
                calculate();
            }
        }
        /// <summary>
        /// Calculates sum of all rows and adds VAT.
        /// </summary>
        private void calculate()
        {
            decimal suma = 0.0m;
            decimal total;
            saleList.ToList().ForEach(
                element => {
                    suma += (element.Quantity * element.SalePrice);
                });
            total = suma * 1.2m;
            textBox1.Text = Math.Round(suma, 2).ToString();
            textBox2.Text = Math.Round((total - suma), 2).ToString();
            textBox3.Text =/* String.Format(CultureInfo.CurrentCulture, "{0:C0}", Math.Round(total, 2));//*/Math.Round(total, 2).ToString();
        }
        private void MasterDetailControl_Load( object sender, EventArgs e )
        {

            dataGridViewAvailable.DataSource = null;
            dataGridViewAvailable.DataSource = _deliveryManager.GetAvailableProductsproperties();
 
            dataGridViewMaster.DataSource = null;
            dataGridViewMaster.DataSource = statisticList;
            

        }
        /// <summary>
        /// Shows details of given document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMaster_SelectionChanged( object sender, EventArgs e )
        {
            int index = ((DataGridView)sender).CurrentCell.RowIndex;
            DataGridViewCell cell = (DataGridViewCell)((DataGridView)sender) [dataGridViewMaster.Columns ["DocumentId"].Index, index];
            int DocID = int.Parse(cell.Value.ToString());
            dataGridViewDetail.DataSource = new BindingList<Sale>(_saleManager.getListWithSaleCompanyDetails(DocID));
        }
 
    }
}

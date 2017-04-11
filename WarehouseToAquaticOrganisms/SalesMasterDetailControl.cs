using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using DataGridViewPercentTextBoxColumn;
using iTextSharp.text;
using iTextSharp.text.pdf;
using WarehouseToAquaticOrganisms.Classes;
using WarehouseToAquaticOrganisms.DBClasses;
using CustomTextBox1;
using FishGUI;

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
        private BindingList<Sale> statisticCompanyList;
        private BindingList<Sale> statisticPersonList;
        private List<Delivery> chooseList;



        private DataGridViewTextBoxColumn textColumnProductId;
        private DataGridViewTextBoxColumn textColumnArticle;
        private DataGridViewTextBoxColumn textColumnPieces; 
        private DataGridViewTextBoxColumn textColumnPrice;
        private DataGridViewTextBoxColumn textRowSum;
        private DataGridTextPercentColumn percentColumn;
        //  private DataGridViewTextBoxColumn textColumnVAT;
        //   private DataGridViewComboBoxColumn comboWithArticles;


        ///// <summary>
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
            chooseList = new List<Delivery>();
            createMasterGridCompanies();
            createMasterGridPersons();
            cerateDetailGrid();

            loadTree();
            treeView1.ExpandAll(); 

            CustomTextBoxcs control = new CustomTextBoxcs(); 
            control.LabelText = "asdad";

            control.HoverColor = Color.Bisque;
            control.Width = 300;
             
            this.splitContainerFooter.Panel1.Controls.Add(control);



          //  control.
           // this.control

        }

        /// <summary>
        /// Creates Pesrons master grid.
        /// </summary>
        private void createMasterGridPersons()
        {  
            DataGridViewUtillity.clearGrid(dataGridViewMasterPersons);
            dataGridViewMasterPersons.Columns.AddRange(new DataGridViewColumn [] {
            DataGridViewUtillity.createDatagridViewTextBoxColumn("ID", "DocumentId", "DocId", false),
            DataGridViewUtillity.createDatagridViewTextBoxColumn("Person", "PersonName", "PersonName", true),
            DataGridViewUtillity.createDatagridViewTextBoxColumn("EGN", "EGN", "Egn", true),
            DataGridViewUtillity.createDataGridViewCheckBoxColumn("Is paid", "Is paid", "IsPaid", true)});
            loadPersonMasterInfo();
        } 
        /// <summary>
        /// Creates Company master grid.
        /// </summary>
        private void createMasterGridCompanies()
        {
            DataGridViewUtillity.clearGrid(dataGridViewMasterCompanies); 
            dataGridViewMasterCompanies.Columns.AddRange(new DataGridViewColumn [] {
            DataGridViewUtillity.createDatagridViewTextBoxColumn("ID", "DocumentId", "DocId", false),
            DataGridViewUtillity.createDatagridViewTextBoxColumn("Company", "CompanyName", "CompanyName", true),
            DataGridViewUtillity.createDatagridViewTextBoxColumn("Bulstat", "CompanyBulstat", "CompanyBulstat", true),
            DataGridViewUtillity.createDataGridViewCheckBoxColumn("Is paid", "Is paid", "IsPaid", true),           
            DataGridViewUtillity.createDataGridViewCheckBoxColumn("Invoice", "Invoice", "isTheInvoiceIssued", false)}); 
            loadCompanyMasterInfo(); 
        } 
        private void loadCompanyMasterInfo()
        {
            statisticCompanyList = new BindingList<Sale>(_saleManager.getListWithCompanySales()); 
            dataGridViewMasterCompanies.DataSource = statisticCompanyList;
            dataGridViewMasterCompanies.Refresh();
        }
        private void loadPersonMasterInfo()
        {
            statisticPersonList = new BindingList<Sale>(_saleManager.getListWithPersonSales());
            dataGridViewMasterPersons.DataSource = statisticPersonList;
            dataGridViewMasterPersons.Refresh();
        }
        /// <summary>
        /// Creates detail grid
        /// </summary>
        private void cerateDetailGrid()
        {      
            DataGridViewUtillity.clearGrid(dataGridViewDetail);
            detailDocId = DataGridViewUtillity.createDatagridViewTextBoxColumn("ID", "DocId", "DocId", true);
            detailProductName = DataGridViewUtillity.createDatagridViewTextBoxColumn("Product", "ProductName", "ProductName", true); 
            detailQuantity= DataGridViewUtillity.createDatagridViewTextBoxColumn("Quantity", "Quantity", "Quantity", true);
            detailSalePrice= DataGridViewUtillity.createDatagridViewTextBoxColumn("Price", "SalePrice", "SalePrice", true);
            dataGridViewDetail.Columns.AddRange(new DataGridViewColumn [] {detailDocId,detailProductName,detailQuantity,detailSalePrice});  
        } 
        private void createSaleGrid()
        {
            textColumnProductId = DataGridViewUtillity.createDatagridViewTextBoxColumn("ID", "ProductID", "ProductId", true);
           // textColumnProductId.Width = 50;
            textColumnArticle = DataGridViewUtillity.createDatagridViewTextBoxColumn("Product", "ProductID", "ProductName", true);
            textColumnPieces = DataGridViewUtillity.createDatagridViewTextBoxColumn("Quantity", "Quantity", "Quantity", false);
          //  textColumnPieces.Width = 50;
            textColumnPrice = DataGridViewUtillity.createDatagridViewTextBoxColumn("Sale Price", "SalePrice", "SalePrice", true);

            textRowSum = DataGridViewUtillity.createDatagridViewTextBoxColumn("Sum", "RowSum", "RowSum",true);
            textRowSum.DefaultCellStyle = DataGridViewUtillity.getPriceStyle();

            textColumnPrice.DefaultCellStyle = DataGridViewUtillity.getPriceStyle();
            dataGridViewSaleList.AllowUserToAddRows = false;
            DataGridViewUtillity.clearGrid(dataGridViewSaleList);


            percentColumn = new DataGridTextPercentColumn(  "%", "PercentOfRow",100);
          


            dataGridViewSaleList.Columns.AddRange(new DataGridViewColumn [] 
            { textColumnProductId, textColumnArticle, textColumnPieces, textColumnPrice, textRowSum ,percentColumn });

            saleList = new BindingList<Sale>();
          //  dataGridViewSaleList.DataSource = saleList;
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
            dataGridViewSaleList.Enabled = true; 
            tableLayoutPanel1.Enabled = true; 
            buttonSave.Enabled = true; 
            } else { 
            dataGridViewSaleList.Enabled=false;
            tableLayoutPanel1.Enabled = false; 
            buttonSave.Enabled = false; 
            }
        }
        #region TreeView
        private void loadTree()
        {
            List<Delivery> categoryList = _deliveryManager.GetListWithCategories();
            chooseList = _deliveryManager.GetAvailableProductsproperties();
            ///////////////////////////////
            //////////////////////////////////////////////////
            //////////////////////////////////////////////////////////

            categoryList.ForEach(element => {
                treeView1.Nodes.Add(new TreeNode(element.Category));
            }); 

            chooseList.ForEach(element=> {
                TreeNode parent = findCategory(element.CategoryId);
              
                parent.Nodes.Add(element.ProductName);
            }); 
        }

        private TreeNode findCategory( int categoryId )
        {
            TreeNode parent = treeView1.Nodes[categoryId];
            return parent;
        }

        private void treeView1_AfterSelect_1( object sender, TreeViewEventArgs e )
        {
            Delivery del = chooseList.FirstOrDefault(element => element.ProductName.Equals(e.Node.Text));
            this.propertyGrid1.SelectedObject = del;



            Sale newRowOfSaleList = new Sale();
            newRowOfSaleList.ProductId = del.ProductID;
            newRowOfSaleList.ProductName = del.ProductName;
            newRowOfSaleList.DeliveryPrice = del.DeliveryPrice;
            newRowOfSaleList.SalePrice = del.DeliveryPrice * ((percentProfit / 100) + 1);

            refreshSaleList();
            saleList.Add(newRowOfSaleList);
        }
     
           private void treeView1_DoubleClick( object sender, EventArgs e )
        {

        }
        private void treeView1_MouseDoubleClick( object sender, MouseEventArgs e )
        {

        }
        #endregion
        private void createAvailableGridContent()
        {
            DataGridViewUtillity.clearGrid(dataGridViewAvailable);
            _productName = DataGridViewUtillity.createDatagridViewTextBoxColumn("Product", "ProductName", "ProductName", true);
            _quantity = DataGridViewUtillity.createDatagridViewTextBoxColumn("Quantity", "quantity", "Quantity", false);
            _averagePrice= DataGridViewUtillity.createDatagridViewTextBoxColumn("Delivery price", "Price", "DeliveryPrice", false);          
            this._averagePrice.DefaultCellStyle = DataGridViewUtillity.getPriceStyle(); 

            dataGridViewAvailable.Columns.AddRange(new DataGridViewColumn[] { _productName, _quantity, _averagePrice }); 
            dataGridViewAvailable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            dataGridViewAvailable.DataSource = _deliveryManager.GetAvailableProductsproperties();
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
            personCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown; 
            personCombo.Location = hide;
            personCombo.SelectedIndexChanged += new System.EventHandler(this.personCombo_SelectedIndexChanged);
            this.splitContainerSaleAndMaster.Panel1.Controls.Add(personCombo); 

            companyCombo = new ComboBox();
            companyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown; 
            companyCombo.Location = hide;
            companyCombo.SelectedIndexChanged += new System.EventHandler(this.companyCombo_SelectedIndexChanged);
            this.splitContainerSaleAndMaster.Panel1.Controls.Add (companyCombo);
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
                    tabControl1.SelectedTab = tabControl1.TabPages [1];
                    break;
                case TypeOfPartner.Company:
                    RefreshLists();
                    companyCombo.Location = new System.Drawing.Point(comboBox1.Location.X, comboBox1.Location.Y + 30);
                    personCombo.Location = hide; 
                    tabControl1.SelectedTab = tabControl1.TabPages [0];
                    break;
                default:
                    break; 
            }
            labelName.Text = "";
            labelBullstat.Text ="";
            labelAddress.Text = "";
            enableSaleProperies(true);
            this.Update(); 
        }
        /// <summary>
        /// Gets object <see cref="Person"/> from <see cref="PersonManager"/> list. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personCombo_SelectedIndexChanged( object sender, EventArgs e )
        {
            Person partner = _personManager.ElementAt(personCombo.SelectedIndex);
            labelName.Text = partner.Name;
            labelBullstat.Text = partner.Egn.ToString();
            labelAddress.Text = partner.Address;
          //  propertyGridSelectedClient.SelectedObject = partner;
        }

        private void companyCombo_SelectedIndexChanged( object sender, EventArgs e )
        {
            Company partner = _companyManager.ElementAt(companyCombo.SelectedIndex);
            labelName.Text = partner.Name;
            labelBullstat.Text = partner.Bulstat;
            labelAddress.Text = partner.Address; 
            // propertyGridSelectedClient.SelectedObject = partner;
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
            Thread.Sleep(500);
            loadCompanyMasterInfo();
            loadPersonMasterInfo(); 
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
                    refreshSaleList();
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
          //  int rows = 1;
            decimal suma = 0.0m;
            decimal rowSum;
            decimal total;
            
            saleList.ToList().ForEach(
                element => {
                    rowSum = (element.Quantity * element.SalePrice);
                    suma += rowSum;
                    element.RowSum =  rowSum ;
                }); 
            saleList.ToList().ForEach(element => {
                rowSum = (element.Quantity * element.SalePrice);
                element.PercentOfRow =Math.Round(((rowSum / suma) * 100),2);
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
 
            dataGridViewMasterCompanies.DataSource = null;
            dataGridViewMasterCompanies.DataSource = statisticCompanyList;

            dataGridViewMasterPersons.DataSource = null;
            dataGridViewMasterPersons.DataSource = statisticPersonList; 
        }
        /// <summary>
        /// Shows details by document ID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMaster_SelectionChanged( object sender, EventArgs e )
        {
            
            int index = ((DataGridView)sender).CurrentCell.RowIndex;
            DataGridViewCell cell = (DataGridViewCell)((DataGridView)sender) [dataGridViewMasterCompanies.Columns ["DocumentId"].Index, index];
            int DocID = int.Parse(cell.Value.ToString()); 
            dataGridViewDetail.DataSource = new BindingList<Sale>(_saleManager.getListWithSaleCompanyDetails(DocID));
            
        } 


        private void groupBox2_MouseHover( object sender, EventArgs e )
        {
            if (!dataGridViewSaleList.Enabled)
            {
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                
                this.groupBox2.Focus();
                ToolTip1.SetToolTip(this.groupBox2, "Please, choose contragent"); 
            }
        }
     
        #region PDF  writer
        private void tabControl1_SelectedIndexChanged( object sender, EventArgs e )
        {
            dataGridViewDetail.DataSource = null;
            dataGridViewDetail.Refresh();
            //TabControl a = (TabControl)sender;
            //switch (a.SelectedTab.Tag.ToString())
            //{
            //    case "0":
                   
            //        this.dataGridViewMasterCompanies.SelectionChanged += dataGridViewMaster_SelectionChanged; 
            //        break;
            //    case "1":
            //        dataGridViewMasterPersons.MultiSelect = false;
            //        //this.dataGridViewMasterPersons.Rows [0].Selected = true;
            //        this.dataGridViewMasterPersons.SelectionChanged += dataGridViewMaster_SelectionChanged;
            //        //  this.dataGridViewMasterCompanies.ClearSelection();
            //        break;
            //    default:
            //        break;
            //}
           
        }
        private void buttonPDF_Click( object sender, EventArgs e )
        { 
            captureForm(this.groupBox2);
        }

        private void captureForm( GroupBox groupBox2 )
        {
            try
            {
                System.Drawing.Rectangle bounds = groupBox2.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    groupBox2.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));
                    
                    using (Bitmap resized = new Bitmap( (int)((float)bitmap.Width / 1.5f), (int)((float)bitmap.Height / 1.5f)) )
                    {
                        using (Graphics g = Graphics.FromImage(resized))
                        {
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            g.DrawImage(bitmap, 0, 0, resized.Width, resized.Height);
                        }
                        resized.Save("D:\\GroupBoxImage.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        exportPDF(resized);
                    }
                }  
            }  
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            } 
        }
        public void exportPDF( Bitmap img )
        { 
          //  System.Drawing.Image image = img; 
            Document doc = new Document(PageSize.A4 );
            PdfAWriter.GetInstance(doc, new FileStream("D://image.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(img,
                    System.Drawing.Imaging.ImageFormat.Bmp);
            doc.Add(pdfImage);
            doc.Close();
        }




        #endregion

        private void dataGridViewSaleList_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
        {
            calculate();
        }
    }
}

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
    public partial class SalesControl : UserControl
    {
        private enum TypeOfPartner {Type = 0, Person = 1, Company = 2 }
        private DataGridViewTextBoxColumn _productName;
        private DataGridViewTextBoxColumn _quantity;
        private DataGridViewTextBoxColumn _averagePrice;
        /// <summary>
        /// //////////////////////////////////////////////////////////////// opravi kato napravish tablica v bazata
        /// </summary>
     //   private enum Goods { Fish, Crab, Seaweed}
        private PersonManager _personManager;
        private CompanyManager _companyManager;
        private DeliveryManager2 _deliveryManager;
        private ComboBox personCombo;
        private ComboBox companyCombo;
        private static decimal percentProfit;

      //  private decimal suma;
       // private decimal total;
        private System.Drawing.Point hide;


        private BindingList<SaleTestClass> saleList;

        private DataGridViewTextBoxColumn textColumnNumberOfRow;
        private DataGridViewTextBoxColumn textColumnArticle;
        private DataGridViewTextBoxColumn textColumnPieces; 
        private DataGridViewTextBoxColumn textColumnPrice;
      //  private DataGridViewTextBoxColumn textColumnVAT;
     //   private DataGridViewComboBoxColumn comboWithArticles;


        public SalesControl(PersonManager personManager, CompanyManager companyManager,DeliveryManager2 deliveryManager)
        {
            InitializeComponent();
         //   RefreshLists();
            _personManager = personManager;
            _companyManager = companyManager;
            this._deliveryManager = deliveryManager;
            comboBox1.DataSource = Enum.GetValues(typeof(TypeOfPartner)); 
            hide = new System.Drawing.Point(-100, -100);
            loadComboBoxes();
            percentProfit = 10.00m;
            maskedTextBox1.Text = percentProfit.ToString();
            //////////////////////////////////////////////


            //CreateTable();

            createAvailableGridContent();

            createSaleGrid();
           
        }

        private void createSaleGrid()
        {
           // textColumnNumberOfRow= Utillity.createDatagridViewTextBoxColumn("Product", "ProductID", "ProductName", true);
            textColumnArticle = Utillity.createDatagridViewTextBoxColumn("Product", "ProductID", "ProductName", true);
            textColumnPieces = Utillity.createDatagridViewTextBoxColumn("Quantity", "Quantity", "Quantity", false);
            textColumnPrice = Utillity.createDatagridViewTextBoxColumn("Sale Price", "SalePrice", "SalePrice", true);
            this.textColumnPrice.DefaultCellStyle = getPriceStyle();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.AddRange(new DataGridViewColumn [] { textColumnArticle, textColumnPieces  , textColumnPrice });

            saleList = new BindingList<SaleTestClass>();
            dataGridView1.DataSource = saleList;
        }

        private void createAvailableGridContent()
        {
            _productName = Utillity.createDatagridViewTextBoxColumn("Product", "ProductID", "ProductName", true);
            _quantity = Utillity.createDatagridViewTextBoxColumn("Quantity", "quantity", "Quantity", false);
            _averagePrice= Utillity.createDatagridViewTextBoxColumn("Delivery price", "Price", "DeliveryPrice", false);
          
            this._averagePrice.DefaultCellStyle = getPriceStyle();  
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { _productName, _quantity, _averagePrice });
            dataGridView2.DataSource = _deliveryManager.GetAvailableProductsproperties();
            dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick); 
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
        private void dataGridView2_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            int row = e.RowIndex;
            
          //  MessageBox.Show(row.ToString());
            List<TestDeliveryClass> lll =  _deliveryManager.GetAvailableProductsproperties();
            TestDeliveryClass ob1 = lll.ElementAt(row);
            SaleTestClass ob = new SaleTestClass();

            ob.ProductName = ob1.ProductName; 
            decimal total  = ob1.DeliveryPrice * ((percentProfit / 100) + 1);
            ob.DeliveryPrice = ob1.DeliveryPrice;
            ob.SalePrice = total;

            refreshSaleList();
           
            this.propertyGrid1.SelectedObject = ob;
            saleList.Add(ob);
        }


        //private void CreateTable()
        //{

        //    textColumnNumberOfRow = Utillity.createDatagridViewTextBoxColumn("#", "rowNum", "colRows", 10, true);
        //    textColumnPieces = Utillity.createDatagridViewTextBoxColumn("pieces", "pieces", "colPieces", 10, false);
        //    textColumnPrice = Utillity.createDatagridViewTextBoxColumn("Price", "rowNum", "colPrice", 10, false);
        //    textColumnVAT = Utillity.createDatagridViewTextBoxColumn("VAT", "vatColumn", "colVAT", 30, false);
        //    comboWithArticles = Utillity.createDataGridViewComboboxColumn("TYPE", 40);
        //    dataGridView1.Columns.AddRange(textColumnNumberOfRow, comboWithArticles, textColumnPieces, textColumnPrice, textColumnVAT);

        //}

        private void loadComboBoxes()
        {
            personCombo = new ComboBox();
            personCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            personCombo.Location = hide;
            this.splitContainer2.Panel2.Controls.Add(personCombo);

            companyCombo = new ComboBox();
            companyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            companyCombo.Location = hide;
            this.splitContainer2.Panel2.Controls.Add (companyCombo);
        }

        public  void RefreshLists()
        {
            personCombo.DataSource = _personManager;//.List;
            personCombo.DisplayMember = "Name";

            companyCombo.DataSource = _companyManager;//.List;
            companyCombo.DisplayMember = "Name";
        }
        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            TypeOfPartner type = (TypeOfPartner)comboBox1.SelectedItem;
           
            switch (type)
            {
                case TypeOfPartner.Person:
                    RefreshLists();
                    //comboBox1.ValueMember = "Name";
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
            this.Update();
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void button1_Click( object sender, EventArgs e )
        {
            //var val = dataGridView1.Rows.Count;// [0].Cells [3].Value.ToString();

            //textBox1.Text = val.ToString();
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

        private void dataGridView1_CellEndEdit( object sender, DataGridViewCellEventArgs e )
        { 
            int row = e.RowIndex;
            if (row >= 0)
            { 
                // int ID = (int)dataGridView1.Rows [row].Cells ["iDDataGridViewTextBoxColumn"].Value; ;
                if (e.ColumnIndex == _quantity.Index)//columnPieces.Index)
                {
                    //  DataGridViewRow done = dataGridView1.Rows [row];
                    calculate();
                   
                } 
            }
        }

       

        private void refreshSaleList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = saleList;
        }
 

        private void maskedTextBox1_KeyEnterPress( object sender, KeyEventArgs e )
        {
            e.Handled = e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
            {

                // this.Parent.GetNextControl(this, true).Select();



                decimal.TryParse(maskedTextBox1.Text, out percentProfit);
                saleList.ToList().ForEach(element =>
                {
                    element.SalePrice = element.DeliveryPrice * ((percentProfit / 100) + 1);
                });
                // this.Focus();
                refreshSaleList();
                calculate();

            }

        }
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
            textBox3.Text = /*String.Format(CultureInfo.CurrentCulture, "{0:C0}", Math.Round(total, 2));//*/Math.Round(total, 2).ToString();
        }
        //private void maskedTextBox1_MouseUp( object sender, MouseEventArgs e )
        //{

        //    decimal.TryParse(maskedTextBox1.Text, out percentProfit);
        //    saleList.ToList().ForEach(element => {
        //        element.SalePrice = element.DeliveryPrice * ((percentProfit / 100) + 1);
        //    });
        //    // this.Focus();
        //    refreshSaleList();
        //}
    }
}

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
using Observer;
using WarehouseToAquaticOrganisms.Observer;
using System.Text.RegularExpressions;

namespace WarehouseToAquaticOrganisms
{
    public partial class MakeDeliveryControl : UserControl
    {
        private CompanyManager _manager;
        private Warehouse _warehouse;
        private DeliveryManager _deliveryManager;
        private Company company;
        private BindingList<Delivery> listWithDeliveries;

        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn providerColumn;
        private DataGridViewTextBoxColumn productColumn;
        private DataGridViewTextBoxColumn quantityCol;
        private DataGridViewTextBoxColumn priceColumn;
        private DataGridViewTextBoxColumn timeColumn;
         
        ErrorProvider errorProvider1;
       

        public MakeDeliveryControl(CompanyManager manager, Warehouse warehouse, DeliveryManager deliveryManager)
        {
            InitializeComponent();
            this._manager = manager;
            this._warehouse = warehouse;
            this._deliveryManager = deliveryManager;
            comboBoxChooseProvider.DataSource = _manager ;
            comboBoxChooseProvider.DisplayMember = "Name";
            // List with products..
           // productNameColumn.DataSource = _deliveryManager.ListWithProducts;
          //  productNameColumn.DisplayMember = "Name";

            listWithDeliveries = new BindingList<Delivery>();


            dataGridView1.Visible = false;

            dataGridView1.DataSource = listWithDeliveries;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(Utillity.createDataGridViewComboboxColumn("Product", _deliveryManager.ListWithProducts, "Product", "Name", "Id"));
            dataGridView1.Columns.Add(Utillity.createDatagridViewTextBoxColumn("Quantity", "Quantity", "Quantity", false));
            dataGridView1.Columns.Add(Utillity.createDatagridViewTextBoxColumn("Price", "Price", "Price", false));
            dataGridView1.AllowUserToAddRows = true;
            panel1.BackColor = Color.Gainsboro;

              errorProvider1 = new ErrorProvider();
            
            this.dataGridView2.DataSource = _deliveryManager.DeliveryList;



            /////////////////////////////////////////////////////////////////////////////////
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Clear();
            timeColumn = Utillity.createDatagridViewTextBoxColumn("Time", "columnDateTime", "DateTime", true);
            idColumn = Utillity.createDatagridViewTextBoxColumn("ID", "columnID", "ID", true);
            providerColumn = Utillity.createDatagridViewTextBoxColumn("Provider", "columnProvider", "ProviderName", true);
            productColumn = Utillity.createDatagridViewTextBoxColumn("Product", "columnProduct", "ProductName", true);
            quantityCol = Utillity.createDatagridViewTextBoxColumn("Quantity", "columnQuantity", "Quantity", true);
            priceColumn = Utillity.createDatagridViewTextBoxColumn("DeliveryPrice", "columnDeliveryPrice", "Price", true);

            dataGridView2.Columns.AddRange(timeColumn, idColumn, providerColumn, productColumn, quantityCol, priceColumn);


            
        }


        private void comboBoxProviders_SelectedIndexChanged( object sender, EventArgs e )
        {
            dataGridView1.Visible = true;

            int index = comboBoxChooseProvider.SelectedIndex;
            company = _manager.ElementAt(index);
          //  MessageBox.Show(_manager.ElementAt(index).Name);//.ind.FirstOrDefault(element=>element.Id == index)).Name);
           

            panel1.Enabled = true;
            panel1.BackColor = Color.White;
        }
        public void reloadList() {
            comboBoxChooseProvider.DataSource = null;
            comboBoxChooseProvider.DataSource = _manager ;
        }

        

        private void panel1_Paint( object sender, PaintEventArgs e )
        {
            //if (dataGridView1.Visible == false)
            //{
            //    //System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            //    //ToolTip1.SetToolTip(this.dataGridView1, "Choose provider");
            // //   MessageBox.Show("Choose provider.");
            //}
        }

        private void button1_Click( object sender, EventArgs e )
        {

            Delivery row = new Delivery();
            // row.Provider = company.Name;
            row.DateTime = System.DateTime.Now;

            row.ProviderID = company.ID;
            row.ProductID = 3;
            row.Quantity = 555;
            row.Price = 0.25m;
            Delivery row2 = new Delivery();
            //  row2.Provider = company.Name;
            row2.DateTime = System.DateTime.Now;
            row2.ProviderID = company.ID;
            row2.ProductID = 2;
            row2.Quantity = 666;
            row2.Price = 0.25m;


            listWithDeliveries.Add(row);
            listWithDeliveries.Add(row2);
            _warehouse.MakeDelivery(listWithDeliveries.ToList());

          

        }

        // end edit rows on datagrid
        private void dataGridView1_CellEndEdit( object sender, DataGridViewCellEventArgs e )
        { 
            //int row = e.RowIndex;
            //int col = e.ColumnIndex;
            //if (row > -1 && col != productNameColumn.Index)
            //{
            //    //DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridView1.Rows [row].Cells [col];

            //    //// int row = e.RowIndex;
            //    //if (e.ColumnIndex == quantityColumn.Index)
            //    //{
            //    //    //  DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridView1.Rows [row].Cells [deliveryPriceColumn.Index];
            //    //    int value;
            //    //    bool isInt = int.TryParse(cell.Value.ToString(), out value);
            //    //    if (!isInt)
            //    //    {
            //    //        this.dataGridView1.Rows [row].Cells [quantityColumn.Index].ErrorText = "Integers only";

            //    //    }
            //    //    else
            //    //    {
            //    //        this.dataGridView1.Rows [row].Cells [quantityColumn.Index].ErrorText = "";

            //    //    }
            //    //}
            //    //if (e.ColumnIndex == deliveryPriceColumn.Index)
            //    //{
            //    //    decimal value;
            //    //    bool isDecimal = decimal.TryParse(cell.Value.ToString(), out value);
            //    //    if (!isDecimal || cell.Value==null)
            //    //    {
            //    //        this.dataGridView1.Rows [row].Cells [deliveryPriceColumn.Index].ErrorText = "Decimals only";

            //    //    }
            //    //    else
            //    //    {
            //    //        this.dataGridView1.Rows [row].Cells [deliveryPriceColumn.Index].ErrorText = "";

            //    //    }
            //    //}
            //    ////////////////////////////////////////////

            //    //string value = cell.Value.ToString();
            //    //int num;
            //    //bool isNum =  int.TryParse(value, out num);
            //    //if (!isNum)
            //    //{
            //    //    cell.Value = ":-)";
            //    //  //  dataGridView1.Rows.RemoveAt(row); 
            //    //}
            //    //else {                        

            //    //} 
            //    //   }
            //    //if (e.ColumnIndex == deliveryPriceColumn.Index)
            //    //{
            //    //   // DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridView1.Rows [row].Cells [quantityColumn.Index];

            //    //    string value = cell.Value.ToString();
            //    //    if (!decNumber.IsMatch(value))
            //    //    {
            //    //        cell.Value = ":-)";
            //    //      //  dataGridView1.Rows.RemoveAt(row);
            //    //    }
            //    //    else
            //    //    {

            //    //    }
            //    //}

            //    //// int ID = (int)dataGridView1.Rows [row].Cells ["iDDataGridViewTextBoxColumn"].Value; ;
            //    //if (e.ColumnIndex == productNameColumn.Index)
            //    //{
                  
            //    //    DataGridViewComboBoxCell combo = (DataGridViewComboBoxCell)dataGridView1.Rows [row].Cells [productNameColumn.Index];
            //    //    if (!combo.Selected)
            //    //    {
            //    //     //   MessageBox.Show("it wasnt selected.."); 
            //    //        this.dataGridView1.Rows [row].Cells [col].ErrorText = "Select Product";
            //    //    }
            //    // //   Product product = _deliveryManager.ListWithProducts.ElementAt(e.RowIndex);
            //    //    //cell.Selected
            //    //    //  MessageBox.Show(product.Name);


                  
            //    //}
            //}
             
            //col = 0;
            //row = 0;
            //markNullCells();
            //textBox1.Text = isErrorTextInTable().ToString();
            
        }

        private void markNullCells()
        {
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value==null)
                    {
                         
                    }
                }
              
            }
        }

        private bool isErrorTextInTable()
        {
            bool hasErrorText = false;
            //replace this.dataGridView1 with the name of your datagridview control
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ErrorText.Length > 0)
                    {
                        hasErrorText = true;
                        break;
                    }
                }
                if (hasErrorText)
                    break;
            }

            return hasErrorText;

        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void dataGridView1_CellValueChanged( object sender, DataGridViewCellEventArgs e )
        {
           // if (e.RowIndex>-1)
           // {

           // //My combobox column is the second one so I hard coded a 1, flavor to taste
           //DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows [e.RowIndex].Cells [0];
           //     if (cb.Value == null)
           //     {
           //         // do stuff

           //         MessageBox.Show("it wasnt selected..");
           //         this.dataGridView1.Rows [e.RowIndex].Cells [0].ErrorText = "Select Product";
           //         // int index = 0;

           //         //  Product product = _deliveryManager.ListWithProducts.ElementAt(index);

           //         // MessageBox.Show("QQQQ");

           //         dataGridView1.Invalidate();
           //     }
           //     else {
           //         this.dataGridView1.Rows [e.RowIndex].Cells [0].ErrorText = "";
           //     }

           // }
        }

        private void dataGridView1_EditingControlShowing( object sender, DataGridViewEditingControlShowingEventArgs e )
        {
          //  Delivery row = new Delivery();
          // // row.Provider = company.Name;
          //  row.DateTime = System.DateTime.Now;
           
          //  row.ProviderID = company.ID;
          //  row.ProductID = 3;
          //  row.Quantity = 333;
          //  Delivery row2 = new Delivery();
          ////  row2.Provider = company.Name;
          //  row2.DateTime = System.DateTime.Now;
          //  row2.ProviderID = company.ID;
          //  row2.ProductID = 2;
          //  row2.Quantity = 444;


          //  listWithDeliveries.Add(row );
          //  listWithDeliveries.Add(row2);
          //  _warehouse.MakeDelivery(listWithDeliveries);
            
            //ComboBox combo = e.Control as ComboBox;
            //if (combo != null)
            //{
            //    // Remove an existing event-handler, if present, to avoid 
            //    // adding multiple handlers when the editing control is reused.
            //    combo.SelectedIndexChanged -=
            //        new EventHandler(ComboBox_SelectedIndexChanged);

            //    // Add the event handler. 
            //    combo.SelectedIndexChanged +=
            //        new EventHandler(ComboBox_SelectedIndexChanged);
            //}

        }
        private void ComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            MessageBox.Show(((ComboBox) sender).SelectedIndex.ToString());
        }
        private void ShowDeliveryControl_Load( object sender, EventArgs e )
        {
            Refresh();
        }
        public override void Refresh()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _deliveryManager.DeliveryList;
        }
 
    }
}

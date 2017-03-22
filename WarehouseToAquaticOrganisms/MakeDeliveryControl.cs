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
using Observer;
using WarehouseToAquaticOrganisms.Observer;

namespace WarehouseToAquaticOrganisms
{
    public partial class MakeDeliveryControl : UserControl
    {
        private CompanyManager _manager;
        private Warehouse _warehouse;
        private DeliveryManager _deliveryManager;
        private Company company;
        public MakeDeliveryControl(CompanyManager manager, Warehouse warehouse, DeliveryManager deliveryManager)
        {
            InitializeComponent();
            this._manager = manager;
            this._warehouse = warehouse;
            this._deliveryManager = deliveryManager;
            comboBoxChooseProvider.DataSource = _manager ;
            comboBoxChooseProvider.DisplayMember = "Name";
            // List with products..
            productNameColumn.DataSource = _deliveryManager.ListWithProducts;
            productNameColumn.DisplayMember = "Name";

            dataGridView1.Visible = false;
            panel1.BackColor = Color.Gainsboro;
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
            row.Provider = company.Name;
            row.DateTime = System.DateTime.Now;
            row.Provider = "";
            row.Product = "";
            row.Quantity = 0;
        
                _warehouse.MakeDelivery(row);
           
        }

        // end edit rows on datagrid
        private void dataGridView1_CellEndEdit( object sender, DataGridViewCellEventArgs e )
        {
            //int row = e.RowIndex;
            //if (row >= 0)
            //{
               
            //    // int ID = (int)dataGridView1.Rows [row].Cells ["iDDataGridViewTextBoxColumn"].Value; ;
            //    if (e.ColumnIndex == productNameColumn.Index)
            //    {
            //        //  DataGridViewRow done = dataGridView1.Rows [row];
            //      //  DataGridViewCell cell =             // ComboBox obj = (ComboBox)done.Cells [1].;
            //       int index  =0;
            //        DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1.Rows [row].Cells [productNameColumn.Index];
                    
            //        Product product =  _deliveryManager.ListWithProducts.ElementAt(index);
            //     //   cell.Selected
            //     //   MessageBox.Show(product.Name);


            //        //done.Cells [0].Value = row + 1;

            //        //done.Cells [3].Value = 2.58m;
            //        //decimal pieces;
            //        //decimal.TryParse(done.Cells [2].Value.ToString(), out pieces);

            //        //decimal price;
            //        //decimal.TryParse(done.Cells [3].Value.ToString(), out price);

            //        //decimal temp = pieces * price;
            //        //suma += temp;
            //        //done.Cells [4].Value = temp;

            //        //total = suma * 1.2m;
            //        //Math.Round(total, 2);
            //        //textBox1.Text = suma.ToString();
            //        //decimal vat = Math.Round((total - suma), 2);
            //        //textBox2.Text = (vat).ToString();
            //        //textBox3.Text = /*String.Format(CultureInfo.CurrentCulture, "{0:C0}", Math.Round(total, 2));//*/Math.Round(total, 2).ToString();




            //        //temp = 0;
            //    }
            //}
        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void dataGridView1_CellValueChanged( object sender, DataGridViewCellEventArgs e )
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            //DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows [e.RowIndex].Cells [productNameColumn.Index];
            //if (cb.Value != null)
            //{
            //    // do stuff

                
            //    int index =  0;

            //    Product product = _deliveryManager.ListWithProducts.ElementAt(index);

            //    MessageBox.Show(product.Name);

            //    dataGridView1.Invalidate();
            //}
        }

        private void dataGridView1_EditingControlShowing( object sender, DataGridViewEditingControlShowingEventArgs e )
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                // Remove an existing event-handler, if present, to avoid 
                // adding multiple handlers when the editing control is reused.
                combo.SelectedIndexChanged -=
                    new EventHandler(ComboBox_SelectedIndexChanged);

                // Add the event handler. 
                combo.SelectedIndexChanged +=
                    new EventHandler(ComboBox_SelectedIndexChanged);
            }

        }
        private void ComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            MessageBox.Show(((ComboBox) sender).SelectedIndex.ToString());
        }
    }
}

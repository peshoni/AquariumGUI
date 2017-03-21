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

namespace WarehouseToAquaticOrganisms
{
    public partial class MakeDeliveryControl : UserControl
    {
        private CompanyManager _manager;
        private Warehouse _warehouse;
        public MakeDeliveryControl(CompanyManager manager, Warehouse warehouse)
        {
            InitializeComponent();
            this._manager = manager;
            this._warehouse = warehouse;

            //Company com = new Company();
            //com.Name = "--Please Select provider--";
            //comboBox2.Items.Insert(0, com);
            //comboBox2.DataBindings.Add(com);
            comboBox2.DataSource = _manager ;
           
            comboBox2.DisplayMember = "Name";
            dataGridView1.Visible = false;
            panel1.BackColor = Color.Gainsboro;
        }


        private void comboBox2_SelectedIndexChanged( object sender, EventArgs e )
        {
            dataGridView1.Visible = true;
            panel1.BackColor = Color.White;
        }
        public void reloadList() {
            comboBox2.DataSource = null;
            comboBox2.DataSource = _manager ;
        }

        

        private void panel1_Paint( object sender, PaintEventArgs e )
        {
            if (dataGridView1.Visible == false)
            {
                //System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                //ToolTip1.SetToolTip(this.dataGridView1, "Choose provider");
             //   MessageBox.Show("Choose provider.");
            }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            
                DeliveryRow row = new DeliveryRow();
               
                row.Price = 0.25m;
                row.Product = "Vafli";
                row.Provider = "Pesho";
                row.Quantity = 100;
                _warehouse.MakeDelivery(row);
           
        }
    }
}

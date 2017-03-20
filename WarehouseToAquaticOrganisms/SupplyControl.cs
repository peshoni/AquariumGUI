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

namespace WarehouseToAquaticOrganisms
{
    public partial class SupplyControl : UserControl
    {
        private CompanyManager _manager;
        public SupplyControl(CompanyManager manager)
        {
            InitializeComponent();
            this._manager = manager;
            comboBox2.DataSource = _manager.List;
            comboBox2.DisplayMember = "Name";
 
        }


        private void comboBox2_SelectedIndexChanged( object sender, EventArgs e )
        {
           

        }
        public void reloadList() {
            comboBox2.DataSource = null;
            comboBox2.DataSource = _manager.List;
        }
 
    }
}

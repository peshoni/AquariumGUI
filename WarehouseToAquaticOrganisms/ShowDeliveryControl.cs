using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Observer;

namespace WarehouseToAquaticOrganisms
{
    public partial class ShowDeliveryControl : UserControl
    {
        private DeliveryManager _suplyManager;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn providerColumn;
        private DataGridViewTextBoxColumn productColumn;
        private DataGridViewTextBoxColumn quantitryColumn;
        private DataGridViewTextBoxColumn deliveryPriceColumn; 
        public ShowDeliveryControl(DeliveryManager suplyManager)
        {
            InitializeComponent();
            this._suplyManager = suplyManager;
            this.dataGridViewForDeliveries.DataSource = _suplyManager.DeliveryList;
            dataGridViewForDeliveries.AutoGenerateColumns = false;
            dataGridViewForDeliveries.Columns.Clear();

            idColumn = Utillity.createDatagridViewTextBoxColumn("ID", "columnID", "ID", true);
            providerColumn = Utillity.createDatagridViewTextBoxColumn("Provider", "columnProvider", "Provider", true);
            productColumn = Utillity.createDatagridViewTextBoxColumn("Product", "columnProduct", "Product", true);
            quantitryColumn = Utillity.createDatagridViewTextBoxColumn("Quantity", "columnQuantity", "Quantity", true);
            deliveryPriceColumn = Utillity.createDatagridViewTextBoxColumn("DeliveryPrice", "columnDeliveryPrice", "Price", true);

            dataGridViewForDeliveries.Columns.AddRange(idColumn, providerColumn, productColumn, quantitryColumn, deliveryPriceColumn);
        }

       

        private void ShowDeliveryControl_Load( object sender, EventArgs e )
        {
            Refresh();
        }
        public override void Refresh()
        {
            dataGridViewForDeliveries.DataSource = null;
            dataGridViewForDeliveries.DataSource = _suplyManager.DeliveryList;
        }
    }
}

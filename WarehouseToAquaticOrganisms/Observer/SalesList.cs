using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class SalesList : Observer
    {
        private Hashtable _table;
        private int ID;

        public Hashtable Table
        {
            get
            {
                return _table;
            } 
        }

        public SalesList( Warehouse warehouse )
        {
            this._table = new Hashtable(); 
            this._warehouse = warehouse;
            this._warehouse.attachObserver(this);
        }
 

        public override void update()
        {
            sellProduct(_warehouse.Sale);
        }
/// <summary>
/// Registering sold in the table.
/// </summary>
/// <param name="sale"></param>
        private void sellProduct(Sale sale)
        {
            if (sale != null && _warehouse.IsSold)
            {
                Table.Add(++ID, sale);
            }
        }
    }
}

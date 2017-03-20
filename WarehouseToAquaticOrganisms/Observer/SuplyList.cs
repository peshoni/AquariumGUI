using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class SupplyList : Observer
    { 
        private Hashtable _table;
        private int ID; 

        public SupplyList( Warehouse warehouse )
        { 
            this._table = new Hashtable();
            this._warehouse = warehouse;
            this._warehouse.attachObserver(this); 
        }
  

        public Hashtable Table
        {
            get
            {
                return _table;
            } 
        } 

        /// <summary>
        /// Adds product into suplylist.
        /// </summary> 
        public override void update()
        {
            addProduct(_warehouse.Delivery);
        }

        private void addProduct( Delivery delivery)
        {
            if (delivery!=null) {
                Table.Add(++ID, delivery);
            } 
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Available : Observer
    {
        private Hashtable _table; 

        public Hashtable Table
        {
            get
            {
                return _table;
            }
        }
        /// <summary>
        /// Constructor with parameter Warehouse
        /// </summary>
        /// <param name="warehouse"></param>
        public Available(Warehouse warehouse) { 
            this._table = new Hashtable ();
            this._warehouse = warehouse;
            this._warehouse.attachObserver(this);      
        }
 

        public override void update()
        {
            if (_warehouse.IsSold) {
                sellProduct(_warehouse.Sale);
            }
            if (_warehouse.IsDelivery) {
                addProduct(_warehouse.Delivery);
            }
        }
        /// <summary>
        /// Sells products from warehouse.
        /// </summary>
        /// <param name="delivery"></param>
        private void sellProduct( Sale sale )
        {
          string key = sale.ProductName; 
          if (Table.ContainsKey(key)){
                if (((Product)Table [key]).Quantity<sale.Quantity)
                {
                    ((Product)Table [key]).Quantity -= sale.Quantity;
                    throw new Exception("");
                }  
           } 
        }
       /// <summary>
       /// Adds products in warehouse.
       /// </summary>
       /// <param name="delivery"></param>
        private void addProduct( Delivery delivery )
        {  
            string key = delivery.ProductName;
            if (!Table.ContainsKey(key)){
                 Table.Add(delivery.ProductName, new Product(delivery.ProductName, delivery.Quantity));
            }else {
                 ((Product)Table [key]).Quantity += delivery.Quantity;
            }
        }  
    }
}
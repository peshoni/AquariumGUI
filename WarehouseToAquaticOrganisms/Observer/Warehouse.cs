using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Warehouse
    {    
        private List<Observer> _observers = new List<Observer>(); 
        private Delivery _delivery;  
        private Sale _sale;
        private bool _isDelivery;
        private bool _isSold;

        #region Getters and Setters 
        public Delivery Delivery
        {
            get
            {
                return _delivery;
            }

            set
            {
                _delivery = value;
            }
        }

        public List<Observer> Observers
        {
            get
            {
                return _observers;
            } 
        }

        public Sale Sale
        {
            get
            {
                return _sale;
            }

            set
            {
                _sale = value;
            }
        }

        public bool IsDelivery
        {
            get
            {
                return _isDelivery;
            }

            set
            {
                _isDelivery = value;
            }
        }

        public bool IsSold
        {
            get
            {
                return _isSold;
            }

            set
            {
                _isSold = value;
            }
        }


        #endregion

        /// <summary>
        /// Called by observers to add to the list with observers.
        /// </summary>
        /// <param name="observer">To be added.</param>
        public void attachObserver( Observer observer ) {
                  Observers.Add(observer);
        }


        public void MakeDelivery( Delivery delivеry ) {
                 this.Delivery = delivеry;
                 _isDelivery = true;                      
                 notifyAll(); 
        }

        public void MakeASale( Sale sale) {
            /// Gates available quantity..
            Observer list =   _observers.Find(element => element.GetType().Equals(typeof(Available)));
            Available table = (Available)list;
            int q = ((Product)table.Table[sale.ProductName]).Quantity;
            if (q > sale.Quantity)
            {
                this.Sale = sale;
                _isSold = true;
                notifyAll();
            }
            else {
                Console.WriteLine(" Your request for " + sale.Quantity + " units of '"+sale.ProductName+"' can not be executed!");
                Console.WriteLine(" Available from stock '"+ sale.ProductName+"' are: "+ q);
            } 
        }
       

        /// <summary>
        /// Notify all observers to call 'update()' method. Retuns tha basic state of bool's.
        /// </summary>
        private void notifyAll() {
            Observers.ForEach(element=> {
                element.update();
            });
            _isDelivery = false;
            _isSold = false;
        }
    }
}

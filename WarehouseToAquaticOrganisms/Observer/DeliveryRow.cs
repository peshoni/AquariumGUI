using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class DeliveryRow 
    {
        private int _id;
        private string _providerName;
        private string _productName;
        private int _quantity;
        private decimal _price;
        public DeliveryRow() { }
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Provider
        {
            get
            {
                return _providerName;
            }

            set
            {
                _providerName = value;
            }
        }

        public string Product
        {
            get
            {
                return _productName;
            }

            set
            {
                _productName = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public DeliveryRow( int _id, string _providerName, string _productName, int _quantity, decimal _price )
        {
            this.Id = _id;
            this.Provider = _providerName;
            this.Product = _productName;
            this.Quantity = _quantity;
            this.Price = _price;
        }
    }
}
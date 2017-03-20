using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Delivery 
    {
        private string _providerName;
        private string _productName;
        private int _quantity;
        #region Getters and setters
        public string ProviderName
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

        public string ProductName
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
        #endregion
        public Delivery(string providerName, string productName, int quantity )
        {
            this._providerName = providerName;
            this._productName = productName;
            this._quantity = quantity;
        } 
    }
}
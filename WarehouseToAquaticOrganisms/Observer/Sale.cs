using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Sale 
    {
        private string _buyer;
        private string _productName;
        private int _quantity;

        #region Getters and setters
        public string Buyer
        {
            get
            {
                return _buyer;
            }

            set
            {
                _buyer = value;
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

        /// <summary>
        /// Constructor with two parameters.
        /// </summary>
        /// <param name="Buyer">The Buyer of goods </param>
        /// <param name="aProduct">Product subject to purchas.</param>
        public Sale(string buyerName, string productName, int quantity ) {
            this._buyer = buyerName;
            this._productName = productName;
            this._quantity = quantity; 
        } 
    }
}
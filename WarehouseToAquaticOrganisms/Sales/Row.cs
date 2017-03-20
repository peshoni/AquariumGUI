using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseToAquaticOrganisms.Sales
{
   public class Row
    {
        private DateTime date; 
        private int _salesNumber;
        private string _buyer;
        private string _productName;
        private int _quantiry;
        private float _price;

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public int SalesNumber
        {
            get
            {
                return _salesNumber;
            }

            set
            {
                _salesNumber = value;
            }
        }

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

        public int Quantiry
        {
            get
            {
                return _quantiry;
            }

            set
            {
                _quantiry = value;
            }
        }

        public float Price
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

        public Row( DateTime date, int _salesNumber, string _buyer, string _productName, int _quantiry, float _price )
        {
            this.Date = date;
            this.SalesNumber = _salesNumber;
            this.Buyer = _buyer;
            this.ProductName = _productName;
            this.Quantiry = _quantiry;
            this.Price = _price;
        }
    }
}

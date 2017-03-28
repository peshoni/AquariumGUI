using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseToAquaticOrganisms.DBClasses
{
   public class SaleTestClass
    {
        private int _companyId;
        private int _personId;
        private string _place;
        private bool _isPaid;
        private int _productId;
        private string _productName;
        private int _quantity;
        private decimal _salePrice;
        private decimal _deliveryPrice;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SaleTestClass() { }
        #region get and set
        public int CompanyId
        {
            get
            {
                return _companyId;
            }

            set
            {
                _companyId = value;
            }
        }

        public int PersonId
        {
            get
            {
                return _personId;
            }

            set
            {
                _personId = value;
            }
        }

        public string Place
        {
            get
            {
                return _place;
            }

            set
            {
                _place = value;
            }
        }

        public bool IsPaid
        {
            get
            {
                return _isPaid;
            }

            set
            {
                _isPaid = value;
            }
        }

        public int ProductId
        {
            get
            {
                return _productId;
            }

            set
            {
                _productId = value;
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

        public decimal SalePrice
        {
            get
            {
                return _salePrice;
            }

            set
            {
                _salePrice = value;
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

        public decimal DeliveryPrice
        {
            get
            {
                return _deliveryPrice;
            }

            set
            {
                _deliveryPrice = value;
            }
        }
        #endregion
    }
}

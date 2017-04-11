using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseToAquaticOrganisms.DBClasses
{
   public class Sale : IDataErrorInfo
    {
        private int docID;
        private string _place;
        private bool _isPaid;
        private int _productId;
        private string _productName;
        private int _quantity;
        private decimal _salePrice;
        private decimal _deliveryPrice;
        // private bool _isDelivery;
        private decimal rowSum;
        private decimal percentOfRow;


        private string _personName;
        private long _egn;

        private string _companyName;
        private string _companyBulstat;
        private int _companyId;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Sale() { }
        #region get and set
       

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

        public bool IsDelivery
        {
            get
            {
                return false;
            } 
        }

        public int DocID
        {
            get
            {
                return docID;
            }

            set
            {
                docID = value;
            }
        }

        public string PersonName
        {
            get
            {
                return _personName;
            }

            set
            {
                _personName = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return _companyName;
            }

            set
            {
                _companyName = value;
            }
        }

        public string CompanyBulstat
        {
            get
            {
                return _companyBulstat;
            }

            set
            {
                _companyBulstat = value;
            }
        }

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

        public long Egn
        {
            get
            {
                return _egn;
            }

            set
            {
                _egn = value;
            }
        }

        public string Error
        {
            get
            {
                return string.Empty;
            }
        }

        public decimal PercentOfRow
        {
            get
            {
                return percentOfRow;
            }

            set
            {
                percentOfRow = value;
            }
        }

        public decimal RowSum
        {
            get
            {
                return rowSum;
            }

            set
            {
                rowSum = value;
            }
        }

        public string this [string columnName]
        {
            get
            {
                if ("Quantity" == columnName && Quantity == 0)
                    return "Please fill Quantity";
                return string.Empty;
            }
        }
        #endregion
    }
}
